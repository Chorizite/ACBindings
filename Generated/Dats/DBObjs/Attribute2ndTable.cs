namespace ACBindings;

// Attribute2ndTable
public unsafe struct Attribute2ndTable : System.IDisposable
{
    // Base Classes
    public ACBindings.SerializeUsingPackDBObj BaseClass_SerializeUsingPackDBObj; // ACBindings.SerializeUsingPackDBObj

    // Child Types
    // Attribute2ndTable_vtbl
    public unsafe struct Attribute2ndTable_vtbl
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
    public ACBindings.Attribute2ndBase _max_health;
    public ACBindings.Attribute2ndBase _max_stamina;
    public ACBindings.Attribute2ndBase _max_mana;

    // Generated Constructor
    public Attribute2ndTable(void** a2) {
        _ConstructorInternal(a2);
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods
    // unsigned int __thiscall Attribute2ndTable::GetDBOType(Attribute2ndTable*)
    public uint GetDBOType() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Attribute2ndTable, uint>)0x004E7230)(ref this);
    // int __thiscall Attribute2ndTable::InqAttribute2ndBase(Attribute2ndTable*,unsigned int,Attribute2ndBase*)
    public int InqAttribute2ndBase(uint key, ACBindings.Attribute2ndBase* sbase) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Attribute2ndTable, uint, ACBindings.Attribute2ndBase*, int>)0x004F1E30)(ref this, key, sbase);
    // DBObj* __cdecl Attribute2ndTable::Allocator()
    public static ACBindings.DBObj* Allocator() => ((delegate* unmanaged[Cdecl]<ACBindings.DBObj*>)0x0058B6B0)();
    // unsigned int __thiscall Attribute2ndTable::Pack(Attribute2ndTable*,void**,unsigned int)
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Attribute2ndTable, void**, uint, uint>)0x005CC2E0)(ref this, addr, size);
    // int __thiscall Attribute2ndTable::UnPack(Attribute2ndTable*,void**,unsigned int)
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Attribute2ndTable, void**, uint, int>)0x005CC360)(ref this, addr, size);
    // int __thiscall Attribute2ndTable::Attribute2ndTable(int,void**)
    public int _ConstructorInternal(void** a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Attribute2ndTable, void**, int>)0x005CC420)(ref this, a2);
    // void __thiscall Attribute2ndTable::~Attribute2ndTable(Attribute2ndTable*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Attribute2ndTable, void>)0x005CC4F0)(ref this);
}

