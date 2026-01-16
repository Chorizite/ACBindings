namespace ACBindings.Internal;


/// <summary>Represents a statistical modifier applied to game objects, storing its type, key identifier, and numeric value. It is serializable via Pack/UnPack functions and inherits packing utilities from PackObj.</summary>
public unsafe struct StatMod
{
    // Base Classes
    public ACBindings.Internal.PackObj BaseClass_PackObj; // ACBindings.Internal.PackObj

    // Child Types
    public unsafe struct StatMod_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.StatMod*, void> StatMod_dtor_0; // function pointer
        public fixed byte gap4[4];
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.StatMod*, uint> GetPackSize; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.StatMod*, void**, uint, uint> Pack; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.StatMod*, void**, uint, int> UnPack; // function pointer

        // Methods
    }

    // Members
    public uint type;
    public uint key;
    public float val;

    // Methods

    /// <summary>Unpacks a ShortCutData structure from the provided buffer by reading three consecutive unsigned integers and advancing the buffer pointer.
    /// <code>Offset: 0x005B75E0
    /// int __thiscall StatMod::UnPack(ShortCutData*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="this">Pointer to the ShortCutData instance into which data will be loaded.</param>
    /// <param name="addr">Address of a pointer that references the current position in the input buffer; updated to point after the read data.</param>
    /// <param name="size">Number of bytes remaining in the buffer; must be at least 12 for successful unpacking.</param>
    /// <returns>1 if the buffer contains enough data and fields were populated successfully; otherwise 0.</returns>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.StatMod, void**, uint, int>)0x005B75E0)(ref this, addr, size);

    /// <summary>Writes the StatMod's type, key and value into a supplied buffer, advancing the write pointer by 12 bytes.
    /// <code>Offset: 0x005BE160
    /// unsigned int __thiscall StatMod::Pack(StatMod*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Reference to the current write position; updated to point after the packed data.</param>
    /// <param name="size">Number of bytes remaining in the destination buffer; must be at least 12 for packing to occur.</param>
    /// <returns>Always returns 12, the size of the serialized StatMod structure.</returns>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.StatMod, void**, uint, uint>)0x005BE160)(ref this, addr, size);
}

