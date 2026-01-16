namespace ACBindings.Internal;


/// <summary>
/// Manages in‑game communication, coordinating Turbine chat integration, message filtering (squelching), and target tracking.  
/// Holds state such as the current talk focus, last speakable entity, and user names for @monarch/@patron contexts.  
/// Provides interfaces for initializing chat systems, querying status, and updating squelch settings.
/// </summary>
public unsafe struct gmCCommunicationSystem
{
    // Base Classes
    public ACBindings.Internal.CCommunicationSystem BaseClass_CCommunicationSystem; // ACBindings.Internal.CCommunicationSystem

    // Child Types
    public unsafe struct gmCCommunicationSystem_vtbl
    {
        // Members
        public System.IntPtr StartupTurbineChat_Internal;
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.gmCCommunicationSystem*, ACBindings.Internal.CCommunicationSystem.ChatInterfaceProvider*> CreateChatInterfaceProvider; // function pointer

        // Methods
    }

    /// <summary>Implements chat communication handling for the system, managing message dispatch and user‑interface updates.</summary>
    public unsafe struct uiChatInterfaceProvider
    {
        // Base Classes
        public ACBindings.Internal.CCommunicationSystem.ChatInterfaceProvider BaseClass_CCommunicationSystem_ChatInterfaceProvider; // ACBindings.Internal.CCommunicationSystem.ChatInterfaceProvider

        // Child Types
        public unsafe struct uiChatInterfaceProvider_vtbl
        {
            // Members
            public static delegate* unmanaged[Stdcall]<ACBindings.Internal.IUnknown*, ACBindings.Internal._GUID*, void**, int> QueryInterface; // function pointer
            public static delegate* unmanaged[Stdcall]<ACBindings.Internal.IUnknown*, uint> AddRef; // function pointer
            public static delegate* unmanaged[Stdcall]<ACBindings.Internal.IUnknown*, uint> Release; // function pointer
            public static delegate* unmanaged[Stdcall]<ACBindings.Internal.IChatNetwork*, ACBindings.Internal.tagBLOB, int> SendData; // function pointer
            public static delegate* unmanaged[Stdcall]<ACBindings.Internal.IChatNetwork*, int> UseTime; // function pointer
            public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CCommunicationSystem.ChatInterfaceProvider*, void> ChatInterfaceProvider_dtor_14; // function pointer

            // Methods
        }

        // Methods

        /// <summary>Handles the completion of an asynchronous send-to-room request by reporting failures to the UI scroll pane.
        /// <code>Offset: 0x0058AC60
        /// void __stdcall gmCCommunicationSystem::uiChatInterfaceProvider::OnSendToRoomByIDResult(gmCCommunicationSystem::uiChatInterfaceProvider*,HRESULT,unsigned int,const unsigned __int16*,tagBLOB)</code>
        /// </summary>
        /// <param name="hAsyncResult">Result code; non-zero indicates failure.</param>
        /// <param name="dwRoomID">Identifier of the target chat room.</param>
        /// <param name="pwszText">The text that was attempted to be sent.</param>
        /// <param name="localBlob">Additional data associated with the operation (unused by this handler).</param>
        public static void OnSendToRoomByIDResult(ACBindings.Internal.gmCCommunicationSystem.uiChatInterfaceProvider* this_, int hAsyncResult, uint dwRoomID, ushort* pwszText, ACBindings.Internal.tagBLOB localBlob) => ((delegate* unmanaged[Stdcall]<ACBindings.Internal.gmCCommunicationSystem.uiChatInterfaceProvider*, int, uint, ushort*, ACBindings.Internal.tagBLOB, void>)0x0058AC60)(this_, hAsyncResult, dwRoomID, pwszText, localBlob);

        /// <summary>Processes an outgoing chat message for a specified room, performing safety and squelch checks before displaying it in the UI.
        /// <code>Offset: 0x0058B3C0
        /// void __stdcall gmCCommunicationSystem::uiChatInterfaceProvider::OnSendToRoom(gmCCommunicationSystem::uiChatInterfaceProvider*,unsigned int,const unsigned __int16*,const unsigned __int16*,tagBLOB)</code>
        /// </summary>
        /// <param name="dwRoomID">Identifier of the target chat room.</param>
        /// <param name="pwszDisplayName">Unicode display name of the sender.</param>
        /// <param name="pwszText">Unicode text content of the message.</param>
        /// <param name="extraInfoBlob">Additional data blob containing command metadata used for formatting and handling the message.</param>
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

