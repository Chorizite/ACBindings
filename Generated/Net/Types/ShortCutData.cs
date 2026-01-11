namespace ACBindings.Internal;

public unsafe struct ShortCutData
{
    // Base Classes
    public ACBindings.Internal.PackObj BaseClass_PackObj; // ACBindings.Internal.PackObj

    // Child Types
    public unsafe struct ShortCutData_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ShortCutData*, void> ShortCutData_dtor_0; // function pointer
        public fixed byte gap4[4];
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ShortCutData*, uint> GetPackSize; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ShortCutData*, void**, uint, uint> Pack; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ShortCutData*, void**, uint, int> UnPack; // function pointer

        // Methods
    }

    // Members
    public int index_;
    public uint objectID_;
    public uint spellID_;

    // Generated Constructor
    public ShortCutData(int index, uint objectID, uint spellID) {
        _ConstructorInternal(index, objectID, spellID);
    }
    public ShortCutData() {
        _ConstructorInternal();
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x005D6730
    /// void __thiscall ShortCutData::ShortCutData(ShortCutData*,int,unsigned int,unsigned int)</code>
    /// </summary>
    public void _ConstructorInternal(int index, uint objectID, uint spellID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ShortCutData, int, uint, uint, void>)0x005D6730)(ref this, index, objectID, spellID);

    /// <summary>
    /// <code>Offset: 0x005D6750
    /// void __thiscall ShortCutData::ShortCutData(ShortCutData*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ShortCutData, void>)0x005D6750)(ref this);
}

