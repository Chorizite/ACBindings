namespace ACBindings.Internal;

public unsafe struct gmMiniGameUI : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.UIElement_Field BaseClass_UIElement_Field; // ACBindings.Internal.UIElement_Field
    public ACBindings.Internal.gmNoticeHandler BaseClass_gmNoticeHandler; // ACBindings.Internal.gmNoticeHandler

    // Child Types
    public unsafe struct gmMiniGameUI_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIListener*, void> UIListener_dtor_0; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIListener*, ACBindings.Internal.InputEvent*, byte> OnAction; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIListener*, uint, uint, uint, ACBindings.Internal.CallbackLoseFocusResult> OnLoseFocus; // function pointer
        public fixed byte gapC[4];
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIListener*, uint, ACBindings.Internal.UIElement*, uint, int, ACBindings.Internal.UIElementMessageListenResult> ListenToElementMessage; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIListener*, uint, int, void> ListenToGlobalMessage; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, byte, void> SetVisible; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, byte, void> SetShouldBlockClicks; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, byte, void> SetShouldEraseBackground; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, uint, void> SetClampGameViewEdge; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, byte> CheckOverOverride; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, int, int, void> MoveTo; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, int, int, void> ResizeTo; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, ACBindings.Internal.Box2D*, ACBindings.Internal.Box2D*> GetSurfaceBox; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, ACBindings.Internal.UIRegion*, int> CompareZLevel; // function pointer
        public System.IntPtr DrawHere;
        public System.IntPtr EraseSelf;
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, ACBindings.Internal.UIRegion*, void> SetParent; // function pointer
        public fixed byte gap48[4];
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, int, int, void> MouseMove; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, byte, void> MouseOver; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, byte, void> MouseOverTop; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, int, int, byte> MouseHover; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, void> MouseUnhover; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, uint, uint, uint, void> MouseDown; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, uint, uint, uint, void> MouseUp; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, byte> HasCursor; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, ACBindings.Internal.UIRegion*, void> AddChild; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, ACBindings.Internal.UIRegion*, void> RemoveChild; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, void> DrawStart; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, ACBindings.Internal.Box2D*, ACBindings.Internal.UISurface*, void> EraseBackground; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, ACBindings.Internal.Box2D*, ACBindings.Internal.UISurface*, void> PreBlit; // function pointer
        public System.IntPtr DrawSelf;
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, ACBindings.Internal.Box2D*, ACBindings.Internal.UISurface*, void> PostBlit; // function pointer
        public System.IntPtr DrawChildren;
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, void> DrawDone; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, uint, uint, uint, void> MouseTap; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, uint, ACBindings.Internal.UIElement*> DynamicCast; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, uint> GetUIElementType; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, uint, byte> SetState; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, ACBindings.Internal.UIElement*> GetParent; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, uint, ACBindings.Internal.UIElement*> GetAncestorByID; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, uint, byte> KeyUp; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, uint, float, byte> KeyDown; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, int, byte> RegisterInputMaps; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, byte> UnregisterInputMaps; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, ACBindings.Internal.UIElement*, ACBindings.Internal.InputEvent*, byte> OnChildAction; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, void> Initialize; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, void> PostInit; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, ACBindings.Internal.AvailablePropertySet*, byte> InqAvailableProperties; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, ACBindings.Internal.BaseProperty*, void> OnSetAttribute; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, uint, byte> ContainsProperty; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, uint, ACBindings.Internal.BaseProperty*, byte> InqProperty; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, ACBindings.Internal.BaseProperty*, byte> SetProperty; // function pointer
        public fixed byte gapD8[4];
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, ACBindings.Internal.UIElement*, ACBindings.Internal.UIElement.FunctionSignatureChanged> CatchDroppedItem; // function pointer
        public fixed byte gapE0[4];
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, ACBindings.Internal.UIElement*, byte, ACBindings.Internal.UIElement.FunctionSignatureChanged> DragAndDropComplete; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, ACBindings.Internal.UIElement**, byte> DragItem; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, ACBindings.Internal.UIElement*, ACBindings.Internal.UIElement*> GetDragAndDropCatcher; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, ACBindings.Internal.UIElement*, void> MatchElement; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, ACBindings.Internal.UIElement*, void> UpdateForChildSizeChange; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, byte, void> UpdateForParentVisibilityChange; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, byte> Activate; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, byte> Deactivate; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, byte> TakeFocus; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, byte> RelinquishFocus; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, byte> GetActivatable; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, byte, void> SetMouseVisible; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, void> UpdateForScreenPositionChange; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, ACBindings.Internal.UIObject*, byte> SetUIObject; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, ACBindings.Internal.UIObject**, byte> MakeUIObject; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, ACBindings.Internal.UIElement*, byte, void> OnChildActivationChanged; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, byte> GetShouldBeMouseVisible; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, ACBindings.Internal.UIElementMessageInfo*, ACBindings.Internal.UIElementMessageListenResult, ACBindings.Internal.UIElementMessageListenResult> ForwardElementMessage; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, ACBindings.Internal.UIElementMessageInfo*, byte> DefElementMessageHandler; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, byte, void> OnVisibilityChanged; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, ACBindings.Internal.UIElement.Intialized_Has_Been_Replaced_With_PostInit> Initialized; // function pointer

        // Methods
    }
    // gmMiniGameUI::GameState
    public enum GameState : byte
    {
        GS_NotPlaying = 0x0,
        GS_AttemptingToJoinGame = 0x1,
        GS_WaitingForGameStart = 0x2,
        GS_PlayingMyTurn = 0x3,
        GS_PlayingTryingToMove = 0x4,
        GS_PlayingNotMyTurn = 0x5
    }

    // Members
    public ACBindings.Internal.UIElement_Button* m_pResignButton;
    public ACBindings.Internal.UIElement_Button* m_pPassButton;
    public ACBindings.Internal.UIElement_Button* m_pStalemateButton;
    public int m_iTeam;
    public uint m_idCurrentGame;
    public ACBindings.Internal.gmMiniGameUI.GameState m_state;
    public int m_fStalemate;
    public ACBindings.Internal.GameBoardGrid* m_pGameBoard;
    public uint m_uiResignDialogContext;

    // Generated Constructor
    public gmMiniGameUI(ACBindings.Internal.LayoutDesc* layout, ACBindings.Internal.ElementDesc* full_desc) {
        _ConstructorInternal(layout, full_desc);
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x004A7F40
    /// void __thiscall gmMiniGameUI::gmMiniGameUI(gmMiniGameUI*,const LayoutDesc*,const ElementDesc*)</code>
    /// </summary>
    public void _ConstructorInternal(ACBindings.Internal.LayoutDesc* layout, ACBindings.Internal.ElementDesc* full_desc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmMiniGameUI, ACBindings.Internal.LayoutDesc*, ACBindings.Internal.ElementDesc*, void>)0x004A7F40)(ref this, layout, full_desc);

    /// <summary>
    /// <code>Offset: 0x004A7FB0
    /// UIElement* __thiscall gmMiniGameUI::DynamicCast(gmMiniGameUI*,unsigned int)</code>
    /// </summary>
    public ACBindings.Internal.UIElement* DynamicCast(uint i_eType) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmMiniGameUI, uint, ACBindings.Internal.UIElement*>)0x004A7FB0)(ref this, i_eType);

    /// <summary>
    /// <code>Offset: 0x004A7FD0
    /// unsigned int __thiscall gmMiniGameUI::GetUIElementType(gmMiniGameUI*)</code>
    /// </summary>
    public uint GetUIElementType() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmMiniGameUI, uint>)0x004A7FD0)(ref this);

    /// <summary>
    /// <code>Offset: 0x004A7FE0
    /// void __thiscall gmMiniGameUI::~gmMiniGameUI(gmMiniGameUI*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmMiniGameUI, void>)0x004A7FE0)(ref this);

    /// <summary>
    /// <code>Offset: 0x004A8070
    /// void __thiscall gmMiniGameUI::RecvNotice_EndGame(gmMiniGameUI*)</code>
    /// </summary>
    public void RecvNotice_EndGame() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmMiniGameUI, void>)0x004A8070)(ref this);

    /// <summary>
    /// <code>Offset: 0x004A8090
    /// bool __thiscall gmMiniGameUI::DoMove(gmMiniGameUI*,int,int,int,int)</code>
    /// </summary>
    public byte DoMove(int x0, int y0, int x1, int y1) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmMiniGameUI, int, int, int, int, byte>)0x004A8090)(ref this, x0, y0, x1, y1);

    /// <summary>
    /// <code>Offset: 0x004A84A0
    /// void __cdecl gmMiniGameUI::Register()</code>
    /// </summary>
    public static void Register() => ((delegate* unmanaged[Cdecl]<void>)0x004A84A0)();

    /// <summary>
    /// <code>Offset: 0x004A94A0
    /// void __thiscall gmMiniGameUI::PostInit(gmMiniGameUI*)</code>
    /// </summary>
    public void PostInit() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmMiniGameUI, void>)0x004A94A0)(ref this);

    /// <summary>
    /// <code>Offset: 0x004A9EF0
    /// void __cdecl gmMiniGameUI::MiniGameQuitDialogCallback(const PropertyCollection*)</code>
    /// </summary>
    public static void MiniGameQuitDialogCallback(ACBindings.Internal.PropertyCollection* i_rcResults) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.PropertyCollection*, void>)0x004A9EF0)(i_rcResults);

    /// <summary>
    /// <code>Offset: 0x004AA000
    /// void __thiscall gmMiniGameUI::RecvNotice_OpponentOffersStalemate(gmMiniGameUI*,unsigned int,int,int)</code>
    /// </summary>
    public void RecvNotice_OpponentOffersStalemate(uint idGame, int iTeam, int fOn) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmMiniGameUI, uint, int, int, void>)0x004AA000)(ref this, idGame, iTeam, fOn);

    /// <summary>
    /// <code>Offset: 0x004AA040
    /// void __thiscall gmMiniGameUI::SetInfoText(gmMiniGameUI*,const char*)</code>
    /// </summary>
    public void SetInfoText(sbyte* szText) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmMiniGameUI, sbyte*, void>)0x004AA040)(ref this, szText);

    /// <summary>
    /// <code>Offset: 0x004AA3E0
    /// void __thiscall gmMiniGameUI::RecvNotice_JoinGameResponse(gmMiniGameUI*,unsigned int,int)</code>
    /// </summary>
    public void RecvNotice_JoinGameResponse(uint idGame, int iTeam) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmMiniGameUI, uint, int, void>)0x004AA3E0)(ref this, idGame, iTeam);

    /// <summary>
    /// <code>Offset: 0x004AA450
    /// void __thiscall gmMiniGameUI::RecvNotice_StartGame(gmMiniGameUI*,unsigned int,int)</code>
    /// </summary>
    public void RecvNotice_StartGame(uint idGame, int iTeam) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmMiniGameUI, uint, int, void>)0x004AA450)(ref this, idGame, iTeam);

    /// <summary>
    /// <code>Offset: 0x004AA4A0
    /// bool __thiscall gmMiniGameUI::TryToJoinGame(gmMiniGameUI*,unsigned int)</code>
    /// </summary>
    public byte TryToJoinGame(uint idGame) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmMiniGameUI, uint, byte>)0x004AA4A0)(ref this, idGame);

    /// <summary>
    /// <code>Offset: 0x004AA5C0
    /// void __thiscall gmMiniGameUI::ShowMoveResult(gmMiniGameUI*,int)</code>
    /// </summary>
    public void ShowMoveResult(int cmr) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmMiniGameUI, int, void>)0x004AA5C0)(ref this, cmr);

    /// <summary>
    /// <code>Offset: 0x004AA850
    /// void __thiscall gmMiniGameUI::ShowOpponentMoveResult(gmMiniGameUI*,int)</code>
    /// </summary>
    public void ShowOpponentMoveResult(int cmr) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmMiniGameUI, int, void>)0x004AA850)(ref this, cmr);

    /// <summary>
    /// <code>Offset: 0x004AA920
    /// void __thiscall gmMiniGameUI::GotoDefaultState(gmMiniGameUI*,const char*)</code>
    /// </summary>
    public void GotoDefaultState(sbyte* szText) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmMiniGameUI, sbyte*, void>)0x004AA920)(ref this, szText);

    /// <summary>
    /// <code>Offset: 0x004AAC10
    /// void __thiscall gmMiniGameUI::RecvNotice_BeginGame(gmMiniGameUI*,unsigned int)</code>
    /// </summary>
    public void RecvNotice_BeginGame(uint idGame) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmMiniGameUI, uint, void>)0x004AAC10)(ref this, idGame);

    /// <summary>
    /// <code>Offset: 0x004AAC40
    /// void __thiscall gmMiniGameUI::RecvNotice_MoveResponse(gmMiniGameUI*,unsigned int,int)</code>
    /// </summary>
    public void RecvNotice_MoveResponse(uint idGame, int iMoveResult) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmMiniGameUI, uint, int, void>)0x004AAC40)(ref this, idGame, iMoveResult);

    /// <summary>
    /// <code>Offset: 0x004AACA0
    /// void __thiscall gmMiniGameUI::RecvNotice_OpponentTurn(gmMiniGameUI*,unsigned int,int,const GameMoveData*)</code>
    /// </summary>
    public void RecvNotice_OpponentTurn(uint idGame, int iTeam, ACBindings.Internal.GameMoveData* move) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmMiniGameUI, uint, int, ACBindings.Internal.GameMoveData*, void>)0x004AACA0)(ref this, idGame, iTeam, move);

    /// <summary>
    /// <code>Offset: 0x004AACD0
    /// void __thiscall gmMiniGameUI::RecvNotice_GameOver(gmMiniGameUI*,unsigned int,int)</code>
    /// </summary>
    public void RecvNotice_GameOver(uint idGame, int iTeamWinner) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmMiniGameUI, uint, int, void>)0x004AACD0)(ref this, idGame, iTeamWinner);

    /// <summary>
    /// <code>Offset: 0x004AADB0
    /// UIElementMessageListenResult __thiscall gmMiniGameUI::ListenToElementMessage(gmMiniGameUI*,const UIElementMessageInfo*)</code>
    /// </summary>
    public ACBindings.Internal.UIElementMessageListenResult ListenToElementMessage(ACBindings.Internal.UIElementMessageInfo* i_rMsg) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmMiniGameUI, ACBindings.Internal.UIElementMessageInfo*, ACBindings.Internal.UIElementMessageListenResult>)0x004AADB0)(ref this, i_rMsg);

    /// <summary>
    /// <code>Offset: 0x004AB050
    /// void __thiscall gmMiniGameUI::RecvNotice_TryToQuitGame(gmMiniGameUI*,bool)</code>
    /// </summary>
    public void RecvNotice_TryToQuitGame(byte bQuitting) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmMiniGameUI, byte, void>)0x004AB050)(ref this, bQuitting);
}

