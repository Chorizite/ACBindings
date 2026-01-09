namespace ACBindings;

// IChatClientEventSink
public unsafe struct IChatClientEventSink
{
    // Base Classes
    public ACBindings.IUnknown BaseClass_IUnknown; // ACBindings.IUnknown

    // Child Types
    // IChatClientEventSink_vtbl
    public unsafe struct IChatClientEventSink_vtbl
    {
        // Members
        public System.IntPtr QueryInterface; // function pointer
        public System.IntPtr AddRef; // function pointer
        public System.IntPtr Release; // function pointer
        public System.IntPtr OnSendToRoom; // function pointer

        // Methods
    }

    // Methods
}

