namespace ACBindings;

// WeekDay
public unsafe struct WeekDay
{
    // Members
    public ACBindings.AC1Legacy.PStringBase__sbyte week_day_name;

    // Methods
    // int __thiscall WeekDay::UnPack(WeekDay*,void**,unsigned int*)
    public int UnPack(void** addr, uint* size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.WeekDay, void**, uint*, int>)0x005A7E70)(ref this, addr, size);
}

