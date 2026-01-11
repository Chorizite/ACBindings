namespace ACBindings.Internal;

public unsafe struct HouseData : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.PackObj BaseClass_PackObj; // ACBindings.Internal.PackObj

    // Child Types
    public unsafe struct HouseData_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.HouseData*, void> HouseData_dtor_0; // function pointer
        public fixed byte gap4[4];
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.HouseData*, uint> GetPackSize; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.HouseData*, void**, uint, uint> Pack; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.HouseData*, void**, uint, int> UnPack; // function pointer

        // Methods
    }

    // Members
    public int m_buy_time;
    public int m_rent_time;
    public ACBindings.Internal.HousePaymentList m_buy;
    public ACBindings.Internal.HousePaymentList m_rent;
    public ACBindings.Internal.Position m_pos;
    public uint m_type;
    public int m_maintenance_free;

    // Generated Constructor
    public HouseData() {
        _ConstructorInternal();
    }
    public HouseData(ACBindings.Internal.HouseData* rhs) {
        _ConstructorInternal(rhs);
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x005BC5F0
    /// unsigned int __thiscall HouseData::GetPackSize(HouseData*)</code>
    /// </summary>
    public uint GetPackSize() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.HouseData, uint>)0x005BC5F0)(ref this);

    /// <summary>
    /// <code>Offset: 0x005BC640
    /// unsigned int __thiscall HouseData::Pack(HouseData*,void**,unsigned int)</code>
    /// </summary>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.HouseData, void**, uint, uint>)0x005BC640)(ref this, addr, size);

    /// <summary>
    /// <code>Offset: 0x005BC6C0
    /// int __thiscall HouseData::UnPack(HouseData*,void**,unsigned int)</code>
    /// </summary>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.HouseData, void**, uint, int>)0x005BC6C0)(ref this, addr, size);

    /// <summary>
    /// <code>Offset: 0x005BC780
    /// void __thiscall HouseData::HouseData(HouseData*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.HouseData, void>)0x005BC780)(ref this);

    /// <summary>
    /// <code>Offset: 0x005BC890
    /// void __thiscall HouseData::HouseData(HouseData*,const HouseData*)</code>
    /// </summary>
    public void _ConstructorInternal(ACBindings.Internal.HouseData* rhs) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.HouseData, ACBindings.Internal.HouseData*, void>)0x005BC890)(ref this, rhs);

    /// <summary>
    /// <code>Offset: 0x006AC5A0
    /// void __thiscall HouseData::~HouseData(HouseData*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.HouseData, void>)0x006AC5A0)(ref this);
}

