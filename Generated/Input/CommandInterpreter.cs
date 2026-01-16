namespace ACBindings.Internal;


/// <summary>Interprets keyboard and mouse input, translating it into movement commands for a player while managing autonomy, auto‑run, server control, and focus states.</summary>
public unsafe struct CommandInterpreter
{
    // Base Classes
    public ACBindings.Internal.IInputActionCallback BaseClass_IInputActionCallback; // ACBindings.Internal.IInputActionCallback

    // Child Types
    public unsafe struct CommandInterpreter_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CommandInterpreter*, void> CommandInterpreter_dtor_0; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CommandInterpreter*, ACBindings.Internal.InputEvent*, byte> OnAction; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CommandInterpreter*, uint, uint, uint, ACBindings.Internal.CallbackLoseFocusResult> OnLoseFocus; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CommandInterpreter*, uint, ACBindings.Internal.CommandList*> WhichList; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CommandInterpreter*, uint, float, int, int, void> AddCommand; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CommandInterpreter*, uint*, int*, float*, int*, int*, int> NukeCommand; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CommandInterpreter*, uint*, int*, float*, int*, int*, int> BookkeepCommandAndModifyIfNecessary; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CommandInterpreter*, void> ApplyCurrentMovement; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CommandInterpreter*, int, void> SetHoldRun; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CommandInterpreter*, int, void> SetHoldSidestep; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CommandInterpreter*, void> ClearAllCommands; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CommandInterpreter*, ACBindings.Internal.CommandList*, void> ApplyListHeadMovement; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CommandInterpreter*, ACBindings.Internal.CommandList*, void> StopListHeadMovement; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CommandInterpreter*, uint*, float*, void> ApplyHoldKeysToCommand; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CommandInterpreter*, uint, int, float, ACBindings.Internal.HoldKey, void> MovePlayer_NonAutonomous; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CommandInterpreter*, int> UITogglesRun; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CommandInterpreter*, void> CommenceJump; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CommandInterpreter*, byte, void> DoJump; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CommandInterpreter*, void> HandleNewForwardMovement; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CommandInterpreter*, void> SendMovementEvent; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CommandInterpreter*, void> FinishJump; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CommandInterpreter*, System.IntPtr, System.IntPtr, void> SetUI; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CommandInterpreter*, void> SendPositionEvent; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CommandInterpreter*, ACBindings.Internal.SmartBox*, void> SetSmartBox; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CommandInterpreter*, int> UsePositionFromServer; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CommandInterpreter*, void> LoseControlToServer; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CommandInterpreter*, void> TakeControlFromServer; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CommandInterpreter*, int, void> NewPlayer; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CommandInterpreter*, void> LoseKeyboardFocus; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CommandInterpreter*, void> PlayerTeleported; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CommandInterpreter*, int> PlayerIsDead; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CommandInterpreter*, void> HandleExhaustion; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CommandInterpreter*, void> UpdateToggleRun; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CommandInterpreter*, void> Disable; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CommandInterpreter*, void> Enable; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CommandInterpreter*, int> IsEnabled; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CommandInterpreter*, int> IsActive; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CommandInterpreter*, void> HandleLogOff; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CommandInterpreter*, ACBindings.Internal.CmdStruct*, void> HandleKeyboardCommand; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CommandInterpreter*, ACBindings.Internal.CmdStruct*, void> HandleMouseMovementCommand; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CommandInterpreter*, uint, int, float, int, int, void> MovePlayer; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CommandInterpreter*, void> StopDrift; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CommandInterpreter*, void> UseTime; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CommandInterpreter*, int> ShouldSendPositionEvent; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CommandInterpreter*, uint, int> SetAutonomyLevel; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CommandInterpreter*, uint> GetAutonomyLevel; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CommandInterpreter*, int> IsStandingStill; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CommandInterpreter*, int> StopCompletely; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CommandInterpreter*, int> MaybeStopCompletely; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CommandInterpreter*, float, int, int> TurnToHeading; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CommandInterpreter*, void> ToggleAutoRun; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CommandInterpreter*, int, int, void> SetAutoRun; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CommandInterpreter*, int, void> SetMouseLookActive; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CommandInterpreter*, int> GetMouseLookActive; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CommandInterpreter*, int, int> HandleSelectLeft; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CommandInterpreter*, int, void> SetMouseLeftDown; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CommandInterpreter*, int> GetMouseLeftDown; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CommandInterpreter*, uint, int> SendAutonomyLevelEvent; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CommandInterpreter*, uint, float, ACBindings.Internal.HoldKey, int> SendDoMovementEvent; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CommandInterpreter*, uint, ACBindings.Internal.HoldKey, int> SendStopMovementEvent; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CommandInterpreter*, ACBindings.Internal.MoveToStatePack*, int> SendMoveToStateEvent; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CommandInterpreter*, ACBindings.Internal.AutonomousPositionPack*, int> SendAutonomousPositionEvent; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CommandInterpreter*, ACBindings.Internal.TurnToEventPack*, int> SendTurnToEvent; // function pointer

