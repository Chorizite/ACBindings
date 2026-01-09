namespace ACBindings;

// FullPlayerData
public unsafe struct FullPlayerData
{
    // Base Classes
    public ACBindings.PackObj BaseClass_PackObj; // ACBindings.PackObj

    // Child Types
    // FullPlayerData_vtbl
    public unsafe struct FullPlayerData_vtbl
    {
        // Members
        public System.IntPtr FullPlayerData_dtor_0; // function pointer
        public fixed byte gap4[4];
        public System.IntPtr GetPackSize; // function pointer
        public System.IntPtr Pack; // function pointer
        public System.IntPtr UnPack; // function pointer

        // Methods
    }

    // Members
    public uint bookieID;
    public ACBindings.AC1Legacy.PStringBase__sbyte character_name;
    public ACBindings.AC1Legacy.PStringBase__sbyte player_name;
    public ACBindings.AC1Legacy.PStringBase__sbyte ip_address;
    public ACBindings.Position position;

    // Methods
}

