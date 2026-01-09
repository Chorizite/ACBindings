namespace ACBindings;

// IBasicAudio
public unsafe struct IBasicAudio
{
    // Base Classes
    public ACBindings.IDispatch BaseClass_IDispatch; // ACBindings.IDispatch

    // Child Types
    // IBasicAudio_vtbl
    public unsafe struct IBasicAudio_vtbl
    {
        // Members
        public System.IntPtr QueryInterface; // function pointer
        public System.IntPtr AddRef; // function pointer
        public System.IntPtr Release; // function pointer
        public System.IntPtr GetTypeInfoCount; // function pointer
        public System.IntPtr GetTypeInfo; // function pointer
        public System.IntPtr GetIDsOfNames; // function pointer
        public System.IntPtr Invoke; // function pointer
        public System.IntPtr put_Volume; // function pointer
        public System.IntPtr get_Volume; // function pointer
        public System.IntPtr put_Balance; // function pointer
        public System.IntPtr get_Balance; // function pointer

        // Methods
    }

    // Methods
}

