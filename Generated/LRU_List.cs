namespace ACBindings.Internal;


/// <summary>Maintains an LRU cache of disk‑backed blocks, coordinating block allocation, usage tracking, and eviction through internal hash tables and memory pools.</summary>
public unsafe struct LRU_List
{
    // Members
    public byte initialized_fm;
    public byte empty_fm;
    public int used_count_lm;
    public ACBindings.Internal.HashList___IDClass____tagDataID__byte used_table_m;
    public ACBindings.Internal.HashSet___IDClass____tagDataID dead_table_m;
    public ACBindings.Internal.LRUB_Mem_t* young_pm;
    public ACBindings.Internal.LRUB_Mem_t* old_pm;
    public ACBindings.Internal.CLBlockAllocator* block_man_pm;
    public ACBindings.Internal.DiskFileInfo_t* file_info_pm;

    // Generated Constructor
    public LRU_List(ACBindings.Internal.CLBlockAllocator* block_man_p, ACBindings.Internal.DiskFileInfo_t* file_info_p) {
        _ConstructorInternal(block_man_p, file_info_p);
    }

    // Methods

    /// <summary>Initializes the LRU list if it has not been initialized yet and both young and old memory pointers are null, setting internal state based on the associated disk file information.
    /// <code>Offset: 0x00675AB0
    /// bool __thiscall LRU_List::Create_List(LRU_List*)</code>
    /// </summary>
    /// <returns>True when initialization succeeds; otherwise false.</returns>
    public byte Create_List() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.LRU_List, byte>)0x00675AB0)(ref this);

    /// <summary>Loads the LRU list from disk into memory, initializing young and old segments as needed.
    /// <code>Offset: 0x00675C40
    /// bool __thiscall LRU_List::Load_List(LRU_List*)</code>
    /// </summary>
    /// <returns>True if the list was loaded successfully; otherwise, false.</returns>
    public byte Load_List() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.LRU_List, byte>)0x00675C40)(ref this);

    /// <summary>Adds the specified integer value to the LRU list's current segment, updating internal counters and allocating space through the block allocator as needed.
    /// <code>Offset: 0x00675DA0
    /// char __thiscall LRU_List::Add_Exec(int,int)</code>
    /// </summary>
    /// <param name="a2">The integer identifier or data value to insert into the list.</param>
    /// <returns>Always returns 1 (true) to indicate successful addition.</returns>
    public sbyte Add_Exec(int a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.LRU_List, int, sbyte>)0x00675DA0)(ref this, a2);

    /// <summary>Expands the LRU list’s free‑block region by applying transaction information to the young‑block metadata and file data, then stores updated blocks via the allocator.
    /// <code>Offset: 0x00675E30
    /// bool __thiscall LRU_List::Expand_Exec(LRU_List*,const LRUExpandTransactInfo*)</code>
    /// </summary>
    /// <param name="this">The LRU_List instance whose state is modified.</param>
    /// <param name="pTrIn">Transaction details that specify the target ID, new young offset, and first free block for expansion.</param>
    /// <returns>Always false; currently the function does not report success status.</returns>
    public byte Expand_Exec(ACBindings.Internal.LRUExpandTransactInfo* pTrIn) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.LRU_List, ACBindings.Internal.LRUExpandTransactInfo*, byte>)0x00675E30)(ref this, pTrIn);

    /// <summary>Deletes a block from the LRU list, updating predecessor/successor links and freeing associated memory.
    /// <code>Offset: 0x00675F70
    /// bool __thiscall LRU_List::Delete_Exec(LRU_List*,const LRUDeleteTransactInfo*)</code>
    /// </summary>
    /// <param name="pTrIn">Information about the block to delete, including its offset and neighboring offsets in the LRU chain.</param>
    /// <returns>True if the block was successfully deleted; otherwise false.</returns>
    public byte Delete_Exec(ACBindings.Internal.LRUDeleteTransactInfo* pTrIn) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.LRU_List, ACBindings.Internal.LRUDeleteTransactInfo*, byte>)0x00675F70)(ref this, pTrIn);

    /// <summary>Expands the LRU list for a specified target ID by allocating or updating memory blocks and recording the operation as a transaction.
    /// <code>Offset: 0x00676120
    /// char __thiscall LRU_List::Expand_Trans(LRU_List*,unsigned int,char)</code>
    /// </summary>
    /// <param name="a2">Identifier of the data item to be expanded within the LRU list.</param>
    /// <param name="a3">Flag indicating whether the transaction should be cleared after execution; non‑zero clears the transaction.</param>
    /// <returns>Zero (always).</returns>
    public sbyte Expand_Trans(uint a2, sbyte a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.LRU_List, uint, sbyte, sbyte>)0x00676120)(ref this, a2, a3);

    /// <summary>Deletes an LRU memory block from the list, performing transaction bookkeeping and optionally clearing pending transaction state.
    /// <code>Offset: 0x00676240
    /// bool __thiscall LRU_List::Delete_Trans(LRU_List*,LRUB_Mem_t*,bool)</code>
    /// </summary>
    /// <param name="block_p">Pointer to the LRUB_Mem_t block to delete.</param>
    /// <param name="clear_f">If true clears any pending transaction after deletion.</param>
    /// <returns>Always returns false.</returns>
    public byte Delete_Trans(ACBindings.Internal.LRUB_Mem_t* block_p, byte clear_f) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.LRU_List, ACBindings.Internal.LRUB_Mem_t*, byte, byte>)0x00676240)(ref this, block_p, clear_f);

    /// <summary>Retrieves the identifier of the oldest entry in the LRU list, moving it between internal memory pools if necessary. If no entries exist, stores an invalid ID.
    /// <code>Offset: 0x00676460
    /// unsigned int* __thiscall LRU_List::Get_Oldest(LRU_List*,unsigned int*)</code>
    /// </summary>
    /// <param name="a2">Pointer to a location where the retrieved identifier will be stored; receives INVALID_DID_421 if the list is empty or contains only invalid entries.</param>
    /// <returns>Returns the same pointer passed in as a2.</returns>
    public uint* Get_Oldest(uint* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.LRU_List, uint*, uint*>)0x00676460)(ref this, a2);

    /// <summary>Adds an entry identified by a2 to the LRU list, first removing any existing dead reference and then placing it into either the young memory pool or expanding the list if required.
    /// <code>Offset: 0x006768F0
    /// char __thiscall LRU_List::Write_Added(LRU_List*,unsigned int)</code>
    /// </summary>
    /// <param name="a2">The identifier of the element to add.</param>
    /// <returns>Zero on completion (the function always returns 0).</returns>
    public sbyte Write_Added(uint a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.LRU_List, uint, sbyte>)0x006768F0)(ref this, a2);

    /// <summary>
    /// Removes duplicate data identifiers from a cached block, updating internal tables and reordering blocks to preserve unique entries.
    /// 
    /// <code>Offset: 0x00676960
    /// void __thiscall LRU_List::Purge_Duplicates(LRU_List*,int,int)</code>
    /// </summary>
    /// <param name="was_offset_l">File offset of the block being processed.</param>
    /// <param name="was_index_l">Index position of that block within the LRU list.</param>
    public void Purge_Duplicates(int was_offset_l, int was_index_l) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.LRU_List, int, int, void>)0x00676960)(ref this, was_offset_l, was_index_l);

    /// <summary>Initializes an LRU list by setting its internal hash tables and linking to the supplied block allocator and disk file information.
    /// <code>Offset: 0x00676D30
    /// void __thiscall LRU_List::LRU_List(LRU_List*,CLBlockAllocator*,DiskFileInfo_t*)</code>
    /// </summary>
    /// <param name="block_man_p">Allocator used for managing memory blocks within the LRU system.</param>
    /// <param name="file_info_p">Metadata about the disk file that backs the LRU cache.</param>
    public void _ConstructorInternal(ACBindings.Internal.CLBlockAllocator* block_man_p, ACBindings.Internal.DiskFileInfo_t* file_info_p) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.LRU_List, ACBindings.Internal.CLBlockAllocator*, ACBindings.Internal.DiskFileInfo_t*, void>)0x00676D30)(ref this, block_man_p, file_info_p);

    /// <summary>Marks an entry as deleted by removing it from the active hash list and recording its identifier in a deletion set.
    /// <code>Offset: 0x00676EB0
    /// char __thiscall LRU_List::Mark_Deleted(DLListBase*,int)</code>
    /// </summary>
    /// <param name="a2">Identifier of the element to be marked for deletion.</param>
    /// <returns>Non‑zero if the operation succeeded, zero otherwise.</returns>
    public sbyte Mark_Deleted(int a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.LRU_List, int, sbyte>)0x00676EB0)(ref this, a2);

    /// <summary>Flushes all active entries from the list, removes them from tracking structures, frees their memory, and updates bookkeeping for expired items.
    /// <code>Offset: 0x00676EF0
    /// bool __thiscall LRU_List::Write_All_Out(LRU_List*)</code>
    /// </summary>
    /// <returns>True if the flush succeeded; otherwise, false (currently always returns false).</returns>
    public byte Write_All_Out() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.LRU_List, byte>)0x00676EF0)(ref this);

    /// <summary>Marks an entry identified by the supplied ID as recently used in the LRU list, moving it to the front and ensuring the list stays within its capacity.
    /// <code>Offset: 0x006771C0
    /// char __thiscall LRU_List::Mark_Used(DLListBase*,int)</code>
    /// </summary>
    /// <param name="a2">The identifier of the item to be marked as used.</param>
    /// <returns>A character value returned from the underlying push_head or pop_tail operation, indicating the outcome of updating the LRU list.</returns>
    public sbyte Mark_Used(int a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.LRU_List, int, sbyte>)0x006771C0)(ref this, a2);
}

