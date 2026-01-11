namespace ACBindings.Internal;

public unsafe struct RegionMisc
{
    // Members
    public uint version;
    public ACBindings.Internal.IDClass____tagDataID game_map;
    public ACBindings.Internal.IDClass____tagDataID autotest_map;
    public uint autotest_map_size;
    public ACBindings.Internal.IDClass____tagDataID clear_cell;
    public ACBindings.Internal.IDClass____tagDataID clear_monster;

    // Methods

    /// <summary>
    /// <code>Offset: 0x004FF5A0
    /// unsigned int __thiscall RegionMisc::Pack(RegionMisc*,void**,unsigned int*)</code>
    /// </summary>
    public uint Pack(void** addr, uint* size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RegionMisc, void**, uint*, uint>)0x004FF5A0)(ref this, addr, size);

    /// <summary>
    /// <code>Offset: 0x004FF640
    /// int __thiscall RegionMisc::UnPack(RegionMisc*,void**,unsigned int*)</code>
    /// </summary>
    public int UnPack(void** addr, uint* size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RegionMisc, void**, uint*, int>)0x004FF640)(ref this, addr, size);
}

