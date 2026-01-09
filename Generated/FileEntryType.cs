namespace ACBindings;

// FileEntryType
public enum FileEntryType : byte
{
    NewName = 0x0,
    OnlyExisting = 0x1,
    UnsearchedDirectory = 0x2,
    SearchedDirectory = 0x3,
    DIDLessFile = 0x4,
    DIDFile = 0x5
}

