namespace ACBindings;

// ShortCutData
public unsafe struct ShortCutData
{
    // Base Classes
    public ACBindings.PackObj BaseClass_PackObj; // ACBindings.PackObj

    // Child Types
    // ShortCutData_vtbl
    public unsafe struct ShortCutData_vtbl
    {
        // Members
        public System.IntPtr ShortCutData_dtor_0; // function pointer
        public fixed byte gap4[4];
        public System.IntPtr GetPackSize; // function pointer
        public System.IntPtr Pack; // function pointer
        public System.IntPtr UnPack; // function pointer

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
    // void __thiscall ShortCutData::ShortCutData(ShortCutData*,int,unsigned int,unsigned int)
    public void _ConstructorInternal(int index, uint objectID, uint spellID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ShortCutData, int, uint, uint, void>)0x005D6730)(ref this, index, objectID, spellID);
    // void __thiscall ShortCutData::ShortCutData(ShortCutData*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ShortCutData, void>)0x005D6750)(ref this);
}

