namespace ACBindings;

// BondedStatusEnum
public enum BondedStatusEnum : uint
{
    Normal_BondedStatus = 0x0,
    Bonded_BondedStatus = 0x1,
    Sticky_BondedStatus = 0x2,
    FORCE_BondedStatusEnum_32_BIT = 0x7FFFFFFF,
    Destroy_BondedStatus = 0xFFFFFFFE,
    Slippery_BondedStatus = 0xFFFFFFFF
}

