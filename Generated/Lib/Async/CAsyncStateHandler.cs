namespace ACBindings.Internal;


/// <summary>Links an asynchronous state handler into the system's intrusive hash list and associates it with a state machine instance.</summary>
public unsafe struct CAsyncStateHandler : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.IntrusiveHashListData__int___CAsyncStateHandler_ptr BaseClass_IntrusiveHashListData; // ACBindings.Internal.IntrusiveHashListData__int___CAsyncStateHandler_ptr

    // Child Types

    /// <summary>Provides a table of function pointers for handling asynchronous state and context events in CAsyncStateHandler, enabling dynamic dispatch of lifecycle callbacks such as initiation, termination, cleanup, and status reporting.</summary>
    public unsafe struct CAsyncStateHandler_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CAsyncStateHandler*, void> CAsyncStateHandler_dtor_0; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CAsyncStateHandler*, ACBindings.Internal.AsyncContext, void> OnContextBegun; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CAsyncStateHandler*, ACBindings.Internal.AsyncContext, void> OnStateBegun; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CAsyncStateHandler*, ACBindings.Internal.AsyncContext, ACBindings.Internal.AsyncStateMachineStatus, void> OnStateEnded; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CAsyncStateHandler*, ACBindings.Internal.AsyncContext, ACBindings.Internal.AsyncStateMachineStatus, void> OnContextEnded; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CAsyncStateHandler*, ACBindings.Internal.AsyncContext, void> CleanupContextData; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CAsyncStateHandler*, void> OnStateHandlerInit; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CAsyncStateHandler*, void> OnStateHandlerDone; // function pointer

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

    /// <summary>Concludes an asynchronous state handling operation by notifying the associated state machine that the handler finished successfully and specifying the next state to transition to.
    /// <code>Offset: 0x0065EB50
    /// AsyncStateMachineStatus __thiscall CAsyncStateHandler::EndStateOK(CAsyncStateHandler*,AsyncContext,int)</code>
    /// </summary>
    /// <param name="hContext">The context identifier for the current asynchronous operation.</param>
    /// <param name="NextStateNumber">The numeric identifier of the next state to transition to after completion.</param>
    /// <returns>AsyncStateMachineStatus value returned by the underlying state machine's completion callback.</returns>
    public ACBindings.Internal.AsyncStateMachineStatus EndStateOK(ACBindings.Internal.AsyncContext hContext, int NextStateNumber) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CAsyncStateHandler, ACBindings.Internal.AsyncContext, int, ACBindings.Internal.AsyncStateMachineStatus>)0x0065EB50)(ref this, hContext, NextStateNumber);

    /// <summary>Initializes a new async state handler with the specified state number, setting up hash key, list links, virtual table pointer, and clearing its machine reference.
    /// <code>Offset: 0x0065ECE0
    /// void __thiscall CAsyncStateHandler::CAsyncStateHandler(CAsyncStateHandler*,int)</code>
    /// </summary>
    /// <param name="StateNumber">The numeric identifier of the asynchronous state to be handled.</param>
    public void _ConstructorInternal(int StateNumber) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CAsyncStateHandler, int, void>)0x0065ECE0)(ref this, StateNumber);

    /// <summary>Retrieves an integer value from a specified asynchronous context's data array by index; returns 0 if the context does not exist.
    /// <code>Offset: 0x0065F230
    /// int __thiscall CAsyncStateHandler::GetContextData(CAsyncStateHandler*,AsyncContext,unsigned int)</code>
    /// </summary>
    /// <param name="hContext">Identifier for the async context whose data is requested.</param>
    /// <param name="dwDataIndex">Zero‑based index into the context's data array.</param>
    /// <returns>The integer stored at the specified index, or zero if the context cannot be found.</returns>
    public int GetContextData(ACBindings.Internal.AsyncContext hContext, uint dwDataIndex) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CAsyncStateHandler, ACBindings.Internal.AsyncContext, uint, int>)0x0065F230)(ref this, hContext, dwDataIndex);

    /// <summary>Sets a data value in the asynchronous state machine context identified by hContext. Returns true when the specified index is updated successfully, or false if the context cannot be found.
    /// <code>Offset: 0x0065F240
    /// bool __thiscall CAsyncStateHandler::SetContextData(CAsyncStateHandler*,AsyncContext,unsigned int,int)</code>
    /// </summary>
    /// <param name="hContext">The AsyncContext identifying the target context within the state machine.</param>
    /// <param name="dwDataIndex">Zero-based index into the context's data array to modify.</param>
    /// <param name="dwData">Integer value to store at the specified index.</param>
    /// <returns>True when the data was set; otherwise false if no matching context exists.</returns>
    public byte SetContextData(ACBindings.Internal.AsyncContext hContext, uint dwDataIndex, int dwData) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CAsyncStateHandler, ACBindings.Internal.AsyncContext, uint, int, byte>)0x0065F240)(ref this, hContext, dwDataIndex, dwData);

    /// <summary>Registers one or more context data names with the associated asynchronous state machine and returns the resulting name set.
    /// <code>Offset: 0x00660210
    /// const char** __thiscall CAsyncStateHandler::RegisterContextDataName(unsigned int**,const char**)</code>
    /// </summary>
    /// <param name="a2">An array of null‑terminated strings representing the context data names to register.</param>
    /// <returns>The registered name(s) as returned by the underlying state machine.</returns>
    public sbyte** RegisterContextDataName(sbyte** a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CAsyncStateHandler, sbyte**, sbyte**>)0x00660210)(ref this, a2);

    /// <summary>
    /// Detaches the handler from its owning async state machine, removing it from the machine’s internal hash list, then clears all internal references.
    /// 
    /// <code>Offset: 0x006605B0
    /// void __thiscall CAsyncStateHandler::~CAsyncStateHandler(CAsyncStateHandler*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CAsyncStateHandler, void>)0x006605B0)(ref this);
}

