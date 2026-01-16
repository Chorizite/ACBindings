namespace ACBindings.Internal;


/// <summary>Manages the client UI flow by coordinating mode transitions, registering UI elements and event listeners, and handling character error and server death notices.</summary>
public unsafe struct gmUIFlow : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.UIFlow BaseClass_UIFlow; // ACBindings.Internal.UIFlow
    public ACBindings.Internal.gmNoticeHandler BaseClass_gmNoticeHandler; // ACBindings.Internal.gmNoticeHandler

    // Child Types
    public unsafe struct gmUIFlow_vtbl
    {
        // Members
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.Interface*, ACBindings.Internal._GUID*, void**, int> IUnknown_QueryInterface; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.Interface*, uint> IUnknown_AddRef; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.Interface*, uint> IUnknown_Release; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.Interface*, ACBindings.Internal.TResult*, ACBindings.Internal.Turbine_GUID*, void**, ACBindings.Internal.TResult*> QueryInterface; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.Interface*, uint> AddRef; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.Interface*, uint> Release; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIFlow*, ACBindings.Internal.UIFlow.Enum19> You_Must_Not_Have_Multiple_Implementations_Of_AddRef_In_A_Hierarchy; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIFlow*, uint, void> QueueUIMode; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIFlow*, uint, ACBindings.Internal.StringInfo*, void> QueueUIModeWithError; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIFlow*, ACBindings.Internal.UIPersistantData*> GetPersistantData; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIFlow*, void> Update; // function pointer

        // Methods
    }

    // Generated Constructor
    public gmUIFlow() {
        _ConstructorInternal();
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>Initializes the UI flow system by setting up vtables, registering UI elements and modes, queuing the initial mode, configuring the cursor element, and registering notice handlers with the global event handler.
    /// <code>Offset: 0x0047AA10
    /// void __thiscall gmUIFlow::gmUIFlow(gmUIFlow*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmUIFlow, void>)0x0047AA10)(ref this);

    /// <summary>Destroys a gmUIFlow object, unregistering all global notice handlers, cleaning up UI resources, and invoking the destructors of its embedded UIFlow and NoticeHandler components.
    /// <code>Offset: 0x0047AB20
    /// void __thiscall gmUIFlow::~gmUIFlow(gmUIFlow*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmUIFlow, void>)0x0047AB20)(ref this);

    /// <summary>Translates character error codes into localized message identifiers and forwards them to the notice handler with an appropriate notice type.
    /// <code>Offset: 0x0047ABC0
    /// void __thiscall gmUIFlow::RecvNotice_CharacterError(gmUIFlow*,charError)</code>
    /// </summary>
    /// <param name="error">The character error code specifying the failure that occurred, such as logon errors, server crashes, or account issues.</param>
    public void RecvNotice_CharacterError(ACBindings.Internal.charError error) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmUIFlow, ACBindings.Internal.charError, void>)0x0047ABC0)(ref this, error);

    /// <summary>Handles a notification that the server has died by displaying an error message when appropriate.
    /// <code>Offset: 0x0047ADA0
    /// void __thiscall gmUIFlow::RecvNotice_ServerDied(gmUIFlow*)</code>
    /// </summary>
    public void RecvNotice_ServerDied() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmUIFlow, void>)0x0047ADA0)(ref this);
}

