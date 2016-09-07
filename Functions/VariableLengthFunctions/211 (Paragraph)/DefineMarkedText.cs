using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WP_Reader
{
    public class DefineMarkedText: ParagraphGroupFunction
    {
        public MarkTextForGenerateDefinitionPacket definition { get; set; }
        public MarkedTextType markedTextType { get; set; }


       public DefineMarkedText(WP6Document doc, int index)
            : base(doc, index)
        {
            markedTextType = (MarkedTextType)nonDeletableInfo[0];
            definition = new MarkTextForGenerateDefinitionPacket(doc, prefixIds[0] - 1);
        }
    }

    public enum MarkedTextType
    {
        ToC = 0,
        List,
        Index,
        ToA
    }
}
