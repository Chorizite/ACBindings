namespace ACBindings.Internal;


/// <summary>Describes pixel format characteristics such as bit depth, channel masks, and per‑component limits used by image processing and rendering pipelines.</summary>
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

    /// <summary>Computes the bit offset, count, and maximum value for each color channel from its mask in the pixel format descriptor.
    /// <code>Offset: 0x0043D150
    /// void __thiscall PixelFormatDesc::CalcBitOffsets(PixelFormatDesc*)</code>
    /// </summary>
    public void CalcBitOffsets() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PixelFormatDesc, void>)0x0043D150)(ref this);

    /// <summary>Sets pixel format descriptor fields based on the given PixelFormatID, configuring bit masks, offsets, flags and other attributes accordingly.
    /// <code>Offset: 0x0043D290
    /// bool __thiscall PixelFormatDesc::SetFormat(PixelFormatDesc*,const PixelFormatID)</code>
    /// </summary>
    /// <param name="format">Pixel format identifier to apply to the descriptor.</param>
    /// <returns>True if the format is supported and the descriptor was successfully configured; otherwise false.</returns>
    public byte SetFormat(ACBindings.Internal.PixelFormatID format) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PixelFormatDesc, ACBindings.Internal.PixelFormatID, byte>)0x0043D290)(ref this, format);

    /// <summary>Initializes a PixelFormatDesc instance based on the specified PixelFormatID, configuring all internal fields accordingly.
    /// <code>Offset: 0x0043D7D0
    /// void __thiscall PixelFormatDesc::PixelFormatDesc(PixelFormatDesc*,const PixelFormatID)</code>
    /// </summary>
    /// <param name="format">The pixel format identifier used to set up the descriptor.</param>
    public void _ConstructorInternal(ACBindings.Internal.PixelFormatID format) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PixelFormatDesc, ACBindings.Internal.PixelFormatID, void>)0x0043D7D0)(ref this, format);
}

