namespace ACBindings.Internal.AC1Legacy;


/// <summary>Encapsulates a flexible unit and its share count, enabling resource management within the AC1Legacy framework.</summary>
public unsafe struct vlong_value
{
    // Base Classes
    public ACBindings.Internal.AC1Legacy.flex_unit BaseClass_AC1Legacy_flex_unit; // ACBindings.Internal.AC1Legacy.flex_unit

    // Members
    public uint share;

    // Methods

    /// <summary>Returns the number of bits required to represent this variable‑length long value.
    /// <code>Offset: 0x005B1550
    /// unsigned int __thiscall AC1Legacy::vlong_value::bits(AC1Legacy::vlong_value*)</code>
    /// </summary>
    /// <returns>The count of significant bits, or zero when the value contains no data.</returns>
    public uint bits() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AC1Legacy.vlong_value, uint>)0x005B1550)(ref this);

    /// <summary>Compares two AC1Legacy::vlong_value objects and returns an ordering indicator.
    /// <code>Offset: 0x005B15A0
    /// int __thiscall AC1Legacy::vlong_value::cf(AC1Legacy::vlong_value*,AC1Legacy::vlong_value*)</code>
    /// </summary>
    /// <param name="this">The current instance to compare.</param>
    /// <param name="x">The value to compare against.</param>
    /// <returns>An integer: 1 if this is greater, -1 if lesser, or 0 if equal.</returns>
    public int cf(ACBindings.Internal.AC1Legacy.vlong_value* x) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AC1Legacy.vlong_value, ACBindings.Internal.AC1Legacy.vlong_value*, int>)0x005B15A0)(ref this, x);

    /// <summary>Adds the value represented by x to this instance, performing carry-aware addition on the underlying unsigned integer array.
    /// <code>Offset: 0x005B1630
    /// void __thiscall AC1Legacy::vlong_value::add(AC1Legacy::vlong_value*,AC1Legacy::vlong_value*)</code>
    /// </summary>
    /// <param name="this">The destination vlong_value that will hold the sum after operation.</param>
    /// <param name="x">The operand vlong_value whose value is added to this instance.</param>
    public void add(ACBindings.Internal.AC1Legacy.vlong_value* x) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AC1Legacy.vlong_value, ACBindings.Internal.AC1Legacy.vlong_value*, void>)0x005B1630)(ref this, x);

    /// <summary>Subtracts the value of x from this vlong_value instance, updating the current object to hold the result.
    /// <code>Offset: 0x005B16A0
    /// void __thiscall AC1Legacy::vlong_value::subtract(AC1Legacy::vlong_value*,AC1Legacy::vlong_value*)</code>
    /// </summary>
    /// <param name="x">The vlong_value whose value is subtracted from this instance.</param>
    public void subtract(ACBindings.Internal.AC1Legacy.vlong_value* x) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AC1Legacy.vlong_value, ACBindings.Internal.AC1Legacy.vlong_value*, void>)0x005B16A0)(ref this, x);

    /// <summary>Copies the contents of a source AC1Legacy::vlong_value instance into this instance, resetting the destination before assignment.
    /// <code>Offset: 0x005B1700
    /// void __thiscall AC1Legacy::vlong_value::copy(AC1Legacy::vlong_value*,AC1Legacy::vlong_value*)</code>
    /// </summary>
    /// <param name="x">Source vlong_value to copy from.</param>
    public void copy(ACBindings.Internal.AC1Legacy.vlong_value* x) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AC1Legacy.vlong_value, ACBindings.Internal.AC1Legacy.vlong_value*, void>)0x005B1700)(ref this, x);
}

