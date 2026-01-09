namespace ACBindings;

// DBWave
public unsafe struct DBWave
{
    // Base Classes
    public ACBindings.SerializeUsingPackDBObj BaseClass_SerializeUsingPackDBObj; // ACBindings.SerializeUsingPackDBObj
    public ACBindings.WaveFile BaseClass_WaveFile; // ACBindings.WaveFile

    // Child Types
    // DBWave_vtbl
    public unsafe struct DBWave_vtbl
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

    // Generated Constructor
    public DBWave(void** a2) {
        _ConstructorInternal(a2);
    }

    // Methods
    // DBObj* __cdecl DBWave::Allocator()
    public static ACBindings.DBObj* Allocator() => ((delegate* unmanaged[Cdecl]<ACBindings.DBObj*>)0x004F7BD0)();
    // int __thiscall DBWave::DBWave(int,void**)
    public int _ConstructorInternal(void** a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.DBWave, void**, int>)0x005526C0)(ref this, a2);
    // unsigned int __thiscall DBWave::Pack(DBWave*,void**,unsigned int)
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.DBWave, void**, uint, uint>)0x00552730)(ref this, addr, size);
    // int __thiscall DBWave::UnPack(DBWave*,void**,unsigned int)
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.DBWave, void**, uint, int>)0x005527B0)(ref this, addr, size);
    // DBObj* __cdecl DBWave::Get(int)
    public static ACBindings.DBObj* Get(int a1) => ((delegate* unmanaged[Cdecl]<int, ACBindings.DBObj*>)0x005534A0)(a1);
}

