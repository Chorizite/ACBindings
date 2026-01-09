namespace ACBindings;

// IViewObject2
public unsafe struct IViewObject2
{
    // Base Classes
    public ACBindings.IViewObject BaseClass_IViewObject; // ACBindings.IViewObject

    // Child Types
    // IViewObject2_vtbl
    public unsafe struct IViewObject2_vtbl
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
        public System.IntPtr GetExtent; // function pointer

        // Methods
    }

    // Methods
}

