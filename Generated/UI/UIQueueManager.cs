namespace ACBindings;

// UIQueueManager
public unsafe struct UIQueueManager : System.IDisposable
{
    // Base Classes
    public ACBindings.IQueuedUIEventDeliverer BaseClass_IQueuedUIEventDeliverer; // ACBindings.IQueuedUIEventDeliverer

    // Child Types
    // UIQueueManager_vtbl
    public unsafe struct UIQueueManager_vtbl
    {
        // Members
        public System.IntPtr IUnknown_QueryInterface; // function pointer
        public System.IntPtr IUnknown_AddRef; // function pointer
        public System.IntPtr IUnknown_Release; // function pointer
        public System.IntPtr QueryInterface; // function pointer
        public System.IntPtr AddRef; // function pointer
        public System.IntPtr Release; // function pointer
        public System.IntPtr OnStartup; // function pointer
        public System.IntPtr OnShutdown; // function pointer
        public System.IntPtr UseTime; // function pointer
        public System.IntPtr ProcessOrderedNetBlob; // function pointer
        public System.IntPtr ProcessEphemeralNetBlob; // function pointer
        public System.IntPtr ResetDeliverySystem; // function pointer
        public System.IntPtr You_Must_Not_Have_Multiple_Implementations_Of_AddRef_In_A_Hierarchy; // function pointer

        // Methods
    }
    // UIQueueManager::Enum16
    public enum Enum16 : uint
    {
    }
    // UIQueueManager::Enum17
    public enum Enum17 : uint
    {
    }
    // UIQueueManager::Enum18
    public enum Enum18 : byte
    {
        IMPLEMENT_STD_ADDREF_UNIQUE_RETVAL = 0x0
    }

    // Members
    public ACBindings.Turbine_RefCount m_cTurbineRefCount;
    public ACBindings.NIList__NetBlob_ptr m_rgWaitingBlobs;
    public byte m_fCrucialOrderedEventsReceived;
    public System.IntPtr m_pUIQueue;
    public ACBindings.SmartArray__ClientSystem_ptr m_rgSystems;
    public ACBindings.ClientMagicSystem* m_pMagicSystem;
    public ACBindings.ClientCommunicationSystem* m_pCommunicationSystem;
    public ACBindings.ClientObjMaintSystem* m_pObjMaintSystem;
    public ACBindings.ClientUISystem* m_pUISystem;
    public ACBindings.ClientAllegianceSystem* m_pAllegianceSystem;
    public ACBindings.ClientFellowshipSystem* m_pFellowshipSystem;
    public ACBindings.CPlayerSystem* m_pPlayerSystem;
    public ACBindings.ClientHousingSystem* m_pHousingSystem;
    public ACBindings.ClientMiniGameSystem* m_pMiniGameSystem;
    public ACBindings.ClientAdminSystem* m_pAdminSystem;
    public ACBindings.ClientCombatSystem* m_pCombatSystem;
    public ACBindings.ClientTradeSystem* m_pTradeSystem;

    // Generated Constructor
    public UIQueueManager(int a2) {
        _ConstructorInternal(a2);
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods
    // TResult* __thiscall UIQueueManager::QueryInterface(UIQueueManager*,TResult*,const Turbine_GUID*,void**)
    public ACBindings.TResult* QueryInterface(ACBindings.TResult* result, ACBindings.Turbine_GUID* i_rcInterface, void** o_ppvInterface) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIQueueManager, ACBindings.TResult*, ACBindings.Turbine_GUID*, void**, ACBindings.TResult*>)0x0055B210)(ref this, result, i_rcInterface, o_ppvInterface);
    // void __thiscall UIQueueManager::OnBeginCharacterSession(UIQueueManager*)
    public void OnBeginCharacterSession() => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIQueueManager, void>)0x0055B2E0)(ref this);
    // void __thiscall UIQueueManager::OnEndCharacterSession(UIQueueManager*)
    public void OnEndCharacterSession() => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIQueueManager, void>)0x0055B310)(ref this);
    // void __thiscall UIQueueManager::OnShutdown(UIQueueManager*)
    public void OnShutdown() => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIQueueManager, void>)0x0055B340)(ref this);
    // void __thiscall UIQueueManager::CrucialOrderedEventsReceived(UIQueueManager*)
    public void CrucialOrderedEventsReceived() => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIQueueManager, void>)0x0055B430)(ref this);
    // int __thiscall UIQueueManager::UIQueueManager(int,int)
    public int _ConstructorInternal(int a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIQueueManager, int, int>)0x0055B530)(ref this, a2);
    // void __thiscall UIQueueManager::~UIQueueManager(UIQueueManager*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIQueueManager, void>)0x0055B5A0)(ref this);
    // unsigned int __thiscall UIQueueManager::HandleStringUpdateEvents(UIQueueManager*,void*,unsigned int,unsigned int)
    public uint HandleStringUpdateEvents(System.IntPtr buff, uint size, uint etype) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIQueueManager, System.IntPtr, uint, uint, uint>)0x0055B650)(ref this, buff, size, etype);
    // unsigned int __thiscall UIQueueManager::Release(UIQueueManager*)
    public uint Release() => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIQueueManager, uint>)0x0055B7F0)(ref this);
    // void __thiscall UIQueueManager::OnStartup(UIQueueManager*)
    public void OnStartup() => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIQueueManager, void>)0x0055B820)(ref this);
    // unsigned int __thiscall UIQueueManager::ProcessNetBlobData(UIQueueManager*,void*,unsigned int)
    public uint ProcessNetBlobData(System.IntPtr buff, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIQueueManager, System.IntPtr, uint, uint>)0x0055BCD0)(ref this, buff, size);
    // void __thiscall UIQueueManager::ProcessOrderedNetBlob(UIQueueManager*,NetBlob*)
    public void ProcessOrderedNetBlob(ACBindings.NetBlob* blob) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIQueueManager, ACBindings.NetBlob*, void>)0x0055DD80)(ref this, blob);
    // void __thiscall UIQueueManager::ProcessEphemeralNetBlob(UIQueueManager*,NetBlob*)
    public void ProcessEphemeralNetBlob(ACBindings.NetBlob* blob) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIQueueManager, ACBindings.NetBlob*, void>)0x0055DDE0)(ref this, blob);
    // void __thiscall UIQueueManager::HandleOrderingForBlob(UIQueueManager*,NetBlob*)
    public void HandleOrderingForBlob(ACBindings.NetBlob* blob) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIQueueManager, ACBindings.NetBlob*, void>)0x0055DEE0)(ref this, blob);
    // void __thiscall UIQueueManager::UseTime(UIQueueManager*)
    public void UseTime() => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIQueueManager, void>)0x0055E050)(ref this);
}

