namespace ACBindings.Internal;

public unsafe struct FilenameList
{
    // Members
    public ACBindings.Internal.OldList pathList;
    public ACBindings.Internal.OldList fileList;
    public fixed sbyte fullname[256];

    // Methods
}

