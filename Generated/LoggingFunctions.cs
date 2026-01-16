namespace ACBindings.Internal;


/// <summary>Provides callback pointers for packet logging within the networking module, enabling capture of received and sent data in both compressed and uncompressed forms.</summary>
/// <remarks>dwUserLoggingData supplies context-specific information passed to each logger function.</remarks>
public unsafe struct LoggingFunctions
{
    // Members
    public static delegate* unmanaged[Cdecl]<ACBindings.Internal.PacketInfo*, uint, void> pfnRecvLogger; // function pointer
    public static delegate* unmanaged[Cdecl]<ACBindings.Internal.PacketInfo*, uint, void> pfnSendLogger; // function pointer
    public static delegate* unmanaged[Cdecl]<ACBindings.Internal.PacketInfo*, uint, void> pfnUncompressedRecvLogger; // function pointer
    public static delegate* unmanaged[Cdecl]<ACBindings.Internal.PacketInfo*, uint, void> pfnUncompressedSendLogger; // function pointer
    public uint dwUserLoggingData;

    // Methods
}

