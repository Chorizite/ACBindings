namespace ACBindings.Internal;

public unsafe struct AutoRegisterInputHandler
{
    // Base Classes
    public ACBindings.Internal.CInputHandler BaseClass_CInputHandler; // ACBindings.Internal.CInputHandler

    // Child Types
    public unsafe struct AutoRegisterInputHandler_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.AutoRegisterInputHandler*, ACBindings.Internal.InputEvent*, void> ActionHandler; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.AutoRegisterInputHandler*, int, int, void> MouseMoveHandler; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.AutoRegisterInputHandler*, int, int, void> MouseLookHandler; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.AutoRegisterInputHandler*, byte, int, void> FocusSwitchHandler; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.AutoRegisterInputHandler*, System.Char, void> CharacterHandler; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.AutoRegisterInputHandler*, ACBindings.Internal.QualifiedControl*, uint*, byte> KeyHitHandler; // function pointer

        // Methods
    }

    // Members
    public uint m_RegisteredTypes;

    // Methods
}

