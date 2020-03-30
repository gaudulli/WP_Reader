using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WP_Reader
{
    public class EndOfGeneratedText: ParagraphGroupFunction
    {

        public int sizeOfGenerateTable { get; set; }


        public EndOfGeneratedText()
        {

        }
        public EndOfGeneratedText(WP6Document doc, int index)
            : base(doc, index)
        {
            sizeOfGenerateTable = BitConverter.ToInt16(nonDeletableInfo, 0);
        }
    }
}
