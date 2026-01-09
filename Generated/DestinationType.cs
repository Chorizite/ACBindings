namespace ACBindings;

// DestinationType
public enum DestinationType : uint
{
    Undef_DestinationType = 0x0,
    Contain_DestinationType = 0x1,
    Wield_DestinationType = 0x2,
    Shop_DestinationType = 0x4,
    Checkpoint_DestinationType = 0x7,
    Treasure_DestinationType = 0x8,
    ContainTreasure_DestinationType = 0x9,
    WieldTreasure_DestinationType = 0xA,
    ShopTreasure_DestinationType = 0xC,
    HouseBuy_DestinationType = 0x10,
    HouseRent_DestinationType = 0x20,
    FORCE_DestinationType_32_BIT = 0x7FFFFFFF
}

