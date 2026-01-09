namespace ACBindings;

// LRUExpandTransactInfo
public unsafe struct LRUExpandTransactInfo
{
    // Base Classes
    public ACBindings.DiskTransactInfo BaseClass_DiskTransactInfo; // ACBindings.DiskTransactInfo

    // Child Types
    // LRUExpandTransactInfo_vtbl
    public unsafe struct LRUExpandTransactInfo_vtbl
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
    public int m_nYoungOffset;
    public int m_nFirstFreeBlock;
    public ACBindings.IDClass___tagDataID m_cTargetDID;

    // Generated Constructor
    public LRUExpandTransactInfo() {
        _ConstructorInternal();
    }

    // Methods
    // void __thiscall LRUExpandTransactInfo::LRUExpandTransactInfo(LRUExpandTransactInfo*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.LRUExpandTransactInfo, void>)0x00677920)(ref this);
}

