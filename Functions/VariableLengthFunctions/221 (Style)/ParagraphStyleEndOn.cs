using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WP_Reader
{
    public class ParagraphStyleEndOn:StyleGroupFunction
    {
        public NormalStylePacket info { get; set; }
        public int hash { get; set; }

        public ParagraphStyleEndOn()
        {

        }

        public ParagraphStyleEndOn(WP6Document doc, int index)
            : base(doc, index)
        {
            info = new NormalStylePacket(doc, prefixIds[0] - 1);
            hash = BitConverter.ToInt16(nonDeletableInfo, 0);
        }
    }
}
