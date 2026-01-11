namespace ACBindings.Internal.AC1Legacy;

public unsafe struct flex_unit
{
    // Members
    public uint* a;
    public uint z;
    public uint n;

    // Methods

    /// <summary>
    /// <code>Offset: 0x005B1330
    /// void __thiscall AC1Legacy::flex_unit::reserve(AC1Legacy::flex_unit*,unsigned int)</code>
    /// </summary>
    public void reserve(uint x) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AC1Legacy.flex_unit, uint, void>)0x005B1330)(ref this, x);

    /// <summary>
    /// <code>Offset: 0x005B1390
    /// void __thiscall AC1Legacy::flex_unit::set(AC1Legacy::flex_unit*,unsigned int,unsigned int)</code>
    /// </summary>
    public void set(uint i, uint x) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AC1Legacy.flex_unit, uint, uint, void>)0x005B1390)(ref this, i, x);

    /// <summary>
    /// <code>Offset: 0x005B1450
    /// void __thiscall AC1Legacy::flex_unit::fast_mul(AC1Legacy::flex_unit*,AC1Legacy::flex_unit*,AC1Legacy::flex_unit*,unsigned int)</code>
    /// </summary>
    public void fast_mul(ACBindings.Internal.AC1Legacy.flex_unit* x, ACBindings.Internal.AC1Legacy.flex_unit* y, uint keep) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AC1Legacy.flex_unit, ACBindings.Internal.AC1Legacy.flex_unit*, ACBindings.Internal.AC1Legacy.flex_unit*, uint, void>)0x005B1450)(ref this, x, y, keep);
}

