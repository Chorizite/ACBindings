namespace ACBindings.Internal;


/// <summary>Manages all rendering resources, state, and configuration for a graphics device, handling surfaces, viewports, and device lifecycle.</summary>
/// <remarks>Initializes presentation settings, manages frame buffers, depth‑stencil targets, wireframe mode, and provides utility functions such as aspect‑ratio calculation. Handles reset logic when the device is lost and cleans up resources on shutdown or destruction.</remarks>
public unsafe struct RenderDevice : System.IDisposable
{
    // Statics
    public static ACBindings.Internal.RenderDevice** render_device = (ACBindings.Internal.RenderDevice**)0x00870340;

    // Child Types
    public unsafe struct RenderDevice_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.RenderDevice*, void> RenderDevice_dtor_0; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.RenderDevice*, uint, ACBindings.Internal.RenderDevicePresentation*, ACBindings.Internal.RenderDeviceConfig*, byte> Startup; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.RenderDevice*, void> Shutdown; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.RenderDevice*, ACBindings.Internal.RenderSurface*> CreateLocalSurface; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.RenderDevice*, ACBindings.Internal.RenderSurface*> CreateSurface; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.RenderDevice*, ACBindings.Internal.RenderTexture*> CreateTexture; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.RenderDevice*, ACBindings.Internal.RenderIndexBuffer*> CreateIndexBuffer; // function pointer
        public System.IntPtr CreateVertexBuffer;
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.RenderDevice*, void> BeginScene; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.RenderDevice*, void> EndScene; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.RenderDevice*, void> Flip; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.RenderDevice*, uint, ACBindings.Internal.RGBAColor*, float, void> Clear; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.RenderDevice*, byte> IsResetPossible; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.RenderDevice*, uint, ACBindings.Internal.RenderSurface*, ACBindings.Internal.RenderSurface*, void> SetRenderTarget; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.RenderDevice*, ACBindings.Internal.RenderDevicePresentation*, byte> ResetDevice; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.RenderDevice*, ACBindings.Internal.RenderSurface*> GenerateSurfaceFromFrontBuffer; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.RenderDevice*, uint, uint, uint, uint, byte, void> SetViewport; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.RenderDevice*, ACBindings.Internal.LScape*, void> SetLandscape; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.RenderDevice*, ACBindings.Internal.CEnvCell*, void> DrawInside; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.RenderDevice*, ACBindings.Internal.CPortalPoly*, int, int, void> DrawPortal; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.RenderDevice*, ACBindings.Internal.CLandBlock*, void> DrawBlock; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.RenderDevice*, ACBindings.Internal.CLandCell*, void> DrawLandCell; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.RenderDevice*, ACBindings.Internal.CSortCell*, void> DrawSortCell; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.RenderDevice*, ACBindings.Internal.CEnvCell*, void> DrawEnvCell; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.RenderDevice*, ACBindings.Internal.CObjCell*, void> DrawObjCell; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.RenderDevice*, ACBindings.Internal.CObjCell*, void> DrawObjCellForDummies; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.RenderDevice*, ACBindings.Internal.CBuildingObj*, void> DrawBuilding; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.RenderDevice*, uint, void> DrawBuildingLeaf; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.RenderDevice*, ACBindings.Internal.CGfxObj*, ACBindings.Internal.Position*, byte, ACBindings.Internal.ObjectDrawStatus> DrawMesh; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.RenderDevice*, ACBindings.Internal.CGfxObj*, ACBindings.Internal.Position*, void> DrawDetailMesh; // function pointer

