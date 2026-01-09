namespace ACBindings.StringTableMetaLanguage;

// StringTableMetaLanguage::RenderErrorCode
public enum RenderErrorCode : byte
{
    recSuccess = 0x0,
    recSyntaxError = 0x1,
    recDuplicateIDs = 0x2,
    recDuplicateChoices = 0x3,
    recInternalError = 0x4
}

