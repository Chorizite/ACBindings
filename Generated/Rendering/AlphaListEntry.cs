namespace ACBindings;

// AlphaListEntry
public unsafe struct AlphaListEntry
{
    // Members
    public ACBindings.MeshBuffer* pMeshBuffer;
    public int surfaceNum;
    public ACBindings.CSurface* surface;
    public ACBindings.CMaterial* material;
    public ACBindings.Matrix4 worldMatrix;
    public byte bNewObject;
    public byte overrideClipmapSetting;

    // Methods
}

