namespace ACBindings.Internal;


/// <summary>Represents a vertex in the CSW model format, containing an identifier, normal vector and dynamic array of UV coordinates. An unnamed field (___u0) is present whose purpose is not defined.</summary>
/// <remarks>UV data is allocated during UnPack and freed by Destroy; Pack serializes the vertex into a contiguous byte buffer, and pack_size reports its size.</remarks>
public unsafe struct CSWVertex
{
    // Members
    public ACBindings.Internal._DB07F05AFE1DBE8AF4B8F0A046C9EB4D ___u0;
    public short vert_id;
    public ushort num_uvs;
    public ACBindings.Internal.CVec2Duv* uvs;
    public ACBindings.Internal.AC1Legacy.Vector3 normal;

    // Methods

    /// <summary>Resets the vertex’s identifier, UV count, and UV pointer to default values.
    /// <code>Offset: 0x0053EA90
    /// void __thiscall CSWVertex::Init(CSWVertex*)</code>
    /// </summary>
    public void Init() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CSWVertex, void>)0x0053EA90)(ref this);

    /// <summary>Computes the number of bytes needed to serialize a CSWVertex, including its fixed data and all associated UVs.
    /// <code>Offset: 0x0053EAA0
    /// unsigned int __thiscall CSWVertex::pack_size(CSWVertex*)</code>
    /// </summary>
    /// <returns>The packed size in bytes, equal to 28 plus eight times the vertex’s num_uvs field.</returns>
    public uint pack_size() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CSWVertex, uint>)0x0053EAA0)(ref this);

    /// <summary>Serializes a CSWVertex into a contiguous byte buffer, writing vertex ID, UV count, position, normal and texture coordinates. If the supplied buffer size is insufficient, no data is written.
    /// <code>Offset: 0x0053EAB0
    /// unsigned int __thiscall CSWVertex::Pack(CSWVertex*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Address of a pointer to the destination buffer; on success it points to the byte following the packed data.</param>
    /// <param name="size">Number of bytes available in the destination buffer.</param>
    /// <returns>Size in bytes that the vertex occupies when serialized (8 * num_uvs + 28).</returns>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CSWVertex, void**, uint, uint>)0x0053EAB0)(ref this, addr, size);

    /// <summary>Releases the memory allocated for UV coordinates stored in this vertex and resets the pointer to null.
    /// <code>Offset: 0x0053EB90
    /// void __thiscall CSWVertex::Destroy(CSWVertex*)</code>
    /// </summary>
    public void Destroy() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CSWVertex, void>)0x0053EB90)(ref this);

    /// <summary>Reads a vertex from binary data, filling ID, coordinates, normal and UVs while allocating memory for the UV array as needed.
    /// <code>Offset: 0x0053EBB0
    /// int __thiscall CSWVertex::UnPack(CSWVertex*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Address of a pointer that references the current position in the input buffer; it will be advanced as fields are read.</param>
    /// <param name="size">Size of the remaining data in the buffer, used to guard reading of the position/normal block.</param>
    /// <returns>Integer status code, always 1 for success.</returns>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CSWVertex, void**, uint, int>)0x0053EBB0)(ref this, addr, size);
}

