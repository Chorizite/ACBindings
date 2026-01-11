namespace ACBindings.Internal;

public unsafe struct DiskController : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.DiskConBase BaseClass_DiskConBase; // ACBindings.Internal.DiskConBase

    // Child Types
    public unsafe struct DiskController_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DiskController*, void> DiskController_dtor_0; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DiskController*, ACBindings.Internal.DiskConInitInfo*, byte> InitFile; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DiskController*, byte> Close; // function pointer
        public System.IntPtr LoadData;
        public System.IntPtr SaveData;
        public System.IntPtr DeleteData;
        public System.IntPtr DeleteDataByMask;
        public System.IntPtr IsMember;
        public System.IntPtr GetMembers;
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DiskController*, int> HowmuchFreeSpace; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DiskController*, ACBindings.Internal.CMostlyConsecutiveIntSet*, byte> LoadIterationList; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DiskController*, ACBindings.Internal.CMostlyConsecutiveIntSet*, byte> SaveIterationList; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DiskController*, ACBindings.Internal.DATFILE_TYPE> GetDataset; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DiskController*, uint> GetSubset; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DiskController*, ulong> GetDatFileID; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DiskController*, byte> IsInitialized; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DiskController*, byte> IsReadOnly; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DiskController*, byte> IsExpandable; // function pointer
        public System.IntPtr GetMasterMapDID;
        public System.IntPtr SetMasterMapDID;
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DiskController*, ACBindings.Internal.DatIDStamp*, void> SetDatIDStamp; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DiskController*, ACBindings.Internal.DatIDStamp*, ACBindings.Internal.DatIDStamp*> GetDatIDStamp; // function pointer
        public System.IntPtr GetFilename;
        public System.IntPtr GetDataSize;
        public System.IntPtr GetUncompressedDataSize;
        public System.IntPtr GetDatestamp;
        public System.IntPtr GetIteration;
        public System.IntPtr GetVersion;
        public System.IntPtr GetIsCompressed;
        public System.IntPtr LoadDataEx;
        public System.IntPtr SaveAndCompressData;
        public System.IntPtr SavePreCompressedData;
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DiskController*, ACBindings.Internal.BTEntry*, ACBindings.Internal.Cache_Pack_t*, uint, byte> SaveDataEx; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DiskController*, ACBindings.Internal.Cache_Pack_t*, ACBindings.Internal.Cache_Pack_t*, byte> AttemptToCompress; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DiskController*, ACBindings.Internal.Cache_Pack_t*, ACBindings.Internal.Cache_Pack_t*, byte> Decompress; // function pointer

        // Methods
    }

    // Members
    public ACBindings.Internal.CLBlockAllocator block_man_m;
    public ACBindings.Internal.BTree did_tree_m;
    public ACBindings.Internal.PStringBase__sbyte filename_m;
    public ACBindings.Internal.DiskFileInfo_t file_info_m;

    // Generated Constructor
    public DiskController() {
        _ConstructorInternal();
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x004F8E00
    /// int __thiscall DiskController::HowmuchFreeSpace(DiskController*)</code>
    /// </summary>
    public int HowmuchFreeSpace() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DiskController, int>)0x004F8E00)(ref this);

    /// <summary>
    /// <code>Offset: 0x004F8E10
    /// DatIDStamp* __thiscall DiskController::GetDatIDStamp(DiskController*,DatIDStamp*)</code>
    /// </summary>
    public ACBindings.Internal.DatIDStamp* GetDatIDStamp(ACBindings.Internal.DatIDStamp* result) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DiskController, ACBindings.Internal.DatIDStamp*, ACBindings.Internal.DatIDStamp*>)0x004F8E10)(ref this, result);

    /// <summary>
    /// <code>Offset: 0x004F8E30
    /// char* __thiscall DiskController::GetFilename(char*)</code>
    /// </summary>
    public sbyte* GetFilename() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DiskController, sbyte*>)0x004F8E30)(ref this);

    /// <summary>
    /// <code>Offset: 0x004F8E40
    /// _DWORD* __thiscall DiskController::GetMasterMapDID(_DWORD*,_DWORD*)</code>
    /// </summary>
    public int* GetMasterMapDID(int* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DiskController, int*, int*>)0x004F8E40)(ref this, a2);

    /// <summary>
    /// <code>Offset: 0x00671360
    /// bool __thiscall DiskController::Close(DiskController*)</code>
    /// </summary>
    public byte Close() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DiskController, byte>)0x00671360)(ref this);

    /// <summary>
    /// <code>Offset: 0x006713A0
    /// char __thiscall DiskController::GetMembers(int,_DWORD*)</code>
    /// </summary>
    public sbyte GetMembers(int* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DiskController, int*, sbyte>)0x006713A0)(ref this, a2);

    /// <summary>
    /// <code>Offset: 0x006713B0
    /// void __thiscall DiskController::SetDatIDStamp(DiskController*,DatIDStamp*)</code>
    /// </summary>
    public void SetDatIDStamp(ACBindings.Internal.DatIDStamp* stamp) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DiskController, ACBindings.Internal.DatIDStamp*, void>)0x006713B0)(ref this, stamp);

    /// <summary>
    /// <code>Offset: 0x006714E0
    /// int __thiscall DiskController::SaveData(void*,int,int,int)</code>
    /// </summary>
    public int SaveData(int a2, int a3, int a4) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DiskController, int, int, int, int>)0x006714E0)(ref this, a2, a3, a4);

    /// <summary>
    /// <code>Offset: 0x00671530
    /// int __thiscall DiskController::SaveAndCompressData(void*,int,int,int)</code>
    /// </summary>
    public int SaveAndCompressData(int a2, int a3, int a4) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DiskController, int, int, int, int>)0x00671530)(ref this, a2, a3, a4);

    /// <summary>
    /// <code>Offset: 0x00671580
    /// int __thiscall DiskController::SavePreCompressedData(void*,int,int,int)</code>
    /// </summary>
    public int SavePreCompressedData(int a2, int a3, int a4) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DiskController, int, int, int, int>)0x00671580)(ref this, a2, a3, a4);

    /// <summary>
    /// <code>Offset: 0x006715D0
    /// bool __thiscall DiskController::AttemptToCompress(DiskController*,const Cache_Pack_t*,Cache_Pack_t*)</code>
    /// </summary>
    public byte AttemptToCompress(ACBindings.Internal.Cache_Pack_t* i_cpUncompressed, ACBindings.Internal.Cache_Pack_t* o_cpCompressed) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DiskController, ACBindings.Internal.Cache_Pack_t*, ACBindings.Internal.Cache_Pack_t*, byte>)0x006715D0)(ref this, i_cpUncompressed, o_cpCompressed);

    /// <summary>
    /// <code>Offset: 0x00671730
    /// bool __thiscall DiskController::CheckRoom(DiskController*,int)</code>
    /// </summary>
    public byte CheckRoom(int size_l) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DiskController, int, byte>)0x00671730)(ref this, size_l);

    /// <summary>
    /// <code>Offset: 0x00671780
    /// int __thiscall DiskController::GetDatestamp(void*,int)</code>
    /// </summary>
    public int GetDatestamp(int a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DiskController, int, int>)0x00671780)(ref this, a2);

    /// <summary>
    /// <code>Offset: 0x006717D0
    /// unsigned int __thiscall DiskController::GetVersion(int*,int)</code>
    /// </summary>
    public uint GetVersion(int a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DiskController, int, uint>)0x006717D0)(ref this, a2);

    /// <summary>
    /// <code>Offset: 0x00671830
    /// char __thiscall DiskController::GetIsCompressed(int*,int)</code>
    /// </summary>
    public sbyte GetIsCompressed(int a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DiskController, int, sbyte>)0x00671830)(ref this, a2);

    /// <summary>
    /// <code>Offset: 0x00671890
    /// int __thiscall DiskController::GetIteration(void*,int)</code>
    /// </summary>
    public int GetIteration(int a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DiskController, int, int>)0x00671890)(ref this, a2);

    /// <summary>
    /// <code>Offset: 0x006718E0
    /// int __thiscall DiskController::GetDataSize(void*,int)</code>
    /// </summary>
    public int GetDataSize(int a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DiskController, int, int>)0x006718E0)(ref this, a2);

    /// <summary>
    /// <code>Offset: 0x00671930
    /// int __thiscall DiskController::GetUncompressedDataSize(int*,int)</code>
    /// </summary>
    public int GetUncompressedDataSize(int a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DiskController, int, int>)0x00671930)(ref this, a2);

    /// <summary>
    /// <code>Offset: 0x00671A20
    /// bool __thiscall DiskController::Decompress(DiskController*,const Cache_Pack_t*,Cache_Pack_t*)</code>
    /// </summary>
    public byte Decompress(ACBindings.Internal.Cache_Pack_t* i_cpCompressed, ACBindings.Internal.Cache_Pack_t* o_cpUncompressed) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DiskController, ACBindings.Internal.Cache_Pack_t*, ACBindings.Internal.Cache_Pack_t*, byte>)0x00671A20)(ref this, i_cpCompressed, o_cpUncompressed);

    /// <summary>
    /// <code>Offset: 0x00671B20
    /// int __thiscall DiskController::LoadData(void*,int,int)</code>
    /// </summary>
    public int LoadData(int a2, int a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DiskController, int, int, int>)0x00671B20)(ref this, a2, a3);

    /// <summary>
    /// <code>Offset: 0x00671B60
    /// char __thiscall DiskController::LoadDataEx(int,int,Cache_Pack_t*,LONG*,char)</code>
    /// </summary>
    public sbyte LoadDataEx(int a2, ACBindings.Internal.Cache_Pack_t* nNumberOfBytesToRead, int* bShortRead, sbyte a5) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DiskController, int, ACBindings.Internal.Cache_Pack_t*, int*, sbyte, sbyte>)0x00671B60)(ref this, a2, nNumberOfBytesToRead, bShortRead, a5);

    /// <summary>
    /// <code>Offset: 0x00671CB0
    /// int __thiscall DiskController::IsMember(void*,int,int*)</code>
    /// </summary>
    public int IsMember(int a2, int* a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DiskController, int, int*, int>)0x00671CB0)(ref this, a2, a3);

    /// <summary>
    /// <code>Offset: 0x00671D00
    /// bool __thiscall DiskController::DeleteData(int,unsigned int,int)</code>
    /// </summary>
    public byte DeleteData(uint a2, int a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DiskController, uint, int, byte>)0x00671D00)(ref this, a2, a3);

    /// <summary>
    /// <code>Offset: 0x00671D40
    /// IDClass&lt;_tagDataID,32,0&gt;* __thiscall DiskController::SetMasterMapDID(int,IDClass&lt;_tagDataID,32,0&gt;*,int)</code>
    /// </summary>
    public ACBindings.Internal.IDClass____tagDataID* SetMasterMapDID(ACBindings.Internal.IDClass____tagDataID* a2, int a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DiskController, ACBindings.Internal.IDClass____tagDataID*, int, ACBindings.Internal.IDClass____tagDataID*>)0x00671D40)(ref this, a2, a3);

    /// <summary>
    /// <code>Offset: 0x00671D80
    /// bool __thiscall DiskController::LoadIterationList(DiskController*,CMostlyConsecutiveIntSet*)</code>
    /// </summary>
    public byte LoadIterationList(ACBindings.Internal.CMostlyConsecutiveIntSet* Iters) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DiskController, ACBindings.Internal.CMostlyConsecutiveIntSet*, byte>)0x00671D80)(ref this, Iters);

    /// <summary>
    /// <code>Offset: 0x00671E80
    /// bool __thiscall DiskController::SaveIterationList(DiskController*,CMostlyConsecutiveIntSet*)</code>
    /// </summary>
    public byte SaveIterationList(ACBindings.Internal.CMostlyConsecutiveIntSet* Iters) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DiskController, ACBindings.Internal.CMostlyConsecutiveIntSet*, byte>)0x00671E80)(ref this, Iters);

    /// <summary>
    /// <code>Offset: 0x00671F80
    /// void __thiscall DiskController::DiskController(DiskController*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DiskController, void>)0x00671F80)(ref this);

    /// <summary>
    /// <code>Offset: 0x00671FE0
    /// void __thiscall DiskController::~DiskController(DiskController*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DiskController, void>)0x00671FE0)(ref this);

    /// <summary>
    /// <code>Offset: 0x00672060
    /// bool __thiscall DiskController::SaveDataEx(DiskController*,BTEntry*,Cache_Pack_t*,unsigned int)</code>
    /// </summary>
    public byte SaveDataEx(ACBindings.Internal.BTEntry* io_entNew, ACBindings.Internal.Cache_Pack_t* i_cpUser, uint dwFlags) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DiskController, ACBindings.Internal.BTEntry*, ACBindings.Internal.Cache_Pack_t*, uint, byte>)0x00672060)(ref this, io_entNew, i_cpUser, dwFlags);

    /// <summary>
    /// <code>Offset: 0x006722B0
    /// char __thiscall DiskController::DeleteDataByMask(char*,int,int)</code>
    /// </summary>
    public sbyte DeleteDataByMask(int a2, int a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DiskController, int, int, sbyte>)0x006722B0)(ref this, a2, a3);

    /// <summary>
    /// <code>Offset: 0x006723D0
    /// bool __thiscall DiskController::InitFile(DiskController*,DiskConInitInfo*)</code>
    /// </summary>
    public byte InitFile(ACBindings.Internal.DiskConInitInfo* info_r) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DiskController, ACBindings.Internal.DiskConInitInfo*, byte>)0x006723D0)(ref this, info_r);
}

