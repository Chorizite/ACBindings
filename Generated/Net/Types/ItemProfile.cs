namespace ACBindings.Internal;


/// <summary>Represents an item profile in the game system, holding the quantity of an item, its unique identifier, and an optional descriptor for serialization or additional metadata.</summary>
public unsafe struct ItemProfile : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.PackObj BaseClass_PackObj; // ACBindings.Internal.PackObj

    // Child Types
    public unsafe struct ItemProfile_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ItemProfile*, void> ItemProfile_dtor_0; // function pointer
        public fixed byte gap4[4];
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ItemProfile*, uint> GetPackSize; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ItemProfile*, void**, uint, uint> Pack; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ItemProfile*, void**, uint, int> UnPack; // function pointer

        // Methods
    }

    // Members
    public int amount;
    public uint iid;
    public ACBindings.Internal.PublicWeenieDesc* pwd;

    // Generated Constructor
    public ItemProfile() {
        _ConstructorInternal();
    }
    public ItemProfile(ACBindings.Internal.ItemProfile* rhs) {
        _ConstructorInternal(rhs);
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>Cleans up the item profile's description by destroying its PublicWeenieDesc instance and resetting the pointer to null.
    /// <code>Offset: 0x005D2750
    /// void __thiscall ItemProfile::Clear(ItemProfile*)</code>
    /// </summary>
    public void Clear() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ItemProfile, void>)0x005D2750)(ref this);

    /// <summary>Initializes a new ItemProfile instance with default values (amount zero, item ID zero, and null descriptor).
    /// <code>Offset: 0x005D2810
    /// void __thiscall ItemProfile::ItemProfile(ItemProfile*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ItemProfile, void>)0x005D2810)(ref this);

    /// <summary>Destroys an ItemProfile instance, freeing its associated PublicWeenieDesc and resetting base class vtable pointers.
    /// <code>Offset: 0x005D2830
    /// void __thiscall ItemProfile::~ItemProfile(ItemProfile*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ItemProfile, void>)0x005D2830)(ref this);

    /// <summary>Creates a new ItemProfile by copying the contents of another instance.
    /// <code>Offset: 0x005D2860
    /// void __thiscall ItemProfile::ItemProfile(ItemProfile*,const ItemProfile*)</code>
    /// </summary>
    /// <param name="rhs">The ItemProfile from which values are copied.</param>
    public void _ConstructorInternal(ACBindings.Internal.ItemProfile* rhs) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ItemProfile, ACBindings.Internal.ItemProfile*, void>)0x005D2860)(ref this, rhs);

    /// <summary>Serializes an ItemProfile into a buffer, encoding its amount, ID, and optional PublicWeenieDesc data.
    /// <code>Offset: 0x005D2890
    /// unsigned int __thiscall ItemProfile::Pack(ItemProfile*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Pointer to a memory location that receives the serialized data; upon return it points after the written bytes.</param>
    /// <param name="size">Maximum number of bytes available in the target buffer. If insufficient, nothing is written but the function returns the required size.</param>
    /// <returns>The total number of bytes needed to represent this ItemProfile, including any PublicWeenieDesc data.</returns>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ItemProfile, void**, uint, uint>)0x005D2890)(ref this, addr, size);

    /// <summary>Deserializes an ItemProfile from a binary stream, populating its amount and identifier while handling optional associated objects based on encoded flags.
    /// <code>Offset: 0x005D2910
    /// int __thiscall ItemProfile::UnPack(ItemProfile*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Reference to the current read position in the buffer; advanced as data is consumed.</param>
    /// <param name="size">Remaining size of the buffer; used to validate sufficient data before unpacking.</param>
    /// <returns>Non‑zero if unpack succeeded, zero otherwise.</returns>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ItemProfile, void**, uint, int>)0x005D2910)(ref this, addr, size);
}

