namespace ACBindings.Internal;

// SpellType
public enum SpellType : uint
{
    Undef_SpellType = 0x0,
    Enchantment_SpellType = 0x1,
    Projectile_SpellType = 0x2,
    Boost_SpellType = 0x3,
    Transfer_SpellType = 0x4,
    PortalLink_SpellType = 0x5,
    PortalRecall_SpellType = 0x6,
    PortalSummon_SpellType = 0x7,
    PortalSending_SpellType = 0x8,
    Dispel_SpellType = 0x9,
    LifeProjectile_SpellType = 0xA,
    FellowBoost_SpellType = 0xB,
    FellowEnchantment_SpellType = 0xC,
    FellowPortalSending_SpellType = 0xD,
    FellowDispel_SpellType = 0xE,
    EnchantmentProjectile_SpellType = 0xF,
    FORCE_SpellType_32_BIT = 0x7FFFFFFF
}

