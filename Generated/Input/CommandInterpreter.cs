namespace ACBindings;

// CommandInterpreter
public unsafe struct CommandInterpreter
{
    // Base Classes
    public ACBindings.IInputActionCallback BaseClass_IInputActionCallback; // ACBindings.IInputActionCallback

    // Child Types
    // CommandInterpreter_vtbl
    public unsafe struct CommandInterpreter_vtbl
    {
        // Members
        public System.IntPtr CommandInterpreter_dtor_0; // function pointer
        public System.IntPtr OnAction; // function pointer
        public System.IntPtr OnLoseFocus; // function pointer
        public System.IntPtr WhichList; // function pointer
        public System.IntPtr AddCommand; // function pointer
        public System.IntPtr NukeCommand; // function pointer
        public System.IntPtr BookkeepCommandAndModifyIfNecessary; // function pointer
        public System.IntPtr ApplyCurrentMovement; // function pointer
        public System.IntPtr SetHoldRun; // function pointer
        public System.IntPtr SetHoldSidestep; // function pointer
        public System.IntPtr ClearAllCommands; // function pointer
        public System.IntPtr ApplyListHeadMovement; // function pointer
        public System.IntPtr StopListHeadMovement; // function pointer
        public System.IntPtr ApplyHoldKeysToCommand; // function pointer
        public System.IntPtr MovePlayer_NonAutonomous; // function pointer
        public System.IntPtr UITogglesRun; // function pointer
        public System.IntPtr CommenceJump; // function pointer
        public System.IntPtr DoJump; // function pointer
        public System.IntPtr HandleNewForwardMovement; // function pointer
        public System.IntPtr SendMovementEvent; // function pointer
        public System.IntPtr FinishJump; // function pointer
        public System.IntPtr SetUI; // function pointer
        public System.IntPtr SendPositionEvent; // function pointer
        public System.IntPtr SetSmartBox; // function pointer
        public System.IntPtr UsePositionFromServer; // function pointer
        public System.IntPtr LoseControlToServer; // function pointer
        public System.IntPtr TakeControlFromServer; // function pointer
        public System.IntPtr NewPlayer; // function pointer
        public System.IntPtr LoseKeyboardFocus; // function pointer
        public System.IntPtr PlayerTeleported; // function pointer
        public System.IntPtr PlayerIsDead; // function pointer
        public System.IntPtr HandleExhaustion; // function pointer
        public System.IntPtr UpdateToggleRun; // function pointer
        public System.IntPtr Disable; // function pointer
        public System.IntPtr Enable; // function pointer
        public System.IntPtr IsEnabled; // function pointer
        public System.IntPtr IsActive; // function pointer
        public System.IntPtr HandleLogOff; // function pointer
        public System.IntPtr HandleKeyboardCommand; // function pointer
        public System.IntPtr HandleMouseMovementCommand; // function pointer
        public System.IntPtr MovePlayer; // function pointer
        public System.IntPtr StopDrift; // function pointer
        public System.IntPtr UseTime; // function pointer
        public System.IntPtr ShouldSendPositionEvent; // function pointer
        public System.IntPtr SetAutonomyLevel; // function pointer
        public System.IntPtr GetAutonomyLevel; // function pointer
        public System.IntPtr IsStandingStill; // function pointer
        public System.IntPtr StopCompletely; // function pointer
        public System.IntPtr MaybeStopCompletely; // function pointer
        public System.IntPtr TurnToHeading; // function pointer
        public System.IntPtr ToggleAutoRun; // function pointer
        public System.IntPtr SetAutoRun; // function pointer
        public System.IntPtr SetMouseLookActive; // function pointer
        public System.IntPtr GetMouseLookActive; // function pointer
        public System.IntPtr HandleSelectLeft; // function pointer
        public System.IntPtr SetMouseLeftDown; // function pointer
        public System.IntPtr GetMouseLeftDown; // function pointer
        public System.IntPtr SendAutonomyLevelEvent; // function pointer
        public System.IntPtr SendDoMovementEvent; // function pointer
        public System.IntPtr SendStopMovementEvent; // function pointer
        public System.IntPtr SendMoveToStateEvent; // function pointer
        public System.IntPtr SendAutonomousPositionEvent; // function pointer
        public System.IntPtr SendTurnToEvent; // function pointer

