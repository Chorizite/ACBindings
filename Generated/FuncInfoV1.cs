namespace ACBindings;

// FuncInfoV1
public unsafe struct FuncInfoV1
{
    // Members
    public int magicNumber;
    public int maxState;
    public System.IntPtr pUnwindMap;
    public int nTryBlocks;
    public System.IntPtr pTryBlockMap;
    public int nIPMapEntries;
    public System.IntPtr pIPtoStateMap;

    // Methods
}

