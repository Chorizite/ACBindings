namespace ACBindings.Internal;


/// <summary>Encapsulates all data necessary to describe an active player session, such as unique identifiers, display names, network address, and spatial coordinates. Serves as the primary structure exchanged during login, matchmaking, and state updates.</summary>
public unsafe struct FullPlayerData
{
    // Base Classes
    public ACBindings.Internal.PackObj BaseClass_PackObj; // ACBindings.Internal.PackObj

    // Child Types
    public unsafe struct FullPlayerData_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.FullPlayerData*, void> FullPlayerData_dtor_0; // function pointer
        public fixed byte gap4[4];
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.FullPlayerData*, uint> GetPackSize; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.FullPlayerData*, void**, uint, uint> Pack; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.FullPlayerData*, void**, uint, int> UnPack; // function pointer

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

