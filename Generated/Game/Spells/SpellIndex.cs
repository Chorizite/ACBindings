namespace ACBindings.Internal;

// SpellIndex
public enum SpellIndex : uint
{
    Undef_SpellIndex = 0x0,
    Resistable_SpellIndex = 0x1,
    PKSensitive_SpellIndex = 0x2,
    Beneficial_SpellIndex = 0x4,
    SelfTargeted_SpellIndex = 0x8,
    Reversed_SpellIndex = 0x10,
    NotIndoor_SpellIndex = 0x20,
    NotOutdoor_SpellIndex = 0x40,
    NotResearchable_SpellIndex = 0x80,
    Projectile_SpellIndex = 0x100,
    CreatureSpell_SpellIndex = 0x200,
    ExcludedFromItemDescriptions_SpellIndex = 0x400,
    IgnoresManaConversion_SpellIndex = 0x800,
    NonTrackingProjectile_SpellIndex = 0x1000,
    FellowshipSpell_SpellIndex = 0x2000,
    FastCast_SpellIndex = 0x4000,
    IndoorLongRange_SpellIndex = 0x8000,
    DamageOverTime_SpellIndex = 0x10000,
    FORCE_SpellIndex_32_BIT = 0x7FFFFFFF
}

