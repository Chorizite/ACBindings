namespace ACBindings.Internal;


/// <summary>Holds configuration for a rendering device's presentation settings, including window handle, resolution, full‑screen options, refresh rate, color depth, buffering, vsync, and anti‑aliasing.</summary>
public unsafe struct RenderDevicePresentation
{
    // Members
    public int* hRenderWindow;
    public uint Width;
    public uint Height;
    public byte FullScreen;
    public uint FSRefreshRate;
    public uint FSBitsPerPixel;
    public byte FSTripleBuffering;
    public byte FSSyncToDisplayRefresh;
    public byte Antialiasing;

    // Generated Constructor
    public RenderDevicePresentation() {
        _ConstructorInternal();
    }

    // Methods

    /// <summary>Initializes a RenderDevicePresentation instance with default display configuration: an 800×600 window, no render window handle, and standard visual settings such as 32‑bit color depth, no antialiasing, and no fullscreen mode.
    /// <code>Offset: 0x00439140
    /// void __thiscall RenderDevicePresentation::RenderDevicePresentation(RenderDevicePresentation*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderDevicePresentation, void>)0x00439140)(ref this);
}

