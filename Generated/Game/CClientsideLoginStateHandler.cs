namespace ACBindings.Internal;


/// <summary>Handles client‑side login operations within the asynchronous state machine by registering context data for recipient ID, server address, authenticator, and failure reason.</summary>
public unsafe struct CClientsideLoginStateHandler
{
    // Base Classes
    public ACBindings.Internal.CAsyncStateHandler BaseClass_CAsyncStateHandler; // ACBindings.Internal.CAsyncStateHandler

    // Child Types
    public unsafe struct CClientsideLoginStateHandler_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CClientsideLoginStateHandler*, void> CClientsideLoginStateHandler_dtor_0; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CClientsideLoginStateHandler*, ACBindings.Internal.AsyncContext, void> OnContextBegun; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CClientsideLoginStateHandler*, ACBindings.Internal.AsyncContext, void> OnStateBegun; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CClientsideLoginStateHandler*, ACBindings.Internal.AsyncContext, ACBindings.Internal.AsyncStateMachineStatus, void> OnStateEnded; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CClientsideLoginStateHandler*, ACBindings.Internal.AsyncContext, ACBindings.Internal.AsyncStateMachineStatus, void> OnContextEnded; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CClientsideLoginStateHandler*, ACBindings.Internal.AsyncContext, void> CleanupContextData; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CClientsideLoginStateHandler*, void> OnStateHandlerInit; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CClientsideLoginStateHandler*, void> OnStateHandlerDone; // function pointer

        // Methods
    }

    // Members
    public uint m_idxRecipientID;
    public uint m_idxServerAddr;
    public uint m_idxNetAuth;
    public uint m_idxFailureReason;

    // Methods

    /// <summary>Registers the context data identifiers used by the client‑side login state machine and stores their corresponding indices for fast lookup during asynchronous processing.
    /// <code>Offset: 0x00545150
    /// void __thiscall CClientsideLoginStateHandler::OnStateHandlerInit(CClientsideLoginStateHandler*)</code>
    /// </summary>
    public void OnStateHandlerInit() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CClientsideLoginStateHandler, void>)0x00545150)(ref this);
}

