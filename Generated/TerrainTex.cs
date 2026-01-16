namespace ACBindings.Internal;


/// <summary>Encapsulates texture data for terrain rendering, linking base and detail textures with adjustable parameters such as tiling, brightness, saturation, hue, and slope sensitivity.</summary>
public unsafe struct TerrainTex
{
    // Members
    public ACBindings.Internal.IDClass____tagDataID tex_gid;
    public ACBindings.Internal.ImgTex* base_texture;
    public float min_slope;
    public uint tex_tiling;
    public uint max_vert_bright;
    public uint min_vert_bright;
    public uint max_vert_saturate;
    public uint min_vert_saturate;
    public uint max_vert_hue;
    public uint min_vert_hue;
    public uint detail_tex_tiling;
    public ACBindings.Internal.IDClass____tagDataID detail_tex_gid;

    // Methods

    /// <summary>Completes initialization by resolving the base texture for the terrain from its identifier.
    /// <code>Offset: 0x00503F70
    /// int __thiscall TerrainTex::InitEnd(TerrainTex*)</code>
    /// </summary>
    /// <returns>Non-zero if the base texture was successfully retrieved; zero otherwise.</returns>
    public int InitEnd() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.TerrainTex, int>)0x00503F70)(ref this);

    /// <summary>Serializes the TerrainTex properties into a contiguous byte buffer, advancing the pointer and reducing the available size for each written field.
    /// <code>Offset: 0x00504490
    /// unsigned int __thiscall TerrainTex::Pack(TerrainTex*,void**,unsigned int*)</code>
    /// </summary>
    /// <param name="addr">Pointer to the current write location within the target buffer; updated after each field is written.</param>
    /// <param name="size">Pointer to the remaining writable bytes in the buffer; reduced as fields are serialized.</param>
    /// <returns>The number of bytes left unfilled after serialization, which will be zero when all properties fit.</returns>
    public uint Pack(void** addr, uint* size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.TerrainTex, void**, uint*, uint>)0x00504490)(ref this, addr, size);

    /// <summary>Unpacks terrain texture parameters from a binary stream into the TerrainTex object.
    /// <code>Offset: 0x005045A0
    /// int __thiscall TerrainTex::UnPack(TerrainTex*,void**,unsigned int*)</code>
    /// </summary>
    /// <param name="addr">Pointer to the current read position within the data buffer; advanced as fields are consumed.</param>
    /// <param name="size">Pointer to the number of bytes remaining in the buffer; decremented during unpacking.</param>
    /// <returns>Integer status code (1 indicates successful unpack).</returns>
    public int UnPack(void** addr, uint* size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.TerrainTex, void**, uint*, int>)0x005045A0)(ref this, addr, size);
}

