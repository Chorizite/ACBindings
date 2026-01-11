namespace ACBindings.Internal;

public unsafe struct Indicator : System.IDisposable
{
    // Child Types
    public unsafe struct Indicator_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.Indicator*, void> Indicator_dtor_0; // function pointer

        // Methods
    }

    // Members
    public System.IntPtr __vftable; // vtable pointer
    public ACBindings.Internal.UI64Hash___NetBlob waitingBlobs_;
    public ACBindings.Internal.UI64Hash___ArrivedEphInfo arrivedEphBlobs_;
    public ACBindings.Internal.ArrivedEphInfo* firstInfo_;
    public double flushStamp_;

    // Generated Constructor
    public Indicator() {
        _ConstructorInternal();
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x0054ADB0
    /// void __thiscall Indicator::Indicator(Indicator*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Indicator, void>)0x0054ADB0)(ref this);

    /// <summary>
    /// <code>Offset: 0x0054AED0
    /// void __thiscall Indicator::AddArrivedEphInfo(Indicator*,ArrivedEphInfo*)</code>
    /// </summary>
    public void AddArrivedEphInfo(ACBindings.Internal.ArrivedEphInfo* info) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Indicator, ACBindings.Internal.ArrivedEphInfo*, void>)0x0054AED0)(ref this, info);

    /// <summary>
    /// <code>Offset: 0x0054AFB0
    /// int __thiscall Indicator::FragIsObsoleteEmphemeral(Indicator*,unsigned __int64)</code>
    /// </summary>
    public int FragIsObsoleteEmphemeral(ulong netBlobID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Indicator, ulong, int>)0x0054AFB0)(ref this, netBlobID);

    /// <summary>
    /// <code>Offset: 0x0054B0E0
    /// void __thiscall Indicator::CleanupWaitingBlobs(Indicator*)</code>
    /// </summary>
    public void CleanupWaitingBlobs() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Indicator, void>)0x0054B0E0)(ref this);

    /// <summary>
    /// <code>Offset: 0x0054B1A0
    /// void __thiscall Indicator::AcceptFrag(Indicator*,BlobFrag*,unsigned __int16)</code>
    /// </summary>
    public void AcceptFrag(ACBindings.Internal.BlobFrag* newFrag, ushort sender) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Indicator, ACBindings.Internal.BlobFrag*, ushort, void>)0x0054B1A0)(ref this, newFrag, sender);

    /// <summary>
    /// <code>Offset: 0x0054B2F0
    /// void __thiscall Indicator::~Indicator(Indicator*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Indicator, void>)0x0054B2F0)(ref this);

    /// <summary>
    /// <code>Offset: 0x0054B340
    /// void __thiscall Indicator::CheckInPacket(Indicator*,const NetPacket*,unsigned __int16)</code>
    /// </summary>
    public void CheckInPacket(ACBindings.Internal.NetPacket* packet, ushort sender) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Indicator, ACBindings.Internal.NetPacket*, ushort, void>)0x0054B340)(ref this, packet, sender);
}

