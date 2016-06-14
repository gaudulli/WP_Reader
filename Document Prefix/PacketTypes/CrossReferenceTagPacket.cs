using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WP_Reader
{
    public class CrossReferenceTagPacket: PacketData
    {

        public string targetname{get; set;}

      public CrossReferenceTagPacket(WP6Document document, int prefixID):
            base(document, prefixID)
        {
            if (prefixID > -1)
            {
                targetname = getWPWordString();
            }
        }
    }
}
