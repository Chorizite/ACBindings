namespace ACBindings;

// HouseProfile
public unsafe struct HouseProfile : System.IDisposable
{
    // Base Classes
    public ACBindings.PackObj BaseClass_PackObj; // ACBindings.PackObj

    // Child Types
    // HouseProfile_vtbl
    public unsafe struct HouseProfile_vtbl
    {
        // Members
        public System.IntPtr HouseProfile_dtor_0; // function pointer
        public fixed byte gap4[4];
        public System.IntPtr GetPackSize; // function pointer
        public System.IntPtr Pack; // function pointer
        public System.IntPtr UnPack; // function pointer

        // Methods
    }

    // Members
    public uint _id;
    public uint _owner;
    public ACBindings.AC1Legacy.PStringBase__sbyte _name;
    public uint _bitmask;
    public ACBindings.HousePaymentList _buy;
    public ACBindings.HousePaymentList _rent;
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
    public HouseProfile(ACBindings.HouseProfile* rhs) {
        _ConstructorInternal(rhs);
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods
    // int __thiscall HouseProfile::IsPaidInFull(HouseProfile*,HouseOp)
    public int IsPaidInFull(ACBindings.HouseOp op) => ((delegate* unmanaged[Thiscall]<ref ACBindings.HouseProfile, ACBindings.HouseOp, int>)0x005BC900)(ref this, op);
    // int __thiscall HouseProfile::Pay(HouseProfile*,HouseOp,const HousePayment*)
    public int Pay(ACBindings.HouseOp op, ACBindings.HousePayment* pay) => ((delegate* unmanaged[Thiscall]<ref ACBindings.HouseProfile, ACBindings.HouseOp, ACBindings.HousePayment*, int>)0x005BC930)(ref this, op, pay);
    // int __thiscall HouseProfile::RemovePayment(HouseProfile*,HouseOp,const HousePayment*)
    public int RemovePayment(ACBindings.HouseOp op, ACBindings.HousePayment* pay) => ((delegate* unmanaged[Thiscall]<ref ACBindings.HouseProfile, ACBindings.HouseOp, ACBindings.HousePayment*, int>)0x005BC960)(ref this, op, pay);
    // int __thiscall HouseProfile::ComposeText(_DWORD*,int,int)
    public int ComposeText(int a2, int a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.HouseProfile, int, int, int>)0x005BC990)(ref this, a2, a3);
    // int __thiscall HouseProfile::ComposeText2(_DWORD*,int,int)
    public int ComposeText2(int a2, int a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.HouseProfile, int, int, int>)0x005BC9C0)(ref this, a2, a3);
    // BOOL __thiscall HouseProfile::NeedsMore(_DWORD*,int,int)
    public byte NeedsMore(int a2, int a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.HouseProfile, int, int, byte>)0x005BC9F0)(ref this, a2, a3);
    // unsigned int __thiscall HouseProfile::Pack(HouseProfile*,void**,unsigned int)
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.HouseProfile, void**, uint, uint>)0x005BCA20)(ref this, addr, size);
    // int __thiscall HouseProfile::UnPack(HouseProfile*,unsigned int,void**,unsigned int)
    public int UnPack(uint version, void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.HouseProfile, uint, void**, uint, int>)0x005BCBD0)(ref this, version, addr, size);
    // void __thiscall HouseProfile::HouseProfile(HouseProfile*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.HouseProfile, void>)0x005BCD60)(ref this);
    // void __thiscall HouseProfile::~HouseProfile(HouseProfile*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.HouseProfile, void>)0x005BCDE0)(ref this);
    // void __thiscall HouseProfile::HouseProfile(HouseProfile*,const HouseProfile*)
    public void _ConstructorInternal(ACBindings.HouseProfile* rhs) => ((delegate* unmanaged[Thiscall]<ref ACBindings.HouseProfile, ACBindings.HouseProfile*, void>)0x005BCE40)(ref this, rhs);
    // int __thiscall HouseProfile::UnPack(HouseProfile*,void**,unsigned int)
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.HouseProfile, void**, uint, int>)0x005BCE90)(ref this, addr, size);
}

