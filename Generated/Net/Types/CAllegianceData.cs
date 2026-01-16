namespace ACBindings.Internal;


/// <summary>Wraps an AllegianceData instance, providing a custom virtual table for polymorphic handling of alliance data within the system. Stores and manages alliance information such as name, title, membership status, and related metadata. Acts as a lightweight container that facilitates serialization and deserialization via PackObj functions.</summary>
public unsafe struct CAllegianceData
{
    // Base Classes
    public ACBindings.Internal.AllegianceData BaseClass_AllegianceData; // ACBindings.Internal.AllegianceData

    // Child Types
    public unsafe struct CAllegianceData_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CAllegianceData*, void> CAllegianceData_dtor_0; // function pointer
        public fixed byte gap4[4];
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CAllegianceData*, uint> GetPackSize; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CAllegianceData*, void**, uint, uint> Pack; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CAllegianceData*, void**, uint, int> UnPack; // function pointer

        // Methods
    }

    // Generated Constructor
    public CAllegianceData() {
        _ConstructorInternal();
    }

    // Methods

    /// <summary>Creates a new CAllegianceData instance and initializes its base AllegianceData subobject.
    /// <code>Offset: 0x0059A040
    /// void __thiscall CAllegianceData::CAllegianceData(CAllegianceData*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CAllegianceData, void>)0x0059A040)(ref this);
}

