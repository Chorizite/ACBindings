namespace ACBindings.Internal;


/// <summary>Represents configuration settings for a rendering device, controlling focus window handle and buffer usage options.</summary>
public unsafe struct RenderDeviceConfig
{
    // Members
    public int* hFocusWindow;
    public byte bUseStencilBuffer;
    public byte bSoftwareVertexProcessing;
    public byte bUsePureDevice;

    // Methods
}

