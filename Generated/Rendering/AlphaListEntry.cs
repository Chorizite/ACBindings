namespace ACBindings.Internal;


/// <summary>Entry in the alpha rendering queue, holding mesh buffer, associated surface and material, transformation matrix, and flags indicating a newly added object or clipmap override.</summary>
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

