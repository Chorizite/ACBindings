namespace ACBindings;

// Ray
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
    public ACBindings.Vector3 pt;
    public ACBindings.Vector3 dir;
    public float length;

    // Methods
    // void __thiscall Ray::InitFromOffset(Ray*,const Vector3*,const Vector3*)
    public void InitFromOffset(ACBindings.Vector3* start_pt, ACBindings.Vector3* offset) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Ray, ACBindings.Vector3*, ACBindings.Vector3*, void>)0x0050DE00)(ref this, start_pt, offset);
}

