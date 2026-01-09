namespace ACBindings;

// QuestTable
public unsafe struct QuestTable
{
    // Base Classes
    public ACBindings.PackObj BaseClass_PackObj; // ACBindings.PackObj

    // Child Types
    // QuestTable_vtbl
    public unsafe struct QuestTable_vtbl
    {
        // Members
        public System.IntPtr QuestTable_dtor_0; // function pointer
        public fixed byte gap4[4];
        public System.IntPtr GetPackSize; // function pointer
        public System.IntPtr Pack; // function pointer
        public System.IntPtr UnPack; // function pointer

        // Methods
    }

    // Members
    public ACBindings.PackableHashTable__AC1Legacy_CaseInsensitiveStringBase__AC1Legacy_PStringBase__sbyte__QuestProfile _quest_table;

    // Methods
}

