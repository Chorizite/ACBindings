namespace ACBindings;

// AllegianceAppraisalProfile
public unsafe struct AllegianceAppraisalProfile
{
    // Base Classes
    public ACBindings.PackObj BaseClass_PackObj; // ACBindings.PackObj

    // Child Types
    // AllegianceAppraisalProfile_vtbl
    public unsafe struct AllegianceAppraisalProfile_vtbl
    {
        // Members
        public System.IntPtr AllegianceAppraisalProfile_dtor_0; // function pointer
        public fixed byte gap4[4];
        public System.IntPtr GetPackSize; // function pointer
        public System.IntPtr Pack; // function pointer
        public System.IntPtr UnPack; // function pointer

        // Methods
    }

    // Members
    public ACBindings.AC1Legacy.PStringBase__sbyte m_AllegianceName;
    public ACBindings.AC1Legacy.PStringBase__sbyte _mtitle;
    public ACBindings.AC1Legacy.PStringBase__sbyte _ptitle;
    public int _followers;

    // Methods
}

