namespace ACBindings.Internal;


/// <summary>Encapsulates appraisal data for an allegiance, storing its name, primary and secondary titles, and follower count.</summary>
public unsafe struct AllegianceAppraisalProfile
{
    // Base Classes
    public ACBindings.Internal.PackObj BaseClass_PackObj; // ACBindings.Internal.PackObj

    // Child Types
    public unsafe struct AllegianceAppraisalProfile_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.AllegianceAppraisalProfile*, void> AllegianceAppraisalProfile_dtor_0; // function pointer
        public fixed byte gap4[4];
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.AllegianceAppraisalProfile*, uint> GetPackSize; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.AllegianceAppraisalProfile*, void**, uint, uint> Pack; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.AllegianceAppraisalProfile*, void**, uint, int> UnPack; // function pointer

        // Methods
    }

    // Members
    public ACBindings.Internal.AC1Legacy.PStringBase__sbyte m_AllegianceName;
    public ACBindings.Internal.AC1Legacy.PStringBase__sbyte _mtitle;
    public ACBindings.Internal.AC1Legacy.PStringBase__sbyte _ptitle;
    public int _followers;

    // Methods
}

