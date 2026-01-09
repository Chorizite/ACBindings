namespace ACBindings;

// RegionMisc
public unsafe struct RegionMisc
{
    // Members
    public uint version;
    public ACBindings.IDClass___tagDataID game_map;
    public ACBindings.IDClass___tagDataID autotest_map;
    public uint autotest_map_size;
    public ACBindings.IDClass___tagDataID clear_cell;
    public ACBindings.IDClass___tagDataID clear_monster;

    // Methods
    // unsigned int __thiscall RegionMisc::Pack(RegionMisc*,void**,unsigned int*)
    public uint Pack(void** addr, uint* size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.RegionMisc, void**, uint*, uint>)0x004FF5A0)(ref this, addr, size);
    // int __thiscall RegionMisc::UnPack(RegionMisc*,void**,unsigned int*)
    public int UnPack(void** addr, uint* size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.RegionMisc, void**, uint*, int>)0x004FF640)(ref this, addr, size);
}

