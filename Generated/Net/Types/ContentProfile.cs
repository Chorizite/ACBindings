namespace ACBindings.Internal;


/// <summary>Provides identification and container properties for a content object, enabling binary packing and unpacking of its state.</summary>
public unsafe struct ContentProfile
{
    // Base Classes
    public ACBindings.Internal.PackObj BaseClass_PackObj; // ACBindings.Internal.PackObj

    // Child Types
    public unsafe struct ContentProfile_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ContentProfile*, void> ContentProfile_dtor_0; // function pointer
        public fixed byte gap4[4];
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ContentProfile*, uint> GetPackSize; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ContentProfile*, void**, uint, uint> Pack; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ContentProfile*, void**, uint, int> UnPack; // function pointer

        // Methods
    }

    // Members
    public uint m_iid;
    public uint m_uContainerProperties;

    // Generated Constructor
    public ContentProfile(uint iid) {
        _ConstructorInternal(iid);
    }
    public ContentProfile() {
        _ConstructorInternal();
    }

    // Methods

    /// <summary>Packs the old and new texture identifiers into a binary buffer, writing two 4‑byte values.
    /// <code>Offset: 0x005A9890
    /// unsigned int __thiscall ContentProfile::Pack(CloTextureEffect*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Address of the buffer pointer; advanced past the data written.</param>
    /// <param name="size">Size in bytes available at the buffer; must be at least 8 for packing to occur.</param>
    /// <returns>Number of bytes required for the packed data (always 8).</returns>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ContentProfile, void**, uint, uint>)0x005A9890)(ref this, addr, size);

    /// <summary>Initializes a ContentProfile object with the given identifier, configuring its virtual table and clearing container properties.
    /// <code>Offset: 0x006B0DA0
    /// void __thiscall ContentProfile::ContentProfile(ContentProfile*,unsigned int)</code>
    /// </summary>
    /// <param name="iid">The unique identifier to assign to the new profile instance.</param>
    public void _ConstructorInternal(uint iid) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ContentProfile, uint, void>)0x006B0DA0)(ref this, iid);

    /// <summary>Creates a ContentProfile instance, setting its virtual table pointer and initializing identifier and property fields to zero.
    /// <code>Offset: 0x006B0DC0
    /// void __thiscall ContentProfile::ContentProfile(ContentProfile*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ContentProfile, void>)0x006B0DC0)(ref this);

    /// <summary>Extracts two unsigned integers from a memory buffer into the ContentProfile's m_iid and m_uContainerProperties fields, advancing the buffer pointer accordingly.
    /// <code>Offset: 0x006B0DE0
    /// int __thiscall ContentProfile::UnPack(ContentProfile*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Pointer to the current position in the data buffer; will be updated to point after the extracted values.</param>
    /// <param name="size">Number of bytes remaining in the buffer; must be at least 8 for a successful unpack.</param>
    /// <returns>1 if two values were successfully read, otherwise 0 when size is too small.</returns>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ContentProfile, void**, uint, int>)0x006B0DE0)(ref this, addr, size);
}

