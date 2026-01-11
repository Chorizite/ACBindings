namespace ACBindings.Internal;

public unsafe struct SpellComponentTable
{
    // Base Classes
    public ACBindings.Internal.SerializeUsingPackDBObj BaseClass_SerializeUsingPackDBObj; // ACBindings.Internal.SerializeUsingPackDBObj

    // Child Types
    public unsafe struct SpellComponentTable_vtbl
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
    public ACBindings.Internal.PackableHashTable__uint___SpellComponentBase _spellComponentBaseHash;

    // Generated Constructor
    public SpellComponentTable(void** a2) {
        _ConstructorInternal(a2);
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x0048A1F0
    /// int __thiscall SpellComponentTable::InqSpellComponentBase(SpellComponentTable*,const unsigned int,SpellComponentBase*)</code>
    /// </summary>
    public int InqSpellComponentBase(uint key, ACBindings.Internal.SpellComponentBase* sbase) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SpellComponentTable, uint, ACBindings.Internal.SpellComponentBase*, int>)0x0048A1F0)(ref this, key, sbase);

    /// <summary>
    /// <code>Offset: 0x0058B730
    /// DBObj* __cdecl SpellComponentTable::Allocator()</code>
    /// </summary>
    public static ACBindings.Internal.DBObj* Allocator() => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.DBObj*>)0x0058B730)();

    /// <summary>
    /// <code>Offset: 0x005BD070
    /// unsigned int __cdecl SpellComponentTable::GetTargetTypeFromComponentID(const unsigned int)</code>
    /// </summary>
    public static uint GetTargetTypeFromComponentID(uint scid) => ((delegate* unmanaged[Cdecl]<uint, uint>)0x005BD070)(scid);

    /// <summary>
    /// <code>Offset: 0x005BD2C0
    /// unsigned int* __cdecl SpellComponentTable::SchoolOfMagic2WCID(unsigned int*,unsigned int)</code>
    /// </summary>
    public static uint* SchoolOfMagic2WCID(uint* a1, uint a2) => ((delegate* unmanaged[Cdecl]<uint*, uint, uint*>)0x005BD2C0)(a1, a2);

    /// <summary>
    /// <code>Offset: 0x005BD310
    /// int __cdecl SpellComponentTable::WCIDtoSCID(unsigned int)</code>
    /// </summary>
    public static int WCIDtoSCID(uint a1) => ((delegate* unmanaged[Cdecl]<uint, int>)0x005BD310)(a1);

    /// <summary>
    /// <code>Offset: 0x005BD3C0
    /// unsigned int* __cdecl SpellComponentTable::SCIDtoWCID(unsigned int*,unsigned int)</code>
    /// </summary>
    public static uint* SCIDtoWCID(uint* a1, uint a2) => ((delegate* unmanaged[Cdecl]<uint*, uint, uint*>)0x005BD3C0)(a1, a2);

    /// <summary>
    /// <code>Offset: 0x005BD410
    /// void __thiscall SpellComponentTable::GetSubDataIDs(SpellComponentTable*,QualifiedDataIDArray*)</code>
    /// </summary>
    public void GetSubDataIDs(ACBindings.Internal.QualifiedDataIDArray* id_array) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SpellComponentTable, ACBindings.Internal.QualifiedDataIDArray*, void>)0x005BD410)(ref this, id_array);

    /// <summary>
    /// <code>Offset: 0x005BD840
    /// int __thiscall SpellComponentTable::SpellComponentTable(int,void**)</code>
    /// </summary>
    public int _ConstructorInternal(void** a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SpellComponentTable, void**, int>)0x005BD840)(ref this, a2);
}

