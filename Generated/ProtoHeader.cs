namespace ACBindings.Internal;


/// <summary>Encapsulates the header of a protocol message, holding sequence identification, checksum verification, record and interval metadata, data length, and iteration count for packet processing.</summary>
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

