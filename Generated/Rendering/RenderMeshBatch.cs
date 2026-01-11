namespace ACBindings.Internal;

public unsafe struct RenderMeshBatch
{
    // Base Classes
    public ACBindings.Internal.ReferenceCountTemplate BaseClass_ReferenceCountTemplate; // ACBindings.Internal.ReferenceCountTemplate

    // Child Types
    public unsafe struct RenderMeshBatch_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.RenderMeshBatch*, void> RenderMeshBatch_dtor_0; // function pointer

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

    /// <summary>
    /// <code>Offset: 0x0044F330
    /// char __thiscall RenderMeshBatch::InitRenderBatch(RenderMeshBatch*,MaterialInstance*,enum PrimType,unsigned int,unsigned int,unsigned int,int,int,RenderVertexBuffer**)</code>
    /// </summary>
    public sbyte InitRenderBatch(ACBindings.Internal.MaterialInstance* a2, ACBindings.Internal.PrimType a3, uint a4, uint a5, uint a6, int a7, int a8, ACBindings.Internal.RenderVertexBuffer** a9) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderMeshBatch, ACBindings.Internal.MaterialInstance*, ACBindings.Internal.PrimType, uint, uint, uint, int, int, ACBindings.Internal.RenderVertexBuffer**, sbyte>)0x0044F330)(ref this, a2, a3, a4, a5, a6, a7, a8, a9);

    /// <summary>
    /// <code>Offset: 0x0044F450
    /// unsigned int* __thiscall RenderMeshBatch::Serialize(RenderMeshBatch*,Archive*,RenderMesh*)</code>
    /// </summary>
    public uint* Serialize(ACBindings.Internal.Archive* a2, ACBindings.Internal.RenderMesh* a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderMeshBatch, ACBindings.Internal.Archive*, ACBindings.Internal.RenderMesh*, uint*>)0x0044F450)(ref this, a2, a3);

    /// <summary>
    /// <code>Offset: 0x0044F570
    /// bool __thiscall RenderMeshBatch::ParseFromFileNode(RenderMeshBatch*,const PFileNode*)</code>
    /// </summary>
    public byte ParseFromFileNode(ACBindings.Internal.PFileNode* pBaseNode) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderMeshBatch, ACBindings.Internal.PFileNode*, byte>)0x0044F570)(ref this, pBaseNode);
}

