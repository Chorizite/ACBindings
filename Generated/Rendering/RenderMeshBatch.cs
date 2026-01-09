namespace ACBindings;

// RenderMeshBatch
public unsafe struct RenderMeshBatch
{
    // Base Classes
    public ACBindings.ReferenceCountTemplate BaseClass_ReferenceCountTemplate; // ACBindings.ReferenceCountTemplate

    // Child Types
    // RenderMeshBatch_vtbl
    public unsafe struct RenderMeshBatch_vtbl
    {
        // Members
        public System.IntPtr RenderMeshBatch_dtor_0; // function pointer

        // Methods
    }

    // Members
    public ACBindings.PrimType m_PrimitivesType;
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
    // char __thiscall RenderMeshBatch::InitRenderBatch(RenderMeshBatch*,MaterialInstance*,enum PrimType,unsigned int,unsigned int,unsigned int,int,int,RenderVertexBuffer**)
    public sbyte InitRenderBatch(ACBindings.MaterialInstance* a2, ACBindings.PrimType a3, uint a4, uint a5, uint a6, int a7, int a8, ACBindings.RenderVertexBuffer** a9) => ((delegate* unmanaged[Thiscall]<ref ACBindings.RenderMeshBatch, ACBindings.MaterialInstance*, ACBindings.PrimType, uint, uint, uint, int, int, ACBindings.RenderVertexBuffer**, sbyte>)0x0044F330)(ref this, a2, a3, a4, a5, a6, a7, a8, a9);
    // unsigned int* __thiscall RenderMeshBatch::Serialize(RenderMeshBatch*,Archive*,RenderMesh*)
    public uint* Serialize(ACBindings.Archive* a2, ACBindings.RenderMesh* a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.RenderMeshBatch, ACBindings.Archive*, ACBindings.RenderMesh*, uint*>)0x0044F450)(ref this, a2, a3);
    // bool __thiscall RenderMeshBatch::ParseFromFileNode(RenderMeshBatch*,const PFileNode*)
    public byte ParseFromFileNode(ACBindings.PFileNode* pBaseNode) => ((delegate* unmanaged[Thiscall]<ref ACBindings.RenderMeshBatch, ACBindings.PFileNode*, byte>)0x0044F570)(ref this, pBaseNode);
}

