namespace ACBindings;

// TQueenPiece<CBasePiece>
public unsafe struct TQueenPiece__CBasePiece
{
    // Base Classes
    public ACBindings.TChessPiece__CBasePiece BaseClass_TChessPiece; // ACBindings.TChessPiece__CBasePiece

    // Child Types
    // TQueenPiece_vtbl<CBasePiece>
    public unsafe struct TQueenPiece_vtbl__CBasePiece
    {
        // Members
        public System.IntPtr bCanGoTo;
        public System.IntPtr bCanAttack;
        public System.IntPtr Pack;
        public System.IntPtr UnPack;
        public System.IntPtr GetPackSize;

        // Methods
    }

    // Methods
}