    /// <summary>Sets the current talk focus in the communication system.
    /// <code>Offset: 0x00589E70
    /// void __cdecl gmCCommunicationSystem::SetTalkFocus(unsigned int)</code>
    /// </summary>
    /// <param name="focus">Identifier for the entity to become the new talk focus.</param>
    public static void SetTalkFocus(uint focus) => ((delegate* unmanaged[Cdecl]<uint, void>)0x00589E70)(focus);

    /// <summary>Retrieves the identifier of the entity currently in focus for communication, providing a default when no system instance exists.
    /// <code>Offset: 0x00589E90
    /// unsigned int __cdecl gmCCommunicationSystem::GetTalkFocus()</code>
    /// </summary>
    /// <returns>An unsigned integer indicating the current talk focus; returns 1 if the communication system has not been instantiated.</returns>
    public static uint GetTalkFocus() => ((delegate* unmanaged[Cdecl]<uint>)0x00589E90)();

    /// <summary>Enables or disables a specific talk focus flag for the communication system and informs registered listeners of the change.
    /// <code>Offset: 0x00589EB0
    /// void __cdecl gmCCommunicationSystem::SetTalkFocusEnabled(unsigned int,bool)</code>
    /// </summary>
    /// <param name="i_eFocus">Index of the talk focus to modify; treated as a bit position in an internal mask.</param>
    /// <param name="i_bEnabled">If true, sets the corresponding bit to enable the focus; if false, clears it.</param>
    public static void SetTalkFocusEnabled(uint i_eFocus, byte i_bEnabled) => ((delegate* unmanaged[Cdecl]<uint, byte, void>)0x00589EB0)(i_eFocus, i_bEnabled);

    /// <summary>Determines whether the specified talk focus mode is currently active by testing a bitmask stored in the communication system.
    /// <code>Offset: 0x00589F00
    /// bool __cdecl gmCCommunicationSystem::IsTalkFocusEnabled(unsigned int)</code>
    /// </summary>
    /// <param name="i_eFocus">The index of the talk focus flag to query.</param>
    /// <returns>True if the corresponding bit is set; otherwise, false.</returns>
    public static byte IsTalkFocusEnabled(uint i_eFocus) => ((delegate* unmanaged[Cdecl]<uint, byte>)0x00589F00)(i_eFocus);

