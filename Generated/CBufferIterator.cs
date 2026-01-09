namespace ACBindings;

// CBufferIterator
public unsafe struct CBufferIterator
{
    // Members
    public byte* m_pBuf;
    public uint m_dwCurOfs;
    public uint m_cbBufSize;

    // Methods
    // bool __thiscall CBufferIterator::ReadPrimArray(CBufferIterator*,unsigned int*,int)
    public byte ReadPrimArray(uint* a2, int a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CBufferIterator, uint*, int, byte>)0x005AB870)(ref this, a2, a3);
}

