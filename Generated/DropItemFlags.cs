namespace ACBindings.Internal;

// DropItemFlags
public enum DropItemFlags : uint
{
    DROPITEM_FLAGS_NONE = 0x0,
    DROPITEM_IS_CONTAINER = 0x1,
    DROPITEM_IS_VENDOR = 0x2,
    DROPITEM_IS_SHORTCUT = 0x4,
    DROPITEM_IS_SALVAGE = 0x8,
    DROPITEM_IS_ALIAS = 0xE,
    FORCE_DROPITEM_FLAGS_32_BIT = 0x7FFFFFFF
}

