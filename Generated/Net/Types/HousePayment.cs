namespace ACBindings.Internal;


/// <summary>Encapsulates payment data for a house transaction, including identifiers, amounts, and descriptive names.</summary>
public unsafe struct HousePayment : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.PackObj BaseClass_PackObj; // ACBindings.Internal.PackObj

    // Child Types
    public unsafe struct HousePayment_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.HousePayment*, void> HousePayment_dtor_0; // function pointer
        public fixed byte gap4[4];
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.HousePayment*, uint> GetPackSize; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.HousePayment*, void**, uint, uint> Pack; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.HousePayment*, void**, uint, int> UnPack; // function pointer

        // Methods
    }

    // Members
    public ACBindings.Internal.IDClass____tagDataID wcid;
    public int num;
    public int paid;
    public ACBindings.Internal.AC1Legacy.PStringBase__sbyte name;
    public ACBindings.Internal.AC1Legacy.PStringBase__sbyte pname;

    // Generated Constructor
    public HousePayment() {
        _ConstructorInternal();
    }
    public HousePayment(ACBindings.Internal.HousePayment* rhs) {
        _ConstructorInternal(rhs);
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>Initializes a HousePayment instance with default values and assigns shared empty string buffers for name and pname.
    /// <code>Offset: 0x004A2960
    /// void __thiscall HousePayment::HousePayment(HousePayment*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.HousePayment, void>)0x004A2960)(ref this);

    /// <summary>Releases resources owned by HousePayment, decrementing the reference counts of its string buffers and restoring the base class vtable to the default state.
    /// <code>Offset: 0x004A29B0
    /// void __thiscall HousePayment::~HousePayment(HousePayment*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.HousePayment, void>)0x004A29B0)(ref this);

    /// <summary>Attempts to pay a trade note using the specified amount and value per note, updating the paid count and returning how many notes were successfully applied.
    /// <code>Offset: 0x005BB720
    /// int __thiscall HousePayment::PayWithTradeNote(HousePayment*,const int,const int)</code>
    /// </summary>
    /// <param name="amount">The maximum number of trade notes that may be used for payment.</param>
    /// <param name="value">The monetary value represented by each trade note.</param>
    /// <returns>Zero if the payment cannot be processed; otherwise, the number of trade notes actually applied to the payment.</returns>
    public int PayWithTradeNote(int amount, int value) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.HousePayment, int, int, int>)0x005BB720)(ref this, amount, value);

    /// <summary>Computes the serialized byte count for the house payment, adding the packed sizes of both the primary name and the alternate name along with a fixed 12‑byte header overhead.
    /// <code>Offset: 0x005BBAF0
    /// unsigned int __thiscall HousePayment::GetPackSize(HousePayment*)</code>
    /// </summary>
    /// <returns>The total number of bytes required to pack this HousePayment instance.</returns>
    public uint GetPackSize() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.HousePayment, uint>)0x005BBAF0)(ref this);

    /// <summary>Packs the HousePayment object's data into a binary stream, serializing its numeric fields and strings while advancing the output pointer.
    /// <code>Offset: 0x005BBB30
    /// unsigned int __thiscall HousePayment::Pack(HousePayment*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Pointer to the current write position; updated to point after serialized data.</param>
    /// <param name="size">Remaining buffer capacity in bytes; packing proceeds only if sufficient space is available.</param>
    /// <returns>Unsigned integer indicating total byte count required for packing this object.</returns>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.HousePayment, void**, uint, uint>)0x005BBB30)(ref this, addr, size);

    /// <summary>Creates a HousePayment object by copying the contents of another instance, initializing its fields and managing reference counts for string buffers.
    /// <code>Offset: 0x005BBBB0
    /// void __thiscall HousePayment::HousePayment(HousePayment*,const HousePayment*)</code>
    /// </summary>
    /// <param name="rhs">The source HousePayment to copy data from.</param>
    public void _ConstructorInternal(ACBindings.Internal.HousePayment* rhs) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.HousePayment, ACBindings.Internal.HousePayment*, void>)0x005BBBB0)(ref this, rhs);

    /// <summary>Deserializes a HousePayment record from a binary buffer, updating the object's fields and advancing the read pointer.
    /// <code>Offset: 0x005BBC00
    /// int __thiscall HousePayment::UnPack(HousePayment*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Reference to a pointer into the buffer; advanced as each field is extracted.</param>
    /// <param name="size">Number of bytes remaining in the buffer when called.</param>
    /// <returns>Nonzero if all fields—including both string members—are unpacked successfully; zero otherwise.</returns>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.HousePayment, void**, uint, int>)0x005BBC00)(ref this, addr, size);

    /// <summary>Creates a textual representation of the payment’s numeric value, appends a trailing space, and passes the resulting string to GetName for final processing.
    /// <code>Offset: 0x005BC000
    /// int __thiscall HousePayment::ComposeText(_DWORD*,int)</code>
    /// </summary>
    /// <param name="a2">String buffer into which the composed text is appended.</param>
    /// <returns>Return value from HousePayment::GetName.</returns>
    public int ComposeText(int a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.HousePayment, int, int>)0x005BC000)(ref this, a2);

    /// <summary>Constructs a formatted string consisting of the payment's name, a slash separator, its secondary name followed by a space, stores it in the supplied buffer, and passes that buffer to GetName.
    /// <code>Offset: 0x005BC0C0
    /// int __thiscall HousePayment::ComposeText2(_DWORD*,int)</code>
    /// </summary>
    /// <param name="a2">Pointer to a PStringBase&lt;char&gt; instance that receives the composed text.</param>
    /// <returns>Integer status returned by HousePayment::GetName.</returns>
    public int ComposeText2(int a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.HousePayment, int, int>)0x005BC0C0)(ref this, a2);
}

