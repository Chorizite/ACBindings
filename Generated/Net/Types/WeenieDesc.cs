namespace ACBindings;

// WeenieDesc
public unsafe struct WeenieDesc : System.IDisposable
{
    // Base Classes
    public ACBindings.PackObj BaseClass_PackObj; // ACBindings.PackObj

    // Child Types
    // WeenieDesc_vtbl
    public unsafe struct WeenieDesc_vtbl
    {
        // Members
        public System.IntPtr WeenieDesc_dtor_0; // function pointer
        public fixed byte gap4[4];
        public System.IntPtr GetPackSize; // function pointer
        public System.IntPtr Pack; // function pointer
        public System.IntPtr UnPack; // function pointer
        public System.IntPtr pack_size; // function pointer

        // Methods
    }

    // Generated Constructor
    public WeenieDesc() {
        _ConstructorInternal();
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods
    // void __thiscall WeenieDesc::WeenieDesc(WeenieDesc*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.WeenieDesc, void>)0x005AEBE0)(ref this);
    // void __thiscall WeenieDesc::~WeenieDesc(WeenieDesc*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.WeenieDesc, void>)0x005AEBF0)(ref this);
}

