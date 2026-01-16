namespace ACBindings.Internal;


/// <summary>Decodes raw image data from a source into a destination buffer, handling palette mapping, pixel format conversion, and exposing image dimensions and format information.</summary>
public unsafe struct ImageDecoder
{
    // Child Types
    public unsafe struct ImageDecoder_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ImageDecoder*, int*, int*, ACBindings.Internal.PixelFormatID*, int> ReadHeader; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ImageDecoder*, int> Decode; // function pointer

        // Methods
    }

    // Members
    public System.IntPtr __vftable; // vtable pointer
    public ACBindings.Internal.RGBAUnion* m_pPal;
    public ACBindings.Internal.DataSource* m_pDataSrc;
    public int m_width;
    public int m_height;
    public int m_pitch;
    public int m_bpp;
    public byte* m_pDataDst;
    public ACBindings.Internal.PixelFormatDesc m_dstPFD;
    public ACBindings.Internal.PixelFormatDesc m_argbPFD;

    // Methods
}

