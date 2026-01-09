namespace ACBindings;

// Client
public unsafe struct Client : System.IDisposable
{
    // Base Classes
    public ACBindings.Interface BaseClass_Interface; // ACBindings.Interface
    public ACBindings.ArgumentParser BaseClass_ArgumentParser; // ACBindings.ArgumentParser
    public ACBindings.CDDDStatusPlugin BaseClass_CDDDStatusPlugin; // ACBindings.CDDDStatusPlugin
    public ACBindings.IInputActionCallback BaseClass_IInputActionCallback; // ACBindings.IInputActionCallback
    public ACBindings.LinkStatusHolder BaseClass_LinkStatusHolder; // ACBindings.LinkStatusHolder

    // Statics
    public static ACBindings.Client* m_instance = (ACBindings.Client*)0x008379E4;

    // Child Types
    // Client_vtbl
    public unsafe struct Client_vtbl
    {
        // Members
        public System.IntPtr IUnknown_QueryInterface; // function pointer
        public System.IntPtr IUnknown_AddRef; // function pointer
        public System.IntPtr IUnknown_Release; // function pointer
        public System.IntPtr QueryInterface; // function pointer
        public System.IntPtr AddRef; // function pointer
        public System.IntPtr Release; // function pointer
        public System.IntPtr You_Must_Not_Have_Multiple_Implementations_Of_AddRef_In_A_Hierarchy; // function pointer
        public System.IntPtr Init;
        public System.IntPtr Cleanup; // function pointer
        public System.IntPtr Connect; // function pointer
        public System.IntPtr Disconnect; // function pointer
        public System.IntPtr Run; // function pointer
        public System.IntPtr UseTime; // function pointer
        public System.IntPtr GetAccountName; // function pointer
        public System.IntPtr SetAccountName; // function pointer
        public System.IntPtr GetHostName;
        public System.IntPtr SetHostName;
        public System.IntPtr GetPort; // function pointer
        public System.IntPtr SetPortA; // function pointer
        public System.IntPtr GetLanguage; // function pointer
        public System.IntPtr SetLanguage;
        public System.IntPtr GetWorldName;
        public System.IntPtr SetWorldName;
        public System.IntPtr AddDDDStatusPlugin; // function pointer
        public System.IntPtr RemoveDDDStatusPlugin; // function pointer
        public System.IntPtr GetNameRuleLanguage; // function pointer
        public System.IntPtr InitPreferences; // function pointer
        public System.IntPtr CleanupPreferences; // function pointer
        public System.IntPtr InitNet; // function pointer
        public System.IntPtr InitDatabase; // function pointer
        public System.IntPtr InitAuth; // function pointer
        public System.IntPtr InitUI;
        public System.IntPtr IsAlreadyRunning; // function pointer
        public System.IntPtr CleanupUI; // function pointer
        public System.IntPtr CleanupDatabase; // function pointer
        public System.IntPtr CleanupNet; // function pointer

        // Methods
    }
    // Client::Enum18
    public enum Enum18 : uint
    {
    }
    // Client::Enum4
    public enum Enum4 : uint
    {
    }
    // Client::Enum5
    public enum Enum5 : uint
    {
    }
    // Client::Enum6
    public enum Enum6 : uint
    {
    }

    // Members
    public ACBindings.Turbine_RefCount m_cTurbineRefCount;
    public ACBindings.PStringBase__sbyte m_FullOutputText;
    public ACBindings.PStringBase__sbyte m_preferencesFile;
    public int m_fWindowed;
    public int m_fUseMemoryManager;
    public int m_fReadOnlyDatFiles;
    public ACBindings.accountID m_account;
    public ACBindings.PStringBase__sbyte m_pPrimer;
    public ACBindings.PStringBase__sbyte m_LanguageStr;
    public ACBindings.PStringBase__sbyte m_hostName;
    public int m_noflowqueue;
    public int m_port;
    public int m_clientPort;
    public int m_latencyDelay;
    public int m_latencyPercent;
    public int m_Language;
    public ACBindings.PStringBase__ushort m_worldName;
    public ACBindings.CLCache* m_pDBCache;
    public ACBindings.UIFlow* m_ui;
    public byte m_connected;
    public ACBindings.NetAuthenticator m_netAuth;
    public ACBindings.ClientNet* m_net;
    public ACBindings.GlobalEventHandler* m_eventHandler;
    public ACBindings.QualityRegistrar* m_qualityRegistrar;
    public ACBindings.PStringBase__sbyte m_strPreferenceBindInterface;
    public byte m_bPreferenceComputeUniquePort;
    public uint m_nPreferenceUserSpecifiedPort;
    public ACBindings.IQueuedUIEventDeliverer* m_UIQueueManager;
    public ACBindings.NetAuthenticator* pNetAuth_;
    public ACBindings.SmartBox* smartbox_;
    public System.IntPtr m_logonEventQueue;
    public ACBindings.PacketController* packControl_;
    public System.IntPtr netQueues_;
    public ACBindings.AlreadyRunningCheck m_running_check;

