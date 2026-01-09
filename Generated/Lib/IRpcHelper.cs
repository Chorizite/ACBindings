namespace ACBindings;

// IRpcHelper
public unsafe struct IRpcHelper
{
    // Base Classes
    public ACBindings.IUnknown BaseClass_IUnknown; // ACBindings.IUnknown

    // Child Types
    // IRpcHelper_vtbl
    public unsafe struct IRpcHelper_vtbl
    {
        // Members
        public System.IntPtr QueryInterface; // function pointer
        public System.IntPtr AddRef; // function pointer
        public System.IntPtr Release; // function pointer
        public System.IntPtr GetDCOMProtocolVersion; // function pointer
        public System.IntPtr GetIIDFromOBJREF; // function pointer

        // Methods
    }

    // Methods
}

