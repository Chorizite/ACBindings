namespace ACBindings.Internal;


/// <summary>Maintains rolling averages of link performance metrics—packet counts, byte volumes, round‑trip latency, and time differences—to evaluate network health over successive snapshots.</summary>
public unsafe struct CLinkStatusAverages
{
    // Child Types
    public unsafe struct CAverager__float
    {
        // Members
        public fixed float m_Samples[4];
        public double m_CurTotal;
        public ushort m_nSamples;
        public ushort m_idxFirst;

        // Methods
    }
    public unsafe struct CAverager__ushort
    {
        // Members
        public fixed ushort m_Samples[40];
        public double m_CurTotal;
        public ushort m_nSamples;
        public ushort m_idxFirst;

        // Methods
    }
    public unsafe struct CAverager__uint
    {
        // Members
        public fixed uint m_Samples[2];
        public double m_CurTotal;
        public ushort m_nSamples;
        public ushort m_idxFirst;

        // Methods
    }
    public unsafe struct CAverager__double
    {
        // Members
        public fixed double m_Samples[2];
        public double m_CurTotal;
        public ushort m_nSamples;
        public ushort m_idxFirst;

        // Methods
    }

    // Members
    public ACBindings.Internal.CLinkStatusSnapshot m_Snapshot;
    public double m_LocalTimeOfSnapshot;
    public ACBindings.Internal.CLinkStatusAverages.CAverager__float m_RoundTripDelays;
    public ACBindings.Internal.CLinkStatusAverages.CAverager__ushort m_nPktsSent;
    public ACBindings.Internal.CLinkStatusAverages.CAverager__ushort m_nPktsRetransmitted;
    public ACBindings.Internal.CLinkStatusAverages.CAverager__ushort m_nPktsReceived;
    public ACBindings.Internal.CLinkStatusAverages.CAverager__ushort m_nPktsNAKed;
    public ACBindings.Internal.CLinkStatusAverages.CAverager__uint m_nBytesSent;
    public ACBindings.Internal.CLinkStatusAverages.CAverager__uint m_nBytesReceived;
    public ACBindings.Internal.CLinkStatusAverages.CAverager__double m_TimeDiffs;

    // Generated Constructor
    public CLinkStatusAverages() {
        _ConstructorInternal();
    }

    // Methods

    /// <summary>Initializes a new CLinkStatusAverages instance, resetting all statistical counters and the snapshot timestamp to zero.
    /// <code>Offset: 0x00542F40
    /// void __thiscall CLinkStatusAverages::CLinkStatusAverages(CLinkStatusAverages*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CLinkStatusAverages, void>)0x00542F40)(ref this);

    /// <summary>Computes the average packet loss rate by comparing the sum of NAKed and retransmitted packets against the total of sent and received packets, returning twice that ratio.
    /// <code>Offset: 0x005471D0
    /// long double __thiscall CLinkStatusAverages::GetAveragePacketLoss(CLinkStatusAverages*)</code>
    /// </summary>
    /// <returns>A long double representing twice the proportion of lost packets relative to total packets; returns 0 when no packets have been processed.</returns>
    public double GetAveragePacketLoss() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CLinkStatusAverages, double>)0x005471D0)(ref this);

    /// <summary>Ingests a link status snapshot, updating stored values and computing rolling averages.
    /// <code>Offset: 0x00547210
    /// void __thiscall CLinkStatusAverages::AddSnapshot(CLinkStatusAverages*,const CLinkStatusSnapshot*)</code>
    /// </summary>
    /// <param name="Snap">Snapshot containing packet statistics and duration to incorporate.</param>
    public void AddSnapshot(ACBindings.Internal.CLinkStatusSnapshot* Snap) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CLinkStatusAverages, ACBindings.Internal.CLinkStatusSnapshot*, void>)0x00547210)(ref this, Snap);

    /// <summary>Records a new round‑trip delay, updating the circular buffer and running total used for averaging latency.
    /// <code>Offset: 0x005472F0
    /// void __thiscall CLinkStatusAverages::OnPingResponse(CLinkStatusAverages*,float)</code>
    /// </summary>
    /// <param name="RoundTripDelay">Measured round‑trip latency to record.</param>
    public void OnPingResponse(float RoundTripDelay) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CLinkStatusAverages, float, void>)0x005472F0)(ref this, RoundTripDelay);
}

