namespace ACBindings.Internal;


/// <summary>Manages performance monitoring counters and coordinates the RPC server lifecycle, offering operations for adding, querying, and resetting counters while handling crash cleanup.</summary>
public unsafe struct PerfMonCounterManager
{
    // Base Classes
    public ACBindings.Internal.CrashCleaner BaseClass_CrashCleaner; // ACBindings.Internal.CrashCleaner

    // Statics
    public static ACBindings.Internal.PerfMonCounterManager** Sm_pPerfMonCounterManager = (ACBindings.Internal.PerfMonCounterManager**)0x008F8A50;

    // Child Types
    public unsafe struct PerfMonCounterManager_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.PerfMonCounterManager*, void> PerfMonCounterManager_dtor_0; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.PerfMonCounterManager*, ACBindings.Internal.CPluginManager*, void> OnPluggedIn; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.PerfMonCounterManager*, void> CrashCleanup; // function pointer

        // Methods
    }

    // Members
    public ACBindings.Internal.RpcServer* m_pRpcServer;
    public ACBindings.Internal.List___PerfMonCounterInfo_ptr m_counters;
    public byte m_fInstalling;

    // Methods

    /// <summary>Cleans up crash‑related resources by resetting the RPC server pointer and clearing the global counter manager reference.
    /// <code>Offset: 0x00683F20
    /// void __thiscall PerfMonCounterManager::CrashCleanup(PerfMonCounterManager*)</code>
    /// </summary>
    public void CrashCleanup() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PerfMonCounterManager, void>)0x00683F20)(ref this);

    /// <summary>Searches for an existing performance counter by its name and returns a handle if one is found.
    /// <code>Offset: 0x00683FB0
    /// int __thiscall PerfMonCounterManager::LookupExistingCounterByName(_DWORD*,const wchar_t**,int)</code>
    /// </summary>
    /// <param name="a2">Pointer to the wide string containing the counter’s name.</param>
    /// <param name="a3">Auxiliary identifier used during the search, such as a counter index or flag.</param>
    /// <returns>Handle (non‑zero integer) of the matching counter; zero if no match exists.</returns>
    public int LookupExistingCounterByName(System.IntPtr a2, int a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PerfMonCounterManager, System.IntPtr, int, int>)0x00683FB0)(ref this, a2, a3);

    /// <summary>Adds a performance monitoring counter to the manager when no RPC server is running or installing is in progress. If a counter with the same name already exists, it does not add a duplicate and returns false.
    /// <code>Offset: 0x006840A0
    /// bool __thiscall PerfMonCounterManager::AddCounter(PerfMonCounterManager*,PerfMonCounterInfo*)</code>
    /// </summary>
    /// <param name="counter">The PerfMonCounterInfo object representing the counter to register.</param>
    /// <returns>True if the counter was added successfully; otherwise, false.</returns>
    public byte AddCounter(ACBindings.Internal.PerfMonCounterInfo* counter) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PerfMonCounterManager, ACBindings.Internal.PerfMonCounterInfo*, byte>)0x006840A0)(ref this, counter);

    /// <summary>Shuts down the RPC server, clears all performance counter entries, and releases associated resources.
    /// <code>Offset: 0x006841D0
    /// bool __thiscall PerfMonCounterManager::ShutdownAndResetInternal(PerfMonCounterManager*)</code>
    /// </summary>
    /// <returns>True after completion.</returns>
    public byte ShutdownAndResetInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PerfMonCounterManager, byte>)0x006841D0)(ref this);

    /// <summary>Populates a dynamic integer array with the type identifiers of all counters managed by the instance, resizing the array as required.
    /// <code>Offset: 0x00684370
    /// int __thiscall PerfMonCounterManager::FillInCounterTypes(_DWORD*,_DWORD*)</code>
    /// </summary>
    /// <param name="a2">The dynamic array into which counter type identifiers will be inserted.</param>
    /// <returns>The number of counter types added to the array.</returns>
    public int FillInCounterTypes(int* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PerfMonCounterManager, int*, int>)0x00684370)(ref this, a2);

    /// <summary>Fills supplied SmartArray with 64‑bit counter values from this manager and returns the total number of counters examined.
    /// <code>Offset: 0x00684420
    /// int __thiscall PerfMonCounterManager::FillInCounterValues(_DWORD*,int*)</code>
    /// </summary>
    /// <param name="a2">SmartArray buffer that receives the counter values; its capacity is expanded as needed.</param>
    /// <returns>The count of counters processed, which may be greater than the number actually stored if array growth fails.</returns>
    public int FillInCounterValues(int* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PerfMonCounterManager, int*, int>)0x00684420)(ref this, a2);
}

