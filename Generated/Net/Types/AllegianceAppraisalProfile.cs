namespace ACBindings.Internal;

public unsafe struct AllegianceAppraisalProfile
{
    // Base Classes
    public ACBindings.Internal.PackObj BaseClass_PackObj; // ACBindings.Internal.PackObj

    // Child Types
    public unsafe struct AllegianceAppraisalProfile_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.AllegianceAppraisalProfile*, void> AllegianceAppraisalProfile_dtor_0; // function pointer
        public fixed byte gap4[4];
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.AllegianceAppraisalProfile*, uint> GetPackSize; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.AllegianceAppraisalProfile*, void**, uint, uint> Pack; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.AllegianceAppraisalProfile*, void**, uint, int> UnPack; // function pointer

        // Methods
    }

    // Members
    public ACBindings.Internal.AC1Legacy.PStringBase__sbyte m_AllegianceName;
    public ACBindings.Internal.AC1Legacy.PStringBase__sbyte _mtitle;
    public ACBindings.Internal.AC1Legacy.PStringBase__sbyte _ptitle;
    public int _followers;

    // Methods
}

