namespace ACBindings;

// PlayerDesc
public unsafe struct PlayerDesc
{
    // Base Classes
    public ACBindings.CACQualities BaseClass_CACQualities; // ACBindings.CACQualities

    // Child Types
    // PlayerDesc_vtbl
    public unsafe struct PlayerDesc_vtbl
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
        public System.IntPtr InqPluralNameString;

        // Methods
    }

    // Generated Constructor
    public PlayerDesc() {
        _ConstructorInternal();
    }

    // Methods
    // bool __thiscall PlayerDesc::PlayerIsPSRLead(PlayerDesc*)
    public byte PlayerIsPSRLead() => ((delegate* unmanaged[Thiscall]<ref ACBindings.PlayerDesc, byte>)0x00593DE0)(ref this);
    // bool __thiscall PlayerDesc::PlayerIsPSR(PlayerDesc*)
    public byte PlayerIsPSR() => ((delegate* unmanaged[Thiscall]<ref ACBindings.PlayerDesc, byte>)0x00593E30)(ref this);
    // TResult* __thiscall PlayerDesc::QueryInterface(PlayerDesc*,TResult*,const Turbine_GUID*,void**)
    public ACBindings.TResult* QueryInterface(ACBindings.TResult* result, ACBindings.Turbine_GUID* i_rcInterface, void** o_ppvInterface) => ((delegate* unmanaged[Thiscall]<ref ACBindings.PlayerDesc, ACBindings.TResult*, ACBindings.Turbine_GUID*, void**, ACBindings.TResult*>)0x00593F20)(ref this, result, i_rcInterface, o_ppvInterface);
    // void __thiscall PlayerDesc::PlayerDesc(PlayerDesc*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.PlayerDesc, void>)0x00594620)(ref this);
    // void __thiscall PlayerDesc::Cleanup(PlayerDesc*)
    public void Cleanup() => ((delegate* unmanaged[Thiscall]<ref ACBindings.PlayerDesc, void>)0x00594710)(ref this);
}

