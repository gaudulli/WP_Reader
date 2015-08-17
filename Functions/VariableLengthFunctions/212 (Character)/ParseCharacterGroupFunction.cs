using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WP_Reader
{
    public static class ParseCharacterGroupFunction
    {
        public static CharacterGroupFunction getFunction(WP6Document doc, int index)
        {
            WP6_FunctionKey key = new WP6_FunctionKey(doc.data[index], doc.data[index+1]);
            if (WP6_FunctionNames.map.ContainsKey(key))
            {
                CharacterGroup name = (CharacterGroup)WP6_FunctionNames.map[key];
                switch (name)
                {
                    case CharacterGroup.set_alignment_character:        // 0x D4 00  (212 00)
                        return new SetAlignmentCharacter(doc, index);
                    case CharacterGroup.bookmark:
                        return new Bookmark(doc, index);                // 0x D4 25 (212 37)
                    case CharacterGroup.hypertext_begin_on:
                        return new HypertextBeginOn(doc, index);        // 0x D4 34 (212 52)
                    case CharacterGroup.hypertext_begin_off:
                        return new HypertextBeginOff(doc, index);       // 0x D4 35 (212 53)
                    case CharacterGroup.hypertext_end_on:
                        return new HypertextEndOn(doc, index);          // 0x D4 36 (212 54)
                    case CharacterGroup.hypertext_end_off:
                        return new HypertextEndOff(doc, index);         // 0x D4 37 (212 55)


                    default:
                        return new CharacterGroupFunction(doc, index);
                }
            }

            return new CharacterGroupFunction(doc, index); ;
        }
    }
}
