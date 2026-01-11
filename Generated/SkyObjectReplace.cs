namespace ACBindings.Internal;

public unsafe struct SkyObjectReplace
{
    // Members
    public uint object_index;
    public ACBindings.Internal.SkyObject* object_;
    public ACBindings.Internal.IDClass____tagDataID gfx_obj_id;
    public float rotate;
    public float transparent;
    public float luminosity;
    public float max_bright;

    // Methods

    /// <summary>
    /// <code>Offset: 0x00501C20
    /// unsigned int __thiscall SkyObjectReplace::Pack(SkyObjectReplace*,void**,unsigned int*)</code>
    /// </summary>
    public uint Pack(void** addr, uint* size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SkyObjectReplace, void**, uint*, uint>)0x00501C20)(ref this, addr, size);

    /// <summary>
    /// <code>Offset: 0x00501CD0
    /// int __thiscall SkyObjectReplace::UnPack(SkyObjectReplace*,void**,unsigned int*)</code>
    /// </summary>
    public int UnPack(void** addr, uint* size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SkyObjectReplace, void**, uint*, int>)0x00501CD0)(ref this, addr, size);
}

