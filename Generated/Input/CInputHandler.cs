namespace ACBindings;

// CInputHandler
public unsafe struct CInputHandler
{
    // Child Types
    // CInputHandler_vtbl
    public unsafe struct CInputHandler_vtbl
    {
        // Members
        public System.IntPtr ActionHandler; // function pointer
        public System.IntPtr MouseMoveHandler; // function pointer
        public System.IntPtr MouseLookHandler; // function pointer
        public System.IntPtr FocusSwitchHandler; // function pointer
        public System.IntPtr CharacterHandler; // function pointer
        public System.IntPtr KeyHitHandler; // function pointer

        // Methods
    }

    // Members
    public System.IntPtr __vftable; // vtable pointer

    // Methods
}

