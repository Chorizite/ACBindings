namespace ACBindings.Internal;

public unsafe struct CircularArray__sbyte
{
    // Child Types

    /// <summary>Iterates over a fixed-size circular buffer of characters, providing read‑only access to each element by maintaining a pointer to the underlying array and an index within its bounds.</summary>
    public unsafe struct const_iterator
    {
        // Members
        public System.IntPtr m_pcArray;
        public uint m_nIndex;

        // Methods
    }

    /// <summary>Iterates over elements within a fixed-size circular buffer of characters, tracking the current position via an index and accessing the underlying array through a pointer for efficient traversal.</summary>
    public unsafe struct iterator
    {
        // Members
        public System.IntPtr m_pcArray;
        public uint m_nIndex;

        // Methods
    }

    // Members
    public uint m_nStartIndex;
    public uint m_nEndIndex;
    public uint m_nNumElements;
    public fixed sbyte m_aMemory[32768];

    // Methods
}

