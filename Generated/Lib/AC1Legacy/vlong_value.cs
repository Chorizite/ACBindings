namespace ACBindings.AC1Legacy;

// AC1Legacy::vlong_value
public unsafe struct vlong_value
{
    // Base Classes
    public ACBindings.AC1Legacy.flex_unit BaseClass_AC1Legacy_flex_unit; // ACBindings.AC1Legacy.flex_unit

    // Members
    public uint share;

    // Methods
    // unsigned int __thiscall AC1Legacy::vlong_value::bits(AC1Legacy::vlong_value*)
    public uint bits() => ((delegate* unmanaged[Thiscall]<ref ACBindings.AC1Legacy.vlong_value, uint>)0x005B1550)(ref this);
    // int __thiscall AC1Legacy::vlong_value::cf(AC1Legacy::vlong_value*,AC1Legacy::vlong_value*)
    public int cf(ACBindings.AC1Legacy.vlong_value* x) => ((delegate* unmanaged[Thiscall]<ref ACBindings.AC1Legacy.vlong_value, ACBindings.AC1Legacy.vlong_value*, int>)0x005B15A0)(ref this, x);
    // void __thiscall AC1Legacy::vlong_value::add(AC1Legacy::vlong_value*,AC1Legacy::vlong_value*)
    public void add(ACBindings.AC1Legacy.vlong_value* x) => ((delegate* unmanaged[Thiscall]<ref ACBindings.AC1Legacy.vlong_value, ACBindings.AC1Legacy.vlong_value*, void>)0x005B1630)(ref this, x);
    // void __thiscall AC1Legacy::vlong_value::subtract(AC1Legacy::vlong_value*,AC1Legacy::vlong_value*)
    public void subtract(ACBindings.AC1Legacy.vlong_value* x) => ((delegate* unmanaged[Thiscall]<ref ACBindings.AC1Legacy.vlong_value, ACBindings.AC1Legacy.vlong_value*, void>)0x005B16A0)(ref this, x);
    // void __thiscall AC1Legacy::vlong_value::copy(AC1Legacy::vlong_value*,AC1Legacy::vlong_value*)
    public void copy(ACBindings.AC1Legacy.vlong_value* x) => ((delegate* unmanaged[Thiscall]<ref ACBindings.AC1Legacy.vlong_value, ACBindings.AC1Legacy.vlong_value*, void>)0x005B1700)(ref this, x);
}

