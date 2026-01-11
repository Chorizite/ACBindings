namespace ACBindings.Internal;

public unsafe struct CAsyncStateMachine : System.IDisposable
{
    // Child Types
    public unsafe struct CAsyncStateMachine_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CAsyncStateMachine*, void> CAsyncStateMachine_dtor_0; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CAsyncStateMachine*, ACBindings.Internal.AsyncContext*, ACBindings.Internal.AsyncContext*> AllocateContext; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CAsyncStateMachine*, ACBindings.Internal.AsyncContext, void> OnContextBegun; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CAsyncStateMachine*, ACBindings.Internal.AsyncContext, ACBindings.Internal.AsyncStateMachineStatus, void> OnContextEnded; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CAsyncStateMachine*, ACBindings.Internal.AsyncContext, void> CleanupContextData; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CAsyncStateMachine*, ACBindings.Internal.AsyncContext, int, ACBindings.Internal.AsyncStateMachineStatus> Advance; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CAsyncStateMachine*, ACBindings.Internal.AsyncContext, int, ACBindings.Internal.AsyncStateMachineStatus> OnHandlerDoneOK; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CAsyncStateMachine*, ACBindings.Internal.AsyncContext, void> OnHandlerFailed; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CAsyncStateMachine*, ACBindings.Internal.AsyncContext, ACBindings.Internal.CAsyncStateMachine.CAsyncStateData*> AllocateStateData; // function pointer

