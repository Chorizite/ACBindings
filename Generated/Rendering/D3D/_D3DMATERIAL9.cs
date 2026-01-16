namespace ACBindings.Internal;


/// <summary>Defines material properties used in rendering, including diffuse, ambient, specular and emissive color values, and a power factor.</summary>
public unsafe struct _D3DMATERIAL9
{
    // Members
    public ACBindings.Internal._D3DCOLORVALUE Diffuse;
    public ACBindings.Internal._D3DCOLORVALUE Ambient;
    public ACBindings.Internal._D3DCOLORVALUE Specular;
    public ACBindings.Internal._D3DCOLORVALUE Emissive;
    public float Power;

    // Methods
}

