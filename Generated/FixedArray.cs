namespace ACBindings.Internal;

public unsafe struct FixedArray___PStringBase__sbyte
{
    // Members
    public System.IntPtr m_data;
    public uint m_num;

    // Methods

    /// <summary>Initializes a FixedArray to contain the specified number of PStringBase instances and allocates memory for them.
    /// <code>Offset: 0x00435390
    /// LONG __thiscall FixedArray&lt;PStringBase&lt;char&gt;&gt;::Create(PStringBase&lt;char&gt;**,int)</code>
    /// </summary>
    /// <param name="a2">The desired count of elements in the array.</param>
    /// <returns>The number of elements successfully initialized (a2 – 1), or zero if allocation fails.</returns>
    // LONG __thiscall FixedArray<PStringBase<char>>::Create(PStringBase<char>**,int) (template type method)
}

public unsafe struct FixedArray__uint
{
    // Members
    public uint* m_data;
    public uint m_num;

    // Methods
}

public unsafe struct FixedArray___TextureBasedFontCharacter
{
    // Members
    public ACBindings.Internal.TextureBasedFontCharacter* m_data;
    public uint m_num;

    // Methods
}

public unsafe struct FixedArray__sbyte_ptr
{
    // Members
    public sbyte** m_data;
    public uint m_num;

    // Methods
}

