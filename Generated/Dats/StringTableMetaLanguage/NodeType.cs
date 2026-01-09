namespace ACBindings.StringTableMetaLanguage;

// StringTableMetaLanguage::NodeType
public enum NodeType : byte
{
    ntInvalid = 0x0,
    ntRootNode = 0x1,
    ntText = 0x2,
    ntVar = 0x3,
    ntChoiceBlock = 0x4,
    ntOutsideVar = 0x5
}

