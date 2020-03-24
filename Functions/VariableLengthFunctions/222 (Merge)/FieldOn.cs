using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WP_Reader
{
    public class FieldOn: MergeGroupFunction
    {

        public FieldOn()
        {

        }
        public FieldOn(WP6Document doc, int index)
            : base(doc, index)
        {

        }

    }
}
