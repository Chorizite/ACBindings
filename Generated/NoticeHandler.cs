namespace ACBindings.Internal;


/// <summary>Handles system notifications by maintaining a virtual function table reference, enabling dynamic dispatch of notice-related callbacks.</summary>
public unsafe struct NoticeHandler : System.IDisposable
{
    // Child Types

    /// <summary>Provides a virtual table of function pointers that handle diverse in‑game notifications—including character state changes, server messages, object creation/deletion events, and UI interactions—allowing a NoticeHandler implementation to respond accordingly.</summary>
    public unsafe struct NoticeHandler_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.NoticeHandler*, byte> IsEngine; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.NoticeHandler*, ACBindings.Internal.CharacterSet*, void> RecvNotice_CharacterSet; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.NoticeHandler*, void> RecvNotice_PlayerObjDescChanged; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.NoticeHandler*, byte, uint, uint, void> RecvNotice_RuntimeDDDStatus; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.NoticeHandler*, uint, uint, void> RecvNotice_ItemAttributesChanged; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.NoticeHandler*, uint, void> RecvNotice_ServerSaysAttemptFailed; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.NoticeHandler*, uint, uint, uint, uint, uint, int, uint, uint, void> RecvNotice_ServerSaysMoveItem; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.NoticeHandler*, uint, uint, void> RecvNotice_SetSelectedItem; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.NoticeHandler*, ACBindings.Internal.charError, void> RecvNotice_CharacterError; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.NoticeHandler*, void> RecvNotice_ServerDied; // function pointer
        public System.IntPtr RecvNotice_WorldName;
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.NoticeHandler*, ACBindings.Internal.CWeenieObject*, void> RecvNotice_BeingDeleted; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.NoticeHandler*, uint, void> RecvNotice_CreateObject; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.NoticeHandler*, uint, ACBindings.Internal.PropertyCollection*, void> RecvNotice_CloseDialog; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.NoticeHandler*, uint, ACBindings.Internal.StringInfo*, ACBindings.Internal.StringInfo*, uint, void> RecvNotice_DisplayFinalStringInfo; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.NoticeHandler*, uint, ACBindings.Internal.StringInfo*, void> RecvNotice_DisplayStringInfo; // function pointer
        public System.IntPtr RecvNotice_DisplayWeenieError;
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.NoticeHandler*, uint, void> RecvNotice_OpenDialog; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.NoticeHandler*, uint, void> RecvNotice_SmartBoxObjectFound; // function pointer
        public System.IntPtr RecvNotice_TextTag_DIDClick;
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.NoticeHandler*, uint, uint, void> RecvNotice_TextTag_IIDClick; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.NoticeHandler*, uint, uint, uint, void> RecvNotice_TextTag_IIDEnumClick; // function pointer
        public System.IntPtr RecvNotice_TextTag_IIDStringClick;
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.NoticeHandler*, uint, uint, uint, uint, void> RecvNotice_UpdateGameView; // function pointer

        // Methods
    }

    // Members
    public System.IntPtr __vftable; // vtable pointer

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>Destructs a NoticeHandler, resetting its virtual table and removing it from any registered global or local event handlers.
    /// <code>Offset: 0x0043C610
    /// void __thiscall NoticeHandler::~NoticeHandler(NoticeHandler*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.NoticeHandler, void>)0x0043C610)(ref this);
}

