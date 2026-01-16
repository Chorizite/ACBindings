namespace ACBindings.Internal;


/// <summary>Represents a textured 3D vertex, storing position coordinates, diffuse color, and texture mapping coordinates for rendering with Direct3D.</summary>
public unsafe struct CUSTOM_D3D_L_VERTEX
{
    // Members
    public float x;
    public float y;
    public float z;
    public uint diffuse;
    public float tu;
    public float tv;

    // Methods
}

