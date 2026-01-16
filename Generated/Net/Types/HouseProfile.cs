namespace ACBindings.Internal;


/// <summary>
/// Holds data for a house profile, including identification, ownership, name, buy and rent payment lists, level and allegiance restrictions, maintenance cost flag, and type classification.
/// </summary>
public unsafe struct HouseProfile : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.PackObj BaseClass_PackObj; // ACBindings.Internal.PackObj

    // Child Types
    public unsafe struct HouseProfile_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.HouseProfile*, void> HouseProfile_dtor_0; // function pointer
        public fixed byte gap4[4];
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.HouseProfile*, uint> GetPackSize; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.HouseProfile*, void**, uint, uint> Pack; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.HouseProfile*, void**, uint, int> UnPack; // function pointer

        // Methods
    }

    // Members
    public uint _id;
    public uint _owner;
    public ACBindings.Internal.AC1Legacy.PStringBase__sbyte _name;
    public uint _bitmask;
    public ACBindings.Internal.HousePaymentList _buy;
    public ACBindings.Internal.HousePaymentList _rent;
    public int _min_level;
    public int _max_level;
    public int _min_alleg_rank;
    public int _max_alleg_rank;
    public int _maintenance_free;
    public uint _type;

    // Generated Constructor
    public HouseProfile() {
        _ConstructorInternal();
    }
    public HouseProfile(ACBindings.Internal.HouseProfile* rhs) {
        _ConstructorInternal(rhs);
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>Determines whether a house operation (buy or rent) is fully paid by examining the associated payment list.
    /// <code>Offset: 0x005BC900
    /// int __thiscall HouseProfile::IsPaidInFull(HouseProfile*,HouseOp)</code>
    /// </summary>
    /// <param name="op">The house operation to evaluate, typically Buy_House or Rent_House.</param>
    /// <returns>Non‑zero if the operation has been paid in full; otherwise zero.</returns>
    public int IsPaidInFull(ACBindings.Internal.HouseOp op) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.HouseProfile, ACBindings.Internal.HouseOp, int>)0x005BC900)(ref this, op);

    /// <summary>Processes a purchase or rental payment by delegating to the appropriate payment list within the house profile.
    /// <code>Offset: 0x005BC930
    /// int __thiscall HouseProfile::Pay(HouseProfile*,HouseOp,const HousePayment*)</code>
    /// </summary>
    /// <param name="op">Specifies whether the operation is buying or renting the house.</param>
    /// <param name="pay">Payment details to apply to the chosen operation.</param>
    /// <returns>Non‑zero if the payment was processed successfully; otherwise zero.</returns>
    public int Pay(ACBindings.Internal.HouseOp op, ACBindings.Internal.HousePayment* pay) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.HouseProfile, ACBindings.Internal.HouseOp, ACBindings.Internal.HousePayment*, int>)0x005BC930)(ref this, op, pay);

    /// <summary>Removes the specified payment record from the house's buy or rent payment lists based on the provided operation.
    /// <code>Offset: 0x005BC960
    /// int __thiscall HouseProfile::RemovePayment(HouseProfile*,HouseOp,const HousePayment*)</code>
    /// </summary>
    /// <param name="op">Operation type indicating whether to remove a purchase or rental payment.</param>
    /// <param name="pay">Pointer to the HousePayment instance to be removed.</param>
    /// <returns>An integer indicating success (non‑zero) or failure (zero).</returns>
    public int RemovePayment(ACBindings.Internal.HouseOp op, ACBindings.Internal.HousePayment* pay) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.HouseProfile, ACBindings.Internal.HouseOp, ACBindings.Internal.HousePayment*, int>)0x005BC960)(ref this, op, pay);

    /// <summary>Creates a text representation of the house’s buy or rent payment list by forwarding to the relevant HousePaymentList::ComposeText.
    /// <code>Offset: 0x005BC990
    /// int __thiscall HouseProfile::ComposeText(_DWORD*,int,int)</code>
    /// </summary>
    /// <param name="a2">Specifies which payment list to compose: 1 for purchase, 2 for rental.</param>
    /// <param name="a3">Contextual information passed directly to HousePaymentList::ComposeText.</param>
    /// <returns>Result of the underlying ComposeText call; returns 0 if an unsupported type is requested or no payment list exists.</returns>
    public int ComposeText(int a2, int a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.HouseProfile, int, int, int>)0x005BC990)(ref this, a2, a3);

    /// <summary>Composes textual representation for a house's purchase or rental payments based on the provided type and forwards to the corresponding HousePaymentList.
    /// <code>Offset: 0x005BC9C0
    /// int __thiscall HouseProfile::ComposeText2(_DWORD*,int,int)</code>
    /// </summary>
    /// <param name="a2">Specifies which payment list to compose: 1 selects the buy list, 2 selects the rent list; any other value yields no operation.</param>
    /// <param name="a3">Value passed unchanged to HousePaymentList::ComposeText2 (typically a buffer or formatting flag).</param>
    /// <returns>Result of the composed text operation, or zero if an unsupported list type is requested.</returns>
    public int ComposeText2(int a2, int a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.HouseProfile, int, int, int>)0x005BC9C0)(ref this, a2, a3);

    /// <summary>Determines whether more payments can be added to the house's buy or rent list by delegating to the appropriate HousePaymentList instance.
    /// <code>Offset: 0x005BC9F0
    /// BOOL __thiscall HouseProfile::NeedsMore(_DWORD*,int,int)</code>
    /// </summary>
    /// <param name="a2">Specifies which payment list to inspect: 1 selects the buy list, 2 selects the rent list.</param>
    /// <param name="a3">Argument passed unchanged to HousePaymentList::NeedsMore; its meaning depends on that method’s implementation.</param>
    /// <returns>True if the chosen payment list can accept additional entries; otherwise false.</returns>
    public byte NeedsMore(int a2, int a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.HouseProfile, int, int, byte>)0x005BC9F0)(ref this, a2, a3);

    /// <summary>Packs the HouseProfile into a contiguous memory buffer, serializing all fields including identifiers, limits, type, name, and payment lists.
    /// <code>Offset: 0x005BCA20
    /// unsigned int __thiscall HouseProfile::Pack(HouseProfile*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Pointer to the buffer address; on success it points past the written data.</param>
    /// <param name="size">Maximum number of bytes available for writing.</param>
    /// <returns>Number of bytes written if the buffer is large enough; otherwise returns the required size without modifying the buffer.</returns>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.HouseProfile, void**, uint, uint>)0x005BCA20)(ref this, addr, size);

    /// <summary>Deserializes a HouseProfile from binary data, reading fields according to the specified version and advancing the input pointer.
    /// <code>Offset: 0x005BCBD0
    /// int __thiscall HouseProfile::UnPack(HouseProfile*,unsigned int,void**,unsigned int)</code>
    /// </summary>
    /// <param name="version">Format version used during unpacking; determines which fields are read.</param>
    /// <param name="addr">Pointer to the current position in the input buffer; advanced as data is consumed.</param>
    /// <param name="size">Number of bytes remaining in the buffer at the time of call.</param>
    /// <returns>Non-zero on success, zero if insufficient data or unpacking fails.</returns>
    public int UnPack(uint version, void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.HouseProfile, uint, void**, uint, int>)0x005BCBD0)(ref this, version, addr, size);

    /// <summary>Initializes a new HouseProfile instance with default values for all fields, sets up virtual function tables, and prepares empty payment lists.
    /// <code>Offset: 0x005BCD60
    /// void __thiscall HouseProfile::HouseProfile(HouseProfile*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.HouseProfile, void>)0x005BCD60)(ref this);

    /// <summary>Releases resources owned by a HouseProfile instance, including buy and rent payment lists, and decrements the reference count of its name string before clean‑up.
    /// <code>Offset: 0x005BCDE0
    /// void __thiscall HouseProfile::~HouseProfile(HouseProfile*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.HouseProfile, void>)0x005BCDE0)(ref this);

    /// <summary>Initializes a new HouseProfile by copying all data from an existing profile and setting up its internal payment lists.
    /// <code>Offset: 0x005BCE40
    /// void __thiscall HouseProfile::HouseProfile(HouseProfile*,const HouseProfile*)</code>
    /// </summary>
    /// <param name="rhs">The source HouseProfile whose values are copied into the newly constructed object.</param>
    public void _ConstructorInternal(ACBindings.Internal.HouseProfile* rhs) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.HouseProfile, ACBindings.Internal.HouseProfile*, void>)0x005BCE40)(ref this, rhs);

    /// <summary>Unpacks a HouseProfile from serialized data using the predefined format identifier 3.
    /// <code>Offset: 0x005BCE90
    /// int __thiscall HouseProfile::UnPack(HouseProfile*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Pointer to the buffer containing packed HouseProfile data; may be advanced to point after the processed bytes.</param>
    /// <param name="size">Number of bytes available in *addr for unpacking.</param>
    /// <returns>Zero on success, non‑zero indicates an error during unpacking.</returns>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.HouseProfile, void**, uint, int>)0x005BCE90)(ref this, addr, size);
}

