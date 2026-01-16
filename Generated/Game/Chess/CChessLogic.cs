namespace ACBindings.Internal;

public unsafe struct CChessLogic___CBasePiece
{
    // Members
    public System.IntPtr __vftable; // vtable pointer
    public fixed byte m_Board_Raw[64 * 4];
    public System.IntPtr* m_Board => (System.IntPtr*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref m_Board_Raw[0]);
    public fixed byte m_Pieces_Raw[24];
    public ACBindings.Internal.AC1Legacy.SmartArray___TChessPiece___CBasePiece_ptr* m_Pieces => (ACBindings.Internal.AC1Legacy.SmartArray___TChessPiece___CBasePiece_ptr*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref m_Pieces_Raw[0]);
    public int m_CurPlayer;
    public int m_bLastMoveWasCheck;
    public ACBindings.Internal.TCoord m_EnPassantAttackSite;
    public ACBindings.Internal.TCoord m_EnPassantVictimPos;

    // Methods

    /// <summary>Verifies board consistency by ensuring both leading pieces have type identifier 6 when certain internal conditions are met.
    /// <code>Offset: 0x004A8290
    /// BOOL __thiscall CChessLogic&lt;CBasePiece&gt;::SanityCheckBoard(int)</code>
    /// </summary>
    /// <returns>True if the sanity check passes; otherwise, false.</returns>
    // BOOL __thiscall CChessLogic<CBasePiece>::SanityCheckBoard(int) (template type method)

    /// <summary>Converts a source and destination coordinate pair into a movement vector, returning the number of steps and a direction identifier if the move follows a straight or diagonal line.
    /// <code>Offset: 0x004A82E0
    /// BOOL __stdcall CChessLogic&lt;CBasePiece&gt;::ConvertMoveToVector(_DWORD*,_DWORD*,_DWORD*,signed int*)</code>
    /// </summary>
    /// <param name="a1">Source position as an array containing x and y coordinates.</param>
    /// <param name="a2">Destination position as an array containing x and y coordinates.</param>
    /// <param name="a3">Receives the movement direction index (0–7) that matches the vector components.</param>
    /// <param name="a4">Receives the number of steps required for the move.</param>
    /// <returns>True if the move aligns with a valid horizontal, vertical, or diagonal path; otherwise false.</returns>
    // BOOL __stdcall CChessLogic<CBasePiece>::ConvertMoveToVector(_DWORD*,_DWORD*,_DWORD*,signed int*) (template type method)

    /// <summary>Initializes a new chess board, clearing all piece slots and resetting game state for a fresh play session.
    /// <code>Offset: 0x004A85D0
    /// void*** __thiscall CChessLogic&lt;CBasePiece&gt;::CChessLogic&lt;CBasePiece&gt;(void***)</code>
    /// </summary>
    // void*** __thiscall CChessLogic<CBasePiece>::CChessLogic<CBasePiece>(void***) (template type method)

    /// <summary>
    /// Moves a chess piece to a specified board coordinate, updating its stored position and the internal board array.
    /// 
    /// <code>Offset: 0x004A8A00
    /// int __thiscall CChessLogic&lt;CBasePiece&gt;::TryPiecePos(_DWORD*,int,int,int)</code>
    /// </summary>
    /// <param name="a2">Pointer to the piece to relocate.</param>
    /// <param name="a3">Target column index (0–7).</param>
    /// <param name="a4">Target row index (0–7).</param>
    /// <returns>Returns the piece pointer that was moved; returns null if a2 is null.</returns>
    // int __thiscall CChessLogic<CBasePiece>::TryPiecePos(_DWORD*,int,int,int) (template type method)

    /// <summary>Reverts a previously attempted move of a chess piece, resetting its coordinates to their original values and updating the board grid accordingly.
    /// <code>Offset: 0x004A8A70
    /// _DWORD* __thiscall CChessLogic&lt;CBasePiece&gt;::UndoTryPiecePos(_DWORD*,_DWORD*)</code>
    /// </summary>
    /// <param name="a2">Pointer to the piece whose tentative position is being undone.</param>
    /// <returns>The same piece pointer after restoration.</returns>
    // _DWORD* __thiscall CChessLogic<CBasePiece>::UndoTryPiecePos(_DWORD*,_DWORD*) (template type method)

