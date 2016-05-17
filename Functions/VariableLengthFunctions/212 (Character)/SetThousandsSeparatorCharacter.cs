using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WP_Reader
{
    public class SetThousandsSeparatorCharacter: CharacterGroupFunction
    {
        public string separator { get; set; }

        public SetThousandsSeparatorCharacter(WP6Document doc, int index)
            : base(doc, index)
        {
            separator = ((char)nonDeletableInfo[0]).ToString();
            if (nonDeletableInfo[1] > 0)
            {
                separator += ((char)nonDeletableInfo[1]).ToString();
            }
        }

    }
}
