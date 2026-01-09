namespace ACBindings.AC1Legacy;

// AC1Legacy::flex_unit
public unsafe struct flex_unit
{
    // Members
    public uint* a;
    public uint z;
    public uint n;

    // Methods
    // void __thiscall AC1Legacy::flex_unit::reserve(AC1Legacy::flex_unit*,unsigned int)
    public void reserve(uint x) => ((delegate* unmanaged[Thiscall]<ref ACBindings.AC1Legacy.flex_unit, uint, void>)0x005B1330)(ref this, x);
    // void __thiscall AC1Legacy::flex_unit::set(AC1Legacy::flex_unit*,unsigned int,unsigned int)
    public void set(uint i, uint x) => ((delegate* unmanaged[Thiscall]<ref ACBindings.AC1Legacy.flex_unit, uint, uint, void>)0x005B1390)(ref this, i, x);
    // void __thiscall AC1Legacy::flex_unit::fast_mul(AC1Legacy::flex_unit*,AC1Legacy::flex_unit*,AC1Legacy::flex_unit*,unsigned int)
    public void fast_mul(ACBindings.AC1Legacy.flex_unit* x, ACBindings.AC1Legacy.flex_unit* y, uint keep) => ((delegate* unmanaged[Thiscall]<ref ACBindings.AC1Legacy.flex_unit, ACBindings.AC1Legacy.flex_unit*, ACBindings.AC1Legacy.flex_unit*, uint, void>)0x005B1450)(ref this, x, y, keep);
}

