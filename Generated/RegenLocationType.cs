namespace ACBindings;

// RegenLocationType
public enum RegenLocationType : uint
{
    Undef_RegenLocationType = 0x0,
    OnTop_RegenLocationType = 0x1,
    Scatter_RegenLocationType = 0x2,
    Specific_RegenLocationType = 0x4,
    Contain_RegenLocationType = 0x8,
    Wield_RegenLocationType = 0x10,
    Shop_RegenLocationType = 0x20,
    Checkpoint_RegenLocationType = 0x38,
    Treasure_RegenLocationType = 0x40,
    OnTopTreasure_RegenLocationType = 0x41,
    ScatterTreasure_RegenLocationType = 0x42,
    SpecificTreasure_RegenLocationType = 0x44,
    ContainTreasure_RegenLocationType = 0x48,
    WieldTreasure_RegenLocationType = 0x50,
    ShopTreasure_RegenLocationType = 0x60,
    FORCE_RegenLocationType_32_BIT = 0x7FFFFFFF
}

