namespace ACBindings;

// CSoundDesc
public unsafe struct CSoundDesc : System.IDisposable
{
    // Members
    public ACBindings.AC1Legacy.SmartArray__AmbientSTBDesc_ptr stb_desc;

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods
    // void __thiscall CSoundDesc::Destroy(CSoundDesc*)
    public void Destroy() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CSoundDesc, void>)0x005031F0)(ref this);
    // unsigned int __thiscall CSoundDesc::pack_size(CSoundDesc*)
    public uint pack_size() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CSoundDesc, uint>)0x00503250)(ref this);
    // unsigned int __thiscall CSoundDesc::Pack(CSoundDesc*,void**,unsigned int*)
    public uint Pack(void** addr, uint* size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CSoundDesc, void**, uint*, uint>)0x005032A0)(ref this, addr, size);
    // void __thiscall CSoundDesc::~CSoundDesc(CSoundDesc*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CSoundDesc, void>)0x00503310)(ref this);
    // void __thiscall CSoundDesc::GetSubDataIDs(CSoundDesc*,QualifiedDataIDArray*)
    public void GetSubDataIDs(ACBindings.QualifiedDataIDArray* id_array) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CSoundDesc, ACBindings.QualifiedDataIDArray*, void>)0x00503330)(ref this, id_array);
    // int __thiscall CSoundDesc::UnPack(CSoundDesc*,void**,unsigned int*)
    public int UnPack(void** addr, uint* size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CSoundDesc, void**, uint*, int>)0x00503380)(ref this, addr, size);
}

