namespace ACBindings;

// gmCCommunicationSystem
public unsafe struct gmCCommunicationSystem
{
    // Base Classes
    public ACBindings.CCommunicationSystem BaseClass_CCommunicationSystem; // ACBindings.CCommunicationSystem

    // Child Types
    // gmCCommunicationSystem_vtbl
    public unsafe struct gmCCommunicationSystem_vtbl
    {
        // Members
        public System.IntPtr StartupTurbineChat_Internal;
        public System.IntPtr CreateChatInterfaceProvider; // function pointer

        // Methods
    }
    // gmCCommunicationSystem::uiChatInterfaceProvider_vtbl
    public unsafe struct uiChatInterfaceProvider_vtbl
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
    // gmCCommunicationSystem::uiChatInterfaceProvider
    public unsafe struct uiChatInterfaceProvider
    {
        // Base Classes
        public ACBindings.CCommunicationSystem.ChatInterfaceProvider BaseClass_CCommunicationSystem_ChatInterfaceProvider; // ACBindings.CCommunicationSystem.ChatInterfaceProvider

        // Methods
        // void __stdcall gmCCommunicationSystem::uiChatInterfaceProvider::OnSendToRoomByIDResult(gmCCommunicationSystem::uiChatInterfaceProvider*,HRESULT,unsigned int,const unsigned __int16*,tagBLOB)
        public static void OnSendToRoomByIDResult(ACBindings.gmCCommunicationSystem.uiChatInterfaceProvider* this_, int hAsyncResult, uint dwRoomID, ushort* pwszText, ACBindings.tagBLOB localBlob) => ((delegate* unmanaged[Stdcall]<ACBindings.gmCCommunicationSystem.uiChatInterfaceProvider*, int, uint, ushort*, ACBindings.tagBLOB, void>)0x0058AC60)(this_, hAsyncResult, dwRoomID, pwszText, localBlob);
        // void __stdcall gmCCommunicationSystem::uiChatInterfaceProvider::OnSendToRoom(gmCCommunicationSystem::uiChatInterfaceProvider*,unsigned int,const unsigned __int16*,const unsigned __int16*,tagBLOB)
        public static void OnSendToRoom(ACBindings.gmCCommunicationSystem.uiChatInterfaceProvider* this_, uint dwRoomID, ushort* pwszDisplayName, ushort* pwszText, ACBindings.tagBLOB extraInfoBlob) => ((delegate* unmanaged[Stdcall]<ACBindings.gmCCommunicationSystem.uiChatInterfaceProvider*, uint, ushort*, ushort*, ACBindings.tagBLOB, void>)0x0058B3C0)(this_, dwRoomID, pwszDisplayName, pwszText, extraInfoBlob);
    }

    // Members
    public uint talkFocus;
    public uint m_uiAllowedTalkFocusBitmask;
    public ACBindings.SquelchDB _squelch_db;
    public int chatSquelched;
    public uint m_iidLastSpeakableTarget;
    public ACBindings.PStringBase__sbyte lastTelleeName;
    public uint lastTeller;
    public ACBindings.PStringBase__sbyte lastTellerName;
    public ACBindings.AC1Legacy.PStringBase__sbyte lastAtMonarchUserName;
    public ACBindings.AC1Legacy.PStringBase__sbyte lastAtPatronUserName;
    public ACBindings.AC1Legacy.PStringBase__sbyte system_message_string;
    public ACBindings.ChatRoomTracker* crt;
    public int m_WantsToBeInAllegChat;

    // Generated Constructor
    public gmCCommunicationSystem() {
        _ConstructorInternal();
    }

