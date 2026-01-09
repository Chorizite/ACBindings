namespace ACBindings;

// CCommunicationSystem
public unsafe struct CCommunicationSystem
{
    // Statics
    public static ACBindings.CCommunicationSystem* s_pInstance = (ACBindings.CCommunicationSystem*)0x0086F634;

    // Child Types
    // CCommunicationSystem_vtbl
    public unsafe struct CCommunicationSystem_vtbl
    {
        // Members
        public System.IntPtr StartupTurbineChat_Internal;
        public System.IntPtr CreateChatInterfaceProvider; // function pointer

        // Methods
    }
    // CCommunicationSystem::ChatInterfaceProvider_vtbl
    public unsafe struct ChatInterfaceProvider_vtbl
    {
        // Members
        public System.IntPtr QueryInterface; // function pointer
        public System.IntPtr AddRef; // function pointer
        public System.IntPtr Release; // function pointer
        public System.IntPtr SendData; // function pointer
        public System.IntPtr UseTime; // function pointer
        public System.IntPtr ChatInterfaceProvider_dtor_14; // function pointer

        // Methods
    }
    // CCommunicationSystem::ChatInterfaceProvider
    public unsafe struct ChatInterfaceProvider
    {
        // Base Classes
        public ACBindings.IChatNetwork BaseClass_IChatNetwork; // ACBindings.IChatNetwork
        public ACBindings.IChatClientEventSink BaseClass_IChatClientEventSink; // ACBindings.IChatClientEventSink
        public ACBindings.IChatClientAsyncResultSink BaseClass_IChatClientAsyncResultSink; // ACBindings.IChatClientAsyncResultSink

        // Methods
        // HRESULT __stdcall CCommunicationSystem::ChatInterfaceProvider::SendData(CCommunicationSystem::ChatInterfaceProvider*,tagBLOB)
        public static int SendData(ACBindings.CCommunicationSystem.ChatInterfaceProvider* this_, ACBindings.tagBLOB blob) => ((delegate* unmanaged[Stdcall]<ACBindings.CCommunicationSystem.ChatInterfaceProvider*, ACBindings.tagBLOB, int>)0x00557010)(this_, blob);
        // HRESULT __stdcall CCommunicationSystem::ChatInterfaceProvider::QueryInterface(CCommunicationSystem::ChatInterfaceProvider*,const _GUID*,void**)
        public static int QueryInterface(ACBindings.CCommunicationSystem.ChatInterfaceProvider* this_, ACBindings._GUID* riid, void** ppvObject) => ((delegate* unmanaged[Stdcall]<ACBindings.CCommunicationSystem.ChatInterfaceProvider*, ACBindings._GUID*, void**, int>)0x00589E30)(this_, riid, ppvObject);
        // HRESULT __stdcall CCommunicationSystem::ChatInterfaceProvider::QueryInterface(const _GUID*,void**)
        public static int QueryInterface(ACBindings._GUID* a1, void** a2) => ((delegate* unmanaged[Stdcall]<ACBindings._GUID*, void**, int>)0x0058A0B0)(a1, a2);
    }

    // Members
    public System.IntPtr __vftable; // vtable pointer
    public ACBindings.CCommunicationSystem.ChatInterfaceProvider* m_pChatInterfaceProvider;
    public ACBindings.AC1ClientChatManager* m_pChatManager;
    public int m_fUseTurbineChat;
    public ACBindings.PStringBase__sbyte m_TurbineChatDllName;

    // Generated Constructor
    public CCommunicationSystem() {
        _ConstructorInternal();
    }

    // Methods
    // void __cdecl CCommunicationSystem::Init()
    public static void Init() => ((delegate* unmanaged[Cdecl]<void>)0x00556EB0)();
    // int __cdecl CCommunicationSystem::IsUsingTurbineChat()
    public static int IsUsingTurbineChat() => ((delegate* unmanaged[Cdecl]<int>)0x00556ED0)();
    // int __cdecl CCommunicationSystem::CSendToTurbineRoomByID(unsigned int,const unsigned __int16*,tagBLOB,tagBLOB)
    public static int CSendToTurbineRoomByID(uint dwRoomID, ushort* pwszText, ACBindings.tagBLOB localBlob, ACBindings.tagBLOB remoteBlob) => ((delegate* unmanaged[Cdecl]<uint, ushort*, ACBindings.tagBLOB, ACBindings.tagBLOB, int>)0x00556F00)(dwRoomID, pwszText, localBlob, remoteBlob);
    // AC1ClientChatManager* __cdecl CCommunicationSystem::GetChatManager()
    public static ACBindings.AC1ClientChatManager* GetChatManager() => ((delegate* unmanaged[Cdecl]<ACBindings.AC1ClientChatManager*>)0x00556F40)();
    // int __cdecl CCommunicationSystem::StartupTurbineChat(int)
    public static int StartupTurbineChat(int a1) => ((delegate* unmanaged[Cdecl]<int, int>)0x005570E0)(a1);
    // void __cdecl CCommunicationSystem::Cleanup()
    public static void Cleanup() => ((delegate* unmanaged[Cdecl]<void>)0x00557170)();
    // void __thiscall CCommunicationSystem::CCommunicationSystem(CCommunicationSystem*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CCommunicationSystem, void>)0x00557300)(ref this);
    // int __thiscall CCommunicationSystem::StartupTurbineChat_Internal(_DWORD*,int)
    public int StartupTurbineChat_Internal(int a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CCommunicationSystem, int, int>)0x00557330)(ref this, a2);
}

