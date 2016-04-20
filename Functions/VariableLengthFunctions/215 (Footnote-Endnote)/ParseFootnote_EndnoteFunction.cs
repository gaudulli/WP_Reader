using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WP_Reader
{
    public static class ParseFootnote_EndnoteFunction
    {
        public static Footnote_EndnoteFunction getFunction(WP6Document doc, int index)
        {
            WP6_FunctionKey key = new WP6_FunctionKey(doc.data[index], doc.data[index+1]);
            if (WP6_FunctionNames.map.ContainsKey(key))
            {
                Footnote_EndnoteGroup name = (Footnote_EndnoteGroup)WP6_FunctionNames.map[key];
                switch (name)
                {
                    case Footnote_EndnoteGroup.footnote_on:
                        return new FootnoteOn(doc, index);      // 0x D7 00   215 0
                    case Footnote_EndnoteGroup.footnote_off:
                        return new FootnoteOff(doc, index);     // 0x D7 01   215 1
                    case Footnote_EndnoteGroup.endnote_on:
                        return new EndNoteOn(doc, index);       // 0x D7 02   215 2
                    case Footnote_EndnoteGroup.endnote_off:
                        return new EndnoteOff(doc, index);      // 0x D7 03   215 3
                }
            }
            return null;
        }

    }
}