    // Generated Constructor
    public Client() {
        _ConstructorInternal();
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods
    // accountID* __thiscall Client::GetAccountName(Client*)
    public ACBindings.accountID* GetAccountName() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Client, ACBindings.accountID*>)0x00401D90)(ref this);
    // char* __thiscall Client::GetHostName(char*)
    public sbyte* GetHostName() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Client, sbyte*>)0x00401DA0)(ref this);
    // void __thiscall Client::SetPortA(PlayerModule*,unsigned int)
    public void SetPortA(uint filters) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Client, uint, void>)0x00401DC0)(ref this, filters);
    // char* __thiscall Client::GetWorldName(char*)
    public sbyte* GetWorldName() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Client, sbyte*>)0x00401DD0)(ref this);
    // TResult* __thiscall Client::QueryInterface(Client*,TResult*,const Turbine_GUID*,void**)
    public ACBindings.TResult* QueryInterface(ACBindings.TResult* result, ACBindings.Turbine_GUID* i_rcInterface, void** o_ppObject) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Client, ACBindings.TResult*, ACBindings.Turbine_GUID*, void**, ACBindings.TResult*>)0x00401E00)(ref this, result, i_rcInterface, o_ppObject);
    // LONG __thiscall Client::AddRef(Client*)
    public int AddRef() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Client, int>)0x00401E60)(ref this);
    // unsigned int __thiscall Client::Release(Client*)
    public uint Release() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Client, uint>)0x00401E70)(ref this);
    // LONG __thiscall Client::SetHostName(_DWORD*,int*)
    public int SetHostName(int* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Client, int*, int>)0x004021E0)(ref this, a2);
    // LONG __thiscall Client::SetWorldName(_DWORD*,int*)
    public int SetWorldName(int* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Client, int*, int>)0x00402230)(ref this, a2);
    // void __thiscall Client::SetAccountName(Client*,const accountID*)
    public void SetAccountName(ACBindings.accountID* account) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Client, ACBindings.accountID*, void>)0x00403490)(ref this, account);
    // Client* __cdecl Client::GetInstance()
    public static ACBindings.Client* GetInstance() => ((delegate* unmanaged[Cdecl]<ACBindings.Client*>)0x004114C0)();
    // void __thiscall Client::CleanupUI(Client*)
    public void CleanupUI() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Client, void>)0x004114D0)(ref this);
    // void __thiscall Client::CleanupDatabase(Client*)
    public void CleanupDatabase() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Client, void>)0x00411560)(ref this);
    // void __thiscall Client::CleanupPreferences(Client*)
    public void CleanupPreferences() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Client, void>)0x004115A0)(ref this);
    // bool __thiscall Client::InitAuth(Client*)
    public byte InitAuth() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Client, byte>)0x004115D0)(ref this);
    // bool __thiscall Client::Disconnect(Client*)
    public byte Disconnect() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Client, byte>)0x004115F0)(ref this);
    // void __thiscall Client::KeepUIAlive(Client*)
    public void KeepUIAlive() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Client, void>)0x00411630)(ref this);
    // int __thiscall Client::GetCharactersToWrapUsageTo(Client*)
    public int GetCharactersToWrapUsageTo() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Client, int>)0x004116A0)(ref this);
    // unsigned int __thiscall Client::GetNameRuleLanguage(Client*)
    public uint GetNameRuleLanguage() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Client, uint>)0x004116B0)(ref this);
    // void __thiscall Client::Cleanup(Client*)
    public void Cleanup() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Client, void>)0x004118D0)(ref this);
    // int __thiscall Client::GetLanguage(Client*)
    public int GetLanguage() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Client, int>)0x00411980)(ref this);
    // char __thiscall Client::InitUI(_DWORD*,const char**)
    public sbyte InitUI(sbyte** a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Client, sbyte**, sbyte>)0x004119C0)(ref this, a2);
    // int __thiscall Client::AddNetQueue(Client*,__int16)
    public int AddNetQueue(short queueID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Client, short, int>)0x00411AA0)(ref this, queueID);
    // bool __thiscall Client::Run(Client*)
    public byte Run() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Client, byte>)0x00411B10)(ref this);
    // LONG __thiscall Client::SetLanguage(_DWORD*,int*)
    public int SetLanguage(int* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Client, int*, int>)0x00411B50)(ref this, a2);
    // void __thiscall Client::OnDDDEvent(Client*,DDDEvent,unsigned int)
    public void OnDDDEvent(ACBindings.DDDEvent evtNum, uint nBytes) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Client, ACBindings.DDDEvent, uint, void>)0x00411BA0)(ref this, evtNum, nBytes);
    // void __thiscall Client::ProcessLogonEventQueue(Client*)
    public void ProcessLogonEventQueue() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Client, void>)0x00411C20)(ref this);
    // bool __thiscall Client::InitNet(Client*)
    public byte InitNet() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Client, byte>)0x00411E80)(ref this);
    // bool __thiscall Client::UseTime(Client*)
    public byte UseTime() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Client, byte>)0x00411FA0)(ref this);
    // void __thiscall Client::CleanupNet(Client*)
    public void CleanupNet() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Client, void>)0x00412060)(ref this);
    // bool __thiscall Client::Init(_DWORD*,int,int,int)
    public byte Init(int a2, int a3, int a4) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Client, int, int, int, byte>)0x00412180)(ref this, a2, a3, a4);
    // bool __thiscall Client::IsAlreadyRunning(Client*)
    public byte IsAlreadyRunning() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Client, byte>)0x004122A0)(ref this);
    // bool __thiscall Client::InitPreferences(Client*)
    public byte InitPreferences() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Client, byte>)0x00412310)(ref this);
    // void __thiscall Client::BuildCommandLineArgs(Client*,ArgumentParser::CommandLineArgList*)
    public void BuildCommandLineArgs(ACBindings.ArgumentParser.CommandLineArgList* Args) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Client, ACBindings.ArgumentParser.CommandLineArgList*, void>)0x00412420)(ref this, Args);
    // char __thiscall Client::EvaluateCommandLineArg(int*,_DWORD*,const char*)
    public sbyte EvaluateCommandLineArg(int* a2, sbyte* a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Client, int*, sbyte*, sbyte>)0x00412850)(ref this, a2, a3);
    // void __thiscall Client::FinishOutputText(Client*)
    public void FinishOutputText() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Client, void>)0x00412A80)(ref this);
    // bool __thiscall Client::RemoveDDDStatusPlugin(Client*,CDDDStatusPlugin*)
    public byte RemoveDDDStatusPlugin(ACBindings.CDDDStatusPlugin* i_pPlugin) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Client, ACBindings.CDDDStatusPlugin*, byte>)0x00412AC0)(ref this, i_pPlugin);
    // void __thiscall Client::~Client(Client*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Client, void>)0x00412B70)(ref this);
    // void __thiscall Client::AppendOutputText(Client*,const char*,ArgumentParser::OutputTextType)
    public void AppendOutputText(sbyte* Text, ACBindings.ArgumentParser.OutputTextType i_eFormattingHint) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Client, sbyte*, ACBindings.ArgumentParser.OutputTextType, void>)0x00412DA0)(ref this, Text, i_eFormattingHint);
    // void __thiscall Client::Client(Client*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Client, void>)0x00412E50)(ref this);
    // bool __thiscall Client::InitDatabase(Client*,const int,const int,bool)
    public byte InitDatabase(int language_i, int region_i, byte open_readonly) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Client, int, int, byte, byte>)0x00413070)(ref this, language_i, region_i, open_readonly);
    // NetError* __thiscall Client::Connect(Client*,NetError*)
    public ACBindings.NetError* Connect(ACBindings.NetError* result) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Client, ACBindings.NetError*, ACBindings.NetError*>)0x00413180)(ref this, result);
    // bool __thiscall Client::AddDDDStatusPlugin(Client*,CDDDStatusPlugin*)
    public byte AddDDDStatusPlugin(ACBindings.CDDDStatusPlugin* i_pPlugin) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Client, ACBindings.CDDDStatusPlugin*, byte>)0x00413450)(ref this, i_pPlugin);
}

