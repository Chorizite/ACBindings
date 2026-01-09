namespace ACBindings;

// CSoundTable
public unsafe struct CSoundTable : System.IDisposable
{
    // Base Classes
    public ACBindings.SerializeUsingPackDBObj BaseClass_SerializeUsingPackDBObj; // ACBindings.SerializeUsingPackDBObj

    // Child Types
    // CSoundTable_vtbl
    public unsafe struct CSoundTable_vtbl
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
    public ACBindings.SoundTableData sound_data_;

    // Generated Constructor
    public CSoundTable(void** a2) {
        _ConstructorInternal(a2);
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods
    // DBObj* __cdecl CSoundTable::Allocator()
    public static ACBindings.DBObj* Allocator() => ((delegate* unmanaged[Cdecl]<ACBindings.DBObj*>)0x004F7E20)();
    // int __thiscall CSoundTable::UnPack(CSoundTable*,void**,unsigned int)
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CSoundTable, void**, uint, int>)0x005528F0)(ref this, addr, size);
    // void __thiscall CSoundTable::GetSubDataIDs(CSoundTable*,QualifiedDataIDArray*)
    public void GetSubDataIDs(ACBindings.QualifiedDataIDArray* id_array) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CSoundTable, ACBindings.QualifiedDataIDArray*, void>)0x00552C70)(ref this, id_array);
    // unsigned int __thiscall CSoundTable::Pack(CSoundTable*,void**,unsigned int)
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CSoundTable, void**, uint, uint>)0x00552C80)(ref this, addr, size);
    // int __thiscall CSoundTable::CSoundTable(int,void**)
    public int _ConstructorInternal(void** a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CSoundTable, void**, int>)0x00553150)(ref this, a2);
    // unsigned int __thiscall CSoundTable::GetDBOType(CSoundTable*)
    public uint GetDBOType() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CSoundTable, uint>)0x00553180)(ref this);
    // void __thiscall CSoundTable::~CSoundTable(CSoundTable*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CSoundTable, void>)0x005531A0)(ref this);
}

