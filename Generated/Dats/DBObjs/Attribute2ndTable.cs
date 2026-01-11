namespace ACBindings.Internal;

public unsafe struct Attribute2ndTable : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.SerializeUsingPackDBObj BaseClass_SerializeUsingPackDBObj; // ACBindings.Internal.SerializeUsingPackDBObj

    // Child Types
    public unsafe struct Attribute2ndTable_vtbl
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
    public ACBindings.Internal.Attribute2ndBase _max_health;
    public ACBindings.Internal.Attribute2ndBase _max_stamina;
    public ACBindings.Internal.Attribute2ndBase _max_mana;

    // Generated Constructor
    public Attribute2ndTable(void** a2) {
        _ConstructorInternal(a2);
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x004E7230
    /// unsigned int __thiscall Attribute2ndTable::GetDBOType(Attribute2ndTable*)</code>
    /// </summary>
    public uint GetDBOType() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Attribute2ndTable, uint>)0x004E7230)(ref this);

    /// <summary>
    /// <code>Offset: 0x004F1E30
    /// int __thiscall Attribute2ndTable::InqAttribute2ndBase(Attribute2ndTable*,unsigned int,Attribute2ndBase*)</code>
    /// </summary>
    public int InqAttribute2ndBase(uint key, ACBindings.Internal.Attribute2ndBase* sbase) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Attribute2ndTable, uint, ACBindings.Internal.Attribute2ndBase*, int>)0x004F1E30)(ref this, key, sbase);

    /// <summary>
    /// <code>Offset: 0x0058B6B0
    /// DBObj* __cdecl Attribute2ndTable::Allocator()</code>
    /// </summary>
    public static ACBindings.Internal.DBObj* Allocator() => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.DBObj*>)0x0058B6B0)();

    /// <summary>
    /// <code>Offset: 0x005CC2E0
    /// unsigned int __thiscall Attribute2ndTable::Pack(Attribute2ndTable*,void**,unsigned int)</code>
    /// </summary>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Attribute2ndTable, void**, uint, uint>)0x005CC2E0)(ref this, addr, size);

    /// <summary>
    /// <code>Offset: 0x005CC360
    /// int __thiscall Attribute2ndTable::UnPack(Attribute2ndTable*,void**,unsigned int)</code>
    /// </summary>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Attribute2ndTable, void**, uint, int>)0x005CC360)(ref this, addr, size);

    /// <summary>
    /// <code>Offset: 0x005CC420
    /// int __thiscall Attribute2ndTable::Attribute2ndTable(int,void**)</code>
    /// </summary>
    public int _ConstructorInternal(void** a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Attribute2ndTable, void**, int>)0x005CC420)(ref this, a2);

    /// <summary>
    /// <code>Offset: 0x005CC4F0
    /// void __thiscall Attribute2ndTable::~Attribute2ndTable(Attribute2ndTable*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Attribute2ndTable, void>)0x005CC4F0)(ref this);
}

