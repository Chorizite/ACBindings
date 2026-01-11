namespace ACBindings.Internal.AC1Legacy;
public unsafe struct PSRefBuffer__sbyte
{
    public Turbine_RefCount _ref;
    public int m_len;
    public uint m_size;
    public uint m_hash;
    public fixed sbyte m_data[512];
}

public unsafe struct PSRefBuffer__ushort
{
    public Turbine_RefCount _ref;
    public int m_len;
    public uint m_size;
    public uint m_hash;
    public fixed ushort m_data[256];
}