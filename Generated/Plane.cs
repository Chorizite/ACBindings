namespace ACBindings.Internal;

public unsafe struct Plane
{
    // Members
    public ACBindings.Internal.AC1Legacy.Vector3 N;
    public float d;

    // Generated Constructor
    public Plane(ACBindings.Internal.AC1Legacy.Vector3* normal, ACBindings.Internal.AC1Legacy.Vector3* point) {
        _ConstructorInternal(normal, point);
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x00444880
    /// Sidedness __thiscall Plane::which_side(Plane*,const AC1Legacy::Vector3*,float)</code>
    /// </summary>
    public ACBindings.Internal.Sidedness which_side(ACBindings.Internal.AC1Legacy.Vector3* v, float epsilon) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Plane, ACBindings.Internal.AC1Legacy.Vector3*, float, ACBindings.Internal.Sidedness>)0x00444880)(ref this, v, epsilon);

    /// <summary>
    /// <code>Offset: 0x0050A720
    /// void __thiscall Plane::snap_to_plane(Plane*,AC1Legacy::Vector3*)</code>
    /// </summary>
    public void snap_to_plane(ACBindings.Internal.AC1Legacy.Vector3* offset) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Plane, ACBindings.Internal.AC1Legacy.Vector3*, void>)0x0050A720)(ref this, offset);

    /// <summary>
    /// <code>Offset: 0x0052FD90
    /// int __thiscall Plane::set_height(Plane*,AC1Legacy::Vector3*)</code>
    /// </summary>
    public int set_height(ACBindings.Internal.AC1Legacy.Vector3* vc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Plane, ACBindings.Internal.AC1Legacy.Vector3*, int>)0x0052FD90)(ref this, vc);

    /// <summary>
    /// <code>Offset: 0x00537760
    /// void __thiscall Plane::Plane(Plane*,const AC1Legacy::Vector3*,const AC1Legacy::Vector3*)</code>
    /// </summary>
    public void _ConstructorInternal(ACBindings.Internal.AC1Legacy.Vector3* normal, ACBindings.Internal.AC1Legacy.Vector3* point) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Plane, ACBindings.Internal.AC1Legacy.Vector3*, ACBindings.Internal.AC1Legacy.Vector3*, void>)0x00537760)(ref this, normal, point);

    /// <summary>
    /// <code>Offset: 0x00539060
    /// int __thiscall Plane::compute_time_of_intersection(Plane*,const Ray*,long double*)</code>
    /// </summary>
    public int compute_time_of_intersection(ACBindings.Internal.Ray* line, double* time) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Plane, ACBindings.Internal.Ray*, double*, int>)0x00539060)(ref this, line, time);

    /// <summary>
    /// <code>Offset: 0x0053D0C0
    /// unsigned int __thiscall Plane::Pack(Plane*,void**,unsigned int)</code>
    /// </summary>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Plane, void**, uint, uint>)0x0053D0C0)(ref this, addr, size);

    /// <summary>
    /// <code>Offset: 0x005AB150
    /// Plane* __cdecl Plane::localtoglobal(Plane*,const Position*,const Position*,const Plane*)</code>
    /// </summary>
    public static ACBindings.Internal.Plane* localtoglobal(ACBindings.Internal.Plane* result, ACBindings.Internal.Position* to, ACBindings.Internal.Position* from, ACBindings.Internal.Plane* local_plane) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.Plane*, ACBindings.Internal.Position*, ACBindings.Internal.Position*, ACBindings.Internal.Plane*, ACBindings.Internal.Plane*>)0x005AB150)(result, to, from, local_plane);

    /// <summary>
    /// <code>Offset: 0x005AB220
    /// Sidedness __thiscall Plane::intersect_box(Plane*,const BBox*)</code>
    /// </summary>
    public ACBindings.Internal.Sidedness intersect_box(ACBindings.Internal.BBox* box) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Plane, ACBindings.Internal.BBox*, ACBindings.Internal.Sidedness>)0x005AB220)(ref this, box);

    /// <summary>
    /// <code>Offset: 0x006B7120
    /// Sidedness __thiscall Plane::which_side2(Plane*,const AC1Legacy::Vector3*,float,float)</code>
    /// </summary>
    public ACBindings.Internal.Sidedness which_side2(ACBindings.Internal.AC1Legacy.Vector3* v, float bias, float epsilon) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Plane, ACBindings.Internal.AC1Legacy.Vector3*, float, float, ACBindings.Internal.Sidedness>)0x006B7120)(ref this, v, bias, epsilon);
}

