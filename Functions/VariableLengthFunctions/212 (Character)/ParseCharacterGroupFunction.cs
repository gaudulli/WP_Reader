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

                    default:
                        return new CharacterGroupFunction(doc, index);
                }
            }

            return new CharacterGroupFunction(doc, index); ;
        }
    }
}
