namespace ACBindings.Internal;

public unsafe struct MaterialGraphicsStatesType
{
    // Members
    public byte WantFFLighting;
    public byte WantFFDyeColorInTFactor;
    public byte WantFFSpecularLighting;
    public byte WantFFVertexDiffuse;
    public byte WantFFVertexSpecular;
    public byte WantFFDistanceFog;
    public ACBindings.Internal.RGBAColor MaterialDiffuseColor;
    public ACBindings.Internal.RGBAColor MaterialSpecularColor;
    public float MaterialSpecularPower;
    public ACBindings.Internal.RGBAColor MaterialDyeColor;
    public ACBindings.Internal.RGBAColor AmbientLight;
    public uint MaterialAlphaTestRef;

    // Methods
}

