namespace ACBindings;

// NetKeyExch
public unsafe struct NetKeyExch
{
    // Base Classes
    public ACBindings.PackObj BaseClass_PackObj; // ACBindings.PackObj

    // Child Types
    // NetKeyExch_vtbl
    public unsafe struct NetKeyExch_vtbl
    {
        // Members
        public System.IntPtr NetKeyExch_dtor_0; // function pointer
        public fixed byte gap4[4];
        public System.IntPtr GetPackSize; // function pointer
        public System.IntPtr Pack; // function pointer
        public System.IntPtr UnPack; // function pointer

        // Methods
    }

    // Members
    public ACBindings.PortalDH* dh_;
    public ACBindings.AC1Legacy.vlong rnum_;
    public int fInitialized_;

    // Generated Constructor
    public NetKeyExch(ACBindings.PortalDH* dh) {
        _ConstructorInternal(dh);
    }

    // Methods
    // void __thiscall NetKeyExch::SetPrivateRandom(NetKeyExch*,const AC1Legacy::vlong*)
    public void SetPrivateRandom(ACBindings.AC1Legacy.vlong* rnum) => ((delegate* unmanaged[Thiscall]<ref ACBindings.NetKeyExch, ACBindings.AC1Legacy.vlong*, void>)0x0054A440)(ref this, rnum);
    // unsigned int __thiscall NetKeyExch::Pack(NetKeyExch*,void**,unsigned int)
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.NetKeyExch, void**, uint, uint>)0x0054A460)(ref this, addr, size);
    // int __thiscall NetKeyExch::UnPack(NetKeyExch*,void**,unsigned int)
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.NetKeyExch, void**, uint, int>)0x0054A4B0)(ref this, addr, size);
    // void __thiscall NetKeyExch::NetKeyExch(NetKeyExch*,PortalDH*)
    public void _ConstructorInternal(ACBindings.PortalDH* dh) => ((delegate* unmanaged[Thiscall]<ref ACBindings.NetKeyExch, ACBindings.PortalDH*, void>)0x0054A4F0)(ref this, dh);
    // unsigned int __thiscall NetKeyExch::GetPackSize(NetKeyExch*)
    public uint GetPackSize() => ((delegate* unmanaged[Thiscall]<ref ACBindings.NetKeyExch, uint>)0x0054A520)(ref this);
}

