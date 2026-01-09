namespace ACBindings;

// NetInitializer
public unsafe struct NetInitializer : System.IDisposable
{
    // Statics
    public static uint* s_RefCount = (uint*)0x008EEFC8;

    // Child Types
    // NetInitializer::AllSocketsCrashCleaner_vtbl
    public unsafe struct AllSocketsCrashCleaner_vtbl
    {
        // Members
        public System.IntPtr NetInitializer; // function pointer
        public System.IntPtr OnPluggedIn; // function pointer
        public System.IntPtr CrashCleanup; // function pointer

        // Methods
    }
    // NetInitializer::AllSocketsCrashCleaner
    public unsafe struct AllSocketsCrashCleaner
    {
        // Base Classes
        public ACBindings.CrashCleaner BaseClass_CrashCleaner; // ACBindings.CrashCleaner

        // Methods
        // void __thiscall NetInitializer::AllSocketsCrashCleaner::CrashCleanup(NetInitializer::AllSocketsCrashCleaner*)
        public void CrashCleanup() => ((delegate* unmanaged[Thiscall]<ref ACBindings.NetInitializer.AllSocketsCrashCleaner, void>)0x005AB810)(ref this);
    }

    // Generated Constructor
    public NetInitializer() {
        _ConstructorInternal();
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods
    // void __thiscall NetInitializer::NetInitializer(NetInitializer*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.NetInitializer, void>)0x005AB7C0)(ref this);
    // void __thiscall NetInitializer::~NetInitializer(NetInitializer*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.NetInitializer, void>)0x005AB800)(ref this);
}