        // Methods
    }

    /// <summary>
    /// Represents all per‑frame rendering parameters, including transformation matrices, lighting and fog settings, bloom effects, and viewport scaling, enabling consistent visual output from the RenderDevice.
    /// </summary>
    public unsafe struct GraphicsStatesType
    {
        // Members
        public ACBindings.Internal.Matrix4 ModelToWorldMatrix;
        public ACBindings.Internal.Matrix4 WorldToViewMatrix;
        public ACBindings.Internal.Matrix4 ViewToClipMatrix;
        public ACBindings.Internal.RGBAColor AmbientLight;
        public ACBindings.Internal.RGBAColor DistanceFogColor;
        public float DistanceFogNear;
        public float DistanceFogFar;
        public float DistantSpriteOpacityNear;
        public float DistantSpriteOpacityRange;
        public float OpacityFogNearDistance;
        public float OpacityFogRange;
        public ACBindings.Internal.RenderLight* pMPLightSource;
        public ACBindings.Internal.RenderTexture* pMPLightProjectorTexture;
        public ACBindings.Internal.SmartArray___RenderLight FFLightSources;
        public byte ChangedFFLightSources;
        public ACBindings.Internal.RGBAColor FrameBufferBloomRGBAmount;
        public fixed byte PixelFilterTexCoords_Raw[240];
        public ACBindings.Internal.Vector4* PixelFilterTexCoords => (ACBindings.Internal.Vector4*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref PixelFilterTexCoords_Raw[0]);
        public ACBindings.Internal.Vector4 BSVLightOriginAndExtrusionOffset;
        public float FrameBufferViewportOffsetX;
        public float FrameBufferViewportOffsetY;
        public float FrameBufferViewportScaleX;
        public float FrameBufferViewportScaleY;

        // Generated Constructor
        public GraphicsStatesType() {
            _ConstructorInternal();
        }

        // Methods

        /// <summary>Initializes all graphics state fields with default values, setting transformation matrices to zero matrices, defining standard ambient light, fog, and sprite opacity parameters, and clearing dynamic light source lists.
        /// <code>Offset: 0x00550150
        /// void __thiscall RenderDevice::GraphicsStatesType::GraphicsStatesType(RenderDevice::GraphicsStatesType*)</code>
        /// </summary>
        public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderDevice.GraphicsStatesType, void>)0x00550150)(ref this);
    }

    // Members
    public System.IntPtr __vftable; // vtable pointer
    public ACBindings.Internal.RenderDevicePresentation m_presentation;
    public ACBindings.Internal.RenderDeviceConfig m_config;
    public ACBindings.Internal.RenderDeviceCaps m_caps;
    public ACBindings.Internal.RenderDeviceDisplayInfo m_displayInfo;
    public uint m_viewportX;
    public uint m_viewportY;
    public uint m_viewportWidth;
    public uint m_viewportHeight;
    public uint m_RenderTargetWidth;
    public uint m_RenderTargetHeight;
    public float m_DisplayAspectRatio;
    public float m_ViewportAspectRatio;
    public byte m_bOpenScene;
    public byte m_bDeviceLost;
    public uint m_nFrameStamp;
    public ACBindings.Internal.RenderSurface* m_pFrameBufferSurface;
    public ACBindings.Internal.RenderSurface* m_pDepthStencilSurface;
    public ACBindings.Internal.RenderSurface* m_pRenderTarget;
    public ACBindings.Internal.RenderSurface* m_pDepthStencilTarget;
    public byte m_WireframeMode;
    public byte m_ReverseCulling;
    public ACBindings.Internal.RenderDevice.GraphicsStatesType m_GState;
    public ACBindings.Internal.TextureBasedFont* m_pDebugFont;
    public uint m_DebugFontWidth;
    public uint m_DebugFontHeight;

    // Generated Constructor
    public RenderDevice() {
        _ConstructorInternal();
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>Releases all render surface resources owned by the device and clears associated pointers to avoid dangling references.
    /// <code>Offset: 0x0054FCC0
    /// void __thiscall RenderDevice::ReleaseSurfaceResources(RenderDevice*)</code>
    /// </summary>
    public void ReleaseSurfaceResources() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderDevice, void>)0x0054FCC0)(ref this);

    /// <summary>Retrieves the width of the device’s current frame buffer surface.
    /// <code>Offset: 0x0054FD20
    /// unsigned int __thiscall RenderDevice::GetDisplayWidth(RenderDevice*)</code>
    /// </summary>
    /// <returns>The width in pixels as an unsigned integer.</returns>
    public uint GetDisplayWidth() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderDevice, uint>)0x0054FD20)(ref this);

    /// <summary>Retrieves the pixel height of the device’s framebuffer surface.
    /// <code>Offset: 0x0054FD30
    /// unsigned int __thiscall RenderDevice::GetDisplayHeight(RenderDevice*)</code>
    /// </summary>
    /// <returns>The height in pixels of the framebuffer.</returns>
    public uint GetDisplayHeight() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderDevice, uint>)0x0054FD30)(ref this);

    /// <summary>Creates a new RenderSurface instance for the device by allocating memory and invoking its constructor.
    /// <code>Offset: 0x0054FD40
    /// RenderSurface* __thiscall RenderDevice::CreateLocalSurface(RenderDevice*)</code>
    /// </summary>
    /// <returns>A pointer to the initialized RenderSurface, or nullptr if memory allocation fails.</returns>
    public ACBindings.Internal.RenderSurface* CreateLocalSurface() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderDevice, ACBindings.Internal.RenderSurface*>)0x0054FD40)(ref this);

    /// <summary>Calculates the viewport aspect ratio from its dimensions, optionally scaling by the device’s display aspect ratio and a fixed factor when auto‑aspect is disabled.
    /// <code>Offset: 0x0054FD60
    /// float __thiscall RenderDevice::ComputeAspectForViewport(RenderDevice*,unsigned int,unsigned int,unsigned int,unsigned int,bool)</code>
    /// </summary>
    /// <param name="x">Viewport X coordinate (unused in calculation).</param>
    /// <param name="y">Viewport Y coordinate (unused in calculation).</param>
    /// <param name="width">Viewport width in pixels.</param>
    /// <param name="height">Viewport height in pixels.</param>
    /// <param name="UseAutoAspect">If true, returns width divided by height; otherwise multiplies the result by the display aspect ratio and a factor of 0.75.</param>
    /// <returns>The computed viewport aspect ratio as a float.</returns>
    public float ComputeAspectForViewport(uint x, uint y, uint width, uint height, byte UseAutoAspect) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderDevice, uint, uint, uint, uint, byte, float>)0x0054FD60)(ref this, x, y, width, height, UseAutoAspect);

    /// <summary>Sets the rendering viewport within the current render target, clamping coordinates and dimensions to valid ranges and updating internal state accordingly.
    /// <code>Offset: 0x0054FDD0
    /// void __thiscall RenderDevice::SetViewport(RenderDevice*,unsigned int,unsigned int,unsigned int,unsigned int,bool)</code>
    /// </summary>
    /// <param name="x">The horizontal coordinate of the viewport's top-left corner in pixels.</param>
    /// <param name="y">The vertical coordinate of the viewport's top-left corner in pixels.</param>
    /// <param name="width">The desired width of the viewport in pixels.</param>
    /// <param name="height">The desired height of the viewport in pixels.</param>
    /// <param name="UseAutoAspect">If true, calculates the aspect ratio automatically; otherwise uses the existing configuration.</param>
    public void SetViewport(uint x, uint y, uint width, uint height, byte UseAutoAspect) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderDevice, uint, uint, uint, uint, byte, void>)0x0054FDD0)(ref this, x, y, width, height, UseAutoAspect);

    /// <summary>Initializes the rendering device using the supplied adapter index, presentation settings, and configuration data.
    /// <code>Offset: 0x0054FE50
    /// bool __thiscall RenderDevice::Startup(RenderDevice*,const unsigned int,const RenderDevicePresentation*,const RenderDeviceConfig*)</code>
    /// </summary>
    /// <param name="nDisplayAdapter">Index of the display adapter to use for rendering.</param>
    /// <param name="presentation">Presentation parameters such as window handle, resolution, fullscreen mode, etc.</param>
    /// <param name="config">Device configuration options.</param>
    /// <returns>True if initialization succeeds; always true in current implementation.</returns>
    public byte Startup(uint nDisplayAdapter, ACBindings.Internal.RenderDevicePresentation* presentation, ACBindings.Internal.RenderDeviceConfig* config) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderDevice, uint, ACBindings.Internal.RenderDevicePresentation*, ACBindings.Internal.RenderDeviceConfig*, byte>)0x0054FE50)(ref this, nDisplayAdapter, presentation, config);

    /// <summary>Retrieves the pixel format identifier used for the UI surface stored in the device’s display information.
    /// <code>Offset: 0x0054FE80
    /// PixelFormatID __thiscall RenderDevice::GetUISurfaceFormat(RenderDevice*)</code>
    /// </summary>
    /// <returns>The PixelFormatID that represents the UI surface format.</returns>
    public ACBindings.Internal.PixelFormatID GetUISurfaceFormat() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderDevice, ACBindings.Internal.PixelFormatID>)0x0054FE80)(ref this);

    /// <summary>Finalizes rendering operations by releasing surface resources, deregistering the global wireframe setting, and decrementing references to the debug font when its reference count reaches zero.
    /// <code>Offset: 0x005502A0
    /// void __thiscall RenderDevice::End(RenderDevice*)</code>
    /// </summary>
    public void End() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderDevice, void>)0x005502A0)(ref this);

    /// <summary>Initializes a RenderDevice instance with default presentation parameters, clears capability flags, configures stencil buffer usage, resets viewport and render target dimensions, initializes graphics states, cleans any existing light source data, and registers the wireframe mode setting.
    /// <code>Offset: 0x00550850
    /// void __thiscall RenderDevice::Begin(RenderDevice*)</code>
    /// </summary>
    public void Begin() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderDevice, void>)0x00550850)(ref this);

    /// <summary>Terminates the current rendering session and reinitializes the device to reset its state.
    /// <code>Offset: 0x00550AC0
    /// void __thiscall RenderDevice::Shutdown(RenderDevice*)</code>
    /// </summary>
    public void Shutdown() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderDevice, void>)0x00550AC0)(ref this);

    /// <summary>Initializes a new rendering device by setting default presentation settings, configuration flags, capabilities, display information, and establishing the initial graphics state before beginning rendering operations.
    /// <code>Offset: 0x0059EDE0
    /// void __thiscall RenderDevice::RenderDevice(RenderDevice*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderDevice, void>)0x0059EDE0)(ref this);

    /// <summary>Determines if the rendering device can be reset by checking whether it has been marked as lost.
    /// <code>Offset: 0x0059EEC0
    /// bool __thiscall RenderDevice::IsResetPossible(RenderDevice*)</code>
    /// </summary>
    /// <returns>True if the device is not lost and a reset is possible; otherwise, false.</returns>
    public byte IsResetPossible() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderDevice, byte>)0x0059EEC0)(ref this);

    /// <summary>Terminates the rendering device and releases associated resources, including deallocating light‑source data if it was allocated.
    /// <code>Offset: 0x0059EED0
    /// void __thiscall RenderDevice::~RenderDevice(RenderDevice*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderDevice, void>)0x0059EED0)(ref this);
}

