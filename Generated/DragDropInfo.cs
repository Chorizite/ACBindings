namespace ACBindings.Internal;

public unsafe struct DragDropInfo
{
    // Base Classes
    public ACBindings.Internal.ReferenceCountTemplate BaseClass_ReferenceCountTemplate; // ACBindings.Internal.ReferenceCountTemplate

    // Child Types
    public unsafe struct DragDropInfo_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DragDropInfo*, void> DragDropInfo_dtor_0; // function pointer

        // Methods
    }

    // Members
    public ACBindings.Internal.UIElement* element;
    public ACBindings.Internal.UIElement* owner;
    public ACBindings.Internal.UIElement* catcher;
    public byte success;

    // Methods
}

