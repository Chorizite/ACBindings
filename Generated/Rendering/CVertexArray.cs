namespace ACBindings.Internal;


/// <summary>Array of vertex data used in rendering pipelines, storing raw memory, a bounding box, the vertex format, total count, and a pointer to individual vertices.</summary>
public unsafe struct CVertexArray
{
    // Statics
    public static uint* vertex_size = (uint*)0x0081F710;

    // Members
    public System.IntPtr vertex_memory;
    public ACBindings.Internal.BBox bbox;
    public ACBindings.Internal.VertexType vertex_type;
    public uint num_vertices;
    public ACBindings.Internal.CVertex* vertices;

    // Generated Constructor
    public CVertexArray() {
        _ConstructorInternal();
    }

    // Methods

    /// <summary>Allocates storage for the specified number of vertices and initializes the vertex array.
    /// <code>Offset: 0x0053CB90
    /// int __thiscall CVertexArray::AllocateVertex(CVertexArray*,unsigned int,VertexType)</code>
    /// </summary>
    /// <param name="size">The number of vertices to allocate.</param>
    /// <param name="type">The type of vertices that will be stored; determines whether individual vertices are initialized.</param>
    /// <returns>Non‑zero if allocation succeeds, zero on failure.</returns>
    public int AllocateVertex(uint size, ACBindings.Internal.VertexType type) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CVertexArray, uint, ACBindings.Internal.VertexType, int>)0x0053CB90)(ref this, size, type);

    /// <summary>Destroys stored vertices when the array holds CSWVertex objects; otherwise it simply frees the vertex buffer. Afterwards clears all internal bookkeeping fields.
    /// <code>Offset: 0x0053CC10
    /// void __thiscall CVertexArray::DestroyVertex(CVertexArray*)</code>
    /// </summary>
    public void DestroyVertex() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CVertexArray, void>)0x0053CC10)(ref this);

    /// <summary>Computes the axis-aligned bounding box that encloses all vertices in the array and stores it in the instance’s bbox member.
    /// <code>Offset: 0x0053CC70
    /// void __thiscall CVertexArray::BuildBoundingBox(CVertexArray*)</code>
    /// </summary>
    public void BuildBoundingBox() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CVertexArray, void>)0x0053CC70)(ref this);

    /// <summary>Computes the total byte count required to serialize this vertex array, adding an 8‑byte header and per‑vertex sizes when the type is CSWVertexType.
    /// <code>Offset: 0x0053CCC0
    /// unsigned int __thiscall CVertexArray::pack_size(CVertexArray*)</code>
    /// </summary>
    /// <returns>The serialized packet size in bytes.</returns>
    public uint pack_size() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CVertexArray, uint>)0x0053CCC0)(ref this);

    /// <summary>Initializes a new vertex array instance, resetting all members to their default states.
    /// <code>Offset: 0x0053CD10
    /// void __thiscall CVertexArray::CVertexArray(CVertexArray*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CVertexArray, void>)0x0053CD10)(ref this);

    /// <summary>Packs a CVertexArray into an output buffer when enough space is available, writing vertex type, count, and packed vertex data sequentially.
    /// <code>Offset: 0x0053CD20
    /// unsigned int __thiscall CVertexArray::Pack(CVertexArray*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Pointer to the destination memory; updated to point after written data.</param>
    /// <param name="size">Maximum number of bytes that may be written to the destination buffer.</param>
    /// <returns>Number of bytes required to represent the packed vertex array. If size is insufficient, packing does not occur and this value is still returned.</returns>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CVertexArray, void**, uint, uint>)0x0053CD20)(ref this, addr, size);

    /// <summary>Unpacks a vertex array from the provided data buffer. Reads vertex type and count, allocates storage, then unpacks each vertex according to its type before building the bounding box.
    /// <code>Offset: 0x0053CD90
    /// int __thiscall CVertexArray::UnPack(CVertexArray*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Pointer to the current position in the source buffer; advanced as data is consumed.</param>
    /// <param name="size">Size of the remaining data buffer (passed through to per-vertex unpacking).</param>
    /// <returns>1 on success, otherwise an error code from AllocateVertex indicating allocation failure.</returns>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CVertexArray, void**, uint, int>)0x0053CD90)(ref this, addr, size);
}

