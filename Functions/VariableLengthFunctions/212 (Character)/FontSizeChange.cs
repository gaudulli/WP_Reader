using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WP_Reader
{
    public class FontSizeChange: CharacterGroupFunction
    {
        public FontTypefaceDescriptorPoolPacket oldDesiredTypefaceDescriptor { get; set; }
        public short desiredPointSize { get; set; }
        public short hashOfMatchedTypefaceDesscriptor { get; set; }
        public short matchedFontIndex { get; set; }
        public short matchedPointSizeOfFont { get; set; }

        public FontSizeChange(WP6Document doc, int index)
            : base(doc, index)
        {
            oldDesiredTypefaceDescriptor = new FontTypefaceDescriptorPoolPacket(doc, prefixIds[0] - 1);
            desiredPointSize = BitConverter.ToInt16(nonDeletableInfo, 0);
            hashOfMatchedTypefaceDesscriptor = BitConverter.ToInt16(nonDeletableInfo, 2);
            matchedFontIndex = BitConverter.ToInt16(nonDeletableInfo, 4);
            matchedPointSizeOfFont = BitConverter.ToInt16(nonDeletableInfo, 6);

        }
    }
}
