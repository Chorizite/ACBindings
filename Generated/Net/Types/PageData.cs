namespace ACBindings.Internal;


/// <summary>Contains page content, author data, and linkage pointers for use in serialized page collections.</summary>
public unsafe struct PageData : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.PackObj BaseClass_PackObj; // ACBindings.Internal.PackObj

    // Child Types
    public unsafe struct PageData_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.PageData*, void> PageData_dtor_0; // function pointer
        public fixed byte gap4[4];
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.PageData*, uint> GetPackSize; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.PageData*, void**, uint, uint> Pack; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.PageData*, void**, uint, int> UnPack; // function pointer

        // Methods
    }

    // Members
    public uint authorID;
    public ACBindings.Internal.AC1Legacy.PStringBase__sbyte authorName;
    public ACBindings.Internal.AC1Legacy.PStringBase__sbyte authorAccount;
    public int textIncluded;
    public int ignoreAuthor;
    public ACBindings.Internal.AC1Legacy.PStringBase__sbyte pageText;
    public ACBindings.Internal.PageData* prev;
    public ACBindings.Internal.PageData* next;

    // Generated Constructor
    public PageData() {
        _ConstructorInternal();
    }
    public PageData(void** a2, void*** a3, void*** a4, void*** a5, void** a6) {
        _ConstructorInternal(a2, a3, a4, a5, a6);
    }
    public PageData(ACBindings.Internal.PageData* pd, int includeText) {
        _ConstructorInternal(pd, includeText);
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>Sets the pageText pointer of a PageData instance, performing refcount management on the old and new strings.
    /// <code>Offset: 0x004BB980
    /// LONG __thiscall PageData::SetPageText(_DWORD*,LONG*)</code>
    /// </summary>
    /// <param name="a2">Address of the LONG value representing the new page text reference.</param>
    /// <returns>The resulting reference count after assignment (or unchanged count if the same pointer).</returns>
    public int SetPageText(int* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PageData, int*, int>)0x004BB980)(ref this, a2);

    /// <summary>Releases the resources held by a PageData instance, decrementing reference counts on its string buffers and freeing them when no longer used.
    /// <code>Offset: 0x0055B180
    /// void __thiscall PageData::~PageData(PageData*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PageData, void>)0x0055B180)(ref this);

    /// <summary>Initializes a new PageData instance with default author information, text inclusion flags, and linked list pointers.
    /// <code>Offset: 0x005D2FC0
    /// void __thiscall PageData::PageData(PageData*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PageData, void>)0x005D2FC0)(ref this);

    /// <summary>Initializes a PageData object with author data, page text, and linkage pointers, setting the internal vftable, storing an author ID, incrementing reference counts for string parameters, marking the page as included, recording an ignore‑author flag, and clearing prev/next links.
    /// <code>Offset: 0x005D3020
    /// void*** __thiscall PageData::PageData(void***,void**,void***,void***,void***,void**)</code>
    /// </summary>
    /// <param name="a2">Author identifier value stored directly in the object.</param>
    /// <param name="a3">Pointer to the author's name string; its reference count is incremented.</param>
    /// <param name="a4">Pointer to the author's account string; its reference count is incremented.</param>
    /// <param name="a5">Pointer to the page text string; its reference count is incremented.</param>
    /// <param name="a6">Flag indicating whether the author should be ignored, stored in the object.</param>
    /// <returns>Reference to the newly constructed PageData instance.</returns>
    public void*** _ConstructorInternal(void** a2, void*** a3, void*** a4, void*** a5, void** a6) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PageData, void**, void***, void***, void***, void**, void***>)0x005D3020)(ref this, a2, a3, a4, a5, a6);

    /// <summary>Initializes a PageData instance by copying author information and optionally page text from an existing PageData object. Sets prev and next links to nullptr.
    /// <code>Offset: 0x005D32B0
    /// void __thiscall PageData::PageData(PageData*,PageData*,int)</code>
    /// </summary>
    /// <param name="pd">Source PageData whose data is copied into the new instance.</param>
    /// <param name="includeText">Flag indicating whether to copy the pageText field; if false, pageText is set to empty.</param>
    public void _ConstructorInternal(ACBindings.Internal.PageData* pd, int includeText) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PageData, ACBindings.Internal.PageData*, int, void>)0x005D32B0)(ref this, pd, includeText);

    /// <summary>Serializes a PageData instance into binary form, writing its fields sequentially to the supplied buffer and advancing the buffer pointer.
    /// <code>Offset: 0x005D3380
    /// unsigned int __thiscall PageData::Pack(PageData*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Reference to a pointer that marks the current write position in the buffer; updated as data is written.</param>
    /// <param name="size">Maximum number of bytes available for writing; if insufficient, no data is written.</param>
    /// <returns>Returns the total byte count required (or used) for the serialization. If size is smaller than this value, the function returns the needed size without modifying the buffer.</returns>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PageData, void**, uint, uint>)0x005D3380)(ref this, addr, size);

    /// <summary>Deserializes a PageData object from the provided buffer, populating fields such as authorID, authorName, authorAccount, textIncluded, ignoreAuthor and optionally pageText.
    /// <code>Offset: 0x005D3460
    /// int __thiscall PageData::UnPack(PageData*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Pointer to the current position within the input buffer; the method advances this pointer past the data it consumes.</param>
    /// <param name="size">Number of bytes remaining in the buffer from the original start point; used to determine string lengths during unpacking.</param>
    /// <returns>Returns 1 on successful unpacking of the PageData structure.</returns>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PageData, void**, uint, int>)0x005D3460)(ref this, addr, size);

    /// <summary>Serializes the PageData object’s author information (ID, name, account and ignoreAuthor flag) into a binary buffer without including page text.
    /// <code>Offset: 0x005D3510
    /// unsigned int __thiscall PageData::PackNoText(PageData*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Pointer to the current position in the destination buffer; updated to point after the written data when the operation succeeds.</param>
    /// <param name="size">Number of bytes available in the destination buffer.</param>
    /// <returns>The total number of bytes required to pack the author information. This value is returned whether or not the data was actually written into the buffer.</returns>
    public uint PackNoText(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PageData, void**, uint, uint>)0x005D3510)(ref this, addr, size);
}

