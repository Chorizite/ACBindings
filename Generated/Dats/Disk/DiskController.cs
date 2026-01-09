namespace ACBindings;

// DiskController
public unsafe struct DiskController : System.IDisposable
{
    // Base Classes
    public ACBindings.DiskConBase BaseClass_DiskConBase; // ACBindings.DiskConBase

    // Child Types
    // DiskController_vtbl
    public unsafe struct DiskController_vtbl
    {
        // Members
        public System.IntPtr DiskController_dtor_0; // function pointer
        public System.IntPtr InitFile; // function pointer
        public System.IntPtr Close; // function pointer
        public System.IntPtr LoadData;
        public System.IntPtr SaveData;
        public System.IntPtr DeleteData;
        public System.IntPtr DeleteDataByMask;
        public System.IntPtr IsMember;
        public System.IntPtr GetMembers;
        public System.IntPtr HowmuchFreeSpace; // function pointer
        public System.IntPtr LoadIterationList; // function pointer
        public System.IntPtr SaveIterationList; // function pointer
        public System.IntPtr GetDataset; // function pointer
        public System.IntPtr GetSubset; // function pointer
        public System.IntPtr GetDatFileID; // function pointer
        public System.IntPtr IsInitialized; // function pointer
        public System.IntPtr IsReadOnly; // function pointer
        public System.IntPtr IsExpandable; // function pointer
        public System.IntPtr GetMasterMapDID;
        public System.IntPtr SetMasterMapDID;
        public System.IntPtr SetDatIDStamp; // function pointer
        public System.IntPtr GetDatIDStamp; // function pointer
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
        public System.IntPtr SaveDataEx; // function pointer
        public System.IntPtr AttemptToCompress; // function pointer
        public System.IntPtr Decompress; // function pointer

        // Methods
    }

    // Members
    public ACBindings.CLBlockAllocator block_man_m;
    public ACBindings.BTree did_tree_m;
    public ACBindings.PStringBase__sbyte filename_m;
    public ACBindings.DiskFileInfo_t file_info_m;

