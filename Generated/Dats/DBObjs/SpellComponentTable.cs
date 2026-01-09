namespace ACBindings;

// SpellComponentTable
public unsafe struct SpellComponentTable
{
    // Base Classes
    public ACBindings.SerializeUsingPackDBObj BaseClass_SerializeUsingPackDBObj; // ACBindings.SerializeUsingPackDBObj

    // Child Types
    // SpellComponentTable_vtbl
    public unsafe struct SpellComponentTable_vtbl
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
    public ACBindings.PackableHashTable__uint__SpellComponentBase _spellComponentBaseHash;

    // Generated Constructor
    public SpellComponentTable(void** a2) {
        _ConstructorInternal(a2);
    }

    // Methods
    // int __thiscall SpellComponentTable::InqSpellComponentBase(SpellComponentTable*,const unsigned int,SpellComponentBase*)
    public int InqSpellComponentBase(uint key, ACBindings.SpellComponentBase* sbase) => ((delegate* unmanaged[Thiscall]<ref ACBindings.SpellComponentTable, uint, ACBindings.SpellComponentBase*, int>)0x0048A1F0)(ref this, key, sbase);
    // DBObj* __cdecl SpellComponentTable::Allocator()
    public static ACBindings.DBObj* Allocator() => ((delegate* unmanaged[Cdecl]<ACBindings.DBObj*>)0x0058B730)();
    // unsigned int __cdecl SpellComponentTable::GetTargetTypeFromComponentID(const unsigned int)
    public static uint GetTargetTypeFromComponentID(uint scid) => ((delegate* unmanaged[Cdecl]<uint, uint>)0x005BD070)(scid);
    // unsigned int* __cdecl SpellComponentTable::SchoolOfMagic2WCID(unsigned int*,unsigned int)
    public static uint* SchoolOfMagic2WCID(uint* a1, uint a2) => ((delegate* unmanaged[Cdecl]<uint*, uint, uint*>)0x005BD2C0)(a1, a2);
    // int __cdecl SpellComponentTable::WCIDtoSCID(unsigned int)
    public static int WCIDtoSCID(uint a1) => ((delegate* unmanaged[Cdecl]<uint, int>)0x005BD310)(a1);
    // unsigned int* __cdecl SpellComponentTable::SCIDtoWCID(unsigned int*,unsigned int)
    public static uint* SCIDtoWCID(uint* a1, uint a2) => ((delegate* unmanaged[Cdecl]<uint*, uint, uint*>)0x005BD3C0)(a1, a2);
    // void __thiscall SpellComponentTable::GetSubDataIDs(SpellComponentTable*,QualifiedDataIDArray*)
    public void GetSubDataIDs(ACBindings.QualifiedDataIDArray* id_array) => ((delegate* unmanaged[Thiscall]<ref ACBindings.SpellComponentTable, ACBindings.QualifiedDataIDArray*, void>)0x005BD410)(ref this, id_array);
    // int __thiscall SpellComponentTable::SpellComponentTable(int,void**)
    public int _ConstructorInternal(void** a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.SpellComponentTable, void**, int>)0x005BD840)(ref this, a2);
}

