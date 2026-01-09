namespace ACBindings;

// CSceneDesc
public unsafe struct CSceneDesc : System.IDisposable
{
    // Members
    public ACBindings.AC1Legacy.SmartArray__CSceneType_ptr scene_types;

    // Generated Constructor
    public CSceneDesc() {
        _ConstructorInternal();
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods
    // void __thiscall CSceneDesc::Destroy(CSceneDesc*)
    public void Destroy() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CSceneDesc, void>)0x00502DC0)(ref this);
    // unsigned int __thiscall CSceneDesc::pack_size(CSceneDesc*)
    public uint pack_size() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CSceneDesc, uint>)0x00502E20)(ref this);
    // void __thiscall CSceneDesc::~CSceneDesc(CSceneDesc*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CSceneDesc, void>)0x00502E50)(ref this);
    // void __thiscall CSceneDesc::GetSubDataIDs(CSceneDesc*,QualifiedDataIDArray*)
    public void GetSubDataIDs(ACBindings.QualifiedDataIDArray* id_array) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CSceneDesc, ACBindings.QualifiedDataIDArray*, void>)0x00502E70)(ref this, id_array);
    // int __thiscall CSceneDesc::Add(CSceneDesc*,CSceneType*)
    public int Add(ACBindings.CSceneType* scene) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CSceneDesc, ACBindings.CSceneType*, int>)0x00502EF0)(ref this, scene);
    // void __thiscall CSceneDesc::CSceneDesc(TurbineChatBlob*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CSceneDesc, void>)0x005031E0)(ref this);
}

