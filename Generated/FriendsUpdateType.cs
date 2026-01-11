namespace ACBindings.Internal;

// FriendsUpdateType
public enum FriendsUpdateType : uint
{
    FRIENDS_UPDATE = 0x0,
    FRIENDS_UPDATE_ADD = 0x1,
    FRIENDS_UPDATE_REMOVE = 0x2,
    FRIENDS_UPDATE_REMOVE_SILENT = 0x3,
    FRIENDS_UPDATE_ONLINE_STATUS = 0x4,
    FORCE_FriendsUpdateType_32_BIT = 0x7FFFFFFF
}

