namespace ACBindings.Internal.StringTableMetaLanguage;


/// <summary>
/// Records an error that occurs during rendering of string table meta language, providing the position where it happened, the specific error code, and a descriptive message.
/// </summary>
public unsafe struct RenderErr
{
    // Members
    public int pos;
    public ACBindings.Internal.StringTableMetaLanguage.RenderErrorCode code;
    public ACBindings.Internal.PStringBase__sbyte msg;

    // Methods
}

