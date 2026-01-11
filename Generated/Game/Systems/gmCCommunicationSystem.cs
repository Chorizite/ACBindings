namespace ACBindings.Internal;

public unsafe struct gmCCommunicationSystem
{
    // Base Classes
    public ACBindings.Internal.CCommunicationSystem BaseClass_CCommunicationSystem; // ACBindings.Internal.CCommunicationSystem

    // Child Types
    public unsafe struct gmCCommunicationSystem_vtbl
    {
        // Members
        public System.IntPtr StartupTurbineChat_Internal;
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.gmCCommunicationSystem*, ACBindings.Internal.CCommunicationSystem.ChatInterfaceProvider*> CreateChatInterfaceProvider; // function pointer

        // Methods
    }
    public unsafe struct uiChatInterfaceProvider
    {
        // Base Classes
        public ACBindings.Internal.CCommunicationSystem.ChatInterfaceProvider BaseClass_CCommunicationSystem_ChatInterfaceProvider; // ACBindings.Internal.CCommunicationSystem.ChatInterfaceProvider

        // Child Types
        public unsafe struct uiChatInterfaceProvider_vtbl
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
        /// <code>Offset: 0x0058AC60
        /// void __stdcall gmCCommunicationSystem::uiChatInterfaceProvider::OnSendToRoomByIDResult(gmCCommunicationSystem::uiChatInterfaceProvider*,HRESULT,unsigned int,const unsigned __int16*,tagBLOB)</code>
        /// </summary>
        public static void OnSendToRoomByIDResult(ACBindings.Internal.gmCCommunicationSystem.uiChatInterfaceProvider* this_, int hAsyncResult, uint dwRoomID, ushort* pwszText, ACBindings.Internal.tagBLOB localBlob) => ((delegate* unmanaged[Stdcall]<ACBindings.Internal.gmCCommunicationSystem.uiChatInterfaceProvider*, int, uint, ushort*, ACBindings.Internal.tagBLOB, void>)0x0058AC60)(this_, hAsyncResult, dwRoomID, pwszText, localBlob);

        /// <summary>
        /// <code>Offset: 0x0058B3C0
        /// void __stdcall gmCCommunicationSystem::uiChatInterfaceProvider::OnSendToRoom(gmCCommunicationSystem::uiChatInterfaceProvider*,unsigned int,const unsigned __int16*,const unsigned __int16*,tagBLOB)</code>
        /// </summary>
        public static void OnSendToRoom(ACBindings.Internal.gmCCommunicationSystem.uiChatInterfaceProvider* this_, uint dwRoomID, ushort* pwszDisplayName, ushort* pwszText, ACBindings.Internal.tagBLOB extraInfoBlob) => ((delegate* unmanaged[Stdcall]<ACBindings.Internal.gmCCommunicationSystem.uiChatInterfaceProvider*, uint, ushort*, ushort*, ACBindings.Internal.tagBLOB, void>)0x0058B3C0)(this_, dwRoomID, pwszDisplayName, pwszText, extraInfoBlob);
    }

    // Members
    public uint talkFocus;
    public uint m_uiAllowedTalkFocusBitmask;
    public ACBindings.Internal.SquelchDB _squelch_db;
    public int chatSquelched;
    public uint m_iidLastSpeakableTarget;
    public ACBindings.Internal.PStringBase__sbyte lastTelleeName;
    public uint lastTeller;
    public ACBindings.Internal.PStringBase__sbyte lastTellerName;
    public ACBindings.Internal.AC1Legacy.PStringBase__sbyte lastAtMonarchUserName;
    public ACBindings.Internal.AC1Legacy.PStringBase__sbyte lastAtPatronUserName;
    public ACBindings.Internal.AC1Legacy.PStringBase__sbyte system_message_string;
    public ACBindings.Internal.ChatRoomTracker* crt;
    public int m_WantsToBeInAllegChat;

