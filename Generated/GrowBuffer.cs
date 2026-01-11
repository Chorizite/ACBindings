namespace ACBindings.Internal;

public unsafe struct GrowBuffer
{
    // Base Classes
    public ACBindings.Internal.ReferenceCountTemplate BaseClass_ReferenceCountTemplate; // ACBindings.Internal.ReferenceCountTemplate

    // Statics
    public static ACBindings.Internal.GrowBuffer.FreeGrowBuffer* m_FreeList = (ACBindings.Internal.GrowBuffer.FreeGrowBuffer*)0x00837758;

    // Child Types
    public unsafe struct GrowBuffer_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.GrowBuffer*, void> GrowBuffer_dtor_0; // function pointer

        // Methods
    }
    public unsafe struct FreeGrowBuffer
    {
        // Members
        public byte* pData;
        public uint cbSize;

        // Methods
    }
    public unsafe struct GrowExact____l2__FreeListLockAllocator
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

    /// <summary>Computes an allocation size that is at least the requested amount and conforms to alignment constraints: a minimum of 16 bytes, a power‑of‑two boundary for moderate sizes, or rounding up to the next multiple of 0x40000 when the request exceeds that threshold.
    /// <code>Offset: 0x00406E20
    /// unsigned int __thiscall GrowBuffer::GetGoodSize(GrowBuffer*,unsigned int)</code>
    /// </summary>
    /// <param name="i_sizeNeeded">The number of bytes required for the buffer.</param>
    /// <returns>Adjusted size in bytes that meets the requested minimum and alignment rules described above.</returns>
    public uint GetGoodSize(uint i_sizeNeeded) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.GrowBuffer, uint, uint>)0x00406E20)(ref this, i_sizeNeeded);

    /// <summary>Frees the memory buffer owned by this GrowBuffer instance. If the buffer was allocated from a freelist, it is returned to that list for future reuse.
    /// <code>Offset: 0x00406E80
    /// void __thiscall GrowBuffer::FreeBuffer(GrowBuffer*)</code>
    /// </summary>
    public void FreeBuffer() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.GrowBuffer, void>)0x00406E80)(ref this);

    /// <summary>Ensures the GrowBuffer holds at least i_exactSize bytes, reallocating memory when necessary and preserving existing data.
    /// <code>Offset: 0x00407250
    /// void __thiscall GrowBuffer::GrowExact(GrowBuffer*,unsigned int)</code>
    /// </summary>
    /// <param name="i_exactSize">The desired buffer size in bytes.</param>
    public void GrowExact(uint i_exactSize) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.GrowBuffer, uint, void>)0x00407250)(ref this, i_exactSize);
}

