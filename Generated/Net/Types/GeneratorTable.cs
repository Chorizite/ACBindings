namespace ACBindings;

// GeneratorTable
public unsafe struct GeneratorTable
{
    // Base Classes
    public ACBindings.PackObj BaseClass_PackObj; // ACBindings.PackObj

    // Child Types
    // GeneratorTable_vtbl
    public unsafe struct GeneratorTable_vtbl
    {
        // Members
        public System.IntPtr GeneratorTable_dtor_0; // function pointer
        public fixed byte gap4[4];
        public System.IntPtr GetPackSize; // function pointer
        public System.IntPtr Pack; // function pointer
        public System.IntPtr UnPack; // function pointer

        // Methods
    }

    // Members
    public ACBindings.PackableList__GeneratorProfile _profile_list;

    // Generated Constructor
    public GeneratorTable() {
        _ConstructorInternal();
    }

    // Methods
    // void __thiscall GeneratorTable::GeneratorTable(GeneratorTable*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.GeneratorTable, void>)0x005D1300)(ref this);
}

