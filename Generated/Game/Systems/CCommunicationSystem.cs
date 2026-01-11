namespace ACBindings.Internal;

public unsafe struct CCommunicationSystem
{
    // Statics
    public static ACBindings.Internal.CCommunicationSystem* s_pInstance = (ACBindings.Internal.CCommunicationSystem*)0x00870BE4;

    // Child Types
    public unsafe struct CCommunicationSystem_vtbl
    {
        // Members
        public System.IntPtr StartupTurbineChat_Internal;
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CCommunicationSystem*, ACBindings.Internal.CCommunicationSystem.ChatInterfaceProvider*> CreateChatInterfaceProvider; // function pointer

        // Methods
    }
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
            public delegate* unmanaged[Stdcall]<ACBindings.Internal.IUnknown*, ACBindings.Internal._GUID*, void**, int> QueryInterface; // function pointer
            public delegate* unmanaged[Stdcall]<ACBindings.Internal.IUnknown*, uint> AddRef; // function pointer
            public delegate* unmanaged[Stdcall]<ACBindings.Internal.IUnknown*, uint> Release; // function pointer
            public delegate* unmanaged[Stdcall]<ACBindings.Internal.IChatNetwork*, ACBindings.Internal.tagBLOB, int> SendData; // function pointer
            public delegate* unmanaged[Stdcall]<ACBindings.Internal.IChatNetwork*, int> UseTime; // function pointer
            public delegate* unmanaged[Thiscall]<ACBindings.Internal.CCommunicationSystem.ChatInterfaceProvider*, void> ChatInterfaceProvider_dtor_14; // function pointer

            // Methods
        }

        // Methods

        /// <summary>
        /// <code>Offset: 0x00557010
        /// HRESULT __stdcall CCommunicationSystem::ChatInterfaceProvider::SendData(CCommunicationSystem::ChatInterfaceProvider*,tagBLOB)</code>
        /// </summary>
        public static int SendData(ACBindings.Internal.CCommunicationSystem.ChatInterfaceProvider* this_, ACBindings.Internal.tagBLOB blob) => ((delegate* unmanaged[Stdcall]<ACBindings.Internal.CCommunicationSystem.ChatInterfaceProvider*, ACBindings.Internal.tagBLOB, int>)0x00557010)(this_, blob);

        /// <summary>
        /// <code>Offset: 0x00589E30
        /// HRESULT __stdcall CCommunicationSystem::ChatInterfaceProvider::QueryInterface(CCommunicationSystem::ChatInterfaceProvider*,const _GUID*,void**)</code>
        /// </summary>
        public static int QueryInterface(ACBindings.Internal.CCommunicationSystem.ChatInterfaceProvider* this_, ACBindings.Internal._GUID* riid, void** ppvObject) => ((delegate* unmanaged[Stdcall]<ACBindings.Internal.CCommunicationSystem.ChatInterfaceProvider*, ACBindings.Internal._GUID*, void**, int>)0x00589E30)(this_, riid, ppvObject);

        /// <summary>
        /// <code>Offset: 0x0058A0B0
        /// HRESULT __stdcall CCommunicationSystem::ChatInterfaceProvider::QueryInterface(const _GUID*,void**)</code>
        /// </summary>
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

    /// <summary>
    /// <code>Offset: 0x00556EB0
    /// void __cdecl CCommunicationSystem::Init()</code>
    /// </summary>
    public static void Init() => ((delegate* unmanaged[Cdecl]<void>)0x00556EB0)();

    /// <summary>
    /// <code>Offset: 0x00556ED0
    /// int __cdecl CCommunicationSystem::IsUsingTurbineChat()</code>
    /// </summary>
    public static int IsUsingTurbineChat() => ((delegate* unmanaged[Cdecl]<int>)0x00556ED0)();

    /// <summary>
    /// <code>Offset: 0x00556F00
    /// int __cdecl CCommunicationSystem::CSendToTurbineRoomByID(unsigned int,const unsigned __int16*,tagBLOB,tagBLOB)</code>
    /// </summary>
    public static int CSendToTurbineRoomByID(uint dwRoomID, ushort* pwszText, ACBindings.Internal.tagBLOB localBlob, ACBindings.Internal.tagBLOB remoteBlob) => ((delegate* unmanaged[Cdecl]<uint, ushort*, ACBindings.Internal.tagBLOB, ACBindings.Internal.tagBLOB, int>)0x00556F00)(dwRoomID, pwszText, localBlob, remoteBlob);

    /// <summary>
    /// <code>Offset: 0x00556F40
    /// AC1ClientChatManager* __cdecl CCommunicationSystem::GetChatManager()</code>
    /// </summary>
    public static ACBindings.Internal.AC1ClientChatManager* GetChatManager() => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.AC1ClientChatManager*>)0x00556F40)();

    /// <summary>
    /// <code>Offset: 0x005570E0
    /// int __cdecl CCommunicationSystem::StartupTurbineChat(int)</code>
    /// </summary>
    public static int StartupTurbineChat(int a1) => ((delegate* unmanaged[Cdecl]<int, int>)0x005570E0)(a1);

    /// <summary>
    /// <code>Offset: 0x00557170
    /// void __cdecl CCommunicationSystem::Cleanup()</code>
    /// </summary>
    public static void Cleanup() => ((delegate* unmanaged[Cdecl]<void>)0x00557170)();

    /// <summary>
    /// <code>Offset: 0x00557300
    /// void __thiscall CCommunicationSystem::CCommunicationSystem(CCommunicationSystem*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CCommunicationSystem, void>)0x00557300)(ref this);

    /// <summary>
    /// <code>Offset: 0x00557330
    /// int __thiscall CCommunicationSystem::StartupTurbineChat_Internal(_DWORD*,int)</code>
    /// </summary>
    public int StartupTurbineChat_Internal(int a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CCommunicationSystem, int, int>)0x00557330)(ref this, a2);
}

