namespace ACBindings;

// CSpellTable
public unsafe struct CSpellTable : System.IDisposable
{
    // Base Classes
    public ACBindings.SerializeUsingPackDBObj BaseClass_SerializeUsingPackDBObj; // ACBindings.SerializeUsingPackDBObj

    // Child Types
    // CSpellTable_vtbl
    public unsafe struct CSpellTable_vtbl
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
    public ACBindings.PackableHashTable__uint__CSpellBase _spellBaseHash;
    public ACBindings.PHashTable__uint__SpellSet m_SpellSetHash;

    // Generated Constructor
    public CSpellTable(void** a2) {
        _ConstructorInternal(a2);
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods
    // int __thiscall CSpellTable::InqSpellBase(CSpellTable*,const unsigned int,CSpellBase*)
    public int InqSpellBase(uint key, ACBindings.CSpellBase* sbase) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CSpellTable, uint, ACBindings.CSpellBase*, int>)0x00567E50)(ref this, key, sbase);
    // DBObj* __cdecl CSpellTable::Allocator()
    public static ACBindings.DBObj* Allocator() => ((delegate* unmanaged[Cdecl]<ACBindings.DBObj*>)0x0058B700)();
    // const CSpellBase* __thiscall CSpellTable::GetSpellBase(CSpellTable*,const unsigned int)
    public ACBindings.CSpellBase* GetSpellBase(uint key) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CSpellTable, uint, ACBindings.CSpellBase*>)0x00594980)(ref this, key);
    // unsigned int __thiscall CSpellTable::Pack(CSpellTable*,void**,unsigned int)
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CSpellTable, void**, uint, uint>)0x00598450)(ref this, addr, size);
    // int __thiscall CSpellTable::UnPack(CSpellTable*,void**,unsigned int)
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CSpellTable, void**, uint, int>)0x005984C0)(ref this, addr, size);
    // void __thiscall CSpellTable::GetSubDataIDs(CSpellTable*,QualifiedDataIDArray*)
    public void GetSubDataIDs(ACBindings.QualifiedDataIDArray* id_array) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CSpellTable, ACBindings.QualifiedDataIDArray*, void>)0x005986E0)(ref this, id_array);
    // int __thiscall CSpellTable::CSpellTable(int,void**)
    public int _ConstructorInternal(void** a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CSpellTable, void**, int>)0x005993E0)(ref this, a2);
    // void __thiscall CSpellTable::~CSpellTable(CSpellTable*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CSpellTable, void>)0x00599490)(ref this);
}

