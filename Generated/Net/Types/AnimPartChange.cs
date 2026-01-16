namespace ACBindings.Internal;


/// <summary>Tracks a modification to an animation part, storing its index and unique identifier while linking changes in a doubly‑linked list for sequential processing. Used by the animation system to apply or revert part changes during playback.</summary>
public unsafe struct AnimPartChange
{
    // Base Classes
    public ACBindings.Internal.PackObj BaseClass_PackObj; // ACBindings.Internal.PackObj

    // Child Types
    public unsafe struct AnimPartChange_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.AnimPartChange*, void> AnimPartChange_dtor_0; // function pointer
        public fixed byte gap4[4];
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.AnimPartChange*, uint> GetPackSize; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.AnimPartChange*, void**, uint, uint> Pack; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.AnimPartChange*, void**, uint, int> UnPack; // function pointer

        // Methods
    }

    // Members
    public uint part_index;
    public ACBindings.Internal.IDClass____tagDataID part_id;
    public ACBindings.Internal.AnimPartChange* prev;
    public ACBindings.Internal.AnimPartChange* next;

    // Methods

    /// <summary>Serializes an AnimPartChange instance into a binary buffer by writing its part index followed by the packed part ID. If the supplied buffer has enough space, the data is written and the remaining unused length is returned; otherwise no data is written and the required byte count is returned.
    /// <code>Offset: 0x005AEA60
    /// unsigned int __thiscall AnimPartChange::Pack(AnimPartChange*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Pointer to the start of the destination buffer; updated to point just past the data written.</param>
    /// <param name="size">Number of bytes available in the destination buffer.</param>
    /// <returns>When sufficient space exists, returns the number of unused bytes left after packing. If the buffer is too small, returns the total byte count needed to pack this object.</returns>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AnimPartChange, void**, uint, uint>)0x005AEA60)(ref this, addr, size);

    /// <summary>Unpacks an animation part change from a serialized data stream, extracting the part index and its identifier.
    /// <code>Offset: 0x005AEAC0
    /// int __thiscall AnimPartChange::UnPack(AnimPartChange*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Pointer to the current position in the buffer; advances past the parsed data on return.</param>
    /// <param name="size">Number of bytes remaining in the buffer; must be at least 3 for successful unpacking.</param>
    /// <returns>Non‑zero if the unpack succeeded, zero otherwise (including insufficient data).</returns>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AnimPartChange, void**, uint, int>)0x005AEAC0)(ref this, addr, size);
}

