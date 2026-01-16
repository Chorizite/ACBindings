namespace ACBindings.Internal;


/// <summary>Wraps an IME font with position, color, and a Font reference for rendering text in the application.</summary>
public unsafe struct CImeFontWrapper
{
    // Child Types
    public unsafe struct CImeFontWrapper_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CImeFontWrapper*, uint, void> SetHeight; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CImeFontWrapper*, uint, void> SetColor; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CImeFontWrapper*, int, int, void> SetPosition; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CImeFontWrapper*, sbyte*, uint*, uint*, void> GetTextExtent; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CImeFontWrapper*, sbyte*, void> DrawTextA; // function pointer

        // Methods
    }

    // Members
    public System.IntPtr __vftable; // vtable pointer
    public uint m_color;
    public int m_x;
    public int m_y;
    public ACBindings.Internal.Font* m_font;

    // Methods
}

