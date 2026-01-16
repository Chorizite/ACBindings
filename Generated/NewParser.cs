namespace ACBindings.Internal;


/// <summary>Handles parsing of input streams, managing include paths, extracting comments, tracking errors, and providing debugging information.</summary>
public unsafe struct NewParser : System.IDisposable
{
    // Members
    public ACBindings.Internal.List___PStringBase__sbyte include_path;
    public byte error;
    public ACBindings.Internal.InputStream in_;
    public ACBindings.Internal.PStringBase__sbyte curr_comment;
    public ACBindings.Internal.PStringBase__sbyte curr_filename;
    public ACBindings.Internal.PFileParser* file_parser;
    public ACBindings.Internal.PStringBase__sbyte m_strDebug;

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>Releases resources held by a NewParser instance, including debug information, current file and comment strings, the input stream, and include path list.
    /// <code>Offset: 0x006BB940
    /// void __thiscall NewParser::~NewParser(NewParser*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.NewParser, void>)0x006BB940)(ref this);

    /// <summary>Initializes or updates the parser's internal state with new values for two integer fields, handling reference counting on previously held objects and resetting any error flag.
    /// <code>Offset: 0x006BBCE0
    /// LONG __thiscall NewParser::Init(int,int*,int*)</code>
    /// </summary>
    /// <param name="a2">Pointer to an int providing the new value for the field at offset 60 within the parser object.</param>
    /// <param name="a3">Pointer to an int providing the new value for the field at offset 68 within the parser object.</param>
    /// <returns>The updated value stored in the second integer field (offset 68), or the original value if it has not changed.</returns>
    public int Init(int* a2, int* a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.NewParser, int*, int*, int>)0x006BBCE0)(ref this, a2, a3);

    /// <summary>Resets the parser’s input stream state and releases owned string buffers, closing any open file when appropriate.
    /// <code>Offset: 0x006BBDA0
    /// void __thiscall NewParser::Cleanup(NewParser*)</code>
    /// </summary>
    public void Cleanup() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.NewParser, void>)0x006BBDA0)(ref this);

    /// <summary>
    /// Parses a comment block from the parser’s input stream. The comment begins with ‘#’, and all subsequent lines are collected into the parser’s curr_comment string until another ‘#’ or end of input is reached. Newline characters may be retained in the resulting text depending on the eat_newlines flag.
    /// 
    /// <code>Offset: 0x006BBEE0
    /// bool __thiscall NewParser::ParseComment(NewParser*,bool)</code>
    /// </summary>
    /// <param name="eat_newlines">If true, newline characters preceding a new comment line are preserved; if false, they are skipped as whitespace.</param>
    /// <returns>True when a comment was successfully parsed (i.e., the first non‑whitespace character was ‘#’); otherwise false.</returns>
    public byte ParseComment(byte eat_newlines) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.NewParser, byte, byte>)0x006BBEE0)(ref this, eat_newlines);

    /// <summary>Parses a node name from the parser's input stream, storing the resulting string in the supplied PFileNode and setting its file position.
    /// <code>Offset: 0x006BC110
    /// bool __thiscall NewParser::ParseNodeName(NewParser*,PFileNode*)</code>
    /// </summary>
    /// <param name="node">The PFileNode to receive the parsed name.</param>
    /// <returns>True if parsing began successfully; false when the input stream is already at end‑of‑file before any characters are read. Errors such as unexpected EOF after a backslash or an unterminated string may be recorded internally but do not affect this return value.</returns>
    public byte ParseNodeName(ACBindings.Internal.PFileNode* node) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.NewParser, ACBindings.Internal.PFileNode*, byte>)0x006BC110)(ref this, node);

    /// <summary>Parses a file node from the parser's input stream, handling whitespace, comments, and nested structures such as parentheses, brackets or braces. Updates the given PFileNode with parsed data.
    /// <code>Offset: 0x006BC3D0
    /// bool __thiscall NewParser::ParseNode(NewParser*,PFileNode*)</code>
    /// </summary>
    /// <param name="node">The PFileNode to populate with parsed information.</param>
    /// <returns>True if the node was successfully parsed; otherwise false when encountering EOF, syntax errors, or mismatched delimiters.</returns>
    public byte ParseNode(ACBindings.Internal.PFileNode* node) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.NewParser, ACBindings.Internal.PFileNode*, byte>)0x006BC3D0)(ref this, node);

    /// <summary>Parses nodes from the parser’s input stream, attaching each parsed node as a child of the supplied parent node. Handles special '!'-prefixed nodes via post‑processing.
    /// <code>Offset: 0x006BC650
    /// bool __thiscall NewParser::ParseNodes(NewParser*,PFileNode*)</code>
    /// </summary>
    /// <param name="parent_node">The node under which parsed subnodes are attached.</param>
    /// <returns>True if parsing completed without setting the parser’s error flag; otherwise false.</returns>
    public byte ParseNodes(ACBindings.Internal.PFileNode* parent_node) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.NewParser, ACBindings.Internal.PFileNode*, byte>)0x006BC650)(ref this, parent_node);

    /// <summary>Collects all files found in the parser's include directories, optionally appending a relative component, and stores their absolute paths in the supplied list.
    /// <code>Offset: 0x006BC7E0
    /// int __thiscall NewParser::FindIncludeFiles(int*,char**,_DWORD*)</code>
    /// </summary>
    /// <param name="a2">Relative path or filename to append to each search directory.</param>
    /// <param name="a3">Output list that will receive the discovered file paths; it is cleared at function start.</param>
    /// <returns>Zero if all directories were searched successfully; a non‑zero value indicates an error during the operation.</returns>
    public int FindIncludeFiles(sbyte** a2, int* a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.NewParser, sbyte**, int*, int>)0x006BC7E0)(ref this, a2, a3);

    /// <summary>Parses the supplied file node, initializing its file information, handling comments, recursively parsing child nodes, and setting an error flag if parsing fails.
    /// <code>Offset: 0x006BC990
    /// bool __thiscall NewParser::Parse(NewParser*,PFileNode*)</code>
    /// </summary>
    /// <param name="node">Root PFileNode to parse.</param>
    /// <returns>True on successful parse; false if an error occurs (e.g., unexpected close brace or internal parser error).</returns>
    public byte Parse(ACBindings.Internal.PFileNode* node) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.NewParser, ACBindings.Internal.PFileNode*, byte>)0x006BC990)(ref this, node);

    /// <summary>Parses a file represented by the specified PFileNode, initializing parser state, configuring the input stream, executing the parse routine, and cleaning up resources.
    /// <code>Offset: 0x006BCA90
    /// char __thiscall NewParser::ParseFile(NewParser*,PFileNode*,int*,_DWORD*,int,double)</code>
    /// </summary>
    /// <param name="node">The root node containing file information to be parsed.</param>
    /// <param name="a3">Pointer to the filename or path string used to open the input stream.</param>
    /// <param name="a4">Additional configuration data for the input stream setup.</param>
    /// <param name="a5">Integer parameter passed to InputStream::SetFile, possibly indicating file size or offset.</param>
    /// <param name="a6">Double parameter passed to InputStream::SetFile, perhaps representing a version or timestamp.</param>
    /// <returns>Non‑zero on successful parsing; zero if the input stream could not be set up or parsing failed.</returns>
    public sbyte ParseFile(ACBindings.Internal.PFileNode* node, int* a3, int* a4, int a5, double a6) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.NewParser, ACBindings.Internal.PFileNode*, int*, int*, int, double, sbyte>)0x006BCA90)(ref this, node, a3, a4, a5, a6);

    /// <summary>Processes a file node by handling include directives, propagating errors and warnings, and appending resulting subnodes to the supplied list.
    /// <code>Offset: 0x006BCAF0
    /// char __thiscall NewParser::PostProcessNode(int*,PFileNode*,_DWORD*)</code>
    /// </summary>
    /// <param name="file_node">The node representing a parsed line or directive to be post‑processed.</param>
    /// <param name="a3">A container where processed child nodes are stored; used as the output list for includes.</param>
    /// <returns>Zero on success; non‑zero if an error occurred during processing.</returns>
    public sbyte PostProcessNode(ACBindings.Internal.PFileNode* file_node, int* a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.NewParser, ACBindings.Internal.PFileNode*, int*, sbyte>)0x006BCAF0)(ref this, file_node, a3);
}

