namespace ACBindings.Internal;

public unsafe struct PixelFormatDesc
{
    // Members
    public ACBindings.Internal.PixelFormatID format;
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
    public PixelFormatDesc(ACBindings.Internal.PixelFormatID format) {
        _ConstructorInternal(format);
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x0043D150
    /// void __thiscall PixelFormatDesc::CalcBitOffsets(PixelFormatDesc*)</code>
    /// </summary>
    public void CalcBitOffsets() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PixelFormatDesc, void>)0x0043D150)(ref this);

    /// <summary>
    /// <code>Offset: 0x0043D290
    /// bool __thiscall PixelFormatDesc::SetFormat(PixelFormatDesc*,const PixelFormatID)</code>
    /// </summary>
    public byte SetFormat(ACBindings.Internal.PixelFormatID format) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PixelFormatDesc, ACBindings.Internal.PixelFormatID, byte>)0x0043D290)(ref this, format);

    /// <summary>
    /// <code>Offset: 0x0043D7D0
    /// void __thiscall PixelFormatDesc::PixelFormatDesc(PixelFormatDesc*,const PixelFormatID)</code>
    /// </summary>
    public void _ConstructorInternal(ACBindings.Internal.PixelFormatID format) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PixelFormatDesc, ACBindings.Internal.PixelFormatID, void>)0x0043D7D0)(ref this, format);
}

