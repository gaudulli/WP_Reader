using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WP_Reader
{
    public class DelayedCodes: PageGroupFunction
    {

        public short numPages { get; set; }

        public GeneralWPText_Packet codes;


        public DelayedCodes()
        {

        }
        public DelayedCodes(WP6Document doc, int index)
            : base(doc, index)
        {
            numPages = BitConverter.ToInt16(nonDeletableInfo, 2);
            codes = new GeneralWPText_Packet(doc, prefixIds[0] - 1);
        }
    }
}
