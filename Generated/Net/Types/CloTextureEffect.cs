namespace ACBindings.Internal;


/// <summary>Represents a packed texture transition effect, holding the original and replacement texture IDs while providing methods to unpack these identifiers from a binary stream.</summary>
/// <remarks>Used during asset loading or runtime updates where textures need to be swapped efficiently within serialized data structures.</remarks>
public unsafe struct CloTextureEffect
{
    // Base Classes
    public ACBindings.Internal.PackObj BaseClass_PackObj; // ACBindings.Internal.PackObj

    // Child Types
    public unsafe struct CloTextureEffect_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CloTextureEffect*, void> CloTextureEffect_dtor_0; // function pointer
        public fixed byte gap4[4];
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CloTextureEffect*, uint> GetPackSize; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CloTextureEffect*, void**, uint, uint> Pack; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CloTextureEffect*, void**, uint, int> UnPack; // function pointer

        // Methods
    }

    // Members
    public ACBindings.Internal.IDClass____tagDataID oldTexID;
    public ACBindings.Internal.IDClass____tagDataID newTexID;

    // Generated Constructor
    public CloTextureEffect() {
        _ConstructorInternal();
    }

    // Methods

    /// <summary>Initializes a CloTextureEffect instance by assigning its vtable and marking both the old and new texture identifiers as invalid.
    /// <code>Offset: 0x005A9500
    /// void __thiscall CloTextureEffect::CloTextureEffect(CloTextureEffect*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CloTextureEffect, void>)0x005A9500)(ref this);

    /// <summary>Unpacks two texture identifiers from a binary stream and stores them in the object, updating the read pointer.
    /// <code>Offset: 0x005A98C0
    /// int __thiscall CloTextureEffect::UnPack(CloTextureEffect*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Address of the buffer pointer to advance as data is consumed; reset on failure.</param>
    /// <param name="size">Number of bytes remaining in the buffer before unpacking.</param>
    /// <returns>1 if both identifiers were successfully extracted; otherwise 0 and the buffer pointer restored.</returns>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CloTextureEffect, void**, uint, int>)0x005A98C0)(ref this, addr, size);
}

