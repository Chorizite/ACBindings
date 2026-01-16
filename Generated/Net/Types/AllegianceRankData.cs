namespace ACBindings.Internal;


/// <summary>Represents the data associated with a specific allegiance rank, including its unique identifier and rank level. The struct is serializable via PackObj, enabling efficient packing and unpacking of rank information within the application.</summary>
public unsafe struct AllegianceRankData
{
    // Base Classes
    public ACBindings.Internal.PackObj BaseClass_PackObj; // ACBindings.Internal.PackObj

    // Child Types
    public unsafe struct AllegianceRankData_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.AllegianceRankData*, void> AllegianceRankData_dtor_0; // function pointer
        public fixed byte gap4[4];
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.AllegianceRankData*, uint> GetPackSize; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.AllegianceRankData*, void**, uint, uint> Pack; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.AllegianceRankData*, void**, uint, int> UnPack; // function pointer

        // Methods
    }

    // Members
    public uint _id;
    public uint _rank;

    // Methods
}

