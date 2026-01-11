namespace ACBindings.Internal;

public unsafe struct CDirSound : System.IDisposable
{
    // Members
    public ACBindings.Internal.tWAVEFORMATEX m_defaultFormat;
    public int* m_hWindow;
    public System.IntPtr m_pDirectSoundObj;
    public System.IntPtr m_lpDs3dListener;
    public System.IntPtr m_3DSoundBuffer;

    // Generated Constructor
    public CDirSound(int* hWnd) {
        _ConstructorInternal(hWnd);
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x00554930
    /// void __thiscall CDirSound::CDirSound(CDirSound*,HWND__*)</code>
    /// </summary>
    public void _ConstructorInternal(int* hWnd) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CDirSound, int*, void>)0x00554930)(ref this, hWnd);

    /// <summary>
    /// <code>Offset: 0x00554A60
    /// void __thiscall CDirSound::~CDirSound(CDirSound*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CDirSound, void>)0x00554A60)(ref this);
}

