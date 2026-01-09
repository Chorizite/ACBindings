namespace ACBindings;

// ObjectDesc
public unsafe struct ObjectDesc
{
    // Members
    public ACBindings.IDClass___tagDataID obj_id;
    public ACBindings.Frame base_loc;
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
    // int __thiscall ObjectDesc::CheckSlope(ObjectDesc*,float)
    public int CheckSlope(float z_val) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ObjectDesc, float, int>)0x0052FDD0)(ref this, z_val);
    // float __thiscall ObjectDesc::ScaleObj(ObjectDesc*,unsigned int,unsigned int,unsigned int)
    public float ScaleObj(uint x, uint y, uint k) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ObjectDesc, uint, uint, uint, float>)0x0052FE00)(ref this, x, y, k);
    // void __thiscall ObjectDesc::Place(ObjectDesc*,unsigned int,unsigned int,unsigned int,AC1Legacy::Vector3*)
    public void Place(uint ix, uint iy, uint iq, ACBindings.AC1Legacy.Vector3* obj_loc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ObjectDesc, uint, uint, uint, ACBindings.AC1Legacy.Vector3*, void>)0x005A6CC0)(ref this, ix, iy, iq, obj_loc);
    // void __thiscall ObjectDesc::GetObjFrame(ObjectDesc*,unsigned int,unsigned int,unsigned int,const AC1Legacy::Vector3*,Frame*)
    public void GetObjFrame(uint x, uint y, uint k, ACBindings.AC1Legacy.Vector3* loc, ACBindings.Frame* obj_frame) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ObjectDesc, uint, uint, uint, ACBindings.AC1Legacy.Vector3*, ACBindings.Frame*, void>)0x005A6E60)(ref this, x, y, k, loc, obj_frame);
    // void __thiscall ObjectDesc::ObjectDesc(ObjectDesc*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ObjectDesc, void>)0x005A6F00)(ref this);
    // void __thiscall ObjectDesc::ObjAlign(ObjectDesc*,const Plane*,const AC1Legacy::Vector3*,Frame*)
    public void ObjAlign(ACBindings.Plane* plane, ACBindings.AC1Legacy.Vector3* loc, ACBindings.Frame* obj_frame) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ObjectDesc, ACBindings.Plane*, ACBindings.AC1Legacy.Vector3*, ACBindings.Frame*, void>)0x005A6F60)(ref this, plane, loc, obj_frame);
    // void __thiscall ObjectDesc::Pack(ObjectDesc*,void**,unsigned int)
    public void Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ObjectDesc, void**, uint, void>)0x005A7100)(ref this, addr, size);
    // int __thiscall ObjectDesc::UnPack(ObjectDesc*,void**,unsigned int)
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ObjectDesc, void**, uint, int>)0x005A7220)(ref this, addr, size);
}

