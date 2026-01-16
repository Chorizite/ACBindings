namespace ACBindings.Internal;


/// <summary>Globally unique identifier used to uniquely identify interfaces, objects, or components within the Windows COM architecture.</summary>
/// <remarks>Encapsulates a 32‑bit integer, two 16‑bit integers, and an eight-byte array that together encode the GUID value.</remarks>
public unsafe struct _GUID
{
    // Members
    public uint Data1;
    public ushort Data2;
    public ushort Data3;
    public fixed byte Data4[8];

    // Methods
}

