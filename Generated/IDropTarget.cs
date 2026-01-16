namespace ACBindings.Internal;


/// <summary>IDropTarget defines the contract for objects that accept drag-and-drop data, providing methods to handle drag enter, over, drop, and leave events.</summary>
/// <remarks>This interface is part of the OLE drag-and-drop subsystem and is implemented by controls that need to receive dragged items from other applications or components. It typically inherits from IUnknown.</remarks>
public unsafe struct IDropTarget
{
    // Base Classes
    public ACBindings.Internal.IUnknown BaseClass_IUnknown; // ACBindings.Internal.IUnknown

    // Child Types
    public unsafe struct IDropTarget_vtbl
    {
        // Members
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.IUnknown*, ACBindings.Internal._GUID*, void**, int> QueryInterface; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.IUnknown*, uint> AddRef; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.IUnknown*, uint> Release; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.IDropTarget*, ACBindings.Internal.IDataObject*, uint, int*, uint*, int> DragEnter; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.IDropTarget*, uint, int*, uint*, int> DragOver; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.IDropTarget*, int> DragLeave; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.IDropTarget*, ACBindings.Internal.IDataObject*, uint, int*, uint*, int> Drop; // function pointer

        // Methods
    }

    // Methods
}

