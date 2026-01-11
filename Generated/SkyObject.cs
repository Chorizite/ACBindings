namespace ACBindings.Internal;

public unsafe struct SkyObject
{
    // Members
    public sbyte* object_name;
    public float begin_time;
    public float end_time;
    public float begin_angle;
    public float end_angle;
    public ACBindings.Internal.AC1Legacy.Vector3 tex_velocity;
    public uint properties;
    public ACBindings.Internal.IDClass____tagDataID default_gfx_object;
    public ACBindings.Internal.IDClass____tagDataID default_pes_object;

    // Methods

    /// <summary>
    /// <code>Offset: 0x005014D0
    /// void __thiscall SkyObject::Destroy(SkyObject*)</code>
    /// </summary>
    public void Destroy() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SkyObject, void>)0x005014D0)(ref this);

    /// <summary>
    /// <code>Offset: 0x00501A20
    /// unsigned int __thiscall SkyObject::Pack(SkyObject*,void**,unsigned int*)</code>
    /// </summary>
    public uint Pack(void** addr, uint* size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SkyObject, void**, uint*, uint>)0x00501A20)(ref this, addr, size);

    /// <summary>
    /// <code>Offset: 0x00501B20
    /// int __thiscall SkyObject::UnPack(SkyObject*,void**,unsigned int*)</code>
    /// </summary>
    public int UnPack(void** addr, uint* size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SkyObject, void**, uint*, int>)0x00501B20)(ref this, addr, size);
}

