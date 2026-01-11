namespace ACBindings.Internal;

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

    /// <summary>
    /// <code>Offset: 0x006BAB00
    /// bool __thiscall PFileParser::FormatSubNodes(PFileParser*,const PFileNode*,OutputStream*)</code>
    /// </summary>
    public byte FormatSubNodes(ACBindings.Internal.PFileNode* in_, ACBindings.Internal.OutputStream* out_) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PFileParser, ACBindings.Internal.PFileNode*, ACBindings.Internal.OutputStream*, byte>)0x006BAB00)(ref this, in_, out_);

    /// <summary>
    /// <code>Offset: 0x006BAB90
    /// bool __stdcall PFileParser::IsFileBinary(const char**)</code>
    /// </summary>
    public static byte IsFileBinary(sbyte** a1) => ((delegate* unmanaged[Stdcall]<sbyte**, byte>)0x006BAB90)(a1);

    /// <summary>
    /// <code>Offset: 0x006BABF0
    /// unsigned int __thiscall PFileParser::CheckWrapTree(PFileParser*,const PFileNode*,unsigned int,unsigned int)</code>
    /// </summary>
    public uint CheckWrapTree(ACBindings.Internal.PFileNode* node, uint max_chars, uint max_depth) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PFileParser, ACBindings.Internal.PFileNode*, uint, uint, uint>)0x006BABF0)(ref this, node, max_chars, max_depth);

    /// <summary>
    /// <code>Offset: 0x006BAD10
    /// bool __stdcall PFileParser::LoadBinary(PStringBase&lt;char&gt;**,const char**)</code>
    /// </summary>
    public static byte LoadBinary(ACBindings.Internal.PStringBase__sbyte** a1, sbyte** a2) => ((delegate* unmanaged[Stdcall]<ACBindings.Internal.PStringBase__sbyte**, sbyte**, byte>)0x006BAD10)(a1, a2);

    /// <summary>
    /// <code>Offset: 0x006BADE0
    /// void __thiscall PFileParser::MaybeIndent(PFileParser*,OutputStream*)</code>
    /// </summary>
    public void MaybeIndent(ACBindings.Internal.OutputStream* out_) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PFileParser, ACBindings.Internal.OutputStream*, void>)0x006BADE0)(ref this, out_);

    /// <summary>
    /// <code>Offset: 0x006BAE50
    /// char __stdcall PFileParser::PutQuotedString(_DWORD*,int)</code>
    /// </summary>
    public static sbyte PutQuotedString(int* a1, int Source) => ((delegate* unmanaged[Stdcall]<int*, int, sbyte>)0x006BAE50)(a1, Source);

    /// <summary>
    /// <code>Offset: 0x006BB320
    /// void __thiscall PFileParser::NewLine(PFileParser*,OutputStream*)</code>
    /// </summary>
    public void NewLine(ACBindings.Internal.OutputStream* out_) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PFileParser, ACBindings.Internal.OutputStream*, void>)0x006BB320)(ref this, out_);

    /// <summary>
    /// <code>Offset: 0x006BB360
    /// void __thiscall PFileParser::InsertSeparator(PFileParser*,OutputStream*)</code>
    /// </summary>
    public void InsertSeparator(ACBindings.Internal.OutputStream* out_) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PFileParser, ACBindings.Internal.OutputStream*, void>)0x006BB360)(ref this, out_);

    /// <summary>
    /// <code>Offset: 0x006BB3D0
    /// char __thiscall PFileParser::LoadFromFile(int,PStringBase&lt;char&gt;**,const char**,char)</code>
    /// </summary>
    public sbyte LoadFromFile(ACBindings.Internal.PStringBase__sbyte** a2, sbyte** a3, sbyte a4) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PFileParser, ACBindings.Internal.PStringBase__sbyte**, sbyte**, sbyte, sbyte>)0x006BB3D0)(ref this, a2, a3, a4);

    /// <summary>
    /// <code>Offset: 0x006BB420
    /// void __thiscall PFileParser::InsertComments(PFileParser*,const PFileNode*,OutputStream*)</code>
    /// </summary>
    public void InsertComments(ACBindings.Internal.PFileNode* node, ACBindings.Internal.OutputStream* out_) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PFileParser, ACBindings.Internal.PFileNode*, ACBindings.Internal.OutputStream*, void>)0x006BB420)(ref this, node, out_);

    /// <summary>
    /// <code>Offset: 0x006BB5C0
    /// bool __thiscall PFileParser::FormatNode(PFileParser*,const PFileNode*,OutputStream*)</code>
    /// </summary>
    public byte FormatNode(ACBindings.Internal.PFileNode* node, ACBindings.Internal.OutputStream* out_) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PFileParser, ACBindings.Internal.PFileNode*, ACBindings.Internal.OutputStream*, byte>)0x006BB5C0)(ref this, node, out_);

    /// <summary>
    /// <code>Offset: 0x006BB740
    /// bool __thiscall PFileParser::SaveToFile(PFileParser*,PFileNode*,const char**)</code>
    /// </summary>
    public byte SaveToFile(ACBindings.Internal.PFileNode* node, sbyte** a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PFileParser, ACBindings.Internal.PFileNode*, sbyte**, byte>)0x006BB740)(ref this, node, a3);

    /// <summary>
    /// <code>Offset: 0x006BB9C0
    /// void __thiscall PFileParser::PFileParser(PFileParser*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PFileParser, void>)0x006BB9C0)(ref this);

    /// <summary>
    /// <code>Offset: 0x006BBA10
    /// void __thiscall PFileParser::~PFileParser(PFileParser*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PFileParser, void>)0x006BBA10)(ref this);
}

