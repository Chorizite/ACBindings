namespace ACBindings.Internal;


/// <summary>Provides a visual description of an in‑game entity by wrapping a PackObj instance and temporarily assigning the VisualDesc virtual table during construction, restoring it upon destruction.</summary>
public unsafe struct WeenieDesc : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.PackObj BaseClass_PackObj; // ACBindings.Internal.PackObj

    // Child Types
    public unsafe struct WeenieDesc_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.WeenieDesc*, void> WeenieDesc_dtor_0; // function pointer
        public fixed byte gap4[4];
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.WeenieDesc*, uint> GetPackSize; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.WeenieDesc*, void**, uint, uint> Pack; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.WeenieDesc*, void**, uint, int> UnPack; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.WeenieDesc*, uint> pack_size; // function pointer

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

    /// <summary>Initializes a WeenieDesc object by assigning its base PackObj’s virtual table to that of VisualDesc, enabling proper polymorphic behavior.
    /// <code>Offset: 0x005AEBE0
    /// void __thiscall WeenieDesc::WeenieDesc(WeenieDesc*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.WeenieDesc, void>)0x005AEBE0)(ref this);

    /// <summary>Restores the PackObj base‑class virtual table for a WeenieDesc instance during destruction.
    /// <code>Offset: 0x005AEBF0
    /// void __thiscall WeenieDesc::~WeenieDesc(WeenieDesc*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.WeenieDesc, void>)0x005AEBF0)(ref this);
}

