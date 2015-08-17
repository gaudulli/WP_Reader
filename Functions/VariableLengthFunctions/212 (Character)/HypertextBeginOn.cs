using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WP_Reader
{
    public class HypertextBeginOn:CharacterGroupFunction
    {
        public NativeFileNamePacket filename_or_macro_PID { get; set; }
        public HypertextBookmarkNamePacket bookmarkPID { get; set; }
        public int hypertextAction { get; set; }

        public HypertextBeginOn(WP6Document doc, int index)
          : base(doc, index)
        {
            filename_or_macro_PID = new NativeFileNamePacket(doc, prefixIds[0]-1);  // WP starts index areas with 1
            bookmarkPID = new HypertextBookmarkNamePacket(doc, prefixIds[1] - 1);
            hypertextAction = nonDeletableInfo[0];
        }
    }
}
