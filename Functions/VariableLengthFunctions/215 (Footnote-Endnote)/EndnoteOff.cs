using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WP_Reader
{
    public class EndnoteOff: Footnote_EndnoteFunction
    {
        public EndnoteOff()
        {

        }
        public EndnoteOff(WP6Document doc, int index)
            : base(doc, index)
        {

        }

    }
}
