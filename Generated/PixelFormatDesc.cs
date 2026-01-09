namespace ACBindings;

// PixelFormatDesc
public unsafe struct PixelFormatDesc
{
    // Members
    public ACBindings.PixelFormatID format;
    public uint flags;
    public uint fourCC;
    public byte bitsPerPixel;
    public uint redBitMask;
    public uint greenBitMask;
    public uint blueBitMask;
    public uint alphaBitMask;
    public byte redBitCount;
    public byte greenBitCount;
    public byte blueBitCount;
    public byte alphaBitCount;
    public byte redBitOffset;
    public byte greenBitOffset;
    public byte blueBitOffset;
    public byte alphaBitOffset;
    public uint redMax;
    public uint greenMax;
    public uint blueMax;
    public uint alphaMax;

    // Generated Constructor
    public PixelFormatDesc(ACBindings.PixelFormatID format) {
        _ConstructorInternal(format);
    }

    // Methods
    // void __thiscall PixelFormatDesc::CalcBitOffsets(PixelFormatDesc*)
    public void CalcBitOffsets() => ((delegate* unmanaged[Thiscall]<ref ACBindings.PixelFormatDesc, void>)0x0043D150)(ref this);
    // bool __thiscall PixelFormatDesc::SetFormat(PixelFormatDesc*,const PixelFormatID)
    public byte SetFormat(ACBindings.PixelFormatID format) => ((delegate* unmanaged[Thiscall]<ref ACBindings.PixelFormatDesc, ACBindings.PixelFormatID, byte>)0x0043D290)(ref this, format);
    // void __thiscall PixelFormatDesc::PixelFormatDesc(PixelFormatDesc*,const PixelFormatID)
    public void _ConstructorInternal(ACBindings.PixelFormatID format) => ((delegate* unmanaged[Thiscall]<ref ACBindings.PixelFormatDesc, ACBindings.PixelFormatID, void>)0x0043D7D0)(ref this, format);
}

