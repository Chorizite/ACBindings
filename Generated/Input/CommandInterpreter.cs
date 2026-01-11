namespace ACBindings.Internal;

public unsafe struct CommandInterpreter
{
    // Base Classes
    public ACBindings.Internal.IInputActionCallback BaseClass_IInputActionCallback; // ACBindings.Internal.IInputActionCallback

    // Child Types
    public unsafe struct CommandInterpreter_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CommandInterpreter*, void> CommandInterpreter_dtor_0; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CommandInterpreter*, ACBindings.Internal.InputEvent*, byte> OnAction; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CommandInterpreter*, uint, uint, uint, ACBindings.Internal.CallbackLoseFocusResult> OnLoseFocus; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CommandInterpreter*, uint, ACBindings.Internal.CommandList*> WhichList; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CommandInterpreter*, uint, float, int, int, void> AddCommand; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CommandInterpreter*, uint*, int*, float*, int*, int*, int> NukeCommand; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CommandInterpreter*, uint*, int*, float*, int*, int*, int> BookkeepCommandAndModifyIfNecessary; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CommandInterpreter*, void> ApplyCurrentMovement; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CommandInterpreter*, int, void> SetHoldRun; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CommandInterpreter*, int, void> SetHoldSidestep; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CommandInterpreter*, void> ClearAllCommands; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CommandInterpreter*, ACBindings.Internal.CommandList*, void> ApplyListHeadMovement; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CommandInterpreter*, ACBindings.Internal.CommandList*, void> StopListHeadMovement; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CommandInterpreter*, uint*, float*, void> ApplyHoldKeysToCommand; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CommandInterpreter*, uint, int, float, ACBindings.Internal.HoldKey, void> MovePlayer_NonAutonomous; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CommandInterpreter*, int> UITogglesRun; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CommandInterpreter*, void> CommenceJump; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CommandInterpreter*, byte, void> DoJump; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CommandInterpreter*, void> HandleNewForwardMovement; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CommandInterpreter*, void> SendMovementEvent; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CommandInterpreter*, void> FinishJump; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CommandInterpreter*, System.IntPtr, System.IntPtr, void> SetUI; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CommandInterpreter*, void> SendPositionEvent; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CommandInterpreter*, ACBindings.Internal.SmartBox*, void> SetSmartBox; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CommandInterpreter*, int> UsePositionFromServer; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CommandInterpreter*, void> LoseControlToServer; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CommandInterpreter*, void> TakeControlFromServer; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CommandInterpreter*, int, void> NewPlayer; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CommandInterpreter*, void> LoseKeyboardFocus; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CommandInterpreter*, void> PlayerTeleported; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CommandInterpreter*, int> PlayerIsDead; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CommandInterpreter*, void> HandleExhaustion; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CommandInterpreter*, void> UpdateToggleRun; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CommandInterpreter*, void> Disable; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CommandInterpreter*, void> Enable; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CommandInterpreter*, int> IsEnabled; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CommandInterpreter*, int> IsActive; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CommandInterpreter*, void> HandleLogOff; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CommandInterpreter*, ACBindings.Internal.CmdStruct*, void> HandleKeyboardCommand; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CommandInterpreter*, ACBindings.Internal.CmdStruct*, void> HandleMouseMovementCommand; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CommandInterpreter*, uint, int, float, int, int, void> MovePlayer; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CommandInterpreter*, void> StopDrift; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CommandInterpreter*, void> UseTime; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CommandInterpreter*, int> ShouldSendPositionEvent; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CommandInterpreter*, uint, int> SetAutonomyLevel; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CommandInterpreter*, uint> GetAutonomyLevel; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CommandInterpreter*, int> IsStandingStill; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CommandInterpreter*, int> StopCompletely; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CommandInterpreter*, int> MaybeStopCompletely; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CommandInterpreter*, float, int, int> TurnToHeading; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CommandInterpreter*, void> ToggleAutoRun; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CommandInterpreter*, int, int, void> SetAutoRun; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CommandInterpreter*, int, void> SetMouseLookActive; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CommandInterpreter*, int> GetMouseLookActive; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CommandInterpreter*, int, int> HandleSelectLeft; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CommandInterpreter*, int, void> SetMouseLeftDown; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CommandInterpreter*, int> GetMouseLeftDown; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CommandInterpreter*, uint, int> SendAutonomyLevelEvent; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CommandInterpreter*, uint, float, ACBindings.Internal.HoldKey, int> SendDoMovementEvent; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CommandInterpreter*, uint, ACBindings.Internal.HoldKey, int> SendStopMovementEvent; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CommandInterpreter*, ACBindings.Internal.MoveToStatePack*, int> SendMoveToStateEvent; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CommandInterpreter*, ACBindings.Internal.AutonomousPositionPack*, int> SendAutonomousPositionEvent; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CommandInterpreter*, ACBindings.Internal.TurnToEventPack*, int> SendTurnToEvent; // function pointer

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

