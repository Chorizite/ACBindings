namespace ACBindings.Internal;

public unsafe struct DiskTransactInfo
{
    // Child Types
    public unsafe struct DiskTransactInfo_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DiskTransactInfo*, ACBindings.Internal.Archive*, void> Serialize; // function pointer
        public fixed byte gap4[4];
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DiskTransactInfo*, ACBindings.Internal.AddObjectTransactInfo*> DynamicCast_AddObject; // function pointer
        public fixed byte gapC[4];
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DiskTransactInfo*, ACBindings.Internal.DeleteLeafTransactInfo*> DynamicCast_DeleteLeaf; // function pointer
        public fixed byte gap14[4];
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DiskTransactInfo*, ACBindings.Internal.DeleteInternalTransactInfo*> DynamicCast_DeleteInternal; // function pointer
        public fixed byte gap1C[4];
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DiskTransactInfo*, ACBindings.Internal.MergeNodesTransactInfo*> DynamicCast_MergeNodes; // function pointer
        public fixed byte gap24[4];
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DiskTransactInfo*, ACBindings.Internal.UpdateObjectTransactInfo*> DynamicCast_UpdateObject; // function pointer
        public fixed byte gap2C[4];
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DiskTransactInfo*, ACBindings.Internal.SplitNodeTransactInfo*> DynamicCast_SplitNode; // function pointer
        public fixed byte gap34[4];
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DiskTransactInfo*, ACBindings.Internal.RotateEntryTransactInfo*> DynamicCast_RotateEntry; // function pointer
        public fixed byte gap3C[4];
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DiskTransactInfo*, ACBindings.Internal.LRUExpandTransactInfo*> DynamicCast_LRUExpand; // function pointer
        public fixed byte gap44[4];
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DiskTransactInfo*, ACBindings.Internal.LRUDeleteTransactInfo*> DynamicCast_LRUDelete; // function pointer

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

    /// <summary>
    /// <code>Offset: 0x00677220
    /// void __thiscall DiskTransactInfo::DiskTransactInfo(DiskTransactInfo*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DiskTransactInfo, void>)0x00677220)(ref this);

    /// <summary>
    /// <code>Offset: 0x006772D0
    /// void __thiscall DiskTransactInfo::Serialize(DiskTransactInfo*,Archive*)</code>
    /// </summary>
    public void Serialize(ACBindings.Internal.Archive* io_rcArchive) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DiskTransactInfo, ACBindings.Internal.Archive*, void>)0x006772D0)(ref this, io_rcArchive);

    /// <summary>
    /// <code>Offset: 0x00677AB0
    /// DiskTransactInfo* __cdecl DiskTransactInfo::CreateTransactInfo(DiskTransactType)</code>
    /// </summary>
    public static ACBindings.Internal.DiskTransactInfo* CreateTransactInfo(ACBindings.Internal.DiskTransactType i_eType) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.DiskTransactType, ACBindings.Internal.DiskTransactInfo*>)0x00677AB0)(i_eType);
}

