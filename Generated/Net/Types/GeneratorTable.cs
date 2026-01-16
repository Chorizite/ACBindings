namespace ACBindings.Internal;


/// <summary>Maintains a collection of generator profiles and exposes pack/unpack operations through an embedded PackObj instance.</summary>
public unsafe struct GeneratorTable
{
    // Base Classes
    public ACBindings.Internal.PackObj BaseClass_PackObj; // ACBindings.Internal.PackObj

    // Child Types
    public unsafe struct GeneratorTable_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.GeneratorTable*, void> GeneratorTable_dtor_0; // function pointer
        public fixed byte gap4[4];
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.GeneratorTable*, uint> GetPackSize; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.GeneratorTable*, void**, uint, uint> Pack; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.GeneratorTable*, void**, uint, int> UnPack; // function pointer

        // Methods
    }

    // Members
    public ACBindings.Internal.PackableList___GeneratorProfile _profile_list;

    // Generated Constructor
    public GeneratorTable() {
        _ConstructorInternal();
    }

    // Methods

    /// <summary>Constructs a GeneratorTable instance by initializing its virtual table pointer and preparing an empty list of generator profiles.
    /// <code>Offset: 0x005D1300
    /// void __thiscall GeneratorTable::GeneratorTable(GeneratorTable*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.GeneratorTable, void>)0x005D1300)(ref this);
}

