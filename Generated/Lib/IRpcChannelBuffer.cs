namespace ACBindings.Internal;

public unsafe struct IRpcChannelBuffer
{
    // Child Types
    public unsafe struct IRpcChannelBuffer_vtbl
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

        // Methods
    }

    // Members
    public System.IntPtr lpVtbl; // vtable pointer

    // Methods
}

