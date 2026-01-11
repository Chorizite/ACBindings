namespace ACBindings.Internal;

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

    /// <summary>
    /// <code>Offset: 0x006759D0
    /// void __thiscall LRUB_Mem_t::LRUB_Mem_t(LRUB_Mem_t*,const LRUB_Mem_t*)</code>
    /// </summary>
    public void _ConstructorInternal(ACBindings.Internal.LRUB_Mem_t* source) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.LRUB_Mem_t, ACBindings.Internal.LRUB_Mem_t*, void>)0x006759D0)(ref this, source);

    /// <summary>
    /// <code>Offset: 0x00675A50
    /// void __thiscall LRUB_Mem_t::Make_Buffer(LRUB_Mem_t*,int)</code>
    /// </summary>
    public void Make_Buffer(int size_l) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.LRUB_Mem_t, int, void>)0x00675A50)(ref this, size_l);

    /// <summary>
    /// <code>Offset: 0x00675B00
    /// void __thiscall LRUB_Mem_t::LRUB_Mem_t(LRUB_Mem_t*,int)</code>
    /// </summary>
    public void _ConstructorInternal(int block_size_l) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.LRUB_Mem_t, int, void>)0x00675B00)(ref this, block_size_l);

    /// <summary>
    /// <code>Offset: 0x00675B40
    /// unsigned int* __thiscall LRUB_Mem_t::Remove_Below(_DWORD*,unsigned int*)</code>
    /// </summary>
    public uint* Remove_Below(uint* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.LRUB_Mem_t, uint*, uint*>)0x00675B40)(ref this, a2);

    /// <summary>
    /// <code>Offset: 0x00675B80
    /// unsigned int* __thiscall LRUB_Mem_t::Remove_Above(_DWORD*,unsigned int*)</code>
    /// </summary>
    public uint* Remove_Above(uint* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.LRUB_Mem_t, uint*, uint*>)0x00675B80)(ref this, a2);

    /// <summary>
    /// <code>Offset: 0x00675BD0
    /// unsigned int* __thiscall LRUB_Mem_t::Peek_Above(_DWORD*,unsigned int*)</code>
    /// </summary>
    public uint* Peek_Above(uint* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.LRUB_Mem_t, uint*, uint*>)0x00675BD0)(ref this, a2);
}

