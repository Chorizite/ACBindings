namespace ACBindings;

// HouseData
public unsafe struct HouseData : System.IDisposable
{
    // Base Classes
    public ACBindings.PackObj BaseClass_PackObj; // ACBindings.PackObj

    // Child Types
    // HouseData_vtbl
    public unsafe struct HouseData_vtbl
    {
        // Members
        public System.IntPtr HouseData_dtor_0; // function pointer
        public fixed byte gap4[4];
        public System.IntPtr GetPackSize; // function pointer
        public System.IntPtr Pack; // function pointer
        public System.IntPtr UnPack; // function pointer

        // Methods
    }

    // Members
    public int m_buy_time;
    public int m_rent_time;
    public ACBindings.HousePaymentList m_buy;
    public ACBindings.HousePaymentList m_rent;
    public ACBindings.Position m_pos;
    public uint m_type;
    public int m_maintenance_free;

    // Generated Constructor
    public HouseData() {
        _ConstructorInternal();
    }
    public HouseData(ACBindings.HouseData* rhs) {
        _ConstructorInternal(rhs);
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods
    // unsigned int __thiscall HouseData::GetPackSize(HouseData*)
    public uint GetPackSize() => ((delegate* unmanaged[Thiscall]<ref ACBindings.HouseData, uint>)0x005BC5F0)(ref this);
    // unsigned int __thiscall HouseData::Pack(HouseData*,void**,unsigned int)
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.HouseData, void**, uint, uint>)0x005BC640)(ref this, addr, size);
    // int __thiscall HouseData::UnPack(HouseData*,void**,unsigned int)
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.HouseData, void**, uint, int>)0x005BC6C0)(ref this, addr, size);
    // void __thiscall HouseData::HouseData(HouseData*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.HouseData, void>)0x005BC780)(ref this);
    // void __thiscall HouseData::HouseData(HouseData*,const HouseData*)
    public void _ConstructorInternal(ACBindings.HouseData* rhs) => ((delegate* unmanaged[Thiscall]<ref ACBindings.HouseData, ACBindings.HouseData*, void>)0x005BC890)(ref this, rhs);
    // void __thiscall HouseData::~HouseData(HouseData*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.HouseData, void>)0x006AC5A0)(ref this);
}

