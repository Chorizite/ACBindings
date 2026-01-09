namespace ACBindings;

// CShortCutData
public unsafe struct CShortCutData
{
    // Base Classes
    public ACBindings.ShortCutData BaseClass_ShortCutData; // ACBindings.ShortCutData

    // Child Types
    // CShortCutData_vtbl
    public unsafe struct CShortCutData_vtbl
    {
        // Members
        public System.IntPtr CShortCutData_dtor_0; // function pointer
        public fixed byte gap4[4];
        public System.IntPtr GetPackSize; // function pointer
        public System.IntPtr Pack; // function pointer
        public System.IntPtr UnPack; // function pointer

        // Methods
    }

    // Generated Constructor
    public CShortCutData(int index, uint objectID, uint spellID) {
        _ConstructorInternal(index, objectID, spellID);
    }

    // Methods
    // void __thiscall CShortCutData::CShortCutData(CShortCutData*,int,unsigned int,unsigned int)
    public void _ConstructorInternal(int index, uint objectID, uint spellID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CShortCutData, int, uint, uint, void>)0x0059B5B0)(ref this, index, objectID, spellID);
}

