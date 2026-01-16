namespace ACBindings.Internal;


/// <summary>Represents memory block information for an LRU buffer, including offsets, sizes, limits, and pointers to metadata and data buffers.</summary>
public unsafe struct LRUB_Mem_t
{
    // Members
    public int offset_lm;
    public int size_lm;
    public int max_lm;
    public int above_lm;
    public int below_lm;
    public ACBindings.Internal.LRUB_Info_t* info_pm;
    public System.IntPtr DIds_pm;
    public byte* buffer_cpm;

    // Generated Constructor
    public LRUB_Mem_t(ACBindings.Internal.LRUB_Mem_t* source) {
        _ConstructorInternal(source);
    }
    public LRUB_Mem_t(int block_size_l) {
        _ConstructorInternal(block_size_l);
    }

    // Methods

    /// <summary>Creates a new LRUB_Mem_t by copying another instance. If the source contains a data buffer, allocates a duplicate and initializes related internal pointers.
    /// <code>Offset: 0x006759D0
    /// void __thiscall LRUB_Mem_t::LRUB_Mem_t(LRUB_Mem_t*,const LRUB_Mem_t*)</code>
    /// </summary>
    /// <param name="source">The instance to copy from.</param>
    public void _ConstructorInternal(ACBindings.Internal.LRUB_Mem_t* source) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.LRUB_Mem_t, ACBindings.Internal.LRUB_Mem_t*, void>)0x006759D0)(ref this, source);

    /// <summary>Creates an internal buffer of the specified size for the LRUB_Mem_t instance if none exists.
    /// <code>Offset: 0x00675A50
    /// void __thiscall LRUB_Mem_t::Make_Buffer(LRUB_Mem_t*,int)</code>
    /// </summary>
    /// <param name="size_l">The desired size of the new buffer in bytes; must be greater than zero to allocate memory.</param>
    public void Make_Buffer(int size_l) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.LRUB_Mem_t, int, void>)0x00675A50)(ref this, size_l);

    /// <summary>Initializes a new memory block manager, setting all fields to default values and allocating an internal buffer when a positive size is provided.
    /// <code>Offset: 0x00675B00
    /// void __thiscall LRUB_Mem_t::LRUB_Mem_t(LRUB_Mem_t*,int)</code>
    /// </summary>
    /// <param name="block_size_l">The desired size of the buffer; if zero or negative, no allocation occurs.</param>
    public void _ConstructorInternal(int block_size_l) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.LRUB_Mem_t, int, void>)0x00675B00)(ref this, block_size_l);

    /// <summary>Trims trailing sentinel identifiers from the below list of the memory structure and writes the first non‑sentinel identifier into the supplied output parameter.
    /// <code>Offset: 0x00675B40
    /// unsigned int* __thiscall LRUB_Mem_t::Remove_Below(_DWORD*,unsigned int*)</code>
    /// </summary>
    /// <param name="a2">Pointer to an unsigned int where the function stores the identifier found after removing trailing sentinels; may receive a sentinel value if none remain.</param>
    /// <returns>Returns the same pointer that was passed in, enabling call chaining or immediate use of the result.</returns>
    public uint* Remove_Below(uint* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.LRUB_Mem_t, uint*, uint*>)0x00675B40)(ref this, a2);

    /// <summary>Removes consecutive entries equal to INVALID_DID_421.id from the top of the LRUB buffer, advancing the above_lm index, and writes the first ID that stops removal into the supplied pointer.
    /// <code>Offset: 0x00675B80
    /// unsigned int* __thiscall LRUB_Mem_t::Remove_Above(_DWORD*,unsigned int*)</code>
    /// </summary>
    /// <param name="a2">Pointer to an unsigned int where the ID that caused exit is stored; if no IDs were removed, receives INVALID_DID_421.id.</param>
    /// <returns>Pointer to the same unsigned int passed in a2.</returns>
    public uint* Remove_Above(uint* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.LRUB_Mem_t, uint*, uint*>)0x00675B80)(ref this, a2);

    /// <summary>
    /// Retrieves an identifier from the internal buffer at the current “above” index, advancing the index while skipping invalid entries and updating state accordingly.
    /// 
    /// <code>Offset: 0x00675BD0
    /// unsigned int* __thiscall LRUB_Mem_t::Peek_Above(_DWORD*,unsigned int*)</code>
    /// </summary>
    /// <param name="a2">Pointer to unsigned int where the retrieved ID will be stored.</param>
    /// <returns>Returns the same pointer passed in, now pointing to the output value.</returns>
    public uint* Peek_Above(uint* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.LRUB_Mem_t, uint*, uint*>)0x00675BD0)(ref this, a2);
}

