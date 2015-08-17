using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WP_Reader
{
    public static class ParseStyleGroupFunction
    {

        public static StyleGroupFunction getFunction(WP6Document doc, int index)
        {
            WP6_FunctionKey key = new WP6_FunctionKey(doc.data[index], doc.data[index+1]);
            if (WP6_FunctionNames.map.ContainsKey(key))
            {
                StyleGroup name = (StyleGroup)WP6_FunctionNames.map[key];
                switch (name)
                {
                    case StyleGroup.style_begin_on:
                        return new StyleBeginOn(doc, index);            //  0xDD 00   221 0
                    case StyleGroup.style_begin_off:
                        return new StyleBeginOff(doc, index);           // 0xDD 01    221 1
                    case StyleGroup.style_end_on:
                        return new StyleEndOn(doc, index);              // 0xDD 02    221 2
                    case StyleGroup.style_end_off:
                        return new StyleEndOff(doc, index);             // 0xDD 03    221 3
                    case StyleGroup.paragraph_style_begin_on_part_1:
                        return new ParagraphStyleBeginOn_Part1(doc, index); // 0xDD 04  221 4
                    case StyleGroup.paragraph_style_begin_off_part_1:
                        return new ParagraphStyleBeginOff_Part1(doc, index);  // 0xDD 05    221 5
                    case StyleGroup.paragraph_style_begin_on_part_2:
                        return new ParagraphStyleBeginOn_Part2(doc,index);      // 0xDD 06  221 6
                    case StyleGroup.paragraph_style_begin_off_part_2:
                        return new ParagraphStyleBeginOff_Part2(doc, index);    // 0xDD 07  221 7
                    case StyleGroup.paragraph_style_end_on:
                        return new ParagraphStyleEndOn(doc, index);             // 0xDD 08  221 8
                    case StyleGroup.paragraph_style_end_off:
                        return new ParagraphStyleEndOff(doc, index);            // 0xDD09   221 9
                    case StyleGroup.global_on:
                        return new GlobalOn(doc, index);                        // 0xDD0A   221 10
                    case StyleGroup.global_off:
                        return new GlobalOff(doc, index);                       // 0xDD0B   221 11
                    default:
                        return new StyleGroupFunction(doc, index);
                }
            }
            return new StyleGroupFunction(doc, index);
        }
    }
}
