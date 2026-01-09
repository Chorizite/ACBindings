namespace ACBindings;

// SkyDesc
public unsafe struct SkyDesc : System.IDisposable
{
    // Members
    public uint present_day_group;
    public double tick_size;
    public double light_tick_size;
    public ACBindings.AC1Legacy.SmartArray__DayGroup_ptr day_groups;

    // Generated Constructor
    public SkyDesc() {
        _ConstructorInternal();
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods
    // void __thiscall SkyDesc::SkyDesc(SkyDesc*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.SkyDesc, void>)0x005015D0)(ref this);
    // void __thiscall SkyDesc::GetLighting(SkyDesc*,float,float*,RGBAUnion*,AC1Legacy::Vector3*,RGBAUnion*)
    public void GetLighting(float time_of_day, float* ambient, ACBindings.RGBAUnion* amb_color, ACBindings.AC1Legacy.Vector3* directional, ACBindings.RGBAUnion* dir_color) => ((delegate* unmanaged[Thiscall]<ref ACBindings.SkyDesc, float, float*, ACBindings.RGBAUnion*, ACBindings.AC1Legacy.Vector3*, ACBindings.RGBAUnion*, void>)0x00501600)(ref this, time_of_day, ambient, amb_color, directional, dir_color);
    // int __thiscall SkyDesc::GetWorldFog(SkyDesc*,float,float*,float*,RGBAUnion*)
    public int GetWorldFog(float time_of_day, float* min, float* max, ACBindings.RGBAUnion* color) => ((delegate* unmanaged[Thiscall]<ref ACBindings.SkyDesc, float, float*, float*, ACBindings.RGBAUnion*, int>)0x00501860)(ref this, time_of_day, min, max, color);
    // void __thiscall SkyDesc::CalcPresentDayGroup(SkyDesc*)
    public void CalcPresentDayGroup() => ((delegate* unmanaged[Thiscall]<ref ACBindings.SkyDesc, void>)0x00501990)(ref this);
    // void __thiscall SkyDesc::GetSubDataIDs(SkyDesc*,QualifiedDataIDArray*)
    public void GetSubDataIDs(ACBindings.QualifiedDataIDArray* id_array) => ((delegate* unmanaged[Thiscall]<ref ACBindings.SkyDesc, ACBindings.QualifiedDataIDArray*, void>)0x00501F50)(ref this, id_array);
    // unsigned int __thiscall SkyDesc::pack_size(SkyDesc*)
    public uint pack_size() => ((delegate* unmanaged[Thiscall]<ref ACBindings.SkyDesc, uint>)0x00502500)(ref this);
    // unsigned int __thiscall SkyDesc::Pack(SkyDesc*,void**,unsigned int*)
    public uint Pack(void** addr, uint* size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.SkyDesc, void**, uint*, uint>)0x00502540)(ref this, addr, size);
    // int __thiscall SkyDesc::UnPack(SkyDesc*,void**,unsigned int*)
    public int UnPack(void** addr, uint* size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.SkyDesc, void**, uint*, int>)0x00502820)(ref this, addr, size);
    // void __thiscall SkyDesc::Destroy(SkyDesc*)
    public void Destroy() => ((delegate* unmanaged[Thiscall]<ref ACBindings.SkyDesc, void>)0x00502970)(ref this);
    // int __thiscall SkyDesc::GetSky(_DWORD*,float,float)
    public int GetSky(float time_of_day, float ratio) => ((delegate* unmanaged[Thiscall]<ref ACBindings.SkyDesc, float, float, int>)0x00502A10)(ref this, time_of_day, ratio);
    // void __thiscall SkyDesc::~SkyDesc(SkyDesc*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.SkyDesc, void>)0x00502DA0)(ref this);
}

