namespace ACBindings;

// DragDropInfo
public unsafe struct DragDropInfo
{
    // Base Classes
    public ACBindings.ReferenceCountTemplate BaseClass_ReferenceCountTemplate; // ACBindings.ReferenceCountTemplate

    // Child Types
    // DragDropInfo_vtbl
    public unsafe struct DragDropInfo_vtbl
    {
        // Members
        public System.IntPtr DragDropInfo_dtor_0; // function pointer

        // Methods
    }

    // Members
    public ACBindings.UIElement* element;
    public ACBindings.UIElement* owner;
    public ACBindings.UIElement* catcher;
    public byte success;

    // Methods
}

