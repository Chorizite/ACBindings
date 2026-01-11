namespace ACBindings.Internal;

public unsafe struct VendorProfile
{
    // Base Classes
    public ACBindings.Internal.PackObj BaseClass_PackObj; // ACBindings.Internal.PackObj

    // Child Types
    public unsafe struct VendorProfile_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.VendorProfile*, void> VendorProfile_dtor_0; // function pointer
        public fixed byte gap4[4];
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.VendorProfile*, uint> GetPackSize; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.VendorProfile*, void**, uint, uint> Pack; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.VendorProfile*, void**, uint, int> UnPack; // function pointer

        // Methods
    }

    // Members
    public uint item_types;
    public int min_value;
    public int max_value;
    public int magic;
    public float buy_price;
    public float sell_price;
    public ACBindings.Internal.IDClass____tagDataID trade_id;
    public int trade_num;
    public ACBindings.Internal.AC1Legacy.PStringBase__sbyte trade_name;

    // Generated Constructor
    public VendorProfile() {
        _ConstructorInternal();
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x005D2A90
    /// unsigned int __thiscall VendorProfile::InqAcceptability(VendorProfile*,PublicWeenieDesc*)</code>
    /// </summary>
    public uint InqAcceptability(ACBindings.Internal.PublicWeenieDesc* item) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.VendorProfile, ACBindings.Internal.PublicWeenieDesc*, uint>)0x005D2A90)(ref this, item);

    /// <summary>
    /// <code>Offset: 0x005D2B00
    /// int __thiscall VendorProfile::VendorSellPrice(VendorProfile*,PublicWeenieDesc*,unsigned int)</code>
    /// </summary>
    public int VendorSellPrice(ACBindings.Internal.PublicWeenieDesc* item, uint subAmount) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.VendorProfile, ACBindings.Internal.PublicWeenieDesc*, uint, int>)0x005D2B00)(ref this, item, subAmount);

    /// <summary>
    /// <code>Offset: 0x005D2B50
    /// int __thiscall VendorProfile::IsAcceptable(VendorProfile*,PublicWeenieDesc*)</code>
    /// </summary>
    public int IsAcceptable(ACBindings.Internal.PublicWeenieDesc* item) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.VendorProfile, ACBindings.Internal.PublicWeenieDesc*, int>)0x005D2B50)(ref this, item);

    /// <summary>
    /// <code>Offset: 0x005D2B70
    /// int __thiscall VendorProfile::VendorBuyPrice(VendorProfile*,PublicWeenieDesc*,PublicWeenieDesc*)</code>
    /// </summary>
    public int VendorBuyPrice(ACBindings.Internal.PublicWeenieDesc* vendor, ACBindings.Internal.PublicWeenieDesc* item) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.VendorProfile, ACBindings.Internal.PublicWeenieDesc*, ACBindings.Internal.PublicWeenieDesc*, int>)0x005D2B70)(ref this, vendor, item);

    /// <summary>
    /// <code>Offset: 0x005D2BD0
    /// _DWORD* __thiscall VendorProfile::VendorTradeCurrency(_DWORD*,_DWORD*)</code>
    /// </summary>
    public int* VendorTradeCurrency(int* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.VendorProfile, int*, int*>)0x005D2BD0)(ref this, a2);

    /// <summary>
    /// <code>Offset: 0x005D2BE0
    /// void __thiscall VendorProfile::VendorProfile(VendorProfile*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.VendorProfile, void>)0x005D2BE0)(ref this);

    /// <summary>
    /// <code>Offset: 0x005D2C60
    /// unsigned int __thiscall VendorProfile::GetPackSize(VendorProfile*)</code>
    /// </summary>
    public uint GetPackSize() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.VendorProfile, uint>)0x005D2C60)(ref this);

    /// <summary>
    /// <code>Offset: 0x005D2C80
    /// unsigned int __thiscall VendorProfile::Pack(VendorProfile*,void**,unsigned int)</code>
    /// </summary>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.VendorProfile, void**, uint, uint>)0x005D2C80)(ref this, addr, size);

    /// <summary>
    /// <code>Offset: 0x005D2D20
    /// int __thiscall VendorProfile::UnPack(VendorProfile*,void**,unsigned int)</code>
    /// </summary>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.VendorProfile, void**, uint, int>)0x005D2D20)(ref this, addr, size);
}

