using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WP_Reader
{
    public class SuppressPageCharacteristics: PageGroupFunction
    {
        public SuppressPageCharacteristicsEnum characteristic { get; set; }

        public SuppressPageCharacteristics(WP6Document doc, int index)
            : base(doc, index)
        {
            characteristic = (SuppressPageCharacteristicsEnum)nonDeletableInfo[0];
        }
    }


    [Flags()]
    public enum SuppressPageCharacteristicsEnum
    {
        none = 0,
        pageNumbering = 1,
        pageNumberingAndPrint = 2,
        headerA = 4,
        headerB = 8,
        footerA = 16,
        footerB = 32,
        watermarkA = 64,
        watermarkB = 128
    }

}
