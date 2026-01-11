namespace ACBindings.Internal;

public unsafe struct CBufferIterator
{
    // Members
    public byte* m_pBuf;
    public uint m_dwCurOfs;
    public uint m_cbBufSize;

    // Methods

    /// <summary>
    /// <code>Offset: 0x005AB870
    /// bool __thiscall CBufferIterator::ReadPrimArray(CBufferIterator*,unsigned int*,int)</code>
    /// </summary>
    public byte ReadPrimArray(uint* a2, int a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CBufferIterator, uint*, int, byte>)0x005AB870)(ref this, a2, a3);
}

