namespace ACBindings.Internal;


/// <summary>Defines a record describing how a texture is replaced on a specific model part, storing the part index and identifiers for the old and new textures. Linked as a doubly‑linked list, it supports packing and unpacking of change information into binary streams.</summary>
public unsafe struct TextureMapChange
{
    // Base Classes
    public ACBindings.Internal.PackObj BaseClass_PackObj; // ACBindings.Internal.PackObj

    // Child Types
    public unsafe struct TextureMapChange_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.TextureMapChange*, void> TextureMapChange_dtor_0; // function pointer
        public fixed byte gap4[4];
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.TextureMapChange*, uint> GetPackSize; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.TextureMapChange*, void**, uint, uint> Pack; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.TextureMapChange*, void**, uint, int> UnPack; // function pointer

        // Methods
    }

    // Members
    public uint part_index;
    public ACBindings.Internal.IDClass____tagDataID old_tex_id;
    public ACBindings.Internal.IDClass____tagDataID new_tex_id;
    public ACBindings.Internal.TextureMapChange* prev;
    public ACBindings.Internal.TextureMapChange* next;

    // Methods

    /// <summary>Packs a texture map change record into the supplied buffer by serializing its part index followed by the old and new texture IDs using a known-type encoding.
    /// <code>Offset: 0x005AE950
    /// unsigned int __thiscall TextureMapChange::Pack(TextureMapChange*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">A pointer to the destination buffer; on success, the pointer is advanced past the written data.</param>
    /// <param name="size">The number of bytes available in the destination buffer.</param>
    /// <returns>Returns the number of bytes written if the buffer was large enough; otherwise returns the total size required to encode the record.</returns>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.TextureMapChange, void**, uint, uint>)0x005AE950)(ref this, addr, size);

    /// <summary>Unpacks a texture map change from a byte stream, extracting the part index and old/new texture IDs.
    /// <code>Offset: 0x005AE9D0
    /// int __thiscall TextureMapChange::UnPack(TextureMapChange*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Pointer to the current read position in the data buffer; will be advanced as data is consumed.</param>
    /// <param name="size">Number of bytes remaining in the buffer; must be at least 5 for a valid unpack.</param>
    /// <returns>Nonzero if unpacking succeeds; zero otherwise.</returns>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.TextureMapChange, void**, uint, int>)0x005AE9D0)(ref this, addr, size);

    /// <summary>Compare part index and old texture ID to determine whether this change replaces another.
    /// <code>Offset: 0x005AEA30
    /// int __thiscall TextureMapChange::replaces(TextureMapChange*,const TextureMapChange*)</code>
    /// </summary>
    /// <param name="change">The texture map change to compare against.</param>
    /// <returns>Non‑zero if this change replaces the supplied one, zero otherwise.</returns>
    public int replaces(ACBindings.Internal.TextureMapChange* change) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.TextureMapChange, ACBindings.Internal.TextureMapChange*, int>)0x005AEA30)(ref this, change);
}

