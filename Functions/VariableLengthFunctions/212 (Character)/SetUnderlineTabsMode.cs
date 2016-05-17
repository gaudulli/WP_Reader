using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WP_Reader
{
    public class SetUnderlineTabsMode:CharacterGroupFunction
    {

       public bool underlineTabs { get; set; }

       public SetUnderlineTabsMode(WP6Document doc, int index)
            : base(doc, index)
        {
            underlineTabs = nonDeletableInfo[0] > 0;
        }
    }
}
