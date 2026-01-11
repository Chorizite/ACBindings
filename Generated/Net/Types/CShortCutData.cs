namespace ACBindings.Internal;

public unsafe struct CShortCutData
{
    // Base Classes
    public ACBindings.Internal.ShortCutData BaseClass_ShortCutData; // ACBindings.Internal.ShortCutData

    // Child Types
    public unsafe struct CShortCutData_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CShortCutData*, void> CShortCutData_dtor_0; // function pointer
        public fixed byte gap4[4];
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CShortCutData*, uint> GetPackSize; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CShortCutData*, void**, uint, uint> Pack; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CShortCutData*, void**, uint, int> UnPack; // function pointer

        // Methods
    }

    // Generated Constructor
    public CShortCutData(int index, uint objectID, uint spellID) {
        _ConstructorInternal(index, objectID, spellID);
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x0059B5B0
    /// void __thiscall CShortCutData::CShortCutData(CShortCutData*,int,unsigned int,unsigned int)</code>
    /// </summary>
    public void _ConstructorInternal(int index, uint objectID, uint spellID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CShortCutData, int, uint, uint, void>)0x0059B5B0)(ref this, index, objectID, spellID);
}

