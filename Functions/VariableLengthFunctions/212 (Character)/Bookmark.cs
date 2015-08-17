using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WP_Reader
{
    public class Bookmark : CharacterGroupFunction
    {
        public BookmarkDataPacket info { get; set; }

        public Bookmark(WP6Document doc, int index)
            : base(doc, index)
        {
            info = new BookmarkDataPacket(doc, prefixIds[0]-1);

        }
    }
}
