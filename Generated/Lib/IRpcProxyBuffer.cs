namespace ACBindings.Internal;

public unsafe struct IRpcProxyBuffer
{
    // Base Classes
    public ACBindings.Internal.IUnknown BaseClass_IUnknown; // ACBindings.Internal.IUnknown

    // Child Types
    public unsafe struct IRpcProxyBuffer_vtbl
    {
        // Members
        public delegate* unmanaged[Stdcall]<ACBindings.Internal.IUnknown*, ACBindings.Internal._GUID*, void**, int> QueryInterface; // function pointer
        public delegate* unmanaged[Stdcall]<ACBindings.Internal.IUnknown*, uint> AddRef; // function pointer
        public delegate* unmanaged[Stdcall]<ACBindings.Internal.IUnknown*, uint> Release; // function pointer
        public delegate* unmanaged[Stdcall]<ACBindings.Internal.IRpcProxyBuffer*, ACBindings.Internal.IRpcChannelBuffer*, int> Connect; // function pointer
        public delegate* unmanaged[Stdcall]<ACBindings.Internal.IRpcProxyBuffer*, void> Disconnect; // function pointer

        // Methods
    }

    // Methods
}

