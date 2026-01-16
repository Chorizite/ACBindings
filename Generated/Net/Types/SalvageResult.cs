namespace ACBindings.Internal;


/// <summary>
/// Represents a salvage operation result, containing an identifier for the material salvaged, the workmanship quality as a long double, and the number of units recovered.
/// </summary>
public unsafe struct SalvageResult
{
    // Base Classes
    public ACBindings.Internal.PackObj BaseClass_PackObj; // ACBindings.Internal.PackObj

    // Child Types
    public unsafe struct SalvageResult_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.SalvageResult*, void> SalvageResult_dtor_0; // function pointer
        public fixed byte gap4[4];
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.SalvageResult*, uint> GetPackSize; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.SalvageResult*, void**, uint, uint> Pack; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.SalvageResult*, void**, uint, int> UnPack; // function pointer

        // Methods
    }

    // Members
    public uint m_material;
    public double m_workmanship;
    public int m_units;

    // Methods

    /// <summary>Packs the SalvageResult fields into a contiguous block of memory.
    /// <code>Offset: 0x005CA810
    /// unsigned int __thiscall SalvageResult::Pack(SalvageResult*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Pointer to the destination buffer; updated to point after the written data.</param>
    /// <param name="size">Size, in bytes, of the available space at *addr.</param>
    /// <returns>Number of bytes written (16).</returns>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SalvageResult, void**, uint, uint>)0x005CA810)(ref this, addr, size);

    /// <summary>Deserializes a SalvageResult instance from raw binary data.
    /// <code>Offset: 0x005CA850
    /// int __thiscall SalvageResult::UnPack(SalvageResult*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Reference to the current position in the buffer; updated to point after the unpacked fields.</param>
    /// <param name="size">Number of bytes available for unpacking; must be at least 16.</param>
    /// <returns>1 if unpacking succeeded; otherwise, 0.</returns>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SalvageResult, void**, uint, int>)0x005CA850)(ref this, addr, size);
}

