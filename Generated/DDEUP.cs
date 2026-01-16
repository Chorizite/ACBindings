namespace ACBindings.Internal;


/// <summary>DDEUP encapsulates a DDE update packet containing a format identifier and associated data payload for interprocess communication.</summary>
public unsafe struct DDEUP
{
    // Members
    public short _bf_0;
    public short cfFormat;
    public fixed byte rgb[1];

    // Methods
}

