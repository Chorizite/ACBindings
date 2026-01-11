namespace ACBindings.Internal;

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

    /// <summary>
    /// <code>Offset: 0x0052FDD0
    /// int __thiscall ObjectDesc::CheckSlope(ObjectDesc*,float)</code>
    /// </summary>
    public int CheckSlope(float z_val) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ObjectDesc, float, int>)0x0052FDD0)(ref this, z_val);

    /// <summary>
    /// <code>Offset: 0x0052FE00
    /// float __thiscall ObjectDesc::ScaleObj(ObjectDesc*,unsigned int,unsigned int,unsigned int)</code>
    /// </summary>
    public float ScaleObj(uint x, uint y, uint k) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ObjectDesc, uint, uint, uint, float>)0x0052FE00)(ref this, x, y, k);

    /// <summary>
    /// <code>Offset: 0x005A6CC0
    /// void __thiscall ObjectDesc::Place(ObjectDesc*,unsigned int,unsigned int,unsigned int,AC1Legacy::Vector3*)</code>
    /// </summary>
    public void Place(uint ix, uint iy, uint iq, ACBindings.Internal.AC1Legacy.Vector3* obj_loc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ObjectDesc, uint, uint, uint, ACBindings.Internal.AC1Legacy.Vector3*, void>)0x005A6CC0)(ref this, ix, iy, iq, obj_loc);

    /// <summary>
    /// <code>Offset: 0x005A6E60
    /// void __thiscall ObjectDesc::GetObjFrame(ObjectDesc*,unsigned int,unsigned int,unsigned int,const AC1Legacy::Vector3*,Frame*)</code>
    /// </summary>
    public void GetObjFrame(uint x, uint y, uint k, ACBindings.Internal.AC1Legacy.Vector3* loc, ACBindings.Internal.Frame* obj_frame) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ObjectDesc, uint, uint, uint, ACBindings.Internal.AC1Legacy.Vector3*, ACBindings.Internal.Frame*, void>)0x005A6E60)(ref this, x, y, k, loc, obj_frame);

    /// <summary>
    /// <code>Offset: 0x005A6F00
    /// void __thiscall ObjectDesc::ObjectDesc(ObjectDesc*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ObjectDesc, void>)0x005A6F00)(ref this);

    /// <summary>
    /// <code>Offset: 0x005A6F60
    /// void __thiscall ObjectDesc::ObjAlign(ObjectDesc*,const Plane*,const AC1Legacy::Vector3*,Frame*)</code>
    /// </summary>
    public void ObjAlign(ACBindings.Internal.Plane* plane, ACBindings.Internal.AC1Legacy.Vector3* loc, ACBindings.Internal.Frame* obj_frame) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ObjectDesc, ACBindings.Internal.Plane*, ACBindings.Internal.AC1Legacy.Vector3*, ACBindings.Internal.Frame*, void>)0x005A6F60)(ref this, plane, loc, obj_frame);

    /// <summary>
    /// <code>Offset: 0x005A7100
    /// void __thiscall ObjectDesc::Pack(ObjectDesc*,void**,unsigned int)</code>
    /// </summary>
    public void Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ObjectDesc, void**, uint, void>)0x005A7100)(ref this, addr, size);

    /// <summary>
    /// <code>Offset: 0x005A7220
    /// int __thiscall ObjectDesc::UnPack(ObjectDesc*,void**,unsigned int)</code>
    /// </summary>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ObjectDesc, void**, uint, int>)0x005A7220)(ref this, addr, size);
}

