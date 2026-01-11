namespace ACBindings.Internal;

public unsafe struct ID3DXFont
{
    // Base Classes
    public ACBindings.Internal.IUnknown BaseClass_IUnknown; // ACBindings.Internal.IUnknown

    // Child Types
    public unsafe struct ID3DXFont_vtbl
    {
        // Members
        public delegate* unmanaged[Stdcall]<ACBindings.Internal.IUnknown*, ACBindings.Internal._GUID*, void**, int> QueryInterface; // function pointer
        public delegate* unmanaged[Stdcall]<ACBindings.Internal.IUnknown*, uint> AddRef; // function pointer
        public delegate* unmanaged[Stdcall]<ACBindings.Internal.IUnknown*, uint> Release; // function pointer
        public delegate* unmanaged[Stdcall]<ACBindings.Internal.ID3DXFont*, System.IntPtr, int> GetDevice; // function pointer
        public System.IntPtr GetDescA;
        public System.IntPtr GetDescW;
        public delegate* unmanaged[Stdcall]<ACBindings.Internal.ID3DXFont*, System.IntPtr, int> GetTextMetricsA; // function pointer
        public delegate* unmanaged[Stdcall]<ACBindings.Internal.ID3DXFont*, System.IntPtr, int> GetTextMetricsW; // function pointer
        public delegate* unmanaged[Stdcall]<ACBindings.Internal.ID3DXFont*, System.IntPtr> GetDC; // function pointer
        public delegate* unmanaged[Stdcall]<ACBindings.Internal.ID3DXFont*, uint, System.IntPtr, ACBindings.Internal.tagRECT*, ACBindings.Internal.tagPOINT*, int> GetGlyphData; // function pointer
        public delegate* unmanaged[Stdcall]<ACBindings.Internal.ID3DXFont*, uint, uint, int> PreloadCharacters; // function pointer
        public delegate* unmanaged[Stdcall]<ACBindings.Internal.ID3DXFont*, uint, uint, int> PreloadGlyphs; // function pointer
        public delegate* unmanaged[Stdcall]<ACBindings.Internal.ID3DXFont*, sbyte*, int, int> PreloadTextA; // function pointer
        public delegate* unmanaged[Stdcall]<ACBindings.Internal.ID3DXFont*, ushort*, int, int> PreloadTextW; // function pointer
        public delegate* unmanaged[Stdcall]<ACBindings.Internal.ID3DXFont*, ACBindings.Internal.ID3DXSprite*, sbyte*, int, ACBindings.Internal.tagRECT*, uint, uint, int> DrawTextA; // function pointer
        public delegate* unmanaged[Stdcall]<ACBindings.Internal.ID3DXFont*, ACBindings.Internal.ID3DXSprite*, ushort*, int, ACBindings.Internal.tagRECT*, uint, uint, int> DrawTextW; // function pointer
        public delegate* unmanaged[Stdcall]<ACBindings.Internal.ID3DXFont*, int> OnLostDevice; // function pointer
        public delegate* unmanaged[Stdcall]<ACBindings.Internal.ID3DXFont*, int> OnResetDevice; // function pointer

        // Methods
    }

    // Methods
}

