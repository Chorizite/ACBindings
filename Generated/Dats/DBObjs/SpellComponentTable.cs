namespace ACBindings.Internal;


/// <summary>Handles spell component data, providing mapping between world identifiers, spell identifiers, and target types while storing component bases in an efficient hash table.</summary>
public unsafe struct SpellComponentTable
{
    // Base Classes
    public ACBindings.Internal.SerializeUsingPackDBObj BaseClass_SerializeUsingPackDBObj; // ACBindings.Internal.SerializeUsingPackDBObj

    // Child Types
    public unsafe struct SpellComponentTable_vtbl
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
    public ACBindings.Internal.PackableHashTable__uint___SpellComponentBase _spellComponentBaseHash;

    // Generated Constructor
    public SpellComponentTable(void** a2) {
        _ConstructorInternal(a2);
    }

    // Methods

    /// <summary>Queries the spell component table for a base entry identified by the given key, copying the result into the supplied SpellComponentBase structure and indicating whether the lookup succeeded.
    /// <code>Offset: 0x0048A1F0
    /// int __thiscall SpellComponentTable::InqSpellComponentBase(SpellComponentTable*,const unsigned int,SpellComponentBase*)</code>
    /// </summary>
    /// <param name="key">The unique identifier used to locate a spell component base in the table.</param>
    /// <param name="sbase">Reference where the located SpellComponentBase data will be copied if found.</param>
    /// <returns>Non‑zero if the component was found and copied; zero otherwise.</returns>
    public int InqSpellComponentBase(uint key, ACBindings.Internal.SpellComponentBase* sbase) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SpellComponentTable, uint, ACBindings.Internal.SpellComponentBase*, int>)0x0048A1F0)(ref this, key, sbase);

    /// <summary>Allocates a new SpellComponentTable instance and returns its DBObj interface pointer, or null if allocation fails.
    /// <code>Offset: 0x0058B730
    /// DBObj* __cdecl SpellComponentTable::Allocator()</code>
    /// </summary>
    /// <returns>The newly constructed DBObj, or 0 when memory cannot be allocated.</returns>
    public static ACBindings.Internal.DBObj* Allocator() => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.DBObj*>)0x0058B730)();

    /// <summary>Maps a spell component ID to its corresponding target type identifier.
    /// <code>Offset: 0x005BD070
    /// unsigned int __cdecl SpellComponentTable::GetTargetTypeFromComponentID(const unsigned int)</code>
    /// </summary>
    /// <param name="scid">The component ID to query.</param>
    /// <returns>An unsigned integer representing the target type; returns 16 for several common IDs, 560015 or 268500992 for specific IDs, and 0 when the ID is unrecognized.</returns>
    public static uint GetTargetTypeFromComponentID(uint scid) => ((delegate* unmanaged[Cdecl]<uint, uint>)0x005BD070)(scid);

    /// <summary>Converts a magic school enumeration value into its corresponding database object ID and stores it in the supplied unsigned integer pointer.
    /// <code>Offset: 0x005BD2C0
    /// unsigned int* __cdecl SpellComponentTable::SchoolOfMagic2WCID(unsigned int*,unsigned int)</code>
    /// </summary>
    /// <param name="a1">Pointer to an unsigned int where the resolved data ID will be written.</param>
    /// <param name="a2">Enumeration value identifying a magic school.</param>
    /// <returns>Same unsigned int pointer passed as <c>a1</c>, now containing the mapped data ID (or an invalid ID if lookup fails).</returns>
    public static uint* SchoolOfMagic2WCID(uint* a1, uint a2) => ((delegate* unmanaged[Cdecl]<uint*, uint, uint*>)0x005BD2C0)(a1, a2);

    /// <summary>Converts a world component identifier to the corresponding spell component identifier by querying an internal mapping table.
    /// <code>Offset: 0x005BD310
    /// int __cdecl SpellComponentTable::WCIDtoSCID(unsigned int)</code>
    /// </summary>
    /// <param name="a1">The world component identifier to convert.</param>
    /// <returns>The mapped spell component identifier, or zero if no match is found.</returns>
    public static int WCIDtoSCID(uint a1) => ((delegate* unmanaged[Cdecl]<uint, int>)0x005BD310)(a1);

    /// <summary>
    /// Converts a spell component enumeration identifier to its corresponding database identifier and stores the result through the supplied pointer.
    /// 
    /// <code>Offset: 0x005BD3C0
    /// unsigned int* __cdecl SpellComponentTable::SCIDtoWCID(unsigned int*,unsigned int)</code>
    /// </summary>
    /// <param name="a1">Pointer that receives the mapped database identifier.</param>
    /// <param name="a2">Input enumeration identifier to be converted.</param>
    /// <returns>Same pointer passed in as <paramref name="a1"/>, now containing the converted identifier.</returns>
    public static uint* SCIDtoWCID(uint* a1, uint a2) => ((delegate* unmanaged[Cdecl]<uint*, uint, uint*>)0x005BD3C0)(a1, a2);

    /// <summary>Collects all spell component identifiers stored in the table and appends them to the supplied QualifiedDataIDArray.
    /// <code>Offset: 0x005BD410
    /// void __thiscall SpellComponentTable::GetSubDataIDs(SpellComponentTable*,QualifiedDataIDArray*)</code>
    /// </summary>
    /// <param name="id_array">The array that receives the collected identifiers.</param>
    public void GetSubDataIDs(ACBindings.Internal.QualifiedDataIDArray* id_array) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SpellComponentTable, ACBindings.Internal.QualifiedDataIDArray*, void>)0x005BD410)(ref this, id_array);

    /// <summary>Initializes a SpellComponentTable by setting up base classes and preparing internal hash tables for spell components.
    /// <code>Offset: 0x005BD840
    /// int __thiscall SpellComponentTable::SpellComponentTable(int,void**)</code>
    /// </summary>
    /// <param name="a2">Optional data used during base class construction, typically database or context information.</param>
    /// <returns>The initialized SpellComponentTable instance (this pointer).</returns>
    public int _ConstructorInternal(void** a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SpellComponentTable, void**, int>)0x005BD840)(ref this, a2);
}

