namespace ACBindings.Internal;


/// <summary>Captures metadata for a memory checkpoint, storing pointers to the data block and its starting address, size of the region, allocation status, and formatting preference.</summary>
public unsafe struct CheckpointData
{
    // Members
    public System.IntPtr _data;
    public System.IntPtr _start;
    public uint _size;
    public int _ialloc;
    public int _pretty;

    // Methods
}

