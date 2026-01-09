namespace ACBindings;

// GetStringErrorCode
public enum GetStringErrorCode : uint
{
    gsSuccess = 0x0,
    gsUninitialized = 0x1,
    gsMissingString = 0x2,
    gsMissingTable = 0x3,
    gsMissingPrivateString = 0x4,
    gsMissingPrivateTable = 0x5,
    gsMissingVariable = 0x6,
    gsMetaLanguageError = 0x7,
    gsGenericError = 0x8,
    GetStringErrorCode_FORCE_32_BIT = 0x7FFFFFFF
}

