using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WP_Reader
{
    public static class ParseCharacterGroupFunction
    {
        public static CharacterGroupFunction getFunction(WP6Document doc, int index)
        {
            WP6_FunctionKey key = new WP6_FunctionKey(doc.data[index], doc.data[index+1]);
            if (WP6_FunctionNames.map.ContainsKey(key))
            {
                CharacterGroup name = (CharacterGroup)WP6_FunctionNames.map[key];
                switch (name)
                {
                    case CharacterGroup.set_alignment_character:                     // 0x D4 00  (212 00)
                        return new SetAlignmentCharacter(doc, index);
                    case CharacterGroup.set_thousands_separator_character:              // 0x D4 01 (212 01)
                        return new SetThousandsSeparatorCharacter(doc, index);
                    case CharacterGroup.set_underline_spaces_mode:                       // 0x D4 02  (212 02)
                        return new SetUnderlineSpacesMode(doc, index); 
                    case CharacterGroup.set_underline_tabs_mode:                        // 0x D4 03 (212 03)
                        return new SetUnderlineTabsMode(doc, index);
                    case CharacterGroup.horizontal_advance_to_page_position:            // 0x D4 04 (212 04)
                        return new HorizontalAdvanceToPagePosition(doc, index);
                    case CharacterGroup.vertical_advance_to_page_position:              // 0x D4 05 (212 05)
                        return new VerticalAdvanceTo_PagePosition(doc, index);
                    case CharacterGroup.index_entry:
                        return new IndexEntry(doc, index);
                    case CharacterGroup.table_of_authority_entry:
                        return new TableOfAuthorityEntry(doc, index);
                    case CharacterGroup.cross_reference_tag:
                        return new CrossReferenceTag(doc, index);
                    case CharacterGroup.begin_marked_text_for_table_of_contents:
                        return new BeginMarkedTextForTableOfContents(doc, index);
                    case CharacterGroup.end_marked_text_for_table_of_contents:
                        return new EndMarkedTextForTableOfContents(doc, index);
                    case CharacterGroup.begin_marked_text_for_list:
                        return new BeginMarkedTextForList(doc, index);
                    case CharacterGroup.end_marked_text_for_list:
                        return new EndMarkedTextForList(doc, index);
                    case CharacterGroup.begin_hidden_text:
                        return new BeginHiddenText(doc, index);
                    case CharacterGroup.end_hidden_text:
                        return new EndHiddenText(doc, index);
                    case CharacterGroup.kerning_on_off:
                        return new Kerning_On_Off(doc, index);
                    case CharacterGroup.block_on_off:
                        return new Block_On_Off(doc, index);
                    case CharacterGroup.color:
                        return new Color(doc, index);
                    case CharacterGroup.character_shading_change:
                        return new CharacterShadingChange(doc, index);
                    case CharacterGroup.bookmark:
                        return new Bookmark(doc, index);                                 // 0x D4 25 (212 37)
                    case CharacterGroup.hypertext_begin_on:     
                        return new HypertextBeginOn(doc, index);                        // 0x D4 34 (212 52)
                    case CharacterGroup.hypertext_begin_off:
                        return new HypertextBeginOff(doc, index);                       // 0x D4 35 (212 53)
                    case CharacterGroup.hypertext_end_on:
                        return new HypertextEndOn(doc, index);                          // 0x D4 36 (212 54)
                    case CharacterGroup.hypertext_end_off:
                        return new HypertextEndOff(doc, index);                         // 0x D4 37 (212 55)


                    default:
                        return new CharacterGroupFunction(doc, index);
                }
            }

            return new CharacterGroupFunction(doc, index); ;
        }
    }
}
