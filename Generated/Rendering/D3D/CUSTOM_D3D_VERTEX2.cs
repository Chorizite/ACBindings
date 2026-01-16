namespace ACBindings.Internal;


/// <summary>Represents a vertex used in Direct3D rendering, storing position, normal vector, diffuse color, and two sets of texture coordinates.</summary>
public unsafe struct CUSTOM_D3D_VERTEX2
{
    // Members
    public float x;
    public float y;
    public float z;
    public float nx;
    public float ny;
    public float nz;
    public uint diffuse;
    public float tu1;
    public float tv1;
    public float tu2;
    public float tv2;

    // Methods
}

