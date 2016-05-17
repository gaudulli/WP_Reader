using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WP_Reader
{
    public class CharacterShadingChange: CharacterGroupFunction
    {
        public int newShading { get; set; }

        public CharacterShadingChange(WP6Document doc, int index)
            : base(doc, index)
        {
            newShading = nonDeletableInfo[0];
        }
    }
}
