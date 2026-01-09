namespace ACBindings;

// DBFile2IDTable
public unsafe struct DBFile2IDTable : System.IDisposable
{
    // Base Classes
    public ACBindings.DBObj BaseClass_DBObj; // ACBindings.DBObj
    public ACBindings.TFile2IDTable BaseClass_TFile2IDTable; // ACBindings.TFile2IDTable

    // Child Types
    // DBFile2IDTable_vtbl
    public unsafe struct DBFile2IDTable_vtbl
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

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods
    // DBObj* __thiscall DBFile2IDTable::Allocate(DBFile2IDTable*)
    public ACBindings.DBObj* Allocate() => ((delegate* unmanaged[Thiscall]<ref ACBindings.DBFile2IDTable, ACBindings.DBObj*>)0x004F7CA0)(ref this);
    // int __thiscall DBFile2IDTable::GetDBOType(SoundTweakedHook*)
    public int GetDBOType() => ((delegate* unmanaged[Thiscall]<ref ACBindings.DBFile2IDTable, int>)0x004F7CF0)(ref this);
    // void __thiscall DBFile2IDTable::~DBFile2IDTable(DBFile2IDTable*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.DBFile2IDTable, void>)0x004F7D20)(ref this);
    // void __thiscall DBFile2IDTable::Serialize(DBFile2IDTable*,Archive*)
    public void Serialize(ACBindings.Archive* io_archive) => ((delegate* unmanaged[Thiscall]<ref ACBindings.DBFile2IDTable, ACBindings.Archive*, void>)0x0067C310)(ref this, io_archive);
}

