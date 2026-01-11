namespace ACBindings.Internal;

public unsafe struct CBldPortal : System.IDisposable
{
    // Members
    public int portal_side;
    public uint other_cell_id;
    public int other_portal_id;
    public int exact_match;
    public uint num_stabs;
    public uint* stab_list;
    public float sidedness;

    // Generated Constructor
    public CBldPortal() {
        _ConstructorInternal();
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x0053C890
    /// void __thiscall CBldPortal::CBldPortal(CBldPortal*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CBldPortal, void>)0x0053C890)(ref this);

    /// <summary>
    /// <code>Offset: 0x0053C8B0
    /// void __thiscall CBldPortal::~CBldPortal(CBldPortal*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CBldPortal, void>)0x0053C8B0)(ref this);

    /// <summary>
    /// <code>Offset: 0x0053C8C0
    /// void __thiscall CBldPortal::add_to_stablist(CBldPortal*,unsigned int**,unsigned int*,unsigned int*)</code>
    /// </summary>
    public void add_to_stablist(uint** block_stab_list, uint* max_size, uint* stab_num) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CBldPortal, uint**, uint*, uint*, void>)0x0053C8C0)(ref this, block_stab_list, max_size, stab_num);

    /// <summary>
    /// <code>Offset: 0x0053C990
    /// CEnvCell* __thiscall CBldPortal::GetOtherCell(CBldPortal*)</code>
    /// </summary>
    public ACBindings.Internal.CEnvCell* GetOtherCell() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CBldPortal, ACBindings.Internal.CEnvCell*>)0x0053C990)(ref this);

    /// <summary>
    /// <code>Offset: 0x0053C9A0
    /// int __thiscall CBldPortal::UnPack(CBldPortal*,unsigned int,void**,unsigned int)</code>
    /// </summary>
    public int UnPack(uint block_mask, void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CBldPortal, uint, void**, uint, int>)0x0053C9A0)(ref this, block_mask, addr, size);

    /// <summary>
    /// <code>Offset: 0x0053CA60
    /// int __thiscall CBldPortal::PreFetchCells(CBldPortal*)</code>
    /// </summary>
    public int PreFetchCells() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CBldPortal, int>)0x0053CA60)(ref this);

    /// <summary>
    /// <code>Offset: 0x0053CAB0
    /// unsigned int __thiscall CBldPortal::pack_size(CBldPortal*)</code>
    /// </summary>
    public uint pack_size() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CBldPortal, uint>)0x0053CAB0)(ref this);

    /// <summary>
    /// <code>Offset: 0x0053CAD0
    /// unsigned int __thiscall CBldPortal::Pack(CBldPortal*,void**,unsigned int)</code>
    /// </summary>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CBldPortal, void**, uint, uint>)0x0053CAD0)(ref this, addr, size);
}

