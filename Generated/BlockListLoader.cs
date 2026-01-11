namespace ACBindings.Internal;

public unsafe struct BlockListLoader
{
    // Child Types
    public unsafe struct BlockListLoader_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.BlockListLoader*, void> BlockListLoader_dtor_0; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.BlockListLoader*, sbyte*, int> Reload; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.BlockListLoader*, uint, int> fEntryInBlockList; // function pointer

        // Methods
    }

    // Members
    public System.IntPtr __vftable; // vtable pointer
    public ACBindings.Internal.NIList___BlockListEntry blockList_;
    public ACBindings.Internal.LongNIHash___BlockListEntry blockHash_;

    // Methods
}

