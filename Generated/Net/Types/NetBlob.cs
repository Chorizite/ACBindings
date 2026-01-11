namespace ACBindings.Internal;

public unsafe struct NetBlob
{
    // Base Classes
    public ACBindings.Internal.ReferenceCountTemplate BaseClass_ReferenceCountTemplate; // ACBindings.Internal.ReferenceCountTemplate
    public ACBindings.Internal.PackObj BaseClass_PackObj; // ACBindings.Internal.PackObj
    public ACBindings.Internal.UI64HashData BaseClass_UI64HashData; // ACBindings.Internal.UI64HashData

    // Child Types
    public unsafe struct NetBlob_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.NetBlob*, void> NetBlob_dtor_0; // function pointer

        // Methods
    }
    // NetBlob::State
    public enum State : uint
    {
        NETBLOB_FROZEN = 0x0,
        NETBLOB_SENDING = 0x1,
        NETBLOB_RECEIVING = 0x2,
        NETBLOB_RECEIVED = 0x3,
        NETBLOB_FRAGMENTED = 0x4,
        FORCE_State_32_BIT = 0x7FFFFFFF
    }

    // Members
    public ACBindings.Internal.NetBlob.State state_;
    public byte* buf_;
    public uint bufSize_;
    public uint cMaxFragments_;
    public uint numFragments_;
    public ushort sender_;
    public ushort queueID_;
    public uint priority_;
    public ACBindings.Internal.NetBlob* waitNext_;
    public ulong savedNetBlobID_;

    // Generated Constructor
    public NetBlob(byte* buf, uint bufSize, short queue) {
        _ConstructorInternal(buf, bufSize, queue);
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x0054A580
    /// void __thiscall NetBlob::ReceiveAddFragment(NetBlob*,BlobFrag*)</code>
    /// </summary>
    public void ReceiveAddFragment(ACBindings.Internal.BlobFrag* frag) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.NetBlob, ACBindings.Internal.BlobFrag*, void>)0x0054A580)(ref this, frag);

    /// <summary>
    /// <code>Offset: 0x0054A690
    /// void __thiscall NetBlob::ReceiveBlobReady(NetBlob*)</code>
    /// </summary>
    public void ReceiveBlobReady() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.NetBlob, void>)0x0054A690)(ref this);

    /// <summary>
    /// <code>Offset: 0x0054A6A0
    /// bool __thiscall NetBlob::Send(NetBlob*,unsigned __int16,unsigned int)</code>
    /// </summary>
    public byte Send(ushort recip, uint priority) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.NetBlob, ushort, uint, byte>)0x0054A6A0)(ref this, recip, priority);

    /// <summary>
    /// <code>Offset: 0x0054A6F0
    /// void __thiscall NetBlob::NetBlob(NetBlob*,unsigned __int8*,unsigned int,__int16)</code>
    /// </summary>
    public void _ConstructorInternal(byte* buf, uint bufSize, short queue) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.NetBlob, byte*, uint, short, void>)0x0054A6F0)(ref this, buf, bufSize, queue);

    /// <summary>
    /// <code>Offset: 0x0054A790
    /// unsigned int __thiscall NetBlob::GetPackSize(NetBlob*)</code>
    /// </summary>
    public uint GetPackSize() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.NetBlob, uint>)0x0054A790)(ref this);

    /// <summary>
    /// <code>Offset: 0x0054A850
    /// unsigned int __thiscall NetBlob::Fragmentize(NetBlob*,BlobFrag**)</code>
    /// </summary>
    public uint Fragmentize(ACBindings.Internal.BlobFrag** ppCurFragment) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.NetBlob, ACBindings.Internal.BlobFrag**, uint>)0x0054A850)(ref this, ppCurFragment);

    /// <summary>
    /// <code>Offset: 0x0054A900
    /// unsigned int __thiscall NetBlob::Pack(NetBlob*,void**,unsigned int)</code>
    /// </summary>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.NetBlob, void**, uint, uint>)0x0054A900)(ref this, addr, size);

    /// <summary>
    /// <code>Offset: 0x0054A9D0
    /// int __thiscall NetBlob::UnPack(NetBlob*,void**,unsigned int)</code>
    /// </summary>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.NetBlob, void**, uint, int>)0x0054A9D0)(ref this, addr, size);
}

