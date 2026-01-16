namespace ACBindings.Internal;


/// <summary>Defines configuration for a freelist allocator, controlling recycling behavior, shrinking policy, and size limits.</summary>
public unsafe struct FreelistDef
{
    // Members
    public byte m_bRecycle;
    public byte m_bShrink;
    public uint m_nIdealSize;
    public uint m_nMaxSize;

    // Methods
}

