namespace ACBindings.Internal;


/// <summary>Provides an interface for object range operations via a virtual function table.</summary>
/// <remarks>Derived classes implement specific logic for querying or manipulating objects within defined ranges. The struct itself contains only the vftable pointer required for polymorphic behavior.</remarks>
public unsafe struct ObjectRangeHandler
{
    // Child Types

    /// <summary>Defines the virtual function table for handling object range events, providing callbacks for exit and timeout scenarios.</summary>
    public unsafe struct ObjectRangeHandler_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ObjectRangeHandler*, uint, void> OnObjectRangeExit; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ObjectRangeHandler*, uint, void> OnObjectRangeTimeout; // function pointer

        // Methods
    }

    // Members
    public System.IntPtr __vftable; // vtable pointer

    // Methods
}

