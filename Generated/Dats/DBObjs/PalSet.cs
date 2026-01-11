namespace ACBindings.Internal;

public unsafe struct PalSet
{
    // Base Classes
    public ACBindings.Internal.SerializeUsingPackDBObj BaseClass_SerializeUsingPackDBObj; // ACBindings.Internal.SerializeUsingPackDBObj

    // Child Types
    public unsafe struct PalSet_vtbl
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
    public uint num_pals;
    public System.IntPtr palette_IDs;

    // Generated Constructor
    public PalSet(void** a2) {
        _ConstructorInternal(a2);
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x0047D050
    /// DBObj* __cdecl PalSet::Get(int)</code>
    /// </summary>
    public static ACBindings.Internal.DBObj* Get(int a1) => ((delegate* unmanaged[Cdecl]<int, ACBindings.Internal.DBObj*>)0x0047D050)(a1);

    /// <summary>
    /// <code>Offset: 0x004F7D60
    /// DBObj* __cdecl PalSet::Allocator()</code>
    /// </summary>
    public static ACBindings.Internal.DBObj* Allocator() => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.DBObj*>)0x004F7D60)();

    /// <summary>
    /// <code>Offset: 0x005AD5E0
    /// int __thiscall PalSet::PalSet(int,void**)</code>
    /// </summary>
    public int _ConstructorInternal(void** a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PalSet, void**, int>)0x005AD5E0)(ref this, a2);

    /// <summary>
    /// <code>Offset: 0x005AD620
    /// unsigned int* __thiscall PalSet::GetPaletteID(_DWORD*,unsigned int*,double)</code>
    /// </summary>
    public uint* GetPaletteID(uint* a2, double a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PalSet, uint*, double, uint*>)0x005AD620)(ref this, a2, a3);

    /// <summary>
    /// <code>Offset: 0x005AD6A0
    /// unsigned int* __thiscall PalSet::GetPaletteID_Integral(_DWORD*,unsigned int*,int)</code>
    /// </summary>
    public uint* GetPaletteID_Integral(uint* a2, int a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PalSet, uint*, int, uint*>)0x005AD6A0)(ref this, a2, a3);

    /// <summary>
    /// <code>Offset: 0x005AD6E0
    /// unsigned int __thiscall PalSet::Pack(PalSet*,void**,unsigned int)</code>
    /// </summary>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PalSet, void**, uint, uint>)0x005AD6E0)(ref this, addr, size);

    /// <summary>
    /// <code>Offset: 0x005AD730
    /// int __thiscall PalSet::UnPack(PalSet*,void**,unsigned int)</code>
    /// </summary>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PalSet, void**, uint, int>)0x005AD730)(ref this, addr, size);
}

