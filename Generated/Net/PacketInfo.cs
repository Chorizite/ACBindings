namespace ACBindings.Internal;


/// <summary>Encapsulates metadata and buffers for a network packet, including remote socket address, payload length, I/O vector configuration, and protocol type.</summary>
public unsafe struct PacketInfo
{
    // Child Types
    // PacketInfo::Protocol
    public enum Protocol : byte
    {
        fe_tcp = 0x0,
        be_tcp = 0x1,
        fe_udp = 0x2
    }

    // Members
    public uint cbPacketInfo;
    public System.IntPtr saRemote;
    public uint cbData;
    public void* pvData;
    public ACBindings.Internal._WSABUF* aIOVecs;
    public uint nVecs;
    public uint cbRemote;
    public ACBindings.Internal.PacketInfo.Protocol eProto;
    public ACBindings.Internal._WSABUF iovOldSchool;

    // Methods
}

