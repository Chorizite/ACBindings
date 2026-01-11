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

    /// <summary>
    /// <code>Offset: 0x004A8290
    /// BOOL __thiscall CChessLogic&lt;CBasePiece&gt;::SanityCheckBoard(int)</code>
    /// </summary>
    // BOOL __thiscall CChessLogic<CBasePiece>::SanityCheckBoard(int) (template type method)

    /// <summary>
    /// <code>Offset: 0x004A82E0
    /// BOOL __stdcall CChessLogic&lt;CBasePiece&gt;::ConvertMoveToVector(_DWORD*,_DWORD*,_DWORD*,signed int*)</code>
    /// </summary>
    // BOOL __stdcall CChessLogic<CBasePiece>::ConvertMoveToVector(_DWORD*,_DWORD*,_DWORD*,signed int*) (template type method)

    /// <summary>
    /// <code>Offset: 0x004A85D0
    /// void*** __thiscall CChessLogic&lt;CBasePiece&gt;::CChessLogic&lt;CBasePiece&gt;(void***)</code>
    /// </summary>
    // void*** __thiscall CChessLogic<CBasePiece>::CChessLogic<CBasePiece>(void***) (template type method)

    /// <summary>
    /// <code>Offset: 0x004A8A00
    /// int __thiscall CChessLogic&lt;CBasePiece&gt;::TryPiecePos(_DWORD*,int,int,int)</code>
    /// </summary>
    // int __thiscall CChessLogic<CBasePiece>::TryPiecePos(_DWORD*,int,int,int) (template type method)

    /// <summary>
    /// <code>Offset: 0x004A8A70
    /// _DWORD* __thiscall CChessLogic&lt;CBasePiece&gt;::UndoTryPiecePos(_DWORD*,_DWORD*)</code>
    /// </summary>
    // _DWORD* __thiscall CChessLogic<CBasePiece>::UndoTryPiecePos(_DWORD*,_DWORD*) (template type method)

    /// <summary>
    /// <code>Offset: 0x004A8AE0
    /// void __thiscall CChessLogic&lt;CBasePiece&gt;::~CChessLogic&lt;CBasePiece&gt;(void***)</code>
    /// </summary>
    // void __thiscall CChessLogic<CBasePiece>::~CChessLogic<CBasePiece>(void***) (template type method)

    /// <summary>
    /// <code>Offset: 0x004A8BF0
    /// int __thiscall CChessLogic&lt;CBasePiece&gt;::CommitPiecePos(_DWORD*,_DWORD*,int,int)</code>
    /// </summary>
    // int __thiscall CChessLogic<CBasePiece>::CommitPiecePos(_DWORD*,_DWORD*,int,int) (template type method)

    /// <summary>
    /// <code>Offset: 0x004A8C20
    /// int __thiscall CChessLogic&lt;CBasePiece&gt;::TestCanGetThere(_DWORD*,int,int,int)</code>
    /// </summary>
    // int __thiscall CChessLogic<CBasePiece>::TestCanGetThere(_DWORD*,int,int,int) (template type method)

    /// <summary>
    /// <code>Offset: 0x004A93B0
    /// int __thiscall CChessLogic&lt;CBasePiece&gt;::IsPlayerInCheck(_DWORD*,int)</code>
    /// </summary>
    // int __thiscall CChessLogic<CBasePiece>::IsPlayerInCheck(_DWORD*,int) (template type method)

    /// <summary>
    /// <code>Offset: 0x004A9430
    /// int __thiscall CChessLogic&lt;CBasePiece&gt;::DoesMoveSelfCheck(_DWORD*,_DWORD*,int*)</code>
    /// </summary>
    // int __thiscall CChessLogic<CBasePiece>::DoesMoveSelfCheck(_DWORD*,_DWORD*,int*) (template type method)

    /// <summary>
    /// <code>Offset: 0x004A99F0
    /// int __thiscall CChessLogic&lt;CBasePiece&gt;::HandleCastling(_DWORD*,_DWORD*,_DWORD*)</code>
    /// </summary>
    // int __thiscall CChessLogic<CBasePiece>::HandleCastling(_DWORD*,_DWORD*,_DWORD*) (template type method)

    /// <summary>
    /// <code>Offset: 0x004A9B60
    /// int __thiscall CChessLogic&lt;CBasePiece&gt;::TestMoveAndSelfCheck(_DWORD*,_DWORD*,int*)</code>
    /// </summary>
    // int __thiscall CChessLogic<CBasePiece>::TestMoveAndSelfCheck(_DWORD*,_DWORD*,int*) (template type method)

    /// <summary>
    /// <code>Offset: 0x004A9BA0
    /// int __thiscall CChessLogic&lt;CBasePiece&gt;::IsPlayerInCheckMate(_DWORD*,int)</code>
    /// </summary>
    // int __thiscall CChessLogic<CBasePiece>::IsPlayerInCheckMate(_DWORD*,int) (template type method)

    /// <summary>
    /// <code>Offset: 0x004A9FB0
    /// int __thiscall CChessLogic&lt;CBasePiece&gt;::ComputeCheckResult(_DWORD*,int)</code>
    /// </summary>
    // int __thiscall CChessLogic<CBasePiece>::ComputeCheckResult(_DWORD*,int) (template type method)

    /// <summary>
    /// <code>Offset: 0x004AA1C0
    /// int __thiscall CChessLogic&lt;CBasePiece&gt;::Move(int,int*,int*)</code>
    /// </summary>
    // int __thiscall CChessLogic<CBasePiece>::Move(int,int*,int*) (template type method)
}

