namespace ACBindings.Internal;


/// <summary>Provides a lightweight RAII wrapper for the Windows Sockets API, automatically initializing WSAStartup on first use and cleaning up when all references are released.</summary>
/// <remarks>Uses an internal static reference counter; construction increments and triggers WSAStartup if this is the first instance. Destruction decrements counter and calls WSACleanup once it reaches zero.</remarks>
public unsafe struct NetInitializer : System.IDisposable
{
    // Statics
    public static uint* s_RefCount = (uint*)0x008EEFC8;

    // Child Types

    /// <summary>Releases all Winsock resources initialized by the application, ensuring a clean shutdown of socket operations.</summary>
    public unsafe struct AllSocketsCrashCleaner
    {
        // Base Classes
        public ACBindings.Internal.CrashCleaner BaseClass_CrashCleaner; // ACBindings.Internal.CrashCleaner

        // Child Types
        public unsafe struct AllSocketsCrashCleaner_vtbl
        {
            // Members
            public static delegate* unmanaged[Thiscall]<ACBindings.Internal.NetInitializer.AllSocketsCrashCleaner*, void> NetInitializer; // function pointer
            public static delegate* unmanaged[Thiscall]<ACBindings.Internal.NetInitializer.AllSocketsCrashCleaner*, ACBindings.Internal.CPluginManager*, void> OnPluggedIn; // function pointer
            public static delegate* unmanaged[Thiscall]<ACBindings.Internal.NetInitializer.AllSocketsCrashCleaner*, void> CrashCleanup; // function pointer

            // Methods
        }

        // Methods

        /// <summary>Releases all Winsock resources initialized by the application, ensuring a clean shutdown of socket operations.
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

    /// <summary>Initializes the networking subsystem by invoking WSAStartup when the first instance of NetInitializer is created.
    /// <code>Offset: 0x005AB7C0
    /// void __thiscall NetInitializer::NetInitializer(NetInitializer*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.NetInitializer, void>)0x005AB7C0)(ref this);

    /// <summary>Destroys a NetInitializer instance, decrementing the global reference count and invoking WSACleanup() to release Windows socket resources when no more references remain.
    /// <code>Offset: 0x005AB800
    /// void __thiscall NetInitializer::~NetInitializer(NetInitializer*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.NetInitializer, void>)0x005AB800)(ref this);
}

