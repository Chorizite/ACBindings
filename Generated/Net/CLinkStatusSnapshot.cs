namespace ACBindings.Internal;


/// <summary>Captures a snapshot of link performance metrics over a defined period, recording round‑trip delay, packet statistics, and byte counts to assess connectivity quality.</summary>
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

