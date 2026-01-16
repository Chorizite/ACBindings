namespace ACBindings.Internal;


/// <summary>Encapsulates terrain texture mapping data, linking a terrain code with its associated texture ID and image resource.</summary>
public unsafe struct TerrainAlphaMap
{
    // Members
    public uint tcode;
    public ACBindings.Internal.IDClass____tagDataID tex_gid;
    public ACBindings.Internal.ImgTex* texture;

    // Methods
}

