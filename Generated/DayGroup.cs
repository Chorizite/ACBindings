namespace ACBindings.Internal;

public unsafe struct DayGroup
{
    // Members
    public ACBindings.Internal.AC1Legacy.PStringBase__sbyte day_name;
    public float chance_of_occur;
    public ACBindings.Internal.AC1Legacy.SmartArray___SkyTimeOfDay_ptr sky_time;
    public ACBindings.Internal.AC1Legacy.SmartArray___SkyObject_ptr sky_objects;

    // Methods

    /// <summary>
    /// <code>Offset: 0x00501530
    /// int __thiscall DayGroup::GetTimeOfDay(DayGroup*,float,SkyTimeOfDay**,SkyTimeOfDay**,float*)</code>
    /// </summary>
    public int GetTimeOfDay(float time_of_day, ACBindings.Internal.SkyTimeOfDay** before_time, ACBindings.Internal.SkyTimeOfDay** after_time, float* ratio) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DayGroup, float, ACBindings.Internal.SkyTimeOfDay**, ACBindings.Internal.SkyTimeOfDay**, float*, int>)0x00501530)(ref this, time_of_day, before_time, after_time, ratio);

    /// <summary>
    /// <code>Offset: 0x005022D0
    /// void __thiscall DayGroup::Destroy(DayGroup*)</code>
    /// </summary>
    public void Destroy() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DayGroup, void>)0x005022D0)(ref this);

    /// <summary>
    /// <code>Offset: 0x005023C0
    /// unsigned int __thiscall DayGroup::pack_size(DayGroup*)</code>
    /// </summary>
    public uint pack_size() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DayGroup, uint>)0x005023C0)(ref this);

    /// <summary>
    /// <code>Offset: 0x00502450
    /// unsigned int __thiscall DayGroup::Pack(DayGroup*,void**,unsigned int*)</code>
    /// </summary>
    public uint Pack(void** addr, uint* size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DayGroup, void**, uint*, uint>)0x00502450)(ref this, addr, size);

    /// <summary>
    /// <code>Offset: 0x005025C0
    /// int __thiscall DayGroup::UnPack(DayGroup*,void**,unsigned int*)</code>
    /// </summary>
    public int UnPack(void** addr, uint* size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DayGroup, void**, uint*, int>)0x005025C0)(ref this, addr, size);
}

