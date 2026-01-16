namespace ACBindings.Internal;


/// <summary>Maintains a list of directory paths and file names used by the application to locate resources, storing them in separate pathList and fileList structures. The full file path is cached in fullname for efficient lookup.</summary>
public unsafe struct FilenameList
{
    // Members
    public ACBindings.Internal.OldList pathList;
    public ACBindings.Internal.OldList fileList;
    public fixed sbyte fullname[256];

    // Methods
}

