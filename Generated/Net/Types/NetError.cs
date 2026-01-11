namespace ACBindings.Internal;

public unsafe struct NetError
{
    // Base Classes
    public ACBindings.Internal.PackObj BaseClass_PackObj; // ACBindings.Internal.PackObj

    // Child Types
    public unsafe struct NetError_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.NetError*, void> NetError_dtor_0; // function pointer
        public fixed byte gap4[4];
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.NetError*, uint> GetPackSize; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.NetError*, void**, uint, uint> Pack; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.NetError*, void**, uint, int> UnPack; // function pointer

        // Methods
    }

    // Members
    public uint m_stringID;
    public int m_tableID;

    // Methods

    /// <summary>Packs a NetError object's data into the supplied buffer and advances the pointer.
    /// <code>Offset: 0x004117B0
    /// unsigned int __thiscall NetError::Pack(NetError*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">A reference to a void* pointing to the start of the destination buffer; upon return, points past the written data.</param>
    /// <param name="size">Number of bytes available in the destination buffer.</param>
    /// <returns>Bytes required to pack this NetError instance, as returned by baseclass_0.GetPackSize(this).</returns>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.NetError, void**, uint, uint>)0x004117B0)(ref this, addr, size);

    /// <summary>Unpacks a NetError object from a byte buffer, reading the string ID and table ID when the buffer is large enough.
    /// <code>Offset: 0x00411800
    /// int __thiscall NetError::UnPack(NetError*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Pointer to the current position within the buffer; advanced as data is consumed.</param>
    /// <param name="size">Total number of bytes remaining in the buffer.</param>
    /// <returns>1 if the unpack succeeds; 0 if the buffer size is insufficient.</returns>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.NetError, void**, uint, int>)0x00411800)(ref this, addr, size);

    /// <summary>Retrieves a localized log string for a network error, storing the result into the supplied buffer. If no valid identifier is present, writes "unknown" instead.
    /// <code>Offset: 0x00412AE0
    /// int* __thiscall NetError::GetLogString(int,int*)</code>
    /// </summary>
    /// <param name="a2">Pointer to a wide‑string buffer where the log message will be written.</param>
    /// <returns>The same pointer provided in <paramref name="a2"/> containing the formatted log string.</returns>
    public int* GetLogString(int* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.NetError, int*, int*>)0x00412AE0)(ref this, a2);
}

