namespace ACBindings;

// PalSet
public unsafe struct PalSet
{
    // Base Classes
    public ACBindings.SerializeUsingPackDBObj BaseClass_SerializeUsingPackDBObj; // ACBindings.SerializeUsingPackDBObj

    // Child Types
    // PalSet_vtbl
    public unsafe struct PalSet_vtbl
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
    public uint num_pals;
    public System.IntPtr palette_IDs;

    // Generated Constructor
    public PalSet(void** a2) {
        _ConstructorInternal(a2);
    }

    // Methods
    // DBObj* __cdecl PalSet::Get(int)
    public static ACBindings.DBObj* Get(int a1) => ((delegate* unmanaged[Cdecl]<int, ACBindings.DBObj*>)0x0047D050)(a1);
    // DBObj* __cdecl PalSet::Allocator()
    public static ACBindings.DBObj* Allocator() => ((delegate* unmanaged[Cdecl]<ACBindings.DBObj*>)0x004F7D60)();
    // int __thiscall PalSet::PalSet(int,void**)
    public int _ConstructorInternal(void** a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.PalSet, void**, int>)0x005AD5E0)(ref this, a2);
    // unsigned int* __thiscall PalSet::GetPaletteID(_DWORD*,unsigned int*,double)
    public uint* GetPaletteID(uint* a2, double a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.PalSet, uint*, double, uint*>)0x005AD620)(ref this, a2, a3);
    // unsigned int* __thiscall PalSet::GetPaletteID_Integral(_DWORD*,unsigned int*,int)
    public uint* GetPaletteID_Integral(uint* a2, int a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.PalSet, uint*, int, uint*>)0x005AD6A0)(ref this, a2, a3);
    // unsigned int __thiscall PalSet::Pack(PalSet*,void**,unsigned int)
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.PalSet, void**, uint, uint>)0x005AD6E0)(ref this, addr, size);
    // int __thiscall PalSet::UnPack(PalSet*,void**,unsigned int)
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.PalSet, void**, uint, int>)0x005AD730)(ref this, addr, size);
}

