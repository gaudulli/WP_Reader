using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WP_Reader
{
    public class DefineTextColumns : ColumnGroupFunction
    {
        public ColumnType columnType { get; set; }
        public double spacingBetweenRows { get; set; }
        public int numberColumns { get; set; }
        public columnInfo[] columnInformation { get; set; }


        public DefineTextColumns()
        {

        }
        public DefineTextColumns(WP6Document doc, int index)
            : base(doc, index)
        {
            columnType = (ColumnType)nonDeletableInfo[0];
            spacingBetweenRows = convertWPFPtoDouble(BitConverter.ToInt32(nonDeletableInfo, 1));
            numberColumns = nonDeletableInfo[5];
            if (numberColumns > 1)
            {
                columnInformation = new columnInfo[numberColumns];
                int startIndex = 6;
                for (int i = 0; i < columnInformation.Length; i++)
                {
                    columnInformation[i].columnDefinition = ToWidthType(IsBitSet(nonDeletableInfo[startIndex + (i * 6)], 0));
                    columnInformation[i].hTMLWidths = ToHTMLWidthType(IsBitSet(nonDeletableInfo[startIndex + (i * 6)], 1));
                    if (columnInformation[i].columnDefinition.Equals(WidthType.fixedPointValue))
                    {
                        columnInformation[i].columnWidth = convertWPFPtoDouble(BitConverter.ToInt16(nonDeletableInfo,startIndex + (i * 6) + 1));
                    }
                    else
                    {
                        columnInformation[i].columnWidth = convertWPUtoInches(BitConverter.ToInt16(nonDeletableInfo,startIndex + (i * 6) + 1));
                    }
                    if (i < columnInformation.Length - 1)
                    {
                        columnInformation[i].widthBetweenNextColumnDefinition = ToWidthType(IsBitSet(nonDeletableInfo[startIndex + (i * 6) + 3], 0));
                        if (columnInformation[i].widthBetweenNextColumnDefinition.Equals(WidthType.fixedPointValue))
                        {
                            columnInformation[i].widthBetweenNextColumn = convertWPFPtoDouble(BitConverter.ToInt16(nonDeletableInfo, startIndex + (i * 6) + 4));
                        }
                        else
                        {
                            columnInformation[i].widthBetweenNextColumn = convertWPUtoInches(BitConverter.ToInt16(nonDeletableInfo, startIndex + (i * 6) + 4));
                        }
                    }
                    else 
                    { 
                        columnInformation[i].widthBetweenNextColumnDefinition = WidthType.none;
                    }
                }
            }



        }

        bool IsBitSet(byte b, int pos)
        {
            return (b & (1 << pos)) != 0;
        }

        public static WidthType ToWidthType(bool value)
        {
            if (value)
            {
                return WidthType.fixedWidth;
            }
            else
            {
                return WidthType.fixedPointValue;
            }
        }


        public static HTMLWidths ToHTMLWidthType(bool value)
        {
            if (value)
            {
                return HTMLWidths.percentages;
            }
            else
            {
                return HTMLWidths.pixelWidths;
            }
        }


        public struct columnInfo
        {
            public WidthType columnDefinition { get; set; }
            public HTMLWidths hTMLWidths { get; set; }
            public double columnWidth { get; set; }
            public WidthType widthBetweenNextColumnDefinition { get; set; }
            public double widthBetweenNextColumn { get; set; }

        }


        public enum ColumnType
        {
            newspaper = 0,
            newspaper_with_vertical_balance,
            parallel,
            parallel_with_protect
        }

        public enum WidthType
        {
            fixedPointValue = 0,
            fixedWidth,
            none
        }

        public enum HTMLWidths
        {
            pixelWidths = 0,
            percentages
        }
    }

}
