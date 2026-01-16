namespace ACBindings.Internal;


/// <summary>Represents a DDE poke payload, consisting of a clipboard format code followed by the data to be transferred.</summary>
public unsafe struct DDEPOKE
{
    // Members
    public short _bf_0;
    public short cfFormat;
    public fixed byte Value[1];

    // Methods
}

