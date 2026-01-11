namespace ACBindings.Internal;

public unsafe struct GlobalEventHandler : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.NoticeRegistrar BaseClass_NoticeRegistrar; // ACBindings.Internal.NoticeRegistrar

    // Child Types
    public unsafe struct GlobalEventHandler_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.GlobalEventHandler*, void> GlobalEventHandler_dtor_0; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.GlobalEventHandler*, uint, ACBindings.Internal.NoticeHandler*, byte> RegisterNoticeHandler; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.GlobalEventHandler*, uint, ACBindings.Internal.NoticeHandler*, byte> UnRegisterNoticeHandler; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.GlobalEventHandler*, ACBindings.Internal.NoticeHandler*, byte> UnRegisterAllNoticeHandlers; // function pointer
        public System.IntPtr GetNoticeHandlers;

        // Methods
    }

    // Generated Constructor
    public GlobalEventHandler() {
        _ConstructorInternal();
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x0043C640
    /// void __thiscall GlobalEventHandler::GlobalEventHandler(GlobalEventHandler*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.GlobalEventHandler, void>)0x0043C640)(ref this);

    /// <summary>
    /// <code>Offset: 0x0043C660
    /// void __thiscall GlobalEventHandler::~GlobalEventHandler(GlobalEventHandler*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.GlobalEventHandler, void>)0x0043C660)(ref this);

    /// <summary>
    /// <code>Offset: 0x0043C680
    /// GlobalEventHandler* __cdecl GlobalEventHandler::GetGlobalEventHandler()</code>
    /// </summary>
    public static ACBindings.Internal.GlobalEventHandler* GetGlobalEventHandler() => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.GlobalEventHandler*>)0x0043C680)();
}

