using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WP_Reader
{
    public class SetNumberFunction:VariableLengthFunction
    {

        public SetNumberFunction()
        {

        }
        public SetNumberFunction(WP6Document doc, int index)
            : base(doc, index)
        {

        }
    }
}
