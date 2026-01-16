namespace ACBindings.Internal;


/// <summary>
/// Provides sequential, bounds‑checked access to a raw byte buffer, maintaining the current read offset and total size.
/// </summary>
public unsafe struct CBufferIterator
{
    // Members
    public byte* m_pBuf;
    public uint m_dwCurOfs;
    public uint m_cbBufSize;

    // Methods

    /// <summary>Reads an exact sequence of 32‑bit unsigned integers from the iterator’s buffer into a supplied array, advancing the iterator only when all requested elements are available.
    /// <code>Offset: 0x005AB870
    /// bool __thiscall CBufferIterator::ReadPrimArray(CBufferIterator*,unsigned int*,int)</code>
    /// </summary>
    /// <param name="a2">Pointer to the destination array for the read values.</param>
    /// <param name="a3">Number of 32‑bit unsigned integers to read.</param>
    /// <returns>True if the requested number of elements were present and copied; otherwise false, leaving the iterator unchanged.</returns>
    public byte ReadPrimArray(uint* a2, int a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CBufferIterator, uint*, int, byte>)0x005AB870)(ref this, a2, a3);
}

