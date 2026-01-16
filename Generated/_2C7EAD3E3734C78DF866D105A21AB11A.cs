namespace ACBindings.Internal;


/// <summary>Holds Huffman decoding data used during inflation, including table ID, index, bit‑lengths array, and related structures.</summary>
/// <remarks>Utilized by the decompression routine to interpret compressed data blocks.</remarks>
public unsafe struct _2C7EAD3E3734C78DF866D105A21AB11A
{
    // Members
    public uint table;
    public uint index;
    public uint* blens;
    public uint bb;
    public System.IntPtr tb;

    // Methods
}

