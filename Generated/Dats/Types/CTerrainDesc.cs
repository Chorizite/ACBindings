namespace ACBindings.Internal;

public unsafe struct CTerrainDesc : System.IDisposable
{
    // Members
    public ACBindings.Internal.LandSurf* land_surfaces;
    public ACBindings.Internal.AC1Legacy.SmartArray___CTerrainType_ptr terrain_types;

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x00502F30
    /// void __thiscall CTerrainDesc::GetSubDataIDs(CTerrainDesc*,QualifiedDataIDArray*)</code>
    /// </summary>
    public void GetSubDataIDs(ACBindings.Internal.QualifiedDataIDArray* id_array) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CTerrainDesc, ACBindings.Internal.QualifiedDataIDArray*, void>)0x00502F30)(ref this, id_array);

    /// <summary>
    /// <code>Offset: 0x00502F50
    /// AmbientSTBDesc* __thiscall CTerrainDesc::GetSTBDesc(CTerrainDesc*,unsigned int,unsigned int)</code>
    /// </summary>
    public ACBindings.Internal.AmbientSTBDesc* GetSTBDesc(uint terrain_id, uint scene_type_id) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CTerrainDesc, uint, uint, ACBindings.Internal.AmbientSTBDesc*>)0x00502F50)(ref this, terrain_id, scene_type_id);

    /// <summary>
    /// <code>Offset: 0x00502FD0
    /// IDClass&lt;_tagDataID,32,0&gt;* __thiscall CTerrainDesc::GetScene(_DWORD*,IDClass&lt;_tagDataID,32,0&gt;*,int,int,unsigned int)</code>
    /// </summary>
    public ACBindings.Internal.IDClass____tagDataID* GetScene(ACBindings.Internal.IDClass____tagDataID* a2, int a3, int a4, uint a5) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CTerrainDesc, ACBindings.Internal.IDClass____tagDataID*, int, int, uint, ACBindings.Internal.IDClass____tagDataID*>)0x00502FD0)(ref this, a2, a3, a4, a5);

    /// <summary>
    /// <code>Offset: 0x00503050
    /// void __thiscall CTerrainDesc::Destroy(CTerrainDesc*)</code>
    /// </summary>
    public void Destroy() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CTerrainDesc, void>)0x00503050)(ref this);

    /// <summary>
    /// <code>Offset: 0x00503100
    /// int __thiscall CTerrainDesc::Add(CTerrainDesc*,CTerrainType*)</code>
    /// </summary>
    public int Add(ACBindings.Internal.CTerrainType* terrain) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CTerrainDesc, ACBindings.Internal.CTerrainType*, int>)0x00503100)(ref this, terrain);

    /// <summary>
    /// <code>Offset: 0x00503150
    /// unsigned int __thiscall CTerrainDesc::pack_size(CTerrainDesc*)</code>
    /// </summary>
    public uint pack_size() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CTerrainDesc, uint>)0x00503150)(ref this);

    /// <summary>
    /// <code>Offset: 0x005031C0
    /// void __thiscall CTerrainDesc::~CTerrainDesc(CTerrainDesc*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CTerrainDesc, void>)0x005031C0)(ref this);
}

