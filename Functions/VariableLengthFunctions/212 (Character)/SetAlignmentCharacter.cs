using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WP_Reader
{
    /// <summary>
    /// 0x D4 00  (212 00)
    /// </summary>
    public class SetAlignmentCharacter:CharacterGroupFunction
    {
        public short alignment_decimalCharacter { get; set; }     //not sure if this should be a string...figure out when needed

        public SetAlignmentCharacter(WP6Document doc, int index)
            : base(doc, index)
        {
            alignment_decimalCharacter = BitConverter.ToInt16(nonDeletableInfo, 0);
        }
    }
}
