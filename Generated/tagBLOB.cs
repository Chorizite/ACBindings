namespace ACBindings.Internal;


/// <summary>Represents a binary data buffer with explicit size and pointer to the payload, enabling storage and transmission of arbitrary data.</summary>
public unsafe struct tagBLOB
{
    // Members
    public uint cbSize;
    public byte* pBlobData;

    // Methods
}

