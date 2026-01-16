namespace ACBindings.Internal;


/// <summary>Manages an ordered collection of identifiers using a doubly‑linked list, offering insertion, deletion, traversal, and binary pack/unpack functionality through its PackObj base class.</summary>
public unsafe struct IDList : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.PackObj BaseClass_PackObj; // ACBindings.Internal.PackObj

    // Child Types
    public unsafe struct IDList_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.IDList*, void> IDList_dtor_0; // function pointer
        public fixed byte gap4[4];
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.IDList*, uint> GetPackSize; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.IDList*, void**, uint, uint> Pack; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.IDList*, void**, uint, int> UnPack; // function pointer

        // Methods
    }

    // Members
    public ACBindings.Internal.IDListNode* first;
    public ACBindings.Internal.IDListNode* last;
    public ACBindings.Internal.IDListNode* curNode;
    public int numIDs;
    public int curNum;

    // Generated Constructor
    public IDList() {
        _ConstructorInternal();
    }
    public IDList(ACBindings.Internal.IDList* list) {
        _ConstructorInternal(list);
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>Adds the given identifier to the IDList, inserting it as a new node at the list's tail.
    /// <code>Offset: 0x005AEC00
    /// void __thiscall IDList::Add(IDList*,unsigned int)</code>
    /// </summary>
    /// <param name="id">The integer identifier to append.</param>
    public void Add(uint id) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.IDList, uint, void>)0x005AEC00)(ref this, id);

    /// <summary>Checks whether a specified identifier exists within the list.
    /// <code>Offset: 0x005AEC80
    /// int __thiscall IDList::IsInList(IDList*,unsigned int)</code>
    /// </summary>
    /// <param name="id">The identifier to search for.</param>
    /// <returns>Non-zero (true) if the id is present; zero (false) otherwise.</returns>
    public int IsInList(uint id) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.IDList, uint, int>)0x005AEC80)(ref this, id);

    /// <summary>Advances the internal cursor of an IDList to its next node, updating the current index when a successor exists.
    /// <code>Offset: 0x005AECB0
    /// int __thiscall IDList::SetCurToNext(IDList*)</code>
    /// </summary>
    /// <returns>Non‑zero (1) if the cursor moved to a subsequent node; zero otherwise. When no further node is available, curNum becomes –1. If the list was empty or the cursor was already null, curNum remains unchanged.</returns>
    public int SetCurToNext() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.IDList, int>)0x005AECB0)(ref this);

    /// <summary>Returns the identifier stored in the currently selected node of the list, or 0 when no node is selected.
    /// <code>Offset: 0x005AECE0
    /// unsigned int __thiscall IDList::GetCurID(IDList*)</code>
    /// </summary>
    /// <returns>The ID of the current node, or 0 if none exists.</returns>
    public uint GetCurID() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.IDList, uint>)0x005AECE0)(ref this);

    /// <summary>Retrieves the IDListNode located at the specified zero‑based position within the list.
    /// <code>Offset: 0x005AECF0
    /// IDListNode* __thiscall IDList::GetNodeByNum(IDList*,int)</code>
    /// </summary>
    /// <param name="num">Zero‑based index of the node to retrieve.</param>
    /// <returns>The node if found; otherwise, null when the index is out of range or the list is empty.</returns>
    public ACBindings.Internal.IDListNode* GetNodeByNum(int num) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.IDList, int, ACBindings.Internal.IDListNode*>)0x005AECF0)(ref this, num);

    /// <summary>Initializes a new IDList, setting all internal pointers to null and counters to zero or -1.
    /// <code>Offset: 0x005AEDB0
    /// void __thiscall IDList::IDList(IDList*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.IDList, void>)0x005AEDB0)(ref this);

    /// <summary>Adds a new ID into the list at the specified zero‑based position, inserting before the node currently at that index or appending if the index equals the current count. If the position is out of range and addAtEndOnFail is true, the ID is appended; otherwise the call fails.
    /// <code>Offset: 0x005AEDD0
    /// int __thiscall IDList::AddAtNum(IDList*,unsigned int,int,int)</code>
    /// </summary>
    /// <param name="id">The identifier to insert into the list.</param>
    /// <param name="num">Zero‑based index where the new ID should be placed.</param>
    /// <param name="addAtEndOnFail">If non‑zero and num exceeds bounds, appends the ID instead of failing.</param>
    /// <returns>1 if the ID was inserted (or appended on failure); 0 if the position is invalid and no fallback was requested.</returns>
    public int AddAtNum(uint id, int num, int addAtEndOnFail) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.IDList, uint, int, int, int>)0x005AEDD0)(ref this, id, num, addAtEndOnFail);

    /// <summary>Removes the node that holds the specified ID from the doubly linked list, updating all internal pointers and tracking variables accordingly.
    /// <code>Offset: 0x005AEEA0
    /// int __thiscall IDList::RemoveByID(IDList*,unsigned int)</code>
    /// </summary>
    /// <param name="id">The unique identifier of the element to remove.</param>
    /// <returns>1 if the element was found and removed; 0 if no matching element exists in the list.</returns>
    public int RemoveByID(uint id) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.IDList, uint, int>)0x005AEEA0)(ref this, id);

    /// <summary>Retrieves the identifier stored at the given index within the ID list, returning 0 when no node exists for that position.
    /// <code>Offset: 0x005AEEF0
    /// unsigned int __thiscall IDList::GetByNum(IDList*,int)</code>
    /// </summary>
    /// <param name="num">The ordinal position in the list whose ID should be returned.</param>
    /// <returns>The unsigned integer ID located at the specified index, or 0 if the index is out of range.</returns>
    public uint GetByNum(int num) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.IDList, int, uint>)0x005AEEF0)(ref this, num);

    /// <summary>Empties the IDList by deleting all stored nodes, freeing their memory, and resetting internal pointers and counters to represent an empty list.
    /// <code>Offset: 0x005AEF10
    /// void __thiscall IDList::Clear(IDList*)</code>
    /// </summary>
    public void Clear() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.IDList, void>)0x005AEF10)(ref this);

    /// <summary>Positions the current iterator to the element identified by the supplied sequence number within the list.
    /// <code>Offset: 0x005AEFC0
    /// int __thiscall IDList::SetCurToNum(IDList*,int)</code>
    /// </summary>
    /// <param name="num">The sequence number of the desired node. The function interprets this as an index into the list; if a node exists at that position, it becomes the current node.</param>
    /// <returns>Non‑zero (1) when the specified node is found and set as current; zero when no node exists at that position, in which case curNode is cleared and curNum is set to –1.</returns>
    public int SetCurToNum(int num) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.IDList, int, int>)0x005AEFC0)(ref this, num);

    /// <summary>Packs the list of IDs into a contiguous block of 32‑bit values, starting with the count followed by each ID.
    /// <code>Offset: 0x005AEFF0
    /// unsigned int __thiscall IDList::Pack(IDList*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">A pointer to a memory location where the packed data will be written; it should reference at least <c>size</c> bytes.</param>
    /// <param name="size">The number of bytes available for writing. If less than the required size, no data is written.</param>
    /// <returns>The total byte count needed to represent the list (number of IDs × 4 + 4). This value can be used to determine if the supplied buffer was large enough.</returns>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.IDList, void**, uint, uint>)0x005AEFF0)(ref this, addr, size);

    /// <summary>Deserializes a sequence of integer identifiers from the memory buffer referenced by <paramref name="addr"/> and populates this IDList with new nodes containing those IDs, clearing any existing contents first.
    /// <code>Offset: 0x005AF0A0
    /// int __thiscall IDList::UnPack(IDList*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Pointer to a pointer that points to the start of a byte buffer holding serialized data. The first 4 bytes contain a count, followed by that many 4‑byte IDs.</param>
    /// <param name="size">Size of the buffer in bytes; currently unused by the implementation.</param>
    /// <returns>Always returns 1 to indicate successful unpacking.</returns>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.IDList, void**, uint, int>)0x005AF0A0)(ref this, addr, size);

    /// <summary>Clears all IDs in the list and restores the base class virtual table before destruction.
    /// <code>Offset: 0x005AF120
    /// void __thiscall IDList::~IDList(IDList*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.IDList, void>)0x005AF120)(ref this);

    /// <summary>Appends all IDs from the specified list into this list, preserving their original order.
    /// <code>Offset: 0x005AF140
    /// void __thiscall IDList::AddList(IDList*,IDList*)</code>
    /// </summary>
    /// <param name="list">The source IDList whose items are added to the current list.</param>
    public void AddList(ACBindings.Internal.IDList* list) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.IDList, ACBindings.Internal.IDList*, void>)0x005AF140)(ref this, list);

    /// <summary>Initializes the object as a copy of another IDList, populating its internal node structure with IDs from the provided list.
    /// <code>Offset: 0x005AF210
    /// void __thiscall IDList::IDList(IDList*,IDList*)</code>
    /// </summary>
    /// <param name="list">IDList instance whose contents will be copied into this new instance.</param>
    public void _ConstructorInternal(ACBindings.Internal.IDList* list) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.IDList, ACBindings.Internal.IDList*, void>)0x005AF210)(ref this, list);
}

