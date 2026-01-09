namespace ACBindings;

// CTerrainDesc
public unsafe struct CTerrainDesc : System.IDisposable
{
    // Members
    public ACBindings.LandSurf* land_surfaces;
    public ACBindings.AC1Legacy.SmartArray__CTerrainType_ptr terrain_types;

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods
    // void __thiscall CTerrainDesc::GetSubDataIDs(CTerrainDesc*,QualifiedDataIDArray*)
    public void GetSubDataIDs(ACBindings.QualifiedDataIDArray* id_array) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CTerrainDesc, ACBindings.QualifiedDataIDArray*, void>)0x00502F30)(ref this, id_array);
    // AmbientSTBDesc* __thiscall CTerrainDesc::GetSTBDesc(CTerrainDesc*,unsigned int,unsigned int)
    public ACBindings.AmbientSTBDesc* GetSTBDesc(uint terrain_id, uint scene_type_id) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CTerrainDesc, uint, uint, ACBindings.AmbientSTBDesc*>)0x00502F50)(ref this, terrain_id, scene_type_id);
    // IDClass<_tagDataID,32,0>* __thiscall CTerrainDesc::GetScene(_DWORD*,IDClass<_tagDataID,32,0>*,int,int,unsigned int)
    public ACBindings.IDClass___tagDataID* GetScene(ACBindings.IDClass___tagDataID* a2, int a3, int a4, uint a5) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CTerrainDesc, ACBindings.IDClass___tagDataID*, int, int, uint, ACBindings.IDClass___tagDataID*>)0x00502FD0)(ref this, a2, a3, a4, a5);
    // void __thiscall CTerrainDesc::Destroy(CTerrainDesc*)
    public void Destroy() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CTerrainDesc, void>)0x00503050)(ref this);
    // int __thiscall CTerrainDesc::Add(CTerrainDesc*,CTerrainType*)
    public int Add(ACBindings.CTerrainType* terrain) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CTerrainDesc, ACBindings.CTerrainType*, int>)0x00503100)(ref this, terrain);
    // unsigned int __thiscall CTerrainDesc::pack_size(CTerrainDesc*)
    public uint pack_size() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CTerrainDesc, uint>)0x00503150)(ref this);
    // void __thiscall CTerrainDesc::~CTerrainDesc(CTerrainDesc*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CTerrainDesc, void>)0x005031C0)(ref this);
}

