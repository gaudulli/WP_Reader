using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WP_Reader
{
    public class ConditionalEndOfPage: CharacterGroupFunction
    {
        public int linesNotToBeBroken { get; set; }

        public ConditionalEndOfPage(WP6Document doc, int index)
            : base(doc, index)
        {
            linesNotToBeBroken = nonDeletableInfo[0];
        }
    }
}
