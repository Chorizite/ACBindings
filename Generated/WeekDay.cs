namespace ACBindings.Internal;

public unsafe struct WeekDay
{
    // Members
    public ACBindings.Internal.AC1Legacy.PStringBase__sbyte week_day_name;

    // Methods

    /// <summary>
    /// <code>Offset: 0x005A7E70
    /// int __thiscall WeekDay::UnPack(WeekDay*,void**,unsigned int*)</code>
    /// </summary>
    public int UnPack(void** addr, uint* size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.WeekDay, void**, uint*, int>)0x005A7E70)(ref this, addr, size);
}

