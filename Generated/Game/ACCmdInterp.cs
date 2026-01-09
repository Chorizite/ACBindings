namespace ACBindings;

// ACCmdInterp
public unsafe struct ACCmdInterp : System.IDisposable
{
    // Base Classes
    public ACBindings.CommandInterpreter BaseClass_CommandInterpreter; // ACBindings.CommandInterpreter
    public ACBindings.gmNoticeHandler BaseClass_gmNoticeHandler; // ACBindings.gmNoticeHandler

    // Child Types
    // ACCmdInterp_vtbl
    public unsafe struct ACCmdInterp_vtbl
    {
        // Members
        public System.IntPtr ACCmdInterp_dtor_0; // function pointer
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
    public ACBindings.HashTable__uint__uint m_hashEmoteInputActionsToCommands;

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods
    // void __thiscall ACCmdInterp::TakeControlFromServer(ACCmdInterp*)
    public void TakeControlFromServer() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ACCmdInterp, void>)0x0058BF90)(ref this);
    // int __thiscall ACCmdInterp::UITogglesRun(ACCmdInterp*)
    public int UITogglesRun() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ACCmdInterp, int>)0x0058BFB0)(ref this);
    // void __thiscall ACCmdInterp::CommenceJump(ACCmdInterp*)
    public void CommenceJump() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ACCmdInterp, void>)0x0058BFD0)(ref this);
    // void __thiscall ACCmdInterp::DoJump(ACCmdInterp*,bool)
    public void DoJump(byte autonomous) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ACCmdInterp, byte, void>)0x0058BFF0)(ref this, autonomous);
    // void __thiscall ACCmdInterp::FinishJump(ACCmdInterp*)
    public void FinishJump() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ACCmdInterp, void>)0x0058C000)(ref this);
    // void __thiscall ACCmdInterp::HandleNewForwardMovement(ACCmdInterp*)
    public void HandleNewForwardMovement() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ACCmdInterp, void>)0x0058C020)(ref this);
    // int __thiscall ACCmdInterp::SendAutonomyLevelEvent(ACCmdInterp*,unsigned int)
    public int SendAutonomyLevelEvent(uint level) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ACCmdInterp, uint, int>)0x0058C040)(ref this, level);
    // int __thiscall ACCmdInterp::SendDoMovementEvent(ACCmdInterp*,unsigned int,float,HoldKey)
    public int SendDoMovementEvent(uint motion, float speed, ACBindings.HoldKey hold_key) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ACCmdInterp, uint, float, ACBindings.HoldKey, int>)0x0058C060)(ref this, motion, speed, hold_key);
    // int __thiscall ACCmdInterp::SendStopMovementEvent(ACCmdInterp*,unsigned int,HoldKey)
    public int SendStopMovementEvent(uint motion, ACBindings.HoldKey hold_key) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ACCmdInterp, uint, ACBindings.HoldKey, int>)0x0058C080)(ref this, motion, hold_key);
    // int __thiscall ACCmdInterp::SendMoveToStateEvent(ACCmdInterp*,MoveToStatePack*)
    public int SendMoveToStateEvent(ACBindings.MoveToStatePack* mtsp) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ACCmdInterp, ACBindings.MoveToStatePack*, int>)0x0058C0A0)(ref this, mtsp);
    // int __thiscall ACCmdInterp::SendAutonomousPositionEvent(ACCmdInterp*,AutonomousPositionPack*)
    public int SendAutonomousPositionEvent(ACBindings.AutonomousPositionPack* app) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ACCmdInterp, ACBindings.AutonomousPositionPack*, int>)0x0058C0C0)(ref this, app);
    // int __thiscall ACCmdInterp::SendTurnToEvent(ACCmdInterp*,TurnToEventPack*)
    public int SendTurnToEvent(ACBindings.TurnToEventPack* tep) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ACCmdInterp, ACBindings.TurnToEventPack*, int>)0x0058C0E0)(ref this, tep);
    // void __thiscall ACCmdInterp::RecvNotice_PlayerOptionChanged(ACCmdInterp*,PlayerOption)
    public void RecvNotice_PlayerOptionChanged(ACBindings.PlayerOption i_eOption) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ACCmdInterp, ACBindings.PlayerOption, void>)0x0058C100)(ref this, i_eOption);
    // void __thiscall ACCmdInterp::SetMotion(ACCmdInterp*,unsigned int,bool)
    public void SetMotion(uint motion, byte fOn) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ACCmdInterp, uint, byte, void>)0x0058C140)(ref this, motion, fOn);
    // bool __thiscall ACCmdInterp::OnAction(ACCmdInterp*,const InputEvent*)
    public byte OnAction(ACBindings.InputEvent* i_evt) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ACCmdInterp, ACBindings.InputEvent*, byte>)0x0058C1A0)(ref this, i_evt);
    // void __thiscall ACCmdInterp::InitializeEmoteInputActionHash(ACCmdInterp*)
    public void InitializeEmoteInputActionHash() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ACCmdInterp, void>)0x0058C340)(ref this);
    // void __thiscall ACCmdInterp::~ACCmdInterp(ACCmdInterp*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ACCmdInterp, void>)0x0058CA10)(ref this);
}

