﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WP_Reader
{
    public class AttributeOff:FixedLengthFunction
    {
        public WPAttribute attribute { get; set; }

        public AttributeOff()
        {

        }
        public AttributeOff(WP6Document doc, int index, int size)
            : base(doc, index, size)
        {
            attribute = (WPAttribute)Enum.Parse(typeof(WPAttribute), functionData[0].ToString());
            name = FixedLengthGroup.attribute_off;
        }
    }
}
