namespace ACBindings.Internal;


/// <summary>Encapsulates the outcome of a salvage operation, storing the skill used, items that could not be salvaged, each individual salvage result, and any augmentation bonus applied. The percent return field represents a derived metric calculated after the operation but is not serialized.</summary>
public unsafe struct SalvageOperationsResultData : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.PackObj BaseClass_PackObj; // ACBindings.Internal.PackObj

    // Child Types
    public unsafe struct SalvageOperationsResultData_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.SalvageOperationsResultData*, void> SalvageOperationsResultData_dtor_0; // function pointer
        public fixed byte gap4[4];
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.SalvageOperationsResultData*, uint> GetPackSize; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.SalvageOperationsResultData*, void**, uint, uint> Pack; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.SalvageOperationsResultData*, void**, uint, int> UnPack; // function pointer

        // Methods
    }

    // Members
    public uint m_skillUsed;
    public ACBindings.Internal.PackableList__uint m_notSalvagable;
    public ACBindings.Internal.PackableList___SalvageResult m_salvageResults;
    public double m_percentReturn;
    public int m_augBonus;

    // Generated Constructor
    public SalvageOperationsResultData() {
        _ConstructorInternal();
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>Provides direct access to the object's salvage results data buffer.
    /// <code>Offset: 0x005CA6D0
    /// char* __thiscall SalvageOperationsResultData::GetSalvageResults(char*)</code>
    /// </summary>
    /// <returns>A pointer to the beginning of the internal salvage results structure, typically used for serialization or iteration.</returns>
    public sbyte* GetSalvageResults() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SalvageOperationsResultData, sbyte*>)0x005CA6D0)(ref this);

    /// <summary>Serializes the salvage operation result into a binary buffer, including skill usage, non‑salvageable IDs, individual salvage results, and any augmentation bonus.
    /// <code>Offset: 0x005CA6E0
    /// unsigned int __thiscall SalvageOperationsResultData::Pack(SalvageOperationsResultData*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="this">Instance of SalvageOperationsResultData to serialize.</param>
    /// <param name="addr">Pointer to the current write position in the destination buffer; updated as data is written.</param>
    /// <param name="size">Maximum number of bytes available for writing. If insufficient, function returns required size without modifying the buffer.</param>
    /// <returns>Number of bytes written when sufficient space exists; otherwise the total byte count that would be needed to serialize the object.</returns>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SalvageOperationsResultData, void**, uint, uint>)0x005CA6E0)(ref this, addr, size);

    /// <summary>Deserializes a SalvageOperationsResultData instance from a byte buffer.
    /// <code>Offset: 0x005CA770
    /// int __thiscall SalvageOperationsResultData::UnPack(SalvageOperationsResultData*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Reference to the current read position; advanced as data is consumed.</param>
    /// <param name="size">Number of bytes remaining in the buffer to be unpacked.</param>
    /// <returns>1 if all fields were successfully unpacked, 0 otherwise.</returns>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SalvageOperationsResultData, void**, uint, int>)0x005CA770)(ref this, addr, size);

    /// <summary>Initializes a new instance of SalvageOperationsResultData, resetting all fields to default values and preparing empty lists for salvage results and non‑salvagable items.
    /// <code>Offset: 0x005CAA80
    /// void __thiscall SalvageOperationsResultData::SalvageOperationsResultData(SalvageOperationsResultData*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SalvageOperationsResultData, void>)0x005CAA80)(ref this);

    /// <summary>Destroys a SalvageOperationsResultData instance, freeing all stored salvage data and cleaning up associated resources.
    /// <code>Offset: 0x006AD540
    /// void __thiscall SalvageOperationsResultData::~SalvageOperationsResultData(SalvageOperationsResultData*)</code>
    /// </summary>
    /// <param name="this">The object being destructed.</param>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SalvageOperationsResultData, void>)0x006AD540)(ref this);

    /// <summary>Retrieves the augmentation bonus applied to salvage operations results.
    /// <code>Offset: 0x006B4B20
    /// int __thiscall SalvageOperationsResultData::GetAugBonus(SalvageOperationsResultData*)</code>
    /// </summary>
    /// <returns>The current augmentation bonus as stored in the result data.</returns>
    public int GetAugBonus() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SalvageOperationsResultData, int>)0x006B4B20)(ref this);
}

