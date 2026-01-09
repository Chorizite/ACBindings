namespace ACBindings;

// NoticeHandler
public unsafe struct NoticeHandler : System.IDisposable
{
    // Child Types
    // NoticeHandler_vtbl
    public unsafe struct NoticeHandler_vtbl
    {
        // Members
        public System.IntPtr IsEngine; // function pointer
        public System.IntPtr RecvNotice_CharacterSet; // function pointer
        public System.IntPtr RecvNotice_PlayerObjDescChanged; // function pointer
        public System.IntPtr RecvNotice_RuntimeDDDStatus; // function pointer
        public System.IntPtr RecvNotice_ItemAttributesChanged; // function pointer
        public System.IntPtr RecvNotice_ServerSaysAttemptFailed; // function pointer
        public System.IntPtr RecvNotice_ServerSaysMoveItem; // function pointer
        public System.IntPtr RecvNotice_SetSelectedItem; // function pointer
        public System.IntPtr RecvNotice_CharacterError; // function pointer
        public System.IntPtr RecvNotice_ServerDied; // function pointer
        public System.IntPtr RecvNotice_WorldName;
        public System.IntPtr RecvNotice_BeingDeleted; // function pointer
        public System.IntPtr RecvNotice_CreateObject; // function pointer
        public System.IntPtr RecvNotice_CloseDialog; // function pointer
        public System.IntPtr RecvNotice_DisplayFinalStringInfo; // function pointer
        public System.IntPtr RecvNotice_DisplayStringInfo; // function pointer
        public System.IntPtr RecvNotice_DisplayWeenieError;
        public System.IntPtr RecvNotice_OpenDialog; // function pointer
        public System.IntPtr RecvNotice_SmartBoxObjectFound; // function pointer
        public System.IntPtr RecvNotice_TextTag_DIDClick;
        public System.IntPtr RecvNotice_TextTag_IIDClick; // function pointer
        public System.IntPtr RecvNotice_TextTag_IIDEnumClick; // function pointer
        public System.IntPtr RecvNotice_TextTag_IIDStringClick;
        public System.IntPtr RecvNotice_UpdateGameView; // function pointer

        // Methods
    }

    // Members
    public System.IntPtr __vftable; // vtable pointer

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods
    // void __thiscall NoticeHandler::~NoticeHandler(NoticeHandler*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.NoticeHandler, void>)0x0043C610)(ref this);
}

