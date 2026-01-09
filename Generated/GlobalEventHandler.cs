namespace ACBindings;

// GlobalEventHandler
public unsafe struct GlobalEventHandler : System.IDisposable
{
    // Base Classes
    public ACBindings.NoticeRegistrar BaseClass_NoticeRegistrar; // ACBindings.NoticeRegistrar

    // Statics
    public static ACBindings.GlobalEventHandler* geh = (ACBindings.GlobalEventHandler*)0x00838374;

    // Child Types
    // GlobalEventHandler_vtbl
    public unsafe struct GlobalEventHandler_vtbl
    {
        // Members
        public System.IntPtr GlobalEventHandler_dtor_0; // function pointer
        public System.IntPtr RegisterNoticeHandler; // function pointer
        public System.IntPtr UnRegisterNoticeHandler; // function pointer
        public System.IntPtr UnRegisterAllNoticeHandlers; // function pointer
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
    // void __thiscall GlobalEventHandler::GlobalEventHandler(GlobalEventHandler*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.GlobalEventHandler, void>)0x0043C640)(ref this);
    // void __thiscall GlobalEventHandler::~GlobalEventHandler(GlobalEventHandler*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.GlobalEventHandler, void>)0x0043C660)(ref this);
    // GlobalEventHandler* __cdecl GlobalEventHandler::GetGlobalEventHandler()
    public static ACBindings.GlobalEventHandler* GetGlobalEventHandler() => ((delegate* unmanaged[Cdecl]<ACBindings.GlobalEventHandler*>)0x0043C680)();
}

