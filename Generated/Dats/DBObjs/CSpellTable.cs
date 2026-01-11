namespace ACBindings.Internal;

public unsafe struct CSpellTable : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.SerializeUsingPackDBObj BaseClass_SerializeUsingPackDBObj; // ACBindings.Internal.SerializeUsingPackDBObj

    // Child Types
    public unsafe struct CSpellTable_vtbl
    {
        // Members
        public delegate* unmanaged[Stdcall]<ACBindings.Internal.Interface*, ACBindings.Internal._GUID*, void**, int> IUnknown_QueryInterface; // function pointer
        public delegate* unmanaged[Stdcall]<ACBindings.Internal.Interface*, uint> IUnknown_AddRef; // function pointer
        public delegate* unmanaged[Stdcall]<ACBindings.Internal.Interface*, uint> IUnknown_Release; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.Interface*, ACBindings.Internal.TResult*, ACBindings.Internal.Turbine_GUID*, void**, ACBindings.Internal.TResult*> QueryInterface; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.Interface*, uint> AddRef; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.Interface*, uint> Release; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, void> DBObj_dtor_18; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, ACBindings.Internal.Archive*, void> Serialize; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, ACBindings.Internal.QualifiedDataIDArray*, void> GetSubDataIDs; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, byte> InitLoad; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, byte> GetSubObjects; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, byte> ReleaseSubObjects; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, byte> NotifyFidelityLevel; // function pointer
        public System.IntPtr Refresh;
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, ACBindings.Internal.DBObj*, byte> CopyInto; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, void> Destroy; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, ACBindings.Internal.IDataGraph*, void> FillDataGraph; // function pointer
        public System.IntPtr SetDID;
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, uint> GetDBOType; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, ACBindings.Internal.DBObj*> Allocate; // function pointer
        public System.IntPtr SaveToDisk;
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, byte> ReloadFromDisk; // function pointer

        // Methods
    }

    // Members
    public ACBindings.Internal.PackableHashTable__uint___CSpellBase _spellBaseHash;
    public ACBindings.Internal.PHashTable__uint___SpellSet m_SpellSetHash;

    // Generated Constructor
    public CSpellTable(void** a2) {
        _ConstructorInternal(a2);
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x00567E50
    /// int __thiscall CSpellTable::InqSpellBase(CSpellTable*,const unsigned int,CSpellBase*)</code>
    /// </summary>
    public int InqSpellBase(uint key, ACBindings.Internal.CSpellBase* sbase) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CSpellTable, uint, ACBindings.Internal.CSpellBase*, int>)0x00567E50)(ref this, key, sbase);

    /// <summary>
    /// <code>Offset: 0x0058B700
    /// DBObj* __cdecl CSpellTable::Allocator()</code>
    /// </summary>
    public static ACBindings.Internal.DBObj* Allocator() => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.DBObj*>)0x0058B700)();

    /// <summary>
    /// <code>Offset: 0x00594980
    /// const CSpellBase* __thiscall CSpellTable::GetSpellBase(CSpellTable*,const unsigned int)</code>
    /// </summary>
    public ACBindings.Internal.CSpellBase* GetSpellBase(uint key) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CSpellTable, uint, ACBindings.Internal.CSpellBase*>)0x00594980)(ref this, key);

    /// <summary>
    /// <code>Offset: 0x00598450
    /// unsigned int __thiscall CSpellTable::Pack(CSpellTable*,void**,unsigned int)</code>
    /// </summary>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CSpellTable, void**, uint, uint>)0x00598450)(ref this, addr, size);

    /// <summary>
    /// <code>Offset: 0x005984C0
    /// int __thiscall CSpellTable::UnPack(CSpellTable*,void**,unsigned int)</code>
    /// </summary>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CSpellTable, void**, uint, int>)0x005984C0)(ref this, addr, size);

    /// <summary>
    /// <code>Offset: 0x005986E0
    /// void __thiscall CSpellTable::GetSubDataIDs(CSpellTable*,QualifiedDataIDArray*)</code>
    /// </summary>
    public void GetSubDataIDs(ACBindings.Internal.QualifiedDataIDArray* id_array) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CSpellTable, ACBindings.Internal.QualifiedDataIDArray*, void>)0x005986E0)(ref this, id_array);

    /// <summary>
    /// <code>Offset: 0x005993E0
    /// int __thiscall CSpellTable::CSpellTable(int,void**)</code>
    /// </summary>
    public int _ConstructorInternal(void** a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CSpellTable, void**, int>)0x005993E0)(ref this, a2);

    /// <summary>
    /// <code>Offset: 0x00599490
    /// void __thiscall CSpellTable::~CSpellTable(CSpellTable*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CSpellTable, void>)0x00599490)(ref this);
}

