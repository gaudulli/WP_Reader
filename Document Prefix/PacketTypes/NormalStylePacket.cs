using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WP_Reader
{
    public class NormalStylePacket: PacketData
    {
        public int paragraphTextSize { get; set; }
        public int beginningStyleTextSize { get; set; }
        public int endStyleTextSize { get; set; }
        public int extraStyleTextSize { get; set; } // these four values correspond to the property public int[] sizeofBlock
        public StyleType styleType { get; set; }
        public StyleFlag styleflag { get; set; }
        public short styleHash { get; set; }
        public short descriptionBeginningRelativeOffset { get; set; }
        public string styleName { get; set; }
        public string styleDescription { get; set; }

        public DocumentArea paragraphOrientedBeginInformation { get; set; }
        public DocumentArea otherBeginStyleInformation { get; set; }
        public DocumentArea endStyleInformation { get; set; }
        public DocumentArea extraStyleInformation { get; set; }
        

        private WP6Document _document;



        public NormalStylePacket(WP6Document document, int prefixID) :
            base(document, prefixID)
        {
            _document = document;
            if (prefixID > 0)
            {
                getContents();
            }
        }

        private void getContents()
        {
            paragraphTextSize = sizeofBlock[0];
            beginningStyleTextSize = sizeofBlock[1];
            endStyleTextSize = sizeofBlock[2];
            extraStyleTextSize = sizeofBlock[3];
            styleType = (StyleType)_data[dataIndex];
            dataIndex++;
            styleflag = (StyleFlag)_data[dataIndex];
            dataIndex++;
            styleHash = BitConverter.ToInt16(_data, dataIndex);
            dataIndex += 2;
            descriptionBeginningRelativeOffset = BitConverter.ToInt16(_data, dataIndex);
            dataIndex += 2;
            styleName = getWPWordString();
            styleDescription = getWPWordString();
            paragraphOrientedBeginInformation = new DocumentArea(_document, dataIndex, dataIndex + paragraphTextSize);
            dataIndex += paragraphTextSize;
            otherBeginStyleInformation = new DocumentArea(_document, dataIndex, dataIndex + beginningStyleTextSize);
            dataIndex += beginningStyleTextSize;
            endStyleInformation = new DocumentArea(_document, dataIndex, dataIndex + endStyleTextSize);
            dataIndex += endStyleTextSize;
            extraStyleInformation = new DocumentArea(_document, dataIndex, dataIndex + extraStyleTextSize);
            dataIndex += extraStyleTextSize;

        }

        public enum StyleType
	{
	        openStyle = 1,
            pairedStyle,
            paragraphStyle,
            deleted_including_codes,    //WTF??
            deleted_leaving_codes
	}
        [Flags()]
        public enum StyleFlag
        {
            library_style = 1,
            system_style = 2,
            enter_turns_style_off = 4,
            enter_turns_style_back_on = 8,
            reserved = 16,  //so then why is it set at all?
            includes_other_styles = 32,
            reserved2 = 64,
            variables = 128

        }

    }
}
