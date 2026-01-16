namespace ACBindings.Internal;


/// <summary>Provides a singleton communication subsystem that manages chat interfaces, Turbine chat usage flags, and the associated chat manager for the client application.</summary>
public unsafe struct CCommunicationSystem
{
    // Statics
    public static ACBindings.Internal.CCommunicationSystem** s_pInstance = (ACBindings.Internal.CCommunicationSystem**)0x00870BE4;

    // Child Types
    public unsafe struct CCommunicationSystem_vtbl
    {
        // Members
        public System.IntPtr StartupTurbineChat_Internal;
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CCommunicationSystem*, ACBindings.Internal.CCommunicationSystem.ChatInterfaceProvider*> CreateChatInterfaceProvider; // function pointer

        // Methods
    }

    /// <summary>Facilitates chat network communication by exposing interfaces for sending messages, handling client events, and processing asynchronous results.</summary>
    public unsafe struct ChatInterfaceProvider
    {
        // Base Classes
        public ACBindings.Internal.IChatNetwork BaseClass_IChatNetwork; // ACBindings.Internal.IChatNetwork
        public ACBindings.Internal.IChatClientEventSink BaseClass_IChatClientEventSink; // ACBindings.Internal.IChatClientEventSink
        public ACBindings.Internal.IChatClientAsyncResultSink BaseClass_IChatClientAsyncResultSink; // ACBindings.Internal.IChatClientAsyncResultSink

        // Child Types
        public unsafe struct ChatInterfaceProvider_vtbl
        {
            // Members
            public static delegate* unmanaged[Stdcall]<ACBindings.Internal.IUnknown*, ACBindings.Internal._GUID*, void**, int> QueryInterface; // function pointer
            public static delegate* unmanaged[Stdcall]<ACBindings.Internal.IUnknown*, uint> AddRef; // function pointer
            public static delegate* unmanaged[Stdcall]<ACBindings.Internal.IUnknown*, uint> Release; // function pointer
            public static delegate* unmanaged[Stdcall]<ACBindings.Internal.IChatNetwork*, ACBindings.Internal.tagBLOB, int> SendData; // function pointer
            public static delegate* unmanaged[Stdcall]<ACBindings.Internal.IChatNetwork*, int> UseTime; // function pointer
            public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CCommunicationSystem.ChatInterfaceProvider*, void> ChatInterfaceProvider_dtor_14; // function pointer

            // Methods
        }

        // Methods

        /// <summary>Sends chat data by wrapping the supplied buffer into a NetBlob and transmitting it over the network.
        /// <code>Offset: 0x00557010
        /// HRESULT __stdcall CCommunicationSystem::ChatInterfaceProvider::SendData(CCommunicationSystem::ChatInterfaceProvider*,tagBLOB)</code>
        /// </summary>
        /// <param name="blob">The raw data buffer to be sent, containing a pointer to the data and its size.</param>
        /// <returns>Returns S_OK (0) if the blob was successfully created and transmitted; otherwise returns an error HRESULT such as E_FAIL when creation or transmission fails.</returns>
        public static int SendData(ACBindings.Internal.CCommunicationSystem.ChatInterfaceProvider* this_, ACBindings.Internal.tagBLOB blob) => ((delegate* unmanaged[Stdcall]<ACBindings.Internal.CCommunicationSystem.ChatInterfaceProvider*, ACBindings.Internal.tagBLOB, int>)0x00557010)(this_, blob);

        /// <summary>Attempts to retrieve an interface from the ChatInterfaceProvider but always fails, returning a fixed error code.
        /// <code>Offset: 0x00589E30
        /// HRESULT __stdcall CCommunicationSystem::ChatInterfaceProvider::QueryInterface(CCommunicationSystem::ChatInterfaceProvider*,const _GUID*,void**)</code>
        /// </summary>
        /// <param name="riid">GUID of the requested interface.</param>
        /// <param name="ppvObject">Pointer that would receive the requested interface if succeeded; remains unchanged on failure.</param>
        /// <returns>HRESULT 0x80004001 indicating the operation is unsupported or has failed.</returns>
        public static int QueryInterface(ACBindings.Internal.CCommunicationSystem.ChatInterfaceProvider* this_, ACBindings.Internal._GUID* riid, void** ppvObject) => ((delegate* unmanaged[Stdcall]<ACBindings.Internal.CCommunicationSystem.ChatInterfaceProvider*, ACBindings.Internal._GUID*, void**, int>)0x00589E30)(this_, riid, ppvObject);

        /// <summary>Provides interface pointers for requested COM interfaces of the chat system provider.
        /// <code>Offset: 0x0058A0B0
        /// HRESULT __stdcall CCommunicationSystem::ChatInterfaceProvider::QueryInterface(const _GUID*,void**)</code>
        /// </summary>
        /// <param name="a1">Pointer to the IID of the desired interface.</param>
        /// <param name="a2">Receives the address of the interface pointer if supported.</param>
        /// <returns>Returns S_OK on success or an error code such as E_NOINTERFACE if the requested interface is not implemented.</returns>
        public static int QueryInterface(ACBindings.Internal._GUID* a1, void** a2) => ((delegate* unmanaged[Stdcall]<ACBindings.Internal._GUID*, void**, int>)0x0058A0B0)(a1, a2);
    }

