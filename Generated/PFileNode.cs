namespace ACBindings;

// PFileNode
public unsafe struct PFileNode : System.IDisposable
{
    // Base Classes
    public ACBindings.ReferenceCountTemplate BaseClass_ReferenceCountTemplate; // ACBindings.ReferenceCountTemplate

    // Statics
    public static void* s_fallocPool = (void*)0x008F8638;

    // Child Types
    // PFileNode_vtbl
    public unsafe struct PFileNode_vtbl
    {
        // Members
        public System.IntPtr PFileNode_dtor_0; // function pointer
        public fixed byte gap4[8];
        public System.IntPtr GetSubNode; // function pointer
        public System.IntPtr SortSubNodes; // function pointer
        public System.IntPtr Serialize; // function pointer

        // Methods
    }

    // Members
    public ACBindings.IFileNodeName* m_pcName;
    public ushort line_number;
    public ushort column_number;
    public ACBindings.PStringBase__sbyte comment_string;
    public ACBindings.PStringBase__sbyte m_filename;
    public ACBindings.SmartArray__PFileNode_ptr sub_nodes;
    public byte m_bProcessed;
    public ACBindings.IntrusiveSmartPointer__FileNodeFileInfo m_fileInfo;
    public ACBindings.PFileNode* m_pcParent;
    public uint user_data;

