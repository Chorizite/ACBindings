namespace ACBindings;

// DiskConOpenFlags
public enum DiskConOpenFlags : byte
{
    dcofUseLRU = 0x1,
    dcofExpandable = 0x2,
    dcofReadOnly = 0x4,
    dcofCreate = 0x8,
    dcofCreateIfNeeded = 0x10,
    dfocOptionalFile = 0x20
}

