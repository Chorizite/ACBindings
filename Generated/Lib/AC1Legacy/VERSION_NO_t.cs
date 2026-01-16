namespace ACBindings.Internal.AC1Legacy;


/// <summary>Encapsulates the legacy AC1 version information, comprising numeric revision, subcomponent, build identifiers, month/day release dates, and a debugging flag.</summary>
/// <remarks>Fields rr, sc, bb hold unsigned byte values; mm and dd store two-character date strings; debug indicates whether the build is in debugging mode. The structure is used for storing and transmitting version data across the application.</remarks>
public unsafe struct VERSION_NO_t
{
    // Members
    public byte rr;
    public byte sc;
    public byte bb;
    public fixed sbyte mm[2];
    public fixed sbyte dd[2];
    public sbyte debug;

    // Methods
}

