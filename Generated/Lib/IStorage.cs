namespace ACBindings;

// IStorage
public unsafe struct IStorage
{
    // Base Classes
    public ACBindings.IUnknown BaseClass_IUnknown; // ACBindings.IUnknown

    // Child Types
    // IStorage_vtbl
    public unsafe struct IStorage_vtbl
    {
        // Members
        public System.IntPtr QueryInterface; // function pointer
        public System.IntPtr AddRef; // function pointer
        public System.IntPtr Release; // function pointer
        public System.IntPtr CreateStream; // function pointer
        public System.IntPtr OpenStream; // function pointer
        public System.IntPtr CreateStorage; // function pointer
        public System.IntPtr OpenStorage; // function pointer
        public System.IntPtr CopyTo; // function pointer
        public System.IntPtr MoveElementTo; // function pointer
        public System.IntPtr Commit; // function pointer
        public System.IntPtr Revert; // function pointer
        public System.IntPtr EnumElements; // function pointer
        public System.IntPtr DestroyElement; // function pointer
        public System.IntPtr RenameElement; // function pointer
        public System.IntPtr SetElementTimes; // function pointer
        public System.IntPtr SetClass; // function pointer
        public System.IntPtr SetStateBits; // function pointer
        public System.IntPtr Stat; // function pointer

        // Methods
    }

    // Methods
}

