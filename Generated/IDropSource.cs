namespace ACBindings.Internal;

public unsafe struct IDropSource
{
    // Base Classes
    public ACBindings.Internal.IUnknown BaseClass_IUnknown; // ACBindings.Internal.IUnknown

    // Child Types
    public unsafe struct IDropSource_vtbl
    {
        // Members
        public delegate* unmanaged[Stdcall]<ACBindings.Internal.IUnknown*, ACBindings.Internal._GUID*, void**, int> QueryInterface; // function pointer
        public delegate* unmanaged[Stdcall]<ACBindings.Internal.IUnknown*, uint> AddRef; // function pointer
        public delegate* unmanaged[Stdcall]<ACBindings.Internal.IUnknown*, uint> Release; // function pointer
        public delegate* unmanaged[Stdcall]<ACBindings.Internal.IDropSource*, int, uint, int> QueryContinueDrag; // function pointer
        public delegate* unmanaged[Stdcall]<ACBindings.Internal.IDropSource*, uint, int> GiveFeedback; // function pointer

        // Methods
    }

    // Methods
}

