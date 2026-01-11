namespace ACBindings.Internal;

public unsafe struct GeneratorTable
{
    // Base Classes
    public ACBindings.Internal.PackObj BaseClass_PackObj; // ACBindings.Internal.PackObj

    // Child Types
    public unsafe struct GeneratorTable_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.GeneratorTable*, void> GeneratorTable_dtor_0; // function pointer
        public fixed byte gap4[4];
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.GeneratorTable*, uint> GetPackSize; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.GeneratorTable*, void**, uint, uint> Pack; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.GeneratorTable*, void**, uint, int> UnPack; // function pointer

        // Methods
    }

    // Members
    public ACBindings.Internal.PackableList___GeneratorProfile _profile_list;

    // Generated Constructor
    public GeneratorTable() {
        _ConstructorInternal();
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x005D1300
    /// void __thiscall GeneratorTable::GeneratorTable(GeneratorTable*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.GeneratorTable, void>)0x005D1300)(ref this);
}

