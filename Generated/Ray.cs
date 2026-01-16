namespace ACBindings.Internal;


/// <summary>Represents a ray in 3‑dimensional space, defined by an origin point, a direction vector, and a finite length used for intersection tests and spatial queries.</summary>
public unsafe struct Ray
{
    // Child Types
    // Ray::ClosestPointType
    public enum ClosestPointType : byte
    {
        ClosestPointType_Endpoint = 0x0,
        ClosestPointType_Interior = 0x1
    }

    // Members
    public ACBindings.Internal.Vector3 pt;
    public ACBindings.Internal.Vector3 dir;
    public float length;

    // Methods

    /// <summary>Initializes a Ray with its origin set to <paramref name="start_pt"/> and determines its direction from <paramref name="offset"/>. If the offset is effectively zero, assigns length 0 and defaults the direction to (0, 1, 0); otherwise normalises the offset, stores it as the direction, and sets the Ray’s length to the offset’s magnitude.
    /// <code>Offset: 0x0050DE00
    /// void __thiscall Ray::InitFromOffset(Ray*,const Vector3*,const Vector3*)</code>
    /// </summary>
    /// <param name="start_pt">The origin point of the ray.</param>
    /// <param name="offset">A vector used to compute the ray's direction; if near zero, a default direction is applied.</param>
    public void InitFromOffset(ACBindings.Internal.Vector3* start_pt, ACBindings.Internal.Vector3* offset) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Ray, ACBindings.Internal.Vector3*, ACBindings.Internal.Vector3*, void>)0x0050DE00)(ref this, start_pt, offset);
}

