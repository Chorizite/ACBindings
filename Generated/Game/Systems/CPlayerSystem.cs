namespace ACBindings.Internal;


/// <summary>
/// Handles all aspects of a player’s session, from authentication and character generation to in‑game state management, inventory handling, and network interaction.
/// </summary>
public unsafe struct CPlayerSystem : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.ClientSystem BaseClass_ClientSystem; // ACBindings.Internal.ClientSystem
    public ACBindings.Internal.IInputActionCallback BaseClass_IInputActionCallback; // ACBindings.Internal.IInputActionCallback
    public ACBindings.Internal.QualityChangeHandler BaseClass_QualityChangeHandler; // ACBindings.Internal.QualityChangeHandler
    public ACBindings.Internal.ObjectRangeHandler BaseClass_ObjectRangeHandler; // ACBindings.Internal.ObjectRangeHandler

    // Statics
    public static ACBindings.Internal.CPlayerSystem** s_pPlayerSystem = (ACBindings.Internal.CPlayerSystem**)0x0087119C;

    // Child Types
    public unsafe struct CPlayerSystem_vtbl
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
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CPlayerSystem*, ACBindings.Internal.CPlayerSystem.Enum15> You_Must_Not_Have_Multiple_Implementations_Of_AddRef_In_A_Hierarchy; // function pointer

        // Methods
    }
    // CPlayerSystem::Enum14
    public enum Enum14 : uint
    {
    }
    // CPlayerSystem::Enum15
    public enum Enum15 : uint
    {
    }
    // CPlayerSystem::Enum16
    public enum Enum16 : uint
    {
    }
    // CPlayerSystem::Enum5
    public enum Enum5 : uint
    {
    }
    // CPlayerSystem::Enum6
    public enum Enum6 : uint
    {
    }
    // CPlayerSystem::Enum7
    public enum Enum7 : uint
    {
    }
    // CPlayerSystem::Enum8
    public enum Enum8 : uint
    {
    }

    // Members
    public ACBindings.Internal.Turbine_RefCount m_cTurbineRefCount;
    public ACBindings.Internal.accountID account_;
    public ACBindings.Internal.ClientCharGenState* m_pCharGenState;
    public ACBindings.Internal.CPlayerModule playerModule;
    public uint playerID;
    public byte m_accountHasThroneofDestiny;
    public double logOnRequestTime;
    public double logOffRequestTime;
    public double logOffTime;
    public double deleteCharRequestTime;
    public byte fReadyToEnterGame;
    public byte awaitingLogOn;
    public byte sendLoginCompletePending;
    public byte initialLoginComplete;
    public byte allContainedObjectsReceived;
    public byte player_initialized;
    public byte player_desc_received;
    public double playerInitTime;
    public byte loggingOff;
    public byte logOffRequested;
    public byte connectionLost;
    public byte awaitingExpiration;
    public double expirationTime;
    public uint inventoryMask;
    public uint clothingPriorityMask;
    public byte teleportInProgress;
    public float m_fLoad;
    public byte m_layoutFromFile;
    public uint lastFullyMergedSrcID;
    public uint lastFullyMergedDstID;
    public ACBindings.Internal.CInvSlotModule m_invSlotModule;
    public uint blockingID;
    public uint blockedID;
    public uint blockingDestID;
    public uint blockedSpellTargetID;
    public uint blockedSpellID;
    public ACBindings.Internal.UI_SLOT_SIDE blockedSide;
    public int unblockAttemptNum;
    public uint mOpenContainerID;
    public ACBindings.Internal.NIList__uint pending_components_list;
    public ACBindings.Internal.ComponentTracker* componentTracker;
    public ACBindings.Internal.List___ObjectRangeInfo m_objectRangeCheckList;
    public ACBindings.Internal.CContractTrackerTable m_contractTrackerTable;

    // Generated Constructor
    public CPlayerSystem() {
        _ConstructorInternal();
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>Resets the player system state, clearing identifiers, flags, timers, and related data to prepare for a new login or session.
    /// <code>Offset: 0x0055E130
    /// void __thiscall CPlayerSystem::Begin(CPlayerSystem*)</code>
    /// </summary>
    public void Begin() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPlayerSystem, void>)0x0055E130)(ref this);

    /// <summary>Returns a pointer to the global CPlayerSystem instance used by the client.
    /// <code>Offset: 0x0055E1D0
    /// CPlayerSystem* __cdecl CPlayerSystem::GetPlayerSystem()</code>
    /// </summary>
    /// <returns>A pointer to the current CPlayerSystem object, or nullptr if it has not been created yet.</returns>
    public static ACBindings.Internal.CPlayerSystem* GetPlayerSystem() => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.CPlayerSystem*>)0x0055E1D0)();

    /// <summary>Provides access to the player’s character generation state, constructing it lazily when first requested.
    /// <code>Offset: 0x0055E1E0
    /// ClientCharGenState* __thiscall CPlayerSystem::GetCharGenState(CPlayerSystem*)</code>
    /// </summary>
    /// <returns>A pointer to the ClientCharGenState instance, or null if memory allocation failed.</returns>
    public ACBindings.Internal.ClientCharGenState* GetCharGenState() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPlayerSystem, ACBindings.Internal.ClientCharGenState*>)0x0055E1E0)(ref this);

    /// <summary>
    /// Retrieves the ComponentTracker for this player system, creating and initializing it on first request.
    /// 
    /// <code>Offset: 0x0055E220
    /// ComponentTracker* __thiscall CPlayerSystem::GetComponentTracker(CPlayerSystem*)</code>
    /// </summary>
    /// <returns>Pointer to the ComponentTracker instance; null if allocation fails.</returns>
    public ACBindings.Internal.ComponentTracker* GetComponentTracker() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPlayerSystem, ACBindings.Internal.ComponentTracker*>)0x0055E220)(ref this);

    /// <summary>Handles a server notice indicating a new parent container for an object, updating the internal unblock attempt number when the container belongs to the current player.
    /// <code>Offset: 0x0055E270
    /// void __thiscall CPlayerSystem::RecvNotice_NewParentContainer(CPlayerSystem*,unsigned int)</code>
    /// </summary>
    /// <param name="i_newContainerID">The identifier of the newly assigned parent container.</param>
    public void RecvNotice_NewParentContainer(uint i_newContainerID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPlayerSystem, uint, void>)0x0055E270)(ref this, i_newContainerID);

    /// <summary>Updates the player system’s teleport status, setting the internal flag and adjusting the UI busy counter to match.
    /// <code>Offset: 0x0055E2A0
    /// void __thiscall CPlayerSystem::SetTeleportInProgress(CPlayerSystem*,bool)</code>
    /// </summary>
    /// <param name="bInProgress">Indicates whether a teleport operation is currently in progress.</param>
    public void SetTeleportInProgress(byte bInProgress) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPlayerSystem, byte, void>)0x0055E2A0)(ref this, bInProgress);

    /// <summary>Handles a character error by resetting login state and notifying the client.
    /// <code>Offset: 0x0055E2F0
    /// void __thiscall CPlayerSystem::Handle_CharacterError(CPlayerSystem*,charError)</code>
    /// </summary>
    /// <param name="error">The error code indicating the nature of the character issue.</param>
    public void Handle_CharacterError(ACBindings.Internal.charError error) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPlayerSystem, ACBindings.Internal.charError, void>)0x0055E2F0)(ref this, error);

    /// <summary>Handles a character deletion request by ensuring a character generation state exists, clearing the identity of the current character in the UI flow, resetting the delete request timer, and notifying the system of the updated character set.
    /// <code>Offset: 0x0055E310
    /// void __thiscall CPlayerSystem::Handle_CharacterDelete(CPlayerSystem*)</code>
    /// </summary>
    public void Handle_CharacterDelete() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPlayerSystem, void>)0x0055E310)(ref this);

    /// <summary>Notifies the player of an imminent subscription expiration by sending a formatted warning notice and records the expiration time in the system.
    /// <code>Offset: 0x0055E380
    /// void __thiscall CPlayerSystem::Handle_AwaitingSubscriptionExpiration(CPlayerSystem*,unsigned int)</code>
    /// </summary>
    /// <param name="secondsRemaining">The number of seconds left before the subscription expires.</param>
    public void Handle_AwaitingSubscriptionExpiration(uint secondsRemaining) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPlayerSystem, uint, void>)0x0055E380)(ref this, secondsRemaining);

    /// <summary>Indicates whether the player’s account owns the Throne of Destiny.
    /// <code>Offset: 0x0055E470
    /// bool __thiscall CPlayerSystem::AccountHasThroneOfDestiny(CPlayerSystem*)</code>
    /// </summary>
    /// <returns>true when the account possesses the Throne of Destiny; otherwise, false.</returns>
    public byte AccountHasThroneOfDestiny() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPlayerSystem, byte>)0x0055E470)(ref this);

    /// <summary>Restores a character specified by avatar ID through an administrative request.
    /// <code>Offset: 0x0055E480
    /// void __thiscall CPlayerSystem::RestoreCharacter(CPlayerSystem*,unsigned int)</code>
    /// </summary>
    /// <param name="i_iidAvatar">The unique identifier of the character to be restored.</param>
    public void RestoreCharacter(uint i_iidAvatar) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPlayerSystem, uint, void>)0x0055E480)(ref this, i_iidAvatar);

    /// <summary>Logs the player out of the current session by resetting login status, clearing player identifiers, and disconnecting from the game world.
    /// <code>Offset: 0x0055E4A0
    /// void __thiscall CPlayerSystem::ExecuteLogOff(CPlayerSystem*)</code>
    /// </summary>
    public void ExecuteLogOff() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPlayerSystem, void>)0x0055E4A0)(ref this);

    /// <summary>Marks the beginning of a player log‑off sequence by clearing the pending log‑off request flag.
    /// <code>Offset: 0x0055E4F0
    /// void __thiscall CPlayerSystem::SetLogOffStarted(CPlayerSystem*)</code>
    /// </summary>
    public void SetLogOffStarted() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPlayerSystem, void>)0x0055E4F0)(ref this);

    /// <summary>Determines whether entity A is farther than entity B, using distance and identifier as a tie‑breaker.
    /// <code>Offset: 0x0055E550
    /// bool __thiscall CPlayerSystem::Farther(CPlayerSystem*,long double,unsigned int,long double,unsigned int)</code>
    /// </summary>
    /// <param name="dist_a">Distance of the first entity.</param>
    /// <param name="id_a">Identifier of the first entity used when distances are equal.</param>
    /// <param name="dist_b">Distance of the second entity.</param>
    /// <param name="id_b">Identifier of the second entity used when distances are equal.</param>
    /// <returns>True if A is farther than B, or they are equidistant but A's identifier exceeds B's; otherwise false.</returns>
    public byte Farther(double dist_a, uint id_a, double dist_b, uint id_b) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPlayerSystem, double, uint, double, uint, byte>)0x0055E550)(ref this, dist_a, id_a, dist_b, id_b);

    /// <summary>Provides the current radar radius based on whether the player is outdoors or indoors.
    /// <code>Offset: 0x0055E5A0
    /// float __thiscall CPlayerSystem::GetRadarRadius(CPlayerSystem*)</code>
    /// </summary>
    /// <returns>The radar radius (75.0 when outside, 25.0 otherwise).</returns>
    public float GetRadarRadius() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPlayerSystem, float>)0x0055E5A0)(ref this);

    /// <summary>Checks whether the current player instance is positioned outside the playable region.
    /// <code>Offset: 0x0055E5C0
    /// bool __thiscall CPlayerSystem::IsOutside(CPlayerSystem*)</code>
    /// </summary>
    /// <returns>True when the player is located outside the defined zone; otherwise false.</returns>
    public byte IsOutside() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPlayerSystem, byte>)0x0055E5C0)(ref this);

    /// <summary>Attempts to transfer an item identified by its ID into the player’s inventory, either into a main pack or the currently open container. The operation succeeds only if the item can be placed in the target location.
    /// <code>Offset: 0x0055E5E0
    /// bool __thiscall CPlayerSystem::PlaceInBackpack(CPlayerSystem*,unsigned int,bool)</code>
    /// </summary>
    /// <param name="i_iidItem">The unique identifier of the item to place.</param>
    /// <param name="bPlaceInMainPack">If true, attempts placement directly into the player’s main pack; otherwise uses the currently open container.</param>
    /// <returns>True if the item was successfully placed in the inventory; otherwise false.</returns>
    public byte PlaceInBackpack(uint i_iidItem, byte bPlaceInMainPack) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPlayerSystem, uint, byte, byte>)0x0055E5E0)(ref this, i_iidItem, bPlaceInMainPack);

    /// <summary>Resets the player's blocking state by clearing blocking and blocked identifiers, side, and attempt counter.
    /// <code>Offset: 0x0055E660
    /// void __thiscall CPlayerSystem::ResetUnblocking(CPlayerSystem*)</code>
    /// </summary>
    public void ResetUnblocking() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPlayerSystem, void>)0x0055E660)(ref this);

    /// <summary>Registers input maps for the player system and associated components with the global input manager.
    /// <code>Offset: 0x0055EAA0
    /// void __thiscall CPlayerSystem::RegisterInputMaps(CPlayerSystem*)</code>
    /// </summary>
    public void RegisterInputMaps() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPlayerSystem, void>)0x0055EAA0)(ref this);

    /// <summary>Assigns a contract tracker to be displayed and informs the social subsystem of the change.
    /// <code>Offset: 0x0055EB30
    /// void __thiscall CPlayerSystem::SetDisplayContractTracker(CPlayerSystem*,CContractTracker)</code>
    /// </summary>
    /// <param name="contractTracker">The contract tracker containing the details to present on screen.</param>
    public void SetDisplayContractTracker(ACBindings.Internal.CContractTracker contractTracker) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPlayerSystem, ACBindings.Internal.CContractTracker, void>)0x0055EB30)(ref this, contractTracker);

    /// <summary>Increments the object’s Turbine reference counter atomically and returns the new count.
    /// <code>Offset: 0x0055F0D0
    /// unsigned int __thiscall CPlayerSystem::AddRef(CPlayerSystem*)</code>
    /// </summary>
    /// <returns>The updated reference count after the increment operation.</returns>
    public uint AddRef() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPlayerSystem, uint>)0x0055F0D0)(ref this);

    /// <summary>Retrieves an interface pointer from a CPlayerSystem instance based on a GUID, storing the status in a TResult object and optionally returning the interface via an output parameter.
    /// <code>Offset: 0x0055F0E0
    /// TResult* __thiscall CPlayerSystem::QueryInterface(CPlayerSystem*,TResult*,const Turbine_GUID*,void**)</code>
    /// </summary>
    /// <param name="result">Receives the query status; m_val is set to 0 on success or an error code if the interface is not available.</param>
    /// <param name="i_rcInterface">GUID identifying the desired interface.</param>
    /// <param name="o_ppvInterface">If non‑null, receives a pointer to the requested interface instance.</param>
    /// <returns>Returns the TResult object passed in result for chaining or further inspection.</returns>
    public ACBindings.Internal.TResult* QueryInterface(ACBindings.Internal.TResult* result, ACBindings.Internal.Turbine_GUID* i_rcInterface, void** o_ppvInterface) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPlayerSystem, ACBindings.Internal.TResult*, ACBindings.Internal.Turbine_GUID*, void**, ACBindings.Internal.TResult*>)0x0055F0E0)(ref this, result, i_rcInterface, o_ppvInterface);

    /// <summary>Resets blocking state when the server reports that an attempted action involving the specified item failed.
    /// <code>Offset: 0x0055F1B0
    /// void __thiscall CPlayerSystem::RecvNotice_ServerSaysAttemptFailed(CPlayerSystem*,unsigned int)</code>
    /// </summary>
    /// <param name="itemID">The identifier of the item whose blocking attempt has been canceled by the server.</param>
    public void RecvNotice_ServerSaysAttemptFailed(uint itemID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPlayerSystem, uint, void>)0x0055F1B0)(ref this, itemID);

    /// <summary>Processes a character generation verification response from the server, updating local character state based on the returned status code and notifying other components accordingly.
    /// <code>Offset: 0x0055F620
    /// void __thiscall CPlayerSystem::Handle_CharGenVerificationResponse(CPlayerSystem*,void*,unsigned int)</code>
    /// </summary>
    /// <param name="buff">Pointer to the raw message buffer received from the server.</param>
    /// <param name="size">Number of bytes contained in the buffer.</param>
    public void Handle_CharGenVerificationResponse(System.IntPtr buff, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPlayerSystem, System.IntPtr, uint, void>)0x0055F620)(ref this, buff, size);

    /// <summary>Updates a player's spell component by adding it to the active tracker and optionally sending a UI update; if the player is not yet initialized, queues the component for later processing.
    /// <code>Offset: 0x0055F870
    /// ComponentTrackerUpdate __thiscall CPlayerSystem::UpdateSpellComponent(CPlayerSystem*,ACCWeenieObject*,int)</code>
    /// </summary>
    /// <param name="weenObj">The component object whose data should be updated.</param>
    /// <param name="updateUI">When true, triggers an in‑game notice so the client UI refreshes.</param>
    public ACBindings.Internal.ComponentTrackerUpdate UpdateSpellComponent(ACBindings.Internal.ACCWeenieObject* weenObj, int updateUI) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPlayerSystem, ACBindings.Internal.ACCWeenieObject*, int, ACBindings.Internal.ComponentTrackerUpdate>)0x0055F870)(ref this, weenObj, updateUI);

    /// <summary>Removes an object range handler association for the specified object ID from the player system.
    /// <code>Offset: 0x0055F900
    /// void __thiscall CPlayerSystem::UnregisterObjectRangeHandler(CPlayerSystem*,ObjectRangeHandler*,unsigned int)</code>
    /// </summary>
    /// <param name="handler">The ObjectRangeHandler to unregister.</param>
    /// <param name="objectID">Identifier of the object whose handler should be removed.</param>
    public void UnregisterObjectRangeHandler(ACBindings.Internal.ObjectRangeHandler* handler, uint objectID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPlayerSystem, ACBindings.Internal.ObjectRangeHandler*, uint, void>)0x0055F900)(ref this, handler, objectID);

    /// <summary>Unregisters the specified object range handler from all registered range checks within the player system.
    /// <code>Offset: 0x0055F930
    /// void __thiscall CPlayerSystem::UnregisterAllObjectRangeHandlers(CPlayerSystem*,ObjectRangeHandler*)</code>
    /// </summary>
    /// <param name="handler">The ObjectRangeHandler instance to remove.</param>
    public void UnregisterAllObjectRangeHandlers(ACBindings.Internal.ObjectRangeHandler* handler) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPlayerSystem, ACBindings.Internal.ObjectRangeHandler*, void>)0x0055F930)(ref this, handler);

    /// <summary>Deinitializes the player system during shutdown, clearing the global instance reference, unregistering the player module interface from the system, and releasing any held references.
    /// <code>Offset: 0x0055FA60
    /// void __thiscall CPlayerSystem::OnShutdown(CPlayerSystem*)</code>
    /// </summary>
    public void OnShutdown() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPlayerSystem, void>)0x0055FA60)(ref this);

    /// <summary>Checks whether an item can be auto‑wielded by the player, considering inventory state, combat mode, and compatibility with currently equipped gear.
    /// <code>Offset: 0x0055FAD0
    /// bool __thiscall CPlayerSystem::AutoWieldIsLegal(CPlayerSystem*,unsigned int,int)</code>
    /// </summary>
    /// <param name="item">The identifier of the item to test for legality.</param>
    /// <param name="quiet">When non‑zero, suppresses any UI notice that would normally explain why the action is illegal.</param>
    /// <returns>True if the item may be auto‑wielded; otherwise false.</returns>
    public byte AutoWieldIsLegal(uint item, int quiet) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPlayerSystem, uint, int, byte>)0x0055FAD0)(ref this, item, quiet);

    /// <summary>Determines whether a specified item can be automatically equipped by the player, taking into account clothing priority, current wear status, inventory conflicts, and optional UI suppression.
    /// <code>Offset: 0x0055FCB0
    /// bool __thiscall CPlayerSystem::AutoWearIsLegal(CPlayerSystem*,unsigned int,int*,int)</code>
    /// </summary>
    /// <param name="item">The object ID of the item to evaluate for auto‑wear.</param>
    /// <param name="blockedBySelf">Output flag set to 1 if the player is already wearing the item; otherwise 0.</param>
    /// <param name="quiet">When non‑zero, suppresses user notification messages that would normally be sent if auto‑wear is not allowed.</param>
    /// <returns>True if the item can be auto‑worn under current conditions; false if it is blocked or already worn by the player (or other constraints prevent wearing).</returns>
    public byte AutoWearIsLegal(uint item, int* blockedBySelf, int quiet) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPlayerSystem, uint, int*, int, byte>)0x0055FCB0)(ref this, item, blockedBySelf, quiet);

    /// <summary>Replaces the player’s contract tracker table with a fresh copy of the supplied table, clearing any previous entries and propagating the change through the social system.
    /// <code>Offset: 0x0055FE30
    /// void __thiscall CPlayerSystem::UpdateContractTrackerTable(CPlayerSystem*,const CContractTrackerTable*)</code>
    /// </summary>
    /// <param name="contractTrackerTable">The new contract tracker table whose contents will replace the current table for this player.</param>
    public void UpdateContractTrackerTable(ACBindings.Internal.CContractTrackerTable* contractTrackerTable) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPlayerSystem, ACBindings.Internal.CContractTrackerTable*, void>)0x0055FE30)(ref this, contractTrackerTable);

    /// <summary>Updates the player's contract tracker table by adding, updating, or removing a contract entry based on the supplied data. If deleteContract is non‑zero, the contract is removed; otherwise it is inserted or updated. After modifying the table, a notice is broadcast to the social system.
    /// <code>Offset: 0x0055FF00
    /// void __thiscall CPlayerSystem::UpdateContractTracker(CPlayerSystem*,CContractTracker,int)</code>
    /// </summary>
    /// <param name="contractTracker">The contract information (ID, stage, times) used for adding or updating the tracker entry.</param>
    /// <param name="deleteContract">Non‑zero indicates that the specified contract should be removed from the tracker; zero causes the contract to be inserted or updated.</param>
    public void UpdateContractTracker(ACBindings.Internal.CContractTracker contractTracker, int deleteContract) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPlayerSystem, ACBindings.Internal.CContractTracker, int, void>)0x0055FF00)(ref this, contractTracker, deleteContract);

    /// <summary>Processes the player’s object range list, invoking callbacks when objects enter or leave range and removing expired entries.
    /// <code>Offset: 0x005600D0
    /// void __thiscall CPlayerSystem::CalculateObjectRangeChecks(CPlayerSystem*)</code>
    /// </summary>
    public void CalculateObjectRangeChecks() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPlayerSystem, void>)0x005600D0)(ref this);

    /// <summary>Processes a notice that an item's attributes have changed, updating spell components when appropriate.
    /// <code>Offset: 0x005601D0
    /// void __thiscall CPlayerSystem::RecvNotice_ItemAttributesChanged(CPlayerSystem*,unsigned int,unsigned int)</code>
    /// </summary>
    /// <param name="i_target">Identifier of the item whose attributes changed.</param>
    /// <param name="i_attrib">Index of the attribute that changed (currently unused).</param>
    public void RecvNotice_ItemAttributesChanged(uint i_target, uint i_attrib) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPlayerSystem, uint, uint, void>)0x005601D0)(ref this, i_target, i_attrib);

    /// <summary>Updates the player's load value, sends a load change notice to the character system, and displays an encumbrance warning when the load crosses defined thresholds.
    /// <code>Offset: 0x00560280
    /// bool __thiscall CPlayerSystem::OnLoadChanged(CPlayerSystem*)</code>
    /// </summary>
    /// <returns>True on successful update; false if the player descriptor cannot be obtained or the load query fails.</returns>
    public byte OnLoadChanged() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPlayerSystem, byte>)0x00560280)(ref this);

    /// <summary>Parses a CharacterSet structure from the supplied buffer, updates the player system’s account information—including expansion flags and account name—initializes Turbine chat if enabled, and sends a notice to the client with the received character set.
    /// <code>Offset: 0x00560440
    /// void __thiscall CPlayerSystem::Handle_Login__CharacterSet(CPlayerSystem*,void*,unsigned int)</code>
    /// </summary>
    /// <param name="buff">Buffer containing serialized character set data.</param>
    /// <param name="size">Size of the buffer in bytes.</param>
    public void Handle_Login__CharacterSet(System.IntPtr buff, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPlayerSystem, System.IntPtr, uint, void>)0x00560440)(ref this, buff, size);

    /// <summary>Deletes the specified character belonging to the player’s account by sending a server request and records the deletion request time.
    /// <code>Offset: 0x005605A0
    /// void __thiscall CPlayerSystem::DeleteCharacter(CPlayerSystem*,unsigned int)</code>
    /// </summary>
    /// <param name="i_iidAvatar">The unique identifier of the character (avatar) to be deleted.</param>
    public void DeleteCharacter(uint i_iidAvatar) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPlayerSystem, uint, void>)0x005605A0)(ref this, i_iidAvatar);

    /// <summary>Logs a character into the game world, initializing systems and issuing an enter‑world request.
    /// <code>Offset: 0x00560600
    /// bool __thiscall CPlayerSystem::LogOnCharacter(CPlayerSystem*,unsigned int)</code>
    /// </summary>
    /// <param name="i_iidAvatar">Identifier of the avatar to log on.</param>
    /// <returns>True if the login was successfully initiated; otherwise false.</returns>
    public byte LogOnCharacter(uint i_iidAvatar) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPlayerSystem, uint, byte>)0x00560600)(ref this, i_iidAvatar);

    /// <summary>Selects the next game object of a specified type relative to the current selection, optionally preferring closer or farther targets and applying distance weighting based on the extreme flag. Updates the player's selected object ID accordingly.
    /// <code>Offset: 0x00560710
    /// void __thiscall CPlayerSystem::SelectNext(CPlayerSystem*,bool,bool,UI_SELECTION_TYPE,bool)</code>
    /// </summary>
    /// <param name="closer">True to choose the nearest qualifying object; false selects the farthest.</param>
    /// <param name="extreme">If true uses a weighted distance calculation that emphasizes height differences.</param>
    /// <param name="sel_type">The UI_SELECTION_TYPE specifying which categories of objects are considered (e.g., items, monsters, players).</param>
    /// <param name="ignore_wielded">When true skips objects currently wielded or owned by the player.</param>
    public void SelectNext(byte closer, byte extreme, ACBindings.Internal.UI_SELECTION_TYPE sel_type, byte ignore_wielded) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPlayerSystem, byte, byte, ACBindings.Internal.UI_SELECTION_TYPE, byte, void>)0x00560710)(ref this, closer, extreme, sel_type, ignore_wielded);

    /// <summary>Determines whether an object identified by its ID lies within the player's radar detection radius, based on the object's location and zone context.
    /// <code>Offset: 0x00560CE0
    /// bool __thiscall CPlayerSystem::ObjectIsWithinRadarRange(CPlayerSystem*,unsigned int)</code>
    /// </summary>
    /// <param name="objectID">The identifier of the target game object to evaluate.</param>
    /// <returns>True when the object is inside the radar range; otherwise false.</returns>
    public byte ObjectIsWithinRadarRange(uint objectID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPlayerSystem, uint, byte>)0x00560CE0)(ref this, objectID);

    /// <summary>Queries the player's current world coordinates, writing them into the supplied output parameters.
    /// <code>Offset: 0x00560E00
    /// bool __thiscall CPlayerSystem::InqPlayerCoords(CPlayerSystem*,long double*,long double*)</code>
    /// </summary>
    /// <param name="x">Pointer to a long double where the X coordinate will be stored if the query succeeds.</param>
    /// <param name="y">Pointer to a long double where the Y coordinate will be stored if the query succeeds.</param>
    /// <returns>True when the player's coordinates are successfully retrieved; otherwise false.</returns>
    public byte InqPlayerCoords(double* x, double* y) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPlayerSystem, double*, double*, byte>)0x00560E00)(ref this, x, y);

    /// <summary>Attempts to automatically equip the specified item for the player if it satisfies all legality checks, invoking a wield action when possible.
    /// <code>Offset: 0x00560F30
    /// bool __thiscall CPlayerSystem::AutoWear(CPlayerSystem*,unsigned int,int*,int)</code>
    /// </summary>
    /// <param name="item">The identifier of the item to be auto‑worn.</param>
    /// <param name="blockedBySelf">Pointer to an integer that receives a code indicating why auto‑wear was blocked; zero means no block.</param>
    /// <param name="quiet">Suppresses UI or notification output when true.</param>
    /// <returns>True if the item passed legality checks and the wield attempt was initiated; otherwise false.</returns>
    public byte AutoWear(uint item, int* blockedBySelf, int quiet) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPlayerSystem, uint, int*, int, byte>)0x00560F30)(ref this, item, blockedBySelf, quiet);

    /// <summary>Checks whether the current player character is an Olthoi type.
    /// <code>Offset: 0x00560F80
    /// int __cdecl CPlayerSystem::IsOlthoi()</code>
    /// </summary>
    /// <returns>Non‑zero (1) if the player is an Olthoi, otherwise zero.</returns>
    public static int IsOlthoi() => ((delegate* unmanaged[Cdecl]<int>)0x00560F80)();

    /// <summary>Registers an ObjectRangeHandler for a specific object with the provided range and behavior settings, updating any existing registrations for the same handler and object ID and adding a new monitoring entry.
    /// <code>Offset: 0x00561040
    /// void __thiscall CPlayerSystem::RegisterObjectRangeHandler(CPlayerSystem*,ObjectRangeHandler*,unsigned int,long double,bool,bool,long double,long double)</code>
    /// </summary>
    /// <param name="handler">The handler to be notified when the monitored object enters or exits the specified range.</param>
    /// <param name="objectID">Identifier of the object whose proximity is being tracked.</param>
    /// <param name="range">Maximum distance at which range events are triggered.</param>
    /// <param name="useRadii">If true, uses radii for spherical calculations; otherwise flat distance is used.</param>
    /// <param name="ignoreZDelta">If true, ignores vertical differences when determining distance.</param>
    /// <param name="timeInterval">How often (in seconds) the range check should be performed.</param>
    /// <param name="timeOut">Maximum time (in seconds) after which the registration will expire automatically.</param>
    public void RegisterObjectRangeHandler(ACBindings.Internal.ObjectRangeHandler* handler, uint objectID, double range, byte useRadii, byte ignoreZDelta, double timeInterval, double timeOut) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPlayerSystem, ACBindings.Internal.ObjectRangeHandler*, uint, double, byte, byte, double, double, void>)0x00561040)(ref this, handler, objectID, range, useRadii, ignoreZDelta, timeInterval, timeOut);

    /// <summary>Initializes a new player system instance by setting up base interfaces, reference counts, account data, modules, inventory slots, contract tracking, and registering necessary event handlers for quality changes and notices.
    /// <code>Offset: 0x005611E0
    /// void __thiscall CPlayerSystem::CPlayerSystem(CPlayerSystem*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPlayerSystem, void>)0x005611E0)(ref this);

    /// <summary>Decrements the reference counter for the player system and destroys its input action callback base when no references remain.
    /// <code>Offset: 0x00561400
    /// unsigned int __thiscall CPlayerSystem::Release(CPlayerSystem*)</code>
    /// </summary>
    /// <returns>The number of active references after decrementing; zero indicates the object has been cleaned up.</returns>
    public uint Release() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPlayerSystem, uint>)0x00561400)(ref this);

    /// <summary>Terminates the player system by clearing pending components, resetting modules, destroying component trackers, and emptying contract tracker data structures to prepare for shutdown or reuse.
    /// <code>Offset: 0x00561430
    /// void __thiscall CPlayerSystem::End(CPlayerSystem*)</code>
    /// </summary>
    public void End() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPlayerSystem, void>)0x00561430)(ref this);

    /// <summary>Handles a notice indicating the player's currently selected item has changed; updates range monitoring and UI state accordingly.
    /// <code>Offset: 0x00561490
    /// void __thiscall CPlayerSystem::RecvNotice_SetSelectedItem(CPlayerSystem*,unsigned int,unsigned int)</code>
    /// </summary>
    /// <param name="oldSelectedID">Identifier of the previously selected object.</param>
    /// <param name="selectedID">Identifier of the newly selected object.</param>
    public void RecvNotice_SetSelectedItem(uint oldSelectedID, uint selectedID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPlayerSystem, uint, uint, void>)0x00561490)(ref this, oldSelectedID, selectedID);

    /// <summary>Handles a notification that the player’s enchantments have changed, invoking a load‑state refresh to keep the system synchronized with the new attributes.
    /// <code>Offset: 0x005615D0
    /// void __thiscall CPlayerSystem::RecvNotice_EnchantmentsChanged(CPlayerSystem*)</code>
    /// </summary>
    public void RecvNotice_EnchantmentsChanged() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPlayerSystem, void>)0x005615D0)(ref this);

    /// <summary>Handles exit of a selected object from the player’s range. If the object remains in view, re‑registers a handler with a distance based on whether the player is inside or outside the smartbox; otherwise clears the selection.
    /// <code>Offset: 0x005615E0
    /// void __thiscall CPlayerSystem::OnObjectRangeExit(CPlayerSystem*,unsigned int)</code>
    /// </summary>
    /// <param name="objectID">Identifier of the object that has exited the range.</param>
    public void OnObjectRangeExit(uint objectID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPlayerSystem, uint, void>)0x005615E0)(ref this, objectID);

    /// <summary>Handles removal of a quality from an object and triggers any necessary load state updates.
    /// <code>Offset: 0x00561660
    /// void __thiscall CPlayerSystem::OnQualityRemoved(CPlayerSystem*,CWeenieObject*,StatType,unsigned int)</code>
    /// </summary>
    /// <param name="cwobj">The game object whose quality has been removed.</param>
    /// <param name="stype">The type of stat that was removed.</param>
    /// <param name="senum">An identifier for the specific quality instance being removed.</param>
    public void OnQualityRemoved(ACBindings.Internal.CWeenieObject* cwobj, ACBindings.Internal.StatType stype, uint senum) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPlayerSystem, ACBindings.Internal.CWeenieObject*, ACBindings.Internal.StatType, uint, void>)0x00561660)(ref this, cwobj, stype, senum);

    /// <summary>Requests the name of the active third‑party plugin via APIManager and reports it to the admin system. If the API is unavailable, returns a default message.
    /// <code>Offset: 0x00561670
    /// void __thiscall CPlayerSystem::SendQueryPluginData(CPlayerSystem*,unsigned int)</code>
    /// </summary>
    /// <param name="context">Identifier used when invoking Event_QueryPluginListResponse.</param>
    public void SendQueryPluginData(uint context) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPlayerSystem, uint, void>)0x00561670)(ref this, context);

    /// <summary>Attempts to automatically sort a specified inventory item by wearing it, optionally wielding it, or moving it into the backpack if applicable. Returns true on success; otherwise false.
    /// <code>Offset: 0x00561710
    /// bool __thiscall CPlayerSystem::AutoSort(CPlayerSystem*,unsigned int,int,int)</code>
    /// </summary>
    /// <param name="item">Identifier of the object to be sorted.</param>
    /// <param name="wield">When non‑zero, allows auto‑wielding after wear fails.</param>
    /// <param name="quiet">Suppresses in‑game messages during sorting.</param>
    /// <returns>True if the item was successfully worn, wielded, or placed into a backpack; otherwise false.</returns>
    public byte AutoSort(uint item, int wield, int quiet) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPlayerSystem, uint, int, int, byte>)0x00561710)(ref this, item, wield, quiet);

    /// <summary>Attempts to automatically equip the specified item for the player, handling slot compatibility, current equipment, and optional unwinding of blocking gear. If immediate wielding is impossible and autosortOnFail is enabled, the item may be sorted into inventory instead.
    /// <code>Offset: 0x005617D0
    /// bool __thiscall CPlayerSystem::AutoWield(CPlayerSystem*,unsigned int,UI_SLOT_SIDE,int,int,int,int)</code>
    /// </summary>
    /// <param name="item">The ID of the object to equip.</param>
    /// <param name="slotSide">Desired hand or side for ring/wrist items.</param>
    /// <param name="quiet">Suppresses UI notifications when non‑zero.</param>
    /// <param name="unblock">Allows automatic removal of blocking equipment if needed.</param>
    /// <param name="autosortOnFail">Attempts to auto‑sort the item into inventory when it cannot be wielded immediately.</param>
    /// <param name="trySecondChoiceSide">If set, tries an alternate wrist or ring side before giving up.</param>
    /// <returns>True if the item was successfully wielded (or moved to backpack); otherwise false.</returns>
    public byte AutoWield(uint item, ACBindings.Internal.UI_SLOT_SIDE slotSide, int quiet, int unblock, int autosortOnFail, int trySecondChoiceSide) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPlayerSystem, uint, ACBindings.Internal.UI_SLOT_SIDE, int, int, int, int, byte>)0x005617D0)(ref this, item, slotSide, quiet, unblock, autosortOnFail, trySecondChoiceSide);

    /// <summary>Processes a player action input event, routing it to the appropriate handler such as targeting, inventory manipulation or UI toggles.
    /// <code>Offset: 0x00562600
    /// bool __thiscall CPlayerSystem::OnAction(CPlayerSystem*,const InputEvent*)</code>
    /// </summary>
    /// <param name="this">The CPlayerSystem instance on which to process the action.</param>
    /// <param name="i_evt">Input event containing the action identifier and additional data.</param>
    /// <returns>True if the event was handled; otherwise false.</returns>
    public byte OnAction(ACBindings.Internal.InputEvent* i_evt) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPlayerSystem, ACBindings.Internal.InputEvent*, byte>)0x00562600)(ref this, i_evt);

    /// <summary>Terminates the current character session, unregisters input callbacks, releases any pending SmartBox references, and resets the player system by invoking End and Begin.
    /// <code>Offset: 0x00563610
    /// void __thiscall CPlayerSystem::OnEndCharacterSession(CPlayerSystem*)</code>
    /// </summary>
    public void OnEndCharacterSession() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPlayerSystem, void>)0x00563610)(ref this);

    /// <summary>Destroys a CPlayerSystem instance, releasing owned resources such as character generation state, contract trackers, component lists, inventory modules, and unregistering associated event handlers.
    /// <code>Offset: 0x00563660
    /// void __thiscall CPlayerSystem::~CPlayerSystem(CPlayerSystem*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPlayerSystem, void>)0x00563660)(ref this);

    /// <summary>Handles an account boot event by extracting the boot reason from the supplied data packet, composing a localized message, and displaying it through the UI flow system.
    /// <code>Offset: 0x00563810
    /// void __thiscall CPlayerSystem::Handle_AccountBooted(CPlayerSystem*,void*,unsigned int)</code>
    /// </summary>
    /// <param name="buff">Pointer to raw packet data containing the boot reason information.</param>
    /// <param name="size">Size of the data buffer in bytes.</param>
    public void Handle_AccountBooted(System.IntPtr buff, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPlayerSystem, System.IntPtr, uint, void>)0x00563810)(ref this, buff, size);

    /// <summary>Displays a ban notification to the player based on data received from the server, including ban expiry or permanent status.
    /// <code>Offset: 0x00563970
    /// void __thiscall CPlayerSystem::Handle_AccountBanned(CPlayerSystem*,void*,unsigned int)</code>
    /// </summary>
    /// <param name="buff">Pointer to a buffer containing the ban information packet.</param>
    /// <param name="size">Size of the buffer in bytes.</param>
    public void Handle_AccountBanned(System.IntPtr buff, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPlayerSystem, System.IntPtr, uint, void>)0x00563970)(ref this, buff, size);

    /// <summary>Logs out the active player, displaying a “Logging off…” message, invoking the UI logout routine, and setting internal state to schedule disconnection. If the character is linked to a persistent object, extends the log‑off delay by an additional 20 seconds.
    /// <code>Offset: 0x00563B70
    /// void __thiscall CPlayerSystem::RequestLogOff(CPlayerSystem*)</code>
    /// </summary>
    public void RequestLogOff() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPlayerSystem, void>)0x00563B70)(ref this);

    /// <summary>Completes the player’s login sequence by verifying that all required objects exist, then notifying subsystems and updating UI elements. If verification succeeds it triggers the login complete event, requests additional data from the API plugin, displays the inventory, broadcasts a global message, and clears the pending flag; otherwise it marks completion as pending until the objects are ready.
    /// <code>Offset: 0x00563C30
    /// void __thiscall CPlayerSystem::SendLoginCompleteNotification(CPlayerSystem*)</code>
    /// </summary>
    public void SendLoginCompleteNotification() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPlayerSystem, void>)0x00563C30)(ref this);

    /// <summary>Attempts to send a login‑complete notification once the player’s description and all contained objects are available. Marks the contained objects as received and triggers the notification if it was pending.
    /// <code>Offset: 0x00563CC0
    /// void __thiscall CPlayerSystem::AttemptSendLoginCompleteNotification(CPlayerSystem*)</code>
    /// </summary>
    public void AttemptSendLoginCompleteNotification() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPlayerSystem, void>)0x00563CC0)(ref this);

    /// <summary>Attempts to use an item identified by <paramref name="itemID"/>. The function determines the item's type and executes the appropriate action such as placing it in the backpack, wielding it, sorting inventory slots, initiating trade or salvage dialogs, opening a contained container, dropping it on the ground, or starting a game.
    /// <code>Offset: 0x00563D10
    /// bool __thiscall CPlayerSystem::UsingItem(CPlayerSystem*,unsigned int,int,int)</code>
    /// </summary>
    /// <param name="itemID">The unique identifier of the item to use.</param>
    /// <param name="useable">Useability flags for the item; currently unused by this implementation.</param>
    /// <param name="forceUse">If non‑zero, bypasses automatic use determination and forces an immediate attempt to use the item.</param>
    /// <returns>True if an action was successfully performed on the item; otherwise false.</returns>
    public byte UsingItem(uint itemID, int useable, int forceUse) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPlayerSystem, uint, int, int, byte>)0x00563D10)(ref this, itemID, useable, forceUse);

    /// <summary>Performs time‑based updates for the player system, handling login completion, connection monitoring, logout requests, subscription expiry, and object range calculations while delegating per‑frame work to the player module.
    /// <code>Offset: 0x00563EB0
    /// void __thiscall CPlayerSystem::UseTime(CPlayerSystem*)</code>
    /// </summary>
    public void UseTime() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPlayerSystem, void>)0x00563EB0)(ref this);

    /// <summary>Handles a server notice that an item has moved from one container or wielder to another, updating client inventory state, slot assignments, and related spell component lists.
    /// <code>Offset: 0x00564000
    /// void __thiscall CPlayerSystem::RecvNotice_ServerSaysMoveItem(CPlayerSystem*,unsigned int,unsigned int,unsigned int,unsigned int,unsigned int,int,unsigned int,unsigned int)</code>
    /// </summary>
    /// <param name="itemID">The unique identifier of the item being moved.</param>
    /// <param name="oldContainer">The ID of the container the item was previously in.</param>
    /// <param name="oldWielder">The ID of the entity that had previously wielded the item.</param>
    /// <param name="oldLocation">The previous location identifier of the item (e.g., ground, inventory).</param>
    /// <param name="newContainer">The ID of the container into which the item is being moved.</param>
    /// <param name="place">The index or position within the new container where the item should be placed.</param>
    /// <param name="newWielder">The ID of the entity that will wield the item after the move.</param>
    /// <param name="newLocation">The destination location identifier for the item (e.g., ground, inventory).</param>
    public void RecvNotice_ServerSaysMoveItem(uint itemID, uint oldContainer, uint oldWielder, uint oldLocation, uint newContainer, int place, uint newWielder, uint newLocation) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPlayerSystem, uint, uint, uint, uint, uint, int, uint, uint, void>)0x00564000)(ref this, itemID, oldContainer, oldWielder, oldLocation, newContainer, place, newWielder, newLocation);

    /// <summary>Persists player data to the server and initiates a logout sequence based on the immediate flag, handling queued or delayed logoffs.
    /// <code>Offset: 0x005642C0
    /// void __thiscall CPlayerSystem::LogOffCharacter(CPlayerSystem*,bool)</code>
    /// </summary>
    /// <param name="immediate">If true, performs an immediate logoff; otherwise, queues or starts a delayed logoff depending on prior requests.</param>
    public void LogOffCharacter(byte immediate) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPlayerSystem, byte, void>)0x005642C0)(ref this, immediate);

    /// <summary>Initializes the player system state when first activated. Sets timestamps, assigns a unique player ID from the smartbox, processes any pending component updates, and triggers related notifications such as spell component updates, login completion, and house events.
    /// <code>Offset: 0x00564310
    /// void __thiscall CPlayerSystem::InitializePlayer(CPlayerSystem*)</code>
    /// </summary>
    public void InitializePlayer() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPlayerSystem, void>)0x00564310)(ref this);

    /// <summary>Processes a packed player description buffer, unpacking core player data, content profiles and inventory placement, initializing or updating the player state, and notifying relevant subsystems of the new information.
    /// <code>Offset: 0x00564440
    /// void __thiscall CPlayerSystem::Handle_PlayerDescription(CPlayerSystem*,void*,unsigned int)</code>
    /// </summary>
    /// <param name="buff">Pointer to the packed player description data received from the server.</param>
    /// <param name="size">Length in bytes of the data buffer.</param>
    public void Handle_PlayerDescription(System.IntPtr buff, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPlayerSystem, System.IntPtr, uint, void>)0x00564440)(ref this, buff, size);
}

