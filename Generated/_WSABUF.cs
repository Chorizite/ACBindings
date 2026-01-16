namespace ACBindings.Internal;


/// <summary>Represents a buffer used in Winsock asynchronous I/O operations, holding the length of data and a pointer to the memory containing that data.</summary>
public unsafe struct _WSABUF
{
    // Members
    public uint len;
    public sbyte* buf;

    // Methods
}

