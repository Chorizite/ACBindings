namespace ACBindings;

// gmMiniGameUI
public unsafe struct gmMiniGameUI : System.IDisposable
{
    // Base Classes
    public ACBindings.UIElement_Field BaseClass_UIElement_Field; // ACBindings.UIElement_Field
    public ACBindings.gmNoticeHandler BaseClass_gmNoticeHandler; // ACBindings.gmNoticeHandler

    // Child Types
    // gmMiniGameUI_vtbl
    public unsafe struct gmMiniGameUI_vtbl
    {
        // Members
        public System.IntPtr UIListener_dtor_0; // function pointer
        public System.IntPtr OnAction; // function pointer
        public System.IntPtr OnLoseFocus; // function pointer
        public fixed byte gapC[4];
        public System.IntPtr ListenToElementMessage; // function pointer
        public System.IntPtr ListenToGlobalMessage; // function pointer
        public System.IntPtr SetVisible; // function pointer
        public System.IntPtr SetShouldBlockClicks; // function pointer
        public System.IntPtr SetShouldEraseBackground; // function pointer
        public System.IntPtr SetClampGameViewEdge; // function pointer
        public System.IntPtr CheckOverOverride; // function pointer
        public System.IntPtr MoveTo; // function pointer
        public System.IntPtr ResizeTo; // function pointer
        public System.IntPtr GetSurfaceBox; // function pointer
        public System.IntPtr CompareZLevel; // function pointer
        public System.IntPtr DrawHere;
        public System.IntPtr EraseSelf;
        public System.IntPtr SetParent; // function pointer
        public fixed byte gap48[4];
        public System.IntPtr MouseMove; // function pointer
        public System.IntPtr MouseOver; // function pointer
        public System.IntPtr MouseOverTop; // function pointer
        public System.IntPtr MouseHover; // function pointer
        public System.IntPtr MouseUnhover; // function pointer
        public System.IntPtr MouseDown; // function pointer
        public System.IntPtr MouseUp; // function pointer
        public System.IntPtr HasCursor; // function pointer
        public System.IntPtr AddChild; // function pointer
        public System.IntPtr RemoveChild; // function pointer
        public System.IntPtr DrawStart; // function pointer
        public System.IntPtr EraseBackground; // function pointer
        public System.IntPtr PreBlit; // function pointer
        public System.IntPtr DrawSelf;
        public System.IntPtr PostBlit; // function pointer
        public System.IntPtr DrawChildren;
        public System.IntPtr DrawDone; // function pointer
        public System.IntPtr MouseTap; // function pointer
        public System.IntPtr DynamicCast; // function pointer
        public System.IntPtr GetUIElementType; // function pointer
        public System.IntPtr SetState; // function pointer
        public System.IntPtr GetParent; // function pointer
        public System.IntPtr GetAncestorByID; // function pointer
        public System.IntPtr KeyUp; // function pointer
        public System.IntPtr KeyDown; // function pointer
        public System.IntPtr RegisterInputMaps; // function pointer
        public System.IntPtr UnregisterInputMaps; // function pointer
        public System.IntPtr OnChildAction; // function pointer
        public System.IntPtr Initialize; // function pointer
        public System.IntPtr PostInit; // function pointer
        public System.IntPtr InqAvailableProperties; // function pointer
        public System.IntPtr OnSetAttribute; // function pointer
        public System.IntPtr ContainsProperty; // function pointer
        public System.IntPtr InqProperty; // function pointer
        public System.IntPtr SetProperty; // function pointer
        public fixed byte gapD8[4];
        public System.IntPtr CatchDroppedItem; // function pointer
        public fixed byte gapE0[4];
        public System.IntPtr DragAndDropComplete; // function pointer
        public System.IntPtr DragItem; // function pointer
        public System.IntPtr GetDragAndDropCatcher; // function pointer
        public System.IntPtr MatchElement; // function pointer
        public System.IntPtr UpdateForChildSizeChange; // function pointer
        public System.IntPtr UpdateForParentVisibilityChange; // function pointer
        public System.IntPtr Activate; // function pointer
        public System.IntPtr Deactivate; // function pointer
        public System.IntPtr TakeFocus; // function pointer
        public System.IntPtr RelinquishFocus; // function pointer
        public System.IntPtr GetActivatable; // function pointer
        public System.IntPtr SetMouseVisible; // function pointer
        public System.IntPtr UpdateForScreenPositionChange; // function pointer
        public System.IntPtr SetUIObject; // function pointer
        public System.IntPtr MakeUIObject; // function pointer
        public System.IntPtr OnChildActivationChanged; // function pointer
        public System.IntPtr GetShouldBeMouseVisible; // function pointer
        public System.IntPtr ForwardElementMessage; // function pointer
        public System.IntPtr DefElementMessageHandler; // function pointer
        public System.IntPtr OnVisibilityChanged; // function pointer
        public System.IntPtr Initialized; // function pointer

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
    public ACBindings.UIElement_Button* m_pResignButton;
    public ACBindings.UIElement_Button* m_pPassButton;
    public ACBindings.UIElement_Button* m_pStalemateButton;
    public int m_iTeam;
    public uint m_idCurrentGame;
    public ACBindings.gmMiniGameUI.GameState m_state;
    public int m_fStalemate;
    public ACBindings.GameBoardGrid* m_pGameBoard;
    public uint m_uiResignDialogContext;

