namespace ACBindings;

// Indicator
public unsafe struct Indicator : System.IDisposable
{
    // Child Types
    // Indicator_vtbl
    public unsafe struct Indicator_vtbl
    {
        // Members
        public System.IntPtr Indicator_dtor_0; // function pointer

        // Methods
    }

    // Members
    public System.IntPtr __vftable; // vtable pointer
    public ACBindings.UI64Hash__NetBlob waitingBlobs_;
    public ACBindings.UI64Hash__ArrivedEphInfo arrivedEphBlobs_;
    public ACBindings.ArrivedEphInfo* firstInfo_;
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
    // void __thiscall Indicator::Indicator(Indicator*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Indicator, void>)0x0054ADB0)(ref this);
    // void __thiscall Indicator::AddArrivedEphInfo(Indicator*,ArrivedEphInfo*)
    public void AddArrivedEphInfo(ACBindings.ArrivedEphInfo* info) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Indicator, ACBindings.ArrivedEphInfo*, void>)0x0054AED0)(ref this, info);
    // int __thiscall Indicator::FragIsObsoleteEmphemeral(Indicator*,unsigned __int64)
    public int FragIsObsoleteEmphemeral(ulong netBlobID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Indicator, ulong, int>)0x0054AFB0)(ref this, netBlobID);
    // void __thiscall Indicator::CleanupWaitingBlobs(Indicator*)
    public void CleanupWaitingBlobs() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Indicator, void>)0x0054B0E0)(ref this);
    // void __thiscall Indicator::AcceptFrag(Indicator*,BlobFrag*,unsigned __int16)
    public void AcceptFrag(ACBindings.BlobFrag* newFrag, ushort sender) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Indicator, ACBindings.BlobFrag*, ushort, void>)0x0054B1A0)(ref this, newFrag, sender);
    // void __thiscall Indicator::~Indicator(Indicator*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Indicator, void>)0x0054B2F0)(ref this);
    // void __thiscall Indicator::CheckInPacket(Indicator*,const NetPacket*,unsigned __int16)
    public void CheckInPacket(ACBindings.NetPacket* packet, ushort sender) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Indicator, ACBindings.NetPacket*, ushort, void>)0x0054B340)(ref this, packet, sender);
}

