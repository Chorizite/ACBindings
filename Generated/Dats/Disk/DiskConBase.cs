namespace ACBindings.Internal;


/// <summary>Acts as the foundational representation of a disk container within the application. Tracks initialization status, read‑only mode, expandability, and holds identifiers for its data set and subset.</summary>
public unsafe struct DiskConBase
{
    // Child Types
    public unsafe struct DiskConBase_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DiskConBase*, void> DiskConBase_dtor_0; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DiskConBase*, ACBindings.Internal.DiskConInitInfo*, byte> InitFile; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DiskConBase*, byte> Close; // function pointer
        public System.IntPtr LoadData;
        public System.IntPtr SaveData;
        public System.IntPtr DeleteData;
        public System.IntPtr DeleteDataByMask;
        public System.IntPtr IsMember;
        public System.IntPtr GetMembers;
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DiskConBase*, int> HowmuchFreeSpace; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DiskConBase*, ACBindings.Internal.CMostlyConsecutiveIntSet*, byte> LoadIterationList; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DiskConBase*, ACBindings.Internal.CMostlyConsecutiveIntSet*, byte> SaveIterationList; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DiskConBase*, ACBindings.Internal.DATFILE_TYPE> GetDataset; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DiskConBase*, uint> GetSubset; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DiskConBase*, ulong> GetDatFileID; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DiskConBase*, byte> IsInitialized; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DiskConBase*, byte> IsReadOnly; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DiskConBase*, byte> IsExpandable; // function pointer
        public System.IntPtr GetMasterMapDID;
        public System.IntPtr SetMasterMapDID;
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DiskConBase*, ACBindings.Internal.DatIDStamp*, void> SetDatIDStamp; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DiskConBase*, ACBindings.Internal.DatIDStamp*, ACBindings.Internal.DatIDStamp*> GetDatIDStamp; // function pointer
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

    /// <summary>Returns a 64‑bit ID formed from the object's data set type and subset number.
    /// <code>Offset: 0x004F8DB0
    /// unsigned __int64 __thiscall DiskConBase::GetDatFileID(DiskConBase*)</code>
    /// </summary>
    /// <returns>A 64-bit unsigned integer where the high‑order 32 bits contain the data_set_lm value and the low‑order 32 bits contain data_subset_lm.</returns>
    public ulong GetDatFileID() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DiskConBase, ulong>)0x004F8DB0)(ref this);

    /// <summary>Returns whether this DiskConBase instance has been initialized.
    /// <code>Offset: 0x004F8DD0
    /// bool __thiscall DiskConBase::IsInitialized(DiskConBase*)</code>
    /// </summary>
    /// <returns>True if the object is initialized; otherwise false.</returns>
    public byte IsInitialized() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DiskConBase, byte>)0x004F8DD0)(ref this);

    /// <summary>Determines whether this DiskConBase instance operates in read‑only mode.
    /// <code>Offset: 0x004F8DE0
    /// bool __thiscall DiskConBase::IsReadOnly(DiskConBase*)</code>
    /// </summary>
    /// <returns>True if the instance is read‑only; otherwise, false.</returns>
    public byte IsReadOnly() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DiskConBase, byte>)0x004F8DE0)(ref this);

    /// <summary>Determines whether the disk container is marked as expandable.
    /// <code>Offset: 0x004F8DF0
    /// bool __thiscall DiskConBase::IsExpandable(DiskConBase*)</code>
    /// </summary>
    /// <returns>True if the expandable_fm flag is set; otherwise, false.</returns>
    public byte IsExpandable() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DiskConBase, byte>)0x004F8DF0)(ref this);

    /// <summary>Initializes a DatIDStamp structure at the supplied pointer with default values and returns the same pointer.
    /// <code>Offset: 0x00671320
    /// DatIDStamp* __thiscall DiskConBase::GetDatIDStamp(DiskConBase*,DatIDStamp*)</code>
    /// </summary>
    /// <param name="result">Pointer to the DatIDStamp object that will receive the initialized data.</param>
    /// <returns>The initialized DatIDStamp pointer, allowing direct use or method chaining.</returns>
    public ACBindings.Internal.DatIDStamp* GetDatIDStamp(ACBindings.Internal.DatIDStamp* result) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DiskConBase, ACBindings.Internal.DatIDStamp*, ACBindings.Internal.DatIDStamp*>)0x00671320)(ref this, result);

    /// <summary>Performs no operation and returns zero.
    /// <code>Offset: 0x006714B0
    /// char __stdcall DiskConBase::SaveData(int,int,int)</code>
    /// </summary>
    /// <param name="a1">Ignored; not used by the function.</param>
    /// <param name="a2">Ignored; not used by the function.</param>
    /// <param name="a3">Ignored; not used by the function.</param>
    /// <returns>Zero, indicating that the method has no effect.</returns>
    public static sbyte SaveData(int a1, int a2, int a3) => ((delegate* unmanaged[Stdcall]<int, int, int, sbyte>)0x006714B0)(a1, a2, a3);

    /// <summary>Assigns an invalid identifier (INVALID_DID_416) to a supplied IDClass instance and returns that pointer.
    /// <code>Offset: 0x006714C0
    /// IDClass&lt;_tagDataID,32,0&gt;* __stdcall DiskConBase::GetMasterMapDID(IDClass&lt;_tagDataID,32,0&gt;*)</code>
    /// </summary>
    /// <param name="a1">Pointer to the IDClass object whose id field will be set to INVALID_DID_416.</param>
    /// <returns>Pointer to the modified IDClass instance.</returns>
    public static ACBindings.Internal.IDClass____tagDataID* GetMasterMapDID(ACBindings.Internal.IDClass____tagDataID* a1) => ((delegate* unmanaged[Stdcall]<ACBindings.Internal.IDClass____tagDataID*, ACBindings.Internal.IDClass____tagDataID*>)0x006714C0)(a1);

    /// <summary>Assigns an invalid data identifier to the supplied IDClass instance and returns it.
    /// <code>Offset: 0x006714D0
    /// IDClass&lt;_tagDataID,32,0&gt;* __stdcall DiskConBase::SetMasterMapDID(IDClass&lt;_tagDataID,32,0&gt;*,int)</code>
    /// </summary>
    /// <param name="a1">The IDClass object whose id field will be set to the predefined invalid value.</param>
    /// <returns>The same IDClass pointer after its id has been updated.</returns>
    public static ACBindings.Internal.IDClass____tagDataID* SetMasterMapDID(ACBindings.Internal.IDClass____tagDataID* a1, int a2) => ((delegate* unmanaged[Stdcall]<ACBindings.Internal.IDClass____tagDataID*, int, ACBindings.Internal.IDClass____tagDataID*>)0x006714D0)(a1, a2);
}

