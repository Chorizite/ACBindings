namespace ACBindings.Internal;


/// <summary>Represents a vertex for Direct3D with 3‑dimensional position, diffuse color and two sets of texture coordinates used in rendering pipelines.</summary>
public unsafe struct CUSTOM_D3D_L_VERTEX2
{
    // Members
    public float x;
    public float y;
    public float z;
    public uint diffuse;
    public float tu1;
    public float tv1;
    public float tu2;
    public float tv2;

    // Methods
}

