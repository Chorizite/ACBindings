namespace ACBindings.Internal;


/// <summary>Represents a land‑block unit within the server, tracking identifiers, load statistics, and status information for synchronization and checkpointing.</summary>
public unsafe struct LBUnit
{
    // Members
    public uint lbID;
    public uint srvID;
    public ushort numBookies;
    public ushort computedLoad_;
    public uint numUniques_;
    public System.IntPtr lb;
    public System.IntPtr m_pBSE;
    public ushort flags_;
    public int fPendingCreate_;
    public int fIsLoaded_;
    public double m_timeLastCheckpointed;

    // Methods
}