    // Generated Constructor
    public PFileNode() {
        _ConstructorInternal();
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods
    // void __thiscall PFileNode::SetNameAsBool(PFileNode*,bool)
    public void SetNameAsBool(byte i_name) => ((delegate* unmanaged[Thiscall]<ref ACBindings.PFileNode, byte, void>)0x00423D30)(ref this, i_name);
    // void __thiscall PFileNode::SetNameAsDouble(PFileNode*,long double)
    public void SetNameAsDouble(double i_name) => ((delegate* unmanaged[Thiscall]<ref ACBindings.PFileNode, double, void>)0x00425410)(ref this, i_name);
    // void __thiscall PFileNode::SetNameAsFloat(PFileNode*,float)
    public void SetNameAsFloat(float i_name) => ((delegate* unmanaged[Thiscall]<ref ACBindings.PFileNode, float, void>)0x00425C50)(ref this, i_name);
    // void __thiscall PFileNode::SetNameAsHex(PFileNode*,unsigned int)
    public void SetNameAsHex(uint i_name) => ((delegate* unmanaged[Thiscall]<ref ACBindings.PFileNode, uint, void>)0x00425D00)(ref this, i_name);
    // bool __thiscall PFileNode::GetNameAsFloat(PFileNode*,float*)
    public byte GetNameAsFloat(float* o_name) => ((delegate* unmanaged[Thiscall]<ref ACBindings.PFileNode, float*, byte>)0x00426CB0)(ref this, o_name);
    // bool __thiscall PFileNode::GetNameAsInt32(PFileNode*,int*)
    public byte GetNameAsInt32(int* o_name) => ((delegate* unmanaged[Thiscall]<ref ACBindings.PFileNode, int*, byte>)0x00426E90)(ref this, o_name);
    // _DWORD* __thiscall PFileNode::MakeSubNode(void*,int)
    public int* MakeSubNode(int a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.PFileNode, int, int*>)0x00426F90)(ref this, a2);
    // _DWORD* __thiscall PFileNode::MakeSubNodeAsPString(void*,int)
    public int* MakeSubNodeAsPString(int a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.PFileNode, int, int*>)0x00426FE0)(ref this, a2);
    // LONG __thiscall PFileNode::SetNameAsPString(_DWORD*,int)
    public int SetNameAsPString(int a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.PFileNode, int, int>)0x00427050)(ref this, a2);
    // bool __thiscall PFileNode::GetNameAsDouble(PFileNode*,long double*)
    public byte GetNameAsDouble(double* o_name) => ((delegate* unmanaged[Thiscall]<ref ACBindings.PFileNode, double*, byte>)0x00428100)(ref this, o_name);
    // bool __thiscall PFileNode::GetNameAsBinary(PFileNode*,SmartBuffer*)
    public byte GetNameAsBinary(ACBindings.SmartBuffer* o_name) => ((delegate* unmanaged[Thiscall]<ref ACBindings.PFileNode, ACBindings.SmartBuffer*, byte>)0x00444F00)(ref this, o_name);
    // bool __thiscall PFileNode::GetNameAsUInt32(PFileNode*,unsigned int*)
    public byte GetNameAsUInt32(uint* o_name) => ((delegate* unmanaged[Thiscall]<ref ACBindings.PFileNode, uint*, byte>)0x00448290)(ref this, o_name);
    // PFileNode* __thiscall PFileNode::MakeSubNodeAsFloat(PFileNode*,float)
    public ACBindings.PFileNode* MakeSubNodeAsFloat(float i_name) => ((delegate* unmanaged[Thiscall]<ref ACBindings.PFileNode, float, ACBindings.PFileNode*>)0x005B3B50)(ref this, i_name);
    // bool __thiscall PFileNode::GetSubName(PFileNode*,unsigned int,unsigned int*)
    public byte GetSubName(uint i_index, uint* o_retval) => ((delegate* unmanaged[Thiscall]<ref ACBindings.PFileNode, uint, uint*, byte>)0x005D8780)(ref this, i_index, o_retval);
    // bool __thiscall PFileNode::GetSubName(PFileNode*,unsigned int,float*)
    public byte GetSubName(uint i_index, float* o_retval) => ((delegate* unmanaged[Thiscall]<ref ACBindings.PFileNode, uint, float*, byte>)0x005D87B0)(ref this, i_index, o_retval);
    // FileNodeFileInfo* __thiscall PFileNode::GetFileInfo(PFileNode*)
    public ACBindings.FileNodeFileInfo* GetFileInfo() => ((delegate* unmanaged[Thiscall]<ref ACBindings.PFileNode, ACBindings.FileNodeFileInfo*>)0x0065CA20)(ref this);
    // unsigned int __thiscall PFileNode::GetNumSubNodes(PFileNode*)
    public uint GetNumSubNodes() => ((delegate* unmanaged[Thiscall]<ref ACBindings.PFileNode, uint>)0x0065CA40)(ref this);
    // PFileNode* __thiscall PFileNode::GetSubNode(PFileNode*,unsigned int)
    public ACBindings.PFileNode* GetSubNode(uint index) => ((delegate* unmanaged[Thiscall]<ref ACBindings.PFileNode, uint, ACBindings.PFileNode*>)0x0065CA50)(ref this, index);
    // const PFileNode* __thiscall PFileNode::GetOnlyChild(PFileNode*)
    public ACBindings.PFileNode* GetOnlyChild() => ((delegate* unmanaged[Thiscall]<ref ACBindings.PFileNode, ACBindings.PFileNode*>)0x0065CA70)(ref this);
    // const PFileNode* __thiscall PFileNode::GetLeaf(PFileNode*)
    public ACBindings.PFileNode* GetLeaf() => ((delegate* unmanaged[Thiscall]<ref ACBindings.PFileNode, ACBindings.PFileNode*>)0x0065CA90)(ref this);
    // PFileNode* __thiscall PFileNode::RemoveSubNode(PFileNode*,unsigned int)
    public ACBindings.PFileNode* RemoveSubNode(uint index) => ((delegate* unmanaged[Thiscall]<ref ACBindings.PFileNode, uint, ACBindings.PFileNode*>)0x0065CAB0)(ref this, index);
    // bool __thiscall PFileNode::ClearComments(PFileNode*,bool)
    public byte ClearComments(byte recursive) => ((delegate* unmanaged[Thiscall]<ref ACBindings.PFileNode, byte, byte>)0x0065CE40)(ref this, recursive);
    // void __thiscall PFileNode::PFileNode(PFileNode*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.PFileNode, void>)0x0065D1A0)(ref this);
    // void __thiscall PFileNode::Destroy(PFileNode*)
    public void Destroy() => ((delegate* unmanaged[Thiscall]<ref ACBindings.PFileNode, void>)0x0065D210)(ref this);
    // bool __thiscall PFileNode::RemoveSubNodePtr(PFileNode*,PFileNode*)
    public byte RemoveSubNodePtr(ACBindings.PFileNode* node) => ((delegate* unmanaged[Thiscall]<ref ACBindings.PFileNode, ACBindings.PFileNode*, byte>)0x0065D360)(ref this, node);
    // void __thiscall PFileNode::InitFileInfo(PStringBase<char>**,int*)
    public void InitFileInfo(int* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.PFileNode, int*, void>)0x0065D3F0)(ref this, a2);
    // void __thiscall PFileNode::~PFileNode(PFileNode*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.PFileNode, void>)0x0065D4D0)(ref this);
    // int* __thiscall PFileNode::GetSourceFileName(_DWORD*)
    public int* GetSourceFileName() => ((delegate* unmanaged[Thiscall]<ref ACBindings.PFileNode, int*>)0x0065D560)(ref this);
    // char __thiscall PFileNode::AddComment(char**,char**)
    public sbyte AddComment(sbyte** Source) => ((delegate* unmanaged[Thiscall]<ref ACBindings.PFileNode, sbyte**, sbyte>)0x0065D5C0)(ref this, Source);
    // void __thiscall PFileNode::AdoptSubNode(PFileNode*,PFileNode*)
    public void AdoptSubNode(ACBindings.PFileNode* new_subnode) => ((delegate* unmanaged[Thiscall]<ref ACBindings.PFileNode, ACBindings.PFileNode*, void>)0x0065D7B0)(ref this, new_subnode);
    // PFileNode* __thiscall PFileNode::MakeSubNode(PFileNode*)
    public ACBindings.PFileNode* MakeSubNode() => ((delegate* unmanaged[Thiscall]<ref ACBindings.PFileNode, ACBindings.PFileNode*>)0x0065D9D0)(ref this);
    // void __thiscall PFileNode::Serialize(PFileNode*,Archive*)
    public void Serialize(ACBindings.Archive* io_archive) => ((delegate* unmanaged[Thiscall]<ref ACBindings.PFileNode, ACBindings.Archive*, void>)0x0065DA10)(ref this, io_archive);
    // void __thiscall PFileNode::SortSubNodes(PFileNode*)
    public void SortSubNodes() => ((delegate* unmanaged[Thiscall]<ref ACBindings.PFileNode, void>)0x0065DB60)(ref this);
    // PFileNode* __thiscall PFileNode::MakeSubNodeAsBool(PFileNode*,bool)
    public ACBindings.PFileNode* MakeSubNodeAsBool(byte i_name) => ((delegate* unmanaged[Thiscall]<ref ACBindings.PFileNode, byte, ACBindings.PFileNode*>)0x00679170)(ref this, i_name);
    // PFileNode* __thiscall PFileNode::MakeSubNodeAsUInt32(PFileNode*,unsigned int)
    public ACBindings.PFileNode* MakeSubNodeAsUInt32(uint i_name) => ((delegate* unmanaged[Thiscall]<ref ACBindings.PFileNode, uint, ACBindings.PFileNode*>)0x0068B390)(ref this, i_name);
    // void __thiscall PFileNode::SetNameAsGuid(PFileNode*,Turbine_GUID)
    public void SetNameAsGuid(ACBindings.Turbine_GUID i_name) => ((delegate* unmanaged[Thiscall]<ref ACBindings.PFileNode, ACBindings.Turbine_GUID, void>)0x0068D610)(ref this, i_name);
    // PFileNode* __thiscall PFileNode::MakeSubNodeAsGuid(PFileNode*,Turbine_GUID)
    public ACBindings.PFileNode* MakeSubNodeAsGuid(ACBindings.Turbine_GUID i_name) => ((delegate* unmanaged[Thiscall]<ref ACBindings.PFileNode, ACBindings.Turbine_GUID, ACBindings.PFileNode*>)0x0068D670)(ref this, i_name);
    // PFileNode* __thiscall PFileNode::MakeSubNodeAsHex(PFileNode*,unsigned int)
    public ACBindings.PFileNode* MakeSubNodeAsHex(uint i_name) => ((delegate* unmanaged[Thiscall]<ref ACBindings.PFileNode, uint, ACBindings.PFileNode*>)0x0068D7A0)(ref this, i_name);
    // bool __thiscall PFileNode::GetNameAsGuid(PFileNode*,Turbine_GUID*)
    public byte GetNameAsGuid(ACBindings.Turbine_GUID* o_name) => ((delegate* unmanaged[Thiscall]<ref ACBindings.PFileNode, ACBindings.Turbine_GUID*, byte>)0x0068DA40)(ref this, o_name);
    // PFileNode* __thiscall PFileNode::MakeSubNodeAsInt32(PFileNode*,int)
    public ACBindings.PFileNode* MakeSubNodeAsInt32(int i_name) => ((delegate* unmanaged[Thiscall]<ref ACBindings.PFileNode, int, ACBindings.PFileNode*>)0x0069B600)(ref this, i_name);
    // LONG __thiscall PFileNode::SetFileName(_DWORD*,int*)
    public int SetFileName(int* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.PFileNode, int*, int>)0x006BBE90)(ref this, a2);
}

