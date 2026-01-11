namespace ACBindings.Internal;

public unsafe struct PFileNode : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.ReferenceCountTemplate BaseClass_ReferenceCountTemplate; // ACBindings.Internal.ReferenceCountTemplate

    // Child Types
    public unsafe struct PFileNode_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.PFileNode*, void> PFileNode_dtor_0; // function pointer
        public fixed byte gap4[8];
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.PFileNode*, uint, ACBindings.Internal.PFileNode*> GetSubNode; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.PFileNode*, void> SortSubNodes; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.PFileNode*, ACBindings.Internal.Archive*, void> Serialize; // function pointer

        // Methods
    }

    // Members
    public ACBindings.Internal.IFileNodeName* m_pcName;
    public ushort line_number;
    public ushort column_number;
    public ACBindings.Internal.PStringBase__sbyte comment_string;
    public ACBindings.Internal.PStringBase__sbyte m_filename;
    public ACBindings.Internal.SmartArray___PFileNode_ptr sub_nodes;
    public byte m_bProcessed;
    public ACBindings.Internal.IntrusiveSmartPointer___FileNodeFileInfo m_fileInfo;
    public ACBindings.Internal.PFileNode* m_pcParent;
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

    /// <summary>Sets this file node's name to a boolean value, replacing any existing name.
    /// <code>Offset: 0x00423D30
    /// void __thiscall PFileNode::SetNameAsBool(PFileNode*,bool)</code>
    /// </summary>
    /// <param name="i_name">The boolean value to assign as the node’s name.</param>
    public void SetNameAsBool(byte i_name) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PFileNode, byte, void>)0x00423D30)(ref this, i_name);

    /// <summary>Assigns a long double value as the node's name by allocating a new name object and replacing any existing one.
    /// <code>Offset: 0x00425410
    /// void __thiscall PFileNode::SetNameAsDouble(PFileNode*,long double)</code>
    /// </summary>
    /// <param name="i_name">The numeric value to use as the node name.</param>
    public void SetNameAsDouble(double i_name) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PFileNode, double, void>)0x00425410)(ref this, i_name);

    /// <summary>Sets the node’s name to a new value based on the supplied floating‑point number, disposing any previous name.
    /// <code>Offset: 0x00425C50
    /// void __thiscall PFileNode::SetNameAsFloat(PFileNode*,float)</code>
    /// </summary>
    /// <param name="i_name">The numeric value that will become the node’s name.</param>
    public void SetNameAsFloat(float i_name) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PFileNode, float, void>)0x00425C50)(ref this, i_name);

    /// <summary>
    /// Sets the file node’s name to its hexadecimal representation.
    /// 
    /// <code>Offset: 0x00425D00
    /// void __thiscall PFileNode::SetNameAsHex(PFileNode*,unsigned int)</code>
    /// </summary>
    /// <param name="i_name">The unsigned integer value that will be converted to a hexadecimal string and stored as the node's name.</param>
    public void SetNameAsHex(uint i_name) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PFileNode, uint, void>)0x00425D00)(ref this, i_name);

    /// <summary>Retrieves the file node’s name as a floating‑point value when stored in a compatible format.
    /// <code>Offset: 0x00426CB0
    /// bool __thiscall PFileNode::GetNameAsFloat(PFileNode*,float*)</code>
    /// </summary>
    /// <param name="o_name">Receives the parsed float value on success; remains unchanged if conversion fails.</param>
    /// <returns>True if the node’s name could be represented as a float and was written to o_name; otherwise false.</returns>
    public byte GetNameAsFloat(float* o_name) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PFileNode, float*, byte>)0x00426CB0)(ref this, o_name);

    /// <summary>Attempts to retrieve the node's name as a 32‑bit integer, converting or replacing the stored name representation if necessary.
    /// <code>Offset: 0x00426E90
    /// bool __thiscall PFileNode::GetNameAsInt32(PFileNode*,int*)</code>
    /// </summary>
    /// <param name="o_name">Receives the integer value parsed from the node’s name when conversion succeeds.</param>
    /// <returns>True if the name was successfully interpreted as an int; otherwise false.</returns>
    public byte GetNameAsInt32(int* o_name) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PFileNode, int*, byte>)0x00426E90)(ref this, o_name);

    /// <summary>Creates a new child node from supplied data, managing reference counts and invoking cleanup callbacks when the count reaches zero.
    /// <code>Offset: 0x00426F90
    /// _DWORD* __thiscall PFileNode::MakeSubNode(void*,int)</code>
    /// </summary>
    /// <param name="a2">A pointer to context or data that contains reference counting information for the new node.</param>
    /// <returns>A pointer to the newly created sub-node.</returns>
    public int* MakeSubNode(int a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PFileNode, int, int*>)0x00426F90)(ref this, a2);

    /// <summary>Creates a child node under this node, assigns it the name from the supplied PString, and returns the new sub‑node.
    /// <code>Offset: 0x00426FE0
    /// _DWORD* __thiscall PFileNode::MakeSubNodeAsPString(void*,int)</code>
    /// </summary>
    /// <param name="a2">Pointer to a PString containing the desired name for the newly created sub‑node.</param>
    /// <returns>Pointer to the created sub-node, or nullptr if node creation fails.</returns>
    public int* MakeSubNodeAsPString(int a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PFileNode, int, int*>)0x00426FE0)(ref this, a2);

    /// <summary>Replaces the file node's current name with a new PString instance, handling reference counting on the old and new strings.
    /// <code>Offset: 0x00427050
    /// LONG __thiscall PFileNode::SetNameAsPString(_DWORD*,int)</code>
    /// </summary>
    /// <param name="a2">Pointer to a PStringBase object that contains the desired name string.</param>
    /// <returns>The reference count of the previous name after release; zero if the previous name was fully released.</returns>
    public int SetNameAsPString(int a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PFileNode, int, int>)0x00427050)(ref this, a2);

    /// <summary>Attempts to retrieve the node’s name as a long double. If the internal name already holds a double it copies that value; otherwise it converts the current name representation into a double, updates the node’s stored name, and returns success.
    /// <code>Offset: 0x00428100
    /// bool __thiscall PFileNode::GetNameAsDouble(PFileNode*,long double*)</code>
    /// </summary>
    /// <param name="o_name">Receives the converted double value when the operation succeeds.</param>
    /// <returns>True if the name could be represented as a long double; otherwise false.</returns>
    public byte GetNameAsDouble(double* o_name) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PFileNode, double*, byte>)0x00428100)(ref this, o_name);

    /// <summary>
    /// <code>Offset: 0x00444F00
    /// bool __thiscall PFileNode::GetNameAsBinary(PFileNode*,SmartBuffer*)</code>
    /// </summary>
    public byte GetNameAsBinary(ACBindings.Internal.SmartBuffer* o_name) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PFileNode, ACBindings.Internal.SmartBuffer*, byte>)0x00444F00)(ref this, o_name);

    /// <summary>
    /// <code>Offset: 0x00448290
    /// bool __thiscall PFileNode::GetNameAsUInt32(PFileNode*,unsigned int*)</code>
    /// </summary>
    public byte GetNameAsUInt32(uint* o_name) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PFileNode, uint*, byte>)0x00448290)(ref this, o_name);

    /// <summary>
    /// <code>Offset: 0x005B3B50
    /// PFileNode* __thiscall PFileNode::MakeSubNodeAsFloat(PFileNode*,float)</code>
    /// </summary>
    public ACBindings.Internal.PFileNode* MakeSubNodeAsFloat(float i_name) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PFileNode, float, ACBindings.Internal.PFileNode*>)0x005B3B50)(ref this, i_name);

    /// <summary>
    /// <code>Offset: 0x005D8780
    /// bool __thiscall PFileNode::GetSubName(PFileNode*,unsigned int,unsigned int*)</code>
    /// </summary>
    public byte GetSubName(uint i_index, uint* o_retval) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PFileNode, uint, uint*, byte>)0x005D8780)(ref this, i_index, o_retval);

    /// <summary>
    /// <code>Offset: 0x005D87B0
    /// bool __thiscall PFileNode::GetSubName(PFileNode*,unsigned int,float*)</code>
    /// </summary>
    public byte GetSubName(uint i_index, float* o_retval) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PFileNode, uint, float*, byte>)0x005D87B0)(ref this, i_index, o_retval);

    /// <summary>
    /// <code>Offset: 0x0065CA20
    /// FileNodeFileInfo* __thiscall PFileNode::GetFileInfo(PFileNode*)</code>
    /// </summary>
    public ACBindings.Internal.FileNodeFileInfo* GetFileInfo() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PFileNode, ACBindings.Internal.FileNodeFileInfo*>)0x0065CA20)(ref this);

    /// <summary>
    /// <code>Offset: 0x0065CA40
    /// unsigned int __thiscall PFileNode::GetNumSubNodes(PFileNode*)</code>
    /// </summary>
    public uint GetNumSubNodes() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PFileNode, uint>)0x0065CA40)(ref this);

    /// <summary>
    /// <code>Offset: 0x0065CA50
    /// PFileNode* __thiscall PFileNode::GetSubNode(PFileNode*,unsigned int)</code>
    /// </summary>
    public ACBindings.Internal.PFileNode* GetSubNode(uint index) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PFileNode, uint, ACBindings.Internal.PFileNode*>)0x0065CA50)(ref this, index);

    /// <summary>
    /// <code>Offset: 0x0065CA70
    /// const PFileNode* __thiscall PFileNode::GetOnlyChild(PFileNode*)</code>
    /// </summary>
    public ACBindings.Internal.PFileNode* GetOnlyChild() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PFileNode, ACBindings.Internal.PFileNode*>)0x0065CA70)(ref this);

    /// <summary>
    /// <code>Offset: 0x0065CA90
    /// const PFileNode* __thiscall PFileNode::GetLeaf(PFileNode*)</code>
    /// </summary>
    public ACBindings.Internal.PFileNode* GetLeaf() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PFileNode, ACBindings.Internal.PFileNode*>)0x0065CA90)(ref this);

    /// <summary>
    /// <code>Offset: 0x0065CAB0
    /// PFileNode* __thiscall PFileNode::RemoveSubNode(PFileNode*,unsigned int)</code>
    /// </summary>
    public ACBindings.Internal.PFileNode* RemoveSubNode(uint index) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PFileNode, uint, ACBindings.Internal.PFileNode*>)0x0065CAB0)(ref this, index);

    /// <summary>
    /// <code>Offset: 0x0065CE40
    /// bool __thiscall PFileNode::ClearComments(PFileNode*,bool)</code>
    /// </summary>
    public byte ClearComments(byte recursive) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PFileNode, byte, byte>)0x0065CE40)(ref this, recursive);

    /// <summary>
    /// <code>Offset: 0x0065D1A0
    /// void __thiscall PFileNode::PFileNode(PFileNode*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PFileNode, void>)0x0065D1A0)(ref this);

    /// <summary>
    /// <code>Offset: 0x0065D210
    /// void __thiscall PFileNode::Destroy(PFileNode*)</code>
    /// </summary>
    public void Destroy() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PFileNode, void>)0x0065D210)(ref this);

    /// <summary>
    /// <code>Offset: 0x0065D360
    /// bool __thiscall PFileNode::RemoveSubNodePtr(PFileNode*,PFileNode*)</code>
    /// </summary>
    public byte RemoveSubNodePtr(ACBindings.Internal.PFileNode* node) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PFileNode, ACBindings.Internal.PFileNode*, byte>)0x0065D360)(ref this, node);

    /// <summary>
    /// <code>Offset: 0x0065D3F0
    /// void __thiscall PFileNode::InitFileInfo(PStringBase&lt;char&gt;**,int*)</code>
    /// </summary>
    public void InitFileInfo(int* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PFileNode, int*, void>)0x0065D3F0)(ref this, a2);

    /// <summary>
    /// <code>Offset: 0x0065D4D0
    /// void __thiscall PFileNode::~PFileNode(PFileNode*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PFileNode, void>)0x0065D4D0)(ref this);

    /// <summary>
    /// <code>Offset: 0x0065D560
    /// int* __thiscall PFileNode::GetSourceFileName(_DWORD*)</code>
    /// </summary>
    public int* GetSourceFileName() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PFileNode, int*>)0x0065D560)(ref this);

    /// <summary>
    /// <code>Offset: 0x0065D5C0
    /// char __thiscall PFileNode::AddComment(char**,char**)</code>
    /// </summary>
    public sbyte AddComment(sbyte** Source) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PFileNode, sbyte**, sbyte>)0x0065D5C0)(ref this, Source);

    /// <summary>
    /// <code>Offset: 0x0065D7B0
    /// void __thiscall PFileNode::AdoptSubNode(PFileNode*,PFileNode*)</code>
    /// </summary>
    public void AdoptSubNode(ACBindings.Internal.PFileNode* new_subnode) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PFileNode, ACBindings.Internal.PFileNode*, void>)0x0065D7B0)(ref this, new_subnode);

    /// <summary>
    /// <code>Offset: 0x0065D9D0
    /// PFileNode* __thiscall PFileNode::MakeSubNode(PFileNode*)</code>
    /// </summary>
    public ACBindings.Internal.PFileNode* MakeSubNode() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PFileNode, ACBindings.Internal.PFileNode*>)0x0065D9D0)(ref this);

    /// <summary>
    /// <code>Offset: 0x0065DA10
    /// void __thiscall PFileNode::Serialize(PFileNode*,Archive*)</code>
    /// </summary>
    public void Serialize(ACBindings.Internal.Archive* io_archive) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PFileNode, ACBindings.Internal.Archive*, void>)0x0065DA10)(ref this, io_archive);

    /// <summary>
    /// <code>Offset: 0x0065DB60
    /// void __thiscall PFileNode::SortSubNodes(PFileNode*)</code>
    /// </summary>
    public void SortSubNodes() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PFileNode, void>)0x0065DB60)(ref this);

    /// <summary>
    /// <code>Offset: 0x00679170
    /// PFileNode* __thiscall PFileNode::MakeSubNodeAsBool(PFileNode*,bool)</code>
    /// </summary>
    public ACBindings.Internal.PFileNode* MakeSubNodeAsBool(byte i_name) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PFileNode, byte, ACBindings.Internal.PFileNode*>)0x00679170)(ref this, i_name);

    /// <summary>
    /// <code>Offset: 0x0068B390
    /// PFileNode* __thiscall PFileNode::MakeSubNodeAsUInt32(PFileNode*,unsigned int)</code>
    /// </summary>
    public ACBindings.Internal.PFileNode* MakeSubNodeAsUInt32(uint i_name) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PFileNode, uint, ACBindings.Internal.PFileNode*>)0x0068B390)(ref this, i_name);

    /// <summary>
    /// <code>Offset: 0x0068D610
    /// void __thiscall PFileNode::SetNameAsGuid(PFileNode*,Turbine_GUID)</code>
    /// </summary>
    public void SetNameAsGuid(ACBindings.Internal.Turbine_GUID i_name) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PFileNode, ACBindings.Internal.Turbine_GUID, void>)0x0068D610)(ref this, i_name);

    /// <summary>
    /// <code>Offset: 0x0068D670
    /// PFileNode* __thiscall PFileNode::MakeSubNodeAsGuid(PFileNode*,Turbine_GUID)</code>
    /// </summary>
    public ACBindings.Internal.PFileNode* MakeSubNodeAsGuid(ACBindings.Internal.Turbine_GUID i_name) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PFileNode, ACBindings.Internal.Turbine_GUID, ACBindings.Internal.PFileNode*>)0x0068D670)(ref this, i_name);

    /// <summary>
    /// <code>Offset: 0x0068D7A0
    /// PFileNode* __thiscall PFileNode::MakeSubNodeAsHex(PFileNode*,unsigned int)</code>
    /// </summary>
    public ACBindings.Internal.PFileNode* MakeSubNodeAsHex(uint i_name) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PFileNode, uint, ACBindings.Internal.PFileNode*>)0x0068D7A0)(ref this, i_name);

    /// <summary>
    /// <code>Offset: 0x0068DA40
    /// bool __thiscall PFileNode::GetNameAsGuid(PFileNode*,Turbine_GUID*)</code>
    /// </summary>
    public byte GetNameAsGuid(ACBindings.Internal.Turbine_GUID* o_name) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PFileNode, ACBindings.Internal.Turbine_GUID*, byte>)0x0068DA40)(ref this, o_name);

    /// <summary>
    /// <code>Offset: 0x0069B600
    /// PFileNode* __thiscall PFileNode::MakeSubNodeAsInt32(PFileNode*,int)</code>
    /// </summary>
    public ACBindings.Internal.PFileNode* MakeSubNodeAsInt32(int i_name) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PFileNode, int, ACBindings.Internal.PFileNode*>)0x0069B600)(ref this, i_name);

    /// <summary>
    /// <code>Offset: 0x006BBE90
    /// LONG __thiscall PFileNode::SetFileName(_DWORD*,int*)</code>
    /// </summary>
    public int SetFileName(int* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PFileNode, int*, int>)0x006BBE90)(ref this, a2);
}

