namespace ACBindings.Internal;


/// <summary>Defines a single vertex used to render bitmap fonts, storing 3D origin, diffuse color, and texture mapping coordinates.</summary>
public unsafe struct TextureBasedFontVertexType
{
    // Members
    public ACBindings.Internal.Vector3 Origin;
    public uint Diffuse;
    public ACBindings.Internal.TexCoordPair TexCoord;

    // Methods
}

