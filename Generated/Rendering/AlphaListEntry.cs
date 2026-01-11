namespace ACBindings.Internal;

public unsafe struct AlphaListEntry
{
    // Members
    public ACBindings.Internal.MeshBuffer* pMeshBuffer;
    public int surfaceNum;
    public ACBindings.Internal.CSurface* surface;
    public ACBindings.Internal.CMaterial* material;
    public ACBindings.Internal.Matrix4 worldMatrix;
    public byte bNewObject;
    public byte overrideClipmapSetting;

    // Methods
}

