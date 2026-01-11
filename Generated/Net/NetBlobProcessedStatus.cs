namespace ACBindings.Internal;

// NetBlobProcessedStatus
public enum NetBlobProcessedStatus : uint
{
    NETBLOB_UNDEF_STATUS = 0x0,
    NETBLOB_PROCESSED_OK = 0x1,
    NETBLOB_OLD_INSTANCE = 0x2,
    NETBLOB_ERROR = 0x3,
    NETBLOB_QUEUED = 0x4,
    FORCE_NetBlobProcessedStatus_32_BIT = 0x7FFFFFFF
}

