namespace ACBindings.Internal;


/// <summary>Represents an object containing a virtual function table pointer, enabling dynamic dispatch of member functions in derived types.</summary>
public unsafe struct PackObj
{
    // Child Types

    /// <summary>Defines the vtable layout for PackObj, exposing methods for object destruction, determining pack size, serializing (Pack), and deserializing (UnPack) packed data.</summary>
    public unsafe struct PackObj_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.PackObj*, void> PackObj_dtor_0; // function pointer
        public fixed byte gap4[4];
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.PackObj*, uint> GetPackSize; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.PackObj*, void**, uint, uint> Pack; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.PackObj*, void**, uint, int> UnPack; // function pointer

        // Methods
    }

    // Members
    public System.IntPtr __vftable; // vtable pointer

    // Methods

    /// <summary>Retrieves the total size in bytes of the pack represented by this object.
    /// <code>Offset: 0x00401090
    /// unsigned int __thiscall PackObj::GetPackSize(PackObj*)</code>
    /// </summary>
    /// <returns>The size of the pack in bytes as an unsigned integer.</returns>
    public uint GetPackSize() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PackObj, uint>)0x00401090)(ref this);

    /// <summary>Unpacks a 32‑bit integer from the supplied buffer into the provided output pointer.
    /// <code>Offset: 0x004FD180
    /// int __cdecl PackObj::UNPACK_TYPE(int*,void**,unsigned int*)</code>
    /// </summary>
    /// <param name="data_r">Receives the extracted integer value.</param>
    /// <param name="buffer_vpr">Pointer to the current read position within the buffer; advanced by four bytes on success.</param>
    /// <param name="size_r">Current remaining size of the buffer in bytes; decreased by four on successful unpack.</param>
    /// <returns>Nonzero if an integer was successfully extracted; zero when fewer than four bytes remain.</returns>
    public static int UNPACK_TYPE(int* data_r, void** buffer_vpr, uint* size_r) => ((delegate* unmanaged[Cdecl]<int*, void**, uint*, int>)0x004FD180)(data_r, buffer_vpr, size_r);

    /// <summary>Aligns a memory address to the next 4‑byte boundary by zeroing any intervening bytes and updating the pointer, returning the number of padded bytes.
    /// <code>Offset: 0x004FD1B0
    /// unsigned int __cdecl PackObj::ALIGN_PTR(void**)</code>
    /// </summary>
    /// <param name="ptr">The address to align; on return points to the new aligned location.</param>
    /// <returns>The count of bytes written (zero if the original address was already aligned).</returns>
    public static uint ALIGN_PTR(void** ptr) => ((delegate* unmanaged[Cdecl]<void**, uint>)0x004FD1B0)(ptr);

    /// <summary>Aligns a pointer to the next 4‑byte boundary within a buffer, zeroing any padding bytes and reducing the available size accordingly.
    /// <code>Offset: 0x00500610
    /// int __cdecl PackObj::ALIGN_PTR(void**,unsigned int*)</code>
    /// </summary>
    /// <param name="ptr">Reference to the current pointer; advanced to the aligned address if alignment succeeds.</param>
    /// <param name="size">Pointer to the remaining buffer length; decremented by the number of padding bytes added. Left unchanged on failure.</param>
    /// <returns>Non‑zero (1) when alignment succeeds, zero (0) when there is insufficient space for the required padding.</returns>
    public static int ALIGN_PTR(void** ptr, uint* size) => ((delegate* unmanaged[Cdecl]<void**, uint*, int>)0x00500610)(ptr, size);

    /// <summary>Determines how many bytes remain within a range defined by a start pointer and total size, given a current address.
    /// <code>Offset: 0x00526D90
    /// unsigned int __cdecl PackObj::GET_SIZE_LEFT(void*,void*,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Current pointer within the buffer region.</param>
    /// <param name="start">Starting address of the buffer region.</param>
    /// <param name="size">Total number of bytes in the buffer region.</param>
    /// <returns>Number of bytes left from <paramref name="addr"/> to the end of the region; zero if the address is at or beyond the end.</returns>
    public static uint GET_SIZE_LEFT(System.IntPtr addr, System.IntPtr start, uint size) => ((delegate* unmanaged[Cdecl]<System.IntPtr, System.IntPtr, uint, uint>)0x00526D90)(addr, start, size);

    /// <summary>Checks whether a given address lies inside the memory block starting at <paramref name="start"/> and spanning <paramref name="size"/> bytes, including both boundaries.
    /// <code>Offset: 0x00526DB0
    /// int __cdecl PackObj::VERIFY_ADDR(void*,void*,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Address to validate.</param>
    /// <param name="start">Start of the examined range.</param>
    /// <param name="size">Number of bytes in the range.</param>
    /// <returns>Non‑zero if <paramref name="addr"/> is within [<paramref name="start"/>, <paramref name="start"/>+<paramref name="size"/>]; otherwise zero.</returns>
    public static int VERIFY_ADDR(System.IntPtr addr, System.IntPtr start, uint size) => ((delegate* unmanaged[Cdecl]<System.IntPtr, System.IntPtr, uint, int>)0x00526DB0)(addr, start, size);
}

