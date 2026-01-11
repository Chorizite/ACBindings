namespace ACBindings.Internal;

public unsafe struct IViewObject
{
    // Base Classes
    public ACBindings.Internal.IUnknown BaseClass_IUnknown; // ACBindings.Internal.IUnknown

    // Child Types
    public unsafe struct IViewObject_vtbl
    {
        // Members
        public delegate* unmanaged[Stdcall]<ACBindings.Internal.IUnknown*, ACBindings.Internal._GUID*, void**, int> QueryInterface; // function pointer
        public delegate* unmanaged[Stdcall]<ACBindings.Internal.IUnknown*, uint> AddRef; // function pointer
        public delegate* unmanaged[Stdcall]<ACBindings.Internal.IUnknown*, uint> Release; // function pointer
        public delegate* unmanaged[Stdcall]<ACBindings.Internal.IViewObject*, uint, int, System.IntPtr, System.IntPtr, System.IntPtr, System.IntPtr, System.IntPtr, System.IntPtr, System.IntPtr, uint, int> Draw; // function pointer
        public delegate* unmanaged[Stdcall]<ACBindings.Internal.IViewObject*, uint, int, System.IntPtr, System.IntPtr, System.IntPtr, System.IntPtr, int> GetColorSet; // function pointer
        public delegate* unmanaged[Stdcall]<ACBindings.Internal.IViewObject*, uint, int, System.IntPtr, uint*, int> Freeze; // function pointer
        public delegate* unmanaged[Stdcall]<ACBindings.Internal.IViewObject*, uint, int> Unfreeze; // function pointer
        public delegate* unmanaged[Stdcall]<ACBindings.Internal.IViewObject*, uint, uint, System.IntPtr, int> SetAdvise; // function pointer
        public delegate* unmanaged[Stdcall]<ACBindings.Internal.IViewObject*, uint*, uint*, System.IntPtr, int> GetAdvise; // function pointer

        // Methods
    }

    // Methods
}

