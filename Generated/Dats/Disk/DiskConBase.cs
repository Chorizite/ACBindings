namespace ACBindings;

// DiskConBase
public unsafe struct DiskConBase
{
    // Child Types
    // DiskConBase_vtbl
    public unsafe struct DiskConBase_vtbl
    {
        // Members
        public System.IntPtr DiskConBase_dtor_0; // function pointer
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

        // Methods
    }

    // Members
    public System.IntPtr __vftable; // vtable pointer
    public byte initialized_fm;
    public byte read_only_fm;
    public byte expandable_fm;
    public ACBindings.DATFILE_TYPE data_set_lm;
    public uint data_subset_lm;

    // Methods
    // unsigned __int64 __thiscall DiskConBase::GetDatFileID(DiskConBase*)
    public ulong GetDatFileID() => ((delegate* unmanaged[Thiscall]<ref ACBindings.DiskConBase, ulong>)0x004F8DB0)(ref this);
    // bool __thiscall DiskConBase::IsInitialized(DiskConBase*)
    public byte IsInitialized() => ((delegate* unmanaged[Thiscall]<ref ACBindings.DiskConBase, byte>)0x004F8DD0)(ref this);
    // bool __thiscall DiskConBase::IsReadOnly(DiskConBase*)
    public byte IsReadOnly() => ((delegate* unmanaged[Thiscall]<ref ACBindings.DiskConBase, byte>)0x004F8DE0)(ref this);
    // bool __thiscall DiskConBase::IsExpandable(DiskConBase*)
    public byte IsExpandable() => ((delegate* unmanaged[Thiscall]<ref ACBindings.DiskConBase, byte>)0x004F8DF0)(ref this);
    // DatIDStamp* __thiscall DiskConBase::GetDatIDStamp(DiskConBase*,DatIDStamp*)
    public ACBindings.DatIDStamp* GetDatIDStamp(ACBindings.DatIDStamp* result) => ((delegate* unmanaged[Thiscall]<ref ACBindings.DiskConBase, ACBindings.DatIDStamp*, ACBindings.DatIDStamp*>)0x00671320)(ref this, result);
    // char __stdcall DiskConBase::SaveData(int,int,int)
    public static sbyte SaveData(int a1, int a2, int a3) => ((delegate* unmanaged[Stdcall]<int, int, int, sbyte>)0x006714B0)(a1, a2, a3);
    // IDClass<_tagDataID,32,0>* __stdcall DiskConBase::GetMasterMapDID(IDClass<_tagDataID,32,0>*)
    public static ACBindings.IDClass___tagDataID* GetMasterMapDID(ACBindings.IDClass___tagDataID* a1) => ((delegate* unmanaged[Stdcall]<ACBindings.IDClass___tagDataID*, ACBindings.IDClass___tagDataID*>)0x006714C0)(a1);
    // IDClass<_tagDataID,32,0>* __stdcall DiskConBase::SetMasterMapDID(IDClass<_tagDataID,32,0>*,int)
    public static ACBindings.IDClass___tagDataID* SetMasterMapDID(ACBindings.IDClass___tagDataID* a1, int a2) => ((delegate* unmanaged[Stdcall]<ACBindings.IDClass___tagDataID*, int, ACBindings.IDClass___tagDataID*>)0x006714D0)(a1, a2);
}

