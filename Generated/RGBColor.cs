namespace ACBindings.Internal;

public unsafe struct RGBColor
{
    // Members
    public float r;
    public float g;
    public float b;

    // Methods

    /// <summary>
    /// <code>Offset: 0x00451A60
    /// void __thiscall RGBColor::SetColor32(RGBColor*,const unsigned int)</code>
    /// </summary>
    public void SetColor32(uint color) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RGBColor, uint, void>)0x00451A60)(ref this, color);

    /// <summary>
    /// <code>Offset: 0x005AB0D0
    /// unsigned int __thiscall RGBColor::Pack(RGBColor*,void**,unsigned int)</code>
    /// </summary>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RGBColor, void**, uint, uint>)0x005AB0D0)(ref this, addr, size);

    /// <summary>
    /// <code>Offset: 0x005AB130
    /// int __thiscall RGBColor::UnPack(RGBColor*,void**,unsigned int)</code>
    /// </summary>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RGBColor, void**, uint, int>)0x005AB130)(ref this, addr, size);
}

