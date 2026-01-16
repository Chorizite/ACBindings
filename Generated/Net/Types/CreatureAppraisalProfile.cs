namespace ACBindings.Internal;


/// <summary>
/// Stores detailed appraisal data for a creature, including base attributes, health, stamina, mana, and enchantment effects.
/// Encapsulates the information required to serialize, unpack, and query creature statistics during gameplay.
/// </summary>
public unsafe struct CreatureAppraisalProfile
{
    // Base Classes
    public ACBindings.Internal.PackObj BaseClass_PackObj; // ACBindings.Internal.PackObj

    // Child Types
    public unsafe struct CreatureAppraisalProfile_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CreatureAppraisalProfile*, void> CreatureAppraisalProfile_dtor_0; // function pointer
        public fixed byte gap4[4];
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CreatureAppraisalProfile*, uint> GetPackSize; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CreatureAppraisalProfile*, void**, uint, uint> Pack; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CreatureAppraisalProfile*, void**, uint, int> UnPack; // function pointer

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

    /// <summary>
    /// Retrieves a creature attribute value by type and stores it in the supplied output parameter.
    /// 
    /// <code>Offset: 0x005B6E30
    /// int __thiscall CreatureAppraisalProfile::InqAttribute(CreatureAppraisalProfile*,unsigned int,unsigned int*)</code>
    /// </summary>
    /// <param name="stype">
    /// Identifier for the attribute to query: 1=Strength, 2=Endurance, 3=Quickness, 4=Coordination, 5=Focus, 6=Self. Any other value results in failure.
    /// </param>
    /// <param name="retval">Pointer where the retrieved unsigned integer attribute value will be written.</param>
    /// <returns>Non‑zero if an attribute was successfully returned and its value is non‑zero; zero otherwise (unknown type or zero value).</returns>
    public int InqAttribute(uint stype, uint* retval) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CreatureAppraisalProfile, uint, uint*, int>)0x005B6E30)(ref this, stype, retval);

    /// <summary>Retrieves the specified secondary attribute from a creature's appraisal profile, storing the result through the supplied pointer.
    /// <code>Offset: 0x005B6ED0
    /// int __thiscall CreatureAppraisalProfile::InqAttribute2nd(CreatureAppraisalProfile*,unsigned int,unsigned int*)</code>
    /// </summary>
    /// <param name="stype">Attribute identifier: 1 = max health, 2 = current health, 3 = max stamina, 4 = stamina, 5 = max mana, 6 = mana.</param>
    /// <param name="retval">Pointer to receive the attribute value.</param>
    /// <returns>Non‑zero if the requested attribute exists and its value is non‑zero; otherwise zero.</returns>
    public int InqAttribute2nd(uint stype, uint* retval) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CreatureAppraisalProfile, uint, uint*, int>)0x005B6ED0)(ref this, stype, retval);

    /// <summary>Queries whether a specified attribute has an active enchantment modifier; on success writes the modifier’s bitmask value into the out parameter.
    /// <code>Offset: 0x005B6F70
    /// int __thiscall CreatureAppraisalProfile::InqAttributeEnchantmentMod(CreatureAppraisalProfile*,unsigned int,int*)</code>
    /// </summary>
    /// <param name="stype">Identifier of the attribute to query (e.g., 1 for Strength, 2 for Endurance, …).</param>
    /// <param name="raised">Out parameter that receives the modifier’s bitmask value if present; left unchanged when no modifier exists for the given attribute.</param>
    /// <returns>Returns 1 when the requested attribute has an active enchantment modifier, otherwise returns 0.</returns>
    public int InqAttributeEnchantmentMod(uint stype, int* raised) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CreatureAppraisalProfile, uint, int*, int>)0x005B6F70)(ref this, stype, raised);

    /// <summary>Queries whether a specified attribute has a second‑enchantment modifier applied, returning the modifier value via output parameter.
    /// <code>Offset: 0x005B7060
    /// int __thiscall CreatureAppraisalProfile::InqAttribute2ndEnchantmentMod(CreatureAppraisalProfile*,unsigned int,int*)</code>
    /// </summary>
    /// <param name="stype">Identifier of the attribute to inspect (e.g., strength, endurance).</param>
    /// <param name="raised">Pointer receiving the modifier value when one is present.</param>
    /// <returns>1 if a second‑enchantment modifier exists for the specified attribute; otherwise 0.</returns>
    public int InqAttribute2ndEnchantmentMod(uint stype, int* raised) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CreatureAppraisalProfile, uint, int*, int>)0x005B7060)(ref this, stype, raised);

    /// <summary>Initializes a creature appraisal profile with all attributes set to zero and establishes its virtual table linkage.
    /// <code>Offset: 0x005B70D0
    /// void __thiscall CreatureAppraisalProfile::CreatureAppraisalProfile(CreatureAppraisalProfile*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CreatureAppraisalProfile, void>)0x005B70D0)(ref this);

    /// <summary>Serializes a creature's appraisal profile into the supplied buffer, writing only attributes that are present, and returns the total number of bytes required.
    /// <code>Offset: 0x005B7110
    /// unsigned int __thiscall CreatureAppraisalProfile::Pack(CreatureAppraisalProfile*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Pointer to a memory block where packed data will be written; it is advanced past the last field after packing. If null, no data is written—only size calculation occurs.</param>
    /// <param name="size">Maximum number of bytes available for writing. Packing proceeds only if this value meets or exceeds the required size.</param>
    /// <returns>Number of bytes needed to represent the profile (including any optional fields). When a buffer large enough is supplied, this equals the number of bytes actually written.</returns>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CreatureAppraisalProfile, void**, uint, uint>)0x005B7110)(ref this, addr, size);

    /// <summary>Unpacks a serialized CreatureAppraisalProfile from the buffer pointed to by <paramref name="addr"/>, advancing the read pointer and filling the object's attributes.
    /// <code>Offset: 0x005B7240
    /// int __thiscall CreatureAppraisalProfile::UnPack(CreatureAppraisalProfile*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Reference to a pointer that tracks the current position within the data buffer; it is updated as fields are read.</param>
    /// <param name="size">Number of bytes available in the buffer for this unpacking operation.</param>
    /// <returns>1 if the profile was successfully unpacked without exceeding the provided size, otherwise 0.</returns>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CreatureAppraisalProfile, void**, uint, int>)0x005B7240)(ref this, addr, size);
}

