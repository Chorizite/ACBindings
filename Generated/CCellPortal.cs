namespace ACBindings;

// CCellPortal
public unsafe struct CCellPortal
{
    // Members
    public uint other_cell_id;
    public ACBindings.CEnvCell* other_cell_ptr;
    public ACBindings.CPolygon* portal;
    public int portal_side;
    public int other_portal_id;
    public int exact_match;

    // Generated Constructor
    public CCellPortal() {
        _ConstructorInternal();
    }

    // Methods
    // void __thiscall CCellPortal::CCellPortal(CCellPortal*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CCellPortal, void>)0x0053C770)(ref this);
    // CEnvCell* __thiscall CCellPortal::GetOtherCell(CCellPortal*,int)
    public ACBindings.CEnvCell* GetOtherCell(int do_not_load) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CCellPortal, int, ACBindings.CEnvCell*>)0x0053C790)(ref this, do_not_load);
    // unsigned int __thiscall CCellPortal::Pack(CCellPortal*,void**,unsigned int)
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CCellPortal, void**, uint, uint>)0x0053C7A0)(ref this, addr, size);
    // int __thiscall CCellPortal::UnPack(CCellPortal*,unsigned int,unsigned __int16*,void**,unsigned int)
    public int UnPack(uint block_mask, ushort* poly_id, void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CCellPortal, uint, ushort*, void**, uint, int>)0x0053C810)(ref this, block_mask, poly_id, addr, size);
}

