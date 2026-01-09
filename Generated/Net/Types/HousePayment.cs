namespace ACBindings;

// HousePayment
public unsafe struct HousePayment : System.IDisposable
{
    // Base Classes
    public ACBindings.PackObj BaseClass_PackObj; // ACBindings.PackObj

    // Child Types
    // HousePayment_vtbl
    public unsafe struct HousePayment_vtbl
    {
        // Members
        public System.IntPtr HousePayment_dtor_0; // function pointer
        public fixed byte gap4[4];
        public System.IntPtr GetPackSize; // function pointer
        public System.IntPtr Pack; // function pointer
        public System.IntPtr UnPack; // function pointer

        // Methods
    }

    // Members
    public ACBindings.IDClass___tagDataID wcid;
    public int num;
    public int paid;
    public ACBindings.AC1Legacy.PStringBase__sbyte name;
    public ACBindings.AC1Legacy.PStringBase__sbyte pname;

    // Generated Constructor
    public HousePayment() {
        _ConstructorInternal();
    }
    public HousePayment(ACBindings.HousePayment* rhs) {
        _ConstructorInternal(rhs);
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods
    // void __thiscall HousePayment::HousePayment(HousePayment*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.HousePayment, void>)0x004A2960)(ref this);
    // void __thiscall HousePayment::~HousePayment(HousePayment*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.HousePayment, void>)0x004A29B0)(ref this);
    // int __thiscall HousePayment::PayWithTradeNote(HousePayment*,const int,const int)
    public int PayWithTradeNote(int amount, int value) => ((delegate* unmanaged[Thiscall]<ref ACBindings.HousePayment, int, int, int>)0x005BB720)(ref this, amount, value);
    // unsigned int __thiscall HousePayment::GetPackSize(HousePayment*)
    public uint GetPackSize() => ((delegate* unmanaged[Thiscall]<ref ACBindings.HousePayment, uint>)0x005BBAF0)(ref this);
    // unsigned int __thiscall HousePayment::Pack(HousePayment*,void**,unsigned int)
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.HousePayment, void**, uint, uint>)0x005BBB30)(ref this, addr, size);
    // void __thiscall HousePayment::HousePayment(HousePayment*,const HousePayment*)
    public void _ConstructorInternal(ACBindings.HousePayment* rhs) => ((delegate* unmanaged[Thiscall]<ref ACBindings.HousePayment, ACBindings.HousePayment*, void>)0x005BBBB0)(ref this, rhs);
    // int __thiscall HousePayment::UnPack(HousePayment*,void**,unsigned int)
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.HousePayment, void**, uint, int>)0x005BBC00)(ref this, addr, size);
    // int __thiscall HousePayment::ComposeText(_DWORD*,int)
    public int ComposeText(int a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.HousePayment, int, int>)0x005BC000)(ref this, a2);
    // int __thiscall HousePayment::ComposeText2(_DWORD*,int)
    public int ComposeText2(int a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.HousePayment, int, int>)0x005BC0C0)(ref this, a2);
}

