namespace ACBindings.Internal;


/// <summary>Describes a RIFF chunk header used by the Windows multimedia API, containing the chunk identifier, size, type code, data offset, and flag bits.</summary>
public unsafe struct _MMCKINFO
{
    // Members
    public uint ckid;
    public uint cksize;
    public uint fccType;
    public uint dwDataOffset;
    public uint dwFlags;

    // Methods
}

