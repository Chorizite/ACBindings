namespace ACBindings.Internal;


/// <summary>Represents a vertex format used by Direct3D, providing position, normal, diffuse color and texture coordinates for rendering.</summary>
public unsafe struct CUSTOM_D3D_VERTEX
{
    // Members
    public float x;
    public float y;
    public float z;
    public float nx;
    public float ny;
    public float nz;
    public uint diffuse;
    public float tu;
    public float tv;

    // Methods
}

