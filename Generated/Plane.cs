namespace ACBindings.Internal;


/// <summary>Plane defines a flat surface in 3D space through its normal vector and offset from the origin, facilitating geometric operations such as point classification and intersection testing.</summary>
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

    /// <summary>Determines which side of the plane a point lies on by evaluating its signed distance with an epsilon tolerance.
    /// <code>Offset: 0x00444880
    /// Sidedness __thiscall Plane::which_side(Plane*,const AC1Legacy::Vector3*,float)</code>
    /// </summary>
    /// <param name="v">The point to test against the plane.</param>
    /// <param name="epsilon">Tolerance for treating the point as lying on the plane.</param>
    /// <returns>Sidedness value: POSITIVE if the point is more than ε units on the positive side, ON_PLANE when its distance lies within ±ε, and NEGATIVE otherwise.</returns>
    public ACBindings.Internal.Sidedness which_side(ACBindings.Internal.AC1Legacy.Vector3* v, float epsilon) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Plane, ACBindings.Internal.AC1Legacy.Vector3*, float, ACBindings.Internal.Sidedness>)0x00444880)(ref this, v, epsilon);

    /// <summary>Adjusts a given vector so that it lies on the plane represented by this Plane, modifying its z component when the plane normal has a sufficiently large z component.
    /// <code>Offset: 0x0050A720
    /// void __thiscall Plane::snap_to_plane(Plane*,AC1Legacy::Vector3*)</code>
    /// </summary>
    /// <param name="offset">The vector to be snapped; updated in place if |N.z| exceeds 0.00019999999.</param>
    public void snap_to_plane(ACBindings.Internal.AC1Legacy.Vector3* offset) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Plane, ACBindings.Internal.AC1Legacy.Vector3*, void>)0x0050A720)(ref this, offset);

    /// <summary>Sets the z-coordinate of a Vector3 so that it lies on the Plane defined by normal N and distance d, modifying the vector in place.
    /// <code>Offset: 0x0052FD90
    /// int __thiscall Plane::set_height(Plane*,AC1Legacy::Vector3*)</code>
    /// </summary>
    /// <param name="vc">The vector whose z-component will be adjusted to satisfy the plane equation.</param>
    /// <returns>Non-zero if the height was successfully set; zero when the plane normal is nearly vertical (|z| ≤ 0.0002) and no adjustment can be made.</returns>
    public int set_height(ACBindings.Internal.AC1Legacy.Vector3* vc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Plane, ACBindings.Internal.AC1Legacy.Vector3*, int>)0x0052FD90)(ref this, vc);

    /// <summary>Creates a plane defined by the given normal vector and a point on the plane.
    /// <code>Offset: 0x00537760
    /// void __thiscall Plane::Plane(Plane*,const AC1Legacy::Vector3*,const AC1Legacy::Vector3*)</code>
    /// </summary>
    /// <param name="normal">Normal vector perpendicular to the plane.</param>
    /// <param name="point">A point that lies on the plane.</param>
    public void _ConstructorInternal(ACBindings.Internal.AC1Legacy.Vector3* normal, ACBindings.Internal.AC1Legacy.Vector3* point) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Plane, ACBindings.Internal.AC1Legacy.Vector3*, ACBindings.Internal.AC1Legacy.Vector3*, void>)0x00537760)(ref this, normal, point);

    /// <summary>Computes the parameter t at which a given ray first intersects this plane, storing the result in the supplied long double*. The method returns 1 when an intersection occurs ahead of the ray origin and 0 otherwise.
    /// <code>Offset: 0x00539060
    /// int __thiscall Plane::compute_time_of_intersection(Plane*,const Ray*,long double*)</code>
    /// </summary>
    /// <param name="line">Ray to test for intersection against the plane.</param>
    /// <param name="time">Pointer to store the computed intersection parameter t.</param>
    /// <returns>1 if the ray intersects the plane in the forward direction; 0 if parallel or intersection lies behind the origin.</returns>
    public int compute_time_of_intersection(ACBindings.Internal.Ray* line, double* time) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Plane, ACBindings.Internal.Ray*, double*, int>)0x00539060)(ref this, line, time);

    /// <summary>Packs the plane's normal vector and distance into a binary buffer, advancing the output pointer.
    /// <code>Offset: 0x0053D0C0
    /// unsigned int __thiscall Plane::Pack(Plane*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Pointer to the current position in the output buffer; advanced past the packed data.</param>
    /// <param name="size">Number of bytes remaining in the buffer; packing occurs only if at least 16 bytes are available.</param>
    /// <returns>Number of bytes written (always 16).</returns>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Plane, void**, uint, uint>)0x0053D0C0)(ref this, addr, size);

    /// <summary>Transforms a plane defined in local coordinates into the global coordinate system using specified source and destination positions.
    /// <code>Offset: 0x005AB150
    /// Plane* __cdecl Plane::localtoglobal(Plane*,const Position*,const Position*,const Plane*)</code>
    /// </summary>
    /// <param name="result">Pointer to the plane that will receive the transformed equation.</param>
    /// <param name="to">Destination position used for the transformation.</param>
    /// <param name="from">Source position from which the local plane originates.</param>
    /// <param name="local_plane">The plane expressed in local coordinates.</param>
    /// <returns>Same as <paramref name="result"/>, containing the plane converted to global space.</returns>
    public static ACBindings.Internal.Plane* localtoglobal(ACBindings.Internal.Plane* result, ACBindings.Internal.Position* to, ACBindings.Internal.Position* from, ACBindings.Internal.Plane* local_plane) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.Plane*, ACBindings.Internal.Position*, ACBindings.Internal.Position*, ACBindings.Internal.Plane*, ACBindings.Internal.Plane*>)0x005AB150)(result, to, from, local_plane);

    /// <summary>Determines whether an axis-aligned bounding box lies entirely on one side of this plane or intersects it, using a small numerical tolerance for robustness.
    /// <code>Offset: 0x005AB220
    /// Sidedness __thiscall Plane::intersect_box(Plane*,const BBox*)</code>
    /// </summary>
    /// <param name="box">The bounding box to test against the plane.</param>
    /// <returns>A Sidedness value indicating if the box is on the positive side, negative side, or intersects the plane.</returns>
    public ACBindings.Internal.Sidedness intersect_box(ACBindings.Internal.BBox* box) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Plane, ACBindings.Internal.BBox*, ACBindings.Internal.Sidedness>)0x005AB220)(ref this, box);

    /// <summary>Determines which side of the plane a point lies on by evaluating its signed distance plus an optional bias against a tolerance epsilon.
    /// <code>Offset: 0x006B7120
    /// Sidedness __thiscall Plane::which_side2(Plane*,const AC1Legacy::Vector3*,float,float)</code>
    /// </summary>
    /// <param name="v">The point to test relative to the plane.</param>
    /// <param name="bias">An offset added to the plane's signed distance before comparison.</param>
    /// <param name="epsilon">A tolerance value used to classify points near the plane as neutral.</param>
    /// <returns>A Sidedness enumeration indicating whether the point is on the positive side, negative side, or within the epsilon band around the plane.</returns>
    public ACBindings.Internal.Sidedness which_side2(ACBindings.Internal.AC1Legacy.Vector3* v, float bias, float epsilon) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Plane, ACBindings.Internal.AC1Legacy.Vector3*, float, float, ACBindings.Internal.Sidedness>)0x006B7120)(ref this, v, bias, epsilon);
}

