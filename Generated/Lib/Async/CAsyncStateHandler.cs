namespace ACBindings;

// CAsyncStateHandler
public unsafe struct CAsyncStateHandler : System.IDisposable
{
    // Base Classes
    public ACBindings.IntrusiveHashListData__int__CAsyncStateHandler_ptr BaseClass_IntrusiveHashListData; // ACBindings.IntrusiveHashListData__int__CAsyncStateHandler_ptr

    // Child Types
    // CAsyncStateHandler_vtbl
    public unsafe struct CAsyncStateHandler_vtbl
    {
        // Members
        public System.IntPtr CAsyncStateHandler_dtor_0; // function pointer
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
    public System.IntPtr __vftable; // vtable pointer
    public ACBindings.CAsyncStateMachine* m_pMachine;

    // Generated Constructor
    public CAsyncStateHandler(int StateNumber) {
        _ConstructorInternal(StateNumber);
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods
    // AsyncStateMachineStatus __thiscall CAsyncStateHandler::EndStateOK(CAsyncStateHandler*,AsyncContext,int)
    public ACBindings.AsyncStateMachineStatus EndStateOK(ACBindings.AsyncContext hContext, int NextStateNumber) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CAsyncStateHandler, ACBindings.AsyncContext, int, ACBindings.AsyncStateMachineStatus>)0x0065EB50)(ref this, hContext, NextStateNumber);
    // void __thiscall CAsyncStateHandler::CAsyncStateHandler(CAsyncStateHandler*,int)
    public void _ConstructorInternal(int StateNumber) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CAsyncStateHandler, int, void>)0x0065ECE0)(ref this, StateNumber);
    // int __thiscall CAsyncStateHandler::GetContextData(CAsyncStateHandler*,AsyncContext,unsigned int)
    public int GetContextData(ACBindings.AsyncContext hContext, uint dwDataIndex) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CAsyncStateHandler, ACBindings.AsyncContext, uint, int>)0x0065F230)(ref this, hContext, dwDataIndex);
    // bool __thiscall CAsyncStateHandler::SetContextData(CAsyncStateHandler*,AsyncContext,unsigned int,int)
    public byte SetContextData(ACBindings.AsyncContext hContext, uint dwDataIndex, int dwData) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CAsyncStateHandler, ACBindings.AsyncContext, uint, int, byte>)0x0065F240)(ref this, hContext, dwDataIndex, dwData);
    // const char** __thiscall CAsyncStateHandler::RegisterContextDataName(unsigned int**,const char**)
    public sbyte** RegisterContextDataName(sbyte** a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CAsyncStateHandler, sbyte**, sbyte**>)0x00660210)(ref this, a2);
    // void __thiscall CAsyncStateHandler::~CAsyncStateHandler(CAsyncStateHandler*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CAsyncStateHandler, void>)0x006605B0)(ref this);
}

