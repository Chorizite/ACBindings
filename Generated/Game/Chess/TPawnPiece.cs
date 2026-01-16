namespace ACBindings.Internal;

public unsafe struct TPawnPiece___CBasePiece
{
    // Base Classes
    public ACBindings.Internal.TChessPiece___CBasePiece BaseClass_TChessPiece; // ACBindings.Internal.TChessPiece___CBasePiece

    // Child Types
    public unsafe struct TPawnPiece_vtbl___CBasePiece
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

    /// <summary>Determines whether a pawn can capture an opponent piece at the given relative position.
    /// <code>Offset: 0x004A8750
    /// int __stdcall TPawnPiece&lt;CBasePiece&gt;::bCanAttack(int,int)</code>
    /// </summary>
    /// <param name="a1">Horizontal offset from the pawn's current square (negative for left, positive for right).</param>
    /// <param name="a2">Vertical offset from the pawn's current square; must be one rank forward to represent a capture move.</param>
    /// <returns>Non‑zero if the displacement matches a valid pawn capture direction; otherwise zero.</returns>
    // int __stdcall TPawnPiece<CBasePiece>::bCanAttack(int,int) (template type method)
}

