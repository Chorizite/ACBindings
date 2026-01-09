namespace ACBindings;

// SoundBuf
public unsafe struct SoundBuf
{
    // Statics
    public static int* useDatabase = (int*)0x00820230;

    // Members
    public ACBindings.CDirSound* m_pCDirSound;
    public System.IntPtr m_pBuf;
    public System.IntPtr m_p3DBuf;
    public sbyte* m_filename;
    public int m_tagval;
    public uint m_bufsize;
    public int m_3D;
    public ACBindings.IDClass___tagDataID m_gid;

    // Generated Constructor
    public SoundBuf(ACBindings.SoundBuf* sb) {
        _ConstructorInternal(sb);
    }
    public SoundBuf(int a2, int a3, int pdwOutputBytes, int a5) {
        _ConstructorInternal(a2, a3, pdwOutputBytes, a5);
    }

    // Methods
    // void __thiscall SoundBuf::ReleaseAll(SoundBuf*)
    public void ReleaseAll() => ((delegate* unmanaged[Thiscall]<ref ACBindings.SoundBuf, void>)0x00553290)(ref this);
    // int __thiscall SoundBuf::CopyWaveToBuffer(SoundBuf*,WaveFile*)
    public int CopyWaveToBuffer(ACBindings.WaveFile* pWave) => ((delegate* unmanaged[Thiscall]<ref ACBindings.SoundBuf, ACBindings.WaveFile*, int>)0x005532F0)(ref this, pWave);
    // int __thiscall SoundBuf::Stop(SoundBuf*)
    public int Stop() => ((delegate* unmanaged[Thiscall]<ref ACBindings.SoundBuf, int>)0x00553450)(ref this);
    // int __thiscall SoundBuf::GetStatus(SoundBuf*)
    public int GetStatus() => ((delegate* unmanaged[Thiscall]<ref ACBindings.SoundBuf, int>)0x00553470)(ref this);
    // void __thiscall SoundBuf::SoundBuf(SoundBuf*,const SoundBuf*)
    public void _ConstructorInternal(ACBindings.SoundBuf* sb) => ((delegate* unmanaged[Thiscall]<ref ACBindings.SoundBuf, ACBindings.SoundBuf*, void>)0x005534D0)(ref this, sb);
    // int __thiscall SoundBuf::Create(SoundBuf*,int)
    public int Create(int use_static) => ((delegate* unmanaged[Thiscall]<ref ACBindings.SoundBuf, int, int>)0x00553550)(ref this, use_static);
    // int __thiscall SoundBuf::Restore(SoundBuf*)
    public int Restore() => ((delegate* unmanaged[Thiscall]<ref ACBindings.SoundBuf, int>)0x005537B0)(ref this);
    // SoundBuf* __thiscall SoundBuf::SoundBuf(SoundBuf*,int,int,int,int)
    public ACBindings.SoundBuf* _ConstructorInternal(int a2, int a3, int pdwOutputBytes, int a5) => ((delegate* unmanaged[Thiscall]<ref ACBindings.SoundBuf, int, int, int, int, ACBindings.SoundBuf*>)0x00553920)(ref this, a2, a3, pdwOutputBytes, a5);
    // int __thiscall SoundBuf::Play(SoundBuf*,int,int)
    public int Play(int pan, int vol) => ((delegate* unmanaged[Thiscall]<ref ACBindings.SoundBuf, int, int, int>)0x00553970)(ref this, pan, vol);
}

