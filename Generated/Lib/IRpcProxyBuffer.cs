namespace ACBindings.Internal;


/// <summary>Acting as a proxy buffer for RPC operations, this structure facilitates the marshaling of COM interface pointers across process boundaries.</summary>
public unsafe struct IRpcProxyBuffer
{
    // Base Classes
    public ACBindings.Internal.IUnknown BaseClass_IUnknown; // ACBindings.Internal.IUnknown

    // Child Types
    public unsafe struct IRpcProxyBuffer_vtbl
    {
        // Members
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.IUnknown*, ACBindings.Internal._GUID*, void**, int> QueryInterface; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.IUnknown*, uint> AddRef; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.IUnknown*, uint> Release; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.IRpcProxyBuffer*, ACBindings.Internal.IRpcChannelBuffer*, int> Connect; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.IRpcProxyBuffer*, void> Disconnect; // function pointer

        // Methods
    }

    // Methods
}

