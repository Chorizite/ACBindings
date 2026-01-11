namespace ACBindings.Internal;

public unsafe struct SmartBuffer
{
    // Members
    public uint m_startOffset;
    public uint m_size;
    public ACBindings.Internal.GrowBuffer* m_masterBuffer;

    // Generated Constructor
    public SmartBuffer() {
        _ConstructorInternal();
    }
    public SmartBuffer(ACBindings.Internal.SmartBuffer* i_rhs) {
        _ConstructorInternal(i_rhs);
    }
    public SmartBuffer(byte* i_addr, uint i_size) {
        _ConstructorInternal(i_addr, i_size);
    }

    // Methods

    /// <summary>Initializes a SmartBuffer with zero start offset, size, and no master buffer reference.
    /// <code>Offset: 0x00406D60
    /// void __thiscall SmartBuffer::SmartBuffer(SmartBuffer*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SmartBuffer, void>)0x00406D60)(ref this);

    /// <summary>Determines if the smart buffer is allowed to grow based on its master buffer’s resize capability.
    /// <code>Offset: 0x00406D70
    /// char __thiscall SmartBuffer::CanGrow(SmartBuffer*)</code>
    /// </summary>
    /// <returns>True (non‑zero) when there is no master buffer or the master buffer permits resizing; otherwise false (zero).</returns>
    public sbyte CanGrow() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SmartBuffer, sbyte>)0x00406D70)(ref this);

    /// <summary>Returns a pointer to the internal data segment managed by this SmartBuffer.
    /// <code>Offset: 0x00406D80
    /// unsigned __int8* __thiscall SmartBuffer::GetBuffer(SmartBuffer*)</code>
    /// </summary>
    /// <returns>A pointer to the start of the buffer data within the master GrowBuffer, or nullptr when no master buffer is associated.</returns>
    public byte* GetBuffer() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SmartBuffer, byte*>)0x00406D80)(ref this);

    /// <summary>Detaches the SmartBuffer from its master GrowBuffer, disabling ownership and resizability, then returns a pointer to the underlying data.
    /// <code>Offset: 0x00406D90
    /// unsigned __int8* __thiscall SmartBuffer::Orphan(SmartBuffer*)</code>
    /// </summary>
    /// <returns>A pointer to the buffer's raw data, or null if no master buffer is associated.</returns>
    public byte* Orphan() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SmartBuffer, byte*>)0x00406D90)(ref this);

    /// <summary>Retrieves the current size of the SmartBuffer instance.
    /// <code>Offset: 0x00406DB0
    /// unsigned int __thiscall SmartBuffer::GetSize(SmartBuffer*)</code>
    /// </summary>
    /// <returns>The number of elements stored in the buffer.</returns>
    public uint GetSize() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SmartBuffer, uint>)0x00406DB0)(ref this);

    /// <summary>Returns the reference count of the buffer's master buffer, or zero if no master exists.
    /// <code>Offset: 0x00406DC0
    /// unsigned int __thiscall SmartBuffer::GetShareCount(SmartBuffer*)</code>
    /// </summary>
    /// <returns>The current share count for the buffer.</returns>
    public uint GetShareCount() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SmartBuffer, uint>)0x00406DC0)(ref this);

    /// <summary>Initializes a new SmartBuffer by copying its start offset, size, and master buffer reference from the supplied source, incrementing the master buffer’s reference count when it is not null.
    /// <code>Offset: 0x00406F60
    /// void __thiscall SmartBuffer::SmartBuffer(SmartBuffer*,const SmartBuffer*)</code>
    /// </summary>
    /// <param name="i_rhs">Source SmartBuffer to copy data from.</param>
    public void _ConstructorInternal(ACBindings.Internal.SmartBuffer* i_rhs) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SmartBuffer, ACBindings.Internal.SmartBuffer*, void>)0x00406F60)(ref this, i_rhs);

    /// <summary>Releases the master buffer associated with this SmartBuffer, decrementing its reference count and clearing internal state.
    /// <code>Offset: 0x00406F90
    /// void __thiscall SmartBuffer::ReleaseMasterBuffer(SmartBuffer*)</code>
    /// </summary>
    public void ReleaseMasterBuffer() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SmartBuffer, void>)0x00406F90)(ref this);

    /// <summary>Initializes a SmartBuffer with a given data block, storing its size and setting the start offset to zero.
    /// <code>Offset: 0x00407060
    /// void __thiscall SmartBuffer::SmartBuffer(SmartBuffer*,unsigned __int8*,unsigned int)</code>
    /// </summary>
    /// <param name="i_addr">Pointer to an externally provided memory buffer that the SmartBuffer will reference.</param>
    /// <param name="i_size">Size of the referenced buffer in bytes. The SmartBuffer treats this as the total available data length.</param>
    public void _ConstructorInternal(byte* i_addr, uint i_size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SmartBuffer, byte*, uint, void>)0x00407060)(ref this, i_addr, i_size);

    /// <summary>Creates a sub‑buffer (window) into the current SmartBuffer’s data region, initializing the supplied result with an adjusted start offset and size while managing the underlying GrowBuffer’s reference count.
    /// <code>Offset: 0x00407140
    /// SmartBuffer* __thiscall SmartBuffer::MakeWindow(SmartBuffer*,SmartBuffer*,unsigned int,unsigned int)</code>
    /// </summary>
    /// <param name="result">The SmartBuffer instance to be configured as the new window.</param>
    /// <param name="i_start">Offset from this buffer’s starting point for the window.</param>
    /// <param name="i_size">Size of the window in bytes.</param>
    /// <returns>The initialized result buffer.</returns>
    public ACBindings.Internal.SmartBuffer* MakeWindow(ACBindings.Internal.SmartBuffer* result, uint i_start, uint i_size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SmartBuffer, ACBindings.Internal.SmartBuffer*, uint, uint, ACBindings.Internal.SmartBuffer*>)0x00407140)(ref this, result, i_start, i_size);

    /// <summary>Reinitializes the SmartBuffer by releasing any existing master buffer, resetting offsets and size, and allocating a new master buffer.
    /// <code>Offset: 0x004071E0
    /// void __thiscall SmartBuffer::CreateNewMasterBuffer(SmartBuffer*)</code>
    /// </summary>
    public void CreateNewMasterBuffer() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SmartBuffer, void>)0x004071E0)(ref this);

    /// <summary>Create a view into this buffer starting at the specified offset, covering the remaining data up to the end of the original buffer. The resulting SmartBuffer shares the same underlying master buffer.
    /// <code>Offset: 0x00407390
    /// SmartBuffer* __thiscall SmartBuffer::MakeWindow(SmartBuffer*,SmartBuffer*,unsigned int)</code>
    /// </summary>
    /// <param name="result">The SmartBuffer instance that will be initialized as the windowed view.</param>
    /// <param name="i_start">The offset within this buffer where the new window begins.</param>
    /// <returns>The supplied result buffer, configured to reference the subrange of data.</returns>
    public ACBindings.Internal.SmartBuffer* MakeWindow(ACBindings.Internal.SmartBuffer* result, uint i_start) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SmartBuffer, ACBindings.Internal.SmartBuffer*, uint, ACBindings.Internal.SmartBuffer*>)0x00407390)(ref this, result, i_start);

    /// <summary>Associates the buffer instance with externally provided memory, updating its size and preventing automatic resizing or ownership transfer.
    /// <code>Offset: 0x004073B0
    /// void __thiscall SmartBuffer::Borrow(SmartBuffer*,unsigned __int8*,unsigned int)</code>
    /// </summary>
    /// <param name="i_addr">Pointer to external data to borrow.</param>
    /// <param name="i_size">Size of the borrowed data in bytes.</param>
    public void Borrow(byte* i_addr, uint i_size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SmartBuffer, byte*, uint, void>)0x004073B0)(ref this, i_addr, i_size);

    /// <summary>Creates a clone of the current SmartBuffer into the supplied result buffer, allocating a new GrowBuffer and copying the underlying data.
    /// <code>Offset: 0x004073F0
    /// SmartBuffer* __thiscall SmartBuffer::Clone(SmartBuffer*,SmartBuffer*)</code>
    /// </summary>
    /// <param name="result">The SmartBuffer instance that will receive the cloned content.</param>
    /// <returns>The same SmartBuffer pointer passed in as result after cloning.</returns>
    public ACBindings.Internal.SmartBuffer* Clone(ACBindings.Internal.SmartBuffer* result) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SmartBuffer, ACBindings.Internal.SmartBuffer*, ACBindings.Internal.SmartBuffer*>)0x004073F0)(ref this, result);

    /// <summary>Reconfigures the buffer’s allocation and properties based on the requested size and supplied behavior flags.
    /// <code>Offset: 0x004074B0
    /// void __thiscall SmartBuffer::ReconfigureAllocation(SmartBuffer*,unsigned int,char)</code>
    /// </summary>
    /// <param name="i_sizeNeeded">Desired new size of the buffer in bytes.</param>
    /// <param name="i_dwBehaviorBits">
    ///   Bit‑encoded flags that control allocation behaviour:
    ///   <list type="bullet">
    ///     <item>Bit 0 (value 1) – use an optimized growth size calculation before allocating.</item>
    ///     <item>Bit 1 (value 2) – update stored size even when no resize is performed.</item>
    ///     <item>Bit 2 (value 4) – set the buffer to be non‑resizable after this call.</item>
    ///     <item>Bit 3 (value 8) – enable allocation from a freelist if available.</item>
    ///   </list>
    /// </param>
    public void ReconfigureAllocation(uint i_sizeNeeded, sbyte i_dwBehaviorBits) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SmartBuffer, uint, sbyte, void>)0x004074B0)(ref this, i_sizeNeeded, i_dwBehaviorBits);
}

