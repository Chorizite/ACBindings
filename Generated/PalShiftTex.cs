namespace ACBindings;

// PalShiftTex
public unsafe struct PalShiftTex
{
    // Members
    public ACBindings.IDClass___tagDataID tex_gid;
    public ACBindings.AC1Legacy.SmartArray__PalShiftSubPal_ptr sub_pal;
    public ACBindings.AC1Legacy.SmartArray__PalShiftRoadCode_ptr road_code;
    public ACBindings.AC1Legacy.SmartArray__PalShiftTerrainPal_ptr terrain_pal;

    // Methods
    // void __thiscall PalShiftTex::Destroy(PalShiftTex*)
    public void Destroy() => ((delegate* unmanaged[Thiscall]<ref ACBindings.PalShiftTex, void>)0x00500A40)(ref this);
    // unsigned int __thiscall PalShiftTex::Pack(PalShiftTex*,void**,unsigned int*)
    public uint Pack(void** addr, uint* size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.PalShiftTex, void**, uint*, uint>)0x00500B30)(ref this, addr, size);
    // int __thiscall PalShiftTex::UnPack(PalShiftTex*,void**,unsigned int*)
    public int UnPack(void** addr, uint* size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.PalShiftTex, void**, uint*, int>)0x00500F70)(ref this, addr, size);
}

