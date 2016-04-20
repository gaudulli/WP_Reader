using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WP_Reader
{
    public static class ParseVariableLengthFunction
    {

        public static VariableLengthFunction getfunction(WP6Document doc, int index)
        {
            functionGroups functionGroup = (functionGroups)Enum.Parse(typeof(functionGroups), doc.data[index].ToString());
            switch (functionGroup)
            {
                case functionGroups.EOL:
                    return new EOLFunction(doc, index);
                case functionGroups.page:
                    return ParsePageGroupFunction.getFunction(doc, index);
                case functionGroups.column:
                    return ParseColumnGroupFunction.getFunction(doc, index);
                case functionGroups.paragraph:
                    return ParseParagrapghGroupFunction.getFunction(doc, index);
                case functionGroups.character:
                    return ParseCharacterGroupFunction.getFunction(doc, index);
                case functionGroups.cross_reference:
                    return new Cross_ReferenceFunction(doc, index);
                case functionGroups.header_footer:
                    return new Header_FooterFunction(doc, index);
                case functionGroups.footnote_endnote:
                    return ParseFootnote_EndnoteFunction.getFunction(doc, index);
                case functionGroups.set_number:
                    return new SetNumberFunction(doc, index);
                case functionGroups.numbering_method:
                    return new NumberingMethodFunction(doc, index);
                case functionGroups.display_number:
                    return new DisplayNumberFunction(doc, index);
                case functionGroups.increment_number:
                    return new IncrementNumberFunction(doc, index);
                case functionGroups.decrement_number:
                    return new DecrementNumberFunction(doc, index);
                case functionGroups.style:
                    return ParseStyleGroupFunction.getFunction(doc, index);
                case functionGroups.merge:
                    return new MergeFunction(doc, index);
                case functionGroups.box:
                    return new BoxFunction(doc, index);
                case functionGroups.tab:
                    return new TabFunction(doc, index);
                case functionGroups.platform:
                    return new PlatformFunction(doc, index);
                case functionGroups.formatter:
                    return new FormatterFunction(doc, index);
            }
        
            return null;
        }

    }
}
