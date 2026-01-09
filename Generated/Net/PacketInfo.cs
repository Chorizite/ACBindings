namespace ACBindings;

// PacketInfo
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
    public ACBindings._WSABUF* aIOVecs;
    public uint nVecs;
    public uint cbRemote;
    public ACBindings.PacketInfo.Protocol eProto;
    public ACBindings._WSABUF iovOldSchool;

    // Methods
}

