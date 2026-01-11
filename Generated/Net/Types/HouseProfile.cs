namespace ACBindings.Internal;

public unsafe struct HouseProfile : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.PackObj BaseClass_PackObj; // ACBindings.Internal.PackObj

    // Child Types
    public unsafe struct HouseProfile_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.HouseProfile*, void> HouseProfile_dtor_0; // function pointer
        public fixed byte gap4[4];
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.HouseProfile*, uint> GetPackSize; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.HouseProfile*, void**, uint, uint> Pack; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.HouseProfile*, void**, uint, int> UnPack; // function pointer

        // Methods
    }

    // Members
    public uint _id;
    public uint _owner;
    public ACBindings.Internal.AC1Legacy.PStringBase__sbyte _name;
    public uint _bitmask;
    public ACBindings.Internal.HousePaymentList _buy;
    public ACBindings.Internal.HousePaymentList _rent;
    public int _min_level;
    public int _max_level;
    public int _min_alleg_rank;
    public int _max_alleg_rank;
    public int _maintenance_free;
    public uint _type;

    // Generated Constructor
    public HouseProfile() {
        _ConstructorInternal();
    }
    public HouseProfile(ACBindings.Internal.HouseProfile* rhs) {
        _ConstructorInternal(rhs);
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x005BC900
    /// int __thiscall HouseProfile::IsPaidInFull(HouseProfile*,HouseOp)</code>
    /// </summary>
    public int IsPaidInFull(ACBindings.Internal.HouseOp op) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.HouseProfile, ACBindings.Internal.HouseOp, int>)0x005BC900)(ref this, op);

    /// <summary>
    /// <code>Offset: 0x005BC930
    /// int __thiscall HouseProfile::Pay(HouseProfile*,HouseOp,const HousePayment*)</code>
    /// </summary>
    public int Pay(ACBindings.Internal.HouseOp op, ACBindings.Internal.HousePayment* pay) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.HouseProfile, ACBindings.Internal.HouseOp, ACBindings.Internal.HousePayment*, int>)0x005BC930)(ref this, op, pay);

    /// <summary>
    /// <code>Offset: 0x005BC960
    /// int __thiscall HouseProfile::RemovePayment(HouseProfile*,HouseOp,const HousePayment*)</code>
    /// </summary>
    public int RemovePayment(ACBindings.Internal.HouseOp op, ACBindings.Internal.HousePayment* pay) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.HouseProfile, ACBindings.Internal.HouseOp, ACBindings.Internal.HousePayment*, int>)0x005BC960)(ref this, op, pay);

    /// <summary>
    /// <code>Offset: 0x005BC990
    /// int __thiscall HouseProfile::ComposeText(_DWORD*,int,int)</code>
    /// </summary>
    public int ComposeText(int a2, int a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.HouseProfile, int, int, int>)0x005BC990)(ref this, a2, a3);

    /// <summary>
    /// <code>Offset: 0x005BC9C0
    /// int __thiscall HouseProfile::ComposeText2(_DWORD*,int,int)</code>
    /// </summary>
    public int ComposeText2(int a2, int a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.HouseProfile, int, int, int>)0x005BC9C0)(ref this, a2, a3);

    /// <summary>
    /// <code>Offset: 0x005BC9F0
    /// BOOL __thiscall HouseProfile::NeedsMore(_DWORD*,int,int)</code>
    /// </summary>
    public byte NeedsMore(int a2, int a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.HouseProfile, int, int, byte>)0x005BC9F0)(ref this, a2, a3);

    /// <summary>
    /// <code>Offset: 0x005BCA20
    /// unsigned int __thiscall HouseProfile::Pack(HouseProfile*,void**,unsigned int)</code>
    /// </summary>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.HouseProfile, void**, uint, uint>)0x005BCA20)(ref this, addr, size);

    /// <summary>
    /// <code>Offset: 0x005BCBD0
    /// int __thiscall HouseProfile::UnPack(HouseProfile*,unsigned int,void**,unsigned int)</code>
    /// </summary>
    public int UnPack(uint version, void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.HouseProfile, uint, void**, uint, int>)0x005BCBD0)(ref this, version, addr, size);

    /// <summary>
    /// <code>Offset: 0x005BCD60
    /// void __thiscall HouseProfile::HouseProfile(HouseProfile*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.HouseProfile, void>)0x005BCD60)(ref this);

    /// <summary>
    /// <code>Offset: 0x005BCDE0
    /// void __thiscall HouseProfile::~HouseProfile(HouseProfile*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.HouseProfile, void>)0x005BCDE0)(ref this);

    /// <summary>
    /// <code>Offset: 0x005BCE40
    /// void __thiscall HouseProfile::HouseProfile(HouseProfile*,const HouseProfile*)</code>
    /// </summary>
    public void _ConstructorInternal(ACBindings.Internal.HouseProfile* rhs) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.HouseProfile, ACBindings.Internal.HouseProfile*, void>)0x005BCE40)(ref this, rhs);

    /// <summary>
    /// <code>Offset: 0x005BCE90
    /// int __thiscall HouseProfile::UnPack(HouseProfile*,void**,unsigned int)</code>
    /// </summary>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.HouseProfile, void**, uint, int>)0x005BCE90)(ref this, addr, size);
}

