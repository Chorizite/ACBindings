namespace ACBindings;

// CAllegianceProfile
public unsafe struct CAllegianceProfile
{
    // Base Classes
    public ACBindings.AllegianceProfile BaseClass_AllegianceProfile; // ACBindings.AllegianceProfile

    // Child Types
    // CAllegianceProfile_vtbl
    public unsafe struct CAllegianceProfile_vtbl
    {
        // Members
        public System.IntPtr CAllegianceProfile_dtor_0; // function pointer
        public fixed byte gap4[4];
        public System.IntPtr GetPackSize; // function pointer
        public System.IntPtr Pack; // function pointer
        public System.IntPtr UnPack; // function pointer

        // Methods
    }

    // Generated Constructor
    public CAllegianceProfile() {
        _ConstructorInternal();
    }

    // Methods
    // void __thiscall CAllegianceProfile::CAllegianceProfile(CAllegianceProfile*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CAllegianceProfile, void>)0x0059A080)(ref this);
}

