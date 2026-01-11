namespace ACBindings.Internal.AC1Legacy;

public unsafe struct vlong_value
{
    // Base Classes
    public ACBindings.Internal.AC1Legacy.flex_unit BaseClass_AC1Legacy_flex_unit; // ACBindings.Internal.AC1Legacy.flex_unit

    // Members
    public uint share;

    // Methods

    /// <summary>
    /// <code>Offset: 0x005B1550
    /// unsigned int __thiscall AC1Legacy::vlong_value::bits(AC1Legacy::vlong_value*)</code>
    /// </summary>
    public uint bits() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AC1Legacy.vlong_value, uint>)0x005B1550)(ref this);

    /// <summary>
    /// <code>Offset: 0x005B15A0
    /// int __thiscall AC1Legacy::vlong_value::cf(AC1Legacy::vlong_value*,AC1Legacy::vlong_value*)</code>
    /// </summary>
    public int cf(ACBindings.Internal.AC1Legacy.vlong_value* x) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AC1Legacy.vlong_value, ACBindings.Internal.AC1Legacy.vlong_value*, int>)0x005B15A0)(ref this, x);

    /// <summary>
    /// <code>Offset: 0x005B1630
    /// void __thiscall AC1Legacy::vlong_value::add(AC1Legacy::vlong_value*,AC1Legacy::vlong_value*)</code>
    /// </summary>
    public void add(ACBindings.Internal.AC1Legacy.vlong_value* x) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AC1Legacy.vlong_value, ACBindings.Internal.AC1Legacy.vlong_value*, void>)0x005B1630)(ref this, x);

    /// <summary>
    /// <code>Offset: 0x005B16A0
    /// void __thiscall AC1Legacy::vlong_value::subtract(AC1Legacy::vlong_value*,AC1Legacy::vlong_value*)</code>
    /// </summary>
    public void subtract(ACBindings.Internal.AC1Legacy.vlong_value* x) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AC1Legacy.vlong_value, ACBindings.Internal.AC1Legacy.vlong_value*, void>)0x005B16A0)(ref this, x);

    /// <summary>
    /// <code>Offset: 0x005B1700
    /// void __thiscall AC1Legacy::vlong_value::copy(AC1Legacy::vlong_value*,AC1Legacy::vlong_value*)</code>
    /// </summary>
    public void copy(ACBindings.Internal.AC1Legacy.vlong_value* x) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AC1Legacy.vlong_value, ACBindings.Internal.AC1Legacy.vlong_value*, void>)0x005B1700)(ref this, x);
}

