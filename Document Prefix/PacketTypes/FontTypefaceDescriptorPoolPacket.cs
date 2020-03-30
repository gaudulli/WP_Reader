using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace WP_Reader
{
    public class FontTypefaceDescriptorPoolPacket: PacketData
    {
        public short averageCharacterWidth { get; set; } // in PSU (Printer Scalable Units), or 1/10,000 of point size
        public short ascenderHeight { get; set; }   // PSU
        public short xHeight { get; set; }          // PSU
        public short descenderHeight { get; set; }  // PSU
        public short italicAdjust { get; set; }
        public FontFamily fontFamily { get; set; }  // not part of specification, but yields the font family
        public Enum primaryFamilyID { get; set; }  // actual name of font
        public FontScriptingSystem scriptingSystem { get; set; }
        public byte primaryCharacterSet { get; set; }
        public FontWidth width { get; set; }
        public FontWeight weight { get; set; }
        public FontAttributes attributes { get; set; }
        public FontGeneralCharacteristics generalCharacteristics;
        public FontClassification classification { get; set; }
        public byte fillByte { get; set; }
        public FontType fontType; 
        public short typefaceNameLengthInBytes { get; set; }
        public FontTypefaceName typefaceName;  



        public FontTypefaceDescriptorPoolPacket()
        {

        }
        public FontTypefaceDescriptorPoolPacket(WP6Document document, int prefixID):
            base(document, prefixID)
        {
            if (prefixID > -1)
            {
                averageCharacterWidth = BitConverter.ToInt16(_data, dataIndex);
                ascenderHeight = BitConverter.ToInt16(_data, dataIndex + 2);
                xHeight = BitConverter.ToInt16(_data, dataIndex + 4);
                descenderHeight = BitConverter.ToInt16(_data, dataIndex + 6);
                italicAdjust = BitConverter.ToInt16(_data, dataIndex + 8);

                int fontNum = BitConverter.ToInt16(_data, dataIndex + 10);
                int familyNum = (fontNum / 0x100 * 0x100);
                if (Enum.IsDefined(typeof(FontFamily), familyNum))
                {
                    fontFamily = (FontFamily)familyNum;
                }
                primaryFamilyID = getFontName(fontFamily, fontNum);
                byte scriptingNum = _data[dataIndex + 12];
                if (Enum.IsDefined(typeof(FontScriptingSystem), (int)scriptingNum))
                {
                    scriptingSystem = (FontScriptingSystem)scriptingNum;
                }
                primaryCharacterSet = _data[dataIndex + 13];
                byte widthNum = (byte)((int)_data[dataIndex + 14] / 16);
                if (widthNum < 15)
                {
                    width = (FontWidth)widthNum;
                }
                byte weightNum = (byte)((int)_data[dataIndex + 15] / 8);
                if (weightNum < 15)
                {
                    weight = (FontWeight)weightNum;
                }
                attributes = (FontAttributes)_data[dataIndex + 16];
                byte genCharNum = _data[dataIndex + 17];
                generalCharacteristics.usageCategory = (FGC_UsageCategory)(genCharNum & 3);
                generalCharacteristics.generalSerif = (FGC_GeneralSerif)(genCharNum >> 2 & 3);
                generalCharacteristics.spacing = (FGC_Spacing)(genCharNum >> 4 & 3);

                if (Enum.IsDefined(typeof(FontClassification), (int)_data[dataIndex + 18]))
                {
                    classification = (FontClassification)_data[dataIndex + 18];
                }
                fillByte = _data[dataIndex + 19];
                byte fontTypeNum = _data[dataIndex + 20];
                if (fontTypeNum <= 4)
                {
                    if (Enum.IsDefined(typeof(FontType_PRS_File), (int)fontTypeNum))
                    {
                        fontType.PRS_File = (FontType_PRS_File)fontTypeNum;
                    }
                }
                else if (fontTypeNum >= 128)
                {
                    if (Enum.IsDefined(typeof(FontType_DRS_File), (int)fontTypeNum))
                    {
                        fontType.DRS_File = (FontType_DRS_File)fontTypeNum;
                    }
                }
                byte sourceFileType = _data[dataIndex + 21];
                if (Enum.IsDefined(typeof(FontSourceFileType), (int)sourceFileType))
                {
                    fontType.sourceFileType = (FontSourceFileType)sourceFileType;
                }
                typefaceNameLengthInBytes = BitConverter.ToInt16(_data, dataIndex + 22);
                dataIndex += 24;
                typefaceName.typefaceFamily = getWPWordString();
                typefaceName.attributes = getWPWordString();
                typefaceName.namePrefix = getWPWordString();
                typefaceName.nameExtension = getWPWordString();
            }

        }





        private Enum getFontName(FontFamily f, int num)
        {
            switch (fontFamily)
            {
                case FontFamily.ITCBenguiat:
                    if (Enum.IsDefined(typeof(ITCBenguiatFontFamily), num))
                    {
                        return (ITCBenguiatFontFamily)num;
                    }
                    else return null;
                case FontFamily.TimesRoman:
                    if (Enum.IsDefined(typeof(TimesRomanFontFamily), num))
                    {
                        return (TimesRomanFontFamily)num;
                    }
                    else return null;
                case FontFamily.ITCGaramond:
                    if (Enum.IsDefined(typeof(ITCGaramondFontFamily), num))
                    {
                        return (ITCGaramondFontFamily)num;
                    }
                    else return null;
                case FontFamily.CenturySchoolbook:
                    if (Enum.IsDefined(typeof(CenturySchoolbookFontFamily), num))
                    {
                        return (CenturySchoolbookFontFamily)num;
                    }
                    else return null;
                case FontFamily.Bodoni:
                    if (Enum.IsDefined(typeof(BodoniFontFamily), num))
                    {
                        return (BodoniFontFamily)num;
                    }
                    else return null;
                case FontFamily.ITCLubalinGraph:
                    if (Enum.IsDefined(typeof(ITCLubalinGraphFontFamily), num))
                    {
                        return (ITCLubalinGraphFontFamily)num;
                    }
                    else return null;
                case FontFamily.Albertus:
                    if (Enum.IsDefined(typeof(AlbertusFontFamily), num))
                    {
                        return (AlbertusFontFamily)num;
                    }
                    else return null;
                case FontFamily.Courier:
                    if (Enum.IsDefined(typeof(CourierFontFamily), num))
                    {
                        return (CourierFontFamily)num;
                    }
                    else return null;
                case FontFamily.Helvetica:
                    if (Enum.IsDefined(typeof(HelveticaFontFamily), num))
                    {
                        return (HelveticaFontFamily)num;
                    }
                    else return null;
                case FontFamily.ITCRonda:
                    if (Enum.IsDefined(typeof(ITCRondaFontFamily), num))
                    {
                        return (ITCRondaFontFamily)num;
                    }
                    else return null;
                case FontFamily.Microstyle:
                    if (Enum.IsDefined(typeof(MicrostyleFontFamily), num))
                    {
                        return (MicrostyleFontFamily)num;
                    }
                    else return null;
                case FontFamily.Optima:
                    if (Enum.IsDefined(typeof(OptimaFontFamily), num))
                    {
                        return (OptimaFontFamily)num;
                    }
                    else return null;
                case FontFamily.LetterGothic:
                    if (Enum.IsDefined(typeof(LetterGothicFontFamily), num))
                    {
                        return (LetterGothicFontFamily)num;
                    }
                    else return null;
                case FontFamily.Brush:
                    if (Enum.IsDefined(typeof(BrushFontFamily), num))
                    {
                        return (BrushFontFamily)num;
                    }
                    else return null;
                case FontFamily.ParkAvenue:
                    if (Enum.IsDefined(typeof(ParkAvenueFontFamily), num))
                    {
                        return (ParkAvenueFontFamily)num;
                    }
                    else return null;
                case FontFamily.SignetRoundhand:
                    if (Enum.IsDefined(typeof(SignetRoundhandFontFamily), num))
                    {
                        return (SignetRoundhandFontFamily)num;
                    }
                    else return null;
                case FontFamily.Tekton:
                    if (Enum.IsDefined(typeof(TektonFontFamily), num))
                    {
                        return (TektonFontFamily)num;
                    }
                    else return null;
                case FontFamily.Uncial:
                    if (Enum.IsDefined(typeof(UncialFontFamily), num))
                    {
                        return (UncialFontFamily)num;
                    }
                    else return null;
                case FontFamily.OldEnglish:
                    if (Enum.IsDefined(typeof(OldEnglishFontFamily), num))
                    {
                        return (OldEnglishFontFamily)num;
                    }
                    else return null;
                case FontFamily.ITCZapfDingbats:
                    if (Enum.IsDefined(typeof(ITCZapfDingbatsFontFamily), num))
                    {
                        return (ITCZapfDingbatsFontFamily)num;
                    }
                    else return null;
                case FontFamily.Broadway:
                    if (Enum.IsDefined(typeof(BroadwayFontFamily), num))
                    {
                        return (BroadwayFontFamily)num;
                    }
                    else return null;
                case FontFamily.Computer:
                    if (Enum.IsDefined(typeof(ComputerFontFamily), num))
                    {
                        return (ComputerFontFamily)num;
                    }
                    else return null;
                case FontFamily.PTBarnum:
                    if (Enum.IsDefined(typeof(PTBarnumFontFamily), num))
                    {
                        return (PTBarnumFontFamily)num;
                    }
                    else return null;
                case FontFamily.Ponderosa:
                    if (Enum.IsDefined(typeof(PonderosaFontFamily), num))
                    {
                        return (PonderosaFontFamily)num;
                    }
                    else return null;
                case FontFamily.Madrone:
                    if (Enum.IsDefined(typeof(MadroneFontFamily), num))
                    {
                        return (MadroneFontFamily)num;
                    }
                    else return null;
                case FontFamily.Hobo:
                    if (Enum.IsDefined(typeof(HoboFontFamily), num))
                    {
                        return (HoboFontFamily)num;
                    }
                    else return null;
                case FontFamily.Revue:
                    if (Enum.IsDefined(typeof(RevueFontFamily), num))
                    {
                        return (RevueFontFamily)num;
                    }
                    else return null;
                case FontFamily.AestheticOrnamented:
                    if (Enum.IsDefined(typeof(AestheticOrnamentedFontFamily), num))
                    {
                        return (AestheticOrnamentedFontFamily)num;
                    }
                    else return null;
                default:
                    return null;



            }
        }


    }
}
