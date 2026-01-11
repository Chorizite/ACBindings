namespace ACBindings.Internal;

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

    /// <summary>
    /// <code>Offset: 0x00675AB0
    /// bool __thiscall LRU_List::Create_List(LRU_List*)</code>
    /// </summary>
    public byte Create_List() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.LRU_List, byte>)0x00675AB0)(ref this);

    /// <summary>
    /// <code>Offset: 0x00675C40
    /// bool __thiscall LRU_List::Load_List(LRU_List*)</code>
    /// </summary>
    public byte Load_List() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.LRU_List, byte>)0x00675C40)(ref this);

    /// <summary>
    /// <code>Offset: 0x00675DA0
    /// char __thiscall LRU_List::Add_Exec(int,int)</code>
    /// </summary>
    public sbyte Add_Exec(int a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.LRU_List, int, sbyte>)0x00675DA0)(ref this, a2);

    /// <summary>
    /// <code>Offset: 0x00675E30
    /// bool __thiscall LRU_List::Expand_Exec(LRU_List*,const LRUExpandTransactInfo*)</code>
    /// </summary>
    public byte Expand_Exec(ACBindings.Internal.LRUExpandTransactInfo* pTrIn) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.LRU_List, ACBindings.Internal.LRUExpandTransactInfo*, byte>)0x00675E30)(ref this, pTrIn);

    /// <summary>
    /// <code>Offset: 0x00675F70
    /// bool __thiscall LRU_List::Delete_Exec(LRU_List*,const LRUDeleteTransactInfo*)</code>
    /// </summary>
    public byte Delete_Exec(ACBindings.Internal.LRUDeleteTransactInfo* pTrIn) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.LRU_List, ACBindings.Internal.LRUDeleteTransactInfo*, byte>)0x00675F70)(ref this, pTrIn);

    /// <summary>
    /// <code>Offset: 0x00676120
    /// char __thiscall LRU_List::Expand_Trans(LRU_List*,unsigned int,char)</code>
    /// </summary>
    public sbyte Expand_Trans(uint a2, sbyte a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.LRU_List, uint, sbyte, sbyte>)0x00676120)(ref this, a2, a3);

    /// <summary>
    /// <code>Offset: 0x00676240
    /// bool __thiscall LRU_List::Delete_Trans(LRU_List*,LRUB_Mem_t*,bool)</code>
    /// </summary>
    public byte Delete_Trans(ACBindings.Internal.LRUB_Mem_t* block_p, byte clear_f) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.LRU_List, ACBindings.Internal.LRUB_Mem_t*, byte, byte>)0x00676240)(ref this, block_p, clear_f);

    /// <summary>
    /// <code>Offset: 0x00676460
    /// unsigned int* __thiscall LRU_List::Get_Oldest(LRU_List*,unsigned int*)</code>
    /// </summary>
    public uint* Get_Oldest(uint* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.LRU_List, uint*, uint*>)0x00676460)(ref this, a2);

    /// <summary>
    /// <code>Offset: 0x006768F0
    /// char __thiscall LRU_List::Write_Added(LRU_List*,unsigned int)</code>
    /// </summary>
    public sbyte Write_Added(uint a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.LRU_List, uint, sbyte>)0x006768F0)(ref this, a2);

    /// <summary>
    /// <code>Offset: 0x00676960
    /// void __thiscall LRU_List::Purge_Duplicates(LRU_List*,int,int)</code>
    /// </summary>
    public void Purge_Duplicates(int was_offset_l, int was_index_l) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.LRU_List, int, int, void>)0x00676960)(ref this, was_offset_l, was_index_l);

    /// <summary>
    /// <code>Offset: 0x00676D30
    /// void __thiscall LRU_List::LRU_List(LRU_List*,CLBlockAllocator*,DiskFileInfo_t*)</code>
    /// </summary>
    public void _ConstructorInternal(ACBindings.Internal.CLBlockAllocator* block_man_p, ACBindings.Internal.DiskFileInfo_t* file_info_p) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.LRU_List, ACBindings.Internal.CLBlockAllocator*, ACBindings.Internal.DiskFileInfo_t*, void>)0x00676D30)(ref this, block_man_p, file_info_p);

    /// <summary>
    /// <code>Offset: 0x00676EB0
    /// char __thiscall LRU_List::Mark_Deleted(DLListBase*,int)</code>
    /// </summary>
    public sbyte Mark_Deleted(int a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.LRU_List, int, sbyte>)0x00676EB0)(ref this, a2);

    /// <summary>
    /// <code>Offset: 0x00676EF0
    /// bool __thiscall LRU_List::Write_All_Out(LRU_List*)</code>
    /// </summary>
    public byte Write_All_Out() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.LRU_List, byte>)0x00676EF0)(ref this);

    /// <summary>
    /// <code>Offset: 0x006771C0
    /// char __thiscall LRU_List::Mark_Used(DLListBase*,int)</code>
    /// </summary>
    public sbyte Mark_Used(int a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.LRU_List, int, sbyte>)0x006771C0)(ref this, a2);
}

