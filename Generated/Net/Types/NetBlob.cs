namespace ACBindings;

// NetBlob
public unsafe struct NetBlob
{
    // Base Classes
    public ACBindings.ReferenceCountTemplate BaseClass_ReferenceCountTemplate; // ACBindings.ReferenceCountTemplate
    public ACBindings.PackObj BaseClass_PackObj; // ACBindings.PackObj
    public ACBindings.UI64HashData BaseClass_UI64HashData; // ACBindings.UI64HashData

    // Child Types
    // NetBlob_vtbl
    public unsafe struct NetBlob_vtbl
    {
        // Members
        public System.IntPtr NetBlob_dtor_0; // function pointer

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
    public ACBindings.NetBlob.State state_;
    public byte* buf_;
    public uint bufSize_;
    public uint cMaxFragments_;
    public uint numFragments_;
    public ushort sender_;
    public ushort queueID_;
    public uint priority_;
    public ACBindings.NetBlob* waitNext_;
    public ulong savedNetBlobID_;

    // Generated Constructor
    public NetBlob(byte* buf, uint bufSize, short queue) {
        _ConstructorInternal(buf, bufSize, queue);
    }

    // Methods
    // void __thiscall NetBlob::ReceiveAddFragment(NetBlob*,BlobFrag*)
    public void ReceiveAddFragment(ACBindings.BlobFrag* frag) => ((delegate* unmanaged[Thiscall]<ref ACBindings.NetBlob, ACBindings.BlobFrag*, void>)0x0054A580)(ref this, frag);
    // void __thiscall NetBlob::ReceiveBlobReady(NetBlob*)
    public void ReceiveBlobReady() => ((delegate* unmanaged[Thiscall]<ref ACBindings.NetBlob, void>)0x0054A690)(ref this);
    // bool __thiscall NetBlob::Send(NetBlob*,unsigned __int16,unsigned int)
    public byte Send(ushort recip, uint priority) => ((delegate* unmanaged[Thiscall]<ref ACBindings.NetBlob, ushort, uint, byte>)0x0054A6A0)(ref this, recip, priority);
    // void __thiscall NetBlob::NetBlob(NetBlob*,unsigned __int8*,unsigned int,__int16)
    public void _ConstructorInternal(byte* buf, uint bufSize, short queue) => ((delegate* unmanaged[Thiscall]<ref ACBindings.NetBlob, byte*, uint, short, void>)0x0054A6F0)(ref this, buf, bufSize, queue);
    // unsigned int __thiscall NetBlob::GetPackSize(NetBlob*)
    public uint GetPackSize() => ((delegate* unmanaged[Thiscall]<ref ACBindings.NetBlob, uint>)0x0054A790)(ref this);
    // unsigned int __thiscall NetBlob::Fragmentize(NetBlob*,BlobFrag**)
    public uint Fragmentize(ACBindings.BlobFrag** ppCurFragment) => ((delegate* unmanaged[Thiscall]<ref ACBindings.NetBlob, ACBindings.BlobFrag**, uint>)0x0054A850)(ref this, ppCurFragment);
    // unsigned int __thiscall NetBlob::Pack(NetBlob*,void**,unsigned int)
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.NetBlob, void**, uint, uint>)0x0054A900)(ref this, addr, size);
    // int __thiscall NetBlob::UnPack(NetBlob*,void**,unsigned int)
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.NetBlob, void**, uint, int>)0x0054A9D0)(ref this, addr, size);
}

