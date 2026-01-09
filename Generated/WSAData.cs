namespace ACBindings;

// WSAData
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

