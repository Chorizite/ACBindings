namespace ACBindings;

// TimeOfDay
public unsafe struct TimeOfDay
{
    // Members
    public ACBindings.AC1Legacy.PStringBase__sbyte time_of_day_name;
    public float begin;
    public int is_night;

    // Methods
    // int __thiscall TimeOfDay::UnPack(TimeOfDay*,void**,unsigned int*)
    public int UnPack(void** addr, uint* size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.TimeOfDay, void**, uint*, int>)0x005A7EE0)(ref this, addr, size);
}

