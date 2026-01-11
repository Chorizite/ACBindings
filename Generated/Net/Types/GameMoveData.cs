namespace ACBindings.Internal;

public unsafe struct GameMoveData
{
    // Base Classes
    public ACBindings.Internal.PackObj BaseClass_PackObj; // ACBindings.Internal.PackObj

    // Child Types
    public unsafe struct GameMoveData_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.GameMoveData*, void> GameMoveData_dtor_0; // function pointer
        public fixed byte gap4[4];
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.GameMoveData*, uint> GetPackSize; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.GameMoveData*, void**, uint, uint> Pack; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.GameMoveData*, void**, uint, int> UnPack; // function pointer

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

    /// <summary>
    /// <code>Offset: 0x006B85A0
    /// unsigned int __thiscall GameMoveData::GetPackSize(GameMoveData*)</code>
    /// </summary>
    public uint GetPackSize() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.GameMoveData, uint>)0x006B85A0)(ref this);

    /// <summary>
    /// <code>Offset: 0x006B85D0
    /// unsigned int __thiscall GameMoveData::Pack(GameMoveData*,void**,unsigned int)</code>
    /// </summary>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.GameMoveData, void**, uint, uint>)0x006B85D0)(ref this, addr, size);

    /// <summary>
    /// <code>Offset: 0x006B8680
    /// int __thiscall GameMoveData::UnPack(GameMoveData*,void**,unsigned int)</code>
    /// </summary>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.GameMoveData, void**, uint, int>)0x006B8680)(ref this, addr, size);
}

