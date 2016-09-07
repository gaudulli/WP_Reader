using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public enum functionGroups
{
    none,           //the first four types don't really exist as WP "groups"
    textCharacter,  // but they are used to classify various types for 
    singleByte,     // use in parsing.
    fixedLength,

    EOL = 0xd0,       //208
    page,             //209
    column,           //210
    paragraph,        //211
    character,        //212
    cross_reference,  //213
    header_footer,    //214
    footnote_endnote, //215
    set_number,       //216
    numbering_method, //217
    display_number,   //218
    increment_number, //219
    decrement_number, //220
    style,            //221
    merge,            //222
    box,              //223
    tab,              //224
    platform,         //225
    formatter         //226
    
    
}


public enum WPAttribute
{
    extra_large = 0 ,
    very_large  = 1,
    large = 2,
    small_print = 3,
    fine_print = 4,
    superscript = 5,
    subscript = 6,
    outline = 7,
    italics = 8,
    shadow = 9,
    redline = 10,
    double_underline = 11,
    bold = 12,
    strikeout = 13,
    underline = 14,
    small_caps = 15,
    blink = 16,
    reverse_video = 17
}

[Flags()]
public enum flagsByte
{
    simplePaired = 1,
    encased_and_paired = 2,
    encased = 3,
    revert_off = 6,
    revert_on = 7,
    ignore = 64,
    prefixID = 128
}

public enum EOLGroup
{
    beginning_of_file,
    soft_eol,
    soft_eol_eoc,
    soft_eol_eoc_eop,
    hard_eol,
    hard_eol_eoc,
    hard_eol_eoc_eop,
    hard_eoc,
    hard_eoc_eop,
    hard_eop,
    table_cell,
    table_row,
    table_row_eoc,
    table_row_eoc_eop,
    table_row_hard_eoc,
    table_row_hard_eoc_eop,
    table_row_hard_eop,
    table_off,
    table_off_eoc,
    table_off_eoc_eop,
    deletable_soft_eol,
    deletable_soft_eol_eoc,
    deletable_soft_eol_eoc_eop,
    deletable_hard_eol,
    deletable_hard_eol_eoc,
    deletable_hard_eol_eoc_eop,
    deletable_hard_eoc,
    deletable_hard_eoc_eop,
    deletable_hard_eop,
    none
}

public enum PageGroup
{
    top_margin_set,
    bottom_margin_set,
    suppress_page_characteristics,
    page_number_position,
    center_current_page_top_to_bottom,
    center_page_top_to_bottom,
    widow_orphan_on_off,
    set_space_between_footnotes,
    set_space_between_endnotes,
    footnote_minimum_amount_to_keep_together,
    endnote_minimum_amount_to_keep_together,
    footnote_number_restart_on_each_page,
    footnote_continued_message,
    footnote_text_position,
    footnote_separator_line,
    binding_width,
    page_border,
    form,
    form_labels,
    double_sided_printing,
    logical_pages,
    delayed_codes,
    start_of_delayed_codes,
    end_of_delayed_codes,
    page_number_format,
    text_direction,
    header_separator_distance,
    footer_separator_distance,
    line_count,
    logical_page_flow,
    minimum_header_size,
    minimum_footer_size,
    none
}

public enum ColumnGroup
{
    left_margin_set,
    right_margin_set,
    define_text_colums,
    column_border,
    none
}

public enum ParagraphGroup
{
    set_line_height,
    set_line_spacing,
    set_left_hotzone,
    set_right_hotzone,
    tab_set,
    set_justification_mode,
    set_hyphenation_mode,
    set_leading_adjustment,
    begin_generated_text,
    end_of_generated_text,
    set_spacing_after_paragraph,
    indent_first_line_of_paragraph,
    left_margin_adjustment,
    right_margin_adjustment,
    outline_define,
    paragraph_border,
    define_math_columns,
    math_on_off,
    line_numbering_definition,
    force_odd_even_new,
    endnotes_print_here,
    endnotes_print_here_end,
    define_marked_text,
    define_drop_cap,
    paragraph_text_direction,
    Asian_wrapping,
    paragraph_character_count,
    none
}

