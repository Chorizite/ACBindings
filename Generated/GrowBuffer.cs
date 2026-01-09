namespace ACBindings;

// GrowBuffer
public unsafe struct GrowBuffer
{
    // Base Classes
    public ACBindings.ReferenceCountTemplate BaseClass_ReferenceCountTemplate; // ACBindings.ReferenceCountTemplate

    // Statics
    public static ACBindings.GrowBuffer.FreeGrowBuffer* m_FreeList = (ACBindings.GrowBuffer.FreeGrowBuffer*)0x00837758;
    public static ACBindings.CSpinLock* m_pFreeListLock = (ACBindings.CSpinLock*)0x00837798;
    public static uint* m_nFreeListEntries = (uint*)0x0083779C;

    // Child Types
    // GrowBuffer_vtbl
    public unsafe struct GrowBuffer_vtbl
    {
        // Members
        public System.IntPtr GrowBuffer_dtor_0; // function pointer

        // Methods
    }
    // GrowBuffer::FreeGrowBuffer
    public unsafe struct FreeGrowBuffer
    {
        // Members
        public byte* pData;
        public uint cbSize;

        // Methods
    }
    // GrowBuffer::GrowExact::__l2::FreeListLockAllocator
    public unsafe struct FreeListLockAllocator
    {
        // Methods
    }

    // Members
    public byte* m_data;
    public uint m_size;
    public byte m_ownsBuffer;
    public byte m_bCanResize;
    public byte m_bAllocateFromFreelist;

    // Methods
    // unsigned int __thiscall GrowBuffer::GetGoodSize(GrowBuffer*,unsigned int)
    public uint GetGoodSize(uint i_sizeNeeded) => ((delegate* unmanaged[Thiscall]<ref ACBindings.GrowBuffer, uint, uint>)0x00406E20)(ref this, i_sizeNeeded);
    // void __thiscall GrowBuffer::FreeBuffer(GrowBuffer*)
    public void FreeBuffer() => ((delegate* unmanaged[Thiscall]<ref ACBindings.GrowBuffer, void>)0x00406E80)(ref this);
    // void __thiscall GrowBuffer::GrowExact(GrowBuffer*,unsigned int)
    public void GrowExact(uint i_exactSize) => ((delegate* unmanaged[Thiscall]<ref ACBindings.GrowBuffer, uint, void>)0x00407250)(ref this, i_exactSize);
}

