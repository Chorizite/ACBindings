namespace ACBindings.Internal;

public unsafe struct AmbientSTBDesc : System.IDisposable
{
    // Members
    public ACBindings.Internal.IDClass____tagDataID stb_id;
    public int stb_not_found;
    public ACBindings.Internal.AC1Legacy.SmartArray___AmbientSoundDesc_ptr ambient_sounds;
    public ACBindings.Internal.CSoundTable* sound_table;
    public uint play_count;

    // Generated Constructor
    public AmbientSTBDesc() {
        _ConstructorInternal();
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x004FF4E0
    /// int __thiscall AmbientSTBDesc::InitSoundTable(AmbientSTBDesc*)</code>
    /// </summary>
    public int InitSoundTable() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AmbientSTBDesc, int>)0x004FF4E0)(ref this);

    /// <summary>
    /// <code>Offset: 0x00551DC0
    /// void __thiscall AmbientSTBDesc::AmbientSTBDesc(AmbientSTBDesc*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AmbientSTBDesc, void>)0x00551DC0)(ref this);

    /// <summary>
    /// <code>Offset: 0x00551DE0
    /// void __thiscall AmbientSTBDesc::~AmbientSTBDesc(AmbientSTBDesc*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AmbientSTBDesc, void>)0x00551DE0)(ref this);

    /// <summary>
    /// <code>Offset: 0x00551E40
    /// unsigned int __thiscall AmbientSTBDesc::Pack(AmbientSTBDesc*,void**,unsigned int*)</code>
    /// </summary>
    public uint Pack(void** addr, uint* size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AmbientSTBDesc, void**, uint*, uint>)0x00551E40)(ref this, addr, size);

    /// <summary>
    /// <code>Offset: 0x00551F20
    /// unsigned int __thiscall AmbientSTBDesc::pack_size(AmbientSTBDesc*)</code>
    /// </summary>
    public uint pack_size() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AmbientSTBDesc, uint>)0x00551F20)(ref this);

    /// <summary>
    /// <code>Offset: 0x00552510
    /// int __thiscall AmbientSTBDesc::UnPack(AmbientSTBDesc*,void**,unsigned int*)</code>
    /// </summary>
    public int UnPack(void** addr, uint* size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AmbientSTBDesc, void**, uint*, int>)0x00552510)(ref this, addr, size);
}

