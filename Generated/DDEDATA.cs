namespace ACBindings.Internal;


/// <summary>Encapsulates the data payload for Dynamic Data Exchange operations, storing a format code followed by a byte sequence representing the actual data content.</summary>
public unsafe struct DDEDATA
{
    // Members
    public short _bf_0;
    public short cfFormat;
    public fixed byte Value[1];

    // Methods
}

