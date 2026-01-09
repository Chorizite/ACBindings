namespace ACBindings;

// NetPacket
public unsafe struct NetPacket : System.IDisposable
{
    // Base Classes
    public ACBindings.ReferenceCountTemplate BaseClass_ReferenceCountTemplate; // ACBindings.ReferenceCountTemplate

    // Child Types
    // NetPacket_vtbl
    public unsafe struct NetPacket_vtbl
    {
        // Members
        public System.IntPtr NetPacket_dtor_0; // function pointer

        // Methods
    }

    // Members
    public ACBindings.NetPacket* next_;
    public fixed byte specialFragList__Raw[32 * 4];
    public ACBindings.COptionalHeader** specialFragList_ => (ACBindings.COptionalHeader**)System.Runtime.CompilerServices.Unsafe.AsPointer(ref specialFragList__Raw[0]);
    public uint numSpecialFrags_;
    public fixed byte fragList__Raw[29 * 4];
    public ACBindings.BlobFrag** fragList_ => (ACBindings.BlobFrag**)System.Runtime.CompilerServices.Unsafe.AsPointer(ref fragList__Raw[0]);
    public uint numFrags_;
    public ushort recipient_;
    public uint realPriority_;
    public uint size_;
    public uint seqNum_;
    public uint cryptoKey_;
    public uint checksum_;
    public uint flags_;

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods
    // NetPacket* __cdecl NetPacket::CreateForSend(unsigned __int16)
    public static ACBindings.NetPacket* CreateForSend(ushort recip) => ((delegate* unmanaged[Cdecl]<ushort, ACBindings.NetPacket*>)0x00543760)(recip);
    // void __thiscall NetPacket::~NetPacket(NetPacket*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.NetPacket, void>)0x00543800)(ref this);
    // void __thiscall NetPacket::ComputeChecksum(NetPacket*)
    public void ComputeChecksum() => ((delegate* unmanaged[Thiscall]<ref ACBindings.NetPacket, void>)0x00549E10)(ref this);
    // unsigned int __thiscall NetPacket::ApplySpecialFrags(NetPacket*,ProtoHeader*)
    public uint ApplySpecialFrags(ACBindings.ProtoHeader* pHeader) => ((delegate* unmanaged[Thiscall]<ref ACBindings.NetPacket, ACBindings.ProtoHeader*, uint>)0x00549ED0)(ref this, pHeader);
    // void __thiscall NetPacket::AddToTail(NetPacket*,NetPacket**,NetPacket**)
    public void AddToTail(ACBindings.NetPacket** head, ACBindings.NetPacket** tail) => ((delegate* unmanaged[Thiscall]<ref ACBindings.NetPacket, ACBindings.NetPacket**, ACBindings.NetPacket**, void>)0x00549F00)(ref this, head, tail);
    // void __thiscall NetPacket::AddToHead(NetPacket*,NetPacket**,NetPacket**)
    public void AddToHead(ACBindings.NetPacket** head, ACBindings.NetPacket** tail) => ((delegate* unmanaged[Thiscall]<ref ACBindings.NetPacket, ACBindings.NetPacket**, ACBindings.NetPacket**, void>)0x00549F30)(ref this, head, tail);
    // void __thiscall NetPacket::Remove(NetPacket*,NetPacket*,NetPacket**,NetPacket**)
    public void Remove(ACBindings.NetPacket* prev, ACBindings.NetPacket** head, ACBindings.NetPacket** tail) => ((delegate* unmanaged[Thiscall]<ref ACBindings.NetPacket, ACBindings.NetPacket*, ACBindings.NetPacket**, ACBindings.NetPacket**, void>)0x00549F80)(ref this, prev, head, tail);
    // void __thiscall NetPacket::AddOptionalHeader(NetPacket*,COptionalHeader*)
    public void AddOptionalHeader(ACBindings.COptionalHeader* frag) => ((delegate* unmanaged[Thiscall]<ref ACBindings.NetPacket, ACBindings.COptionalHeader*, void>)0x00549FC0)(ref this, frag);
    // bool __thiscall NetPacket::RemoveDisposableOptionalHeaders(NetPacket*)
    public byte RemoveDisposableOptionalHeaders() => ((delegate* unmanaged[Thiscall]<ref ACBindings.NetPacket, byte>)0x0054A070)(ref this);
    // bool __thiscall NetPacket::UpdateTimeSensitiveHeaders(NetPacket*)
    public byte UpdateTimeSensitiveHeaders() => ((delegate* unmanaged[Thiscall]<ref ACBindings.NetPacket, byte>)0x0054A130)(ref this);
    // void __thiscall NetPacket::AddFrag(NetPacket*,BlobFrag*,unsigned __int16,unsigned int)
    public void AddFrag(ACBindings.BlobFrag* frag, ushort recip, uint priority) => ((delegate* unmanaged[Thiscall]<ref ACBindings.NetPacket, ACBindings.BlobFrag*, ushort, uint, void>)0x0054A1A0)(ref this, frag, recip, priority);
}

