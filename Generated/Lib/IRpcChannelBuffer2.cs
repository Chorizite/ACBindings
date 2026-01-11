namespace ACBindings.Internal;

public unsafe struct IRpcChannelBuffer2
{
    // Base Classes
    public ACBindings.Internal.IRpcChannelBuffer BaseClass_IRpcChannelBuffer; // ACBindings.Internal.IRpcChannelBuffer

    // Child Types
    public unsafe struct IRpcChannelBuffer2_vtbl
    {
        // Members
        public delegate* unmanaged[Stdcall]<ACBindings.Internal.IRpcChannelBuffer*, ACBindings.Internal._GUID*, void**, int> QueryInterface; // function pointer
        public delegate* unmanaged[Stdcall]<ACBindings.Internal.IRpcChannelBuffer*, uint> AddRef; // function pointer
        public delegate* unmanaged[Stdcall]<ACBindings.Internal.IRpcChannelBuffer*, uint> Release; // function pointer
        public delegate* unmanaged[Stdcall]<ACBindings.Internal.IRpcChannelBuffer*, System.IntPtr, ACBindings.Internal._GUID*, int> GetBuffer; // function pointer
        public delegate* unmanaged[Stdcall]<ACBindings.Internal.IRpcChannelBuffer*, System.IntPtr, uint*, int> SendReceive; // function pointer
        public delegate* unmanaged[Stdcall]<ACBindings.Internal.IRpcChannelBuffer*, System.IntPtr, int> FreeBuffer; // function pointer
        public delegate* unmanaged[Stdcall]<ACBindings.Internal.IRpcChannelBuffer*, uint*, void**, int> GetDestCtx; // function pointer
        public delegate* unmanaged[Stdcall]<ACBindings.Internal.IRpcChannelBuffer*, int> IsConnected; // function pointer
        public delegate* unmanaged[Stdcall]<ACBindings.Internal.IRpcChannelBuffer2*, uint*, int> GetProtocolVersion; // function pointer

        // Methods
    }

    // Methods
}

