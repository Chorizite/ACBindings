namespace ACBindings.Internal;

public unsafe struct GameBoardGrid
{
    // Base Classes
    public ACBindings.Internal.CChessLogic___CBasePiece BaseClass_CChessLogic; // ACBindings.Internal.CChessLogic___CBasePiece

    // Child Types
    public unsafe struct GameBoardGrid_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.GameBoardGrid*, void> GameBoardGrid_dtor_0; // function pointer
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

    /// <summary>
    /// <code>Offset: 0x004A7EE0
    /// void __thiscall GameBoardGrid::PrepareNewMove(GameBoardGrid*)</code>
    /// </summary>
    public void PrepareNewMove() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.GameBoardGrid, void>)0x004A7EE0)(ref this);

    /// <summary>
    /// <code>Offset: 0x004A80C0
    /// void __thiscall GameBoardGrid::Draw(GameBoardGrid*)</code>
    /// </summary>
    public void Draw() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.GameBoardGrid, void>)0x004A80C0)(ref this);

    /// <summary>
    /// <code>Offset: 0x004A8410
    /// void __thiscall GameBoardGrid::UndoMoves(GameBoardGrid*)</code>
    /// </summary>
    public void UndoMoves() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.GameBoardGrid, void>)0x004A8410)(ref this);

    /// <summary>
    /// <code>Offset: 0x004A84C0
    /// IDClass&lt;_tagDataID,32,0&gt;* __stdcall GameBoardGrid::GetPieceDID(IDClass&lt;_tagDataID,32,0&gt;*,int,unsigned int)</code>
    /// </summary>
    public static ACBindings.Internal.IDClass____tagDataID* GetPieceDID(ACBindings.Internal.IDClass____tagDataID* a1, int a2, uint id) => ((delegate* unmanaged[Stdcall]<ACBindings.Internal.IDClass____tagDataID*, int, uint, ACBindings.Internal.IDClass____tagDataID*>)0x004A84C0)(a1, a2, id);

    /// <summary>
    /// <code>Offset: 0x004A8E10
    /// void __thiscall GameBoardGrid::CommitMoves(GameBoardGrid*)</code>
    /// </summary>
    public void CommitMoves() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.GameBoardGrid, void>)0x004A8E10)(ref this);

    /// <summary>
    /// <code>Offset: 0x004A8EC0
    /// void __thiscall GameBoardGrid::ClearAllPieces(GameBoardGrid*)</code>
    /// </summary>
    public void ClearAllPieces() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.GameBoardGrid, void>)0x004A8EC0)(ref this);

    /// <summary>
    /// <code>Offset: 0x004A8F50
    /// void __thiscall GameBoardGrid::GameBoardGrid(GameBoardGrid*,gmMiniGameUI*)</code>
    /// </summary>
    public void _ConstructorInternal(ACBindings.Internal.gmMiniGameUI* gameUI) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.GameBoardGrid, ACBindings.Internal.gmMiniGameUI*, void>)0x004A8F50)(ref this, gameUI);

    /// <summary>
    /// <code>Offset: 0x004A9180
    /// void __thiscall GameBoardGrid::CreatePiece(GameBoardGrid*,int,int,int,ChessPieceType)</code>
    /// </summary>
    public void CreatePiece(int x, int y, int iPlayer, ACBindings.Internal.ChessPieceType type) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.GameBoardGrid, int, int, int, ACBindings.Internal.ChessPieceType, void>)0x004A9180)(ref this, x, y, iPlayer, type);

    /// <summary>
    /// <code>Offset: 0x004A9630
    /// void __thiscall GameBoardGrid::Reset(GameBoardGrid*)</code>
    /// </summary>
    public void Reset() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.GameBoardGrid, void>)0x004A9630)(ref this);

    /// <summary>
    /// <code>Offset: 0x004AA090
    /// ChessMoveResult __thiscall GameBoardGrid::DoPromotion(GameBoardGrid*,int,int,ChessMoveResult)</code>
    /// </summary>
    public ACBindings.Internal.ChessMoveResult DoPromotion(int x, int y, ACBindings.Internal.ChessMoveResult result) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.GameBoardGrid, int, int, ACBindings.Internal.ChessMoveResult, ACBindings.Internal.ChessMoveResult>)0x004AA090)(ref this, x, y, result);

    /// <summary>
    /// <code>Offset: 0x004AA9A0
    /// void __thiscall GameBoardGrid::HandleMousePresses(GameBoardGrid*,const UIElementMessageInfo*)</code>
    /// </summary>
    public void HandleMousePresses(ACBindings.Internal.UIElementMessageInfo* i_rMsg) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.GameBoardGrid, ACBindings.Internal.UIElementMessageInfo*, void>)0x004AA9A0)(ref this, i_rMsg);

    /// <summary>
    /// <code>Offset: 0x004AAB90
    /// void __thiscall GameBoardGrid::OpponentMove(GameBoardGrid*,const GameMoveData*)</code>
    /// </summary>
    public void OpponentMove(ACBindings.Internal.GameMoveData* move) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.GameBoardGrid, ACBindings.Internal.GameMoveData*, void>)0x004AAB90)(ref this, move);
}

