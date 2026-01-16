namespace ACBindings.Internal;


/// <summary>Manages queued UI events and coordinates client systems, handling ordered and transient network blobs while maintaining reference counts and system lifecycles.</summary>
public unsafe struct UIQueueManager : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.IQueuedUIEventDeliverer BaseClass_IQueuedUIEventDeliverer; // ACBindings.Internal.IQueuedUIEventDeliverer

    // Child Types
    public unsafe struct UIQueueManager_vtbl
    {
        // Members
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.Interface*, ACBindings.Internal._GUID*, void**, int> IUnknown_QueryInterface; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.Interface*, uint> IUnknown_AddRef; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.Interface*, uint> IUnknown_Release; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.Interface*, ACBindings.Internal.TResult*, ACBindings.Internal.Turbine_GUID*, void**, ACBindings.Internal.TResult*> QueryInterface; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.Interface*, uint> AddRef; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.Interface*, uint> Release; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.IQueuedUIEventDeliverer*, void> OnStartup; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.IQueuedUIEventDeliverer*, void> OnShutdown; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.IQueuedUIEventDeliverer*, void> UseTime; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.IQueuedUIEventDeliverer*, ACBindings.Internal.NetBlob*, void> ProcessOrderedNetBlob; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.IQueuedUIEventDeliverer*, ACBindings.Internal.NetBlob*, void> ProcessEphemeralNetBlob; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.IQueuedUIEventDeliverer*, void> ResetDeliverySystem; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIQueueManager*, ACBindings.Internal.UIQueueManager.Enum17> You_Must_Not_Have_Multiple_Implementations_Of_AddRef_In_A_Hierarchy; // function pointer

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

    /// <summary>Retrieves a UI interface corresponding to the supplied GUID, storing the status in <paramref name="result"/> and delivering the interface pointer via <paramref name="o_ppvInterface"/> when available.
    /// <code>Offset: 0x0055B210
    /// TResult* __thiscall UIQueueManager::QueryInterface(UIQueueManager*,TResult*,const Turbine_GUID*,void**)</code>
    /// </summary>
    /// <param name="result">Container that receives a status code; its m_val field is set to 0 on success or E_NOINTERFACE (-2147467262) if the requested interface cannot be found.</param>
    /// <param name="i_rcInterface">GUID identifying the interface to query.</param>
    /// <param name="o_ppvInterface">Receives a pointer to the queried interface when it is supported; otherwise remains unchanged.</param>
    /// <returns>The same TResult instance passed in, with m_val indicating success (0) or failure (E_NOINTERFACE).</returns>
    public ACBindings.Internal.TResult* QueryInterface(ACBindings.Internal.TResult* result, ACBindings.Internal.Turbine_GUID* i_rcInterface, void** o_ppvInterface) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIQueueManager, ACBindings.Internal.TResult*, ACBindings.Internal.Turbine_GUID*, void**, ACBindings.Internal.TResult*>)0x0055B210)(ref this, result, i_rcInterface, o_ppvInterface);

    /// <summary>Releases all client systems currently held by the manager by decrementing their reference counts, in preparation for starting a new character session.
    /// <code>Offset: 0x0055B2E0
    /// void __thiscall UIQueueManager::OnBeginCharacterSession(UIQueueManager*)</code>
    /// </summary>
    public void OnBeginCharacterSession() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIQueueManager, void>)0x0055B2E0)(ref this);

    /// <summary>Calls QueryInterface on each client system maintained by the UIQueueManager.
    /// <code>Offset: 0x0055B310
    /// void __thiscall UIQueueManager::OnEndCharacterSession(UIQueueManager*)</code>
    /// </summary>
    public void OnEndCharacterSession() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIQueueManager, void>)0x0055B310)(ref this);

    /// <summary>Releases references to all client systems registered with the UI queue manager, clears their pointers, and performs shutdown cleanup for each system. Invokes base class shutdown logic after clearing system pointers.
    /// <code>Offset: 0x0055B340
    /// void __thiscall UIQueueManager::OnShutdown(UIQueueManager*)</code>
    /// </summary>
    public void OnShutdown() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIQueueManager, void>)0x0055B340)(ref this);

    /// <summary>Marks that crucial ordered events have been received and processes all queued waiting blobs, removing them from the queue and triggering cleanup callbacks for each.
    /// <code>Offset: 0x0055B430
    /// void __thiscall UIQueueManager::CrucialOrderedEventsReceived(UIQueueManager*)</code>
    /// </summary>
    public void CrucialOrderedEventsReceived() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIQueueManager, void>)0x0055B430)(ref this);

    /// <summary>Initializes a new UIQueueManager instance with default state and associates it with the supplied UI queue handle.
    /// <code>Offset: 0x0055B530
    /// int __thiscall UIQueueManager::UIQueueManager(int,int)</code>
    /// </summary>
    /// <param name="a2">UI queue handle that will be stored in the manager’s m_pUIQueue field.</param>
    /// <returns>The initialized UIQueueManager object.</returns>
    public int _ConstructorInternal(int a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIQueueManager, int, int>)0x0055B530)(ref this, a2);

    /// <summary>Destroys the UIQueueManager instance, releasing owned systems, clearing queued blobs, resetting reference counting, and performing internal cleanup routines.
    /// <code>Offset: 0x0055B5A0
    /// void __thiscall UIQueueManager::~UIQueueManager(UIQueueManager*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIQueueManager, void>)0x0055B5A0)(ref this);

    /// <summary>Handles string update events by unpacking a network buffer and delegating to the object maintenance system. If the event type matches the expected value, it extracts quality identifiers, optional length data, decompresses the string payload, and invokes either a public or private update routine. The function returns the result of that routine.
    /// <code>Offset: 0x0055B650
    /// unsigned int __thiscall UIQueueManager::HandleStringUpdateEvents(UIQueueManager*,void*,unsigned int,unsigned int)</code>
    /// </summary>
    /// <param name="buff">Pointer to the raw event buffer containing the event type, parameters, and compressed string data.</param>
    /// <param name="size">Size in bytes of the original buffer passed from the caller.</param>
    /// <param name="etype">Expected event type identifier; if it does not match the first DWORD of the buffer, the update is ignored.</param>
    /// <returns>Zero if the object maintenance system is unavailable or the event type mismatches; otherwise returns the value produced by the underlying quality update method (non‑zero on success).</returns>
    public uint HandleStringUpdateEvents(System.IntPtr buff, uint size, uint etype) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIQueueManager, System.IntPtr, uint, uint, uint>)0x0055B650)(ref this, buff, size, etype);

    /// <summary>Decrements the object's reference count and destroys the instance when the count reaches zero.
    /// <code>Offset: 0x0055B7F0
    /// unsigned int __thiscall UIQueueManager::Release(UIQueueManager*)</code>
    /// </summary>
    /// <returns>The updated reference count, or 0 if the object was deleted during this call.</returns>
    public uint Release() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIQueueManager, uint>)0x0055B7F0)(ref this);

    /// <summary>Initializes the UIQueueManager by constructing and registering a suite of client systems—magic, communication, UI, allegiance, fellowship, player, housing, mini‑game, combat, trade, and object maintenance—and storing their interfaces in an internal system list for subsequent use.
    /// <code>Offset: 0x0055B820
    /// void __thiscall UIQueueManager::OnStartup(UIQueueManager*)</code>
    /// </summary>
    public void OnStartup() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIQueueManager, void>)0x0055B820)(ref this);

    /// <summary>Processes incoming network data blobs and routes them to the appropriate UI event handlers based on an opcode contained in the first four bytes of the buffer.
    /// <code>Offset: 0x0055BCD0
    /// unsigned int __thiscall UIQueueManager::ProcessNetBlobData(UIQueueManager*,void*,unsigned int)</code>
    /// </summary>
    /// <param name="this">Pointer to the UIQueueManager instance handling the blob.</param>
    /// <param name="buff">Raw pointer to the network data blob; its first 4 bytes encode the event type, followed by the associated payload.</param>
    /// <param name="size">Total size in bytes of the buffer.</param>
    /// <returns>Result code returned by the dispatched handler, or zero if no action was taken.</returns>
    public uint ProcessNetBlobData(System.IntPtr buff, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIQueueManager, System.IntPtr, uint, uint>)0x0055BCD0)(ref this, buff, size);

    /// <summary>Processes an ordered network blob by unpacking its header and forwarding remaining data to ProcessNetBlobData.
    /// <code>Offset: 0x0055DD80
    /// void __thiscall UIQueueManager::ProcessOrderedNetBlob(UIQueueManager*,NetBlob*)</code>
    /// </summary>
    /// <param name="blob">The NetBlob containing the serialized event information.</param>
    public void ProcessOrderedNetBlob(ACBindings.Internal.NetBlob* blob) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIQueueManager, ACBindings.Internal.NetBlob*, void>)0x0055DD80)(ref this, blob);

    /// <summary>Processes an incoming transient network blob, immediately handling it if crucial ordered events have been received; otherwise defers processing by queuing the blob for later execution.
    /// <code>Offset: 0x0055DDE0
    /// void __thiscall UIQueueManager::ProcessEphemeralNetBlob(UIQueueManager*,NetBlob*)</code>
    /// </summary>
    /// <param name="blob">The NetBlob containing data to be processed or deferred.</param>
    public void ProcessEphemeralNetBlob(ACBindings.Internal.NetBlob* blob) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIQueueManager, ACBindings.Internal.NetBlob*, void>)0x0055DDE0)(ref this, blob);

    /// <summary>Handles a network UI event blob, ensuring that ordered blobs are processed in sequence for the target object before delivering them to the UI system. If the blob contains an order header with an item ID, it coordinates with the object maintenance system to queue or forward the blob appropriately; otherwise, it forwards the data directly to ProcessNetBlobData.
    /// <code>Offset: 0x0055DEE0
    /// void __thiscall UIQueueManager::HandleOrderingForBlob(UIQueueManager*,NetBlob*)</code>
    /// </summary>
    /// <param name="this">The UIQueueManager instance handling the event queue.</param>
    /// <param name="blob">The NetBlob containing UI event data and optional ordering information.</param>
    public void HandleOrderingForBlob(ACBindings.Internal.NetBlob* blob) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIQueueManager, ACBindings.Internal.NetBlob*, void>)0x0055DEE0)(ref this, blob);

    /// <summary>Processes queued network blobs for the UI system, handling message ordering and managing reference counts. For each blob in the queue it dispatches ordered events or increments references, then releases the blob when its count reaches zero. After clearing the queue, it increases reference counts on all registered client systems to keep them alive during subsequent operations.
    /// <code>Offset: 0x0055E050
    /// void __thiscall UIQueueManager::UseTime(UIQueueManager*)</code>
    /// </summary>
    public void UseTime() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIQueueManager, void>)0x0055E050)(ref this);
}

