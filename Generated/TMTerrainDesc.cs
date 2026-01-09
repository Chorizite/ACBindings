namespace ACBindings;

// TMTerrainDesc
public unsafe struct TMTerrainDesc : System.IDisposable
{
    // Members
    public ACBindings.LandDefs.TerrainType terrain_type;
    public ACBindings.AC1Legacy.SmartArray__TerrainTex_ptr terrain_tex;

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods
    // void __thiscall TMTerrainDesc::~TMTerrainDesc(TMTerrainDesc*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.TMTerrainDesc, void>)0x005046B0)(ref this);
    // int __thiscall TMTerrainDesc::UnPack(TMTerrainDesc*,void**,unsigned int*)
    public int UnPack(void** addr, uint* size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.TMTerrainDesc, void**, uint*, int>)0x00504CC0)(ref this, addr, size);
}

