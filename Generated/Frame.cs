namespace ACBindings.Internal;


/// <summary>Defines a spatial reference frame using a quaternion for orientation, a 3×3 matrix for linear transformation, and an origin point to establish position in space. Serves as the coordinate system foundation for positioning and transforming objects within the application.</summary>
public unsafe struct Frame
{
    // Child Types
    // Frame::FrameInitializationEnum
    public enum FrameInitializationEnum : uint
    {
    }

    // Members
    public float qw;
    public float qx;
    public float qy;
    public float qz;
    public fixed float m_fl2gv[9];
    public ACBindings.Internal.AC1Legacy.Vector3 m_fOrigin;

    // Generated Constructor
    public Frame() {
        _ConstructorInternal();
    }

    // Methods

    /// <summary>Initializes the Frame object with an identity quaternion and a zero origin position, then caches its state.
    /// <code>Offset: 0x00424CE0
    /// void __thiscall Frame::Frame(Frame*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Frame, void>)0x00424CE0)(ref this);

    /// <summary>Compares this frame with another, returning true when the origin vectors match within a small tolerance and the quaternion orientations are equal.
    /// <code>Offset: 0x00424E90
    /// int __thiscall Frame::is_equal(Frame*,const Frame*)</code>
    /// </summary>
    /// <param name="rhs">The frame to compare against.</param>
    /// <returns>Non‑zero if both frames are equivalent; zero otherwise.</returns>
    public int is_equal(ACBindings.Internal.Frame* rhs) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Frame, ACBindings.Internal.Frame*, int>)0x00424E90)(ref this, rhs);

    /// <summary>Compares quaternion components of this frame with another, determining if they are effectively equal within a small tolerance.
    /// <code>Offset: 0x00424ED0
    /// int __thiscall Frame::is_quaternion_equal(Frame*,const Frame*)</code>
    /// </summary>
    /// <param name="rhs">The frame whose quaternion to compare against.</param>
    /// <returns>Non-zero if all quaternion components differ by less than 0.0002; otherwise zero.</returns>
    public int is_quaternion_equal(ACBindings.Internal.Frame* rhs) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Frame, ACBindings.Internal.Frame*, int>)0x00424ED0)(ref this, rhs);

    /// <summary>Converts a vector from local space into global coordinates using the frame's orientation matrix.
    /// <code>Offset: 0x00452530
    /// AC1Legacy::Vector3* __thiscall Frame::localtoglobalvec(Frame*,AC1Legacy::Vector3*,const AC1Legacy::Vector3*)</code>
    /// </summary>
    /// <param name="result">Output vector that receives the transformed coordinates.</param>
    /// <param name="in">Input vector expressed in local space to be converted.</param>
    /// <returns>The same pointer as result, containing the transformed vector.</returns>
    public ACBindings.Internal.AC1Legacy.Vector3* localtoglobalvec(ACBindings.Internal.AC1Legacy.Vector3* result, ACBindings.Internal.AC1Legacy.Vector3* in_) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Frame, ACBindings.Internal.AC1Legacy.Vector3*, ACBindings.Internal.AC1Legacy.Vector3*, ACBindings.Internal.AC1Legacy.Vector3*>)0x00452530)(ref this, result, in_);

    /// <summary>Converts a global-space vector into the frame's local coordinate system using the frame's transformation matrix and stores the result in the supplied output vector.
    /// <code>Offset: 0x00452590
    /// AC1Legacy::Vector3* __thiscall Frame::globaltolocalvec(Frame*,AC1Legacy::Vector3*,const AC1Legacy::Vector3*)</code>
    /// </summary>
    /// <param name="this">The frame containing the transformation data.</param>
    /// <param name="result">Output vector receiving the transformed coordinates.</param>
    /// <param name="in">Input global-space vector to be converted.</param>
    /// <returns>Pointer to the output vector after conversion.</returns>
    public ACBindings.Internal.AC1Legacy.Vector3* globaltolocalvec(ACBindings.Internal.AC1Legacy.Vector3* result, ACBindings.Internal.AC1Legacy.Vector3* in_) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Frame, ACBindings.Internal.AC1Legacy.Vector3*, ACBindings.Internal.AC1Legacy.Vector3*, ACBindings.Internal.AC1Legacy.Vector3*>)0x00452590)(ref this, result, in_);

    /// <summary>Transforms a local-space vector by the frame's matrix and forwards it to Frame::grotate.
    /// <code>Offset: 0x004525F0
    /// void __thiscall Frame::rotate(Frame*,const AC1Legacy::Vector3*)</code>
    /// </summary>
    /// <param name="w">The vector in local coordinates to transform before rotating the frame.</param>
    public void rotate(ACBindings.Internal.AC1Legacy.Vector3* w) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Frame, ACBindings.Internal.AC1Legacy.Vector3*, void>)0x004525F0)(ref this, w);

    /// <summary>Transforms a point from the frame’s local coordinate system into world coordinates by applying the frame’s 3×3 transform matrix and origin offset.
    /// <code>Offset: 0x00452660
    /// AC1Legacy::Vector3* __thiscall Frame::localtoglobal(Frame*,AC1Legacy::Vector3*,const AC1Legacy::Vector3*)</code>
    /// </summary>
    /// <param name="result">Vector to receive the transformed global coordinates; returned for convenience.</param>
    /// <param name="in">Local-space vector to be converted.</param>
    /// <returns>Pointer to the result vector after conversion.</returns>
    public ACBindings.Internal.AC1Legacy.Vector3* localtoglobal(ACBindings.Internal.AC1Legacy.Vector3* result, ACBindings.Internal.AC1Legacy.Vector3* in_) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Frame, ACBindings.Internal.AC1Legacy.Vector3*, ACBindings.Internal.AC1Legacy.Vector3*, ACBindings.Internal.AC1Legacy.Vector3*>)0x00452660)(ref this, result, in_);

    /// <summary>Transforms a point from global coordinates into the local coordinate space of this frame.
    /// <code>Offset: 0x004526C0
    /// AC1Legacy::Vector3* __thiscall Frame::globaltolocal(Frame*,AC1Legacy::Vector3*,const AC1Legacy::Vector3*)</code>
    /// </summary>
    /// <param name="this">The frame whose origin and orientation define the target coordinate system.</param>
    /// <param name="result">Pointer to a vector that receives the transformed local coordinates.</param>
    /// <param name="in">Global position vector to be converted.</param>
    /// <returns>Pointer to the result vector containing the point expressed in the frame’s local space.</returns>
    public ACBindings.Internal.AC1Legacy.Vector3* globaltolocal(ACBindings.Internal.AC1Legacy.Vector3* result, ACBindings.Internal.AC1Legacy.Vector3* in_) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Frame, ACBindings.Internal.AC1Legacy.Vector3*, ACBindings.Internal.AC1Legacy.Vector3*, ACBindings.Internal.AC1Legacy.Vector3*>)0x004526C0)(ref this, result, in_);

    /// <summary>Compares the quaternion components of two frames, returning a non‑zero value when all differences are less than epsilon.
    /// <code>Offset: 0x00455E90
    /// int __cdecl Frame::close_rotation(const Frame*,const Frame*,const float)</code>
    /// </summary>
    /// <param name="f1">First frame to compare.</param>
    /// <param name="f2">Second frame to compare.</param>
    /// <param name="epsilon">Maximum allowed difference per component.</param>
    /// <returns>Non‑zero if frames are close within the tolerance; zero otherwise.</returns>
    public static int close_rotation(ACBindings.Internal.Frame* f1, ACBindings.Internal.Frame* f2, float epsilon) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.Frame*, ACBindings.Internal.Frame*, float, int>)0x00455E90)(f1, f2, epsilon);

    /// <summary>Combines two transforms, updating this frame with the result of applying f2 after f1.
    /// <code>Offset: 0x00512DE0
    /// void __thiscall Frame::combine(Frame*,const Frame*,const Frame*)</code>
    /// </summary>
    /// <param name="this">The destination frame to receive the combined transform.</param>
    /// <param name="f1">First source frame whose position and orientation form the base transform.</param>
    /// <param name="f2">Second source frame whose transform is applied on top of f1.</param>
    public void combine(ACBindings.Internal.Frame* f1, ACBindings.Internal.Frame* f2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Frame, ACBindings.Internal.Frame*, ACBindings.Internal.Frame*, void>)0x00512DE0)(ref this, f1, f2);

    /// <summary>Combines the position and rotation of two frames into this frame. Applies a scale vector to the second frame’s origin, transforms it by the first frame’s rotation matrix and translation, then multiplies the first frame’s quaternion with the second frame’s quaternion to produce the combined orientation.
    /// <code>Offset: 0x00519B00
    /// void __thiscall Frame::combine(Frame*,const Frame*,const AFrame*,const AC1Legacy::Vector3*)</code>
    /// </summary>
    /// <param name="f1">The base frame providing rotation matrix and origin for the combination.</param>
    /// <param name="f2">The additional frame whose origin is scaled before transformation and whose rotation is combined via quaternion multiplication.</param>
    /// <param name="scale">A vector applied to f2’s origin components before they are transformed by f1.</param>
    public void combine(ACBindings.Internal.Frame* f1, ACBindings.Internal.AFrame* f2, ACBindings.Internal.AC1Legacy.Vector3* scale) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Frame, ACBindings.Internal.Frame*, ACBindings.Internal.AFrame*, ACBindings.Internal.AC1Legacy.Vector3*, void>)0x00519B00)(ref this, f1, f2, scale);

    /// <summary>Combines the position and orientation of a base frame with an offset frame to create a new transform stored in this object.
    /// <code>Offset: 0x00525D80
    /// void __thiscall Frame::combine(Frame*,const Frame*,const AFrame*)</code>
    /// </summary>
    /// <param name="f1">The source frame providing rotation (m_fl2gv) and translation (m_fOrigin).</param>
    /// <param name="f2">An additional frame whose origin is rotated by f1's matrix and added to f1's position, with its quaternion multiplied with f1's quaternion.</param>
    public void combine(ACBindings.Internal.Frame* f1, ACBindings.Internal.AFrame* f2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Frame, ACBindings.Internal.Frame*, ACBindings.Internal.AFrame*, void>)0x00525D80)(ref this, f1, f2);

    /// <summary>Computes the 3×3 rotation matrix from this frame's quaternion and stores it in m_fl2gv.
    /// <code>Offset: 0x00535B30
    /// void __thiscall Frame::cache(Frame*)</code>
    /// </summary>
    public void cache() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Frame, void>)0x00535B30)(ref this);

    /// <summary>Determines whether a Frame contains valid data by verifying that its origin coordinates and quaternion components are defined (not NaN) and that the quaternion's squared norm is within ±0.001 of unity.
    /// <code>Offset: 0x00535C10
    /// int __thiscall Frame::IsValid(Frame*)</code>
    /// </summary>
    /// <returns>Non‑zero if all checks pass; zero otherwise.</returns>
    public int IsValid() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Frame, int>)0x00535C10)(ref this);

    /// <summary>Checks that a frame’s origin coordinates are numerically valid while allowing the heading quaternion to contain undefined components.
    /// <code>Offset: 0x00535D20
    /// int __thiscall Frame::IsValidExceptForHeading(Frame*)</code>
    /// </summary>
    /// <returns>Non‑zero if the origin is defined and at least one quaternion component is NaN; otherwise zero.</returns>
    public int IsValidExceptForHeading() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Frame, int>)0x00535D20)(ref this);

    /// <summary>Sets the frame's orientation by assigning a normalized quaternion from the supplied components. If the new quaternion fails validation, the original orientation is restored.
    /// <code>Offset: 0x00535DC0
    /// void __thiscall Frame::set_rotate(Frame*,float,float,float,float)</code>
    /// </summary>
    /// <param name="new_qw">The w component of the desired rotation quaternion.</param>
    /// <param name="new_qx">The x component of the desired rotation quaternion.</param>
    /// <param name="new_qy">The y component of the desired rotation quaternion.</param>
    /// <param name="new_qz">The z component of the desired rotation quaternion.</param>
    public void set_rotate(float new_qw, float new_qx, float new_qy, float new_qz) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Frame, float, float, float, float, void>)0x00535DC0)(ref this, new_qw, new_qx, new_qy, new_qz);

    /// <summary>Packs the frame’s position and orientation into a 28‑byte block of memory.
    /// <code>Offset: 0x00535E70
    /// unsigned int __thiscall Frame::Pack(Frame*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Pointer to the current write location in a preallocated buffer; on success it is advanced past the written data.</param>
    /// <param name="size">Minimum number of bytes available for writing; if less than 28 the function writes nothing and still returns 28.</param>
    /// <returns>The size, in bytes, of the packed data (always 28).</returns>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Frame, void**, uint, uint>)0x00535E70)(ref this, addr, size);

    /// <summary>Unpacks a serialized frame from the provided byte buffer into this Frame object, updating origin and orientation values.
    /// <code>Offset: 0x00535EE0
    /// int __thiscall Frame::UnPack(Frame*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Pointer to the current read position within the buffer; will be advanced past the unpacked data.</param>
    /// <param name="size">Number of bytes remaining in the buffer starting at *addr.</param>
    /// <returns>Non‑zero if the frame was successfully unpacked and validated, otherwise zero.</returns>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Frame, void**, uint, int>)0x00535EE0)(ref this, addr, size);

    /// <summary>Serializes this Frame's orientation quaternion and origin position to or from an Archive, performing read or write based on the archive mode.
    /// <code>Offset: 0x00535F70
    /// void __thiscall Frame::Serialize(Frame*,Archive*)</code>
    /// </summary>
    /// <param name="io_archive">The Archive used for reading or writing the frame data.</param>
    public void Serialize(ACBindings.Internal.Archive* io_archive) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Frame, ACBindings.Internal.Archive*, void>)0x00535F70)(ref this, io_archive);

    /// <summary>Interpolates the origin vector of this frame linearly between two source frames based on a blend factor t.
    /// <code>Offset: 0x00536030
    /// void __thiscall Frame::interpolate_origin(Frame*,const Frame*,const Frame*,float)</code>
    /// </summary>
    /// <param name="from">Source frame whose origin contributes when t equals zero.</param>
    /// <param name="to">Target frame whose origin contributes when t equals one.</param>
    /// <param name="t">Blend factor, where 0 yields the from origin and 1 yields the to origin; values in between produce a linear interpolation.</param>
    public void interpolate_origin(ACBindings.Internal.Frame* from, ACBindings.Internal.Frame* to, float t) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Frame, ACBindings.Internal.Frame*, ACBindings.Internal.Frame*, float, void>)0x00536030)(ref this, from, to, t);

    /// <summary>Interpolates this frame’s rotation between two source frames by applying spherical linear interpolation with factor t and updates the orientation.
    /// <code>Offset: 0x005360D0
    /// void __thiscall Frame::interpolate_rotation(Frame*,const Frame*,const Frame*,float)</code>
    /// </summary>
    /// <param name="from">The frame providing the starting quaternion for interpolation.</param>
    /// <param name="to">The frame providing the ending quaternion for interpolation.</param>
    /// <param name="t">Interpolation parameter, where 0 yields the source rotation and 1 yields the target rotation.</param>
    public void interpolate_rotation(ACBindings.Internal.Frame* from, ACBindings.Internal.Frame* to, float t) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Frame, ACBindings.Internal.Frame*, ACBindings.Internal.Frame*, float, void>)0x005360D0)(ref this, from, to, t);

    /// <summary>Computes a frame representing the relative transform from f2 to f1 by combining their orientations and origins, storing the result in this object.
    /// <code>Offset: 0x00536260
    /// void __thiscall Frame::subtract1(Frame*,const Frame*,const AFrame*)</code>
    /// </summary>
    /// <param name="f1">The reference frame whose position is used as the target for the subtraction.</param>
    /// <param name="f2">The source frame whose origin is subtracted and orientation combined with f1's.</param>
    public void subtract1(ACBindings.Internal.Frame* f1, ACBindings.Internal.AFrame* f2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Frame, ACBindings.Internal.Frame*, ACBindings.Internal.AFrame*, void>)0x00536260)(ref this, f1, f2);

    /// <summary>Computes the relative transform from frame f2 to frame f1 and stores it in this frame.
    /// <code>Offset: 0x00536390
    /// void __thiscall Frame::subtract2(Frame*,const Frame*,const Frame*)</code>
    /// </summary>
    /// <param name="this">The destination frame that will receive the computed origin and rotation.</param>
    /// <param name="f1">Frame whose position and orientation are used as the target of the subtraction.</param>
    /// <param name="f2">Reference frame whose coordinate system is subtracted from f1 to produce a local transform.</param>
    public void subtract2(ACBindings.Internal.Frame* f1, ACBindings.Internal.Frame* f2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Frame, ACBindings.Internal.Frame*, ACBindings.Internal.Frame*, void>)0x00536390)(ref this, f1, f2);

    /// <summary>Extracts the frame's heading direction into the supplied Vector3.
    /// <code>Offset: 0x00536460
    /// AC1Legacy::Vector3* __thiscall Frame::get_vector_heading(Frame*,AC1Legacy::Vector3*)</code>
    /// </summary>
    /// <param name="this">Frame instance whose orientation defines the heading.</param>
    /// <param name="result">Output vector that receives the computed heading.</param>
    /// <returns>Pointer to result containing the heading vector.</returns>
    public ACBindings.Internal.AC1Legacy.Vector3* get_vector_heading(ACBindings.Internal.AC1Legacy.Vector3* result) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Frame, ACBindings.Internal.AC1Legacy.Vector3*, ACBindings.Internal.AC1Legacy.Vector3*>)0x00536460)(ref this, result);

    /// <summary>Calculates the yaw angle of a frame in degrees from its orientation matrix.
    /// <code>Offset: 0x005364A0
    /// float __thiscall Frame::get_heading(Frame*)</code>
    /// </summary>
    /// <returns>The heading in degrees (0–360).</returns>
    public float get_heading() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Frame, float>)0x005364A0)(ref this);

    /// <summary>Applies a relative rotation to the frame based on an axis‑angle vector.
    /// <code>Offset: 0x005364E0
    /// void __thiscall Frame::grotate(Frame*,const AC1Legacy::Vector3*)</code>
    /// </summary>
    /// <param name="w">Axis‑angle vector whose direction specifies the rotation axis and whose length equals the rotation angle in radians.</param>
    public void grotate(ACBindings.Internal.AC1Legacy.Vector3* w) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Frame, ACBindings.Internal.AC1Legacy.Vector3*, void>)0x005364E0)(ref this, w);

    /// <summary>Computes a quaternion from the frame’s 3×3 rotation matrix and updates the frame’s orientation with it.
    /// <code>Offset: 0x00536610
    /// void __thiscall Frame::cache_quaternion(Frame*)</code>
    /// </summary>
    public void cache_quaternion() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Frame, void>)0x00536610)(ref this);

    /// <summary>Rotates the frame so that its selected local axis aligns with the supplied direction vector, updating the internal rotation matrix and quaternion representation.
    /// <code>Offset: 0x00536780
    /// void __thiscall Frame::rotate_around_axis_to_vector(Frame*,int,const AC1Legacy::Vector3*)</code>
    /// </summary>
    /// <param name="axis_num">Index (0–2) of the local axis to rotate.</param>
    /// <param name="dir">Target direction vector for the chosen axis; may be unnormalized.</param>
    public void rotate_around_axis_to_vector(int axis_num, ACBindings.Internal.AC1Legacy.Vector3* dir) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Frame, int, ACBindings.Internal.AC1Legacy.Vector3*, void>)0x00536780)(ref this, axis_num, dir);

    /// <summary>Sets the frame's orientation by converting Euler angles (x, y, z) into a quaternion using the specified rotation order.
    /// <code>Offset: 0x00536930
    /// void __thiscall Frame::euler_set_rotate(Frame*,float,float,float,int)</code>
    /// </summary>
    /// <param name="x">The first rotation angle in radians.</param>
    /// <param name="y">The second rotation angle in radians.</param>
    /// <param name="z">The third rotation angle in radians.</param>
    /// <param name="order">An integer specifying the sequence of axis rotations applied during conversion. Certain values trigger special handling of sign or order adjustments.</param>
    public void euler_set_rotate(float x, float y, float z, int order) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Frame, float, float, float, int, void>)0x00536930)(ref this, x, y, z, order);

    /// <summary>Updates the frame's orientation to align with the supplied heading vector.
    /// <code>Offset: 0x00536AF0
    /// void __thiscall Frame::set_vector_heading(Frame*,const AC1Legacy::Vector3*)</code>
    /// </summary>
    /// <param name="heading">Vector used to compute the new rotation; interpreted as a direction in 3D space.</param>
    public void set_vector_heading(ACBindings.Internal.AC1Legacy.Vector3* heading) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Frame, ACBindings.Internal.AC1Legacy.Vector3*, void>)0x00536AF0)(ref this, heading);

    /// <summary>Updates the frame’s orientation based on a heading angle provided in degrees, converting it to a direction vector and applying it with set_vector_heading.
    /// <code>Offset: 0x00536B80
    /// void __thiscall Frame::set_heading(Frame*,float)</code>
    /// </summary>
    /// <param name="degrees">The desired heading angle in degrees.</param>
    public void set_heading(float degrees) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Frame, float, void>)0x00536B80)(ref this, degrees);
}

