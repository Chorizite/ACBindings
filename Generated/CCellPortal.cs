namespace ACBindings.Internal;

public unsafe struct CCellPortal
{
    // Members
    public uint other_cell_id;
    public ACBindings.Internal.CEnvCell* other_cell_ptr;
    public ACBindings.Internal.CPolygon* portal;
    public int portal_side;
    public int other_portal_id;
    public int exact_match;

    // Generated Constructor
    public CCellPortal() {
        _ConstructorInternal();
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x0053C770
    /// void __thiscall CCellPortal::CCellPortal(CCellPortal*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CCellPortal, void>)0x0053C770)(ref this);

    /// <summary>
    /// <code>Offset: 0x0053C790
    /// CEnvCell* __thiscall CCellPortal::GetOtherCell(CCellPortal*,int)</code>
    /// </summary>
    public ACBindings.Internal.CEnvCell* GetOtherCell(int do_not_load) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CCellPortal, int, ACBindings.Internal.CEnvCell*>)0x0053C790)(ref this, do_not_load);

    /// <summary>
    /// <code>Offset: 0x0053C7A0
    /// unsigned int __thiscall CCellPortal::Pack(CCellPortal*,void**,unsigned int)</code>
    /// </summary>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CCellPortal, void**, uint, uint>)0x0053C7A0)(ref this, addr, size);

    /// <summary>
    /// <code>Offset: 0x0053C810
    /// int __thiscall CCellPortal::UnPack(CCellPortal*,unsigned int,unsigned __int16*,void**,unsigned int)</code>
    /// </summary>
    public int UnPack(uint block_mask, ushort* poly_id, void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CCellPortal, uint, ushort*, void**, uint, int>)0x0053C810)(ref this, block_mask, poly_id, addr, size);
}

