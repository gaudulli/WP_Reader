using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



namespace WP_Reader
{
    public class ExtendedCharacter: FixedLengthFunction
    {
        public string character { get; set; }  //could be 1 or 2 unicode characters or 2 values pointing beyond the BMP
        public WP6_Character_Sets charset { get; set; }
        public int charNumber { get; set; }

        

        public ExtendedCharacter(WP6Document doc, int index, int size)
            : base(doc, index, size)
        {

            name = FixedLengthGroup.extended_character;
            charNumber = functionData[0];
            charset = (WP6_Character_Sets)Enum.Parse(typeof(WP6_Character_Sets), functionData[1].ToString());

            switch (charset)
            {
                case WP6_Character_Sets.multinational:
                    if (ExtendedCharacterSets.WP6_multinational[charNumber] != 0)
                    {
                        //chars[0] = (char)ExtendedCharacterSets.WP6_multinational[charNumber];
                        //character = new string(chars);
                        character = new string ((char)ExtendedCharacterSets.WP6_multinational[charNumber],1);
                       // Console.WriteLine("test " + character);
                    }
                    else
                    // if value in array is zero, then get the 2-character unicode equavalent
                    {
                        if (ExtendedCharacterSets.WP6_multinationalComplex.ContainsKey(charNumber))
                        {
                            char[] chars = new char[2];
                            chars[0] = (char)ExtendedCharacterSets.WP6_multinationalComplex[charNumber][0];
                            chars[1] = (char)ExtendedCharacterSets.WP6_multinationalComplex[charNumber][1];
                            character = new string(chars);
                        }
                    }
                    break;
                case WP6_Character_Sets.phonetic:
                    character = new string((char)ExtendedCharacterSets.WP6_phonetic[charNumber],1);
                    break;
                case WP6_Character_Sets.box_drawing:
                    character = new string((char)ExtendedCharacterSets.WP6_box_drawing[charNumber], 1);
                    break;
                case WP6_Character_Sets.typographic_symbols:
                    if (ExtendedCharacterSets.WP6_typographic_symbols[charNumber] <= 0xFFFF)
                    {
                        character = new string((char)ExtendedCharacterSets.WP6_typographic_symbols[charNumber], 1);
                    }
                    else
                        //handle number beyond 0xFFFF, different plane; need two values to map
                    {
                        character = char.ConvertFromUtf32(ExtendedCharacterSets.WP6_typographic_symbols[charNumber]).ToString();
                        
                    }

                    break;
                case WP6_Character_Sets.iconic_symbols:
                    character = new string((char)ExtendedCharacterSets.WP6_iconic_symbols[charNumber], 1);
                    break;
                case WP6_Character_Sets.math_scientific:
                    character = new string((char)ExtendedCharacterSets.WP6_math_scientific[charNumber], 1);
                    break;
                case WP6_Character_Sets.math_scientific_extended:
                    character = new string((char)ExtendedCharacterSets.WP6_math_scientific_extended[charNumber], 1);
                    break;
                case WP6_Character_Sets.Greek:
                    character = new string((char)ExtendedCharacterSets.WP6_Greek[charNumber], 1);
                    break;
                case WP6_Character_Sets.Hebrew:
                    character = new string((char)ExtendedCharacterSets.WP6_Hebrew[charNumber], 1);
                    break;
                case WP6_Character_Sets.Cyrillic:
                    character = new string((char)ExtendedCharacterSets.WP6_Cyrillic[charNumber], 1);
                    break;
                case WP6_Character_Sets.Japanese:
                    character = new string((char)ExtendedCharacterSets.WP6_Japanese[charNumber], 1);
                    break;
                case WP6_Character_Sets.Arabic:
                    character = new string((char)ExtendedCharacterSets.WP6_Arabic[charNumber], 1);
                    break;
                case WP6_Character_Sets.Arabic_script:
                    character = new string((char)ExtendedCharacterSets.WP6_ArabicScript[charNumber], 1);
                    break;
                default:
                    character = "";
                    break;
            }


        }

        public enum WP6_Character_Sets
        {
            multinational = 1,
            phonetic,
            box_drawing,
            typographic_symbols,
            iconic_symbols,
            math_scientific,
            math_scientific_extended,
            Greek,
            Hebrew,
            Cyrillic,
            Japanese,
            Arabic = 13,
            Arabic_script
        }




    }
}




