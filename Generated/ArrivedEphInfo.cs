namespace ACBindings.Internal;

public unsafe struct ArrivedEphInfo
{
    // Base Classes
    public ACBindings.Internal.UI64HashData BaseClass_UI64HashData; // ACBindings.Internal.UI64HashData

    // Child Types
    public unsafe struct ArrivedEphInfo_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ArrivedEphInfo*, void> ArrivedEphInfo_dtor_0; // function pointer

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

    /// <summary>
    /// <code>Offset: 0x0054B9C0
    /// void __thiscall ArrivedEphInfo::ArrivedEphInfo(ArrivedEphInfo*,unsigned __int64,unsigned __int64)</code>
    /// </summary>
    public void _ConstructorInternal(ulong sequence, ulong netBlobID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ArrivedEphInfo, ulong, ulong, void>)0x0054B9C0)(ref this, sequence, netBlobID);

    /// <summary>
    /// <code>Offset: 0x0054BA10
    /// void __thiscall ArrivedEphInfo::UpdateNetBlobID(ArrivedEphInfo*,unsigned __int64)</code>
    /// </summary>
    public void UpdateNetBlobID(ulong netBlobID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ArrivedEphInfo, ulong, void>)0x0054BA10)(ref this, netBlobID);

    /// <summary>
    /// <code>Offset: 0x0054BA40
    /// bool __thiscall ArrivedEphInfo::fTimedOut(ArrivedEphInfo*)</code>
    /// </summary>
    public byte fTimedOut() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ArrivedEphInfo, byte>)0x0054BA40)(ref this);
}

