namespace ACBindings;

// TChessPiece<CBasePiece>
public unsafe struct TChessPiece__CBasePiece
{
    // Base Classes
    public ACBindings.CBasePiece BaseClass_CBasePiece; // ACBindings.CBasePiece

    // Child Types
    // TChessPiece_vtbl<CBasePiece>
    public unsafe struct TChessPiece_vtbl__CBasePiece
    {
        // Members
        public System.IntPtr bCanGoTo;
        public System.IntPtr bCanAttack;
        public System.IntPtr Pack;
        public System.IntPtr UnPack;
        public System.IntPtr GetPackSize;

        // Methods
    }

    // Members
    public System.IntPtr __vftable; // vtable pointer
    public ACBindings.ChessPieceType m_Type;
    public int m_Player;
    public ACBindings.TCoord m_CurPos;
    public ACBindings.TCoord m_LastKnownGoodPos;
    public int m_bMoved;

    // Methods
    // TChessPiece<CBasePiece>::bCanAttack (template type method)
    // TChessPiece<CBasePiece>::UnPack (template type method)
    // TChessPiece<CBasePiece>::Pack (template type method)
    // TChessPiece<CBasePiece>::GetPackSize (template type method)
}

