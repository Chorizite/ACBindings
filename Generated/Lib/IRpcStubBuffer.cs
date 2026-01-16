namespace ACBindings.Internal;


/// <summary>Provides an interface for COM RPC stub buffers, enabling serialization of method parameters and handling remote procedure calls.</summary>
public unsafe struct IRpcStubBuffer
{
    // Base Classes
    public ACBindings.Internal.IUnknown BaseClass_IUnknown; // ACBindings.Internal.IUnknown

    // Child Types
    public unsafe struct IRpcStubBuffer_vtbl
    {
        // Members
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.IUnknown*, ACBindings.Internal._GUID*, void**, int> QueryInterface; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.IUnknown*, uint> AddRef; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.IUnknown*, uint> Release; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.IRpcStubBuffer*, ACBindings.Internal.IUnknown*, int> Connect; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.IRpcStubBuffer*, void> Disconnect; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.IRpcStubBuffer*, System.IntPtr, ACBindings.Internal.IRpcChannelBuffer*, int> Invoke; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.IRpcStubBuffer*, ACBindings.Internal._GUID*, ACBindings.Internal.IRpcStubBuffer*> IsIIDSupported; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.IRpcStubBuffer*, uint> CountRefs; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.IRpcStubBuffer*, void**, int> DebugServerQueryInterface; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.IRpcStubBuffer*, System.IntPtr, void> DebugServerRelease; // function pointer

        // Methods
    }

    // Methods
}

