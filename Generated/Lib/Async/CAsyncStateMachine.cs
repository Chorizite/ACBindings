namespace ACBindings;

// CAsyncStateMachine
public unsafe struct CAsyncStateMachine : System.IDisposable
{
    // Child Types
    // CAsyncStateMachine::CAsyncStateData_vtbl
    public unsafe struct CAsyncStateData_vtbl
    {
        // Members
        public System.IntPtr CAsyncStateMachine; // function pointer

        // Methods
    }
    // CAsyncStateMachine_vtbl
    public unsafe struct CAsyncStateMachine_vtbl
    {
        // Members
        public System.IntPtr CAsyncStateMachine_dtor_0; // function pointer
        public System.IntPtr AllocateContext; // function pointer
        public System.IntPtr OnContextBegun; // function pointer
        public System.IntPtr OnContextEnded; // function pointer
        public System.IntPtr CleanupContextData; // function pointer
        public System.IntPtr Advance; // function pointer
        public System.IntPtr OnHandlerDoneOK; // function pointer
        public System.IntPtr OnHandlerFailed; // function pointer
        public System.IntPtr AllocateStateData; // function pointer

        // Methods
    }
    // CAsyncStateMachine::CAsyncStateData
    public unsafe struct CAsyncStateData
    {
        // Base Classes
        public ACBindings.ReferenceCountTemplate BaseClass_ReferenceCountTemplate; // ACBindings.ReferenceCountTemplate
        public ACBindings.IntrusiveHashListData__AsyncContext__CAsyncStateMachine_CAsyncStateData_ptr BaseClass_IntrusiveHashListData; // ACBindings.IntrusiveHashListData__AsyncContext__CAsyncStateMachine_CAsyncStateData_ptr

        // Members
        public ACBindings.SmartArray__int Data;
        public ACBindings.AsyncStateMachineStatus eStatus;
        public byte bAdvancing;
        public int iDelayedNextStateNumber;
        public ACBindings.CAsyncStateHandler* pCurrentState;
        public int iMaxStateNumber;
        public double tContextBegan;
        public double tCurStateBegan;

        // Methods
    }

    // Members
    public System.IntPtr __vftable; // vtable pointer
    public ACBindings.IntrusiveHashList__int__CAsyncStateHandler_ptr m_States;
    public int m_iLowState;
    public ACBindings.IntrusiveHashList__AsyncContext__CAsyncStateMachine_CAsyncStateData_ptr m_ContextHash;
    public ACBindings.AutoGrowHashTable__PStringBase__sbyte__uint m_DataNames;
    public uint m_dwNextContextNumber;
    public ACBindings.PreciseTimerInstance* m_pTimer;

    // Generated Constructor
    public CAsyncStateMachine() {
        _ConstructorInternal();
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods
    // CAsyncStateMachine::CAsyncStateData* __thiscall CAsyncStateMachine::AllocateStateData(CAsyncStateMachine*,AsyncContext)
    public ACBindings.CAsyncStateMachine.CAsyncStateData* AllocateStateData(ACBindings.AsyncContext hContext) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CAsyncStateMachine, ACBindings.AsyncContext, ACBindings.CAsyncStateMachine.CAsyncStateData*>)0x0065ED60)(ref this, hContext);
    // AsyncStateMachineStatus __thiscall CAsyncStateMachine::BeginContext(CAsyncStateMachine*,AsyncContext,int)
    public ACBindings.AsyncStateMachineStatus BeginContext(ACBindings.AsyncContext hContext, int StartState) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CAsyncStateMachine, ACBindings.AsyncContext, int, ACBindings.AsyncStateMachineStatus>)0x0065EE40)(ref this, hContext, StartState);
    // AsyncStateMachineStatus __thiscall CAsyncStateMachine::Advance(CAsyncStateMachine*,AsyncContext,int)
    public ACBindings.AsyncStateMachineStatus Advance(ACBindings.AsyncContext hContext, int NextStateNumber) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CAsyncStateMachine, ACBindings.AsyncContext, int, ACBindings.AsyncStateMachineStatus>)0x0065EF90)(ref this, hContext, NextStateNumber);
    // AsyncContext* __thiscall CAsyncStateMachine::AllocateAndBeginContext(CAsyncStateMachine*,AsyncContext*)
    public ACBindings.AsyncContext* AllocateAndBeginContext(ACBindings.AsyncContext* result) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CAsyncStateMachine, ACBindings.AsyncContext*, ACBindings.AsyncContext*>)0x0065F250)(ref this, result);
    // bool __thiscall CAsyncStateMachine::AddStateHandler(CAsyncStateMachine*,CAsyncStateHandler*)
    public byte AddStateHandler(ACBindings.CAsyncStateHandler* pStateHandler) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CAsyncStateMachine, ACBindings.CAsyncStateHandler*, byte>)0x0065FC60)(ref this, pStateHandler);
    // AsyncContext* __thiscall CAsyncStateMachine::AllocateContext(CAsyncStateMachine*,AsyncContext*)
    public ACBindings.AsyncContext* AllocateContext(ACBindings.AsyncContext* result) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CAsyncStateMachine, ACBindings.AsyncContext*, ACBindings.AsyncContext*>)0x0065FDB0)(ref this, result);
    // void __thiscall CAsyncStateMachine::EndAndReleaseContext(CAsyncStateMachine*,AsyncContext,AsyncStateMachineStatus)
    public void EndAndReleaseContext(ACBindings.AsyncContext hContext, ACBindings.AsyncStateMachineStatus i_eFinalStatus) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CAsyncStateMachine, ACBindings.AsyncContext, ACBindings.AsyncStateMachineStatus, void>)0x0065FE70)(ref this, hContext, i_eFinalStatus);
    // AsyncStateMachineStatus __thiscall CAsyncStateMachine::OnHandlerDoneOK(CAsyncStateMachine*,AsyncContext,int)
    public ACBindings.AsyncStateMachineStatus OnHandlerDoneOK(ACBindings.AsyncContext hContext, int NextStateNumber) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CAsyncStateMachine, ACBindings.AsyncContext, int, ACBindings.AsyncStateMachineStatus>)0x0065FFB0)(ref this, hContext, NextStateNumber);
    // void __thiscall CAsyncStateMachine::OnHandlerFailed(CAsyncStateMachine*,AsyncContext)
    public void OnHandlerFailed(ACBindings.AsyncContext hContext) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CAsyncStateMachine, ACBindings.AsyncContext, void>)0x0065FFE0)(ref this, hContext);
    // const char** __thiscall CAsyncStateMachine::RegisterContextDataName(unsigned int*,const char**)
    public sbyte** RegisterContextDataName(sbyte** a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CAsyncStateMachine, sbyte**, sbyte**>)0x006600F0)(ref this, a2);
    // void __thiscall CAsyncStateMachine::CAsyncStateMachine(CAsyncStateMachine*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CAsyncStateMachine, void>)0x00660220)(ref this);
    // void __thiscall CAsyncStateMachine::~CAsyncStateMachine(CAsyncStateMachine*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CAsyncStateMachine, void>)0x006602C0)(ref this);
    // bool __thiscall CAsyncStateMachine::RemoveStateHandler(CAsyncStateMachine*,int)
    public byte RemoveStateHandler(int StateNumber) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CAsyncStateMachine, int, byte>)0x006604E0)(ref this, StateNumber);
}

