namespace ACBindings;

// ClothingTable
public unsafe struct ClothingTable : System.IDisposable
{
    // Base Classes
    public ACBindings.SerializeUsingPackDBObj BaseClass_SerializeUsingPackDBObj; // ACBindings.SerializeUsingPackDBObj

    // Child Types
    // ClothingTable_vtbl
    public unsafe struct ClothingTable_vtbl
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
    public ACBindings.PackableHashTable__IDClass___tagDataID__ClothingBase _cloBaseHash;
    public ACBindings.PackableHashTable__uint__CloPaletteTemplate _paletteTemplatesHash;

    // Generated Constructor
    public ClothingTable(void** a2) {
        _ConstructorInternal(a2);
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods
    // DBObj* __cdecl ClothingTable::Get(int)
    public static ACBindings.DBObj* Get(int a1) => ((delegate* unmanaged[Cdecl]<int, ACBindings.DBObj*>)0x004EF2F0)(a1);
    // DBObj* __cdecl ClothingTable::Allocator()
    public static ACBindings.DBObj* Allocator() => ((delegate* unmanaged[Cdecl]<ACBindings.DBObj*>)0x004F7D80)();
    // unsigned int __thiscall ClothingTable::Pack(ClothingTable*,void**,unsigned int)
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClothingTable, void**, uint, uint>)0x005A8320)(ref this, addr, size);
    // int __thiscall ClothingTable::UnPack(ClothingTable*,void**,unsigned int)
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClothingTable, void**, uint, int>)0x005A8380)(ref this, addr, size);
    // CloPaletteTemplate* __thiscall ClothingTable::GetCloPaletteTemplate(ClothingTable*,const unsigned int)
    public ACBindings.CloPaletteTemplate* GetCloPaletteTemplate(uint key) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClothingTable, uint, ACBindings.CloPaletteTemplate*>)0x005A85F0)(ref this, key);
    // void __thiscall ClothingTable::GetSubDataIDs(ClothingTable*,QualifiedDataIDArray*)
    public void GetSubDataIDs(ACBindings.QualifiedDataIDArray* id_array) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClothingTable, ACBindings.QualifiedDataIDArray*, void>)0x005A8730)(ref this, id_array);
    // int __thiscall ClothingTable::BuildObjDesc(_DWORD*,unsigned int,int,ShadePackage*,ObjDesc*)
    public int BuildObjDesc(uint a2, int a3, ACBindings.ShadePackage* a4, ACBindings.ObjDesc* od) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClothingTable, uint, int, ACBindings.ShadePackage*, ACBindings.ObjDesc*, int>)0x005A89B0)(ref this, a2, a3, a4, od);
    // int __thiscall ClothingTable::ClothingTable(int,void**)
    public int _ConstructorInternal(void** a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClothingTable, void**, int>)0x005A9210)(ref this, a2);
    // void __thiscall ClothingTable::~ClothingTable(ClothingTable*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClothingTable, void>)0x005A92B0)(ref this);
}

