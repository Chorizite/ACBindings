namespace ACBindings;

// ImageDecoder
public unsafe struct ImageDecoder
{
    // Child Types
    // ImageDecoder_vtbl
    public unsafe struct ImageDecoder_vtbl
    {
        // Members
        public System.IntPtr ReadHeader; // function pointer
        public System.IntPtr Decode; // function pointer

        // Methods
    }

    // Members
    public System.IntPtr __vftable; // vtable pointer
    public ACBindings.RGBAUnion* m_pPal;
    public ACBindings.DataSource* m_pDataSrc;
    public int m_width;
    public int m_height;
    public int m_pitch;
    public int m_bpp;
    public byte* m_pDataDst;
    public ACBindings.PixelFormatDesc m_dstPFD;
    public ACBindings.PixelFormatDesc m_argbPFD;

    // Methods
}

