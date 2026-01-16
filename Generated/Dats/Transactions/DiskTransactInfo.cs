namespace ACBindings.Internal;


/// <summary>Represents information about a disk transaction, including its type and a magic number for integrity checks.</summary>
public unsafe struct DiskTransactInfo
{
    // Child Types

    /// <summary>Function pointer table for DiskTransactInfo, enabling serialization of disk transactions and dynamic casting to specialized transact info types such as AddObject, DeleteLeaf, MergeNodes, and others used within the disk management subsystem.</summary>
    public unsafe struct DiskTransactInfo_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DiskTransactInfo*, ACBindings.Internal.Archive*, void> Serialize; // function pointer
        public fixed byte gap4[4];
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DiskTransactInfo*, ACBindings.Internal.AddObjectTransactInfo*> DynamicCast_AddObject; // function pointer
        public fixed byte gapC[4];
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DiskTransactInfo*, ACBindings.Internal.DeleteLeafTransactInfo*> DynamicCast_DeleteLeaf; // function pointer
        public fixed byte gap14[4];
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DiskTransactInfo*, ACBindings.Internal.DeleteInternalTransactInfo*> DynamicCast_DeleteInternal; // function pointer
        public fixed byte gap1C[4];
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DiskTransactInfo*, ACBindings.Internal.MergeNodesTransactInfo*> DynamicCast_MergeNodes; // function pointer
        public fixed byte gap24[4];
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DiskTransactInfo*, ACBindings.Internal.UpdateObjectTransactInfo*> DynamicCast_UpdateObject; // function pointer
        public fixed byte gap2C[4];
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DiskTransactInfo*, ACBindings.Internal.SplitNodeTransactInfo*> DynamicCast_SplitNode; // function pointer
        public fixed byte gap34[4];
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DiskTransactInfo*, ACBindings.Internal.RotateEntryTransactInfo*> DynamicCast_RotateEntry; // function pointer
        public fixed byte gap3C[4];
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DiskTransactInfo*, ACBindings.Internal.LRUExpandTransactInfo*> DynamicCast_LRUExpand; // function pointer
        public fixed byte gap44[4];
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DiskTransactInfo*, ACBindings.Internal.LRUDeleteTransactInfo*> DynamicCast_LRUDelete; // function pointer

        // Methods
    }

    // Members
    public System.IntPtr __vftable; // vtable pointer
    public ACBindings.Internal.DiskTransactType m_eTransactType;
    public int m_nMagicNumber;

    // Generated Constructor
    public DiskTransactInfo() {
        _ConstructorInternal();
    }

    // Methods

    /// <summary>Initializes a DiskTransactInfo instance by assigning its virtual function table, setting the transaction type to NO_TRANS, and initializing the magic number to 19536.
    /// <code>Offset: 0x00677220
    /// void __thiscall DiskTransactInfo::DiskTransactInfo(DiskTransactInfo*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DiskTransactInfo, void>)0x00677220)(ref this);

    /// <summary>Serializes or deserializes the transaction's magic number to/from an archive based on the archive mode.
    /// <code>Offset: 0x006772D0
    /// void __thiscall DiskTransactInfo::Serialize(DiskTransactInfo*,Archive*)</code>
    /// </summary>
    /// <param name="io_rcArchive">The archive used for reading or writing the magic number of this transaction.</param>
    public void Serialize(ACBindings.Internal.Archive* io_rcArchive) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DiskTransactInfo, ACBindings.Internal.Archive*, void>)0x006772D0)(ref this, io_rcArchive);

    /// <summary>Creates and returns a new DiskTransactInfo object corresponding to the requested disk transaction type.
    /// <code>Offset: 0x00677AB0
    /// DiskTransactInfo* __cdecl DiskTransactInfo::CreateTransactInfo(DiskTransactType)</code>
    /// </summary>
    /// <param name="i_eType">The DiskTransactType indicating which specific subclass of DiskTransactInfo to instantiate.</param>
    /// <returns>A pointer to the newly allocated transaction info instance, or null if memory allocation fails or the type is unsupported.</returns>
    public static ACBindings.Internal.DiskTransactInfo* CreateTransactInfo(ACBindings.Internal.DiskTransactType i_eType) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.DiskTransactType, ACBindings.Internal.DiskTransactInfo*>)0x00677AB0)(i_eType);
}

