namespace ACBindings;

// UIChildFramework
public unsafe struct UIChildFramework
{
    // Base Classes
    public ACBindings.UIFramework BaseClass_UIFramework; // ACBindings.UIFramework

    // Child Types
    // UIChildFramework_vtbl
    public unsafe struct UIChildFramework_vtbl
    {
        // Members
        public System.IntPtr UIFramework_dtor_0; // function pointer
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

        // Methods
    }

    // Members
    public ACBindings.UIFramework* m_parent;

    // Methods
}

