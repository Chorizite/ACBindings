namespace ACBindings.Internal;

public unsafe struct CAllegianceProfile
{
    // Base Classes
    public ACBindings.Internal.AllegianceProfile BaseClass_AllegianceProfile; // ACBindings.Internal.AllegianceProfile

    // Child Types
    public unsafe struct CAllegianceProfile_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CAllegianceProfile*, void> CAllegianceProfile_dtor_0; // function pointer
        public fixed byte gap4[4];
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CAllegianceProfile*, uint> GetPackSize; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CAllegianceProfile*, void**, uint, uint> Pack; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CAllegianceProfile*, void**, uint, int> UnPack; // function pointer

        // Methods
    }

    // Generated Constructor
    public CAllegianceProfile() {
        _ConstructorInternal();
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x0059A080
    /// void __thiscall CAllegianceProfile::CAllegianceProfile(CAllegianceProfile*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CAllegianceProfile, void>)0x0059A080)(ref this);
}

