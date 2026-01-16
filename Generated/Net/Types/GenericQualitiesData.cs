namespace ACBindings.Internal;


/// <summary>Holds generic quality statistics as type‑specific hash tables, enabling runtime lookup, modification, and binary serialization through pack/unpack operations.</summary>
public unsafe struct GenericQualitiesData : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.PackObj BaseClass_PackObj; // ACBindings.Internal.PackObj

    // Child Types
    public unsafe struct GenericQualitiesData_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.GenericQualitiesData*, void> GenericQualitiesData_dtor_0; // function pointer
        public fixed byte gap4[4];
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.GenericQualitiesData*, uint> GetPackSize; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.GenericQualitiesData*, void**, uint, uint> Pack; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.GenericQualitiesData*, void**, uint, int> UnPack; // function pointer

        // Methods
    }

    // Members
    public System.IntPtr m_pIntStatsTable;
    public System.IntPtr m_pBoolStatsTable;
    public System.IntPtr m_pFloatStatsTable;
    public System.IntPtr m_pStrStatsTable;

    // Generated Constructor
    public GenericQualitiesData() {
        _ConstructorInternal();
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>Initializes a new GenericQualitiesData instance by setting its virtual table pointer and clearing all stat table pointers.
    /// <code>Offset: 0x006B8740
    /// void __thiscall GenericQualitiesData::GenericQualitiesData(GenericQualitiesData*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.GenericQualitiesData, void>)0x006B8740)(ref this);

    /// <summary>Releases resources held by the generic qualities data, invoking cleanup routines for its integer, boolean, float, and string statistic tables and resetting internal pointers to null before restoring base class state.
    /// <code>Offset: 0x006B8760
    /// void __thiscall GenericQualitiesData::~GenericQualitiesData(GenericQualitiesData*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.GenericQualitiesData, void>)0x006B8760)(ref this);

    /// <summary>Packs the object's statistics tables into a supplied memory buffer and returns the total number of bytes required.
    /// <code>Offset: 0x006B87C0
    /// unsigned int __thiscall GenericQualitiesData::Pack(GenericQualitiesData*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Pointer to the destination buffer; may be null to query size only.</param>
    /// <param name="size">Size of the destination buffer in bytes.</param>
    /// <returns>The number of bytes needed to serialize all present statistics tables. If addr is non‑null and buffer has sufficient space, the function writes a presence bitmask followed by each table's data.</returns>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.GenericQualitiesData, void**, uint, uint>)0x006B87C0)(ref this, addr, size);

    /// <summary>Unpacks serialized quality statistics into hash tables according to flags in a memory buffer and updates the read position.
    /// <code>Offset: 0x006B8880
    /// int __thiscall GenericQualitiesData::UnPack(GenericQualitiesData*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Pointer to the current read location; advanced as data is consumed during unpacking.</param>
    /// <param name="size">Maximum number of bytes available for reading from the buffer.</param>
    /// <returns>1 if all requested tables were successfully unpacked and the buffer contained enough data; otherwise 0, resetting the read position.</returns>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.GenericQualitiesData, void**, uint, int>)0x006B8880)(ref this, addr, size);

    /// <summary>Retrieves a string entry from the object's internal string statistics table by its identifier and places it into the provided buffer.
    /// <code>Offset: 0x006B8A30
    /// int __thiscall GenericQualitiesData::InqString(_DWORD*,int,int*)</code>
    /// </summary>
    /// <param name="a2">The identifier used to look up the desired string value.</param>
    /// <param name="a3">A pointer to the output buffer that receives the retrieved string.</param>
    /// <returns>Nonzero (1) if the lookup succeeded; zero (0) if no table exists or the identifier is not found.</returns>
    public int InqString(int a2, int* a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.GenericQualitiesData, int, int*, int>)0x006B8A30)(ref this, a2, a3);

    /// <summary>Assigns a string value to the specified key within the object's string statistics table, creating or initializing the table if needed.
    /// <code>Offset: 0x006B8A60
    /// int __thiscall GenericQualitiesData::SetString(_DWORD*,unsigned int,int*)</code>
    /// </summary>
    /// <param name="a2">Identifier for the string entry.</param>
    /// <param name="a3">Pointer to the string data to store.</param>
    /// <returns>Non‑zero on success; zero if memory allocation fails.</returns>
    public int SetString(uint a2, int* a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.GenericQualitiesData, uint, int*, int>)0x006B8A60)(ref this, a2, a3);
}

