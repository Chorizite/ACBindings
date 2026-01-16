namespace ACBindings.Internal;


/// <summary>Defines display configuration settings including resolution, fullscreen mode, refresh rate, and visual quality options such as triple buffering, VSync, and antialiasing.</summary>
public unsafe struct DisplayPrefs
{
    // Members
    public uint Resolution;
    public byte FullScreen;
    public uint RefreshRate;
    public byte TripleBuffering;
    public byte SyncToRefresh;
    public byte Antialiasing;

    // Methods
}

