namespace ACBindings.Internal;


/// <summary>Maintains an ordered collection of PageData instances, providing operations for insertion, deletion, and binary packing/unpacking. The structure stores pointers to first and last pages, tracks page count, and configures maximum sizes and text inclusion during serialization.</summary>
public unsafe struct PageDataList : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.PackObj BaseClass_PackObj; // ACBindings.Internal.PackObj

    // Child Types
    public unsafe struct PageDataList_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.PageDataList*, void> PageDataList_dtor_0; // function pointer
        public fixed byte gap4[4];
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.PageDataList*, uint> GetPackSize; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.PageDataList*, void**, uint, uint> Pack; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.PageDataList*, void**, uint, int> UnPack; // function pointer

        // Methods
    }

    // Members
    public ACBindings.Internal.PageData* first;
    public ACBindings.Internal.PageData* last;
    public int numPages;
    public int maxNumPages;
    public int maxNumCharsPerPage;
    public int packWithText;

    // Generated Constructor
    public PageDataList() {
        _ConstructorInternal();
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>Retrieves the page at the specified zero‑based index in the list, returning nullptr when the index is out of bounds.
    /// <code>Offset: 0x005D2DC0
    /// PageData* __thiscall PageDataList::Get(PageDataList*,int)</code>
    /// </summary>
    /// <param name="this">The PageDataList instance to query.</param>
    /// <param name="pos">Zero‑based position of the desired page.</param>
    /// <returns>A pointer to the PageData object at <paramref name="pos"/>, or nullptr if pos is negative or exceeds numPages – 1.</returns>
    public ACBindings.Internal.PageData* Get(int pos) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PageDataList, int, ACBindings.Internal.PageData*>)0x005D2DC0)(ref this, pos);

    /// <summary>Initializes a new PageDataList instance, resetting page list pointers and counters to zero and enabling text packing by default.
    /// <code>Offset: 0x005D2DF0
    /// void __thiscall PageDataList::PageDataList(PageDataList*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PageDataList, void>)0x005D2DF0)(ref this);

    /// <summary>Inserts a PageData node into the list at a specified position. If pos is zero, the node becomes the new first element. If pos lies between 0 and numPages – 1, the node is inserted before the page currently at that index; if pos is greater than or equal to numPages, it appends to the end, updating the list’s links and incrementing the page count.
    /// <code>Offset: 0x005D2E20
    /// void __thiscall PageDataList::Insert(PageDataList*,PageData*,int)</code>
    /// </summary>
    /// <param name="pd">The PageData instance to insert into the list.</param>
    /// <param name="pos">Zero‑based position where the new node should appear. A value of 0 inserts at the front; a positive value less than numPages places it before that index; values greater than or equal to numPages appends after the current last page.</param>
    public void Insert(ACBindings.Internal.PageData* pd, int pos) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PageDataList, ACBindings.Internal.PageData*, int, void>)0x005D2E20)(ref this, pd, pos);

    /// <summary>Removes the page at the specified zero‑based index from the list, updating links and decrementing the page count.
    /// <code>Offset: 0x005D2ED0
    /// PageData* __thiscall PageDataList::Remove(PageDataList*,int)</code>
    /// </summary>
    /// <param name="pos">The zero‑based position of the page to remove; if out of range, no removal occurs.</param>
    /// <returns>A pointer to the removed PageData object, or nullptr when the requested position is invalid or the list is empty.</returns>
    public ACBindings.Internal.PageData* Remove(int pos) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PageDataList, int, ACBindings.Internal.PageData*>)0x005D2ED0)(ref this, pos);

    /// <summary>Removes the page at the given position from the list and deallocates its memory.
    /// <code>Offset: 0x005D2F40
    /// void __thiscall PageDataList::Delete(PageDataList*,int)</code>
    /// </summary>
    /// <param name="pos">Zero-based index of the page to delete. If no page exists at this index, the function has no effect.</param>
    public void Delete(int pos) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PageDataList, int, void>)0x005D2F40)(ref this, pos);

    /// <summary>Removes all pages from the list, destroying each PageData instance and updating internal links.
    /// <code>Offset: 0x005D2F60
    /// void __thiscall PageDataList::Flush(PageDataList*)</code>
    /// </summary>
    public void Flush() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PageDataList, void>)0x005D2F60)(ref this);

    /// <summary>Destroys a PageDataList instance, flushing all stored pages and restoring the base PackObj virtual table to ensure proper cleanup during object destruction.
    /// <code>Offset: 0x005D3090
    /// void __thiscall PageDataList::~PageDataList(PageDataList*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PageDataList, void>)0x005D3090)(ref this);

    /// <summary>
    /// Deserializes a list of PageData objects from a binary buffer into the current PageDataList instance, clearing any existing entries and rebuilding its linked list structure.
    /// 
    /// <code>Offset: 0x005D30B0
    /// int __thiscall PageDataList::UnPack(PageDataList*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Pointer to a void* that points to the current read position within the source buffer; updated as data is consumed.</param>
    /// <param name="size">Total size of the remaining data in the buffer, used as an upper bound for safety.</param>
    /// <returns>Non‑zero integer indicating successful completion (always returns 1).</returns>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PageDataList, void**, uint, int>)0x005D30B0)(ref this, addr, size);

    /// <summary>Computes the total number of bytes required to serialize all PageData objects stored in this list, invoking Pack or PackNoText on each element according to the packWithText flag and accumulating the resulting sizes.
    /// <code>Offset: 0x005D3640
    /// unsigned int __thiscall PageDataList::pack_size(PageDataList*)</code>
    /// </summary>
    /// <returns>The cumulative packed size in bytes for the entire list.</returns>
    public uint pack_size() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PageDataList, uint>)0x005D3640)(ref this);

    /// <summary>Serializes a PageDataList into a contiguous memory block and returns the total byte count required. The function writes page metadata followed by each PageData, optionally including text when enabled.
    /// <code>Offset: 0x005D36A0
    /// unsigned int __thiscall PageDataList::Pack(PageDataList*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Pointer to the destination buffer; upon successful packing it is advanced past the written data.</param>
    /// <param name="size">Maximum number of bytes that may be written into the buffer.</param>
    /// <returns>The total size in bytes needed to serialize the PageDataList. If the supplied buffer is too small, no data is written and this value is returned instead.</returns>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PageDataList, void**, uint, uint>)0x005D36A0)(ref this, addr, size);
}

