namespace ACBindings.Internal;

public unsafe struct NetInitializer : System.IDisposable
{
    // Statics
    public static uint* s_RefCount = (uint*)0x008EEFC8;

    // Child Types
    public unsafe struct AllSocketsCrashCleaner
    {
        // Base Classes
        public ACBindings.Internal.CrashCleaner BaseClass_CrashCleaner; // ACBindings.Internal.CrashCleaner

        // Child Types
        public unsafe struct AllSocketsCrashCleaner_vtbl
        {
            // Members
            public delegate* unmanaged[Thiscall]<ACBindings.Internal.NetInitializer.AllSocketsCrashCleaner*, void> NetInitializer; // function pointer
            public delegate* unmanaged[Thiscall]<ACBindings.Internal.NetInitializer.AllSocketsCrashCleaner*, ACBindings.Internal.CPluginManager*, void> OnPluggedIn; // function pointer
            public delegate* unmanaged[Thiscall]<ACBindings.Internal.NetInitializer.AllSocketsCrashCleaner*, void> CrashCleanup; // function pointer

            // Methods
        }

        // Methods

        /// <summary>
        /// <code>Offset: 0x005AB810
        /// void __thiscall NetInitializer::AllSocketsCrashCleaner::CrashCleanup(NetInitializer::AllSocketsCrashCleaner*)</code>
        /// </summary>
        public void CrashCleanup() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.NetInitializer.AllSocketsCrashCleaner, void>)0x005AB810)(ref this);
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

    /// <summary>
    /// <code>Offset: 0x005AB7C0
    /// void __thiscall NetInitializer::NetInitializer(NetInitializer*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.NetInitializer, void>)0x005AB7C0)(ref this);

    /// <summary>
    /// <code>Offset: 0x005AB800
    /// void __thiscall NetInitializer::~NetInitializer(NetInitializer*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.NetInitializer, void>)0x005AB800)(ref this);
}

