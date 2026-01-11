namespace ACBindings.Internal;

// EnchantmentTypeEnum
public enum EnchantmentTypeEnum : uint
{
    Undef_EnchantmentType = 0x0,
    Attribute_EnchantmentType = 0x1,
    SecondAtt_EnchantmentType = 0x2,
    Int_EnchantmentType = 0x4,
    Float_EnchantmentType = 0x8,
    Skill_EnchantmentType = 0x10,
    BodyDamageValue_EnchantmentType = 0x20,
    BodyDamageVariance_EnchantmentType = 0x40,
    BodyArmorValue_EnchantmentType = 0x80,
    StatTypes_EnchantmentType = 0xFF,
    SingleStat_EnchantmentType = 0x1000,
    MultipleStat_EnchantmentType = 0x2000,
    Multiplicative_EnchantmentType = 0x4000,
    Additive_EnchantmentType = 0x8000,
    AttackSkills_EnchantmentType = 0x10000,
    DefenseSkills_EnchantmentType = 0x20000,
    Multiplicative_Degrade_EnchantmentType = 0x100000,
    Additive_Degrade_EnchantmentType = 0x200000,
    Vitae_EnchantmentType = 0x800000,
    Cooldown_EnchantmentType = 0x1000000,
    Beneficial_EnchantmentType = 0x2000000,
    FORCE_EnchantmentTypeEnum_32_BIT = 0x7FFFFFFF
}

