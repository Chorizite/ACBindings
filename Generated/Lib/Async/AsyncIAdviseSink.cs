namespace ACBindings;

// AsyncIAdviseSink
public unsafe struct AsyncIAdviseSink
{
    // Base Classes
    public ACBindings.IUnknown BaseClass_IUnknown; // ACBindings.IUnknown

    // Child Types
    // AsyncIAdviseSink_vtbl
    public unsafe struct AsyncIAdviseSink_vtbl
    {
        // Members
        public System.IntPtr QueryInterface; // function pointer
        public System.IntPtr AddRef; // function pointer
        public System.IntPtr Release; // function pointer
        public System.IntPtr Begin_OnDataChange; // function pointer
        public System.IntPtr Finish_OnDataChange; // function pointer
        public System.IntPtr Begin_OnViewChange; // function pointer
        public System.IntPtr Finish_OnViewChange; // function pointer
        public System.IntPtr Begin_OnRename; // function pointer
        public System.IntPtr Finish_OnRename; // function pointer
        public System.IntPtr Begin_OnSave; // function pointer
        public System.IntPtr Finish_OnSave; // function pointer
        public System.IntPtr Begin_OnClose; // function pointer
        public System.IntPtr Finish_OnClose; // function pointer

        // Methods
    }

    // Methods
}

