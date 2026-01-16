namespace ACBindings.Internal;


/// <summary>
/// Holds configuration data for initializing a disk connection used to load engine or game packages from a dataset. Includes file and path strings, dataset identifiers (type and subset), open flags, file size, block size, package version numbers, and an engine‑only flag.
/// </summary>
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

    /// <summary>Initializes a DiskConInitInfo object with specified file and path strings, dataset identifiers, open flags, size and block parameters, package versions, and an engine‑only flag while incrementing the reference counts of the supplied file and path objects.
    /// <code>Offset: 0x004F8720
    /// int* __thiscall DiskConInitInfo::DiskConInitInfo(int*,int*,int*,int,int,int,int,int,int,int,char)</code>
    /// </summary>
    /// <param name="filePtr">Pointer to the PStringBase&lt;char&gt; representing the file name; its reference count is increased.</param>
    /// <param name="pathPtr">Pointer to the PStringBase&lt;unsigned short&gt; representing the path; its reference count is increased.</param>
    /// <param name="dataSet">Dataset identifier (DATFILE_TYPE).</param>
    /// <param name="dataSubset">Subset number within the dataset.</param>
    /// <param name="openFlags">Flags controlling file opening behavior.</param>
    /// <param name="fileSize">Size of the disk image in bytes.</param>
    /// <param name="blockSize">Block size used when accessing the disk image.</param>
    /// <param name="engPackVnum">Engine package version number.</param>
    /// <param name="gamePackVnum">Game package version number.</param>
    /// <param name="engOnly">Non‑zero if only engine data is included; otherwise zero.</param>
    /// <returns>Pointer to the initialized DiskConInitInfo instance.</returns>
    public int* _ConstructorInternal(int* a2, int* a3, int a4, int a5, int a6, int a7, int a8, int a9, int a10, sbyte a11) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DiskConInitInfo, int*, int*, int, int, int, int, int, int, int, sbyte, int*>)0x004F8720)(ref this, a2, a3, a4, a5, a6, a7, a8, a9, a10, a11);
}