    // Generated Constructor
    public gmMiniGameUI(ACBindings.LayoutDesc* layout, ACBindings.ElementDesc* full_desc) {
        _ConstructorInternal(layout, full_desc);
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods
    // void __thiscall gmMiniGameUI::gmMiniGameUI(gmMiniGameUI*,const LayoutDesc*,const ElementDesc*)
    public void _ConstructorInternal(ACBindings.LayoutDesc* layout, ACBindings.ElementDesc* full_desc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmMiniGameUI, ACBindings.LayoutDesc*, ACBindings.ElementDesc*, void>)0x004A7F40)(ref this, layout, full_desc);
    // UIElement* __thiscall gmMiniGameUI::DynamicCast(gmMiniGameUI*,unsigned int)
    public ACBindings.UIElement* DynamicCast(uint i_eType) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmMiniGameUI, uint, ACBindings.UIElement*>)0x004A7FB0)(ref this, i_eType);
    // unsigned int __thiscall gmMiniGameUI::GetUIElementType(gmMiniGameUI*)
    public uint GetUIElementType() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmMiniGameUI, uint>)0x004A7FD0)(ref this);
    // void __thiscall gmMiniGameUI::~gmMiniGameUI(gmMiniGameUI*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmMiniGameUI, void>)0x004A7FE0)(ref this);
    // void __thiscall gmMiniGameUI::RecvNotice_EndGame(gmMiniGameUI*)
    public void RecvNotice_EndGame() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmMiniGameUI, void>)0x004A8070)(ref this);
    // bool __thiscall gmMiniGameUI::DoMove(gmMiniGameUI*,int,int,int,int)
    public byte DoMove(int x0, int y0, int x1, int y1) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmMiniGameUI, int, int, int, int, byte>)0x004A8090)(ref this, x0, y0, x1, y1);
    // void __cdecl gmMiniGameUI::Register()
    public static void Register() => ((delegate* unmanaged[Cdecl]<void>)0x004A84A0)();
    // void __thiscall gmMiniGameUI::PostInit(gmMiniGameUI*)
    public void PostInit() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmMiniGameUI, void>)0x004A94A0)(ref this);
    // void __cdecl gmMiniGameUI::MiniGameQuitDialogCallback(const PropertyCollection*)
    public static void MiniGameQuitDialogCallback(ACBindings.PropertyCollection* i_rcResults) => ((delegate* unmanaged[Cdecl]<ACBindings.PropertyCollection*, void>)0x004A9EF0)(i_rcResults);
    // void __thiscall gmMiniGameUI::RecvNotice_OpponentOffersStalemate(gmMiniGameUI*,unsigned int,int,int)
    public void RecvNotice_OpponentOffersStalemate(uint idGame, int iTeam, int fOn) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmMiniGameUI, uint, int, int, void>)0x004AA000)(ref this, idGame, iTeam, fOn);
    // void __thiscall gmMiniGameUI::SetInfoText(gmMiniGameUI*,const char*)
    public void SetInfoText(sbyte* szText) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmMiniGameUI, sbyte*, void>)0x004AA040)(ref this, szText);
    // void __thiscall gmMiniGameUI::RecvNotice_JoinGameResponse(gmMiniGameUI*,unsigned int,int)
    public void RecvNotice_JoinGameResponse(uint idGame, int iTeam) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmMiniGameUI, uint, int, void>)0x004AA3E0)(ref this, idGame, iTeam);
    // void __thiscall gmMiniGameUI::RecvNotice_StartGame(gmMiniGameUI*,unsigned int,int)
    public void RecvNotice_StartGame(uint idGame, int iTeam) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmMiniGameUI, uint, int, void>)0x004AA450)(ref this, idGame, iTeam);
    // bool __thiscall gmMiniGameUI::TryToJoinGame(gmMiniGameUI*,unsigned int)
    public byte TryToJoinGame(uint idGame) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmMiniGameUI, uint, byte>)0x004AA4A0)(ref this, idGame);
    // void __thiscall gmMiniGameUI::ShowMoveResult(gmMiniGameUI*,int)
    public void ShowMoveResult(int cmr) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmMiniGameUI, int, void>)0x004AA5C0)(ref this, cmr);
    // void __thiscall gmMiniGameUI::ShowOpponentMoveResult(gmMiniGameUI*,int)
    public void ShowOpponentMoveResult(int cmr) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmMiniGameUI, int, void>)0x004AA850)(ref this, cmr);
    // void __thiscall gmMiniGameUI::GotoDefaultState(gmMiniGameUI*,const char*)
    public void GotoDefaultState(sbyte* szText) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmMiniGameUI, sbyte*, void>)0x004AA920)(ref this, szText);
    // void __thiscall gmMiniGameUI::RecvNotice_BeginGame(gmMiniGameUI*,unsigned int)
    public void RecvNotice_BeginGame(uint idGame) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmMiniGameUI, uint, void>)0x004AAC10)(ref this, idGame);
    // void __thiscall gmMiniGameUI::RecvNotice_MoveResponse(gmMiniGameUI*,unsigned int,int)
    public void RecvNotice_MoveResponse(uint idGame, int iMoveResult) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmMiniGameUI, uint, int, void>)0x004AAC40)(ref this, idGame, iMoveResult);
    // void __thiscall gmMiniGameUI::RecvNotice_OpponentTurn(gmMiniGameUI*,unsigned int,int,const GameMoveData*)
    public void RecvNotice_OpponentTurn(uint idGame, int iTeam, ACBindings.GameMoveData* move) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmMiniGameUI, uint, int, ACBindings.GameMoveData*, void>)0x004AACA0)(ref this, idGame, iTeam, move);
    // void __thiscall gmMiniGameUI::RecvNotice_GameOver(gmMiniGameUI*,unsigned int,int)
    public void RecvNotice_GameOver(uint idGame, int iTeamWinner) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmMiniGameUI, uint, int, void>)0x004AACD0)(ref this, idGame, iTeamWinner);
    // UIElementMessageListenResult __thiscall gmMiniGameUI::ListenToElementMessage(gmMiniGameUI*,const UIElementMessageInfo*)
    public ACBindings.UIElementMessageListenResult ListenToElementMessage(ACBindings.UIElementMessageInfo* i_rMsg) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmMiniGameUI, ACBindings.UIElementMessageInfo*, ACBindings.UIElementMessageListenResult>)0x004AADB0)(ref this, i_rMsg);
    // void __thiscall gmMiniGameUI::RecvNotice_TryToQuitGame(gmMiniGameUI*,bool)
    public void RecvNotice_TryToQuitGame(byte bQuitting) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmMiniGameUI, byte, void>)0x004AB050)(ref this, bQuitting);
}

