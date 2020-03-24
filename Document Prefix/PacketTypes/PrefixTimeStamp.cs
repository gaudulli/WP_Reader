using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WP_Reader
{
    public class PrefixTimeStamp : PacketData
    {
        public DateTime date { get; set; }
        public short version { get; set; }
        public byte minor { get; set; }
        public byte patch { get; set; }
        public int build { get; set; }
        public string wpVersion { get; set; }

        public PrefixTimeStamp()
        {

        }

        public PrefixTimeStamp(WP6Document document, int prefixID):
            base(document, prefixID)
        {
            date = ToDateTime(BitConverter.ToInt32(_data, dataIndex));
            build = BitConverter.ToInt32(_data, dataIndex + 4);
            minor = _data[dataIndex + 8];
            patch = _data[dataIndex + 9];
            version = BitConverter.ToInt16(_data, dataIndex + 10);
            wpVersion = version.ToString() + "." + minor.ToString() + "." + patch.ToString() +
                "." + build.ToString();

        }


        public  DateTime ToDateTime(int dosDateTime)
        {
            var date = (dosDateTime & 0xFFFF0000) >> 16;
            var time = (dosDateTime & 0x0000FFFF);

            var year = (date >> 9) + 1980;
            var month = (date & 0x01e0) >> 5;
            var day = date & 0x1F;
            var hour = time >> 11;
            //hour = hour - 6;    // WordPerfect seems to mis-read the DOS time stamp by 6 hours!!
            var minute = (time & 0x07e0) >> 5;
            var second = (time & 0x1F) * 2;

            return new DateTime((int)year, (int)month, (int)day, (int)hour, (int)minute, (int)second);
        }


    }
}
