namespace ACBindings;

// CChessLogic<CBasePiece>
public unsafe struct CChessLogic__CBasePiece
{
    // Members
    public System.IntPtr __vftable; // vtable pointer
    public fixed byte m_Board_Raw[64 * 4];
    public System.IntPtr* m_Board => (System.IntPtr*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref m_Board_Raw[0]);
    public fixed byte m_Pieces_Raw[24];
    public ACBindings.AC1Legacy.SmartArray__TChessPiece__CBasePiece_ptr* m_Pieces => (ACBindings.AC1Legacy.SmartArray__TChessPiece__CBasePiece_ptr*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref m_Pieces_Raw[0]);
    public int m_CurPlayer;
    public int m_bLastMoveWasCheck;
    public ACBindings.TCoord m_EnPassantAttackSite;
    public ACBindings.TCoord m_EnPassantVictimPos;

    // Methods
    // CChessLogic<CBasePiece>::SanityCheckBoard (template type method)
    // CChessLogic<CBasePiece>::ConvertMoveToVector (template type method)
    // CChessLogic<CBasePiece>::CChessLogic<CBasePiece> (template type method)
    // CChessLogic<CBasePiece>::TryPiecePos (template type method)
    // CChessLogic<CBasePiece>::UndoTryPiecePos (template type method)
    // CChessLogic<CBasePiece>::~CChessLogic<CBasePiece> (template type method)
    // CChessLogic<CBasePiece>::CommitPiecePos (template type method)
    // CChessLogic<CBasePiece>::TestCanGetThere (template type method)
    // CChessLogic<CBasePiece>::IsPlayerInCheck (template type method)
    // CChessLogic<CBasePiece>::DoesMoveSelfCheck (template type method)
    // CChessLogic<CBasePiece>::HandleCastling (template type method)
    // CChessLogic<CBasePiece>::TestMoveAndSelfCheck (template type method)
    // CChessLogic<CBasePiece>::IsPlayerInCheckMate (template type method)
    // CChessLogic<CBasePiece>::ComputeCheckResult (template type method)
    // CChessLogic<CBasePiece>::Move (template type method)
}

