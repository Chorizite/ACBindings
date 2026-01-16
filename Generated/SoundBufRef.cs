namespace ACBindings.Internal;


/// <summary>Manages a reference to a sound buffer, maintaining its unique ID, associated data, and link count while providing direct access to the underlying SoundBuf instance.</summary>
/// <remarks>
/// <para><c>baseclass_0</c>: Intrusive hash entry keyed by sound ID.</para>
/// <para><c>data_</c>: Holds metadata about the sound.</para>
/// <para><c>links_</c>: Reference count indicating how many entities use this buffer.</para>
/// <para><c>sound_buf_</c>: Pointer to the allocated SoundBuf object.</para>
/// <para><c>buffer_num_</c>: Identifier for the specific buffer slot.</para>
/// </remarks>
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

    /// <summary>Creates a SoundBufRef object, initializing its ID and internal state, and allocates an associated SoundBuf.
    /// <code>Offset: 0x00550D20
    /// char* __thiscall SoundBufRef::SoundBufRef(char*,int)</code>
    /// </summary>
    /// <param name="a2">Identifier for the sound buffer reference.</param>
    /// <returns>Pointer to the newly constructed SoundBufRef instance.</returns>
    public sbyte* _ConstructorInternal(int a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SoundBufRef, int, sbyte*>)0x00550D20)(ref this, a2);
}

