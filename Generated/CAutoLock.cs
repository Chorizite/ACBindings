namespace ACBindings.Internal;


/// <summary>Encapsulates a pointer to CCritSec, enabling automatic lock handling in concurrent contexts.</summary>
public unsafe struct CAutoLock
{
    // Members
    public ACBindings.Internal.CCritSec* m_pLock;

    // Methods
}

