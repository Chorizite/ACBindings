namespace ACBindings;

// SkyObjectReplace
public unsafe struct SkyObjectReplace
{
    // Members
    public uint object_index;
    public ACBindings.SkyObject* object_;
    public ACBindings.IDClass___tagDataID gfx_obj_id;
    public float rotate;
    public float transparent;
    public float luminosity;
    public float max_bright;

    // Methods
    // unsigned int __thiscall SkyObjectReplace::Pack(SkyObjectReplace*,void**,unsigned int*)
    public uint Pack(void** addr, uint* size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.SkyObjectReplace, void**, uint*, uint>)0x00501C20)(ref this, addr, size);
    // int __thiscall SkyObjectReplace::UnPack(SkyObjectReplace*,void**,unsigned int*)
    public int UnPack(void** addr, uint* size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.SkyObjectReplace, void**, uint*, int>)0x00501CD0)(ref this, addr, size);
}

