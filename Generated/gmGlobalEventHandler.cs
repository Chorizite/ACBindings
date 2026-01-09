namespace ACBindings;

// gmGlobalEventHandler
public unsafe struct gmGlobalEventHandler
{
    // Base Classes
    public ACBindings.GlobalEventHandler BaseClass_GlobalEventHandler; // ACBindings.GlobalEventHandler

    // Child Types
    // gmGlobalEventHandler_vtbl
    public unsafe struct gmGlobalEventHandler_vtbl
    {
        // Members
        public System.IntPtr gmGlobalEventHandler_dtor_0; // function pointer
        public System.IntPtr RegisterNoticeHandler; // function pointer
        public System.IntPtr UnRegisterNoticeHandler; // function pointer
        public System.IntPtr UnRegisterAllNoticeHandlers; // function pointer
        public System.IntPtr GetNoticeHandlers;

        // Methods
    }

    // Methods
}

