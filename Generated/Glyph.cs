namespace ACBindings;

// Glyph
public unsafe struct Glyph : System.IDisposable
{
    // Members
    public ushort m_data;
    public int m_width;
    public int m_height;
    public ACBindings.RGBAColor m_color;
    public ACBindings.Font* m_font;
    public ACBindings.TextTag* m_tag;

    // Generated Constructor
    public Glyph() {
        _ConstructorInternal();
    }
    public Glyph(ACBindings.Glyph* rhs) {
        _ConstructorInternal(rhs);
    }
    public Glyph(ushort character, ACBindings.RGBAColor* color, ACBindings.Font* font, ACBindings.TextTag* tag) {
        _ConstructorInternal(character, color, font, tag);
    }
    public Glyph(ushort character, ACBindings.RGBAColor* color, ACBindings.Font* font, ACBindings.TextTag* tag, uint width, uint height) {
        _ConstructorInternal(character, color, font, tag, width, height);
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods
    // bool __thiscall Glyph::IsWhiteSpace(Glyph*)
    public byte IsWhiteSpace() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Glyph, byte>)0x00474B90)(ref this);
    // void __thiscall Glyph::Glyph(Glyph*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Glyph, void>)0x00474BC0)(ref this);
    // void __thiscall Glyph::~Glyph(Glyph*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Glyph, void>)0x00474BE0)(ref this);
    // void __thiscall Glyph::SetTag(Glyph*,TextTag*)
    public void SetTag(ACBindings.TextTag* pTag) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Glyph, ACBindings.TextTag*, void>)0x00474CE0)(ref this, pTag);
    // void __thiscall Glyph::Glyph(Glyph*,const Glyph*)
    public void _ConstructorInternal(ACBindings.Glyph* rhs) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Glyph, ACBindings.Glyph*, void>)0x00474D30)(ref this, rhs);
    // void __thiscall Glyph::SetFont(Glyph*,Font*)
    public void SetFont(ACBindings.Font* font) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Glyph, ACBindings.Font*, void>)0x00474D60)(ref this, font);
    // void __thiscall Glyph::Glyph(Glyph*,const unsigned __int16,const RGBAColor*,Font*,TextTag*)
    public void _ConstructorInternal(ushort character, ACBindings.RGBAColor* color, ACBindings.Font* font, ACBindings.TextTag* tag) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Glyph, ushort, ACBindings.RGBAColor*, ACBindings.Font*, ACBindings.TextTag*, void>)0x00474E50)(ref this, character, color, font, tag);
    // void __thiscall Glyph::Glyph(Glyph*,const unsigned __int16,const RGBAColor*,Font*,TextTag*,const unsigned int,const unsigned int)
    public void _ConstructorInternal(ushort character, ACBindings.RGBAColor* color, ACBindings.Font* font, ACBindings.TextTag* tag, uint width, uint height) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Glyph, ushort, ACBindings.RGBAColor*, ACBindings.Font*, ACBindings.TextTag*, uint, uint, void>)0x00474EC0)(ref this, character, color, font, tag, width, height);
}

