namespace ACBindings.Internal;


/// <summary>
/// Manages the user interface for a mini‑game, coordinating player actions, board updates, and server notifications while tracking current game state.
/// </summary>
public unsafe struct gmMiniGameUI : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.UIElement_Field BaseClass_UIElement_Field; // ACBindings.Internal.UIElement_Field
    public ACBindings.Internal.gmNoticeHandler BaseClass_gmNoticeHandler; // ACBindings.Internal.gmNoticeHandler

    // Child Types
    public unsafe struct gmMiniGameUI_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIListener*, void> UIListener_dtor_0; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIListener*, ACBindings.Internal.InputEvent*, byte> OnAction; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIListener*, uint, uint, uint, ACBindings.Internal.CallbackLoseFocusResult> OnLoseFocus; // function pointer
        public fixed byte gapC[4];
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIListener*, uint, ACBindings.Internal.UIElement*, uint, int, ACBindings.Internal.UIElementMessageListenResult> ListenToElementMessage; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIListener*, uint, int, void> ListenToGlobalMessage; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, byte, void> SetVisible; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, byte, void> SetShouldBlockClicks; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, byte, void> SetShouldEraseBackground; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, uint, void> SetClampGameViewEdge; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, byte> CheckOverOverride; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, int, int, void> MoveTo; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, int, int, void> ResizeTo; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, ACBindings.Internal.Box2D*, ACBindings.Internal.Box2D*> GetSurfaceBox; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, ACBindings.Internal.UIRegion*, int> CompareZLevel; // function pointer
        public System.IntPtr DrawHere;
        public System.IntPtr EraseSelf;
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, ACBindings.Internal.UIRegion*, void> SetParent; // function pointer
        public fixed byte gap48[4];
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, int, int, void> MouseMove; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, byte, void> MouseOver; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, byte, void> MouseOverTop; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, int, int, byte> MouseHover; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, void> MouseUnhover; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, uint, uint, uint, void> MouseDown; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, uint, uint, uint, void> MouseUp; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, byte> HasCursor; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, ACBindings.Internal.UIRegion*, void> AddChild; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, ACBindings.Internal.UIRegion*, void> RemoveChild; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, void> DrawStart; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, ACBindings.Internal.Box2D*, ACBindings.Internal.UISurface*, void> EraseBackground; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, ACBindings.Internal.Box2D*, ACBindings.Internal.UISurface*, void> PreBlit; // function pointer
        public System.IntPtr DrawSelf;
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, ACBindings.Internal.Box2D*, ACBindings.Internal.UISurface*, void> PostBlit; // function pointer
        public System.IntPtr DrawChildren;
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, void> DrawDone; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, uint, uint, uint, void> MouseTap; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, uint, ACBindings.Internal.UIElement*> DynamicCast; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, uint> GetUIElementType; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, uint, byte> SetState; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, ACBindings.Internal.UIElement*> GetParent; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, uint, ACBindings.Internal.UIElement*> GetAncestorByID; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, uint, byte> KeyUp; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, uint, float, byte> KeyDown; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, int, byte> RegisterInputMaps; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, byte> UnregisterInputMaps; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, ACBindings.Internal.UIElement*, ACBindings.Internal.InputEvent*, byte> OnChildAction; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, void> Initialize; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, void> PostInit; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, ACBindings.Internal.AvailablePropertySet*, byte> InqAvailableProperties; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, ACBindings.Internal.BaseProperty*, void> OnSetAttribute; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, uint, byte> ContainsProperty; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, uint, ACBindings.Internal.BaseProperty*, byte> InqProperty; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, ACBindings.Internal.BaseProperty*, byte> SetProperty; // function pointer
        public fixed byte gapD8[4];
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, ACBindings.Internal.UIElement*, ACBindings.Internal.UIElement.FunctionSignatureChanged> CatchDroppedItem; // function pointer
        public fixed byte gapE0[4];
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, ACBindings.Internal.UIElement*, byte, ACBindings.Internal.UIElement.FunctionSignatureChanged> DragAndDropComplete; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, ACBindings.Internal.UIElement**, byte> DragItem; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, ACBindings.Internal.UIElement*, ACBindings.Internal.UIElement*> GetDragAndDropCatcher; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, ACBindings.Internal.UIElement*, void> MatchElement; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, ACBindings.Internal.UIElement*, void> UpdateForChildSizeChange; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, byte, void> UpdateForParentVisibilityChange; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, byte> Activate; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, byte> Deactivate; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, byte> TakeFocus; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, byte> RelinquishFocus; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, byte> GetActivatable; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, byte, void> SetMouseVisible; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, void> UpdateForScreenPositionChange; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, ACBindings.Internal.UIObject*, byte> SetUIObject; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, ACBindings.Internal.UIObject**, byte> MakeUIObject; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, ACBindings.Internal.UIElement*, byte, void> OnChildActivationChanged; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, byte> GetShouldBeMouseVisible; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, ACBindings.Internal.UIElementMessageInfo*, ACBindings.Internal.UIElementMessageListenResult, ACBindings.Internal.UIElementMessageListenResult> ForwardElementMessage; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, ACBindings.Internal.UIElementMessageInfo*, byte> DefElementMessageHandler; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, byte, void> OnVisibilityChanged; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, ACBindings.Internal.UIElement.Intialized_Has_Been_Replaced_With_PostInit> Initialized; // function pointer

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

    /// <summary>Initializes a new instance of the mini‑game UI component, setting up its visual layout and internal state for gameplay interaction.
    /// <code>Offset: 0x004A7F40
    /// void __thiscall gmMiniGameUI::gmMiniGameUI(gmMiniGameUI*,const LayoutDesc*,const ElementDesc*)</code>
    /// </summary>
    /// <param name="layout">The layout configuration describing display dimensions and element arrangement.</param>
    /// <param name="full_desc">Full element description providing detailed properties for each UI component.</param>
    public void _ConstructorInternal(ACBindings.Internal.LayoutDesc* layout, ACBindings.Internal.ElementDesc* full_desc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmMiniGameUI, ACBindings.Internal.LayoutDesc*, ACBindings.Internal.ElementDesc*, void>)0x004A7F40)(ref this, layout, full_desc);

    /// <summary>Attempts to cast a gmMiniGameUI instance to the UI element type specified by i_eType, returning a matching UIElement pointer or null when unsupported.
    /// <code>Offset: 0x004A7FB0
    /// UIElement* __thiscall gmMiniGameUI::DynamicCast(gmMiniGameUI*,unsigned int)</code>
    /// </summary>
    /// <param name="i_eType">Identifier of the desired UI element type used for the dynamic cast.</param>
    /// <returns>A UIElement pointer if the requested type matches the object's capabilities; otherwise null.</returns>
    public ACBindings.Internal.UIElement* DynamicCast(uint i_eType) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmMiniGameUI, uint, ACBindings.Internal.UIElement*>)0x004A7FB0)(ref this, i_eType);

    /// <summary>Retrieves the UI element type identifier for this mini‑game UI instance.
    /// <code>Offset: 0x004A7FD0
    /// unsigned int __thiscall gmMiniGameUI::GetUIElementType(gmMiniGameUI*)</code>
    /// </summary>
    /// <returns>An unsigned integer that uniquely identifies the UI element type.</returns>
    public uint GetUIElementType() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmMiniGameUI, uint>)0x004A7FD0)(ref this);

    /// <summary>Destroys a gmMiniGameUI instance by releasing its game board, unregistering event handlers, and invoking base class destructors to clean up UI elements and notice handling resources.
    /// <code>Offset: 0x004A7FE0
    /// void __thiscall gmMiniGameUI::~gmMiniGameUI(gmMiniGameUI*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmMiniGameUI, void>)0x004A7FE0)(ref this);

    /// <summary>Calls the internal callback that handles an end‑game notice for the mini‑game UI instance.
    /// <code>Offset: 0x004A8070
    /// void __thiscall gmMiniGameUI::RecvNotice_EndGame(gmMiniGameUI*)</code>
    /// </summary>
    public void RecvNotice_EndGame() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmMiniGameUI, void>)0x004A8070)(ref this);

    /// <summary>Initiates a move from (x0, y0) to (x1, y1), notifying the game engine and updating the UI state to indicate an ongoing move attempt.
    /// <code>Offset: 0x004A8090
    /// bool __thiscall gmMiniGameUI::DoMove(gmMiniGameUI*,int,int,int,int)</code>
    /// </summary>
    /// <param name="x0">Source X coordinate of the piece or board cell.</param>
    /// <param name="y0">Source Y coordinate of the piece or board cell.</param>
    /// <param name="x1">Destination X coordinate for the piece.</param>
    /// <param name="y1">Destination Y coordinate for the piece.</param>
    /// <returns>True if the move request was successfully dispatched; always true in this implementation.</returns>
    public byte DoMove(int x0, int y0, int x1, int y1) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmMiniGameUI, int, int, int, int, byte>)0x004A8090)(ref this, x0, y0, x1, y1);

    /// <summary>Registers the mini‑game UI element class with the UI system so it can be instantiated by layout descriptors.
    /// <code>Offset: 0x004A84A0
    /// void __cdecl gmMiniGameUI::Register()</code>
    /// </summary>
    public static void Register() => ((delegate* unmanaged[Cdecl]<void>)0x004A84A0)();

    /// <summary>Initializes the mini‑game UI by locating its action buttons, registering event handlers for global notices, and constructing the game board component.
    /// <code>Offset: 0x004A94A0
    /// void __thiscall gmMiniGameUI::PostInit(gmMiniGameUI*)</code>
    /// </summary>
    public void PostInit() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmMiniGameUI, void>)0x004A94A0)(ref this);

    /// <summary>Processes the result of a mini‑game quit confirmation dialog. Determines whether the user selected “quit”, notifies the game system, and updates any associated reference counters.
    /// <code>Offset: 0x004A9EF0
    /// void __cdecl gmMiniGameUI::MiniGameQuitDialogCallback(const PropertyCollection*)</code>
    /// </summary>
    /// <param name="i_rcResults">Property collection returned from the dialog containing the user's choice (property ID 146 indicates the quit decision).</param>
    public static void MiniGameQuitDialogCallback(ACBindings.Internal.PropertyCollection* i_rcResults) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.PropertyCollection*, void>)0x004A9EF0)(i_rcResults);

    /// <summary>Handles an opponent's stalemate offer or withdrawal by updating the client UI with an appropriate message.
    /// <code>Offset: 0x004AA000
    /// void __thiscall gmMiniGameUI::RecvNotice_OpponentOffersStalemate(gmMiniGameUI*,unsigned int,int,int)</code>
    /// </summary>
    /// <param name="idGame">Identifier of the game to which this notice applies.</param>
    /// <param name="iTeam">Index of the team involved (unused internally).</param>
    /// <param name="fOn">Non‑zero if the opponent is offering stalemate; zero if retracting the offer.</param>
    public void RecvNotice_OpponentOffersStalemate(uint idGame, int iTeam, int fOn) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmMiniGameUI, uint, int, int, void>)0x004AA000)(ref this, idGame, iTeam, fOn);

    /// <summary>Adds the provided text to the mini‑game interface’s scrolling information area, converting from ANSI to Unicode before insertion.
    /// <code>Offset: 0x004AA040
    /// void __thiscall gmMiniGameUI::SetInfoText(gmMiniGameUI*,const char*)</code>
    /// </summary>
    /// <param name="szText">The null‑terminated string containing the message to display.</param>
    public void SetInfoText(sbyte* szText) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmMiniGameUI, sbyte*, void>)0x004AA040)(ref this, szText);

    /// <summary>Handles the server response for attempting to join a mini‑game, updating UI text and internal state based on success or failure.
    /// <code>Offset: 0x004AA3E0
    /// void __thiscall gmMiniGameUI::RecvNotice_JoinGameResponse(gmMiniGameUI*,unsigned int,int)</code>
    /// </summary>
    /// <param name="idGame">Identifier of the game the player attempted to join.</param>
    /// <param name="iTeam">Team index chosen by the player; a value of –1 indicates that joining was rejected.</param>
    public void RecvNotice_JoinGameResponse(uint idGame, int iTeam) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmMiniGameUI, uint, int, void>)0x004AA3E0)(ref this, idGame, iTeam);

    /// <summary>Handles the start‑game notification from the server, updating the interface to show whether the local player begins immediately or must wait for an opponent.
    /// <code>Offset: 0x004AA450
    /// void __thiscall gmMiniGameUI::RecvNotice_StartGame(gmMiniGameUI*,unsigned int,int)</code>
    /// </summary>
    /// <param name="idGame">Identifier of the game session that has started.</param>
    /// <param name="iTeam">Team number assigned to the local player; used to determine turn order.</param>
    public void RecvNotice_StartGame(uint idGame, int iTeam) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmMiniGameUI, uint, int, void>)0x004AA450)(ref this, idGame, iTeam);

    /// <summary>Attempts to join the specified mini‑game, updating UI state and notifying the system.
    /// <code>Offset: 0x004AA4A0
    /// bool __thiscall gmMiniGameUI::TryToJoinGame(gmMiniGameUI*,unsigned int)</code>
    /// </summary>
    /// <param name="idGame">The unique identifier of the game to join.</param>
    /// <returns>True if a join attempt was initiated; false if already in that game or another active game.</returns>
    public byte TryToJoinGame(uint idGame) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmMiniGameUI, uint, byte>)0x004AA4A0)(ref this, idGame);

    /// <summary>Displays a user-facing message describing the outcome of a chess-like move based on a status code, handling errors, check, and check‑mate scenarios.
    /// <code>Offset: 0x004AA5C0
    /// void __thiscall gmMiniGameUI::ShowMoveResult(gmMiniGameUI*,int)</code>
    /// </summary>
    /// <param name="cmr">A result code indicating success, failure reasons (negative values), or game state flags such as check or check‑mate.</param>
    public void ShowMoveResult(int cmr) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmMiniGameUI, int, void>)0x004AA5C0)(ref this, cmr);

    /// <summary>Displays the outcome of the opponent’s most recent move on the mini‑game UI, updating the info text to indicate a checkmate or that it is the player’s turn.
    /// <code>Offset: 0x004AA850
    /// void __thiscall gmMiniGameUI::ShowOpponentMoveResult(gmMiniGameUI*,int)</code>
    /// </summary>
    /// <param name="cmr">Bitmask of move result flags; bit 0x800 denotes checkmate, bit 0x400 denotes being in check.</param>
    public void ShowOpponentMoveResult(int cmr) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmMiniGameUI, int, void>)0x004AA850)(ref this, cmr);

    /// <summary>Reset the mini‑game UI to its default state, clearing any current game data and resetting board status.
    /// <code>Offset: 0x004AA920
    /// void __thiscall gmMiniGameUI::GotoDefaultState(gmMiniGameUI*,const char*)</code>
    /// </summary>
    /// <param name="szText">Optional text displayed in the info area after the reset.</param>
    public void GotoDefaultState(sbyte* szText) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmMiniGameUI, sbyte*, void>)0x004AA920)(ref this, szText);

    /// <summary>Handles a begin‑game notice by initiating a join request for the specified mini‑game.
    /// <code>Offset: 0x004AAC10
    /// void __thiscall gmMiniGameUI::RecvNotice_BeginGame(gmMiniGameUI*,unsigned int)</code>
    /// </summary>
    /// <param name="idGame">Identifier of the game that has started and should be joined.</param>
    public void RecvNotice_BeginGame(uint idGame) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmMiniGameUI, uint, void>)0x004AAC10)(ref this, idGame);

    /// <summary>Handles a move response for the current mini‑game session, updating board state and UI based on success or failure.
    /// <code>Offset: 0x004AAC40
    /// void __thiscall gmMiniGameUI::RecvNotice_MoveResponse(gmMiniGameUI*,unsigned int,int)</code>
    /// </summary>
    /// <param name="idGame">Identifier of the game to which the response applies; processed only if it matches the active game.</param>
    /// <param name="iMoveResult">Result code from the move; non‑positive values trigger an undo, while positive values commit the move and prompt waiting for the opponent.</param>
    public void RecvNotice_MoveResponse(uint idGame, int iMoveResult) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmMiniGameUI, uint, int, void>)0x004AAC40)(ref this, idGame, iMoveResult);

    /// <summary>Updates the mini‑game board with the opponent’s move when a turn notice is received for the active game.
    /// <code>Offset: 0x004AACA0
    /// void __thiscall gmMiniGameUI::RecvNotice_OpponentTurn(gmMiniGameUI*,unsigned int,int,const GameMoveData*)</code>
    /// </summary>
    /// <param name="idGame">Identifier of the game from which the notice was sent.</param>
    /// <param name="iTeam">Index of the team that just made a move (currently unused by this routine).</param>
    /// <param name="move">Pointer to a structure containing data about the opponent’s move to apply to the board.</param>
    public void RecvNotice_OpponentTurn(uint idGame, int iTeam, ACBindings.Internal.GameMoveData* move) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmMiniGameUI, uint, int, ACBindings.Internal.GameMoveData*, void>)0x004AACA0)(ref this, idGame, iTeam, move);

    /// <summary>Handles a game‑over notification by composing an appropriate message based on the winner indicator and displays it before resetting the UI to its default state.
    /// <code>Offset: 0x004AACD0
    /// void __thiscall gmMiniGameUI::RecvNotice_GameOver(gmMiniGameUI*,unsigned int,int)</code>
    /// </summary>
    /// <param name="idGame">Identifier of the finished game.</param>
    /// <param name="iTeamWinner">
    /// Specifies the outcome: –2 indicates that the end‑game notice should be sent, –1 denotes a stalemate, a value equal to the local player’s team ID signals victory, and any other value indicates defeat.
    /// </param>
    public void RecvNotice_GameOver(uint idGame, int iTeamWinner) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmMiniGameUI, uint, int, void>)0x004AACD0)(ref this, idGame, iTeamWinner);

    /// <summary>Handles UI element messages for the mini‑game interface, reacting to button clicks (resign, pass, stalemate) and delegating mouse presses on the game board to the underlying grid component.
    /// <code>Offset: 0x004AADB0
    /// UIElementMessageListenResult __thiscall gmMiniGameUI::ListenToElementMessage(gmMiniGameUI*,const UIElementMessageInfo*)</code>
    /// </summary>
    /// <param name="i_rMsg">Information about the received message, including element ID, message type, parameters, and coordinates.</param>
    /// <returns>UIElementMessageListenResult indicating whether the message was handled; the function forwards unprocessed messages to the base UI element implementation after performing any custom actions.</returns>
    public ACBindings.Internal.UIElementMessageListenResult ListenToElementMessage(ACBindings.Internal.UIElementMessageInfo* i_rMsg) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmMiniGameUI, ACBindings.Internal.UIElementMessageInfo*, ACBindings.Internal.UIElementMessageListenResult>)0x004AADB0)(ref this, i_rMsg);

    /// <summary>Processes a quit attempt from the player, notifying the system of a game exit and resetting the UI to its default state if a current game exists.
    /// <code>Offset: 0x004AB050
    /// void __thiscall gmMiniGameUI::RecvNotice_TryToQuitGame(gmMiniGameUI*,bool)</code>
    /// </summary>
    /// <param name="bQuitting">True when the player confirms quitting; otherwise false.</param>
    public void RecvNotice_TryToQuitGame(byte bQuitting) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmMiniGameUI, byte, void>)0x004AB050)(ref this, bQuitting);
}