public enum CharacterGroup
{
    set_alignment_character,
    set_thousands_separator_character,
    set_underline_spaces_mode,
    set_underline_tabs_mode,
    horizontal_advance_to_page_position,
    vertical_advance_to_page_position,
    index_entry,
    table_of_authority_entry,
    cross_reference_tag,
    include_subdocument,
    begin_marked_text_for_table_of_contents,
    end_marked_text_for_table_of_contents,
    begin_marked_text_for_list,
    end_marked_text_for_list,
    start_of_included_subdocument,
    end_of_included_subdocument,
    begin_hidden_text,
    end_hidden_text,
    start_generate_number_placeholder,
    end_generate_number_placeholder,
    concordance_match,
    embedded_printer_command,
    kerning_on_off,
    block_on_off,
    color,
    character_shading_change,
    font_face_change,
    font_size_change,
    set_language,
    comment,
    set_dot_leader_characters,
    conditional_end_of_page,
    date,
    end_of_date,
    date_format,
    charcter_space_width,
    bookmark,
    space_expansion,
    protect_block_on,
    protect_block_off,
    pause_printer,
    overstrike,
    table_definition,
    define_table_end,
    table_column,
    disable_writing_tools,
    print_filename_start,
    print_filename_end,
    bar_code,
    sound,
    paragraph_number_on,
    paragraph_number_off,
    hypertext_begin_on,
    hypertext_begin_off,
    hypertext_end_on,
    hypertext_end_off,
    change_end_of_line_characters,
    change_beginning_of_line_characters,
    define_link_start,
    define_link_end,
    style_separator_comment_begin,
    style_separator_comment_end,
    macro_function_begin,
    macro_function_end,
    page_number_on,
    page_number_off,
    start_of_text_marked_for_hiding,
    end_of_text_marked_for_hiding,
    floating_cell_begin,
    floating_cell_end,
    hidden_text_function,
    attached_text_subtitle_mark_farEast,
    text_of_attached_text_farEast,
    attached_text_options_farEast,
    ligature_control_for_Arabic_midEast,
    number_shaping_for_Arabic_Hebrew_midEast,
    start_of_right_to_left_text,
    end_of_right_to_left_text,
    native_font_change_midEast,
    native_font_size_change_midEast,
    tracked_region_on,
    tracked_region_off,
    style_example_begin,
    style_example_end,
    style_prefix_undo,
    delay_prefix_undo,
    annotate_insert_on,
    annotate_insert_off,
    annotate_delete_on,
    annotate_delete_off,
    speech_recognition_begin,
    speech_recognition_end,
    HTML_begin_form_tag,
    HTML_end_form_tag,
    HTML_specific_tag,
    check_as_you_go,
    named_region_on,
    named_region_off,
    set_underline_styles,
    set_underline_color,
    HTML_specific_tag_on,
    HTML_specific_tag_off,
    document_compare_begin_field,
    document_compare_end_field,
    none
}

// groups that just have the name of the group have not been expanded yet
public enum CrossReferenceGroup
{
    cross_reference
}

public enum Header_FooterGroup
{
    header_A,
    header_B,
    footer_A,
    footer_B,
    watermark_A,
    watermark_B,
    fancy_border,
    none
}

public enum Footnote_EndnoteGroup
{
    footnote_on,
    footnote_off,
    endnote_on,
    endnote_off,
    none
}

public enum SetNumberGroup
{
    set_number
}

public enum NumberingMethodGroup
{
    numbering_method
}

public enum DisplayNumberReferenceGroup
{
    display_number_reference
}

public enum IncrementNumberGroup
{
    increment_number
}

public enum DecrementNumberGroup
{
    decrement_number
}

public enum StyleGroup
{
    style_begin_on,
    style_begin_off,
    style_end_on,
    style_end_off,
    paragraph_style_begin_on_part_1,
    paragraph_style_begin_off_part_1,
    paragraph_style_begin_on_part_2,
    paragraph_style_begin_off_part_2,
    paragraph_style_end_on,
    paragraph_style_end_off,
    global_on,
    global_off,
    none
}


public enum MergeGroup
{
    merge
}

