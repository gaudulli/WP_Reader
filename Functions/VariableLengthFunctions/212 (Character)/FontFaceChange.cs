using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WP_Reader
{
    public class FontFaceChange: CharacterGroupFunction
    {
        public FontTypefaceDescriptorPoolPacket fontDescriptor { get; set; }
        public short oldMatchedPointSize { get; set; }
        public short hashOfMatchedTypefaceDesscriptor { get; set; }
        public short matchedFontIndex { get; set; }
        public short matchedPointSizeOfFont { get; set; }

        public FontFaceChange()
        {

        }

        public FontFaceChange(WP6Document doc, int index)
            : base(doc, index)
        {
            fontDescriptor = new FontTypefaceDescriptorPoolPacket(doc, prefixIds[0] -1);
            oldMatchedPointSize = BitConverter.ToInt16(nonDeletableInfo, 0);
            hashOfMatchedTypefaceDesscriptor = BitConverter.ToInt16(nonDeletableInfo, 2);
            matchedFontIndex = BitConverter.ToInt16(nonDeletableInfo, 4);
            matchedPointSizeOfFont = BitConverter.ToInt16(nonDeletableInfo, 6);

        }

    }
}
