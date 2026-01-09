namespace ACBindings;

// IRpcStubBuffer
public unsafe struct IRpcStubBuffer
{
    // Base Classes
    public ACBindings.IUnknown BaseClass_IUnknown; // ACBindings.IUnknown

    // Child Types
    // IRpcStubBuffer_vtbl
    public unsafe struct IRpcStubBuffer_vtbl
    {
        // Members
        public System.IntPtr QueryInterface; // function pointer
        public System.IntPtr AddRef; // function pointer
        public System.IntPtr Release; // function pointer
        public System.IntPtr Connect; // function pointer
        public System.IntPtr Disconnect; // function pointer
        public System.IntPtr Invoke; // function pointer
        public System.IntPtr IsIIDSupported; // function pointer
        public System.IntPtr CountRefs; // function pointer
        public System.IntPtr DebugServerQueryInterface; // function pointer
        public System.IntPtr DebugServerRelease; // function pointer

        // Methods
    }

    // Methods
}

