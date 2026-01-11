namespace ACBindings.Internal;

public unsafe struct KeyBlob3DES
{
    // Members
    public ACBindings.Internal._PUBLICKEYSTRUC hdr;
    public uint aiPrivKeyAlg;
    public fixed byte KeyData[24];
    public byte KeyNul;
    public fixed byte NonZeroPadding[37];
    public byte bBlockType;
    public byte Reserved;

    // Methods
}

