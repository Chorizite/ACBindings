namespace ACBindings.Internal;

public unsafe struct CSceneType : System.IDisposable
{
    // Members
    public ACBindings.Internal.PStringBase__sbyte scene_name;
    public ACBindings.Internal.SmartArray___IDClass____tagDataID scenes;
    public ACBindings.Internal.AmbientSTBDesc* sound_table_desc;

    // Generated Constructor
    public CSceneType() {
        _ConstructorInternal();
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x00503C20
    /// unsigned int __thiscall CSceneType::pack_size(CSceneType*)</code>
    /// </summary>
    public uint pack_size() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CSceneType, uint>)0x00503C20)(ref this);

    /// <summary>
    /// <code>Offset: 0x00503C30
    /// unsigned int __thiscall CSceneType::pack(CSceneType*,void**,unsigned int*)</code>
    /// </summary>
    public uint pack(void** addr, uint* size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CSceneType, void**, uint*, uint>)0x00503C30)(ref this, addr, size);

    /// <summary>
    /// <code>Offset: 0x00503C90
    /// void __thiscall CSceneType::CSceneType(CSceneType*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CSceneType, void>)0x00503C90)(ref this);

    /// <summary>
    /// <code>Offset: 0x00503CC0
    /// void __thiscall CSceneType::~CSceneType(CSceneType*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CSceneType, void>)0x00503CC0)(ref this);

    /// <summary>
    /// <code>Offset: 0x00503D20
    /// int __thiscall CSceneType::unpack(CSceneType*,void**,unsigned int*)</code>
    /// </summary>
    public int unpack(void** addr, uint* size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CSceneType, void**, uint*, int>)0x00503D20)(ref this, addr, size);
}

