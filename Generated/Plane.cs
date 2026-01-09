namespace ACBindings;

// Plane
public unsafe struct Plane
{
    // Members
    public ACBindings.AC1Legacy.Vector3 N;
    public float d;

    // Generated Constructor
    public Plane(ACBindings.AC1Legacy.Vector3* normal, ACBindings.AC1Legacy.Vector3* point) {
        _ConstructorInternal(normal, point);
    }

    // Methods
    // Sidedness __thiscall Plane::which_side(Plane*,const AC1Legacy::Vector3*,float)
    public ACBindings.Sidedness which_side(ACBindings.AC1Legacy.Vector3* v, float epsilon) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Plane, ACBindings.AC1Legacy.Vector3*, float, ACBindings.Sidedness>)0x00444880)(ref this, v, epsilon);
    // void __thiscall Plane::snap_to_plane(Plane*,AC1Legacy::Vector3*)
    public void snap_to_plane(ACBindings.AC1Legacy.Vector3* offset) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Plane, ACBindings.AC1Legacy.Vector3*, void>)0x0050A720)(ref this, offset);
    // int __thiscall Plane::set_height(Plane*,AC1Legacy::Vector3*)
    public int set_height(ACBindings.AC1Legacy.Vector3* vc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Plane, ACBindings.AC1Legacy.Vector3*, int>)0x0052FD90)(ref this, vc);
    // void __thiscall Plane::Plane(Plane*,const AC1Legacy::Vector3*,const AC1Legacy::Vector3*)
    public void _ConstructorInternal(ACBindings.AC1Legacy.Vector3* normal, ACBindings.AC1Legacy.Vector3* point) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Plane, ACBindings.AC1Legacy.Vector3*, ACBindings.AC1Legacy.Vector3*, void>)0x00537760)(ref this, normal, point);
    // int __thiscall Plane::compute_time_of_intersection(Plane*,const Ray*,long double*)
    public int compute_time_of_intersection(ACBindings.Ray* line, double* time) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Plane, ACBindings.Ray*, double*, int>)0x00539060)(ref this, line, time);
    // unsigned int __thiscall Plane::Pack(Plane*,void**,unsigned int)
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Plane, void**, uint, uint>)0x0053D0C0)(ref this, addr, size);
    // Plane* __cdecl Plane::localtoglobal(Plane*,const Position*,const Position*,const Plane*)
    public static ACBindings.Plane* localtoglobal(ACBindings.Plane* result, ACBindings.Position* to, ACBindings.Position* from, ACBindings.Plane* local_plane) => ((delegate* unmanaged[Cdecl]<ACBindings.Plane*, ACBindings.Position*, ACBindings.Position*, ACBindings.Plane*, ACBindings.Plane*>)0x005AB150)(result, to, from, local_plane);
    // Sidedness __thiscall Plane::intersect_box(Plane*,const BBox*)
    public ACBindings.Sidedness intersect_box(ACBindings.BBox* box) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Plane, ACBindings.BBox*, ACBindings.Sidedness>)0x005AB220)(ref this, box);
    // Sidedness __thiscall Plane::which_side2(Plane*,const AC1Legacy::Vector3*,float,float)
    public ACBindings.Sidedness which_side2(ACBindings.AC1Legacy.Vector3* v, float bias, float epsilon) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Plane, ACBindings.AC1Legacy.Vector3*, float, float, ACBindings.Sidedness>)0x006B7120)(ref this, v, bias, epsilon);
}

