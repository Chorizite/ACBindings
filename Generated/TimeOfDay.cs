namespace ACBindings.Internal;

public unsafe struct TimeOfDay
{
    // Members
    public ACBindings.Internal.AC1Legacy.PStringBase__sbyte time_of_day_name;
    public float begin;
    public int is_night;

    // Methods

    /// <summary>
    /// <code>Offset: 0x005A7EE0
    /// int __thiscall TimeOfDay::UnPack(TimeOfDay*,void**,unsigned int*)</code>
    /// </summary>
    public int UnPack(void** addr, uint* size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.TimeOfDay, void**, uint*, int>)0x005A7EE0)(ref this, addr, size);
}

