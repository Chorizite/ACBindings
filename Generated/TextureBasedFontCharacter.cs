namespace ACBindings.Internal;


/// <summary>Represents the metrics and texture coordinates of an individual character in a texture‑based font system, including its glyph rectangle within the atlas and positioning offsets.</summary>
public unsafe struct TextureBasedFontCharacter
{
    // Members
    public float m_U0;
    public float m_V0;
    public float m_U1;
    public float m_V1;
    public byte m_Width;
    public byte m_Height;
    public sbyte m_HorizontalOffsetBefore;
    public sbyte m_HorizontalOffsetAfter;
    public sbyte m_VerticalOffsetBefore;

    // Methods
}

