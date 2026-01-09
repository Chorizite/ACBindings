namespace ACBindings;

// CombatStyle
public enum CombatStyle : uint
{
    Undef_CombatStyle = 0x0,
    Unarmed_CombatStyle = 0x1,
    OneHanded_CombatStyle = 0x2,
    OneHandedAndShield_CombatStyle = 0x4,
    TwoHanded_CombatStyle = 0x8,
    Bow_CombatStyle = 0x10,
    Crossbow_CombatStyle = 0x20,
    Sling_CombatStyle = 0x40,
    ThrownWeapon_CombatStyle = 0x80,
    DualWield_CombatStyle = 0x100,
    Melee_CombatStyles = 0x10F,
    Magic_CombatStyle = 0x200,
    Magic_CombatStyles = 0x200,
    Atlatl_CombatStyle = 0x400,
    ThrownShield_CombatStyle = 0x800,
    Missile_CombatStyles = 0xCF0,
    Reserved1_CombatStyle = 0x1000,
    Reserved2_CombatStyle = 0x2000,
    Reserved3_CombatStyle = 0x4000,
    Reserved4_CombatStyle = 0x8000,
    All_CombatStyle = 0xFFFF,
    StubbornMagic_CombatStyle = 0x10000,
    StubbornProjectile_CombatStyle = 0x20000,
    StubbornMelee_CombatStyle = 0x40000,
    StubbornMissile_CombatStyle = 0x80000,
    FORCE_CombatStyle_32_BIT = 0x7FFFFFFF
}

