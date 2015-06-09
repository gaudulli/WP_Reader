using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WP_Reader
{
    public class AttributeOn: FixedLengthFunction
    {
        public Attribute attribute { get; set; }

        public AttributeOn(WP6Document doc, int index, int size)
            : base(doc, index, size)
        {
            attribute = (Attribute)Enum.Parse(typeof(Attribute), functionData[0].ToString());
            name = FixedLengthGroup.attribute_on;
        }
    }
}
