namespace ACBindings.Internal;

public unsafe struct CSceneDesc : System.IDisposable
{
    // Members
    public ACBindings.Internal.AC1Legacy.SmartArray___CSceneType_ptr scene_types;

    // Generated Constructor
    public CSceneDesc() {
        _ConstructorInternal();
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x00502DC0
    /// void __thiscall CSceneDesc::Destroy(CSceneDesc*)</code>
    /// </summary>
    public void Destroy() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CSceneDesc, void>)0x00502DC0)(ref this);

    /// <summary>
    /// <code>Offset: 0x00502E20
    /// unsigned int __thiscall CSceneDesc::pack_size(CSceneDesc*)</code>
    /// </summary>
    public uint pack_size() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CSceneDesc, uint>)0x00502E20)(ref this);

    /// <summary>
    /// <code>Offset: 0x00502E50
    /// void __thiscall CSceneDesc::~CSceneDesc(CSceneDesc*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CSceneDesc, void>)0x00502E50)(ref this);

    /// <summary>
    /// <code>Offset: 0x00502E70
    /// void __thiscall CSceneDesc::GetSubDataIDs(CSceneDesc*,QualifiedDataIDArray*)</code>
    /// </summary>
    public void GetSubDataIDs(ACBindings.Internal.QualifiedDataIDArray* id_array) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CSceneDesc, ACBindings.Internal.QualifiedDataIDArray*, void>)0x00502E70)(ref this, id_array);

    /// <summary>
    /// <code>Offset: 0x00502EF0
    /// int __thiscall CSceneDesc::Add(CSceneDesc*,CSceneType*)</code>
    /// </summary>
    public int Add(ACBindings.Internal.CSceneType* scene) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CSceneDesc, ACBindings.Internal.CSceneType*, int>)0x00502EF0)(ref this, scene);

    /// <summary>
    /// <code>Offset: 0x005031E0
    /// void __thiscall CSceneDesc::CSceneDesc(TurbineChatBlob*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CSceneDesc, void>)0x005031E0)(ref this);
}

