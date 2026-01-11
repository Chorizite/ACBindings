namespace ACBindings.Internal;

public unsafe struct CInputHandler
{
    // Child Types
    public unsafe struct CInputHandler_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CInputHandler*, ACBindings.Internal.InputEvent*, void> ActionHandler; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CInputHandler*, int, int, void> MouseMoveHandler; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CInputHandler*, int, int, void> MouseLookHandler; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CInputHandler*, byte, int, void> FocusSwitchHandler; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CInputHandler*, System.Char, void> CharacterHandler; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CInputHandler*, ACBindings.Internal.QualifiedControl*, uint*, byte> KeyHitHandler; // function pointer

        // Methods
    }

    // Members
    public System.IntPtr __vftable; // vtable pointer

    // Methods
}

