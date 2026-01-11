namespace ACBindings.Internal;

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

    /// <summary>
    /// <code>Offset: 0x006BB940
    /// void __thiscall NewParser::~NewParser(NewParser*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.NewParser, void>)0x006BB940)(ref this);

    /// <summary>
    /// <code>Offset: 0x006BBCE0
    /// LONG __thiscall NewParser::Init(int,int*,int*)</code>
    /// </summary>
    public int Init(int* a2, int* a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.NewParser, int*, int*, int>)0x006BBCE0)(ref this, a2, a3);

    /// <summary>
    /// <code>Offset: 0x006BBDA0
    /// void __thiscall NewParser::Cleanup(NewParser*)</code>
    /// </summary>
    public void Cleanup() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.NewParser, void>)0x006BBDA0)(ref this);

    /// <summary>
    /// <code>Offset: 0x006BBEE0
    /// bool __thiscall NewParser::ParseComment(NewParser*,bool)</code>
    /// </summary>
    public byte ParseComment(byte eat_newlines) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.NewParser, byte, byte>)0x006BBEE0)(ref this, eat_newlines);

    /// <summary>
    /// <code>Offset: 0x006BC110
    /// bool __thiscall NewParser::ParseNodeName(NewParser*,PFileNode*)</code>
    /// </summary>
    public byte ParseNodeName(ACBindings.Internal.PFileNode* node) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.NewParser, ACBindings.Internal.PFileNode*, byte>)0x006BC110)(ref this, node);

    /// <summary>
    /// <code>Offset: 0x006BC3D0
    /// bool __thiscall NewParser::ParseNode(NewParser*,PFileNode*)</code>
    /// </summary>
    public byte ParseNode(ACBindings.Internal.PFileNode* node) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.NewParser, ACBindings.Internal.PFileNode*, byte>)0x006BC3D0)(ref this, node);

    /// <summary>
    /// <code>Offset: 0x006BC650
    /// bool __thiscall NewParser::ParseNodes(NewParser*,PFileNode*)</code>
    /// </summary>
    public byte ParseNodes(ACBindings.Internal.PFileNode* parent_node) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.NewParser, ACBindings.Internal.PFileNode*, byte>)0x006BC650)(ref this, parent_node);

    /// <summary>
    /// <code>Offset: 0x006BC7E0
    /// int __thiscall NewParser::FindIncludeFiles(int*,char**,_DWORD*)</code>
    /// </summary>
    public int FindIncludeFiles(sbyte** a2, int* a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.NewParser, sbyte**, int*, int>)0x006BC7E0)(ref this, a2, a3);

    /// <summary>
    /// <code>Offset: 0x006BC990
    /// bool __thiscall NewParser::Parse(NewParser*,PFileNode*)</code>
    /// </summary>
    public byte Parse(ACBindings.Internal.PFileNode* node) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.NewParser, ACBindings.Internal.PFileNode*, byte>)0x006BC990)(ref this, node);

    /// <summary>
    /// <code>Offset: 0x006BCA90
    /// char __thiscall NewParser::ParseFile(NewParser*,PFileNode*,int*,_DWORD*,int,double)</code>
    /// </summary>
    public sbyte ParseFile(ACBindings.Internal.PFileNode* node, int* a3, int* a4, int a5, double a6) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.NewParser, ACBindings.Internal.PFileNode*, int*, int*, int, double, sbyte>)0x006BCA90)(ref this, node, a3, a4, a5, a6);

    /// <summary>
    /// <code>Offset: 0x006BCAF0
    /// char __thiscall NewParser::PostProcessNode(int*,PFileNode*,_DWORD*)</code>
    /// </summary>
    public sbyte PostProcessNode(ACBindings.Internal.PFileNode* file_node, int* a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.NewParser, ACBindings.Internal.PFileNode*, int*, sbyte>)0x006BCAF0)(ref this, file_node, a3);
}

