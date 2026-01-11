namespace ACBindings.Internal;

public unsafe struct UIQueueManager : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.IQueuedUIEventDeliverer BaseClass_IQueuedUIEventDeliverer; // ACBindings.Internal.IQueuedUIEventDeliverer

    // Child Types
    public unsafe struct UIQueueManager_vtbl
    {
        // Members
        public delegate* unmanaged[Stdcall]<ACBindings.Internal.Interface*, ACBindings.Internal._GUID*, void**, int> IUnknown_QueryInterface; // function pointer
        public delegate* unmanaged[Stdcall]<ACBindings.Internal.Interface*, uint> IUnknown_AddRef; // function pointer
        public delegate* unmanaged[Stdcall]<ACBindings.Internal.Interface*, uint> IUnknown_Release; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.Interface*, ACBindings.Internal.TResult*, ACBindings.Internal.Turbine_GUID*, void**, ACBindings.Internal.TResult*> QueryInterface; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.Interface*, uint> AddRef; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.Interface*, uint> Release; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.IQueuedUIEventDeliverer*, void> OnStartup; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.IQueuedUIEventDeliverer*, void> OnShutdown; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.IQueuedUIEventDeliverer*, void> UseTime; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.IQueuedUIEventDeliverer*, ACBindings.Internal.NetBlob*, void> ProcessOrderedNetBlob; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.IQueuedUIEventDeliverer*, ACBindings.Internal.NetBlob*, void> ProcessEphemeralNetBlob; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.IQueuedUIEventDeliverer*, void> ResetDeliverySystem; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIQueueManager*, ACBindings.Internal.UIQueueManager.Enum17> You_Must_Not_Have_Multiple_Implementations_Of_AddRef_In_A_Hierarchy; // function pointer

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
    public ACBindings.Internal.Turbine_RefCount m_cTurbineRefCount;
    public ACBindings.Internal.NIList___NetBlob_ptr m_rgWaitingBlobs;
    public byte m_fCrucialOrderedEventsReceived;
    public System.IntPtr m_pUIQueue;
    public ACBindings.Internal.SmartArray___ClientSystem_ptr m_rgSystems;
    public ACBindings.Internal.ClientMagicSystem* m_pMagicSystem;
    public ACBindings.Internal.ClientCommunicationSystem* m_pCommunicationSystem;
    public ACBindings.Internal.ClientObjMaintSystem* m_pObjMaintSystem;
    public ACBindings.Internal.ClientUISystem* m_pUISystem;
    public ACBindings.Internal.ClientAllegianceSystem* m_pAllegianceSystem;
    public ACBindings.Internal.ClientFellowshipSystem* m_pFellowshipSystem;
    public ACBindings.Internal.CPlayerSystem* m_pPlayerSystem;
    public ACBindings.Internal.ClientHousingSystem* m_pHousingSystem;
    public ACBindings.Internal.ClientMiniGameSystem* m_pMiniGameSystem;
    public ACBindings.Internal.ClientAdminSystem* m_pAdminSystem;
    public ACBindings.Internal.ClientCombatSystem* m_pCombatSystem;
    public ACBindings.Internal.ClientTradeSystem* m_pTradeSystem;

    // Generated Constructor
    public UIQueueManager(int a2) {
        _ConstructorInternal(a2);
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x0055B210
    /// TResult* __thiscall UIQueueManager::QueryInterface(UIQueueManager*,TResult*,const Turbine_GUID*,void**)</code>
    /// </summary>
    public ACBindings.Internal.TResult* QueryInterface(ACBindings.Internal.TResult* result, ACBindings.Internal.Turbine_GUID* i_rcInterface, void** o_ppvInterface) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIQueueManager, ACBindings.Internal.TResult*, ACBindings.Internal.Turbine_GUID*, void**, ACBindings.Internal.TResult*>)0x0055B210)(ref this, result, i_rcInterface, o_ppvInterface);

    /// <summary>
    /// <code>Offset: 0x0055B2E0
    /// void __thiscall UIQueueManager::OnBeginCharacterSession(UIQueueManager*)</code>
    /// </summary>
    public void OnBeginCharacterSession() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIQueueManager, void>)0x0055B2E0)(ref this);

    /// <summary>
    /// <code>Offset: 0x0055B310
    /// void __thiscall UIQueueManager::OnEndCharacterSession(UIQueueManager*)</code>
    /// </summary>
    public void OnEndCharacterSession() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIQueueManager, void>)0x0055B310)(ref this);

    /// <summary>
    /// <code>Offset: 0x0055B340
    /// void __thiscall UIQueueManager::OnShutdown(UIQueueManager*)</code>
    /// </summary>
    public void OnShutdown() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIQueueManager, void>)0x0055B340)(ref this);

    /// <summary>
    /// <code>Offset: 0x0055B430
    /// void __thiscall UIQueueManager::CrucialOrderedEventsReceived(UIQueueManager*)</code>
    /// </summary>
    public void CrucialOrderedEventsReceived() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIQueueManager, void>)0x0055B430)(ref this);

    /// <summary>
    /// <code>Offset: 0x0055B530
    /// int __thiscall UIQueueManager::UIQueueManager(int,int)</code>
    /// </summary>
    public int _ConstructorInternal(int a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIQueueManager, int, int>)0x0055B530)(ref this, a2);

    /// <summary>
    /// <code>Offset: 0x0055B5A0
    /// void __thiscall UIQueueManager::~UIQueueManager(UIQueueManager*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIQueueManager, void>)0x0055B5A0)(ref this);

    /// <summary>
    /// <code>Offset: 0x0055B650
    /// unsigned int __thiscall UIQueueManager::HandleStringUpdateEvents(UIQueueManager*,void*,unsigned int,unsigned int)</code>
    /// </summary>
    public uint HandleStringUpdateEvents(System.IntPtr buff, uint size, uint etype) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIQueueManager, System.IntPtr, uint, uint, uint>)0x0055B650)(ref this, buff, size, etype);

    /// <summary>
    /// <code>Offset: 0x0055B7F0
    /// unsigned int __thiscall UIQueueManager::Release(UIQueueManager*)</code>
    /// </summary>
    public uint Release() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIQueueManager, uint>)0x0055B7F0)(ref this);

    /// <summary>
    /// <code>Offset: 0x0055B820
    /// void __thiscall UIQueueManager::OnStartup(UIQueueManager*)</code>
    /// </summary>
    public void OnStartup() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIQueueManager, void>)0x0055B820)(ref this);

    /// <summary>
    /// <code>Offset: 0x0055BCD0
    /// unsigned int __thiscall UIQueueManager::ProcessNetBlobData(UIQueueManager*,void*,unsigned int)</code>
    /// </summary>
    public uint ProcessNetBlobData(System.IntPtr buff, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIQueueManager, System.IntPtr, uint, uint>)0x0055BCD0)(ref this, buff, size);

    /// <summary>
    /// <code>Offset: 0x0055DD80
    /// void __thiscall UIQueueManager::ProcessOrderedNetBlob(UIQueueManager*,NetBlob*)</code>
    /// </summary>
    public void ProcessOrderedNetBlob(ACBindings.Internal.NetBlob* blob) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIQueueManager, ACBindings.Internal.NetBlob*, void>)0x0055DD80)(ref this, blob);

    /// <summary>
    /// <code>Offset: 0x0055DDE0
    /// void __thiscall UIQueueManager::ProcessEphemeralNetBlob(UIQueueManager*,NetBlob*)</code>
    /// </summary>
    public void ProcessEphemeralNetBlob(ACBindings.Internal.NetBlob* blob) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIQueueManager, ACBindings.Internal.NetBlob*, void>)0x0055DDE0)(ref this, blob);

    /// <summary>
    /// <code>Offset: 0x0055DEE0
    /// void __thiscall UIQueueManager::HandleOrderingForBlob(UIQueueManager*,NetBlob*)</code>
    /// </summary>
    public void HandleOrderingForBlob(ACBindings.Internal.NetBlob* blob) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIQueueManager, ACBindings.Internal.NetBlob*, void>)0x0055DEE0)(ref this, blob);

    /// <summary>
    /// <code>Offset: 0x0055E050
    /// void __thiscall UIQueueManager::UseTime(UIQueueManager*)</code>
    /// </summary>
    public void UseTime() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIQueueManager, void>)0x0055E050)(ref this);
}

