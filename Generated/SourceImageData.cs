namespace ACBindings.Internal;


/// <summary>Contains a pointer to an array of unsigned integers representing image pixels, along with the image's width, height, and pitch for row‑stride calculations.</summary>
public unsafe struct SourceImageData
{
    // Members
    public uint* pData;
    public uint cxImage;
    public uint cyImage;
    public uint pitch;

    // Methods
}

