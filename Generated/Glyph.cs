namespace ACBindings.Internal;


/// <summary>Glyph representing a rendered character with dimensions, visual attributes, and associated font and metadata.</summary>
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

    /// <summary>Determines whether this glyph represents a whitespace character.
    /// <code>Offset: 0x00474B90
    /// bool __thiscall Glyph::IsWhiteSpace(Glyph*)</code>
    /// </summary>
    /// <returns>True if the glyph's data value equals 9 (tab), 13 (carriage return) or 32 (space); otherwise, false.</returns>
    public byte IsWhiteSpace() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Glyph, byte>)0x00474B90)(ref this);

    /// <summary>Initializes a Glyph instance with default values, clearing data, dimensions, font reference, and tag pointer.
    /// <code>Offset: 0x00474BC0
    /// void __thiscall Glyph::Glyph(Glyph*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Glyph, void>)0x00474BC0)(ref this);

    /// <summary>Destroys a Glyph instance, releasing its TextTag and Font references and resetting the corresponding member pointers.
    /// <code>Offset: 0x00474BE0
    /// void __thiscall Glyph::~Glyph(Glyph*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Glyph, void>)0x00474BE0)(ref this);

    /// <summary>Assigns a new text formatting tag to the glyph, decrementing the reference count of any previously assigned tag and releasing it when the count reaches zero.
    /// <code>Offset: 0x00474CE0
    /// void __thiscall Glyph::SetTag(Glyph*,TextTag*)</code>
    /// </summary>
    /// <param name="pTag">The TextTag to associate with the glyph; may be null to clear the current tag.</param>
    public void SetTag(ACBindings.Internal.TextTag* pTag) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Glyph, ACBindings.Internal.TextTag*, void>)0x00474CE0)(ref this, pTag);

    /// <summary>Initializes a new Glyph instance by resetting all member fields to default values and then copying the contents of another Glyph.
    /// <code>Offset: 0x00474D30
    /// void __thiscall Glyph::Glyph(Glyph*,const Glyph*)</code>
    /// </summary>
    /// <param name="rhs">The source Glyph whose data will be copied into this object.</param>
    public void _ConstructorInternal(ACBindings.Internal.Glyph* rhs) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Glyph, ACBindings.Internal.Glyph*, void>)0x00474D30)(ref this, rhs);

    /// <summary>Assigns a new font to the glyph, updating its dimensions and ensuring character support; falls back to default fonts when the requested font lacks the glyph.
    /// <code>Offset: 0x00474D60
    /// void __thiscall Glyph::SetFont(Glyph*,Font*)</code>
    /// </summary>
    /// <param name="font">The font to associate with this glyph. If null, the glyph retains no font reference.</param>
    public void SetFont(ACBindings.Internal.Font* font) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Glyph, ACBindings.Internal.Font*, void>)0x00474D60)(ref this, font);

    /// <summary>Initializes a Glyph with the specified character code, color, font, and optional text tag. Sets dimensions to zero and increments the reference count of the provided tag.
    /// <code>Offset: 0x00474E50
    /// void __thiscall Glyph::Glyph(Glyph*,const unsigned __int16,const RGBAColor*,Font*,TextTag*)</code>
    /// </summary>
    /// <param name="character">Unicode code point that identifies the glyph.</param>
    /// <param name="color">Pointer to an RGBAColor struct defining the glyph's color.</param>
    /// <param name="font">Pointer to a Font structure containing character metrics.</param>
    /// <param name="tag">Optional TextTag providing formatting information; its reference count is incremented if non‑null.</param>
    public void _ConstructorInternal(ushort character, ACBindings.Internal.RGBAColor* color, ACBindings.Internal.Font* font, ACBindings.Internal.TextTag* tag) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Glyph, ushort, ACBindings.Internal.RGBAColor*, ACBindings.Internal.Font*, ACBindings.Internal.TextTag*, void>)0x00474E50)(ref this, character, color, font, tag);

    /// <summary>Initializes a Glyph instance with specified character, visual attributes, and optional text formatting information.
    /// <code>Offset: 0x00474EC0
    /// void __thiscall Glyph::Glyph(Glyph*,const unsigned __int16,const RGBAColor*,Font*,TextTag*,const unsigned int,const unsigned int)</code>
    /// </summary>
    /// <param name="character">Unicode code point of the glyph.</param>
    /// <param name="color">Color used for rendering the glyph.</param>
    /// <param name="font">Font containing metrics and texture data.</param>
    /// <param name="tag">Optional tag providing additional formatting; reference count is incremented if supplied.</param>
    /// <param name="width">Desired width in pixels.</param>
    /// <param name="height">Desired height in pixels.</param>
    public void _ConstructorInternal(ushort character, ACBindings.Internal.RGBAColor* color, ACBindings.Internal.Font* font, ACBindings.Internal.TextTag* tag, uint width, uint height) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Glyph, ushort, ACBindings.Internal.RGBAColor*, ACBindings.Internal.Font*, ACBindings.Internal.TextTag*, uint, uint, void>)0x00474EC0)(ref this, character, color, font, tag, width, height);
}

