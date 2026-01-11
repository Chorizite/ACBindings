namespace ACBindings.Internal;

public unsafe struct Region
{
    // Members
    public ACBindings.Internal.tagRECT* m_lpBoundingERect;
    public ACBindings.Internal.tagRECT* m_lpFirstERect;
    public int m_iNumRects;
    public int m_iNumAllocatedRects;

    // Methods
}

