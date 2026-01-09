namespace ACBindings;

// RenderDevice
public unsafe struct RenderDevice : System.IDisposable
{
    // Child Types
    // RenderDevice_vtbl
    public unsafe struct RenderDevice_vtbl
    {
        // Members
        public System.IntPtr RenderDevice_dtor_0; // function pointer
        public System.IntPtr Startup; // function pointer
        public System.IntPtr Shutdown; // function pointer
        public System.IntPtr CreateLocalSurface; // function pointer
        public System.IntPtr CreateSurface; // function pointer
        public System.IntPtr CreateTexture; // function pointer
        public System.IntPtr CreateIndexBuffer; // function pointer
        public System.IntPtr CreateVertexBuffer;
        public System.IntPtr BeginScene; // function pointer
        public System.IntPtr EndScene; // function pointer
        public System.IntPtr Flip; // function pointer
        public System.IntPtr Clear; // function pointer
        public System.IntPtr IsResetPossible; // function pointer
        public System.IntPtr SetRenderTarget; // function pointer
        public System.IntPtr ResetDevice; // function pointer
        public System.IntPtr GenerateSurfaceFromFrontBuffer; // function pointer
        public System.IntPtr SetViewport; // function pointer
        public System.IntPtr SetLandscape; // function pointer
        public System.IntPtr DrawInside; // function pointer
        public System.IntPtr DrawPortal; // function pointer
        public System.IntPtr DrawBlock; // function pointer
        public System.IntPtr DrawLandCell; // function pointer
        public System.IntPtr DrawSortCell; // function pointer
        public System.IntPtr DrawEnvCell; // function pointer
        public System.IntPtr DrawObjCell; // function pointer
        public System.IntPtr DrawObjCellForDummies; // function pointer
        public System.IntPtr DrawBuilding; // function pointer
        public System.IntPtr DrawBuildingLeaf; // function pointer
        public System.IntPtr DrawMesh; // function pointer
        public System.IntPtr DrawDetailMesh; // function pointer

        // Methods
    }
    // RenderDevice::GraphicsStatesType
    public unsafe struct GraphicsStatesType
    {
        // Members
        public ACBindings.Matrix4 ModelToWorldMatrix;
        public ACBindings.Matrix4 WorldToViewMatrix;
        public ACBindings.Matrix4 ViewToClipMatrix;
        public ACBindings.RGBAColor AmbientLight;
        public ACBindings.RGBAColor DistanceFogColor;
        public float DistanceFogNear;
        public float DistanceFogFar;
        public float DistantSpriteOpacityNear;
        public float DistantSpriteOpacityRange;
        public float OpacityFogNearDistance;
        public float OpacityFogRange;
        public ACBindings.RenderLight* pMPLightSource;
        public ACBindings.RenderTexture* pMPLightProjectorTexture;
        public ACBindings.SmartArray__RenderLight FFLightSources;
        public byte ChangedFFLightSources;
        public ACBindings.RGBAColor FrameBufferBloomRGBAmount;
        public fixed byte PixelFilterTexCoords_Raw[240];
        public ACBindings.Vector4* PixelFilterTexCoords => (ACBindings.Vector4*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref PixelFilterTexCoords_Raw[0]);
        public ACBindings.Vector4 BSVLightOriginAndExtrusionOffset;
        public float FrameBufferViewportOffsetX;
        public float FrameBufferViewportOffsetY;
        public float FrameBufferViewportScaleX;
        public float FrameBufferViewportScaleY;

        // Generated Constructor
        public GraphicsStatesType() {
            _ConstructorInternal();
        }

