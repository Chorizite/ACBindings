namespace ACBindings.Internal;

public unsafe struct LinkStatusHolder
{
    // Base Classes
    public ACBindings.Internal.CLinkStatusPlugin BaseClass_CLinkStatusPlugin; // ACBindings.Internal.CLinkStatusPlugin

    // Child Types
    public unsafe struct LinkStatusHolder_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.LinkStatusHolder*, void> LinkStatusHolder_dtor_0; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.LinkStatusHolder*, ACBindings.Internal.CPluginManager*, void> OnPluggedIn; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.LinkStatusHolder*, ACBindings.Internal.CLinkStatusAverages*, void> OnHeartbeat; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.LinkStatusHolder*, ACBindings.Internal.NetStatus, int, int, void> OnNetStatusChange; // function pointer

        // Methods
    }

    // Members
    public ACBindings.Internal._ECF5B552CC8265AFC2011C3A0B8A5C2C m_eLinkState;
    public double m_tLastHeardFromCurServer;
    public float m_fConnectionProgress;
    public float m_fPacketLoss;
    public ACBindings.Internal.NetError m_errFinal;
    public int m_nodropKick;

    // Methods

    /// <summary>Retrieves the current packet loss percentage.
    /// <code>Offset: 0x004116D0
    /// float __thiscall LinkStatusHolder::GetPacketLossPercentage(LinkStatusHolder*)</code>
    /// </summary>
    /// <returns>The packet loss percentage as a floating‑point value.</returns>
    public float GetPacketLossPercentage() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.LinkStatusHolder, float>)0x004116D0)(ref this);

    /// <summary>Determines whether the link is currently in the Connected state and returns the time elapsed since the last server heartbeat when connected, or zero when disconnected.
    /// <code>Offset: 0x004116E0
    /// long double __thiscall LinkStatusHolder::GetConnectionStatus(LinkStatusHolder*,int*)</code>
    /// </summary>
    /// <param name="bConnected">Receives a flag indicating if the link state equals LinkStatus_Connected (1 for true, 0 for false).</param>
    /// <returns>The number of seconds since the last heartbeat if still connected; otherwise zero. When nodropKick is enabled, this value is capped at 15 seconds.</returns>
    public double GetConnectionStatus(int* bConnected) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.LinkStatusHolder, int*, double>)0x004116E0)(ref this, bConnected);

    /// <summary>Records the time of the latest heartbeat and updates the current packet loss estimate based on the supplied averages.
    /// <code>Offset: 0x00411730
    /// void __thiscall LinkStatusHolder::OnHeartbeat(LinkStatusHolder*,const CLinkStatusAverages*)</code>
    /// </summary>
    /// <param name="Avgs">Link status information from which to compute average packet loss.</param>
    public void OnHeartbeat(ACBindings.Internal.CLinkStatusAverages* Avgs) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.LinkStatusHolder, ACBindings.Internal.CLinkStatusAverages*, void>)0x00411730)(ref this, Avgs);

    /// <summary>Updates link state and connection progress of the holder according to a network status change.
    /// <code>Offset: 0x00411CC0
    /// void __thiscall LinkStatusHolder::OnNetStatusChange(LinkStatusHolder*,NetStatus,int,int)</code>
    /// </summary>
    /// <param name="Status">Network status value indicating the current stage or error.</param>
    /// <param name="Param1">Numerical data for progress calculation during authentication/connection, or pointer to error information when a connection error occurs.</param>
    /// <param name="Param2">Denominator used when computing authentication progress; ignored for other states.</param>
    public void OnNetStatusChange(ACBindings.Internal.NetStatus Status, int Param1, int Param2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.LinkStatusHolder, ACBindings.Internal.NetStatus, int, int, void>)0x00411CC0)(ref this, Status, Param1, Param2);
}

