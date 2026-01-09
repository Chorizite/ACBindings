namespace ACBindings;

// SkyObject
public unsafe struct SkyObject
{
    // Members
    public sbyte* object_name;
    public float begin_time;
    public float end_time;
    public float begin_angle;
    public float end_angle;
    public ACBindings.AC1Legacy.Vector3 tex_velocity;
    public uint properties;
    public ACBindings.IDClass___tagDataID default_gfx_object;
    public ACBindings.IDClass___tagDataID default_pes_object;

    // Methods
    // void __thiscall SkyObject::Destroy(SkyObject*)
    public void Destroy() => ((delegate* unmanaged[Thiscall]<ref ACBindings.SkyObject, void>)0x005014D0)(ref this);
    // unsigned int __thiscall SkyObject::Pack(SkyObject*,void**,unsigned int*)
    public uint Pack(void** addr, uint* size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.SkyObject, void**, uint*, uint>)0x00501A20)(ref this, addr, size);
    // int __thiscall SkyObject::UnPack(SkyObject*,void**,unsigned int*)
    public int UnPack(void** addr, uint* size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.SkyObject, void**, uint*, int>)0x00501B20)(ref this, addr, size);
}

