namespace ACBindings.Internal;


/// <summary>Represents the association between a dynamic library name and its loaded instance handle, enabling efficient DLL lookup and management within the application.</summary>
public unsafe struct DLLMap
{
    // Members
    public sbyte* szDLLName;
    public int* hMod;

    // Methods
}

