using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WP_Reader
{
    public class FootnoteOn: Footnote_EndnoteFunction
    {
        public GeneralWPText_Packet footnoteText { get; set; }


        public FootnoteOn(WP6Document doc, int index)
            : base(doc, index)
        {
            footnoteText = new GeneralWPText_Packet(doc, prefixIds[0] - 1);

        }

    }
}
