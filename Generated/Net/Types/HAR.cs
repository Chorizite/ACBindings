namespace ACBindings.Internal;


/// <summary>Represents a host access record that associates a primary entity with its guests and roommates. Holds identification flags, a monarch ID, a hash table of guest information, and a list of roommate identifiers for quick lookup and management.</summary>
public unsafe struct HAR : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.PackObj BaseClass_PackObj; // ACBindings.Internal.PackObj

    // Child Types
    public unsafe struct HAR_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.HAR*, void> HAR_dtor_0; // function pointer
        public fixed byte gap4[4];
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.HAR*, uint> GetPackSize; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.HAR*, void**, uint, uint> Pack; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.HAR*, void**, uint, int> UnPack; // function pointer

        // Methods
    }

    // Members
    public uint _bitmask;
    public uint _monarch_iid;
    public ACBindings.Internal.PackableHashTable__uint___GuestInfo _guest_table;
    public ACBindings.Internal.PList__uint _roommate_list;

    // Generated Constructor
    public HAR() {
        _ConstructorInternal();
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>Serializes a HAR instance into a binary format, writing its bitmask, monarch IID, guest table, and roommate list with 4‑byte alignment.
    /// <code>Offset: 0x005B00E0
    /// unsigned int __thiscall HAR::Pack(HAR*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Pointer to the destination buffer; updated as data is written.</param>
    /// <param name="size">Maximum number of bytes available in the destination buffer.</param>
    /// <returns>Number of bytes required to serialize the HAR object (including padding). If size is sufficient, this many bytes are written; otherwise no data is produced.</returns>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.HAR, void**, uint, uint>)0x005B00E0)(ref this, addr, size);

    /// <summary>Serializes guest list, optional roommate and permission information from a HAR instance into a string buffer.
    /// <code>Offset: 0x005B06F0
    /// int __thiscall HAR::Dump(_DWORD*,int,int)</code>
    /// </summary>
    /// <param name="a2">Destination buffer for formatted data.</param>
    /// <param name="a3">When non‑zero, includes roommates and allegiance permissions in the output; otherwise only guests are written.</param>
    /// <returns>Always 1.</returns>
    public int Dump(int a2, int a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.HAR, int, int, int>)0x005B06F0)(ref this, a2, a3);

    /// <summary>Unpacks HAR data from the provided buffer, initializing bitmask, monarch ID, guest table, and roommate list as appropriate.
    /// <code>Offset: 0x005B0A70
    /// int __thiscall HAR::UnPack(HAR*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Pointer to the current read position; updated to the next unread byte after unpacking.</param>
    /// <param name="size">Number of bytes remaining in the buffer.</param>
    /// <returns>1 if unpack succeeded; 0 on failure (e.g., insufficient data or internal errors).</returns>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.HAR, void**, uint, int>)0x005B0A70)(ref this, addr, size);

    /// <summary>Creates a new HAR instance, initializing the guest table and roommate list to empty structures and resetting internal state.
    /// <code>Offset: 0x005B0DF0
    /// void __thiscall HAR::HAR(HAR*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.HAR, void>)0x005B0DF0)(ref this);

    /// <summary>Destroys a HAR instance, clearing its guest table and roommate list while resetting internal state flags and releasing allocated memory.
    /// <code>Offset: 0x005B0E60
    /// void __thiscall HAR::~HAR(HAR*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.HAR, void>)0x005B0E60)(ref this);
}

