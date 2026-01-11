namespace ACBindings.Internal;

public unsafe struct FullPlayerData
{
    // Base Classes
    public ACBindings.Internal.PackObj BaseClass_PackObj; // ACBindings.Internal.PackObj

    // Child Types
    public unsafe struct FullPlayerData_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.FullPlayerData*, void> FullPlayerData_dtor_0; // function pointer
        public fixed byte gap4[4];
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.FullPlayerData*, uint> GetPackSize; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.FullPlayerData*, void**, uint, uint> Pack; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.FullPlayerData*, void**, uint, int> UnPack; // function pointer

        // Methods
    }

    // Members
    public uint bookieID;
    public ACBindings.Internal.AC1Legacy.PStringBase__sbyte character_name;
    public ACBindings.Internal.AC1Legacy.PStringBase__sbyte player_name;
    public ACBindings.Internal.AC1Legacy.PStringBase__sbyte ip_address;
    public ACBindings.Internal.Position position;

    // Methods
}

