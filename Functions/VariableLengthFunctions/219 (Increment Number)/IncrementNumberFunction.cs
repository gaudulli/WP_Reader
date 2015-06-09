using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WP_Reader
{
    class IncrementNumberFunction:VariableLengthFunction
    {
        public IncrementNumberFunction(WP6Document doc, int index)
            : base(doc, index)
        {

        }
    }
}
