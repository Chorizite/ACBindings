namespace ACBindings;

// SoundBufRef
public unsafe struct SoundBufRef
{
    // Base Classes
    public ACBindings.IntrusiveHashData__IDClass___tagDataID__SoundBufRef_ptr BaseClass_IntrusiveHashData; // ACBindings.IntrusiveHashData__IDClass___tagDataID__SoundBufRef_ptr

    // Members
    public ACBindings.SoundData data_;
    public int links_;
    public ACBindings.SoundBuf* sound_buf_;
    public int buffer_num_;

    // Generated Constructor
    public SoundBufRef(int a2) {
        _ConstructorInternal(a2);
    }

    // Methods
    // char* __thiscall SoundBufRef::SoundBufRef(char*,int)
    public sbyte* _ConstructorInternal(int a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.SoundBufRef, int, sbyte*>)0x00550D20)(ref this, a2);
}

