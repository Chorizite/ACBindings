namespace ACBindings.Internal;


/// <summary>Encapsulates the configuration used when creating an entity, including its data identifier, visual palette, and optional bonding behavior.</summary>
public unsafe struct CreationProfile
{
    // Base Classes
    public ACBindings.Internal.PackObj BaseClass_PackObj; // ACBindings.Internal.PackObj

    // Child Types
    public unsafe struct CreationProfile_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CreationProfile*, void> CreationProfile_dtor_0; // function pointer
        public fixed byte gap4[4];
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CreationProfile*, uint> GetPackSize; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CreationProfile*, void**, uint, uint> Pack; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CreationProfile*, void**, uint, int> UnPack; // function pointer

        // Methods
    }

    // Members
    public ACBindings.Internal.IDClass____tagDataID wcid;
    public int try_to_bond;
    public uint palette;
    public ACBindings.Internal._8CE6913025E23AEA9D70623073A7213E ___u4;
    public ACBindings.Internal._C35DDEE700DD6A38E6EDE7A3277AAE91 ___u5;
    public ACBindings.Internal._84ACB31EA67D08504ED00D0F279E10D9 ___u6;

    // Generated Constructor
    public CreationProfile() {
        _ConstructorInternal();
    }
    public CreationProfile(ACBindings.Internal.CreationProfile* rhs) {
        _ConstructorInternal(rhs);
    }

    // Methods

    /// <summary>Initializes a new CreationProfile object by setting its vtable and assigning default values to core properties such as wcid, try_to_bond, and palette.
    /// <code>Offset: 0x005CD250
    /// void __thiscall CreationProfile::CreationProfile(CreationProfile*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CreationProfile, void>)0x005CD250)(ref this);

    /// <summary>Create a new CreationProfile by copying attributes from the provided source instance.
    /// <code>Offset: 0x005CD280
    /// void __thiscall CreationProfile::CreationProfile(CreationProfile*,const CreationProfile*)</code>
    /// </summary>
    /// <param name="rhs">The profile to copy data from.</param>
    public void _ConstructorInternal(ACBindings.Internal.CreationProfile* rhs) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CreationProfile, ACBindings.Internal.CreationProfile*, void>)0x005CD280)(ref this, rhs);

    /// <summary>Serializes the current CreationProfile into a contiguous memory block.
    /// <code>Offset: 0x005CD2C0
    /// unsigned int __thiscall CreationProfile::Pack(CreationProfile*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Pointer to a pointer that receives the address of the buffer; after packing, it points to the byte following the last written field.</param>
    /// <param name="size">Size in bytes of the destination buffer. Must be at least 24 to hold all packed fields.</param>
    /// <returns>The number of bytes written (24).</returns>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CreationProfile, void**, uint, uint>)0x005CD2C0)(ref this, addr, size);

    /// <summary>Deserializes a CreationProfile instance from binary data supplied via an address pointer.
    /// <code>Offset: 0x005CD320
    /// int __thiscall CreationProfile::UnPack(CreationProfile*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Pointer to the current read position; updated as fields are extracted.</param>
    /// <param name="size">Number of bytes available in the buffer; must be at least 0x18 for successful unpacking.</param>
    /// <returns>Non‑zero on success, zero if the provided size is insufficient.</returns>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CreationProfile, void**, uint, int>)0x005CD320)(ref this, addr, size);
}

