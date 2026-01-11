namespace ACBindings.Internal;

public unsafe struct WeenieDesc : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.PackObj BaseClass_PackObj; // ACBindings.Internal.PackObj

    // Child Types
    public unsafe struct WeenieDesc_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.WeenieDesc*, void> WeenieDesc_dtor_0; // function pointer
        public fixed byte gap4[4];
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.WeenieDesc*, uint> GetPackSize; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.WeenieDesc*, void**, uint, uint> Pack; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.WeenieDesc*, void**, uint, int> UnPack; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.WeenieDesc*, uint> pack_size; // function pointer

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

    /// <summary>
    /// <code>Offset: 0x005AEBE0
    /// void __thiscall WeenieDesc::WeenieDesc(WeenieDesc*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.WeenieDesc, void>)0x005AEBE0)(ref this);

    /// <summary>
    /// <code>Offset: 0x005AEBF0
    /// void __thiscall WeenieDesc::~WeenieDesc(WeenieDesc*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.WeenieDesc, void>)0x005AEBF0)(ref this);
}

