namespace ACBindings.Internal;

public unsafe struct CAllegianceNode
{
    // Base Classes
    public ACBindings.Internal.AllegianceNode BaseClass_AllegianceNode; // ACBindings.Internal.AllegianceNode

    // Child Types
    public unsafe struct CAllegianceNode_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CAllegianceNode*, void> CAllegianceNode_dtor_0; // function pointer
        public fixed byte gap4[4];
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CAllegianceNode*, uint> GetPackSize; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CAllegianceNode*, void**, uint, uint> Pack; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CAllegianceNode*, void**, uint, int> UnPack; // function pointer

        // Methods
    }

    // Methods
}

