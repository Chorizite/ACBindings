namespace ACBindings;

// FilenameList
public unsafe struct FilenameList
{
    // Members
    public ACBindings.OldList pathList;
    public ACBindings.OldList fileList;
    public fixed sbyte fullname[256];

    // Methods
}

