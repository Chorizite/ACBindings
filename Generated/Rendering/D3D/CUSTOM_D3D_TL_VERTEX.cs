namespace ACBindings.Internal;


/// <summary>Encapsulates a DirectX vertex with X, Y, Z coordinates, perspective division factor (rhw), diffuse color, and texture UVs for rendering within the transformation layer.</summary>
public unsafe struct CUSTOM_D3D_TL_VERTEX
{
    // Members
    public float x;
    public float y;
    public float z;
    public float rhw;
    public uint diffuse;
    public float tu;
    public float tv;

    // Methods
}

