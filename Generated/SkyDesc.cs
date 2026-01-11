namespace ACBindings.Internal;

public unsafe struct SkyDesc : System.IDisposable
{
    // Members
    public uint present_day_group;
    public double tick_size;
    public double light_tick_size;
    public ACBindings.Internal.AC1Legacy.SmartArray___DayGroup_ptr day_groups;

    // Generated Constructor
    public SkyDesc() {
        _ConstructorInternal();
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x005015D0
    /// void __thiscall SkyDesc::SkyDesc(SkyDesc*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SkyDesc, void>)0x005015D0)(ref this);

    /// <summary>
    /// <code>Offset: 0x00501600
    /// void __thiscall SkyDesc::GetLighting(SkyDesc*,float,float*,RGBAUnion*,AC1Legacy::Vector3*,RGBAUnion*)</code>
    /// </summary>
    public void GetLighting(float time_of_day, float* ambient, ACBindings.Internal.RGBAUnion* amb_color, ACBindings.Internal.AC1Legacy.Vector3* directional, ACBindings.Internal.RGBAUnion* dir_color) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SkyDesc, float, float*, ACBindings.Internal.RGBAUnion*, ACBindings.Internal.AC1Legacy.Vector3*, ACBindings.Internal.RGBAUnion*, void>)0x00501600)(ref this, time_of_day, ambient, amb_color, directional, dir_color);

    /// <summary>
    /// <code>Offset: 0x00501860
    /// int __thiscall SkyDesc::GetWorldFog(SkyDesc*,float,float*,float*,RGBAUnion*)</code>
    /// </summary>
    public int GetWorldFog(float time_of_day, float* min, float* max, ACBindings.Internal.RGBAUnion* color) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SkyDesc, float, float*, float*, ACBindings.Internal.RGBAUnion*, int>)0x00501860)(ref this, time_of_day, min, max, color);

    /// <summary>
    /// <code>Offset: 0x00501990
    /// void __thiscall SkyDesc::CalcPresentDayGroup(SkyDesc*)</code>
    /// </summary>
    public void CalcPresentDayGroup() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SkyDesc, void>)0x00501990)(ref this);

    /// <summary>
    /// <code>Offset: 0x00501F50
    /// void __thiscall SkyDesc::GetSubDataIDs(SkyDesc*,QualifiedDataIDArray*)</code>
    /// </summary>
    public void GetSubDataIDs(ACBindings.Internal.QualifiedDataIDArray* id_array) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SkyDesc, ACBindings.Internal.QualifiedDataIDArray*, void>)0x00501F50)(ref this, id_array);

    /// <summary>
    /// <code>Offset: 0x00502500
    /// unsigned int __thiscall SkyDesc::pack_size(SkyDesc*)</code>
    /// </summary>
    public uint pack_size() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SkyDesc, uint>)0x00502500)(ref this);

    /// <summary>
    /// <code>Offset: 0x00502540
    /// unsigned int __thiscall SkyDesc::Pack(SkyDesc*,void**,unsigned int*)</code>
    /// </summary>
    public uint Pack(void** addr, uint* size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SkyDesc, void**, uint*, uint>)0x00502540)(ref this, addr, size);

    /// <summary>
    /// <code>Offset: 0x00502820
    /// int __thiscall SkyDesc::UnPack(SkyDesc*,void**,unsigned int*)</code>
    /// </summary>
    public int UnPack(void** addr, uint* size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SkyDesc, void**, uint*, int>)0x00502820)(ref this, addr, size);

    /// <summary>
    /// <code>Offset: 0x00502970
    /// void __thiscall SkyDesc::Destroy(SkyDesc*)</code>
    /// </summary>
    public void Destroy() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SkyDesc, void>)0x00502970)(ref this);

    /// <summary>
    /// <code>Offset: 0x00502A10
    /// int __thiscall SkyDesc::GetSky(_DWORD*,float,float)</code>
    /// </summary>
    public int GetSky(float time_of_day, float ratio) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SkyDesc, float, float, int>)0x00502A10)(ref this, time_of_day, ratio);

    /// <summary>
    /// <code>Offset: 0x00502DA0
    /// void __thiscall SkyDesc::~SkyDesc(SkyDesc*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SkyDesc, void>)0x00502DA0)(ref this);
}