    // Methods
    // void __cdecl gmCCommunicationSystem::SetTalkFocus(unsigned int)
    public static void SetTalkFocus(uint focus) => ((delegate* unmanaged[Cdecl]<uint, void>)0x00589E70)(focus);
    // unsigned int __cdecl gmCCommunicationSystem::GetTalkFocus()
    public static uint GetTalkFocus() => ((delegate* unmanaged[Cdecl]<uint>)0x00589E90)();
    // void __cdecl gmCCommunicationSystem::SetTalkFocusEnabled(unsigned int,bool)
    public static void SetTalkFocusEnabled(uint i_eFocus, byte i_bEnabled) => ((delegate* unmanaged[Cdecl]<uint, byte, void>)0x00589EB0)(i_eFocus, i_bEnabled);
    // bool __cdecl gmCCommunicationSystem::IsTalkFocusEnabled(unsigned int)
    public static byte IsTalkFocusEnabled(uint i_eFocus) => ((delegate* unmanaged[Cdecl]<uint, byte>)0x00589F00)(i_eFocus);
    // ChatRoomTracker* __cdecl gmCCommunicationSystem::GetChatRoomTracker()
    public static ACBindings.ChatRoomTracker* GetChatRoomTracker() => ((delegate* unmanaged[Cdecl]<ACBindings.ChatRoomTracker*>)0x00589F20)();
    // int __cdecl gmCCommunicationSystem::SetChatRoomTracker(const ChatRoomTracker*)
    public static int SetChatRoomTracker(ACBindings.ChatRoomTracker* i_pChatTracker) => ((delegate* unmanaged[Cdecl]<ACBindings.ChatRoomTracker*, int>)0x00589F40)(i_pChatTracker);
    // void __cdecl gmCCommunicationSystem::SetWantsToBeInAllegChat(int)
    public static void SetWantsToBeInAllegChat(int wantsToBeInAllegChat) => ((delegate* unmanaged[Cdecl]<int, void>)0x00589F60)(wantsToBeInAllegChat);
    // int __cdecl gmCCommunicationSystem::WantsToBeInAllegChat()
    public static int WantsToBeInAllegChat() => ((delegate* unmanaged[Cdecl]<int>)0x00589F80)();
    // void __cdecl gmCCommunicationSystem::SetLastSpeakableTarget(unsigned int)
    public static void SetLastSpeakableTarget(uint i_iidTarget) => ((delegate* unmanaged[Cdecl]<uint, void>)0x00589FA0)(i_iidTarget);
    // unsigned int __cdecl gmCCommunicationSystem::GetLastSpeakableTarget()
    public static uint GetLastSpeakableTarget() => ((delegate* unmanaged[Cdecl]<uint>)0x00589FC0)();
    // void __cdecl gmCCommunicationSystem::SetLastTeller(unsigned int)
    public static void SetLastTeller(uint id) => ((delegate* unmanaged[Cdecl]<uint, void>)0x00589FD0)(id);
    // unsigned int __cdecl gmCCommunicationSystem::GetLastTeller()
    public static uint GetLastTeller() => ((delegate* unmanaged[Cdecl]<uint>)0x00589FF0)();
    // int __cdecl gmCCommunicationSystem::IsSquelched(unsigned int,int*,unsigned int)
    public static int IsSquelched(uint a1, int* a2, uint ltt) => ((delegate* unmanaged[Cdecl]<uint, int*, uint, int>)0x0058A000)(a1, a2, ltt);
    // void __cdecl gmCCommunicationSystem::SetSquelchDB(const SquelchDB*)
    public static void SetSquelchDB(ACBindings.SquelchDB* db) => ((delegate* unmanaged[Cdecl]<ACBindings.SquelchDB*, void>)0x0058A050)(db);
    // void __cdecl gmCCommunicationSystem::ClearSquelchDB()
    public static void ClearSquelchDB() => ((delegate* unmanaged[Cdecl]<void>)0x0058A070)();
    // void __thiscall gmCCommunicationSystem::gmCCommunicationSystem(gmCCommunicationSystem*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmCCommunicationSystem, void>)0x0058A1F0)(ref this);
    // LONG __cdecl gmCCommunicationSystem::SetLastTelleeName(int)
    public static int SetLastTelleeName(int a1) => ((delegate* unmanaged[Cdecl]<int, int>)0x0058A2B0)(a1);
    // __int32 __cdecl gmCCommunicationSystem::SetLastTellerName(int*)
    public static int SetLastTellerName(int* a1) => ((delegate* unmanaged[Cdecl]<int*, int>)0x0058A330)(a1);
    // void** __cdecl gmCCommunicationSystem::GetLastTellerName(void**)
    public static void** GetLastTellerName(void** a1) => ((delegate* unmanaged[Cdecl]<void**, void**>)0x0058A380)(a1);
    // LONG __cdecl gmCCommunicationSystem::SetLastAtMonarchUserName(int)
    public static int SetLastAtMonarchUserName(int a1) => ((delegate* unmanaged[Cdecl]<int, int>)0x0058A3C0)(a1);
    // void** __cdecl gmCCommunicationSystem::GetLastAtMonarchUserName(void**)
    public static void** GetLastAtMonarchUserName(void** a1) => ((delegate* unmanaged[Cdecl]<void**, void**>)0x0058A440)(a1);
    // LONG __cdecl gmCCommunicationSystem::SetLastAtPatronUserName(int)
    public static int SetLastAtPatronUserName(int a1) => ((delegate* unmanaged[Cdecl]<int, int>)0x0058A480)(a1);
    // void** __cdecl gmCCommunicationSystem::GetLastAtPatronUserName(void**)
    public static void** GetLastAtPatronUserName(void** a1) => ((delegate* unmanaged[Cdecl]<void**, void**>)0x0058A500)(a1);
    // void __cdecl gmCCommunicationSystem::StartSquelchIteration()
    public static void StartSquelchIteration() => ((delegate* unmanaged[Cdecl]<void>)0x0058A540)();
    // BOOL __thiscall gmCCommunicationSystem::StartupTurbineChat_Internal(_DWORD*,int)
    public byte StartupTurbineChat_Internal(int a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmCCommunicationSystem, int, byte>)0x0058A580)(ref this, a2);
    // int __cdecl gmCCommunicationSystem::CanHear(const unsigned int,const unsigned int)
    public static int CanHear(uint iid, uint msg_type) => ((delegate* unmanaged[Cdecl]<uint, uint, int>)0x0058A690)(iid, msg_type);
    // int __cdecl gmCCommunicationSystem::NextSquelchIteration(int*,int*)
    public static int NextSquelchIteration(int* a1, int* a2) => ((delegate* unmanaged[Cdecl]<int*, int*, int>)0x0058A790)(a1, a2);
    // CCommunicationSystem::ChatInterfaceProvider* __thiscall gmCCommunicationSystem::CreateChatInterfaceProvider(gmCCommunicationSystem*)
    public ACBindings.CCommunicationSystem.ChatInterfaceProvider* CreateChatInterfaceProvider() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmCCommunicationSystem, ACBindings.CCommunicationSystem.ChatInterfaceProvider*>)0x0058A830)(ref this);
    // void** __cdecl gmCCommunicationSystem::GetLastTelleeName(void**)
    public static void** GetLastTelleeName(void** a1) => ((delegate* unmanaged[Cdecl]<void**, void**>)0x0058A870)(a1);
    // int __cdecl gmCCommunicationSystem::ConvertSQToPString(SquelchInfo*,int*,int)
    public static int ConvertSQToPString(ACBindings.SquelchInfo* a1, int* a2, int a3) => ((delegate* unmanaged[Cdecl]<ACBindings.SquelchInfo*, int*, int, int>)0x0058A8B0)(a1, a2, a3);
    // int __cdecl gmCCommunicationSystem::GetListofSquelchChannels(char**)
    public static int GetListofSquelchChannels(sbyte** a1) => ((delegate* unmanaged[Cdecl]<sbyte**, int>)0x0058ACE0)(a1);
    // void __cdecl gmCCommunicationSystem::HandleRangedTalkEvent(int,int,unsigned int,float,unsigned int)
    public static void HandleRangedTalkEvent(int a1, int a2, uint ArgList, float a4, uint i_ltt) => ((delegate* unmanaged[Cdecl]<int, int, uint, float, uint, void>)0x0058AD90)(a1, a2, ArgList, a4, i_ltt);
    // int __cdecl gmCCommunicationSystem::DoGlobalSquelchQuery()
    public static int DoGlobalSquelchQuery() => ((delegate* unmanaged[Cdecl]<int>)0x0058AED0)();
    // int __cdecl gmCCommunicationSystem::DoSquelchQuery()
    public static int DoSquelchQuery() => ((delegate* unmanaged[Cdecl]<int>)0x0058B0F0)();
}

