namespace ACBindings.Internal;

public unsafe struct PalShiftTex
{
    // Members
    public ACBindings.Internal.IDClass____tagDataID tex_gid;
    public ACBindings.Internal.AC1Legacy.SmartArray___PalShiftSubPal_ptr sub_pal;
    public ACBindings.Internal.AC1Legacy.SmartArray___PalShiftRoadCode_ptr road_code;
    public ACBindings.Internal.AC1Legacy.SmartArray___PalShiftTerrainPal_ptr terrain_pal;

    // Methods

    /// <summary>
    /// <code>Offset: 0x00500A40
    /// void __thiscall PalShiftTex::Destroy(PalShiftTex*)</code>
    /// </summary>
    public void Destroy() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PalShiftTex, void>)0x00500A40)(ref this);

    /// <summary>
    /// <code>Offset: 0x00500B30
    /// unsigned int __thiscall PalShiftTex::Pack(PalShiftTex*,void**,unsigned int*)</code>
    /// </summary>
    public uint Pack(void** addr, uint* size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PalShiftTex, void**, uint*, uint>)0x00500B30)(ref this, addr, size);

    /// <summary>
    /// <code>Offset: 0x00500F70
    /// int __thiscall PalShiftTex::UnPack(PalShiftTex*,void**,unsigned int*)</code>
    /// </summary>
    public int UnPack(void** addr, uint* size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PalShiftTex, void**, uint*, int>)0x00500F70)(ref this, addr, size);
}

