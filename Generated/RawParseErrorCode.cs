namespace ACBindings.Internal;

// RawParseErrorCode
public enum RawParseErrorCode : byte
{
    rpecSuccess = 0x0,
    rpecVarNameNonTerminated = 0x1,
    rpecVarNameEmpty = 0x2,
    rpecMetaLanguageBad = 0x3,
    rpecInvalidVarName = 0x4,
    rpecUndef = 0x5
}