    /// <summary>
    /// <code>Offset: 0x0058C9C0
    /// int __thiscall CommandInterpreter::IsEnabled(CommandInterpreter*)</code>
    /// </summary>
    public int IsEnabled() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CommandInterpreter, int>)0x0058C9C0)(ref this);

    /// <summary>
    /// <code>Offset: 0x0058C9D0
    /// void __thiscall CommandInterpreter::SetMouseLookActive(CommandInterpreter*,int)</code>
    /// </summary>
    public void SetMouseLookActive(int active) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CommandInterpreter, int, void>)0x0058C9D0)(ref this, active);

    /// <summary>
    /// <code>Offset: 0x0058C9E0
    /// int __thiscall CommandInterpreter::GetMouseLookActive(CommandInterpreter*)</code>
    /// </summary>
    public int GetMouseLookActive() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CommandInterpreter, int>)0x0058C9E0)(ref this);

    /// <summary>
    /// <code>Offset: 0x0058C9F0
    /// void __thiscall CommandInterpreter::SetMouseLeftDown(CommandInterpreter*,int)</code>
    /// </summary>
    public void SetMouseLeftDown(int active) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CommandInterpreter, int, void>)0x0058C9F0)(ref this, active);

    /// <summary>
    /// <code>Offset: 0x0058CA00
    /// int __thiscall CommandInterpreter::GetMouseLeftDown(CommandInterpreter*)</code>
    /// </summary>
    public int GetMouseLeftDown() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CommandInterpreter, int>)0x0058CA00)(ref this);

    /// <summary>
    /// <code>Offset: 0x006B4080
    /// void __thiscall CommandInterpreter::SetSmartBox(CommandInterpreter*,SmartBox*)</code>
    /// </summary>
    public void SetSmartBox(ACBindings.Internal.SmartBox* i_smartbox) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CommandInterpreter, ACBindings.Internal.SmartBox*, void>)0x006B4080)(ref this, i_smartbox);

    /// <summary>
    /// <code>Offset: 0x006B40B0
    /// void __thiscall CommandInterpreter::LoseControlToServer(CommandInterpreter*)</code>
    /// </summary>
    public void LoseControlToServer() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CommandInterpreter, void>)0x006B40B0)(ref this);

    /// <summary>
    /// <code>Offset: 0x006B40E0
    /// void __thiscall CommandInterpreter::ClearAllCommands(CommandInterpreter*)</code>
    /// </summary>
    public void ClearAllCommands() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CommandInterpreter, void>)0x006B40E0)(ref this);

    /// <summary>
    /// <code>Offset: 0x006B4100
    /// void __thiscall CommandInterpreter::NewPlayer(CommandInterpreter*,int)</code>
    /// </summary>
    public void NewPlayer(int autonomous_movement) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CommandInterpreter, int, void>)0x006B4100)(ref this, autonomous_movement);

    /// <summary>
    /// <code>Offset: 0x006B4130
    /// void __thiscall CommandInterpreter::LoseKeyboardFocus(CommandInterpreter*)</code>
    /// </summary>
    public void LoseKeyboardFocus() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CommandInterpreter, void>)0x006B4130)(ref this);

    /// <summary>
    /// <code>Offset: 0x006B4190
    /// void __thiscall CommandInterpreter::Disable(CommandInterpreter*)</code>
    /// </summary>
    public void Disable() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CommandInterpreter, void>)0x006B4190)(ref this);

    /// <summary>
    /// <code>Offset: 0x006B41D0
    /// void __thiscall CommandInterpreter::Enable(CommandInterpreter*)</code>
    /// </summary>
    public void Enable() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CommandInterpreter, void>)0x006B41D0)(ref this);

    /// <summary>
    /// <code>Offset: 0x006B41F0
    /// void __thiscall CommandInterpreter::PlayerTeleported(CommandInterpreter*)</code>
    /// </summary>
    public void PlayerTeleported() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CommandInterpreter, void>)0x006B41F0)(ref this);

    /// <summary>
    /// <code>Offset: 0x006B4210
    /// void __thiscall CommandInterpreter::TakeControlFromServer(CommandInterpreter*)</code>
    /// </summary>
    public void TakeControlFromServer() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CommandInterpreter, void>)0x006B4210)(ref this);

    /// <summary>
    /// <code>Offset: 0x006B4270
    /// void __thiscall CommandInterpreter::HandleLogOff(CommandInterpreter*)</code>
    /// </summary>
    public void HandleLogOff() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CommandInterpreter, void>)0x006B4270)(ref this);

    /// <summary>
    /// <code>Offset: 0x006B4280
    /// void __thiscall CommandInterpreter::ApplyHoldKeysToCommand(CommandInterpreter*,unsigned int*,float*)</code>
    /// </summary>
    public void ApplyHoldKeysToCommand(uint* cmd, float* speed) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CommandInterpreter, uint*, float*, void>)0x006B4280)(ref this, cmd, speed);

    /// <summary>
    /// <code>Offset: 0x006B42B0
    /// void __thiscall CommandInterpreter::SetHoldRun(CommandInterpreter*,int)</code>
    /// </summary>
    public void SetHoldRun(int new_value) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CommandInterpreter, int, void>)0x006B42B0)(ref this, new_value);

    /// <summary>
    /// <code>Offset: 0x006B4350
    /// void __thiscall CommandInterpreter::SetHoldSidestep(CommandInterpreter*,int)</code>
    /// </summary>
    public void SetHoldSidestep(int new_value) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CommandInterpreter, int, void>)0x006B4350)(ref this, new_value);

    /// <summary>
    /// <code>Offset: 0x006B4370
    /// void __thiscall CommandInterpreter::ApplyCurrentMovement(CommandInterpreter*)</code>
    /// </summary>
    public void ApplyCurrentMovement() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CommandInterpreter, void>)0x006B4370)(ref this);

    /// <summary>
    /// <code>Offset: 0x006B4450
    /// void __thiscall CommandInterpreter::ApplyListHeadMovement(CommandInterpreter*,const CommandList*)</code>
    /// </summary>
    public void ApplyListHeadMovement(ACBindings.Internal.CommandList* list) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CommandInterpreter, ACBindings.Internal.CommandList*, void>)0x006B4450)(ref this, list);

    /// <summary>
    /// <code>Offset: 0x006B44E0
    /// void __thiscall CommandInterpreter::StopListHeadMovement(CommandInterpreter*,const CommandList*)</code>
    /// </summary>
    public void StopListHeadMovement(ACBindings.Internal.CommandList* list) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CommandInterpreter, ACBindings.Internal.CommandList*, void>)0x006B44E0)(ref this, list);

    /// <summary>
    /// <code>Offset: 0x006B4570
    /// int __thiscall CommandInterpreter::HandleSelectLeft(CommandInterpreter*,int)</code>
    /// </summary>
    public int HandleSelectLeft(int start) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CommandInterpreter, int, int>)0x006B4570)(ref this, start);

    /// <summary>
    /// <code>Offset: 0x006B45D0
    /// void __thiscall CommandInterpreter::HandleKeyboardCommand(CommandInterpreter*,CmdStruct*)</code>
    /// </summary>
    public void HandleKeyboardCommand(ACBindings.Internal.CmdStruct* cmdstruct) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CommandInterpreter, ACBindings.Internal.CmdStruct*, void>)0x006B45D0)(ref this, cmdstruct);

    /// <summary>
    /// <code>Offset: 0x006B47B0
    /// void __thiscall CommandInterpreter::HandleMouseMovementCommand(CommandInterpreter*,CmdStruct*)</code>
    /// </summary>
    public void HandleMouseMovementCommand(ACBindings.Internal.CmdStruct* cmdstruct) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CommandInterpreter, ACBindings.Internal.CmdStruct*, void>)0x006B47B0)(ref this, cmdstruct);

    /// <summary>
    /// <code>Offset: 0x006B4890
    /// CommandList* __thiscall CommandInterpreter::WhichList(CommandInterpreter*,unsigned int)</code>
    /// </summary>
    public ACBindings.Internal.CommandList* WhichList(uint cmd) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CommandInterpreter, uint, ACBindings.Internal.CommandList*>)0x006B4890)(ref this, cmd);

    /// <summary>
    /// <code>Offset: 0x006B48E0
    /// void __thiscall CommandInterpreter::AddCommand(CommandInterpreter*,unsigned int,float,int,int)</code>
    /// </summary>
    public void AddCommand(uint cmd, float speed, int mouse, int new_hold_run) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CommandInterpreter, uint, float, int, int, void>)0x006B48E0)(ref this, cmd, speed, mouse, new_hold_run);

    /// <summary>
    /// <code>Offset: 0x006B4960
    /// int __thiscall CommandInterpreter::NukeCommand(CommandInterpreter*,unsigned int*,int*,float*,int*,int*)</code>
    /// </summary>
    public int NukeCommand(uint* cmd, int* start, float* speed, int* mouse, int* new_hold_run) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CommandInterpreter, uint*, int*, float*, int*, int*, int>)0x006B4960)(ref this, cmd, start, speed, mouse, new_hold_run);

    /// <summary>
    /// <code>Offset: 0x006B4A10
    /// int __thiscall CommandInterpreter::BookkeepCommandAndModifyIfNecessary(CommandInterpreter*,unsigned int*,int*,float*,int*,int*)</code>
    /// </summary>
    public int BookkeepCommandAndModifyIfNecessary(uint* cmd, int* start, float* speed, int* mouse, int* new_hold_run) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CommandInterpreter, uint*, int*, float*, int*, int*, int>)0x006B4A10)(ref this, cmd, start, speed, mouse, new_hold_run);

    /// <summary>
    /// <code>Offset: 0x006B4A80
    /// int __thiscall CommandInterpreter::UsePositionFromServer(CommandInterpreter*)</code>
    /// </summary>
    public int UsePositionFromServer() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CommandInterpreter, int>)0x006B4A80)(ref this);

    /// <summary>
    /// <code>Offset: 0x006B4A90
    /// int __thiscall CommandInterpreter::StopCompletely(CommandInterpreter*)</code>
    /// </summary>
    public int StopCompletely() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CommandInterpreter, int>)0x006B4A90)(ref this);

    /// <summary>
    /// <code>Offset: 0x006B4AD0
    /// int __thiscall CommandInterpreter::MaybeStopCompletely(CommandInterpreter*)</code>
    /// </summary>
    public int MaybeStopCompletely() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CommandInterpreter, int>)0x006B4AD0)(ref this);

    /// <summary>
    /// <code>Offset: 0x006B4AF0
    /// int __thiscall CommandInterpreter::SetAutonomyLevel(CommandInterpreter*,unsigned int)</code>
    /// </summary>
    public int SetAutonomyLevel(uint new_level) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CommandInterpreter, uint, int>)0x006B4AF0)(ref this, new_level);

    /// <summary>
    /// <code>Offset: 0x006B4B30
    /// void __thiscall CommandInterpreter::UseTime(CommandInterpreter*)</code>
    /// </summary>
    public void UseTime() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CommandInterpreter, void>)0x006B4B30)(ref this);

    /// <summary>
    /// <code>Offset: 0x006B4BB0
    /// void __thiscall CommandInterpreter::HandleExhaustion(CommandInterpreter*)</code>
    /// </summary>
    public void HandleExhaustion() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CommandInterpreter, void>)0x006B4BB0)(ref this);

    /// <summary>
    /// <code>Offset: 0x006B4BC0
    /// void __thiscall CommandInterpreter::UpdateToggleRun(CommandInterpreter*)</code>
    /// </summary>
    public void UpdateToggleRun() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CommandInterpreter, void>)0x006B4BC0)(ref this);

    /// <summary>
    /// <code>Offset: 0x006B4BE0
    /// int __thiscall CommandInterpreter::IsStandingStill(CommandInterpreter*)</code>
    /// </summary>
    public int IsStandingStill() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CommandInterpreter, int>)0x006B4BE0)(ref this);

    /// <summary>
    /// <code>Offset: 0x006B4C00
    /// void __thiscall CommandInterpreter::ToggleAutoRun(CommandInterpreter*)</code>
    /// </summary>
    public void ToggleAutoRun() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CommandInterpreter, void>)0x006B4C00)(ref this);

    /// <summary>
    /// <code>Offset: 0x006B4C20
    /// int __thiscall CommandInterpreter::IsActive(CommandInterpreter*)</code>
    /// </summary>
    public int IsActive() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CommandInterpreter, int>)0x006B4C20)(ref this);

    /// <summary>
    /// <code>Offset: 0x006B4C40
    /// void __thiscall CommandInterpreter::MovePlayer_NonAutonomous(CommandInterpreter*,unsigned int,int,float,HoldKey)</code>
    /// </summary>
    public void MovePlayer_NonAutonomous(uint cmd, int start, float speed, ACBindings.Internal.HoldKey key) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CommandInterpreter, uint, int, float, ACBindings.Internal.HoldKey, void>)0x006B4C40)(ref this, cmd, start, speed, key);

    /// <summary>
    /// <code>Offset: 0x006B4CA0
    /// void __thiscall CommandInterpreter::HandleNewForwardMovement(CommandInterpreter*)</code>
    /// </summary>
    public void HandleNewForwardMovement() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CommandInterpreter, void>)0x006B4CA0)(ref this);

    /// <summary>
    /// <code>Offset: 0x006B4CB0
    /// int __thiscall CommandInterpreter::PlayerIsDead(CommandInterpreter*)</code>
    /// </summary>
    public int PlayerIsDead() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CommandInterpreter, int>)0x006B4CB0)(ref this);

    /// <summary>
    /// <code>Offset: 0x006B4D80
    /// void __thiscall CommandInterpreter::CommandInterpreter(CommandInterpreter*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CommandInterpreter, void>)0x006B4D80)(ref this);

    /// <summary>
    /// <code>Offset: 0x006B4E80
    /// void __thiscall CommandInterpreter::MovePlayer(CommandInterpreter*,unsigned int,int,float,int,int)</code>
    /// </summary>
    public void MovePlayer(uint cmd, int start, float speed, int mouse, int new_hold_run) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CommandInterpreter, uint, int, float, int, int, void>)0x006B4E80)(ref this, cmd, start, speed, mouse, new_hold_run);

    /// <summary>
    /// <code>Offset: 0x006B5450
    /// void __thiscall CommandInterpreter::StopDrift(CommandInterpreter*)</code>
    /// </summary>
    public void StopDrift() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CommandInterpreter, void>)0x006B5450)(ref this);

    /// <summary>
    /// <code>Offset: 0x006B54B0
    /// int __thiscall CommandInterpreter::TurnToHeading(CommandInterpreter*,float,int)</code>
    /// </summary>
    public int TurnToHeading(float new_heading, int run) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CommandInterpreter, float, int, int>)0x006B54B0)(ref this, new_heading, run);

    /// <summary>
    /// <code>Offset: 0x006B5520
    /// int __thiscall CommandInterpreter::ShouldSendPositionEvent(CommandInterpreter*)</code>
    /// </summary>
    public int ShouldSendPositionEvent() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CommandInterpreter, int>)0x006B5520)(ref this);

    /// <summary>
    /// <code>Offset: 0x006B55C0
    /// void __thiscall CommandInterpreter::SendMovementEvent(CommandInterpreter*)</code>
    /// </summary>
    public void SendMovementEvent() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CommandInterpreter, void>)0x006B55C0)(ref this);

    /// <summary>
    /// <code>Offset: 0x006B56B0
    /// void __thiscall CommandInterpreter::SendPositionEvent(CommandInterpreter*)</code>
    /// </summary>
    public void SendPositionEvent() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CommandInterpreter, void>)0x006B56B0)(ref this);

    /// <summary>
    /// <code>Offset: 0x006B5790
    /// void __thiscall CommandInterpreter::SetAutoRun(CommandInterpreter*,int,int)</code>
    /// </summary>
    public void SetAutoRun(int val, int apply_movement) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CommandInterpreter, int, int, void>)0x006B5790)(ref this, val, apply_movement);
}

