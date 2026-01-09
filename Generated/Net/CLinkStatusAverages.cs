namespace ACBindings;

// CLinkStatusAverages
public unsafe struct CLinkStatusAverages
{
    // Child Types
    // CLinkStatusAverages::CAverager<float,4>
    public unsafe struct CAverager__float
    {
        // Members
        public fixed float m_Samples[4];
        public double m_CurTotal;
        public ushort m_nSamples;
        public ushort m_idxFirst;

        // Methods
    }
    // CLinkStatusAverages::CAverager<unsigned short,40>
    public unsafe struct CAverager__ushort
    {
        // Members
        public fixed ushort m_Samples[40];
        public double m_CurTotal;
        public ushort m_nSamples;
        public ushort m_idxFirst;

        // Methods
    }
    // CLinkStatusAverages::CAverager<unsigned long,2>
    public unsafe struct CAverager__uint
    {
        // Members
        public fixed uint m_Samples[2];
        public double m_CurTotal;
        public ushort m_nSamples;
        public ushort m_idxFirst;

        // Methods
    }
    // CLinkStatusAverages::CAverager<double,2>
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
    public ACBindings.CLinkStatusSnapshot m_Snapshot;
    public double m_LocalTimeOfSnapshot;
    public ACBindings.CLinkStatusAverages.CAverager__float m_RoundTripDelays;
    public ACBindings.CLinkStatusAverages.CAverager__ushort m_nPktsSent;
    public ACBindings.CLinkStatusAverages.CAverager__ushort m_nPktsRetransmitted;
    public ACBindings.CLinkStatusAverages.CAverager__ushort m_nPktsReceived;
    public ACBindings.CLinkStatusAverages.CAverager__ushort m_nPktsNAKed;
    public ACBindings.CLinkStatusAverages.CAverager__uint m_nBytesSent;
    public ACBindings.CLinkStatusAverages.CAverager__uint m_nBytesReceived;
    public ACBindings.CLinkStatusAverages.CAverager__double m_TimeDiffs;

    // Generated Constructor
    public CLinkStatusAverages() {
        _ConstructorInternal();
    }

    // Methods
    // void __thiscall CLinkStatusAverages::CLinkStatusAverages(CLinkStatusAverages*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CLinkStatusAverages, void>)0x00542F40)(ref this);
    // long double __thiscall CLinkStatusAverages::GetAveragePacketLoss(CLinkStatusAverages*)
    public double GetAveragePacketLoss() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CLinkStatusAverages, double>)0x005471D0)(ref this);
    // void __thiscall CLinkStatusAverages::AddSnapshot(CLinkStatusAverages*,const CLinkStatusSnapshot*)
    public void AddSnapshot(ACBindings.CLinkStatusSnapshot* Snap) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CLinkStatusAverages, ACBindings.CLinkStatusSnapshot*, void>)0x00547210)(ref this, Snap);
    // void __thiscall CLinkStatusAverages::OnPingResponse(CLinkStatusAverages*,float)
    public void OnPingResponse(float RoundTripDelay) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CLinkStatusAverages, float, void>)0x005472F0)(ref this, RoundTripDelay);
}

