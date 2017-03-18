using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



namespace WP_Reader
{
    public class ExtendedCharacter: FixedLengthFunction
    {
        public string content { get; set; }  //could be 1 or 2 unicode characters or 2 values pointing beyond the BMP
        public WP6_Character_Sets charset { get; set; }
        public int charNumber { get; set; }

        

        public ExtendedCharacter(WP6Document doc, int index, int size)
            : base(doc, index, size)
        {
            parseCharacter();
        }

        public ExtendedCharacter(byte charSet, byte offset)
        {
            functionData = new byte[2];
            functionData[1] = charSet;
            functionData[0] = offset;
            codeValue = ((int)charset << 8 | (int)offset) + PUA;
            parseCharacter();
        }

        private void parseCharacter()
        {
            name = FixedLengthGroup.extended_character;
            charNumber = functionData[0];
            charset = (WP6_Character_Sets)Enum.Parse(typeof(WP6_Character_Sets), functionData[1].ToString());
            codeValue = (functionData[1] << 8 | functionData[0]) + PUA;
            switch (charset)
            {
                case WP6_Character_Sets.multinational:
                    if (ExtendedCharacterSets.WP6_multinational[charNumber] != 0)
                    {
                        content = new string((char)ExtendedCharacterSets.WP6_multinational[charNumber], 1);
                    }
                    else
                    // if value in array is zero, then get the 2-character unicode equavalent
                    {
                        if (ExtendedCharacterSets.WP6_multinationalComplex.ContainsKey(charNumber))
                        {
                            char[] chars = new char[2];
                            chars[0] = (char)ExtendedCharacterSets.WP6_multinationalComplex[charNumber][0];
                            chars[1] = (char)ExtendedCharacterSets.WP6_multinationalComplex[charNumber][1];
                            content = new string(chars);
                        }
                    }
                    break;
                case WP6_Character_Sets.phonetic:
                    content = new string((char)ExtendedCharacterSets.WP6_phonetic[charNumber], 1);
                    break;
                case WP6_Character_Sets.box_drawing:
                    content = new string((char)ExtendedCharacterSets.WP6_box_drawing[charNumber], 1);
                    break;
                case WP6_Character_Sets.typographic_symbols:
                    if (ExtendedCharacterSets.WP6_typographic_symbols[charNumber] <= 0xFFFF)
                    {
                        content = new string((char)ExtendedCharacterSets.WP6_typographic_symbols[charNumber], 1);
                    }
                    else
                    //handle number beyond 0xFFFF, different plane; need two values to map
                    {
                        content = char.ConvertFromUtf32(ExtendedCharacterSets.WP6_typographic_symbols[charNumber]).ToString();

                    }

                    break;
                case WP6_Character_Sets.iconic_symbols:
                    content = new string((char)ExtendedCharacterSets.WP6_iconic_symbols[charNumber], 1);
                    break;
                case WP6_Character_Sets.math_scientific:
                    content = new string((char)ExtendedCharacterSets.WP6_math_scientific[charNumber], 1);
                    break;
                case WP6_Character_Sets.math_scientific_extended:
                    content = new string((char)ExtendedCharacterSets.WP6_math_scientific_extended[charNumber], 1);
                    break;
                case WP6_Character_Sets.Greek:
                    content = new string((char)ExtendedCharacterSets.WP6_Greek[charNumber], 1);
                    break;
                case WP6_Character_Sets.Hebrew:
                    content = new string((char)ExtendedCharacterSets.WP6_Hebrew[charNumber], 1);
                    break;
                case WP6_Character_Sets.Cyrillic:
                    content = new string((char)ExtendedCharacterSets.WP6_Cyrillic[charNumber], 1);
                    break;
                case WP6_Character_Sets.Japanese:
                    content = new string((char)ExtendedCharacterSets.WP6_Japanese[charNumber], 1);
                    break;
                case WP6_Character_Sets.Arabic:
                    content = new string((char)ExtendedCharacterSets.WP6_Arabic[charNumber], 1);
                    break;
                case WP6_Character_Sets.Arabic_script:
                    content = new string((char)ExtendedCharacterSets.WP6_ArabicScript[charNumber], 1);
                    break;
                default:
                    content = " ";
                    break;
            }

        }





    }
}




