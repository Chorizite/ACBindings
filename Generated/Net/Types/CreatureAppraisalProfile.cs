namespace ACBindings;

// CreatureAppraisalProfile
public unsafe struct CreatureAppraisalProfile
{
    // Base Classes
    public ACBindings.PackObj BaseClass_PackObj; // ACBindings.PackObj

    // Child Types
    // CreatureAppraisalProfile_vtbl
    public unsafe struct CreatureAppraisalProfile_vtbl
    {
        // Members
        public System.IntPtr CreatureAppraisalProfile_dtor_0; // function pointer
        public fixed byte gap4[4];
        public System.IntPtr GetPackSize; // function pointer
        public System.IntPtr Pack; // function pointer
        public System.IntPtr UnPack; // function pointer

        // Methods
    }
    // CreatureAppraisalProfile::Enchantment_BFIndex
    public enum Enchantment_BFIndex : uint
    {
        BF_STRENGTH = 0x1,
        BF_ENDURANCE = 0x2,
        BF_QUICKNESS = 0x4,
        BF_COORDINATION = 0x8,
        BF_FOCUS = 0x10,
        BF_SELF = 0x20,
        BF_MAX_HEALTH = 0x40,
        BF_MAX_STAMINA = 0x80,
        BF_MAX_MANA = 0x100,
        BF_STRENGTH_HI = 0x10000,
        BF_ENDURANCE_HI = 0x20000,
        BF_QUICKNESS_HI = 0x40000,
        BF_COORDINATION_HI = 0x80000,
        BF_FOCUS_HI = 0x100000,
        BF_SELF_HI = 0x200000,
        BF_MAX_HEALTH_HI = 0x400000,
        BF_MAX_STAMINA_HI = 0x800000,
        BF_MAX_MANA_HI = 0x1000000,
        FORCE_Enchantment_BFIndex_32_BIT = 0x7FFFFFFF
    }

    // Members
    public uint strength;
    public uint endurance;
    public uint quickness;
    public uint coordination;
    public uint focus;
    public uint self;
    public uint health;
    public uint stamina;
    public uint mana;
    public uint max_health;
    public uint max_stamina;
    public uint max_mana;
    public uint enchantment_bitfield;

    // Generated Constructor
    public CreatureAppraisalProfile() {
        _ConstructorInternal();
    }

    // Methods
    // int __thiscall CreatureAppraisalProfile::InqAttribute(CreatureAppraisalProfile*,unsigned int,unsigned int*)
    public int InqAttribute(uint stype, uint* retval) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CreatureAppraisalProfile, uint, uint*, int>)0x005B6E30)(ref this, stype, retval);
    // int __thiscall CreatureAppraisalProfile::InqAttribute2nd(CreatureAppraisalProfile*,unsigned int,unsigned int*)
    public int InqAttribute2nd(uint stype, uint* retval) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CreatureAppraisalProfile, uint, uint*, int>)0x005B6ED0)(ref this, stype, retval);
    // int __thiscall CreatureAppraisalProfile::InqAttributeEnchantmentMod(CreatureAppraisalProfile*,unsigned int,int*)
    public int InqAttributeEnchantmentMod(uint stype, int* raised) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CreatureAppraisalProfile, uint, int*, int>)0x005B6F70)(ref this, stype, raised);
    // int __thiscall CreatureAppraisalProfile::InqAttribute2ndEnchantmentMod(CreatureAppraisalProfile*,unsigned int,int*)
    public int InqAttribute2ndEnchantmentMod(uint stype, int* raised) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CreatureAppraisalProfile, uint, int*, int>)0x005B7060)(ref this, stype, raised);
    // void __thiscall CreatureAppraisalProfile::CreatureAppraisalProfile(CreatureAppraisalProfile*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CreatureAppraisalProfile, void>)0x005B70D0)(ref this);
    // unsigned int __thiscall CreatureAppraisalProfile::Pack(CreatureAppraisalProfile*,void**,unsigned int)
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CreatureAppraisalProfile, void**, uint, uint>)0x005B7110)(ref this, addr, size);
    // int __thiscall CreatureAppraisalProfile::UnPack(CreatureAppraisalProfile*,void**,unsigned int)
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CreatureAppraisalProfile, void**, uint, int>)0x005B7240)(ref this, addr, size);
}

