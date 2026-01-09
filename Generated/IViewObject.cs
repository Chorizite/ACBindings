namespace ACBindings;

// IViewObject
public unsafe struct IViewObject
{
    // Base Classes
    public ACBindings.IUnknown BaseClass_IUnknown; // ACBindings.IUnknown

    // Child Types
    // IViewObject_vtbl
    public unsafe struct IViewObject_vtbl
    {
        // Members
        public System.IntPtr QueryInterface; // function pointer
        public System.IntPtr AddRef; // function pointer
        public System.IntPtr Release; // function pointer
        public System.IntPtr Draw; // function pointer
        public System.IntPtr GetColorSet; // function pointer
        public System.IntPtr Freeze; // function pointer
        public System.IntPtr Unfreeze; // function pointer
        public System.IntPtr SetAdvise; // function pointer
        public System.IntPtr GetAdvise; // function pointer

        // Methods
    }

    // Methods
}

