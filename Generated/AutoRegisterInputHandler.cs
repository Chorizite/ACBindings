namespace ACBindings.Internal;


/// <summary>Automates registration of input handlers by extending CInputHandler and maintaining a count of registered types.</summary>
public unsafe struct AutoRegisterInputHandler
{
    // Base Classes
    public ACBindings.Internal.CInputHandler BaseClass_CInputHandler; // ACBindings.Internal.CInputHandler

    // Child Types
    public unsafe struct AutoRegisterInputHandler_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.AutoRegisterInputHandler*, ACBindings.Internal.InputEvent*, void> ActionHandler; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.AutoRegisterInputHandler*, int, int, void> MouseMoveHandler; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.AutoRegisterInputHandler*, int, int, void> MouseLookHandler; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.AutoRegisterInputHandler*, byte, int, void> FocusSwitchHandler; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.AutoRegisterInputHandler*, System.Char, void> CharacterHandler; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.AutoRegisterInputHandler*, ACBindings.Internal.QualifiedControl*, uint*, byte> KeyHitHandler; // function pointer

        // Methods
    }

    // Members
    public uint m_RegisteredTypes;

    // Methods
}

