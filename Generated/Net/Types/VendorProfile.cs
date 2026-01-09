namespace ACBindings;

// VendorProfile
public unsafe struct VendorProfile
{
    // Base Classes
    public ACBindings.PackObj BaseClass_PackObj; // ACBindings.PackObj

    // Child Types
    // VendorProfile_vtbl
    public unsafe struct VendorProfile_vtbl
    {
        // Members
        public System.IntPtr VendorProfile_dtor_0; // function pointer
        public fixed byte gap4[4];
        public System.IntPtr GetPackSize; // function pointer
        public System.IntPtr Pack; // function pointer
        public System.IntPtr UnPack; // function pointer

        // Methods
    }

    // Members
    public uint item_types;
    public int min_value;
    public int max_value;
    public int magic;
    public float buy_price;
    public float sell_price;
    public ACBindings.IDClass___tagDataID trade_id;
    public int trade_num;
    public ACBindings.AC1Legacy.PStringBase__sbyte trade_name;

    // Generated Constructor
    public VendorProfile() {
        _ConstructorInternal();
    }

    // Methods
    // unsigned int __thiscall VendorProfile::InqAcceptability(VendorProfile*,PublicWeenieDesc*)
    public uint InqAcceptability(ACBindings.PublicWeenieDesc* item) => ((delegate* unmanaged[Thiscall]<ref ACBindings.VendorProfile, ACBindings.PublicWeenieDesc*, uint>)0x005D2A90)(ref this, item);
    // int __thiscall VendorProfile::VendorSellPrice(VendorProfile*,PublicWeenieDesc*,unsigned int)
    public int VendorSellPrice(ACBindings.PublicWeenieDesc* item, uint subAmount) => ((delegate* unmanaged[Thiscall]<ref ACBindings.VendorProfile, ACBindings.PublicWeenieDesc*, uint, int>)0x005D2B00)(ref this, item, subAmount);
    // int __thiscall VendorProfile::IsAcceptable(VendorProfile*,PublicWeenieDesc*)
    public int IsAcceptable(ACBindings.PublicWeenieDesc* item) => ((delegate* unmanaged[Thiscall]<ref ACBindings.VendorProfile, ACBindings.PublicWeenieDesc*, int>)0x005D2B50)(ref this, item);
    // int __thiscall VendorProfile::VendorBuyPrice(VendorProfile*,PublicWeenieDesc*,PublicWeenieDesc*)
    public int VendorBuyPrice(ACBindings.PublicWeenieDesc* vendor, ACBindings.PublicWeenieDesc* item) => ((delegate* unmanaged[Thiscall]<ref ACBindings.VendorProfile, ACBindings.PublicWeenieDesc*, ACBindings.PublicWeenieDesc*, int>)0x005D2B70)(ref this, vendor, item);
    // _DWORD* __thiscall VendorProfile::VendorTradeCurrency(_DWORD*,_DWORD*)
    public int* VendorTradeCurrency(int* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.VendorProfile, int*, int*>)0x005D2BD0)(ref this, a2);
    // void __thiscall VendorProfile::VendorProfile(VendorProfile*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.VendorProfile, void>)0x005D2BE0)(ref this);
    // unsigned int __thiscall VendorProfile::GetPackSize(VendorProfile*)
    public uint GetPackSize() => ((delegate* unmanaged[Thiscall]<ref ACBindings.VendorProfile, uint>)0x005D2C60)(ref this);
    // unsigned int __thiscall VendorProfile::Pack(VendorProfile*,void**,unsigned int)
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.VendorProfile, void**, uint, uint>)0x005D2C80)(ref this, addr, size);
    // int __thiscall VendorProfile::UnPack(VendorProfile*,void**,unsigned int)
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.VendorProfile, void**, uint, int>)0x005D2D20)(ref this, addr, size);
}