        // Methods
    }
    public unsafe struct CAsyncStateData
    {
        // Base Classes
        public ACBindings.Internal.ReferenceCountTemplate BaseClass_ReferenceCountTemplate; // ACBindings.Internal.ReferenceCountTemplate
        public ACBindings.Internal.IntrusiveHashListData___AsyncContext___CAsyncStateMachine_CAsyncStateData_ptr BaseClass_IntrusiveHashListData; // ACBindings.Internal.IntrusiveHashListData___AsyncContext___CAsyncStateMachine_CAsyncStateData_ptr

        // Child Types
        public unsafe struct CAsyncStateData_vtbl
        {
            // Members
            public delegate* unmanaged[Thiscall]<ACBindings.Internal.CAsyncStateMachine.CAsyncStateData*, void> CAsyncStateMachine; // function pointer

            // Methods
        }

        // Members
        public ACBindings.Internal.SmartArray__int Data;
        public ACBindings.Internal.AsyncStateMachineStatus eStatus;
        public byte bAdvancing;
        public int iDelayedNextStateNumber;
        public ACBindings.Internal.CAsyncStateHandler* pCurrentState;
        public int iMaxStateNumber;
        public double tContextBegan;
        public double tCurStateBegan;

        // Methods
    }

    // Members
    public System.IntPtr __vftable; // vtable pointer
    public ACBindings.Internal.IntrusiveHashList__int___CAsyncStateHandler_ptr m_States;
    public int m_iLowState;
    public ACBindings.Internal.IntrusiveHashList___AsyncContext___CAsyncStateMachine_CAsyncStateData_ptr m_ContextHash;
    public ACBindings.Internal.AutoGrowHashTable___PStringBase__sbyte__uint m_DataNames;
    public uint m_dwNextContextNumber;
    public ACBindings.Internal.PreciseTimerInstance* m_pTimer;

    // Generated Constructor
    public CAsyncStateMachine() {
        _ConstructorInternal();
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x0065ED60
    /// CAsyncStateMachine::CAsyncStateData* __thiscall CAsyncStateMachine::AllocateStateData(CAsyncStateMachine*,AsyncContext)</code>
    /// </summary>
    public ACBindings.Internal.CAsyncStateMachine.CAsyncStateData* AllocateStateData(ACBindings.Internal.AsyncContext hContext) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CAsyncStateMachine, ACBindings.Internal.AsyncContext, ACBindings.Internal.CAsyncStateMachine.CAsyncStateData*>)0x0065ED60)(ref this, hContext);

    /// <summary>
    /// <code>Offset: 0x0065EE40
    /// AsyncStateMachineStatus __thiscall CAsyncStateMachine::BeginContext(CAsyncStateMachine*,AsyncContext,int)</code>
    /// </summary>
    public ACBindings.Internal.AsyncStateMachineStatus BeginContext(ACBindings.Internal.AsyncContext hContext, int StartState) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CAsyncStateMachine, ACBindings.Internal.AsyncContext, int, ACBindings.Internal.AsyncStateMachineStatus>)0x0065EE40)(ref this, hContext, StartState);

    /// <summary>
    /// <code>Offset: 0x0065EF90
    /// AsyncStateMachineStatus __thiscall CAsyncStateMachine::Advance(CAsyncStateMachine*,AsyncContext,int)</code>
    /// </summary>
    public ACBindings.Internal.AsyncStateMachineStatus Advance(ACBindings.Internal.AsyncContext hContext, int NextStateNumber) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CAsyncStateMachine, ACBindings.Internal.AsyncContext, int, ACBindings.Internal.AsyncStateMachineStatus>)0x0065EF90)(ref this, hContext, NextStateNumber);

    /// <summary>
    /// <code>Offset: 0x0065F250
    /// AsyncContext* __thiscall CAsyncStateMachine::AllocateAndBeginContext(CAsyncStateMachine*,AsyncContext*)</code>
    /// </summary>
    public ACBindings.Internal.AsyncContext* AllocateAndBeginContext(ACBindings.Internal.AsyncContext* result) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CAsyncStateMachine, ACBindings.Internal.AsyncContext*, ACBindings.Internal.AsyncContext*>)0x0065F250)(ref this, result);

    /// <summary>
    /// <code>Offset: 0x0065FC60
    /// bool __thiscall CAsyncStateMachine::AddStateHandler(CAsyncStateMachine*,CAsyncStateHandler*)</code>
    /// </summary>
    public byte AddStateHandler(ACBindings.Internal.CAsyncStateHandler* pStateHandler) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CAsyncStateMachine, ACBindings.Internal.CAsyncStateHandler*, byte>)0x0065FC60)(ref this, pStateHandler);

    /// <summary>
    /// <code>Offset: 0x0065FDB0
    /// AsyncContext* __thiscall CAsyncStateMachine::AllocateContext(CAsyncStateMachine*,AsyncContext*)</code>
    /// </summary>
    public ACBindings.Internal.AsyncContext* AllocateContext(ACBindings.Internal.AsyncContext* result) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CAsyncStateMachine, ACBindings.Internal.AsyncContext*, ACBindings.Internal.AsyncContext*>)0x0065FDB0)(ref this, result);

    /// <summary>
    /// <code>Offset: 0x0065FE70
    /// void __thiscall CAsyncStateMachine::EndAndReleaseContext(CAsyncStateMachine*,AsyncContext,AsyncStateMachineStatus)</code>
    /// </summary>
    public void EndAndReleaseContext(ACBindings.Internal.AsyncContext hContext, ACBindings.Internal.AsyncStateMachineStatus i_eFinalStatus) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CAsyncStateMachine, ACBindings.Internal.AsyncContext, ACBindings.Internal.AsyncStateMachineStatus, void>)0x0065FE70)(ref this, hContext, i_eFinalStatus);

    /// <summary>
    /// <code>Offset: 0x0065FFB0
    /// AsyncStateMachineStatus __thiscall CAsyncStateMachine::OnHandlerDoneOK(CAsyncStateMachine*,AsyncContext,int)</code>
    /// </summary>
    public ACBindings.Internal.AsyncStateMachineStatus OnHandlerDoneOK(ACBindings.Internal.AsyncContext hContext, int NextStateNumber) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CAsyncStateMachine, ACBindings.Internal.AsyncContext, int, ACBindings.Internal.AsyncStateMachineStatus>)0x0065FFB0)(ref this, hContext, NextStateNumber);

    /// <summary>
    /// <code>Offset: 0x0065FFE0
    /// void __thiscall CAsyncStateMachine::OnHandlerFailed(CAsyncStateMachine*,AsyncContext)</code>
    /// </summary>
    public void OnHandlerFailed(ACBindings.Internal.AsyncContext hContext) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CAsyncStateMachine, ACBindings.Internal.AsyncContext, void>)0x0065FFE0)(ref this, hContext);

    /// <summary>
    /// <code>Offset: 0x006600F0
    /// const char** __thiscall CAsyncStateMachine::RegisterContextDataName(unsigned int*,const char**)</code>
    /// </summary>
    public sbyte** RegisterContextDataName(sbyte** a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CAsyncStateMachine, sbyte**, sbyte**>)0x006600F0)(ref this, a2);

    /// <summary>
    /// <code>Offset: 0x00660220
    /// void __thiscall CAsyncStateMachine::CAsyncStateMachine(CAsyncStateMachine*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CAsyncStateMachine, void>)0x00660220)(ref this);

    /// <summary>
    /// <code>Offset: 0x006602C0
    /// void __thiscall CAsyncStateMachine::~CAsyncStateMachine(CAsyncStateMachine*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CAsyncStateMachine, void>)0x006602C0)(ref this);

    /// <summary>
    /// <code>Offset: 0x006604E0
    /// bool __thiscall CAsyncStateMachine::RemoveStateHandler(CAsyncStateMachine*,int)</code>
    /// </summary>
    public byte RemoveStateHandler(int StateNumber) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CAsyncStateMachine, int, byte>)0x006604E0)(ref this, StateNumber);
}

