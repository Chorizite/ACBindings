namespace ACBindings;

// CombatManeuverTable
public unsafe struct CombatManeuverTable : System.IDisposable
{
    // Base Classes
    public ACBindings.SerializeUsingPackDBObj BaseClass_SerializeUsingPackDBObj; // ACBindings.SerializeUsingPackDBObj

    // Child Types
    // CombatManeuverTable_vtbl
    public unsafe struct CombatManeuverTable_vtbl
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
    public uint _num_combat_maneuvers;
    public ACBindings.CombatManeuver* _cmt;

    // Generated Constructor
    public CombatManeuverTable(void** a2) {
        _ConstructorInternal(a2);
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods
    // DBObj* __cdecl CombatManeuverTable::Get(int)
    public static ACBindings.DBObj* Get(int a1) => ((delegate* unmanaged[Cdecl]<int, ACBindings.DBObj*>)0x0056B8A0)(a1);
    // DBObj* __cdecl CombatManeuverTable::Allocator()
    public static ACBindings.DBObj* Allocator() => ((delegate* unmanaged[Cdecl]<ACBindings.DBObj*>)0x0058B7B0)();
    // void __thiscall CombatManeuverTable::~CombatManeuverTable(CombatManeuverTable*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CombatManeuverTable, void>)0x005CB4D0)(ref this);
    // unsigned int __thiscall CombatManeuverTable::Pack(CombatManeuverTable*,void**,unsigned int)
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CombatManeuverTable, void**, uint, uint>)0x005CB520)(ref this, addr, size);
    // int __thiscall CombatManeuverTable::Init(CombatManeuverTable*,unsigned int)
    public int Init(uint num_combat_maneuvers) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CombatManeuverTable, uint, int>)0x005CB5A0)(ref this, num_combat_maneuvers);
    // int __thiscall CombatManeuverTable::CombatManeuverTable(int,void**)
    public int _ConstructorInternal(void** a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CombatManeuverTable, void**, int>)0x005CB640)(ref this, a2);
    // int __thiscall CombatManeuverTable::UnPack(CombatManeuverTable*,void**,unsigned int)
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CombatManeuverTable, void**, uint, int>)0x005CB690)(ref this, addr, size);
}

