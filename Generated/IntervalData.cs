namespace ACBindings.Internal;


/// <summary>Represents statistical information collected over a specific time interval, including identifier, byte count, packet count, and flow level metrics.</summary>
public unsafe struct IntervalData
{
    // Members
    public ushort intervalID_;
    public int nBytes_;
    public int FlowLevel_;
    public int nPkts_;

    // Methods
}

