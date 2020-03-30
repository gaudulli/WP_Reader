using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WP_Reader
{
    public class PageNumberPosition : PageGroupFunction
    {
        public FontTypefaceDescriptorPoolPacket fontID { get; set; }
        public short fontHash { get; set; }
        public bool use { get; set; }
        public short copyOfFontHash { get; set; } // WTF??
        public short pointSize { get; set; }  //WPUs
        public PageNumberPositionEnum position { get; set; }
        public short matchedFontIndexInFontList { get; set; }
        public short matchedPointSizeOfFont { get; set; }
        public PageNumberAttribute firstWordAttribute { get; set; }
        public PageNumberAttribute secondWordAttribute { get; set; }
        public RGBS_Color color;
        public short pageNumberHeight { get; set; }
        public PageNumberPositionEnum NewPagePositionOverride { get; set; }

        public PageNumberPosition()
        {

        }

        public PageNumberPosition(WP6Document doc, int index)
            : base(doc, index)
        {
            hasTextContent = true;
            fontID = new FontTypefaceDescriptorPoolPacket(doc, prefixIds[0] - 1);
            fontHash = BitConverter.ToInt16(nonDeletableInfo, 0);
            BitArray b = new BitArray(nonDeletableInfo[2]);
            use = b.Get(0);
            copyOfFontHash = BitConverter.ToInt16(nonDeletableInfo, 3);
            pointSize = BitConverter.ToInt16(nonDeletableInfo, 5);
            position = (PageNumberPositionEnum)nonDeletableInfo[7];
            matchedFontIndexInFontList = BitConverter.ToInt16(nonDeletableInfo, 8);
            matchedPointSizeOfFont = BitConverter.ToInt16(nonDeletableInfo, 10);
            firstWordAttribute = (PageNumberAttribute)BitConverter.ToInt16(nonDeletableInfo, 12);
            //leave alone 2nd word attribute for now, since WP doesn't even have blink or reverse video
            color.red = (double)nonDeletableInfo[15] / 255;
            color.green = (double)nonDeletableInfo[16] / 255;
            color.blue = (double)nonDeletableInfo[17] / 255;
            color.shading = (double)nonDeletableInfo[18] / 255;
            pageNumberHeight = BitConverter.ToInt16(nonDeletableInfo, 19);
            NewPagePositionOverride = (PageNumberPositionEnum)nonDeletableInfo[21];

        }
    }


    public enum PageNumberPositionEnum
    {
        none,
        top_left,
        top_center,
        top_right,
        top_left_and_right,
        bottom_left,
        botom_center,
        bottom_right,
        bottom_left_and_right,
        top_inside_left_and_right,
        bottom_inside_left_and_right
    }

    [Flags()]
    public enum PageNumberAttribute
    {
        none = 0,
        extra_large = 0x01,
        very_large = 0x02,
        large = 0x04,
        small_print = 0x08,
        fine_print = 0x10,
        superscript = 0x20,
        subscript = 0x40,
        outline = 0x80,
        italics = 0x100,
        shadow = 0x200,
        redline = 0x400,
        double_underline = 0x800,
        bold = 0x1000,
        strikeout = 0x2000,
        underline = 0x4000,
        small_caps = 0x8000

    }

}