        // Methods
    }

    // Members
    public ACBindings.SmartBox* smartbox;
    public ACBindings.CPhysicsObj* player;
    public ACBindings.CommandList SubstateList;
    public ACBindings.CommandList TurnList;
    public ACBindings.CommandList SidestepList;
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
    public ACBindings.Position last_sent_position;
    public ACBindings.Plane last_sent_contact_plane;
    public double time_between_position_events;

    // Generated Constructor
    public CommandInterpreter() {
        _ConstructorInternal();
    }

    // Methods
    // int __thiscall CommandInterpreter::IsEnabled(CommandInterpreter*)
    public int IsEnabled() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CommandInterpreter, int>)0x0058C9C0)(ref this);
    // void __thiscall CommandInterpreter::SetMouseLookActive(CommandInterpreter*,int)
    public void SetMouseLookActive(int active) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CommandInterpreter, int, void>)0x0058C9D0)(ref this, active);
    // int __thiscall CommandInterpreter::GetMouseLookActive(CommandInterpreter*)
    public int GetMouseLookActive() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CommandInterpreter, int>)0x0058C9E0)(ref this);
    // void __thiscall CommandInterpreter::SetMouseLeftDown(CommandInterpreter*,int)
    public void SetMouseLeftDown(int active) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CommandInterpreter, int, void>)0x0058C9F0)(ref this, active);
    // int __thiscall CommandInterpreter::GetMouseLeftDown(CommandInterpreter*)
    public int GetMouseLeftDown() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CommandInterpreter, int>)0x0058CA00)(ref this);
    // void __thiscall CommandInterpreter::SetSmartBox(CommandInterpreter*,SmartBox*)
    public void SetSmartBox(ACBindings.SmartBox* i_smartbox) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CommandInterpreter, ACBindings.SmartBox*, void>)0x006B4080)(ref this, i_smartbox);
    // void __thiscall CommandInterpreter::LoseControlToServer(CommandInterpreter*)
    public void LoseControlToServer() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CommandInterpreter, void>)0x006B40B0)(ref this);
    // void __thiscall CommandInterpreter::ClearAllCommands(CommandInterpreter*)
    public void ClearAllCommands() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CommandInterpreter, void>)0x006B40E0)(ref this);
    // void __thiscall CommandInterpreter::NewPlayer(CommandInterpreter*,int)
    public void NewPlayer(int autonomous_movement) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CommandInterpreter, int, void>)0x006B4100)(ref this, autonomous_movement);
    // void __thiscall CommandInterpreter::LoseKeyboardFocus(CommandInterpreter*)
    public void LoseKeyboardFocus() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CommandInterpreter, void>)0x006B4130)(ref this);
    // void __thiscall CommandInterpreter::Disable(CommandInterpreter*)
    public void Disable() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CommandInterpreter, void>)0x006B4190)(ref this);
    // void __thiscall CommandInterpreter::Enable(CommandInterpreter*)
    public void Enable() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CommandInterpreter, void>)0x006B41D0)(ref this);
    // void __thiscall CommandInterpreter::PlayerTeleported(CommandInterpreter*)
    public void PlayerTeleported() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CommandInterpreter, void>)0x006B41F0)(ref this);
    // void __thiscall CommandInterpreter::TakeControlFromServer(CommandInterpreter*)
    public void TakeControlFromServer() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CommandInterpreter, void>)0x006B4210)(ref this);
    // void __thiscall CommandInterpreter::HandleLogOff(CommandInterpreter*)
    public void HandleLogOff() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CommandInterpreter, void>)0x006B4270)(ref this);
    // void __thiscall CommandInterpreter::ApplyHoldKeysToCommand(CommandInterpreter*,unsigned int*,float*)
    public void ApplyHoldKeysToCommand(uint* cmd, float* speed) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CommandInterpreter, uint*, float*, void>)0x006B4280)(ref this, cmd, speed);
    // void __thiscall CommandInterpreter::SetHoldRun(CommandInterpreter*,int)
    public void SetHoldRun(int new_value) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CommandInterpreter, int, void>)0x006B42B0)(ref this, new_value);
    // void __thiscall CommandInterpreter::SetHoldSidestep(CommandInterpreter*,int)
    public void SetHoldSidestep(int new_value) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CommandInterpreter, int, void>)0x006B4350)(ref this, new_value);
    // void __thiscall CommandInterpreter::ApplyCurrentMovement(CommandInterpreter*)
    public void ApplyCurrentMovement() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CommandInterpreter, void>)0x006B4370)(ref this);
    // void __thiscall CommandInterpreter::ApplyListHeadMovement(CommandInterpreter*,const CommandList*)
    public void ApplyListHeadMovement(ACBindings.CommandList* list) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CommandInterpreter, ACBindings.CommandList*, void>)0x006B4450)(ref this, list);
    // void __thiscall CommandInterpreter::StopListHeadMovement(CommandInterpreter*,const CommandList*)
    public void StopListHeadMovement(ACBindings.CommandList* list) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CommandInterpreter, ACBindings.CommandList*, void>)0x006B44E0)(ref this, list);
    // int __thiscall CommandInterpreter::HandleSelectLeft(CommandInterpreter*,int)
    public int HandleSelectLeft(int start) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CommandInterpreter, int, int>)0x006B4570)(ref this, start);
    // void __thiscall CommandInterpreter::HandleKeyboardCommand(CommandInterpreter*,CmdStruct*)
    public void HandleKeyboardCommand(ACBindings.CmdStruct* cmdstruct) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CommandInterpreter, ACBindings.CmdStruct*, void>)0x006B45D0)(ref this, cmdstruct);
    // void __thiscall CommandInterpreter::HandleMouseMovementCommand(CommandInterpreter*,CmdStruct*)
    public void HandleMouseMovementCommand(ACBindings.CmdStruct* cmdstruct) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CommandInterpreter, ACBindings.CmdStruct*, void>)0x006B47B0)(ref this, cmdstruct);
    // CommandList* __thiscall CommandInterpreter::WhichList(CommandInterpreter*,unsigned int)
    public ACBindings.CommandList* WhichList(uint cmd) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CommandInterpreter, uint, ACBindings.CommandList*>)0x006B4890)(ref this, cmd);
    // void __thiscall CommandInterpreter::AddCommand(CommandInterpreter*,unsigned int,float,int,int)
    public void AddCommand(uint cmd, float speed, int mouse, int new_hold_run) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CommandInterpreter, uint, float, int, int, void>)0x006B48E0)(ref this, cmd, speed, mouse, new_hold_run);
    // int __thiscall CommandInterpreter::NukeCommand(CommandInterpreter*,unsigned int*,int*,float*,int*,int*)
    public int NukeCommand(uint* cmd, int* start, float* speed, int* mouse, int* new_hold_run) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CommandInterpreter, uint*, int*, float*, int*, int*, int>)0x006B4960)(ref this, cmd, start, speed, mouse, new_hold_run);
    // int __thiscall CommandInterpreter::BookkeepCommandAndModifyIfNecessary(CommandInterpreter*,unsigned int*,int*,float*,int*,int*)
    public int BookkeepCommandAndModifyIfNecessary(uint* cmd, int* start, float* speed, int* mouse, int* new_hold_run) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CommandInterpreter, uint*, int*, float*, int*, int*, int>)0x006B4A10)(ref this, cmd, start, speed, mouse, new_hold_run);
    // int __thiscall CommandInterpreter::UsePositionFromServer(CommandInterpreter*)
    public int UsePositionFromServer() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CommandInterpreter, int>)0x006B4A80)(ref this);
    // int __thiscall CommandInterpreter::StopCompletely(CommandInterpreter*)
    public int StopCompletely() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CommandInterpreter, int>)0x006B4A90)(ref this);
    // int __thiscall CommandInterpreter::MaybeStopCompletely(CommandInterpreter*)
    public int MaybeStopCompletely() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CommandInterpreter, int>)0x006B4AD0)(ref this);
    // int __thiscall CommandInterpreter::SetAutonomyLevel(CommandInterpreter*,unsigned int)
    public int SetAutonomyLevel(uint new_level) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CommandInterpreter, uint, int>)0x006B4AF0)(ref this, new_level);
    // void __thiscall CommandInterpreter::UseTime(CommandInterpreter*)
    public void UseTime() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CommandInterpreter, void>)0x006B4B30)(ref this);
    // void __thiscall CommandInterpreter::HandleExhaustion(CommandInterpreter*)
    public void HandleExhaustion() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CommandInterpreter, void>)0x006B4BB0)(ref this);
    // void __thiscall CommandInterpreter::UpdateToggleRun(CommandInterpreter*)
    public void UpdateToggleRun() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CommandInterpreter, void>)0x006B4BC0)(ref this);
    // int __thiscall CommandInterpreter::IsStandingStill(CommandInterpreter*)
    public int IsStandingStill() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CommandInterpreter, int>)0x006B4BE0)(ref this);
    // void __thiscall CommandInterpreter::ToggleAutoRun(CommandInterpreter*)
    public void ToggleAutoRun() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CommandInterpreter, void>)0x006B4C00)(ref this);
    // int __thiscall CommandInterpreter::IsActive(CommandInterpreter*)
    public int IsActive() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CommandInterpreter, int>)0x006B4C20)(ref this);
    // void __thiscall CommandInterpreter::MovePlayer_NonAutonomous(CommandInterpreter*,unsigned int,int,float,HoldKey)
    public void MovePlayer_NonAutonomous(uint cmd, int start, float speed, ACBindings.HoldKey key) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CommandInterpreter, uint, int, float, ACBindings.HoldKey, void>)0x006B4C40)(ref this, cmd, start, speed, key);
    // void __thiscall CommandInterpreter::HandleNewForwardMovement(CommandInterpreter*)
    public void HandleNewForwardMovement() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CommandInterpreter, void>)0x006B4CA0)(ref this);
    // int __thiscall CommandInterpreter::PlayerIsDead(CommandInterpreter*)
    public int PlayerIsDead() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CommandInterpreter, int>)0x006B4CB0)(ref this);
    // void __thiscall CommandInterpreter::CommandInterpreter(CommandInterpreter*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CommandInterpreter, void>)0x006B4D80)(ref this);
    // void __thiscall CommandInterpreter::MovePlayer(CommandInterpreter*,unsigned int,int,float,int,int)
    public void MovePlayer(uint cmd, int start, float speed, int mouse, int new_hold_run) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CommandInterpreter, uint, int, float, int, int, void>)0x006B4E80)(ref this, cmd, start, speed, mouse, new_hold_run);
    // void __thiscall CommandInterpreter::StopDrift(CommandInterpreter*)
    public void StopDrift() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CommandInterpreter, void>)0x006B5450)(ref this);
    // int __thiscall CommandInterpreter::TurnToHeading(CommandInterpreter*,float,int)
    public int TurnToHeading(float new_heading, int run) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CommandInterpreter, float, int, int>)0x006B54B0)(ref this, new_heading, run);
    // int __thiscall CommandInterpreter::ShouldSendPositionEvent(CommandInterpreter*)
    public int ShouldSendPositionEvent() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CommandInterpreter, int>)0x006B5520)(ref this);
    // void __thiscall CommandInterpreter::SendMovementEvent(CommandInterpreter*)
    public void SendMovementEvent() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CommandInterpreter, void>)0x006B55C0)(ref this);
    // void __thiscall CommandInterpreter::SendPositionEvent(CommandInterpreter*)
    public void SendPositionEvent() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CommandInterpreter, void>)0x006B56B0)(ref this);
    // void __thiscall CommandInterpreter::SetAutoRun(CommandInterpreter*,int,int)
    public void SetAutoRun(int val, int apply_movement) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CommandInterpreter, int, int, void>)0x006B5790)(ref this, val, apply_movement);
}

