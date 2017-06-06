# WP_Reader
Library to parse WordPerfect documents in the WP6x file format.

Models a WordPerfect document in the class WP6Document, which include `fileHeader`, `indexArea` and `documentArea`.  
`documentArea` consists of a list of `WPTokens` called `WPStream`, which can then be accessed.
`WPToken` is a class that models every character and function in a WordPerfect document.

Not all functions have been fully modeled.  There are hundreds of functions in the specification, and I have not had time to model every one. The remaining unmapped functions are simply named (either with a function name or a function group name).

Functions that have been modeled:

    characters
    default extended international character set
    single-byte functions
    extended character sets (those that have a unicode equivalent)--thanks to libwpd for this data source!
    Fixed length functions
    Variable-length functions:
        EOL group
        Character Group -- about 25 out of 100+ have been mapped
        Page Group -- a few have been mapped
        Column Group -- a few have been mapped
        Paragraph Group -- a few have been mapped
        Header-Footer Group
        Footnote-Endnote Group
        Style Group
        Tab Group
    
    
All functions contain the byte representation of the WP function, plus any relevant information modeled in the appropriate C# type.  
For example, the `bottomMargin` function contains a variable number of bytes, which follow a specified pattern.  The "useful" information is actually the number of WordPerfect Units (WPUs) that are set in that function, which in this case is the `short bottomMargin`.  

WP_Reader is accessible from an outside application by instantiating a WP6Document, which will return the model of the file:

```C#
string url = "whatever/path/file.wpd" //(or .wpt)
WP6Document doc = new WP6Document(url);
```
 
The document being accessed cannot be currently open in WordPerfect (or any other application), because Windows throws a fit when that happens.

The main useful property (for reading a document) in the WP6Document is `documentArea`.  This contains the actual document.  The other properties are accessed by the particular function that stores its data in the IndexArea(s).  For example, the WP function `bookmark` has its useful information stored in one of the IndexAreas as a Prefix Packet.   The C# class `bookmark` in WP_Reader has methods to access and extract this information.

WP_Reader could, theoretically, be used to export the .wpd file type to another file format.  However, there are plenty of existing programs that do just that, including WordPerfect iteself, Microsoft Word and LibreOffice/OpenOffice Write.  The Write application uses the open source C++ [libwpd](http://libwpd.sourceforge.net/) library to translate WordPerfect documents into the odt file format.  That application has mapped nearly every WordPerfect function in the specification and does a very good job at translating the format.  

For more information on how to use the library, go to the WPUniverse [forums](http://www.wpuniverse.com/vb/showthread.php?37525-WP_Reader-A-C-Library-to-Model-a-WordPerfect-File)

ricgaudet@gmail.com

    
