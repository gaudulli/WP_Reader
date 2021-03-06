﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WP_Reader {
    public class VariableLengthFunction: Function
    
    {
        public byte group { get; set; }
        public byte subGroup { get; set; }
        public int size { get; set; }
        public flagsByte flags { get; set; }
        public int prefixIdCount { get; set; }
        public int[] prefixIds { get; set; }
        public int sizeOfNonDeletableInfo { get; set; }
        public byte[] nonDeletableInfo { get; set; }

        protected WP6Document document;

        private int _index;
        
        private byte[] _data;


        public VariableLengthFunction(WP6Document doc, int index)
        {
            document = doc;
            _index = index;
            _startIndex = index;
            _data = document.data;
            prefixIds = new int[0];     // initialize null array in case no prefix IDs exist
            prefixIdCount = 0;          // set to 0 in case no prefix IDs exist
            parseFunction();
        }

        public VariableLengthFunction()
        {

        }


        public void parseFunction() 
        {
            group = _data[_index];
            functionGroup = (functionGroups)Enum.Parse(typeof(functionGroups), _data[_index].ToString());
            _index++;
            subGroup = _data[_index];
            _index++;
            size = BitConverter.ToInt16(_data, _index);
            _index += 2;
            flags = (flagsByte)_data[_index];
            _index++;
            if (flags.HasFlag(flagsByte.prefixID))
            { // process prefix IDs if prefixID bit is set (128)
                prefixIdCount = _data[_index];
                _index++;
                prefixIds = new int[prefixIdCount];
                for (int i = 0; i < prefixIdCount; i++)
                {
                    prefixIds[i] = BitConverter.ToInt16(_data, _index);
                    _index += 2;
                }
            }
            sizeOfNonDeletableInfo = BitConverter.ToInt16(_data, _index);
            _index += 2;
            nonDeletableInfo = new byte[sizeOfNonDeletableInfo];  // array will be null if no data
            for (int i = 0; i < sizeOfNonDeletableInfo; i++) 
            {    // loop will be bypassed if null array
                nonDeletableInfo[i] = _data[_index];
                _index++;
            }
            getName();
            codeValue = (subGroup << 8 | group) + PUA;
        }

        public virtual void getName()
        {
            WP6_FunctionKey key = new WP6_FunctionKey(group, subGroup);
            if (WP6_FunctionNames.map.ContainsKey(key))
            {
                name = WP6_FunctionNames.map[key];
            }
            else
            {
                name = functionGroups.none;
            }
        }

        public double convertWPUtoInches(int value)
        {
            return ((double)value / 1200);
        }

        public int convertInchestoWPU(double value)
        {
            return (int)(value * 1200);
        }

        public double convertWPFPtoDouble(int value)
        {
            return ((double)value / (UInt16.MaxValue + 1));
        }

        public int convertDoubletoWPFP(double value)
        {
            return (int)(value * (UInt16.MaxValue + 1));
        }

        public double convertWPSPtoDouble(int value)
        {
            byte[] bytes = BitConverter.GetBytes(value);
            ushort firstHalf = BitConverter.ToUInt16(bytes, 0);
            short secondHalf = BitConverter.ToInt16(bytes, 2);
            return convertWPFPtoDouble(firstHalf) + secondHalf;
        }

        public int convertDoubletoWSPS(double value)
        {
            byte[] bytes = new byte[4];
            int intPart = (int)Math.Truncate((decimal)value);
            byte[] secondHalf = BitConverter.GetBytes(intPart);
            byte[] firstHalf = BitConverter.GetBytes(convertDoubletoWPFP((intPart - value)));
            Array.Copy(firstHalf, 0, bytes, 0, 2);
            Array.Copy(secondHalf, 0, bytes, 3, 2);
            return BitConverter.ToInt32(bytes, 0);

        }


        protected string getWPWordString(byte[] info, int startIndex)
        {
            int dataIndex = startIndex;
            string WPWordString = "";
            byte lowByte, highByte;
            bool nullTerminator = false;
            while (!nullTerminator && dataIndex < info.Count())
            {
                lowByte = info[dataIndex];
                highByte = info[dataIndex + 1];
                if (lowByte == 0 && highByte == 0)
                {
                    dataIndex += 2;
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
                dataIndex += 2;

            }
            return WPWordString;
        }



        public override string ToString() {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("VariableLengthFunction: ");
            sb.AppendLine("\tFunction Group: " + functionGroup);
            sb.AppendLine("\tSubGroup: " + subGroup);
            sb.AppendLine("\tSize: " + size);
            sb.AppendLine("\tFlags: " + flags);
            sb.AppendLine("\tPrefixIdCount: " + prefixIdCount);
            foreach (int i in prefixIds)
                {
                    sb.AppendLine("\tPrefixId: " + i);
            }
            sb.AppendLine("\tSizeOfNonDeletableInfo: " + sizeOfNonDeletableInfo);
            foreach (byte b in nonDeletableInfo) {
                sb.AppendLine("\tNonDeletableInfo: " + b);
            }

            return sb.ToString();
        }


    }

}
