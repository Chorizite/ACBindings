namespace ACBindings.Internal;


/// <summary>
/// WaveFile encapsulates the handling of WAV audio files, storing format information, data buffers, and MMIO state for reading and playback.
/// It provides functionality to load, read, cue and release wave file resources.
/// </summary>
public unsafe struct WaveFile
{
    // Child Types
    public unsafe struct WaveFile_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.WaveFile*, void> WaveFile_dtor_0; // function pointer

        // Methods
    }

    // Members
    public System.IntPtr __vftable; // vtable pointer
    public ACBindings.Internal.tWAVEFORMATEX* m_pwfmt;
    public byte* m_pData;
    public System.IntPtr m_hmmio;
    public uint m_mmr;
    public ACBindings.Internal._MMCKINFO m_mmckiRiff;
    public ACBindings.Internal._MMCKINFO m_mmckiFmt;
    public ACBindings.Internal._MMCKINFO m_mmckiData;
    public uint m_nDuration;
    public uint m_nBlockAlign;
    public uint m_nAvgDataRate;
    public uint m_nDataSize;
    public uint m_nFormatSize;
    public uint m_nBytesPlayed;

    // Generated Constructor
    public WaveFile() {
        _ConstructorInternal();
    }

    // Methods

    /// <summary>Positions the wave file at the beginning of its data chunk, resetting playback progress.
    /// <code>Offset: 0x00554460
    /// int __thiscall WaveFile::Cue(WaveFile*)</code>
    /// </summary>
    /// <returns>Non‑zero if positioning succeeded; zero on failure, with an internal error code stored in m_mmr.</returns>
    public int Cue() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.WaveFile, int>)0x00554460)(ref this);

    /// <summary>Reads up to the specified number of bytes from the wave file into a buffer, updating internal playback position and returning the actual byte count.
    /// <code>Offset: 0x005544C0
    /// unsigned int __thiscall WaveFile::Read(WaveFile*,unsigned __int8*,unsigned int)</code>
    /// </summary>
    /// <param name="pbDest">Destination buffer for the data.</param>
    /// <param name="cbSize">Maximum number of bytes to read.</param>
    /// <returns>Number of bytes actually transferred; zero indicates either no remaining data or an error during reading.</returns>
    public uint Read(byte* pbDest, uint cbSize) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.WaveFile, byte*, uint, uint>)0x005544C0)(ref this, pbDest, cbSize);

    /// <summary>Loads audio data into the WaveFile object's internal buffer by allocating memory of the appropriate size and reading from the source via Read. Returns the number of bytes successfully loaded, or 0 on failure.
    /// <code>Offset: 0x00554590
    /// unsigned int __thiscall WaveFile::Load(WaveFile*)</code>
    /// </summary>
    /// <returns>The count of bytes written into m_pData; returns 0 if no data was available or loading failed.</returns>
    public uint Load() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.WaveFile, uint>)0x00554590)(ref this);

    /// <summary>Initializes a WaveFile instance, assigning its virtual table and resetting all member variables to zero or null.
    /// <code>Offset: 0x005545E0
    /// void __thiscall WaveFile::WaveFile(WaveFile*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.WaveFile, void>)0x005545E0)(ref this);

    /// <summary>Releases the wave file's resources—closes the MMIO handle, deletes data and format buffers, and clears all internal state fields.
    /// <code>Offset: 0x00554640
    /// void __thiscall WaveFile::ReleaseAll(WaveFile*)</code>
    /// </summary>
    public void ReleaseAll() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.WaveFile, void>)0x00554640)(ref this);

    /// <summary>Opens a wave file specified by the supplied path and initializes format, data size, and duration information for the WaveFile object.
    /// <code>Offset: 0x005546E0
    /// HMMIO__* __thiscall WaveFile::Open(WaveFile*,const char**)</code>
    /// </summary>
    /// <param name="a2">Pointer to a null‑terminated string containing the file path of the wave file to open.</param>
    /// <returns>Non‑zero value (1) when the file is opened and parsed successfully; zero if opening or parsing fails, with m_mmr set to an error code.</returns>
    public System.IntPtr Open(sbyte** a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.WaveFile, sbyte**, System.IntPtr>)0x005546E0)(ref this, a2);
}

