using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WP_Reader
{
    public class Comment_AnnotationPacket: PacketData
    {
        public GeneralWPText_Packet text { get; set; }
        public CommentType commentType { get; set; }
        public DateTime commentTime { get; set; }
        public RGBS_Color color;
        public string userInitials { get; set; }
        public string userName { get; set; }
        

        public Comment_AnnotationPacket(WP6Document document, int prefixID):
            base(document, prefixID)
        {
            if (prefixID > -1)
            {
                text = new GeneralWPText_Packet(document, childID[0] - 1);
                if (_data[dataIndex] == 0)
                {
                    commentType = CommentType.comment;
                }
                else
                {
                    commentType = CommentType.annotation;
                    commentTime = new DateTime(BitConverter.ToInt16(_data, dataIndex + 1), _data[dataIndex + 3],
                    _data[dataIndex + 4], _data[dataIndex + 5], _data[dataIndex + 6], _data[dataIndex + 7]);
                    color.red = (double)_data[dataIndex + 11] / 255;
                    color.green = (double)_data[dataIndex + 12] / 255;
                    color.blue = (double)_data[dataIndex + 13] / 255;
                    color.shading = (double)_data[dataIndex + 14] / 255;
                    dataIndex += 14;    //this is not what the spec says but is what actually works!!!
                    userInitials = getWPWordString();
                    userName = getWPWordString();
                }
            }

        }

        public enum CommentType
        {
            comment,
            annotation
        }


    }

    
}
