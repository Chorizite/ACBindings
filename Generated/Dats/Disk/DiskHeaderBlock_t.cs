namespace ACBindings.Internal;

public unsafe struct DiskHeaderBlock_t
{
    // Members
    public fixed sbyte acVersionStr_[256];
    public fixed sbyte acTransactionRecord[64];
    public ACBindings.Internal.DiskFileInfo_t FileInfo_;

    // Methods
}

