namespace ACBindings.Internal;

public unsafe struct IAMovieSetup
{
    // Base Classes
    public ACBindings.Internal.IUnknown BaseClass_IUnknown; // ACBindings.Internal.IUnknown

    // Child Types
    public unsafe struct IAMovieSetup_vtbl
    {
        // Members
        public delegate* unmanaged[Stdcall]<ACBindings.Internal.IUnknown*, ACBindings.Internal._GUID*, void**, int> QueryInterface; // function pointer
        public delegate* unmanaged[Stdcall]<ACBindings.Internal.IUnknown*, uint> AddRef; // function pointer
        public delegate* unmanaged[Stdcall]<ACBindings.Internal.IUnknown*, uint> Release; // function pointer
        public delegate* unmanaged[Stdcall]<ACBindings.Internal.IAMovieSetup*, int> Register; // function pointer
        public delegate* unmanaged[Stdcall]<ACBindings.Internal.IAMovieSetup*, int> Unregister; // function pointer

        // Methods
    }

    // Methods
}

