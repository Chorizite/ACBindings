namespace ACBindings.Internal;

public unsafe struct gmClient : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.Client BaseClass_Client; // ACBindings.Internal.Client
    public ACBindings.Internal.NoticeHandler BaseClass_NoticeHandler; // ACBindings.Internal.NoticeHandler

    // Statics
    public static uint* sm_nFontFace = (uint*)0x0081820C;
    public static uint* sm_nFontSize = (uint*)0x00818210;

    // Child Types
    public unsafe struct gmClient_vtbl
    {
        // Members
        public delegate* unmanaged[Stdcall]<ACBindings.Internal.Interface*, ACBindings.Internal._GUID*, void**, int> IUnknown_QueryInterface; // function pointer
        public delegate* unmanaged[Stdcall]<ACBindings.Internal.Interface*, uint> IUnknown_AddRef; // function pointer
        public delegate* unmanaged[Stdcall]<ACBindings.Internal.Interface*, uint> IUnknown_Release; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.Interface*, ACBindings.Internal.TResult*, ACBindings.Internal.Turbine_GUID*, void**, ACBindings.Internal.TResult*> QueryInterface; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.Interface*, uint> AddRef; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.Interface*, uint> Release; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.Client*, ACBindings.Internal.Client.Enum5> You_Must_Not_Have_Multiple_Implementations_Of_AddRef_In_A_Hierarchy; // function pointer
        public System.IntPtr Init;
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.Client*, void> Cleanup; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.Client*, ACBindings.Internal.NetError*, ACBindings.Internal.NetError*> Connect; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.Client*, byte> Disconnect; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.Client*, byte> Run; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.Client*, byte> UseTime; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.Client*, ACBindings.Internal.accountID*> GetAccountName; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.Client*, ACBindings.Internal.accountID*, void> SetAccountName; // function pointer
        public System.IntPtr GetHostName;
        public System.IntPtr SetHostName;
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.Client*, int> GetPort; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.Client*, int, void> SetPortA; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.Client*, int> GetLanguage; // function pointer
        public System.IntPtr SetLanguage;
        public System.IntPtr GetWorldName;
        public System.IntPtr SetWorldName;
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.Client*, ACBindings.Internal.CDDDStatusPlugin*, byte> AddDDDStatusPlugin; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.Client*, ACBindings.Internal.CDDDStatusPlugin*, byte> RemoveDDDStatusPlugin; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.Client*, uint> GetNameRuleLanguage; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.Client*, byte> InitPreferences; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.Client*, void> CleanupPreferences; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.Client*, byte> InitNet; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.Client*, int, int, byte, byte> InitDatabase; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.Client*, byte> InitAuth; // function pointer
        public System.IntPtr InitUI;
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.Client*, byte> IsAlreadyRunning; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.Client*, void> CleanupUI; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.Client*, void> CleanupDatabase; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.Client*, void> CleanupNet; // function pointer
        public System.IntPtr InitKeymap;

        // Methods
    }

    // Members
    public ACBindings.Internal.PStringBase__sbyte m_startChar;
    public ACBindings.Internal.PStringBase__sbyte m_createChar;
    public ACBindings.Internal.PStringBase__sbyte m_strKeymapFile;
    public byte m_bKeymapLoaded;
    public ACBindings.Internal.PStringBase__sbyte m_strZoneTicket;
    public ACBindings.Internal.PStringBase__sbyte m_strGLSTicket;
    public ACBindings.Internal.PStringBase__ushort m_wstrMigrationURL;
    public ACBindings.Internal.PStringBase__sbyte m_strVGPassword;

    // Generated Constructor
    public gmClient() {
        _ConstructorInternal();
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>Processes a DDD event for gmClient, forwarding it to the base Client and resetting the keymap file path when the patching phase concludes.
    /// <code>Offset: 0x00401790
    /// void __thiscall gmClient::OnDDDEvent(gmClient*,DDDEvent,unsigned int)</code>
    /// </summary>
    /// <param name="evtNum">Identifier of the DDD event being handled.</param>
    /// <param name="nBytes">Size in bytes of any data accompanying the event.</param>
    public void OnDDDEvent(ACBindings.Internal.DDDEvent evtNum, uint nBytes) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmClient, ACBindings.Internal.DDDEvent, uint, void>)0x00401790)(ref this, evtNum, nBytes);

    /// <summary>Releases the queued UI event manager and then performs standard client time processing.
    /// <code>Offset: 0x004017C0
    /// bool __thiscall gmClient::UseTime(gmClient*)</code>
    /// </summary>
    /// <returns>True if the underlying Client::UseTime call succeeded; otherwise false.</returns>
    public byte UseTime() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmClient, byte>)0x004017C0)(ref this);

    /// <summary>Detaches all registered UI preference settings from the client, removing sound, rendering, display, input, camera, and chat font preferences so they can be reset or reloaded.
    /// <code>Offset: 0x004017E0
    /// void __thiscall gmClient::DetachUIPreferences(gmClient*)</code>
    /// </summary>
    public void DetachUIPreferences() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmClient, void>)0x004017E0)(ref this);

    /// <summary>Notifies the user interface of updated font face and size after a font preference change event.
    /// <code>Offset: 0x00401900
    /// void __cdecl gmClient::GRPCallback_OnFontPreferenceChanged()</code>
    /// </summary>
    public static void GRPCallback_OnFontPreferenceChanged() => ((delegate* unmanaged[Cdecl]<void>)0x00401900)();

    /// <summary>Destroys a gmClient instance, releasing owned resources—including reference counts on shared strings, network authentication objects, and UI components—and then calls base class destructors to clean up the Client and NoticeHandler parts.
    /// <code>Offset: 0x00401C50
    /// void __thiscall gmClient::~gmClient(gmClient*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmClient, void>)0x00401C50)(ref this);

    /// <summary>Releases resources held by the gmClient instance. Unregisters UI preferences and event handlers, unloads custom keymaps, deregisters global variables, and performs base Client cleanup.
    /// <code>Offset: 0x00401EC0
    /// void __thiscall gmClient::Cleanup(gmClient*)</code>
    /// </summary>
    public void Cleanup() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmClient, void>)0x00401EC0)(ref this);

    /// <summary>Attempts to establish a network connection using gmClient's underlying Client implementation and records any errors in the supplied NetError object.
    /// <code>Offset: 0x00402000
    /// NetError* __thiscall gmClient::Connect(gmClient*,NetError*)</code>
    /// </summary>
    /// <param name="result">Object used to receive error information from the connection attempt.</param>
    /// <returns>The same NetError pointer that was passed in, allowing callers to inspect any reported errors after the call.</returns>
    public ACBindings.Internal.NetError* Connect(ACBindings.Internal.NetError* result) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmClient, ACBindings.Internal.NetError*, ACBindings.Internal.NetError*>)0x00402000)(ref this, result);

    /// <summary>Sets the client's key‑map file reference to a new value, adjusting internal reference counts for the previous and new key maps.
    /// <code>Offset: 0x00402020
    /// LONG __thiscall gmClient::SetKeyMapFileName(_DWORD*,int*)</code>
    /// </summary>
    /// <param name="a2">Pointer to the identifier of the desired key‑map file.</param>
    /// <returns>The prior key‑map identifier if no change was made; otherwise the updated reference count of the newly selected key map.</returns>
    public int SetKeyMapFileName(int* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmClient, int*, int>)0x00402020)(ref this, a2);

    /// <summary>Initializes a gmClient instance by constructing its base classes, resetting string members to empty buffers, determining the location of UserPreferences.ini (using the current working directory or creating an Asheron's Call folder if necessary), setting m_bKeymapLoaded to false, and allocating the migration URL buffer used for billing services.
    /// <code>Offset: 0x00402810
    /// void __thiscall gmClient::gmClient(gmClient*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmClient, void>)0x00402810)(ref this);

    /// <summary>Extends the command‑line argument list with GM client options such as character selection, account tickets, migration server URL, and Vanguard password.
    /// <code>Offset: 0x00402A90
    /// void __thiscall gmClient::BuildCommandLineArgs(gmClient*,ArgumentParser::CommandLineArgList*)</code>
    /// </summary>
    /// <param name="Args">The ArgumentParser::CommandLineArgList to which the options are added.</param>
    public void BuildCommandLineArgs(ACBindings.Internal.ArgumentParser.CommandLineArgList* Args) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmClient, ACBindings.Internal.ArgumentParser.CommandLineArgList*, void>)0x00402A90)(ref this, Args);

    /// <summary>Evaluates a command‑line argument by delegating to the base Client implementation and performing special handling for the "glsticket" option, which reads or deletes the GLSTicket registry value under HKCU\Software\Turbine\ac1.
    /// <code>Offset: 0x00402DF0
    /// char __thiscall gmClient::EvaluateCommandLineArg(int,const char**,const char*)</code>
    /// </summary>
    /// <param name="Type">Array of strings containing the parsed tokens for this command‑line argument.</param>
    /// <returns>Non‑zero if the argument was processed successfully; zero otherwise.</returns>
    public sbyte EvaluateCommandLineArg(sbyte** Type, sbyte* a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmClient, sbyte**, sbyte*, sbyte>)0x00402DF0)(ref this, Type, a3);

    /// <summary>Validates required command line arguments after parsing, ensuring an account name is supplied and a host name is present.
    /// <code>Offset: 0x00402F60
    /// char __thiscall gmClient::OnCommandLineEvaluationDone(gmClient*)</code>
    /// </summary>
    /// <returns>Zero on success or when the account name is missing (a notice is shown). Returns one if the host name argument is missing.</returns>
    public sbyte OnCommandLineEvaluationDone() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmClient, sbyte>)0x00402F60)(ref this);

    /// <summary>Initializes the client's key mapping configuration by resolving a keymap file path and loading it via ICIDM. Returns 1 on success, 0 if initialization fails.
    /// <code>Offset: 0x00402FE0
    /// char __thiscall gmClient::InitKeymap(int,int*)</code>
    /// </summary>
    /// <param name="a2">Pointer to the keymap identifier or filename used for determining which keymap to load.</param>
    /// <returns>Non‑zero value if the keymap was successfully initialized; zero otherwise.</returns>
    public sbyte InitKeymap(int* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmClient, int*, sbyte>)0x00402FE0)(ref this, a2);

    /// <summary>Registers client‑specific preference settings, including keymap file path and chat font face and size, then invokes the base Client initialization.
    /// <code>Offset: 0x00403170
    /// bool __thiscall gmClient::InitPreferences(gmClient*)</code>
    /// </summary>
    /// <returns>True if preferences were initialized successfully; otherwise false.</returns>
    public byte InitPreferences() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmClient, byte>)0x00403170)(ref this);

    /// <summary>Initializes the client’s authentication state using stored credentials. If a VG password is present, configures the authenticator for type 2 with that data; if a GLS ticket exists instead, uses type 0x40000002 with the ticket. When neither credential is available, delegates to the base Client::InitAuth implementation.
    /// <code>Offset: 0x00403270
    /// bool __thiscall gmClient::InitAuth(gmClient*)</code>
    /// </summary>
    /// <returns>True on successful initialization; otherwise false (as may be returned by the base implementation).</returns>
    public byte InitAuth() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmClient, byte>)0x00403270)(ref this);

    /// <summary>Initializes the client’s UI preferences by registering a comprehensive set of configurable options—including sound, tooltip, graphics, input, and camera settings—attaching each preference key with its default value, allowed range, or enumerated choices.
    /// <code>Offset: 0x004037B0
    /// void __thiscall gmClient::InitUIPreferences(gmClient*)</code>
    /// </summary>
    public void InitUIPreferences() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmClient, void>)0x004037B0)(ref this);

    /// <summary>Initializes the gmClient instance by forcing a display resolution of 800×600, invoking the base Client::Init routine, setting up a UI event queue manager, configuring English locale settings, registering a global notice handler, and initializing UI preferences.
    /// <code>Offset: 0x004049A0
    /// bool __thiscall gmClient::Init(gmClient*,int,int,int)</code>
    /// </summary>
    /// <param name="a2">First argument forwarded to Client::Init during client initialization.</param>
    /// <param name="a3">Second argument forwarded to Client::Init during client initialization.</param>
    /// <param name="a4">Third argument forwarded to Client::Init during client initialization.</param>
    /// <returns>True if the client initializes successfully; otherwise, false.</returns>
    public byte Init(int a2, int a3, int a4) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmClient, int, int, int, byte>)0x004049A0)(ref this, a2, a3, a4);

    /// <summary>Processes a world name notice from the server, extracting the world name string and passing it to the client’s handler while managing packet reference counting.
    /// <code>Offset: 0x00404AE0
    /// LONG __thiscall gmClient::RecvNotice_WorldName(_DWORD*,int)</code>
    /// </summary>
    /// <param name="a2">Pointer to the incoming data buffer containing the world name string.</param>
    /// <returns>A LONG value representing the updated reference count; zero indicates the packet has been fully processed.</returns>
    public int RecvNotice_WorldName(int a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmClient, int, int>)0x00404AE0)(ref this, a2);
}

