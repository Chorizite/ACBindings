namespace ACBindings.Internal;


/// <summary>Represents an individual node within a parsed file structure, storing metadata such as the node's name, source location, comments, and child nodes for hierarchical representation.</summary>
public unsafe struct PFileNode : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.ReferenceCountTemplate BaseClass_ReferenceCountTemplate; // ACBindings.Internal.ReferenceCountTemplate

    // Statics
    //public static ACBindings.Internal.FallocPool* s_fallocPool = (ACBindings.Internal.FallocPool*)0x008F8624;

    // Child Types
    public unsafe struct PFileNode_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.PFileNode*, void> PFileNode_dtor_0; // function pointer
        public fixed byte gap4[8];
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.PFileNode*, uint, ACBindings.Internal.PFileNode*> GetSubNode; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.PFileNode*, void> SortSubNodes; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.PFileNode*, ACBindings.Internal.Archive*, void> Serialize; // function pointer

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
    /// Converts the file node's name into binary form, storing it in the provided SmartBuffer. If the name is already binary, the buffer is set directly; otherwise a new FileNodeName_Binary instance is created and stored.
    /// Returns true on success or false if the node has no name or conversion fails.
    /// 
    /// <code>Offset: 0x00444F00
    /// bool __thiscall PFileNode::GetNameAsBinary(PFileNode*,SmartBuffer*)</code>
    /// </summary>
    /// <param name="o_name">Output buffer receiving the binary representation of the node's name.</param>
    /// <returns>True if conversion succeeded; otherwise, false.</returns>
    public byte GetNameAsBinary(ACBindings.Internal.SmartBuffer* o_name) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PFileNode, ACBindings.Internal.SmartBuffer*, byte>)0x00444F00)(ref this, o_name);

    /// <summary>Attempts to retrieve the node's name as a 32‑bit unsigned integer. If the stored name is already an integer or can be converted, writes the value into o_name and returns true; otherwise leaves the name unchanged and returns false.
    /// <code>Offset: 0x00448290
    /// bool __thiscall PFileNode::GetNameAsUInt32(PFileNode*,unsigned int*)</code>
    /// </summary>
    /// <param name="o_name">Receives the numeric name when conversion succeeds.</param>
    /// <returns>True if the name could be represented as a uint32; otherwise false.</returns>
    public byte GetNameAsUInt32(uint* o_name) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PFileNode, uint*, byte>)0x00448290)(ref this, o_name);

    /// <summary>Creates a child node and sets its name to the floating‑point value supplied.
    /// <code>Offset: 0x005B3B50
    /// PFileNode* __thiscall PFileNode::MakeSubNodeAsFloat(PFileNode*,float)</code>
    /// </summary>
    /// <param name="i_name">The float value that becomes the node's name.</param>
    /// <returns>A pointer to the newly created sub-node, or null if creation fails.</returns>
    public ACBindings.Internal.PFileNode* MakeSubNodeAsFloat(float i_name) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PFileNode, float, ACBindings.Internal.PFileNode*>)0x005B3B50)(ref this, i_name);

    /// <summary>Retrieves the numeric identifier of a subnode at a specified index.
    /// <code>Offset: 0x005D8780
    /// bool __thiscall PFileNode::GetSubName(PFileNode*,unsigned int,unsigned int*)</code>
    /// </summary>
    /// <param name="i_index">Zero‑based position of the desired child node within the current node’s children list.</param>
    /// <param name="o_retval">Pointer to receive the unsigned integer representation of the child node’s name.</param>
    /// <returns>True if a child exists at the given index and its name was successfully obtained; otherwise false.</returns>
    public byte GetSubName(uint i_index, uint* o_retval) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PFileNode, uint, uint*, byte>)0x005D8780)(ref this, i_index, o_retval);

    /// <summary>Retrieves the name of the i-th sub-node as a floating‑point value and stores it in o_retval.
    /// <code>Offset: 0x005D87B0
    /// bool __thiscall PFileNode::GetSubName(PFileNode*,unsigned int,float*)</code>
    /// </summary>
    /// <param name="i_index">Index of the child node whose name will be parsed.</param>
    /// <param name="o_retval">Pointer to receive the parsed float value; must not be null.</param>
    /// <returns>True if the sub-node exists and its name can be converted to a float; otherwise, false.</returns>
    public byte GetSubName(uint i_index, float* o_retval) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PFileNode, uint, float*, byte>)0x005D87B0)(ref this, i_index, o_retval);

    /// <summary>Traverses upward from the current node to the root of the hierarchy and returns the associated <c>FileNodeFileInfo</c> instance.
    /// <code>Offset: 0x0065CA20
    /// FileNodeFileInfo* __thiscall PFileNode::GetFileInfo(PFileNode*)</code>
    /// </summary>
    /// <returns>A pointer to the <c>FileNodeFileInfo</c> object belonging to the topmost file node, or null if none is set.</returns>
    public ACBindings.Internal.FileNodeFileInfo* GetFileInfo() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PFileNode, ACBindings.Internal.FileNodeFileInfo*>)0x0065CA20)(ref this);

    /// <summary>Returns the number of child nodes attached to this PFileNode.
    /// <code>Offset: 0x0065CA40
    /// unsigned int __thiscall PFileNode::GetNumSubNodes(PFileNode*)</code>
    /// </summary>
    /// <returns>The count of sub‑nodes.</returns>
    public uint GetNumSubNodes() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PFileNode, uint>)0x0065CA40)(ref this);

    /// <summary>Retrieves a child node at the specified index, returning nullptr when the index is out of bounds.
    /// <code>Offset: 0x0065CA50
    /// PFileNode* __thiscall PFileNode::GetSubNode(PFileNode*,unsigned int)</code>
    /// </summary>
    /// <param name="index">Zero-based position within the node's sub‑node list.</param>
    /// <returns>Pointer to the requested sub-node or nullptr if the index exceeds the count.</returns>
    public ACBindings.Internal.PFileNode* GetSubNode(uint index) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PFileNode, uint, ACBindings.Internal.PFileNode*>)0x0065CA50)(ref this, index);

    /// <summary>Returns a pointer to the only child node of this file node, or nullptr when the node has zero or multiple children.
    /// <code>Offset: 0x0065CA70
    /// const PFileNode* __thiscall PFileNode::GetOnlyChild(PFileNode*)</code>
    /// </summary>
    /// <returns>A const pointer to the sole child node if present; otherwise nullptr.</returns>
    public ACBindings.Internal.PFileNode* GetOnlyChild() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PFileNode, ACBindings.Internal.PFileNode*>)0x0065CA70)(ref this);

    /// <summary>Returns the sole child of this node when it exists and is a leaf, otherwise returns null.
    /// <code>Offset: 0x0065CA90
    /// const PFileNode* __thiscall PFileNode::GetLeaf(PFileNode*)</code>
    /// </summary>
    /// <returns>The child node that has no descendants; null if there are zero or multiple children, or the single child itself has subnodes.</returns>
    public ACBindings.Internal.PFileNode* GetLeaf() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PFileNode, ACBindings.Internal.PFileNode*>)0x0065CA90)(ref this);

    /// <summary>Removes the child node at the given index from this node’s sub‑nodes collection, detaches it by clearing its parent pointer, and returns the removed node; returns nullptr when the index is out of bounds.
    /// <code>Offset: 0x0065CAB0
    /// PFileNode* __thiscall PFileNode::RemoveSubNode(PFileNode*,unsigned int)</code>
    /// </summary>
    /// <param name="index">Zero‑based position of the child to remove within the current node’s sub_nodes array.</param>
    /// <returns>The removed PFileNode if the index was valid, otherwise null.</returns>
    public ACBindings.Internal.PFileNode* RemoveSubNode(uint index) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PFileNode, uint, ACBindings.Internal.PFileNode*>)0x0065CAB0)(ref this, index);

    /// <summary>Clears the comment associated with a file node, optionally propagating to child nodes.
    /// <code>Offset: 0x0065CE40
    /// bool __thiscall PFileNode::ClearComments(PFileNode*,bool)</code>
    /// </summary>
    /// <param name="recursive">When true, clears comments on all descendant sub-nodes recursively.</param>
    /// <returns>True if every comment was successfully cleared; otherwise false.</returns>
    public byte ClearComments(byte recursive) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PFileNode, byte, byte>)0x0065CE40)(ref this, recursive);

    /// <summary>Initializes a new file node with default values, setting the reference count to one, clearing name and parent pointers, zeroing line and column numbers, assigning null buffers for comment and filename while incrementing their reference counts, preparing an empty list of child nodes, marking the node as unprocessed, resetting associated file information and user data.
    /// <code>Offset: 0x0065D1A0
    /// void __thiscall PFileNode::PFileNode(PFileNode*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PFileNode, void>)0x0065D1A0)(ref this);

    /// <summary>Releases resources held by a file node, clearing its name, sub‑nodes, comment and filename strings, and decrementing reference counts on associated objects before resetting internal state.
    /// <code>Offset: 0x0065D210
    /// void __thiscall PFileNode::Destroy(PFileNode*)</code>
    /// </summary>
    public void Destroy() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PFileNode, void>)0x0065D210)(ref this);

    /// <summary>Removes the specified sub-node from the current file node's child list if present.
    /// <code>Offset: 0x0065D360
    /// bool __thiscall PFileNode::RemoveSubNodePtr(PFileNode*,PFileNode*)</code>
    /// </summary>
    /// <param name="node">The sub-node to be removed.</param>
    /// <returns>True when the sub-node is found and removed; otherwise, false.</returns>
    public byte RemoveSubNodePtr(ACBindings.Internal.PFileNode* node) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PFileNode, ACBindings.Internal.PFileNode*, byte>)0x0065D360)(ref this, node);

    /// <summary>Initializes or updates the file information for this node, ensuring a FileNodeFileInfo object exists and its identifier matches the supplied value.
    /// <code>Offset: 0x0065D3F0
    /// void __thiscall PFileNode::InitFileInfo(PStringBase&lt;char&gt;**,int*)</code>
    /// </summary>
    /// <param name="a2">Pointer to an integer containing the desired file‑information identifier. The function reads the value pointed to by this argument.</param>
    public void InitFileInfo(int* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PFileNode, int*, void>)0x0065D3F0)(ref this, a2);

    /// <summary>Releases resources owned by a PFileNode instance, decrementing reference counts for its file information and string buffers, freeing the sub-node array when appropriate, and resetting internal state for reuse.
    /// <code>Offset: 0x0065D4D0
    /// void __thiscall PFileNode::~PFileNode(PFileNode*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PFileNode, void>)0x0065D4D0)(ref this);

    /// <summary>Retrieves the source file name associated with this PFileNode. If a parent node exists, its file information is used; otherwise the node’s own file data is consulted. When no file information is available, a static &quot;&lt;unknown&gt;&quot; string is returned.
    /// <code>Offset: 0x0065D560
    /// int* __thiscall PFileNode::GetSourceFileName(_DWORD*)</code>
    /// </summary>
    /// <returns>A pointer to the character array containing the source file name or a reference to the global &quot;&lt;unknown&gt;&quot; placeholder when no file info exists.</returns>
    public int* GetSourceFileName() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PFileNode, int*>)0x0065D560)(ref this);

    /// <summary>Adds the supplied comment text to this node's internal buffer, appending all characters except the last one and ensuring a newline terminator is present.
    /// <code>Offset: 0x0065D5C0
    /// char __thiscall PFileNode::AddComment(char**,char**)</code>
    /// </summary>
    /// <param name="Source">Pointer to the source string containing the comment to append.</param>
    /// <returns>Always returns 1 to indicate success.</returns>
    public sbyte AddComment(sbyte** Source) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PFileNode, sbyte**, sbyte>)0x0065D5C0)(ref this, Source);

    /// <summary>Adopts the specified node as a child of this node, inserting it into the internal array and updating its parent reference.
    /// <code>Offset: 0x0065D7B0
    /// void __thiscall PFileNode::AdoptSubNode(PFileNode*,PFileNode*)</code>
    /// </summary>
    /// <param name="new_subnode">The node to be adopted as a child.</param>
    public void AdoptSubNode(ACBindings.Internal.PFileNode* new_subnode) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PFileNode, ACBindings.Internal.PFileNode*, void>)0x0065D7B0)(ref this, new_subnode);

    /// <summary>Creates a new child node from the internal allocation pool and attaches it to the current node.
    /// <code>Offset: 0x0065D9D0
    /// PFileNode* __thiscall PFileNode::MakeSubNode(PFileNode*)</code>
    /// </summary>
    /// <returns>A pointer to the newly created sub-node, which becomes a child of the caller.</returns>
    public ACBindings.Internal.PFileNode* MakeSubNode() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PFileNode, ACBindings.Internal.PFileNode*>)0x0065D9D0)(ref this);

    /// <summary>Serializes or deserializes a file node’s name and child nodes using the provided Archive, setting parent references appropriately.
    /// <code>Offset: 0x0065DA10
    /// void __thiscall PFileNode::Serialize(PFileNode*,Archive*)</code>
    /// </summary>
    /// <param name="io_archive">Archive instance that dictates whether to read from or write to the node data.</param>
    public void Serialize(ACBindings.Internal.Archive* io_archive) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PFileNode, ACBindings.Internal.Archive*, void>)0x0065DA10)(ref this, io_archive);

    /// <summary>Sorts this file node’s child nodes using the custom comparator PFileNodeSorter, arranging them in a defined order.
    /// <code>Offset: 0x0065DB60
    /// void __thiscall PFileNode::SortSubNodes(PFileNode*)</code>
    /// </summary>
    public void SortSubNodes() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PFileNode, void>)0x0065DB60)(ref this);

    /// <summary>Creates a child file node whose name represents the specified boolean value.
    /// <code>Offset: 0x00679170
    /// PFileNode* __thiscall PFileNode::MakeSubNodeAsBool(PFileNode*,bool)</code>
    /// </summary>
    /// <param name="i_name">The boolean value that becomes the node's name.</param>
    /// <returns>A pointer to the new sub-node, or nullptr if node creation failed.</returns>
    public ACBindings.Internal.PFileNode* MakeSubNodeAsBool(byte i_name) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PFileNode, byte, ACBindings.Internal.PFileNode*>)0x00679170)(ref this, i_name);

    /// <summary>Creates a new child node from this node and assigns it an unsigned 32‑bit name containing the supplied value.
    /// <code>Offset: 0x0068B390
    /// PFileNode* __thiscall PFileNode::MakeSubNodeAsUInt32(PFileNode*,unsigned int)</code>
    /// </summary>
    /// <param name="i_name">The unsigned integer to use as the child’s name.</param>
    /// <returns>A pointer to the newly created subnode, or null if creation fails.</returns>
    public ACBindings.Internal.PFileNode* MakeSubNodeAsUInt32(uint i_name) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PFileNode, uint, ACBindings.Internal.PFileNode*>)0x0068B390)(ref this, i_name);

    /// <summary>Assigns a new GUID-based name to the file node, replacing any existing name.
    /// <code>Offset: 0x0068D610
    /// void __thiscall PFileNode::SetNameAsGuid(PFileNode*,Turbine_GUID)</code>
    /// </summary>
    /// <param name="i_name">The GUID that will become the node’s identifier.</param>
    public void SetNameAsGuid(ACBindings.Internal.Turbine_GUID i_name) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PFileNode, ACBindings.Internal.Turbine_GUID, void>)0x0068D610)(ref this, i_name);

    /// <summary>Creates a child node under the current file node, assigning it the supplied GUID as its name.
    /// <code>Offset: 0x0068D670
    /// PFileNode* __thiscall PFileNode::MakeSubNodeAsGuid(PFileNode*,Turbine_GUID)</code>
    /// </summary>
    /// <param name="i_name">The GUID to use for naming the new sub‑node.</param>
    /// <returns>A pointer to the newly created sub‑node, or null if creation fails.</returns>
    public ACBindings.Internal.PFileNode* MakeSubNodeAsGuid(ACBindings.Internal.Turbine_GUID i_name) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PFileNode, ACBindings.Internal.Turbine_GUID, ACBindings.Internal.PFileNode*>)0x0068D670)(ref this, i_name);

    /// <summary>Creates a child node under the current file node and assigns it a hexadecimal name derived from the supplied integer.
    /// <code>Offset: 0x0068D7A0
    /// PFileNode* __thiscall PFileNode::MakeSubNodeAsHex(PFileNode*,unsigned int)</code>
    /// </summary>
    /// <param name="i_name">The unsigned integer to be converted to a hex string for the new node's name.</param>
    /// <returns>A pointer to the newly created subnode, or null if creation fails.</returns>
    public ACBindings.Internal.PFileNode* MakeSubNodeAsHex(uint i_name) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PFileNode, uint, ACBindings.Internal.PFileNode*>)0x0068D7A0)(ref this, i_name);

    /// <summary>
    /// Retrieves the file node’s name as a GUID, converting from string if necessary. If the current name is already a Guid type, copies it to the supplied buffer; otherwise attempts to construct a new Guid name and replaces the stored name.
    /// 
    /// <code>Offset: 0x0068DA40
    /// bool __thiscall PFileNode::GetNameAsGuid(PFileNode*,Turbine_GUID*)</code>
    /// </summary>
    /// <param name="o_name">Buffer that receives the GUID representation of the node's name.</param>
    /// <returns>True when the GUID was successfully retrieved or constructed; otherwise false.</returns>
    public byte GetNameAsGuid(ACBindings.Internal.Turbine_GUID* o_name) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PFileNode, ACBindings.Internal.Turbine_GUID*, byte>)0x0068DA40)(ref this, o_name);

    /// <summary>Creates a child node whose name represents the supplied 32‑bit integer value.
    /// <code>Offset: 0x0069B600
    /// PFileNode* __thiscall PFileNode::MakeSubNodeAsInt32(PFileNode*,int)</code>
    /// </summary>
    /// <param name="i_name">The integer to use as the new subnode's name.</param>
    /// <returns>Pointer to the newly created child node, or nullptr if the base class fails to create it.</returns>
    public ACBindings.Internal.PFileNode* MakeSubNodeAsInt32(int i_name) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PFileNode, int, ACBindings.Internal.PFileNode*>)0x0069B600)(ref this, i_name);

    /// <summary>Assigns a new file identifier to the node and updates reference counts of the old and new identifiers appropriately.
    /// <code>Offset: 0x006BBE90
    /// LONG __thiscall PFileNode::SetFileName(_DWORD*,int*)</code>
    /// </summary>
    /// <param name="a2">Pointer to an integer containing the new file identifier to set for this node.</param>
    /// <returns>When the identifier changes, returns the updated reference count for the new identifier; if no change occurs, returns the original identifier value unchanged.</returns>
    public int SetFileName(int* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PFileNode, int*, int>)0x006BBE90)(ref this, a2);
}

