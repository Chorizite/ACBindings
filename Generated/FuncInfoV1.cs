namespace ACBindings.Internal;


/// <summary>Stores metadata required by the runtime to perform stack unwinding and exception handling, including a magic number, maximum state count, unwind map, try block table, and instruction‑pointer to state mapping.</summary>
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

