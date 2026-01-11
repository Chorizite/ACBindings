namespace ACBindings.Internal;

public unsafe struct CTerrainType
{
    // Members
    public ACBindings.Internal.AC1Legacy.PStringBase__sbyte terrain_name;
    public ACBindings.Internal.RGBAUnion terrain_color;
    public ACBindings.Internal.AC1Legacy.SmartArray___CSceneType_ptr scene_types;

    // Generated Constructor
    public CTerrainType() {
        _ConstructorInternal();
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x00503010
    /// void __thiscall CTerrainType::CTerrainType(CTerrainType*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CTerrainType, void>)0x00503010)(ref this);
}

