namespace ACBindings.Internal;

public unsafe struct ObjectRangeHandler
{
    // Child Types
    public unsafe struct ObjectRangeHandler_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ObjectRangeHandler*, uint, void> OnObjectRangeExit; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ObjectRangeHandler*, uint, void> OnObjectRangeTimeout; // function pointer

        // Methods
    }

    // Members
    public System.IntPtr __vftable; // vtable pointer

    // Methods
}

