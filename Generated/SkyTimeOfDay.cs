namespace ACBindings.Internal;

public unsafe struct SkyTimeOfDay : System.IDisposable
{
    // Members
    public float begin;
    public float dir_bright;
    public float dir_heading;
    public float dir_pitch;
    public ACBindings.Internal.RGBAUnion dir_color;
    public float amb_bright;
    public ACBindings.Internal.RGBAUnion amb_color;
    public int world_fog;
    public float min_world_fog;
    public float max_world_fog;
    public ACBindings.Internal.RGBAUnion world_fog_color;
    public ACBindings.Internal.AC1Legacy.SmartArray___SkyObjectReplace_ptr sky_obj_replace;

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x00501D80
    /// void __thiscall SkyTimeOfDay::~SkyTimeOfDay(SkyTimeOfDay*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SkyTimeOfDay, void>)0x00501D80)(ref this);

    /// <summary>
    /// <code>Offset: 0x00501DE0
    /// unsigned int __thiscall SkyTimeOfDay::Pack(SkyTimeOfDay*,void**,unsigned int*)</code>
    /// </summary>
    public uint Pack(void** addr, uint* size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SkyTimeOfDay, void**, uint*, uint>)0x00501DE0)(ref this, addr, size);

    /// <summary>
    /// <code>Offset: 0x00502100
    /// int __thiscall SkyTimeOfDay::UnPack(SkyTimeOfDay*,void**,unsigned int*)</code>
    /// </summary>
    public int UnPack(void** addr, uint* size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SkyTimeOfDay, void**, uint*, int>)0x00502100)(ref this, addr, size);
}

