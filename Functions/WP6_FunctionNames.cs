using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WP_Reader
{
    public static class WP6_FunctionNames
    {
        public static Dictionary<WP6_FunctionKey, Enum > map;
        static  WP6_FunctionNames()
        {
            map = new Dictionary<WP6_FunctionKey, Enum>();

        // Single-byte functions are all mapped with "subgroup" set to zero
        map.Add(new WP6_FunctionKey(0x80, 0),SingleByteGroup.soft_space);                     //128
        map.Add(new WP6_FunctionKey(0x81, 0),SingleByteGroup.hard_space);                     //129
        map.Add(new WP6_FunctionKey(0x82, 0),SingleByteGroup.soft_hyphen_in_line);             //130
        map.Add(new WP6_FunctionKey(0x83, 0),SingleByteGroup.soft_hyphen_at_eol);              //131
        map.Add(new WP6_FunctionKey(0x84, 0),SingleByteGroup.hard_hyphen_in_line);             //132
        map.Add(new WP6_FunctionKey(0x85, 0),SingleByteGroup.auto_hyphen_at_eol);              //133
        map.Add(new WP6_FunctionKey(0x86, 0),SingleByteGroup.invisible_return_in_line);       //134
        map.Add(new WP6_FunctionKey(0x87, 0),SingleByteGroup.dormant_hard_return);            //135
        map.Add(new WP6_FunctionKey(0x88, 0),SingleByteGroup.soft_end_of_center_align);       //136
        map.Add(new WP6_FunctionKey(0x89, 0),SingleByteGroup.hard_end_of_center_align);       //137
        map.Add(new WP6_FunctionKey(0x8A, 0),SingleByteGroup.generate_text_place_holder);     //138
        map.Add(new WP6_FunctionKey(0x8B, 0),SingleByteGroup.generate_end_text_holder);       //139
        map.Add(new WP6_FunctionKey(0x8C, 0),SingleByteGroup.style_seperator_mark);           //140
        map.Add(new WP6_FunctionKey(0x8D, 0),SingleByteGroup.start_of_text_to_skip);          //141
        map.Add(new WP6_FunctionKey(0x8E, 0),SingleByteGroup.end_of_text_to_skip);            //142
        map.Add(new WP6_FunctionKey(0x8F, 0),SingleByteGroup.exited_hyphenation);             //143
        map.Add(new WP6_FunctionKey(0x90, 0),SingleByteGroup.cancel_hyphenation);             //144
        map.Add(new WP6_FunctionKey(0x91, 0),SingleByteGroup.do_subtotal);                    //145
        map.Add(new WP6_FunctionKey(0x92, 0),SingleByteGroup.subtotal_entry);                 //146
        map.Add(new WP6_FunctionKey(0x93, 0),SingleByteGroup.do_total);                       //147
        map.Add(new WP6_FunctionKey(0x94, 0),SingleByteGroup.total_entry);                    //148
        map.Add(new WP6_FunctionKey(0x95, 0),SingleByteGroup.do_grand_total);                 //149
        map.Add(new WP6_FunctionKey(0x96, 0),SingleByteGroup.calculation_column);             //150
        map.Add(new WP6_FunctionKey(0x97, 0),SingleByteGroup.math_negate);                    //151
        map.Add(new WP6_FunctionKey(0x99, 0), SingleByteGroup.no_revert);                     //153
        map.Add(new WP6_FunctionKey(0x9A, 0), SingleByteGroup.optional_space);                //154
        map.Add(new WP6_FunctionKey(0x9B, 0), SingleByteGroup.speller_clean_on);              //155
        map.Add(new WP6_FunctionKey(0x9C, 0), SingleByteGroup.speller_clean_off);             //156
        map.Add(new WP6_FunctionKey(0x9D, 0), SingleByteGroup.joiner_control);                //157
        map.Add(new WP6_FunctionKey(0x9E, 0), SingleByteGroup.nonjoiner_control);             //158
        map.Add(new WP6_FunctionKey(0x9F, 0), SingleByteGroup.weak_on);                       //159
        map.Add(new WP6_FunctionKey(0xA0, 0), SingleByteGroup.weak_off);                      //160
        map.Add(new WP6_FunctionKey(0xA1, 0), SingleByteGroup.decimal_align_end);             //161
        map.Add(new WP6_FunctionKey(0xA2, 0), SingleByteGroup.speller_dirty_on);              //162
        map.Add(new WP6_FunctionKey(0xA3, 0), SingleByteGroup.speller_dirty_off);             //163


        // EOL Single-Byte Functions
        map.Add(new WP6_FunctionKey(0xB4, 0),EOLGroup.deletable_hard_eop);             //180
        map.Add(new WP6_FunctionKey(0xB5, 0),EOLGroup.deletable_hard_eoc_eop);         //181
        map.Add(new WP6_FunctionKey(0xB6, 0),EOLGroup.deletable_hard_eoc);             //182
        map.Add(new WP6_FunctionKey(0xB7, 0),EOLGroup.deletable_hard_eol_eoc_eop);     //183
        map.Add(new WP6_FunctionKey(0xB8, 0),EOLGroup.deletable_hard_eol_eoc);         //184
        map.Add(new WP6_FunctionKey(0xB9, 0),EOLGroup.deletable_hard_eol);             //185
        map.Add(new WP6_FunctionKey(0xBA, 0),EOLGroup.deletable_soft_eol_eoc_eop);     //186
        map.Add(new WP6_FunctionKey(0xBB, 0),EOLGroup.deletable_soft_eol_eoc);         //187
        map.Add(new WP6_FunctionKey(0xBC, 0),EOLGroup.deletable_soft_eol);             //188
        map.Add(new WP6_FunctionKey(0xBD, 0),EOLGroup.table_off_eoc_eop);              //189
        map.Add(new WP6_FunctionKey(0xBE, 0),EOLGroup.table_off_eoc);                  //190
        map.Add(new WP6_FunctionKey(0xBF, 0),EOLGroup.table_off);                      //191
        map.Add(new WP6_FunctionKey(0xC0, 0),EOLGroup.table_row_hard_eop);             //192
        map.Add(new WP6_FunctionKey(0xC1, 0),EOLGroup.table_row_hard_eoc_eop);         //193
        map.Add(new WP6_FunctionKey(0xC2, 0),EOLGroup.table_row_hard_eoc);             //194
        map.Add(new WP6_FunctionKey(0xC3, 0),EOLGroup.table_row_eoc_eop);              //195
        map.Add(new WP6_FunctionKey(0xC4, 0),EOLGroup.table_row_eoc);                  //196
        map.Add(new WP6_FunctionKey(0xC5, 0),EOLGroup.table_row);                      //197
        map.Add(new WP6_FunctionKey(0xC6, 0),EOLGroup.table_cell);                     //198
        map.Add(new WP6_FunctionKey(0xC7, 0),EOLGroup.hard_eop);                       //199
        map.Add(new WP6_FunctionKey(0xC8, 0),EOLGroup.hard_eoc_eop);                   //200
        map.Add(new WP6_FunctionKey(0xC9, 0),EOLGroup.hard_eoc);                       //201
        map.Add(new WP6_FunctionKey(0xCA, 0),EOLGroup.hard_eol_eoc_eop);               //202
        map.Add(new WP6_FunctionKey(0xCB, 0),EOLGroup.hard_eol_eoc);                   //203
        map.Add(new WP6_FunctionKey(0xCC, 0),EOLGroup.hard_eol);                       //204
        map.Add(new WP6_FunctionKey(0xCD, 0),EOLGroup.soft_eol_eoc_eop);               //205
        map.Add(new WP6_FunctionKey(0xCE, 0),EOLGroup.soft_eol_eoc);                   //206
        map.Add(new WP6_FunctionKey(0xCF, 0),EOLGroup.soft_eol);                       //207


        //208 EOL Group
        map.Add(new WP6_FunctionKey(0xD0, 0),EOLGroup.beginning_of_file);
        map.Add(new WP6_FunctionKey(0xD0, 1),EOLGroup.soft_eol);
        map.Add(new WP6_FunctionKey(0xD0, 2),EOLGroup.soft_eol_eoc);
        map.Add(new WP6_FunctionKey(0xD0, 3),EOLGroup.soft_eol_eoc_eop);
        map.Add(new WP6_FunctionKey(0xD0, 4),EOLGroup.hard_eol);
        map.Add(new WP6_FunctionKey(0xD0, 5),EOLGroup.hard_eol_eoc);
        map.Add(new WP6_FunctionKey(0xD0, 6),EOLGroup.hard_eol_eoc_eop);
        map.Add(new WP6_FunctionKey(0xD0, 7),EOLGroup.hard_eoc);
        map.Add(new WP6_FunctionKey(0xD0, 8),EOLGroup.hard_eoc_eop);
        map.Add(new WP6_FunctionKey(0xD0, 9),EOLGroup.hard_eop);
        map.Add(new WP6_FunctionKey(0xD0, 10),EOLGroup.table_cell);
        map.Add(new WP6_FunctionKey(0xD0, 11),EOLGroup.table_row);
        map.Add(new WP6_FunctionKey(0xD0, 12),EOLGroup.table_row_eoc);
        map.Add(new WP6_FunctionKey(0xD0, 13),EOLGroup.table_row_eoc_eop);
        map.Add(new WP6_FunctionKey(0xD0, 14),EOLGroup.table_row_hard_eoc);
        map.Add(new WP6_FunctionKey(0xD0, 15),EOLGroup.table_row_hard_eoc_eop);
        map.Add(new WP6_FunctionKey(0xD0, 16),EOLGroup.table_row_hard_eop);
        map.Add(new WP6_FunctionKey(0xD0, 17),EOLGroup.table_off);
        map.Add(new WP6_FunctionKey(0xD0, 18),EOLGroup.table_off_eoc);
        map.Add(new WP6_FunctionKey(0xD0, 19),EOLGroup.table_off_eoc_eop);
        map.Add(new WP6_FunctionKey(0xD0, 20),EOLGroup.deletable_soft_eol);
        map.Add(new WP6_FunctionKey(0xD0, 21),EOLGroup.deletable_soft_eol_eoc);
        map.Add(new WP6_FunctionKey(0xD0, 22),EOLGroup.deletable_soft_eol_eoc_eop);
        map.Add(new WP6_FunctionKey(0xD0, 23),EOLGroup.deletable_hard_eol);
        map.Add(new WP6_FunctionKey(0xD0, 24),EOLGroup.deletable_hard_eol_eoc);
        map.Add(new WP6_FunctionKey(0xD0, 25),EOLGroup.deletable_hard_eol_eoc_eop);
        map.Add(new WP6_FunctionKey(0xD0, 26),EOLGroup.deletable_hard_eoc);
        map.Add(new WP6_FunctionKey(0xD0, 27),EOLGroup.deletable_hard_eoc_eop);
        map.Add(new WP6_FunctionKey(0xD0, 28),EOLGroup.deletable_hard_eop);

       //Skip over embedded EOL subfunctions unless needed in the future.

        //209 Page Group
        map.Add(new WP6_FunctionKey(0xD1, 0), PageGroup.top_margin_set);
        map.Add(new WP6_FunctionKey(0xD1, 1), PageGroup.bottom_margin_set);
        map.Add(new WP6_FunctionKey(0xD1, 2), PageGroup.suppress_page_characteristics);
        map.Add(new WP6_FunctionKey(0xD1, 3), PageGroup.page_number_position);
        map.Add(new WP6_FunctionKey(0xD1, 4), PageGroup.center_current_page_top_to_bottom);
        map.Add(new WP6_FunctionKey(0xD1, 5), PageGroup.center_page_top_to_bottom);
        map.Add(new WP6_FunctionKey(0xD1, 6), PageGroup.widow_orphan_on_off);
        map.Add(new WP6_FunctionKey(0xD1, 7), PageGroup.set_space_between_footnotes);
        map.Add(new WP6_FunctionKey(0xD1, 8), PageGroup.set_space_between_endnotes);
        map.Add(new WP6_FunctionKey(0xD1, 9), PageGroup.footnote_minimum_amount_to_keep_together);
        map.Add(new WP6_FunctionKey(0xD1, 10), PageGroup.endnote_minimum_amount_to_keep_together);
        map.Add(new WP6_FunctionKey(0xD1, 11), PageGroup.footnote_number_restart_on_each_page);
        map.Add(new WP6_FunctionKey(0xD1, 12), PageGroup.footnote_continued_message);
        map.Add(new WP6_FunctionKey(0xD1, 13), PageGroup.footnote_text_position);
        map.Add(new WP6_FunctionKey(0xD1, 14), PageGroup.footnote_separator_line);
        map.Add(new WP6_FunctionKey(0xD1, 15), PageGroup.binding_width);
        map.Add(new WP6_FunctionKey(0xD1, 16), PageGroup.page_border);
        map.Add(new WP6_FunctionKey(0xD1, 17), PageGroup.form);
        map.Add(new WP6_FunctionKey(0xD1, 18), PageGroup.form_labels);
        map.Add(new WP6_FunctionKey(0xD1, 19), PageGroup.double_sided_printing);
        map.Add(new WP6_FunctionKey(0xD1, 20), PageGroup.logical_pages);
        map.Add(new WP6_FunctionKey(0xD1, 21), PageGroup.delayed_codes);
        map.Add(new WP6_FunctionKey(0xD1, 22), PageGroup.start_of_delayed_codes);
        map.Add(new WP6_FunctionKey(0xD1, 23), PageGroup.end_of_delayed_codes);
        map.Add(new WP6_FunctionKey(0xD1, 24), PageGroup.page_number_format);
        map.Add(new WP6_FunctionKey(0xD1, 25), PageGroup.text_direction);
        map.Add(new WP6_FunctionKey(0xD1, 26), PageGroup.header_separator_distance);
        map.Add(new WP6_FunctionKey(0xD1, 27), PageGroup.footer_separator_distance);
        map.Add(new WP6_FunctionKey(0xD1, 28), PageGroup.line_count);
        map.Add(new WP6_FunctionKey(0xD1, 29), PageGroup.logical_page_flow);
        map.Add(new WP6_FunctionKey(0xD1, 30), PageGroup.minimum_header_size);
        map.Add(new WP6_FunctionKey(0xD1, 31), PageGroup.minimum_footer_size);


        //210 Column Group
        map.Add(new WP6_FunctionKey(0xD2, 0), ColumnGroup.left_margin_set);
        map.Add(new WP6_FunctionKey(0xD2, 1), ColumnGroup.right_margin_set);
        map.Add(new WP6_FunctionKey(0xD2, 2), ColumnGroup.define_text_colums);
        map.Add(new WP6_FunctionKey(0xD2, 3), ColumnGroup.column_border);
   
        //211 Paragraph Group
        map.Add(new WP6_FunctionKey(0xD3, 0), ParagraphGroup.set_line_height);
        map.Add(new WP6_FunctionKey(0xD3, 1), ParagraphGroup.set_line_spacing);
        map.Add(new WP6_FunctionKey(0xD3, 2), ParagraphGroup.set_left_hotzone);
        map.Add(new WP6_FunctionKey(0xD3, 3), ParagraphGroup.set_right_hotzone);
        map.Add(new WP6_FunctionKey(0xD3, 4), ParagraphGroup.tab_set);
        map.Add(new WP6_FunctionKey(0xD3, 5), ParagraphGroup.set_justification_mode);
        map.Add(new WP6_FunctionKey(0xD3, 6), ParagraphGroup.set_hyphenation_mode);
        map.Add(new WP6_FunctionKey(0xD3, 7), ParagraphGroup.set_leading_adjustment);
        map.Add(new WP6_FunctionKey(0xD3, 8), ParagraphGroup.begin_generated_text);
        map.Add(new WP6_FunctionKey(0xD3, 9), ParagraphGroup.end_of_generated_text);
        map.Add(new WP6_FunctionKey(0xD3, 10), ParagraphGroup.set_spacing_after_paragraph);
        map.Add(new WP6_FunctionKey(0xD3, 11), ParagraphGroup.indent_first_line_of_paragraph);
        map.Add(new WP6_FunctionKey(0xD3, 12), ParagraphGroup.left_margin_adjustment);
        map.Add(new WP6_FunctionKey(0xD3, 13), ParagraphGroup.right_margin_adjustment);
        map.Add(new WP6_FunctionKey(0xD3, 14), ParagraphGroup.outline_define);
        map.Add(new WP6_FunctionKey(0xD3, 15), ParagraphGroup.paragraph_border);
        map.Add(new WP6_FunctionKey(0xD3, 16), ParagraphGroup.define_math_columns);
        map.Add(new WP6_FunctionKey(0xD3, 17), ParagraphGroup.math_on_off);
        map.Add(new WP6_FunctionKey(0xD3, 18), ParagraphGroup.line_numbering_definition);
        map.Add(new WP6_FunctionKey(0xD3, 19), ParagraphGroup.force_odd_even_new);
        map.Add(new WP6_FunctionKey(0xD3, 20), ParagraphGroup.endnotes_print_here);
        map.Add(new WP6_FunctionKey(0xD3, 21), ParagraphGroup.endnotes_print_here_end);
        map.Add(new WP6_FunctionKey(0xD3, 22), ParagraphGroup.define_marked_text);
        map.Add(new WP6_FunctionKey(0xD3, 23), ParagraphGroup.define_drop_cap);
        map.Add(new WP6_FunctionKey(0xD3, 24), ParagraphGroup.paragraph_text_direction);
        map.Add(new WP6_FunctionKey(0xD3, 25), ParagraphGroup.Asian_wrapping);
        map.Add(new WP6_FunctionKey(0xD3, 26), ParagraphGroup.paragraph_character_count);

        //212 Character Group
        map.Add(new WP6_FunctionKey(0xD4, 0), CharacterGroup.set_alignment_character);
        map.Add(new WP6_FunctionKey(0xD4, 1), CharacterGroup.set_thousands_separator_character);
        map.Add(new WP6_FunctionKey(0xD4, 2), CharacterGroup.set_underline_spaces_mode);
        map.Add(new WP6_FunctionKey(0xD4, 3), CharacterGroup.set_underline_tabs_mode);
        map.Add(new WP6_FunctionKey(0xD4, 4), CharacterGroup.horizontal_advance_to_page_position);
        map.Add(new WP6_FunctionKey(0xD4, 5), CharacterGroup.vertical_advance_to_page_position);
        map.Add(new WP6_FunctionKey(0xD4, 6), CharacterGroup.index_entry);
        map.Add(new WP6_FunctionKey(0xD4, 7), CharacterGroup.table_of_authority_entry);
        map.Add(new WP6_FunctionKey(0xD4, 8), CharacterGroup.cross_reference_tag);
        map.Add(new WP6_FunctionKey(0xD4, 9), CharacterGroup.include_subdocument);
        map.Add(new WP6_FunctionKey(0xD4, 10), CharacterGroup.begin_marked_text_for_table_of_contents);
        map.Add(new WP6_FunctionKey(0xD4, 11), CharacterGroup.end_marked_text_for_table_of_contents);
        map.Add(new WP6_FunctionKey(0xD4, 12), CharacterGroup.begin_marked_text_for_list);
        map.Add(new WP6_FunctionKey(0xD4, 13), CharacterGroup.end_marked_text_for_list);
        map.Add(new WP6_FunctionKey(0xD4, 14), CharacterGroup.start_of_included_subdocument);
        map.Add(new WP6_FunctionKey(0xD4, 15), CharacterGroup.end_of_included_subdocument);
        map.Add(new WP6_FunctionKey(0xD4, 16), CharacterGroup.begin_hidden_text);
        map.Add(new WP6_FunctionKey(0xD4, 17), CharacterGroup.end_hidden_text);
        map.Add(new WP6_FunctionKey(0xD4, 18), CharacterGroup.start_generate_number_placeholder);
        map.Add(new WP6_FunctionKey(0xD4, 19), CharacterGroup.end_generate_number_placeholder);
        map.Add(new WP6_FunctionKey(0xD4, 20), CharacterGroup.concordance_match);
        map.Add(new WP6_FunctionKey(0xD4, 21), CharacterGroup.embedded_printer_command);
        map.Add(new WP6_FunctionKey(0xD4, 22), CharacterGroup.kerning_on_off);
        map.Add(new WP6_FunctionKey(0xD4, 23), CharacterGroup.block_on_off);
        map.Add(new WP6_FunctionKey(0xD4, 24), CharacterGroup.color);
        map.Add(new WP6_FunctionKey(0xD4, 25), CharacterGroup.character_shading_change);
        map.Add(new WP6_FunctionKey(0xD4, 26), CharacterGroup.font_face_change);    // 6868
        map.Add(new WP6_FunctionKey(0xD4, 27), CharacterGroup.font_size_change);    // 7124
        map.Add(new WP6_FunctionKey(0xD4, 28), CharacterGroup.set_language);
        map.Add(new WP6_FunctionKey(0xD4, 29), CharacterGroup.comment);
        map.Add(new WP6_FunctionKey(0xD4, 30), CharacterGroup.set_dot_leader_characters);
        map.Add(new WP6_FunctionKey(0xD4, 31), CharacterGroup.conditional_end_of_page);
        map.Add(new WP6_FunctionKey(0xD4, 32), CharacterGroup.date);
        map.Add(new WP6_FunctionKey(0xD4, 33), CharacterGroup.end_of_date);
        map.Add(new WP6_FunctionKey(0xD4, 34), CharacterGroup.date_format);
        map.Add(new WP6_FunctionKey(0xD4, 35), CharacterGroup.charcter_space_width);
        map.Add(new WP6_FunctionKey(0xD4, 36), CharacterGroup.space_expansion);
        map.Add(new WP6_FunctionKey(0xD4, 37), CharacterGroup.bookmark);
        map.Add(new WP6_FunctionKey(0xD4, 38), CharacterGroup.protect_block_on);
        map.Add(new WP6_FunctionKey(0xD4, 39), CharacterGroup.protect_block_off);
        map.Add(new WP6_FunctionKey(0xD4, 40), CharacterGroup.pause_printer);
        map.Add(new WP6_FunctionKey(0xD4, 41), CharacterGroup.overstrike);
        map.Add(new WP6_FunctionKey(0xD4, 42), CharacterGroup.table_definition);
        map.Add(new WP6_FunctionKey(0xD4, 43), CharacterGroup.define_table_end);
        map.Add(new WP6_FunctionKey(0xD4, 44), CharacterGroup.table_column);
        map.Add(new WP6_FunctionKey(0xD4, 45), CharacterGroup.disable_writing_tools);
        map.Add(new WP6_FunctionKey(0xD4, 46), CharacterGroup.print_filename_start);
        map.Add(new WP6_FunctionKey(0xD4, 47), CharacterGroup.print_filename_end);
        map.Add(new WP6_FunctionKey(0xD4, 48), CharacterGroup.bar_code);
        map.Add(new WP6_FunctionKey(0xD4, 49), CharacterGroup.sound);
        map.Add(new WP6_FunctionKey(0xD4, 50), CharacterGroup.paragraph_number_on);
        map.Add(new WP6_FunctionKey(0xD4, 51), CharacterGroup.paragraph_number_off);
        map.Add(new WP6_FunctionKey(0xD4, 52), CharacterGroup.hypertext_begin_on);
        map.Add(new WP6_FunctionKey(0xD4, 53), CharacterGroup.hypertext_begin_off);
        map.Add(new WP6_FunctionKey(0xD4, 54), CharacterGroup.hypertext_end_on);
        map.Add(new WP6_FunctionKey(0xD4, 55), CharacterGroup.hypertext_end_off);
        map.Add(new WP6_FunctionKey(0xD4, 56), CharacterGroup.change_end_of_line_characters);
        map.Add(new WP6_FunctionKey(0xD4, 57), CharacterGroup.change_beginning_of_line_characters);
        map.Add(new WP6_FunctionKey(0xD4, 58), CharacterGroup.define_link_start);
        map.Add(new WP6_FunctionKey(0xD4, 59), CharacterGroup.define_link_end);
        map.Add(new WP6_FunctionKey(0xD4, 60), CharacterGroup.style_separator_comment_begin);
        map.Add(new WP6_FunctionKey(0xD4, 61), CharacterGroup.style_separator_comment_end);
        map.Add(new WP6_FunctionKey(0xD4, 62), CharacterGroup.macro_function_begin);
        map.Add(new WP6_FunctionKey(0xD4, 63), CharacterGroup.macro_function_end);
        map.Add(new WP6_FunctionKey(0xD4, 64), CharacterGroup.page_number_on);
        map.Add(new WP6_FunctionKey(0xD4, 65), CharacterGroup.page_number_off);
        map.Add(new WP6_FunctionKey(0xD4, 66), CharacterGroup.start_of_text_marked_for_hiding);
        map.Add(new WP6_FunctionKey(0xD4, 67), CharacterGroup.end_of_text_marked_for_hiding);
        map.Add(new WP6_FunctionKey(0xD4, 68), CharacterGroup.floating_cell_begin);
        map.Add(new WP6_FunctionKey(0xD4, 69), CharacterGroup.floating_cell_end);
        map.Add(new WP6_FunctionKey(0xD4, 70), CharacterGroup.hidden_text_function);
        map.Add(new WP6_FunctionKey(0xD4, 71), CharacterGroup.attached_text_subtitle_mark_farEast);
        map.Add(new WP6_FunctionKey(0xD4, 72), CharacterGroup.text_of_attached_text_farEast);
        map.Add(new WP6_FunctionKey(0xD4, 73), CharacterGroup.attached_text_options_farEast);
        map.Add(new WP6_FunctionKey(0xD4, 74), CharacterGroup.ligature_control_for_Arabic_midEast);
        map.Add(new WP6_FunctionKey(0xD4, 75), CharacterGroup.number_shaping_for_Arabic_Hebrew_midEast);
        map.Add(new WP6_FunctionKey(0xD4, 76), CharacterGroup.start_of_right_to_left_text);
        map.Add(new WP6_FunctionKey(0xD4, 77), CharacterGroup.end_of_right_to_left_text);
        map.Add(new WP6_FunctionKey(0xD4, 78), CharacterGroup.native_font_change_midEast);
        map.Add(new WP6_FunctionKey(0xD4, 79), CharacterGroup.native_font_size_change_midEast);
        map.Add(new WP6_FunctionKey(0xD4, 80), CharacterGroup.tracked_region_on);
        map.Add(new WP6_FunctionKey(0xD4, 81), CharacterGroup.tracked_region_off);
        map.Add(new WP6_FunctionKey(0xD4, 82), CharacterGroup.style_example_begin);
        map.Add(new WP6_FunctionKey(0xD4, 83), CharacterGroup.style_example_end);
        map.Add(new WP6_FunctionKey(0xD4, 84), CharacterGroup.style_prefix_undo);
        map.Add(new WP6_FunctionKey(0xD4, 85), CharacterGroup.delay_prefix_undo);
        map.Add(new WP6_FunctionKey(0xD4, 86), CharacterGroup.annotate_insert_on);
        map.Add(new WP6_FunctionKey(0xD4, 87), CharacterGroup.annotate_insert_off);
        map.Add(new WP6_FunctionKey(0xD4, 88), CharacterGroup.annotate_delete_on);
        map.Add(new WP6_FunctionKey(0xD4, 89), CharacterGroup.annotate_delete_off);
        map.Add(new WP6_FunctionKey(0xD4, 90), CharacterGroup.speech_recognition_begin);
        map.Add(new WP6_FunctionKey(0xD4, 91), CharacterGroup.speech_recognition_end);
        map.Add(new WP6_FunctionKey(0xD4, 92), CharacterGroup.HTML_begin_form_tag);
        map.Add(new WP6_FunctionKey(0xD4, 93), CharacterGroup.HTML_end_form_tag);
        map.Add(new WP6_FunctionKey(0xD4, 94), CharacterGroup.HTML_specific_tag);
        map.Add(new WP6_FunctionKey(0xD4, 95), CharacterGroup.check_as_you_go);
        map.Add(new WP6_FunctionKey(0xD4, 96), CharacterGroup.named_region_on);
        map.Add(new WP6_FunctionKey(0xD4, 97), CharacterGroup.named_region_off);
        map.Add(new WP6_FunctionKey(0xD4, 98), CharacterGroup.set_underline_styles);
        map.Add(new WP6_FunctionKey(0xD4, 99), CharacterGroup.set_underline_color);
        map.Add(new WP6_FunctionKey(0xD4, 100), CharacterGroup.HTML_specific_tag_on);
        map.Add(new WP6_FunctionKey(0xD4, 101), CharacterGroup.HTML_specific_tag_off);
        map.Add(new WP6_FunctionKey(0xD4, 102), CharacterGroup.document_compare_begin_field);
        map.Add(new WP6_FunctionKey(0xD4, 103), CharacterGroup.document_compare_end_field);



        //213 Cross-Reference Group
        //  Skip over cross-reference functions until needed in the future
        for (int i = 0; i < 18; i++)        {
            map.Add(new WP6_FunctionKey(0xD5, (byte)i), CrossReferenceGroup.cross_reference);  }


        //214  Header-Footer Group
        map.Add(new WP6_FunctionKey(0xD6, 0), Header_FooterGroup.header_A);
        map.Add(new WP6_FunctionKey(0xD6, 1), Header_FooterGroup.header_B);
        map.Add(new WP6_FunctionKey(0xD6, 2), Header_FooterGroup.footer_A);
        map.Add(new WP6_FunctionKey(0xD6, 3), Header_FooterGroup.footer_B);
        map.Add(new WP6_FunctionKey(0xD6, 4), Header_FooterGroup.watermark_A);
        map.Add(new WP6_FunctionKey(0xD6, 5), Header_FooterGroup.watermark_B);
        map.Add(new WP6_FunctionKey(0xD6, 6), Header_FooterGroup.fancy_border);


        //215 Footnote-Endnote Group
        map.Add(new WP6_FunctionKey(0xD7, 0), Footnote_EndnoteGroup.footnote_on);
        map.Add(new WP6_FunctionKey(0xD7, 1), Footnote_EndnoteGroup.footnote_off);
        map.Add(new WP6_FunctionKey(0xD7, 2), Footnote_EndnoteGroup.endnote_on);
        map.Add(new WP6_FunctionKey(0xD7, 3), Footnote_EndnoteGroup.endnote_off);

        //216 Set Number Group
        //  Skip over set number functions until needed in the future
        for (int i = 0; i < 10; i++) 
        { map.Add(new WP6_FunctionKey(0xD8, (byte)i),SetNumberGroup.set_number); }


        //217  Numbering Method Group
        //Skip over numbering method functions until needed
        for (int i = 0; i < 10; i++)
        { map.Add(new WP6_FunctionKey(0xD9, (byte)i), NumberingMethodGroup.numbering_method); }


        //218 Display Number Reference Group
        //Skip over display number reference functions until needed
        for (int i = 0; i < 20; i++)
        { map.Add(new WP6_FunctionKey(0xDA, (byte)i), DisplayNumberReferenceGroup.display_number_reference); }

        //219  Increment Number Group
        //Skip over increment number functions until needed
        for (int i = 0; i < 10; i++)
        { map.Add(new WP6_FunctionKey(0xDB, (byte)i), IncrementNumberGroup.increment_number); }


        //220 Decrement Number Group
        //Skip over decrement number functions until needed
        for (int i = 0; i < 10; i++)
        { map.Add(new WP6_FunctionKey(0xDC, (byte)i), DecrementNumberGroup.decrement_number); }

        //221 Style Group
        map.Add(new WP6_FunctionKey(0xDD, 0), StyleGroup.style_begin_on);
        map.Add(new WP6_FunctionKey(0xDD, 1), StyleGroup.style_begin_off);
        map.Add(new WP6_FunctionKey(0xDD, 2), StyleGroup.style_end_on);
        map.Add(new WP6_FunctionKey(0xDD, 3), StyleGroup.style_end_off);
        map.Add(new WP6_FunctionKey(0xDD, 4), StyleGroup.paragraph_style_begin_on_part_1);
        map.Add(new WP6_FunctionKey(0xDD, 5), StyleGroup.paragraph_style_begin_off_part_1);
        map.Add(new WP6_FunctionKey(0xDD, 6), StyleGroup.paragraph_style_begin_on_part_2);
        map.Add(new WP6_FunctionKey(0xDD, 7), StyleGroup.paragraph_style_begin_off_part_2);
        map.Add(new WP6_FunctionKey(0xDD, 8), StyleGroup.paragraph_style_end_on);
        map.Add(new WP6_FunctionKey(0xDD, 9), StyleGroup.paragraph_style_end_off);
        map.Add(new WP6_FunctionKey(0xDD, 10), StyleGroup.global_on);
        map.Add(new WP6_FunctionKey(0xDD, 11), StyleGroup.global_off);

            //222 Merge Group
            
            map.Add(new WP6_FunctionKey(0xDE, 0), MergeGroup);
            map.Add(new WP6_FunctionKey(0xDE, 1), MergeGroup);
            map.Add(new WP6_FunctionKey(0xDE,2 ), MergeGroup);
            map.Add(new WP6_FunctionKey(0xDE,3 ), MergeGroup);
            map.Add(new WP6_FunctionKey(0xDE, 4), MergeGroup);
            map.Add(new WP6_FunctionKey(0xDE, 5), MergeGroup);
            map.Add(new WP6_FunctionKey(0xDE, 6), MergeGroup);
            map.Add(new WP6_FunctionKey(0xDE,7 ), MergeGroup);
            map.Add(new WP6_FunctionKey(0xDE, 8), MergeGroup);
            map.Add(new WP6_FunctionKey(0xDE,9 ), MergeGroup);
            map.Add(new WP6_FunctionKey(0xDE, 10), MergeGroup);
            map.Add(new WP6_FunctionKey(0xDE, 11), MergeGroup);
            map.Add(new WP6_FunctionKey(0xDE,12 ), MergeGroup);
            map.Add(new WP6_FunctionKey(0xDE,13 ), MergeGroup);
            map.Add(new WP6_FunctionKey(0xDE,14 ), MergeGroup);
            map.Add(new WP6_FunctionKey(0xDE, 15), MergeGroup);
            map.Add(new WP6_FunctionKey(0xDE, 16), MergeGroup);
            map.Add(new WP6_FunctionKey(0xDE, 17), MergeGroup);
            map.Add(new WP6_FunctionKey(0xDE, 18), MergeGroup);
            map.Add(new WP6_FunctionKey(0xDE, 19), MergeGroup);
            map.Add(new WP6_FunctionKey(0xDE, 20), MergeGroup);
            map.Add(new WP6_FunctionKey(0xDE, 21), MergeGroup);
            map.Add(new WP6_FunctionKey(0xDE, 22), MergeGroup);
            map.Add(new WP6_FunctionKey(0xDE, 23), MergeGroup);
            map.Add(new WP6_FunctionKey(0xDE, 24), MergeGroup);
            map.Add(new WP6_FunctionKey(0xDE, 25), MergeGroup);
            map.Add(new WP6_FunctionKey(0xDE, 26), MergeGroup);
            map.Add(new WP6_FunctionKey(0xDE, 27), MergeGroup);
            map.Add(new WP6_FunctionKey(0xDE, 28), MergeGroup);
            map.Add(new WP6_FunctionKey(0xDE, 29), MergeGroup);
            map.Add(new WP6_FunctionKey(0xDE, 30), MergeGroup);
            map.Add(new WP6_FunctionKey(0xDE, 31), MergeGroup);
            map.Add(new WP6_FunctionKey(0xDE, 32), MergeGroup);
            map.Add(new WP6_FunctionKey(0xDE, 33), MergeGroup);
            map.Add(new WP6_FunctionKey(0xDE, 34), MergeGroup);
            map.Add(new WP6_FunctionKey(0xDE, 35), MergeGroup);
            map.Add(new WP6_FunctionKey(0xDE, 36), MergeGroup);
            map.Add(new WP6_FunctionKey(0xDE, 37), MergeGroup);
            map.Add(new WP6_FunctionKey(0xDE, 38), MergeGroup);
            map.Add(new WP6_FunctionKey(0xDE, 39), MergeGroup);
            map.Add(new WP6_FunctionKey(0xDE, 40), MergeGroup);
            map.Add(new WP6_FunctionKey(0xDE, 41), MergeGroup);
            map.Add(new WP6_FunctionKey(0xDE, 42), MergeGroup);
            map.Add(new WP6_FunctionKey(0xDE, 43), MergeGroup);
            map.Add(new WP6_FunctionKey(0xDE, 44), MergeGroup);
            map.Add(new WP6_FunctionKey(0xDE, 45), MergeGroup);
            map.Add(new WP6_FunctionKey(0xDE, 46), MergeGroup);
            map.Add(new WP6_FunctionKey(0xDE, 47), MergeGroup);
            map.Add(new WP6_FunctionKey(0xDE, 48), MergeGroup);
            map.Add(new WP6_FunctionKey(0xDE, 49), MergeGroup);
            map.Add(new WP6_FunctionKey(0xDE, 50), MergeGroup);
            map.Add(new WP6_FunctionKey(0xDE, 51), MergeGroup);
            map.Add(new WP6_FunctionKey(0xDE, 52), MergeGroup);
            map.Add(new WP6_FunctionKey(0xDE, 53), MergeGroup);
            map.Add(new WP6_FunctionKey(0xDE, 54), MergeGroup);
            map.Add(new WP6_FunctionKey(0xDE, 55), MergeGroup);
            map.Add(new WP6_FunctionKey(0xDE, 56), MergeGroup);
            map.Add(new WP6_FunctionKey(0xDE, 57), MergeGroup);
            map.Add(new WP6_FunctionKey(0xDE, 58), MergeGroup);
            map.Add(new WP6_FunctionKey(0xDE, 59), MergeGroup);
            map.Add(new WP6_FunctionKey(0xDE, 60), MergeGroup);
            map.Add(new WP6_FunctionKey(0xDE, 61), MergeGroup);
            map.Add(new WP6_FunctionKey(0xDE, 62), MergeGroup);
            map.Add(new WP6_FunctionKey(0xDE, 63), MergeGroup);
            map.Add(new WP6_FunctionKey(0xDE, 64), MergeGroup);
            map.Add(new WP6_FunctionKey(0xDE, 65), MergeGroup);
            map.Add(new WP6_FunctionKey(0xDE, 66), MergeGroup);
            map.Add(new WP6_FunctionKey(0xDE, 67), MergeGroup);
            map.Add(new WP6_FunctionKey(0xDE, 68), MergeGroup);
            map.Add(new WP6_FunctionKey(0xDE, 69), MergeGroup);
            map.Add(new WP6_FunctionKey(0xDE, 70), MergeGroup);
            map.Add(new WP6_FunctionKey(0xDE, 71), MergeGroup);
            map.Add(new WP6_FunctionKey(0xDE, 72), MergeGroup);
            map.Add(new WP6_FunctionKey(0xDE, 73), MergeGroup);
            map.Add(new WP6_FunctionKey(0xDE, 74), MergeGroup);
            map.Add(new WP6_FunctionKey(0xDE, 75), MergeGroup);
            map.Add(new WP6_FunctionKey(0xDE, 76), MergeGroup);
            map.Add(new WP6_FunctionKey(0xDE, 77), MergeGroup);
            map.Add(new WP6_FunctionKey(0xDE, 78), MergeGroup);
            map.Add(new WP6_FunctionKey(0xDE, 79), MergeGroup);
            map.Add(new WP6_FunctionKey(0xDE, 80), MergeGroup);
            map.Add(new WP6_FunctionKey(0xDE, 81), MergeGroup);
            map.Add(new WP6_FunctionKey(0xDE, 82), MergeGroup);
            map.Add(new WP6_FunctionKey(0xDE, 83), MergeGroup);
            map.Add(new WP6_FunctionKey(0xDE, 84), MergeGroup);
            map.Add(new WP6_FunctionKey(0xDE, 85), MergeGroup);
            map.Add(new WP6_FunctionKey(0xDE, 86), MergeGroup);
            map.Add(new WP6_FunctionKey(0xDE, 87), MergeGroup);
            map.Add(new WP6_FunctionKey(0xDE, 88), MergeGroup);
            map.Add(new WP6_FunctionKey(0xDE, 89), MergeGroup);
            map.Add(new WP6_FunctionKey(0xDE, 90), MergeGroup);
            map.Add(new WP6_FunctionKey(0xDE, 91), MergeGroup);
            map.Add(new WP6_FunctionKey(0xDE, 92), MergeGroup);
            map.Add(new WP6_FunctionKey(0xDE, 93), MergeGroup);
            map.Add(new WP6_FunctionKey(0xDE, 94), MergeGroup);
            map.Add(new WP6_FunctionKey(0xDE, 95), MergeGroup);









            //for (int i=0; i<150; i++)
            //    {
            //    map.Add(new WP6_FunctionKey(0xDE, (byte)i),MergeGroup.none);
            //}

            //223 Box Group
            map.Add(new WP6_FunctionKey(0xDF, 0), BoxGroup.character_anchored_box);
        map.Add(new WP6_FunctionKey(0xDF, 1), BoxGroup.paragraph_anchored_box);
        map.Add(new WP6_FunctionKey(0xDF, 2), BoxGroup.page_anchored_box);
        map.Add(new WP6_FunctionKey(0xDF, 3), BoxGroup.graphics_rule);

        //224 Tab Group
        // tab subgroup is based on bit flags, but not all combinations are possible
        map.Add(new WP6_FunctionKey(0xE0, 0), TabGroup.hard_back_tab);      //224
        map.Add(new WP6_FunctionKey(0xE0, 2), TabGroup.hard_back_tab_DL);   //736
        map.Add(new WP6_FunctionKey(0xE0, 8), TabGroup.hard_tab);           //2272
        map.Add(new WP6_FunctionKey(0xE0, 10), TabGroup.hard_tab_DL);       //3808
        map.Add(new WP6_FunctionKey(0xE0, 16), TabGroup.hard_left_tab);     //4320
        map.Add(new WP6_FunctionKey(0xE0, 17), TabGroup.left_tab);          // 4576
        map.Add(new WP6_FunctionKey(0xE0, 18), TabGroup.hard_left_tab_DL);  //4832
        map.Add(new WP6_FunctionKey(0xE0, 19), TabGroup.left_tab_DL);       //5088
        map.Add(new WP6_FunctionKey(0xE0, 24), TabGroup.hard_table_tab);    //6368
        map.Add(new WP6_FunctionKey(0xE0, 26), TabGroup.hard_table_tab_DL); //6880      
        map.Add(new WP6_FunctionKey(0xE0, 48), TabGroup.hard_left_indent);      //12512
        map.Add(new WP6_FunctionKey(0xE0, 50), TabGroup.hard_left_indent_DL);   //13024
        map.Add(new WP6_FunctionKey(0xE0, 56), TabGroup.hard_left_right_indent);   //14560
        map.Add(new WP6_FunctionKey(0xE0, 58), TabGroup.hard_left_right_indent_DL); //15072
        map.Add(new WP6_FunctionKey(0xE0, 64), TabGroup.hard_center_on_margin);    //16608
        map.Add(new WP6_FunctionKey(0xE0, 66), TabGroup.hard_center_on_margin_DL); //17120
        map.Add(new WP6_FunctionKey(0xE0, 72), TabGroup.hard_center_on_pos);       //18656
        map.Add(new WP6_FunctionKey(0xE0, 74), TabGroup.hard_center_on_pos_DL);    //19168
        map.Add(new WP6_FunctionKey(0xE0, 80), TabGroup.hard_center_tab);       //20704
        map.Add(new WP6_FunctionKey(0xE0, 81), TabGroup.center_tab);            //20960
        map.Add(new WP6_FunctionKey(0xE0, 82), TabGroup.hard_center_tab_DL);    //21216
        map.Add(new WP6_FunctionKey(0xE0, 83), TabGroup.center_tab_DL);         //21472
        map.Add(new WP6_FunctionKey(0xE0, 128), TabGroup.hard_flush_right);     //32992
        map.Add(new WP6_FunctionKey(0xE0, 130), TabGroup.hard_flush_right_DL);  //33504
        map.Add(new WP6_FunctionKey(0xE0, 144), TabGroup.hard_right_tab);       //37088
        map.Add(new WP6_FunctionKey(0xE0, 145), TabGroup.right_tab);            //37344
        map.Add(new WP6_FunctionKey(0xE0, 146), TabGroup.hard_right_tab_DL);    //37600
        map.Add(new WP6_FunctionKey(0xE0, 147), TabGroup.right_tab_DL);         //37856
        map.Add(new WP6_FunctionKey(0xE0, 208), TabGroup.hard_decimal_tab);         //53472
        map.Add(new WP6_FunctionKey(0xE0, 209), TabGroup.decimal_tab);              //53728
        map.Add(new WP6_FunctionKey(0xE0, 210), TabGroup.hard_decimal_tab_DL);      //53984
        map.Add(new WP6_FunctionKey(0xE0, 211), TabGroup.decimal_tab_DL);           //54240
            
        //225 Platform Group
        //Skip over all platform functions; just fill in a blank reference in case code appears in document.
        for (int i = 0; i < 32; i++)
        { map.Add(new WP6_FunctionKey(0xE1, (byte)i), PlatformGroup.platform); }

        //226 Formatter Group
        //Skip over all formatter functions; just fill in a blank reference in case code appears in document.
        for (int i = 0; i < 256; i++)
        { map.Add(new WP6_FunctionKey(0xE2, (byte)i), FormatterGroup.formatter); }

        //240-255 Fixed-Length Multibyte Functions
        // Fixed-length multibyte functions are all mapped with "subgroup" set to zero, since they do not have subgroups

        map.Add(new WP6_FunctionKey(0xF0, 0), FixedLengthGroup.extended_character);
        map.Add(new WP6_FunctionKey(0xF1, 0), FixedLengthGroup.undo);
        map.Add(new WP6_FunctionKey(0xF2, 0), FixedLengthGroup.attribute_on);
        map.Add(new WP6_FunctionKey(0xF3, 0), FixedLengthGroup.attribute_off);
        map.Add(new WP6_FunctionKey(0xF4, 0), FixedLengthGroup.reserved1);
        map.Add(new WP6_FunctionKey(0xF5, 0), FixedLengthGroup.reserved2);
        map.Add(new WP6_FunctionKey(0xF6, 0), FixedLengthGroup.reserved3);
        map.Add(new WP6_FunctionKey(0xF7, 0), FixedLengthGroup.reserved4); 
        map.Add(new WP6_FunctionKey(0xF8, 0), FixedLengthGroup.reserved5);
        map.Add(new WP6_FunctionKey(0xF9, 0), FixedLengthGroup.reserved6); 
        map.Add(new WP6_FunctionKey(0xFA, 0), FixedLengthGroup.reserved7);
        map.Add(new WP6_FunctionKey(0xFB, 0), FixedLengthGroup.highlight_on); 
        map.Add(new WP6_FunctionKey(0xFC, 0), FixedLengthGroup.highlight_off);
        map.Add(new WP6_FunctionKey(0xFD, 0), FixedLengthGroup.reserved8); 
        map.Add(new WP6_FunctionKey(0xFE, 0), FixedLengthGroup.reserved9);
        map.Add(new WP6_FunctionKey(0xFF, 0), FixedLengthGroup.reserved_for_negative_one);

        }
    }
}