public enum BoxGroup
{
    character_anchored_box,
    paragraph_anchored_box,
    page_anchored_box,
    graphics_rule,
    none
}

public enum TabGroup
{
    left_tab = 4576,
    left_tab_DL = 5088,
    right_tab = 37344,
    right_tab_DL = 37856,
    center_tab = 20960,
    center_tab_DL = 21472,
    decimal_tab = 53728,
    decimal_tab_DL = 54240,
    vertical_bar_tab,
    vertical_bar_tab_DL,
    hard_back_tab = 224,
    hard_back_tab_DL = 736,
    hard_tab = 2272,
    hard_tab_DL = 3808,
    hard_left_tab = 4320,
    hard_left_tab_DL = 4832,
    hard_table_tab = 6368,
    hard_table_tab_DL = 6880,
    hard_left_indent = 12512,
    hard_left_indent_DL = 13024,
    hard_left_right_indent = 14560,
    hard_left_right_indent_DL = 15072,
    hard_center_on_margin = 16608,
    hard_center_on_margin_DL = 17120,
    hard_center_on_pos = 18656,
    hard_center_on_pos_DL = 19168,
    hard_center_tab = 20704,
    hard_center_tab_DL = 21216,
    hard_flush_right = 32992,
    hard_flush_right_DL = 33504,
    hard_right_tab = 37088,
    hard_right_tab_DL = 37600,
    hard_decimal_tab = 53472,
    hard_decimal_tab_DL = 53984,
    none

}

public enum PlatformGroup
{
    platform
}

public enum FormatterGroup
{
    formatter
}

public enum FixedLengthGroup
{
    
    extended_character = 240,
    undo,
    attribute_on,
    attribute_off,
    reserved1,
    reserved2,
    reserved3,
    reserved4,
    reserved5,
    reserved6,
    reserved7,
    highlight_on,
    highlight_off,
    reserved8,
    reserved9,
    reserved_for_negative_one,
    none
    
}

public enum UndoType    //WP stores undo codes in the document, which means the codes need to be properly parsed
{
    start_of_invalid_text,
    end_of_invalid_text,
    start_of_valid_text,
    end_of_valid_text
}

public enum SingleByteGroup
{
    soft_space = 0x80,
    hard_space,
    soft_hyphen_in_line,
    soft_hyphen_at_eol,
    hard_hyphen_in_line,
    auto_hyphen_at_eol,
    invisible_return_in_line,
    dormant_hard_return,
    soft_end_of_center_align,
    hard_end_of_center_align,
    generate_text_place_holder,
    generate_end_text_holder,
    style_seperator_mark,
    start_of_text_to_skip,
    end_of_text_to_skip,
    exited_hyphenation,
    cancel_hyphenation,
    do_subtotal,
    subtotal_entry,
    do_total,
    total_entry,
    do_grand_total,
    calculation_column,
    math_negate,
    no_revert = 0x99,
    optional_space,
    speller_clean_on,
    speller_clean_off,
    joiner_control,
    nonjoiner_control,
    weak_on,
    weak_off,
    decimal_align_end,
    speller_dirty_on,
    speller_dirty_off,
    none
}


public enum WP6_Character_Sets
{
    multinational = 1,
    phonetic,
    box_drawing,
    typographic_symbols,
    iconic_symbols,
    math_scientific,
    math_scientific_extended,
    Greek,
    Hebrew,
    Cyrillic,
    Japanese,
    Arabic = 13,
    Arabic_script
}

// used in index area to specify structure of packets
[Flags]
public enum IndexFlags
{
    childPacketIDs = 1,
    WP_character_set_mapped_text = 2,
    valid_use_count_is_1 = 4,   //no idea what this bit is supposed to do...
    conditional_valid_use_count_is_1 = 8    // or this one

}

public struct RGB_Color
{
    public double red { get; set; }
    public double green { get; set; }
    public double blue { get; set; }
}

public struct RGBS_Color
{
    public double red { get; set; }
    public double green { get; set; }
    public double blue { get; set; }
    public double shading { get; set; }
}

public struct RGBT_Color
{
    public double red { get; set; }
    public double green { get; set; }
    public double blue { get; set; }
    public double transparency { get; set; }
}




