namespace ACBindings;

// GameMoveData
public unsafe struct GameMoveData
{
    // Base Classes
    public ACBindings.PackObj BaseClass_PackObj; // ACBindings.PackObj

    // Child Types
    // GameMoveData_vtbl
    public unsafe struct GameMoveData_vtbl
    {
        // Members
        public System.IntPtr GameMoveData_dtor_0; // function pointer
        public fixed byte gap4[4];
        public System.IntPtr GetPackSize; // function pointer
        public System.IntPtr Pack; // function pointer
        public System.IntPtr UnPack; // function pointer

        // Methods
    }

    // Members
    public ACBindings.MoveType m_type;
    public uint m_idPlayer;
    public ACBindings._C5EC65FAD35F61F41D84ED9E3D001807 ___u3;
    public ACBindings._30EFC6471DBF0CA0DB303A60997DD882 ___u4;
    public int m_xTo;
    public int m_yTo;

    // Methods
    // unsigned int __thiscall GameMoveData::GetPackSize(GameMoveData*)
    public uint GetPackSize() => ((delegate* unmanaged[Thiscall]<ref ACBindings.GameMoveData, uint>)0x006B85A0)(ref this);
    // unsigned int __thiscall GameMoveData::Pack(GameMoveData*,void**,unsigned int)
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.GameMoveData, void**, uint, uint>)0x006B85D0)(ref this, addr, size);
    // int __thiscall GameMoveData::UnPack(GameMoveData*,void**,unsigned int)
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.GameMoveData, void**, uint, int>)0x006B8680)(ref this, addr, size);
}

