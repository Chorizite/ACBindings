namespace ACBindings.Internal;

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

