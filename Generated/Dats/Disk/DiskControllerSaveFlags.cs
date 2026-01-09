namespace ACBindings;

// DiskControllerSaveFlags
public enum DiskControllerSaveFlags : byte
{
    dcsfNoCompression = 0x1,
    dcsfCompress = 0x2,
    dcsfDataIsCompressed = 0x3,
    dcsfUncompress = 0x4,
    dcsfBTEntryOnly = 0x5,
    dcsfCompressionMask = 0x7,
    dcsfModifyCachePack = 0x8
}

