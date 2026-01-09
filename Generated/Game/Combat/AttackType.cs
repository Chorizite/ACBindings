namespace ACBindings;

// AttackType
public enum AttackType : uint
{
    Undef_AttackType = 0x0,
    Punch_AttackType = 0x1,
    Thrust_AttackType = 0x2,
    Slash_AttackType = 0x4,
    Kick_AttackType = 0x8,
    OffhandPunch_AttackType = 0x10,
    Unarmed_AttackType = 0x19,
    DoubleSlash_AttackType = 0x20,
    TripleSlash_AttackType = 0x40,
    DoubleThrust_AttackType = 0x80,
    TripleThrust_AttackType = 0x100,
    OffhandThrust_AttackType = 0x200,
    OffhandSlash_AttackType = 0x400,
    OffhandDoubleSlash_AttackType = 0x800,
    OffhandTripleSlash_AttackType = 0x1000,
    OffhandDoubleThrust_AttackType = 0x2000,
    OffhandTripleThrust_AttackType = 0x4000,
    MultiStrike_AttackType = 0x79E0,
    FORCE_AttackType_32_BIT = 0x7FFFFFFF
}

