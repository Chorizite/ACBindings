namespace ACBindings;

// SkyTimeOfDay
public unsafe struct SkyTimeOfDay : System.IDisposable
{
    // Members
    public float begin;
    public float dir_bright;
    public float dir_heading;
    public float dir_pitch;
    public ACBindings.RGBAUnion dir_color;
    public float amb_bright;
    public ACBindings.RGBAUnion amb_color;
    public int world_fog;
    public float min_world_fog;
    public float max_world_fog;
    public ACBindings.RGBAUnion world_fog_color;
    public ACBindings.AC1Legacy.SmartArray__SkyObjectReplace_ptr sky_obj_replace;

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods
    // void __thiscall SkyTimeOfDay::~SkyTimeOfDay(SkyTimeOfDay*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.SkyTimeOfDay, void>)0x00501D80)(ref this);
    // unsigned int __thiscall SkyTimeOfDay::Pack(SkyTimeOfDay*,void**,unsigned int*)
    public uint Pack(void** addr, uint* size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.SkyTimeOfDay, void**, uint*, uint>)0x00501DE0)(ref this, addr, size);
    // int __thiscall SkyTimeOfDay::UnPack(SkyTimeOfDay*,void**,unsigned int*)
    public int UnPack(void** addr, uint* size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.SkyTimeOfDay, void**, uint*, int>)0x00502100)(ref this, addr, size);
}

