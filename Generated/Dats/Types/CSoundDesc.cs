namespace ACBindings.Internal;

public unsafe struct CSoundDesc : System.IDisposable
{
    // Members
    public ACBindings.Internal.AC1Legacy.SmartArray___AmbientSTBDesc_ptr stb_desc;

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x005031F0
    /// void __thiscall CSoundDesc::Destroy(CSoundDesc*)</code>
    /// </summary>
    public void Destroy() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CSoundDesc, void>)0x005031F0)(ref this);

    /// <summary>
    /// <code>Offset: 0x00503250
    /// unsigned int __thiscall CSoundDesc::pack_size(CSoundDesc*)</code>
    /// </summary>
    public uint pack_size() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CSoundDesc, uint>)0x00503250)(ref this);

    /// <summary>
    /// <code>Offset: 0x005032A0
    /// unsigned int __thiscall CSoundDesc::Pack(CSoundDesc*,void**,unsigned int*)</code>
    /// </summary>
    public uint Pack(void** addr, uint* size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CSoundDesc, void**, uint*, uint>)0x005032A0)(ref this, addr, size);

    /// <summary>
    /// <code>Offset: 0x00503310
    /// void __thiscall CSoundDesc::~CSoundDesc(CSoundDesc*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CSoundDesc, void>)0x00503310)(ref this);

    /// <summary>
    /// <code>Offset: 0x00503330
    /// void __thiscall CSoundDesc::GetSubDataIDs(CSoundDesc*,QualifiedDataIDArray*)</code>
    /// </summary>
    public void GetSubDataIDs(ACBindings.Internal.QualifiedDataIDArray* id_array) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CSoundDesc, ACBindings.Internal.QualifiedDataIDArray*, void>)0x00503330)(ref this, id_array);

    /// <summary>
    /// <code>Offset: 0x00503380
    /// int __thiscall CSoundDesc::UnPack(CSoundDesc*,void**,unsigned int*)</code>
    /// </summary>
    public int UnPack(void** addr, uint* size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CSoundDesc, void**, uint*, int>)0x00503380)(ref this, addr, size);
}

