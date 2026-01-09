namespace ACBindings;

// BlockListLoader
public unsafe struct BlockListLoader
{
    // Child Types
    // BlockListLoader_vtbl
    public unsafe struct BlockListLoader_vtbl
    {
        // Members
        public System.IntPtr BlockListLoader_dtor_0; // function pointer
        public System.IntPtr Reload; // function pointer
        public System.IntPtr fEntryInBlockList; // function pointer

        // Methods
    }

    // Members
    public System.IntPtr __vftable; // vtable pointer
    public ACBindings.NIList__BlockListEntry blockList_;
    public ACBindings.LongNIHash__BlockListEntry blockHash_;

    // Methods
}

