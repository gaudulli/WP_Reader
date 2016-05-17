using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WP_Reader
{
    public static class UtilityMethods
    {

        public static string getWPWordString(byte[] _data, int index, int stop)
        {
            string WPWordString = "";
            byte lowByte, highByte;
            bool nullTerminator = false;
            while (!nullTerminator && index <= stop)
            {
                lowByte = _data[index];
                highByte = _data[index + 1];
                if (lowByte == 0 && highByte == 0)
                {
                    index += 2;
                    return WPWordString;
                }
                else if (highByte == 0 && lowByte < 127)
                {
                    WPWordString += (char)lowByte;
                }
                else if (highByte > 0 && highByte < 15)
                {
                    WPWordString += new ExtendedCharacter(highByte, lowByte).content;   // call alternate constructor for 
                    //  ExtendedCharacter to get Unicode value.
                }
                index += 2;

            }
                return WPWordString;
        }
    }
}
