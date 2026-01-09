namespace ACBindings;

// CircularArray<char,32768,1>
public unsafe struct CircularArray__sbyte
{
    // Child Types
    // CircularArray<char,32768,1>::const_iterator
    public unsafe struct const_iterator
    {
        // Members
        public System.IntPtr m_pcArray;
        public uint m_nIndex;

        // Methods
    }
    // CircularArray<char,32768,1>::iterator
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

