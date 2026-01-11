namespace ACBindings.Internal;

public unsafe struct ISequentialStream
{
    // Base Classes
    public ACBindings.Internal.IUnknown BaseClass_IUnknown; // ACBindings.Internal.IUnknown

    // Child Types
    public unsafe struct ISequentialStream_vtbl
    {
        // Members
        public delegate* unmanaged[Stdcall]<ACBindings.Internal.IUnknown*, ACBindings.Internal._GUID*, void**, int> QueryInterface; // function pointer
        public delegate* unmanaged[Stdcall]<ACBindings.Internal.IUnknown*, uint> AddRef; // function pointer
        public delegate* unmanaged[Stdcall]<ACBindings.Internal.IUnknown*, uint> Release; // function pointer
        public delegate* unmanaged[Stdcall]<ACBindings.Internal.ISequentialStream*, System.IntPtr, uint, uint*, int> Read; // function pointer
        public delegate* unmanaged[Stdcall]<ACBindings.Internal.ISequentialStream*, void*, uint, uint*, int> Write; // function pointer

        // Methods
    }

    // Methods
}

