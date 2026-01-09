namespace ACBindings;

// IStream
public unsafe struct IStream
{
    // Base Classes
    public ACBindings.ISequentialStream BaseClass_ISequentialStream; // ACBindings.ISequentialStream

    // Child Types
    // IStream_vtbl
    public unsafe struct IStream_vtbl
    {
        // Members
        public System.IntPtr QueryInterface; // function pointer
        public System.IntPtr AddRef; // function pointer
        public System.IntPtr Release; // function pointer
        public System.IntPtr Read; // function pointer
        public System.IntPtr Write; // function pointer
        public System.IntPtr Seek; // function pointer
        public System.IntPtr SetSize; // function pointer
        public System.IntPtr CopyTo; // function pointer
        public System.IntPtr Commit; // function pointer
        public System.IntPtr Revert; // function pointer
        public System.IntPtr LockRegion; // function pointer
        public System.IntPtr UnlockRegion; // function pointer
        public System.IntPtr Stat; // function pointer
        public System.IntPtr Clone; // function pointer

        // Methods
    }

    // Methods
}

