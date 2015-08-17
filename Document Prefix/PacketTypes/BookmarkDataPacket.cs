using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WP_Reader
{
    public class BookmarkDataPacket : PacketData
    {
        public string bookmarkName { get; set; }
        public BookmarkDataFlags flags { get; set; }

        public BookmarkDataPacket(WP6Document document, int prefixID):
            base(document, prefixID)
        {
            if (prefixID > 0)
            {
                index += 2; //skip past reserved 2 bytes
                flags = (BookmarkDataFlags)_data[index];
                index+=2;  // skip another reserved byte
                bookmarkName = getWPWordString();
            }
        }
    }

    [Flags]
    public enum BookmarkDataFlags
    {
        paired = 16,
        inSubstructure = 32,
        quick = 64,
        deleted = 128
    }
}
