namespace ACBindings.Internal;


/// <summary>Tracks data reception metrics for flow control, storing the total bytes received and an interval used to regulate transfer.</summary>
public unsafe struct CFlowStruct
{
    // Members
    public uint cbDataRecvd;
    public ushort interval;

    // Methods
}

