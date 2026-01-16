namespace ACBindings.Internal;


/// <summary>Represents a line of glyphs in a text layout system, storing its identifier, pixel width, and pixel height for rendering calculations.</summary>
public unsafe struct GlyphLine
{
    // Child Types

    /// <summary>Represents the virtual function table for GlyphLine, storing pointers to its virtual methods such as the destructor.</summary>
    public unsafe struct GlyphLine_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.GlyphLine*, void> GlyphLine_dtor_0; // function pointer

        // Methods
    }

    // Members
    public System.IntPtr __vftable; // vtable pointer
    public uint m_nIndex;
    public int m_nLineWidth;
    public int m_nLineHeight;

    // Methods
}

