namespace ACBindings;

// DiskTransactInfo
public unsafe struct DiskTransactInfo
{
    // Child Types
    // DiskTransactInfo_vtbl
    public unsafe struct DiskTransactInfo_vtbl
    {
        // Members
        public System.IntPtr Serialize; // function pointer
        public fixed byte gap4[4];
        public System.IntPtr DynamicCast_AddObject; // function pointer
        public fixed byte gapC[4];
        public System.IntPtr DynamicCast_DeleteLeaf; // function pointer
        public fixed byte gap14[4];
        public System.IntPtr DynamicCast_DeleteInternal; // function pointer
        public fixed byte gap1C[4];
        public System.IntPtr DynamicCast_MergeNodes; // function pointer
        public fixed byte gap24[4];
        public System.IntPtr DynamicCast_UpdateObject; // function pointer
        public fixed byte gap2C[4];
        public System.IntPtr DynamicCast_SplitNode; // function pointer
        public fixed byte gap34[4];
        public System.IntPtr DynamicCast_RotateEntry; // function pointer
        public fixed byte gap3C[4];
        public System.IntPtr DynamicCast_LRUExpand; // function pointer
        public fixed byte gap44[4];
        public System.IntPtr DynamicCast_LRUDelete; // function pointer

        // Methods
    }

    // Members
    public System.IntPtr __vftable; // vtable pointer
    public ACBindings.DiskTransactType m_eTransactType;
    public int m_nMagicNumber;

    // Generated Constructor
    public DiskTransactInfo() {
        _ConstructorInternal();
    }

    // Methods
    // void __thiscall DiskTransactInfo::DiskTransactInfo(DiskTransactInfo*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.DiskTransactInfo, void>)0x00677220)(ref this);
    // void __thiscall DiskTransactInfo::Serialize(DiskTransactInfo*,Archive*)
    public void Serialize(ACBindings.Archive* io_rcArchive) => ((delegate* unmanaged[Thiscall]<ref ACBindings.DiskTransactInfo, ACBindings.Archive*, void>)0x006772D0)(ref this, io_rcArchive);
    // DiskTransactInfo* __cdecl DiskTransactInfo::CreateTransactInfo(DiskTransactType)
    public static ACBindings.DiskTransactInfo* CreateTransactInfo(ACBindings.DiskTransactType i_eType) => ((delegate* unmanaged[Cdecl]<ACBindings.DiskTransactType, ACBindings.DiskTransactInfo*>)0x00677AB0)(i_eType);
}

