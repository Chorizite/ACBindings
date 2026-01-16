namespace ACBindings.Internal;


/// <summary>Handles clothing assets, maintaining base item data and palette templates in hash tables for efficient lookup, and enabling serialization and object descriptor construction.</summary>
public unsafe struct ClothingTable : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.SerializeUsingPackDBObj BaseClass_SerializeUsingPackDBObj; // ACBindings.Internal.SerializeUsingPackDBObj

    // Child Types
    public unsafe struct ClothingTable_vtbl
    {
        // Members
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.Interface*, ACBindings.Internal._GUID*, void**, int> IUnknown_QueryInterface; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.Interface*, uint> IUnknown_AddRef; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.Interface*, uint> IUnknown_Release; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.Interface*, ACBindings.Internal.TResult*, ACBindings.Internal.Turbine_GUID*, void**, ACBindings.Internal.TResult*> QueryInterface; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.Interface*, uint> AddRef; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.Interface*, uint> Release; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, void> DBObj_dtor_18; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, ACBindings.Internal.Archive*, void> Serialize; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, ACBindings.Internal.QualifiedDataIDArray*, void> GetSubDataIDs; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, byte> InitLoad; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, byte> GetSubObjects; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, byte> ReleaseSubObjects; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, byte> NotifyFidelityLevel; // function pointer
        public System.IntPtr Refresh;
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, ACBindings.Internal.DBObj*, byte> CopyInto; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, void> Destroy; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, ACBindings.Internal.IDataGraph*, void> FillDataGraph; // function pointer
        public System.IntPtr SetDID;
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, uint> GetDBOType; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, ACBindings.Internal.DBObj*> Allocate; // function pointer
        public System.IntPtr SaveToDisk;
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, byte> ReloadFromDisk; // function pointer

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

    /// <summary>Retrieves a database object for a clothing item by its numeric ID.
    /// <code>Offset: 0x004EF2F0
    /// DBObj* __cdecl ClothingTable::Get(int)</code>
    /// </summary>
    /// <param name="a1">The identifier of the clothing item to retrieve.</param>
    /// <returns>A pointer to the corresponding DBObj, or nullptr if no matching entry exists.</returns>
    public static ACBindings.Internal.DBObj* Get(int a1) => ((delegate* unmanaged[Cdecl]<int, ACBindings.Internal.DBObj*>)0x004EF2F0)(a1);

    /// <summary>Allocates and constructs a new ClothingTable instance, returning it as a DBObj pointer.
    /// <code>Offset: 0x004F7D80
    /// DBObj* __cdecl ClothingTable::Allocator()</code>
    /// </summary>
    /// <returns>A pointer to the newly allocated ClothingTable cast as a DBObj, or nullptr if memory allocation fails.</returns>
    public static ACBindings.Internal.DBObj* Allocator() => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.DBObj*>)0x004F7D80)();

    /// <summary>Serializes the ClothingTable into a binary format, writing data to the supplied buffer when sufficient space is available.
    /// <code>Offset: 0x005A8320
    /// unsigned int __thiscall ClothingTable::Pack(ClothingTable*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Pointer to the buffer where packed data will be stored.</param>
    /// <param name="size">Size of the provided buffer in bytes.</param>
    /// <returns>The number of bytes required for serialization. If size is large enough, the table is written to addr; otherwise no data is written.</returns>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClothingTable, void**, uint, uint>)0x005A8320)(ref this, addr, size);

    /// <summary>Deserializes clothing data from a memory buffer, updating the table and internal state.
    /// <code>Offset: 0x005A8380
    /// int __thiscall ClothingTable::UnPack(ClothingTable*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Pointer to the current read position in the buffer; advanced as data is consumed.</param>
    /// <param name="size">Number of bytes available for reading.</param>
    /// <returns>Non‑zero on success, zero if the buffer was too small or unpacking failed.</returns>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClothingTable, void**, uint, int>)0x005A8380)(ref this, addr, size);

    /// <summary>Retrieves a clothing palette template from the internal hash table using the supplied key, returning a pointer to the matching entry.
    /// <code>Offset: 0x005A85F0
    /// CloPaletteTemplate* __thiscall ClothingTable::GetCloPaletteTemplate(ClothingTable*,const unsigned int)</code>
    /// </summary>
    /// <param name="key">Hash table key identifying the desired palette template.</param>
    /// <returns>A pointer to the located <c>CloPaletteTemplate</c>, or <c>nullptr</c> if no match is found.</returns>
    public ACBindings.Internal.CloPaletteTemplate* GetCloPaletteTemplate(uint key) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClothingTable, uint, ACBindings.Internal.CloPaletteTemplate*>)0x005A85F0)(ref this, key);

    /// <summary>Accumulates every qualified data identifier referenced by clothing base entries and palette template entries, inserting them into the supplied QualifiedDataIDArray.
    /// <code>Offset: 0x005A8730
    /// void __thiscall ClothingTable::GetSubDataIDs(ClothingTable*,QualifiedDataIDArray*)</code>
    /// </summary>
    /// <param name="id_array">The array to populate with collected identifiers.</param>
    public void GetSubDataIDs(ACBindings.Internal.QualifiedDataIDArray* id_array) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClothingTable, ACBindings.Internal.QualifiedDataIDArray*, void>)0x005A8730)(ref this, id_array);

    /// <summary>Builds an object descriptor by applying clothing part and texture changes for a specified setup ID, optionally adding subpalettes from a palette template.
    /// <code>Offset: 0x005A89B0
    /// int __thiscall ClothingTable::BuildObjDesc(_DWORD*,unsigned int,int,ShadePackage*,ObjDesc*)</code>
    /// </summary>
    /// <param name="a2">Identifier of the clothing setup to process; may be replaced by a default if not found in the table.</param>
    /// <param name="a3">Palette template identifier. If zero, no palettes are added.</param>
    /// <param name="a4">ShadePackage supplying color values for palette generation.</param>
    /// <param name="od">Output object descriptor populated with applied changes and any generated subpalettes.</param>
    /// <returns>Zero on success; non‑zero indicates failure to locate data or apply changes.</returns>
    public int BuildObjDesc(uint a2, int a3, ACBindings.Internal.ShadePackage* a4, ACBindings.Internal.ObjDesc* od) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClothingTable, uint, int, ACBindings.Internal.ShadePackage*, ACBindings.Internal.ObjDesc*, int>)0x005A89B0)(ref this, a2, a3, a4, od);

    /// <summary>Initializes a ClothingTable instance by setting up its base classes and internal hash tables for clothing items and palette templates.
    /// <code>Offset: 0x005A9210
    /// int __thiscall ClothingTable::ClothingTable(int,void**)</code>
    /// </summary>
    /// <param name="a2">Initialization data passed to the DBObj constructor.</param>
    /// <returns>The constructed ClothingTable object.</returns>
    public int _ConstructorInternal(void** a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClothingTable, void**, int>)0x005A9210)(ref this, a2);

    /// <summary>Destroys a ClothingTable instance, clearing its palette template and clothing base hash tables, freeing associated memory, and invoking the base DBObj destructor.
    /// <code>Offset: 0x005A92B0
    /// void __thiscall ClothingTable::~ClothingTable(ClothingTable*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClothingTable, void>)0x005A92B0)(ref this);
}

