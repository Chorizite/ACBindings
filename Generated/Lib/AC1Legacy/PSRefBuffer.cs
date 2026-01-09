namespace ACBindings.AC1Legacy;

// AC1Legacy::PSRefBuffer<char>
public unsafe struct PSRefBuffer__sbyte
{
    // Base Classes
    public ACBindings.ReferenceCountTemplate BaseClass_ReferenceCountTemplate; // ACBindings.ReferenceCountTemplate

    // Members
    public uint m_len;
    public uint m_size;
    public uint m_hash;
    public fixed sbyte m_data[1];

    // Methods
}

// AC1Legacy::PSRefBuffer<unsigned short>
public unsafe struct PSRefBuffer__ushort
{
    // Base Classes
    public ACBindings.ReferenceCountTemplate BaseClass_ReferenceCountTemplate; // ACBindings.ReferenceCountTemplate

    // Members
    public uint m_len;
    public uint m_size;
    public uint m_hash;
    public fixed ushort m_data[1];

    // Methods
}

