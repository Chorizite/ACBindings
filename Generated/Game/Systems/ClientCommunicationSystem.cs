namespace ACBindings.Internal;


/// <summary>Handles client‑side communication by parsing and executing chat commands, managing spam detection, message filtering, and logging. Integrates with Turbine chat services and tracks the current command state and source.</summary>
public unsafe struct ClientCommunicationSystem : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.ClientSystem BaseClass_ClientSystem; // ACBindings.Internal.ClientSystem
    public ACBindings.Internal.QualityChangeHandler BaseClass_QualityChangeHandler; // ACBindings.Internal.QualityChangeHandler

    // Statics
    public static ACBindings.Internal.ClientCommunicationSystem** s_pCommunicationSystem = (ACBindings.Internal.ClientCommunicationSystem**)0x008717FC;

    // Child Types
    public unsafe struct ClientCommunicationSystem_vtbl
    {
        // Members
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.Interface*, ACBindings.Internal._GUID*, void**, int> IUnknown_QueryInterface; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.Interface*, uint> IUnknown_AddRef; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.Interface*, uint> IUnknown_Release; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.Interface*, ACBindings.Internal.TResult*, ACBindings.Internal.Turbine_GUID*, void**, ACBindings.Internal.TResult*> QueryInterface; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.Interface*, uint> AddRef; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.Interface*, uint> Release; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ClientSystem*, void> OnStartup; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ClientSystem*, void> UseTime; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ClientSystem*, void> OnBeginCharacterSession; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ClientSystem*, void> OnEndCharacterSession; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ClientSystem*, void> OnShutdown; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ClientCommunicationSystem*, ACBindings.Internal.ClientCommunicationSystem.Enum10> You_Must_Not_Have_Multiple_Implementations_Of_AddRef_In_A_Hierarchy; // function pointer

        // Methods
    }

    /// <summary>Container for command metadata used by the client communication system, linking a hashed identifier to its callback function and optional help data.</summary>
    public unsafe struct CmdHashData
    {
        // Base Classes
        public ACBindings.Internal.IntrusiveHashData___CaseInsensitiveStringBase___PStringBase__sbyte___ClientCommunicationSystem_CmdHashData_ptr BaseClass_IntrusiveHashData; // ACBindings.Internal.IntrusiveHashData___CaseInsensitiveStringBase___PStringBase__sbyte___ClientCommunicationSystem_CmdHashData_ptr

        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ClientCommunicationSystem*, int, sbyte**, byte> func; // function pointer
        public System.IntPtr help;

        // Generated Constructor
        public CmdHashData(int* a2, int a3, int a4, int a5, int a6) {
            _ConstructorInternal(a2, a3, a4, a5, a6);
        }

        // Methods

        /// <summary>Initializes CmdHashData by copying the hash key from the supplied source, incrementing its reference count, and assigning callback, help, and auxiliary integer parameters.
        /// <code>Offset: 0x0056FAE0
        /// int* __thiscall ClientCommunicationSystem::CmdHashData::CmdHashData(int*,int*,int,int,int,int)</code>
        /// </summary>
        /// <param name="a2">Pointer to the source data containing the hash key; its reference count is increased during initialization.</param>
        /// <param name="a3">Callback function pointer assigned to the command handler field.</param>
        /// <param name="a4">First auxiliary integer value stored in the object.</param>
        /// <param name="a5">Second auxiliary integer value stored in the object.</param>
        /// <param name="a6">Help pointer or additional data reference stored in the object.</param>
        /// <returns>Pointer to the newly initialized CmdHashData instance.</returns>
        public int* _ConstructorInternal(int* a2, int a3, int a4, int a5, int a6) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientCommunicationSystem.CmdHashData, int*, int, int, int, int, int*>)0x0056FAE0)(ref this, a2, a3, a4, a5, a6);
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
    public ACBindings.Internal.Turbine_RefCount m_cTurbineRefCount;
    public ACBindings.Internal.IntrusiveHashTable___CaseInsensitiveStringBase___PStringBase__sbyte___ClientCommunicationSystem_CmdHashData_ptr m_hashCommands;
    public ACBindings.Internal.PStringBase__sbyte m_strLastCommandLine;
    public ACBindings.Internal.PStringBase__sbyte m_strCurrentCommand;
    public uint m_idCurrentCommandSource;
    public int m_LastSpamCheck;
    public int m_ChatMessageCount;
    public ACBindings.Internal.PStringBase__sbyte m_strLogName;

    // Generated Constructor
    public ClientCommunicationSystem() {
        _ConstructorInternal();
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>Retrieves the client communication system singleton.
    /// <code>Offset: 0x0056F230
    /// ClientCommunicationSystem* __cdecl ClientCommunicationSystem::GetCommunicationSystem()</code>
    /// </summary>
    /// <returns>A pointer to the global ClientCommunicationSystem instance.</returns>
    public static ACBindings.Internal.ClientCommunicationSystem* GetCommunicationSystem() => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.ClientCommunicationSystem*>)0x0056F230)();

    /// <summary>Notifies the QualityRegistrar that a character session has begun, passing the system's QualityChangeHandler base instance or null if unavailable.
    /// <code>Offset: 0x0056F240
    /// void __thiscall ClientCommunicationSystem::OnBeginCharacterSession(ClientCommunicationSystem*)</code>
    /// </summary>
    public void OnBeginCharacterSession() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientCommunicationSystem, void>)0x0056F240)(ref this);

    /// <summary>Notifies the quality registrar that a character session has ended, providing the system’s quality change handler if available.
    /// <code>Offset: 0x0056F270
    /// void __thiscall ClientCommunicationSystem::OnEndCharacterSession(ClientCommunicationSystem*)</code>
    /// </summary>
    public void OnEndCharacterSession() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientCommunicationSystem, void>)0x0056F270)(ref this);

    /// <summary>Handles receipt of a new chat room tracker, updating internal state and adjusting talk focus when appropriate.
    /// <code>Offset: 0x0056F2A0
    /// unsigned int __thiscall ClientCommunicationSystem::Handle_Communication__Recv_ChatRoomTracker(ClientCommunicationSystem*,const ChatRoomTracker*)</code>
    /// </summary>
    /// <param name="chatRoomTracker">The updated chat room tracker containing identifiers for various chat rooms.</param>
    /// <returns>Zero on success.</returns>
    public uint Handle_Communication__Recv_ChatRoomTracker(ACBindings.Internal.ChatRoomTracker* chatRoomTracker) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientCommunicationSystem, ACBindings.Internal.ChatRoomTracker*, uint>)0x0056F2A0)(ref this, chatRoomTracker);

    /// <summary>Delegates a ranged speech event to the communication subsystem, passing through all supplied arguments unchanged.
    /// <code>Offset: 0x0056F300
    /// int __stdcall ClientCommunicationSystem::Handle_Communication__HearRangedSpeech(int,int,unsigned int,float,int)</code>
    /// </summary>
    /// <param name="a1">Identifier of the entity initiating the speech.</param>
    /// <param name="a2">Identifier of the target or recipient entity.</param>
    /// <param name="ArgList">Additional data or options for the speech event.</param>
    /// <param name="a4">A floating-point value associated with the event (e.g., volume, distance).</param>
    /// <param name="a5">Contextual identifier for the event.</param>
    /// <returns>Zero to indicate successful handling of the ranged speech event.</returns>
    public static int Handle_Communication__HearRangedSpeech(int a1, int a2, uint ArgList, float a4, int a5) => ((delegate* unmanaged[Stdcall]<int, int, uint, float, int, int>)0x0056F300)(a1, a2, ArgList, a4, a5);

    /// <summary>Evaluates whether a recent chat message is considered spam by comparing elapsed time since the previous check and updating an internal counter.
    /// <code>Offset: 0x0056F330
    /// int __thiscall ClientCommunicationSystem::IsMessageSpam(ClientCommunicationSystem*,int)</code>
    /// </summary>
    /// <param name="wait_time">The minimum interval between messages that is acceptable; this parameter is currently unused but retained for API compatibility.</param>
    /// <returns>Non-zero if the message is detected as spam; zero otherwise.</returns>
    public int IsMessageSpam(int wait_time) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientCommunicationSystem, int, int>)0x0056F330)(ref this, wait_time);

    /// <summary>Handles a birth command by querying whether the character can be spawned and returns the result.
    /// <code>Offset: 0x0056F3A0
    /// bool __thiscall ClientCommunicationSystem::DoBirth(ClientCommunicationSystem*,int,char**)</code>
    /// </summary>
    /// <param name="argc">Number of arguments supplied for the command; unused in this implementation.</param>
    /// <param name="argv">Array of argument strings; unused in this implementation.</param>
    /// <returns>True if the birth event query succeeded, otherwise false.</returns>
    public byte DoBirth(int argc, sbyte** argv) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientCommunicationSystem, int, sbyte**, byte>)0x0056F3A0)(ref this, argc, argv);

    /// <summary>Enables chat focus channels based on the current communication mode. If Turbine chat is active, it checks each channel (general, trade, LFG, roleplay, society, Olthoi) for hearing capability and sets the corresponding talk focus enabled flag; otherwise all focuses are cleared.
    /// <code>Offset: 0x0056F400
    /// bool __thiscall ClientCommunicationSystem::EnableChatTalkFocuses(ClientCommunicationSystem*)</code>
    /// </summary>
    /// <returns>True when Turbine chat is in use and talk focuses were set, false if Turbine chat is not used and all focuses remain disabled.</returns>
    public byte EnableChatTalkFocuses() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientCommunicationSystem, byte>)0x0056F400)(ref this);

    /// <summary>Retrieves a pointer to an interface of ClientCommunicationSystem matching the specified GUID and records the operation status.
    /// <code>Offset: 0x0056F570
    /// TResult* __thiscall ClientCommunicationSystem::QueryInterface(ClientCommunicationSystem*,TResult*,const Turbine_GUID*,void**)</code>
    /// </summary>
    /// <param name="this">The ClientCommunicationSystem instance on which the query is performed.</param>
    /// <param name="result">Structure used to receive the result code; set to 0 on success or E_NOINTERFACE (−2147467262) if the interface does not exist.</param>
    /// <param name="i_rcInterface">GUID identifying the desired interface.</param>
    /// <param name="o_ppvInterface">Receives a pointer to the requested interface object when available; remains null otherwise.</param>
    /// <returns>The result structure passed in, now containing the status code.</returns>
    public ACBindings.Internal.TResult* QueryInterface(ACBindings.Internal.TResult* result, ACBindings.Internal.Turbine_GUID* i_rcInterface, void** o_ppvInterface) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientCommunicationSystem, ACBindings.Internal.TResult*, ACBindings.Internal.Turbine_GUID*, void**, ACBindings.Internal.TResult*>)0x0056F570)(ref this, result, i_rcInterface, o_ppvInterface);

    /// <summary>Processes a display-string notice by extracting text from the supplied StringInfo, appending it to the client’s scroll log, and managing any associated reference count for cleanup.
    /// <code>Offset: 0x0056F640
    /// void __thiscall ClientCommunicationSystem::RecvNotice_DisplayStringInfo(ClientCommunicationSystem*,unsigned int,const StringInfo*)</code>
    /// </summary>
    /// <param name="type">Identifier or flags that control how the string is handled; also used as a handle for an object whose reference count is decremented during processing.</param>
    /// <param name="msg">Container holding the string token and related data to be displayed.</param>
    public void RecvNotice_DisplayStringInfo(uint type, ACBindings.Internal.StringInfo* msg) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientCommunicationSystem, uint, ACBindings.Internal.StringInfo*, void>)0x0056F640)(ref this, type, msg);

    /// <summary>Handles receipt of a player description notice by activating chat and talk focus features for the client communication system.
    /// <code>Offset: 0x0056F690
    /// void __thiscall ClientCommunicationSystem::RecvNotice_PlayerDescReceived(ClientCommunicationSystem*,const CACQualities*,const CPlayerModule*)</code>
    /// </summary>
    /// <param name="i_playerDesc">Qualities data describing the player received from the server.</param>
    /// <param name="i_playerModule">Player module containing state and metadata for the player.</param>
    public void RecvNotice_PlayerDescReceived(ACBindings.Internal.CACQualities* i_playerDesc, ACBindings.Internal.CPlayerModule* i_playerModule) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientCommunicationSystem, ACBindings.Internal.CACQualities*, ACBindings.Internal.CPlayerModule*, void>)0x0056F690)(ref this, i_playerDesc, i_playerModule);

    /// <summary>Handles a notification of player option changes, enabling chat talk focus when the option pertains to chat channels such as general, trade, LFG, roleplay, or society.
    /// <code>Offset: 0x0056F6A0
    /// void __thiscall ClientCommunicationSystem::RecvNotice_PlayerOptionChanged(ClientCommunicationSystem*,PlayerOption)</code>
    /// </summary>
    /// <param name="i_eOption">The specific player option that has changed.</param>
    public void RecvNotice_PlayerOptionChanged(ACBindings.Internal.PlayerOption i_eOption) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientCommunicationSystem, ACBindings.Internal.PlayerOption, void>)0x0056F6A0)(ref this, i_eOption);

    /// <summary>Destroys a ClientCommunicationSystem instance by unregistering its notice handlers, releasing reference‑counted strings, clearing the command hash table, and resetting internal structures.
    /// <code>Offset: 0x0056F860
    /// void __thiscall ClientCommunicationSystem::~ClientCommunicationSystem(ClientCommunicationSystem*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientCommunicationSystem, void>)0x0056F860)(ref this);

    /// <summary>Updates the client communication system with a new squelch database and applies it to the current user context if one is selected.
    /// <code>Offset: 0x0056F940
    /// unsigned int __thiscall ClientCommunicationSystem::Handle_Communication__SetSquelchDB(ClientCommunicationSystem*,const SquelchDB*)</code>
    /// </summary>
    /// <param name="db">A pointer to the SquelchDB object containing account, character, and global squelch information to be applied.</param>
    /// <returns>A status code; zero indicates that the operation completed successfully.</returns>
    public uint Handle_Communication__SetSquelchDB(ACBindings.Internal.SquelchDB* db) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientCommunicationSystem, ACBindings.Internal.SquelchDB*, uint>)0x0056F940)(ref this, db);

    /// <summary>Checks whether a chat message contains disallowed content such as private messages or line breaks.
    /// <code>Offset: 0x0056FB20
    /// BOOL __stdcall ClientCommunicationSystem::IsMessageSafe(char*)</code>
    /// </summary>
    /// <param name="String">The chat message to evaluate.</param>
    /// <returns>True if the message does not contain &lt;tell: tags and newline characters; otherwise false.</returns>
    public static byte IsMessageSafe(sbyte* String) => ((delegate* unmanaged[Stdcall]<sbyte*, byte>)0x0056FB20)(String);

    /// <summary>Executes the “Allegiance Hometown” command, recalling the player to their allegiance hometown when no arguments are supplied. If any arguments are provided, displays an error message indicating that the command takes no arguments and returns success.
    /// <code>Offset: 0x0056FCE0
    /// bool __thiscall ClientCommunicationSystem::DoAllegianceHometown(ClientCommunicationSystem*,int,char**)</code>
    /// </summary>
    /// <param name="argc">The number of arguments passed to the command.</param>
    /// <param name="argv">An array of argument strings (unused by this command).</param>
    /// <returns>True if the command was processed successfully; otherwise false.</returns>
    public byte DoAllegianceHometown(int argc, sbyte** argv) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientCommunicationSystem, int, sbyte**, byte>)0x0056FCE0)(ref this, argc, argv);

    /// <summary>Processes the "allegiance house" command by interpreting subcommands such as guest open/close or storage open/close and dispatching the corresponding events. Returns whether a valid action was performed.
    /// <code>Offset: 0x0056FD40
    /// bool __thiscall ClientCommunicationSystem::DoAllegianceHouse(ClientCommunicationSystem*,int,char**)</code>
    /// </summary>
    /// <param name="argc">The number of arguments supplied to the command.</param>
    /// <param name="argv">Array of argument strings following the command.</param>
    /// <returns>True if the command matched a known subcommand and the event was triggered; otherwise false.</returns>
    public byte DoAllegianceHouse(int argc, sbyte** argv) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientCommunicationSystem, int, sbyte**, byte>)0x0056FD40)(ref this, argc, argv);

    /// <summary>Creates help text describing how to broadcast to the specified channel and stores it in the supplied buffer.
    /// <code>Offset: 0x00570060
    /// char __stdcall ClientCommunicationSystem::HelpStupidChannelHack(int,int,char**)</code>
    /// </summary>
    /// <param name="a1">Ignored; reserved for future use or client context.</param>
    /// <param name="a2">Pointer (passed as an integer) to a null‑terminated string containing the channel identifier and optional suffix.</param>
    /// <param name="a3">Output parameter that receives a newly allocated string with the help message. If a previous buffer was supplied it is released.</param>
    /// <returns>Always returns 1 to indicate success.</returns>
    public static sbyte HelpStupidChannelHack(int a1, int a2, sbyte** a3) => ((delegate* unmanaged[Stdcall]<int, int, sbyte**, sbyte>)0x00570060)(a1, a2, a3);

    /// <summary>Joins a chat channel based on the provided argument and updates the player's chat settings.
    /// <code>Offset: 0x005702E0
    /// bool __thiscall ClientCommunicationSystem::DoJoinChat(ClientCommunicationSystem*,int,char**)</code>
    /// </summary>
    /// <param name="argc">Number of remaining arguments after the command name.</param>
    /// <param name="argv">Array of strings; the first element specifies the desired chat channel (e.g., "Allegiance", "General").</param>
    /// <returns>True if a recognized channel was joined and settings updated; otherwise, false.</returns>
    public byte DoJoinChat(int argc, sbyte** argv) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientCommunicationSystem, int, sbyte**, byte>)0x005702E0)(ref this, argc, argv);

    /// <summary>Leaves the specified chat channel. Supports “Allegiance”, “General”, “Trade”, “LFG”, “Roleplay” and society channels (“Society” or “Soc”).
    /// <code>Offset: 0x005705C0
    /// bool __thiscall ClientCommunicationSystem::DoLeaveChat(ClientCommunicationSystem*,int,char**)</code>
    /// </summary>
    /// <param name="argc">The number of arguments supplied.</param>
    /// <param name="argv">Pointer to the first argument string indicating the chat channel to leave.</param>
    /// <returns>True if a known channel was specified and left successfully; otherwise, false.</returns>
    public byte DoLeaveChat(int argc, sbyte** argv) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientCommunicationSystem, int, sbyte**, byte>)0x005705C0)(ref this, argc, argv);

    /// <summary>Enables or disables chat by modifying the global squelch state based on a single argument.
    /// <code>Offset: 0x005708A0
    /// bool __thiscall ClientCommunicationSystem::DoChatToggle(ClientCommunicationSystem*,int,char**)</code>
    /// </summary>
    /// <param name="argc">The number of arguments supplied to the command; expected to be 1 for a valid toggle request.</param>
    /// <param name="argv">An array of strings containing the command argument, which should be either "on" or "off".</param>
    /// <returns>True if the squelch state was successfully updated (or a help message was displayed); otherwise, false when the underlying event fails.</returns>
    public byte DoChatToggle(int argc, sbyte** argv) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientCommunicationSystem, int, sbyte**, byte>)0x005708A0)(ref this, argc, argv);

    /// <summary>Handles the marketplace command, displaying usage information when arguments are supplied or teleporting the player to the market area when no arguments are provided.
    /// <code>Offset: 0x00570AB0
    /// bool __thiscall ClientCommunicationSystem::DoMarketplace(ClientCommunicationSystem*,int,char**)</code>
    /// </summary>
    /// <param name="argc">The number of arguments supplied with the command.</param>
    /// <param name="argv">An array of argument strings (unused for this operation).</param>
    /// <returns>True on successful execution; always returns true.</returns>
    public byte DoMarketplace(int argc, sbyte** argv) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientCommunicationSystem, int, sbyte**, byte>)0x00570AB0)(ref this, argc, argv);

    /// <summary>Handles the “fillcomps” client command, allowing players to clear their component list or request buying a specific spell component type and amount. Sends chat messages and UI updates accordingly.
    /// <code>Offset: 0x00570B20
    /// bool __thiscall ClientCommunicationSystem::DoFillComponents(ClientCommunicationSystem*,int,char**)</code>
    /// </summary>
    /// <param name="argc">Number of arguments supplied with the command.</param>
    /// <param name="argv">Array of argument strings provided by the player.</param>
    /// <returns>True after processing the command; the function never returns false.</returns>
    public byte DoFillComponents(int argc, sbyte** argv) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientCommunicationSystem, int, sbyte**, byte>)0x00570B20)(ref this, argc, argv);

    /// <summary>Processes the ‘saveui’ command, saving the current UI layout to a file. Accepts an optional filename argument of up to 16 characters; otherwise displays usage help.
    /// <code>Offset: 0x00570DC0
    /// bool __thiscall ClientCommunicationSystem::DoSaveUI(ClientCommunicationSystem*,int,char**)</code>
    /// </summary>
    /// <param name="argc">Number of arguments supplied after the command keyword.</param>
    /// <param name="argv">Array of argument strings.</param>
    /// <returns>True if the command was handled (always true).</returns>
    public byte DoSaveUI(int argc, sbyte** argv) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientCommunicationSystem, int, sbyte**, byte>)0x00570DC0)(ref this, argc, argv);

    /// <summary>Loads the UI file specified by the command arguments, displaying usage information when the number or length of arguments is incorrect.
    /// <code>Offset: 0x00570F20
    /// bool __thiscall ClientCommunicationSystem::DoLoadUI(ClientCommunicationSystem*,int,char**)</code>
    /// </summary>
    /// <param name="argc">Number of arguments supplied to the command, including the command name.</param>
    /// <param name="argv">Array of argument strings passed to the command.</param>
    /// <returns>True after processing; indicates that the command has been handled.</returns>
    public byte DoLoadUI(int argc, sbyte** argv) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientCommunicationSystem, int, sbyte**, byte>)0x00570F20)(ref this, argc, argv);

    /// <summary>Saves the current UI layout automatically when no arguments are supplied; displays a help message if any arguments are provided.
    /// <code>Offset: 0x00571080
    /// bool __thiscall ClientCommunicationSystem::DoSaveAutoUI(ClientCommunicationSystem*,int,char**)</code>
    /// </summary>
    /// <param name="argc">The number of command-line arguments. A value of zero triggers an auto‑save; any other value causes usage information to be shown.</param>
    /// <param name="argv">Array of argument strings (unused by this function).</param>
    /// <returns>True, indicating that the operation completed successfully (even when displaying help).</returns>
    public byte DoSaveAutoUI(int argc, sbyte** argv) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientCommunicationSystem, int, sbyte**, byte>)0x00571080)(ref this, argc, argv);

    /// <summary>Loads the auto UI when invoked without arguments; otherwise displays a usage hint.
    /// <code>Offset: 0x00571100
    /// bool __thiscall ClientCommunicationSystem::DoLoadAutoUI(ClientCommunicationSystem*,int,char**)</code>
    /// </summary>
    /// <param name="argc">Number of command-line arguments supplied to the command.</param>
    /// <param name="argv">Array of argument strings (unused in this implementation).</param>
    /// <returns>True if the operation succeeded; always true in current implementation.</returns>
    public byte DoLoadAutoUI(int argc, sbyte** argv) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientCommunicationSystem, int, sbyte**, byte>)0x00571100)(ref this, argc, argv);

    /// <summary>toggles the user interface lock state for the current player and broadcasts a global message when invoked without arguments; otherwise displays usage help.
    /// <code>Offset: 0x00571180
    /// bool __thiscall ClientCommunicationSystem::DoLockUI(ClientCommunicationSystem*,int,char**)</code>
    /// </summary>
    /// <param name="argc">Number of command-line arguments supplied to the command.</param>
    /// <param name="argv">Array of argument strings, unused by this implementation.</param>
    /// <returns>True on success (always).</returns>
    public byte DoLockUI(int argc, sbyte** argv) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientCommunicationSystem, int, sbyte**, byte>)0x00571180)(ref this, argc, argv);

    /// <summary>Handles the house recall command; teleports player to their home when invoked without arguments, otherwise displays help information.
    /// <code>Offset: 0x00571220
    /// bool __thiscall ClientCommunicationSystem::DoHouseRecall(ClientCommunicationSystem*,int,char**)</code>
    /// </summary>
    /// <param name="argc">Number of arguments supplied with the command.</param>
    /// <param name="argv">Array of argument strings (not used in this implementation).</param>
    /// <returns>True if the command was processed successfully.</returns>
    public byte DoHouseRecall(int argc, sbyte** argv) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientCommunicationSystem, int, sbyte**, byte>)0x00571220)(ref this, argc, argv);

    /// <summary>Executes the mansion recall command, teleporting the player to their home when no arguments are supplied or displaying help text when arguments are present.
    /// <code>Offset: 0x00571280
    /// bool __thiscall ClientCommunicationSystem::DoMansionRecall(ClientCommunicationSystem*,int,char**)</code>
    /// </summary>
    /// <param name="argc">The number of arguments passed to the command.</param>
    /// <param name="argv">The array of argument strings (unused for this command).</param>
    /// <returns>True if the recall operation succeeded; otherwise false.</returns>
    public byte DoMansionRecall(int argc, sbyte** argv) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientCommunicationSystem, int, sbyte**, byte>)0x00571280)(ref this, argc, argv);

    /// <summary>Processes the “house available list” command by interpreting a house type argument (“apartment”, “cottage”, “villa”, or “mansion”) and invoking the corresponding event handler to display available houses. If an invalid type is supplied, it notifies the user with usage instructions.
    /// <code>Offset: 0x005712E0
    /// bool __thiscall ClientCommunicationSystem::DoHouseAvailableList(ClientCommunicationSystem*,int,char**)</code>
    /// </summary>
    /// <param name="argc">The number of arguments supplied to the command.</param>
    /// <param name="argv">An array of argument strings; the first element specifies the house type.</param>
    /// <returns>True if the command was handled successfully; otherwise false.</returns>
    public byte DoHouseAvailableList(int argc, sbyte** argv) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientCommunicationSystem, int, sbyte**, byte>)0x005712E0)(ref this, argc, argv);

    /// <summary>Handles the @framerate command, toggling on‑screen frame rate display when called without arguments or reporting an error when arguments are supplied.
    /// <code>Offset: 0x005715A0
    /// bool __thiscall ClientCommunicationSystem::DoFrameRate(ClientCommunicationSystem*,int,char**)</code>
    /// </summary>
    /// <param name="argc">Number of arguments passed to the command.</param>
    /// <param name="argv">Array of argument strings (unused).</param>
    /// <returns>True if the command was processed; always true in this implementation.</returns>
    public byte DoFrameRate(int argc, sbyte** argv) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientCommunicationSystem, int, sbyte**, byte>)0x005715A0)(ref this, argc, argv);

    /// <summary>Decrements the object's reference count and destroys the object when the count reaches zero.
    /// <code>Offset: 0x00571870
    /// unsigned int __thiscall ClientCommunicationSystem::Release(ClientCommunicationSystem*)</code>
    /// </summary>
    /// <returns>The remaining reference count after the release operation.</returns>
    public uint Release() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientCommunicationSystem, uint>)0x00571870)(ref this);

    /// <summary>Formats and broadcasts a channel message to the client display, handling different channel types and user roles. Builds the final chat line with appropriate prefixes, applies filtering rules, and appends it to the UI text area.
    /// <code>Offset: 0x00571960
    /// int __thiscall ClientCommunicationSystem::Handle_Communication__ChannelBroadcast(void*,char*,char*,int)</code>
    /// </summary>
    /// <param name="Source">Identifier or type of the channel from which the message originates.</param>
    /// <param name="a3">Text content of the message to be broadcasted.</param>
    /// <param name="a4">Supplementary string containing contextual information such as the channel name, used when constructing the output.</param>
    /// <returns>Zero on success.</returns>
    public int Handle_Communication__ChannelBroadcast(sbyte* Source, sbyte* a3, int a4) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientCommunicationSystem, sbyte*, sbyte*, int, int>)0x00571960)(ref this, Source, a3, a4);

    /// <summary>Processes a character age‑query reply, formats the playtime message and posts it to the chat scroll.
    /// <code>Offset: 0x00571FA0
    /// int __thiscall ClientCommunicationSystem::Handle_Character__QueryAgeResponse(void*,int,int*)</code>
    /// </summary>
    /// <param name="a2">Pointer to a structure containing character data; includes a flag indicating whether the query is for the local player and the character’s name string at offset 20.</param>
    /// <param name="a3">Reference‑counted response buffer that holds the age/playtime text at offset 20.</param>
    /// <returns>Zero, indicating successful handling of the response.</returns>
    public int Handle_Character__QueryAgeResponse(int a2, int* a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientCommunicationSystem, int, int*, int>)0x00571FA0)(ref this, a2, a3);

    /// <summary>Handles an incoming speech packet, formats the speaker name and text based on special markers, applies class checks, then appends the formatted line to the chat scroll.
    /// <code>Offset: 0x00572070
    /// int __thiscall ClientCommunicationSystem::Handle_Communication__HearSpeech(void*,CLogonHeader::HandshakeWireData,unsigned int,unsigned int)</code>
    /// </summary>
    /// <param name="this">Pointer to the ClientCommunicationSystem instance.</param>
    /// <param name="a2">Handshake data containing the client version string and authentication data used for message formatting.</param>
    /// <param name="ArgList">Identifier of the speaking source or command list that influences how the message is displayed.</param>
    /// <param name="msg_type">Numeric code indicating the type of communication (e.g., chat, tell).</param>
    /// <returns>An integer status code; zero on success.</returns>
    public int Handle_Communication__HearSpeech(ACBindings.Internal.CLogonHeader.HandshakeWireData a2, uint ArgList, uint msg_type) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientCommunicationSystem, ACBindings.Internal.CLogonHeader.HandshakeWireData, uint, uint, int>)0x00572070)(ref this, a2, ArgList, msg_type);

    /// <summary>Processes incoming direct speech from a client, determines whether the sender is an Olthoi or human, formats the message (handling special tell messages when appropriate), and adds it to the chat scroll.
    /// <code>Offset: 0x00572370
    /// int __thiscall ClientCommunicationSystem::Handle_Communication__HearDirectSpeech(void*,CLogonHeader::HandshakeWireData,unsigned int,void*,int,int)</code>
    /// </summary>
    /// <param name="this">ClientCommunicationSystem instance handling the message.</param>
    /// <param name="a2">Handshake data containing the speaker's name string and optional authentication data used for determining Olthoi status.</param>
    /// <param name="ArgList">Identifier of the sender; if in 0x50000001–0x6FFFFFFF, treated as a direct tell from that user.</param>
    /// <param name="a4">Optional buffer placeholder; only used when matching ArgList to produce an alternate message format.</param>
    /// <param name="a5">Display flag passed to AddTextToScroll controlling formatting attributes.</param>
    /// <returns>Always 0 (success).</returns>
    public int Handle_Communication__HearDirectSpeech(ACBindings.Internal.CLogonHeader.HandshakeWireData a2, uint ArgList, System.IntPtr a4, int a5, int a6) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientCommunicationSystem, ACBindings.Internal.CLogonHeader.HandshakeWireData, uint, System.IntPtr, int, int, int>)0x00572370)(ref this, a2, ArgList, a4, a5, a6);

    /// <summary>Handles a failure event by interpreting the provided error code and displaying an appropriate message to the user.
    /// <code>Offset: 0x00572760
    /// LONG __thiscall ClientCommunicationSystem::HandleFailureEvent(void*,unsigned int,const wchar_t**)</code>
    /// </summary>
    /// <param name="this">Pointer to the ClientCommunicationSystem instance handling the event.</param>
    /// <param name="i_error">The numeric identifier of the specific failure that occurred.</param>
    /// <param name="a3">Optional wide‑character string arguments used in formatting error messages.</param>
    /// <returns>Zero on success or a non‑zero value indicating an internal reference count after processing.</returns>
    public int HandleFailureEvent(uint i_error, System.IntPtr a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientCommunicationSystem, uint, System.IntPtr, int>)0x00572760)(ref this, i_error, a3);

    /// <summary>Handles allegiance chat commands, toggling chat listening or performing actions such as kicking, gagging, and ungagging players based on supplied arguments.
    /// <code>Offset: 0x00576A80
    /// bool __thiscall ClientCommunicationSystem::DoAllegianceChat(ClientCommunicationSystem*,int,char**)</code>
    /// </summary>
    /// <param name="argc">The number of command-line arguments.</param>
    /// <param name="argv">Array of argument strings passed to the command.</param>
    /// <returns>True if a recognized command was successfully processed; otherwise false.</returns>
    public byte DoAllegianceChat(int argc, sbyte** argv) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientCommunicationSystem, int, sbyte**, byte>)0x00576A80)(ref this, argc, argv);

    /// <summary>Broadcasts an allegiance announcement to the appropriate channel using the supplied command arguments.
    /// <code>Offset: 0x00576FC0
    /// bool __thiscall ClientCommunicationSystem::DoAllegianceBroadcast(ClientCommunicationSystem*,int,char**)</code>
    /// </summary>
    /// <param name="argc">The count of argument strings passed with the command.</param>
    /// <param name="argv">An array of C‑style strings containing the command arguments; the function may inspect a marker preceding the first element for special handling.</param>
    /// <returns>True if the broadcast event was successfully queued, otherwise false.</returns>
    public byte DoAllegianceBroadcast(int argc, sbyte** argv) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientCommunicationSystem, int, sbyte**, byte>)0x00576FC0)(ref this, argc, argv);

    /// <summary>Processes an allegiance ban command, handling listing bans, adding a new ban or removing an existing one based on the first argument and validating input before delegating to CM_Allegiance events.
    /// <code>Offset: 0x00577070
    /// bool __thiscall ClientCommunicationSystem::DoAllegianceBan(ClientCommunicationSystem*,int,char**)</code>
    /// </summary>
    /// <param name="argc">The number of arguments supplied for the command.</param>
    /// <param name="argv">An array of strings containing the command arguments.</param>
    /// <returns>True if the command was recognized and executed successfully; otherwise false.</returns>
    public byte DoAllegianceBan(int argc, sbyte** argv) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientCommunicationSystem, int, sbyte**, byte>)0x00577070)(ref this, argc, argv);

    /// <summary>Handles a client command to request allegiance information for a specified name, validating arguments and sending the appropriate response or error message.
    /// <code>Offset: 0x00577330
    /// bool __thiscall ClientCommunicationSystem::DoAllegianceInfo(ClientCommunicationSystem*,int,char**)</code>
    /// </summary>
    /// <param name="argc">Number of arguments supplied with the command.</param>
    /// <param name="argv">Array of argument strings provided by the client.</param>
    /// <returns>True if the command was processed successfully (either an information request sent or an error message returned); otherwise false.</returns>
    public byte DoAllegianceInfo(int argc, sbyte** argv) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientCommunicationSystem, int, sbyte**, byte>)0x00577330)(ref this, argc, argv);

    /// <summary>Handles the "allegiance officer" command from the client console, performing actions such as list, clear, remove, set or add based on the first argument.
    /// <code>Offset: 0x00577420
    /// bool __thiscall ClientCommunicationSystem::DoAllegianceOfficer(ClientCommunicationSystem*,const OLECHAR*,char**)</code>
    /// </summary>
    /// <param name="argc">The first argument string indicating the subcommand (e.g., "list", "clear", "remove", "set"). If null, lists all officers.</param>
    /// <param name="argv">Array of subsequent command arguments; may contain an officer name and a level for set/add commands.</param>
    /// <returns>True if the command was processed successfully; otherwise false.</returns>
    public byte DoAllegianceOfficer(System.IntPtr argc, sbyte** argv) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientCommunicationSystem, System.IntPtr, sbyte**, byte>)0x00577420)(ref this, argc, argv);

    /// <summary>Processes the “allegiance officer title” command, supporting subcommands to list, clear, or set titles for allegiance officers.
    /// <code>Offset: 0x005777E0
    /// bool __thiscall ClientCommunicationSystem::DoAllegianceOfficerTitle(ClientCommunicationSystem*,int,char**)</code>
    /// </summary>
    /// <param name="argc">The number of arguments supplied with the command.</param>
    /// <param name="argv">An array of argument strings passed to the command.</param>
    /// <returns>True if a recognized subcommand was executed successfully; otherwise false.</returns>
    public byte DoAllegianceOfficerTitle(int argc, sbyte** argv) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientCommunicationSystem, int, sbyte**, byte>)0x005777E0)(ref this, argc, argv);

    /// <summary>Handles the Allegiance Name command by querying, setting, or clearing the current name based on supplied arguments.
    /// <code>Offset: 0x00577A50
    /// bool __thiscall ClientCommunicationSystem::DoAllegianceName(ClientCommunicationSystem*,const char*,char**)</code>
    /// </summary>
    /// <param name="argc">The first argument string indicating the desired operation ("set", "clear") or null to request a query.</param>
    /// <param name="argv">Additional arguments providing the new name when setting; may be null if no extra data is needed.</param>
    /// <returns>True if the command was successfully processed (query, set, or clear); otherwise false for invalid input.</returns>
    public byte DoAllegianceName(sbyte* argc, sbyte** argv) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientCommunicationSystem, sbyte*, sbyte**, byte>)0x00577A50)(ref this, argc, argv);

    /// <summary>Handles the allegiance lock command by interpreting its arguments ('on', 'off', 'toggle', 'check', 'bypass') and invoking the corresponding alliance action events. If no argument is supplied, performs a status check.
    /// <code>Offset: 0x00577C40
    /// bool __thiscall ClientCommunicationSystem::DoAllegianceLock(ClientCommunicationSystem*,int,char**)</code>
    /// </summary>
    /// <param name="argc">The number of arguments supplied to the command.</param>
    /// <param name="argv">An array of pointers to the argument strings.</param>
    /// <returns>True if an event was successfully triggered; otherwise false.</returns>
    public byte DoAllegianceLock(int argc, sbyte** argv) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientCommunicationSystem, int, sbyte**, byte>)0x00577C40)(ref this, argc, argv);

    /// <summary>Processes a Message of the Day (MOTD) command, handling query, set, or clear operations based on supplied arguments.
    /// <code>Offset: 0x00577F20
    /// bool __thiscall ClientCommunicationSystem::DoMotd(ClientCommunicationSystem*,const char*,char**)</code>
    /// </summary>
    /// <param name="argc">The first argument string specifying the action ('set', 'clear', or omitted for query).</param>
    /// <param name="argv">Array of additional argument strings used when setting the MOTD; ignored otherwise.</param>
    /// <returns>True if the operation succeeded (setting or clearing), false if it failed. When no arguments are supplied, returns the result of querying the current MOTD status.</returns>
    public byte DoMotd(sbyte* argc, sbyte** argv) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientCommunicationSystem, sbyte*, sbyte**, byte>)0x00577F20)(ref this, argc, argv);

    /// <summary>Populates the supplied string with help information for the “motd” command, applying optional formatting from a3.
    /// <code>Offset: 0x00578100
    /// char __stdcall ClientCommunicationSystem::HelpMotd(char*,int,char**)</code>
    /// </summary>
    /// <param name="Source">String buffer into which the help text is written; must be reference‑counted and allocated before calling.</param>
    /// <param name="a2">Unused parameter reserved for future use (e.g., command length).</param>
    /// <param name="a3">Array of strings used to substitute arguments into the help message.</param>
    /// <returns>Always returns 1 to indicate successful completion.</returns>
    public static sbyte HelpMotd(sbyte* Source, int a2, sbyte** a3) => ((delegate* unmanaged[Stdcall]<sbyte*, int, sbyte**, sbyte>)0x00578100)(Source, a2, a3);

    /// <summary>Executes a command directed at a chat channel, validating the channel ID, assembling the command string from arguments, and broadcasting the event to the specified channel.
    /// <code>Offset: 0x00578270
    /// bool __thiscall ClientCommunicationSystem::DoChannelCommand(ClientCommunicationSystem*,int,char**)</code>
    /// </summary>
    /// <param name="argc">The number of command arguments supplied.</param>
    /// <param name="argv">Array of argument strings for the command.</param>
    /// <returns>True if the command was successfully broadcast; otherwise false (e.g., invalid channel or no arguments).</returns>
    public byte DoChannelCommand(int argc, sbyte** argv) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientCommunicationSystem, int, sbyte**, byte>)0x00578270)(ref this, argc, argv);

    /// <summary>Creates help text for the “join” chat command, inserting an optional channel tag if provided and storing the resulting message in the supplied buffer.
    /// <code>Offset: 0x00578350
    /// char __thiscall ClientCommunicationSystem::HelpJoinChat(char*,int,int,char**)</code>
    /// </summary>
    /// <param name="a2">Unused parameter.</param>
    /// <param name="a3">Unused parameter.</param>
    /// <param name="a4">Pointer to a string buffer where the help text will be written.</param>
    /// <returns>Always returns 1 to indicate success.</returns>
    public sbyte HelpJoinChat(int a2, int a3, sbyte** a4) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientCommunicationSystem, int, int, sbyte**, sbyte>)0x00578350)(ref this, a2, a3, a4);

    /// <summary>Outputs help information for the 'leave' chat command, formatting usage text into the provided buffer.
    /// <code>Offset: 0x005783A0
    /// char __thiscall ClientCommunicationSystem::HelpLeaveChat(char*,int,int,char**)</code>
    /// </summary>
    /// <param name="a4">Pointer to a character pointer that will receive the constructed help string.</param>
    /// <returns>Non-zero if the help message was successfully written; zero otherwise.</returns>
    public sbyte HelpLeaveChat(int a2, int a3, sbyte** a4) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientCommunicationSystem, int, int, sbyte**, sbyte>)0x005783A0)(ref this, a2, a3, a4);

    /// <summary>Generates help strings for reply commands and writes them into the supplied buffer.
    /// <code>Offset: 0x00578820
    /// char __stdcall ClientCommunicationSystem::HelpReply(char*,int,char*)</code>
    /// </summary>
    /// <param name="Source">Optional prefix; when not null the generated help lines include a “&lt;text&gt;” placeholder, otherwise concise command names are used.</param>
    /// <param name="a2">Unused; retained for compatibility with other help functions.</param>
    /// <param name="a3">Buffer that receives the concatenated help strings.</param>
    /// <returns>1 to indicate successful generation and output of the help text.</returns>
    public static sbyte HelpReply(sbyte* Source, int a2, sbyte* a3) => ((delegate* unmanaged[Stdcall]<sbyte*, int, sbyte*, sbyte>)0x00578820)(Source, a2, a3);

    /// <summary>Re-sends the last private message to the previously told player, verifying a recipient has been set with @tell first.
    /// <code>Offset: 0x005789A0
    /// bool __thiscall ClientCommunicationSystem::DoReTell(ClientCommunicationSystem*,const OLECHAR*,char**)</code>
    /// </summary>
    /// <param name="argc">Wide-character string containing the raw command input for this operation.</param>
    /// <param name="argv">Array of argument strings passed by reference; may be modified during processing.</param>
    /// <returns>Always true to indicate successful handling of the command.</returns>
    public byte DoReTell(System.IntPtr argc, sbyte** argv) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientCommunicationSystem, System.IntPtr, sbyte**, byte>)0x005789A0)(ref this, argc, argv);

    /// <summary>Provides help text for the @retell command, formatting it with usage details based on whether a source string is supplied.
    /// <code>Offset: 0x00578B50
    /// char __stdcall ClientCommunicationSystem::HelpReTell(char*,int,char**)</code>
    /// </summary>
    /// <param name="Source">Pointer to a character buffer that will receive the formatted help message; may be null to request a minimal description.</param>
    /// <param name="a2">Unspecified; present for compatibility with other command handlers but not used in this implementation.</param>
    /// <param name="a3">Internal string list parameter, unused by this function. Included only for signature consistency.</param>
    /// <returns>True (1) to indicate the help message was generated successfully.</returns>
    public static sbyte HelpReTell(sbyte* Source, int a2, sbyte** a3) => ((delegate* unmanaged[Stdcall]<sbyte*, int, sbyte**, sbyte>)0x00578B50)(Source, a2, a3);

    /// <summary>Processes a private chat command by parsing the target name and message separated by a comma, then sends the message or displays an error if the format is incorrect.
    /// <code>Offset: 0x00578C10
    /// bool __thiscall ClientCommunicationSystem::DoTell(ClientCommunicationSystem*,volatile LONG*,char**)</code>
    /// </summary>
    /// <param name="argc">The number of arguments supplied to the /tell command.</param>
    /// <param name="argv">An array of strings containing the command arguments.</param>
    /// <returns>True when the command has been handled (always returns true).</returns>
    public byte DoTell(int* argc, sbyte** argv) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientCommunicationSystem, int*, sbyte**, byte>)0x00578C10)(ref this, argc, argv);

    /// <summary>Provides help text for the @tell and related commands, writing the description into the supplied buffer.
    /// <code>Offset: 0x00578DD0
    /// char __stdcall ClientCommunicationSystem::HelpTell(char*,int,char**)</code>
    /// </summary>
    /// <param name="Source">Buffer to receive the help message; after execution it contains a descriptive string.</param>
    /// <param name="a2">Unspecified parameter (unused in this implementation).</param>
    /// <param name="a3">Array of strings for appending additional help content; may be null if no extra text is required.</param>
    /// <returns>Always returns 1 to indicate success.</returns>
    public static sbyte HelpTell(sbyte* Source, int a2, sbyte** a3) => ((delegate* unmanaged[Stdcall]<sbyte*, int, sbyte**, sbyte>)0x00578DD0)(Source, a2, a3);

    /// <summary>Populates the supplied buffers with detailed usage information for the @afk command, including its subcommands.
    /// <code>Offset: 0x00578E30
    /// char __stdcall ClientCommunicationSystem::HelpAFK(char*,int,char*)</code>
    /// </summary>
    /// <param name="Source">Buffer to receive the primary help message for the @afk command.</param>
    /// <param name="a2">Unused parameter; retained for compatibility with the command interface.</param>
    /// <param name="a3">Buffer to receive additional help lines describing AFK subcommands such as on, off, and msg.</param>
    /// <returns>Always returns 1 to indicate successful completion of the help text generation.</returns>
    public static sbyte HelpAFK(sbyte* Source, int a2, sbyte* a3) => ((delegate* unmanaged[Stdcall]<sbyte*, int, sbyte*, sbyte>)0x00578E30)(Source, a2, a3);

    /// <summary>Provides detailed help text for corpse‑looting consent commands and appends it to the supplied buffer.
    /// <code>Offset: 0x00578F90
    /// char __stdcall ClientCommunicationSystem::HelpConsent(char*,int,char**)</code>
    /// </summary>
    /// <param name="Source">Reference to a reference‑counted string where the help message is stored.</param>
    /// <param name="a2">Unused parameter, retained for compatibility.</param>
    /// <param name="a3">Pointer to an output buffer that receives the final help text.</param>
    /// <returns>Always returns 1 indicating success.</returns>
    public static sbyte HelpConsent(sbyte* Source, int a2, sbyte** a3) => ((delegate* unmanaged[Stdcall]<sbyte*, int, sbyte**, sbyte>)0x00578F90)(Source, a2, a3);

    /// <summary>Retrieves and displays the player's most recent outside death location to the client, or informs them that no record exists.
    /// <code>Offset: 0x00578FF0
    /// bool __thiscall ClientCommunicationSystem::DoCorpse(ClientCommunicationSystem*,int,char**)</code>
    /// </summary>
    /// <param name="argc">Number of arguments supplied with the command; unused for this operation.</param>
    /// <param name="argv">Array of argument strings supplied with the command; unused for this operation.</param>
    /// <returns>True if the player descriptor could be obtained and the command executed, otherwise false.</returns>
    public byte DoCorpse(int argc, sbyte** argv) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientCommunicationSystem, int, sbyte**, byte>)0x00578FF0)(ref this, argc, argv);

    /// <summary>Writes help information for the @corpse command to the supplied buffer.
    /// <code>Offset: 0x00579200
    /// char __stdcall ClientCommunicationSystem::HelpCorpse(char*,int,char**)</code>
    /// </summary>
    /// <param name="Source">Buffer that receives the formatted help message.</param>
    /// <param name="a2">Reserved; not used by this routine.</param>
    /// <param name="a3">Pointer to optional argument string(s) appended to the help text if present.</param>
    /// <returns>Always returns 1, indicating successful completion.</returns>
    public static sbyte HelpCorpse(sbyte* Source, int a2, sbyte** a3) => ((delegate* unmanaged[Stdcall]<sbyte*, int, sbyte**, sbyte>)0x00579200)(Source, a2, a3);

    /// <summary>Outputs help information for the @die command into the supplied string buffer.
    /// <code>Offset: 0x00579270
    /// char __stdcall ClientCommunicationSystem::HelpDie(char*,int,char**)</code>
    /// </summary>
    /// <param name="Source">Pointer to a PStringBase&lt;char&gt; instance that will receive the help text. If NULL, a brief message is written instead of the detailed description.</param>
    /// <param name="a2">Ignored by this function (present for signature compatibility).</param>
    /// <param name="a3">Optional pointer to additional text that may be appended to the generated help message.</param>
    /// <returns>Always returns 1 to indicate successful completion.</returns>
    public static sbyte HelpDie(sbyte* Source, int a2, sbyte** a3) => ((delegate* unmanaged[Stdcall]<sbyte*, int, sbyte**, sbyte>)0x00579270)(Source, a2, a3);

    /// <summary>Outputs the help text for the “lifestone” command into the supplied buffer.
    /// <code>Offset: 0x005792D0
    /// char __thiscall ClientCommunicationSystem::HelpLifestone(char*,int,int,char**)</code>
    /// </summary>
    /// <param name="a2">Unused parameter, reserved for future use.</param>
    /// <param name="a3">Unused parameter, reserved for future use.</param>
    /// <param name="a4">Pointer to a character array that receives the help message appended to existing content.</param>
    /// <returns>Always returns 1 to indicate success.</returns>
    public sbyte HelpLifestone(int a2, int a3, sbyte** a4) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientCommunicationSystem, int, int, sbyte**, sbyte>)0x005792D0)(ref this, a2, a3, a4);

    /// <summary>Provides help text for the marketplace command and writes it to the supplied buffer.
    /// <code>Offset: 0x00579320
    /// char __thiscall ClientCommunicationSystem::HelpMarketplace(char*,int,int,char**)</code>
    /// </summary>
    /// <param name="a2">Identifier of the command source (unused in this method).</param>
    /// <param name="a3">Number of arguments or flags provided with the command (unused).</param>
    /// <param name="a4">Pointer to a string buffer where the help message will be stored.</param>
    /// <returns>Always returns 1 to indicate success.</returns>
    public sbyte HelpMarketplace(int a2, int a3, sbyte** a4) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientCommunicationSystem, int, int, sbyte**, sbyte>)0x00579320)(ref this, a2, a3, a4);

    /// <summary>Handles a permit command by interpreting the first argument as “add” or “remove”, validating a target player name, and invoking the corresponding event to grant or revoke permissions.
    /// <code>Offset: 0x00579370
    /// bool __thiscall ClientCommunicationSystem::DoPermit(ClientCommunicationSystem*,int,char**)</code>
    /// </summary>
    /// <param name="argc">The number of arguments supplied after the command keyword.</param>
    /// <param name="argv">An array of pointers to the individual argument strings.</param>
    /// <returns>True if the command was processed successfully; false only when the add or remove permission event fails. Error cases such as missing arguments return true after displaying an informational message.</returns>
    public byte DoPermit(int argc, sbyte** argv) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientCommunicationSystem, int, sbyte**, byte>)0x00579370)(ref this, argc, argv);

    /// <summary>Builds help text for the @permit command and stores it in Source.
    /// <code>Offset: 0x00579640
    /// char __stdcall ClientCommunicationSystem::HelpPermit(char*,int,char**)</code>
    /// </summary>
    /// <param name="Source">Output string buffer that receives the help text.</param>
    /// <param name="a2">Unused placeholder parameter.</param>
    /// <param name="a3">Optional additional help text appended to the base description.</param>
    /// <returns>Always 1 indicating success.</returns>
    public static sbyte HelpPermit(sbyte* Source, int a2, sbyte** a3) => ((delegate* unmanaged[Stdcall]<sbyte*, int, sbyte**, sbyte>)0x00579640)(Source, a2, a3);

    /// <summary>Generates help text for the PK Arena command, optionally appending additional details supplied via a4.
    /// <code>Offset: 0x00579750
    /// char __thiscall ClientCommunicationSystem::HelpPKArena(char*,int,int,char**)</code>
    /// </summary>
    /// <param name="this">Pointer to the ClientCommunicationSystem instance.</param>
    /// <param name="a2">Unused parameter placeholder.</param>
    /// <param name="a3">Unused parameter placeholder.</param>
    /// <param name="a4">Optional pointer to a string containing extra help information that will be appended to the base message if present.</param>
    /// <returns>Always 1, indicating that help text was successfully generated and processed.</returns>
    public sbyte HelpPKArena(int a2, int a3, sbyte** a4) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientCommunicationSystem, int, int, sbyte**, sbyte>)0x00579750)(ref this, a2, a3, a4);

    /// <summary>Handles the “pklarena” console command, showing help when arguments are supplied or teleporting the player to the PKL Arena under suitable conditions.
    /// <code>Offset: 0x005797A0
    /// bool __thiscall ClientCommunicationSystem::DoPKLArena(ClientCommunicationSystem*,int,char**)</code>
    /// </summary>
    /// <param name="argc">The number of arguments provided with the command.</param>
    /// <param name="argv">Array of argument strings (unused in this implementation).</param>
    /// <returns>True upon completion; failure situations trigger internal events but the function always returns true.</returns>
    public byte DoPKLArena(int argc, sbyte** argv) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientCommunicationSystem, int, sbyte**, byte>)0x005797A0)(ref this, argc, argv);

    /// <summary>Creates the help text for the PKL Arena command and appends any supplied arguments through the fourth parameter.
    /// <code>Offset: 0x00579850
    /// char __thiscall ClientCommunicationSystem::HelpPKLArena(char*,int,int,char**)</code>
    /// </summary>
    /// <param name="a2">Command argument count or identifier (unused in this function).</param>
    /// <param name="a3">Placeholder parameter, not used by the implementation.</param>
    /// <param name="a4">Pointer to a buffer where the constructed help string is written; additional arguments can be appended from this buffer.</param>
    /// <returns>Always returns 1 to indicate successful generation of the help message.</returns>
    public sbyte HelpPKLArena(int a2, int a3, sbyte** a4) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientCommunicationSystem, int, int, sbyte**, sbyte>)0x00579850)(ref this, a2, a3, a4);

    /// <summary>Processes a client-issued emote command by parsing its arguments and triggering the corresponding event.
    /// <code>Offset: 0x005798A0
    /// bool __thiscall ClientCommunicationSystem::DoEmote(ClientCommunicationSystem*,int,char**)</code>
    /// </summary>
    /// <param name="argc">The number of argument strings supplied with the emote command.</param>
    /// <param name="argv">Array of C‑style strings containing the command’s arguments.</param>
    /// <returns>True if the emote was handled successfully; otherwise false.</returns>
    public byte DoEmote(int argc, sbyte** argv) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientCommunicationSystem, int, sbyte**, byte>)0x005798A0)(ref this, argc, argv);

    /// <summary>Generates help text for emote commands and writes it into the supplied buffer.
    /// <code>Offset: 0x00579950
    /// char __stdcall ClientCommunicationSystem::HelpEmote(char*,int,char*)</code>
    /// </summary>
    /// <param name="Source">Specifies which help topic to display. Pass NULL for general emotes help, pass (char*)1 for concise @emote/@emotes help, or any other value for a detailed description of the @emote command; the pointer is overwritten during processing.</param>
    /// <param name="a2">Unused parameter reserved for future use.</param>
    /// <param name="a3">Buffer where the generated help text is written.</param>
    /// <returns>1 indicating success.</returns>
    public static sbyte HelpEmote(sbyte* Source, int a2, sbyte* a3) => ((delegate* unmanaged[Stdcall]<sbyte*, int, sbyte*, sbyte>)0x00579950)(Source, a2, a3);

    /// <summary>Creates a standard list of emotes and optionally appends additional text supplied via a4, then releases any temporary string resources.
    /// <code>Offset: 0x00579A30
    /// char __thiscall ClientCommunicationSystem::HelpEmoteList(char*,int,int,char**)</code>
    /// </summary>
    /// <param name="this">The ClientCommunicationSystem instance on which the help command is invoked.</param>
    /// <param name="a2">Unspecified; currently ignored by the implementation.</param>
    /// <param name="a3">Unspecified; currently ignored by the implementation.</param>
    /// <param name="a4">Pointer to a character string that may be appended to the emote list if multiple references exist; can be null.</param>
    /// <returns>1, indicating successful execution of the help command.</returns>
    public sbyte HelpEmoteList(int a2, int a3, sbyte** a4) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientCommunicationSystem, int, int, sbyte**, sbyte>)0x00579A30)(ref this, a2, a3, a4);

    /// <summary>Provides help information for the @fillcomps command, which assists users in purchasing spell components in bulk.
    /// <code>Offset: 0x00579A80
    /// char __stdcall ClientCommunicationSystem::HelpFillComponents(char*,int,char**)</code>
    /// </summary>
    /// <param name="Source">Pointer to a string buffer that will receive the help text; if null, a brief message is returned instead of detailed usage instructions.</param>
    /// <param name="a2">Reserved parameter; currently unused by this function.</param>
    /// <param name="a3">Internal context used when appending text; callers do not need to supply a specific value for normal use.</param>
    /// <returns>Always returns 1 to indicate successful completion of the help request.</returns>
    public static sbyte HelpFillComponents(sbyte* Source, int a2, sbyte** a3) => ((delegate* unmanaged[Stdcall]<sbyte*, int, sbyte**, sbyte>)0x00579A80)(Source, a2, a3);

    /// <summary>Provides the help text for the “saveui” command, writing a description into the supplied buffer.
    /// <code>Offset: 0x00579AF0
    /// char __stdcall ClientCommunicationSystem::HelpSaveUI(char*,int,char**)</code>
    /// </summary>
    /// <param name="Source">Pointer to a character buffer where the help message will be written.</param>
    /// <param name="a2">Unused integer parameter (reserved for future use).</param>
    /// <param name="a3">Optional string array used when appending additional context to the help text.</param>
    /// <returns>Always returns 1 to indicate success.</returns>
    public static sbyte HelpSaveUI(sbyte* Source, int a2, sbyte** a3) => ((delegate* unmanaged[Stdcall]<sbyte*, int, sbyte**, sbyte>)0x00579AF0)(Source, a2, a3);

    /// <summary>Populates the supplied buffer with help text for the @loadui command, optionally appending extra information from a third argument. Always succeeds.
    /// <code>Offset: 0x00579B60
    /// char __stdcall ClientCommunicationSystem::HelpLoadUI(char*,int,char**)</code>
    /// </summary>
    /// <param name="Source">Pointer to a character buffer that receives the help message; may be null or a sentinel value indicating default formatting.</param>
    /// <param name="a2">Unspecified length parameter – not used within this function.</param>
    /// <param name="a3">Optional pointer to additional text to append to the generated help string when the source is not the sentinel value.</param>
    /// <returns>Always returns 1 to indicate successful execution.</returns>
    public static sbyte HelpLoadUI(sbyte* Source, int a2, sbyte** a3) => ((delegate* unmanaged[Stdcall]<sbyte*, int, sbyte**, sbyte>)0x00579B60)(Source, a2, a3);

    /// <summary>Generates the help text or description for the “saveautoui” command and appends it to the supplied output buffer.
    /// <code>Offset: 0x00579BD0
    /// char __stdcall ClientCommunicationSystem::HelpSaveAutoUI(char*,int,char**)</code>
    /// </summary>
    /// <param name="Source">A string that determines which variant of the help message is produced; when null a generic help message is generated, when equal to (char*)1 a concise command summary is set, otherwise a detailed description of storing the UI layout is used.</param>
    /// <param name="a2">Unused parameter reserved for future extensions.</param>
    /// <param name="a3">Pointer to an output buffer where the constructed help text will be appended.</param>
    /// <returns>Always returns 1 to indicate success. </returns>
    public static sbyte HelpSaveAutoUI(sbyte* Source, int a2, sbyte** a3) => ((delegate* unmanaged[Stdcall]<sbyte*, int, sbyte**, sbyte>)0x00579BD0)(Source, a2, a3);

    /// <summary>Provides the help text for the loadautoui command, optionally appending additional information supplied in a3.
    /// <code>Offset: 0x00579C40
    /// char __stdcall ClientCommunicationSystem::HelpLoadAutoUI(char*,int,char**)</code>
    /// </summary>
    /// <param name="Source">String buffer that receives or contains the help message. If null, the method populates it with a default help description.</param>
    /// <param name="a2">Unspecified; currently unused by this implementation.</param>
    /// <param name="a3">Pointer to a string whose contents are appended to the help text when Source is not empty and its length exceeds one character.</param>
    /// <returns>Always returns 1, indicating successful execution.</returns>
    public static sbyte HelpLoadAutoUI(sbyte* Source, int a2, sbyte** a3) => ((delegate* unmanaged[Stdcall]<sbyte*, int, sbyte**, sbyte>)0x00579C40)(Source, a2, a3);

    /// <summary>Generates help text for the @lockui command and writes it into the supplied buffer.
    /// <code>Offset: 0x00579CB0
    /// char __stdcall ClientCommunicationSystem::HelpLockUI(char*,int,char**)</code>
    /// </summary>
    /// <param name="Source">Buffer that receives the constructed help message; must point to an existing PStringBase instance.</param>
    /// <param name="a2">Unused argument, reserved for future use.</param>
    /// <param name="a3">Pointer to receive the allocated string pointer (may be null if not needed).</param>
    /// <returns>Always returns 1 to indicate successful completion.</returns>
    public static sbyte HelpLockUI(sbyte* Source, int a2, sbyte** a3) => ((delegate* unmanaged[Stdcall]<sbyte*, int, sbyte**, sbyte>)0x00579CB0)(Source, a2, a3);

    /// <summary>Attempts to add a friend using the supplied name. If no name is provided, displays an error message and returns true; otherwise forwards the request to the social system and returns the result.
    /// <code>Offset: 0x00579D80
    /// bool __thiscall ClientCommunicationSystem::DoFriendsAdd(ClientCommunicationSystem*,const OLECHAR*,char**)</code>
    /// </summary>
    /// <param name="argc">The raw argument string or count supplied with the command.</param>
    /// <param name="argv">Array of parsed arguments, where the first element contains the friend’s name.</param>
    /// <returns>True if the add‑friend operation was successful (or attempted); otherwise false.</returns>
    public byte DoFriendsAdd(System.IntPtr argc, sbyte** argv) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientCommunicationSystem, System.IntPtr, sbyte**, byte>)0x00579D80)(ref this, argc, argv);

    /// <summary>Removes a specified friend from the user’s contact list or removes all friends when the “-all” argument is supplied. If no name is given, displays an error message.
    /// <code>Offset: 0x00579E50
    /// bool __thiscall ClientCommunicationSystem::DoFriendsRemove(ClientCommunicationSystem*,int,char**)</code>
    /// </summary>
    /// <param name="argc">The number of arguments passed to the command.</param>
    /// <param name="argv">An array of strings containing the command arguments; typically the friend’s name or the special flag “-all”.</param>
    /// <returns>True if the removal operation was initiated successfully (or an error message was shown); otherwise false when the underlying social notice fails.</returns>
    public byte DoFriendsRemove(int argc, sbyte** argv) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientCommunicationSystem, int, sbyte**, byte>)0x00579E50)(ref this, argc, argv);

    /// <summary>Processes house‑guest management commands such as add, remove, list and allegiance modifications for a player's house.
    /// <code>Offset: 0x00579F70
    /// bool __thiscall ClientCommunicationSystem::DoHouseGuests(ClientCommunicationSystem*,int,char**)</code>
    /// </summary>
    /// <param name="argc">Number of arguments supplied to the command.</param>
    /// <param name="argv">Array of argument strings; argv[0] is the subcommand keyword (e.g., "add", "remove").</param>
    /// <returns>True if the command was handled successfully; otherwise false.</returns>
    public byte DoHouseGuests(int argc, sbyte** argv) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientCommunicationSystem, int, sbyte**, byte>)0x00579F70)(ref this, argc, argv);

    /// <summary>Executes house storage commands such as adding or removing permissions, listing guests, and modifying allegiance settings based on the first argument string.
    /// <code>Offset: 0x0057A330
    /// bool __thiscall ClientCommunicationSystem::DoHouseStorage(ClientCommunicationSystem*,int,char**)</code>
    /// </summary>
    /// <param name="argc">The number of command-line arguments supplied to the command.</param>
    /// <param name="argv">An array of pointers to null‑terminated strings containing the command arguments.</param>
    /// <returns>True if the command was processed successfully; otherwise, false.</returns>
    public byte DoHouseStorage(int argc, sbyte** argv) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientCommunicationSystem, int, sbyte**, byte>)0x0057A330)(ref this, argc, argv);

    /// <summary>Boots house guests according to the provided arguments. If “-all” is specified, all guests are removed from the house; otherwise a single guest matching the argument is booted. When no valid argument is supplied, displays help information.
    /// <code>Offset: 0x0057A740
    /// bool __thiscall ClientCommunicationSystem::DoHouseBoot(ClientCommunicationSystem*,int,char**)</code>
    /// </summary>
    /// <param name="argc">The number of command-line arguments supplied to the command.</param>
    /// <param name="argv">An array of C-string arguments for the command.</param>
    /// <returns>True if the boot operation succeeded; otherwise false.</returns>
    public byte DoHouseBoot(int argc, sbyte** argv) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientCommunicationSystem, int, sbyte**, byte>)0x0057A740)(ref this, argc, argv);

    /// <summary>Outputs help information for house management commands into the provided string, optionally appending additional content when supplied.
    /// <code>Offset: 0x0057A8A0
    /// char __stdcall ClientCommunicationSystem::HelpHouse(char*,int,char**)</code>
    /// </summary>
    /// <param name="Source">String buffer that will receive the help text.</param>
    /// <param name="a2">Unused parameter reserved for future use.</param>
    /// <param name="a3">Optional pointer to a string whose contents are appended after the help message if the source string has reference count greater than one.</param>
    /// <returns>Always 1, indicating successful completion.</returns>
    public static sbyte HelpHouse(sbyte* Source, int a2, sbyte** a3) => ((delegate* unmanaged[Stdcall]<sbyte*, int, sbyte**, sbyte>)0x0057A8A0)(Source, a2, a3);

    /// <summary>Outputs the usage and description of the "hslist" command, which lists available houses for purchase along with optional positions.
    /// <code>Offset: 0x0057A910
    /// char __thiscall ClientCommunicationSystem::HelpHouseAvailableList(char*,int,int,char**)</code>
    /// </summary>
    /// <param name="this">Reference to the client communication system instance.</param>
    /// <param name="a2">Unspecified parameter; preserved but unused in help generation.</param>
    /// <param name="a3">Unspecified parameter; preserved but unused in help generation.</param>
    /// <param name="a4">Pointer to an array of strings that are appended to the help text if provided.</param>
    /// <returns>Always returns 1 to indicate success.</returns>
    public sbyte HelpHouseAvailableList(int a2, int a3, sbyte** a4) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientCommunicationSystem, int, int, sbyte**, sbyte>)0x0057A910)(ref this, a2, a3, a4);

    /// <summary>Displays the help information for the advanced squelch command, writing the description to an output string.
    /// <code>Offset: 0x0057A960
    /// char __thiscall ClientCommunicationSystem::HelpAdvancedSquelch(char*,int,int,char**)</code>
    /// </summary>
    /// <param name="this">ClientCommunicationSystem instance.</param>
    /// <param name="a2">First argument (unused).</param>
    /// <param name="a3">Second argument (unused).</param>
    /// <param name="a4">Pointer to a buffer that receives the help text; caller must provide allocated storage.</param>
    /// <returns>Always returns 1 to indicate success.</returns>
    public sbyte HelpAdvancedSquelch(int a2, int a3, sbyte** a4) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientCommunicationSystem, int, int, sbyte**, sbyte>)0x0057A960)(ref this, a2, a3, a4);

    /// <summary>Displays help information for the @unsquelch command and writes it to the supplied output buffer.
    /// <code>Offset: 0x0057A9B0
    /// char __thiscall ClientCommunicationSystem::HelpAdvancedUnSquelch(char*,int,int,char**)</code>
    /// </summary>
    /// <param name="a2">Unused; reserved for future extensions.</param>
    /// <param name="a3">Unused; reserved for future extensions.</param>
    /// <param name="a4">Pointer to a string that will receive the help text.</param>
    /// <returns>Always returns 1 to indicate success.</returns>
    public sbyte HelpAdvancedUnSquelch(int a2, int a3, sbyte** a4) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientCommunicationSystem, int, int, sbyte**, sbyte>)0x0057A9B0)(ref this, a2, a3, a4);

    /// <summary>Processes arguments for a squelch command, validating the target and category, setting output parameters, and displaying error messages when necessary.
    /// <code>Offset: 0x0057AA00
    /// char __thiscall ClientCommunicationSystem::ProcessSquelchArgs(unsigned int*,int,int,wchar_t*,_BYTE*,void**,unsigned int*)</code>
    /// </summary>
    /// <param name="a2">Number of arguments supplied to the command.</param>
    /// <param name="a3">Pointer to an array of argument strings (each element is a C-style string).</param>
    /// <param name="Destination">Wide-character buffer used for constructing user-facing messages and retrieving the last teller's name.</param>
    /// <param name="a5">Output flag set when the command includes the "account" option, indicating an account target; cleared otherwise.</param>
    /// <param name="a6">Pointer to the resolved target name string (player or account); updated with reference counting as needed.</param>
    /// <param name="a7">Output squelch category identifier. Initially set to 1 and updated if a valid category is supplied.</param>
    /// <returns>Non‑zero on successful processing (or when an error message has been displayed); zero if the specified squelch category is invalid.</returns>
    public sbyte ProcessSquelchArgs(int a2, int a3, System.IntPtr Destination, byte* a5, void** a6, uint* a7) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientCommunicationSystem, int, int, System.IntPtr, byte*, void**, uint*, sbyte>)0x0057AA00)(ref this, a2, a3, Destination, a5, a6, a7);

    /// <summary>Retrieves the current list of squelch channels and writes them to the client’s scrollable text interface.
    /// <code>Offset: 0x0057ADE0
    /// bool __thiscall ClientCommunicationSystem::DoMessageTypes(ClientCommunicationSystem*,int,char**)</code>
    /// </summary>
    /// <param name="argc">Number of arguments supplied; ignored by this function.</param>
    /// <param name="argv">Argument array; ignored by this function.</param>
    /// <returns>True on success.</returns>
    public byte DoMessageTypes(int argc, sbyte** argv) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientCommunicationSystem, int, sbyte**, byte>)0x0057ADE0)(ref this, argc, argv);

    /// <summary>Writes help information for the “age” command into an output buffer and indicates success.
    /// <code>Offset: 0x0057AE80
    /// char __thiscall ClientCommunicationSystem::HelpAge(char*,int,int,char**)</code>
    /// </summary>
    /// <param name="a2">Unspecified integer parameter (ignored).</param>
    /// <param name="a3">Unspecified integer parameter (ignored).</param>
    /// <param name="a4">Pointer to a character buffer where the help text is written.</param>
    /// <returns>Always 1, indicating success.</returns>
    public sbyte HelpAge(int a2, int a3, sbyte** a4) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientCommunicationSystem, int, int, sbyte**, sbyte>)0x0057AE80)(ref this, a2, a3, a4);

    /// <summary>Shows help information for the @birth command, indicating when the character was created.
    /// <code>Offset: 0x0057AED0
    /// char __thiscall ClientCommunicationSystem::HelpBirth(char*,int,int,char**)</code>
    /// </summary>
    /// <param name="a4">Pointer to a string buffer where the help message will be appended.</param>
    /// <returns>Always returns 1 to indicate success.</returns>
    public sbyte HelpBirth(int a2, int a3, sbyte** a4) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientCommunicationSystem, int, int, sbyte**, sbyte>)0x0057AED0)(ref this, a2, a3, a4);

    /// <summary>Creates help text for the “day” command and passes it to the client communication system, optionally including additional content supplied via an argument.
    /// <code>Offset: 0x0057AF20
    /// char __thiscall ClientCommunicationSystem::HelpDay(char*,int,int,char**)</code>
    /// </summary>
    /// <param name="this">Reference to the ClientCommunicationSystem instance on which the help is generated.</param>
    /// <param name="a2">First unused integer parameter; present to match the expected signature of help callbacks.</param>
    /// <param name="a3">Second unused integer parameter; present for compatibility with the callback interface.</param>
    /// <param name="a4">Pointer to a string containing extra information to append to the base help message. May be null if no additional text is needed.</param>
    /// <returns>1, indicating that the help text was successfully created and processed.</returns>
    public sbyte HelpDay(int a2, int a3, sbyte** a4) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientCommunicationSystem, int, int, sbyte**, sbyte>)0x0057AF20)(ref this, a2, a3, a4);

    /// <summary>Create or update a reference‑counted string containing the help text for the endurance attribute and store it in Source.
    /// <code>Offset: 0x0057AF70
    /// char __stdcall ClientCommunicationSystem::HelpEndurance(char*,int,char**)</code>
    /// </summary>
    /// <param name="Source">Reference‑counted buffer that receives the full endurance description; if null, only a short tag is generated.</param>
    /// <param name="a2">Unused argument reserved for compatibility.</param>
    /// <param name="a3">Optional additional text appended to the help string when Source already contains data.</param>
    /// <returns>Returns 1 to indicate successful creation of the help text.</returns>
    public static sbyte HelpEndurance(sbyte* Source, int a2, sbyte** a3) => ((delegate* unmanaged[Stdcall]<sbyte*, int, sbyte**, sbyte>)0x0057AF70)(Source, a2, a3);

    /// <summary>Outputs a help message that explains how to toggle the framerate display using the &quot;@framerate&quot; command.
    /// <code>Offset: 0x0057AFD0
    /// char __thiscall ClientCommunicationSystem::HelpFrameRate(char*,int,int,char**)</code>
    /// </summary>
    /// <param name="a2">Unused argument.</param>
    /// <param name="a3">Unused argument.</param>
    /// <param name="a4">Pointer to a buffer where the help string will be written.</param>
    /// <returns>Always returns 1.</returns>
    public sbyte HelpFrameRate(int a2, int a3, sbyte** a4) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientCommunicationSystem, int, int, sbyte**, sbyte>)0x0057AFD0)(ref this, a2, a3, a4);

    /// <summary>Handles the @loc command, displaying the caller's current location if in a valid cell or an error message otherwise.
    /// <code>Offset: 0x0057B020
    /// bool __thiscall ClientCommunicationSystem::DoLoc(ClientCommunicationSystem*,int,char**)</code>
    /// </summary>
    /// <param name="argc">Number of arguments supplied to the command.</param>
    /// <param name="argv">Array of argument strings.</param>
    /// <returns>true always; indicates the command was processed successfully.</returns>
    public byte DoLoc(int argc, sbyte** argv) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientCommunicationSystem, int, sbyte**, byte>)0x0057B020)(ref this, argc, argv);

    /// <summary>Outputs the help text for the "@pklite" command and writes it into the supplied buffer.
    /// <code>Offset: 0x0057B310
    /// char __stdcall ClientCommunicationSystem::HelpPKLite(char*,int,char**)</code>
    /// </summary>
    /// <param name="Source">Pointer to a string buffer that will receive the help message.</param>
    /// <param name="a2">Unused parameter (reserved for future use).</param>
    /// <param name="a3">Optional pointer used by the underlying system; may be null.</param>
    /// <returns>Always returns 1 to indicate success.</returns>
    public static sbyte HelpPKLite(sbyte* Source, int a2, sbyte** a3) => ((delegate* unmanaged[Stdcall]<sbyte*, int, sbyte**, sbyte>)0x0057B310)(Source, a2, a3);

    /// <summary>Adds help information for the “version” command to the client communication system.
    /// <code>Offset: 0x0057B370
    /// char __thiscall ClientCommunicationSystem::HelpVersion(char*,int,int,char**)</code>
    /// </summary>
    /// <param name="this">The ClientCommunicationSystem instance.</param>
    /// <param name="a2">First argument (unused).</param>
    /// <param name="a3">Second argument (unused).</param>
    /// <param name="a4">Pointer to additional help text that will be appended, if provided.</param>
    /// <returns>Always returns 1 indicating success.</returns>
    public sbyte HelpVersion(int a2, int a3, sbyte** a4) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientCommunicationSystem, int, int, sbyte**, sbyte>)0x0057B370)(ref this, a2, a3, a4);

    /// <summary>Provides help information for the chat clear command, describing its effect on clearing all chat text.
    /// <code>Offset: 0x0057B3C0
    /// char __thiscall ClientCommunicationSystem::HelpClear(char*,int,int,char**)</code>
    /// </summary>
    /// <param name="a2">Reserved parameter; currently unused by this function.</param>
    /// <param name="a3">Reserved parameter; currently unused by this function.</param>
    /// <param name="a4">Optional pointer to additional help text that will be appended to the command description if supplied.</param>
    /// <returns>Returns 1 to indicate successful construction of the help message.</returns>
    public sbyte HelpClear(int a2, int a3, sbyte** a4) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientCommunicationSystem, int, int, sbyte**, sbyte>)0x0057B3C0)(ref this, a2, a3, a4);

    /// <summary>Sets the title of the current chat window using supplied arguments, validating source and length constraints.
    /// <code>Offset: 0x0057B410
    /// bool __thiscall ClientCommunicationSystem::DoTitle(ClientCommunicationSystem*,int,char**)</code>
    /// </summary>
    /// <param name="argc">Number of command-line arguments provided to the title command.</param>
    /// <param name="argv">Array of argument strings used for the new title.</param>
    /// <returns>True after processing; error messages are sent to the client system if conditions fail.</returns>
    public byte DoTitle(int argc, sbyte** argv) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientCommunicationSystem, int, sbyte**, byte>)0x0057B410)(ref this, argc, argv);

    /// <summary>Displays help information for the chat window title command, including optional custom text.
    /// <code>Offset: 0x0057B5B0
    /// char __thiscall ClientCommunicationSystem::HelpTitle(char*,int,int,char**)</code>
    /// </summary>
    /// <param name="this">Pointer to the ClientCommunicationSystem instance.</param>
    /// <param name="a2">Unused placeholder parameter.</param>
    /// <param name="a3">Unused placeholder parameter.</param>
    /// <param name="a4">Optional string containing additional help text to append to the default message.</param>
    /// <returns>Always returns 1, indicating success.</returns>
    public sbyte HelpTitle(int a2, int a3, sbyte** a4) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientCommunicationSystem, int, int, sbyte**, sbyte>)0x0057B5B0)(ref this, a2, a3, a4);

    /// <summary>Writes usage information for the @filter command into the supplied string buffer, optionally appending additional details from the third argument.
    /// <code>Offset: 0x0057B600
    /// char __stdcall ClientCommunicationSystem::HelpFilter(char*,int,char**)</code>
    /// </summary>
    /// <param name="Source">The string buffer that receives the help text; if null a concise description is written instead.</param>
    /// <param name="a2">Unused parameter reserved for future extensions.</param>
    /// <param name="a3">Optional pointer to extra help text appended when appropriate.</param>
    /// <returns>Always returns 1 to indicate successful completion.</returns>
    public static sbyte HelpFilter(sbyte* Source, int a2, sbyte** a3) => ((delegate* unmanaged[Stdcall]<sbyte*, int, sbyte**, sbyte>)0x0057B600)(Source, a2, a3);

    /// <summary>Attempts to add the client to a communication channel specified by its name. If the channel exists and the addition succeeds, returns that result; otherwise reports an error and returns true.
    /// <code>Offset: 0x0057B850
    /// bool __thiscall ClientCommunicationSystem::DoChannelOn(ClientCommunicationSystem*,int,char**)</code>
    /// </summary>
    /// <param name="argc">Number of arguments supplied to the command; must be 1 for a channel name.</param>
    /// <param name="argv">Array of argument strings; argv[0] holds the desired channel name.</param>
    /// <returns>True if the client was added successfully or if the command was processed without performing an addition; false only when adding to the channel fails.</returns>
    public byte DoChannelOn(int argc, sbyte** argv) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientCommunicationSystem, int, sbyte**, byte>)0x0057B850)(ref this, argc, argv);

    /// <summary>Removes the client from a communication channel identified by the supplied name.
    /// <code>Offset: 0x0057B920
    /// bool __thiscall ClientCommunicationSystem::DoChannelOff(ClientCommunicationSystem*,int,char**)</code>
    /// </summary>
    /// <param name="argc">Number of arguments passed to the command; must be 1 to specify a channel name.</param>
    /// <param name="argv">Array containing the channel name as its first element.</param>
    /// <returns>True if the removal operation succeeded, or if no attempt was made due to missing or invalid input. Returns false only when an existing channel is specified but the removal fails.</returns>
    public byte DoChannelOff(int argc, sbyte** argv) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientCommunicationSystem, int, sbyte**, byte>)0x0057B920)(ref this, argc, argv);

    /// <summary>Determines if the current client’s player character is in a PSR state.
    /// <code>Offset: 0x0057B9F0
    /// bool __thiscall ClientCommunicationSystem::PlayerIsPSR(ClientCommunicationSystem*)</code>
    /// </summary>
    /// <returns>True if the player is PSR; otherwise, false.</returns>
    public byte PlayerIsPSR() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientCommunicationSystem, byte>)0x0057B9F0)(ref this);

    /// <summary>Closes the currently open client communication log file and records a closure message in the chat window.
    /// <code>Offset: 0x0057BA90
    /// bool __thiscall ClientCommunicationSystem::CloseLogFile(ClientCommunicationSystem*)</code>
    /// </summary>
    /// <returns>True when a log file was successfully closed; otherwise false if no log file was open.</returns>
    public byte CloseLogFile() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientCommunicationSystem, byte>)0x0057BA90)(ref this);

    /// <summary>Shuts down the client communication system by closing its log file and releasing the global instance reference.
    /// <code>Offset: 0x0057BBA0
    /// void __thiscall ClientCommunicationSystem::OnShutdown(ClientCommunicationSystem*)</code>
    /// </summary>
    public void OnShutdown() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientCommunicationSystem, void>)0x0057BBA0)(ref this);

    /// <summary>Processes a weenie error by delegating to HandleFailureEvent without an accompanying message.
    /// <code>Offset: 0x0057BBC0
    /// unsigned int __thiscall ClientCommunicationSystem::Handle_Communication__WeenieError(ClientCommunicationSystem*,unsigned int)</code>
    /// </summary>
    /// <param name="etype">Identifier of the weenie error to handle.</param>
    /// <returns>Zero, indicating the error was processed successfully.</returns>
    public uint Handle_Communication__WeenieError(uint etype) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientCommunicationSystem, uint, uint>)0x0057BBC0)(ref this, etype);

    /// <summary>Generates and displays help information for the “@allegiance” command set, including subcommands and usage examples.
    /// <code>Offset: 0x0057BBE0
    /// char __stdcall ClientCommunicationSystem::HelpAllegiance(char*,int,char*)</code>
    /// </summary>
    /// <param name="Source">Optional buffer to receive the formatted help text; if null a short description is shown instead.</param>
    /// <param name="a2">Unused parameter (reserved for future use).</param>
    /// <param name="a3">Additional string appended to the help message before it is sent.</param>
    /// <returns>Always returns 1 indicating success.</returns>
    public static sbyte HelpAllegiance(sbyte* Source, int a2, sbyte* a3) => ((delegate* unmanaged[Stdcall]<sbyte*, int, sbyte*, sbyte>)0x0057BBE0)(Source, a2, a3);

    /// <summary>Attempts to terminate an allegiance for a specified member, optionally by account name. Sends status messages and triggers the internal boot event, returning true if the operation succeeded.
    /// <code>Offset: 0x0057BCC0
    /// bool __thiscall ClientCommunicationSystem::DoAllegianceBoot(ClientCommunicationSystem*,const char*,char**)</code>
    /// </summary>
    /// <param name="argc">The number of arguments supplied for the command (typically one).</param>
    /// <param name="argv">Array of argument strings; argv[0] is the target's name or identifier.</param>
    /// <returns>True if the allegiance break was processed successfully; otherwise false.</returns>
    public byte DoAllegianceBoot(sbyte* argc, sbyte** argv) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientCommunicationSystem, sbyte*, sbyte**, byte>)0x0057BCC0)(ref this, argc, argv);

    /// <summary>Generates chat command help messages and writes them into the provided buffer, handling both public and private messaging commands.
    /// <code>Offset: 0x0057BF70
    /// char __stdcall ClientCommunicationSystem::HelpChattingGroup(char*,int,char*)</code>
    /// </summary>
    /// <param name="Source">Pointer to a string where the generated help text will be stored.</param>
    /// <param name="a2">Reserved parameter; currently unused.</param>
    /// <param name="a3">Pointer to an auxiliary buffer used by helper functions during message construction.</param>
    /// <returns>Returns 1 on success.</returns>
    public static sbyte HelpChattingGroup(sbyte* Source, int a2, sbyte* a3) => ((delegate* unmanaged[Stdcall]<sbyte*, int, sbyte*, sbyte>)0x0057BF70)(Source, a2, a3);

    /// <summary>Processes the AFK command, toggling AFK mode or updating the AFK message for the current player.
    /// <code>Offset: 0x0057C1C0
    /// bool __thiscall ClientCommunicationSystem::DoAFK(ClientCommunicationSystem*,volatile LONG*,char**)</code>
    /// </summary>
    /// <param name="argc">The count of arguments supplied to the AFK command; may be modified during processing.</param>
    /// <param name="argv">An array of strings representing the arguments passed to the AFK command.</param>
    /// <returns>True if the command was handled successfully.</returns>
    public byte DoAFK(int* argc, sbyte** argv) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientCommunicationSystem, int*, sbyte**, byte>)0x0057C1C0)(ref this, argc, argv);

    /// <summary>Provides help text for death and corpse‑related commands such as @permit, @consent, @corpse, @die, @lifestone, @marketplace, @pkarena, and @pklarena.
    /// <code>Offset: 0x0057C680
    /// char __thiscall ClientCommunicationSystem::HelpDeathGroup(char*,char*,int,char*)</code>
    /// </summary>
    /// <param name="Source">The command source string that triggers the help response; if null, a generic help header is displayed.</param>
    /// <param name="a3">An unused integer parameter (reserved for future use).</param>
    /// <param name="a4">Pointer to an array of strings where each constructed help message will be stored or forwarded to the caller.</param>
    /// <returns>Always returns 1 to indicate successful processing of the command.</returns>
    public sbyte HelpDeathGroup(sbyte* Source, int a3, sbyte* a4) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientCommunicationSystem, sbyte*, int, sbyte*, sbyte>)0x0057C680)(ref this, Source, a3, a4);

    /// <summary>
    /// Processes the result of a die dialog by examining properties in the supplied collection. If a death flag is present, it triggers the character's suicide event and releases any referenced resources.
    /// 
    /// <code>Offset: 0x0057C840
    /// void __cdecl ClientCommunicationSystem::DieDialogCallback(const PropertyCollection*)</code>
    /// </summary>
    /// <param name="i_rcResults">Collection of properties returned from the dialog.</param>
    public static void DieDialogCallback(ACBindings.Internal.PropertyCollection* i_rcResults) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.PropertyCollection*, void>)0x0057C840)(i_rcResults);

    /// <summary>Displays a formatted list of available emotes to the client’s chat window.
    /// <code>Offset: 0x0057C900
    /// bool __thiscall ClientCommunicationSystem::DoEmoteList(ClientCommunicationSystem*,int,char**)</code>
    /// </summary>
    /// <param name="argc">Number of arguments passed; ignored by this command.</param>
    /// <param name="argv">Array of argument strings; not used when listing emotes.</param>
    /// <returns>True after printing the emote list successfully.</returns>
    public byte DoEmoteList(int argc, sbyte** argv) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientCommunicationSystem, int, sbyte**, byte>)0x0057C900)(ref this, argc, argv);

    /// <summary>Processes a friends chat command by interpreting subcommands such as add, remove, online, and old, delegating to the appropriate handlers or displaying friend lists.
    /// <code>Offset: 0x0057C9D0
    /// bool __thiscall ClientCommunicationSystem::DoFriends(ClientCommunicationSystem*,int,char**)</code>
    /// </summary>
    /// <param name="argc">The number of arguments supplied with the command.</param>
    /// <param name="argv">An array of argument strings provided to the command.</param>
    /// <returns>True if the command was handled (either successfully or by reporting an error); false otherwise.</returns>
    public byte DoFriends(int argc, sbyte** argv) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientCommunicationSystem, int, sbyte**, byte>)0x0057C9D0)(ref this, argc, argv);

    /// <summary>Processes the result properties from a house‑abandon dialog, checks for approval flags and triggers the abandonment event if indicated.
    /// <code>Offset: 0x0057CC60
    /// void __cdecl ClientCommunicationSystem::HouseAbandonDialogCallback_Second(const PropertyCollection*)</code>
    /// </summary>
    /// <param name="i_rcResults">Collection of properties returned from the server during the second step of the house abandon workflow.</param>
    public static void HouseAbandonDialogCallback_Second(ACBindings.Internal.PropertyCollection* i_rcResults) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.PropertyCollection*, void>)0x0057CC60)(i_rcResults);

    /// <summary>Processes a squelch command, modifying or querying the spam filter based on supplied arguments.
    /// <code>Offset: 0x0057CD20
    /// bool __thiscall ClientCommunicationSystem::DoSquelch(ClientCommunicationSystem*,int,char**)</code>
    /// </summary>
    /// <param name="argc">Number of arguments following the command.</param>
    /// <param name="argv">Array of argument strings passed to the command.</param>
    /// <returns>True when the operation succeeds; returns false only if called with no arguments and the current squelch status query fails.</returns>
    public byte DoSquelch(int argc, sbyte** argv) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientCommunicationSystem, int, sbyte**, byte>)0x0057CD20)(ref this, argc, argv);

    /// <summary>Un-squelches an account or character based on supplied command arguments; with no arguments it reports whether squelching is currently active.
    /// <code>Offset: 0x0057CE40
    /// bool __thiscall ClientCommunicationSystem::DoUnSquelch(ClientCommunicationSystem*,int,char**)</code>
    /// </summary>
    /// <param name="argc">The number of command‑line arguments provided.</param>
    /// <param name="argv">Pointer to the array of argument strings.</param>
    /// <returns>Always true, indicating that the request was processed.</returns>
    public byte DoUnSquelch(int argc, sbyte** argv) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientCommunicationSystem, int, sbyte**, byte>)0x0057CE40)(ref this, argc, argv);

    /// <summary>Generates the help text for the @squelch command and writes it into the provided output buffer. The message varies based on whether a source string is supplied, with special handling for null or placeholder values.
    /// <code>Offset: 0x0057CF60
    /// char __thiscall ClientCommunicationSystem::HelpSquelch(char*,char*,int,char*)</code>
    /// </summary>
    /// <param name="Source">Input string indicating which help to produce; if nullptr shows general help, if (char*)1 shows brief help, otherwise detailed help is generated.</param>
    /// <param name="a3">Reserved integer parameter currently unused by the implementation.</param>
    /// <param name="a4">Output buffer where the constructed help text is stored.</param>
    /// <returns>Always returns 1 to indicate successful execution.</returns>
    public sbyte HelpSquelch(sbyte* Source, int a3, sbyte* a4) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientCommunicationSystem, sbyte*, int, sbyte*, sbyte>)0x0057CF60)(ref this, Source, a3, a4);

    /// <summary>Modifies or queries the global message‑squelching setting. With no arguments it reports whether global squelch is active; otherwise it parses a dash‑prefixed message type and enables or disables that squelch according to the add flag.
    /// <code>Offset: 0x0057D0A0
    /// bool __thiscall ClientCommunicationSystem::PerformGlobalSquelchMod(ClientCommunicationSystem*,int,char**,bool)</code>
    /// </summary>
    /// <param name="argc">Number of command arguments supplied.</param>
    /// <param name="argv">Array of C‑style strings containing those arguments.</param>
    /// <param name="add">True to enable, false to disable the specified squelch type when modifying.</param>
    /// <returns>Returns true after applying a modification; when called with zero arguments it returns whether global squelch is currently active (no failure case).</returns>
    public byte PerformGlobalSquelchMod(int argc, sbyte** argv, byte add) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientCommunicationSystem, int, sbyte**, byte, byte>)0x0057D0A0)(ref this, argc, argv, add);

    /// <summary>Outputs help text for status commands into the provided buffer.
    /// <code>Offset: 0x0057D1E0
    /// char __thiscall ClientCommunicationSystem::HelpStatusGroup(char*,char*,int,char*)</code>
    /// </summary>
    /// <param name="Source">When supplied, triggers detailed help generation; otherwise a brief group heading is produced.</param>
    /// <param name="a3">Command identifier (unused in this implementation).</param>
    /// <param name="a4">Buffer where the generated help string is written.</param>
    /// <returns>Always returns 1 to indicate success.</returns>
    public sbyte HelpStatusGroup(sbyte* Source, int a3, sbyte* a4) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientCommunicationSystem, sbyte*, int, sbyte*, sbyte>)0x0057D1E0)(ref this, Source, a3, a4);

    /// <summary>Retrieves the age of the currently selected player during a Player Status Report session by issuing a character event.
    /// <code>Offset: 0x0057D370
    /// bool __thiscall ClientCommunicationSystem::DoAge(ClientCommunicationSystem*,int,char**)</code>
    /// </summary>
    /// <param name="argc">The number of arguments supplied to the DoAge command (unused).</param>
    /// <param name="argv">Array of argument strings for the DoAge command (unused).</param>
    /// <returns>True if an age query event was successfully issued; otherwise, false.</returns>
    public byte DoAge(int argc, sbyte** argv) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientCommunicationSystem, int, sbyte**, byte>)0x0057D370)(ref this, argc, argv);

    /// <summary>Displays a formatted explanation of the Endurance attribute and its associated benefits in the character information panel.
    /// <code>Offset: 0x0057D3C0
    /// bool __thiscall ClientCommunicationSystem::DoEndurance(ClientCommunicationSystem*,int,char**)</code>
    /// </summary>
    /// <param name="argc">The number of arguments supplied to the command (unused).</param>
    /// <param name="argv">The argument values supplied to the command (unused).</param>
    /// <returns>True after successfully outputting the message.</returns>
    public byte DoEndurance(int argc, sbyte** argv) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientCommunicationSystem, int, sbyte**, byte>)0x0057D3C0)(ref this, argc, argv);

    /// <summary>Builds help text for chat filter commands and appends it to the supplied string buffer, optionally including a header when an output buffer is provided.
    /// <code>Offset: 0x0057D490
    /// char __thiscall ClientCommunicationSystem::HelpTextGroup(char*,char*,int,char*)</code>
    /// </summary>
    /// <param name="Source">Optional pointer to a PStringBase object that receives a help‑text header; if null, no header is added.</param>
    /// <param name="a3">Reserved for future use; currently ignored.</param>
    /// <param name="a4">Pointer to the string buffer into which command descriptions and the title are appended.</param>
    /// <returns>Always returns 1, indicating successful completion.</returns>
    public sbyte HelpTextGroup(sbyte* Source, int a3, sbyte* a4) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientCommunicationSystem, sbyte*, int, sbyte*, sbyte>)0x0057D490)(ref this, Source, a3, a4);

    /// <summary>Determines whether a client-side command should be processed based on global squelch rules.
    /// <code>Offset: 0x0057D630
    /// bool __thiscall ClientCommunicationSystem::DoFilter(ClientCommunicationSystem*,int,char**)</code>
    /// </summary>
    /// <param name="argc">The number of arguments supplied to the command.</param>
    /// <param name="argv">An array of argument strings passed to the command.</param>
    /// <returns>True if the command passes the global filtering check; otherwise, false.</returns>
    public byte DoFilter(int argc, sbyte** argv) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientCommunicationSystem, int, sbyte**, byte>)0x0057D630)(ref this, argc, argv);

    /// <summary>Removes a previously applied global filtering mode, restoring normal communication flow for the client.
    /// <code>Offset: 0x0057D650
    /// bool __thiscall ClientCommunicationSystem::DoUnFilter(ClientCommunicationSystem*,int,char**)</code>
    /// </summary>
    /// <param name="argc">The number of arguments supplied to the command.</param>
    /// <param name="argv">Array of argument strings passed from the command interface.</param>
    /// <returns>True if the unfilter operation succeeded; otherwise false.</returns>
    public byte DoUnFilter(int argc, sbyte** argv) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientCommunicationSystem, int, sbyte**, byte>)0x0057D650)(ref this, argc, argv);

    /// <summary>Begins copying client output to the specified log file.
    /// <code>Offset: 0x0057D670
    /// BOOL __thiscall ClientCommunicationSystem::StartCopyOutputToFile(ClientCommunicationSystem*,const char**)</code>
    /// </summary>
    /// <param name="a2">Pointer to a null‑terminated C string that contains the path of the file to open for appending.</param>
    /// <returns>True if the file was successfully opened; otherwise false.</returns>
    public byte StartCopyOutputToFile(sbyte** a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientCommunicationSystem, sbyte**, byte>)0x0057D670)(ref this, a2);

    /// <summary>Notifies the client when a quality flag changes, adding an appropriate message to the chat scroll to indicate whether the player has set or cleared the away‑from‑keyboard status.
    /// <code>Offset: 0x0057D910
    /// void __thiscall ClientCommunicationSystem::OnQualityChanged(ClientCommunicationSystem*,CWeenieObject*,StatType,unsigned int)</code>
    /// </summary>
    /// <param name="cwobj">The object whose quality changed, typically the player character.</param>
    /// <param name="stype">The type of stat that changed; currently unused in this handler.</param>
    /// <param name="senum">The specific quality change enumeration value; also unused here.</param>
    public void OnQualityChanged(ACBindings.Internal.CWeenieObject* cwobj, ACBindings.Internal.StatType stype, uint senum) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientCommunicationSystem, ACBindings.Internal.CWeenieObject*, ACBindings.Internal.StatType, uint, void>)0x0057D910)(ref this, cwobj, stype, senum);

    /// <summary>Handles a weenie error by invoking the failure event handler with the supplied message and releasing the associated string resource.
    /// <code>Offset: 0x0057D960
    /// int __thiscall ClientCommunicationSystem::Handle_Communication__WeenieErrorWithString(void*,unsigned int,int)</code>
    /// </summary>
    /// <param name="a2">The identifier of the error source or type.</param>
    /// <param name="a3">Pointer to a reference‑counted wide string containing the error description.</param>
    /// <returns>Zero, indicating successful handling.</returns>
    public int Handle_Communication__WeenieErrorWithString(uint a2, int a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientCommunicationSystem, uint, int, int>)0x0057D960)(ref this, a2, a3);

    /// <summary>Handles a client “hear emote” request, constructs an emote message by combining the sender’s name and emote text, applies special formatting rules, selects random messages for non‑visible targets or Olthoi players, and posts the result to the chat scroll view.
    /// <code>Offset: 0x0057D9B0
    /// int __thiscall ClientCommunicationSystem::Handle_Communication__HearEmote(void*,unsigned int,const char*,int)</code>
    /// </summary>
    /// <param name="iid">Identifier of the source interface that issued the emote.</param>
    /// <param name="a3">Pointer to the interface whose name is used as the target in the emote message.</param>
    /// <param name="a4">Pointer to the interface containing the emote text string supplied by the player.</param>
    /// <returns>Zero, indicating successful handling of the request.</returns>
    public int Handle_Communication__HearEmote(uint iid, sbyte* a3, int a4) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientCommunicationSystem, uint, sbyte*, int, int>)0x0057D9B0)(ref this, iid, a3, a4);

    /// <summary>Processes a soul‑emote communication by validating the input, constructing the emote message, managing reference counts on involved objects, and delegating to Handle_Communication__HearEmote for further handling.
    /// <code>Offset: 0x0057DDF0
    /// int __thiscall ClientCommunicationSystem::Handle_Communication__HearSoulEmote(void*,unsigned int,volatile LONG*,int)</code>
    /// </summary>
    /// <param name="this">Pointer to the ClientCommunicationSystem instance.</param>
    /// <param name="a2">Identifier or data associated with the soul‑emote command; processing is skipped if it matches a special SmartBox value.</param>
    /// <param name="a3">Pointer to a ref‑counted string object containing the emote text; its reference count is decremented after use.</param>
    /// <param name="a4">Integer flag or context parameter passed through to Handle_Communication__HearEmote.</param>
    /// <returns>Return value from Handle_Communication__HearEmote, or 0 if the command is ignored due to a matching SmartBox value.</returns>
    public int Handle_Communication__HearSoulEmote(uint a2, int* a3, int a4) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientCommunicationSystem, uint, int*, int, int>)0x0057DDF0)(ref this, a2, a3, a4);

    /// <summary>Shows a header and lists every available communication channel to the client by adding each channel name to the scroll window.
    /// <code>Offset: 0x0057DE90
    /// int __thiscall ClientCommunicationSystem::Handle_Communication__ChannelIndex(void*,int)</code>
    /// </summary>
    /// <param name="a2">Pointer to a data structure that contains the list of channels to enumerate.</param>
    /// <returns>Zero on completion.</returns>
    public int Handle_Communication__ChannelIndex(int a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientCommunicationSystem, int, int>)0x0057DE90)(ref this, a2);

    /// <summary>Displays a formatted list of all players currently listening on a communication channel in the client interface.
    /// <code>Offset: 0x0057E000
    /// int __thiscall ClientCommunicationSystem::Handle_Communication__ChannelList(void*,int)</code>
    /// </summary>
    /// <param name="this">The client communication system instance handling the request.</param>
    /// <param name="a2">Reference to the data structure containing channel participants.</param>
    /// <returns>Zero, indicating successful completion.</returns>
    public int Handle_Communication__ChannelList(int a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientCommunicationSystem, int, int>)0x0057E000)(ref this, a2);

    /// <summary>Handles a transient wide‑string message by appending it to the chat scroll and releasing its resources when no longer needed.
    /// <code>Offset: 0x0057E170
    /// int __thiscall ClientCommunicationSystem::Handle_Communication__TransientString(void*,int)</code>
    /// </summary>
    /// <param name="this">Pointer to the ClientCommunicationSystem instance.</param>
    /// <param name="a2">Reference‑counted pointer to the received wide string.</param>
    /// <returns>Zero, indicating successful handling of the message.</returns>
    public int Handle_Communication__TransientString(int a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientCommunicationSystem, int, int>)0x0057E170)(ref this, a2);

    /// <summary>Generates help messages for allegiance commands and writes them to the provided string buffers.
    /// <code>Offset: 0x0057E1D0
    /// char __stdcall ClientCommunicationSystem::HelpAllegiancesGroup(char*,int,char*)</code>
    /// </summary>
    /// <param name="Source">Pointer to the primary output string buffer where the main help text will be stored.</param>
    /// <param name="a2">Unused parameter reserved for future use or alignment.</param>
    /// <param name="a3">Pointer to an auxiliary output string buffer for additional help details.</param>
    /// <returns>Always returns 1 to indicate successful execution.</returns>
    public static sbyte HelpAllegiancesGroup(sbyte* Source, int a2, sbyte* a3) => ((delegate* unmanaged[Stdcall]<sbyte*, int, sbyte*, sbyte>)0x0057E1D0)(Source, a2, a3);

    /// <summary>Processes an Allegiance client command by inspecting its first argument and routing to a matching handler such as boot, info, chat, broadcast, ban, officer, title, hometown, motd, name, lock or house. After executing the chosen handler it displays help text if no known sub‑command is found.
    /// <code>Offset: 0x0057E2B0
    /// bool __thiscall ClientCommunicationSystem::DoAllegiance(ClientCommunicationSystem*,int,char**)</code>
    /// </summary>
    /// <param name="argc">The number of arguments supplied for the command.</param>
    /// <param name="argv">An array of argument strings; argv[0] holds the sub‑command to execute.</param>
    /// <returns>True when the command has been processed (the function always returns true).</returns>
    public byte DoAllegiance(int argc, sbyte** argv) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientCommunicationSystem, int, sbyte**, byte>)0x0057E2B0)(ref this, argc, argv);

    /// <summary>Displays a deprecation notice for the speaker command, informing users that it is no longer available and to contact the allegiance officer.
    /// <code>Offset: 0x0057E7C0
    /// bool __thiscall ClientCommunicationSystem::DoSpeaker(ClientCommunicationSystem*,int,char**)</code>
    /// </summary>
    /// <param name="argc">The number of arguments supplied (unused).</param>
    /// <param name="argv">Array of argument strings (unused).</param>
    /// <returns>True if the message was displayed successfully.</returns>
    public byte DoSpeaker(int argc, sbyte** argv) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientCommunicationSystem, int, sbyte**, byte>)0x0057E7C0)(ref this, argc, argv);

    /// <summary>Sends a chat message through Turbine’s chat system after verifying that the service is enabled, that the message is safe and not spammy, and then constructs a TurbineChatBlob for transmission.
    /// <code>Offset: 0x0057E820
    /// char __thiscall ClientCommunicationSystem::SendTurbineChat(ClientCommunicationSystem*,int,CLogonHeader::HandshakeWireData,int)</code>
    /// </summary>
    /// <param name="a2">Channel identifier; if zero, the function treats Turbine chat as unavailable and displays an error message.</param>
    /// <param name="a3">Handshake data containing the client version string and authentication buffer used to validate the message before sending.</param>
    /// <param name="a4">Message text to send. If this pointer is null, the global channel name is sent instead.</param>
    /// <returns>Non‑zero if the message was successfully queued for transmission; zero on failure or when Turbine chat is unavailable.</returns>
    public sbyte SendTurbineChat(int a2, ACBindings.Internal.CLogonHeader.HandshakeWireData a3, int a4) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientCommunicationSystem, int, ACBindings.Internal.CLogonHeader.HandshakeWireData, int, sbyte>)0x0057E820)(ref this, a2, a3, a4);

    /// <summary>Processes the ‘consent’ command issued by a player, enabling or disabling acceptance of corpse looting permissions and managing the player’s consent list (displaying current consents, clearing the list, or removing a specific entry).
    /// <code>Offset: 0x0057EAB0
    /// bool __thiscall ClientCommunicationSystem::DoConsent(ClientCommunicationSystem*,int,char**)</code>
    /// </summary>
    /// <param name="argc">The number of arguments supplied with the command.</param>
    /// <param name="argv">An array of argument strings; argv[0] contains the subcommand (“on”, “off”, “who”, “clear”, or “remove”).</param>
    /// <returns>True if the command was handled successfully; false if an error occurred while modifying the consent list.</returns>
    public byte DoConsent(int argc, sbyte** argv) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientCommunicationSystem, int, sbyte**, byte>)0x0057EAB0)(ref this, argc, argv);

    /// <summary>Processes a render option by delegating to SmartBox and logs any resulting status or textbox messages.
    /// <code>Offset: 0x0057EE30
    /// bool __thiscall ClientCommunicationSystem::DoRenderOption(ClientCommunicationSystem*,int,char**)</code>
    /// </summary>
    /// <param name="argc">Number of arguments supplied for the command.</param>
    /// <param name="argv">Array of argument strings passed to the command.</param>
    /// <returns>True if the SmartBox handled the option successfully; otherwise false.</returns>
    public byte DoRenderOption(int argc, sbyte** argv) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientCommunicationSystem, int, sbyte**, byte>)0x0057EE30)(ref this, argc, argv);

    /// <summary>Handles the @version command by displaying client information and notifying the server when appropriate.
    /// <code>Offset: 0x0057EEC0
    /// bool __thiscall ClientCommunicationSystem::DoVersion(ClientCommunicationSystem*,int,char**)</code>
    /// </summary>
    /// <param name="argc">Number of arguments supplied with the command; must be zero for a valid @version call.</param>
    /// <param name="argv">Array of argument strings (unused in this implementation).</param>
    /// <returns>True to indicate that the command was processed successfully.</returns>
    public byte DoVersion(int argc, sbyte** argv) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientCommunicationSystem, int, sbyte**, byte>)0x0057EEC0)(ref this, argc, argv);

    /// <summary>Parses the last entered command line, determines the command name and arguments, looks up the corresponding handler in the command hash table, and executes it (or falls back to a channel command). Returns true when a command was found and processed; otherwise returns false.
    /// <code>Offset: 0x0057EFF0
    /// bool __thiscall ClientCommunicationSystem::DoCommand(ClientCommunicationSystem*)</code>
    /// </summary>
    /// <returns>True if the command was successfully located and executed; false if no valid command could be parsed or executed.</returns>
    public byte DoCommand() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientCommunicationSystem, byte>)0x0057EFF0)(ref this);

    /// <summary>Starts or stops redirecting chat messages to a file based on supplied arguments, updating internal state and displaying status messages.
    /// <code>Offset: 0x0057F200
    /// bool __thiscall ClientCommunicationSystem::DoSetOutput(ClientCommunicationSystem*,const OLECHAR*,char**)</code>
    /// </summary>
    /// <param name="argc">The number of command‑line arguments for the chat output command.</param>
    /// <param name="argv">Array of argument strings passed to the command.</param>
    /// <returns>True if the operation succeeded (the function always returns true).</returns>
    public byte DoSetOutput(System.IntPtr argc, sbyte** argv) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientCommunicationSystem, System.IntPtr, sbyte**, byte>)0x0057F200)(ref this, argc, argv);

    /// <summary>Displays a Weenie error notice using the specified error ID and message text.
    /// <code>Offset: 0x0057F410
    /// LONG __thiscall ClientCommunicationSystem::RecvNotice_DisplayWeenieError(char*,unsigned int,int)</code>
    /// </summary>
    /// <param name="a2">The numeric identifier for the error being reported.</param>
    /// <param name="a3">Pointer to a null‑terminated ASCII string containing the human‑readable error message; internally converted to UTF‑16 for display.</param>
    /// <returns>The remaining reference count of the internal string after decrementing, or zero if it was released.</returns>
    public int RecvNotice_DisplayWeenieError(uint a2, int a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientCommunicationSystem, uint, int, int>)0x0057F410)(ref this, a2, a3);

    /// <summary>Generates comprehensive help for all command groups or a general list of commands, formatting the information into provided string buffers.
    /// <code>Offset: 0x0057F500
    /// char __thiscall ClientCommunicationSystem::HelpAllGroup(char*,char*,int,char*)</code>
    /// </summary>
    /// <param name="Source">Pointer to a string object where a generic help message is written when no specific source buffer is supplied.</param>
    /// <param name="a3">Reserved; unused by current implementation.</param>
    /// <param name="a4">Buffer used to accumulate detailed group‑specific help text that helper functions append to.</param>
    /// <returns>Always returns 1, indicating successful generation of help information.</returns>
    public sbyte HelpAllGroup(sbyte* Source, int a3, sbyte* a4) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientCommunicationSystem, sbyte*, int, sbyte*, sbyte>)0x0057F500)(ref this, Source, a3, a4);

    /// <summary>Sends an Allegiance chat message through Turbine after validating command arguments and input context.
    /// <code>Offset: 0x0057F8B0
    /// bool __thiscall ClientCommunicationSystem::DoTurbineChat_Allegiance(ClientCommunicationSystem*,int,char**)</code>
    /// </summary>
    /// <param name="argc">The number of arguments supplied for the chat command.</param>
    /// <param name="argv">An array of strings containing the argument values.</param>
    /// <returns>True if the chat message was successfully queued for transmission; otherwise, false.</returns>
    public byte DoTurbineChat_Allegiance(int argc, sbyte** argv) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientCommunicationSystem, int, sbyte**, byte>)0x0057F8B0)(ref this, argc, argv);

    /// <summary>Processes a general Turbine chat command by validating arguments, preparing chat data, and sending it to the server.
    /// <code>Offset: 0x0057F960
    /// bool __thiscall ClientCommunicationSystem::DoTurbineChat_General(ClientCommunicationSystem*,int,char**)</code>
    /// </summary>
    /// <param name="argc">The number of arguments supplied with the command.</param>
    /// <param name="argv">An array of argument strings used to construct the chat message.</param>
    /// <returns>True if the command was successfully processed and sent; otherwise false, typically when no arguments are provided or a failure event is triggered.</returns>
    public byte DoTurbineChat_General(int argc, sbyte** argv) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientCommunicationSystem, int, sbyte**, byte>)0x0057F960)(ref this, argc, argv);

    /// <summary>Processes a trade‑chat command by forwarding the supplied arguments to the global trade chat room and returning whether the transmission succeeded.
    /// <code>Offset: 0x0057F9F0
    /// bool __thiscall ClientCommunicationSystem::DoTurbineChat_Trade(ClientCommunicationSystem*,int,char**)</code>
    /// </summary>
    /// <param name="argc">Number of arguments provided with the trade command.</param>
    /// <param name="argv">Array of argument strings passed to the command.</param>
    /// <returns>True if the message was sent successfully; otherwise, false (e.g., when no arguments were supplied).</returns>
    public byte DoTurbineChat_Trade(int argc, sbyte** argv) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientCommunicationSystem, int, sbyte**, byte>)0x0057F9F0)(ref this, argc, argv);

    /// <summary>Processes a Turbine “Looking For Group” (LFG) chat request, validating command arguments and sending the corresponding chat message to the server.
    /// <code>Offset: 0x0057FA80
    /// bool __thiscall ClientCommunicationSystem::DoTurbineChat_LFG(ClientCommunicationSystem*,int,char**)</code>
    /// </summary>
    /// <param name="argc">The count of argument strings supplied with the LFG command.</param>
    /// <param name="argv">Array of pointers to the argument strings for the LFG command.</param>
    /// <returns>True if the LFG chat message was successfully sent; otherwise false, such as when no arguments are provided or a communication error occurs.</returns>
    public byte DoTurbineChat_LFG(int argc, sbyte** argv) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientCommunicationSystem, int, sbyte**, byte>)0x0057FA80)(ref this, argc, argv);

    /// <summary>Processes a Turbine role‑play chat command by validating its arguments, preparing chat room information, and sending the message to the server.
    /// <code>Offset: 0x0057FB10
    /// bool __thiscall ClientCommunicationSystem::DoTurbineChat_Roleplay(ClientCommunicationSystem*,int,char**)</code>
    /// </summary>
    /// <param name="this">Pointer to the ClientCommunicationSystem instance handling the command.</param>
    /// <param name="argc">The count of arguments supplied with the chat command.</param>
    /// <param name="argv">Array of argument strings passed to the command.</param>
    /// <returns>True if the chat message was successfully queued for sending; false if argument validation fails or an error occurs, in which case a failure event is logged.</returns>
    public byte DoTurbineChat_Roleplay(int argc, sbyte** argv) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientCommunicationSystem, int, sbyte**, byte>)0x0057FB10)(ref this, argc, argv);

    /// <summary>Processes the Turbine chat command for Olthoi players, validating that at least one argument is present, preparing handshake data, and sending the request via ClientCommunicationSystem.
    /// <code>Offset: 0x0057FBA0
    /// bool __thiscall ClientCommunicationSystem::DoTurbineChat_Olthoi(ClientCommunicationSystem*,int,char**)</code>
    /// </summary>
    /// <param name="argc">The number of arguments supplied to the chat command.</param>
    /// <param name="argv">An array of strings containing the command arguments.</param>
    /// <returns>True if the Turbine chat message was sent successfully; otherwise false (e.g., when no arguments are provided).</returns>
    public byte DoTurbineChat_Olthoi(int argc, sbyte** argv) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientCommunicationSystem, int, sbyte**, byte>)0x0057FBA0)(ref this, argc, argv);

    /// <summary>Sends a Turbine society chat message using the supplied arguments, handling argument parsing and error conditions.
    /// <code>Offset: 0x0057FC30
    /// bool __thiscall ClientCommunicationSystem::DoTurbineChat_Society(ClientCommunicationSystem*,int,char**)</code>
    /// </summary>
    /// <param name="argc">The number of command line arguments provided to the chat command.</param>
    /// <param name="argv">An array of pointers to the argument strings.</param>
    /// <returns>True if the message was sent successfully; otherwise false when no arguments are supplied or the send operation fails.</returns>
    public byte DoTurbineChat_Society(int argc, sbyte** argv) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientCommunicationSystem, int, sbyte**, byte>)0x0057FC30)(ref this, argc, argv);

    /// <summary>Initializes Turbine chat command handlers by registering predefined channel names and their corresponding handler functions in the system’s command table.
    /// <code>Offset: 0x0057FCC0
    /// bool __thiscall ClientCommunicationSystem::StartupTurbineChatSystem(ClientCommunicationSystem*)</code>
    /// </summary>
    /// <returns>True after the startup process completes successfully.</returns>
    public byte StartupTurbineChatSystem() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientCommunicationSystem, byte>)0x0057FCC0)(ref this);

    /// <summary>Provides context‑sensitive help for client commands. When called with a command name, displays usage information; otherwise lists all available commands.
    /// <code>Offset: 0x005806F0
    /// bool __thiscall ClientCommunicationSystem::DoHelp(ClientCommunicationSystem*,int,char**)</code>
    /// </summary>
    /// <param name="argc">Number of arguments following the help request.</param>
    /// <param name="argv">Array of argument strings supplied to the help command.</param>
    /// <returns>True if help text was successfully written; always true in this implementation.</returns>
    public byte DoHelp(int argc, sbyte** argv) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientCommunicationSystem, int, sbyte**, byte>)0x005806F0)(ref this, argc, argv);

    /// <summary>Displays a pop‑up dialog using the string extracted from the supplied communication packet.
    /// <code>Offset: 0x00580B90
    /// int __stdcall ClientCommunicationSystem::Handle_Communication__PopUpString(int)</code>
    /// </summary>
    /// <param name="a1">Pointer to the communication data containing the message text at offset 20.</param>
    /// <returns>Zero, indicating the operation completed (the return value is not used for error reporting).</returns>
    public static int Handle_Communication__PopUpString(int a1) => ((delegate* unmanaged[Stdcall]<int, int>)0x00580B90)(a1);

    /// <summary>Initiates the death command by displaying a confirmation dialog when invoked with no arguments, or shows usage help text if arguments are provided.
    /// <code>Offset: 0x00580D60
    /// bool __thiscall ClientCommunicationSystem::DoDie(ClientCommunicationSystem*,int,char**)</code>
    /// </summary>
    /// <param name="argc">Number of arguments passed to the command; a non‑zero value triggers help output instead of the prompt.</param>
    /// <param name="argv">Array of argument strings (unused in this implementation).</param>
    /// <returns>True to indicate that the command was processed successfully.</returns>
    public byte DoDie(int argc, sbyte** argv) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientCommunicationSystem, int, sbyte**, byte>)0x00580D60)(ref this, argc, argv);

    /// <summary>Processes the result of an initial house‑abandonment dialog and, when the user indicates they wish to abandon their house, displays a final confirmation prompt.
    /// <code>Offset: 0x00580F50
    /// void __cdecl ClientCommunicationSystem::HouseAbandonDialogCallback_First(const PropertyCollection*)</code>
    /// </summary>
    /// <param name="i_rcResults">Collection of properties returned from the first dialog containing the player’s response.</param>
    public static void HouseAbandonDialogCallback_First(ACBindings.Internal.PropertyCollection* i_rcResults) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.PropertyCollection*, void>)0x00580F50)(i_rcResults);

    /// <summary>Processes a chat pose command, executing associated actions such as smartbox commands and soul emotes based on the input string.
    /// <code>Offset: 0x00581190
    /// char __thiscall ClientCommunicationSystem::Pose(void*,const char**)</code>
    /// </summary>
    /// <param name="a2">Array containing the pose command string to process.</param>
    /// <returns>Non‑zero if the command was handled successfully; zero otherwise.</returns>
    public sbyte Pose(sbyte** a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientCommunicationSystem, sbyte**, sbyte>)0x00581190)(ref this, a2);

    /// <summary>Replaces variable placeholders in the supplied string, converting newline characters into the client’s name and replacing “%DATE%” with the current date formatted as YYYY‑MM‑DD‑Day.
    /// <code>Offset: 0x00581450
    /// LONG __stdcall ClientCommunicationSystem::MakeLoadFileVariableSubstitutions(const char**)</code>
    /// </summary>
    /// <param name="a1">Pointer to a null‑terminated C‑string that will be modified in place with substitutions.</param>
    /// <returns>Zero when substitutions succeed; non‑zero indicates an error or reference count exhaustion during string handling.</returns>
    public static int MakeLoadFileVariableSubstitutions(sbyte** a1) => ((delegate* unmanaged[Stdcall]<sbyte**, int>)0x00581450)(a1);

    /// <summary>Processes textbox input, removes special command markers, checks for squelch status, appends a newline if allowed, and adds the resulting text to the chat scroll.
    /// <code>Offset: 0x00581570
    /// int __thiscall ClientCommunicationSystem::Handle_Communication__TextboxString(ClientSystem*,int,unsigned int)</code>
    /// </summary>
    /// <param name="a2">Pointer to the string entered in the textbox.</param>
    /// <param name="i_ltt">Identifier of the communication source (e.g., local player ID).</param>
    /// <returns>Zero; the function always returns 0.</returns>
    public int Handle_Communication__TextboxString(int a2, uint i_ltt) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientCommunicationSystem, int, uint, int>)0x00581570)(ref this, a2, i_ltt);

    /// <summary>Processes house‑related chat commands entered by the player, handling actions such as opening or closing the house, recalling to it, accessing storage, managing guests, and toggling hook visibility.
    /// <code>Offset: 0x005816E0
    /// bool __thiscall ClientCommunicationSystem::DoHouse(ClientCommunicationSystem*,int,char**)</code>
    /// </summary>
    /// <param name="argc">Number of arguments supplied with the command.</param>
    /// <param name="argv">Array of argument strings; argv[0] is the subcommand (e.g., "open", "close").</param>
    /// <returns>True if the command was processed successfully; otherwise false.</returns>
    public byte DoHouse(int argc, sbyte** argv) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientCommunicationSystem, int, sbyte**, byte>)0x005816E0)(ref this, argc, argv);

    /// <summary>Extracts the substring between two specified delimiter characters from a string, forwards that substring through ClientCommunicationSystem::Pose, then removes the extracted portion from the original string.
    /// <code>Offset: 0x00581E50
    /// LONG __thiscall ClientCommunicationSystem::RemoveTextBetween(void*,int,char,char)</code>
    /// </summary>
    /// <param name="a2">Pointer to the string object (PStringBase&lt;char&gt;) containing the text to be processed.</param>
    /// <param name="a3">Character marking the start of the section to remove.</param>
    /// <param name="a4">Character marking the end of the section to remove.</param>
    /// <returns>Reference count of the temporary buffer after processing, or zero if the buffer was freed.</returns>
    public int RemoveTextBetween(int a2, sbyte a3, sbyte a4) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientCommunicationSystem, int, sbyte, sbyte, int>)0x00581E50)(ref this, a2, a3, a4);

    /// <summary>Sanitizes and broadcasts a public chat message, stripping markup such as &lt;…&gt; tags and isolated '*' characters, trimming whitespace, and ensuring copy‑on‑write semantics before sending it to the communication system.
    /// <code>Offset: 0x00581F70
    /// char* __thiscall ClientCommunicationSystem::PublicChat(void*,int)</code>
    /// </summary>
    /// <param name="a2">Pointer to a PStringBase&lt;char&gt; containing the raw chat text submitted for broadcasting.</param>
    /// <returns>Character pointer to the processed message buffer; null if the string was released during processing or empty after sanitization.</returns>
    public sbyte* PublicChat(int a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientCommunicationSystem, int, sbyte*>)0x00581F70)(ref this, a2);

    /// <summary>Processes a chat command by concatenating the supplied arguments into a single message, trimming leading and trailing whitespace, then broadcasting it or displaying an error if no text is provided.
    /// <code>Offset: 0x005820C0
    /// bool __thiscall ClientCommunicationSystem::DoSay(ClientCommunicationSystem*,const OLECHAR*,char**)</code>
    /// </summary>
    /// <param name="argc">The count of arguments supplied for the command.</param>
    /// <param name="argv">An array of strings containing each argument.</param>
    /// <returns>Always true; indicates that the command was processed (an error message may be shown if the message is empty).</returns>
    public byte DoSay(System.IntPtr argc, sbyte** argv) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientCommunicationSystem, System.IntPtr, sbyte**, byte>)0x005820C0)(ref this, argc, argv);

    /// <summary>Handles an incoming chat message or command from a client, parsing the command string and executing special handlers for commands that begin with '/', ':', ';' or '@'. If no special handler applies, forwards the text to the appropriate channel or direct recipient, broadcasting public messages when necessary.
    /// <code>Offset: 0x005821A0
    /// bool __thiscall ClientCommunicationSystem::OnChatCommand(ClientCommunicationSystem*,CLogonHeader::HandshakeWireData)</code>
    /// </summary>
    /// <param name="a2">The handshake data containing the client’s version string buffer and authentication information used to identify the command source and determine how the message should be routed.</param>
    /// <returns>True if the command was successfully processed; otherwise false when a required resource is unavailable.</returns>
    public byte OnChatCommand(ACBindings.Internal.CLogonHeader.HandshakeWireData a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientCommunicationSystem, ACBindings.Internal.CLogonHeader.HandshakeWireData, byte>)0x005821A0)(ref this, a2);

    /// <summary>Loads a script file line by line, executing each command within the client communication system.
    /// <code>Offset: 0x00582590
    /// char __thiscall ClientCommunicationSystem::LoadFile(ClientCommunicationSystem*,const char**)</code>
    /// </summary>
    /// <param name="a2">Pointer to a null-terminated string containing the path of the file to load.</param>
    /// <returns>Nonzero if the file was successfully opened and processed; otherwise zero.</returns>
    public sbyte LoadFile(sbyte** a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientCommunicationSystem, sbyte**, sbyte>)0x00582590)(ref this, a2);

    /// <summary>Attempts to load a file specified by the command arguments and reports errors via the client system's scroll window.
    /// <code>Offset: 0x005826F0
    /// bool __thiscall ClientCommunicationSystem::DoLoadFile(ClientCommunicationSystem*,int,char**)</code>
    /// </summary>
    /// <param name="argc">Number of arguments passed to the command.</param>
    /// <param name="argv">Array of argument strings; the first element is expected to be the file name.</param>
    /// <returns>True if the command was processed (the current implementation always returns true).</returns>
    public byte DoLoadFile(int argc, sbyte** argv) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientCommunicationSystem, int, sbyte**, byte>)0x005826F0)(ref this, argc, argv);

    /// <summary>Initializes the client communication system by registering a comprehensive set of command handlers and populating an internal command lookup table with command names, descriptions, and their associated callback functions.
    /// <code>Offset: 0x005827F0
    /// void __thiscall ClientCommunicationSystem::InitializeCommands(ClientCommunicationSystem*)</code>
    /// </summary>
    public void InitializeCommands() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientCommunicationSystem, void>)0x005827F0)(ref this);

    /// <summary>Initializes a new instance of the client communication system by setting up reference counting, internal command tables, and registering notice handlers for global events. The constructor configures state such as last command line, current command, spam check counters, chat message count, and log name, and establishes the static singleton pointer to this communication system.
    /// <code>Offset: 0x005863A0
    /// void __thiscall ClientCommunicationSystem::ClientCommunicationSystem(ClientCommunicationSystem*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientCommunicationSystem, void>)0x005863A0)(ref this);
}