    // Members
    public System.IntPtr __vftable; // vtable pointer
    public ACBindings.Internal.CCommunicationSystem.ChatInterfaceProvider* m_pChatInterfaceProvider;
    public ACBindings.Internal.AC1ClientChatManager* m_pChatManager;
    public int m_fUseTurbineChat;
    public ACBindings.Internal.PStringBase__sbyte m_TurbineChatDllName;

    // Generated Constructor
    public CCommunicationSystem() {
        _ConstructorInternal();
    }

    // Methods

    /// <summary>Initializes the singleton instance of CCommunicationSystem by creating it through the factory if it does not already exist.
    /// <code>Offset: 0x00556EB0
    /// void __cdecl CCommunicationSystem::Init()</code>
    /// </summary>
    public static void Init() => ((delegate* unmanaged[Cdecl]<void>)0x00556EB0)();

    /// <summary>Checks whether the communication system is configured to use Turbine chat.
    /// <code>Offset: 0x00556ED0
    /// int __cdecl CCommunicationSystem::IsUsingTurbineChat()</code>
    /// </summary>
    /// <returns>Non‑zero when Turbine chat is enabled; zero otherwise.</returns>
    public static int IsUsingTurbineChat() => ((delegate* unmanaged[Cdecl]<int>)0x00556ED0)();

    /// <summary>Sends a UTF‑16 message along with optional local and remote data blobs to a Turbine chat room identified by its ID.
    /// <code>Offset: 0x00556F00
    /// int __cdecl CCommunicationSystem::CSendToTurbineRoomByID(unsigned int,const unsigned __int16*,tagBLOB,tagBLOB)</code>
    /// </summary>
    /// <param name="dwRoomID">Identifier of the target Turbine chat room.</param>
    /// <param name="pwszText">Wide string containing the text to send (UTF-16).</param>
    /// <param name="localBlob">Data blob for local context, specified by size and pointer fields.</param>
    /// <param name="remoteBlob">Data blob intended for remote recipients, also defined by size and pointer.</param>
    /// <returns>Non‑zero if the message was successfully transmitted; zero otherwise (including when no chat client is available).</returns>
    public static int CSendToTurbineRoomByID(uint dwRoomID, ushort* pwszText, ACBindings.Internal.tagBLOB localBlob, ACBindings.Internal.tagBLOB remoteBlob) => ((delegate* unmanaged[Cdecl]<uint, ushort*, ACBindings.Internal.tagBLOB, ACBindings.Internal.tagBLOB, int>)0x00556F00)(dwRoomID, pwszText, localBlob, remoteBlob);

    /// <summary>
    /// Retrieves the chat manager associated with the global communication system instance.
    /// 
    /// <code>Offset: 0x00556F40
    /// AC1ClientChatManager* __cdecl CCommunicationSystem::GetChatManager()</code>
    /// </summary>
    /// <returns>
    /// Pointer to AC1ClientChatManager, or nullptr when the communication system singleton has not been created or lacks a chat manager.
    /// </returns>
    public static ACBindings.Internal.AC1ClientChatManager* GetChatManager() => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.AC1ClientChatManager*>)0x00556F40)();

    /// <summary>Initializes turbine chat by delegating to the global communication system instance, managing reference counting on the supplied context object, and invoking its cleanup callback when no longer needed.
    /// <code>Offset: 0x005570E0
    /// int __cdecl CCommunicationSystem::StartupTurbineChat(int)</code>
    /// </summary>
    /// <param name="a1">Pointer to a context structure that contains a reference count at offset +4 and a function pointer for cleanup; used to track active turbine chat sessions.</param>
    /// <returns>Zero if the global communication system instance is unavailable, otherwise the status code returned by the instance’s startup routine.</returns>
    public static int StartupTurbineChat(int a1) => ((delegate* unmanaged[Cdecl]<int, int>)0x005570E0)(a1);

    /// <summary>Decrements the reference count of the Turbine chat DLL name string, frees the communication system instance, and clears the global singleton pointer.
    /// <code>Offset: 0x00557170
    /// void __cdecl CCommunicationSystem::Cleanup()</code>
    /// </summary>
    public static void Cleanup() => ((delegate* unmanaged[Cdecl]<void>)0x00557170)();

    /// <summary>Initializes the communication system's internal state, setting default values for the virtual table pointer, chat interface provider, Turbine chat usage flag, and loading the default Turbine chat DLL name.
    /// <code>Offset: 0x00557300
    /// void __thiscall CCommunicationSystem::CCommunicationSystem(CCommunicationSystem*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CCommunicationSystem, void>)0x00557300)(ref this);

    /// <summary>Initializes the Turbine chat subsystem for the communication system, performing single‑time setup of the chat manager and crash reporting helper. Handles reference counting through the supplied object and cleans up on failure.
    /// <code>Offset: 0x00557330
    /// int __thiscall CCommunicationSystem::StartupTurbineChat_Internal(_DWORD*,int)</code>
    /// </summary>
    /// <param name="a2">Reference to an object that holds a reference count and a callback function; used to manage initialization state and cleanup.</param>
    /// <returns>Non‑zero value if initialization succeeds, otherwise zero.</returns>
    public int StartupTurbineChat_Internal(int a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CCommunicationSystem, int, int>)0x00557330)(ref this, a2);
}

