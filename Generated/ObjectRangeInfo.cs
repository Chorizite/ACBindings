namespace ACBindings;

// ObjectRangeInfo
public unsafe struct ObjectRangeInfo
{
    // Members
    public ACBindings.ObjectRangeHandler* m_handler;
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

