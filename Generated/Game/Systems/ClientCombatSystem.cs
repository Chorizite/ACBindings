namespace ACBindings.Internal;


/// <summary>
///   ClientCombatSystem orchestrates combat mechanics for a player client, managing mode transitions, target selection, power bar progress, and attack execution while handling jump logic.
/// </summary>
public unsafe struct ClientCombatSystem : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.ClientSystem BaseClass_ClientSystem; // ACBindings.Internal.ClientSystem
    public ACBindings.Internal.IInputActionCallback BaseClass_IInputActionCallback; // ACBindings.Internal.IInputActionCallback
    public ACBindings.Internal.QualityChangeHandler BaseClass_QualityChangeHandler; // ACBindings.Internal.QualityChangeHandler

    // Statics
    public static ACBindings.Internal.ClientCombatSystem** s_pCombatSystem = (ACBindings.Internal.ClientCombatSystem**)0x0087166C;

    // Child Types
    public unsafe struct ClientCombatSystem_vtbl
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
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ClientCombatSystem*, ACBindings.Internal.ClientCombatSystem.Enum9> You_Must_Not_Have_Multiple_Implementations_Of_AddRef_In_A_Hierarchy; // function pointer

        // Methods
    }
    // ClientCombatSystem::Enum10
    public enum Enum10 : uint
    {
    }
    // ClientCombatSystem::Enum11
    public enum Enum11 : uint
    {
    }
    // ClientCombatSystem::Enum12
    public enum Enum12 : uint
    {
    }
    // ClientCombatSystem::Enum4
    public enum Enum4 : uint
    {
    }
    // ClientCombatSystem::Enum8
    public enum Enum8 : uint
    {
    }
    // ClientCombatSystem::Enum9
    public enum Enum9 : uint
    {
    }

    // Members
    public ACBindings.Internal.Turbine_RefCount m_cTurbineRefCount;
    public byte jump_pending;
    public byte m_bTrackingTarget;
    public ACBindings.Internal.COMBAT_MODE combatMode;
    public ACBindings.Internal.COMBAT_MODE pendingCombatMode;
    public ACBindings.Internal.ATTACK_HEIGHT requestedAttackHeight;
    public double buildStartTime;
    public byte buildInProgress;
    public ACBindings.Internal.PowerBarMode powerBarMode;
    public float latestPowerBarLevel;
    public byte attackInProgress;
    public byte attackServerResponsePending;
    public byte attackRequestInProgress;
    public float requestedAttackPower;
    public byte repeatAttacking;
    public byte currentBuildIsAutomatic;
    public byte targetWillinglyLost;
    public byte attackWhenResponseReceived;
    public float attackWhenResponseReceived_Power;
    public float m_rUIRequestedPower;
    public byte m_bAdvancedCombatMode;
    public double lastAttackedTime;

    // Generated Constructor
    public ClientCombatSystem() {
        _ConstructorInternal();
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>Initializes combat system state by resetting modes, timers, flags, and default attack parameters before registering a notice handler with the global event system.
    /// <code>Offset: 0x0056B1A0
    /// void __thiscall ClientCombatSystem::Begin(ClientCombatSystem*)</code>
    /// </summary>
    public void Begin() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientCombatSystem, void>)0x0056B1A0)(ref this);

    /// <summary>Provides access to the singleton combat system instance used by the client.
    /// <code>Offset: 0x0056B210
    /// ClientCombatSystem* __cdecl ClientCombatSystem::GetCombatSystem()</code>
    /// </summary>
    /// <returns>The active ClientCombatSystem, or nullptr if no instance has been created.</returns>
    public static ACBindings.Internal.ClientCombatSystem* GetCombatSystem() => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.ClientCombatSystem*>)0x0056B210)();

    /// <summary>Initializes the combat system at startup by assigning a global instance pointer, increasing its reference count, and registering a quality change handler.
    /// <code>Offset: 0x0056B220
    /// void __thiscall ClientCombatSystem::OnStartup(ClientCombatSystem*)</code>
    /// </summary>
    public void OnStartup() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientCombatSystem, void>)0x0056B220)(ref this);

    /// <summary>Shuts down the client combat system, clearing any global instance pointer and unregistering associated quality change handlers.
    /// <code>Offset: 0x0056B250
    /// void __thiscall ClientCombatSystem::OnShutdown(ClientCombatSystem*)</code>
    /// </summary>
    public void OnShutdown() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientCombatSystem, void>)0x0056B250)(ref this);

    /// <summary>Updates the combat system with a target's current health value received from server.
    /// <code>Offset: 0x0056B2A0
    /// unsigned int __thiscall ClientCombatSystem::Handle_Combat__QueryHealthResponse(ClientCombatSystem*,unsigned int,float)</code>
    /// </summary>
    /// <param name="target">Identifier of the target entity whose health is being reported.</param>
    /// <param name="health">Health value to apply to the target.</param>
    /// <returns>Zero indicating successful processing of the response.</returns>
    public uint Handle_Combat__QueryHealthResponse(uint target, float health) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientCombatSystem, uint, float, uint>)0x0056B2A0)(ref this, target, health);

    /// <summary>Determines whether a specified combat mode is usable based on the player's current equipment mask.
    /// <code>Offset: 0x0056B2C0
    /// bool __thiscall ClientCombatSystem::CompatibleCombatMode(ClientCombatSystem*,COMBAT_MODE)</code>
    /// </summary>
    /// <param name="i_combatMode">The combat mode to evaluate for compatibility.</param>
    /// <returns>True if the player can employ the given combat mode; otherwise, false.</returns>
    public byte CompatibleCombatMode(ACBindings.Internal.COMBAT_MODE i_combatMode) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientCombatSystem, ACBindings.Internal.COMBAT_MODE, byte>)0x0056B2C0)(ref this, i_combatMode);

    /// <summary>Determines whether the specified object can be attacked by the player in the current combat context, checking for existence, status flags, pet ownership and relevant combat rules.
    /// <code>Offset: 0x0056B340
    /// bool __thiscall ClientCombatSystem::ObjectIsAttackable(ClientCombatSystem*,unsigned int)</code>
    /// </summary>
    /// <param name="objectID">The identifier of the object to evaluate for attackability.</param>
    /// <returns>True if the object is attackable; otherwise, false.</returns>
    public byte ObjectIsAttackable(uint objectID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientCombatSystem, uint, byte>)0x0056B340)(ref this, objectID);

    /// <summary>Determines whether auto‑repeat attack is currently active for the client.
    /// <code>Offset: 0x0056B5A0
    /// bool __thiscall ClientCombatSystem::RepeatAttackInProgress(ClientCombatSystem*)</code>
    /// </summary>
    /// <returns>True if a repeat attack is in progress; otherwise false.</returns>
    public byte RepeatAttackInProgress() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientCombatSystem, byte>)0x0056B5A0)(ref this);

    /// <summary>Updates the combat system's power bar to the specified level, recording the value internally and notifying the character module.
    /// <code>Offset: 0x0056B5D0
    /// void __thiscall ClientCombatSystem::SetPowerBarLevel(ClientCombatSystem*,float)</code>
    /// </summary>
    /// <param name="level">Desired power bar level as a floating‑point value.</param>
    public void SetPowerBarLevel(float level) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientCombatSystem, float, void>)0x0056B5D0)(ref this, level);

    /// <summary>Hides the active power bar, clears any ongoing build progress, sends a completion notice (or zero level if in combat), and resets the system’s mode to undefined.
    /// <code>Offset: 0x0056B5F0
    /// void __thiscall ClientCombatSystem::HidePowerBar(ClientCombatSystem*)</code>
    /// </summary>
    public void HidePowerBar() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientCombatSystem, void>)0x0056B5F0)(ref this);

    /// <summary>Retrieves the current attack target's entity identifier for combat, resolving child physics objects to their parent entities and ensuring the target is neither null nor owned by the player. Returns 0 when no valid target exists.
    /// <code>Offset: 0x0056B630
    /// unsigned int __thiscall ClientCombatSystem::GetAttackTarget(ClientCombatSystem*)</code>
    /// </summary>
    /// <returns>The resolved entity ID of the attack target, or zero if no suitable target is selected.</returns>
    public uint GetAttackTarget() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientCombatSystem, uint>)0x0056B630)(ref this);

    /// <summary>Updates camera targeting when a valid attack target exists during melee or missile combat modes, otherwise clears the camera’s tracked target.
    /// <code>Offset: 0x0056B690
    /// void __thiscall ClientCombatSystem::UpdateTargetTracking(ClientCombatSystem*)</code>
    /// </summary>
    public void UpdateTargetTracking() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientCombatSystem, void>)0x0056B690)(ref this);

    /// <summary>Concludes an ongoing jump action by resetting combat state and cleaning up power‑bar settings. The method clears the pending jump flag, stops any build progress, resets the power‑bar mode, and ensures the character’s physics object exits a standing long‑jump state if present.
    /// <code>Offset: 0x0056B6F0
    /// void __thiscall ClientCombatSystem::FinishJump(ClientCombatSystem*)</code>
    /// </summary>
    public void FinishJump() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientCombatSystem, void>)0x0056B6F0)(ref this);

    /// <summary>Configures combat‑mode input mappings during a mode transition, registering callbacks for the new mode and ensuring a generic action is always active with a 1000 ms duration.
    /// <code>Offset: 0x0056B760
    /// void __thiscall ClientCombatSystem::RegisterInputMaps(ClientCombatSystem*,COMBAT_MODE,COMBAT_MODE)</code>
    /// </summary>
    /// <param name="i_CurrentMode">The combat mode that will become active.</param>
    /// <param name="i_PreviousMode">The combat mode that was active before the switch.</param>
    public void RegisterInputMaps(ACBindings.Internal.COMBAT_MODE i_CurrentMode, ACBindings.Internal.COMBAT_MODE i_PreviousMode) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientCombatSystem, ACBindings.Internal.COMBAT_MODE, ACBindings.Internal.COMBAT_MODE, void>)0x0056B760)(ref this, i_CurrentMode, i_PreviousMode);

    /// <summary>Destroys a ClientCombatSystem object, unregistering its notice handlers from the global event system, resetting reference counts, and invoking base class destructors to clean up all associated resources.
    /// <code>Offset: 0x0056B8C0
    /// void __thiscall ClientCombatSystem::~ClientCombatSystem(ClientCombatSystem*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientCombatSystem, void>)0x0056B8C0)(ref this);

    /// <summary>Decrements the internal reference counter and, if it reaches zero, cleans up the input‑action callback base class.
    /// <code>Offset: 0x0056B960
    /// unsigned int __thiscall ClientCombatSystem::Release(ClientCombatSystem*)</code>
    /// </summary>
    /// <returns>The new reference count after the release operation.</returns>
    public uint Release() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientCombatSystem, uint>)0x0056B960)(ref this);

    /// <summary>Retrieves an interface from the combat system by its GUID, returning success or error through TResult and optionally providing a pointer to the requested interface.
    /// <code>Offset: 0x0056B990
    /// TResult* __thiscall ClientCombatSystem::QueryInterface(ClientCombatSystem*,TResult*,const Turbine_GUID*,void**)</code>
    /// </summary>
    /// <param name="result">Structure receiving status code; m_val set to 0 on success, otherwise an HRESULT error such as -2147467262.</param>
    /// <param name="i_rcInterface">Identifier of the desired interface.</param>
    /// <param name="o_ppvInterface">Optional location to receive the queried interface pointer; may be null.</param>
    /// <returns>The same TResult pointer that was passed in, containing the result status.</returns>
    public ACBindings.Internal.TResult* QueryInterface(ACBindings.Internal.TResult* result, ACBindings.Internal.Turbine_GUID* i_rcInterface, void** o_ppvInterface) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientCombatSystem, ACBindings.Internal.TResult*, ACBindings.Internal.Turbine_GUID*, void**, ACBindings.Internal.TResult*>)0x0056B990)(ref this, result, i_rcInterface, o_ppvInterface);

    /// <summary>Begins an attack sequence by setting internal flags and updating the power bar status. If no power bar exists, it initializes the mode according to advanced combat settings and notifies the character system. The UI busy counter is also increased to reflect the ongoing action.
    /// <code>Offset: 0x0056BA60
    /// void __thiscall ClientCombatSystem::HandleCommenceAttackEvent(ClientCombatSystem*)</code>
    /// </summary>
    public void HandleCommenceAttackEvent() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientCombatSystem, void>)0x0056BA60)(ref this);

    /// <summary>Begins a power‑bar construction sequence by flagging the build as active, recording its start time, and resetting the displayed power level to zero.
    /// <code>Offset: 0x0056BAF0
    /// void __thiscall ClientCombatSystem::StartPowerBarBuild(ClientCombatSystem*)</code>
    /// </summary>
    public void StartPowerBarBuild() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientCombatSystem, void>)0x0056BAF0)(ref this);

    /// <summary>Determines the current power bar level while a build is in progress, scaling elapsed time by the object's motion state and clamping the result between 0 and 1.
    /// <code>Offset: 0x0056BB20
    /// float __thiscall ClientCombatSystem::GetPowerBarLevel(ClientCombatSystem*)</code>
    /// </summary>
    /// <returns>A float ranging from 0.0 to 1.0 that represents how much of the power bar has filled; returns 0 if no build is active or before start, and 1 when fully charged.</returns>
    public float GetPowerBarLevel() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientCombatSystem, float>)0x0056BB20)(ref this);

    /// <summary>Cancels an ongoing or queued automatic attack, clears repeat‑attack flags, and hides the power bar if a build is in progress during combat mode.
    /// <code>Offset: 0x0056BBD0
    /// void __thiscall ClientCombatSystem::AbortAutomaticAttack(ClientCombatSystem*)</code>
    /// </summary>
    public void AbortAutomaticAttack() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientCombatSystem, void>)0x0056BBD0)(ref this);

    /// <summary>Enables or disables target tracking for the combat system and updates internal state when a change occurs.
    /// <code>Offset: 0x0056BC10
    /// void __thiscall ClientCombatSystem::TrackTarget(ClientCombatSystem*,bool)</code>
    /// </summary>
    /// <param name="i_bTrackTarget">True to enable tracking, false to disable.</param>
    public void TrackTarget(byte i_bTrackTarget) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientCombatSystem, byte, void>)0x0056BC10)(ref this, i_bTrackTarget);

    /// <summary>Initializes combat system state when a character session starts by registering its input action callback with the central input manager.
    /// <code>Offset: 0x0056BC30
    /// void __thiscall ClientCombatSystem::OnBeginCharacterSession(ClientCombatSystem*)</code>
    /// </summary>
    /// <param name="this">Pointer to the ClientCombatSystem instance.</param>
    public void OnBeginCharacterSession() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientCombatSystem, void>)0x0056BC30)(ref this);

    /// <summary>Ends the current character session by unregistering all notice handlers and resetting combat state via Begin(). If an ICIDM context exists, it also triggers its callback with the system’s input action base class.
    /// <code>Offset: 0x0056BC70
    /// void __thiscall ClientCombatSystem::OnEndCharacterSession(ClientCombatSystem*)</code>
    /// </summary>
    public void OnEndCharacterSession() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientCombatSystem, void>)0x0056BC70)(ref this);

    /// <summary>Starts a jump sequence by checking jump readiness, cancelling any current attack if necessary, displaying error messages for invalid states, and initializing the jump power‑bar to begin building.
    /// <code>Offset: 0x0056BCD0
    /// void __thiscall ClientCombatSystem::CommenceJump(ClientCombatSystem*)</code>
    /// </summary>
    public void CommenceJump() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientCombatSystem, void>)0x0056BCD0)(ref this);

    /// <summary>Returns the current jump power level, which is zero when a jump is not pending. If a jump is pending, it yields the active power bar level unless that value falls below a minimal threshold, in which case a predefined minimum extent is returned.
    /// <code>Offset: 0x0056BD90
    /// float __thiscall ClientCombatSystem::GetJumpPowerLevel(ClientCombatSystem*)</code>
    /// </summary>
    /// <returns>The effective jump power level as a float; 0 if no jump pending, otherwise the calculated power or the minimum allowed extent.</returns>
    public float GetJumpPowerLevel() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientCombatSystem, float>)0x0056BD90)(ref this);

    /// <summary>Initializes the client combat system’s interfaces and reference counting, then begins combat processing by invoking the Begin method.
    /// <code>Offset: 0x0056BDD0
    /// void __thiscall ClientCombatSystem::ClientCombatSystem(ClientCombatSystem*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientCombatSystem, void>)0x0056BDD0)(ref this);

    /// <summary>Performs a queued jump if one is pending. If autonomous, calculates jump strength from the power bar and applies it via physics; on success triggers a movement event, otherwise displays an error message. For non‑autonomous jumps, signals a jump event with the calculated or zero extent.
    /// <code>Offset: 0x0056BE50
    /// void __thiscall ClientCombatSystem::DoJump(ClientCombatSystem*,bool)</code>
    /// </summary>
    /// <param name="autonomous">Determines whether the jump should be executed automatically (true) or as a player request (false).</param>
    public void DoJump(byte autonomous) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientCombatSystem, byte, void>)0x0056BE50)(ref this, autonomous);

    /// <summary>Determines the default combat mode for the client based on equipped items, returning a COMBAT_MODE value.
    /// <code>Offset: 0x0056C050
    /// COMBAT_MODE __thiscall ClientCombatSystem::GetDefaultCombatMode(ClientCombatSystem*,bool)</code>
    /// </summary>
    /// <param name="quiet">Suppresses the warning message shown when the client cannot enter combat mode due to an equipped item.</param>
    /// <returns>A COMBAT_MODE value representing the client's default combat state (e.g., normal, melee, ranged, or restricted). If no suitable weapon is detected, returns the standard default mode; if a restriction applies and quiet is false, displays an explanatory message before returning the restricted mode.</returns>
    public ACBindings.Internal.COMBAT_MODE GetDefaultCombatMode(byte quiet) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientCombatSystem, byte, ACBindings.Internal.COMBAT_MODE>)0x0056C050)(ref this, quiet);

    /// <summary>Handles an attacker notification event by building a combat message that includes the attacker's name, damage type, amount, and any special modifiers, then posts it to the UI scroll log unless the system is squelched for the attacker.
    /// <code>Offset: 0x0056C160
    /// LONG __thiscall ClientCombatSystem::HandleAttackerNotificationEvent(void*,int,char*,double,int,int,char,int)</code>
    /// </summary>
    /// <param name="a2">Pointer to the attacking entity, used to retrieve its display name.</param>
    /// <param name="Source">Pointer identifying the source or damage type of the attack.</param>
    /// <param name="a4">Attack power value used to select adjectives and format the message.</param>
    /// <param name="a5">Damage points dealt by the attack.</param>
    /// <param name="a6">Flag indicating a critical hit; non‑zero triggers “Critical hit!” text.</param>
    /// <param name="a7">Bitmask of special attack modifiers (e.g., Overpower, Sneak Attack, Recklessness, Critical Protection).</param>
    /// <param name="a8">Notification event identifier (unused in this implementation).</param>
    /// <returns>Result code from the internal reference count decrement; zero indicates successful completion.</returns>
    public int HandleAttackerNotificationEvent(int a2, sbyte* Source, double a4, int a5, int a6, sbyte a7, int a8) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientCombatSystem, int, sbyte*, double, int, int, sbyte, int, int>)0x0056C160)(ref this, a2, Source, a4, a5, a6, a7, a8);

    /// <summary>Determines whether the player is in a ready state for combat based on the current combat mode and physics motion status.
    /// <code>Offset: 0x0056C570
    /// bool __thiscall ClientCombatSystem::PlayerInReadyPosition(ClientCombatSystem*,bool)</code>
    /// </summary>
    /// <param name="considerAttackingReady">If true, treats the player as ready when an attack maneuver is available; otherwise only considers the absence of pending motions.</param>
    /// <returns>True if the player is in a ready position for combat; otherwise false.</returns>
    public byte PlayerInReadyPosition(byte considerAttackingReady) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientCombatSystem, byte, byte>)0x0056C570)(ref this, considerAttackingReady);

    /// <summary>Initiates a building attack sequence when the player is in a ready position and no build is currently in progress. Configures the power bar mode, starts the build timer, and notifies the character system of the new state.
    /// <code>Offset: 0x0056C850
    /// void __thiscall ClientCombatSystem::AttemptStartBuildingAttack(ClientCombatSystem*)</code>
    /// </summary>
    public void AttemptStartBuildingAttack() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientCombatSystem, void>)0x0056C850)(ref this);

    /// <summary>Executes a combat action against the current target using the specified attack height and handles power‑bar state, repeat‑attack logic, and server acknowledgment.
    /// <code>Offset: 0x0056C8C0
    /// void __thiscall ClientCombatSystem::ExecuteAttack(ClientCombatSystem*,ATTACK_HEIGHT,bool)</code>
    /// </summary>
    /// <param name="attackHeight">The desired vertical level for the attack (e.g., low, medium, high).</param>
    /// <param name="expectServerResponse">If true, marks that a response from the server is awaited; otherwise clears that flag immediately after initiating the attack.</param>
    public void ExecuteAttack(ACBindings.Internal.ATTACK_HEIGHT attackHeight, byte expectServerResponse) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientCombatSystem, ACBindings.Internal.ATTACK_HEIGHT, byte, void>)0x0056C8C0)(ref this, attackHeight, expectServerResponse);

    /// <summary>Selects a combat target automatically based on recent attack or next compass item. If the last attacked target is still valid and within 15 seconds, it becomes the new selected object; otherwise the player system selects the next available target. The chosen target is then activated through its interface.
    /// <code>Offset: 0x0056C9D0
    /// void __thiscall ClientCombatSystem::AutoTarget(ClientCombatSystem*)</code>
    /// </summary>
    public void AutoTarget() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientCombatSystem, void>)0x0056C9D0)(ref this);

    /// <summary>Handles changes to the current target selection, updating combat state, canceling pending attacks, and initiating automatic targeting as needed.
    /// <code>Offset: 0x0056CAD0
    /// void __thiscall ClientCombatSystem::RecvNotice_SelectionChanged(ClientCombatSystem*)</code>
    /// </summary>
    public void RecvNotice_SelectionChanged() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientCombatSystem, void>)0x0056CAD0)(ref this);

    /// <summary>Changes the client's combat mode to a new state, performing validation checks when requested by the player, updating UI elements, tracking targets, and notifying relevant subsystems.
    /// <code>Offset: 0x0056CB80
    /// void __thiscall ClientCombatSystem::SetCombatMode(ClientCombatSystem*,COMBAT_MODE,bool)</code>
    /// </summary>
    /// <param name="i_NewCombatMode">The desired combat mode to set.</param>
    /// <param name="i_bPlayerRequested">True if the change was initiated by the player; triggers compatibility checks and UI updates.</param>
    public void SetCombatMode(ACBindings.Internal.COMBAT_MODE i_NewCombatMode, byte i_bPlayerRequested) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientCombatSystem, ACBindings.Internal.COMBAT_MODE, byte, void>)0x0056CB80)(ref this, i_NewCombatMode, i_bPlayerRequested);

    /// <summary>Initiates an attack request when a valid target is selected or advanced combat mode is active. Sets up attack parameters and attempts to start building the attack; otherwise displays an error message prompting target selection.
    /// <code>Offset: 0x0056CD90
    /// void __thiscall ClientCombatSystem::StartAttackRequest(ClientCombatSystem*)</code>
    /// </summary>
    public void StartAttackRequest() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientCombatSystem, void>)0x0056CD90)(ref this);

    /// <summary>Finalizes an ongoing attack request by determining the effective power from the supplied value or UI level and executing the attack immediately when conditions permit, while handling pending server responses.
    /// <code>Offset: 0x0056CE30
    /// void __thiscall ClientCombatSystem::EndAttackRequest(ClientCombatSystem*,ATTACK_HEIGHT,float)</code>
    /// </summary>
    /// <param name="attackHeight">The desired height of the attack (e.g., ground, mid, high).</param>
    /// <param name="power">Requested attack power; a negative value indicates that the system should use the UI power level or advanced combat mode defaults.</param>
    public void EndAttackRequest(ACBindings.Internal.ATTACK_HEIGHT attackHeight, float power) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientCombatSystem, ACBindings.Internal.ATTACK_HEIGHT, float, void>)0x0056CE30)(ref this, attackHeight, power);

    /// <summary>
    /// Handles a quality change event for a CWeenieObject; when the specified integer quality flag is set, updates the client’s combat mode accordingly.
    /// 
    /// <code>Offset: 0x0056CF00
    /// void __thiscall ClientCombatSystem::OnQualityChanged(ClientCombatSystem*,CWeenieObject*,StatType,unsigned int)</code>
    /// </summary>
    /// <param name="this">Pointer to the ClientCombatSystem instance.</param>
    /// <param name="cwobj">The object whose quality changed.</param>
    /// <param name="stype">Type of stat that changed.</param>
    /// <param name="senum">Enumeration value associated with the change (unused in this handler).</param>
    public void OnQualityChanged(ACBindings.Internal.CWeenieObject* cwobj, ACBindings.Internal.StatType stype, uint senum) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientCombatSystem, ACBindings.Internal.CWeenieObject*, ACBindings.Internal.StatType, uint, void>)0x0056CF00)(ref this, cwobj, stype, senum);

    /// <summary>Updates the combat system state by managing power bar levels, executing or canceling attacks, and switching combat modes as appropriate.
    /// <code>Offset: 0x0056CF40
    /// void __thiscall ClientCombatSystem::UseTime(ClientCombatSystem*)</code>
    /// </summary>
    public void UseTime() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientCombatSystem, void>)0x0056CF40)(ref this);

    /// <summary>Processes a player‑death packet received from the server, unpacking its contents and displaying a notification for other players when appropriate.
    /// <code>Offset: 0x0056D070
    /// int __thiscall ClientCombatSystem::HandlePlayerDeathEvent(ClientCombatSystem*,void*,unsigned int)</code>
    /// </summary>
    /// <param name="buff">Pointer to the packed event data sent by the server.</param>
    /// <param name="size">Size of that data buffer in bytes.</param>
    /// <returns>Non‑zero if the packet was unpacked successfully; zero on failure.</returns>
    public int HandlePlayerDeathEvent(System.IntPtr buff, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientCombatSystem, System.IntPtr, uint, int>)0x0056D070)(ref this, buff, size);

    /// <summary>Handles a victim notification event by extracting text from the supplied buffer and adding it to the combat scroll display.
    /// <code>Offset: 0x0056D160
    /// int __thiscall ClientCombatSystem::HandleVictimNotificationEvent(ClientCombatSystem*,void*,unsigned int)</code>
    /// </summary>
    /// <param name="buff">Pointer to the raw data containing the victim notification payload.</param>
    /// <param name="size">Size of the data in bytes.</param>
    /// <returns>1 if the message was successfully unpacked and displayed; 0 otherwise.</returns>
    public int HandleVictimNotificationEvent(System.IntPtr buff, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientCombatSystem, System.IntPtr, uint, int>)0x0056D160)(ref this, buff, size);

    /// <summary>Handles completion of an attack, resetting combat state and initiating any pending automatic or queued attacks based on current combat mode and power‑bar status.
    /// <code>Offset: 0x0056D250
    /// void __thiscall ClientCombatSystem::HandleAttackDoneEvent(ClientCombatSystem*,const unsigned int)</code>
    /// </summary>
    /// <param name="etype">Identifier indicating the type of attack that finished; zero means no specific event.</param>
    public void HandleAttackDoneEvent(uint etype) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientCombatSystem, uint, void>)0x0056D250)(ref this, etype);

    /// <summary>Handles an evasion event from the defender side by displaying a “You evaded … !” message, updating combat timestamps, and initiating auto‑targeting when appropriate.
    /// <code>Offset: 0x0056D370
    /// LONG __thiscall ClientCombatSystem::HandleEvasionDefenderNotificationEvent(ClientCombatSystem*,char*)</code>
    /// </summary>
    /// <param name="a2">Pointer to notification data containing the attacker’s name or related information.</param>
    /// <returns>Reference count after processing; zero indicates that the notification object should be released.</returns>
    public int HandleEvasionDefenderNotificationEvent(sbyte* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientCombatSystem, sbyte*, int>)0x0056D370)(ref this, a2);

    /// <summary>Handles a notification that an attacker evaded your attack, constructs a message, and displays it in the combat UI.
    /// <code>Offset: 0x0056D4F0
    /// LONG __thiscall ClientCombatSystem::HandleEvasionAttackerNotificationEvent(void*,void (__thiscall**a2)(_DWORD, _DWORD))</code>
    /// </summary>
    /// <param name="this">Pointer to the ClientCombatSystem instance.</param>
    /// <param name="a2">Reference to the attacker’s identifier or callback used to retrieve the attacker's name.</param>
    /// <returns>Updated reference count after handling the event; zero when the referenced object is released.</returns>
    public int HandleEvasionAttackerNotificationEvent(delegate* unmanaged[Thiscall]<int, int, void>* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientCombatSystem, delegate* unmanaged[Thiscall]<int, int, void>*, int>)0x0056D4F0)(ref this, a2);

    /// <summary>Switches the combat mode between non‑combat and the system’s default mode, toggling combat engagement on or off accordingly.
    /// <code>Offset: 0x0056D610
    /// void __thiscall ClientCombatSystem::ToggleCombatMode(ClientCombatSystem*)</code>
    /// </summary>
    public void ToggleCombatMode() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientCombatSystem, void>)0x0056D610)(ref this);

    /// <summary>Updates the combat system's requested attack height and initiates an attack request if the height changes or no request is currently active.
    /// <code>Offset: 0x0056D640
    /// void __thiscall ClientCombatSystem::SetRequestedAttackHeight(ClientCombatSystem*,ATTACK_HEIGHT)</code>
    /// </summary>
    /// <param name="height">The desired attack height to be applied to the combat system.</param>
    public void SetRequestedAttackHeight(ACBindings.Internal.ATTACK_HEIGHT height) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientCombatSystem, ACBindings.Internal.ATTACK_HEIGHT, void>)0x0056D640)(ref this, height);

    /// <summary>Processes a defender notification event by constructing and displaying combat feedback based on damage type, amount, body part hit, and attack modifiers. Updates internal state such as last attack time and may trigger auto‑targeting.
    /// <code>Offset: 0x0056D670
    /// LONG __thiscall ClientCombatSystem::HandleDefenderNotificationEvent(ClientCombatSystem*,int*,int,double,int,int,int,char,int)</code>
    /// </summary>
    /// <param name="a2">Pointer to a wide string containing the defender’s name or identifier.</param>
    /// <param name="dtype">Enumeration value specifying the damage type.</param>
    /// <param name="a4">Numeric amount of damage dealt.</param>
    /// <param name="ArgList">Count of additional arguments for message formatting.</param>
    /// <param name="a6">Body part enumeration indicating where the defender was hit.</param>
    /// <param name="a7">Non‑zero if the attack was a critical hit.</param>
    /// <param name="a8">Bitmask of special attack modifiers (e.g., Overpower, Sneak Attack, Reckless).</param>
    /// <param name="a9">Reserved; currently unused.</param>
    /// <returns>Reference count after processing; typically zero when resources are released.</returns>
    public int HandleDefenderNotificationEvent(int* a2, int dtype, double a4, int ArgList, int a6, int a7, sbyte a8, int a9) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientCombatSystem, int*, int, double, int, int, int, sbyte, int, int>)0x0056D670)(ref this, a2, dtype, a4, ArgList, a6, a7, a8, a9);
}

