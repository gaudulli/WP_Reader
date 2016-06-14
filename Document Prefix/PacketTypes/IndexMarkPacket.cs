using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WP_Reader
{
    public class IndexMarkPacket: PacketData
    {

        public string indexName { get; set; }
        public string heading { get; set; }
        public string subheading { get; set; }

        public IndexMarkPacket(WP6Document document, int prefixID) :
            base(document, prefixID)
        {
            if (prefixID > -1)
            {
                indexName = getWPWordString();
                heading = getWPWordString();
                subheading = getWPWordString();
            }
        }

    }
}
