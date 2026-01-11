namespace ACBindings.Internal;

public unsafe struct DiskConBase
{
    // Child Types
    public unsafe struct DiskConBase_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DiskConBase*, void> DiskConBase_dtor_0; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DiskConBase*, ACBindings.Internal.DiskConInitInfo*, byte> InitFile; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DiskConBase*, byte> Close; // function pointer
        public System.IntPtr LoadData;
        public System.IntPtr SaveData;
        public System.IntPtr DeleteData;
        public System.IntPtr DeleteDataByMask;
        public System.IntPtr IsMember;
        public System.IntPtr GetMembers;
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DiskConBase*, int> HowmuchFreeSpace; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DiskConBase*, ACBindings.Internal.CMostlyConsecutiveIntSet*, byte> LoadIterationList; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DiskConBase*, ACBindings.Internal.CMostlyConsecutiveIntSet*, byte> SaveIterationList; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DiskConBase*, ACBindings.Internal.DATFILE_TYPE> GetDataset; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DiskConBase*, uint> GetSubset; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DiskConBase*, ulong> GetDatFileID; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DiskConBase*, byte> IsInitialized; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DiskConBase*, byte> IsReadOnly; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DiskConBase*, byte> IsExpandable; // function pointer
        public System.IntPtr GetMasterMapDID;
        public System.IntPtr SetMasterMapDID;
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DiskConBase*, ACBindings.Internal.DatIDStamp*, void> SetDatIDStamp; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DiskConBase*, ACBindings.Internal.DatIDStamp*, ACBindings.Internal.DatIDStamp*> GetDatIDStamp; // function pointer
        public System.IntPtr GetFilename;

        // Methods
    }

    // Members
    public System.IntPtr __vftable; // vtable pointer
    public byte initialized_fm;
    public byte read_only_fm;
    public byte expandable_fm;
    public ACBindings.Internal.DATFILE_TYPE data_set_lm;
    public uint data_subset_lm;

    // Methods

    /// <summary>
    /// <code>Offset: 0x004F8DB0
    /// unsigned __int64 __thiscall DiskConBase::GetDatFileID(DiskConBase*)</code>
    /// </summary>
    public ulong GetDatFileID() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DiskConBase, ulong>)0x004F8DB0)(ref this);

    /// <summary>
    /// <code>Offset: 0x004F8DD0
    /// bool __thiscall DiskConBase::IsInitialized(DiskConBase*)</code>
    /// </summary>
    public byte IsInitialized() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DiskConBase, byte>)0x004F8DD0)(ref this);

    /// <summary>
    /// <code>Offset: 0x004F8DE0
    /// bool __thiscall DiskConBase::IsReadOnly(DiskConBase*)</code>
    /// </summary>
    public byte IsReadOnly() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DiskConBase, byte>)0x004F8DE0)(ref this);

    /// <summary>
    /// <code>Offset: 0x004F8DF0
    /// bool __thiscall DiskConBase::IsExpandable(DiskConBase*)</code>
    /// </summary>
    public byte IsExpandable() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DiskConBase, byte>)0x004F8DF0)(ref this);

    /// <summary>
    /// <code>Offset: 0x00671320
    /// DatIDStamp* __thiscall DiskConBase::GetDatIDStamp(DiskConBase*,DatIDStamp*)</code>
    /// </summary>
    public ACBindings.Internal.DatIDStamp* GetDatIDStamp(ACBindings.Internal.DatIDStamp* result) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DiskConBase, ACBindings.Internal.DatIDStamp*, ACBindings.Internal.DatIDStamp*>)0x00671320)(ref this, result);

    /// <summary>
    /// <code>Offset: 0x006714B0
    /// char __stdcall DiskConBase::SaveData(int,int,int)</code>
    /// </summary>
    public static sbyte SaveData(int a1, int a2, int a3) => ((delegate* unmanaged[Stdcall]<int, int, int, sbyte>)0x006714B0)(a1, a2, a3);

    /// <summary>
    /// <code>Offset: 0x006714C0
    /// IDClass&lt;_tagDataID,32,0&gt;* __stdcall DiskConBase::GetMasterMapDID(IDClass&lt;_tagDataID,32,0&gt;*)</code>
    /// </summary>
    public static ACBindings.Internal.IDClass____tagDataID* GetMasterMapDID(ACBindings.Internal.IDClass____tagDataID* a1) => ((delegate* unmanaged[Stdcall]<ACBindings.Internal.IDClass____tagDataID*, ACBindings.Internal.IDClass____tagDataID*>)0x006714C0)(a1);

    /// <summary>
    /// <code>Offset: 0x006714D0
    /// IDClass&lt;_tagDataID,32,0&gt;* __stdcall DiskConBase::SetMasterMapDID(IDClass&lt;_tagDataID,32,0&gt;*,int)</code>
    /// </summary>
    public static ACBindings.Internal.IDClass____tagDataID* SetMasterMapDID(ACBindings.Internal.IDClass____tagDataID* a1, int a2) => ((delegate* unmanaged[Stdcall]<ACBindings.Internal.IDClass____tagDataID*, int, ACBindings.Internal.IDClass____tagDataID*>)0x006714D0)(a1, a2);
}

