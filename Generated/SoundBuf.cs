namespace ACBindings.Internal;


/// <summary>Encapsulates a sound buffer for the application’s audio engine, managing DirectSound resources, playback state, and source metadata such as filename, identifier, and 3‑D configuration.</summary>
public unsafe struct SoundBuf
{
    // Statics
    public static int* useDatabase = (int*)0x00820230;

    // Members
    public ACBindings.Internal.CDirSound* m_pCDirSound;
    public System.IntPtr m_pBuf;
    public System.IntPtr m_p3DBuf;
    public sbyte* m_filename;
    public int m_tagval;
    public uint m_bufsize;
    public int m_3D;
    public ACBindings.Internal.IDClass____tagDataID m_gid;

    // Generated Constructor
    public SoundBuf(ACBindings.Internal.SoundBuf* sb) {
        _ConstructorInternal(sb);
    }
    public SoundBuf(int a2, int a3, int pdwOutputBytes, int a5) {
        _ConstructorInternal(a2, a3, pdwOutputBytes, a5);
    }

    // Methods

    /// <summary>Releases all resources owned by this sound buffer, freeing the filename allocation, releasing DirectSound buffer objects, and resetting internal fields to their default states.
    /// <code>Offset: 0x00553290
    /// void __thiscall SoundBuf::ReleaseAll(SoundBuf*)</code>
    /// </summary>
    public void ReleaseAll() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SoundBuf, void>)0x00553290)(ref this);

    /// <summary>Copies audio data from a WaveFile into the SoundBuf's DirectSound buffer, converting format when required.
    /// <code>Offset: 0x005532F0
    /// int __thiscall SoundBuf::CopyWaveToBuffer(SoundBuf*,WaveFile*)</code>
    /// </summary>
    /// <param name="pWave">The source wave file containing audio data and format information.</param>
    /// <returns>Non‑zero if the copy succeeded; zero on failure.</returns>
    public int CopyWaveToBuffer(ACBindings.Internal.WaveFile* pWave) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SoundBuf, ACBindings.Internal.WaveFile*, int>)0x005532F0)(ref this, pWave);

    /// <summary>Stops playback of the sound buffer represented by this SoundBuf instance.
    /// <code>Offset: 0x00553450
    /// int __thiscall SoundBuf::Stop(SoundBuf*)</code>
    /// </summary>
    /// <returns>Returns non‑zero if the underlying DirectSound buffer was successfully stopped; returns zero if there is no buffer or the stop operation fails.</returns>
    public int Stop() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SoundBuf, int>)0x00553450)(ref this);

    /// <summary>Checks whether the underlying DirectSoundBuffer is available and returns a status indicator.
    /// <code>Offset: 0x00553470
    /// int __thiscall SoundBuf::GetStatus(SoundBuf*)</code>
    /// </summary>
    /// <returns>The integer value of this SoundBuf instance when successful; returns –1 if no buffer or QueryInterface fails.</returns>
    public int GetStatus() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SoundBuf, int>)0x00553470)(ref this);

    /// <summary>Constructs a new sound buffer by cloning the DirectSound buffer and metadata from an existing SoundBuf instance.
    /// <code>Offset: 0x005534D0
    /// void __thiscall SoundBuf::SoundBuf(SoundBuf*,const SoundBuf*)</code>
    /// </summary>
    /// <param name="sb">The source SoundBuf whose buffer and properties are copied into this object.</param>
    public void _ConstructorInternal(ACBindings.Internal.SoundBuf* sb) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SoundBuf, ACBindings.Internal.SoundBuf*, void>)0x005534D0)(ref this, sb);

    /// <summary>Create a DirectSound buffer from the sound data linked to this SoundBuf instance, loading either from disk or a database entry and configuring 3‑D settings if requested.
    /// <code>Offset: 0x00553550
    /// int __thiscall SoundBuf::Create(SoundBuf*,int)</code>
    /// </summary>
    /// <param name="use_static">If non‑zero, the buffer is created with static allocation flags.</param>
    /// <returns>Non‑zero on success; zero indicates failure to load or create the buffer.</returns>
    public int Create(int use_static) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SoundBuf, int, int>)0x00553550)(ref this, use_static);

    /// <summary>Restores the sound buffer by reloading its wave data from disk or a database and recreating the DirectSound buffer as necessary.
    /// <code>Offset: 0x005537B0
    /// int __thiscall SoundBuf::Restore(SoundBuf*)</code>
    /// </summary>
    /// <returns>Zero if restoration fails; non‑zero (typically 1) on success.</returns>
    public int Restore() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SoundBuf, int>)0x005537B0)(ref this);

    /// <summary>Constructs a sound buffer with the specified identifier, tag value, output byte count, and 3D setting. Initializes internal DirectSound pointers and attempts to create the underlying buffer if a directory sound is available.
    /// <code>Offset: 0x00553920
    /// SoundBuf* __thiscall SoundBuf::SoundBuf(SoundBuf*,int,int,int,int)</code>
    /// </summary>
    /// <param name="a2">The unique identifier for this sound buffer.</param>
    /// <param name="a3">A user-defined tag value associated with the buffer.</param>
    /// <param name="pdwOutputBytes">The number of bytes of audio data to allocate for the buffer.</param>
    /// <param name="a5">Flag indicating whether 3‑D positioning is enabled (non‑zero) or disabled (zero).</param>
    /// <returns>A reference to the newly constructed SoundBuf instance.</returns>
    public ACBindings.Internal.SoundBuf* _ConstructorInternal(int a2, int a3, int pdwOutputBytes, int a5) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SoundBuf, int, int, int, int, ACBindings.Internal.SoundBuf*>)0x00553920)(ref this, a2, a3, pdwOutputBytes, a5);

    /// <summary>Plays the sound buffer while clamping pan between –15 and 15 and volume above the minimum threshold.
    /// <code>Offset: 0x00553970
    /// int __thiscall SoundBuf::Play(SoundBuf*,int,int)</code>
    /// </summary>
    /// <param name="pan">Desired stereo panning value; values outside –15…15 are capped to the nearest limit.</param>
    /// <param name="vol">Desired volume level; values below the system minimum are raised to that minimum.</param>
    /// <returns>Non‑zero if playback started successfully; zero otherwise.</returns>
    public int Play(int pan, int vol) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SoundBuf, int, int, int>)0x00553970)(ref this, pan, vol);
}

