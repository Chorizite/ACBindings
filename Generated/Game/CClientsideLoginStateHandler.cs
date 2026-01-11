namespace ACBindings.Internal;

public unsafe struct CClientsideLoginStateHandler
{
    // Base Classes
    public ACBindings.Internal.CAsyncStateHandler BaseClass_CAsyncStateHandler; // ACBindings.Internal.CAsyncStateHandler

    // Child Types
    public unsafe struct CClientsideLoginStateHandler_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CClientsideLoginStateHandler*, void> CClientsideLoginStateHandler_dtor_0; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CClientsideLoginStateHandler*, ACBindings.Internal.AsyncContext, void> OnContextBegun; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CClientsideLoginStateHandler*, ACBindings.Internal.AsyncContext, void> OnStateBegun; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CClientsideLoginStateHandler*, ACBindings.Internal.AsyncContext, ACBindings.Internal.AsyncStateMachineStatus, void> OnStateEnded; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CClientsideLoginStateHandler*, ACBindings.Internal.AsyncContext, ACBindings.Internal.AsyncStateMachineStatus, void> OnContextEnded; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CClientsideLoginStateHandler*, ACBindings.Internal.AsyncContext, void> CleanupContextData; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CClientsideLoginStateHandler*, void> OnStateHandlerInit; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CClientsideLoginStateHandler*, void> OnStateHandlerDone; // function pointer

        // Methods
    }

    // Members
    public uint m_idxRecipientID;
    public uint m_idxServerAddr;
    public uint m_idxNetAuth;
    public uint m_idxFailureReason;

    // Methods

    /// <summary>
    /// <code>Offset: 0x00545150
    /// void __thiscall CClientsideLoginStateHandler::OnStateHandlerInit(CClientsideLoginStateHandler*)</code>
    /// </summary>
    public void OnStateHandlerInit() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CClientsideLoginStateHandler, void>)0x00545150)(ref this);
}

