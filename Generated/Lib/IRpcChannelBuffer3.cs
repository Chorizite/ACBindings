namespace ACBindings.Internal;

public unsafe struct IRpcChannelBuffer3
{
    // Base Classes
    public ACBindings.Internal.IRpcChannelBuffer2 BaseClass_IRpcChannelBuffer2; // ACBindings.Internal.IRpcChannelBuffer2

    // Child Types
    public unsafe struct IRpcChannelBuffer3_vtbl
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
        public delegate* unmanaged[Stdcall]<ACBindings.Internal.IRpcChannelBuffer3*, System.IntPtr, uint*, int> Send; // function pointer
        public delegate* unmanaged[Stdcall]<ACBindings.Internal.IRpcChannelBuffer3*, System.IntPtr, uint, uint*, int> Receive; // function pointer
        public delegate* unmanaged[Stdcall]<ACBindings.Internal.IRpcChannelBuffer3*, System.IntPtr, int> Cancel; // function pointer
        public delegate* unmanaged[Stdcall]<ACBindings.Internal.IRpcChannelBuffer3*, System.IntPtr, ACBindings.Internal._GUID*, void**, int> GetCallContext; // function pointer
        public delegate* unmanaged[Stdcall]<ACBindings.Internal.IRpcChannelBuffer3*, System.IntPtr, uint*, void**, int> GetDestCtxEx; // function pointer
        public delegate* unmanaged[Stdcall]<ACBindings.Internal.IRpcChannelBuffer3*, System.IntPtr, uint*, int> GetState; // function pointer
        public delegate* unmanaged[Stdcall]<ACBindings.Internal.IRpcChannelBuffer3*, System.IntPtr, System.IntPtr, int> RegisterAsync; // function pointer

        // Methods
    }

    // Methods
}

