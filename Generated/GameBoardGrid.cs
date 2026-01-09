namespace ACBindings;

// GameBoardGrid
public unsafe struct GameBoardGrid
{
    // Base Classes
    public ACBindings.CChessLogic__CBasePiece BaseClass_CChessLogic; // ACBindings.CChessLogic__CBasePiece

    // Child Types
    // GameBoardGrid_vtbl
    public unsafe struct GameBoardGrid_vtbl
    {
        // Members
        public System.IntPtr GameBoardGrid_dtor_0; // function pointer
        public System.IntPtr MovePiece;
        public System.IntPtr AttackPiece;

        // Methods
    }

    // Members
    public ACBindings.gmMiniGameUI* m_gameUI;
    public ACBindings.UIElement_ListBox* m_pieceListBox;
    public ACBindings.IDClass___tagDataID m_didWhitePawn;
    public ACBindings.IDClass___tagDataID m_didWhiteRook;
    public ACBindings.IDClass___tagDataID m_didWhiteBishop;
    public ACBindings.IDClass___tagDataID m_didWhiteKnight;
    public ACBindings.IDClass___tagDataID m_didWhiteQueen;
    public ACBindings.IDClass___tagDataID m_didWhiteKing;
    public ACBindings.IDClass___tagDataID m_didBlackPawn;
    public ACBindings.IDClass___tagDataID m_didBlackRook;
    public ACBindings.IDClass___tagDataID m_didBlackBishop;
    public ACBindings.IDClass___tagDataID m_didBlackKnight;
    public ACBindings.IDClass___tagDataID m_didBlackQueen;
    public ACBindings.IDClass___tagDataID m_didBlackKing;
    public fixed byte m_rgPreviousBoard_Raw[64 * 4];
    public System.IntPtr* m_rgPreviousBoard => (System.IntPtr*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref m_rgPreviousBoard_Raw[0]);
    public ACBindings.TCoord m_coordSelected;

    // Generated Constructor
    public GameBoardGrid(ACBindings.gmMiniGameUI* gameUI) {
        _ConstructorInternal(gameUI);
    }

    // Methods
    // void __thiscall GameBoardGrid::PrepareNewMove(GameBoardGrid*)
    public void PrepareNewMove() => ((delegate* unmanaged[Thiscall]<ref ACBindings.GameBoardGrid, void>)0x004A7EE0)(ref this);
    // void __thiscall GameBoardGrid::Draw(GameBoardGrid*)
    public void Draw() => ((delegate* unmanaged[Thiscall]<ref ACBindings.GameBoardGrid, void>)0x004A80C0)(ref this);
    // void __thiscall GameBoardGrid::UndoMoves(GameBoardGrid*)
    public void UndoMoves() => ((delegate* unmanaged[Thiscall]<ref ACBindings.GameBoardGrid, void>)0x004A8410)(ref this);
    // IDClass<_tagDataID,32,0>* __stdcall GameBoardGrid::GetPieceDID(IDClass<_tagDataID,32,0>*,int,unsigned int)
    public static ACBindings.IDClass___tagDataID* GetPieceDID(ACBindings.IDClass___tagDataID* a1, int a2, uint id) => ((delegate* unmanaged[Stdcall]<ACBindings.IDClass___tagDataID*, int, uint, ACBindings.IDClass___tagDataID*>)0x004A84C0)(a1, a2, id);
    // void __thiscall GameBoardGrid::CommitMoves(GameBoardGrid*)
    public void CommitMoves() => ((delegate* unmanaged[Thiscall]<ref ACBindings.GameBoardGrid, void>)0x004A8E10)(ref this);
    // void __thiscall GameBoardGrid::ClearAllPieces(GameBoardGrid*)
    public void ClearAllPieces() => ((delegate* unmanaged[Thiscall]<ref ACBindings.GameBoardGrid, void>)0x004A8EC0)(ref this);
    // void __thiscall GameBoardGrid::GameBoardGrid(GameBoardGrid*,gmMiniGameUI*)
    public void _ConstructorInternal(ACBindings.gmMiniGameUI* gameUI) => ((delegate* unmanaged[Thiscall]<ref ACBindings.GameBoardGrid, ACBindings.gmMiniGameUI*, void>)0x004A8F50)(ref this, gameUI);
    // void __thiscall GameBoardGrid::CreatePiece(GameBoardGrid*,int,int,int,ChessPieceType)
    public void CreatePiece(int x, int y, int iPlayer, ACBindings.ChessPieceType type) => ((delegate* unmanaged[Thiscall]<ref ACBindings.GameBoardGrid, int, int, int, ACBindings.ChessPieceType, void>)0x004A9180)(ref this, x, y, iPlayer, type);
    // void __thiscall GameBoardGrid::Reset(GameBoardGrid*)
    public void Reset() => ((delegate* unmanaged[Thiscall]<ref ACBindings.GameBoardGrid, void>)0x004A9630)(ref this);
    // ChessMoveResult __thiscall GameBoardGrid::DoPromotion(GameBoardGrid*,int,int,ChessMoveResult)
    public ACBindings.ChessMoveResult DoPromotion(int x, int y, ACBindings.ChessMoveResult result) => ((delegate* unmanaged[Thiscall]<ref ACBindings.GameBoardGrid, int, int, ACBindings.ChessMoveResult, ACBindings.ChessMoveResult>)0x004AA090)(ref this, x, y, result);
    // void __thiscall GameBoardGrid::HandleMousePresses(GameBoardGrid*,const UIElementMessageInfo*)
    public void HandleMousePresses(ACBindings.UIElementMessageInfo* i_rMsg) => ((delegate* unmanaged[Thiscall]<ref ACBindings.GameBoardGrid, ACBindings.UIElementMessageInfo*, void>)0x004AA9A0)(ref this, i_rMsg);
    // void __thiscall GameBoardGrid::OpponentMove(GameBoardGrid*,const GameMoveData*)
    public void OpponentMove(ACBindings.GameMoveData* move) => ((delegate* unmanaged[Thiscall]<ref ACBindings.GameBoardGrid, ACBindings.GameMoveData*, void>)0x004AAB90)(ref this, move);
}

