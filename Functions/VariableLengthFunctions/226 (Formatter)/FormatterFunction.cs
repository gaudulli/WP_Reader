﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WP_Reader
{
    public class FormatterFunction:VariableLengthFunction
    {

        public FormatterFunction()
        {

        }
        public FormatterFunction(WP6Document doc, int index)
            : base(doc, index)
        {

        }
    }
}
