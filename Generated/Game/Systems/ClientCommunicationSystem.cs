namespace ACBindings;

// ClientCommunicationSystem
public unsafe struct ClientCommunicationSystem : System.IDisposable
{
    // Base Classes
    public ACBindings.ClientSystem BaseClass_ClientSystem; // ACBindings.ClientSystem
    public ACBindings.QualityChangeHandler BaseClass_QualityChangeHandler; // ACBindings.QualityChangeHandler

    // Statics
    public static ACBindings.ClientCommunicationSystem* s_pCommunicationSystem = (ACBindings.ClientCommunicationSystem*)0x0086EA0C;

    // Child Types
    // ClientCommunicationSystem_vtbl
    public unsafe struct ClientCommunicationSystem_vtbl
    {
        // Members
        public System.IntPtr IUnknown_QueryInterface; // function pointer
        public System.IntPtr IUnknown_AddRef; // function pointer
        public System.IntPtr IUnknown_Release; // function pointer
        public System.IntPtr QueryInterface; // function pointer
        public System.IntPtr AddRef; // function pointer
        public System.IntPtr Release; // function pointer
        public System.IntPtr OnStartup; // function pointer
        public System.IntPtr UseTime; // function pointer
        public System.IntPtr OnBeginCharacterSession; // function pointer
        public System.IntPtr OnEndCharacterSession; // function pointer
        public System.IntPtr OnShutdown; // function pointer
        public System.IntPtr You_Must_Not_Have_Multiple_Implementations_Of_AddRef_In_A_Hierarchy; // function pointer

        // Methods
    }
    // ClientCommunicationSystem::CmdHashData
    public unsafe struct CmdHashData
    {
        // Base Classes
        public ACBindings.IntrusiveHashData__CaseInsensitiveStringBase__PStringBase__sbyte__ClientCommunicationSystem_CmdHashData_ptr BaseClass_IntrusiveHashData; // ACBindings.IntrusiveHashData__CaseInsensitiveStringBase__PStringBase__sbyte__ClientCommunicationSystem_CmdHashData_ptr

        // Members
        public System.IntPtr func; // function pointer
        public System.IntPtr help;

        // Generated Constructor
        public CmdHashData(int* a2, int a3, int a4, int a5, int a6) {
            _ConstructorInternal(a2, a3, a4, a5, a6);
        }