    /// <summary>Destroys a chess logic instance, freeing all allocated pieces and associated memory while resetting board state. Clears the internal board array and deallocates smart arrays for both players.
    /// <code>Offset: 0x004A8AE0
    /// void __thiscall CChessLogic&lt;CBasePiece&gt;::~CChessLogic&lt;CBasePiece&gt;(void***)</code>
    /// </summary>
    // void __thiscall CChessLogic<CBasePiece>::~CChessLogic<CBasePiece>(void***) (template type method)

    /// <summary>Commits the outcome of a piece movement attempt to the provided state array, marking it as finalized and recording resulting positions.
    /// <code>Offset: 0x004A8BF0
    /// int __thiscall CChessLogic&lt;CBasePiece&gt;::CommitPiecePos(_DWORD*,_DWORD*,int,int)</code>
    /// </summary>
    /// <param name="a2">Array representing the piece state; updated with commit flag and position data after attempting a move.</param>
    /// <param name="a3">Source or origin coordinate for the attempted move.</param>
    /// <param name="a4">Destination or target coordinate for the attempted move.</param>
    /// <returns>Result code from TryPiecePos, indicating success (non‑zero) or failure (zero).</returns>
    // int __thiscall CChessLogic<CBasePiece>::CommitPiecePos(_DWORD*,_DWORD*,int,int) (template type method)

    /// <summary>Determines whether a chess piece can legally move to the target square, taking into account normal movement rules and optional special‑move checks.
    /// <code>Offset: 0x004A8C20
    /// int __thiscall CChessLogic&lt;CBasePiece&gt;::TestCanGetThere(_DWORD*,int,int,int)</code>
    /// </summary>
    /// <param name="a2">Pointer to the piece whose movement is being tested.</param>
    /// <param name="a3">Address of a two‑integer structure holding the destination board coordinates (x, y).</param>
    /// <param name="a4">Optional flag that enables extra validation such as en‑passant or last‑move conditions; zero disables these checks.</param>
    /// <returns>Integer status code:  
    /// 1 – legal move.  
    /// 2 – legal move involving a special circumstance (e.g., capturing an opponent’s piece).  
    /// 3 – legal move with a different special circumstance (such as en‑passant).  
    /// –104 – destination is off the board.  
    /// –105 – destination contains a friendly piece.  
    /// –107 – path to the destination is blocked by another piece.  
    /// –100 – the piece cannot legally make the requested move or fails its internal movement check.</returns>
    // int __thiscall CChessLogic<CBasePiece>::TestCanGetThere(_DWORD*,int,int,int) (template type method)

    /// <summary>Determines whether the specified player is currently in check by examining all opposing pieces for a legal attack on the king.
    /// <code>Offset: 0x004A93B0
    /// int __thiscall CChessLogic&lt;CBasePiece&gt;::IsPlayerInCheck(_DWORD*,int)</code>
    /// </summary>
    /// <param name="a2">Index of the player to evaluate (e.g., 0 or 1).</param>
    /// <returns>Non‑zero if the player is in check; zero otherwise.</returns>
    // int __thiscall CChessLogic<CBasePiece>::IsPlayerInCheck(_DWORD*,int) (template type method)

    /// <summary>Determines whether moving a piece to the given square would leave its king in check.
    /// <code>Offset: 0x004A9430
    /// int __thiscall CChessLogic&lt;CBasePiece&gt;::DoesMoveSelfCheck(_DWORD*,_DWORD*,int*)</code>
    /// </summary>
    /// <param name="this">The chess logic instance that holds the current board and game rules.</param>
    /// <param name="a2">Pointer to the piece being moved; contains information such as the owning player.</param>
    /// <param name="a3">Array of two integers specifying the target coordinates (x, y).</param>
    /// <returns>Non‑zero if the move would expose the king to check; zero otherwise.</returns>
    // int __thiscall CChessLogic<CBasePiece>::DoesMoveSelfCheck(_DWORD*,_DWORD*,int*) (template type method)

