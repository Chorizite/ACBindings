namespace ACBindings;

// CrashCleaner
public unsafe struct CrashCleaner : System.IDisposable
{
    // Base Classes
    public ACBindings.CPluginPrototype BaseClass_CPluginPrototype; // ACBindings.CPluginPrototype

    // Child Types
    // CrashCleaner_vtbl
    public unsafe struct CrashCleaner_vtbl
    {
        // Members
        public System.IntPtr CrashCleaner_dtor_0; // function pointer
        public System.IntPtr OnPluggedIn; // function pointer
        public System.IntPtr CrashCleanup; // function pointer

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
    // void __thiscall CrashCleaner::~CrashCleaner(CrashCleaner*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CrashCleaner, void>)0x0040E420)(ref this);
    // void __thiscall CrashCleaner::CrashCleaner(CrashCleaner*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CrashCleaner, void>)0x0040E540)(ref this);
}

