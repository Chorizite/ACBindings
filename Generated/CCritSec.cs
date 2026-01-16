namespace ACBindings.Internal;


/// <summary>Encapsulates a Windows RTL critical section, enabling thread‑safe coordination of concurrent operations.</summary>
public unsafe struct CCritSec
{
    // Members
    public ACBindings.Internal._RTL_CRITICAL_SECTION m_CritSec;

    // Methods
}

