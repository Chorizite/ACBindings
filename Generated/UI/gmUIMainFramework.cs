namespace ACBindings;

// gmUIMainFramework
public unsafe struct gmUIMainFramework
{
    // Base Classes
    public ACBindings.UIMainFramework BaseClass_UIMainFramework; // ACBindings.UIMainFramework

    // Child Types
    // gmUIMainFramework_vtbl
    public unsafe struct gmUIMainFramework_vtbl
    {
        // Members
        public System.IntPtr gmUIMainFramework_dtor_0; // function pointer
        public System.IntPtr OnAction; // function pointer
        public System.IntPtr OnLoseFocus; // function pointer
        public fixed byte gapC[4];
        public System.IntPtr ListenToElementMessage; // function pointer
        public System.IntPtr ListenToGlobalMessage; // function pointer
        public System.IntPtr CreateAndAddRootElement; // function pointer
        public System.IntPtr CreateAndAddRootElementByDataID;
        public System.IntPtr RemoveRootElement; // function pointer
        public System.IntPtr Show; // function pointer
        public System.IntPtr Shown; // function pointer
        public System.IntPtr ForceHidden; // function pointer
        public System.IntPtr AddChild; // function pointer
        public System.IntPtr RemoveChild; // function pointer
        public System.IntPtr FindChild; // function pointer
        public System.IntPtr SetErrorMsg; // function pointer
        public System.IntPtr Update; // function pointer

        // Methods
    }

    // Methods
}

