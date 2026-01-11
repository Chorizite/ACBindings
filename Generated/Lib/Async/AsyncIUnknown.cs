namespace ACBindings.Internal;

public unsafe struct AsyncIUnknown
{
    // Base Classes
    public ACBindings.Internal.IUnknown BaseClass_IUnknown; // ACBindings.Internal.IUnknown

    // Child Types
    public unsafe struct AsyncIUnknown_vtbl
    {
        // Members
        public delegate* unmanaged[Stdcall]<ACBindings.Internal.IUnknown*, ACBindings.Internal._GUID*, void**, int> QueryInterface; // function pointer
        public delegate* unmanaged[Stdcall]<ACBindings.Internal.IUnknown*, uint> AddRef; // function pointer
        public delegate* unmanaged[Stdcall]<ACBindings.Internal.IUnknown*, uint> Release; // function pointer
        public delegate* unmanaged[Stdcall]<ACBindings.Internal.AsyncIUnknown*, ACBindings.Internal._GUID*, int> Begin_QueryInterface; // function pointer
        public delegate* unmanaged[Stdcall]<ACBindings.Internal.AsyncIUnknown*, void**, int> Finish_QueryInterface; // function pointer
        public delegate* unmanaged[Stdcall]<ACBindings.Internal.AsyncIUnknown*, int> Begin_AddRef; // function pointer
        public delegate* unmanaged[Stdcall]<ACBindings.Internal.AsyncIUnknown*, uint> Finish_AddRef; // function pointer
        public delegate* unmanaged[Stdcall]<ACBindings.Internal.AsyncIUnknown*, int> Begin_Release; // function pointer
        public delegate* unmanaged[Stdcall]<ACBindings.Internal.AsyncIUnknown*, uint> Finish_Release; // function pointer

        // Methods
    }

    // Methods
}

