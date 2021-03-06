﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WP_Reader
{
    public static class ParseParagrapghGroupFunction
    {
        public static ParagraphGroupFunction getFunction(WP6Document doc, int index)
        {
            WP6_FunctionKey key = new WP6_FunctionKey(doc.data[index], doc.data[index + 1]);
            if (WP6_FunctionNames.map.ContainsKey(key))
            {
                ParagraphGroup name = (ParagraphGroup)WP6_FunctionNames.map[key];
                switch (name)
                {
                    case ParagraphGroup.set_line_height:        // xD3 00 (211 00)
                        return new SetLineHeight(doc, index);
                    case ParagraphGroup.set_line_spacing:
                        return new SetLineSpacing(doc, index);
                    case ParagraphGroup.begin_generated_text:
                        return new BeginGeneratedText(doc, index);
                    case ParagraphGroup.end_of_generated_text:
                        return new EndOfGeneratedText(doc, index);
                    case ParagraphGroup.define_marked_text:
                        return new DefineMarkedText(doc, index);

                    default:
                        return new ParagraphGroupFunction(doc, index);
                }

            }
            return new ParagraphGroupFunction(doc, index);
        }
    }
}
