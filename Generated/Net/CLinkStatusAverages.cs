namespace ACBindings.Internal;

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

    /// <summary>
    /// <code>Offset: 0x00542F40
    /// void __thiscall CLinkStatusAverages::CLinkStatusAverages(CLinkStatusAverages*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CLinkStatusAverages, void>)0x00542F40)(ref this);

    /// <summary>
    /// <code>Offset: 0x005471D0
    /// long double __thiscall CLinkStatusAverages::GetAveragePacketLoss(CLinkStatusAverages*)</code>
    /// </summary>
    public double GetAveragePacketLoss() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CLinkStatusAverages, double>)0x005471D0)(ref this);

    /// <summary>
    /// <code>Offset: 0x00547210
    /// void __thiscall CLinkStatusAverages::AddSnapshot(CLinkStatusAverages*,const CLinkStatusSnapshot*)</code>
    /// </summary>
    public void AddSnapshot(ACBindings.Internal.CLinkStatusSnapshot* Snap) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CLinkStatusAverages, ACBindings.Internal.CLinkStatusSnapshot*, void>)0x00547210)(ref this, Snap);

    /// <summary>
    /// <code>Offset: 0x005472F0
    /// void __thiscall CLinkStatusAverages::OnPingResponse(CLinkStatusAverages*,float)</code>
    /// </summary>
    public void OnPingResponse(float RoundTripDelay) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CLinkStatusAverages, float, void>)0x005472F0)(ref this, RoundTripDelay);
}

