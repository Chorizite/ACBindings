namespace ACBindings.Internal;


/// <summary>
/// Manages per-object configuration for range-based visibility or interaction checks, storing the target’s identifier, spatial limits, optional radius usage, Z-axis handling preference, and timing data for periodic updates and deletion scheduling.
/// </summary>
public unsafe struct ObjectRangeInfo
{
    // Members
    public ACBindings.Internal.ObjectRangeHandler* m_handler;
    public uint m_objectID;
    public double m_range;
    public byte m_useRadii;
    public byte m_ignoreZDelta;
    public double m_timeInterval;
    public double m_timeOut;
    public double m_executeAtTime;
    public double m_nextUpdate;
    public byte m_queuedForDeletion;

    // Methods
}

