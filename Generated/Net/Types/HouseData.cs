namespace ACBindings.Internal;


/// <summary>Represents the data associated with an in‑game house, including purchase and rent timestamps, payment histories, location information, type classification, and maintenance status.</summary>
public unsafe struct HouseData : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.PackObj BaseClass_PackObj; // ACBindings.Internal.PackObj

    // Child Types
    public unsafe struct HouseData_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.HouseData*, void> HouseData_dtor_0; // function pointer
        public fixed byte gap4[4];
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.HouseData*, uint> GetPackSize; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.HouseData*, void**, uint, uint> Pack; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.HouseData*, void**, uint, int> UnPack; // function pointer

        // Methods
    }

    // Members
    public int m_buy_time;
    public int m_rent_time;
    public ACBindings.Internal.HousePaymentList m_buy;
    public ACBindings.Internal.HousePaymentList m_rent;
    public ACBindings.Internal.Position m_pos;
    public uint m_type;
    public int m_maintenance_free;

    // Generated Constructor
    public HouseData() {
        _ConstructorInternal();
    }
    public HouseData(ACBindings.Internal.HouseData* rhs) {
        _ConstructorInternal(rhs);
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>Calculates the total byte count necessary to serialize a house’s data, accounting for rent payments, purchase payments, and positional information, with an additional header offset.
    /// <code>Offset: 0x005BC5F0
    /// unsigned int __thiscall HouseData::GetPackSize(HouseData*)</code>
    /// </summary>
    /// <returns>The size in bytes required to pack the house data.</returns>
    public uint GetPackSize() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.HouseData, uint>)0x005BC5F0)(ref this);

    /// <summary>Packs the house data, including buy time, rent time, type, maintenance flag, payment lists, and position, into a supplied memory block.
    /// <code>Offset: 0x005BC640
    /// unsigned int __thiscall HouseData::Pack(HouseData*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Pointer to a buffer pointer where packed data will be written; updated to point after each field written.</param>
    /// <param name="size">Size of the available buffer space in bytes.</param>
    /// <returns>Number of bytes required to pack the entire HouseData object, regardless of whether the provided buffer was large enough.</returns>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.HouseData, void**, uint, uint>)0x005BC640)(ref this, addr, size);

    /// <summary>Deserializes a HouseData instance from a binary buffer, reading timestamps, type, maintenance status and nested lists.
    /// <code>Offset: 0x005BC6C0
    /// int __thiscall HouseData::UnPack(HouseData*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Pointer to the current position within the input buffer; updated as data is consumed.</param>
    /// <param name="size">Number of bytes remaining in the buffer; used to guard against overruns.</param>
    /// <returns>Non‑zero if all components were unpacked successfully, zero otherwise.</returns>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.HouseData, void**, uint, int>)0x005BC6C0)(ref this, addr, size);

    /// <summary>Creates a new HouseData object with all internal members set to their default state. Resets buy/rent timestamps, clears payment lists, initializes the positional frame to an identity transform at the origin, assigns appropriate vtables for base classes, and sets type and maintenance flags to zero.
    /// <code>Offset: 0x005BC780
    /// void __thiscall HouseData::HouseData(HouseData*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.HouseData, void>)0x005BC780)(ref this);

    /// <summary>Creates a HouseData instance by copying the state of another house data object.
    /// <code>Offset: 0x005BC890
    /// void __thiscall HouseData::HouseData(HouseData*,const HouseData*)</code>
    /// </summary>
    /// <param name="rhs">The house data object to copy from.</param>
    public void _ConstructorInternal(ACBindings.Internal.HouseData* rhs) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.HouseData, ACBindings.Internal.HouseData*, void>)0x005BC890)(ref this, rhs);

    /// <summary>Destructs a HouseData instance by clearing its rent and purchase payment lists and resetting all virtual function tables to their base definitions.
    /// <code>Offset: 0x006AC5A0
    /// void __thiscall HouseData::~HouseData(HouseData*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.HouseData, void>)0x006AC5A0)(ref this);
}

