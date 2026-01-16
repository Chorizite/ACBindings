namespace ACBindings.Internal;


/// <summary>Encapsulates configuration data for regenerating items within the game world, including probability, type identifiers, timing delays, creation limits, regeneration behavior, spatial positioning, and visual shading.</summary>
public unsafe struct GeneratorProfile
{
    // Base Classes
    public ACBindings.Internal.PackObj BaseClass_PackObj; // ACBindings.Internal.PackObj

    // Child Types
    public unsafe struct GeneratorProfile_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.GeneratorProfile*, void> GeneratorProfile_dtor_0; // function pointer
        public fixed byte gap4[4];
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.GeneratorProfile*, uint> GetPackSize; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.GeneratorProfile*, void**, uint, uint> Pack; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.GeneratorProfile*, void**, uint, int> UnPack; // function pointer

        // Methods
    }

    // Members
    public float probability;
    public ACBindings.Internal.IDClass____tagDataID type;
    public double delay;
    public int initCreate;
    public int maxNum;
    public ACBindings.Internal.RegenerationType whenCreate;
    public ACBindings.Internal.RegenLocationType whereCreate;
    public int stackSize;
    public uint ptid;
    public float shade;
    public ACBindings.Internal.Position pos_val;
    public uint slot;

    // Generated Constructor
    public GeneratorProfile() {
        _ConstructorInternal();
    }

    // Methods

    /// <summary>Initializes a GeneratorProfile object with default values governing how and where items regenerate in the game world.
    /// <code>Offset: 0x005D18D0
    /// void __thiscall GeneratorProfile::GeneratorProfile(GeneratorProfile*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.GeneratorProfile, void>)0x005D18D0)(ref this);

    /// <summary>Unpacks a GeneratorProfile from the supplied buffer and populates this object's fields. The function verifies that the buffer contains at least the required number of bytes before reading each member in order.
    /// <code>Offset: 0x005D1950
    /// int __thiscall GeneratorProfile::UnPack(GeneratorProfile*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Reference to a pointer into the data buffer; the function reads sequentially from this address and advances it past the consumed data.</param>
    /// <param name="size">Number of bytes remaining in the buffer when the call begins; used for bounds checking before unpacking.</param>
    /// <returns>Zero if unpack succeeded; non‑zero indicates failure, such as insufficient data or an error during nested unpacking.</returns>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.GeneratorProfile, void**, uint, int>)0x005D1950)(ref this, addr, size);

    /// <summary>Packs a GeneratorProfile into a contiguous memory block, serializing its fields in order.
    /// <code>Offset: 0x005D1AA0
    /// unsigned int __thiscall GeneratorProfile::Pack(GeneratorProfile*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="this">The generator profile instance to serialize.</param>
    /// <param name="addr">Pointer to the destination buffer; updated to point after written data.</param>
    /// <param name="size">Maximum number of bytes available for packing.</param>
    /// <returns>Number of bytes required to pack the entire profile, regardless of buffer size.</returns>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.GeneratorProfile, void**, uint, uint>)0x005D1AA0)(ref this, addr, size);
}

