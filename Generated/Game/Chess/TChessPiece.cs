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

    /// <summary>
    /// <code>Offset: 0x004A81C0
    /// int __thiscall TChessPiece&lt;CBasePiece&gt;::bCanAttack(int (__thiscall***this)(_DWORD))</code>
    /// </summary>
    // int __thiscall TChessPiece<CBasePiece>::bCanAttack(int (__thiscall***this)(_DWORD)) (template type method)

    /// <summary>
    /// <code>Offset: 0x004A81D0
    /// int __thiscall TChessPiece&lt;CBasePiece&gt;::UnPack(TCoord*,void**,unsigned int)</code>
    /// </summary>
    // int __thiscall TChessPiece<CBasePiece>::UnPack(TCoord*,void**,unsigned int) (template type method)

    /// <summary>
    /// <code>Offset: 0x004A8630
    /// unsigned int __thiscall TChessPiece&lt;CBasePiece&gt;::Pack(_DWORD*,_DWORD**,unsigned int)</code>
    /// </summary>
    // unsigned int __thiscall TChessPiece<CBasePiece>::Pack(_DWORD*,_DWORD**,unsigned int) (template type method)

    /// <summary>
    /// <code>Offset: 0x006B2F10
    /// unsigned int __cdecl TChessPiece&lt;CBasePiece&gt;::GetPackSize()</code>
    /// </summary>
    // unsigned int __cdecl TChessPiece<CBasePiece>::GetPackSize() (template type method)
}