        // Methods
    }

    // Members
    public ACBindings.Internal.SmartBox* smartbox;
    public ACBindings.Internal.CPhysicsObj* player;
    public ACBindings.Internal.CommandList SubstateList;
    public ACBindings.Internal.CommandList TurnList;
    public ACBindings.Internal.CommandList SidestepList;
    public uint autonomy_level;
    public int controlled_by_server;
    public int hold_run;
    public int hold_sidestep;
    public int transient_state;
    public int enabled;
    public int auto_run;
    public int mouselook_active;
    public int mouseleft_down;
    public float autorun_speed;
    public uint action_stamp;
    public double last_sent_position_time;
    public ACBindings.Internal.Position last_sent_position;
    public ACBindings.Internal.Plane last_sent_contact_plane;
    public double time_between_position_events;

    // Generated Constructor
    public CommandInterpreter() {
        _ConstructorInternal();
    }

    // Methods

    /// <summary>Indicates whether the command interpreter is currently enabled.
    /// <code>Offset: 0x0058C9C0
    /// int __thiscall CommandInterpreter::IsEnabled(CommandInterpreter*)</code>
    /// </summary>
    /// <returns>Non‑zero if enabled; zero otherwise.</returns>
    public int IsEnabled() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CommandInterpreter, int>)0x0058C9C0)(ref this);

    /// <summary>Enables or disables the mouse‑look mode for the command interpreter.
    /// <code>Offset: 0x0058C9D0
    /// void __thiscall CommandInterpreter::SetMouseLookActive(CommandInterpreter*,int)</code>
    /// </summary>
    /// <param name="active">Non‑zero to activate mouse look; zero to deactivate.</param>
    public void SetMouseLookActive(int active) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CommandInterpreter, int, void>)0x0058C9D0)(ref this, active);

    /// <summary>Indicates whether mouse look mode is currently active.
    /// <code>Offset: 0x0058C9E0
    /// int __thiscall CommandInterpreter::GetMouseLookActive(CommandInterpreter*)</code>
    /// </summary>
    /// <returns>An integer flag (non‑zero for active, zero for inactive) reflecting the value of CommandInterpreter::mouselook_active.</returns>
    public int GetMouseLookActive() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CommandInterpreter, int>)0x0058C9E0)(ref this);

    /// <summary>Updates the internal flag indicating whether the left mouse button is currently pressed.
    /// <code>Offset: 0x0058C9F0
    /// void __thiscall CommandInterpreter::SetMouseLeftDown(CommandInterpreter*,int)</code>
    /// </summary>
    /// <param name="active">Non‑zero to mark the button as down; zero to mark it as up.</param>
    public void SetMouseLeftDown(int active) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CommandInterpreter, int, void>)0x0058C9F0)(ref this, active);

    /// <summary>Returns the current state of the left mouse button as an integer flag.
    /// <code>Offset: 0x0058CA00
    /// int __thiscall CommandInterpreter::GetMouseLeftDown(CommandInterpreter*)</code>
    /// </summary>
    /// <returns>An integer indicating whether the left mouse button is pressed (non‑zero) or released (zero).</returns>
    public int GetMouseLeftDown() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CommandInterpreter, int>)0x0058CA00)(ref this);

    /// <summary>Links a SmartBox instance to this interpreter and synchronizes its player reference.
    /// <code>Offset: 0x006B4080
    /// void __thiscall CommandInterpreter::SetSmartBox(CommandInterpreter*,SmartBox*)</code>
    /// </summary>
    /// <param name="i_smartbox">The SmartBox to associate; may be null to clear the association.</param>
    public void SetSmartBox(ACBindings.Internal.SmartBox* i_smartbox) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CommandInterpreter, ACBindings.Internal.SmartBox*, void>)0x006B4080)(ref this, i_smartbox);

    /// <summary>Transports input control from the local player to the server when autonomy mode is active, setting the interpreter as controlled by the server and invoking necessary cleanup callbacks.
    /// <code>Offset: 0x006B40B0
    /// void __thiscall CommandInterpreter::LoseControlToServer(CommandInterpreter*)</code>
    /// </summary>
    public void LoseControlToServer() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CommandInterpreter, void>)0x006B40B0)(ref this);

    /// <summary>Removes every command from the interpreter’s substate, turn, and sidestep lists.
    /// <code>Offset: 0x006B40E0
    /// void __thiscall CommandInterpreter::ClearAllCommands(CommandInterpreter*)</code>
    /// </summary>
    public void ClearAllCommands() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CommandInterpreter, void>)0x006B40E0)(ref this);

    /// <summary>Sets the interpreter's player reference from its smartbox and triggers the appropriate input‑action handler depending on whether movement is autonomous.
    /// <code>Offset: 0x006B4100
    /// void __thiscall CommandInterpreter::NewPlayer(CommandInterpreter*,int)</code>
    /// </summary>
    /// <param name="autonomous_movement">Non‑zero selects the autonomous action callback, zero uses the standard action callback.</param>
    public void NewPlayer(int autonomous_movement) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CommandInterpreter, int, void>)0x006B4100)(ref this, autonomous_movement);

    /// <summary>Clears all active keyboard commands, resets the side‑step flag, and notifies base class callbacks that focus has been lost; if autonomy is enabled and the interpreter is not server‑controlled, it triggers autonomous action handling.
    /// <code>Offset: 0x006B4130
    /// void __thiscall CommandInterpreter::LoseKeyboardFocus(CommandInterpreter*)</code>
    /// </summary>
    public void LoseKeyboardFocus() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CommandInterpreter, void>)0x006B4130)(ref this);

    /// <summary>Disables the command interpreter by clearing focus and side‑step state, notifying base callbacks, and resetting its enabled flag. If the interpreter has non‑zero autonomy level, a player is present, and the player is not server controlled, it triggers additional actions before disabling.
    /// <code>Offset: 0x006B4190
    /// void __thiscall CommandInterpreter::Disable(CommandInterpreter*)</code>
    /// </summary>
    public void Disable() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CommandInterpreter, void>)0x006B4190)(ref this);

    /// <summary>Enables the command interpreter and triggers its input action callback to handle loss of focus.
    /// <code>Offset: 0x006B41D0
    /// void __thiscall CommandInterpreter::Enable(CommandInterpreter*)</code>
    /// </summary>
    public void Enable() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CommandInterpreter, void>)0x006B41D0)(ref this);

    /// <summary>Handles a player teleportation event by invoking the base input-action callback cleanup and then processing the action through OnAction.
    /// <code>Offset: 0x006B41F0
    /// void __thiscall CommandInterpreter::PlayerTeleported(CommandInterpreter*)</code>
    /// </summary>
    public void PlayerTeleported() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CommandInterpreter, void>)0x006B41F0)(ref this);

    /// <summary>Releases server control over the command interpreter, restoring local autonomy, resetting player movement state, and invoking focus‑loss and action callbacks.
    /// <code>Offset: 0x006B4210
    /// void __thiscall CommandInterpreter::TakeControlFromServer(CommandInterpreter*)</code>
    /// </summary>
    public void TakeControlFromServer() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CommandInterpreter, void>)0x006B4210)(ref this);

    /// <summary>Handles a user logoff by invoking the base class destructor to release resources and perform necessary cleanup for the CommandInterpreter instance.
    /// <code>Offset: 0x006B4270
    /// void __thiscall CommandInterpreter::HandleLogOff(CommandInterpreter*)</code>
    /// </summary>
    public void HandleLogOff() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CommandInterpreter, void>)0x006B4270)(ref this);

    /// <summary>Applies sidestep holding logic to a command, converting forward or backward movement codes into lateral sidesteps when the side‑step key is held.
    /// <code>Offset: 0x006B4280
    /// void __thiscall CommandInterpreter::ApplyHoldKeysToCommand(CommandInterpreter*,unsigned int*,float*)</code>
    /// </summary>
    /// <param name="cmd">Pointer to the current command code that may be altered if sidestep hold is active.</param>
    /// <param name="speed">Ignored; present for compatibility with other command handlers.</param>
    public void ApplyHoldKeysToCommand(uint* cmd, float* speed) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CommandInterpreter, uint*, float*, void>)0x006B4280)(ref this, cmd, speed);

    /// <summary>Updates the interpreter's hold‑run status and propagates the change to the player's physics or input callbacks as appropriate.
    /// <code>Offset: 0x006B42B0
    /// void __thiscall CommandInterpreter::SetHoldRun(CommandInterpreter*,int)</code>
    /// </summary>
    /// <param name="new_value">Non‑zero value enables hold run; zero disables it.</param>
    public void SetHoldRun(int new_value) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CommandInterpreter, int, void>)0x006B42B0)(ref this, new_value);

    /// <summary>Updates the interpreter’s sidestep‑hold flag, clears queued turn actions, and triggers action processing.
    /// <code>Offset: 0x006B4350
    /// void __thiscall CommandInterpreter::SetHoldSidestep(CommandInterpreter*,int)</code>
    /// </summary>
    /// <param name="new_value">The value to assign to the hold sidestep state (e.g., 0 or 1).</param>
    public void SetHoldSidestep(int new_value) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CommandInterpreter, int, void>)0x006B4350)(ref this, new_value);

    /// <summary>Applies the player's current movement state by dispatching appropriate input actions or clearing command lists based on auto‑run settings, substate, turn, sidestep queues and transient status.
    /// <code>Offset: 0x006B4370
    /// void __thiscall CommandInterpreter::ApplyCurrentMovement(CommandInterpreter*)</code>
    /// </summary>
    public void ApplyCurrentMovement() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CommandInterpreter, void>)0x006B4370)(ref this);

    /// <summary>Applies movement from the head of a command list to the interpreter’s action handler, handling mouse and non‑mouse commands differently.
    /// <code>Offset: 0x006B4450
    /// void __thiscall CommandInterpreter::ApplyListHeadMovement(CommandInterpreter*,const CommandList*)</code>
    /// </summary>
    /// <param name="list">The command list whose current head element provides the movement data.</param>
    public void ApplyListHeadMovement(ACBindings.Internal.CommandList* list) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CommandInterpreter, ACBindings.Internal.CommandList*, void>)0x006B4450)(ref this, list);

    /// <summary>Terminates the current movement command at the head of the supplied command list, invoking the interpreter’s input‑action callbacks to signal completion and passing the next command in the sequence.
    /// <code>Offset: 0x006B44E0
    /// void __thiscall CommandInterpreter::StopListHeadMovement(CommandInterpreter*,const CommandList*)</code>
    /// </summary>
    /// <param name="list">The command list whose head command should be stopped.</param>
    public void StopListHeadMovement(ACBindings.Internal.CommandList* list) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CommandInterpreter, ACBindings.Internal.CommandList*, void>)0x006B44E0)(ref this, list);

    /// <summary>Handles a left‑mouse click event by updating internal button state and invoking focus‑and‑action callbacks when appropriate.
    /// <code>Offset: 0x006B4570
    /// int __thiscall CommandInterpreter::HandleSelectLeft(CommandInterpreter*,int)</code>
    /// </summary>
    /// <param name="start">Indicates the new state of the mouse‑left button (pressed or released).</param>
    /// <returns>1 if the action was accepted; 0 otherwise.</returns>
    public int HandleSelectLeft(int start) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CommandInterpreter, int, int>)0x006B4570)(ref this, start);

    /// <summary>Processes a keyboard input command represented by CmdStruct and dispatches the appropriate action or focus change through the interpreter’s callback interface. Handles special cases such as server‑controlled commands, modifier keys, and an “autorun” command that adjusts the player’s autorun speed.
    /// <code>Offset: 0x006B45D0
    /// void __thiscall CommandInterpreter::HandleKeyboardCommand(CommandInterpreter*,CmdStruct*)</code>
    /// </summary>
    /// <param name="cmdstruct">The command structure containing the keyboard event data to be interpreted.</param>
    public void HandleKeyboardCommand(ACBindings.Internal.CmdStruct* cmdstruct) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CommandInterpreter, ACBindings.Internal.CmdStruct*, void>)0x006B45D0)(ref this, cmdstruct);

    /// <summary>Parses a mouse movement command from the supplied CmdStruct and triggers the corresponding action via the input callback interface.
    /// <code>Offset: 0x006B47B0
    /// void __thiscall CommandInterpreter::HandleMouseMovementCommand(CommandInterpreter*,CmdStruct*)</code>
    /// </summary>
    /// <param name="cmdstruct">The command structure containing data to interpret.</param>
    public void HandleMouseMovementCommand(ACBindings.Internal.CmdStruct* cmdstruct) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CommandInterpreter, ACBindings.Internal.CmdStruct*, void>)0x006B47B0)(ref this, cmdstruct);

    /// <summary>Chooses the appropriate command list for a given command code by examining its value and flag bits.
    /// <code>Offset: 0x006B4890
    /// CommandList* __thiscall CommandInterpreter::WhichList(CommandInterpreter*,unsigned int)</code>
    /// </summary>
    /// <param name="cmd">The command identifier used to determine which list contains commands to execute.</param>
    /// <returns>A pointer to the selected CommandList, or null if no matching list exists.</returns>
    public ACBindings.Internal.CommandList* WhichList(uint cmd) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CommandInterpreter, uint, ACBindings.Internal.CommandList*>)0x006B4890)(ref this, cmd);

    /// <summary>Adds an input action command to the appropriate list, applying speed and hold‑run flags, and updates transient state handling based on special bitmask bits in the command identifier.
    /// <code>Offset: 0x006B48E0
    /// void __thiscall CommandInterpreter::AddCommand(CommandInterpreter*,unsigned int,float,int,int)</code>
    /// </summary>
    /// <param name="cmd">Identifier of the action command to add.</param>
    /// <param name="speed">Movement speed modifier associated with the command.</param>
    /// <param name="mouse">Mouse button or position value linked to the command.</param>
    /// <param name="new_hold_run">Flag indicating whether run should be held during this command.</param>
    public void AddCommand(uint cmd, float speed, int mouse, int new_hold_run) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CommandInterpreter, uint, float, int, int, void>)0x006B48E0)(ref this, cmd, speed, mouse, new_hold_run);

    /// <summary>Removes the specified command from the interpreter; on success loads data for the next queued command into the supplied output parameters.
    /// <code>Offset: 0x006B4960
    /// int __thiscall CommandInterpreter::NukeCommand(CommandInterpreter*,unsigned int*,int*,float*,int*,int*)</code>
    /// </summary>
    /// <param name="cmd">Input: ID of the command to remove. Output: Updated with the ID of the following command if one exists.</param>
    /// <param name="start">Output flag set to 1 when a subsequent command is available; otherwise unchanged.</param>
    /// <param name="speed">Output speed value associated with the next command, valid only if a subsequent command exists.</param>
    /// <param name="mouse">Output flag indicating whether the next command requires mouse input, valid only if a subsequent command exists.</param>
    /// <param name="new_hold_run">Output hold‑run state of the next command, valid only if a subsequent command exists.</param>
    /// <returns>1 if the removal succeeded; 0 otherwise (e.g., when the command is not found or a transient/auto‑run conflict prevents removal).</returns>
    public int NukeCommand(uint* cmd, int* start, float* speed, int* mouse, int* new_hold_run) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CommandInterpreter, uint*, int*, float*, int*, int*, int>)0x006B4960)(ref this, cmd, start, speed, mouse, new_hold_run);

    /// <summary>Handles input commands by checking for a special case, invoking focus‑loss handling when a sequence has not started, and then executing the command via the action callback while updating state flags.
    /// <code>Offset: 0x006B4A10
    /// int __thiscall CommandInterpreter::BookkeepCommandAndModifyIfNecessary(CommandInterpreter*,unsigned int*,int*,float*,int*,int*)</code>
    /// </summary>
    /// <param name="cmd">Pointer to the command identifier to be processed.</param>
    /// <param name="start">Pointer to a flag indicating whether the command sequence has begun; if zero triggers focus‑loss logic.</param>
    /// <param name="speed">Pointer to a float value used as action parameter data.</param>
    /// <param name="mouse">Pointer to an integer representing mouse input state for the command.</param>
    /// <param name="new_hold_run">Pointer to an integer flag that may be updated by the action callback to indicate whether running should continue after the command.</param>
    /// <returns>Integer status: 1 when the command is processed successfully; otherwise returns the result of the focus‑loss handler if invoked.</returns>
    public int BookkeepCommandAndModifyIfNecessary(uint* cmd, int* start, float* speed, int* mouse, int* new_hold_run) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CommandInterpreter, uint*, int*, float*, int*, int*, int>)0x006B4A10)(ref this, cmd, start, speed, mouse, new_hold_run);

    /// <summary>Determines whether the interpreter should use positions received from the server based on its autonomy level.
    /// <code>Offset: 0x006B4A80
    /// int __thiscall CommandInterpreter::UsePositionFromServer(CommandInterpreter*)</code>
    /// </summary>
    /// <returns>An integer equal to 1 if the autonomy level is not 2 (indicating that server positions are used), or 0 otherwise.</returns>
    public int UsePositionFromServer() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CommandInterpreter, int>)0x006B4A80)(ref this);

    /// <summary>Stops the player’s physics simulation immediately and triggers associated action callbacks.
    /// <code>Offset: 0x006B4A90
    /// int __thiscall CommandInterpreter::StopCompletely(CommandInterpreter*)</code>
    /// </summary>
    /// <returns>Non-zero if the operation succeeds; zero if either the smartbox or the player object is null.</returns>
    public int StopCompletely() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CommandInterpreter, int>)0x006B4A90)(ref this);

    /// <summary>Stops the interpreter entirely when it is under server control, otherwise delegates to the base class’s focus‑loss handling.
    /// <code>Offset: 0x006B4AD0
    /// int __thiscall CommandInterpreter::MaybeStopCompletely(CommandInterpreter*)</code>
    /// </summary>
    /// <returns>1 if the interpreter was stopped due to being controlled by a server; otherwise returns the result of the base class OnLoseFocus method.</returns>
    public int MaybeStopCompletely() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CommandInterpreter, int>)0x006B4AD0)(ref this);

    /// <summary>Assigns the interpreter's autonomy level to the specified value when it is between 0 and 2 inclusive.
    /// <code>Offset: 0x006B4AF0
    /// int __thiscall CommandInterpreter::SetAutonomyLevel(CommandInterpreter*,unsigned int)</code>
    /// </summary>
    /// <param name="new_level">Desired autonomy level (valid values: 0, 1, or 2).</param>
    /// <returns>Non‑zero if the assignment succeeded; zero if the supplied level exceeds the maximum allowed.</returns>
    public int SetAutonomyLevel(uint new_level) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CommandInterpreter, uint, int>)0x006B4AF0)(ref this, new_level);

    /// <summary>Invokes base class action handlers and, when the controlled player is stationary with pending commands or auto‑run enabled, triggers a loss of focus event.
    /// <code>Offset: 0x006B4B30
    /// void __thiscall CommandInterpreter::UseTime(CommandInterpreter*)</code>
    /// </summary>
    public void UseTime() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CommandInterpreter, void>)0x006B4B30)(ref this);

    /// <summary>Handles player exhaustion by notifying the motion interpreter and triggering a previous spell selection notice if a suitable handler exists.
    /// <code>Offset: 0x006B4BB0
    /// void __thiscall CommandInterpreter::HandleExhaustion(CommandInterpreter*)</code>
    /// </summary>
    public void HandleExhaustion() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CommandInterpreter, void>)0x006B4BB0)(ref this);

    /// <summary>Processes the toggle‑run command, notifying listeners of focus loss with the current hold_run flag and then executing the associated action.
    /// <code>Offset: 0x006B4BC0
    /// void __thiscall CommandInterpreter::UpdateToggleRun(CommandInterpreter*)</code>
    /// </summary>
    public void UpdateToggleRun() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CommandInterpreter, void>)0x006B4BC0)(ref this);

    /// <summary>Determines whether the command interpreter’s controlled player is stationary.
    /// <code>Offset: 0x006B4BE0
    /// int __thiscall CommandInterpreter::IsStandingStill(CommandInterpreter*)</code>
    /// </summary>
    /// <returns>Non‑zero (typically 1) when the player is not moving; zero otherwise. If no player is set, returns 1.</returns>
    public int IsStandingStill() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CommandInterpreter, int>)0x006B4BE0)(ref this);

    /// <summary>Toggles the auto‑run mode of the command interpreter, enabling or disabling continuous movement based on its current state.
    /// <code>Offset: 0x006B4C00
    /// void __thiscall CommandInterpreter::ToggleAutoRun(CommandInterpreter*)</code>
    /// </summary>
    public void ToggleAutoRun() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CommandInterpreter, void>)0x006B4C00)(ref this);

    /// <summary>Checks whether the command interpreter is enabled and has an associated player.
    /// <code>Offset: 0x006B4C20
    /// int __thiscall CommandInterpreter::IsActive(CommandInterpreter*)</code>
    /// </summary>
    /// <returns>Non‑zero if both enabled and a valid player exist; zero otherwise.</returns>
    public int IsActive() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CommandInterpreter, int>)0x006B4C20)(ref this);

    /// <summary>Processes a movement command while the player is not under autonomous control, delegating to the input callback interface based on whether the command starts or ends.
    /// <code>Offset: 0x006B4C40
    /// void __thiscall CommandInterpreter::MovePlayer_NonAutonomous(CommandInterpreter*,unsigned int,int,float,HoldKey)</code>
    /// </summary>
    /// <param name="cmd">Identifier of the action to perform.</param>
    /// <param name="start">Non‑zero indicates the beginning of an action; zero indicates its termination.</param>
    /// <param name="speed">Speed value passed when starting an action that requires a magnitude.</param>
    /// <param name="key">Key state information associated with the command.</param>
    public void MovePlayer_NonAutonomous(uint cmd, int start, float speed, ACBindings.Internal.HoldKey key) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CommandInterpreter, uint, int, float, ACBindings.Internal.HoldKey, void>)0x006B4C40)(ref this, cmd, start, speed, key);

    /// <summary>Initiates a forward movement command on the current player, delegating to the underlying input action callback with the necessary flags for starting motion.
    /// <code>Offset: 0x006B4CA0
    /// void __thiscall CommandInterpreter::HandleNewForwardMovement(CommandInterpreter*)</code>
    /// </summary>
    public void HandleNewForwardMovement() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CommandInterpreter, void>)0x006B4CA0)(ref this);

    /// <summary>Determines whether the controlled player is dead by examining its motion state.
    /// <code>Offset: 0x006B4CB0
    /// int __thiscall CommandInterpreter::PlayerIsDead(CommandInterpreter*)</code>
    /// </summary>
    /// <returns>An integer value of 1 if the player is dead, otherwise 0.</returns>
    public int PlayerIsDead() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CommandInterpreter, int>)0x006B4CB0)(ref this);

    /// <summary>Constructs a CommandInterpreter, initializing command lists, control flags, and positional data to sensible defaults—including an identity quaternion, zero origin, and standard autonomy settings.
    /// <code>Offset: 0x006B4D80
    /// void __thiscall CommandInterpreter::CommandInterpreter(CommandInterpreter*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CommandInterpreter, void>)0x006B4D80)(ref this);

    /// <summary>Processes a player movement command, determining the appropriate motion action based on current autonomy level, active commands, and input source, then applies or stops physics motions accordingly.
    /// <code>Offset: 0x006B4E80
    /// void __thiscall CommandInterpreter::MovePlayer(CommandInterpreter*,unsigned int,int,float,int,int)</code>
    /// </summary>
    /// <param name="cmd">Identifier of the movement command to execute (e.g., turn, sidestep).</param>
    /// <param name="start">Flag indicating whether this is the start of a new movement sequence.</param>
    /// <param name="speed">Desired movement speed; used when initiating motion.</param>
    /// <param name="mouse">Indicates whether the input originated from mouse controls.</param>
    /// <param name="new_hold_run">Specifies whether the run hold key should be applied during the motion.</param>
    public void MovePlayer(uint cmd, int start, float speed, int mouse, int new_hold_run) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CommandInterpreter, uint, int, float, int, int, void>)0x006B4E80)(ref this, cmd, start, speed, mouse, new_hold_run);

    /// <summary>Stops any active drift movement for the player by clearing motion flags and applying stop motion to the physics object.
    /// <code>Offset: 0x006B5450
    /// void __thiscall CommandInterpreter::StopDrift(CommandInterpreter*)</code>
    /// </summary>
    public void StopDrift() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CommandInterpreter, void>)0x006B5450)(ref this);

    /// <summary>Turns the player character toward the specified heading, applying the Run key if requested.
    /// <code>Offset: 0x006B54B0
    /// int __thiscall CommandInterpreter::TurnToHeading(CommandInterpreter*,float,int)</code>
    /// </summary>
    /// <param name="new_heading">Desired heading for the player (in radians or degrees, depending on the engine).</param>
    /// <param name="run">Non‑zero to hold the Run key while turning; zero to turn without running.</param>
    /// <returns>Returns 1 when the turn succeeds, otherwise 0 if the base class callback fails.</returns>
    public int TurnToHeading(float new_heading, int run) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CommandInterpreter, float, int, int>)0x006B54B0)(ref this, new_heading, run);

    /// <summary>Determines whether a position update event must be sent for the controlled player.
    /// <code>Offset: 0x006B5520
    /// int __thiscall CommandInterpreter::ShouldSendPositionEvent(CommandInterpreter*)</code>
    /// </summary>
    /// <returns>Non‑zero if an event should be transmitted, otherwise zero.</returns>
    public int ShouldSendPositionEvent() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CommandInterpreter, int>)0x006B5520)(ref this);

    /// <summary>Transmits the player’s current position and motion state to the input action callback if a smartbox exists, raw motion data is available, and the autonomy level permits movement handling; updates the timestamp of the last sent position.
    /// <code>Offset: 0x006B55C0
    /// void __thiscall CommandInterpreter::SendMovementEvent(CommandInterpreter*)</code>
    /// </summary>
    public void SendMovementEvent() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CommandInterpreter, void>)0x006B55C0)(ref this);

    /// <summary>Transmits the player's current autonomous position to input action callbacks when the player is in a transient state and has a valid position, updating internal records of the last sent position and contact plane.
    /// <code>Offset: 0x006B56B0
    /// void __thiscall CommandInterpreter::SendPositionEvent(CommandInterpreter*)</code>
    /// </summary>
    public void SendPositionEvent() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CommandInterpreter, void>)0x006B56B0)(ref this);

    /// <summary>Switches the interpreter’s auto‑run mode, updates internal state, displays a UI notice and optionally triggers movement.
    /// <code>Offset: 0x006B5790
    /// void __thiscall CommandInterpreter::SetAutoRun(CommandInterpreter*,int,int)</code>
    /// </summary>
    /// <param name="val">Desired value for the auto‑run flag (non‑zero enables, zero disables).</param>
    /// <param name="apply_movement">If true, invoke the command interpreter’s action routine after changing the flag.</param>
    public void SetAutoRun(int val, int apply_movement) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CommandInterpreter, int, int, void>)0x006B5790)(ref this, val, apply_movement);
}

