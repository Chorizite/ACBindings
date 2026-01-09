namespace ACBindings;

// NewParser
public unsafe struct NewParser : System.IDisposable
{
    // Members
    public ACBindings.List__PStringBase__sbyte include_path;
    public byte error;
    public ACBindings.InputStream in_;
    public ACBindings.PStringBase__sbyte curr_comment;
    public ACBindings.PStringBase__sbyte curr_filename;
    public ACBindings.PFileParser* file_parser;
    public ACBindings.PStringBase__sbyte m_strDebug;

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods
    // void __thiscall NewParser::~NewParser(NewParser*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.NewParser, void>)0x006BB940)(ref this);
    // LONG __thiscall NewParser::Init(int,int*,int*)
    public int Init(int* a2, int* a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.NewParser, int*, int*, int>)0x006BBCE0)(ref this, a2, a3);
    // void __thiscall NewParser::Cleanup(NewParser*)
    public void Cleanup() => ((delegate* unmanaged[Thiscall]<ref ACBindings.NewParser, void>)0x006BBDA0)(ref this);
    // bool __thiscall NewParser::ParseComment(NewParser*,bool)
    public byte ParseComment(byte eat_newlines) => ((delegate* unmanaged[Thiscall]<ref ACBindings.NewParser, byte, byte>)0x006BBEE0)(ref this, eat_newlines);
    // bool __thiscall NewParser::ParseNodeName(NewParser*,PFileNode*)
    public byte ParseNodeName(ACBindings.PFileNode* node) => ((delegate* unmanaged[Thiscall]<ref ACBindings.NewParser, ACBindings.PFileNode*, byte>)0x006BC110)(ref this, node);
    // bool __thiscall NewParser::ParseNode(NewParser*,PFileNode*)
    public byte ParseNode(ACBindings.PFileNode* node) => ((delegate* unmanaged[Thiscall]<ref ACBindings.NewParser, ACBindings.PFileNode*, byte>)0x006BC3D0)(ref this, node);
    // bool __thiscall NewParser::ParseNodes(NewParser*,PFileNode*)
    public byte ParseNodes(ACBindings.PFileNode* parent_node) => ((delegate* unmanaged[Thiscall]<ref ACBindings.NewParser, ACBindings.PFileNode*, byte>)0x006BC650)(ref this, parent_node);
    // int __thiscall NewParser::FindIncludeFiles(int*,char**,_DWORD*)
    public int FindIncludeFiles(sbyte** a2, int* a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.NewParser, sbyte**, int*, int>)0x006BC7E0)(ref this, a2, a3);
    // bool __thiscall NewParser::Parse(NewParser*,PFileNode*)
    public byte Parse(ACBindings.PFileNode* node) => ((delegate* unmanaged[Thiscall]<ref ACBindings.NewParser, ACBindings.PFileNode*, byte>)0x006BC990)(ref this, node);
    // char __thiscall NewParser::ParseFile(NewParser*,PFileNode*,int*,_DWORD*,int,double)
    public sbyte ParseFile(ACBindings.PFileNode* node, int* a3, int* a4, int a5, double a6) => ((delegate* unmanaged[Thiscall]<ref ACBindings.NewParser, ACBindings.PFileNode*, int*, int*, int, double, sbyte>)0x006BCA90)(ref this, node, a3, a4, a5, a6);
    // char __thiscall NewParser::PostProcessNode(int*,PFileNode*,_DWORD*)
    public sbyte PostProcessNode(ACBindings.PFileNode* file_node, int* a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.NewParser, ACBindings.PFileNode*, int*, sbyte>)0x006BCAF0)(ref this, file_node, a3);
}

