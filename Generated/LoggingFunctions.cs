namespace ACBindings.Internal;

public unsafe struct LoggingFunctions
{
    // Members
    public delegate* unmanaged[Cdecl]<ACBindings.Internal.PacketInfo*, uint, void> pfnRecvLogger; // function pointer
    public delegate* unmanaged[Cdecl]<ACBindings.Internal.PacketInfo*, uint, void> pfnSendLogger; // function pointer
    public delegate* unmanaged[Cdecl]<ACBindings.Internal.PacketInfo*, uint, void> pfnUncompressedRecvLogger; // function pointer
    public delegate* unmanaged[Cdecl]<ACBindings.Internal.PacketInfo*, uint, void> pfnUncompressedSendLogger; // function pointer
    public uint dwUserLoggingData;

    // Methods
}

