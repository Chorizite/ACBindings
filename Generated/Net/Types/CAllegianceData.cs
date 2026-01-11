namespace ACBindings.Internal;

public unsafe struct CAllegianceData
{
    // Base Classes
    public ACBindings.Internal.AllegianceData BaseClass_AllegianceData; // ACBindings.Internal.AllegianceData

    // Child Types
    public unsafe struct CAllegianceData_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CAllegianceData*, void> CAllegianceData_dtor_0; // function pointer
        public fixed byte gap4[4];
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CAllegianceData*, uint> GetPackSize; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CAllegianceData*, void**, uint, uint> Pack; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CAllegianceData*, void**, uint, int> UnPack; // function pointer

        // Methods
    }

    // Generated Constructor
    public CAllegianceData() {
        _ConstructorInternal();
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x0059A040
    /// void __thiscall CAllegianceData::CAllegianceData(CAllegianceData*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CAllegianceData, void>)0x0059A040)(ref this);
}

