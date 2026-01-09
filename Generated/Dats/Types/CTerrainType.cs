namespace ACBindings;

// CTerrainType
public unsafe struct CTerrainType
{
    // Members
    public ACBindings.AC1Legacy.PStringBase__sbyte terrain_name;
    public ACBindings.RGBAUnion terrain_color;
    public ACBindings.AC1Legacy.SmartArray__CSceneType_ptr scene_types;

    // Generated Constructor
    public CTerrainType() {
        _ConstructorInternal();
    }

    // Methods
    // void __thiscall CTerrainType::CTerrainType(CTerrainType*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CTerrainType, void>)0x00503010)(ref this);
}

