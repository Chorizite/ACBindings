namespace ACBindings;

// IDropTarget
public unsafe struct IDropTarget
{
    // Base Classes
    public ACBindings.IUnknown BaseClass_IUnknown; // ACBindings.IUnknown

    // Child Types
    // IDropTarget_vtbl
    public unsafe struct IDropTarget_vtbl
    {
        // Members
        public System.IntPtr QueryInterface; // function pointer
        public System.IntPtr AddRef; // function pointer
        public System.IntPtr Release; // function pointer
        public System.IntPtr DragEnter; // function pointer
        public System.IntPtr DragOver; // function pointer
        public System.IntPtr DragLeave; // function pointer
        public System.IntPtr Drop; // function pointer

        // Methods
    }

    // Methods
}

