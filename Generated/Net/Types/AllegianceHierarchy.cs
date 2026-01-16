namespace ACBindings.Internal;


/// <summary>Represents the organizational hierarchy of an allegiance within the game system, storing leadership references, officer lists, communication parameters, and metadata such as name and message‑of‑the‑day.</summary>
public unsafe struct AllegianceHierarchy : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.PackObj BaseClass_PackObj; // ACBindings.Internal.PackObj

    // Child Types
    public unsafe struct AllegianceHierarchy_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.AllegianceHierarchy*, void> AllegianceHierarchy_dtor_0; // function pointer
        public fixed byte gap4[4];
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.AllegianceHierarchy*, uint> GetPackSize; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.AllegianceHierarchy*, void**, uint, uint> Pack; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.AllegianceHierarchy*, void**, uint, int> UnPack; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.AllegianceHierarchy*, uint> GetMinPackSize; // function pointer

        // Methods
    }

    // Members
    public ACBindings.Internal.AllegianceVersion m_oldVersion;
    public ACBindings.Internal.AllegianceNode* m_pMonarch;
    public uint m_total;
    public int m_monarchBroadcastTime;
    public int m_spokesBroadcastTime;
    public uint m_monarchBroadcastsToday;
    public uint m_spokesBroadcastsToday;
    public ACBindings.Internal.AC1Legacy.PStringBase__sbyte m_motd;
    public ACBindings.Internal.AC1Legacy.PStringBase__sbyte m_motdSetBy;
    public ACBindings.Internal.AC1Legacy.PStringBase__sbyte m_AllegianceName;
    public int m_NameLastSetTime;
    public uint m_chatRoomID;
    public ACBindings.Internal.PHashTable__uint__uint m_AllegianceOfficers;
    public ACBindings.Internal.PSmartArray___AC1Legacy_PStringBase__sbyte m_OfficerTitles;
    public ACBindings.Internal.Position m_BindPoint;
    public int m_isLocked;
    public uint m_ApprovedVassal;

    // Generated Constructor
    public AllegianceHierarchy() {
        _ConstructorInternal();
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>Recursively deallocates an allegiance hierarchy rooted at the supplied node pointer and clears all references.
    /// <code>Offset: 0x005B7D10
    /// void __thiscall AllegianceHierarchy::Clear(AllegianceHierarchy*,AllegianceNode**)</code>
    /// </summary>
    /// <param name="node">Pointer to the root AllegianceNode to clear; will be set to nullptr after deletion.</param>
    public void Clear(ACBindings.Internal.AllegianceNode** node) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AllegianceHierarchy, ACBindings.Internal.AllegianceNode**, void>)0x005B7D10)(ref this, node);

    /// <summary>Calculates the packed byte size of an AllegianceNode, including its own data, any patron reference, and recursively all subordinate vassal nodes.
    /// <code>Offset: 0x005B7D70
    /// unsigned int __thiscall AllegianceHierarchy::GetNodePackSize(AllegianceHierarchy*,AllegianceNode*)</code>
    /// </summary>
    /// <param name="node">Root node whose pack size is to be computed.</param>
    /// <returns>The total number of bytes required to serialize the specified node hierarchy; returns 0 when the supplied node is null.</returns>
    public uint GetNodePackSize(ACBindings.Internal.AllegianceNode* node) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AllegianceHierarchy, ACBindings.Internal.AllegianceNode*, uint>)0x005B7D70)(ref this, node);

    /// <summary>Searches the allegiance hierarchy for a node whose ID matches the specified value, beginning at the supplied node and exploring its vassal chain recursively. Returns the matching node or null if no match is found.
    /// <code>Offset: 0x005B7DD0
    /// AllegianceNode* __thiscall AllegianceHierarchy::Search(AllegianceHierarchy*,const unsigned int,AllegianceNode*)</code>
    /// </summary>
    /// <param name="id">The ID of the node to locate within the hierarchy.</param>
    /// <param name="node">The starting node for the search; if null or its ID does not match, the function traverses its vassals and peers recursively.</param>
    /// <returns>The AllegianceNode* that matches the given id, or nullptr if none exists.</returns>
    public ACBindings.Internal.AllegianceNode* Search(uint id, ACBindings.Internal.AllegianceNode* node) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AllegianceHierarchy, uint, ACBindings.Internal.AllegianceNode*, ACBindings.Internal.AllegianceNode*>)0x005B7DD0)(ref this, id, node);

    /// <summary>Retrieves the unique identifier of the current monarch in the hierarchy.
    /// <code>Offset: 0x005B7E10
    /// unsigned int __thiscall AllegianceHierarchy::GetMonarchID(AllegianceHierarchy*)</code>
    /// </summary>
    /// <returns>The monarch’s ID, or 0 if there is no monarch assigned.</returns>
    public uint GetMonarchID() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AllegianceHierarchy, uint>)0x005B7E10)(ref this);

    /// <summary>Serializes an allegiance node and its subordinate nodes into the supplied buffer, writing patron identifiers and base class data recursively.
    /// <code>Offset: 0x005B7E20
    /// unsigned int __thiscall AllegianceHierarchy::PackNode(AllegianceHierarchy*,AllegianceNode*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="node">The node to serialize; if null, no data is written.</param>
    /// <param name="addr">Pointer to a pointer that references the current position in the destination buffer; it is advanced as data is written.</param>
    /// <param name="size">Maximum size of the buffer (passed through but not directly used in this implementation).</param>
    /// <returns>The number of bytes written into the buffer during packing.</returns>
    public uint PackNode(ACBindings.Internal.AllegianceNode* node, void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AllegianceHierarchy, ACBindings.Internal.AllegianceNode*, void**, uint, uint>)0x005B7E20)(ref this, node, addr, size);

    /// <summary>Searches for an allegiance node by its identifier within the hierarchy, copies the found node's data into a supplied AllegianceData structure, and signals success or failure.
    /// <code>Offset: 0x005B7E90
    /// int __thiscall AllegianceHierarchy::LookUp(AllegianceHierarchy*,const unsigned int,AllegianceData*)</code>
    /// </summary>
    /// <param name="id">Identifier of the allegiance to locate.</param>
    /// <param name="retval">Structure that receives the data of the located node.</param>
    /// <returns>Nonzero if a matching node was found; zero otherwise.</returns>
    public int LookUp(uint id, ACBindings.Internal.AllegianceData* retval) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AllegianceHierarchy, uint, ACBindings.Internal.AllegianceData*, int>)0x005B7E90)(ref this, id, retval);

    /// <summary>Adds a new allegiance member to the hierarchy. If no monarch exists, the member becomes the monarch; otherwise it is added as a vassal of the specified patron if insertion rules allow.
    /// <code>Offset: 0x005B7FD0
    /// int __thiscall AllegianceHierarchy::Add(AllegianceHierarchy*,const unsigned int,const AllegianceData*)</code>
    /// </summary>
    /// <param name="patron">The ID of the patron under which to add the new member, or zero to create a monarch when none exists.</param>
    /// <param name="new_data">Data describing the new member; its ID must be non‑zero and unique within the hierarchy.</param>
    /// <returns>1 if the member was successfully added; otherwise 0.</returns>
    public int Add(uint patron, ACBindings.Internal.AllegianceData* new_data) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AllegianceHierarchy, uint, ACBindings.Internal.AllegianceData*, int>)0x005B7FD0)(ref this, patron, new_data);

    /// <summary>Copies an allegiance node and its descendant hierarchy into this instance, optionally including the node itself.
    /// <code>Offset: 0x005B8090
    /// int __thiscall AllegianceHierarchy::Copy(AllegianceHierarchy*,AllegianceNode*,int)</code>
    /// </summary>
    /// <param name="node">Node to copy from; if null, operation succeeds immediately.</param>
    /// <param name="copy_node">When non‑zero, add the supplied node to the hierarchy; otherwise copy only its vassals.</param>
    /// <returns>1 on success for all nodes copied; 0 if any addition fails.</returns>
    public int Copy(ACBindings.Internal.AllegianceNode* node, int copy_node) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AllegianceHierarchy, ACBindings.Internal.AllegianceNode*, int, int>)0x005B8090)(ref this, node, copy_node);

    /// <summary>Computes the total byte size required to serialize an AllegianceHierarchy instance, including all strings, collections, and nested objects.
    /// <code>Offset: 0x005B8100
    /// unsigned int __thiscall AllegianceHierarchy::GetPackSize(AllegianceHierarchy*)</code>
    /// </summary>
    /// <returns>The cumulative size in bytes needed for packing this hierarchy.</returns>
    public uint GetPackSize() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AllegianceHierarchy, uint>)0x005B8100)(ref this);

    /// <summary>Serializes an AllegianceHierarchy object into a binary buffer, writing its fields sequentially and advancing the buffer pointer.
    /// <code>Offset: 0x005B81A0
    /// unsigned int __thiscall AllegianceHierarchy::Pack(AllegianceHierarchy*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Pointer to the buffer location where packed data will be written; updated to point after the last byte written.</param>
    /// <param name="size">Number of bytes available in the buffer for packing. If insufficient, no data is written but the required size is still returned.</param>
    /// <returns>The total number of bytes needed to pack this AllegianceHierarchy instance.</returns>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AllegianceHierarchy, void**, uint, uint>)0x005B81A0)(ref this, addr, size);

    /// <summary>Resets the AllegianceHierarchy instance to its default state by clearing all counters, messages, officer lists, and monarch references.
    /// <code>Offset: 0x005B8550
    /// void __thiscall AllegianceHierarchy::Clear(AllegianceHierarchy*)</code>
    /// </summary>
    public void Clear() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AllegianceHierarchy, void>)0x005B8550)(ref this);

    /// <summary>Deserializes an AllegianceHierarchy from a packed data stream, initializing all members based on the stored version and populating internal collections.
    /// <code>Offset: 0x005B8660
    /// int __thiscall AllegianceHierarchy::UnPack(AllegianceHierarchy*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Pointer to the current read position within the source buffer; advanced as bytes are consumed.</param>
    /// <param name="size">Total number of bytes remaining in the buffer for this unpack operation.</param>
    /// <returns>Non‑zero if the unpack succeeds, zero if an error occurs or data is incomplete.</returns>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AllegianceHierarchy, void**, uint, int>)0x005B8660)(ref this, addr, size);

    /// <summary>Constructs an AllegianceHierarchy object by initializing all data members to default values, creating necessary hash tables and arrays, and preparing string buffers with reference counting support.
    /// <code>Offset: 0x005B8930
    /// void __thiscall AllegianceHierarchy::AllegianceHierarchy(AllegianceHierarchy*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AllegianceHierarchy, void>)0x005B8930)(ref this);

    /// <summary>Destroys an AllegianceHierarchy instance by clearing its data, releasing strings, officer titles, and the officers hash table, then resetting internal pointers.
    /// <code>Offset: 0x005B8C00
    /// void __thiscall AllegianceHierarchy::~AllegianceHierarchy(AllegianceHierarchy*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AllegianceHierarchy, void>)0x005B8C00)(ref this);
}

