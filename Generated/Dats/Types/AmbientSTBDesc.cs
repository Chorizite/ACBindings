namespace ACBindings;

// AmbientSTBDesc
public unsafe struct AmbientSTBDesc : System.IDisposable
{
    // Members
    public ACBindings.IDClass___tagDataID stb_id;
    public int stb_not_found;
    public ACBindings.AC1Legacy.SmartArray__AmbientSoundDesc_ptr ambient_sounds;
    public ACBindings.CSoundTable* sound_table;
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
    // int __thiscall AmbientSTBDesc::InitSoundTable(AmbientSTBDesc*)
    public int InitSoundTable() => ((delegate* unmanaged[Thiscall]<ref ACBindings.AmbientSTBDesc, int>)0x004FF4E0)(ref this);
    // void __thiscall AmbientSTBDesc::AmbientSTBDesc(AmbientSTBDesc*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.AmbientSTBDesc, void>)0x00551DC0)(ref this);
    // void __thiscall AmbientSTBDesc::~AmbientSTBDesc(AmbientSTBDesc*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.AmbientSTBDesc, void>)0x00551DE0)(ref this);
    // unsigned int __thiscall AmbientSTBDesc::Pack(AmbientSTBDesc*,void**,unsigned int*)
    public uint Pack(void** addr, uint* size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.AmbientSTBDesc, void**, uint*, uint>)0x00551E40)(ref this, addr, size);
    // unsigned int __thiscall AmbientSTBDesc::pack_size(AmbientSTBDesc*)
    public uint pack_size() => ((delegate* unmanaged[Thiscall]<ref ACBindings.AmbientSTBDesc, uint>)0x00551F20)(ref this);
    // int __thiscall AmbientSTBDesc::UnPack(AmbientSTBDesc*,void**,unsigned int*)
    public int UnPack(void** addr, uint* size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.AmbientSTBDesc, void**, uint*, int>)0x00552510)(ref this, addr, size);
}

