namespace ACBindings.Internal;

public unsafe struct Glyph : System.IDisposable
{
    // Members
    public ushort m_data;
    public int m_width;
    public int m_height;
    public ACBindings.Internal.RGBAColor m_color;
    public ACBindings.Internal.Font* m_font;
    public ACBindings.Internal.TextTag* m_tag;

    // Generated Constructor
    public Glyph() {
        _ConstructorInternal();
    }
    public Glyph(ACBindings.Internal.Glyph* rhs) {
        _ConstructorInternal(rhs);
    }
    public Glyph(ushort character, ACBindings.Internal.RGBAColor* color, ACBindings.Internal.Font* font, ACBindings.Internal.TextTag* tag) {
        _ConstructorInternal(character, color, font, tag);
    }
    public Glyph(ushort character, ACBindings.Internal.RGBAColor* color, ACBindings.Internal.Font* font, ACBindings.Internal.TextTag* tag, uint width, uint height) {
        _ConstructorInternal(character, color, font, tag, width, height);
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x00474B90
    /// bool __thiscall Glyph::IsWhiteSpace(Glyph*)</code>
    /// </summary>
    public byte IsWhiteSpace() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Glyph, byte>)0x00474B90)(ref this);

    /// <summary>
    /// <code>Offset: 0x00474BC0
    /// void __thiscall Glyph::Glyph(Glyph*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Glyph, void>)0x00474BC0)(ref this);

    /// <summary>
    /// <code>Offset: 0x00474BE0
    /// void __thiscall Glyph::~Glyph(Glyph*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Glyph, void>)0x00474BE0)(ref this);

    /// <summary>
    /// <code>Offset: 0x00474CE0
    /// void __thiscall Glyph::SetTag(Glyph*,TextTag*)</code>
    /// </summary>
    public void SetTag(ACBindings.Internal.TextTag* pTag) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Glyph, ACBindings.Internal.TextTag*, void>)0x00474CE0)(ref this, pTag);

    /// <summary>
    /// <code>Offset: 0x00474D30
    /// void __thiscall Glyph::Glyph(Glyph*,const Glyph*)</code>
    /// </summary>
    public void _ConstructorInternal(ACBindings.Internal.Glyph* rhs) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Glyph, ACBindings.Internal.Glyph*, void>)0x00474D30)(ref this, rhs);

    /// <summary>
    /// <code>Offset: 0x00474D60
    /// void __thiscall Glyph::SetFont(Glyph*,Font*)</code>
    /// </summary>
    public void SetFont(ACBindings.Internal.Font* font) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Glyph, ACBindings.Internal.Font*, void>)0x00474D60)(ref this, font);

    /// <summary>
    /// <code>Offset: 0x00474E50
    /// void __thiscall Glyph::Glyph(Glyph*,const unsigned __int16,const RGBAColor*,Font*,TextTag*)</code>
    /// </summary>
    public void _ConstructorInternal(ushort character, ACBindings.Internal.RGBAColor* color, ACBindings.Internal.Font* font, ACBindings.Internal.TextTag* tag) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Glyph, ushort, ACBindings.Internal.RGBAColor*, ACBindings.Internal.Font*, ACBindings.Internal.TextTag*, void>)0x00474E50)(ref this, character, color, font, tag);

    /// <summary>
    /// <code>Offset: 0x00474EC0
    /// void __thiscall Glyph::Glyph(Glyph*,const unsigned __int16,const RGBAColor*,Font*,TextTag*,const unsigned int,const unsigned int)</code>
    /// </summary>
    public void _ConstructorInternal(ushort character, ACBindings.Internal.RGBAColor* color, ACBindings.Internal.Font* font, ACBindings.Internal.TextTag* tag, uint width, uint height) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Glyph, ushort, ACBindings.Internal.RGBAColor*, ACBindings.Internal.Font*, ACBindings.Internal.TextTag*, uint, uint, void>)0x00474EC0)(ref this, character, color, font, tag, width, height);
}

