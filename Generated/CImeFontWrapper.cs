namespace ACBindings;

// CImeFontWrapper
public unsafe struct CImeFontWrapper
{
    // Child Types
    // CImeFontWrapper_vtbl
    public unsafe struct CImeFontWrapper_vtbl
    {
        // Members
        public System.IntPtr SetHeight; // function pointer
        public System.IntPtr SetColor; // function pointer
        public System.IntPtr SetPosition; // function pointer
        public System.IntPtr GetTextExtent; // function pointer
        public System.IntPtr DrawTextA; // function pointer

        // Methods
    }

    // Members
    public System.IntPtr __vftable; // vtable pointer
    public uint m_color;
    public int m_x;
    public int m_y;
    public ACBindings.Font* m_font;

    // Methods
}

