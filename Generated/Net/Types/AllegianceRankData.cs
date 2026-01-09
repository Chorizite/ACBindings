namespace ACBindings;

// AllegianceRankData
public unsafe struct AllegianceRankData
{
    // Base Classes
    public ACBindings.PackObj BaseClass_PackObj; // ACBindings.PackObj

    // Child Types
    // AllegianceRankData_vtbl
    public unsafe struct AllegianceRankData_vtbl
    {
        // Members
        public System.IntPtr AllegianceRankData_dtor_0; // function pointer
        public fixed byte gap4[4];
        public System.IntPtr GetPackSize; // function pointer
        public System.IntPtr Pack; // function pointer
        public System.IntPtr UnPack; // function pointer

        // Methods
    }

    // Members
    public uint _id;
    public uint _rank;

    // Methods
}

