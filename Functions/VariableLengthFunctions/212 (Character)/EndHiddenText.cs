using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WP_Reader
{
    public class EndHiddenText  : CharacterGroupFunction
    {
        public EndHiddenText()
        {

        }
       public EndHiddenText(WP6Document doc, int index)
            : base(doc, index)
        {

        }

    }
}
