namespace ACBindings.Internal;


/// <summary>Admin account data used by the administrative subsystem to represent an individual account and its associated metadata such as name and bookie identifier.</summary>
public unsafe struct AdminAccountData
{
    // Base Classes
    public ACBindings.Internal.PackObj BaseClass_PackObj; // ACBindings.Internal.PackObj

    // Child Types
    public unsafe struct AdminAccountData_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.AdminAccountData*, void> AdminAccountData_dtor_0; // function pointer
        public fixed byte gap4[4];
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.AdminAccountData*, uint> GetPackSize; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.AdminAccountData*, void**, uint, uint> Pack; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.AdminAccountData*, void**, uint, int> UnPack; // function pointer

        // Methods
    }

    // Members
    public ACBindings.Internal.AC1Legacy.PStringBase__sbyte accountName;
    public uint bookieID;

    // Generated Constructor
    public AdminAccountData() {
        _ConstructorInternal();
    }

    // Methods

    /// <summary>Initializes an AdminAccountData instance by linking its base class vtable, assigning a default or global name to accountName, and setting bookieID to zero.
    /// <code>Offset: 0x006B1A00
    /// void __thiscall AdminAccountData::AdminAccountData(AdminAccountData*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AdminAccountData, void>)0x006B1A00)(ref this);

    /// <summary>Serializes the AdminAccountData object into a binary buffer, writing the account name followed by the bookie ID. If the supplied buffer has enough space, it writes the data and advances the pointer; otherwise no data is written. The function returns the total size required to pack the object.
    /// <code>Offset: 0x006B1A60
    /// unsigned int __thiscall AdminAccountData::Pack(AdminAccountData*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Pointer to the current write position in the destination buffer; will be moved past the written data if packing succeeds.</param>
    /// <param name="size">Number of bytes available at the given address for writing the packed data.</param>
    /// <returns>Size, in bytes, needed to represent the object when fully packed.</returns>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AdminAccountData, void**, uint, uint>)0x006B1A60)(ref this, addr, size);

    /// <summary>Deserializes an AdminAccountData object from a binary buffer, extracting the account name and associated bookie ID.
    /// <code>Offset: 0x006B1AC0
    /// int __thiscall AdminAccountData::UnPack(AdminAccountData*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Reference to the current position in the input buffer; advanced past the unpacked data upon return.</param>
    /// <param name="size">Remaining size of the buffer (not directly used but provided for consistency).</param>
    /// <returns>An integer status code, non‑zero on success.</returns>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AdminAccountData, void**, uint, int>)0x006B1AC0)(ref this, addr, size);
}

