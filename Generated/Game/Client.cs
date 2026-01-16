namespace ACBindings.Internal;


/// <summary>Central client object orchestrating networking, user preferences, UI rendering, database caching, and application state for the game client. Handles connection lifecycle, configuration, event processing, and resource management across subsystems.</summary>
public unsafe struct Client : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.Interface BaseClass_Interface; // ACBindings.Internal.Interface
    public ACBindings.Internal.ArgumentParser BaseClass_ArgumentParser; // ACBindings.Internal.ArgumentParser
    public ACBindings.Internal.CDDDStatusPlugin BaseClass_CDDDStatusPlugin; // ACBindings.Internal.CDDDStatusPlugin
    public ACBindings.Internal.IInputActionCallback BaseClass_IInputActionCallback; // ACBindings.Internal.IInputActionCallback
    public ACBindings.Internal.LinkStatusHolder BaseClass_LinkStatusHolder; // ACBindings.Internal.LinkStatusHolder

    // Statics
    public static ACBindings.Internal.Client** m_instance = (ACBindings.Internal.Client**)0x008379E4;

    // Child Types
    public unsafe struct Client_vtbl
    {
        // Members
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.Interface*, ACBindings.Internal._GUID*, void**, int> IUnknown_QueryInterface; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.Interface*, uint> IUnknown_AddRef; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.Interface*, uint> IUnknown_Release; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.Interface*, ACBindings.Internal.TResult*, ACBindings.Internal.Turbine_GUID*, void**, ACBindings.Internal.TResult*> QueryInterface; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.Interface*, uint> AddRef; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.Interface*, uint> Release; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.Client*, ACBindings.Internal.Client.Enum5> You_Must_Not_Have_Multiple_Implementations_Of_AddRef_In_A_Hierarchy; // function pointer
        public System.IntPtr Init;
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.Client*, void> Cleanup; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.Client*, ACBindings.Internal.NetError*, ACBindings.Internal.NetError*> Connect; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.Client*, byte> Disconnect; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.Client*, byte> Run; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.Client*, byte> UseTime; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.Client*, ACBindings.Internal.accountID*> GetAccountName; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.Client*, ACBindings.Internal.accountID*, void> SetAccountName; // function pointer
        public System.IntPtr GetHostName;
        public System.IntPtr SetHostName;
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.Client*, int> GetPort; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.Client*, int, void> SetPortA; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.Client*, int> GetLanguage; // function pointer
        public System.IntPtr SetLanguage;
        public System.IntPtr GetWorldName;
        public System.IntPtr SetWorldName;
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.Client*, ACBindings.Internal.CDDDStatusPlugin*, byte> AddDDDStatusPlugin; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.Client*, ACBindings.Internal.CDDDStatusPlugin*, byte> RemoveDDDStatusPlugin; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.Client*, uint> GetNameRuleLanguage; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.Client*, byte> InitPreferences; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.Client*, void> CleanupPreferences; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.Client*, byte> InitNet; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.Client*, int, int, byte, byte> InitDatabase; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.Client*, byte> InitAuth; // function pointer
        public System.IntPtr InitUI;
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.Client*, byte> IsAlreadyRunning; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.Client*, void> CleanupUI; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.Client*, void> CleanupDatabase; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.Client*, void> CleanupNet; // function pointer

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
    public ACBindings.Internal.Turbine_RefCount m_cTurbineRefCount;
    public ACBindings.Internal.PStringBase__sbyte m_FullOutputText;
    public ACBindings.Internal.PStringBase__sbyte m_preferencesFile;
    public int m_fWindowed;
    public int m_fUseMemoryManager;
    public int m_fReadOnlyDatFiles;
    public ACBindings.Internal.accountID m_account;
    public ACBindings.Internal.PStringBase__sbyte m_pPrimer;
    public ACBindings.Internal.PStringBase__sbyte m_LanguageStr;
    public ACBindings.Internal.PStringBase__sbyte m_hostName;
    public int m_noflowqueue;
    public int m_port;
    public int m_clientPort;
    public int m_latencyDelay;
    public int m_latencyPercent;
    public int m_Language;
    public ACBindings.Internal.PStringBase__ushort m_worldName;
    public ACBindings.Internal.CLCache* m_pDBCache;
    public ACBindings.Internal.UIFlow* m_ui;
    public byte m_connected;
    public ACBindings.Internal.NetAuthenticator m_netAuth;
    public ACBindings.Internal.ClientNet* m_net;
    public ACBindings.Internal.GlobalEventHandler* m_eventHandler;
    public ACBindings.Internal.QualityRegistrar* m_qualityRegistrar;
    public ACBindings.Internal.PStringBase__sbyte m_strPreferenceBindInterface;
    public byte m_bPreferenceComputeUniquePort;
    public uint m_nPreferenceUserSpecifiedPort;
    public ACBindings.Internal.IQueuedUIEventDeliverer* m_UIQueueManager;
    public ACBindings.Internal.NetAuthenticator* pNetAuth_;
    public ACBindings.Internal.SmartBox* smartbox_;
    public System.IntPtr m_logonEventQueue;
    public ACBindings.Internal.PacketController* packControl_;
    public System.IntPtr netQueues_;
    public ACBindings.Internal.AlreadyRunningCheck m_running_check;

    // Generated Constructor
    public Client() {
        _ConstructorInternal();
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>Provides access to the client’s stored account identifier, including the account name and expansion flags.
    /// <code>Offset: 0x00401D90
    /// accountID* __thiscall Client::GetAccountName(Client*)</code>
    /// </summary>
    /// <returns>A non‑null pointer to the internal <c>accountID</c> structure holding the account information.</returns>
    public ACBindings.Internal.accountID* GetAccountName() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Client, ACBindings.Internal.accountID*>)0x00401D90)(ref this);

    /// <summary>Retrieves the host name for this client.
    /// <code>Offset: 0x00401DA0
    /// char* __thiscall Client::GetHostName(char*)</code>
    /// </summary>
    /// <returns>A pointer to a null‑terminated character array containing the client's host name.</returns>
    public sbyte* GetHostName() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Client, sbyte*>)0x00401DA0)(ref this);

    /// <summary>Sets the player's spell filter mask to the given value.
    /// <code>Offset: 0x00401DC0
    /// void __thiscall Client::SetPortA(PlayerModule*,unsigned int)</code>
    /// </summary>
    /// <param name="filters">A bitmask specifying which spells are filtered.</param>
    public void SetPortA(uint filters) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Client, uint, void>)0x00401DC0)(ref this, filters);

    /// <summary>Returns the current world name stored within the client instance.
    /// <code>Offset: 0x00401DD0
    /// char* __thiscall Client::GetWorldName(char*)</code>
    /// </summary>
    /// <returns>A pointer to the character sequence representing the world’s name; the string is owned by the client object.</returns>
    public sbyte* GetWorldName() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Client, sbyte*>)0x00401DD0)(ref this);

    /// <summary>Queries whether the client supports a given interface and returns status via result; if supported, fills o_ppObject with the client pointer.
    /// <code>Offset: 0x00401E00
    /// TResult* __thiscall Client::QueryInterface(Client*,TResult*,const Turbine_GUID*,void**)</code>
    /// </summary>
    /// <param name="this">The client instance on which QueryInterface is called.</param>
    /// <param name="result">Container for the query outcome; set to 0 on success or an error code otherwise.</param>
    /// <param name="i_rcInterface">GUID identifying the interface being requested.</param>
    /// <param name="o_ppObject">Pointer that receives the client instance when the requested interface is supported.</param>
    /// <returns>The same TResult pointer supplied in result, updated with the status code.</returns>
    public ACBindings.Internal.TResult* QueryInterface(ACBindings.Internal.TResult* result, ACBindings.Internal.Turbine_GUID* i_rcInterface, void** o_ppObject) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Client, ACBindings.Internal.TResult*, ACBindings.Internal.Turbine_GUID*, void**, ACBindings.Internal.TResult*>)0x00401E00)(ref this, result, i_rcInterface, o_ppObject);

    /// <summary>Increments the client's reference counter and returns the new value.
    /// <code>Offset: 0x00401E60
    /// LONG __thiscall Client::AddRef(Client*)</code>
    /// </summary>
    /// <returns>The updated reference count after incrementing.</returns>
    public int AddRef() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Client, int>)0x00401E60)(ref this);

    /// <summary>Decrements the client’s Turbine reference counter and, if it drops to zero, destroys its status plugin component. Returns the updated reference count.
    /// <code>Offset: 0x00401E70
    /// unsigned int __thiscall Client::Release(Client*)</code>
    /// </summary>
    /// <returns>The remaining reference count after decrementing.</returns>
    public uint Release() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Client, uint>)0x00401E70)(ref this);

    /// <summary>Assigns a new host name to the client, updating internal reference counts when the supplied object differs from the current one.
    /// <code>Offset: 0x004021E0
    /// LONG __thiscall Client::SetHostName(_DWORD*,int*)</code>
    /// </summary>
    /// <param name="a2">Pointer to the host name object to assign; typically points to a reference‑counted string instance.</param>
    /// <returns>The reference count of the host name after assignment, or the previous value if no change occurred.</returns>
    public int SetHostName(int* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Client, int*, int>)0x004021E0)(ref this, a2);

    /// <summary>Assigns the specified world identifier to the client, adjusting reference counts for the previous and new world objects.
    /// <code>Offset: 0x00402230
    /// LONG __thiscall Client::SetWorldName(_DWORD*,int*)</code>
    /// </summary>
    /// <param name="a2">Pointer to an integer containing the new world ID.</param>
    /// <returns>The updated reference count of the newly assigned world object; if unchanged, returns the current value without altering reference counts.</returns>
    public int SetWorldName(int* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Client, int*, int>)0x00402230)(ref this, a2);

    /// <summary>Updates the client's stored account information with values from a supplied accountID, including name and expansion ownership flags.
    /// <code>Offset: 0x00403490
    /// void __thiscall Client::SetAccountName(Client*,const accountID*)</code>
    /// </summary>
    /// <param name="account">The accountID containing the new account details.</param>
    public void SetAccountName(ACBindings.Internal.accountID* account) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Client, ACBindings.Internal.accountID*, void>)0x00403490)(ref this, account);

    /// <summary>Returns a pointer to the global client instance.
    /// <code>Offset: 0x004114C0
    /// Client* __cdecl Client::GetInstance()</code>
    /// </summary>
    /// <returns>A pointer to the singleton Client object used throughout the application.</returns>
    public static ACBindings.Internal.Client* GetInstance() => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.Client*>)0x004114C0)();

    /// <summary>Releases UI resources and performs system cleanup for the client, including UI elements, event queues, smartbox, input callbacks, device interfaces, key management, and COM components.
    /// <code>Offset: 0x004114D0
    /// void __thiscall Client::CleanupUI(Client*)</code>
    /// </summary>
    public void CleanupUI() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Client, void>)0x004114D0)(ref this);

    /// <summary>Releases the client’s database cache and resets its reference.
    /// <code>Offset: 0x00411560
    /// void __thiscall Client::CleanupDatabase(Client*)</code>
    /// </summary>
    public void CleanupDatabase() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Client, void>)0x00411560)(ref this);

    /// <summary>Cleans up client preferences by unregistering global networking variables, resetting the IME state, persisting current user settings, and clearing temporary preference data.
    /// <code>Offset: 0x004115A0
    /// void __thiscall Client::CleanupPreferences(Client*)</code>
    /// </summary>
    public void CleanupPreferences() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Client, void>)0x004115A0)(ref this);

    /// <summary>Initializes the client's authentication state by configuring the internal NetAuthenticator with its account ID and setting it to type 1.
    /// <code>Offset: 0x004115D0
    /// bool __thiscall Client::InitAuth(Client*)</code>
    /// </summary>
    /// <returns>Always returns true, indicating successful initialization.</returns>
    public byte InitAuth() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Client, byte>)0x004115D0)(ref this);

    /// <summary>Terminates the client’s connection to the server, releases database cache resources, and updates internal state.
    /// <code>Offset: 0x004115F0
    /// bool __thiscall Client::Disconnect(Client*)</code>
    /// </summary>
    /// <returns>True when the disconnection operation succeeds; this implementation always returns true.</returns>
    public byte Disconnect() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Client, byte>)0x004115F0)(ref this);

    /// <summary>Maintains UI responsiveness by updating timers, processing device events, handling network logon transitions, refreshing cached data, rendering UI elements and graphics, then sleeping to regulate frame pacing.
    /// <code>Offset: 0x00411630
    /// void __thiscall Client::KeepUIAlive(Client*)</code>
    /// </summary>
    public void KeepUIAlive() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Client, void>)0x00411630)(ref this);

    /// <summary>Provides the character limit for text wrapping usage; returns –1 to indicate no enforced limit.
    /// <code>Offset: 0x004116A0
    /// int __thiscall Client::GetCharactersToWrapUsageTo(Client*)</code>
    /// </summary>
    /// <returns>An integer specifying the maximum number of characters allowed before wrap, or -1 if wrapping is not restricted.</returns>
    public int GetCharactersToWrapUsageTo() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Client, int>)0x004116A0)(ref this);

    /// <summary>Retrieves the language identifier used for name validation rules from the client's database cache, defaulting to 1 when no cache is available.
    /// <code>Offset: 0x004116B0
    /// unsigned int __thiscall Client::GetNameRuleLanguage(Client*)</code>
    /// </summary>
    /// <returns>The numeric code of the name rule language; returns 1 if no cache exists.</returns>
    public uint GetNameRuleLanguage() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Client, uint>)0x004116B0)(ref this);

    /// <summary>Cleans up the client by releasing references, shutting down subsystems such as the communication system, language interface, and sound manager, destroying associated registrar objects, and deleting the global interface system instance.
    /// <code>Offset: 0x004118D0
    /// void __thiscall Client::Cleanup(Client*)</code>
    /// </summary>
    public void Cleanup() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Client, void>)0x004118D0)(ref this);

    /// <summary>Retrieves the client’s current language setting by translating the stored language string into its corresponding enumeration value.
    /// <code>Offset: 0x00411980
    /// int __thiscall Client::GetLanguage(Client*)</code>
    /// </summary>
    /// <returns>The integer identifier of the active language; returns the existing m_Language value if the translation fails.</returns>
    public int GetLanguage() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Client, int>)0x00411980)(ref this);

    /// <summary>Initializes the client’s user interface and rendering subsystem by setting up COM, device context, sound manager, UI flow, database loading, and optional custom components.
    /// <code>Offset: 0x004119C0
    /// char __thiscall Client::InitUI(_DWORD*,const char**)</code>
    /// </summary>
    /// <param name="a2">Array of command‑line argument strings passed to Device::Init for configuration.</param>
    /// <returns>Non‑zero if initialization succeeded; zero otherwise.</returns>
    public sbyte InitUI(sbyte** a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Client, sbyte**, sbyte>)0x004119C0)(ref this, a2);

    /// <summary>Creates a new receive queue for the specified queue ID and registers it with the packet controller. Returns true if both allocation and registration succeed.
    /// <code>Offset: 0x00411AA0
    /// int __thiscall Client::AddNetQueue(Client*,__int16)</code>
    /// </summary>
    /// <param name="queueID">The identifier of the network queue to add.</param>
    /// <returns>Non‑zero if the queue was successfully added; otherwise zero.</returns>
    public int AddNetQueue(short queueID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Client, short, int>)0x00411AA0)(ref this, queueID);

    /// <summary>Runs the client's main processing loop, repeatedly querying its interface until no further actions remain.
    /// <code>Offset: 0x00411B10
    /// bool __thiscall Client::Run(Client*)</code>
    /// </summary>
    /// <returns>Always returns false after completing the loop; indicates the run cycle finished without error.</returns>
    public byte Run() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Client, byte>)0x00411B10)(ref this);

    /// <summary>Sets the client's language when a different identifier is supplied and updates internal reference counts accordingly.
    /// <code>Offset: 0x00411B50
    /// LONG __thiscall Client::SetLanguage(_DWORD*,int*)</code>
    /// </summary>
    /// <param name="a2">Pointer to the desired language ID.</param>
    /// <returns>The reference count of the newly selected language resource; if the requested language matches the current one, returns the existing reference count unchanged.</returns>
    public int SetLanguage(int* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Client, int*, int>)0x00411B50)(ref this, a2);

    /// <summary>Responds to a DDDEvent indicating patchtime completion by resetting language support, clearing cached database objects, reinitializing services, and updating the UI event region.
    /// <code>Offset: 0x00411BA0
    /// void __thiscall Client::OnDDDEvent(Client*,DDDEvent,unsigned int)</code>
    /// </summary>
    /// <param name="evtNum">The identifier of the DDDEvent being handled; only DDD_PatchtimeEnd triggers actions.</param>
    /// <param name="nBytes">Data length associated with the event, used to set the UI handler region.</param>
    public void OnDDDEvent(ACBindings.Internal.DDDEvent evtNum, uint nBytes) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Client, ACBindings.Internal.DDDEvent, uint, void>)0x00411BA0)(ref this, evtNum, nBytes);

    /// <summary>Processes all queued logon events, handling each event (such as chat interface requests) and releasing associated resources.
    /// <code>Offset: 0x00411C20
    /// void __thiscall Client::ProcessLogonEventQueue(Client*)</code>
    /// </summary>
    public void ProcessLogonEventQueue() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Client, void>)0x00411C20)(ref this);

    /// <summary>Initializes the client’s networking subsystem by allocating a ClientNet instance, constructing a PacketController, preparing net queue storage, and registering essential network queues.
    /// <code>Offset: 0x00411E80
    /// bool __thiscall Client::InitNet(Client*)</code>
    /// </summary>
    /// <returns>True when the network components and required queues have been set up successfully; returns false if any allocation or registration fails.</returns>
    public byte InitNet() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Client, byte>)0x00411E80)(ref this);

    /// <summary>Performs per‑frame updates for the client: synchronizes time, processes event loops, updates networking and packet handling, manages UI elements, draws the scene, and handles any pending logon events.
    /// <code>Offset: 0x00411FA0
    /// bool __thiscall Client::UseTime(Client*)</code>
    /// </summary>
    /// <returns>True if the frame completed normally; false if an event loop handled a request that causes early termination of the current cycle.</returns>
    public byte UseTime() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Client, byte>)0x00411FA0)(ref this);

    /// <summary>Cleans up the client's networking state by disconnecting from any active server, destroying the packet controller, deallocating queued packets and associated resources, and clearing internal network references.
    /// <code>Offset: 0x00412060
    /// void __thiscall Client::CleanupNet(Client*)</code>
    /// </summary>
    public void CleanupNet() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Client, void>)0x00412060)(ref this);

    /// <summary>Initializes the client subsystem, establishing event handling, quality registration, language support, and other core components.
    /// <code>Offset: 0x00412180
    /// bool __thiscall Client::Init(_DWORD*,int,int,int)</code>
    /// </summary>
    /// <param name="a2">Primary configuration parameter used in the final initialization stage.</param>
    /// <param name="a3">Secondary flag passed to internal module setup.</param>
    /// <param name="a4">Tertiary setting for client initialization.</param>
    /// <returns>True if all subsystems initialize successfully; otherwise false.</returns>
    public byte Init(int a2, int a3, int a4) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Client, int, int, int, byte>)0x00412180)(ref this, a2, a3, a4);

    /// <summary>Determines whether another instance of the client is already running by attempting to create a named semaphore.
    /// <code>Offset: 0x004122A0
    /// bool __thiscall Client::IsAlreadyRunning(Client*)</code>
    /// </summary>
    /// <returns>True when an existing instance is detected; otherwise, false.</returns>
    public byte IsAlreadyRunning() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Client, byte>)0x004122A0)(ref this);

    /// <summary>Initializes client preference settings by loading existing configuration and registering network options such as bind interface, unique port calculation flag, and user‑specified port. Also prepares IME preferences.
    /// <code>Offset: 0x00412310
    /// bool __thiscall Client::InitPreferences(Client*)</code>
    /// </summary>
    /// <returns>True after successful initialization; the implementation always returns true.</returns>
    public byte InitPreferences() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Client, byte>)0x00412310)(ref this);

    /// <summary>Populates a command‑line argument list with options for configuring client behaviour, such as account name, debug verbosity, server host and ports, language selection, preferences file, read‑only DAT mode, and memory manager usage.
    /// <code>Offset: 0x00412420
    /// void __thiscall Client::BuildCommandLineArgs(Client*,ArgumentParser::CommandLineArgList*)</code>
    /// </summary>
    /// <param name="Args">The CommandLineArgList to which the supported options are added.</param>
    public void BuildCommandLineArgs(ACBindings.Internal.ArgumentParser.CommandLineArgList* Args) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Client, ACBindings.Internal.ArgumentParser.CommandLineArgList*, void>)0x00412420)(ref this, Args);

    /// <summary>Processes a single command‑line argument for the client, delegating initial parsing to ArgumentParser and updating state for options such as account name, debug flags, output port validation, and read‑only data mode.
    /// <code>Offset: 0x00412850
    /// char __thiscall Client::EvaluateCommandLineArg(int*,_DWORD*,const char*)</code>
    /// </summary>
    /// <param name="client">The Client instance on which the argument is evaluated.</param>
    /// <param name="parser">ArgumentParser object providing the current option key and value.</param>
    /// <param name="value">String containing the value supplied for the current command‑line option.</param>
    /// <returns>Non‑zero if ArgumentParser accepted the argument; zero otherwise.</returns>
    public sbyte EvaluateCommandLineArg(int* a2, sbyte* a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Client, int*, sbyte*, sbyte>)0x00412850)(ref this, a2, a3);

    /// <summary>Finalizes and displays a predefined message for the client by invoking <c>PlatformString::DisplayString</c> with identifier 205.
    /// <code>Offset: 0x00412A80
    /// void __thiscall Client::FinishOutputText(Client*)</code>
    /// </summary>
    public void FinishOutputText() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Client, void>)0x00412A80)(ref this);

    /// <summary>Detaches the specified DDD status plugin from the client's database cache via its plugin manager.
    /// <code>Offset: 0x00412AC0
    /// bool __thiscall Client::RemoveDDDStatusPlugin(Client*,CDDDStatusPlugin*)</code>
    /// </summary>
    /// <param name="i_pPlugin">The plugin to remove.</param>
    /// <returns>True if the plugin was removed successfully; otherwise, false.</returns>
    public byte RemoveDDDStatusPlugin(ACBindings.Internal.CDDDStatusPlugin* i_pPlugin) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Client, ACBindings.Internal.CDDDStatusPlugin*, byte>)0x00412AC0)(ref this, i_pPlugin);

    /// <summary>Releases all resources owned by the client, including network connections, string buffers, plugin references, and reference counts, then clears the global client instance.
    /// <code>Offset: 0x00412B70
    /// void __thiscall Client::~Client(Client*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Client, void>)0x00412B70)(ref this);

    /// <summary>Appends a string to the client’s output stream, forwarding the request to ArgumentParser::AppendOutputText and then copying any non‑empty text into an internal Turbine_RefCount buffer.
    /// <code>Offset: 0x00412DA0
    /// void __thiscall Client::AppendOutputText(Client*,const char*,ArgumentParser::OutputTextType)</code>
    /// </summary>
    /// <param name="Text">Null‑terminated string to append; if null or empty only the base call is executed.</param>
    /// <param name="i_eFormattingHint">Specifies how the text should be formatted by ArgumentParser when appended; it is not used for the subsequent raw copy.</param>
    public void AppendOutputText(sbyte* Text, ACBindings.Internal.ArgumentParser.OutputTextType i_eFormattingHint) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Client, sbyte*, ACBindings.Internal.ArgumentParser.OutputTextType, void>)0x00412DA0)(ref this, Text, i_eFormattingHint);

    /// <summary>Initializes a new client instance by setting default configuration values, preparing internal components such as argument parsing, networking, and link status handling, and establishing the singleton reference. The constructor also initializes string buffers to empty, configures connection parameters (ports, latency, language), sets up debug flags, and calls the communication system initialization routine.
    /// <code>Offset: 0x00412E50
    /// void __thiscall Client::Client(Client*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Client, void>)0x00412E50)(ref this);

    /// <summary>Initializes the client’s database cache by loading “client_portal.dat” with optional read‑only access and configuring networking, plugins, and language settings.
    /// <code>Offset: 0x00413070
    /// bool __thiscall Client::InitDatabase(Client*,const int,const int,bool)</code>
    /// </summary>
    /// <param name="language_i">Index of the language to use when setting local language for the cache.</param>
    /// <param name="region_i">Region identifier for the client (currently unused in this implementation).</param>
    /// <param name="open_readonly">True to open the database file read‑only; otherwise false.</param>
    /// <returns>True if the cache was successfully created, loaded, and configured; otherwise false.</returns>
    public byte InitDatabase(int language_i, int region_i, byte open_readonly) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Client, int, int, byte, byte>)0x00413070)(ref this, language_i, region_i, open_readonly);

    /// <summary>Attempts to establish a connection to the configured server using the client's host and port settings. On success it marks the client as connected; on failure it displays an error popup and records the error details in the supplied NetError structure.
    /// <code>Offset: 0x00413180
    /// NetError* __thiscall Client::Connect(Client*,NetError*)</code>
    /// </summary>
    /// <param name="result">Pre‑allocated NetError object that receives the status of the connect attempt.</param>
    /// <returns>The same NetError pointer passed in result, containing error code and table ID.</returns>
    public ACBindings.Internal.NetError* Connect(ACBindings.Internal.NetError* result) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Client, ACBindings.Internal.NetError*, ACBindings.Internal.NetError*>)0x00413180)(ref this, result);

    /// <summary>Adds a DDD status plugin prototype to the client’s database cache if one exists.
    /// <code>Offset: 0x00413450
    /// bool __thiscall Client::AddDDDStatusPlugin(Client*,CDDDStatusPlugin*)</code>
    /// </summary>
    /// <param name="i_pPlugin">The plugin prototype to register with the database cache.</param>
    /// <returns>True when the plugin is successfully added; otherwise false.</returns>
    public byte AddDDDStatusPlugin(ACBindings.Internal.CDDDStatusPlugin* i_pPlugin) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Client, ACBindings.Internal.CDDDStatusPlugin*, byte>)0x00413450)(ref this, i_pPlugin);
}

