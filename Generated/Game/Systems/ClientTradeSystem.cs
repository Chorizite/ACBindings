namespace ACBindings.Internal;


/// <summary>Manages trading interactions for a client, storing trade session data, participant IDs, and reference counts, while coordinating with the global trade system.</summary>
public unsafe struct ClientTradeSystem : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.ClientSystem BaseClass_ClientSystem; // ACBindings.Internal.ClientSystem

    // Statics
    public static ACBindings.Internal.ClientTradeSystem** s_pTradeSystem = (ACBindings.Internal.ClientTradeSystem**)0x0087174C;

    // Child Types
    public unsafe struct ClientTradeSystem_vtbl
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
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ClientTradeSystem*, ACBindings.Internal.ClientTradeSystem.Enum16> You_Must_Not_Have_Multiple_Implementations_Of_AddRef_In_A_Hierarchy; // function pointer

        // Methods
    }
    // ClientTradeSystem::Enum15
    public enum Enum15 : uint
    {
    }
    // ClientTradeSystem::Enum16
    public enum Enum16 : uint
    {
    }
    // ClientTradeSystem::Enum17
    public enum Enum17 : uint
    {
    }
    // ClientTradeSystem::Enum4
    public enum Enum4 : uint
    {
    }

    // Members
    public ACBindings.Internal.Turbine_RefCount m_cTurbineRefCount;
    public ACBindings.Internal.Trade* m_pTrade;
    public uint m_iidTradeInitiator;
    public uint m_iidTradePartner;
    public uint attemptTradeToPlayerID;
    public uint attemptTradeObjectID;

    // Generated Constructor
    public ClientTradeSystem() {
        _ConstructorInternal();
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>Provides access to the single ClientTradeSystem instance used by the client.
    /// <code>Offset: 0x0056E6B0
    /// ClientTradeSystem* __cdecl ClientTradeSystem::GetTradeSystem()</code>
    /// </summary>
    /// <returns>A pointer to the global trade system object, or null if the system has not yet been created.</returns>
    public static ACBindings.Internal.ClientTradeSystem* GetTradeSystem() => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.ClientTradeSystem*>)0x0056E6B0)();

    /// <summary>Shuts down the client trade system, releasing any allocated resources and resetting the global instance reference.
    /// <code>Offset: 0x0056E6C0
    /// void __thiscall ClientTradeSystem::OnShutdown(ClientTradeSystem*)</code>
    /// </summary>
    public void OnShutdown() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientTradeSystem, void>)0x0056E6C0)(ref this);

    /// <summary>Handles a received open‑trade message by notifying the client system and indicating success.
    /// <code>Offset: 0x0056E6E0
    /// unsigned int __thiscall ClientTradeSystem::Handle_Trade__Recv_OpenTrade(ClientTradeSystem*,unsigned int)</code>
    /// </summary>
    /// <param name="source">Identifier of the initiator who sent the open‑trade request.</param>
    /// <returns>Zero to indicate that the trade request has been processed successfully.</returns>
    public uint Handle_Trade__Recv_OpenTrade(uint source) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientTradeSystem, uint, uint>)0x0056E6E0)(ref this, source);

    /// <summary>Handles a reset trade request from the specified source, sending a notice, adjusting plugin reference counts if available, and clearing the current trade session.
    /// <code>Offset: 0x0056E700
    /// unsigned int __thiscall ClientTradeSystem::Handle_Trade__Recv_ResetTrade(ClientTradeSystem*,unsigned int)</code>
    /// </summary>
    /// <param name="source">The identifier of the entity requesting the trade reset.</param>
    /// <returns>Always returns 0 to indicate successful handling.</returns>
    public uint Handle_Trade__Recv_ResetTrade(uint source) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientTradeSystem, uint, uint>)0x0056E700)(ref this, source);

    /// <summary>Handles a trade‑failure event by removing the specified item from the current trade and broadcasting a trade‑failure notice.
    /// <code>Offset: 0x0056E740
    /// unsigned int __thiscall ClientTradeSystem::Handle_Trade__Recv_TradeFailure(ClientTradeSystem*,unsigned int,unsigned int)</code>
    /// </summary>
    /// <param name="i_iidItem">The identifier of the item involved in the failed trade.</param>
    /// <param name="etype">Error code specifying the reason for the trade failure.</param>
    /// <returns>Zero to indicate that the failure was processed successfully.</returns>
    public uint Handle_Trade__Recv_TradeFailure(uint i_iidItem, uint etype) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientTradeSystem, uint, uint, uint>)0x0056E740)(ref this, i_iidItem, etype);

    /// <summary>Adds the specified item to the local player's trade list at the designated slot.
    /// <code>Offset: 0x0056E780
    /// void __thiscall ClientTradeSystem::AddItemToSelfTradeList(ClientTradeSystem*,unsigned int,int)</code>
    /// </summary>
    /// <param name="i_iidItem">The unique identifier of the item to add.</param>
    /// <param name="i_nPos">The target position in the trade list where the item should be placed.</param>
    public void AddItemToSelfTradeList(uint i_iidItem, int i_nPos) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientTradeSystem, uint, int, void>)0x0056E780)(ref this, i_iidItem, i_nPos);

    /// <summary>Accepts the active trade by marking its accepted flag and triggering the trade‑accepted event.
    /// <code>Offset: 0x0056E7A0
    /// void __thiscall ClientTradeSystem::AcceptTrade(ClientTradeSystem*)</code>
    /// </summary>
    public void AcceptTrade() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientTradeSystem, void>)0x0056E7A0)(ref this);

    /// <summary>Declines the current trade, marking it as unaccepted and notifying the trade system.
    /// <code>Offset: 0x0056E7C0
    /// void __thiscall ClientTradeSystem::DeclineTrade(ClientTradeSystem*)</code>
    /// </summary>
    public void DeclineTrade() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientTradeSystem, void>)0x0056E7C0)(ref this);

    /// <summary>Retrieves the combined count of containers and items currently involved in the trade session.
    /// <code>Offset: 0x0056E7F0
    /// unsigned int __thiscall ClientTradeSystem::GetNumSelfObjectsInTrade(ClientTradeSystem*)</code>
    /// </summary>
    /// <returns>The total number of trade objects owned by the client.</returns>
    public uint GetNumSelfObjectsInTrade() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientTradeSystem, uint>)0x0056E7F0)(ref this);

    /// <summary>Provides the total number of objects that the trade partner has in the current trade, including containers and items.
    /// <code>Offset: 0x0056E810
    /// unsigned int __thiscall ClientTradeSystem::GetNumPartnerObjectsInTrade(ClientTradeSystem*)</code>
    /// </summary>
    /// <returns>The combined count of partner containers and items in the trade session.</returns>
    public uint GetNumPartnerObjectsInTrade() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientTradeSystem, uint>)0x0056E810)(ref this);

    /// <summary>Determines whether the trading partner currently offers a specified item within an active trade session.
    /// <code>Offset: 0x0056E830
    /// bool __thiscall ClientTradeSystem::IsPartnerTradingItem(ClientTradeSystem*,unsigned int)</code>
    /// </summary>
    /// <param name="i_iidItem">Identifier of the item to verify against the partner's trade offer.</param>
    /// <returns>True if the partner is offering that item; otherwise, false.</returns>
    public byte IsPartnerTradingItem(uint i_iidItem) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientTradeSystem, uint, byte>)0x0056E830)(ref this, i_iidItem);

    /// <summary>Ends a character's trading session by destroying any active trade, resetting participant IDs, and attempting to create a fresh trade instance.
    /// <code>Offset: 0x0056E850
    /// void __thiscall ClientTradeSystem::OnEndCharacterSession(ClientTradeSystem*)</code>
    /// </summary>
    public void OnEndCharacterSession() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientTradeSystem, void>)0x0056E850)(ref this);

    /// <summary>Destroys a ClientTradeSystem instance, releasing its current Trade object, resetting reference counts, restoring virtual tables, and invoking base class destructors to clean up resources.
    /// <code>Offset: 0x0056E8A0
    /// void __thiscall ClientTradeSystem::~ClientTradeSystem(ClientTradeSystem*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientTradeSystem, void>)0x0056E8A0)(ref this);

    /// <summary>Attempts to retrieve an interface from a ClientTradeSystem instance by matching the supplied GUID and, if successful, returns a pointer to that interface through an output parameter while recording the operation’s status in the provided TResult object.
    /// <code>Offset: 0x0056E8E0
    /// TResult* __thiscall ClientTradeSystem::QueryInterface(ClientTradeSystem*,TResult*,const Turbine_GUID*,void**)</code>
    /// </summary>
    /// <param name="this">Pointer to the ClientTradeSystem instance requesting the interface.</param>
    /// <param name="result">Object used to receive the result code (0 for success, E_NOINTERFACE otherwise).</param>
    /// <param name="i_rcInterface">GUID identifying the desired interface.</param>
    /// <param name="o_ppvInterface">Output pointer that will be set to the requested interface if supported; can be null.</param>
    /// <returns>Returns the same TResult* passed in via the result parameter.</returns>
    public ACBindings.Internal.TResult* QueryInterface(ACBindings.Internal.TResult* result, ACBindings.Internal.Turbine_GUID* i_rcInterface, void** o_ppvInterface) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientTradeSystem, ACBindings.Internal.TResult*, ACBindings.Internal.Turbine_GUID*, void**, ACBindings.Internal.TResult*>)0x0056E8E0)(ref this, result, i_rcInterface, o_ppvInterface);

    /// <summary>Removes a specified amount of an item from the current trade and notifies other parties.
    /// <code>Offset: 0x0056E9B0
    /// unsigned int __thiscall ClientTradeSystem::Handle_Trade__Recv_RemoveFromTrade(ClientTradeSystem*,unsigned int,unsigned int)</code>
    /// </summary>
    /// <param name="i_iidItem">The identifier of the item to remove from the trade.</param>
    /// <param name="id">Specifies which quantity to remove (1 for one unit, 2 for two units).</param>
    /// <returns>Zero on success.</returns>
    public uint Handle_Trade__Recv_RemoveFromTrade(uint i_iidItem, uint id) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientTradeSystem, uint, uint, uint>)0x0056E9B0)(ref this, i_iidItem, id);

    /// <summary>Processes a received trade accept notification, updating the internal trade state and informing the AC plugin.
    /// <code>Offset: 0x0056E9F0
    /// unsigned int __thiscall ClientTradeSystem::Handle_Trade__Recv_AcceptTrade(ClientTradeSystem*,unsigned int)</code>
    /// </summary>
    /// <param name="source">The identifier of the entity that accepted the trade; a value of zero indicates cancellation or no acceptance.</param>
    /// <returns>Always returns 0 as a status code.</returns>
    public uint Handle_Trade__Recv_AcceptTrade(uint source) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientTradeSystem, uint, uint>)0x0056E9F0)(ref this, source);

    /// <summary>Processes a received trade decline notification, updating internal trade state, informing the user interface and notifying the AC plugin of the outcome.
    /// <code>Offset: 0x0056EA90
    /// unsigned int __thiscall ClientTradeSystem::Handle_Trade__Recv_DeclineTrade(ClientTradeSystem*,unsigned int)</code>
    /// </summary>
    /// <param name="source">The identifier of the player who declined the trade; if it matches the local client ID, the local acceptance flag is cleared, otherwise the partner’s flag is cleared.</param>
    /// <returns>Zero (0) to indicate successful handling of the decline message.</returns>
    public uint Handle_Trade__Recv_DeclineTrade(uint source) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientTradeSystem, uint, uint>)0x0056EA90)(ref this, source);

    /// <summary>Constructs the client trade system, initializing base classes, reference counts, and default trade identifiers; allocates an internal trade instance if memory allocation succeeds.
    /// <code>Offset: 0x0056EB10
    /// void __thiscall ClientTradeSystem::ClientTradeSystem(ClientTradeSystem*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientTradeSystem, void>)0x0056EB10)(ref this);

    /// <summary>Finds the index of an item within the partner’s trade list by matching its identifier.
    /// <code>Offset: 0x0056EB80
    /// int __thiscall ClientTradeSystem::GetItemLocationInPartnerTradeList(ClientTradeSystem*,unsigned int)</code>
    /// </summary>
    /// <param name="i_iidItem">The unique identifier of the item to search for.</param>
    /// <returns>Zero if the item is absent or the list is empty; otherwise returns the zero‑based position of the item in the partner’s trade list.</returns>
    public int GetItemLocationInPartnerTradeList(uint i_iidItem) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientTradeSystem, uint, int>)0x0056EB80)(ref this, i_iidItem);

    /// <summary>Releases a reference to the ClientTradeSystem instance and destroys it when no references remain.
    /// <code>Offset: 0x0056EBB0
    /// unsigned int __thiscall ClientTradeSystem::Release(ClientTradeSystem*)</code>
    /// </summary>
    /// <returns>The remaining reference count after decrementing; zero indicates that the object has been destroyed.</returns>
    public uint Release() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientTradeSystem, uint>)0x0056EBB0)(ref this);

    /// <summary>Handles receipt of a trade close notification by notifying the player, resetting trade data, and cleaning up references.
    /// <code>Offset: 0x0056EBE0
    /// unsigned int __thiscall ClientTradeSystem::Handle_Trade__Recv_CloseTrade(ClientTradeSystem*,unsigned int)</code>
    /// </summary>
    /// <param name="etype">Identifier for the type of trade closure event used by system notices.</param>
    /// <returns>Zero to indicate successful processing of the close trade event.</returns>
    public uint Handle_Trade__Recv_CloseTrade(uint etype) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientTradeSystem, uint, uint>)0x0056EBE0)(ref this, etype);

    /// <summary>Attempts to initiate a trade negotiation with the specified player, validating that the client is in peace mode and that a valid player ID is supplied.
    /// <code>Offset: 0x0056EC90
    /// bool __thiscall ClientTradeSystem::AttemptToOpenTradeNegotiations(ClientTradeSystem*,unsigned int)</code>
    /// </summary>
    /// <param name="i_iidPlayer">The identifier of the target player for the trade.</param>
    /// <returns>True if the trade negotiation was successfully started; otherwise false (e.g., if combat mode is active or the player ID is invalid).</returns>
    public byte AttemptToOpenTradeNegotiations(uint i_iidPlayer) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientTradeSystem, uint, byte>)0x0056EC90)(ref this, i_iidPlayer);

    /// <summary>Initiates an attempt to trade an object with another player, validating ownership and current trade state before proceeding.
    /// <code>Offset: 0x0056ED30
    /// void __thiscall ClientTradeSystem::AttemptToTradeItem(ClientTradeSystem*,unsigned int,unsigned int)</code>
    /// </summary>
    /// <param name="idPlayer">The identifier of the target player involved in the trade.</param>
    /// <param name="idObject">The identifier of the object being offered for trade.</param>
    public void AttemptToTradeItem(uint idPlayer, uint idObject) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientTradeSystem, uint, uint, void>)0x0056ED30)(ref this, idPlayer, idObject);

    /// <summary>Registers a trade request between two players, updates internal state, and notifies the partner. If an API plugin is available, releases resources for the partner and initiates any queued item trades.
    /// <code>Offset: 0x0056EE00
    /// unsigned int __thiscall ClientTradeSystem::Handle_Trade__Recv_RegisterTrade(ClientTradeSystem*,unsigned int,unsigned int,long double)</code>
    /// </summary>
    /// <param name="initiator">Player ID of the trade initiator.</param>
    /// <param name="partner">Player ID of the trade partner.</param>
    /// <param name="stamp">Timestamp marking when the trade request was received.</param>
    /// <returns>Zero, indicating successful handling of the trade registration request.</returns>
    public uint Handle_Trade__Recv_RegisterTrade(uint initiator, uint partner, double stamp) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientTradeSystem, uint, uint, double, uint>)0x0056EE00)(ref this, initiator, partner, stamp);

    /// <summary>Adds an item identified by itemID to the partner’s trade interface at the specified position, handling reference counts and cleanup.
    /// <code>Offset: 0x0056EEB0
    /// bool __thiscall ClientTradeSystem::AddPartnerItem(ClientTradeSystem*,unsigned int,unsigned int)</code>
    /// </summary>
    /// <param name="itemID">The unique identifier of the item to be added.</param>
    /// <param name="pos">The slot index within the partner’s trade window where the item should appear.</param>
    /// <returns>True if the item was successfully added; otherwise, false (e.g., if the item does not exist or cannot be added).</returns>
    public byte AddPartnerItem(uint itemID, uint pos) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientTradeSystem, uint, uint, byte>)0x0056EEB0)(ref this, itemID, pos);

    /// <summary>Adds an item to a trade session based on the specified role identifier, updates the trade state, broadcasts the addition, and forwards the request through an AC plugin if available.
    /// <code>Offset: 0x0056EF90
    /// unsigned int __thiscall ClientTradeSystem::Handle_Trade__Recv_AddToTrade(ClientTradeSystem*,unsigned int,unsigned int,unsigned int)</code>
    /// </summary>
    /// <param name="item">Identifier of the item to add to the trade.</param>
    /// <param name="id">Role flag: 1 for adding own items, 2 for partner's items.</param>
    /// <param name="loc">Location slot index where the item should be placed within the trade window.</param>
    /// <returns>Zero on completion; currently no error reporting is performed.</returns>
    public uint Handle_Trade__Recv_AddToTrade(uint item, uint id, uint loc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientTradeSystem, uint, uint, uint, uint>)0x0056EF90)(ref this, item, id, loc);

    /// <summary>Notifies the trade manager that the client’s current trade session is out of sync, triggering an accept‑trade event and clearing temporary partner and self trade lists to reset local state.
    /// <code>Offset: 0x0056EFF0
    /// void __thiscall ClientTradeSystem::NotifyServerThatTradeIsOutOfSync(ClientTradeSystem*)</code>
    /// </summary>
    public void NotifyServerThatTradeIsOutOfSync() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientTradeSystem, void>)0x0056EFF0)(ref this);
}

