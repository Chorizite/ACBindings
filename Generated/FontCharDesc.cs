namespace ACBindings.Internal;


/// <summary>Represents metrics for a single character glyph in a font, including Unicode code point, positioning offsets, and dimensions used during text layout and rendering.</summary>
/// <remarks>Encapsulates the data required by font rasterizers and layout engines to position each glyph accurately on screen or print media.</remarks>
public unsafe struct FontCharDesc
{
    // Members
    public ushort m_Unicode;
    public ushort m_OffsetX;
    public ushort m_OffsetY;
    public byte m_Width;
    public byte m_Height;
    public sbyte m_HorizontalOffsetBefore;
    public sbyte m_HorizontalOffsetAfter;
    public sbyte m_VerticalOffsetBefore;

    // Methods
}

