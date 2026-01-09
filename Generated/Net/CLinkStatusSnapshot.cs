namespace ACBindings;

// CLinkStatusSnapshot
public unsafe struct CLinkStatusSnapshot
{
    // Members
    public float RoundTripDelay;
    public ushort nPktsSent;
    public ushort nPktsRetransmitted;
    public ushort nPktsReceived;
    public ushort nPktsNAKed;
    public uint nBytesSent;
    public uint nBytesReceived;
    public float TimeSinceLastGotData;
    public float SnapshotDuration;

    // Methods
}

