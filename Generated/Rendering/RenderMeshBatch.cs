namespace ACBindings.Internal;


/// <summary>Encapsulates data required to render a batch of mesh primitives, including primitive type, material index, vertex and index array references, and optional skinning or trick parameters. Acts as the core element for grouping geometry efficiently during rendering.</summary>
public unsafe struct RenderMeshBatch
{
    // Base Classes
    public ACBindings.Internal.ReferenceCountTemplate BaseClass_ReferenceCountTemplate; // ACBindings.Internal.ReferenceCountTemplate

    // Child Types
    public unsafe struct RenderMeshBatch_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.RenderMeshBatch*, void> RenderMeshBatch_dtor_0; // function pointer

        // Methods
    }

    // Members
    public ACBindings.Internal.PrimType m_PrimitivesType;
    public System.IntPtr m_pContainerMesh;
    public uint m_MaterialIndex;
    public uint m_VertexArrayIndex;
    public uint m_IndexArrayIndex;
    public uint m_FirstIndex;
    public uint m_NumPrimitives;
    public void* m_pIBTrickUserObjectPointer;
    public uint m_IBTrickVertexSkinningID;
    public uint m_IBTrickStreamFrameID;
    public uint m_IBTrickBaseVertexIndex;

    // Methods

    /// <summary>Initializes a render mesh batch by associating it with a material, setting its primitive type, and allocating or reusing a vertex buffer for the geometry data.
    /// <code>Offset: 0x0044F330
    /// char __thiscall RenderMeshBatch::InitRenderBatch(RenderMeshBatch*,MaterialInstance*,enum PrimType,unsigned int,unsigned int,unsigned int,int,int,RenderVertexBuffer**)</code>
    /// </summary>
    /// <param name="a2">Material instance to use; if non‑null, its reference count is incremented and its index stored in the batch.</param>
    /// <param name="a3">Primitive type enumeration (e.g., point list, line strip) that determines how vertex indices form primitives.</param>
    /// <param name="a4">Index of an existing vertex array to use; if set to –1, a new vertex array is added to the container mesh.</param>
    /// <param name="a5">Number of vertices or indices supplied for this batch; used to compute the number of primitives based on the primitive type.</param>
    /// <param name="a6">Size value passed to the vertex buffer initialization routine (typically the capacity or stride).</param>
    /// <param name="a7">First offset parameter forwarded to the vertex buffer during initialization.</param>
    /// <param name="a8">Second offset parameter forwarded to the vertex buffer during initialization.</param>
    /// <param name="a9">Output pointer that receives the allocated or existing RenderVertexBuffer; set to null if allocation fails.</param>
    /// <returns>Non‑zero on success, zero on failure (e.g., vertex buffer allocation error).</returns>
    public sbyte InitRenderBatch(ACBindings.Internal.MaterialInstance* a2, ACBindings.Internal.PrimType a3, uint a4, uint a5, uint a6, int a7, int a8, ACBindings.Internal.RenderVertexBuffer** a9) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderMeshBatch, ACBindings.Internal.MaterialInstance*, ACBindings.Internal.PrimType, uint, uint, uint, int, int, ACBindings.Internal.RenderVertexBuffer**, sbyte>)0x0044F330)(ref this, a2, a3, a4, a5, a6, a7, a8, a9);

    /// <summary>Serializes or deserializes RenderMeshBatch data fields to an Archive, optionally updating the container mesh reference.
    /// <code>Offset: 0x0044F450
    /// unsigned int* __thiscall RenderMeshBatch::Serialize(RenderMeshBatch*,Archive*,RenderMesh*)</code>
    /// </summary>
    /// <param name="a2">Archive used for reading or writing batch information; its flags determine whether to write (flag 1 set) or read values.</param>
    /// <param name="a3">RenderMesh that may be stored in m_pContainerMesh when writing.</param>
    /// <returns>Pointer to the buffer containing the NumPrimitives field after the operation, or nullptr if allocation fails.</returns>
    public uint* Serialize(ACBindings.Internal.Archive* a2, ACBindings.Internal.RenderMesh* a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderMeshBatch, ACBindings.Internal.Archive*, ACBindings.Internal.RenderMesh*, uint*>)0x0044F450)(ref this, a2, a3);

    /// <summary>Parses a RenderMeshBatch from the specified file node, extracting primitive type, material index, vertex array, and index array information.
    /// <code>Offset: 0x0044F570
    /// bool __thiscall RenderMeshBatch::ParseFromFileNode(RenderMeshBatch*,const PFileNode*)</code>
    /// </summary>
    /// <param name="pBaseNode">The root file node containing mesh batch data to parse.</param>
    /// <returns>True if parsing succeeds; otherwise false.</returns>
    public byte ParseFromFileNode(ACBindings.Internal.PFileNode* pBaseNode) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderMeshBatch, ACBindings.Internal.PFileNode*, byte>)0x0044F570)(ref this, pBaseNode);
}

