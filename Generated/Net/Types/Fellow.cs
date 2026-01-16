namespace ACBindings.Internal;


/// <summary>Represents a game character with identity, level, loot sharing preference, and core resource statistics.</summary>
/// <remarks>Includes cached values for quick access to power points and lighting effects, and tracks current and maximum health, stamina, and mana.</remarks>
public unsafe struct Fellow : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.PackObj BaseClass_PackObj; // ACBindings.Internal.PackObj

    // Child Types
    public unsafe struct Fellow_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.Fellow*, void> Fellow_dtor_0; // function pointer
        public fixed byte gap4[4];
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.Fellow*, uint> GetPackSize; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.Fellow*, void**, uint, uint> Pack; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.Fellow*, void**, uint, int> UnPack; // function pointer

        // Methods
    }

    // Members
    public ACBindings.Internal.AC1Legacy.PStringBase__sbyte _name;
    public uint _level;
    public uint _cp_cache;
    public uint _lum_cache;
    public int _share_loot;
    public uint _max_health;
    public uint _max_stamina;
    public uint _max_mana;
    public uint _current_health;
    public uint _current_stamina;
    public uint _current_mana;

    // Generated Constructor
    public Fellow() {
        _ConstructorInternal();
    }
    public Fellow(ACBindings.Internal.Fellow* rhs) {
        _ConstructorInternal(rhs);
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>Destructs a Fellow object, releasing its name buffer and resetting base class virtual table pointers.
    /// <code>Offset: 0x0048ED20
    /// void __thiscall Fellow::~Fellow(Fellow*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Fellow, void>)0x0048ED20)(ref this);

    /// <summary>Initializes a new Fellow instance with default values, setting the vtable, clearing numeric attributes, and assigning an empty name buffer.
    /// <code>Offset: 0x005BA9E0
    /// void __thiscall Fellow::Fellow(Fellow*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Fellow, void>)0x005BA9E0)(ref this);

    /// <summary>Creates a new Fellow by copying the state of another instance, sharing its name string through reference counting.
    /// <code>Offset: 0x005BAA30
    /// void __thiscall Fellow::Fellow(Fellow*,const Fellow*)</code>
    /// </summary>
    /// <param name="rhs">The Fellow whose data is duplicated into this object.</param>
    public void _ConstructorInternal(ACBindings.Internal.Fellow* rhs) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Fellow, ACBindings.Internal.Fellow*, void>)0x005BAA30)(ref this, rhs);

    /// <summary>Calculates the number of bytes needed to serialize a Fellow object, including its name and fixed-size header.
    /// <code>Offset: 0x005BAB30
    /// unsigned int __thiscall Fellow::GetPackSize(Fellow*)</code>
    /// </summary>
    /// <returns>The total byte count required for packing this Fellow instance.</returns>
    public uint GetPackSize() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Fellow, uint>)0x005BAB30)(ref this);

    /// <summary>Serializes a Fellow object's state into a contiguous byte buffer, writing primitive fields followed by its name string.
    /// <code>Offset: 0x005BAB50
    /// unsigned int __thiscall Fellow::Pack(Fellow*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Pointer to the destination buffer; on return points to the first unused byte after serialization.</param>
    /// <param name="size">Maximum number of bytes available for packing. If insufficient, no data is written.</param>
    /// <returns>Number of bytes required to pack a Fellow object.</returns>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Fellow, void**, uint, uint>)0x005BAB50)(ref this, addr, size);

    /// <summary>Unpacks serialized data into a Fellow instance, reading values for caches, level, health, stamina, mana, and loot sharing flags from the buffer.
    /// <code>Offset: 0x005BAC10
    /// int __thiscall Fellow::UnPack(Fellow*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Pointer to the current position within the data buffer; advanced as fields are read.</param>
    /// <param name="size">Number of bytes remaining in the buffer; must be at least 0x28 for a valid unpack.</param>
    /// <returns>Zero if size is insufficient, otherwise the result from _name.UnPack indicating success or failure.</returns>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Fellow, void**, uint, int>)0x005BAC10)(ref this, addr, size);
}

