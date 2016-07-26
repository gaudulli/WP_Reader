using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WP_Reader
{
    public static class UnicodePlaceHolders
    {
        public static Dictionary<Enum, char> map;

        static UnicodePlaceHolders()
        {
            map = new Dictionary<Enum, char>();

            // Assign tabs and other WP-specific formatting codes to Unicode PUA
            //  so they can be re-assigned to the proper WP code and re-inserted into document.
            map.Add(TabGroup.hard_back_tab, (char)0xE000);
            map.Add(TabGroup.hard_back_tab_DL, (char)0xE001);
            map.Add(TabGroup.hard_tab, (char)0xE002);
            map.Add(TabGroup.hard_tab_DL, (char)0xE003);
            map.Add(TabGroup.hard_left_tab, (char)0xE004);
            map.Add(TabGroup.left_tab, (char)0xE005);
            map.Add(TabGroup.hard_left_tab_DL, (char)0xE006);
            map.Add(TabGroup.left_tab_DL, (char)0xE007);
            map.Add(TabGroup.hard_table_tab, (char)0xE008);
            map.Add(TabGroup.hard_table_tab_DL, (char)0xE009);
            map.Add(TabGroup.hard_left_indent, (char)0xE00A);
            map.Add(TabGroup.hard_left_indent_DL, (char)0xE00B);
            map.Add(TabGroup.hard_left_right_indent, (char)0xE00C);
            map.Add(TabGroup.hard_left_right_indent_DL, (char)0xE00D);
            map.Add(TabGroup.hard_center_on_margin, (char)0xE00E);
            map.Add(TabGroup.hard_center_on_margin_DL, (char)0xE00F);
            map.Add(TabGroup.hard_center_on_pos, (char)0xE010);
            map.Add(TabGroup.hard_center_on_pos_DL, (char)0xE011);
            map.Add(TabGroup.hard_center_tab, (char)0xE012);
            map.Add(TabGroup.center_tab, (char)0xE013);
            map.Add(TabGroup.hard_center_tab_DL, (char)0xE014);
            map.Add(TabGroup.center_tab_DL, (char)0xE015);
            map.Add(TabGroup.hard_flush_right, (char)0xE016);
            map.Add(TabGroup.hard_flush_right_DL, (char)0xE017);
            map.Add(TabGroup.hard_right_tab, (char)0xE018);
            map.Add(TabGroup.right_tab, (char)0xE019);
            map.Add(TabGroup.hard_right_tab_DL, (char)0xE01A);
            map.Add(TabGroup.right_tab_DL, (char)0xE01B);
            map.Add(TabGroup.hard_decimal_tab, (char)0xE01C);
            map.Add(TabGroup.decimal_tab, (char)0xE01D);
            map.Add(TabGroup.hard_decimal_tab_DL, (char)0xE01E);
            map.Add(TabGroup.decimal_tab_DL, (char)0xE01F);


        }


    }
}
