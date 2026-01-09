namespace ACBindings;

// CBldPortal
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
    // void __thiscall CBldPortal::CBldPortal(CBldPortal*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CBldPortal, void>)0x0053C890)(ref this);
    // void __thiscall CBldPortal::~CBldPortal(CBldPortal*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CBldPortal, void>)0x0053C8B0)(ref this);
    // void __thiscall CBldPortal::add_to_stablist(CBldPortal*,unsigned int**,unsigned int*,unsigned int*)
    public void add_to_stablist(uint** block_stab_list, uint* max_size, uint* stab_num) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CBldPortal, uint**, uint*, uint*, void>)0x0053C8C0)(ref this, block_stab_list, max_size, stab_num);
    // CEnvCell* __thiscall CBldPortal::GetOtherCell(CBldPortal*)
    public ACBindings.CEnvCell* GetOtherCell() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CBldPortal, ACBindings.CEnvCell*>)0x0053C990)(ref this);
    // int __thiscall CBldPortal::UnPack(CBldPortal*,unsigned int,void**,unsigned int)
    public int UnPack(uint block_mask, void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CBldPortal, uint, void**, uint, int>)0x0053C9A0)(ref this, block_mask, addr, size);
    // int __thiscall CBldPortal::PreFetchCells(CBldPortal*)
    public int PreFetchCells() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CBldPortal, int>)0x0053CA60)(ref this);
    // unsigned int __thiscall CBldPortal::pack_size(CBldPortal*)
    public uint pack_size() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CBldPortal, uint>)0x0053CAB0)(ref this);
    // unsigned int __thiscall CBldPortal::Pack(CBldPortal*,void**,unsigned int)
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CBldPortal, void**, uint, uint>)0x0053CAD0)(ref this, addr, size);
}

