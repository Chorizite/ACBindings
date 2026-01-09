namespace ACBindings;

// CAllegianceData
public unsafe struct CAllegianceData
{
    // Base Classes
    public ACBindings.AllegianceData BaseClass_AllegianceData; // ACBindings.AllegianceData

    // Child Types
    // CAllegianceData_vtbl
    public unsafe struct CAllegianceData_vtbl
    {
        // Members
        public System.IntPtr CAllegianceData_dtor_0; // function pointer
        public fixed byte gap4[4];
        public System.IntPtr GetPackSize; // function pointer
        public System.IntPtr Pack; // function pointer
        public System.IntPtr UnPack; // function pointer

        // Methods
    }

    // Generated Constructor
    public CAllegianceData() {
        _ConstructorInternal();
    }

    // Methods
    // void __thiscall CAllegianceData::CAllegianceData(CAllegianceData*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CAllegianceData, void>)0x0059A040)(ref this);
}

