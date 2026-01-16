namespace ACBindings.Internal;


/// <summary>Represents a resizable byte buffer, storing a pointer to the allocated data and tracking its size in bytes.</summary>
public unsafe struct CGrowBuffer
{
    // Members
    public byte* m_pbBuffer;
    public uint m_cbSize;

    // Methods
}

