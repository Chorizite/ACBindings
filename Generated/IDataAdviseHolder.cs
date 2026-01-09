namespace ACBindings;

// IDataAdviseHolder
public unsafe struct IDataAdviseHolder
{
    // Base Classes
    public ACBindings.IUnknown BaseClass_IUnknown; // ACBindings.IUnknown

    // Child Types
    // IDataAdviseHolder_vtbl
    public unsafe struct IDataAdviseHolder_vtbl
    {
        // Members
        public System.IntPtr QueryInterface; // function pointer
        public System.IntPtr AddRef; // function pointer
        public System.IntPtr Release; // function pointer
        public System.IntPtr Advise; // function pointer
        public System.IntPtr Unadvise; // function pointer
        public System.IntPtr EnumAdvise; // function pointer
        public System.IntPtr SendOnDataChange; // function pointer

        // Methods
    }

    // Methods
}