    // Generated Constructor
    public gmCCommunicationSystem() {
        _ConstructorInternal();
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x00589E70
    /// void __cdecl gmCCommunicationSystem::SetTalkFocus(unsigned int)</code>
    /// </summary>
    public static void SetTalkFocus(uint focus) => ((delegate* unmanaged[Cdecl]<uint, void>)0x00589E70)(focus);

    /// <summary>
    /// <code>Offset: 0x00589E90
    /// unsigned int __cdecl gmCCommunicationSystem::GetTalkFocus()</code>
    /// </summary>
    public static uint GetTalkFocus() => ((delegate* unmanaged[Cdecl]<uint>)0x00589E90)();

    /// <summary>
    /// <code>Offset: 0x00589EB0
    /// void __cdecl gmCCommunicationSystem::SetTalkFocusEnabled(unsigned int,bool)</code>
    /// </summary>
    public static void SetTalkFocusEnabled(uint i_eFocus, byte i_bEnabled) => ((delegate* unmanaged[Cdecl]<uint, byte, void>)0x00589EB0)(i_eFocus, i_bEnabled);

    /// <summary>
    /// <code>Offset: 0x00589F00
    /// bool __cdecl gmCCommunicationSystem::IsTalkFocusEnabled(unsigned int)</code>
    /// </summary>
    public static byte IsTalkFocusEnabled(uint i_eFocus) => ((delegate* unmanaged[Cdecl]<uint, byte>)0x00589F00)(i_eFocus);

    /// <summary>
    /// <code>Offset: 0x00589F20
    /// ChatRoomTracker* __cdecl gmCCommunicationSystem::GetChatRoomTracker()</code>
    /// </summary>
    public static ACBindings.Internal.ChatRoomTracker* GetChatRoomTracker() => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.ChatRoomTracker*>)0x00589F20)();

    /// <summary>
    /// <code>Offset: 0x00589F40
    /// int __cdecl gmCCommunicationSystem::SetChatRoomTracker(const ChatRoomTracker*)</code>
    /// </summary>
    public static int SetChatRoomTracker(ACBindings.Internal.ChatRoomTracker* i_pChatTracker) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.ChatRoomTracker*, int>)0x00589F40)(i_pChatTracker);

    /// <summary>
    /// <code>Offset: 0x00589F60
    /// void __cdecl gmCCommunicationSystem::SetWantsToBeInAllegChat(int)</code>
    /// </summary>
    public static void SetWantsToBeInAllegChat(int wantsToBeInAllegChat) => ((delegate* unmanaged[Cdecl]<int, void>)0x00589F60)(wantsToBeInAllegChat);

    /// <summary>
    /// <code>Offset: 0x00589F80
    /// int __cdecl gmCCommunicationSystem::WantsToBeInAllegChat()</code>
    /// </summary>
    public static int WantsToBeInAllegChat() => ((delegate* unmanaged[Cdecl]<int>)0x00589F80)();

    /// <summary>
    /// <code>Offset: 0x00589FA0
    /// void __cdecl gmCCommunicationSystem::SetLastSpeakableTarget(unsigned int)</code>
    /// </summary>
    public static void SetLastSpeakableTarget(uint i_iidTarget) => ((delegate* unmanaged[Cdecl]<uint, void>)0x00589FA0)(i_iidTarget);

    /// <summary>
    /// <code>Offset: 0x00589FC0
    /// unsigned int __cdecl gmCCommunicationSystem::GetLastSpeakableTarget()</code>
    /// </summary>
    public static uint GetLastSpeakableTarget() => ((delegate* unmanaged[Cdecl]<uint>)0x00589FC0)();

    /// <summary>
    /// <code>Offset: 0x00589FD0
    /// void __cdecl gmCCommunicationSystem::SetLastTeller(unsigned int)</code>
    /// </summary>
    public static void SetLastTeller(uint id) => ((delegate* unmanaged[Cdecl]<uint, void>)0x00589FD0)(id);

    /// <summary>
    /// <code>Offset: 0x00589FF0
    /// unsigned int __cdecl gmCCommunicationSystem::GetLastTeller()</code>
    /// </summary>
    public static uint GetLastTeller() => ((delegate* unmanaged[Cdecl]<uint>)0x00589FF0)();

    /// <summary>
    /// <code>Offset: 0x0058A000
    /// int __cdecl gmCCommunicationSystem::IsSquelched(unsigned int,int*,unsigned int)</code>
    /// </summary>
    public static int IsSquelched(uint a1, int* a2, uint ltt) => ((delegate* unmanaged[Cdecl]<uint, int*, uint, int>)0x0058A000)(a1, a2, ltt);

    /// <summary>
    /// <code>Offset: 0x0058A050
    /// void __cdecl gmCCommunicationSystem::SetSquelchDB(const SquelchDB*)</code>
    /// </summary>
    public static void SetSquelchDB(ACBindings.Internal.SquelchDB* db) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.SquelchDB*, void>)0x0058A050)(db);

    /// <summary>
    /// <code>Offset: 0x0058A070
    /// void __cdecl gmCCommunicationSystem::ClearSquelchDB()</code>
    /// </summary>
    public static void ClearSquelchDB() => ((delegate* unmanaged[Cdecl]<void>)0x0058A070)();

    /// <summary>
    /// <code>Offset: 0x0058A1F0
    /// void __thiscall gmCCommunicationSystem::gmCCommunicationSystem(gmCCommunicationSystem*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmCCommunicationSystem, void>)0x0058A1F0)(ref this);

    /// <summary>
    /// <code>Offset: 0x0058A2B0
    /// LONG __cdecl gmCCommunicationSystem::SetLastTelleeName(int)</code>
    /// </summary>
    public static int SetLastTelleeName(int a1) => ((delegate* unmanaged[Cdecl]<int, int>)0x0058A2B0)(a1);

    /// <summary>
    /// <code>Offset: 0x0058A330
    /// __int32 __cdecl gmCCommunicationSystem::SetLastTellerName(int*)</code>
    /// </summary>
    public static int SetLastTellerName(int* a1) => ((delegate* unmanaged[Cdecl]<int*, int>)0x0058A330)(a1);

    /// <summary>
    /// <code>Offset: 0x0058A380
    /// void** __cdecl gmCCommunicationSystem::GetLastTellerName(void**)</code>
    /// </summary>
    public static void** GetLastTellerName(void** a1) => ((delegate* unmanaged[Cdecl]<void**, void**>)0x0058A380)(a1);

    /// <summary>
    /// <code>Offset: 0x0058A3C0
    /// LONG __cdecl gmCCommunicationSystem::SetLastAtMonarchUserName(int)</code>
    /// </summary>
    public static int SetLastAtMonarchUserName(int a1) => ((delegate* unmanaged[Cdecl]<int, int>)0x0058A3C0)(a1);

    /// <summary>
    /// <code>Offset: 0x0058A440
    /// void** __cdecl gmCCommunicationSystem::GetLastAtMonarchUserName(void**)</code>
    /// </summary>
    public static void** GetLastAtMonarchUserName(void** a1) => ((delegate* unmanaged[Cdecl]<void**, void**>)0x0058A440)(a1);

    /// <summary>
    /// <code>Offset: 0x0058A480
    /// LONG __cdecl gmCCommunicationSystem::SetLastAtPatronUserName(int)</code>
    /// </summary>
    public static int SetLastAtPatronUserName(int a1) => ((delegate* unmanaged[Cdecl]<int, int>)0x0058A480)(a1);

    /// <summary>
    /// <code>Offset: 0x0058A500
    /// void** __cdecl gmCCommunicationSystem::GetLastAtPatronUserName(void**)</code>
    /// </summary>
    public static void** GetLastAtPatronUserName(void** a1) => ((delegate* unmanaged[Cdecl]<void**, void**>)0x0058A500)(a1);

    /// <summary>
    /// <code>Offset: 0x0058A540
    /// void __cdecl gmCCommunicationSystem::StartSquelchIteration()</code>
    /// </summary>
    public static void StartSquelchIteration() => ((delegate* unmanaged[Cdecl]<void>)0x0058A540)();

    /// <summary>
    /// <code>Offset: 0x0058A580
    /// BOOL __thiscall gmCCommunicationSystem::StartupTurbineChat_Internal(_DWORD*,int)</code>
    /// </summary>
    public byte StartupTurbineChat_Internal(int a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmCCommunicationSystem, int, byte>)0x0058A580)(ref this, a2);

    /// <summary>
    /// <code>Offset: 0x0058A690
    /// int __cdecl gmCCommunicationSystem::CanHear(const unsigned int,const unsigned int)</code>
    /// </summary>
    public static int CanHear(uint iid, uint msg_type) => ((delegate* unmanaged[Cdecl]<uint, uint, int>)0x0058A690)(iid, msg_type);

    /// <summary>
    /// <code>Offset: 0x0058A790
    /// int __cdecl gmCCommunicationSystem::NextSquelchIteration(int*,int*)</code>
    /// </summary>
    public static int NextSquelchIteration(int* a1, int* a2) => ((delegate* unmanaged[Cdecl]<int*, int*, int>)0x0058A790)(a1, a2);

    /// <summary>
    /// <code>Offset: 0x0058A830
    /// CCommunicationSystem::ChatInterfaceProvider* __thiscall gmCCommunicationSystem::CreateChatInterfaceProvider(gmCCommunicationSystem*)</code>
    /// </summary>
    public ACBindings.Internal.CCommunicationSystem.ChatInterfaceProvider* CreateChatInterfaceProvider() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmCCommunicationSystem, ACBindings.Internal.CCommunicationSystem.ChatInterfaceProvider*>)0x0058A830)(ref this);

    /// <summary>
    /// <code>Offset: 0x0058A870
    /// void** __cdecl gmCCommunicationSystem::GetLastTelleeName(void**)</code>
    /// </summary>
    public static void** GetLastTelleeName(void** a1) => ((delegate* unmanaged[Cdecl]<void**, void**>)0x0058A870)(a1);

    /// <summary>
    /// <code>Offset: 0x0058A8B0
    /// int __cdecl gmCCommunicationSystem::ConvertSQToPString(SquelchInfo*,int*,int)</code>
    /// </summary>
    public static int ConvertSQToPString(ACBindings.Internal.SquelchInfo* a1, int* a2, int a3) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.SquelchInfo*, int*, int, int>)0x0058A8B0)(a1, a2, a3);

    /// <summary>
    /// <code>Offset: 0x0058ACE0
    /// int __cdecl gmCCommunicationSystem::GetListofSquelchChannels(char**)</code>
    /// </summary>
    public static int GetListofSquelchChannels(sbyte** a1) => ((delegate* unmanaged[Cdecl]<sbyte**, int>)0x0058ACE0)(a1);

    /// <summary>
    /// <code>Offset: 0x0058AD90
    /// void __cdecl gmCCommunicationSystem::HandleRangedTalkEvent(int,int,unsigned int,float,unsigned int)</code>
    /// </summary>
    public static void HandleRangedTalkEvent(int a1, int a2, uint ArgList, float a4, uint i_ltt) => ((delegate* unmanaged[Cdecl]<int, int, uint, float, uint, void>)0x0058AD90)(a1, a2, ArgList, a4, i_ltt);

    /// <summary>
    /// <code>Offset: 0x0058AED0
    /// int __cdecl gmCCommunicationSystem::DoGlobalSquelchQuery()</code>
    /// </summary>
    public static int DoGlobalSquelchQuery() => ((delegate* unmanaged[Cdecl]<int>)0x0058AED0)();

    /// <summary>
    /// <code>Offset: 0x0058B0F0
    /// int __cdecl gmCCommunicationSystem::DoSquelchQuery()</code>
    /// </summary>
    public static int DoSquelchQuery() => ((delegate* unmanaged[Cdecl]<int>)0x0058B0F0)();
}

