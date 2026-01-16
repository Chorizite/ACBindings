namespace ACBindings.Internal;


/// <summary>
/// Represents a comprehensive appraisal profile containing statistics, enchantments, and subprofiles for creatures, weapons, armor, and hooks within the game system. Holds success status, various stat tables, and optional component profiles used during item inspection and crafting.
/// </summary>
public unsafe struct AppraisalProfile : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.PackObj BaseClass_PackObj; // ACBindings.Internal.PackObj

    // Child Types
    public unsafe struct AppraisalProfile_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.AppraisalProfile*, void> AppraisalProfile_dtor_0; // function pointer
        public fixed byte gap4[4];
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.AppraisalProfile*, uint> GetPackSize; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.AppraisalProfile*, void**, uint, uint> Pack; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.AppraisalProfile*, void**, uint, int> UnPack; // function pointer

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

    /// <summary>Resets the appraisal profile by releasing associated statistic tables and subprofiles, clearing enchantment flags and base armor values, then marks the profile as successful.
    /// <code>Offset: 0x005B3BB0
    /// void __thiscall AppraisalProfile::Clear(AppraisalProfile*)</code>
    /// </summary>
    public void Clear() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AppraisalProfile, void>)0x005B3BB0)(ref this);

    /// <summary>Copies the internal creature appraisal data into the supplied buffer when available.
    /// <code>Offset: 0x005B3CA0
    /// int __thiscall AppraisalProfile::InqCreature(AppraisalProfile*,CreatureAppraisalProfile*)</code>
    /// </summary>
    /// <param name="cap">The object to receive a copy of the stored creature profile.</param>
    /// <returns>Nonzero if a profile was present and copied; zero otherwise.</returns>
    public int InqCreature(ACBindings.Internal.CreatureAppraisalProfile* cap) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AppraisalProfile, ACBindings.Internal.CreatureAppraisalProfile*, int>)0x005B3CA0)(ref this, cap);

    /// <summary>Determines whether a profile has an integer enchantment modifier for the specified stat type and, if so, outputs that modifier.
    /// <code>Offset: 0x005B3CC0
    /// int __thiscall AppraisalProfile::InqIntEnchantmentMod(AppraisalProfile*,unsigned int,int*)</code>
    /// </summary>
    /// <param name="stype">Stat type identifier indicating which enchantment to query (e.g., 0x1C for armor, 0x2C or 0x31 for weapon).</param>
    /// <param name="raised">Output parameter receiving the modifier value when present; otherwise left as zero.</param>
    /// <returns>Non‑zero if an appropriate modifier is present; zero otherwise.</returns>
    public int InqIntEnchantmentMod(uint stype, int* raised) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AppraisalProfile, uint, int*, int>)0x005B3CC0)(ref this, stype, raised);

    /// <summary>Determines whether a given enchantment type is applied to this appraisal profile and returns its modifier value through the raised parameter.
    /// <code>Offset: 0x005B3D20
    /// int __thiscall AppraisalProfile::InqFloatEnchantmentMod(AppraisalProfile*,unsigned int,int*)</code>
    /// </summary>
    /// <param name="stype">Identifier of the enchantment type to query.</param>
    /// <param name="raised">Output pointer that receives the bitmask value if the enchantment is present; set to zero otherwise.</param>
    /// <returns>Non‑zero (1) when the specified enchantment is active, 0 otherwise.</returns>
    public int InqFloatEnchantmentMod(uint stype, int* raised) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AppraisalProfile, uint, int*, int>)0x005B3D20)(ref this, stype, raised);

    /// <summary>Determines whether the hooked item associated with this appraisal profile can be inscribed.
    /// <code>Offset: 0x005B4040
    /// int __thiscall AppraisalProfile::IsHookedItemInscribable(AppraisalProfile*)</code>
    /// </summary>
    /// <returns>Non‑zero when a hook profile is present and its first bit indicates inscribability; otherwise returns 0.</returns>
    public int IsHookedItemInscribable() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AppraisalProfile, int>)0x005B4040)(ref this);

    /// <summary>Determines whether the hooked appraisal profile represents a healer item by inspecting its internal bitfield.
    /// <code>Offset: 0x005B4050
    /// int __thiscall AppraisalProfile::IsHookedItemHealer(AppraisalProfile*)</code>
    /// </summary>
    /// <returns>Non‑zero if the hook profile exists and its healer flag (bit 1) is set; otherwise zero.</returns>
    public int IsHookedItemHealer() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AppraisalProfile, int>)0x005B4050)(ref this);

    /// <summary>Checks whether the hooked item in this appraisal profile is a lockpick.
    /// <code>Offset: 0x005B4060
    /// int __thiscall AppraisalProfile::IsHookedItemLockpick(AppraisalProfile*)</code>
    /// </summary>
    /// <returns>Non‑zero value when the hook profile exists and its bitfield indicates a lockpick; otherwise zero.</returns>
    public int IsHookedItemLockpick() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AppraisalProfile, int>)0x005B4060)(ref this);

    /// <summary>Retrieves a bitmask of valid locations for the hooked item from its appraisal profile.
    /// <code>Offset: 0x005B4070
    /// unsigned int __thiscall AppraisalProfile::GetHookedItemValidLocations(AppraisalProfile*)</code>
    /// </summary>
    /// <returns>The unsigned integer bitmask returned by HookAppraisalProfile::GetValidLocations; zero if no hook profile is present.</returns>
    public uint GetHookedItemValidLocations() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AppraisalProfile, uint>)0x005B4070)(ref this);

    /// <summary>Retrieves the ammo type of the hooked item by querying its global trade room ID; returns zero when no hook profile exists.
    /// <code>Offset: 0x005B4080
    /// AMMO_TYPE __thiscall AppraisalProfile::GetHookedItemAmmoType(AppraisalProfile*)</code>
    /// </summary>
    /// <returns>The AMMO_TYPE representing the item's ammo category, or 0 if the item is not hooked.</returns>
    public ACBindings.Internal.AMMO_TYPE GetHookedItemAmmoType() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AppraisalProfile, ACBindings.Internal.AMMO_TYPE>)0x005B4080)(ref this);

    /// <summary>Updates the supplied header bitfield to indicate which appraisal data tables and profiles are present in this profile.
    /// <code>Offset: 0x005B4090
    /// void __thiscall AppraisalProfile::SetPackHeader(AppraisalProfile*,unsigned int*)</code>
    /// </summary>
    /// <param name="bitfield">Pointer to the header field; each set flag reflects an existing component such as integer, boolean, float statistics, spellbook, or attached creature/weapon/armor profiles and enchantments.</param>
    public void SetPackHeader(uint* bitfield) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AppraisalProfile, uint*, void>)0x005B4090)(ref this, bitfield);

    /// <summary>Computes the total byte count required to serialize an appraisal profile by summing sizes of all associated statistic tables, sub-profiles and optional attributes.
    /// <code>Offset: 0x005B4180
    /// unsigned int __thiscall AppraisalProfile::pack_size(AppraisalProfile*)</code>
    /// </summary>
    /// <returns>The cumulative size in bytes needed for packing the profile.</returns>
    public uint pack_size() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AppraisalProfile, uint>)0x005B4180)(ref this);

    /// <summary>Initializes a new appraisal profile by setting the virtual table, clearing all component pointers, and resetting statistic tables.
    /// <code>Offset: 0x005B4350
    /// void __thiscall AppraisalProfile::AppraisalProfile(AppraisalProfile*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AppraisalProfile, void>)0x005B4350)(ref this);

    /// <summary>Destructs an AppraisalProfile, clearing all stored data and restoring the base class virtual table before destruction.
    /// <code>Offset: 0x005B4390
    /// void __thiscall AppraisalProfile::~AppraisalProfile(AppraisalProfile*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AppraisalProfile, void>)0x005B4390)(ref this);

    /// <summary>Retrieves armor resistance multipliers from the appraisal profile and writes them into the supplied ArmorProfile structure.
    /// <code>Offset: 0x005B4420
    /// int __thiscall AppraisalProfile::InqArmor(AppraisalProfile*,ArmorProfile*)</code>
    /// </summary>
    /// <param name="aap">Pointer to an ArmorProfile object that will receive the values; must be non‑null.</param>
    /// <returns>1 if the internal armor_profile is present and values were copied, otherwise 0.</returns>
    public int InqArmor(ACBindings.Internal.ArmorProfile* aap) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AppraisalProfile, ACBindings.Internal.ArmorProfile*, int>)0x005B4420)(ref this, aap);

    /// <summary>Packs an AppraisalProfile into a supplied byte buffer or reports the size needed for serialization.
    /// <code>Offset: 0x005B4470
    /// unsigned int __thiscall AppraisalProfile::Pack(AppraisalProfile*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Pointer to a pointer that should reference a writable buffer; if the pointed‑to value (*addr) is null, the function only calculates and returns the required size without writing any data.</param>
    /// <param name="size">Maximum number of bytes available in the buffer referenced by *addr.</param>
    /// <returns>The total byte count necessary to serialize the profile. If the supplied buffer is large enough, this value equals the number of bytes written; otherwise it indicates how many bytes would be required and no data is written.</returns>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AppraisalProfile, void**, uint, uint>)0x005B4470)(ref this, addr, size);

    /// <summary>Copies the stored weapon profile into the supplied buffer if a weapon profile is present.
    /// <code>Offset: 0x005B48C0
    /// int __thiscall AppraisalProfile::InqWeapon(AppraisalProfile*,WeaponProfile*)</code>
    /// </summary>
    /// <param name="wap">The destination WeaponProfile instance to receive the copied data.</param>
    /// <returns>Non‑zero (typically 1) when a profile was successfully copied; zero if no weapon profile exists.</returns>
    public int InqWeapon(ACBindings.Internal.WeaponProfile* wap) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AppraisalProfile, ACBindings.Internal.WeaponProfile*, int>)0x005B48C0)(ref this, wap);

    /// <summary>Retrieves an integer stat from the profile’s internal table by its identifier, storing the result through the supplied pointer.
    /// <code>Offset: 0x005B48E0
    /// int __thiscall AppraisalProfile::InqInt(AppraisalProfile*,unsigned int,int*)</code>
    /// </summary>
    /// <param name="stype">The unique identifier of the statistic to query.</param>
    /// <param name="retval">Pointer where the retrieved value is written if the statistic exists.</param>
    /// <returns>1 when the statistic is found and returned; 0 otherwise.</returns>
    public int InqInt(uint stype, int* retval) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AppraisalProfile, uint, int*, int>)0x005B48E0)(ref this, stype, retval);

    /// <summary>Retrieves an 8-byte integer statistic identified by stype from the appraisal profile and writes it to retval.
    /// <code>Offset: 0x005B4910
    /// int __thiscall AppraisalProfile::InqInt64(AppraisalProfile*,unsigned int,__int64*)</code>
    /// </summary>
    /// <param name="stype">The identifier of the desired statistic.</param>
    /// <param name="retval">Pointer to a __int64 where the retrieved value will be stored.</param>
    /// <returns>Non‑zero if the value was found; zero otherwise.</returns>
    public int InqInt64(uint stype, long* retval) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AppraisalProfile, uint, long*, int>)0x005B4910)(ref this, stype, retval);

    /// <summary>Retrieves a boolean value from the profile's internal table based on the supplied stat type identifier.
    /// <code>Offset: 0x005B4940
    /// int __thiscall AppraisalProfile::InqBool(AppraisalProfile*,unsigned int,int*)</code>
    /// </summary>
    /// <param name="stype">Identifier of the desired boolean statistic.</param>
    /// <param name="retval">Pointer to an integer that receives the retrieved value (0 or 1).</param>
    /// <returns>Nonzero if the value was found and written, otherwise zero.</returns>
    public int InqBool(uint stype, int* retval) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AppraisalProfile, uint, int*, int>)0x005B4940)(ref this, stype, retval);

    /// <summary>Retrieves a float statistic identified by stype from the profile’s float statistics table into retval.
    /// <code>Offset: 0x005B4970
    /// int __thiscall AppraisalProfile::InqFloat(AppraisalProfile*,unsigned int,long double*)</code>
    /// </summary>
    /// <param name="stype">The identifier of the statistic to query.</param>
    /// <param name="retval">Pointer to a long double where the retrieved value will be stored.</param>
    /// <returns>Nonzero (1) if the statistic was found and returned; zero otherwise.</returns>
    public int InqFloat(uint stype, double* retval) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AppraisalProfile, uint, double*, int>)0x005B4970)(ref this, stype, retval);

    /// <summary>Retrieves an identifier from the profile’s data table using a specified key and outputs it via the supplied pointer.
    /// <code>Offset: 0x005B49A0
    /// int __thiscall AppraisalProfile::InqDataID(_DWORD*,int,_DWORD*)</code>
    /// </summary>
    /// <param name="a2">Key used to locate the desired entry in the internal hash table.</param>
    /// <param name="a3">Pointer that receives the located identifier on success.</param>
    /// <returns>Non‑zero if the lookup succeeded; zero if the key is absent or the profile’s table is null.</returns>
    public int InqDataID(int a2, int* a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AppraisalProfile, int, int*, int>)0x005B49A0)(ref this, a2, a3);

    /// <summary>Queries a string from the appraisal profile's internal string table using a key and returns it through an output parameter.
    /// <code>Offset: 0x005B4A00
    /// int __thiscall AppraisalProfile::InqString(_DWORD*,int,int*)</code>
    /// </summary>
    /// <param name="a2">The identifier of the string to retrieve.</param>
    /// <param name="a3">Pointer that receives the retrieved string; set only if the lookup succeeds.</param>
    /// <returns>Non‑zero when the string is found, zero otherwise.</returns>
    public int InqString(int a2, int* a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AppraisalProfile, int, int*, int>)0x005B4A00)(ref this, a2, a3);

    /// <summary>Deserializes an AppraisalProfile from a binary buffer, allocating statistics tables and nested subprofiles as indicated by flag bits in the data.
    /// <code>Offset: 0x005B4A30
    /// int __thiscall AppraisalProfile::UnPack(AppraisalProfile*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">A pointer to the current read location within the input buffer; it is advanced as fields are unpacked.</param>
    /// <param name="size">The total number of bytes available for unpacking; used to ensure sufficient data remains for each component.</param>
    /// <returns>Returns 1 when all expected data was consumed successfully; returns 0 if insufficient data, resetting the read pointer to its original position.</returns>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AppraisalProfile, void**, uint, int>)0x005B4A30)(ref this, addr, size);
}

