namespace ACBindings.Internal;

public unsafe struct IChatNetwork
{
    // Base Classes
    public ACBindings.Internal.IUnknown BaseClass_IUnknown; // ACBindings.Internal.IUnknown

    // Child Types
    public unsafe struct IChatNetwork_vtbl
    {
        // Members
        public delegate* unmanaged[Stdcall]<ACBindings.Internal.IUnknown*, ACBindings.Internal._GUID*, void**, int> QueryInterface; // function pointer
        public delegate* unmanaged[Stdcall]<ACBindings.Internal.IUnknown*, uint> AddRef; // function pointer
        public delegate* unmanaged[Stdcall]<ACBindings.Internal.IUnknown*, uint> Release; // function pointer
        public delegate* unmanaged[Stdcall]<ACBindings.Internal.IChatNetwork*, ACBindings.Internal.tagBLOB, int> SendData; // function pointer
        public delegate* unmanaged[Stdcall]<ACBindings.Internal.IChatNetwork*, int> UseTime; // function pointer

        // Methods
    }

    // Methods
}

