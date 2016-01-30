# WP_Reader
Library to parse WordPerfect documents in the WP6x file format.

Models a WordPerfect document in the class WP6Document, which include FileHeader, IndexHeader, IndexArea[] and DocumentArea.
DocumentArea consists of a list of WPTokens called WPStream, which can then be accessed.
WPToken is a class that models every character and function in a WordPerfect document.

Not all functions have been mapped.  There are thousands of functions in the spefification, and I have mapped the ones that I need for my projects.  The remaining unmapped functions are simply named (either with a function name or a function group name).

Functions that have been mapped:

    characters
    default extended international character set
    single-byte functions
    extended character sets (those that have a unicode equivalent)--thanks to libwpd for this data source!
    Fixed length functions
    Variable-length functions:
        EOL group
        Character Group -- a few have been mapped
        Page Group -- a few have been mapped
        Column Group -- a few have been mapped
        Paragraph Group -- a few have been mapped
        Character Group -- a few have been mapped
        Header-Footer group
        Style Group
        Tab Group
    
    
All functions contain the byte representation of the function, plus any relevant information modeled in the appropriate C# type
For example, the bottomMargin function contains a variable number of bytes, which follow a specified pattern.  The "useful" information is actually the number of WordPerfect Units (WPUs) that are set in that function, which in this case is the short bottomMargin.
 
    
