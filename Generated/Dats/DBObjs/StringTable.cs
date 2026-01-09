namespace ACBindings;

// StringTable
public unsafe struct StringTable : System.IDisposable
{
    // Base Classes
    public ACBindings.DBObj BaseClass_DBObj; // ACBindings.DBObj

    // Child Types
    // StringTable_vtbl
    public unsafe struct StringTable_vtbl
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
    public uint m_version;
    public ACBindings.PStringBase__ushort m_description;
    public uint m_language;
    public ACBindings.HashTable__uint__StringTableString_ptr m_strings;

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods
    // void __thiscall StringTable::GetSubDataIDs(StringTable*,QualifiedDataIDArray*)
    public void GetSubDataIDs(ACBindings.QualifiedDataIDArray* id_array) => ((delegate* unmanaged[Thiscall]<ref ACBindings.StringTable, ACBindings.QualifiedDataIDArray*, void>)0x0042FCB0)(ref this, id_array);
    // StringTableString* __thiscall StringTable::GetStringTableString(StringTable*,unsigned int)
    public ACBindings.StringTableString* GetStringTableString(uint stringID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.StringTable, uint, ACBindings.StringTableString*>)0x004301A0)(ref this, stringID);
    // int __thiscall StringTable::GetString(_DWORD*,wchar_t**,unsigned int,_DWORD*,char)
    public int GetString(System.IntPtr Source, uint stringID, int* a4, sbyte a5) => ((delegate* unmanaged[Thiscall]<ref ACBindings.StringTable, System.IntPtr, uint, int*, sbyte, int>)0x00430270)(ref this, Source, stringID, a4, a5);
    // void __thiscall StringTable::Destroy(StringTable*)
    public void Destroy() => ((delegate* unmanaged[Thiscall]<ref ACBindings.StringTable, void>)0x004306C0)(ref this);
    // unsigned int __thiscall StringTable::GetDBOType(StringTable*)
    public uint GetDBOType() => ((delegate* unmanaged[Thiscall]<ref ACBindings.StringTable, uint>)0x00430840)(ref this);
    // void __thiscall StringTable::~StringTable(StringTable*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.StringTable, void>)0x00430850)(ref this);
    // void __thiscall StringTable::Serialize(StringTable*,Archive*)
    public void Serialize(ACBindings.Archive* rArchive) => ((delegate* unmanaged[Thiscall]<ref ACBindings.StringTable, ACBindings.Archive*, void>)0x00430B60)(ref this, rArchive);
}

