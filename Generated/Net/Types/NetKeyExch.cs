namespace ACBindings.Internal;

public unsafe struct NetKeyExch
{
    // Base Classes
    public ACBindings.Internal.PackObj BaseClass_PackObj; // ACBindings.Internal.PackObj

    // Child Types
    public unsafe struct NetKeyExch_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.NetKeyExch*, void> NetKeyExch_dtor_0; // function pointer
        public fixed byte gap4[4];
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.NetKeyExch*, uint> GetPackSize; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.NetKeyExch*, void**, uint, uint> Pack; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.NetKeyExch*, void**, uint, int> UnPack; // function pointer

        // Methods
    }

    // Members
    public ACBindings.Internal.PortalDH* dh_;
    public ACBindings.Internal.AC1Legacy.vlong rnum_;
    public int fInitialized_;

    // Generated Constructor
    public NetKeyExch(ACBindings.Internal.PortalDH* dh) {
        _ConstructorInternal(dh);
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x0054A440
    /// void __thiscall NetKeyExch::SetPrivateRandom(NetKeyExch*,const AC1Legacy::vlong*)</code>
    /// </summary>
    public void SetPrivateRandom(ACBindings.Internal.AC1Legacy.vlong* rnum) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.NetKeyExch, ACBindings.Internal.AC1Legacy.vlong*, void>)0x0054A440)(ref this, rnum);

    /// <summary>
    /// <code>Offset: 0x0054A460
    /// unsigned int __thiscall NetKeyExch::Pack(NetKeyExch*,void**,unsigned int)</code>
    /// </summary>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.NetKeyExch, void**, uint, uint>)0x0054A460)(ref this, addr, size);

    /// <summary>
    /// <code>Offset: 0x0054A4B0
    /// int __thiscall NetKeyExch::UnPack(NetKeyExch*,void**,unsigned int)</code>
    /// </summary>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.NetKeyExch, void**, uint, int>)0x0054A4B0)(ref this, addr, size);

    /// <summary>
    /// <code>Offset: 0x0054A4F0
    /// void __thiscall NetKeyExch::NetKeyExch(NetKeyExch*,PortalDH*)</code>
    /// </summary>
    public void _ConstructorInternal(ACBindings.Internal.PortalDH* dh) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.NetKeyExch, ACBindings.Internal.PortalDH*, void>)0x0054A4F0)(ref this, dh);

    /// <summary>
    /// <code>Offset: 0x0054A520
    /// unsigned int __thiscall NetKeyExch::GetPackSize(NetKeyExch*)</code>
    /// </summary>
    public uint GetPackSize() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.NetKeyExch, uint>)0x0054A520)(ref this);
}

