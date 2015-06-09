﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WP_Reader
{
    class Header_FooterFunction: VariableLengthFunction
    {
        public GeneralWPText_PacketType content { get; set; }

        public Header_FooterFunction(WP6Document doc, int index)
            : base(doc, index)
        {
            // for now, ignore the possible second prefixID (user assistant)
            content = new GeneralWPText_PacketType(document, prefixIds[0] -1);  
            // WP numbers prefixIDs beginning with 1, so need to subtract 1 to get correct ID
        }
    }
}
