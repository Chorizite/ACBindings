namespace ACBindings.Internal;


/// <summary>Represents a level resource entry with its identifier, name, and associated rendering surface.</summary>
public unsafe struct DBLevelResource
{
    // Members
    public ACBindings.Internal.PStringBase__sbyte m_Name;
    public ACBindings.Internal.IDClass____tagDataID m_LevelID;
    public ACBindings.Internal.RenderSurface* m_pResource;

    // Methods
}

