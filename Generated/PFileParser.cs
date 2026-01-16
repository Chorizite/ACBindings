namespace ACBindings.Internal;


/// <summary>Encapsulates the state and configuration required to parse files using a NewParser instance, handling file locks, retry policies, indentation settings, subnode processing, and include expansion.</summary>
public unsafe struct PFileParser : System.IDisposable
{
    // Members
    public ACBindings.Internal.NewParser* new_parser;
    public byte* locked_file;
    public uint num_retries;
    public double retry_delay;
    public uint indentation;
    public byte separate_subnodes;
    public byte first_subnode;
    public byte want_blank;
    public byte m_expandIncludes;

    // Generated Constructor
    public PFileParser() {
        _ConstructorInternal();
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>Formats each child node of the supplied parent node into the provided OutputStream, applying indentation and blank‑line handling as required by the parser’s settings.
    /// <code>Offset: 0x006BAB00
    /// bool __thiscall PFileParser::FormatSubNodes(PFileParser*,const PFileNode*,OutputStream*)</code>
    /// </summary>
    /// <param name="in">The node whose sub‑nodes are to be written; if null no output is produced.</param>
    /// <param name="out">Destination stream for the formatted node data.</param>
    /// <returns>True after processing completes (the function always returns true).</returns>
    public byte FormatSubNodes(ACBindings.Internal.PFileNode* in_, ACBindings.Internal.OutputStream* out_) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PFileParser, ACBindings.Internal.PFileNode*, ACBindings.Internal.OutputStream*, byte>)0x006BAB00)(ref this, in_, out_);

    /// <summary>Determines whether the file referenced by a1 is binary by checking an internal flag preceding the path and comparing the first 16‑bit word of the file to a magic number.
    /// <code>Offset: 0x006BAB90
    /// bool __stdcall PFileParser::IsFileBinary(const char**)</code>
    /// </summary>
    /// <param name="a1">Pointer to a null-terminated string containing the file path.</param>
    /// <returns>True if the file is identified as binary; otherwise, false (including when the file cannot be opened or read).</returns>
    public static byte IsFileBinary(sbyte** a1) => ((delegate* unmanaged[Stdcall]<sbyte**, byte>)0x006BAB90)(a1);

    /// <summary>Recursively calculates the character count needed to represent a node tree within a specified width and depth constraint. Returns the total count if the subtree fits, otherwise returns a value exceeding max_chars (max_chars + 1).
    /// <code>Offset: 0x006BABF0
    /// unsigned int __thiscall PFileParser::CheckWrapTree(PFileParser*,const PFileNode*,unsigned int,unsigned int)</code>
    /// </summary>
    /// <param name="node">Root node whose subtree is evaluated.</param>
    /// <param name="max_chars">Maximum allowed character count for the representation.</param>
    /// <param name="max_depth">Remaining recursion depth; must be greater than zero or the function reports overflow.</param>
    /// <returns>Number of characters required if the tree fits within the limits; otherwise a value larger than max_chars (typically max_chars + 1).</returns>
    public uint CheckWrapTree(ACBindings.Internal.PFileNode* node, uint max_chars, uint max_depth) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PFileParser, ACBindings.Internal.PFileNode*, uint, uint, uint>)0x006BABF0)(ref this, node, max_chars, max_depth);

    /// <summary>Loads a binary representation of a file node and deserializes its contents into the supplied PStringBase instance while initializing internal metadata.
    /// <code>Offset: 0x006BAD10
    /// bool __stdcall PFileParser::LoadBinary(PStringBase&lt;char&gt;**,const char**)</code>
    /// </summary>
    /// <param name="a1">Reference to a PStringBase object that will receive the parsed data.</param>
    /// <param name="a2">Pointer to the path of the binary file to load; reference counts are updated internally.</param>
    /// <returns>True if loading succeeded, otherwise false.</returns>
    public static byte LoadBinary(ACBindings.Internal.PStringBase__sbyte** a1, sbyte** a2) => ((delegate* unmanaged[Stdcall]<ACBindings.Internal.PStringBase__sbyte**, sbyte**, byte>)0x006BAD10)(a1, a2);

    /// <summary>Outputs the appropriate number of indentation characters to the provided stream when separate subnodes are enabled.
    /// <code>Offset: 0x006BADE0
    /// void __thiscall PFileParser::MaybeIndent(PFileParser*,OutputStream*)</code>
    /// </summary>
    /// <param name="out">The destination stream for indentation output; may be a file or string buffer.</param>
    public void MaybeIndent(ACBindings.Internal.OutputStream* out_) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PFileParser, ACBindings.Internal.OutputStream*, void>)0x006BADE0)(ref this, out_);

    /// <summary>Writes the supplied string to an output destination, enclosing it in double quotes and escaping control characters as needed. The method selects buffered or file output based on the context provided.
    /// <code>Offset: 0x006BAE50
    /// char __stdcall PFileParser::PutQuotedString(_DWORD*,int)</code>
    /// </summary>
    /// <param name="a1">Pointer to the source string that is to be quoted.</param>
    /// <param name="Source">Output context specifying whether to write to a buffer or to a file, along with associated flags and pointers.</param>
    /// <returns>Always returns 1 to indicate success.</returns>
    public static sbyte PutQuotedString(int* a1, int Source) => ((delegate* unmanaged[Stdcall]<int*, int, sbyte>)0x006BAE50)(a1, Source);

    /// <summary>Writes a newline character to the specified output stream, handling both file and string destinations.
    /// <code>Offset: 0x006BB320
    /// void __thiscall PFileParser::NewLine(PFileParser*,OutputStream*)</code>
    /// </summary>
    /// <param name="out">The output stream to receive the newline; if configured for string storage, the newline is appended to its internal buffer, otherwise it is written directly to the underlying file.</param>
    public void NewLine(ACBindings.Internal.OutputStream* out_) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PFileParser, ACBindings.Internal.OutputStream*, void>)0x006BB320)(ref this, out_);

    /// <summary>Inserts a separator into the output stream, writing either a space or newline according to the parser’s separate_subnodes flag and whether the stream is saving to a string buffer.
    /// <code>Offset: 0x006BB360
    /// void __thiscall PFileParser::InsertSeparator(PFileParser*,OutputStream*)</code>
    /// </summary>
    /// <param name="out">The destination OutputStream where the separator character will be emitted.</param>
    public void InsertSeparator(ACBindings.Internal.OutputStream* out_) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PFileParser, ACBindings.Internal.OutputStream*, void>)0x006BB360)(ref this, out_);

    /// <summary>Loads a file into the parser, delegating to LoadBinary for binary files and parsing text files into a node tree.
    /// <code>Offset: 0x006BB3D0
    /// char __thiscall PFileParser::LoadFromFile(int,PStringBase&lt;char&gt;**,const char**,char)</code>
    /// </summary>
    /// <param name="a2">Pointer that receives the parsed file node tree.</param>
    /// <param name="a3">File path or array of paths to be loaded.</param>
    /// <param name="a4">Flag indicating whether to use the parser’s internal buffer during parsing; zero selects default behavior.</param>
    /// <returns>Non‑zero on success, zero if loading fails.</returns>
    public sbyte LoadFromFile(ACBindings.Internal.PStringBase__sbyte** a2, sbyte** a3, sbyte a4) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PFileParser, ACBindings.Internal.PStringBase__sbyte**, sbyte**, sbyte, sbyte>)0x006BB3D0)(ref this, a2, a3, a4);

    /// <summary>Writes the comment block associated with a file node to an output stream, prefixing each line with '#' and applying indentation as needed.
    /// <code>Offset: 0x006BB420
    /// void __thiscall PFileParser::InsertComments(PFileParser*,const PFileNode*,OutputStream*)</code>
    /// </summary>
    /// <param name="node">The file node whose comments are to be written; if null no action is taken.</param>
    /// <param name="out">The output stream where formatted comments will be emitted.</param>
    public void InsertComments(ACBindings.Internal.PFileNode* node, ACBindings.Internal.OutputStream* out_) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PFileParser, ACBindings.Internal.PFileNode*, ACBindings.Internal.OutputStream*, void>)0x006BB420)(ref this, node, out_);

    /// <summary>Formats a file node into the supplied output stream, applying indentation, separators, and comments based on parser settings.
    /// <code>Offset: 0x006BB5C0
    /// bool __thiscall PFileParser::FormatNode(PFileParser*,const PFileNode*,OutputStream*)</code>
    /// </summary>
    /// <param name="node">The node to format; if null no output is produced.</param>
    /// <param name="out">Stream where the formatted representation is written.</param>
    /// <returns>True upon completion (always true for successful formatting).</returns>
    public byte FormatNode(ACBindings.Internal.PFileNode* node, ACBindings.Internal.OutputStream* out_) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PFileParser, ACBindings.Internal.PFileNode*, ACBindings.Internal.OutputStream*, byte>)0x006BB5C0)(ref this, node, out_);

    /// <summary>Writes a PFileNode hierarchy to the specified file path, creating any missing directories and retrying if access fails.
    /// <code>Offset: 0x006BB740
    /// bool __thiscall PFileParser::SaveToFile(PFileParser*,PFileNode*,const char**)</code>
    /// </summary>
    /// <param name="node">The root node whose data is serialized to disk.</param>
    /// <param name="a3">Pointer to the null‑terminated string containing the destination file path.</param>
    /// <returns>True when the node is successfully written; otherwise false.</returns>
    public byte SaveToFile(ACBindings.Internal.PFileNode* node, sbyte** a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PFileParser, ACBindings.Internal.PFileNode*, sbyte**, byte>)0x006BB740)(ref this, node, a3);

    /// <summary>Initializes a new PFileParser with default settings, allocating an internal NewParser instance when possible.
    /// <code>Offset: 0x006BB9C0
    /// void __thiscall PFileParser::PFileParser(PFileParser*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PFileParser, void>)0x006BB9C0)(ref this);

    /// <summary>Releases owned resources by closing any open file and freeing the associated NewParser instance.
    /// <code>Offset: 0x006BBA10
    /// void __thiscall PFileParser::~PFileParser(PFileParser*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PFileParser, void>)0x006BBA10)(ref this);
}

