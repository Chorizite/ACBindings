namespace ACBindings.Internal;

public unsafe struct LBRanges
{
    // Base Classes
    public ACBindings.Internal.PackableNIList___LBRange BaseClass_PackableNIList; // ACBindings.Internal.PackableNIList___LBRange

    // Child Types
    public unsafe struct LBRanges_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.LBRanges*, void> LBRanges_dtor_0; // function pointer
        public fixed byte gap4[4];
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.LBRanges*, uint> GetPackSize; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.LBRanges*, void**, uint, uint> Pack; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.LBRanges*, void**, uint, int> UnPack; // function pointer

        // Methods
    }

    // Methods
}

