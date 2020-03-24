using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WP_Reader
{
    public class EndNoteOn: Footnote_EndnoteFunction
    {
        public GeneralWPText_Packet endnoteText { get; set; }

        public EndNoteOn()
        {

        }
       public EndNoteOn(WP6Document doc, int index)
            : base(doc, index)
        {
            endnoteText = new GeneralWPText_Packet(doc, prefixIds[0] - 1);
        }

    }
}
