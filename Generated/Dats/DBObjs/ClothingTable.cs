namespace ACBindings.Internal;

public unsafe struct ClothingTable : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.SerializeUsingPackDBObj BaseClass_SerializeUsingPackDBObj; // ACBindings.Internal.SerializeUsingPackDBObj

    // Child Types
    public unsafe struct ClothingTable_vtbl
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
    public ACBindings.Internal.PackableHashTable___IDClass____tagDataID___ClothingBase _cloBaseHash;
    public ACBindings.Internal.PackableHashTable__uint___CloPaletteTemplate _paletteTemplatesHash;

    // Generated Constructor
    public ClothingTable(void** a2) {
        _ConstructorInternal(a2);
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x004EF2F0
    /// DBObj* __cdecl ClothingTable::Get(int)</code>
    /// </summary>
    public static ACBindings.Internal.DBObj* Get(int a1) => ((delegate* unmanaged[Cdecl]<int, ACBindings.Internal.DBObj*>)0x004EF2F0)(a1);

    /// <summary>
    /// <code>Offset: 0x004F7D80
    /// DBObj* __cdecl ClothingTable::Allocator()</code>
    /// </summary>
    public static ACBindings.Internal.DBObj* Allocator() => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.DBObj*>)0x004F7D80)();

    /// <summary>
    /// <code>Offset: 0x005A8320
    /// unsigned int __thiscall ClothingTable::Pack(ClothingTable*,void**,unsigned int)</code>
    /// </summary>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClothingTable, void**, uint, uint>)0x005A8320)(ref this, addr, size);

    /// <summary>
    /// <code>Offset: 0x005A8380
    /// int __thiscall ClothingTable::UnPack(ClothingTable*,void**,unsigned int)</code>
    /// </summary>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClothingTable, void**, uint, int>)0x005A8380)(ref this, addr, size);

    /// <summary>
    /// <code>Offset: 0x005A85F0
    /// CloPaletteTemplate* __thiscall ClothingTable::GetCloPaletteTemplate(ClothingTable*,const unsigned int)</code>
    /// </summary>
    public ACBindings.Internal.CloPaletteTemplate* GetCloPaletteTemplate(uint key) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClothingTable, uint, ACBindings.Internal.CloPaletteTemplate*>)0x005A85F0)(ref this, key);

    /// <summary>
    /// <code>Offset: 0x005A8730
    /// void __thiscall ClothingTable::GetSubDataIDs(ClothingTable*,QualifiedDataIDArray*)</code>
    /// </summary>
    public void GetSubDataIDs(ACBindings.Internal.QualifiedDataIDArray* id_array) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClothingTable, ACBindings.Internal.QualifiedDataIDArray*, void>)0x005A8730)(ref this, id_array);

    /// <summary>
    /// <code>Offset: 0x005A89B0
    /// int __thiscall ClothingTable::BuildObjDesc(_DWORD*,unsigned int,int,ShadePackage*,ObjDesc*)</code>
    /// </summary>
    public int BuildObjDesc(uint a2, int a3, ACBindings.Internal.ShadePackage* a4, ACBindings.Internal.ObjDesc* od) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClothingTable, uint, int, ACBindings.Internal.ShadePackage*, ACBindings.Internal.ObjDesc*, int>)0x005A89B0)(ref this, a2, a3, a4, od);

    /// <summary>
    /// <code>Offset: 0x005A9210
    /// int __thiscall ClothingTable::ClothingTable(int,void**)</code>
    /// </summary>
    public int _ConstructorInternal(void** a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClothingTable, void**, int>)0x005A9210)(ref this, a2);

    /// <summary>
    /// <code>Offset: 0x005A92B0
    /// void __thiscall ClothingTable::~ClothingTable(ClothingTable*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClothingTable, void>)0x005A92B0)(ref this);
}

