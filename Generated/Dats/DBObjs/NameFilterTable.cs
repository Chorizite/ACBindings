namespace ACBindings;

// NameFilterTable
public unsafe struct NameFilterTable
{
    // Base Classes
    public ACBindings.DBObj BaseClass_DBObj; // ACBindings.DBObj

    // Child Types
    // NameFilterTable_vtbl
    public unsafe struct NameFilterTable_vtbl
    {
        // Members
        public System.IntPtr IUnknown_QueryInterface; // function pointer
        public System.IntPtr IUnknown_AddRef; // function pointer
        public System.IntPtr IUnknown_Release; // function pointer
        public System.IntPtr QueryInterface; // function pointer
        public System.IntPtr AddRef; // function pointer
        public System.IntPtr Release; // function pointer
        public System.IntPtr DBObj_dtor_18; // function pointer
        public System.IntPtr Serialize; // function pointer
        public System.IntPtr GetSubDataIDs; // function pointer
        public System.IntPtr InitLoad; // function pointer
        public System.IntPtr GetSubObjects; // function pointer
        public System.IntPtr ReleaseSubObjects; // function pointer
        public System.IntPtr NotifyFidelityLevel; // function pointer
        public System.IntPtr Refresh;
        public System.IntPtr CopyInto; // function pointer
        public System.IntPtr Destroy; // function pointer
        public System.IntPtr FillDataGraph; // function pointer
        public System.IntPtr SetDID;
        public System.IntPtr GetDBOType; // function pointer
        public System.IntPtr Allocate; // function pointer
        public System.IntPtr SaveToDisk;
        public System.IntPtr ReloadFromDisk; // function pointer

        // Methods
    }

    // Members
    public ACBindings.HashTable__uint__NameFilterLanguageData m_LanguageData;

    // Methods
    // DBObj* __cdecl NameFilterTable::Allocator()
    public static ACBindings.DBObj* Allocator() => ((delegate* unmanaged[Cdecl]<ACBindings.DBObj*>)0x004F7D40)();
    // void __thiscall NameFilterTable::Serialize(NameFilterTable*,Archive*)
    public void Serialize(ACBindings.Archive* rArchive) => ((delegate* unmanaged[Thiscall]<ref ACBindings.NameFilterTable, ACBindings.Archive*, void>)0x00680900)(ref this, rArchive);
}

