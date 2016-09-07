using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WP_Reader
{
    public class MarkTextForGenerateDefinitionPacket: PacketData
    {
        public NormalStylePacket[] styles { get; set; }
        public PageNumberFormatStringPacket format { get; set; }
        public NativeFileNamePacket concordanceFilename { get; set; }   // only used by Index definition
        public CountersDataPacket graphicsStyle { get; set; } // only used by List definition
        public TypeOfMarkedTextDefinition type { get; set; }
        public NumberMode numberMode { get; set; }
        public string name { get; set; }    // used by List and ToA definitions

        private WP6Document _document;

        public MarkTextForGenerateDefinitionPacket(WP6Document document, int prefixID):
            base(document, prefixID)
        {
            _document = document;
            type = (TypeOfMarkedTextDefinition)_data[dataIndex];
            numberMode = (NumberMode)_data[dataIndex + 1];
            dataIndex += 2;
            switch (type)
            {
                case TypeOfMarkedTextDefinition.ToC:
                    {
                        ParseToCDefinition();
                        break;
                    }
                case TypeOfMarkedTextDefinition.Index:
                    {
                        ParseIndexDefinition();
                        break;
                    }
                case TypeOfMarkedTextDefinition.List:
                    {
                        ParseListDefinition();
                        break;
                    }
                case TypeOfMarkedTextDefinition.ToA:
                    {
                        ParseToADefinition();
                        break;
                    }
            }
            
        }

        private void ParseToCDefinition()
        {
            styles = new NormalStylePacket[childIDCount - 1];
            for (int i = 0; i < childIDCount - 1; i++)
            {
                styles[i] = new NormalStylePacket(_document, childID[i] -1);
            }
            format = new PageNumberFormatStringPacket(_document, childID[childIDCount - 1] - 1);
            

        }

        private void ParseIndexDefinition()
        {

        }

        private void ParseListDefinition(){

        }

        private void ParseToADefinition()
        {

        }


    }

    public enum TypeOfMarkedTextDefinition
    {
        ToC = 0,
        List = 1,
        Index = 2,
        ToA = 4     // this is probably wrong in the documentation!
    }

    public enum NumberMode
    {
        noNumber = 0,
        numberFollowsEntry,
        numberInParenthesesFollowsEntry,
        numberFlushRight,
        numberFlushRightWithDotLeaders
    }
}
