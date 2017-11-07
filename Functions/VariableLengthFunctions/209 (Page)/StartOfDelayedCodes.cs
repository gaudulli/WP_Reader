using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WP_Reader
{
    public class StartOfDelayedCodes: PageGroupFunction
    {
        public List<DelayedCodesInfo> info;

        public StartOfDelayedCodes(WP6Document doc, int index)
            : base(doc, index)
        {
            info = new List<DelayedCodesInfo>();
            short numIds = nonDeletableInfo[0];
            for (int i = 1; i <= numIds; i++)
            {
                info.Add(new DelayedCodesInfo(BitConverter.ToInt16(nonDeletableInfo, i), 
                    BitConverter.ToInt16(nonDeletableInfo, i + 2), BitConverter.ToInt16(nonDeletableInfo, i +4)));
            }
        }

    }

    public struct DelayedCodesInfo
    {
        public short ID;
        public short hash;
        public short pageNumber;

        public DelayedCodesInfo( short _ID, short _hash, short _pageNumber)
        {
            ID = _ID;
            hash = _hash;
            pageNumber = _pageNumber;
        }
    }
}
