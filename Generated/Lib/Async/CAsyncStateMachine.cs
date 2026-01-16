namespace ACBindings.Internal;


/// <summary>Encapsulates an asynchronous state machine that manages multiple state handlers, contexts, and associated data for concurrent operations.</summary>
/// <remarks>Provides efficient lookup via hash tables, tracks the lowest active state, and coordinates timed events through a precise timer instance.</remarks>
public unsafe struct CAsyncStateMachine : System.IDisposable
{
    // Child Types

    /// <summary>Defines the virtual function table for an asynchronous state machine, providing callbacks and lifecycle management for contexts and state transitions.</summary>
    public unsafe struct CAsyncStateMachine_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CAsyncStateMachine*, void> CAsyncStateMachine_dtor_0; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CAsyncStateMachine*, ACBindings.Internal.AsyncContext*, ACBindings.Internal.AsyncContext*> AllocateContext; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CAsyncStateMachine*, ACBindings.Internal.AsyncContext, void> OnContextBegun; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CAsyncStateMachine*, ACBindings.Internal.AsyncContext, ACBindings.Internal.AsyncStateMachineStatus, void> OnContextEnded; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CAsyncStateMachine*, ACBindings.Internal.AsyncContext, void> CleanupContextData; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CAsyncStateMachine*, ACBindings.Internal.AsyncContext, int, ACBindings.Internal.AsyncStateMachineStatus> Advance; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CAsyncStateMachine*, ACBindings.Internal.AsyncContext, int, ACBindings.Internal.AsyncStateMachineStatus> OnHandlerDoneOK; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CAsyncStateMachine*, ACBindings.Internal.AsyncContext, void> OnHandlerFailed; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CAsyncStateMachine*, ACBindings.Internal.AsyncContext, ACBindings.Internal.CAsyncStateMachine.CAsyncStateData*> AllocateStateData; // function pointer

