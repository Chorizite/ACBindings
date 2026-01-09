namespace ACBindings;

// MaterialGraphicsStatesType
public unsafe struct MaterialGraphicsStatesType
{
    // Members
    public byte WantFFLighting;
    public byte WantFFDyeColorInTFactor;
    public byte WantFFSpecularLighting;
    public byte WantFFVertexDiffuse;
    public byte WantFFVertexSpecular;
    public byte WantFFDistanceFog;
    public ACBindings.RGBAColor MaterialDiffuseColor;
    public ACBindings.RGBAColor MaterialSpecularColor;
    public float MaterialSpecularPower;
    public ACBindings.RGBAColor MaterialDyeColor;
    public ACBindings.RGBAColor AmbientLight;
    public uint MaterialAlphaTestRef;

    // Methods
}