        // Methods
        // int* __thiscall ClientCommunicationSystem::CmdHashData::CmdHashData(int*,int*,int,int,int,int)
        public int* _ConstructorInternal(int* a2, int a3, int a4, int a5, int a6) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientCommunicationSystem.CmdHashData, int*, int, int, int, int, int*>)0x0056FAE0)(ref this, a2, a3, a4, a5, a6);
    }
    // ClientCommunicationSystem::Enum10
    public enum Enum10 : uint
    {
    }
    // ClientCommunicationSystem::Enum11
    public enum Enum11 : uint
    {
    }
    // ClientCommunicationSystem::Enum4
    public enum Enum4 : uint
    {
    }
    // ClientCommunicationSystem::Enum9
    public enum Enum9 : uint
    {
    }
    // ClientCommunicationSystem::HelpType
    public enum HelpType : byte
    {
        Summary_HelpType = 0x0,
        List_HelpType = 0x1,
        Detail_HelpType = 0x2
    }

    // Members
    public ACBindings.Turbine_RefCount m_cTurbineRefCount;
    public ACBindings.IntrusiveHashTable__CaseInsensitiveStringBase__PStringBase__sbyte__ClientCommunicationSystem_CmdHashData_ptr m_hashCommands;
    public ACBindings.PStringBase__sbyte m_strLastCommandLine;
    public ACBindings.PStringBase__sbyte m_strCurrentCommand;
    public uint m_idCurrentCommandSource;
    public int m_LastSpamCheck;
    public int m_ChatMessageCount;
    public ACBindings.PStringBase__sbyte m_strLogName;

    // Generated Constructor
    public ClientCommunicationSystem() {
        _ConstructorInternal();
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods
    // ClientCommunicationSystem* __cdecl ClientCommunicationSystem::GetCommunicationSystem()
    public static ACBindings.ClientCommunicationSystem* GetCommunicationSystem() => ((delegate* unmanaged[Cdecl]<ACBindings.ClientCommunicationSystem*>)0x0056F230)();
    // void __thiscall ClientCommunicationSystem::OnBeginCharacterSession(ClientCommunicationSystem*)
    public void OnBeginCharacterSession() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientCommunicationSystem, void>)0x0056F240)(ref this);
    // void __thiscall ClientCommunicationSystem::OnEndCharacterSession(ClientCommunicationSystem*)
    public void OnEndCharacterSession() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientCommunicationSystem, void>)0x0056F270)(ref this);
    // unsigned int __thiscall ClientCommunicationSystem::Handle_Communication__Recv_ChatRoomTracker(ClientCommunicationSystem*,const ChatRoomTracker*)
    public uint Handle_Communication__Recv_ChatRoomTracker(ACBindings.ChatRoomTracker* chatRoomTracker) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientCommunicationSystem, ACBindings.ChatRoomTracker*, uint>)0x0056F2A0)(ref this, chatRoomTracker);
    // int __stdcall ClientCommunicationSystem::Handle_Communication__HearRangedSpeech(int,int,unsigned int,float,int)
    public static int Handle_Communication__HearRangedSpeech(int a1, int a2, uint ArgList, float a4, int a5) => ((delegate* unmanaged[Stdcall]<int, int, uint, float, int, int>)0x0056F300)(a1, a2, ArgList, a4, a5);
    // int __thiscall ClientCommunicationSystem::IsMessageSpam(ClientCommunicationSystem*,int)
    public int IsMessageSpam(int wait_time) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientCommunicationSystem, int, int>)0x0056F330)(ref this, wait_time);
    // bool __thiscall ClientCommunicationSystem::DoBirth(ClientCommunicationSystem*,int,char**)
    public byte DoBirth(int argc, sbyte** argv) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientCommunicationSystem, int, sbyte**, byte>)0x0056F3A0)(ref this, argc, argv);
    // bool __thiscall ClientCommunicationSystem::EnableChatTalkFocuses(ClientCommunicationSystem*)
    public byte EnableChatTalkFocuses() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientCommunicationSystem, byte>)0x0056F400)(ref this);
    // TResult* __thiscall ClientCommunicationSystem::QueryInterface(ClientCommunicationSystem*,TResult*,const Turbine_GUID*,void**)
    public ACBindings.TResult* QueryInterface(ACBindings.TResult* result, ACBindings.Turbine_GUID* i_rcInterface, void** o_ppvInterface) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientCommunicationSystem, ACBindings.TResult*, ACBindings.Turbine_GUID*, void**, ACBindings.TResult*>)0x0056F570)(ref this, result, i_rcInterface, o_ppvInterface);
    // void __thiscall ClientCommunicationSystem::RecvNotice_DisplayStringInfo(ClientCommunicationSystem*,unsigned int,const StringInfo*)
    public void RecvNotice_DisplayStringInfo(uint type, ACBindings.StringInfo* msg) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientCommunicationSystem, uint, ACBindings.StringInfo*, void>)0x0056F640)(ref this, type, msg);
    // void __thiscall ClientCommunicationSystem::RecvNotice_PlayerDescReceived(ClientCommunicationSystem*,const CACQualities*,const CPlayerModule*)
    public void RecvNotice_PlayerDescReceived(ACBindings.CACQualities* i_playerDesc, ACBindings.CPlayerModule* i_playerModule) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientCommunicationSystem, ACBindings.CACQualities*, ACBindings.CPlayerModule*, void>)0x0056F690)(ref this, i_playerDesc, i_playerModule);
    // void __thiscall ClientCommunicationSystem::RecvNotice_PlayerOptionChanged(ClientCommunicationSystem*,PlayerOption)
    public void RecvNotice_PlayerOptionChanged(ACBindings.PlayerOption i_eOption) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientCommunicationSystem, ACBindings.PlayerOption, void>)0x0056F6A0)(ref this, i_eOption);
    // void __thiscall ClientCommunicationSystem::~ClientCommunicationSystem(ClientCommunicationSystem*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientCommunicationSystem, void>)0x0056F860)(ref this);
    // unsigned int __thiscall ClientCommunicationSystem::Handle_Communication__SetSquelchDB(ClientCommunicationSystem*,const SquelchDB*)
    public uint Handle_Communication__SetSquelchDB(ACBindings.SquelchDB* db) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientCommunicationSystem, ACBindings.SquelchDB*, uint>)0x0056F940)(ref this, db);
    // BOOL __stdcall ClientCommunicationSystem::IsMessageSafe(char*)
    public static byte IsMessageSafe(sbyte* String) => ((delegate* unmanaged[Stdcall]<sbyte*, byte>)0x0056FB20)(String);
    // bool __thiscall ClientCommunicationSystem::DoAllegianceHometown(ClientCommunicationSystem*,int,char**)
    public byte DoAllegianceHometown(int argc, sbyte** argv) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientCommunicationSystem, int, sbyte**, byte>)0x0056FCE0)(ref this, argc, argv);
    // bool __thiscall ClientCommunicationSystem::DoAllegianceHouse(ClientCommunicationSystem*,int,char**)
    public byte DoAllegianceHouse(int argc, sbyte** argv) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientCommunicationSystem, int, sbyte**, byte>)0x0056FD40)(ref this, argc, argv);
    // char __stdcall ClientCommunicationSystem::HelpStupidChannelHack(int,int,char**)
    public static sbyte HelpStupidChannelHack(int a1, int a2, sbyte** a3) => ((delegate* unmanaged[Stdcall]<int, int, sbyte**, sbyte>)0x00570060)(a1, a2, a3);
    // bool __thiscall ClientCommunicationSystem::DoJoinChat(ClientCommunicationSystem*,int,char**)
    public byte DoJoinChat(int argc, sbyte** argv) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientCommunicationSystem, int, sbyte**, byte>)0x005702E0)(ref this, argc, argv);
    // bool __thiscall ClientCommunicationSystem::DoLeaveChat(ClientCommunicationSystem*,int,char**)
    public byte DoLeaveChat(int argc, sbyte** argv) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientCommunicationSystem, int, sbyte**, byte>)0x005705C0)(ref this, argc, argv);
    // bool __thiscall ClientCommunicationSystem::DoChatToggle(ClientCommunicationSystem*,int,char**)
    public byte DoChatToggle(int argc, sbyte** argv) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientCommunicationSystem, int, sbyte**, byte>)0x005708A0)(ref this, argc, argv);
    // bool __thiscall ClientCommunicationSystem::DoMarketplace(ClientCommunicationSystem*,int,char**)
    public byte DoMarketplace(int argc, sbyte** argv) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientCommunicationSystem, int, sbyte**, byte>)0x00570AB0)(ref this, argc, argv);
    // bool __thiscall ClientCommunicationSystem::DoFillComponents(ClientCommunicationSystem*,int,char**)
    public byte DoFillComponents(int argc, sbyte** argv) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientCommunicationSystem, int, sbyte**, byte>)0x00570B20)(ref this, argc, argv);
    // bool __thiscall ClientCommunicationSystem::DoSaveUI(ClientCommunicationSystem*,int,char**)
    public byte DoSaveUI(int argc, sbyte** argv) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientCommunicationSystem, int, sbyte**, byte>)0x00570DC0)(ref this, argc, argv);
    // bool __thiscall ClientCommunicationSystem::DoLoadUI(ClientCommunicationSystem*,int,char**)
    public byte DoLoadUI(int argc, sbyte** argv) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientCommunicationSystem, int, sbyte**, byte>)0x00570F20)(ref this, argc, argv);
    // bool __thiscall ClientCommunicationSystem::DoSaveAutoUI(ClientCommunicationSystem*,int,char**)
    public byte DoSaveAutoUI(int argc, sbyte** argv) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientCommunicationSystem, int, sbyte**, byte>)0x00571080)(ref this, argc, argv);
    // bool __thiscall ClientCommunicationSystem::DoLoadAutoUI(ClientCommunicationSystem*,int,char**)
    public byte DoLoadAutoUI(int argc, sbyte** argv) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientCommunicationSystem, int, sbyte**, byte>)0x00571100)(ref this, argc, argv);
    // bool __thiscall ClientCommunicationSystem::DoLockUI(ClientCommunicationSystem*,int,char**)
    public byte DoLockUI(int argc, sbyte** argv) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientCommunicationSystem, int, sbyte**, byte>)0x00571180)(ref this, argc, argv);
    // bool __thiscall ClientCommunicationSystem::DoHouseRecall(ClientCommunicationSystem*,int,char**)
    public byte DoHouseRecall(int argc, sbyte** argv) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientCommunicationSystem, int, sbyte**, byte>)0x00571220)(ref this, argc, argv);
    // bool __thiscall ClientCommunicationSystem::DoMansionRecall(ClientCommunicationSystem*,int,char**)
    public byte DoMansionRecall(int argc, sbyte** argv) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientCommunicationSystem, int, sbyte**, byte>)0x00571280)(ref this, argc, argv);
    // bool __thiscall ClientCommunicationSystem::DoHouseAvailableList(ClientCommunicationSystem*,int,char**)
    public byte DoHouseAvailableList(int argc, sbyte** argv) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientCommunicationSystem, int, sbyte**, byte>)0x005712E0)(ref this, argc, argv);
    // bool __thiscall ClientCommunicationSystem::DoFrameRate(ClientCommunicationSystem*,int,char**)
    public byte DoFrameRate(int argc, sbyte** argv) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientCommunicationSystem, int, sbyte**, byte>)0x005715A0)(ref this, argc, argv);
    // unsigned int __thiscall ClientCommunicationSystem::Release(ClientCommunicationSystem*)
    public uint Release() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientCommunicationSystem, uint>)0x00571870)(ref this);
    // int __thiscall ClientCommunicationSystem::Handle_Communication__ChannelBroadcast(void*,char*,char*,int)
    public int Handle_Communication__ChannelBroadcast(sbyte* Source, sbyte* a3, int a4) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientCommunicationSystem, sbyte*, sbyte*, int, int>)0x00571960)(ref this, Source, a3, a4);
    // int __thiscall ClientCommunicationSystem::Handle_Character__QueryAgeResponse(void*,int,int*)
    public int Handle_Character__QueryAgeResponse(int a2, int* a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientCommunicationSystem, int, int*, int>)0x00571FA0)(ref this, a2, a3);
    // int __thiscall ClientCommunicationSystem::Handle_Communication__HearSpeech(void*,CLogonHeader::HandshakeWireData,unsigned int,unsigned int)
    public int Handle_Communication__HearSpeech(ACBindings.CLogonHeader.HandshakeWireData a2, uint ArgList, uint msg_type) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientCommunicationSystem, ACBindings.CLogonHeader.HandshakeWireData, uint, uint, int>)0x00572070)(ref this, a2, ArgList, msg_type);
    // int __thiscall ClientCommunicationSystem::Handle_Communication__HearDirectSpeech(void*,CLogonHeader::HandshakeWireData,unsigned int,void*,int,int)
    public int Handle_Communication__HearDirectSpeech(ACBindings.CLogonHeader.HandshakeWireData a2, uint ArgList, System.IntPtr a4, int a5, int a6) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientCommunicationSystem, ACBindings.CLogonHeader.HandshakeWireData, uint, System.IntPtr, int, int, int>)0x00572370)(ref this, a2, ArgList, a4, a5, a6);
    // LONG __thiscall ClientCommunicationSystem::HandleFailureEvent(void*,unsigned int,const wchar_t**)
    public int HandleFailureEvent(uint i_error, System.IntPtr a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientCommunicationSystem, uint, System.IntPtr, int>)0x00572760)(ref this, i_error, a3);
    // bool __thiscall ClientCommunicationSystem::DoAllegianceChat(ClientCommunicationSystem*,int,char**)
    public byte DoAllegianceChat(int argc, sbyte** argv) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientCommunicationSystem, int, sbyte**, byte>)0x00576A80)(ref this, argc, argv);
    // bool __thiscall ClientCommunicationSystem::DoAllegianceBroadcast(ClientCommunicationSystem*,int,char**)
    public byte DoAllegianceBroadcast(int argc, sbyte** argv) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientCommunicationSystem, int, sbyte**, byte>)0x00576FC0)(ref this, argc, argv);
    // bool __thiscall ClientCommunicationSystem::DoAllegianceBan(ClientCommunicationSystem*,int,char**)
    public byte DoAllegianceBan(int argc, sbyte** argv) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientCommunicationSystem, int, sbyte**, byte>)0x00577070)(ref this, argc, argv);
    // bool __thiscall ClientCommunicationSystem::DoAllegianceInfo(ClientCommunicationSystem*,int,char**)
    public byte DoAllegianceInfo(int argc, sbyte** argv) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientCommunicationSystem, int, sbyte**, byte>)0x00577330)(ref this, argc, argv);
    // bool __thiscall ClientCommunicationSystem::DoAllegianceOfficer(ClientCommunicationSystem*,const OLECHAR*,char**)
    public byte DoAllegianceOfficer(System.IntPtr argc, sbyte** argv) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientCommunicationSystem, System.IntPtr, sbyte**, byte>)0x00577420)(ref this, argc, argv);
    // bool __thiscall ClientCommunicationSystem::DoAllegianceOfficerTitle(ClientCommunicationSystem*,int,char**)
    public byte DoAllegianceOfficerTitle(int argc, sbyte** argv) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientCommunicationSystem, int, sbyte**, byte>)0x005777E0)(ref this, argc, argv);
    // bool __thiscall ClientCommunicationSystem::DoAllegianceName(ClientCommunicationSystem*,const char*,char**)
    public byte DoAllegianceName(sbyte* argc, sbyte** argv) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientCommunicationSystem, sbyte*, sbyte**, byte>)0x00577A50)(ref this, argc, argv);
    // bool __thiscall ClientCommunicationSystem::DoAllegianceLock(ClientCommunicationSystem*,int,char**)
    public byte DoAllegianceLock(int argc, sbyte** argv) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientCommunicationSystem, int, sbyte**, byte>)0x00577C40)(ref this, argc, argv);
    // bool __thiscall ClientCommunicationSystem::DoMotd(ClientCommunicationSystem*,const char*,char**)
    public byte DoMotd(sbyte* argc, sbyte** argv) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientCommunicationSystem, sbyte*, sbyte**, byte>)0x00577F20)(ref this, argc, argv);
    // char __stdcall ClientCommunicationSystem::HelpMotd(char*,int,char**)
    public static sbyte HelpMotd(sbyte* Source, int a2, sbyte** a3) => ((delegate* unmanaged[Stdcall]<sbyte*, int, sbyte**, sbyte>)0x00578100)(Source, a2, a3);
    // bool __thiscall ClientCommunicationSystem::DoChannelCommand(ClientCommunicationSystem*,int,char**)
    public byte DoChannelCommand(int argc, sbyte** argv) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientCommunicationSystem, int, sbyte**, byte>)0x00578270)(ref this, argc, argv);
    // char __thiscall ClientCommunicationSystem::HelpJoinChat(char*,int,int,char**)
    public sbyte HelpJoinChat(int a2, int a3, sbyte** a4) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientCommunicationSystem, int, int, sbyte**, sbyte>)0x00578350)(ref this, a2, a3, a4);
    // char __thiscall ClientCommunicationSystem::HelpLeaveChat(char*,int,int,char**)
    public sbyte HelpLeaveChat(int a2, int a3, sbyte** a4) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientCommunicationSystem, int, int, sbyte**, sbyte>)0x005783A0)(ref this, a2, a3, a4);
    // char __stdcall ClientCommunicationSystem::HelpReply(char*,int,char*)
    public static sbyte HelpReply(sbyte* Source, int a2, sbyte* a3) => ((delegate* unmanaged[Stdcall]<sbyte*, int, sbyte*, sbyte>)0x00578820)(Source, a2, a3);
    // bool __thiscall ClientCommunicationSystem::DoReTell(ClientCommunicationSystem*,const OLECHAR*,char**)
    public byte DoReTell(System.IntPtr argc, sbyte** argv) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientCommunicationSystem, System.IntPtr, sbyte**, byte>)0x005789A0)(ref this, argc, argv);
    // char __stdcall ClientCommunicationSystem::HelpReTell(char*,int,char**)
    public static sbyte HelpReTell(sbyte* Source, int a2, sbyte** a3) => ((delegate* unmanaged[Stdcall]<sbyte*, int, sbyte**, sbyte>)0x00578B50)(Source, a2, a3);
    // bool __thiscall ClientCommunicationSystem::DoTell(ClientCommunicationSystem*,volatile LONG*,char**)
    public byte DoTell(int* argc, sbyte** argv) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientCommunicationSystem, int*, sbyte**, byte>)0x00578C10)(ref this, argc, argv);
    // char __stdcall ClientCommunicationSystem::HelpTell(char*,int,char**)
    public static sbyte HelpTell(sbyte* Source, int a2, sbyte** a3) => ((delegate* unmanaged[Stdcall]<sbyte*, int, sbyte**, sbyte>)0x00578DD0)(Source, a2, a3);
    // char __stdcall ClientCommunicationSystem::HelpAFK(char*,int,char*)
    public static sbyte HelpAFK(sbyte* Source, int a2, sbyte* a3) => ((delegate* unmanaged[Stdcall]<sbyte*, int, sbyte*, sbyte>)0x00578E30)(Source, a2, a3);
    // char __stdcall ClientCommunicationSystem::HelpConsent(char*,int,char**)
    public static sbyte HelpConsent(sbyte* Source, int a2, sbyte** a3) => ((delegate* unmanaged[Stdcall]<sbyte*, int, sbyte**, sbyte>)0x00578F90)(Source, a2, a3);
    // bool __thiscall ClientCommunicationSystem::DoCorpse(ClientCommunicationSystem*,int,char**)
    public byte DoCorpse(int argc, sbyte** argv) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientCommunicationSystem, int, sbyte**, byte>)0x00578FF0)(ref this, argc, argv);
    // char __stdcall ClientCommunicationSystem::HelpCorpse(char*,int,char**)
    public static sbyte HelpCorpse(sbyte* Source, int a2, sbyte** a3) => ((delegate* unmanaged[Stdcall]<sbyte*, int, sbyte**, sbyte>)0x00579200)(Source, a2, a3);
    // char __stdcall ClientCommunicationSystem::HelpDie(char*,int,char**)
    public static sbyte HelpDie(sbyte* Source, int a2, sbyte** a3) => ((delegate* unmanaged[Stdcall]<sbyte*, int, sbyte**, sbyte>)0x00579270)(Source, a2, a3);
    // char __thiscall ClientCommunicationSystem::HelpLifestone(char*,int,int,char**)
    public sbyte HelpLifestone(int a2, int a3, sbyte** a4) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientCommunicationSystem, int, int, sbyte**, sbyte>)0x005792D0)(ref this, a2, a3, a4);
    // char __thiscall ClientCommunicationSystem::HelpMarketplace(char*,int,int,char**)
    public sbyte HelpMarketplace(int a2, int a3, sbyte** a4) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientCommunicationSystem, int, int, sbyte**, sbyte>)0x00579320)(ref this, a2, a3, a4);
    // bool __thiscall ClientCommunicationSystem::DoPermit(ClientCommunicationSystem*,int,char**)
    public byte DoPermit(int argc, sbyte** argv) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientCommunicationSystem, int, sbyte**, byte>)0x00579370)(ref this, argc, argv);
    // char __stdcall ClientCommunicationSystem::HelpPermit(char*,int,char**)
    public static sbyte HelpPermit(sbyte* Source, int a2, sbyte** a3) => ((delegate* unmanaged[Stdcall]<sbyte*, int, sbyte**, sbyte>)0x00579640)(Source, a2, a3);
    // char __thiscall ClientCommunicationSystem::HelpPKArena(char*,int,int,char**)
    public sbyte HelpPKArena(int a2, int a3, sbyte** a4) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientCommunicationSystem, int, int, sbyte**, sbyte>)0x00579750)(ref this, a2, a3, a4);
    // bool __thiscall ClientCommunicationSystem::DoPKLArena(ClientCommunicationSystem*,int,char**)
    public byte DoPKLArena(int argc, sbyte** argv) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientCommunicationSystem, int, sbyte**, byte>)0x005797A0)(ref this, argc, argv);
    // char __thiscall ClientCommunicationSystem::HelpPKLArena(char*,int,int,char**)
    public sbyte HelpPKLArena(int a2, int a3, sbyte** a4) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientCommunicationSystem, int, int, sbyte**, sbyte>)0x00579850)(ref this, a2, a3, a4);
    // bool __thiscall ClientCommunicationSystem::DoEmote(ClientCommunicationSystem*,int,char**)
    public byte DoEmote(int argc, sbyte** argv) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientCommunicationSystem, int, sbyte**, byte>)0x005798A0)(ref this, argc, argv);
    // char __stdcall ClientCommunicationSystem::HelpEmote(char*,int,char*)
    public static sbyte HelpEmote(sbyte* Source, int a2, sbyte* a3) => ((delegate* unmanaged[Stdcall]<sbyte*, int, sbyte*, sbyte>)0x00579950)(Source, a2, a3);
    // char __thiscall ClientCommunicationSystem::HelpEmoteList(char*,int,int,char**)
    public sbyte HelpEmoteList(int a2, int a3, sbyte** a4) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientCommunicationSystem, int, int, sbyte**, sbyte>)0x00579A30)(ref this, a2, a3, a4);
    // char __stdcall ClientCommunicationSystem::HelpFillComponents(char*,int,char**)
    public static sbyte HelpFillComponents(sbyte* Source, int a2, sbyte** a3) => ((delegate* unmanaged[Stdcall]<sbyte*, int, sbyte**, sbyte>)0x00579A80)(Source, a2, a3);
    // char __stdcall ClientCommunicationSystem::HelpSaveUI(char*,int,char**)
    public static sbyte HelpSaveUI(sbyte* Source, int a2, sbyte** a3) => ((delegate* unmanaged[Stdcall]<sbyte*, int, sbyte**, sbyte>)0x00579AF0)(Source, a2, a3);
    // char __stdcall ClientCommunicationSystem::HelpLoadUI(char*,int,char**)
    public static sbyte HelpLoadUI(sbyte* Source, int a2, sbyte** a3) => ((delegate* unmanaged[Stdcall]<sbyte*, int, sbyte**, sbyte>)0x00579B60)(Source, a2, a3);
    // char __stdcall ClientCommunicationSystem::HelpSaveAutoUI(char*,int,char**)
    public static sbyte HelpSaveAutoUI(sbyte* Source, int a2, sbyte** a3) => ((delegate* unmanaged[Stdcall]<sbyte*, int, sbyte**, sbyte>)0x00579BD0)(Source, a2, a3);
    // char __stdcall ClientCommunicationSystem::HelpLoadAutoUI(char*,int,char**)
    public static sbyte HelpLoadAutoUI(sbyte* Source, int a2, sbyte** a3) => ((delegate* unmanaged[Stdcall]<sbyte*, int, sbyte**, sbyte>)0x00579C40)(Source, a2, a3);
    // char __stdcall ClientCommunicationSystem::HelpLockUI(char*,int,char**)
    public static sbyte HelpLockUI(sbyte* Source, int a2, sbyte** a3) => ((delegate* unmanaged[Stdcall]<sbyte*, int, sbyte**, sbyte>)0x00579CB0)(Source, a2, a3);
    // bool __thiscall ClientCommunicationSystem::DoFriendsAdd(ClientCommunicationSystem*,const OLECHAR*,char**)
    public byte DoFriendsAdd(System.IntPtr argc, sbyte** argv) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientCommunicationSystem, System.IntPtr, sbyte**, byte>)0x00579D80)(ref this, argc, argv);
    // bool __thiscall ClientCommunicationSystem::DoFriendsRemove(ClientCommunicationSystem*,int,char**)
    public byte DoFriendsRemove(int argc, sbyte** argv) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientCommunicationSystem, int, sbyte**, byte>)0x00579E50)(ref this, argc, argv);
    // bool __thiscall ClientCommunicationSystem::DoHouseGuests(ClientCommunicationSystem*,int,char**)
    public byte DoHouseGuests(int argc, sbyte** argv) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientCommunicationSystem, int, sbyte**, byte>)0x00579F70)(ref this, argc, argv);
    // bool __thiscall ClientCommunicationSystem::DoHouseStorage(ClientCommunicationSystem*,int,char**)
    public byte DoHouseStorage(int argc, sbyte** argv) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientCommunicationSystem, int, sbyte**, byte>)0x0057A330)(ref this, argc, argv);
    // bool __thiscall ClientCommunicationSystem::DoHouseBoot(ClientCommunicationSystem*,int,char**)
    public byte DoHouseBoot(int argc, sbyte** argv) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientCommunicationSystem, int, sbyte**, byte>)0x0057A740)(ref this, argc, argv);
    // char __stdcall ClientCommunicationSystem::HelpHouse(char*,int,char**)
    public static sbyte HelpHouse(sbyte* Source, int a2, sbyte** a3) => ((delegate* unmanaged[Stdcall]<sbyte*, int, sbyte**, sbyte>)0x0057A8A0)(Source, a2, a3);
    // char __thiscall ClientCommunicationSystem::HelpHouseAvailableList(char*,int,int,char**)
    public sbyte HelpHouseAvailableList(int a2, int a3, sbyte** a4) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientCommunicationSystem, int, int, sbyte**, sbyte>)0x0057A910)(ref this, a2, a3, a4);
    // char __thiscall ClientCommunicationSystem::HelpAdvancedSquelch(char*,int,int,char**)
    public sbyte HelpAdvancedSquelch(int a2, int a3, sbyte** a4) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientCommunicationSystem, int, int, sbyte**, sbyte>)0x0057A960)(ref this, a2, a3, a4);
    // char __thiscall ClientCommunicationSystem::HelpAdvancedUnSquelch(char*,int,int,char**)
    public sbyte HelpAdvancedUnSquelch(int a2, int a3, sbyte** a4) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientCommunicationSystem, int, int, sbyte**, sbyte>)0x0057A9B0)(ref this, a2, a3, a4);
    // char __thiscall ClientCommunicationSystem::ProcessSquelchArgs(unsigned int*,int,int,wchar_t*,_BYTE*,void**,unsigned int*)
    public sbyte ProcessSquelchArgs(int a2, int a3, System.IntPtr Destination, byte* a5, void** a6, uint* a7) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientCommunicationSystem, int, int, System.IntPtr, byte*, void**, uint*, sbyte>)0x0057AA00)(ref this, a2, a3, Destination, a5, a6, a7);
    // bool __thiscall ClientCommunicationSystem::DoMessageTypes(ClientCommunicationSystem*,int,char**)
    public byte DoMessageTypes(int argc, sbyte** argv) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientCommunicationSystem, int, sbyte**, byte>)0x0057ADE0)(ref this, argc, argv);
    // char __thiscall ClientCommunicationSystem::HelpAge(char*,int,int,char**)
    public sbyte HelpAge(int a2, int a3, sbyte** a4) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientCommunicationSystem, int, int, sbyte**, sbyte>)0x0057AE80)(ref this, a2, a3, a4);
    // char __thiscall ClientCommunicationSystem::HelpBirth(char*,int,int,char**)
    public sbyte HelpBirth(int a2, int a3, sbyte** a4) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientCommunicationSystem, int, int, sbyte**, sbyte>)0x0057AED0)(ref this, a2, a3, a4);
    // char __thiscall ClientCommunicationSystem::HelpDay(char*,int,int,char**)
    public sbyte HelpDay(int a2, int a3, sbyte** a4) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientCommunicationSystem, int, int, sbyte**, sbyte>)0x0057AF20)(ref this, a2, a3, a4);
    // char __stdcall ClientCommunicationSystem::HelpEndurance(char*,int,char**)
    public static sbyte HelpEndurance(sbyte* Source, int a2, sbyte** a3) => ((delegate* unmanaged[Stdcall]<sbyte*, int, sbyte**, sbyte>)0x0057AF70)(Source, a2, a3);
    // char __thiscall ClientCommunicationSystem::HelpFrameRate(char*,int,int,char**)
    public sbyte HelpFrameRate(int a2, int a3, sbyte** a4) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientCommunicationSystem, int, int, sbyte**, sbyte>)0x0057AFD0)(ref this, a2, a3, a4);
    // bool __thiscall ClientCommunicationSystem::DoLoc(ClientCommunicationSystem*,int,char**)
    public byte DoLoc(int argc, sbyte** argv) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientCommunicationSystem, int, sbyte**, byte>)0x0057B020)(ref this, argc, argv);
    // char __stdcall ClientCommunicationSystem::HelpPKLite(char*,int,char**)
    public static sbyte HelpPKLite(sbyte* Source, int a2, sbyte** a3) => ((delegate* unmanaged[Stdcall]<sbyte*, int, sbyte**, sbyte>)0x0057B310)(Source, a2, a3);
    // char __thiscall ClientCommunicationSystem::HelpVersion(char*,int,int,char**)
    public sbyte HelpVersion(int a2, int a3, sbyte** a4) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientCommunicationSystem, int, int, sbyte**, sbyte>)0x0057B370)(ref this, a2, a3, a4);
    // char __thiscall ClientCommunicationSystem::HelpClear(char*,int,int,char**)
    public sbyte HelpClear(int a2, int a3, sbyte** a4) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientCommunicationSystem, int, int, sbyte**, sbyte>)0x0057B3C0)(ref this, a2, a3, a4);
    // bool __thiscall ClientCommunicationSystem::DoTitle(ClientCommunicationSystem*,int,char**)
    public byte DoTitle(int argc, sbyte** argv) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientCommunicationSystem, int, sbyte**, byte>)0x0057B410)(ref this, argc, argv);
    // char __thiscall ClientCommunicationSystem::HelpTitle(char*,int,int,char**)
    public sbyte HelpTitle(int a2, int a3, sbyte** a4) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientCommunicationSystem, int, int, sbyte**, sbyte>)0x0057B5B0)(ref this, a2, a3, a4);
    // char __stdcall ClientCommunicationSystem::HelpFilter(char*,int,char**)
    public static sbyte HelpFilter(sbyte* Source, int a2, sbyte** a3) => ((delegate* unmanaged[Stdcall]<sbyte*, int, sbyte**, sbyte>)0x0057B600)(Source, a2, a3);
    // bool __thiscall ClientCommunicationSystem::DoChannelOn(ClientCommunicationSystem*,int,char**)
    public byte DoChannelOn(int argc, sbyte** argv) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientCommunicationSystem, int, sbyte**, byte>)0x0057B850)(ref this, argc, argv);
    // bool __thiscall ClientCommunicationSystem::DoChannelOff(ClientCommunicationSystem*,int,char**)
    public byte DoChannelOff(int argc, sbyte** argv) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientCommunicationSystem, int, sbyte**, byte>)0x0057B920)(ref this, argc, argv);
    // bool __thiscall ClientCommunicationSystem::PlayerIsPSR(ClientCommunicationSystem*)
    public byte PlayerIsPSR() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientCommunicationSystem, byte>)0x0057B9F0)(ref this);
    // bool __thiscall ClientCommunicationSystem::CloseLogFile(ClientCommunicationSystem*)
    public byte CloseLogFile() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientCommunicationSystem, byte>)0x0057BA90)(ref this);
    // void __thiscall ClientCommunicationSystem::OnShutdown(ClientCommunicationSystem*)
    public void OnShutdown() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientCommunicationSystem, void>)0x0057BBA0)(ref this);
    // unsigned int __thiscall ClientCommunicationSystem::Handle_Communication__WeenieError(ClientCommunicationSystem*,unsigned int)
    public uint Handle_Communication__WeenieError(uint etype) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientCommunicationSystem, uint, uint>)0x0057BBC0)(ref this, etype);
    // char __stdcall ClientCommunicationSystem::HelpAllegiance(char*,int,char*)
    public static sbyte HelpAllegiance(sbyte* Source, int a2, sbyte* a3) => ((delegate* unmanaged[Stdcall]<sbyte*, int, sbyte*, sbyte>)0x0057BBE0)(Source, a2, a3);
    // bool __thiscall ClientCommunicationSystem::DoAllegianceBoot(ClientCommunicationSystem*,const char*,char**)
    public byte DoAllegianceBoot(sbyte* argc, sbyte** argv) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientCommunicationSystem, sbyte*, sbyte**, byte>)0x0057BCC0)(ref this, argc, argv);
    // char __stdcall ClientCommunicationSystem::HelpChattingGroup(char*,int,char*)
    public static sbyte HelpChattingGroup(sbyte* Source, int a2, sbyte* a3) => ((delegate* unmanaged[Stdcall]<sbyte*, int, sbyte*, sbyte>)0x0057BF70)(Source, a2, a3);
    // bool __thiscall ClientCommunicationSystem::DoAFK(ClientCommunicationSystem*,volatile LONG*,char**)
    public byte DoAFK(int* argc, sbyte** argv) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientCommunicationSystem, int*, sbyte**, byte>)0x0057C1C0)(ref this, argc, argv);
    // char __thiscall ClientCommunicationSystem::HelpDeathGroup(char*,char*,int,char*)
    public sbyte HelpDeathGroup(sbyte* Source, int a3, sbyte* a4) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientCommunicationSystem, sbyte*, int, sbyte*, sbyte>)0x0057C680)(ref this, Source, a3, a4);
    // void __cdecl ClientCommunicationSystem::DieDialogCallback(const PropertyCollection*)
    public static void DieDialogCallback(ACBindings.PropertyCollection* i_rcResults) => ((delegate* unmanaged[Cdecl]<ACBindings.PropertyCollection*, void>)0x0057C840)(i_rcResults);
    // bool __thiscall ClientCommunicationSystem::DoEmoteList(ClientCommunicationSystem*,int,char**)
    public byte DoEmoteList(int argc, sbyte** argv) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientCommunicationSystem, int, sbyte**, byte>)0x0057C900)(ref this, argc, argv);
    // bool __thiscall ClientCommunicationSystem::DoFriends(ClientCommunicationSystem*,int,char**)
    public byte DoFriends(int argc, sbyte** argv) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientCommunicationSystem, int, sbyte**, byte>)0x0057C9D0)(ref this, argc, argv);
    // void __cdecl ClientCommunicationSystem::HouseAbandonDialogCallback_Second(const PropertyCollection*)
    public static void HouseAbandonDialogCallback_Second(ACBindings.PropertyCollection* i_rcResults) => ((delegate* unmanaged[Cdecl]<ACBindings.PropertyCollection*, void>)0x0057CC60)(i_rcResults);
    // bool __thiscall ClientCommunicationSystem::DoSquelch(ClientCommunicationSystem*,int,char**)
    public byte DoSquelch(int argc, sbyte** argv) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientCommunicationSystem, int, sbyte**, byte>)0x0057CD20)(ref this, argc, argv);
    // bool __thiscall ClientCommunicationSystem::DoUnSquelch(ClientCommunicationSystem*,int,char**)
    public byte DoUnSquelch(int argc, sbyte** argv) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientCommunicationSystem, int, sbyte**, byte>)0x0057CE40)(ref this, argc, argv);
    // char __thiscall ClientCommunicationSystem::HelpSquelch(char*,char*,int,char*)
    public sbyte HelpSquelch(sbyte* Source, int a3, sbyte* a4) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientCommunicationSystem, sbyte*, int, sbyte*, sbyte>)0x0057CF60)(ref this, Source, a3, a4);
    // bool __thiscall ClientCommunicationSystem::PerformGlobalSquelchMod(ClientCommunicationSystem*,int,char**,bool)
    public byte PerformGlobalSquelchMod(int argc, sbyte** argv, byte add) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientCommunicationSystem, int, sbyte**, byte, byte>)0x0057D0A0)(ref this, argc, argv, add);
    // char __thiscall ClientCommunicationSystem::HelpStatusGroup(char*,char*,int,char*)
    public sbyte HelpStatusGroup(sbyte* Source, int a3, sbyte* a4) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientCommunicationSystem, sbyte*, int, sbyte*, sbyte>)0x0057D1E0)(ref this, Source, a3, a4);
    // bool __thiscall ClientCommunicationSystem::DoAge(ClientCommunicationSystem*,int,char**)
    public byte DoAge(int argc, sbyte** argv) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientCommunicationSystem, int, sbyte**, byte>)0x0057D370)(ref this, argc, argv);
    // bool __thiscall ClientCommunicationSystem::DoEndurance(ClientCommunicationSystem*,int,char**)
    public byte DoEndurance(int argc, sbyte** argv) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientCommunicationSystem, int, sbyte**, byte>)0x0057D3C0)(ref this, argc, argv);
    // char __thiscall ClientCommunicationSystem::HelpTextGroup(char*,char*,int,char*)
    public sbyte HelpTextGroup(sbyte* Source, int a3, sbyte* a4) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientCommunicationSystem, sbyte*, int, sbyte*, sbyte>)0x0057D490)(ref this, Source, a3, a4);
    // bool __thiscall ClientCommunicationSystem::DoFilter(ClientCommunicationSystem*,int,char**)
    public byte DoFilter(int argc, sbyte** argv) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientCommunicationSystem, int, sbyte**, byte>)0x0057D630)(ref this, argc, argv);
    // bool __thiscall ClientCommunicationSystem::DoUnFilter(ClientCommunicationSystem*,int,char**)
    public byte DoUnFilter(int argc, sbyte** argv) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientCommunicationSystem, int, sbyte**, byte>)0x0057D650)(ref this, argc, argv);
    // BOOL __thiscall ClientCommunicationSystem::StartCopyOutputToFile(ClientCommunicationSystem*,const char**)
    public byte StartCopyOutputToFile(sbyte** a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientCommunicationSystem, sbyte**, byte>)0x0057D670)(ref this, a2);
    // void __thiscall ClientCommunicationSystem::OnQualityChanged(ClientCommunicationSystem*,CWeenieObject*,StatType,unsigned int)
    public void OnQualityChanged(ACBindings.CWeenieObject* cwobj, ACBindings.StatType stype, uint senum) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientCommunicationSystem, ACBindings.CWeenieObject*, ACBindings.StatType, uint, void>)0x0057D910)(ref this, cwobj, stype, senum);
    // int __thiscall ClientCommunicationSystem::Handle_Communication__WeenieErrorWithString(void*,unsigned int,int)
    public int Handle_Communication__WeenieErrorWithString(uint a2, int a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientCommunicationSystem, uint, int, int>)0x0057D960)(ref this, a2, a3);
    // int __thiscall ClientCommunicationSystem::Handle_Communication__HearEmote(void*,unsigned int,const char*,int)
    public int Handle_Communication__HearEmote(uint iid, sbyte* a3, int a4) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientCommunicationSystem, uint, sbyte*, int, int>)0x0057D9B0)(ref this, iid, a3, a4);
    // int __thiscall ClientCommunicationSystem::Handle_Communication__HearSoulEmote(void*,unsigned int,volatile LONG*,int)
    public int Handle_Communication__HearSoulEmote(uint a2, int* a3, int a4) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientCommunicationSystem, uint, int*, int, int>)0x0057DDF0)(ref this, a2, a3, a4);
    // int __thiscall ClientCommunicationSystem::Handle_Communication__ChannelIndex(void*,int)
    public int Handle_Communication__ChannelIndex(int a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientCommunicationSystem, int, int>)0x0057DE90)(ref this, a2);
    // int __thiscall ClientCommunicationSystem::Handle_Communication__ChannelList(void*,int)
    public int Handle_Communication__ChannelList(int a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientCommunicationSystem, int, int>)0x0057E000)(ref this, a2);
    // int __thiscall ClientCommunicationSystem::Handle_Communication__TransientString(void*,int)
    public int Handle_Communication__TransientString(int a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientCommunicationSystem, int, int>)0x0057E170)(ref this, a2);
    // char __stdcall ClientCommunicationSystem::HelpAllegiancesGroup(char*,int,char*)
    public static sbyte HelpAllegiancesGroup(sbyte* Source, int a2, sbyte* a3) => ((delegate* unmanaged[Stdcall]<sbyte*, int, sbyte*, sbyte>)0x0057E1D0)(Source, a2, a3);
    // bool __thiscall ClientCommunicationSystem::DoAllegiance(ClientCommunicationSystem*,int,char**)
    public byte DoAllegiance(int argc, sbyte** argv) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientCommunicationSystem, int, sbyte**, byte>)0x0057E2B0)(ref this, argc, argv);
    // bool __thiscall ClientCommunicationSystem::DoSpeaker(ClientCommunicationSystem*,int,char**)
    public byte DoSpeaker(int argc, sbyte** argv) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientCommunicationSystem, int, sbyte**, byte>)0x0057E7C0)(ref this, argc, argv);
    // char __thiscall ClientCommunicationSystem::SendTurbineChat(ClientCommunicationSystem*,int,CLogonHeader::HandshakeWireData,int)
    public sbyte SendTurbineChat(int a2, ACBindings.CLogonHeader.HandshakeWireData a3, int a4) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientCommunicationSystem, int, ACBindings.CLogonHeader.HandshakeWireData, int, sbyte>)0x0057E820)(ref this, a2, a3, a4);
    // bool __thiscall ClientCommunicationSystem::DoConsent(ClientCommunicationSystem*,int,char**)
    public byte DoConsent(int argc, sbyte** argv) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientCommunicationSystem, int, sbyte**, byte>)0x0057EAB0)(ref this, argc, argv);
    // bool __thiscall ClientCommunicationSystem::DoRenderOption(ClientCommunicationSystem*,int,char**)
    public byte DoRenderOption(int argc, sbyte** argv) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientCommunicationSystem, int, sbyte**, byte>)0x0057EE30)(ref this, argc, argv);
    // bool __thiscall ClientCommunicationSystem::DoVersion(ClientCommunicationSystem*,int,char**)
    public byte DoVersion(int argc, sbyte** argv) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientCommunicationSystem, int, sbyte**, byte>)0x0057EEC0)(ref this, argc, argv);
    // bool __thiscall ClientCommunicationSystem::DoCommand(ClientCommunicationSystem*)
    public byte DoCommand() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientCommunicationSystem, byte>)0x0057EFF0)(ref this);
    // bool __thiscall ClientCommunicationSystem::DoSetOutput(ClientCommunicationSystem*,const OLECHAR*,char**)
    public byte DoSetOutput(System.IntPtr argc, sbyte** argv) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientCommunicationSystem, System.IntPtr, sbyte**, byte>)0x0057F200)(ref this, argc, argv);
    // LONG __thiscall ClientCommunicationSystem::RecvNotice_DisplayWeenieError(char*,unsigned int,int)
    public int RecvNotice_DisplayWeenieError(uint a2, int a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientCommunicationSystem, uint, int, int>)0x0057F410)(ref this, a2, a3);
    // char __thiscall ClientCommunicationSystem::HelpAllGroup(char*,char*,int,char*)
    public sbyte HelpAllGroup(sbyte* Source, int a3, sbyte* a4) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientCommunicationSystem, sbyte*, int, sbyte*, sbyte>)0x0057F500)(ref this, Source, a3, a4);
    // bool __thiscall ClientCommunicationSystem::DoTurbineChat_Allegiance(ClientCommunicationSystem*,int,char**)
    public byte DoTurbineChat_Allegiance(int argc, sbyte** argv) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientCommunicationSystem, int, sbyte**, byte>)0x0057F8B0)(ref this, argc, argv);
    // bool __thiscall ClientCommunicationSystem::DoTurbineChat_General(ClientCommunicationSystem*,int,char**)
    public byte DoTurbineChat_General(int argc, sbyte** argv) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientCommunicationSystem, int, sbyte**, byte>)0x0057F960)(ref this, argc, argv);
    // bool __thiscall ClientCommunicationSystem::DoTurbineChat_Trade(ClientCommunicationSystem*,int,char**)
    public byte DoTurbineChat_Trade(int argc, sbyte** argv) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientCommunicationSystem, int, sbyte**, byte>)0x0057F9F0)(ref this, argc, argv);
    // bool __thiscall ClientCommunicationSystem::DoTurbineChat_LFG(ClientCommunicationSystem*,int,char**)
    public byte DoTurbineChat_LFG(int argc, sbyte** argv) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientCommunicationSystem, int, sbyte**, byte>)0x0057FA80)(ref this, argc, argv);
    // bool __thiscall ClientCommunicationSystem::DoTurbineChat_Roleplay(ClientCommunicationSystem*,int,char**)
    public byte DoTurbineChat_Roleplay(int argc, sbyte** argv) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientCommunicationSystem, int, sbyte**, byte>)0x0057FB10)(ref this, argc, argv);
    // bool __thiscall ClientCommunicationSystem::DoTurbineChat_Olthoi(ClientCommunicationSystem*,int,char**)
    public byte DoTurbineChat_Olthoi(int argc, sbyte** argv) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientCommunicationSystem, int, sbyte**, byte>)0x0057FBA0)(ref this, argc, argv);
    // bool __thiscall ClientCommunicationSystem::DoTurbineChat_Society(ClientCommunicationSystem*,int,char**)
    public byte DoTurbineChat_Society(int argc, sbyte** argv) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientCommunicationSystem, int, sbyte**, byte>)0x0057FC30)(ref this, argc, argv);
    // bool __thiscall ClientCommunicationSystem::StartupTurbineChatSystem(ClientCommunicationSystem*)
    public byte StartupTurbineChatSystem() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientCommunicationSystem, byte>)0x0057FCC0)(ref this);
    // bool __thiscall ClientCommunicationSystem::DoHelp(ClientCommunicationSystem*,int,char**)
    public byte DoHelp(int argc, sbyte** argv) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientCommunicationSystem, int, sbyte**, byte>)0x005806F0)(ref this, argc, argv);
    // int __stdcall ClientCommunicationSystem::Handle_Communication__PopUpString(int)
    public static int Handle_Communication__PopUpString(int a1) => ((delegate* unmanaged[Stdcall]<int, int>)0x00580B90)(a1);
    // bool __thiscall ClientCommunicationSystem::DoDie(ClientCommunicationSystem*,int,char**)
    public byte DoDie(int argc, sbyte** argv) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientCommunicationSystem, int, sbyte**, byte>)0x00580D60)(ref this, argc, argv);
    // void __cdecl ClientCommunicationSystem::HouseAbandonDialogCallback_First(const PropertyCollection*)
    public static void HouseAbandonDialogCallback_First(ACBindings.PropertyCollection* i_rcResults) => ((delegate* unmanaged[Cdecl]<ACBindings.PropertyCollection*, void>)0x00580F50)(i_rcResults);
    // char __thiscall ClientCommunicationSystem::Pose(void*,const char**)
    public sbyte Pose(sbyte** a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientCommunicationSystem, sbyte**, sbyte>)0x00581190)(ref this, a2);
    // LONG __stdcall ClientCommunicationSystem::MakeLoadFileVariableSubstitutions(const char**)
    public static int MakeLoadFileVariableSubstitutions(sbyte** a1) => ((delegate* unmanaged[Stdcall]<sbyte**, int>)0x00581450)(a1);
    // int __thiscall ClientCommunicationSystem::Handle_Communication__TextboxString(ClientSystem*,int,unsigned int)
    public int Handle_Communication__TextboxString(int a2, uint i_ltt) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientCommunicationSystem, int, uint, int>)0x00581570)(ref this, a2, i_ltt);
    // bool __thiscall ClientCommunicationSystem::DoHouse(ClientCommunicationSystem*,int,char**)
    public byte DoHouse(int argc, sbyte** argv) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientCommunicationSystem, int, sbyte**, byte>)0x005816E0)(ref this, argc, argv);
    // LONG __thiscall ClientCommunicationSystem::RemoveTextBetween(void*,int,char,char)
    public int RemoveTextBetween(int a2, sbyte a3, sbyte a4) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientCommunicationSystem, int, sbyte, sbyte, int>)0x00581E50)(ref this, a2, a3, a4);
    // char* __thiscall ClientCommunicationSystem::PublicChat(void*,int)
    public sbyte* PublicChat(int a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientCommunicationSystem, int, sbyte*>)0x00581F70)(ref this, a2);
    // bool __thiscall ClientCommunicationSystem::DoSay(ClientCommunicationSystem*,const OLECHAR*,char**)
    public byte DoSay(System.IntPtr argc, sbyte** argv) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientCommunicationSystem, System.IntPtr, sbyte**, byte>)0x005820C0)(ref this, argc, argv);
    // bool __thiscall ClientCommunicationSystem::OnChatCommand(ClientCommunicationSystem*,CLogonHeader::HandshakeWireData)
    public byte OnChatCommand(ACBindings.CLogonHeader.HandshakeWireData a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientCommunicationSystem, ACBindings.CLogonHeader.HandshakeWireData, byte>)0x005821A0)(ref this, a2);
    // char __thiscall ClientCommunicationSystem::LoadFile(ClientCommunicationSystem*,const char**)
    public sbyte LoadFile(sbyte** a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientCommunicationSystem, sbyte**, sbyte>)0x00582590)(ref this, a2);
    // bool __thiscall ClientCommunicationSystem::DoLoadFile(ClientCommunicationSystem*,int,char**)
    public byte DoLoadFile(int argc, sbyte** argv) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientCommunicationSystem, int, sbyte**, byte>)0x005826F0)(ref this, argc, argv);
    // void __thiscall ClientCommunicationSystem::InitializeCommands(ClientCommunicationSystem*)
    public void InitializeCommands() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientCommunicationSystem, void>)0x005827F0)(ref this);
    // void __thiscall ClientCommunicationSystem::ClientCommunicationSystem(ClientCommunicationSystem*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientCommunicationSystem, void>)0x005863A0)(ref this);
}

