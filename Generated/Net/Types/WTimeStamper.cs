namespace ACBindings.Internal;


/// <summary>Provides a compact mechanism to store per‑identifier timestamps, enforcing forward progression rules; internally manages an 8‑bit hash table of time values and a global house timestamp.</summary>
public unsafe struct WTimeStamper : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.PackObj BaseClass_PackObj; // ACBindings.Internal.PackObj

    // Child Types
    public unsafe struct WTimeStamper_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.WTimeStamper*, void> WTimeStamper_dtor_0; // function pointer
        public fixed byte gap4[4];
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.WTimeStamper*, uint> GetPackSize; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.WTimeStamper*, void**, uint, uint> Pack; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.WTimeStamper*, void**, uint, int> UnPack; // function pointer

        // Methods
    }

    // Members
    public ACBindings.Internal.PHashTable__uint__byte _table;
    public byte _house_ts;

    // Generated Constructor
    public WTimeStamper() {
        _ConstructorInternal();
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>Attempts to set the house timestamp while guarding against large forward jumps that could indicate time wrap‑around; updates the internal value only when the new timestamp is within an acceptable range.
    /// <code>Offset: 0x006B3860
    /// int __thiscall WTimeStamper::UpdateHouseRestrictionTS(WTimeStamper*,unsigned __int8)</code>
    /// </summary>
    /// <param name="ts">The candidate timestamp to apply.</param>
    /// <returns>Non‑zero if the timestamp was accepted and stored; zero if rejected due to exceeding the allowed forward difference.</returns>
    public int UpdateHouseRestrictionTS(byte ts) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.WTimeStamper, byte, int>)0x006B3860)(ref this, ts);

    /// <summary>Calculates the number of bytes required to pack a WTimeStamper instance, accounting for its internal hash table data.
    /// <code>Offset: 0x006B38A0
    /// unsigned int __thiscall WTimeStamper::GetPackSize(WTimeStamper*)</code>
    /// </summary>
    /// <returns>The packed size in bytes, aligned to a four‑byte boundary.</returns>
    public uint GetPackSize() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.WTimeStamper, uint>)0x006B38A0)(ref this);

    /// <summary>Serializes a WTimeStamper into a binary stream, writing its timestamp byte followed by its internal hash table data.
    /// <code>Offset: 0x006B38E0
    /// unsigned int __thiscall WTimeStamper::Pack(WTimeStamper*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Address of the buffer pointer where packed bytes will be written; updated to point after the serialized data.</param>
    /// <param name="size">Number of bytes available in the destination buffer; packing occurs only if this meets or exceeds the required size.</param>
    /// <returns>The number of bytes needed to serialize the object. If the provided buffer is large enough, the object is packed and the pointer is advanced accordingly.</returns>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.WTimeStamper, void**, uint, uint>)0x006B38E0)(ref this, addr, size);

    /// <summary>Unpacks the WTimeStamper object's state from the supplied buffer. Reads a house timestamp byte, delegates unpacking of its internal hash table to the base class, and pads the buffer with zeros until the read position aligns on a 4‑byte boundary.
    /// <code>Offset: 0x006B3920
    /// int __thiscall WTimeStamper::UnPack(WTimeStamper*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Pointer to the current read position in the buffer; updated as data is consumed.</param>
    /// <param name="size">Number of bytes remaining in the buffer that may be processed.</param>
    /// <returns>Always returns 1, indicating successful unpacking.</returns>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.WTimeStamper, void**, uint, int>)0x006B3920)(ref this, addr, size);

    /// <summary>Destroys a WTimeStamper instance, freeing its internal hash table and restoring virtual function tables to the appropriate base state.
    /// <code>Offset: 0x006B3B90
    /// void __thiscall WTimeStamper::~WTimeStamper(WTimeStamper*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.WTimeStamper, void>)0x006B3B90)(ref this);

    /// <summary>Constructs a new WTimeStamper instance, initializing its base class virtual tables, setting up an internal hash table for timestamps, and resetting the house timestamp counter to zero.
    /// <code>Offset: 0x006B3C10
    /// void __thiscall WTimeStamper::WTimeStamper(WTimeStamper*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.WTimeStamper, void>)0x006B3C10)(ref this);

    /// <summary>Updates the timestamp associated with a given key in an internal hash table, inserting a new entry when none exists and enforcing that each update must be forward‑increasing or wrap around once per cycle.
    /// <code>Offset: 0x006B3CB0
    /// int __thiscall WTimeStamper::UpdateTS(WTimeStamper*,unsigned int,unsigned __int8)</code>
    /// </summary>
    /// <param name="key">The identifier used to locate the timestamp entry in the hash table.</param>
    /// <param name="new_ts">The proposed new timestamp value (an unsigned 8‑bit integer).</param>
    /// <returns>Non‑zero if the entry was inserted or updated successfully; zero if the update is rejected because it would break the monotonic progression rule.</returns>
    public int UpdateTS(uint key, byte new_ts) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.WTimeStamper, uint, byte, int>)0x006B3CB0)(ref this, key, new_ts);
}