        // Methods
    }

    /// <summary>Tracks runtime data for an asynchronous state machine, including its current status, transition information, active handler, and timestamps for context and state entry.</summary>
    public unsafe struct CAsyncStateData
    {
        // Base Classes
        public ACBindings.Internal.ReferenceCountTemplate BaseClass_ReferenceCountTemplate; // ACBindings.Internal.ReferenceCountTemplate
        public ACBindings.Internal.IntrusiveHashListData___AsyncContext___CAsyncStateMachine_CAsyncStateData_ptr BaseClass_IntrusiveHashListData; // ACBindings.Internal.IntrusiveHashListData___AsyncContext___CAsyncStateMachine_CAsyncStateData_ptr

        // Child Types
        public unsafe struct CAsyncStateData_vtbl
        {
            // Members
            public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CAsyncStateMachine.CAsyncStateData*, void> CAsyncStateMachine; // function pointer

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

    /// <summary>Creates a new CAsyncStateData instance for the specified context, initializing all members to default values.
    /// <code>Offset: 0x0065ED60
    /// CAsyncStateMachine::CAsyncStateData* __thiscall CAsyncStateMachine::AllocateStateData(CAsyncStateMachine*,AsyncContext)</code>
    /// </summary>
    /// <param name="hContext">The AsyncContext key identifying the state data being allocated.</param>
    /// <returns>A pointer to the newly allocated CAsyncStateData or nullptr if memory allocation fails.</returns>
    public ACBindings.Internal.CAsyncStateMachine.CAsyncStateData* AllocateStateData(ACBindings.Internal.AsyncContext hContext) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CAsyncStateMachine, ACBindings.Internal.AsyncContext, ACBindings.Internal.CAsyncStateMachine.CAsyncStateData*>)0x0065ED60)(ref this, hContext);

    /// <summary>Begins execution of an asynchronous context identified by hContext, setting its status to Running, recording the start time, notifying registered state handlers, and signaling completion via OnHandlerDoneOK. If the specified context cannot be found, returns an error status.
    /// <code>Offset: 0x0065EE40
    /// AsyncStateMachineStatus __thiscall CAsyncStateMachine::BeginContext(CAsyncStateMachine*,AsyncContext,int)</code>
    /// </summary>
    /// <param name="hContext">Identifier of the async context to begin.</param>
    /// <param name="StartState">The initial state number for this context.</param>
    /// <returns>AsyncStateMachineStatus value indicating success or failure (e.g., 5 if the context is not found).</returns>
    public ACBindings.Internal.AsyncStateMachineStatus BeginContext(ACBindings.Internal.AsyncContext hContext, int StartState) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CAsyncStateMachine, ACBindings.Internal.AsyncContext, int, ACBindings.Internal.AsyncStateMachineStatus>)0x0065EE40)(ref this, hContext, StartState);

    /// <summary>Advances the asynchronous state machine for a given context toward the specified next state, invoking transition callbacks and handling concurrency.
    /// <code>Offset: 0x0065EF90
    /// AsyncStateMachineStatus __thiscall CAsyncStateMachine::Advance(CAsyncStateMachine*,AsyncContext,int)</code>
    /// </summary>
    /// <param name="hContext">Identifier of the async context to advance.</param>
    /// <param name="NextStateNumber">Target state number for this advancement; special values indicate continuation or completion.</param>
    /// <returns>The resulting AsyncStateMachineStatus after processing the transition.</returns>
    public ACBindings.Internal.AsyncStateMachineStatus Advance(ACBindings.Internal.AsyncContext hContext, int NextStateNumber) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CAsyncStateMachine, ACBindings.Internal.AsyncContext, int, ACBindings.Internal.AsyncStateMachineStatus>)0x0065EF90)(ref this, hContext, NextStateNumber);

    /// <summary>Allocates a new asynchronous context, initiates it, and copies its identifier into the provided result object.
    /// <code>Offset: 0x0065F250
    /// AsyncContext* __thiscall CAsyncStateMachine::AllocateAndBeginContext(CAsyncStateMachine*,AsyncContext*)</code>
    /// </summary>
    /// <param name="result">The AsyncContext instance to receive the allocated context's identifier.</param>
    /// <returns>The same AsyncContext pointer that was passed in, now initialized with the new context ID.</returns>
    public ACBindings.Internal.AsyncContext* AllocateAndBeginContext(ACBindings.Internal.AsyncContext* result) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CAsyncStateMachine, ACBindings.Internal.AsyncContext*, ACBindings.Internal.AsyncContext*>)0x0065F250)(ref this, result);

    /// <summary>Adds the specified state handler to the asynchronous state machine, ensuring no duplicate hash keys exist. If the handler is not already present, inserts it into the internal hash list in key order, links it to this machine, and invokes its initialization callback.
    /// <code>Offset: 0x0065FC60
    /// bool __thiscall CAsyncStateMachine::AddStateHandler(CAsyncStateMachine*,CAsyncStateHandler*)</code>
    /// </summary>
    /// <param name="pStateHandler">The state handler to register with the machine.</param>
    /// <returns>True if the handler was successfully added; false when a handler with the same hash key already exists or insertion is disallowed by an invalid hash range.</returns>
    public byte AddStateHandler(ACBindings.Internal.CAsyncStateHandler* pStateHandler) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CAsyncStateMachine, ACBindings.Internal.CAsyncStateHandler*, byte>)0x0065FC60)(ref this, pStateHandler);

    /// <summary>Allocates a new asynchronous context within the state machine, assigning it a unique identifier and initializing its internal data array. The created context is appended to the machine's context list.
    /// <code>Offset: 0x0065FDB0
    /// AsyncContext* __thiscall CAsyncStateMachine::AllocateContext(CAsyncStateMachine*,AsyncContext*)</code>
    /// </summary>
    /// <param name="result">Pointer to an AsyncContext object that will receive the allocated context data. The function sets its <c>m_id</c> field and returns this pointer.</param>
    /// <returns>The same pointer passed in as <paramref name="result"/>, populated with a new context ID, or unchanged if allocation fails (ID set to <c>INVALID_ASYNCCONTEXT_34.m_id</c>).</returns>
    public ACBindings.Internal.AsyncContext* AllocateContext(ACBindings.Internal.AsyncContext* result) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CAsyncStateMachine, ACBindings.Internal.AsyncContext*, ACBindings.Internal.AsyncContext*>)0x0065FDB0)(ref this, result);

    /// <summary>Ends an asynchronous context identified by its handle and releases associated resources, notifying state handlers of completion.
    /// <code>Offset: 0x0065FE70
    /// void __thiscall CAsyncStateMachine::EndAndReleaseContext(CAsyncStateMachine*,AsyncContext,AsyncStateMachineStatus)</code>
    /// </summary>
    /// <param name="hContext">Handle to the async context being ended.</param>
    /// <param name="i_eFinalStatus">Final status code for the context (e.g., success or failure).</param>
    public void EndAndReleaseContext(ACBindings.Internal.AsyncContext hContext, ACBindings.Internal.AsyncStateMachineStatus i_eFinalStatus) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CAsyncStateMachine, ACBindings.Internal.AsyncContext, ACBindings.Internal.AsyncStateMachineStatus, void>)0x0065FE70)(ref this, hContext, i_eFinalStatus);

    /// <summary>Finalizes a successful handler by advancing to the next state or terminating the context based on the resulting status.
    /// <code>Offset: 0x0065FFB0
    /// AsyncStateMachineStatus __thiscall CAsyncStateMachine::OnHandlerDoneOK(CAsyncStateMachine*,AsyncContext,int)</code>
    /// </summary>
    /// <param name="hContext">Handle identifying the asynchronous operation being processed.</param>
    /// <param name="NextStateNumber">Target state number to transition to after successful completion.</param>
    /// <returns>The new <c>AsyncStateMachineStatus</c> returned by the advance operation, indicating whether the machine is still running or has finished processing.</returns>
    public ACBindings.Internal.AsyncStateMachineStatus OnHandlerDoneOK(ACBindings.Internal.AsyncContext hContext, int NextStateNumber) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CAsyncStateMachine, ACBindings.Internal.AsyncContext, int, ACBindings.Internal.AsyncStateMachineStatus>)0x0065FFB0)(ref this, hContext, NextStateNumber);

    /// <summary>Marks the specified asynchronous context as failed, performs necessary cleanup, and releases its resources.
    /// <code>Offset: 0x0065FFE0
    /// void __thiscall CAsyncStateMachine::OnHandlerFailed(CAsyncStateMachine*,AsyncContext)</code>
    /// </summary>
    /// <param name="hContext">The async context that experienced a handler failure.</param>
    public void OnHandlerFailed(ACBindings.Internal.AsyncContext hContext) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CAsyncStateMachine, ACBindings.Internal.AsyncContext, void>)0x0065FFE0)(ref this, hContext);

    /// <summary>Registers a context data name within the async state machine, ensuring uniqueness, and returns the stored string pointer.
    /// <code>Offset: 0x006600F0
    /// const char** __thiscall CAsyncStateMachine::RegisterContextDataName(unsigned int*,const char**)</code>
    /// </summary>
    /// <param name="this">The CAsyncStateMachine instance on which to register the name.</param>
    /// <param name="a2">Pointer to the null‑terminated string representing the context data name to be registered.</param>
    /// <returns>Pointer to the registered (or existing) context data name within the state machine.</returns>
    public sbyte** RegisterContextDataName(sbyte** a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CAsyncStateMachine, sbyte**, sbyte**>)0x006600F0)(ref this, a2);

    /// <summary>Creates a new asynchronous state machine instance, initializing its state list, context hash table, data name map, and linking to a precise timer instance.
    /// <code>Offset: 0x00660220
    /// void __thiscall CAsyncStateMachine::CAsyncStateMachine(CAsyncStateMachine*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CAsyncStateMachine, void>)0x00660220)(ref this);

    /// <summary>Destroys a CAsyncStateMachine instance, releasing all active contexts and clearing internal state data structures.
    /// <code>Offset: 0x006602C0
    /// void __thiscall CAsyncStateMachine::~CAsyncStateMachine(CAsyncStateMachine*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CAsyncStateMachine, void>)0x006602C0)(ref this);

    /// <summary>Removes the handler for the specified state, releasing any associated contexts and notifying the handler that it is finished.
    /// <code>Offset: 0x006604E0
    /// bool __thiscall CAsyncStateMachine::RemoveStateHandler(CAsyncStateMachine*,int)</code>
    /// </summary>
    /// <param name="StateNumber">The identifier of the state whose handler should be removed.</param>
    /// <returns>True if a handler was found and removed; otherwise false.</returns>
    public byte RemoveStateHandler(int StateNumber) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CAsyncStateMachine, int, byte>)0x006604E0)(ref this, StateNumber);
}

