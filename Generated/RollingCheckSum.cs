namespace ACBindings.Internal;


/// <summary>Maintains a rolling checksum over data, storing intermediate components and an accumulated sum used for quick integrity checks across sequential data blocks.</summary>
public unsafe struct RollingCheckSum
{
    // Members
    public ushort r;
    public ushort c1;
    public ushort c2;
    public uint sum;

    // Methods
}

