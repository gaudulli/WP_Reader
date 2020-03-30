using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WP_Reader
{
    public class Cross_ReferenceFunction: VariableLengthFunction
    {
        public Cross_ReferenceFunction()
        {

        }
        public Cross_ReferenceFunction(WP6Document doc, int index)
            : base(doc, index)
        {

        }
    }
}
