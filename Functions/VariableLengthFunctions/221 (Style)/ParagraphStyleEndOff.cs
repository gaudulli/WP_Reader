﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WP_Reader
{
    public class ParagraphStyleEndOff: StyleGroupFunction
    {

        public ParagraphStyleEndOff()
        {

        }
         public ParagraphStyleEndOff(WP6Document doc, int index)
            : base(doc, index)
        {

        }
    }
}
