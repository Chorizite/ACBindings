namespace ACBindings;

// InventoryRequest
public enum InventoryRequest : uint
{
    IR_NONE = 0x0,
    IR_MERGE = 0x1,
    IR_SPLIT = 0x2,
    IR_MOVE = 0x3,
    IR_PICK_UP = 0x4,
    IR_PUT_IN_CONTAINER = 0x5,
    IR_DROP = 0x6,
    IR_WIELD = 0x7,
    IR_VIEW_AS_GROUND_CONTAINER = 0x8,
    IR_GIVE = 0x9,
    IR_SHOP_EVENT = 0xA,
    FORCE_InventoryRequest_32_BIT = 0x7FFFFFFF
}