        // Methods
        // void __thiscall RenderDevice::GraphicsStatesType::GraphicsStatesType(RenderDevice::GraphicsStatesType*)
        public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.RenderDevice.GraphicsStatesType, void>)0x00550150)(ref this);
    }

    // Members
    public System.IntPtr __vftable; // vtable pointer
    public ACBindings.RenderDevicePresentation m_presentation;
    public ACBindings.RenderDeviceConfig m_config;
    public ACBindings.RenderDeviceCaps m_caps;
    public ACBindings.RenderDeviceDisplayInfo m_displayInfo;
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
    public ACBindings.RenderSurface* m_pFrameBufferSurface;
    public ACBindings.RenderSurface* m_pDepthStencilSurface;
    public ACBindings.RenderSurface* m_pRenderTarget;
    public ACBindings.RenderSurface* m_pDepthStencilTarget;
    public byte m_WireframeMode;
    public byte m_ReverseCulling;
    public ACBindings.RenderDevice.GraphicsStatesType m_GState;
    public ACBindings.TextureBasedFont* m_pDebugFont;
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
    // void __thiscall RenderDevice::ReleaseSurfaceResources(RenderDevice*)
    public void ReleaseSurfaceResources() => ((delegate* unmanaged[Thiscall]<ref ACBindings.RenderDevice, void>)0x0054FCC0)(ref this);
    // unsigned int __thiscall RenderDevice::GetDisplayWidth(RenderDevice*)
    public uint GetDisplayWidth() => ((delegate* unmanaged[Thiscall]<ref ACBindings.RenderDevice, uint>)0x0054FD20)(ref this);
    // unsigned int __thiscall RenderDevice::GetDisplayHeight(RenderDevice*)
    public uint GetDisplayHeight() => ((delegate* unmanaged[Thiscall]<ref ACBindings.RenderDevice, uint>)0x0054FD30)(ref this);
    // RenderSurface* __thiscall RenderDevice::CreateLocalSurface(RenderDevice*)
    public ACBindings.RenderSurface* CreateLocalSurface() => ((delegate* unmanaged[Thiscall]<ref ACBindings.RenderDevice, ACBindings.RenderSurface*>)0x0054FD40)(ref this);
    // float __thiscall RenderDevice::ComputeAspectForViewport(RenderDevice*,unsigned int,unsigned int,unsigned int,unsigned int,bool)
    public float ComputeAspectForViewport(uint x, uint y, uint width, uint height, byte UseAutoAspect) => ((delegate* unmanaged[Thiscall]<ref ACBindings.RenderDevice, uint, uint, uint, uint, byte, float>)0x0054FD60)(ref this, x, y, width, height, UseAutoAspect);
    // void __thiscall RenderDevice::SetViewport(RenderDevice*,unsigned int,unsigned int,unsigned int,unsigned int,bool)
    public void SetViewport(uint x, uint y, uint width, uint height, byte UseAutoAspect) => ((delegate* unmanaged[Thiscall]<ref ACBindings.RenderDevice, uint, uint, uint, uint, byte, void>)0x0054FDD0)(ref this, x, y, width, height, UseAutoAspect);
    // bool __thiscall RenderDevice::Startup(RenderDevice*,const unsigned int,const RenderDevicePresentation*,const RenderDeviceConfig*)
    public byte Startup(uint nDisplayAdapter, ACBindings.RenderDevicePresentation* presentation, ACBindings.RenderDeviceConfig* config) => ((delegate* unmanaged[Thiscall]<ref ACBindings.RenderDevice, uint, ACBindings.RenderDevicePresentation*, ACBindings.RenderDeviceConfig*, byte>)0x0054FE50)(ref this, nDisplayAdapter, presentation, config);
    // PixelFormatID __thiscall RenderDevice::GetUISurfaceFormat(RenderDevice*)
    public ACBindings.PixelFormatID GetUISurfaceFormat() => ((delegate* unmanaged[Thiscall]<ref ACBindings.RenderDevice, ACBindings.PixelFormatID>)0x0054FE80)(ref this);
    // void __thiscall RenderDevice::End(RenderDevice*)
    public void End() => ((delegate* unmanaged[Thiscall]<ref ACBindings.RenderDevice, void>)0x005502A0)(ref this);
    // void __thiscall RenderDevice::Begin(RenderDevice*)
    public void Begin() => ((delegate* unmanaged[Thiscall]<ref ACBindings.RenderDevice, void>)0x00550850)(ref this);
    // void __thiscall RenderDevice::Shutdown(RenderDevice*)
    public void Shutdown() => ((delegate* unmanaged[Thiscall]<ref ACBindings.RenderDevice, void>)0x00550AC0)(ref this);
    // void __thiscall RenderDevice::RenderDevice(RenderDevice*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.RenderDevice, void>)0x0059EDE0)(ref this);
    // bool __thiscall RenderDevice::IsResetPossible(RenderDevice*)
    public byte IsResetPossible() => ((delegate* unmanaged[Thiscall]<ref ACBindings.RenderDevice, byte>)0x0059EEC0)(ref this);
    // void __thiscall RenderDevice::~RenderDevice(RenderDevice*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.RenderDevice, void>)0x0059EED0)(ref this);
}

