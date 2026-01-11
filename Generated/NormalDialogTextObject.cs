namespace ACBindings.Internal;

public unsafe struct NormalDialogTextObject
{
    // Base Classes
    public ACBindings.Internal.GenericDialogTextObject BaseClass_GenericDialogTextObject; // ACBindings.Internal.GenericDialogTextObject

    // Child Types
    public unsafe struct NormalDialogTextObject_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.NormalDialogTextObject*, void> NormalDialogTextObject_dtor_0; // function pointer
        public System.IntPtr GetText;

        // Methods
    }

    // Members
    public ACBindings.Internal.PStringBase__sbyte m_sText;

    // Methods
}

