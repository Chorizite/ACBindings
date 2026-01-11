namespace ACBindings.Internal;

public unsafe struct DiskConInitInfo
{
    // Members
    public ACBindings.Internal.PStringBase__sbyte file;
    public ACBindings.Internal.PStringBase__ushort path;
    public ACBindings.Internal.DATFILE_TYPE data_set_lm;
    public uint data_subset_lm;
    public uint open_flags_lm;
    public int file_size_lm;
    public int block_size_lm;
    public int eng_pack_vnum;
    public int game_pack_vnum;
    public byte eng_only;

    // Generated Constructor
    public DiskConInitInfo(int* a2, int* a3, int a4, int a5, int a6, int a7, int a8, int a9, int a10, sbyte a11) {
        _ConstructorInternal(a2, a3, a4, a5, a6, a7, a8, a9, a10, a11);
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x004F8720
    /// int* __thiscall DiskConInitInfo::DiskConInitInfo(int*,int*,int*,int,int,int,int,int,int,int,char)</code>
    /// </summary>
    public int* _ConstructorInternal(int* a2, int* a3, int a4, int a5, int a6, int a7, int a8, int a9, int a10, sbyte a11) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DiskConInitInfo, int*, int*, int, int, int, int, int, int, int, sbyte, int*>)0x004F8720)(ref this, a2, a3, a4, a5, a6, a7, a8, a9, a10, a11);
}

