namespace ACBindings.Internal;

public unsafe struct PerfMonCounterManager
{
    // Base Classes
    public ACBindings.Internal.CrashCleaner BaseClass_CrashCleaner; // ACBindings.Internal.CrashCleaner

    // Child Types
    public unsafe struct PerfMonCounterManager_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.PerfMonCounterManager*, void> PerfMonCounterManager_dtor_0; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.PerfMonCounterManager*, ACBindings.Internal.CPluginManager*, void> OnPluggedIn; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.PerfMonCounterManager*, void> CrashCleanup; // function pointer

        // Methods
    }

    // Members
    public ACBindings.Internal.RpcServer* m_pRpcServer;
    public ACBindings.Internal.List___PerfMonCounterInfo_ptr m_counters;
    public byte m_fInstalling;

    // Methods

    /// <summary>
    /// <code>Offset: 0x00683F20
    /// void __thiscall PerfMonCounterManager::CrashCleanup(PerfMonCounterManager*)</code>
    /// </summary>
    public void CrashCleanup() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PerfMonCounterManager, void>)0x00683F20)(ref this);

    /// <summary>
    /// <code>Offset: 0x00683FB0
    /// int __thiscall PerfMonCounterManager::LookupExistingCounterByName(_DWORD*,const wchar_t**,int)</code>
    /// </summary>
    public int LookupExistingCounterByName(System.IntPtr a2, int a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PerfMonCounterManager, System.IntPtr, int, int>)0x00683FB0)(ref this, a2, a3);

    /// <summary>
    /// <code>Offset: 0x006840A0
    /// bool __thiscall PerfMonCounterManager::AddCounter(PerfMonCounterManager*,PerfMonCounterInfo*)</code>
    /// </summary>
    public byte AddCounter(ACBindings.Internal.PerfMonCounterInfo* counter) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PerfMonCounterManager, ACBindings.Internal.PerfMonCounterInfo*, byte>)0x006840A0)(ref this, counter);

    /// <summary>
    /// <code>Offset: 0x006841D0
    /// bool __thiscall PerfMonCounterManager::ShutdownAndResetInternal(PerfMonCounterManager*)</code>
    /// </summary>
    public byte ShutdownAndResetInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PerfMonCounterManager, byte>)0x006841D0)(ref this);

    /// <summary>
    /// <code>Offset: 0x00684370
    /// int __thiscall PerfMonCounterManager::FillInCounterTypes(_DWORD*,_DWORD*)</code>
    /// </summary>
    public int FillInCounterTypes(int* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PerfMonCounterManager, int*, int>)0x00684370)(ref this, a2);

    /// <summary>
    /// <code>Offset: 0x00684420
    /// int __thiscall PerfMonCounterManager::FillInCounterValues(_DWORD*,int*)</code>
    /// </summary>
    public int FillInCounterValues(int* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PerfMonCounterManager, int*, int>)0x00684420)(ref this, a2);
}

