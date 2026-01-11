namespace ACBindings.Internal;

public unsafe struct RenderDevice : System.IDisposable
{
    // Child Types
    public unsafe struct RenderDevice_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.RenderDevice*, void> RenderDevice_dtor_0; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.RenderDevice*, uint, ACBindings.Internal.RenderDevicePresentation*, ACBindings.Internal.RenderDeviceConfig*, byte> Startup; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.RenderDevice*, void> Shutdown; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.RenderDevice*, ACBindings.Internal.RenderSurface*> CreateLocalSurface; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.RenderDevice*, ACBindings.Internal.RenderSurface*> CreateSurface; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.RenderDevice*, ACBindings.Internal.RenderTexture*> CreateTexture; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.RenderDevice*, ACBindings.Internal.RenderIndexBuffer*> CreateIndexBuffer; // function pointer
        public System.IntPtr CreateVertexBuffer;
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.RenderDevice*, void> BeginScene; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.RenderDevice*, void> EndScene; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.RenderDevice*, void> Flip; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.RenderDevice*, uint, ACBindings.Internal.RGBAColor*, float, void> Clear; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.RenderDevice*, byte> IsResetPossible; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.RenderDevice*, uint, ACBindings.Internal.RenderSurface*, ACBindings.Internal.RenderSurface*, void> SetRenderTarget; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.RenderDevice*, ACBindings.Internal.RenderDevicePresentation*, byte> ResetDevice; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.RenderDevice*, ACBindings.Internal.RenderSurface*> GenerateSurfaceFromFrontBuffer; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.RenderDevice*, uint, uint, uint, uint, byte, void> SetViewport; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.RenderDevice*, ACBindings.Internal.LScape*, void> SetLandscape; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.RenderDevice*, ACBindings.Internal.CEnvCell*, void> DrawInside; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.RenderDevice*, ACBindings.Internal.CPortalPoly*, int, int, void> DrawPortal; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.RenderDevice*, ACBindings.Internal.CLandBlock*, void> DrawBlock; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.RenderDevice*, ACBindings.Internal.CLandCell*, void> DrawLandCell; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.RenderDevice*, ACBindings.Internal.CSortCell*, void> DrawSortCell; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.RenderDevice*, ACBindings.Internal.CEnvCell*, void> DrawEnvCell; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.RenderDevice*, ACBindings.Internal.CObjCell*, void> DrawObjCell; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.RenderDevice*, ACBindings.Internal.CObjCell*, void> DrawObjCellForDummies; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.RenderDevice*, ACBindings.Internal.CBuildingObj*, void> DrawBuilding; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.RenderDevice*, uint, void> DrawBuildingLeaf; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.RenderDevice*, ACBindings.Internal.CGfxObj*, ACBindings.Internal.Position*, byte, ACBindings.Internal.ObjectDrawStatus> DrawMesh; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.RenderDevice*, ACBindings.Internal.CGfxObj*, ACBindings.Internal.Position*, void> DrawDetailMesh; // function pointer

        // Methods
    }
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

        /// <summary>
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

    /// <summary>
    /// <code>Offset: 0x0054FCC0
    /// void __thiscall RenderDevice::ReleaseSurfaceResources(RenderDevice*)</code>
    /// </summary>
    public void ReleaseSurfaceResources() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderDevice, void>)0x0054FCC0)(ref this);

    /// <summary>
    /// <code>Offset: 0x0054FD20
    /// unsigned int __thiscall RenderDevice::GetDisplayWidth(RenderDevice*)</code>
    /// </summary>
    public uint GetDisplayWidth() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderDevice, uint>)0x0054FD20)(ref this);

    /// <summary>
    /// <code>Offset: 0x0054FD30
    /// unsigned int __thiscall RenderDevice::GetDisplayHeight(RenderDevice*)</code>
    /// </summary>
    public uint GetDisplayHeight() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderDevice, uint>)0x0054FD30)(ref this);

    /// <summary>
    /// <code>Offset: 0x0054FD40
    /// RenderSurface* __thiscall RenderDevice::CreateLocalSurface(RenderDevice*)</code>
    /// </summary>
    public ACBindings.Internal.RenderSurface* CreateLocalSurface() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderDevice, ACBindings.Internal.RenderSurface*>)0x0054FD40)(ref this);

    /// <summary>
    /// <code>Offset: 0x0054FD60
    /// float __thiscall RenderDevice::ComputeAspectForViewport(RenderDevice*,unsigned int,unsigned int,unsigned int,unsigned int,bool)</code>
    /// </summary>
    public float ComputeAspectForViewport(uint x, uint y, uint width, uint height, byte UseAutoAspect) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderDevice, uint, uint, uint, uint, byte, float>)0x0054FD60)(ref this, x, y, width, height, UseAutoAspect);

    /// <summary>
    /// <code>Offset: 0x0054FDD0
    /// void __thiscall RenderDevice::SetViewport(RenderDevice*,unsigned int,unsigned int,unsigned int,unsigned int,bool)</code>
    /// </summary>
    public void SetViewport(uint x, uint y, uint width, uint height, byte UseAutoAspect) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderDevice, uint, uint, uint, uint, byte, void>)0x0054FDD0)(ref this, x, y, width, height, UseAutoAspect);

    /// <summary>
    /// <code>Offset: 0x0054FE50
    /// bool __thiscall RenderDevice::Startup(RenderDevice*,const unsigned int,const RenderDevicePresentation*,const RenderDeviceConfig*)</code>
    /// </summary>
    public byte Startup(uint nDisplayAdapter, ACBindings.Internal.RenderDevicePresentation* presentation, ACBindings.Internal.RenderDeviceConfig* config) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderDevice, uint, ACBindings.Internal.RenderDevicePresentation*, ACBindings.Internal.RenderDeviceConfig*, byte>)0x0054FE50)(ref this, nDisplayAdapter, presentation, config);

    /// <summary>
    /// <code>Offset: 0x0054FE80
    /// PixelFormatID __thiscall RenderDevice::GetUISurfaceFormat(RenderDevice*)</code>
    /// </summary>
    public ACBindings.Internal.PixelFormatID GetUISurfaceFormat() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderDevice, ACBindings.Internal.PixelFormatID>)0x0054FE80)(ref this);

    /// <summary>
    /// <code>Offset: 0x005502A0
    /// void __thiscall RenderDevice::End(RenderDevice*)</code>
    /// </summary>
    public void End() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderDevice, void>)0x005502A0)(ref this);

    /// <summary>
    /// <code>Offset: 0x00550850
    /// void __thiscall RenderDevice::Begin(RenderDevice*)</code>
    /// </summary>
    public void Begin() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderDevice, void>)0x00550850)(ref this);

    /// <summary>
    /// <code>Offset: 0x00550AC0
    /// void __thiscall RenderDevice::Shutdown(RenderDevice*)</code>
    /// </summary>
    public void Shutdown() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderDevice, void>)0x00550AC0)(ref this);

    /// <summary>
    /// <code>Offset: 0x0059EDE0
    /// void __thiscall RenderDevice::RenderDevice(RenderDevice*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderDevice, void>)0x0059EDE0)(ref this);

    /// <summary>
    /// <code>Offset: 0x0059EEC0
    /// bool __thiscall RenderDevice::IsResetPossible(RenderDevice*)</code>
    /// </summary>
    public byte IsResetPossible() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderDevice, byte>)0x0059EEC0)(ref this);

    /// <summary>
    /// <code>Offset: 0x0059EED0
    /// void __thiscall RenderDevice::~RenderDevice(RenderDevice*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderDevice, void>)0x0059EED0)(ref this);
}

