namespace ACBindings.Internal;


/// <summary>Represents a three‑dimensional vector used by Direct3D to store spatial coordinates, normals, or direction vectors.</summary>
/// <remarks>Serves as the base type for many graphics calculations, with X, Y, Z components aligned on 4‑byte boundaries for efficient memory access.</remarks>
public unsafe struct _D3DVECTOR
{
    // Members
    public float x;
    public float y;
    public float z;

    // Methods
}

