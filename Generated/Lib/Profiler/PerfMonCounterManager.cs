namespace ACBindings;

// PerfMonCounterManager
public unsafe struct PerfMonCounterManager
{
    // Base Classes
    public ACBindings.CrashCleaner BaseClass_CrashCleaner; // ACBindings.CrashCleaner

    // Statics
    public static ACBindings.PerfMonCounterManager* Sm_pPerfMonCounterManager = (ACBindings.PerfMonCounterManager*)0x008F8A50;

    // Child Types
    // PerfMonCounterManager_vtbl
    public unsafe struct PerfMonCounterManager_vtbl
    {
        // Members
        public System.IntPtr PerfMonCounterManager_dtor_0; // function pointer
        public System.IntPtr OnPluggedIn; // function pointer
        public System.IntPtr CrashCleanup; // function pointer

        // Methods
    }

    // Members
    public ACBindings.RpcServer* m_pRpcServer;
    public ACBindings.List__PerfMonCounterInfo_ptr m_counters;
    public byte m_fInstalling;

    // Methods
    // void __thiscall PerfMonCounterManager::CrashCleanup(PerfMonCounterManager*)
    public void CrashCleanup() => ((delegate* unmanaged[Thiscall]<ref ACBindings.PerfMonCounterManager, void>)0x00683F20)(ref this);
    // int __thiscall PerfMonCounterManager::LookupExistingCounterByName(_DWORD*,const wchar_t**,int)
    public int LookupExistingCounterByName(System.IntPtr a2, int a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.PerfMonCounterManager, System.IntPtr, int, int>)0x00683FB0)(ref this, a2, a3);
    // bool __thiscall PerfMonCounterManager::AddCounter(PerfMonCounterManager*,PerfMonCounterInfo*)
    public byte AddCounter(ACBindings.PerfMonCounterInfo* counter) => ((delegate* unmanaged[Thiscall]<ref ACBindings.PerfMonCounterManager, ACBindings.PerfMonCounterInfo*, byte>)0x006840A0)(ref this, counter);
    // bool __thiscall PerfMonCounterManager::ShutdownAndResetInternal(PerfMonCounterManager*)
    public byte ShutdownAndResetInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.PerfMonCounterManager, byte>)0x006841D0)(ref this);
    // int __thiscall PerfMonCounterManager::FillInCounterTypes(_DWORD*,_DWORD*)
    public int FillInCounterTypes(int* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.PerfMonCounterManager, int*, int>)0x00684370)(ref this, a2);
    // int __thiscall PerfMonCounterManager::FillInCounterValues(_DWORD*,int*)
    public int FillInCounterValues(int* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.PerfMonCounterManager, int*, int>)0x00684420)(ref this, a2);
}

