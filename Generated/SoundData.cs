namespace ACBindings;

// SoundData
public unsafe struct SoundData
{
    // Members
    public ACBindings.IDClass___tagDataID sound_id_;
    public float priority_;
    public float probability_;
    public float volume_;

    // Generated Constructor
    public SoundData() {
        _ConstructorInternal();
    }

    // Methods
    // void __thiscall SoundData::SoundData(SoundData*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.SoundData, void>)0x005528D0)(ref this);
}

