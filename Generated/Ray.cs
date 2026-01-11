namespace ACBindings.Internal;

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

    /// <summary>
    /// <code>Offset: 0x0050DE00
    /// void __thiscall Ray::InitFromOffset(Ray*,const Vector3*,const Vector3*)</code>
    /// </summary>
    public void InitFromOffset(ACBindings.Internal.Vector3* start_pt, ACBindings.Internal.Vector3* offset) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Ray, ACBindings.Internal.Vector3*, ACBindings.Internal.Vector3*, void>)0x0050DE00)(ref this, start_pt, offset);
}

