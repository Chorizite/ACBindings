namespace ACBindings.Internal;

public unsafe struct IDropTarget
{
    // Base Classes
    public ACBindings.Internal.IUnknown BaseClass_IUnknown; // ACBindings.Internal.IUnknown

    // Child Types
    public unsafe struct IDropTarget_vtbl
    {
        // Members
        public delegate* unmanaged[Stdcall]<ACBindings.Internal.IUnknown*, ACBindings.Internal._GUID*, void**, int> QueryInterface; // function pointer
        public delegate* unmanaged[Stdcall]<ACBindings.Internal.IUnknown*, uint> AddRef; // function pointer
        public delegate* unmanaged[Stdcall]<ACBindings.Internal.IUnknown*, uint> Release; // function pointer
        public delegate* unmanaged[Stdcall]<ACBindings.Internal.IDropTarget*, ACBindings.Internal.IDataObject*, uint, int*, uint*, int> DragEnter; // function pointer
        public delegate* unmanaged[Stdcall]<ACBindings.Internal.IDropTarget*, uint, int*, uint*, int> DragOver; // function pointer
        public delegate* unmanaged[Stdcall]<ACBindings.Internal.IDropTarget*, int> DragLeave; // function pointer
        public delegate* unmanaged[Stdcall]<ACBindings.Internal.IDropTarget*, ACBindings.Internal.IDataObject*, uint, int*, uint*, int> Drop; // function pointer

        // Methods
    }

    // Methods
}

