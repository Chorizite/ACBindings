namespace ACBindings.Internal;

public unsafe struct TMTerrainDesc : System.IDisposable
{
    // Members
    public ACBindings.Internal.LandDefs.TerrainType terrain_type;
    public ACBindings.Internal.AC1Legacy.SmartArray___TerrainTex_ptr terrain_tex;

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x005046B0
    /// void __thiscall TMTerrainDesc::~TMTerrainDesc(TMTerrainDesc*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.TMTerrainDesc, void>)0x005046B0)(ref this);

    /// <summary>
    /// <code>Offset: 0x00504CC0
    /// int __thiscall TMTerrainDesc::UnPack(TMTerrainDesc*,void**,unsigned int*)</code>
    /// </summary>
    public int UnPack(void** addr, uint* size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.TMTerrainDesc, void**, uint*, int>)0x00504CC0)(ref this, addr, size);
}

