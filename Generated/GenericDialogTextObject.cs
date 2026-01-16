namespace ACBindings.Internal;


/// <summary>Provides a virtual table for dialog text objects, enabling runtime polymorphism in dialog text handling.</summary>
public unsafe struct GenericDialogTextObject
{
    // Child Types
    public unsafe struct GenericDialogTextObject_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.GenericDialogTextObject*, void> GenericDialogTextObject_dtor_0; // function pointer
        public System.IntPtr GetText;

        // Methods
    }

    // Members
    public System.IntPtr __vftable; // vtable pointer

    // Methods
}

