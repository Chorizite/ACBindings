namespace ACBindings.Internal;

public unsafe struct SoundBufRef
{
    // Base Classes
    public ACBindings.Internal.IntrusiveHashData___IDClass____tagDataID___SoundBufRef_ptr BaseClass_IntrusiveHashData; // ACBindings.Internal.IntrusiveHashData___IDClass____tagDataID___SoundBufRef_ptr

    // Members
    public ACBindings.Internal.SoundData data_;
    public int links_;
    public ACBindings.Internal.SoundBuf* sound_buf_;
    public int buffer_num_;

    // Generated Constructor
    public SoundBufRef(int a2) {
        _ConstructorInternal(a2);
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x00550D20
    /// char* __thiscall SoundBufRef::SoundBufRef(char*,int)</code>
    /// </summary>
    public sbyte* _ConstructorInternal(int a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SoundBufRef, int, sbyte*>)0x00550D20)(ref this, a2);
}

