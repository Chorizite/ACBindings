namespace ACBindings.Internal.AC1Modern;


/// <summary>Defines a plane in three‑dimensional space by a normal vector N and an offset d along that normal.</summary>
/// <remarks>The implicit equation is N·P + d = 0 for any point P on the plane; if N is normalized, d represents the signed distance from the origin.</remarks>
public unsafe struct Plane
{
    // Members
    public ACBindings.Internal.Vector3 N;
    public float d;

    // Methods
}

