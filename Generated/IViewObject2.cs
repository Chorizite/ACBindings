namespace ACBindings.Internal;

public unsafe struct IViewObject2
{
    // Base Classes
    public ACBindings.Internal.IViewObject BaseClass_IViewObject; // ACBindings.Internal.IViewObject

    // Child Types
    public unsafe struct IViewObject2_vtbl
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
        public delegate* unmanaged[Stdcall]<ACBindings.Internal.IViewObject2*, uint, int, System.IntPtr, System.IntPtr, int> GetExtent; // function pointer

        // Methods
    }

    // Methods
}

