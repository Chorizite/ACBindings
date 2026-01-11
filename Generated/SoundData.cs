namespace ACBindings.Internal;

public unsafe struct SoundData
{
    // Members
    public ACBindings.Internal.IDClass____tagDataID sound_id_;
    public float priority_;
    public float probability_;
    public float volume_;

    // Generated Constructor
    public SoundData() {
        _ConstructorInternal();
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x005528D0
    /// void __thiscall SoundData::SoundData(SoundData*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SoundData, void>)0x005528D0)(ref this);
}

