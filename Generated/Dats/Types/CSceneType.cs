namespace ACBindings;

// CSceneType
public unsafe struct CSceneType : System.IDisposable
{
    // Members
    public ACBindings.PStringBase__sbyte scene_name;
    public ACBindings.SmartArray__IDClass___tagDataID scenes;
    public ACBindings.AmbientSTBDesc* sound_table_desc;

    // Generated Constructor
    public CSceneType() {
        _ConstructorInternal();
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods
    // unsigned int __thiscall CSceneType::pack_size(CSceneType*)
    public uint pack_size() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CSceneType, uint>)0x00503C20)(ref this);
    // unsigned int __thiscall CSceneType::pack(CSceneType*,void**,unsigned int*)
    public uint pack(void** addr, uint* size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CSceneType, void**, uint*, uint>)0x00503C30)(ref this, addr, size);
    // void __thiscall CSceneType::CSceneType(CSceneType*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CSceneType, void>)0x00503C90)(ref this);
    // void __thiscall CSceneType::~CSceneType(CSceneType*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CSceneType, void>)0x00503CC0)(ref this);
    // int __thiscall CSceneType::unpack(CSceneType*,void**,unsigned int*)
    public int unpack(void** addr, uint* size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CSceneType, void**, uint*, int>)0x00503D20)(ref this, addr, size);
}