    /// <summary>Provides access to the chat room tracker maintained by the global communication system.
    /// <code>Offset: 0x00589F20
    /// ChatRoomTracker* __cdecl gmCCommunicationSystem::GetChatRoomTracker()</code>
    /// </summary>
    /// <returns>The ChatRoomTracker instance used by CCommunicationSystem, or nullptr when no communication system has been instantiated.</returns>
    public static ACBindings.Internal.ChatRoomTracker* GetChatRoomTracker() => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.ChatRoomTracker*>)0x00589F20)();

    /// <summary>Sets the communication system's chat room tracker to the supplied configuration if a global instance exists.
    /// <code>Offset: 0x00589F40
    /// int __cdecl gmCCommunicationSystem::SetChatRoomTracker(const ChatRoomTracker*)</code>
    /// </summary>
    /// <param name="i_pChatTracker">Pointer to a ChatRoomTracker containing identifiers for various chat rooms.</param>
    /// <returns>Nonzero (1) when the tracker is successfully applied; otherwise zero indicates no active communication system instance.</returns>
    public static int SetChatRoomTracker(ACBindings.Internal.ChatRoomTracker* i_pChatTracker) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.ChatRoomTracker*, int>)0x00589F40)(i_pChatTracker);

    /// <summary>Sets whether the communication system should join an allegiance chat.
    /// <code>Offset: 0x00589F60
    /// void __cdecl gmCCommunicationSystem::SetWantsToBeInAllegChat(int)</code>
    /// </summary>
    /// <param name="wantsToBeInAllegChat">Non‑zero to enable joining, zero to disable.</param>
    public static void SetWantsToBeInAllegChat(int wantsToBeInAllegChat) => ((delegate* unmanaged[Cdecl]<int, void>)0x00589F60)(wantsToBeInAllegChat);

    /// <summary>Retrieves whether the communication system has requested participation in the Allegiance chat channel.
    /// <code>Offset: 0x00589F80
    /// int __cdecl gmCCommunicationSystem::WantsToBeInAllegChat()</code>
    /// </summary>
    /// <returns>The flag value from the global instance (non‑zero if desired, otherwise zero).</returns>
    public static int WantsToBeInAllegChat() => ((delegate* unmanaged[Cdecl]<int>)0x00589F80)();

    /// <summary>Records the given identifier as the most recent entity eligible for speaking within the communication system.
    /// <code>Offset: 0x00589FA0
    /// void __cdecl gmCCommunicationSystem::SetLastSpeakableTarget(unsigned int)</code>
    /// </summary>
    /// <param name="i_iidTarget">The unique identifier of the target to set as speakable.</param>
    public static void SetLastSpeakableTarget(uint i_iidTarget) => ((delegate* unmanaged[Cdecl]<uint, void>)0x00589FA0)(i_iidTarget);

    /// <summary>Retrieves the identifier of the most recent entity eligible for speaking actions within the communication system.
    /// <code>Offset: 0x00589FC0
    /// unsigned int __cdecl gmCCommunicationSystem::GetLastSpeakableTarget()</code>
    /// </summary>
    /// <returns>The unique ID of the last speakable target; returns zero if no communication system instance is present.</returns>
    public static uint GetLastSpeakableTarget() => ((delegate* unmanaged[Cdecl]<uint>)0x00589FC0)();

    /// <summary>Records the identifier of the most recent speaker for use by the communication system.
    /// <code>Offset: 0x00589FD0
    /// void __cdecl gmCCommunicationSystem::SetLastTeller(unsigned int)</code>
    /// </summary>
    /// <param name="id">The ID of the entity that last spoke.</param>
    public static void SetLastTeller(uint id) => ((delegate* unmanaged[Cdecl]<uint, void>)0x00589FD0)(id);

    /// <summary>Retrieves the identifier of the most recent entity that sent a tell message. Returns zero when the communication system has not been initialized.
    /// <code>Offset: 0x00589FF0
    /// unsigned int __cdecl gmCCommunicationSystem::GetLastTeller()</code>
    /// </summary>
    /// <returns>The ID stored in lastTeller; 0 if no instance exists.</returns>
    public static uint GetLastTeller() => ((delegate* unmanaged[Cdecl]<uint>)0x00589FF0)();

    /// <summary>Determines whether communication with a given target ID and chat type is currently suppressed.
    /// <code>Offset: 0x0058A000
    /// int __cdecl gmCCommunicationSystem::IsSquelched(unsigned int,int*,unsigned int)</code>
    /// </summary>
    /// <param name="a1">Identifier of the target to check.</param>
    /// <param name="a2">Optional pointer for additional status information returned by the SquelchDB query.</param>
    /// <param name="ltt">Chat type or channel identifier used in the query.</param>
    /// <returns>Non‑zero if the communication system is uninitialized or the target/channel is squelched; zero only when the chat type is illegal. Otherwise forwards to the SquelchDB which returns a non‑zero value for a squelched state.</returns>
    public static int IsSquelched(uint a1, int* a2, uint ltt) => ((delegate* unmanaged[Cdecl]<uint, int*, uint, int>)0x0058A000)(a1, a2, ltt);

    /// <summary>Updates the communication system’s squelch database with new values and informs registered listeners of the change.
    /// <code>Offset: 0x0058A050
    /// void __cdecl gmCCommunicationSystem::SetSquelchDB(const SquelchDB*)</code>
    /// </summary>
    /// <param name="db">The source SquelchDB containing updated account, character, and global squelch settings.</param>
    public static void SetSquelchDB(ACBindings.Internal.SquelchDB* db) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.SquelchDB*, void>)0x0058A050)(db);

    /// <summary>Resets the communication system’s squelch database and informs all registered global event listeners that the squelch state has been cleared.
    /// <code>Offset: 0x0058A070
    /// void __cdecl gmCCommunicationSystem::ClearSquelchDB()</code>
    /// </summary>
    public static void ClearSquelchDB() => ((delegate* unmanaged[Cdecl]<void>)0x0058A070)();

    /// <summary>Initializes a communication system instance with default values, sets up the base class, allocates a chat room tracker, and establishes empty state for speaker and message strings.
    /// <code>Offset: 0x0058A1F0
    /// void __thiscall gmCCommunicationSystem::gmCCommunicationSystem(gmCCommunicationSystem*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmCCommunicationSystem, void>)0x0058A1F0)(ref this);

    /// <summary>Updates the communication system’s last known target ID to the supplied value, handling reference counts for the previous and new targets.
    /// <code>Offset: 0x0058A2B0
    /// LONG __cdecl gmCCommunicationSystem::SetLastTelleeName(int)</code>
    /// </summary>
    /// <param name="a1">Identifier of the entity that becomes the new last told‑to target.</param>
    /// <returns>A status code representing the remaining reference count after decrement; zero indicates the object was released and a cleanup routine was executed.</returns>
    public static int SetLastTelleeName(int a1) => ((delegate* unmanaged[Cdecl]<int, int>)0x0058A2B0)(a1);

    /// <summary>Updates the last teller identifier in the communication system and manages associated reference counts.
    /// <code>Offset: 0x0058A330
    /// __int32 __cdecl gmCCommunicationSystem::SetLastTellerName(int*)</code>
    /// </summary>
    /// <param name="a1">Pointer to the new teller ID to set as last.</param>
    /// <returns>The reference count of the newly assigned teller after incrementing; if no change occurs, returns the existing identifier value; may return zero when the system instance is not available.</returns>
    public static int SetLastTellerName(int* a1) => ((delegate* unmanaged[Cdecl]<int*, int>)0x0058A330)(a1);

    /// <summary>Retrieves the current last teller’s name string and increments its reference count for safe use.
    /// <code>Offset: 0x0058A380
    /// void** __cdecl gmCCommunicationSystem::GetLastTellerName(void**)</code>
    /// </summary>
    /// <param name="a1">Output parameter receiving a pointer to the last teller’s name string; the function increases the string’s reference count before returning it.</param>
    /// <returns>The same pointer passed in through <c>a1</c> to allow chaining.</returns>
    public static void** GetLastTellerName(void** a1) => ((delegate* unmanaged[Cdecl]<void**, void**>)0x0058A380)(a1);

    /// <summary>Sets the system’s last monarch user name to the given identifier, handling reference counts on previous and current entries.
    /// <code>Offset: 0x0058A3C0
    /// LONG __cdecl gmCCommunicationSystem::SetLastAtMonarchUserName(int)</code>
    /// </summary>
    /// <param name="a1">The identifier of the new monarch user name.</param>
    /// <returns>The updated reference count for the supplied identifier after the operation; zero indicates it has been released.</returns>
    public static int SetLastAtMonarchUserName(int a1) => ((delegate* unmanaged[Cdecl]<int, int>)0x0058A3C0)(a1);

    /// <summary>Retrieves the most recent “AtMonarch” user name and stores its address in the supplied pointer, incrementing an internal reference counter.
    /// <code>Offset: 0x0058A440
    /// void** __cdecl gmCCommunicationSystem::GetLastAtMonarchUserName(void**)</code>
    /// </summary>
    /// <param name="a1">Pointer to a location where the address of the string will be stored.</param>
    /// <returns>The same pointer that was passed in, pointing to the last “AtMonarch” user name string.</returns>
    public static void** GetLastAtMonarchUserName(void** a1) => ((delegate* unmanaged[Cdecl]<void**, void**>)0x0058A440)(a1);

    /// <summary>Assigns a new “at patron” username to the communication system, updating internal state and managing string reference counts.
    /// <code>Offset: 0x0058A480
    /// LONG __cdecl gmCCommunicationSystem::SetLastAtPatronUserName(int)</code>
    /// </summary>
    /// <param name="a1">Pointer to the PStringBase instance containing the new username.</param>
    /// <returns>The resulting reference count after assignment; zero indicates the object was released.</returns>
    public static int SetLastAtPatronUserName(int a1) => ((delegate* unmanaged[Cdecl]<int, int>)0x0058A480)(a1);

    /// <summary>Retrieves the current “@patron” username string from the communication system and stores its address in the supplied argument while ensuring correct reference counting.
    /// <code>Offset: 0x0058A500
    /// void** __cdecl gmCCommunicationSystem::GetLastAtPatronUserName(void**)</code>
    /// </summary>
    /// <param name="a1">A pointer to a location where the function will write the address of the "@patron" username string. After the call, *a1 points to that string buffer.</param>
    /// <returns>Returns the same pointer passed in (i.e., a1), now pointing to the retrieved username buffer.</returns>
    public static void** GetLastAtPatronUserName(void** a1) => ((delegate* unmanaged[Cdecl]<void**, void**>)0x0058A500)(a1);

    /// <summary>Initializes the global squelch iterator by setting its current position, table size, and bucket array based on the SquelchDB hash table.
    /// <code>Offset: 0x0058A540
    /// void __cdecl gmCCommunicationSystem::StartSquelchIteration()</code>
    /// </summary>
    public static void StartSquelchIteration() => ((delegate* unmanaged[Cdecl]<void>)0x0058A540)();

    /// <summary>Initializes the Turbine chat subsystem for this communication system, coordinating with the client communication system.
    /// <code>Offset: 0x0058A580
    /// BOOL __thiscall gmCCommunicationSystem::StartupTurbineChat_Internal(_DWORD*,int)</code>
    /// </summary>
    /// <param name="a2">Pointer to an object that holds a reference counter (offset +4) and a callback invoked when initialization completes.</param>
    /// <returns>True if the Turbine chat subsystem was successfully started; otherwise, false.</returns>
    public byte StartupTurbineChat_Internal(int a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmCCommunicationSystem, int, byte>)0x0058A580)(ref this, a2);

    /// <summary>Determines whether a message addressed to an entity is audible, taking into account squelch rules and proximity.
    /// <code>Offset: 0x0058A690
    /// int __cdecl gmCCommunicationSystem::CanHear(const unsigned int,const unsigned int)</code>
    /// </summary>
    /// <param name="iid">Identifier of the target entity.</param>
    /// <param name="msg_type">Message type or channel identifier.</param>
    /// <returns>Non‑zero if the message can be heard; zero otherwise.</returns>
    public static int CanHear(uint iid, uint msg_type) => ((delegate* unmanaged[Cdecl]<uint, uint, int>)0x0058A690)(iid, msg_type);

    /// <summary>Retrieves the next squelched entity from the communication system and provides its name and zone status.
    /// <code>Offset: 0x0058A790
    /// int __cdecl gmCCommunicationSystem::NextSquelchIteration(int*,int*)</code>
    /// </summary>
    /// <param name="a1">Output buffer to receive the squelch's name.</param>
    /// <param name="a2">Pointer that receives the zone‑squelch flag (non‑zero if the squelch applies to a zone).</param>
    /// <returns>Non‑zero if another squelched entry was returned; zero when no further entries exist or an error occurs.</returns>
    public static int NextSquelchIteration(int* a1, int* a2) => ((delegate* unmanaged[Cdecl]<int*, int*, int>)0x0058A790)(a1, a2);

    /// <summary>Create a new chat interface provider linked to this communication system, initializing its COM‑style interfaces for networking, event handling, and asynchronous results.
    /// <code>Offset: 0x0058A830
    /// CCommunicationSystem::ChatInterfaceProvider* __thiscall gmCCommunicationSystem::CreateChatInterfaceProvider(gmCCommunicationSystem*)</code>
    /// </summary>
    /// <param name="this">The communication system instance for which the provider is created.</param>
    /// <returns>A pointer to the initialized ChatInterfaceProvider, or nullptr if memory allocation fails.</returns>
    public ACBindings.Internal.CCommunicationSystem.ChatInterfaceProvider* CreateChatInterfaceProvider() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmCCommunicationSystem, ACBindings.Internal.CCommunicationSystem.ChatInterfaceProvider*>)0x0058A830)(ref this);

    /// <summary>Retrieves the character buffer for the name of the last entity told, storing it in the supplied pointer and incrementing its reference count.
    /// <code>Offset: 0x0058A870
    /// void** __cdecl gmCCommunicationSystem::GetLastTelleeName(void**)</code>
    /// </summary>
    /// <param name="a1">Receives a pointer to the string buffer containing the last told name.</param>
    /// <returns>The same pointer that was passed in, now pointing at the retrieved buffer.</returns>
    public static void** GetLastTelleeName(void** a1) => ((delegate* unmanaged[Cdecl]<void**, void**>)0x0058A870)(a1);

    /// <summary>Converts a SquelchInfo into a human‑readable description and stores it in the supplied output buffer.
    /// <code>Offset: 0x0058A8B0
    /// int __cdecl gmCCommunicationSystem::ConvertSQToPString(SquelchInfo*,int*,int)</code>
    /// </summary>
    /// <param name="a1">The SquelchInfo instance containing channel suppression data.</param>
    /// <param name="a2">Pointer to a string buffer that will receive the formatted text.</param>
    /// <param name="a3">If non‑zero, enumerate each squelched channel; if zero and the default channel is suppressed, write “All message types” instead of a list.</param>
    /// <returns>Zero on successful conversion; a non‑zero value indicates that the input was empty or an internal reference count reached zero during cleanup.</returns>
    public static int ConvertSQToPString(ACBindings.Internal.SquelchInfo* a1, int* a2, int a3) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.SquelchInfo*, int*, int, int>)0x0058A8B0)(a1, a2, a3);

    /// <summary>Populates the supplied string pointer with a formatted list of squelch channel names.
    /// <code>Offset: 0x0058ACE0
    /// int __cdecl gmCCommunicationSystem::GetListofSquelchChannels(char**)</code>
    /// </summary>
    /// <param name="a1">Address of a character buffer that receives the generated message. The caller is responsible for allocating and freeing this buffer.</param>
    /// <returns>Always 1, indicating successful completion.</returns>
    public static int GetListofSquelchChannels(sbyte** a1) => ((delegate* unmanaged[Cdecl]<sbyte**, int>)0x0058ACE0)(a1);

    /// <summary>Handles a ranged chat event by checking whether the message should be displayed, formatting it according to the talk focus, and adding it to the client UI scroll.
    /// <code>Offset: 0x0058AD90
    /// void __cdecl gmCCommunicationSystem::HandleRangedTalkEvent(int,int,unsigned int,float,unsigned int)</code>
    /// </summary>
    /// <param name="a1">Pointer to the object that contains the chat text to be displayed.</param>
    /// <param name="a2">Pointer to the speaker’s entity object used for retrieving the speaker’s name.</param>
    /// <param name="ArgList">Identifier of the talk focus or target, used to determine if the message is squelched and how it should be formatted.</param>
    /// <param name="a4">Distance radius within which nearby objects are considered for displaying the message.</param>
    /// <param name="i_ltt">Display flags or timestamp value passed to the UI scroll when adding the chat text.</param>
    public static void HandleRangedTalkEvent(int a1, int a2, uint ArgList, float a4, uint i_ltt) => ((delegate* unmanaged[Cdecl]<int, int, uint, float, uint, void>)0x0058AD90)(a1, a2, ArgList, a4, i_ltt);

    /// <summary>Displays the list of message types currently filtered globally and outputs the information to the chat window.
    /// <code>Offset: 0x0058AED0
    /// int __cdecl gmCCommunicationSystem::DoGlobalSquelchQuery()</code>
    /// </summary>
    /// <returns>An integer status code: non‑zero indicates success, zero indicates failure (e.g., no communication system instance is available).</returns>
    public static int DoGlobalSquelchQuery() => ((delegate* unmanaged[Cdecl]<int>)0x0058AED0)();

    /// <summary>
    /// Queries the current squelch settings, builds a formatted list of characters whose messages are blocked, displays it in the client UI scroll window, and indicates whether the operation succeeded.
    /// 
    /// <code>Offset: 0x0058B0F0
    /// int __cdecl gmCCommunicationSystem::DoSquelchQuery()</code>
    /// </summary>
    /// <returns>
    /// Returns 1 when the squelch query information is displayed successfully; returns 0 if no communication system instance is available.
    /// </returns>
    public static int DoSquelchQuery() => ((delegate* unmanaged[Cdecl]<int>)0x0058B0F0)();
}

