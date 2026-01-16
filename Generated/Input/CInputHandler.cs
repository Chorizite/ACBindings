namespace ACBindings.Internal;


/// <summary>Encapsulates an input handler object with a virtual function table for polymorphic behavior.</summary>
public unsafe struct CInputHandler
{
    // Child Types

    /// <summary>Defines a virtual function table for CInputHandler, holding callbacks for action, mouse movement, look, focus switching, character input, and key hit events.</summary>
    /// <remarks>Used by the input system to dispatch user inputs to the appropriate handler functions.</remarks>
    public unsafe struct CInputHandler_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CInputHandler*, ACBindings.Internal.InputEvent*, void> ActionHandler; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CInputHandler*, int, int, void> MouseMoveHandler; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CInputHandler*, int, int, void> MouseLookHandler; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CInputHandler*, byte, int, void> FocusSwitchHandler; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CInputHandler*, System.Char, void> CharacterHandler; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CInputHandler*, ACBindings.Internal.QualifiedControl*, uint*, byte> KeyHitHandler; // function pointer

        // Methods
    }

    // Members
    public System.IntPtr __vftable; // vtable pointer

    // Methods
}

