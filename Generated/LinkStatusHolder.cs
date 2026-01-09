namespace ACBindings;

// LinkStatusHolder
public unsafe struct LinkStatusHolder
{
    // Base Classes
    public ACBindings.CLinkStatusPlugin BaseClass_CLinkStatusPlugin; // ACBindings.CLinkStatusPlugin

    // Child Types
    // LinkStatusHolder_vtbl
    public unsafe struct LinkStatusHolder_vtbl
    {
        // Members
        public System.IntPtr LinkStatusHolder_dtor_0; // function pointer
        public System.IntPtr OnPluggedIn; // function pointer
        public System.IntPtr OnHeartbeat; // function pointer
        public System.IntPtr OnNetStatusChange; // function pointer

        // Methods
    }

    // Members
    public ACBindings._ECF5B552CC8265AFC2011C3A0B8A5C2C m_eLinkState;
    public double m_tLastHeardFromCurServer;
    public float m_fConnectionProgress;
    public float m_fPacketLoss;
    public ACBindings.NetError m_errFinal;
    public int m_nodropKick;

    // Methods
    // float __thiscall LinkStatusHolder::GetPacketLossPercentage(LinkStatusHolder*)
    public float GetPacketLossPercentage() => ((delegate* unmanaged[Thiscall]<ref ACBindings.LinkStatusHolder, float>)0x004116D0)(ref this);
    // long double __thiscall LinkStatusHolder::GetConnectionStatus(LinkStatusHolder*,int*)
    public double GetConnectionStatus(int* bConnected) => ((delegate* unmanaged[Thiscall]<ref ACBindings.LinkStatusHolder, int*, double>)0x004116E0)(ref this, bConnected);
    // void __thiscall LinkStatusHolder::OnHeartbeat(LinkStatusHolder*,const CLinkStatusAverages*)
    public void OnHeartbeat(ACBindings.CLinkStatusAverages* Avgs) => ((delegate* unmanaged[Thiscall]<ref ACBindings.LinkStatusHolder, ACBindings.CLinkStatusAverages*, void>)0x00411730)(ref this, Avgs);
    // void __thiscall LinkStatusHolder::OnNetStatusChange(LinkStatusHolder*,NetStatus,int,int)
    public void OnNetStatusChange(ACBindings.NetStatus Status, int Param1, int Param2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.LinkStatusHolder, ACBindings.NetStatus, int, int, void>)0x00411CC0)(ref this, Status, Param1, Param2);
}

