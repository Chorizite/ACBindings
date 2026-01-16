namespace ACBindings.Internal;


/// <summary>Defines a single try block in the code, including its low and high addresses, the range of catch blocks that may handle exceptions thrown within it, and a reference to the handler array used during runtime exception processing.</summary>
public unsafe struct TryBlockMapEntry
{
    // Members
    public int tryLow;
    public int tryHigh;
    public int catchHigh;
    public int nCatches;
    public System.IntPtr pHandlerArray;

    // Methods
}

