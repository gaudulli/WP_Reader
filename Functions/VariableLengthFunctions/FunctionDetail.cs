using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WP_Reader
{
    public class FunctionDetail
    {
        public dynamic details;

        public FunctionDetail(WP6Document document, VariableLengthFunction function)
        {

            switch (function.functionGroup)
            {
                case functionGroups.EOL:
                    break;
                case functionGroups.page:
                    break;
                case functionGroups.column:
                    break;
                case functionGroups.paragraph:
                    break;
                case functionGroups.character:
                    break;
                case functionGroups.cross_reference:
                    break;
                case functionGroups.header_footer:
                    //Header_Footer HF = new Header_Footer(document, function);
                    //if (HF.content != null)
                    //{
                    //    details = HF.content.packetText[0].WPStream;
                    //}
                    break;
                case functionGroups.footnote_endnote:
                    break;
                case functionGroups.set_number:
                    break;
                case functionGroups.numbering_method:
                    break;
                case functionGroups.display_number:
                    break;
                case functionGroups.increment_number:
                    break;
                case functionGroups.decrement_number:
                    break;
                case functionGroups.style:
                    break;
                case functionGroups.merge:
                    break;
                case functionGroups.box:
                    break;
                case functionGroups.tab:
                    break;
                case functionGroups.platform:
                    break;
                case functionGroups.formatter:
                    break;
                case functionGroups.fixedLength:
                    break;
            }

        }
    }
}
