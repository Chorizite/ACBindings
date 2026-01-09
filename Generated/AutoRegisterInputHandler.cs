namespace ACBindings;

// AutoRegisterInputHandler
public unsafe struct AutoRegisterInputHandler
{
    // Base Classes
    public ACBindings.CInputHandler BaseClass_CInputHandler; // ACBindings.CInputHandler

    // Child Types
    // AutoRegisterInputHandler_vtbl
    public unsafe struct AutoRegisterInputHandler_vtbl
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
    public uint m_RegisteredTypes;

    // Methods
}

