namespace ACBindings;

// WaveFile
public unsafe struct WaveFile
{
    // Child Types
    // WaveFile_vtbl
    public unsafe struct WaveFile_vtbl
    {
        // Members
        public System.IntPtr WaveFile_dtor_0; // function pointer

        // Methods
    }

    // Members
    public System.IntPtr __vftable; // vtable pointer
    public ACBindings.tWAVEFORMATEX* m_pwfmt;
    public byte* m_pData;
    public System.IntPtr m_hmmio;
    public uint m_mmr;
    public ACBindings._MMCKINFO m_mmckiRiff;
    public ACBindings._MMCKINFO m_mmckiFmt;
    public ACBindings._MMCKINFO m_mmckiData;
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
    // int __thiscall WaveFile::Cue(WaveFile*)
    public int Cue() => ((delegate* unmanaged[Thiscall]<ref ACBindings.WaveFile, int>)0x00554460)(ref this);
    // unsigned int __thiscall WaveFile::Read(WaveFile*,unsigned __int8*,unsigned int)
    public uint Read(byte* pbDest, uint cbSize) => ((delegate* unmanaged[Thiscall]<ref ACBindings.WaveFile, byte*, uint, uint>)0x005544C0)(ref this, pbDest, cbSize);
    // unsigned int __thiscall WaveFile::Load(WaveFile*)
    public uint Load() => ((delegate* unmanaged[Thiscall]<ref ACBindings.WaveFile, uint>)0x00554590)(ref this);
    // void __thiscall WaveFile::WaveFile(WaveFile*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.WaveFile, void>)0x005545E0)(ref this);
    // void __thiscall WaveFile::ReleaseAll(WaveFile*)
    public void ReleaseAll() => ((delegate* unmanaged[Thiscall]<ref ACBindings.WaveFile, void>)0x00554640)(ref this);
    // HMMIO__* __thiscall WaveFile::Open(WaveFile*,const char**)
    public System.IntPtr Open(sbyte** a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.WaveFile, sbyte**, System.IntPtr>)0x005546E0)(ref this, a2);
}

