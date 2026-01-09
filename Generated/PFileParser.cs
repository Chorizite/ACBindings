namespace ACBindings;

// PFileParser
public unsafe struct PFileParser : System.IDisposable
{
    // Members
    public ACBindings.NewParser* new_parser;
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
    // bool __thiscall PFileParser::FormatSubNodes(PFileParser*,const PFileNode*,OutputStream*)
    public byte FormatSubNodes(ACBindings.PFileNode* in_, ACBindings.OutputStream* out_) => ((delegate* unmanaged[Thiscall]<ref ACBindings.PFileParser, ACBindings.PFileNode*, ACBindings.OutputStream*, byte>)0x006BAB00)(ref this, in_, out_);
    // bool __stdcall PFileParser::IsFileBinary(const char**)
    public static byte IsFileBinary(sbyte** a1) => ((delegate* unmanaged[Stdcall]<sbyte**, byte>)0x006BAB90)(a1);
    // unsigned int __thiscall PFileParser::CheckWrapTree(PFileParser*,const PFileNode*,unsigned int,unsigned int)
    public uint CheckWrapTree(ACBindings.PFileNode* node, uint max_chars, uint max_depth) => ((delegate* unmanaged[Thiscall]<ref ACBindings.PFileParser, ACBindings.PFileNode*, uint, uint, uint>)0x006BABF0)(ref this, node, max_chars, max_depth);
    // bool __stdcall PFileParser::LoadBinary(PStringBase<char>**,const char**)
    public static byte LoadBinary(ACBindings.PStringBase__sbyte** a1, sbyte** a2) => ((delegate* unmanaged[Stdcall]<ACBindings.PStringBase__sbyte**, sbyte**, byte>)0x006BAD10)(a1, a2);
    // void __thiscall PFileParser::MaybeIndent(PFileParser*,OutputStream*)
    public void MaybeIndent(ACBindings.OutputStream* out_) => ((delegate* unmanaged[Thiscall]<ref ACBindings.PFileParser, ACBindings.OutputStream*, void>)0x006BADE0)(ref this, out_);
    // char __stdcall PFileParser::PutQuotedString(_DWORD*,int)
    public static sbyte PutQuotedString(int* a1, int Source) => ((delegate* unmanaged[Stdcall]<int*, int, sbyte>)0x006BAE50)(a1, Source);
    // void __thiscall PFileParser::NewLine(PFileParser*,OutputStream*)
    public void NewLine(ACBindings.OutputStream* out_) => ((delegate* unmanaged[Thiscall]<ref ACBindings.PFileParser, ACBindings.OutputStream*, void>)0x006BB320)(ref this, out_);
    // void __thiscall PFileParser::InsertSeparator(PFileParser*,OutputStream*)
    public void InsertSeparator(ACBindings.OutputStream* out_) => ((delegate* unmanaged[Thiscall]<ref ACBindings.PFileParser, ACBindings.OutputStream*, void>)0x006BB360)(ref this, out_);
    // char __thiscall PFileParser::LoadFromFile(int,PStringBase<char>**,const char**,char)
    public sbyte LoadFromFile(ACBindings.PStringBase__sbyte** a2, sbyte** a3, sbyte a4) => ((delegate* unmanaged[Thiscall]<ref ACBindings.PFileParser, ACBindings.PStringBase__sbyte**, sbyte**, sbyte, sbyte>)0x006BB3D0)(ref this, a2, a3, a4);
    // void __thiscall PFileParser::InsertComments(PFileParser*,const PFileNode*,OutputStream*)
    public void InsertComments(ACBindings.PFileNode* node, ACBindings.OutputStream* out_) => ((delegate* unmanaged[Thiscall]<ref ACBindings.PFileParser, ACBindings.PFileNode*, ACBindings.OutputStream*, void>)0x006BB420)(ref this, node, out_);
    // bool __thiscall PFileParser::FormatNode(PFileParser*,const PFileNode*,OutputStream*)
    public byte FormatNode(ACBindings.PFileNode* node, ACBindings.OutputStream* out_) => ((delegate* unmanaged[Thiscall]<ref ACBindings.PFileParser, ACBindings.PFileNode*, ACBindings.OutputStream*, byte>)0x006BB5C0)(ref this, node, out_);
    // bool __thiscall PFileParser::SaveToFile(PFileParser*,PFileNode*,const char**)
    public byte SaveToFile(ACBindings.PFileNode* node, sbyte** a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.PFileParser, ACBindings.PFileNode*, sbyte**, byte>)0x006BB740)(ref this, node, a3);
    // void __thiscall PFileParser::PFileParser(PFileParser*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.PFileParser, void>)0x006BB9C0)(ref this);
    // void __thiscall PFileParser::~PFileParser(PFileParser*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.PFileParser, void>)0x006BBA10)(ref this);
}

