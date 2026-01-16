namespace ACBindings.Internal;


/// <summary>Holds Windows Sockets API version information, descriptive strings, socket limits, and vendor details for initializing networking functionality.</summary>
public unsafe struct WSAData
{
    // Members
    public ushort wVersion;
    public ushort wHighVersion;
    public fixed sbyte szDescription[257];
    public fixed sbyte szSystemStatus[129];
    public ushort iMaxSockets;
    public ushort iMaxUdpDg;
    public sbyte* lpVendorInfo;

    // Methods
}

