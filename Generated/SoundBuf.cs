namespace ACBindings.Internal;

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

    /// <summary>
    /// <code>Offset: 0x00553290
    /// void __thiscall SoundBuf::ReleaseAll(SoundBuf*)</code>
    /// </summary>
    public void ReleaseAll() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SoundBuf, void>)0x00553290)(ref this);

    /// <summary>
    /// <code>Offset: 0x005532F0
    /// int __thiscall SoundBuf::CopyWaveToBuffer(SoundBuf*,WaveFile*)</code>
    /// </summary>
    public int CopyWaveToBuffer(ACBindings.Internal.WaveFile* pWave) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SoundBuf, ACBindings.Internal.WaveFile*, int>)0x005532F0)(ref this, pWave);

    /// <summary>
    /// <code>Offset: 0x00553450
    /// int __thiscall SoundBuf::Stop(SoundBuf*)</code>
    /// </summary>
    public int Stop() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SoundBuf, int>)0x00553450)(ref this);

    /// <summary>
    /// <code>Offset: 0x00553470
    /// int __thiscall SoundBuf::GetStatus(SoundBuf*)</code>
    /// </summary>
    public int GetStatus() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SoundBuf, int>)0x00553470)(ref this);

    /// <summary>
    /// <code>Offset: 0x005534D0
    /// void __thiscall SoundBuf::SoundBuf(SoundBuf*,const SoundBuf*)</code>
    /// </summary>
    public void _ConstructorInternal(ACBindings.Internal.SoundBuf* sb) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SoundBuf, ACBindings.Internal.SoundBuf*, void>)0x005534D0)(ref this, sb);

    /// <summary>
    /// <code>Offset: 0x00553550
    /// int __thiscall SoundBuf::Create(SoundBuf*,int)</code>
    /// </summary>
    public int Create(int use_static) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SoundBuf, int, int>)0x00553550)(ref this, use_static);

    /// <summary>
    /// <code>Offset: 0x005537B0
    /// int __thiscall SoundBuf::Restore(SoundBuf*)</code>
    /// </summary>
    public int Restore() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SoundBuf, int>)0x005537B0)(ref this);

    /// <summary>
    /// <code>Offset: 0x00553920
    /// SoundBuf* __thiscall SoundBuf::SoundBuf(SoundBuf*,int,int,int,int)</code>
    /// </summary>
    public ACBindings.Internal.SoundBuf* _ConstructorInternal(int a2, int a3, int pdwOutputBytes, int a5) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SoundBuf, int, int, int, int, ACBindings.Internal.SoundBuf*>)0x00553920)(ref this, a2, a3, pdwOutputBytes, a5);

    /// <summary>
    /// <code>Offset: 0x00553970
    /// int __thiscall SoundBuf::Play(SoundBuf*,int,int)</code>
    /// </summary>
    public int Play(int pan, int vol) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SoundBuf, int, int, int>)0x00553970)(ref this, pan, vol);
}

