namespace ACBindings.Internal;


/// <summary>Encapsulates DirectSound components, initializing the device, listener, and default audio buffer for a window.</summary>
/// <remarks>Stores the 3‑D listener, sound buffer, and wave format (stereo, 16‑bit, 11 025 Hz) used by the application.</remarks>
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
    /// Initializes DirectSound for the specified window, creating a 3‑D listener and default audio buffer.
    /// Sets up the wave format to stereo, 16‑bit samples at 11 025 Hz and associates the sound object with the supplied HWND.
    /// 
    /// <code>Offset: 0x00554930
    /// void __thiscall CDirSound::CDirSound(CDirSound*,HWND__*)</code>
    /// </summary>
    /// <param name="hWnd">Handle to the window that owns the DirectSound device.</param>
    public void _ConstructorInternal(int* hWnd) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CDirSound, int*, void>)0x00554930)(ref this, hWnd);

    /// <summary>Releases DirectSound interfaces associated with the object, freeing resources before destruction.
    /// <code>Offset: 0x00554A60
    /// void __thiscall CDirSound::~CDirSound(CDirSound*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CDirSound, void>)0x00554A60)(ref this);
}

