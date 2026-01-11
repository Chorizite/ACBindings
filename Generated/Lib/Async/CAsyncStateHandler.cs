namespace ACBindings.Internal;

public unsafe struct CAsyncStateHandler : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.IntrusiveHashListData__int___CAsyncStateHandler_ptr BaseClass_IntrusiveHashListData; // ACBindings.Internal.IntrusiveHashListData__int___CAsyncStateHandler_ptr

    // Child Types
    public unsafe struct CAsyncStateHandler_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CAsyncStateHandler*, void> CAsyncStateHandler_dtor_0; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CAsyncStateHandler*, ACBindings.Internal.AsyncContext, void> OnContextBegun; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CAsyncStateHandler*, ACBindings.Internal.AsyncContext, void> OnStateBegun; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CAsyncStateHandler*, ACBindings.Internal.AsyncContext, ACBindings.Internal.AsyncStateMachineStatus, void> OnStateEnded; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CAsyncStateHandler*, ACBindings.Internal.AsyncContext, ACBindings.Internal.AsyncStateMachineStatus, void> OnContextEnded; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CAsyncStateHandler*, ACBindings.Internal.AsyncContext, void> CleanupContextData; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CAsyncStateHandler*, void> OnStateHandlerInit; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CAsyncStateHandler*, void> OnStateHandlerDone; // function pointer

        // Methods
    }

    // Members
    public System.IntPtr __vftable; // vtable pointer
    public ACBindings.Internal.CAsyncStateMachine* m_pMachine;

    // Generated Constructor
    public CAsyncStateHandler(int StateNumber) {
        _ConstructorInternal(StateNumber);
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x0065EB50
    /// AsyncStateMachineStatus __thiscall CAsyncStateHandler::EndStateOK(CAsyncStateHandler*,AsyncContext,int)</code>
    /// </summary>
    public ACBindings.Internal.AsyncStateMachineStatus EndStateOK(ACBindings.Internal.AsyncContext hContext, int NextStateNumber) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CAsyncStateHandler, ACBindings.Internal.AsyncContext, int, ACBindings.Internal.AsyncStateMachineStatus>)0x0065EB50)(ref this, hContext, NextStateNumber);

    /// <summary>
    /// <code>Offset: 0x0065ECE0
    /// void __thiscall CAsyncStateHandler::CAsyncStateHandler(CAsyncStateHandler*,int)</code>
    /// </summary>
    public void _ConstructorInternal(int StateNumber) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CAsyncStateHandler, int, void>)0x0065ECE0)(ref this, StateNumber);

    /// <summary>
    /// <code>Offset: 0x0065F230
    /// int __thiscall CAsyncStateHandler::GetContextData(CAsyncStateHandler*,AsyncContext,unsigned int)</code>
    /// </summary>
    public int GetContextData(ACBindings.Internal.AsyncContext hContext, uint dwDataIndex) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CAsyncStateHandler, ACBindings.Internal.AsyncContext, uint, int>)0x0065F230)(ref this, hContext, dwDataIndex);

    /// <summary>
    /// <code>Offset: 0x0065F240
    /// bool __thiscall CAsyncStateHandler::SetContextData(CAsyncStateHandler*,AsyncContext,unsigned int,int)</code>
    /// </summary>
    public byte SetContextData(ACBindings.Internal.AsyncContext hContext, uint dwDataIndex, int dwData) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CAsyncStateHandler, ACBindings.Internal.AsyncContext, uint, int, byte>)0x0065F240)(ref this, hContext, dwDataIndex, dwData);

    /// <summary>
    /// <code>Offset: 0x00660210
    /// const char** __thiscall CAsyncStateHandler::RegisterContextDataName(unsigned int**,const char**)</code>
    /// </summary>
    public sbyte** RegisterContextDataName(sbyte** a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CAsyncStateHandler, sbyte**, sbyte**>)0x00660210)(ref this, a2);

    /// <summary>
    /// <code>Offset: 0x006605B0
    /// void __thiscall CAsyncStateHandler::~CAsyncStateHandler(CAsyncStateHandler*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CAsyncStateHandler, void>)0x006605B0)(ref this);
}