    /// <summary>Attempts to perform a king-side or queen-side castling move after verifying that the king and rook have not moved, the path is clear, no squares are under attack, and the move does not leave the king in check.
    /// <code>Offset: 0x004A99F0
    /// int __thiscall CChessLogic&lt;CBasePiece&gt;::HandleCastling(_DWORD*,_DWORD*,_DWORD*)</code>
    /// </summary>
    /// <param name="this">The chess logic instance managing the board state.</param>
    /// <param name="a2">Pointer to the king piece involved in the castling attempt.</param>
    /// <param name="a3">Pointer containing the direction value for castling (positive for kingside, negative for queenside).</param>
    /// <returns>1 if castling succeeds; otherwise a negative integer indicating the specific failure reason (e.g., invalid parameters, pieces already moved, or move would expose king to check).</returns>
    // int __thiscall CChessLogic<CBasePiece>::HandleCastling(_DWORD*,_DWORD*,_DWORD*) (template type method)

    /// <summary>Checks whether a piece can legally move to a target square without leaving its king in check.
    /// <code>Offset: 0x004A9B60
    /// int __thiscall CChessLogic&lt;CBasePiece&gt;::TestMoveAndSelfCheck(_DWORD*,_DWORD*,int*)</code>
    /// </summary>
    /// <param name="a2">Address of the destination square’s coordinate information.</param>
    /// <param name="a3">Address of the moving piece’s data or identifier used for validation.</param>
    /// <returns>Zero or negative value indicates an illegal move; positive values from TestCanGetThere indicate a legal, non‑self‑check move. A return value of –106 specifically denotes that the move would place the king in check.</returns>
    // int __thiscall CChessLogic<CBasePiece>::TestMoveAndSelfCheck(_DWORD*,_DWORD*,int*) (template type method)

    /// <summary>Determines whether the specified player has any legal move to escape a check, returning non‑zero when none exist (check‑mate).
    /// <code>Offset: 0x004A9BA0
    /// int __thiscall CChessLogic&lt;CBasePiece&gt;::IsPlayerInCheckMate(_DWORD*,int)</code>
    /// </summary>
    /// <param name="a2">Index of the player to evaluate (0 for White, 1 for Black).</param>
    /// <returns>Non‑zero if the player is in check‑mate; zero otherwise.</returns>
    // int __thiscall CChessLogic<CBasePiece>::IsPlayerInCheckMate(_DWORD*,int) (template type method)

    /// <summary>Determines whether a specified player is in check or checkmate, updates an internal flag accordingly, and returns a status code.
    /// <code>Offset: 0x004A9FB0
    /// int __thiscall CChessLogic&lt;CBasePiece&gt;::ComputeCheckResult(_DWORD*,int)</code>
    /// </summary>
    /// <param name="a2">Index of the player whose check status should be evaluated.</param>
    /// <returns>An integer code: 0 if no threat, 1024 if the player is in check, 2048 if the player is check‑mated. The method also sets an internal boolean flag to indicate whether the player is currently under check or beyond.</returns>
    // int __thiscall CChessLogic<CBasePiece>::ComputeCheckResult(_DWORD*,int) (template type method)

    /// <summary>Moves a chess piece from the source position to the destination if the move is legal, handling castling, en passant, and check conditions.
    /// <code>Offset: 0x004AA1C0
    /// int __thiscall CChessLogic&lt;CBasePiece&gt;::Move(int,int*,int*)</code>
    /// </summary>
    /// <param name="a2">Source board coordinate as an array of two integers [column,row] (0‑7).</param>
    /// <param name="a3">Destination board coordinate as an array of two integers [column,row] (0‑7).</param>
    /// <returns>Zero or a positive value on success, with flags indicating special conditions; negative values signal errors such as invalid coordinates (-104), missing piece (-102), wrong player (-103), or board sanity failure (-111).</returns>
    // int __thiscall CChessLogic<CBasePiece>::Move(int,int*,int*) (template type method)
}

