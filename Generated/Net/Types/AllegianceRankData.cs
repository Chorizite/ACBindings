namespace ACBindings.Internal;

public unsafe struct AllegianceRankData
{
    // Base Classes
    public ACBindings.Internal.PackObj BaseClass_PackObj; // ACBindings.Internal.PackObj

    // Child Types
    public unsafe struct AllegianceRankData_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.AllegianceRankData*, void> AllegianceRankData_dtor_0; // function pointer
        public fixed byte gap4[4];
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.AllegianceRankData*, uint> GetPackSize; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.AllegianceRankData*, void**, uint, uint> Pack; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.AllegianceRankData*, void**, uint, int> UnPack; // function pointer

        // Methods
    }

    // Members
    public uint _id;
    public uint _rank;

    // Methods
}

