namespace ACBindings.Internal;


/// <summary>Represents the chess board grid used by the mini‑game UI, managing piece placement, movement logic, and visual updates of the 8×8 board while maintaining a snapshot for undo operations.</summary>
public unsafe struct GameBoardGrid
{
    // Base Classes
    public ACBindings.Internal.CChessLogic___CBasePiece BaseClass_CChessLogic; // ACBindings.Internal.CChessLogic___CBasePiece

    // Child Types
    public unsafe struct GameBoardGrid_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.GameBoardGrid*, void> GameBoardGrid_dtor_0; // function pointer
        public System.IntPtr MovePiece;
        public System.IntPtr AttackPiece;

        // Methods
    }

    // Members
    public ACBindings.Internal.gmMiniGameUI* m_gameUI;
    public ACBindings.Internal.UIElement_ListBox* m_pieceListBox;
    public ACBindings.Internal.IDClass____tagDataID m_didWhitePawn;
    public ACBindings.Internal.IDClass____tagDataID m_didWhiteRook;
    public ACBindings.Internal.IDClass____tagDataID m_didWhiteBishop;
    public ACBindings.Internal.IDClass____tagDataID m_didWhiteKnight;
    public ACBindings.Internal.IDClass____tagDataID m_didWhiteQueen;
    public ACBindings.Internal.IDClass____tagDataID m_didWhiteKing;
    public ACBindings.Internal.IDClass____tagDataID m_didBlackPawn;
    public ACBindings.Internal.IDClass____tagDataID m_didBlackRook;
    public ACBindings.Internal.IDClass____tagDataID m_didBlackBishop;
    public ACBindings.Internal.IDClass____tagDataID m_didBlackKnight;
    public ACBindings.Internal.IDClass____tagDataID m_didBlackQueen;
    public ACBindings.Internal.IDClass____tagDataID m_didBlackKing;
    public fixed byte m_rgPreviousBoard_Raw[64 * 4];
    public System.IntPtr* m_rgPreviousBoard => (System.IntPtr*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref m_rgPreviousBoard_Raw[0]);
    public ACBindings.Internal.TCoord m_coordSelected;

    // Generated Constructor
    public GameBoardGrid(ACBindings.Internal.gmMiniGameUI* gameUI) {
        _ConstructorInternal(gameUI);
    }

    // Methods

    /// <summary>Copies the current board configuration into the backup buffer, preparing for a new move.
    /// <code>Offset: 0x004A7EE0
    /// void __thiscall GameBoardGrid::PrepareNewMove(GameBoardGrid*)</code>
    /// </summary>
    public void PrepareNewMove() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.GameBoardGrid, void>)0x004A7EE0)(ref this);

    /// <summary>Updates the visual representation of a chess board grid, assigning piece icons and highlighting the currently selected square based on the current game state.
    /// <code>Offset: 0x004A80C0
    /// void __thiscall GameBoardGrid::Draw(GameBoardGrid*)</code>
    /// </summary>
    public void Draw() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.GameBoardGrid, void>)0x004A80C0)(ref this);

    /// <summary>Restores the chessboard to its previous state by copying each square’s piece back from a stored snapshot and then redraws the board.
    /// <code>Offset: 0x004A8410
    /// void __thiscall GameBoardGrid::UndoMoves(GameBoardGrid*)</code>
    /// </summary>
    public void UndoMoves() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.GameBoardGrid, void>)0x004A8410)(ref this);

    /// <summary>Retrieves the data identifier for a chess piece based on its type and source ID, updating the supplied IDClass instance. If no matching piece exists, assigns an invalid identifier.
    /// <code>Offset: 0x004A84C0
    /// IDClass&lt;_tagDataID,32,0&gt;* __stdcall GameBoardGrid::GetPieceDID(IDClass&lt;_tagDataID,32,0&gt;*,int,unsigned int)</code>
    /// </summary>
    /// <param name="a1">IDClass to receive the resulting data identifier.</param>
    /// <param name="a2">Piece index or type used in the lookup.</param>
    /// <param name="id">Source identifier for the piece; used as a key in the search.</param>
    /// <returns>Pointer to the updated IDClass instance (the same as <c>a1</c>).</returns>
    public static ACBindings.Internal.IDClass____tagDataID* GetPieceDID(ACBindings.Internal.IDClass____tagDataID* a1, int a2, uint id) => ((delegate* unmanaged[Stdcall]<ACBindings.Internal.IDClass____tagDataID*, int, uint, ACBindings.Internal.IDClass____tagDataID*>)0x004A84C0)(a1, a2, id);

    /// <summary>Finalizes the current move by removing captured pieces from the previous board state, clearing temporary board data, resetting selection coordinates, and redrawing the board.
    /// <code>Offset: 0x004A8E10
    /// void __thiscall GameBoardGrid::CommitMoves(GameBoardGrid*)</code>
    /// </summary>
    public void CommitMoves() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.GameBoardGrid, void>)0x004A8E10)(ref this);

    /// <summary>Removes all chess pieces from the grid and resets internal tracking structures.
    /// <code>Offset: 0x004A8EC0
    /// void __thiscall GameBoardGrid::ClearAllPieces(GameBoardGrid*)</code>
    /// </summary>
    public void ClearAllPieces() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.GameBoardGrid, void>)0x004A8EC0)(ref this);

    /// <summary>Initializes a new GameBoardGrid instance, linking it to the supplied gmMiniGameUI and setting up the internal board representation, the piece selection UI, and resource identifiers for each chess piece type.
    /// <code>Offset: 0x004A8F50
    /// void __thiscall GameBoardGrid::GameBoardGrid(GameBoardGrid*,gmMiniGameUI*)</code>
    /// </summary>
    /// <param name="gameUI">Reference to the mini‑game user interface that owns this grid.</param>
    public void _ConstructorInternal(ACBindings.Internal.gmMiniGameUI* gameUI) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.GameBoardGrid, ACBindings.Internal.gmMiniGameUI*, void>)0x004A8F50)(ref this, gameUI);

    /// <summary>Create a chess piece of the specified type for the given player and place it at coordinate (x,y) on the board.
    /// <code>Offset: 0x004A9180
    /// void __thiscall GameBoardGrid::CreatePiece(GameBoardGrid*,int,int,int,ChessPieceType)</code>
    /// </summary>
    /// <param name="x">X-coordinate on the board where the new piece will be positioned.</param>
    /// <param name="y">Y-coordinate on the board where the new piece will be positioned.</param>
    /// <param name="iPlayer">Index of the player owning the piece (0 for white, 1 for black).</param>
    /// <param name="type">The type of chess piece to create (e.g., Pawn, Rook, Knight, etc.).</param>
    public void CreatePiece(int x, int y, int iPlayer, ACBindings.Internal.ChessPieceType type) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.GameBoardGrid, int, int, int, ACBindings.Internal.ChessPieceType, void>)0x004A9180)(ref this, x, y, iPlayer, type);

    /// <summary>Reinitializes the board with a standard chess opening layout, removing all current pieces and creating new ones in their initial squares.
    /// <code>Offset: 0x004A9630
    /// void __thiscall GameBoardGrid::Reset(GameBoardGrid*)</code>
    /// </summary>
    public void Reset() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.GameBoardGrid, void>)0x004A9630)(ref this);

    /// <summary>Promotes the pawn located at (x, y) to a queen of the appropriate color and updates the board state accordingly.
    /// <code>Offset: 0x004AA090
    /// ChessMoveResult __thiscall GameBoardGrid::DoPromotion(GameBoardGrid*,int,int,ChessMoveResult)</code>
    /// </summary>
    /// <param name="x">The file coordinate (0‑7) of the promotion square on the board.</param>
    /// <param name="y">The rank coordinate (0‑7) of the promotion square on the board.</param>
    /// <param name="result">An existing ChessMoveResult that will be combined with any new check status resulting from the promotion.</param>
    /// <returns>An updated ChessMoveResult reflecting the outcome of the promotion and whether it places the opponent in check.</returns>
    public ACBindings.Internal.ChessMoveResult DoPromotion(int x, int y, ACBindings.Internal.ChessMoveResult result) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.GameBoardGrid, int, int, ACBindings.Internal.ChessMoveResult, ACBindings.Internal.ChessMoveResult>)0x004AA090)(ref this, x, y, result);

    /// <summary>Handles mouse press events on the game board and piece list, updating selection state, executing moves, and reflecting results in the UI.
    /// <code>Offset: 0x004AA9A0
    /// void __thiscall GameBoardGrid::HandleMousePresses(GameBoardGrid*,const UIElementMessageInfo*)</code>
    /// </summary>
    /// <param name="i_rMsg">The message info from the UI element indicating which element was pressed and its coordinates.</param>
    public void HandleMousePresses(ACBindings.Internal.UIElementMessageInfo* i_rMsg) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.GameBoardGrid, ACBindings.Internal.UIElementMessageInfo*, void>)0x004AA9A0)(ref this, i_rMsg);

    /// <summary>Processes an opponent’s move by updating the board state, handling promotions, and displaying the result via the mini‑game UI.
    /// <code>Offset: 0x004AAB90
    /// void __thiscall GameBoardGrid::OpponentMove(GameBoardGrid*,const GameMoveData*)</code>
    /// </summary>
    /// <param name="move">Data describing the opponent’s move, including source and destination coordinates and any promotion information.</param>
    public void OpponentMove(ACBindings.Internal.GameMoveData* move) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.GameBoardGrid, ACBindings.Internal.GameMoveData*, void>)0x004AAB90)(ref this, move);
}

