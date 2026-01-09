namespace ACBindings;

// IRpcChannelBufferVtbl
public unsafe struct IRpcChannelBufferVtbl
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

    // Methods
}

