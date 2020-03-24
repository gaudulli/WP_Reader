using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WP_Reader
{
    public class SetUnderlineSpacesMode: CharacterGroupFunction
    {
        public bool underlineSpaces { get; set; }

        public SetUnderlineSpacesMode()
        {

        }
       public SetUnderlineSpacesMode(WP6Document doc, int index)
            : base(doc, index)
        {
            underlineSpaces = nonDeletableInfo[0] > 0;
        }
    }
}
