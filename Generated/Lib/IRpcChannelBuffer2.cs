namespace ACBindings;

// IRpcChannelBuffer2
public unsafe struct IRpcChannelBuffer2
{
    // Base Classes
    public ACBindings.IRpcChannelBuffer BaseClass_IRpcChannelBuffer; // ACBindings.IRpcChannelBuffer

    // Child Types
    // IRpcChannelBuffer2_vtbl
    public unsafe struct IRpcChannelBuffer2_vtbl
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

        // Methods
    }

    // Methods
}

