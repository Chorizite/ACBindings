namespace ACBindings;

// ID3DXFont
public unsafe struct ID3DXFont
{
    // Base Classes
    public ACBindings.IUnknown BaseClass_IUnknown; // ACBindings.IUnknown

    // Child Types
    // ID3DXFont_vtbl
    public unsafe struct ID3DXFont_vtbl
    {
        // Members
        public System.IntPtr QueryInterface; // function pointer
        public System.IntPtr AddRef; // function pointer
        public System.IntPtr Release; // function pointer
        public System.IntPtr GetDevice; // function pointer
        public System.IntPtr GetDescA;
        public System.IntPtr GetDescW;
        public System.IntPtr GetTextMetricsA; // function pointer
        public System.IntPtr GetTextMetricsW; // function pointer
        public System.IntPtr GetDC; // function pointer
        public System.IntPtr GetGlyphData; // function pointer
        public System.IntPtr PreloadCharacters; // function pointer
        public System.IntPtr PreloadGlyphs; // function pointer
        public System.IntPtr PreloadTextA; // function pointer
        public System.IntPtr PreloadTextW; // function pointer
        public System.IntPtr DrawTextA; // function pointer
        public System.IntPtr DrawTextW; // function pointer
        public System.IntPtr OnLostDevice; // function pointer
        public System.IntPtr OnResetDevice; // function pointer

        // Methods
    }

    // Methods
}

