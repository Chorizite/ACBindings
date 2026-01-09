namespace ACBindings;

// SetPositionFlag
public enum SetPositionFlag : uint
{
    PLACEMENT_SPF = 0x1,
    TELEPORT_SPF = 0x2,
    RESTORE_SPF = 0x4,
    SLIDE_SPF = 0x10,
    DONOTCREATECELLS_SPF = 0x20,
    SCATTER_SPF = 0x100,
    RANDOMSCATTER_SPF = 0x200,
    LINE_SPF = 0x400,
    SEND_POSITION_EVENT_SPF = 0x1000,
    FORCE_SetPositionFlag_32_BIT = 0x7FFFFFFF
}

