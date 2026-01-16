namespace ACBindings.Internal;


/// <summary>Registers crash‑cleaning functionality as a plugin prototype, enabling it to be added or removed from the application’s plugin manager and facilitating cleanup of crash data.</summary>
public unsafe struct CrashCleaner : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.CPluginPrototype BaseClass_CPluginPrototype; // ACBindings.Internal.CPluginPrototype

    // Child Types
    public unsafe struct CrashCleaner_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CrashCleaner*, void> CrashCleaner_dtor_0; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CrashCleaner*, ACBindings.Internal.CPluginManager*, void> OnPluggedIn; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CrashCleaner*, void> CrashCleanup; // function pointer

        // Methods
    }

    // Generated Constructor
    public CrashCleaner() {
        _ConstructorInternal();
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>Destructs a CrashCleaner instance by unregistering it from its plugin manager and restoring the base class state.
    /// <code>Offset: 0x0040E420
    /// void __thiscall CrashCleaner::~CrashCleaner(CrashCleaner*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CrashCleaner, void>)0x0040E420)(ref this);

    /// <summary>Initializes a CrashCleaner instance, setting its manager pointer to null and assigning the correct virtual table. Registers the prototype with the global plugin manager.
    /// <code>Offset: 0x0040E540
    /// void __thiscall CrashCleaner::CrashCleaner(CrashCleaner*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CrashCleaner, void>)0x0040E540)(ref this);
}

