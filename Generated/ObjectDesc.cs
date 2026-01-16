namespace ACBindings.Internal;


/// <summary>Represents a spatial object with unique identifier and transformation data, including frequency of occurrence, displacement offsets, scaling bounds, rotational limits, slope constraints, alignment flags, orientation codes, and an associated weenie reference.</summary>
/// <remarks>Provides the data required for placement, scaling, rotation, and alignment operations performed by the rendering engine.</remarks>
public unsafe struct ObjectDesc
{
    // Members
    public ACBindings.Internal.IDClass____tagDataID obj_id;
    public ACBindings.Internal.Frame base_loc;
    public float freq;
    public float displace_x;
    public float displace_y;
    public float min_scale;
    public float max_scale;
    public float max_rot;
    public float min_slope;
    public float max_slope;
    public int align;
    public int orient;
    public int weenie_obj;

    // Generated Constructor
    public ObjectDesc() {
        _ConstructorInternal();
    }

    // Methods

    /// <summary>Determines whether a slope value lies between the object's minimum and maximum limits.
    /// <code>Offset: 0x0052FDD0
    /// int __thiscall ObjectDesc::CheckSlope(ObjectDesc*,float)</code>
    /// </summary>
    /// <param name="z_val">The slope to evaluate.</param>
    /// <returns>Non‑zero when within bounds; zero otherwise.</returns>
    public int CheckSlope(float z_val) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ObjectDesc, float, int>)0x0052FDD0)(ref this, z_val);

    /// <summary>Calculates a scaling factor between an object's minimum and maximum scale values using the supplied unsigned integer inputs.
    /// <code>Offset: 0x0052FE00
    /// float __thiscall ObjectDesc::ScaleObj(ObjectDesc*,unsigned int,unsigned int,unsigned int)</code>
    /// </summary>
    /// <param name="x">An unsigned integer used in the deterministic calculation of the scaling factor.</param>
    /// <param name="y">An unsigned integer used in the deterministic calculation of the scaling factor.</param>
    /// <param name="k">An unsigned integer used in the deterministic calculation of the scaling factor.</param>
    /// <returns>A float representing the computed scale factor, constrained to lie between min_scale and max_scale.</returns>
    public float ScaleObj(uint x, uint y, uint k) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ObjectDesc, uint, uint, uint, float>)0x0052FE00)(ref this, x, y, k);

    /// <summary>Calculates a placement position for the object by combining its base location with optional displacements based on three index values. The resulting coordinates are written into the supplied Vector3 pointer.
    /// <code>Offset: 0x005A6CC0
    /// void __thiscall ObjectDesc::Place(ObjectDesc*,unsigned int,unsigned int,unsigned int,AC1Legacy::Vector3*)</code>
    /// </summary>
    /// <param name="ix">First coordinate index used in displacement calculation.</param>
    /// <param name="iy">Second coordinate index used in displacement calculation.</param>
    /// <param name="iq">Third index influencing the pseudo-random offset.</param>
    /// <param name="obj_loc">Output vector receiving the computed position.</param>
    public void Place(uint ix, uint iy, uint iq, ACBindings.Internal.AC1Legacy.Vector3* obj_loc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ObjectDesc, uint, uint, uint, ACBindings.Internal.AC1Legacy.Vector3*, void>)0x005A6CC0)(ref this, ix, iy, iq, obj_loc);

    /// <summary>Computes the world transform for an object instance by copying its base frame, setting its origin to the supplied location, and optionally applying a rotation derived from the object's maximum rotation value and provided indices.
    /// <code>Offset: 0x005A6E60
    /// void __thiscall ObjectDesc::GetObjFrame(ObjectDesc*,unsigned int,unsigned int,unsigned int,const AC1Legacy::Vector3*,Frame*)</code>
    /// </summary>
    /// <param name="x">First index used in the rotation calculation.</param>
    /// <param name="y">Second index used in the rotation calculation.</param>
    /// <param name="k">Third index used in the rotation calculation.</param>
    /// <param name="loc">Location vector that becomes the origin of the resulting frame.</param>
    /// <param name="obj_frame">Output frame populated with the computed transformation.</param>
    public void GetObjFrame(uint x, uint y, uint k, ACBindings.Internal.AC1Legacy.Vector3* loc, ACBindings.Internal.Frame* obj_frame) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ObjectDesc, uint, uint, uint, ACBindings.Internal.AC1Legacy.Vector3*, ACBindings.Internal.Frame*, void>)0x005A6E60)(ref this, x, y, k, loc, obj_frame);

    /// <summary>Initializes an ObjectDesc instance with neutral identifier, identity transform, zero displacement, and default scale, rotation, slope, alignment, and frequency settings.
    /// <code>Offset: 0x005A6F00
    /// void __thiscall ObjectDesc::ObjectDesc(ObjectDesc*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ObjectDesc, void>)0x005A6F00)(ref this);

    /// <summary>Aligns an object's frame to a specified location and orientation relative to a plane, using the object's base local transform as a reference.
    /// <code>Offset: 0x005A6F60
    /// void __thiscall ObjectDesc::ObjAlign(ObjectDesc*,const Plane*,const AC1Legacy::Vector3*,Frame*)</code>
    /// </summary>
    /// <param name="this">The object descriptor containing the base local transform used for alignment.</param>
    /// <param name="plane">A plane whose normal determines the desired facing direction of the aligned frame.</param>
    /// <param name="loc">The world-space origin to which the object's frame should be positioned.</param>
    /// <param name="obj_frame">Receives the resulting transformation matrix and orientation for the object.</param>
    public void ObjAlign(ACBindings.Internal.Plane* plane, ACBindings.Internal.AC1Legacy.Vector3* loc, ACBindings.Internal.Frame* obj_frame) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ObjectDesc, ACBindings.Internal.Plane*, ACBindings.Internal.AC1Legacy.Vector3*, ACBindings.Internal.Frame*, void>)0x005A6F60)(ref this, plane, loc, obj_frame);

    /// <summary>Serializes an ObjectDesc instance into a binary stream located at *addr, advancing the pointer as data is written.
    /// <code>Offset: 0x005A7100
    /// void __thiscall ObjectDesc::Pack(ObjectDesc*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Pointer to the current write position; will be updated to point after the packed data.</param>
    /// <param name="size">Maximum number of bytes available for writing; only fields that fit within this limit are serialized.</param>
    public void Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ObjectDesc, void**, uint, void>)0x005A7100)(ref this, addr, size);

    /// <summary>Unpacks an ObjectDesc instance from the provided buffer, reading its identifier, spatial frame and various rendering parameters in sequence.
    /// <code>Offset: 0x005A7220
    /// int __thiscall ObjectDesc::UnPack(ObjectDesc*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Pointer to a pointer that references the current position within the source buffer; advanced as data is consumed.</param>
    /// <param name="size">Number of bytes available for unpacking at the time of call.</param>
    /// <returns>1 on successful unpack; otherwise returns the error code produced by Frame::UnPack.</returns>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ObjectDesc, void**, uint, int>)0x005A7220)(ref this, addr, size);
}

