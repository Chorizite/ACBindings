namespace ACBindings;

// DiskFileInfo_t
public unsafe struct DiskFileInfo_t
{
    // Members
    public int magic_;
    public int iBlockSize_;
    public uint fileSize_;
    public ACBindings.DATFILE_TYPE data_set_lm;
    public uint data_subset_lm;
    public int firstFree_;
    public int finalFree_;
    public int iFreeBlocks_;
    public int btreeRoot_;
    public int young_lru_lm;
    public int old_lru_lm;
    public byte use_lru_fm;
    public ACBindings.IDClass___tagDataID master_map_id_m;
    public int eng_pack_vnum;
    public int game_pack_vnum;
    public ACBindings.DatIDStamp id_vnum;

    // Generated Constructor
    public DiskFileInfo_t() {
        _ConstructorInternal();
    }

    // Methods
    // void __thiscall DiskFileInfo_t::ClearData(DiskFileInfo_t*)
    public void ClearData() => ((delegate* unmanaged[Thiscall]<ref ACBindings.DiskFileInfo_t, void>)0x006712D0)(ref this);
    // void __thiscall DiskFileInfo_t::DiskFileInfo_t(DiskFileInfo_t*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.DiskFileInfo_t, void>)0x006713E0)(ref this);
}

