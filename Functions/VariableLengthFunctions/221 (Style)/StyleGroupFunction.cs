﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WP_Reader
{
    public class StyleGroupFunction :VariableLengthFunction
    {
        public StyleGroupFunction()
        {

        }

        public StyleGroupFunction(WP6Document doc, int index)
            : base(doc, index)
        {

        }
    }
}
