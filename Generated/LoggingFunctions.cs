namespace ACBindings;

// LoggingFunctions
public unsafe struct LoggingFunctions
{
    // Members
    public System.IntPtr pfnRecvLogger; // function pointer
    public System.IntPtr pfnSendLogger; // function pointer
    public System.IntPtr pfnUncompressedRecvLogger; // function pointer
    public System.IntPtr pfnUncompressedSendLogger; // function pointer
    public uint dwUserLoggingData;

    // Methods
}

