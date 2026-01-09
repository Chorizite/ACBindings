namespace ACBindings;

// IRpcChannelBuffer3
public unsafe struct IRpcChannelBuffer3
{
    // Base Classes
    public ACBindings.IRpcChannelBuffer2 BaseClass_IRpcChannelBuffer2; // ACBindings.IRpcChannelBuffer2

    // Child Types
    // IRpcChannelBuffer3_vtbl
    public unsafe struct IRpcChannelBuffer3_vtbl
    {
        // Members
        public System.IntPtr QueryInterface; // function pointer
        public System.IntPtr AddRef; // function pointer
        public System.IntPtr Release; // function pointer
        public System.IntPtr GetBuffer; // function pointer
        public System.IntPtr SendReceive; // function pointer
        public System.IntPtr FreeBuffer; // function pointer
        public System.IntPtr GetDestCtx; // function pointer
        public System.IntPtr IsConnected; // function pointer
        public System.IntPtr GetProtocolVersion; // function pointer
        public System.IntPtr Send; // function pointer
        public System.IntPtr Receive; // function pointer
        public System.IntPtr Cancel; // function pointer
        public System.IntPtr GetCallContext; // function pointer
        public System.IntPtr GetDestCtxEx; // function pointer
        public System.IntPtr GetState; // function pointer
        public System.IntPtr RegisterAsync; // function pointer

        // Methods
    }

    // Methods
}

