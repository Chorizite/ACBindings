namespace ACBindings.Internal;

public unsafe struct HousePayment : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.PackObj BaseClass_PackObj; // ACBindings.Internal.PackObj

    // Child Types
    public unsafe struct HousePayment_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.HousePayment*, void> HousePayment_dtor_0; // function pointer
        public fixed byte gap4[4];
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.HousePayment*, uint> GetPackSize; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.HousePayment*, void**, uint, uint> Pack; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.HousePayment*, void**, uint, int> UnPack; // function pointer

        // Methods
    }

    // Members
    public ACBindings.Internal.IDClass____tagDataID wcid;
    public int num;
    public int paid;
    public ACBindings.Internal.AC1Legacy.PStringBase__sbyte name;
    public ACBindings.Internal.AC1Legacy.PStringBase__sbyte pname;

    // Generated Constructor
    public HousePayment() {
        _ConstructorInternal();
    }
    public HousePayment(ACBindings.Internal.HousePayment* rhs) {
        _ConstructorInternal(rhs);
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x004A2960
    /// void __thiscall HousePayment::HousePayment(HousePayment*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.HousePayment, void>)0x004A2960)(ref this);

    /// <summary>
    /// <code>Offset: 0x004A29B0
    /// void __thiscall HousePayment::~HousePayment(HousePayment*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.HousePayment, void>)0x004A29B0)(ref this);

    /// <summary>
    /// <code>Offset: 0x005BB720
    /// int __thiscall HousePayment::PayWithTradeNote(HousePayment*,const int,const int)</code>
    /// </summary>
    public int PayWithTradeNote(int amount, int value) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.HousePayment, int, int, int>)0x005BB720)(ref this, amount, value);

    /// <summary>
    /// <code>Offset: 0x005BBAF0
    /// unsigned int __thiscall HousePayment::GetPackSize(HousePayment*)</code>
    /// </summary>
    public uint GetPackSize() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.HousePayment, uint>)0x005BBAF0)(ref this);

    /// <summary>
    /// <code>Offset: 0x005BBB30
    /// unsigned int __thiscall HousePayment::Pack(HousePayment*,void**,unsigned int)</code>
    /// </summary>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.HousePayment, void**, uint, uint>)0x005BBB30)(ref this, addr, size);

    /// <summary>
    /// <code>Offset: 0x005BBBB0
    /// void __thiscall HousePayment::HousePayment(HousePayment*,const HousePayment*)</code>
    /// </summary>
    public void _ConstructorInternal(ACBindings.Internal.HousePayment* rhs) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.HousePayment, ACBindings.Internal.HousePayment*, void>)0x005BBBB0)(ref this, rhs);

    /// <summary>
    /// <code>Offset: 0x005BBC00
    /// int __thiscall HousePayment::UnPack(HousePayment*,void**,unsigned int)</code>
    /// </summary>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.HousePayment, void**, uint, int>)0x005BBC00)(ref this, addr, size);

    /// <summary>
    /// <code>Offset: 0x005BC000
    /// int __thiscall HousePayment::ComposeText(_DWORD*,int)</code>
    /// </summary>
    public int ComposeText(int a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.HousePayment, int, int>)0x005BC000)(ref this, a2);

    /// <summary>
    /// <code>Offset: 0x005BC0C0
    /// int __thiscall HousePayment::ComposeText2(_DWORD*,int)</code>
    /// </summary>
    public int ComposeText2(int a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.HousePayment, int, int>)0x005BC0C0)(ref this, a2);
}

