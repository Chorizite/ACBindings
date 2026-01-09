namespace ACBindings;

// IUnknown
public unsafe struct IUnknown
{
    // Child Types
    // IUnknown_vtbl
    public unsafe struct IUnknown_vtbl
    {
        // Members
        public System.IntPtr QueryInterface; // function pointer
        public System.IntPtr AddRef; // function pointer
        public System.IntPtr Release; // function pointer

        // Methods
    }

    // Members
    public System.IntPtr __vftable; // vtable pointer

    // Methods
}

