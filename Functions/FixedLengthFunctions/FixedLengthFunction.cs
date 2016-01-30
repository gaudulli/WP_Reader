using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WP_Reader
{
    public class FixedLengthFunction : Function
    {

        public int size { get; set; }
        public byte[] functionData { get; set; }

        protected WP6Document document;

        private int _index;
        private byte[] _data;


        public FixedLengthFunction(WP6Document doc, int index, int size)
        {
            this.size = size;
            document = doc;
            _index = index;
            _data = document.data;
            name = FixedLengthGroup.none;
            functionGroup = functionGroups.fixedLength;
            parseFunction();
        }

        public FixedLengthFunction()
        {

        }

        public void parseFunction()
        {
            _index++;   //skip function number
            int sizeFunctionData = size -2;  //everything except the opening and closing gate
            functionData = new byte[sizeFunctionData];
            for (int i = 0; i < sizeFunctionData; i++)
            {

                functionData[i] = _data[_index];
                _index++;
            }
        }



        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("FixedLengthFunction: ");
            sb.AppendLine("\tFunction: " + name);
            sb.AppendLine("\tSize: " + size);
            return sb.ToString();
        }
    }

}
