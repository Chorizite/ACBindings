namespace ACBindings.Internal;

public unsafe struct NetPacket : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.ReferenceCountTemplate BaseClass_ReferenceCountTemplate; // ACBindings.Internal.ReferenceCountTemplate

    // Child Types
    public unsafe struct NetPacket_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.NetPacket*, void> NetPacket_dtor_0; // function pointer

        // Methods
    }

    // Members
    public ACBindings.Internal.NetPacket* next_;
    public fixed byte specialFragList__Raw[32 * 4];
    public ACBindings.Internal.COptionalHeader** specialFragList_ => (ACBindings.Internal.COptionalHeader**)System.Runtime.CompilerServices.Unsafe.AsPointer(ref specialFragList__Raw[0]);
    public uint numSpecialFrags_;
    public fixed byte fragList__Raw[29 * 4];
    public ACBindings.Internal.BlobFrag** fragList_ => (ACBindings.Internal.BlobFrag**)System.Runtime.CompilerServices.Unsafe.AsPointer(ref fragList__Raw[0]);
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

    /// <summary>
    /// <code>Offset: 0x00543760
    /// NetPacket* __cdecl NetPacket::CreateForSend(unsigned __int16)</code>
    /// </summary>
    public static ACBindings.Internal.NetPacket* CreateForSend(ushort recip) => ((delegate* unmanaged[Cdecl]<ushort, ACBindings.Internal.NetPacket*>)0x00543760)(recip);

    /// <summary>
    /// <code>Offset: 0x00543800
    /// void __thiscall NetPacket::~NetPacket(NetPacket*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.NetPacket, void>)0x00543800)(ref this);

    /// <summary>
    /// <code>Offset: 0x00549E10
    /// void __thiscall NetPacket::ComputeChecksum(NetPacket*)</code>
    /// </summary>
    public void ComputeChecksum() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.NetPacket, void>)0x00549E10)(ref this);

    /// <summary>
    /// <code>Offset: 0x00549ED0
    /// unsigned int __thiscall NetPacket::ApplySpecialFrags(NetPacket*,ProtoHeader*)</code>
    /// </summary>
    public uint ApplySpecialFrags(ACBindings.Internal.ProtoHeader* pHeader) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.NetPacket, ACBindings.Internal.ProtoHeader*, uint>)0x00549ED0)(ref this, pHeader);

    /// <summary>
    /// <code>Offset: 0x00549F00
    /// void __thiscall NetPacket::AddToTail(NetPacket*,NetPacket**,NetPacket**)</code>
    /// </summary>
    public void AddToTail(ACBindings.Internal.NetPacket** head, ACBindings.Internal.NetPacket** tail) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.NetPacket, ACBindings.Internal.NetPacket**, ACBindings.Internal.NetPacket**, void>)0x00549F00)(ref this, head, tail);

    /// <summary>
    /// <code>Offset: 0x00549F30
    /// void __thiscall NetPacket::AddToHead(NetPacket*,NetPacket**,NetPacket**)</code>
    /// </summary>
    public void AddToHead(ACBindings.Internal.NetPacket** head, ACBindings.Internal.NetPacket** tail) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.NetPacket, ACBindings.Internal.NetPacket**, ACBindings.Internal.NetPacket**, void>)0x00549F30)(ref this, head, tail);

    /// <summary>
    /// <code>Offset: 0x00549F80
    /// void __thiscall NetPacket::Remove(NetPacket*,NetPacket*,NetPacket**,NetPacket**)</code>
    /// </summary>
    public void Remove(ACBindings.Internal.NetPacket* prev, ACBindings.Internal.NetPacket** head, ACBindings.Internal.NetPacket** tail) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.NetPacket, ACBindings.Internal.NetPacket*, ACBindings.Internal.NetPacket**, ACBindings.Internal.NetPacket**, void>)0x00549F80)(ref this, prev, head, tail);

    /// <summary>
    /// <code>Offset: 0x00549FC0
    /// void __thiscall NetPacket::AddOptionalHeader(NetPacket*,COptionalHeader*)</code>
    /// </summary>
    public void AddOptionalHeader(ACBindings.Internal.COptionalHeader* frag) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.NetPacket, ACBindings.Internal.COptionalHeader*, void>)0x00549FC0)(ref this, frag);

    /// <summary>
    /// <code>Offset: 0x0054A070
    /// bool __thiscall NetPacket::RemoveDisposableOptionalHeaders(NetPacket*)</code>
    /// </summary>
    public byte RemoveDisposableOptionalHeaders() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.NetPacket, byte>)0x0054A070)(ref this);

    /// <summary>
    /// <code>Offset: 0x0054A130
    /// bool __thiscall NetPacket::UpdateTimeSensitiveHeaders(NetPacket*)</code>
    /// </summary>
    public byte UpdateTimeSensitiveHeaders() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.NetPacket, byte>)0x0054A130)(ref this);

    /// <summary>
    /// <code>Offset: 0x0054A1A0
    /// void __thiscall NetPacket::AddFrag(NetPacket*,BlobFrag*,unsigned __int16,unsigned int)</code>
    /// </summary>
    public void AddFrag(ACBindings.Internal.BlobFrag* frag, ushort recip, uint priority) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.NetPacket, ACBindings.Internal.BlobFrag*, ushort, uint, void>)0x0054A1A0)(ref this, frag, recip, priority);
}

