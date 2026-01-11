namespace ACBindings.Internal;

public unsafe struct gmGlobalEventHandler
{
    // Base Classes
    public ACBindings.Internal.GlobalEventHandler BaseClass_GlobalEventHandler; // ACBindings.Internal.GlobalEventHandler

    // Child Types
    public unsafe struct gmGlobalEventHandler_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.gmGlobalEventHandler*, void> gmGlobalEventHandler_dtor_0; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.gmGlobalEventHandler*, uint, ACBindings.Internal.NoticeHandler*, byte> RegisterNoticeHandler; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.gmGlobalEventHandler*, uint, ACBindings.Internal.NoticeHandler*, byte> UnRegisterNoticeHandler; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.gmGlobalEventHandler*, ACBindings.Internal.NoticeHandler*, byte> UnRegisterAllNoticeHandlers; // function pointer
        public System.IntPtr GetNoticeHandlers;

        // Methods
    }

    // Methods
}

