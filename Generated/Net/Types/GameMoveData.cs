namespace ACBindings.Internal;


/// <summary>
/// Captures a player’s move, storing type, player ID, destination coordinates, and auxiliary data for game‑logic processing.
/// </summary>
public unsafe struct GameMoveData
{
    // Base Classes
    public ACBindings.Internal.PackObj BaseClass_PackObj; // ACBindings.Internal.PackObj

    // Child Types
    public unsafe struct GameMoveData_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.GameMoveData*, void> GameMoveData_dtor_0; // function pointer
        public fixed byte gap4[4];
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.GameMoveData*, uint> GetPackSize; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.GameMoveData*, void**, uint, uint> Pack; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.GameMoveData*, void**, uint, int> UnPack; // function pointer

        // Methods
    }

    // Members
    public ACBindings.Internal.MoveType m_type;
    public uint m_idPlayer;
    public ACBindings.Internal._C5EC65FAD35F61F41D84ED9E3D001807 ___u3;
    public ACBindings.Internal._30EFC6471DBF0CA0DB303A60997DD882 ___u4;
    public int m_xTo;
    public int m_yTo;

    // Methods

    /// <summary>Determines the byte size of a serialized game move packet based on its type.
    /// <code>Offset: 0x006B85A0
    /// unsigned int __thiscall GameMoveData::GetPackSize(GameMoveData*)</code>
    /// </summary>
    /// <returns>The number of bytes required to serialize this move data instance.</returns>
    public uint GetPackSize() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.GameMoveData, uint>)0x006B85A0)(ref this);

    /// <summary>Packs a GameMoveData instance into a binary buffer, writing its fields sequentially according to the move type.
    /// <code>Offset: 0x006B85D0
    /// unsigned int __thiscall GameMoveData::Pack(GameMoveData*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Pointer to the current write position in the destination buffer; updated to point after written data.</param>
    /// <param name="size">Maximum number of bytes available for packing; if insufficient, no data is written.</param>
    /// <returns>The total size required to pack this GameMoveData instance regardless of actual writing.</returns>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.GameMoveData, void**, uint, uint>)0x006B85D0)(ref this, addr, size);

    /// <summary>Unpacks serialized GameMoveData from a buffer and advances the pointer as fields are read. Validates that the buffer contains enough bytes for the base class before reading data.
    /// <code>Offset: 0x006B8680
    /// int __thiscall GameMoveData::UnPack(GameMoveData*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Pointer to a buffer pointer; function reads data from *addr and updates it to point after consumed bytes.</param>
    /// <param name="size">Number of remaining bytes in the buffer.</param>
    /// <returns>Zero if the buffer does not contain enough bytes for the base class; otherwise returns 1 upon successful unpacking.</returns>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.GameMoveData, void**, uint, int>)0x006B8680)(ref this, addr, size);
}

