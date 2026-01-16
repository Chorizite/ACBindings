namespace ACBindings.Internal;


/// <summary>Represents information about an arrived network blob, including its sequence ID, latest net‑blob identifier, and a timestamp used to determine freshness.</summary>
/// <summary>Determines whether arrival data has exceeded its five‑second validity window.</summary>
/// <returns>True if more than five seconds have elapsed since m_timeStamp; otherwise false.</returns>
/// <summary>Initializes an ArrivedEphInfo record with a specified sequence number and network blob identifier, setting up hash linkage and recording the current timestamp.</summary>
/// <param name="sequence">Unique sequence number for the eph info.</param>
/// <param name="netBlobID">Identifier of the network blob that arrived.</param>
/// <summary>Updates the latest network blob ID and refreshes the arrival timestamp.</summary>
/// <param name="netBlobID">New network blob identifier to record.</param>
public unsafe struct ArrivedEphInfo
{
    // Base Classes
    public ACBindings.Internal.UI64HashData BaseClass_UI64HashData; // ACBindings.Internal.UI64HashData

    // Child Types
    public unsafe struct ArrivedEphInfo_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ArrivedEphInfo*, void> ArrivedEphInfo_dtor_0; // function pointer

        // Methods
    }

    // Members
    public ACBindings.Internal.ArrivedEphInfo* m_next;
    public ulong m_latestNetBlobID;
    public double m_timeStamp;

    // Generated Constructor
    public ArrivedEphInfo(ulong sequence, ulong netBlobID) {
        _ConstructorInternal(sequence, netBlobID);
    }

    // Methods

    /// <summary>Constructs an ArrivedEphInfo instance with a specified sequence number and net blob identifier, initializing hash linkage and timestamp.
    /// <code>Offset: 0x0054B9C0
    /// void __thiscall ArrivedEphInfo::ArrivedEphInfo(ArrivedEphInfo*,unsigned __int64,unsigned __int64)</code>
    /// </summary>
    /// <param name="sequence">The unique sequence number for the eph info.</param>
    /// <param name="netBlobID">Identifier of the network blob that arrived.</param>
    public void _ConstructorInternal(ulong sequence, ulong netBlobID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ArrivedEphInfo, ulong, ulong, void>)0x0054B9C0)(ref this, sequence, netBlobID);

    /// <summary>Updates the latest network blob identifier and records the current timestamp.
    /// <code>Offset: 0x0054BA10
    /// void __thiscall ArrivedEphInfo::UpdateNetBlobID(ArrivedEphInfo*,unsigned __int64)</code>
    /// </summary>
    /// <param name="netBlobID">The new network blob ID to assign to this record.</param>
    public void UpdateNetBlobID(ulong netBlobID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ArrivedEphInfo, ulong, void>)0x0054BA10)(ref this, netBlobID);

    /// <summary>Determines whether the arrival information has exceeded its validity period of five seconds.
    /// <code>Offset: 0x0054BA40
    /// bool __thiscall ArrivedEphInfo::fTimedOut(ArrivedEphInfo*)</code>
    /// </summary>
    /// <returns>True if more than five seconds have elapsed since m_timeStamp; otherwise, false.</returns>
    public byte fTimedOut() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ArrivedEphInfo, byte>)0x0054BA40)(ref this);
}

