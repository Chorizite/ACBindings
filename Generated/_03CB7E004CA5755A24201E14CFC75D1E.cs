namespace ACBindings.Internal;


/// <summary>Maintains counters for different network packet categories, such as ACK, NAK, and various header/data combinations, to facilitate transmission statistics and diagnostics. Each field represents the count of a specific packet type observed during operation.</summary>
public unsafe struct _03CB7E004CA5755A24201E14CFC75D1E
{
    // Members
    public uint cBad;
    public uint cMisc;
    public uint cAck;
    public uint cNak;
    public uint cPak;
    public uint cHeaderOnly;
    public uint cDataOnly;
    public uint cHeaderAndData;

    // Methods
}

