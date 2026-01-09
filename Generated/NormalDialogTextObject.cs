namespace ACBindings;

// NormalDialogTextObject
public unsafe struct NormalDialogTextObject
{
    // Base Classes
    public ACBindings.GenericDialogTextObject BaseClass_GenericDialogTextObject; // ACBindings.GenericDialogTextObject

    // Child Types
    // NormalDialogTextObject_vtbl
    public unsafe struct NormalDialogTextObject_vtbl
    {
        // Members
        public System.IntPtr NormalDialogTextObject_dtor_0; // function pointer
        public System.IntPtr GetText;

        // Methods
    }

    // Members
    public ACBindings.PStringBase__sbyte m_sText;

    // Methods
}

