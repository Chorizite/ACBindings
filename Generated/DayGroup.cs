namespace ACBindings;

// DayGroup
public unsafe struct DayGroup
{
    // Members
    public ACBindings.AC1Legacy.PStringBase__sbyte day_name;
    public float chance_of_occur;
    public ACBindings.AC1Legacy.SmartArray__SkyTimeOfDay_ptr sky_time;
    public ACBindings.AC1Legacy.SmartArray__SkyObject_ptr sky_objects;

    // Methods
    // int __thiscall DayGroup::GetTimeOfDay(DayGroup*,float,SkyTimeOfDay**,SkyTimeOfDay**,float*)
    public int GetTimeOfDay(float time_of_day, ACBindings.SkyTimeOfDay** before_time, ACBindings.SkyTimeOfDay** after_time, float* ratio) => ((delegate* unmanaged[Thiscall]<ref ACBindings.DayGroup, float, ACBindings.SkyTimeOfDay**, ACBindings.SkyTimeOfDay**, float*, int>)0x00501530)(ref this, time_of_day, before_time, after_time, ratio);
    // void __thiscall DayGroup::Destroy(DayGroup*)
    public void Destroy() => ((delegate* unmanaged[Thiscall]<ref ACBindings.DayGroup, void>)0x005022D0)(ref this);
    // unsigned int __thiscall DayGroup::pack_size(DayGroup*)
    public uint pack_size() => ((delegate* unmanaged[Thiscall]<ref ACBindings.DayGroup, uint>)0x005023C0)(ref this);
    // unsigned int __thiscall DayGroup::Pack(DayGroup*,void**,unsigned int*)
    public uint Pack(void** addr, uint* size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.DayGroup, void**, uint*, uint>)0x00502450)(ref this, addr, size);
    // int __thiscall DayGroup::UnPack(DayGroup*,void**,unsigned int*)
    public int UnPack(void** addr, uint* size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.DayGroup, void**, uint*, int>)0x005025C0)(ref this, addr, size);
}

