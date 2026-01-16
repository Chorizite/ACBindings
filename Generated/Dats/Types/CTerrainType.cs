namespace ACBindings.Internal;


/// <summary>Defines a terrain variant used by AC1Legacy, storing its identifier, visual appearance, and linked scene objects.</summary>
/// <remarks>Construction sets an empty name string, default color components to -1, and clears the list of associated scenes.</remarks>
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

    /// <summary>Constructs a terrain type instance with default values: name buffer set to null string, scene types array empty, and color components initialized to -1.
    /// <code>Offset: 0x00503010
    /// void __thiscall CTerrainType::CTerrainType(CTerrainType*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CTerrainType, void>)0x00503010)(ref this);
}

