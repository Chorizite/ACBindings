namespace ACBindings.Internal;

public unsafe struct AppraisalProfile : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.PackObj BaseClass_PackObj; // ACBindings.Internal.PackObj

    // Child Types
    public unsafe struct AppraisalProfile_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.AppraisalProfile*, void> AppraisalProfile_dtor_0; // function pointer
        public fixed byte gap4[4];
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.AppraisalProfile*, uint> GetPackSize; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.AppraisalProfile*, void**, uint, uint> Pack; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.AppraisalProfile*, void**, uint, int> UnPack; // function pointer

        // Methods
    }
    // AppraisalProfile::ArmorEnchantment_BFIndex
    public enum ArmorEnchantment_BFIndex : uint
    {
        BF_ARMOR_LEVEL = 0x1,
        BF_ARMOR_MOD_VS_SLASH = 0x2,
        BF_ARMOR_MOD_VS_PIERCE = 0x4,
        BF_ARMOR_MOD_VS_BLUDGEON = 0x8,
        BF_ARMOR_MOD_VS_COLD = 0x10,
        BF_ARMOR_MOD_VS_FIRE = 0x20,
        BF_ARMOR_MOD_VS_ACID = 0x40,
        BF_ARMOR_MOD_VS_ELECTRIC = 0x80,
        BF_ARMOR_MOD_VS_NETHER = 0x100,
        BF_ARMOR_LEVEL_HI = 0x10000,
        BF_ARMOR_MOD_VS_SLASH_HI = 0x20000,
        BF_ARMOR_MOD_VS_PIERCE_HI = 0x40000,
        BF_ARMOR_MOD_VS_BLUDGEON_HI = 0x80000,
        BF_ARMOR_MOD_VS_COLD_HI = 0x100000,
        BF_ARMOR_MOD_VS_FIRE_HI = 0x200000,
        BF_ARMOR_MOD_VS_ACID_HI = 0x400000,
        BF_ARMOR_MOD_VS_ELECTRIC_HI = 0x800000,
        BF_ARMOR_MOD_VS_NETHER_HI = 0x1000000,
        FORCE_ArmorEnchantment_BFIndex_32_BIT = 0x7FFFFFFF
    }
    // AppraisalProfile::ResistanceEnchantment_BFIndex
    public enum ResistanceEnchantment_BFIndex : uint
    {
        BF_RESIST_SLASH = 0x1,
        BF_RESIST_PIERCE = 0x2,
        BF_RESIST_BLUDGEON = 0x4,
        BF_RESIST_FIRE = 0x8,
        BF_RESIST_COLD = 0x10,
        BF_RESIST_ACID = 0x20,
        BF_RESIST_ELECTRIC = 0x40,
        BF_RESIST_HEALTH_BOOST = 0x80,
        BF_RESIST_STAMINA_DRAIN = 0x100,
        BF_RESIST_STAMINA_BOOST = 0x200,
        BF_RESIST_MANA_DRAIN = 0x400,
        BF_RESIST_MANA_BOOST = 0x800,
        BF_MANA_CON_MOD = 0x1000,
        BF_ELE_DAMAGE_MOD = 0x2000,
        BF_RESIST_NETHER = 0x4000,
        BF_RESIST_SLASH_HI = 0x10000,
        BF_RESIST_PIERCE_HI = 0x20000,
        BF_RESIST_BLUDGEON_HI = 0x40000,
        BF_RESIST_FIRE_HI = 0x80000,
        BF_RESIST_COLD_HI = 0x100000,
        BF_RESIST_ACID_HI = 0x200000,
        BF_RESIST_ELECTRIC_HI = 0x400000,
        BF_RESIST_HEALTH_BOOST_HI = 0x800000,
        BF_RESIST_STAMINA_DRAIN_HI = 0x1000000,
        BF_RESIST_STAMINA_BOOST_HI = 0x2000000,
        BF_RESIST_MANA_DRAIN_HI = 0x4000000,
        BF_RESIST_MANA_BOOST_HI = 0x8000000,
        BF_MANA_CON_MOD_HI = 0x10000000,
        BF_ELE_DAMAGE_MOD_HI = 0x20000000,
        BF_RESIST_NETHER_HI = 0x40000000,
        FORCE_ResistanceEnchantment_BFIndex_32_BIT = 0x7FFFFFFF
    }
    // AppraisalProfile::WeaponEnchantment_BFIndex
    public enum WeaponEnchantment_BFIndex : uint
    {
        BF_WEAPON_OFFENSE = 0x1,
        BF_WEAPON_DEFENSE = 0x2,
        BF_WEAPON_TIME = 0x4,
        BF_DAMAGE = 0x8,
        BF_DAMAGE_VARIANCE = 0x10,
        BF_DAMAGE_MOD = 0x20,
        BF_WEAPON_OFFENSE_HI = 0x10000,
        BF_WEAPON_DEFENSE_HI = 0x20000,
        BF_WEAPON_TIME_HI = 0x40000,
        BF_DAMAGE_HI = 0x80000,
        BF_DAMAGE_VARIANCE_HI = 0x100000,
        BF_DAMAGE_MOD_HI = 0x200000,
        FORCE_WeaponEnchantment_BFIndex_32_BIT = 0x7FFFFFFF
    }

    // Members
    public int success_flag;
    public ACBindings.Internal.CreatureAppraisalProfile* creature_profile;
    public ACBindings.Internal.HookAppraisalProfile* hook_profile;
    public ACBindings.Internal.WeaponProfile* weapon_profile;
    public ACBindings.Internal.ArmorProfile* armor_profile;
    public System.IntPtr _intStatsTable;
    public System.IntPtr _int64StatsTable;
    public System.IntPtr _boolStatsTable;
    public System.IntPtr _floatStatsTable;
    public System.IntPtr _strStatsTable;
    public System.IntPtr _didStatsTable;
    public System.IntPtr _spellBook;
    public uint armor_ench_bitfield;
    public uint weapon_ench_bitfield;
    public uint resist_ench_bitfield;
    public int base_armor_head;
    public int base_armor_chest;
    public int base_armor_groin;
    public int base_armor_bicep;
    public int base_armor_wrist;
    public int base_armor_hand;
    public int base_armor_thigh;
    public int base_armor_shin;
    public int base_armor_foot;

    // Generated Constructor
    public AppraisalProfile() {
        _ConstructorInternal();
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x005B3BB0
    /// void __thiscall AppraisalProfile::Clear(AppraisalProfile*)</code>
    /// </summary>
    public void Clear() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AppraisalProfile, void>)0x005B3BB0)(ref this);

    /// <summary>
    /// <code>Offset: 0x005B3CA0
    /// int __thiscall AppraisalProfile::InqCreature(AppraisalProfile*,CreatureAppraisalProfile*)</code>
    /// </summary>
    public int InqCreature(ACBindings.Internal.CreatureAppraisalProfile* cap) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AppraisalProfile, ACBindings.Internal.CreatureAppraisalProfile*, int>)0x005B3CA0)(ref this, cap);

    /// <summary>
    /// <code>Offset: 0x005B3CC0
    /// int __thiscall AppraisalProfile::InqIntEnchantmentMod(AppraisalProfile*,unsigned int,int*)</code>
    /// </summary>
    public int InqIntEnchantmentMod(uint stype, int* raised) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AppraisalProfile, uint, int*, int>)0x005B3CC0)(ref this, stype, raised);

    /// <summary>
    /// <code>Offset: 0x005B3D20
    /// int __thiscall AppraisalProfile::InqFloatEnchantmentMod(AppraisalProfile*,unsigned int,int*)</code>
    /// </summary>
    public int InqFloatEnchantmentMod(uint stype, int* raised) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AppraisalProfile, uint, int*, int>)0x005B3D20)(ref this, stype, raised);

    /// <summary>
    /// <code>Offset: 0x005B4040
    /// int __thiscall AppraisalProfile::IsHookedItemInscribable(AppraisalProfile*)</code>
    /// </summary>
    public int IsHookedItemInscribable() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AppraisalProfile, int>)0x005B4040)(ref this);

    /// <summary>
    /// <code>Offset: 0x005B4050
    /// int __thiscall AppraisalProfile::IsHookedItemHealer(AppraisalProfile*)</code>
    /// </summary>
    public int IsHookedItemHealer() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AppraisalProfile, int>)0x005B4050)(ref this);

    /// <summary>
    /// <code>Offset: 0x005B4060
    /// int __thiscall AppraisalProfile::IsHookedItemLockpick(AppraisalProfile*)</code>
    /// </summary>
    public int IsHookedItemLockpick() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AppraisalProfile, int>)0x005B4060)(ref this);

    /// <summary>
    /// <code>Offset: 0x005B4070
    /// unsigned int __thiscall AppraisalProfile::GetHookedItemValidLocations(AppraisalProfile*)</code>
    /// </summary>
    public uint GetHookedItemValidLocations() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AppraisalProfile, uint>)0x005B4070)(ref this);

    /// <summary>
    /// <code>Offset: 0x005B4080
    /// AMMO_TYPE __thiscall AppraisalProfile::GetHookedItemAmmoType(AppraisalProfile*)</code>
    /// </summary>
    public ACBindings.Internal.AMMO_TYPE GetHookedItemAmmoType() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AppraisalProfile, ACBindings.Internal.AMMO_TYPE>)0x005B4080)(ref this);

    /// <summary>
    /// <code>Offset: 0x005B4090
    /// void __thiscall AppraisalProfile::SetPackHeader(AppraisalProfile*,unsigned int*)</code>
    /// </summary>
    public void SetPackHeader(uint* bitfield) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AppraisalProfile, uint*, void>)0x005B4090)(ref this, bitfield);

    /// <summary>
    /// <code>Offset: 0x005B4180
    /// unsigned int __thiscall AppraisalProfile::pack_size(AppraisalProfile*)</code>
    /// </summary>
    public uint pack_size() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AppraisalProfile, uint>)0x005B4180)(ref this);

    /// <summary>
    /// <code>Offset: 0x005B4350
    /// void __thiscall AppraisalProfile::AppraisalProfile(AppraisalProfile*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AppraisalProfile, void>)0x005B4350)(ref this);

    /// <summary>
    /// <code>Offset: 0x005B4390
    /// void __thiscall AppraisalProfile::~AppraisalProfile(AppraisalProfile*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AppraisalProfile, void>)0x005B4390)(ref this);

    /// <summary>
    /// <code>Offset: 0x005B4420
    /// int __thiscall AppraisalProfile::InqArmor(AppraisalProfile*,ArmorProfile*)</code>
    /// </summary>
    public int InqArmor(ACBindings.Internal.ArmorProfile* aap) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AppraisalProfile, ACBindings.Internal.ArmorProfile*, int>)0x005B4420)(ref this, aap);

    /// <summary>
    /// <code>Offset: 0x005B4470
    /// unsigned int __thiscall AppraisalProfile::Pack(AppraisalProfile*,void**,unsigned int)</code>
    /// </summary>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AppraisalProfile, void**, uint, uint>)0x005B4470)(ref this, addr, size);

    /// <summary>
    /// <code>Offset: 0x005B48C0
    /// int __thiscall AppraisalProfile::InqWeapon(AppraisalProfile*,WeaponProfile*)</code>
    /// </summary>
    public int InqWeapon(ACBindings.Internal.WeaponProfile* wap) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AppraisalProfile, ACBindings.Internal.WeaponProfile*, int>)0x005B48C0)(ref this, wap);

    /// <summary>
    /// <code>Offset: 0x005B48E0
    /// int __thiscall AppraisalProfile::InqInt(AppraisalProfile*,unsigned int,int*)</code>
    /// </summary>
    public int InqInt(uint stype, int* retval) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AppraisalProfile, uint, int*, int>)0x005B48E0)(ref this, stype, retval);

    /// <summary>
    /// <code>Offset: 0x005B4910
    /// int __thiscall AppraisalProfile::InqInt64(AppraisalProfile*,unsigned int,__int64*)</code>
    /// </summary>
    public int InqInt64(uint stype, long* retval) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AppraisalProfile, uint, long*, int>)0x005B4910)(ref this, stype, retval);

    /// <summary>
    /// <code>Offset: 0x005B4940
    /// int __thiscall AppraisalProfile::InqBool(AppraisalProfile*,unsigned int,int*)</code>
    /// </summary>
    public int InqBool(uint stype, int* retval) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AppraisalProfile, uint, int*, int>)0x005B4940)(ref this, stype, retval);

    /// <summary>
    /// <code>Offset: 0x005B4970
    /// int __thiscall AppraisalProfile::InqFloat(AppraisalProfile*,unsigned int,long double*)</code>
    /// </summary>
    public int InqFloat(uint stype, double* retval) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AppraisalProfile, uint, double*, int>)0x005B4970)(ref this, stype, retval);

    /// <summary>
    /// <code>Offset: 0x005B49A0
    /// int __thiscall AppraisalProfile::InqDataID(_DWORD*,int,_DWORD*)</code>
    /// </summary>
    public int InqDataID(int a2, int* a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AppraisalProfile, int, int*, int>)0x005B49A0)(ref this, a2, a3);

    /// <summary>
    /// <code>Offset: 0x005B4A00
    /// int __thiscall AppraisalProfile::InqString(_DWORD*,int,int*)</code>
    /// </summary>
    public int InqString(int a2, int* a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AppraisalProfile, int, int*, int>)0x005B4A00)(ref this, a2, a3);

    /// <summary>
    /// <code>Offset: 0x005B4A30
    /// int __thiscall AppraisalProfile::UnPack(AppraisalProfile*,void**,unsigned int)</code>
    /// </summary>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AppraisalProfile, void**, uint, int>)0x005B4A30)(ref this, addr, size);
}

