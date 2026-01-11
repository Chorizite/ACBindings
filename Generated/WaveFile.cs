namespace ACBindings.Internal;

public unsafe struct WaveFile
{
    // Child Types
    public unsafe struct WaveFile_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.WaveFile*, void> WaveFile_dtor_0; // function pointer

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

    /// <summary>
    /// <code>Offset: 0x00554460
    /// int __thiscall WaveFile::Cue(WaveFile*)</code>
    /// </summary>
    public int Cue() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.WaveFile, int>)0x00554460)(ref this);

    /// <summary>
    /// <code>Offset: 0x005544C0
    /// unsigned int __thiscall WaveFile::Read(WaveFile*,unsigned __int8*,unsigned int)</code>
    /// </summary>
    public uint Read(byte* pbDest, uint cbSize) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.WaveFile, byte*, uint, uint>)0x005544C0)(ref this, pbDest, cbSize);

    /// <summary>
    /// <code>Offset: 0x00554590
    /// unsigned int __thiscall WaveFile::Load(WaveFile*)</code>
    /// </summary>
    public uint Load() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.WaveFile, uint>)0x00554590)(ref this);

    /// <summary>
    /// <code>Offset: 0x005545E0
    /// void __thiscall WaveFile::WaveFile(WaveFile*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.WaveFile, void>)0x005545E0)(ref this);

    /// <summary>
    /// <code>Offset: 0x00554640
    /// void __thiscall WaveFile::ReleaseAll(WaveFile*)</code>
    /// </summary>
    public void ReleaseAll() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.WaveFile, void>)0x00554640)(ref this);

    /// <summary>
    /// <code>Offset: 0x005546E0
    /// HMMIO__* __thiscall WaveFile::Open(WaveFile*,const char**)</code>
    /// </summary>
    public System.IntPtr Open(sbyte** a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.WaveFile, sbyte**, System.IntPtr>)0x005546E0)(ref this, a2);
}

