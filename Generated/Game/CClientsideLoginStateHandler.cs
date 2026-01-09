namespace ACBindings;

// CClientsideLoginStateHandler
public unsafe struct CClientsideLoginStateHandler
{
    // Base Classes
    public ACBindings.CAsyncStateHandler BaseClass_CAsyncStateHandler; // ACBindings.CAsyncStateHandler

    // Child Types
    // CClientsideLoginStateHandler_vtbl
    public unsafe struct CClientsideLoginStateHandler_vtbl
    {
        // Members
        public System.IntPtr CClientsideLoginStateHandler_dtor_0; // function pointer
        public System.IntPtr OnContextBegun; // function pointer
        public System.IntPtr OnStateBegun; // function pointer
        public System.IntPtr OnStateEnded; // function pointer
        public System.IntPtr OnContextEnded; // function pointer
        public System.IntPtr CleanupContextData; // function pointer
        public System.IntPtr OnStateHandlerInit; // function pointer
        public System.IntPtr OnStateHandlerDone; // function pointer

        // Methods
    }

    // Members
    public uint m_idxRecipientID;
    public uint m_idxServerAddr;
    public uint m_idxNetAuth;
    public uint m_idxFailureReason;

    // Methods
    // void __thiscall CClientsideLoginStateHandler::OnStateHandlerInit(CClientsideLoginStateHandler*)
    public void OnStateHandlerInit() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CClientsideLoginStateHandler, void>)0x00545150)(ref this);
}

