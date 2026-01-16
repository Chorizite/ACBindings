namespace ACBindings.Internal.AC1Legacy;


/// <summary>Represents a flexible data unit in AC1Legacy, holding a pointer to unsigned integer data along with two metadata fields.</summary>
public unsafe struct flex_unit
{
    // Members
    public uint* a;
    public uint z;
    public uint n;

    // Methods

    /// <summary>Ensures the flex_unit's internal array has capacity for at least the specified number of elements, reallocating and copying existing data when necessary.
    /// <code>Offset: 0x005B1330
    /// void __thiscall AC1Legacy::flex_unit::reserve(AC1Legacy::flex_unit*,unsigned int)</code>
    /// </summary>
    /// <param name="x">The desired minimum capacity in terms of element count.</param>
    public void reserve(uint x) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AC1Legacy.flex_unit, uint, void>)0x005B1330)(ref this, x);

    /// <summary>Assigns a value to the element at position i within the flex_unit’s internal array. If i exceeds the current size, reserves space and pads intermediate slots with zeros before inserting x, then updates the logical length n accordingly. Setting an entry to zero can trim unused trailing elements, reducing n.
    /// <code>Offset: 0x005B1390
    /// void __thiscall AC1Legacy::flex_unit::set(AC1Legacy::flex_unit*,unsigned int,unsigned int)</code>
    /// </summary>
    /// <param name="i">Index of the element to modify within the flex_unit’s array.</param>
    /// <param name="x">Value to store at position i; a zero may trigger size reduction.</param>
    public void set(uint i, uint x) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AC1Legacy.flex_unit, uint, uint, void>)0x005B1390)(ref this, i, x);

    /// <summary>Multiplies two flex_unit numbers and stores the product in this instance, truncating any bits beyond keep.
    /// <code>Offset: 0x005B1450
    /// void __thiscall AC1Legacy::flex_unit::fast_mul(AC1Legacy::flex_unit*,AC1Legacy::flex_unit*,AC1Legacy::flex_unit*,unsigned int)</code>
    /// </summary>
    /// <param name="x">First operand of the multiplication.</param>
    /// <param name="y">Second operand of the multiplication.</param>
    /// <param name="keep">Maximum number of significant bits to retain in the result; higher bits are discarded.</param>
    public void fast_mul(ACBindings.Internal.AC1Legacy.flex_unit* x, ACBindings.Internal.AC1Legacy.flex_unit* y, uint keep) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AC1Legacy.flex_unit, ACBindings.Internal.AC1Legacy.flex_unit*, ACBindings.Internal.AC1Legacy.flex_unit*, uint, void>)0x005B1450)(ref this, x, y, keep);
}

