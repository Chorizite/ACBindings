namespace ACBindings.Internal;


/// <summary>Holds two 16‑bit timestamps and supplies methods for serializing them into a byte stream while maintaining 4‑byte alignment.</summary>
public unsafe struct PhysicsTimestampPack
{
    // Base Classes
    public ACBindings.Internal.PackObj BaseClass_PackObj; // ACBindings.Internal.PackObj

    // Child Types
    public unsafe struct PhysicsTimestampPack_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.PhysicsTimestampPack*, void> PhysicsTimestampPack_dtor_0; // function pointer
        public fixed byte gap4[4];
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.PhysicsTimestampPack*, uint> GetPackSize; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.PhysicsTimestampPack*, void**, uint, uint> Pack; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.PhysicsTimestampPack*, void**, uint, int> UnPack; // function pointer

        // Methods
    }

    // Members
    public ushort ts1;
    public ushort ts2;

    // Generated Constructor
    public PhysicsTimestampPack() {
        _ConstructorInternal();
    }

    // Methods

    /// <summary>Initializes a PhysicsTimestampPack instance by assigning the appropriate virtual table and resetting timestamps ts1 and ts2 to 0.
    /// <code>Offset: 0x005179F0
    /// void __thiscall PhysicsTimestampPack::PhysicsTimestampPack(PhysicsTimestampPack*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PhysicsTimestampPack, void>)0x005179F0)(ref this);

    /// <summary>Attempts to write two timestamp fields into a byte buffer when at least four bytes are available, updating the pointer and aligning it afterward.
    /// <code>Offset: 0x00517A10
    /// unsigned int __thiscall PhysicsTimestampPack::Pack(PhysicsTimestampPack*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Reference to the current write address; updated to point after the packed data if packing occurs.</param>
    /// <param name="size">Number of bytes remaining in the buffer; must be at least 4 for the timestamps to be written.</param>
    /// <returns>Always 4, representing the size of the timestamp block reserved (even when no data is written).</returns>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PhysicsTimestampPack, void**, uint, uint>)0x00517A10)(ref this, addr, size);

    /// <summary>Unpacks two 16‑bit timestamps from a byte buffer into ts1 and ts2 members, advances the buffer pointer past the data, aligns it, and returns a success flag.
    /// <code>Offset: 0x00517A50
    /// int __thiscall PhysicsTimestampPack::UnPack(PhysicsTimestampPack*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Address of a pointer to the input buffer; on return points past the unpacked data.</param>
    /// <param name="size">Number of bytes available in the buffer; must be at least 4 for a successful unpack.</param>
    /// <returns>Non‑zero if the timestamps were successfully read and stored; zero otherwise.</returns>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PhysicsTimestampPack, void**, uint, int>)0x00517A50)(ref this, addr, size);
}

