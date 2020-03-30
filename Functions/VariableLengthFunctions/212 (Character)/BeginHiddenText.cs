using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WP_Reader
{
    public class BeginHiddenText: CharacterGroupFunction
    {
        public int? outlineLevelNumber { get; set; }
        public bool noParagraphNumbers { get; set; }
        public bool outlineLevelBit4 { get; set; }  //WTF??
        public bool hiddenTableCellInformation { get; set; }
        public bool hiddenByHideSelection { get; set; }
        public int levelNumberAtTimeOfHide { get; set; }


        public BeginHiddenText()
        {

        }
        public BeginHiddenText(WP6Document doc, int index)
            : base(doc, index)
        {
            sbyte num = (sbyte)nonDeletableInfo[0];
            if (num >= 0 && num < 8)
            {
                outlineLevelNumber = num;
            }
            noParagraphNumbers = num == 8;
            outlineLevelBit4 = num == 0x10;
            hiddenTableCellInformation = num == -1;
            hiddenByHideSelection = num == -2;      // I have no idea what these properites are used for...

            levelNumberAtTimeOfHide = nonDeletableInfo[1];
        }
    }
}
