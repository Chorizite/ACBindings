namespace ACBindings.Internal;


/// <summary>Provides a mapping from quest identifiers to their corresponding quest profiles, facilitating efficient lookup and packable serialization through an aligned hash table.</summary>
/// <remarks>The struct contains a PackObj baseclass_0 for packing operations and a packed hash table that stores QuestProfile objects keyed by case‑insensitive strings.</remarks>
public unsafe struct QuestTable
{
    // Base Classes
    public ACBindings.Internal.PackObj BaseClass_PackObj; // ACBindings.Internal.PackObj

    // Child Types
    public unsafe struct QuestTable_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.QuestTable*, void> QuestTable_dtor_0; // function pointer
        public fixed byte gap4[4];
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.QuestTable*, uint> GetPackSize; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.QuestTable*, void**, uint, uint> Pack; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.QuestTable*, void**, uint, int> UnPack; // function pointer

        // Methods
    }

    // Members
    public ACBindings.Internal.PackableHashTable___AC1Legacy_CaseInsensitiveStringBase___AC1Legacy_PStringBase__sbyte___QuestProfile _quest_table;

    // Methods
}

