namespace ACBindings;

// StatType
public enum StatType : uint
{
    Undef_StatType = 0x0,
    Int_StatType = 0x1,
    Float_StatType = 0x2,
    Position_StatType = 0x3,
    Skill_StatType = 0x4,
    String_StatType = 0x5,
    DataID_StatType = 0x6,
    DID_StatType = 0x6,
    InstanceID_StatType = 0x7,
    IID_StatType = 0x7,
    Attribute_StatType = 0x8,
    Attribute_2nd_StatType = 0x9,
    BodyDamageValue_StatType = 0xA,
    BodyDamageVariance_StatType = 0xB,
    BodyArmorValue_StatType = 0xC,
    Bool_StatType = 0xD,
    Int64_StatType = 0xE,
    Num_StatTypes = 0xF,
    FORCE_StatType_32_BIT = 0x7FFFFFFF
}

