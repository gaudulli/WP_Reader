using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WP_Reader
{
    public class IndexEntry: CharacterGroupFunction
    {
        public IndexMarkPacket indexMark { get; set; }
        
        public IndexEntry()
        {

        }

        public IndexEntry(WP6Document doc, int index)
            : base(doc, index)
        {
            indexMark = new IndexMarkPacket(doc, prefixIds[0] -1);
        }

    }
}
