namespace ACBindings.Internal;

public unsafe struct ACCmdInterp : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.CommandInterpreter BaseClass_CommandInterpreter; // ACBindings.Internal.CommandInterpreter
    public ACBindings.Internal.gmNoticeHandler BaseClass_gmNoticeHandler; // ACBindings.Internal.gmNoticeHandler

    // Child Types
    public unsafe struct ACCmdInterp_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ACCmdInterp*, void> ACCmdInterp_dtor_0; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ACCmdInterp*, ACBindings.Internal.InputEvent*, byte> OnAction; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ACCmdInterp*, uint, uint, uint, ACBindings.Internal.CallbackLoseFocusResult> OnLoseFocus; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ACCmdInterp*, uint, ACBindings.Internal.CommandList*> WhichList; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ACCmdInterp*, uint, float, int, int, void> AddCommand; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ACCmdInterp*, uint*, int*, float*, int*, int*, int> NukeCommand; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ACCmdInterp*, uint*, int*, float*, int*, int*, int> BookkeepCommandAndModifyIfNecessary; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ACCmdInterp*, void> ApplyCurrentMovement; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ACCmdInterp*, int, void> SetHoldRun; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ACCmdInterp*, int, void> SetHoldSidestep; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ACCmdInterp*, void> ClearAllCommands; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ACCmdInterp*, ACBindings.Internal.CommandList*, void> ApplyListHeadMovement; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ACCmdInterp*, ACBindings.Internal.CommandList*, void> StopListHeadMovement; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ACCmdInterp*, uint*, float*, void> ApplyHoldKeysToCommand; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ACCmdInterp*, uint, int, float, ACBindings.Internal.HoldKey, void> MovePlayer_NonAutonomous; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ACCmdInterp*, int> UITogglesRun; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ACCmdInterp*, void> CommenceJump; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ACCmdInterp*, byte, void> DoJump; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ACCmdInterp*, void> HandleNewForwardMovement; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ACCmdInterp*, void> SendMovementEvent; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ACCmdInterp*, void> FinishJump; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ACCmdInterp*, System.IntPtr, System.IntPtr, void> SetUI; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ACCmdInterp*, void> SendPositionEvent; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ACCmdInterp*, ACBindings.Internal.SmartBox*, void> SetSmartBox; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ACCmdInterp*, int> UsePositionFromServer; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ACCmdInterp*, void> LoseControlToServer; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ACCmdInterp*, void> TakeControlFromServer; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ACCmdInterp*, int, void> NewPlayer; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ACCmdInterp*, void> LoseKeyboardFocus; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ACCmdInterp*, void> PlayerTeleported; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ACCmdInterp*, int> PlayerIsDead; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ACCmdInterp*, void> HandleExhaustion; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ACCmdInterp*, void> UpdateToggleRun; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ACCmdInterp*, void> Disable; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ACCmdInterp*, void> Enable; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ACCmdInterp*, int> IsEnabled; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ACCmdInterp*, int> IsActive; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ACCmdInterp*, void> HandleLogOff; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ACCmdInterp*, ACBindings.Internal.CmdStruct*, void> HandleKeyboardCommand; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ACCmdInterp*, ACBindings.Internal.CmdStruct*, void> HandleMouseMovementCommand; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ACCmdInterp*, uint, int, float, int, int, void> MovePlayer; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ACCmdInterp*, void> StopDrift; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ACCmdInterp*, void> UseTime; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ACCmdInterp*, int> ShouldSendPositionEvent; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ACCmdInterp*, uint, int> SetAutonomyLevel; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ACCmdInterp*, uint> GetAutonomyLevel; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ACCmdInterp*, int> IsStandingStill; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ACCmdInterp*, int> StopCompletely; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ACCmdInterp*, int> MaybeStopCompletely; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ACCmdInterp*, float, int, int> TurnToHeading; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ACCmdInterp*, void> ToggleAutoRun; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ACCmdInterp*, int, int, void> SetAutoRun; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ACCmdInterp*, int, void> SetMouseLookActive; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ACCmdInterp*, int> GetMouseLookActive; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ACCmdInterp*, int, int> HandleSelectLeft; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ACCmdInterp*, int, void> SetMouseLeftDown; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ACCmdInterp*, int> GetMouseLeftDown; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ACCmdInterp*, uint, int> SendAutonomyLevelEvent; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ACCmdInterp*, uint, float, ACBindings.Internal.HoldKey, int> SendDoMovementEvent; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ACCmdInterp*, uint, ACBindings.Internal.HoldKey, int> SendStopMovementEvent; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ACCmdInterp*, ACBindings.Internal.MoveToStatePack*, int> SendMoveToStateEvent; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ACCmdInterp*, ACBindings.Internal.AutonomousPositionPack*, int> SendAutonomousPositionEvent; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ACCmdInterp*, ACBindings.Internal.TurnToEventPack*, int> SendTurnToEvent; // function pointer

        // Methods
    }

    // Members
    public ACBindings.Internal.HashTable__uint__uint m_hashEmoteInputActionsToCommands;

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x0058BF90
    /// void __thiscall ACCmdInterp::TakeControlFromServer(ACCmdInterp*)</code>
    /// </summary>
    public void TakeControlFromServer() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCmdInterp, void>)0x0058BF90)(ref this);

    /// <summary>
    /// <code>Offset: 0x0058BFB0
    /// int __thiscall ACCmdInterp::UITogglesRun(ACCmdInterp*)</code>
    /// </summary>
    public int UITogglesRun() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCmdInterp, int>)0x0058BFB0)(ref this);

    /// <summary>
    /// <code>Offset: 0x0058BFD0
    /// void __thiscall ACCmdInterp::CommenceJump(ACCmdInterp*)</code>
    /// </summary>
    public void CommenceJump() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCmdInterp, void>)0x0058BFD0)(ref this);

    /// <summary>
    /// <code>Offset: 0x0058BFF0
    /// void __thiscall ACCmdInterp::DoJump(ACCmdInterp*,bool)</code>
    /// </summary>
    public void DoJump(byte autonomous) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCmdInterp, byte, void>)0x0058BFF0)(ref this, autonomous);

    /// <summary>
    /// <code>Offset: 0x0058C000
    /// void __thiscall ACCmdInterp::FinishJump(ACCmdInterp*)</code>
    /// </summary>
    public void FinishJump() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCmdInterp, void>)0x0058C000)(ref this);

    /// <summary>
    /// <code>Offset: 0x0058C020
    /// void __thiscall ACCmdInterp::HandleNewForwardMovement(ACCmdInterp*)</code>
    /// </summary>
    public void HandleNewForwardMovement() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCmdInterp, void>)0x0058C020)(ref this);

    /// <summary>
    /// <code>Offset: 0x0058C040
    /// int __thiscall ACCmdInterp::SendAutonomyLevelEvent(ACCmdInterp*,unsigned int)</code>
    /// </summary>
    public int SendAutonomyLevelEvent(uint level) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCmdInterp, uint, int>)0x0058C040)(ref this, level);

    /// <summary>
    /// <code>Offset: 0x0058C060
    /// int __thiscall ACCmdInterp::SendDoMovementEvent(ACCmdInterp*,unsigned int,float,HoldKey)</code>
    /// </summary>
    public int SendDoMovementEvent(uint motion, float speed, ACBindings.Internal.HoldKey hold_key) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCmdInterp, uint, float, ACBindings.Internal.HoldKey, int>)0x0058C060)(ref this, motion, speed, hold_key);

    /// <summary>
    /// <code>Offset: 0x0058C080
    /// int __thiscall ACCmdInterp::SendStopMovementEvent(ACCmdInterp*,unsigned int,HoldKey)</code>
    /// </summary>
    public int SendStopMovementEvent(uint motion, ACBindings.Internal.HoldKey hold_key) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCmdInterp, uint, ACBindings.Internal.HoldKey, int>)0x0058C080)(ref this, motion, hold_key);

    /// <summary>
    /// <code>Offset: 0x0058C0A0
    /// int __thiscall ACCmdInterp::SendMoveToStateEvent(ACCmdInterp*,MoveToStatePack*)</code>
    /// </summary>
    public int SendMoveToStateEvent(ACBindings.Internal.MoveToStatePack* mtsp) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCmdInterp, ACBindings.Internal.MoveToStatePack*, int>)0x0058C0A0)(ref this, mtsp);

    /// <summary>
    /// <code>Offset: 0x0058C0C0
    /// int __thiscall ACCmdInterp::SendAutonomousPositionEvent(ACCmdInterp*,AutonomousPositionPack*)</code>
    /// </summary>
    public int SendAutonomousPositionEvent(ACBindings.Internal.AutonomousPositionPack* app) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCmdInterp, ACBindings.Internal.AutonomousPositionPack*, int>)0x0058C0C0)(ref this, app);

    /// <summary>
    /// <code>Offset: 0x0058C0E0
    /// int __thiscall ACCmdInterp::SendTurnToEvent(ACCmdInterp*,TurnToEventPack*)</code>
    /// </summary>
    public int SendTurnToEvent(ACBindings.Internal.TurnToEventPack* tep) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCmdInterp, ACBindings.Internal.TurnToEventPack*, int>)0x0058C0E0)(ref this, tep);

    /// <summary>
    /// <code>Offset: 0x0058C100
    /// void __thiscall ACCmdInterp::RecvNotice_PlayerOptionChanged(ACCmdInterp*,PlayerOption)</code>
    /// </summary>
    public void RecvNotice_PlayerOptionChanged(ACBindings.Internal.PlayerOption i_eOption) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCmdInterp, ACBindings.Internal.PlayerOption, void>)0x0058C100)(ref this, i_eOption);

    /// <summary>
    /// <code>Offset: 0x0058C140
    /// void __thiscall ACCmdInterp::SetMotion(ACCmdInterp*,unsigned int,bool)</code>
    /// </summary>
    public void SetMotion(uint motion, byte fOn) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCmdInterp, uint, byte, void>)0x0058C140)(ref this, motion, fOn);

    /// <summary>
    /// <code>Offset: 0x0058C1A0
    /// bool __thiscall ACCmdInterp::OnAction(ACCmdInterp*,const InputEvent*)</code>
    /// </summary>
    public byte OnAction(ACBindings.Internal.InputEvent* i_evt) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCmdInterp, ACBindings.Internal.InputEvent*, byte>)0x0058C1A0)(ref this, i_evt);

    /// <summary>
    /// <code>Offset: 0x0058C340
    /// void __thiscall ACCmdInterp::InitializeEmoteInputActionHash(ACCmdInterp*)</code>
    /// </summary>
    public void InitializeEmoteInputActionHash() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCmdInterp, void>)0x0058C340)(ref this);

    /// <summary>
    /// <code>Offset: 0x0058CA10
    /// void __thiscall ACCmdInterp::~ACCmdInterp(ACCmdInterp*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCmdInterp, void>)0x0058CA10)(ref this);
}

