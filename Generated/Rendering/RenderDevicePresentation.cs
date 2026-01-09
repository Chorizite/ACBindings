namespace ACBindings;

// RenderDevicePresentation
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
    // void __thiscall RenderDevicePresentation::RenderDevicePresentation(RenderDevicePresentation*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.RenderDevicePresentation, void>)0x00439140)(ref this);
}

