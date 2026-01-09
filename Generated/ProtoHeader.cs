namespace ACBindings;

// ProtoHeader
public unsafe struct ProtoHeader
{
    // Members
    public uint seqID_;
    public uint header_;
    public uint checksum_;
    public ushort recID_;
    public ushort interval_;
    public ushort datalen_;
    public ushort iteration_;

    // Methods
}

