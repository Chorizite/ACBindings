namespace ACBindings;

// gmClient
public unsafe struct gmClient : System.IDisposable
{
    // Base Classes
    public ACBindings.Client BaseClass_Client; // ACBindings.Client
    public ACBindings.NoticeHandler BaseClass_NoticeHandler; // ACBindings.NoticeHandler

    // Statics
    public static uint* sm_nFontFace = (uint*)0x0081820C;
    public static uint* sm_nFontSize = (uint*)0x00818210;

    // Child Types
    // gmClient_vtbl
    public unsafe struct gmClient_vtbl
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
        public System.IntPtr InitKeymap;

        // Methods
    }

    // Members
    public ACBindings.PStringBase__sbyte m_startChar;
    public ACBindings.PStringBase__sbyte m_createChar;
    public ACBindings.PStringBase__sbyte m_strKeymapFile;
    public byte m_bKeymapLoaded;
    public ACBindings.PStringBase__sbyte m_strZoneTicket;
    public ACBindings.PStringBase__sbyte m_strGLSTicket;
    public ACBindings.PStringBase__ushort m_wstrMigrationURL;
    public ACBindings.PStringBase__sbyte m_strVGPassword;

    // Generated Constructor
    public gmClient() {
        _ConstructorInternal();
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods
    // void __thiscall gmClient::OnDDDEvent(gmClient*,DDDEvent,unsigned int)
    public void OnDDDEvent(ACBindings.DDDEvent evtNum, uint nBytes) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmClient, ACBindings.DDDEvent, uint, void>)0x00401790)(ref this, evtNum, nBytes);
    // bool __thiscall gmClient::UseTime(gmClient*)
    public byte UseTime() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmClient, byte>)0x004017C0)(ref this);
    // void __thiscall gmClient::DetachUIPreferences(gmClient*)
    public void DetachUIPreferences() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmClient, void>)0x004017E0)(ref this);
    // void __cdecl gmClient::GRPCallback_OnFontPreferenceChanged()
    public static void GRPCallback_OnFontPreferenceChanged() => ((delegate* unmanaged[Cdecl]<void>)0x00401900)();
    // void __thiscall gmClient::~gmClient(gmClient*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmClient, void>)0x00401C50)(ref this);
    // void __thiscall gmClient::Cleanup(gmClient*)
    public void Cleanup() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmClient, void>)0x00401EC0)(ref this);
    // NetError* __thiscall gmClient::Connect(gmClient*,NetError*)
    public ACBindings.NetError* Connect(ACBindings.NetError* result) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmClient, ACBindings.NetError*, ACBindings.NetError*>)0x00402000)(ref this, result);
    // LONG __thiscall gmClient::SetKeyMapFileName(_DWORD*,int*)
    public int SetKeyMapFileName(int* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmClient, int*, int>)0x00402020)(ref this, a2);
    // void __thiscall gmClient::gmClient(gmClient*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmClient, void>)0x00402810)(ref this);
    // void __thiscall gmClient::BuildCommandLineArgs(gmClient*,ArgumentParser::CommandLineArgList*)
    public void BuildCommandLineArgs(ACBindings.ArgumentParser.CommandLineArgList* Args) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmClient, ACBindings.ArgumentParser.CommandLineArgList*, void>)0x00402A90)(ref this, Args);
    // char __thiscall gmClient::EvaluateCommandLineArg(int,const char**,const char*)
    public sbyte EvaluateCommandLineArg(sbyte** Type, sbyte* a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmClient, sbyte**, sbyte*, sbyte>)0x00402DF0)(ref this, Type, a3);
    // char __thiscall gmClient::OnCommandLineEvaluationDone(gmClient*)
    public sbyte OnCommandLineEvaluationDone() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmClient, sbyte>)0x00402F60)(ref this);
    // char __thiscall gmClient::InitKeymap(int,int*)
    public sbyte InitKeymap(int* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmClient, int*, sbyte>)0x00402FE0)(ref this, a2);
    // bool __thiscall gmClient::InitPreferences(gmClient*)
    public byte InitPreferences() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmClient, byte>)0x00403170)(ref this);
    // bool __thiscall gmClient::InitAuth(gmClient*)
    public byte InitAuth() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmClient, byte>)0x00403270)(ref this);
    // void __thiscall gmClient::InitUIPreferences(gmClient*)
    public void InitUIPreferences() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmClient, void>)0x004037B0)(ref this);
    // bool __thiscall gmClient::Init(gmClient*,int,int,int)
    public byte Init(int a2, int a3, int a4) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmClient, int, int, int, byte>)0x004049A0)(ref this, a2, a3, a4);
    // LONG __thiscall gmClient::RecvNotice_WorldName(_DWORD*,int)
    public int RecvNotice_WorldName(int a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmClient, int, int>)0x00404AE0)(ref this, a2);
}

