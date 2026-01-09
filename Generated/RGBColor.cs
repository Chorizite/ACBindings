namespace ACBindings;

// RGBColor
public unsafe struct RGBColor
{
    // Members
    public float r;
    public float g;
    public float b;

    // Methods
    // void __thiscall RGBColor::SetColor32(RGBColor*,const unsigned int)
    public void SetColor32(uint color) => ((delegate* unmanaged[Thiscall]<ref ACBindings.RGBColor, uint, void>)0x00451A60)(ref this, color);
    // unsigned int __thiscall RGBColor::Pack(RGBColor*,void**,unsigned int)
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.RGBColor, void**, uint, uint>)0x005AB0D0)(ref this, addr, size);
    // int __thiscall RGBColor::UnPack(RGBColor*,void**,unsigned int)
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.RGBColor, void**, uint, int>)0x005AB130)(ref this, addr, size);
}

