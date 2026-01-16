namespace ACBindings.Internal;

public unsafe struct TChessPiece___CBasePiece
{
    // Base Classes
    public ACBindings.Internal.CBasePiece BaseClass_CBasePiece; // ACBindings.Internal.CBasePiece

    // Child Types
    public unsafe struct TChessPiece_vtbl___CBasePiece
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
    public ACBindings.Internal.ChessPieceType m_Type;
    public int m_Player;
    public ACBindings.Internal.TCoord m_CurPos;
    public ACBindings.Internal.TCoord m_LastKnownGoodPos;
    public int m_bMoved;

    // Methods

    /// <summary>Invokes the supplied virtual function on this chess piece and returns its integer result.
    /// <code>Offset: 0x004A81C0
    /// int __thiscall TChessPiece&lt;CBasePiece&gt;::bCanAttack(int (__thiscall***this)(_DWORD))</code>
    /// </summary>
    /// <param name="this">Triple‑indirect function pointer that takes a _DWORD argument and returns an int; the argument is passed as a pointer to this object.</param>
    /// <returns>The integer returned by the invoked function.</returns>
    // int __thiscall TChessPiece<CBasePiece>::bCanAttack(int (__thiscall***this)(_DWORD)) (template type method)

    /// <summary>Unpacks serialized chess piece data from a buffer into this object, validating the stored piece type and reading player number as well as current and last known good positions.
    /// <code>Offset: 0x004A81D0
    /// int __thiscall TChessPiece&lt;CBasePiece&gt;::UnPack(TCoord*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Pointer to the start of the serialized data; it is advanced sequentially as each field is read.</param>
    /// <param name="a3">Number of bytes remaining in the buffer. The method requires at least 12 bytes (type, player, and two coordinate pairs); otherwise it fails.</param>
    /// <returns>1 if unpacking succeeds and the stored type matches this piece’s expected type; 0 otherwise.</returns>
    // int __thiscall TChessPiece<CBasePiece>::UnPack(TCoord*,void**,unsigned int) (template type method)

    /// <summary>Serializes the chess piece’s data—including type, owner, moved flag, current position, and last known good position—into a supplied array of 32‑bit values, writing only as many fields as fit within the provided buffer capacity.
    /// <code>Offset: 0x004A8630
    /// unsigned int __thiscall TChessPiece&lt;CBasePiece&gt;::Pack(_DWORD*,_DWORD**,unsigned int)</code>
    /// </summary>
    /// <param name="a2">Pointer to the destination array; advanced by the function to point after the written elements.</param>
    /// <param name="a3">Maximum number of DWORD slots available for serialization.</param>
    /// <returns>Number of DWORDs required to represent the piece, as reported by its virtual size method.</returns>
    // unsigned int __thiscall TChessPiece<CBasePiece>::Pack(_DWORD*,_DWORD**,unsigned int) (template type method)

    /// <summary>Returns the number of bytes required to serialize this chess piece.
    /// <code>Offset: 0x006B2F10
    /// unsigned int __cdecl TChessPiece&lt;CBasePiece&gt;::GetPackSize()</code>
    /// </summary>
    /// <returns>The size, in bytes, of the packed representation of the piece.</returns>
    // unsigned int __cdecl TChessPiece<CBasePiece>::GetPackSize() (template type method)
}