    // Generated Constructor
    public DiskController() {
        _ConstructorInternal();
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods
    // int __thiscall DiskController::HowmuchFreeSpace(DiskController*)
    public int HowmuchFreeSpace() => ((delegate* unmanaged[Thiscall]<ref ACBindings.DiskController, int>)0x004F8E00)(ref this);
    // DatIDStamp* __thiscall DiskController::GetDatIDStamp(DiskController*,DatIDStamp*)
    public ACBindings.DatIDStamp* GetDatIDStamp(ACBindings.DatIDStamp* result) => ((delegate* unmanaged[Thiscall]<ref ACBindings.DiskController, ACBindings.DatIDStamp*, ACBindings.DatIDStamp*>)0x004F8E10)(ref this, result);
    // char* __thiscall DiskController::GetFilename(char*)
    public sbyte* GetFilename() => ((delegate* unmanaged[Thiscall]<ref ACBindings.DiskController, sbyte*>)0x004F8E30)(ref this);
    // _DWORD* __thiscall DiskController::GetMasterMapDID(_DWORD*,_DWORD*)
    public int* GetMasterMapDID(int* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.DiskController, int*, int*>)0x004F8E40)(ref this, a2);
    // bool __thiscall DiskController::Close(DiskController*)
    public byte Close() => ((delegate* unmanaged[Thiscall]<ref ACBindings.DiskController, byte>)0x00671360)(ref this);
    // char __thiscall DiskController::GetMembers(int,_DWORD*)
    public sbyte GetMembers(int* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.DiskController, int*, sbyte>)0x006713A0)(ref this, a2);
    // void __thiscall DiskController::SetDatIDStamp(DiskController*,DatIDStamp*)
    public void SetDatIDStamp(ACBindings.DatIDStamp* stamp) => ((delegate* unmanaged[Thiscall]<ref ACBindings.DiskController, ACBindings.DatIDStamp*, void>)0x006713B0)(ref this, stamp);
    // int __thiscall DiskController::SaveData(void*,int,int,int)
    public int SaveData(int a2, int a3, int a4) => ((delegate* unmanaged[Thiscall]<ref ACBindings.DiskController, int, int, int, int>)0x006714E0)(ref this, a2, a3, a4);
    // int __thiscall DiskController::SaveAndCompressData(void*,int,int,int)
    public int SaveAndCompressData(int a2, int a3, int a4) => ((delegate* unmanaged[Thiscall]<ref ACBindings.DiskController, int, int, int, int>)0x00671530)(ref this, a2, a3, a4);
    // int __thiscall DiskController::SavePreCompressedData(void*,int,int,int)
    public int SavePreCompressedData(int a2, int a3, int a4) => ((delegate* unmanaged[Thiscall]<ref ACBindings.DiskController, int, int, int, int>)0x00671580)(ref this, a2, a3, a4);
    // bool __thiscall DiskController::AttemptToCompress(DiskController*,const Cache_Pack_t*,Cache_Pack_t*)
    public byte AttemptToCompress(ACBindings.Cache_Pack_t* i_cpUncompressed, ACBindings.Cache_Pack_t* o_cpCompressed) => ((delegate* unmanaged[Thiscall]<ref ACBindings.DiskController, ACBindings.Cache_Pack_t*, ACBindings.Cache_Pack_t*, byte>)0x006715D0)(ref this, i_cpUncompressed, o_cpCompressed);
    // bool __thiscall DiskController::CheckRoom(DiskController*,int)
    public byte CheckRoom(int size_l) => ((delegate* unmanaged[Thiscall]<ref ACBindings.DiskController, int, byte>)0x00671730)(ref this, size_l);
    // int __thiscall DiskController::GetDatestamp(void*,int)
    public int GetDatestamp(int a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.DiskController, int, int>)0x00671780)(ref this, a2);
    // unsigned int __thiscall DiskController::GetVersion(int*,int)
    public uint GetVersion(int a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.DiskController, int, uint>)0x006717D0)(ref this, a2);
    // char __thiscall DiskController::GetIsCompressed(int*,int)
    public sbyte GetIsCompressed(int a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.DiskController, int, sbyte>)0x00671830)(ref this, a2);
    // int __thiscall DiskController::GetIteration(void*,int)
    public int GetIteration(int a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.DiskController, int, int>)0x00671890)(ref this, a2);
    // int __thiscall DiskController::GetDataSize(void*,int)
    public int GetDataSize(int a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.DiskController, int, int>)0x006718E0)(ref this, a2);
    // int __thiscall DiskController::GetUncompressedDataSize(int*,int)
    public int GetUncompressedDataSize(int a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.DiskController, int, int>)0x00671930)(ref this, a2);
    // bool __thiscall DiskController::Decompress(DiskController*,const Cache_Pack_t*,Cache_Pack_t*)
    public byte Decompress(ACBindings.Cache_Pack_t* i_cpCompressed, ACBindings.Cache_Pack_t* o_cpUncompressed) => ((delegate* unmanaged[Thiscall]<ref ACBindings.DiskController, ACBindings.Cache_Pack_t*, ACBindings.Cache_Pack_t*, byte>)0x00671A20)(ref this, i_cpCompressed, o_cpUncompressed);
    // int __thiscall DiskController::LoadData(void*,int,int)
    public int LoadData(int a2, int a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.DiskController, int, int, int>)0x00671B20)(ref this, a2, a3);
    // char __thiscall DiskController::LoadDataEx(int,int,Cache_Pack_t*,LONG*,char)
    public sbyte LoadDataEx(int a2, ACBindings.Cache_Pack_t* nNumberOfBytesToRead, int* bShortRead, sbyte a5) => ((delegate* unmanaged[Thiscall]<ref ACBindings.DiskController, int, ACBindings.Cache_Pack_t*, int*, sbyte, sbyte>)0x00671B60)(ref this, a2, nNumberOfBytesToRead, bShortRead, a5);
    // int __thiscall DiskController::IsMember(void*,int,int*)
    public int IsMember(int a2, int* a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.DiskController, int, int*, int>)0x00671CB0)(ref this, a2, a3);
    // bool __thiscall DiskController::DeleteData(int,unsigned int,int)
    public byte DeleteData(uint a2, int a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.DiskController, uint, int, byte>)0x00671D00)(ref this, a2, a3);
    // IDClass<_tagDataID,32,0>* __thiscall DiskController::SetMasterMapDID(int,IDClass<_tagDataID,32,0>*,int)
    public ACBindings.IDClass___tagDataID* SetMasterMapDID(ACBindings.IDClass___tagDataID* a2, int a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.DiskController, ACBindings.IDClass___tagDataID*, int, ACBindings.IDClass___tagDataID*>)0x00671D40)(ref this, a2, a3);
    // bool __thiscall DiskController::LoadIterationList(DiskController*,CMostlyConsecutiveIntSet*)
    public byte LoadIterationList(ACBindings.CMostlyConsecutiveIntSet* Iters) => ((delegate* unmanaged[Thiscall]<ref ACBindings.DiskController, ACBindings.CMostlyConsecutiveIntSet*, byte>)0x00671D80)(ref this, Iters);
    // bool __thiscall DiskController::SaveIterationList(DiskController*,CMostlyConsecutiveIntSet*)
    public byte SaveIterationList(ACBindings.CMostlyConsecutiveIntSet* Iters) => ((delegate* unmanaged[Thiscall]<ref ACBindings.DiskController, ACBindings.CMostlyConsecutiveIntSet*, byte>)0x00671E80)(ref this, Iters);
    // void __thiscall DiskController::DiskController(DiskController*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.DiskController, void>)0x00671F80)(ref this);
    // void __thiscall DiskController::~DiskController(DiskController*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.DiskController, void>)0x00671FE0)(ref this);
    // bool __thiscall DiskController::SaveDataEx(DiskController*,BTEntry*,Cache_Pack_t*,unsigned int)
    public byte SaveDataEx(ACBindings.BTEntry* io_entNew, ACBindings.Cache_Pack_t* i_cpUser, uint dwFlags) => ((delegate* unmanaged[Thiscall]<ref ACBindings.DiskController, ACBindings.BTEntry*, ACBindings.Cache_Pack_t*, uint, byte>)0x00672060)(ref this, io_entNew, i_cpUser, dwFlags);
    // char __thiscall DiskController::DeleteDataByMask(char*,int,int)
    public sbyte DeleteDataByMask(int a2, int a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.DiskController, int, int, sbyte>)0x006722B0)(ref this, a2, a3);
    // bool __thiscall DiskController::InitFile(DiskController*,DiskConInitInfo*)
    public byte InitFile(ACBindings.DiskConInitInfo* info_r) => ((delegate* unmanaged[Thiscall]<ref ACBindings.DiskController, ACBindings.DiskConInitInfo*, byte>)0x006723D0)(ref this, info_r);
}

