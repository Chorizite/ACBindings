namespace ACBindings.Internal;

public unsafe struct RenderDeviceD3D
{
    // Base Classes
    public ACBindings.Internal.RenderDevice BaseClass_RenderDevice; // ACBindings.Internal.RenderDevice

    // Statics
    public static int* building_view = (int*)0x00821E54;
    public static int* backup_building_view = (int*)0x00821E58;
    public static ACBindings.Internal.PView* indoor_pview = (ACBindings.Internal.PView*)0x008EE3CC;
    public static ACBindings.Internal.PView* outdoor_pview = (ACBindings.Internal.PView*)0x008EE3D0;
    public static int* ObjBuildingOrBuildingPart = (int*)0x008EE3D4;
    public static ACBindings.Internal.CPhysicsPart* s_current_physics_part = (ACBindings.Internal.CPhysicsPart*)0x008EE3D8;

    // Child Types
    public unsafe struct RenderDeviceD3D_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.RenderDeviceD3D*, void> RenderDeviceD3D_dtor_0; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.RenderDeviceD3D*, uint, ACBindings.Internal.RenderDevicePresentation*, ACBindings.Internal.RenderDeviceConfig*, byte> Startup; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.RenderDeviceD3D*, void> Shutdown; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.RenderDeviceD3D*, ACBindings.Internal.RenderSurface*> CreateLocalSurface; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.RenderDeviceD3D*, ACBindings.Internal.RenderSurface*> CreateSurface; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.RenderDeviceD3D*, ACBindings.Internal.RenderTexture*> CreateTexture; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.RenderDeviceD3D*, ACBindings.Internal.RenderIndexBuffer*> CreateIndexBuffer; // function pointer
        public System.IntPtr CreateVertexBuffer;
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.RenderDeviceD3D*, void> BeginScene; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.RenderDeviceD3D*, void> EndScene; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.RenderDeviceD3D*, void> Flip; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.RenderDeviceD3D*, uint, ACBindings.Internal.RGBAColor*, float, void> Clear; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.RenderDeviceD3D*, byte> IsResetPossible; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.RenderDeviceD3D*, uint, ACBindings.Internal.RenderSurface*, ACBindings.Internal.RenderSurface*, void> SetRenderTarget; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.RenderDeviceD3D*, ACBindings.Internal.RenderDevicePresentation*, byte> ResetDevice; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.RenderDeviceD3D*, ACBindings.Internal.RenderSurface*> GenerateSurfaceFromFrontBuffer; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.RenderDeviceD3D*, uint, uint, uint, uint, byte, void> SetViewport; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.RenderDeviceD3D*, ACBindings.Internal.LScape*, void> SetLandscape; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.RenderDeviceD3D*, ACBindings.Internal.CEnvCell*, void> DrawInside; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.RenderDeviceD3D*, ACBindings.Internal.CPortalPoly*, int, int, void> DrawPortal; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.RenderDeviceD3D*, ACBindings.Internal.CLandBlock*, void> DrawBlock; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.RenderDeviceD3D*, ACBindings.Internal.CLandCell*, void> DrawLandCell; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.RenderDeviceD3D*, ACBindings.Internal.CSortCell*, void> DrawSortCell; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.RenderDeviceD3D*, ACBindings.Internal.CEnvCell*, void> DrawEnvCell; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.RenderDeviceD3D*, ACBindings.Internal.CObjCell*, void> DrawObjCell; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.RenderDeviceD3D*, ACBindings.Internal.CObjCell*, void> DrawObjCellForDummies; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.RenderDeviceD3D*, ACBindings.Internal.CBuildingObj*, void> DrawBuilding; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.RenderDeviceD3D*, uint, void> DrawBuildingLeaf; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.RenderDeviceD3D*, ACBindings.Internal.CGfxObj*, ACBindings.Internal.Position*, byte, ACBindings.Internal.ObjectDrawStatus> DrawMesh; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.RenderDeviceD3D*, ACBindings.Internal.CGfxObj*, ACBindings.Internal.Position*, void> DrawDetailMesh; // function pointer

        // Methods
    }

    // Members
    public uint m_AdapterID;
    public ACBindings.Internal._D3DDEVTYPE m_D3DDeviceType;
    public ACBindings.Internal._D3DCAPS9 m_D3DCaps;
    public ACBindings.Internal.tagRECT m_PresentSourceRect;
    public ACBindings.Internal.tagRECT m_PresentDestRect;
    public int* m_hPresentWindow;
    public uint m_nFrontBufferWidth;
    public uint m_nFrontBufferHeight;
    public System.IntPtr m_pDirect3DDevice;
    public System.IntPtr m_pPrimarySwapChain;
    public byte m_bForceStates;
    public ACBindings.Internal.RenderStateCacheType m_State;
    public byte m_bMaterialAlphaMode;
    public ACBindings.Internal._D3DMATERIAL9* m_pD3DCurrMaterial;
    public ACBindings.Internal._D3DMATERIAL9 m_defaultMaterial;
    public byte m_currentlyDrawingSky;
    public ACBindings.Internal.CMaterial* m_pCurrMaterial;
    public System.IntPtr m_primitiveVbuf;
    public System.IntPtr m_pSolidColorTexture;
    public uint m_currentSolidColor;
    public float m_gammaBrightnessVal;
    public byte m_ParticleState;
    public ACBindings.Internal.SmartArray__uint m_DefaultSamplerMappings;
    public ACBindings.Internal.TextureBasedFont* m_pDebugFont;
    public uint m_DebugFontWidth;
    public uint m_DebugFontHeight;
    public uint m_TotalVideoMemoryInBytes;

    // Methods

    /// <summary>
    /// <code>Offset: 0x005A00C0
    /// int __thiscall RenderDeviceD3D::Init(RenderDeviceD3D*)</code>
    /// </summary>
    public int Init() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderDeviceD3D, int>)0x005A00C0)(ref this);

    /// <summary>
    /// <code>Offset: 0x005A01D0
    /// void __thiscall RenderDeviceD3D::SetLandscape(RenderDeviceD3D*,LScape*)</code>
    /// </summary>
    public void SetLandscape(ACBindings.Internal.LScape* lscape) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderDeviceD3D, ACBindings.Internal.LScape*, void>)0x005A01D0)(ref this, lscape);

    /// <summary>
    /// <code>Offset: 0x005A01E0
    /// void __thiscall RenderDeviceD3D::DrawInside(RenderDeviceD3D*,CEnvCell*)</code>
    /// </summary>
    public void DrawInside(ACBindings.Internal.CEnvCell* cell) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderDeviceD3D, ACBindings.Internal.CEnvCell*, void>)0x005A01E0)(ref this, cell);

    /// <summary>
    /// <code>Offset: 0x005A01F0
    /// void __thiscall RenderDeviceD3D::DrawPortal(RenderDeviceD3D*,CPortalPoly*,int,int)</code>
    /// </summary>
    public void DrawPortal(ACBindings.Internal.CPortalPoly* portal, int check, int portalPolyOrPortalContents) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderDeviceD3D, ACBindings.Internal.CPortalPoly*, int, int, void>)0x005A01F0)(ref this, portal, check, portalPolyOrPortalContents);

    /// <summary>
    /// <code>Offset: 0x005A0230
    /// void __thiscall RenderDeviceD3D::DrawLandCell(RenderDeviceD3D*,CLandCell*)</code>
    /// </summary>
    public void DrawLandCell(ACBindings.Internal.CLandCell* cell) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderDeviceD3D, ACBindings.Internal.CLandCell*, void>)0x005A0230)(ref this, cell);

    /// <summary>
    /// <code>Offset: 0x005A0250
    /// void __thiscall RenderDeviceD3D::DrawSortCell(RenderDeviceD3D*,CSortCell*)</code>
    /// </summary>
    public void DrawSortCell(ACBindings.Internal.CSortCell* cell) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderDeviceD3D, ACBindings.Internal.CSortCell*, void>)0x005A0250)(ref this, cell);

    /// <summary>
    /// <code>Offset: 0x005A0280
    /// void __thiscall RenderDeviceD3D::DrawEnvCell(RenderDeviceD3D*,CEnvCell*)</code>
    /// </summary>
    public void DrawEnvCell(ACBindings.Internal.CEnvCell* cell) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderDeviceD3D, ACBindings.Internal.CEnvCell*, void>)0x005A0280)(ref this, cell);

    /// <summary>
    /// <code>Offset: 0x005A03B0
    /// void __thiscall RenderDeviceD3D::DrawBuilding(RenderDeviceD3D*,CBuildingObj*)</code>
    /// </summary>
    public void DrawBuilding(ACBindings.Internal.CBuildingObj* building) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderDeviceD3D, ACBindings.Internal.CBuildingObj*, void>)0x005A03B0)(ref this, building);

    /// <summary>
    /// <code>Offset: 0x005A0470
    /// ObjectDrawStatus __thiscall RenderDeviceD3D::DrawMeshInternal(RenderDeviceD3D*,CGfxObj*,bool,BoundingType)</code>
    /// </summary>
    public ACBindings.Internal.ObjectDrawStatus DrawMeshInternal(ACBindings.Internal.CGfxObj* i_pObj, byte i_bBuilding, ACBindings.Internal.BoundingType i_bt) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderDeviceD3D, ACBindings.Internal.CGfxObj*, byte, ACBindings.Internal.BoundingType, ACBindings.Internal.ObjectDrawStatus>)0x005A0470)(ref this, i_pObj, i_bBuilding, i_bt);

    /// <summary>
    /// <code>Offset: 0x005A0520
    /// RenderSurface* __thiscall RenderDeviceD3D::CreateSurface(RenderDeviceD3D*)</code>
    /// </summary>
    public ACBindings.Internal.RenderSurface* CreateSurface() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderDeviceD3D, ACBindings.Internal.RenderSurface*>)0x005A0520)(ref this);

    /// <summary>
    /// <code>Offset: 0x005A0540
    /// RenderTexture* __thiscall RenderDeviceD3D::CreateTexture(RenderDeviceD3D*)</code>
    /// </summary>
    public ACBindings.Internal.RenderTexture* CreateTexture() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderDeviceD3D, ACBindings.Internal.RenderTexture*>)0x005A0540)(ref this);

    /// <summary>
    /// <code>Offset: 0x005A0560
    /// RenderIndexBuffer* __thiscall RenderDeviceD3D::CreateIndexBuffer(RenderDeviceD3D*)</code>
    /// </summary>
    public ACBindings.Internal.RenderIndexBuffer* CreateIndexBuffer() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderDeviceD3D, ACBindings.Internal.RenderIndexBuffer*>)0x005A0560)(ref this);

    /// <summary>
    /// <code>Offset: 0x005A05A0
    /// void __thiscall RenderDeviceD3D::SetVertexStream(RenderDeviceD3D*,const unsigned int,RenderVertexStreamD3D*)</code>
    /// </summary>
    public void SetVertexStream(uint StreamIndex, ACBindings.Internal.RenderVertexStreamD3D* pStream) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderDeviceD3D, uint, ACBindings.Internal.RenderVertexStreamD3D*, void>)0x005A05A0)(ref this, StreamIndex, pStream);

    /// <summary>
    /// <code>Offset: 0x005A05E0
    /// bool __thiscall RenderDeviceD3D::IsResetPossible(RenderDeviceD3D*)</code>
    /// </summary>
    public byte IsResetPossible() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderDeviceD3D, byte>)0x005A05E0)(ref this);

    /// <summary>
    /// <code>Offset: 0x005A0610
    /// void __thiscall RenderDeviceD3D::ApplyVertexFormat(RenderDeviceD3D*,const VertexFormatInfo*)</code>
    /// </summary>
    public void ApplyVertexFormat(ACBindings.Internal.VertexFormatInfo* VFI) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderDeviceD3D, ACBindings.Internal.VertexFormatInfo*, void>)0x005A0610)(ref this, VFI);

    /// <summary>
    /// <code>Offset: 0x005A0630
    /// bool __thiscall RenderDeviceD3D::DetectDeviceCaps(RenderDeviceD3D*)</code>
    /// </summary>
    public byte DetectDeviceCaps() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderDeviceD3D, byte>)0x005A0630)(ref this);

    /// <summary>
    /// <code>Offset: 0x005A0800
    /// void __thiscall RenderDeviceD3D::SetViewport(RenderDeviceD3D*,unsigned int,unsigned int,unsigned int,unsigned int,bool)</code>
    /// </summary>
    public void SetViewport(uint x, uint y, uint width, uint height, byte i_UseAutoAspect) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderDeviceD3D, uint, uint, uint, uint, byte, void>)0x005A0800)(ref this, x, y, width, height, i_UseAutoAspect);

    /// <summary>
    /// <code>Offset: 0x005A0880
    /// PixelFormatID __thiscall RenderDeviceD3D::SelectPixelFormat(RenderDeviceD3D*,const PixelFormatID,const unsigned int,const _D3DRESOURCETYPE,const bool,const unsigned __int8*,const unsigned int)</code>
    /// </summary>
    public ACBindings.Internal.PixelFormatID SelectPixelFormat(ACBindings.Internal.PixelFormatID displayFormat, uint usage, ACBindings.Internal._D3DRESOURCETYPE resource, byte use32, byte* formats, uint numFormats) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderDeviceD3D, ACBindings.Internal.PixelFormatID, uint, ACBindings.Internal._D3DRESOURCETYPE, byte, byte*, uint, ACBindings.Internal.PixelFormatID>)0x005A0880)(ref this, displayFormat, usage, resource, use32, formats, numFormats);

    /// <summary>
    /// <code>Offset: 0x005A0980
    /// bool __thiscall RenderDeviceD3D::ChoosePixelFormats(RenderDeviceD3D*,const PixelFormatID)</code>
    /// </summary>
    public byte ChoosePixelFormats(ACBindings.Internal.PixelFormatID displayFormat) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderDeviceD3D, ACBindings.Internal.PixelFormatID, byte>)0x005A0980)(ref this, displayFormat);

    /// <summary>
    /// <code>Offset: 0x005A0BC0
    /// bool __thiscall RenderDeviceD3D::CheckDisplayModes(RenderDeviceD3D*,const PixelFormatID,const unsigned int,unsigned int*)</code>
    /// </summary>
    public byte CheckDisplayModes(ACBindings.Internal.PixelFormatID displayFormat, uint DesiredRefreshRate, uint* optimalRefreshRate) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderDeviceD3D, ACBindings.Internal.PixelFormatID, uint, uint*, byte>)0x005A0BC0)(ref this, displayFormat, DesiredRefreshRate, optimalRefreshRate);

    /// <summary>
    /// <code>Offset: 0x005A0C80
    /// void __thiscall RenderDeviceD3D::ReleaseD3DResources(RenderDeviceD3D*)</code>
    /// </summary>
    public void ReleaseD3DResources() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderDeviceD3D, void>)0x005A0C80)(ref this);

    /// <summary>
    /// <code>Offset: 0x005A0CE0
    /// void __thiscall RenderDeviceD3D::SetupDisplayAspectRatio(RenderDeviceD3D*)</code>
    /// </summary>
    public void SetupDisplayAspectRatio() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderDeviceD3D, void>)0x005A0CE0)(ref this);

    /// <summary>
    /// <code>Offset: 0x005A0D60
    /// void __thiscall RenderDeviceD3D::SetMipmapLODBiasForAllSamplers(RenderDeviceD3D*,const float)</code>
    /// </summary>
    public void SetMipmapLODBiasForAllSamplers(float Bias) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderDeviceD3D, float, void>)0x005A0D60)(ref this, Bias);

    /// <summary>
    /// <code>Offset: 0x005A0D90
    /// void __thiscall RenderDeviceD3D::BeginScene(RenderDeviceD3D*)</code>
    /// </summary>
    public void BeginScene() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderDeviceD3D, void>)0x005A0D90)(ref this);

    /// <summary>
    /// <code>Offset: 0x005A0E10
    /// void __thiscall RenderDeviceD3D::EndScene(RenderDeviceD3D*)</code>
    /// </summary>
    public void EndScene() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderDeviceD3D, void>)0x005A0E10)(ref this);

    /// <summary>
    /// <code>Offset: 0x005A0E40
    /// void __thiscall RenderDeviceD3D::Clear(RenderDeviceD3D*,unsigned int,const RGBAColor*,const float)</code>
    /// </summary>
    public void Clear(uint clearFlags, ACBindings.Internal.RGBAColor* color, float depth) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderDeviceD3D, uint, ACBindings.Internal.RGBAColor*, float, void>)0x005A0E40)(ref this, clearFlags, color, depth);

    /// <summary>
    /// <code>Offset: 0x005A0F60
    /// void __thiscall RenderDeviceD3D::Flip(RenderDeviceD3D*)</code>
    /// </summary>
    public void Flip() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderDeviceD3D, void>)0x005A0F60)(ref this);

    /// <summary>
    /// <code>Offset: 0x005A0FF0
    /// void __thiscall RenderDeviceD3D::SetCurrentMaterial(RenderDeviceD3D*,const CMaterial*,bool)</code>
    /// </summary>
    public void SetCurrentMaterial(ACBindings.Internal.CMaterial* material, byte force) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderDeviceD3D, ACBindings.Internal.CMaterial*, byte, void>)0x005A0FF0)(ref this, material, force);

    /// <summary>
    /// <code>Offset: 0x005A1080
    /// bool __thiscall RenderDeviceD3D::SetSolidColorTextureColor(RenderDeviceD3D*,unsigned int,bool)</code>
    /// </summary>
    public byte SetSolidColorTextureColor(uint color, byte force) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderDeviceD3D, uint, byte, byte>)0x005A1080)(ref this, color, force);

    /// <summary>
    /// <code>Offset: 0x005A10F0
    /// bool __thiscall RenderDeviceD3D::SetDefaultDeviceStates(RenderDeviceD3D*)</code>
    /// </summary>
    public byte SetDefaultDeviceStates() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderDeviceD3D, byte>)0x005A10F0)(ref this);

    /// <summary>
    /// <code>Offset: 0x005A1260
    /// void __thiscall RenderDeviceD3D::SetRenderTarget(RenderDeviceD3D*,const unsigned int,RenderSurface*,RenderSurface*)</code>
    /// </summary>
    public void SetRenderTarget(uint Index, ACBindings.Internal.RenderSurface* pRenderTarget, ACBindings.Internal.RenderSurface* pDepthStencilTarget) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderDeviceD3D, uint, ACBindings.Internal.RenderSurface*, ACBindings.Internal.RenderSurface*, void>)0x005A1260)(ref this, Index, pRenderTarget, pDepthStencilTarget);

    /// <summary>
    /// <code>Offset: 0x005A1320
    /// RenderSurface* __thiscall RenderDeviceD3D::GenerateSurfaceFromFrontBuffer(RenderDeviceD3D*)</code>
    /// </summary>
    public ACBindings.Internal.RenderSurface* GenerateSurfaceFromFrontBuffer() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderDeviceD3D, ACBindings.Internal.RenderSurface*>)0x005A1320)(ref this);

    /// <summary>
    /// <code>Offset: 0x005A1390
    /// void __thiscall RenderDeviceD3D::EndRenderingDebugText(RenderDeviceD3D*)</code>
    /// </summary>
    public void EndRenderingDebugText() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderDeviceD3D, void>)0x005A1390)(ref this);

    /// <summary>
    /// <code>Offset: 0x005A13A0
    /// void __thiscall RenderDeviceD3D::RenderDebugText(RenderDeviceD3D*,const int,const int,const char*,const unsigned int)</code>
    /// </summary>
    public void RenderDebugText(int ViewportX, int ViewportY, sbyte* pText, uint Color32) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderDeviceD3D, int, int, sbyte*, uint, void>)0x005A13A0)(ref this, ViewportX, ViewportY, pText, Color32);

    /// <summary>
    /// <code>Offset: 0x005A13D0
    /// bool __thiscall RenderDeviceD3D::RenderPrimitivesInHardware(RenderDeviceD3D*,const PrimType,const unsigned int,RenderVertexStreamD3D*,const unsigned int,const unsigned int,const unsigned int)</code>
    /// </summary>
    public byte RenderPrimitivesInHardware(ACBindings.Internal.PrimType PrimType, uint NumPrimitives, ACBindings.Internal.RenderVertexStreamD3D* VertexStream, uint VertexStreamFrameID, uint FirstRemoteVertexIndex, uint NumVertices) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderDeviceD3D, ACBindings.Internal.PrimType, uint, ACBindings.Internal.RenderVertexStreamD3D*, uint, uint, uint, byte>)0x005A13D0)(ref this, PrimType, NumPrimitives, VertexStream, VertexStreamFrameID, FirstRemoteVertexIndex, NumVertices);

    /// <summary>
    /// <code>Offset: 0x005A1460
    /// bool __thiscall RenderDeviceD3D::RenderDynamicPrimitives(RenderDeviceD3D*,const PrimType,const unsigned int,const void*,const unsigned int)</code>
    /// </summary>
    public byte RenderDynamicPrimitives(ACBindings.Internal.PrimType PrimType, uint NumPrimitives, void* pVertices, uint VertexFormat) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderDeviceD3D, ACBindings.Internal.PrimType, uint, void*, uint, byte>)0x005A1460)(ref this, PrimType, NumPrimitives, pVertices, VertexFormat);

    /// <summary>
    /// <code>Offset: 0x005A1520
    /// HRESULT __cdecl RenderDeviceD3D::DrawPrimitiveUP(_D3DPRIMITIVETYPE,unsigned int,const void*,unsigned int)</code>
    /// </summary>
    public static int DrawPrimitiveUP(ACBindings.Internal._D3DPRIMITIVETYPE PrimitiveType, uint nNumPrimitives, void* pVertexStreamZeroData, uint VertexStreamZeroStride) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal._D3DPRIMITIVETYPE, uint, void*, uint, int>)0x005A1520)(PrimitiveType, nNumPrimitives, pVertexStreamZeroData, VertexStreamZeroStride);

    /// <summary>
    /// <code>Offset: 0x005A1560
    /// bool __thiscall RenderDeviceD3D::GetFFFogEnable(RenderDeviceD3D*)</code>
    /// </summary>
    public byte GetFFFogEnable() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderDeviceD3D, byte>)0x005A1560)(ref this);

    /// <summary>
    /// <code>Offset: 0x005A1570
    /// bool __thiscall RenderDeviceD3D::IsAvailableVideoMemoryLow(RenderDeviceD3D*)</code>
    /// </summary>
    public byte IsAvailableVideoMemoryLow() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderDeviceD3D, byte>)0x005A1570)(ref this);

    /// <summary>
    /// <code>Offset: 0x005A15B0
    /// void __thiscall RenderDeviceD3D::InvalidateCachedTexturePointer(RenderDeviceD3D*,void*)</code>
    /// </summary>
    public void InvalidateCachedTexturePointer(System.IntPtr pD3DTexture) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderDeviceD3D, System.IntPtr, void>)0x005A15B0)(ref this, pD3DTexture);

    /// <summary>
    /// <code>Offset: 0x005A15E0
    /// void __thiscall RenderDeviceD3D::InvalidateCachedVertexBufferPointer(RenderDeviceD3D*,void*)</code>
    /// </summary>
    public void InvalidateCachedVertexBufferPointer(System.IntPtr pD3DVertexBuffer) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderDeviceD3D, System.IntPtr, void>)0x005A15E0)(ref this, pD3DVertexBuffer);

    /// <summary>
    /// <code>Offset: 0x005A17A0
    /// void __thiscall RenderDeviceD3D::UpdateObjCell(RenderDeviceD3D*,CObjCell*)</code>
    /// </summary>
    public void UpdateObjCell(ACBindings.Internal.CObjCell* cell) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderDeviceD3D, ACBindings.Internal.CObjCell*, void>)0x005A17A0)(ref this, cell);

    /// <summary>
    /// <code>Offset: 0x005A1870
    /// void __thiscall RenderDeviceD3D::DrawObjCellForDummies(RenderDeviceD3D*,CObjCell*)</code>
    /// </summary>
    public void DrawObjCellForDummies(ACBindings.Internal.CObjCell* cell) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderDeviceD3D, ACBindings.Internal.CObjCell*, void>)0x005A1870)(ref this, cell);

    /// <summary>
    /// <code>Offset: 0x005A18B0
    /// void __thiscall RenderDeviceD3D::DrawPartCell(RenderDeviceD3D*,unsigned int,CPartCell*,unsigned int)</code>
    /// </summary>
    public void DrawPartCell(uint cellID, ACBindings.Internal.CPartCell* cell, uint leaf_index) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderDeviceD3D, uint, ACBindings.Internal.CPartCell*, uint, void>)0x005A18B0)(ref this, cellID, cell, leaf_index);

    /// <summary>
    /// <code>Offset: 0x005A18F0
    /// void __thiscall RenderDeviceD3D::DrawBuildingLeaf(RenderDeviceD3D*,unsigned int)</code>
    /// </summary>
    public void DrawBuildingLeaf(uint leaf_index) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderDeviceD3D, uint, void>)0x005A18F0)(ref this, leaf_index);

    /// <summary>
    /// <code>Offset: 0x005A1970
    /// ObjectDrawStatus __thiscall RenderDeviceD3D::DrawMesh(RenderDeviceD3D*,CGfxObj*,const Position*,bool)</code>
    /// </summary>
    public ACBindings.Internal.ObjectDrawStatus DrawMesh(ACBindings.Internal.CGfxObj* i_pObj, ACBindings.Internal.Position* i_posObj, byte i_bBuilding) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderDeviceD3D, ACBindings.Internal.CGfxObj*, ACBindings.Internal.Position*, byte, ACBindings.Internal.ObjectDrawStatus>)0x005A1970)(ref this, i_pObj, i_posObj, i_bBuilding);

    /// <summary>
    /// <code>Offset: 0x005A1B40
    /// bool __thiscall RenderDeviceD3D::GetD3DResources(RenderDeviceD3D*)</code>
    /// </summary>
    public byte GetD3DResources() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderDeviceD3D, byte>)0x005A1B40)(ref this);

    /// <summary>
    /// <code>Offset: 0x005A1C80
    /// void __thiscall RenderDeviceD3D::SetGamma(RenderDeviceD3D*,const float,const bool)</code>
    /// </summary>
    public void SetGamma(float fBrightness, byte bWantCalibration) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderDeviceD3D, float, byte, void>)0x005A1C80)(ref this, fBrightness, bWantCalibration);

    /// <summary>
    /// <code>Offset: 0x005A1D80
    /// void __thiscall RenderDeviceD3D::SetupState(RenderDeviceD3D*,const MaterialLayer*,const MaterialLayer*,const unsigned int,const RGBAColor*,const RGBAColor*,const bool)</code>
    /// </summary>
    public void SetupState(ACBindings.Internal.MaterialLayer* pReferenceLayer, ACBindings.Internal.MaterialLayer* pLayer, uint VertexFormat, ACBindings.Internal.RGBAColor* DiffuseColorScale, ACBindings.Internal.RGBAColor* AmbientLightBoost, byte ForceTranslucent) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderDeviceD3D, ACBindings.Internal.MaterialLayer*, ACBindings.Internal.MaterialLayer*, uint, ACBindings.Internal.RGBAColor*, ACBindings.Internal.RGBAColor*, byte, void>)0x005A1D80)(ref this, pReferenceLayer, pLayer, VertexFormat, DiffuseColorScale, AmbientLightBoost, ForceTranslucent);

    /// <summary>
    /// <code>Offset: 0x005A2620
    /// bool __thiscall RenderDeviceD3D::InitDebugFont(RenderDeviceD3D*)</code>
    /// </summary>
    public byte InitDebugFont() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderDeviceD3D, byte>)0x005A2620)(ref this);

    /// <summary>
    /// <code>Offset: 0x005A26A0
    /// void __thiscall RenderDeviceD3D::BeginRenderingDebugText(RenderDeviceD3D*)</code>
    /// </summary>
    public void BeginRenderingDebugText() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderDeviceD3D, void>)0x005A26A0)(ref this);

    /// <summary>
    /// <code>Offset: 0x005A26D0
    /// bool __thiscall RenderDeviceD3D::RenderDynamicPrimitivesUsingMaterial(RenderDeviceD3D*,const PrimType,const unsigned int,const void*,const unsigned int,const RenderMaterial*,const RenderMaterial*,const RGBAColor*)</code>
    /// </summary>
    public byte RenderDynamicPrimitivesUsingMaterial(ACBindings.Internal.PrimType PrimType, uint NumPrimitives, void* pVertices, uint VertexFormat, ACBindings.Internal.RenderMaterial* ReferenceMaterial, ACBindings.Internal.RenderMaterial* Material, ACBindings.Internal.RGBAColor* Color) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderDeviceD3D, ACBindings.Internal.PrimType, uint, void*, uint, ACBindings.Internal.RenderMaterial*, ACBindings.Internal.RenderMaterial*, ACBindings.Internal.RGBAColor*, byte>)0x005A26D0)(ref this, PrimType, NumPrimitives, pVertices, VertexFormat, ReferenceMaterial, Material, Color);

    /// <summary>
    /// <code>Offset: 0x005A28D0
    /// void __thiscall RenderDeviceD3D::DrawBlock(RenderDeviceD3D*,CLandBlock*)</code>
    /// </summary>
    public void DrawBlock(ACBindings.Internal.CLandBlock* block) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderDeviceD3D, ACBindings.Internal.CLandBlock*, void>)0x005A28D0)(ref this, block);

    /// <summary>
    /// <code>Offset: 0x005A2B50
    /// void __thiscall RenderDeviceD3D::DrawObjCell(RenderDeviceD3D*,CObjCell*)</code>
    /// </summary>
    public void DrawObjCell(ACBindings.Internal.CObjCell* cell) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderDeviceD3D, ACBindings.Internal.CObjCell*, void>)0x005A2B50)(ref this, cell);

    /// <summary>
    /// <code>Offset: 0x005A2B80
    /// RenderVertexBufferD3D* __thiscall RenderDeviceD3D::CreateVertexBuffer(RenderDeviceD3D*)</code>
    /// </summary>
    public ACBindings.Internal.RenderVertexBufferD3D* CreateVertexBuffer() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderDeviceD3D, ACBindings.Internal.RenderVertexBufferD3D*>)0x005A2B80)(ref this);

    /// <summary>
    /// <code>Offset: 0x005A2BA0
    /// void __thiscall RenderDeviceD3D::OnDeviceDisplayModeChange(RenderDeviceD3D*)</code>
    /// </summary>
    public void OnDeviceDisplayModeChange() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderDeviceD3D, void>)0x005A2BA0)(ref this);

    /// <summary>
    /// <code>Offset: 0x005A2C50
    /// void __thiscall RenderDeviceD3D::End(RenderDeviceD3D*)</code>
    /// </summary>
    public void End() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderDeviceD3D, void>)0x005A2C50)(ref this);

    /// <summary>
    /// <code>Offset: 0x005A2CF0
    /// bool __thiscall RenderDeviceD3D::DetectDisplayFormats(RenderDeviceD3D*,const PixelFormatID)</code>
    /// </summary>
    public byte DetectDisplayFormats(ACBindings.Internal.PixelFormatID displayFormat) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderDeviceD3D, ACBindings.Internal.PixelFormatID, byte>)0x005A2CF0)(ref this, displayFormat);

    /// <summary>
    /// <code>Offset: 0x005A2DF0
    /// bool __thiscall RenderDeviceD3D::SetupDisplayInfo(RenderDeviceD3D*,const PixelFormatID,const PixelFormatID,const PixelFormatID,const bool,const bool)</code>
    /// </summary>
    public byte SetupDisplayInfo(ACBindings.Internal.PixelFormatID displayFormat, ACBindings.Internal.PixelFormatID colorFormat, ACBindings.Internal.PixelFormatID depthStencilFormat, byte has8BitStencil, byte bFullScreen) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderDeviceD3D, ACBindings.Internal.PixelFormatID, ACBindings.Internal.PixelFormatID, ACBindings.Internal.PixelFormatID, byte, byte, byte>)0x005A2DF0)(ref this, displayFormat, colorFormat, depthStencilFormat, has8BitStencil, bFullScreen);

    /// <summary>
    /// <code>Offset: 0x005A2EF0
    /// bool __thiscall RenderDeviceD3D::SelectBufferFormats(RenderDeviceD3D*,const RenderDevicePresentation*,PixelFormatID*,PixelFormatID*,unsigned int*)</code>
    /// </summary>
    public byte SelectBufferFormats(ACBindings.Internal.RenderDevicePresentation* renderPres, ACBindings.Internal.PixelFormatID* colorFormat, ACBindings.Internal.PixelFormatID* depthStencilFormat, uint* optimalRefreshRate) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderDeviceD3D, ACBindings.Internal.RenderDevicePresentation*, ACBindings.Internal.PixelFormatID*, ACBindings.Internal.PixelFormatID*, uint*, byte>)0x005A2EF0)(ref this, renderPres, colorFormat, depthStencilFormat, optimalRefreshRate);

    /// <summary>
    /// <code>Offset: 0x005A3310
    /// void __thiscall RenderDeviceD3D::Begin(RenderDeviceD3D*)</code>
    /// </summary>
    public void Begin() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderDeviceD3D, void>)0x005A3310)(ref this);

    /// <summary>
    /// <code>Offset: 0x005A3520
    /// void __thiscall RenderDeviceD3D::Shutdown(RenderDeviceD3D*)</code>
    /// </summary>
    public void Shutdown() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderDeviceD3D, void>)0x005A3520)(ref this);

    /// <summary>
    /// <code>Offset: 0x005A3560
    /// bool __thiscall RenderDeviceD3D::SetupPresentation(RenderDeviceD3D*,const RenderDevicePresentation*,_D3DPRESENT_PARAMETERS_*)</code>
    /// </summary>
    public byte SetupPresentation(ACBindings.Internal.RenderDevicePresentation* renderPres, System.IntPtr present) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderDeviceD3D, ACBindings.Internal.RenderDevicePresentation*, System.IntPtr, byte>)0x005A3560)(ref this, renderPres, present);

    /// <summary>
    /// <code>Offset: 0x005A3780
    /// bool __thiscall RenderDeviceD3D::ResetDevice(RenderDeviceD3D*,const RenderDevicePresentation*)</code>
    /// </summary>
    public byte ResetDevice(ACBindings.Internal.RenderDevicePresentation* newPres) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderDeviceD3D, ACBindings.Internal.RenderDevicePresentation*, byte>)0x005A3780)(ref this, newPres);

    /// <summary>
    /// <code>Offset: 0x005A3910
    /// bool __thiscall RenderDeviceD3D::Startup(RenderDeviceD3D*,const unsigned int,const RenderDevicePresentation*,const RenderDeviceConfig*)</code>
    /// </summary>
    public byte Startup(uint nDisplayAdapter, ACBindings.Internal.RenderDevicePresentation* presentation, ACBindings.Internal.RenderDeviceConfig* config) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderDeviceD3D, uint, ACBindings.Internal.RenderDevicePresentation*, ACBindings.Internal.RenderDeviceConfig*, byte>)0x005A3910)(ref this, nDisplayAdapter, presentation, config);

    /// <summary>
    /// <code>Offset: 0x005A3BA0
    /// void __thiscall RenderDeviceD3D::SetAlphaBlendEnable(RenderDeviceD3D*,const bool)</code>
    /// </summary>
    public void SetAlphaBlendEnable(byte bValue) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderDeviceD3D, byte, void>)0x005A3BA0)(ref this, bValue);

    /// <summary>
    /// <code>Offset: 0x005A3BE0
    /// void __thiscall RenderDeviceD3D::SetAlphaTestEnable(RenderDeviceD3D*,const bool)</code>
    /// </summary>
    public void SetAlphaTestEnable(byte bValue) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderDeviceD3D, byte, void>)0x005A3BE0)(ref this, bValue);

    /// <summary>
    /// <code>Offset: 0x005A3C20
    /// void __thiscall RenderDeviceD3D::SetAlphaTestFunction(RenderDeviceD3D*,const AlphaTestFunc)</code>
    /// </summary>
    public void SetAlphaTestFunction(ACBindings.Internal.AlphaTestFunc Value) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderDeviceD3D, ACBindings.Internal.AlphaTestFunc, void>)0x005A3C20)(ref this, Value);

    /// <summary>
    /// <code>Offset: 0x005A3C60
    /// void __thiscall RenderDeviceD3D::SetAlphaTestRef(RenderDeviceD3D*,const unsigned int)</code>
    /// </summary>
    public void SetAlphaTestRef(uint Value) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderDeviceD3D, uint, void>)0x005A3C60)(ref this, Value);

    /// <summary>
    /// <code>Offset: 0x005A3CA0
    /// void __thiscall RenderDeviceD3D::SetBlendFunction(RenderDeviceD3D*,const BlendMode,const BlendMode,const BlendOpType)</code>
    /// </summary>
    public void SetBlendFunction(ACBindings.Internal.BlendMode SourceFactor, ACBindings.Internal.BlendMode DestFactor, ACBindings.Internal.BlendOpType Op) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderDeviceD3D, ACBindings.Internal.BlendMode, ACBindings.Internal.BlendMode, ACBindings.Internal.BlendOpType, void>)0x005A3CA0)(ref this, SourceFactor, DestFactor, Op);

    /// <summary>
    /// <code>Offset: 0x005A3D80
    /// void __thiscall RenderDeviceD3D::SetCullMode(RenderDeviceD3D*,const CullModeType)</code>
    /// </summary>
    public void SetCullMode(ACBindings.Internal.CullModeType Value) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderDeviceD3D, ACBindings.Internal.CullModeType, void>)0x005A3D80)(ref this, Value);

    /// <summary>
    /// <code>Offset: 0x005A3DC0
    /// void __thiscall RenderDeviceD3D::SetDepthBias(RenderDeviceD3D*,const float)</code>
    /// </summary>
    public void SetDepthBias(float Value) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderDeviceD3D, float, void>)0x005A3DC0)(ref this, Value);

    /// <summary>
    /// <code>Offset: 0x005A3E00
    /// void __thiscall RenderDeviceD3D::SetDepthBufferEnable(RenderDeviceD3D*,const bool)</code>
    /// </summary>
    public void SetDepthBufferEnable(byte bValue) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderDeviceD3D, byte, void>)0x005A3E00)(ref this, bValue);

    /// <summary>
    /// <code>Offset: 0x005A3E20
    /// void __thiscall RenderDeviceD3D::SetDepthBufferMode(RenderDeviceD3D*,const DepthTestMode,const bool)</code>
    /// </summary>
    public void SetDepthBufferMode(ACBindings.Internal.DepthTestMode DepthTestMode, byte DepthWriteEnable) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderDeviceD3D, ACBindings.Internal.DepthTestMode, byte, void>)0x005A3E20)(ref this, DepthTestMode, DepthWriteEnable);

    /// <summary>
    /// <code>Offset: 0x005A3EB0
    /// void __thiscall RenderDeviceD3D::SetFFAmbientColor32(RenderDeviceD3D*,const unsigned int)</code>
    /// </summary>
    public void SetFFAmbientColor32(uint Value) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderDeviceD3D, uint, void>)0x005A3EB0)(ref this, Value);

    /// <summary>
    /// <code>Offset: 0x005A3EF0
    /// void __thiscall RenderDeviceD3D::SetFFDiffuseColorSource(RenderDeviceD3D*,const ColorSource)</code>
    /// </summary>
    public void SetFFDiffuseColorSource(ACBindings.Internal.ColorSource Value) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderDeviceD3D, ACBindings.Internal.ColorSource, void>)0x005A3EF0)(ref this, Value);

    /// <summary>
    /// <code>Offset: 0x005A3F40
    /// void __thiscall RenderDeviceD3D::SetFFAmbientColorSource(RenderDeviceD3D*,const ColorSource)</code>
    /// </summary>
    public void SetFFAmbientColorSource(ACBindings.Internal.ColorSource Value) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderDeviceD3D, ACBindings.Internal.ColorSource, void>)0x005A3F40)(ref this, Value);

    /// <summary>
    /// <code>Offset: 0x005A3F90
    /// void __thiscall RenderDeviceD3D::SetFFFogEnable(RenderDeviceD3D*,const bool)</code>
    /// </summary>
    public void SetFFFogEnable(byte bValue) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderDeviceD3D, byte, void>)0x005A3F90)(ref this, bValue);

    /// <summary>
    /// <code>Offset: 0x005A3FE0
    /// void __thiscall RenderDeviceD3D::SetFFFogSystemDisabled(RenderDeviceD3D*,const bool)</code>
    /// </summary>
    public void SetFFFogSystemDisabled(byte bValue) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderDeviceD3D, byte, void>)0x005A3FE0)(ref this, bValue);

    /// <summary>
    /// <code>Offset: 0x005A4010
    /// void __thiscall RenderDeviceD3D::SetFFFogUserDisabled(RenderDeviceD3D*,const bool)</code>
    /// </summary>
    public void SetFFFogUserDisabled(byte bValue) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderDeviceD3D, byte, void>)0x005A4010)(ref this, bValue);

    /// <summary>
    /// <code>Offset: 0x005A4040
    /// void __thiscall RenderDeviceD3D::SetFFFogAlphaDisabled(RenderDeviceD3D*,const bool)</code>
    /// </summary>
    public void SetFFFogAlphaDisabled(byte bValue) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderDeviceD3D, byte, void>)0x005A4040)(ref this, bValue);

    /// <summary>
    /// <code>Offset: 0x005A4080
    /// void __thiscall RenderDeviceD3D::SetFFFogProperties(RenderDeviceD3D*,const RGBAColor*,const float,const float)</code>
    /// </summary>
    public void SetFFFogProperties(ACBindings.Internal.RGBAColor* Color, float NearDistance, float FarDistance) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderDeviceD3D, ACBindings.Internal.RGBAColor*, float, float, void>)0x005A4080)(ref this, Color, NearDistance, FarDistance);

    /// <summary>
    /// <code>Offset: 0x005A41B0
    /// void __thiscall RenderDeviceD3D::SetFFFogProperties(RenderDeviceD3D*,const RGBAUnion*,const float,const float)</code>
    /// </summary>
    public void SetFFFogProperties(ACBindings.Internal.RGBAUnion* Color, float NearDistance, float FarDistance) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderDeviceD3D, ACBindings.Internal.RGBAUnion*, float, float, void>)0x005A41B0)(ref this, Color, NearDistance, FarDistance);

    /// <summary>
    /// <code>Offset: 0x005A41F0
    /// void __thiscall RenderDeviceD3D::SetFFLighting(RenderDeviceD3D*,const bool)</code>
    /// </summary>
    public void SetFFLighting(byte bValue) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderDeviceD3D, byte, void>)0x005A41F0)(ref this, bValue);

    /// <summary>
    /// <code>Offset: 0x005A4230
    /// void __thiscall RenderDeviceD3D::SetFFLightEnable(RenderDeviceD3D*,const unsigned int,const bool)</code>
    /// </summary>
    public void SetFFLightEnable(uint Index, byte bValue) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderDeviceD3D, uint, byte, void>)0x005A4230)(ref this, Index, bValue);

    /// <summary>
    /// <code>Offset: 0x005A4280
    /// void __thiscall RenderDeviceD3D::SetFFSpecularColorSource(RenderDeviceD3D*,const ColorSource)</code>
    /// </summary>
    public void SetFFSpecularColorSource(ACBindings.Internal.ColorSource Value) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderDeviceD3D, ACBindings.Internal.ColorSource, void>)0x005A4280)(ref this, Value);

    /// <summary>
    /// <code>Offset: 0x005A42D0
    /// void __thiscall RenderDeviceD3D::SetFFSpecularEnable(RenderDeviceD3D*,const bool)</code>
    /// </summary>
    public void SetFFSpecularEnable(byte bValue) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderDeviceD3D, byte, void>)0x005A42D0)(ref this, bValue);

    /// <summary>
    /// <code>Offset: 0x005A4310
    /// void __thiscall RenderDeviceD3D::SetFFEmissiveColorSource(RenderDeviceD3D*,const ColorSource)</code>
    /// </summary>
    public void SetFFEmissiveColorSource(ACBindings.Internal.ColorSource Value) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderDeviceD3D, ACBindings.Internal.ColorSource, void>)0x005A4310)(ref this, Value);

    /// <summary>
    /// <code>Offset: 0x005A4350
    /// void __thiscall RenderDeviceD3D::SetFFTextureFactor32(RenderDeviceD3D*,const unsigned int)</code>
    /// </summary>
    public void SetFFTextureFactor32(uint Value) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderDeviceD3D, uint, void>)0x005A4350)(ref this, Value);

    /// <summary>
    /// <code>Offset: 0x005A4390
    /// void __thiscall RenderDeviceD3D::SetFillMode(RenderDeviceD3D*,const FillModeType)</code>
    /// </summary>
    public void SetFillMode(ACBindings.Internal.FillModeType Value) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderDeviceD3D, ACBindings.Internal.FillModeType, void>)0x005A4390)(ref this, Value);

    /// <summary>
    /// <code>Offset: 0x005A43D0
    /// void __thiscall RenderDeviceD3D::SetMultiSampleAntialias(RenderDeviceD3D*,const bool)</code>
    /// </summary>
    public void SetMultiSampleAntialias(byte bValue) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderDeviceD3D, byte, void>)0x005A43D0)(ref this, bValue);

    /// <summary>
    /// <code>Offset: 0x005A4420
    /// void __thiscall RenderDeviceD3D::SetSamplerAddressMode(RenderDeviceD3D*,const unsigned int,const TexAddress,const TexAddress)</code>
    /// </summary>
    public void SetSamplerAddressMode(uint Sampler, ACBindings.Internal.TexAddress AddressModeU, ACBindings.Internal.TexAddress AddressModeV) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderDeviceD3D, uint, ACBindings.Internal.TexAddress, ACBindings.Internal.TexAddress, void>)0x005A4420)(ref this, Sampler, AddressModeU, AddressModeV);

    /// <summary>
    /// <code>Offset: 0x005A4460
    /// void __thiscall RenderDeviceD3D::SetSamplerFilterMode(RenderDeviceD3D*,const unsigned int,const TexFilterMode,const TexFilterMode,const TexFilterMode)</code>
    /// </summary>
    public void SetSamplerFilterMode(uint Sampler, ACBindings.Internal.TexFilterMode MagFilterMode, ACBindings.Internal.TexFilterMode MinFilterMode, ACBindings.Internal.TexFilterMode MipFilterMode) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderDeviceD3D, uint, ACBindings.Internal.TexFilterMode, ACBindings.Internal.TexFilterMode, ACBindings.Internal.TexFilterMode, void>)0x005A4460)(ref this, Sampler, MagFilterMode, MinFilterMode, MipFilterMode);

    /// <summary>
    /// <code>Offset: 0x005A4520
    /// void __thiscall RenderDeviceD3D::SetSamplerMipmapLODBias(RenderDeviceD3D*,const unsigned int,const float)</code>
    /// </summary>
    public void SetSamplerMipmapLODBias(uint Sampler, float Bias) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderDeviceD3D, uint, float, void>)0x005A4520)(ref this, Sampler, Bias);

    /// <summary>
    /// <code>Offset: 0x005A4550
    /// void __thiscall RenderDeviceD3D::SetStageFFAlphaSource(RenderDeviceD3D*,const unsigned int,const TextureOp,const unsigned int,const unsigned int)</code>
    /// </summary>
    public void SetStageFFAlphaSource(uint Stage, ACBindings.Internal.TextureOp AlphaOp, uint AlphaArg1, uint AlphaArg2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderDeviceD3D, uint, ACBindings.Internal.TextureOp, uint, uint, void>)0x005A4550)(ref this, Stage, AlphaOp, AlphaArg1, AlphaArg2);

    /// <summary>
    /// <code>Offset: 0x005A4610
    /// void __thiscall RenderDeviceD3D::SetStageFFColorSource(RenderDeviceD3D*,const unsigned int,const TextureOp,const unsigned int,const unsigned int)</code>
    /// </summary>
    public void SetStageFFColorSource(uint Stage, ACBindings.Internal.TextureOp ColorOp, uint ColorArg1, uint ColorArg2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderDeviceD3D, uint, ACBindings.Internal.TextureOp, uint, uint, void>)0x005A4610)(ref this, Stage, ColorOp, ColorArg1, ColorArg2);

    /// <summary>
    /// <code>Offset: 0x005A46C0
    /// void __thiscall RenderDeviceD3D::SetStageFFTexCoordIndex(RenderDeviceD3D*,const unsigned int,const unsigned int)</code>
    /// </summary>
    public void SetStageFFTexCoordIndex(uint Stage, uint TexCoordIndex) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderDeviceD3D, uint, uint, void>)0x005A46C0)(ref this, Stage, TexCoordIndex);

    /// <summary>
    /// <code>Offset: 0x005A4710
    /// void __thiscall RenderDeviceD3D::SetStageFFTextureTransformFlags(RenderDeviceD3D*,const unsigned int,const unsigned int)</code>
    /// </summary>
    public void SetStageFFTextureTransformFlags(uint Stage, uint TextureTransformFlags) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderDeviceD3D, uint, uint, void>)0x005A4710)(ref this, Stage, TextureTransformFlags);

    /// <summary>
    /// <code>Offset: 0x005A4760
    /// void __thiscall RenderDeviceD3D::SetStageTexture(RenderDeviceD3D*,const unsigned int,RenderTexture*)</code>
    /// </summary>
    public void SetStageTexture(uint Stage, ACBindings.Internal.RenderTexture* pTexture) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderDeviceD3D, uint, ACBindings.Internal.RenderTexture*, void>)0x005A4760)(ref this, Stage, pTexture);

    /// <summary>
    /// <code>Offset: 0x005A47D0
    /// void __thiscall RenderDeviceD3D::SetStageTexture(RenderDeviceD3D*,const unsigned int,IDirect3DTexture9*)</code>
    /// </summary>
    public void SetStageTexture(uint Stage, System.IntPtr pTexture) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderDeviceD3D, uint, System.IntPtr, void>)0x005A47D0)(ref this, Stage, pTexture);

    /// <summary>
    /// <code>Offset: 0x005A4820
    /// void __thiscall RenderDeviceD3D::SetModelToWorldMatrix(RenderDeviceD3D*,const Matrix4*)</code>
    /// </summary>
    public void SetModelToWorldMatrix(ACBindings.Internal.Matrix4* m) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderDeviceD3D, ACBindings.Internal.Matrix4*, void>)0x005A4820)(ref this, m);

    /// <summary>
    /// <code>Offset: 0x005A4860
    /// void __thiscall RenderDeviceD3D::SetWorldToViewMatrix(RenderDeviceD3D*,const Matrix4*)</code>
    /// </summary>
    public void SetWorldToViewMatrix(ACBindings.Internal.Matrix4* m) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderDeviceD3D, ACBindings.Internal.Matrix4*, void>)0x005A4860)(ref this, m);

    /// <summary>
    /// <code>Offset: 0x005A4890
    /// void __thiscall RenderDeviceD3D::SetViewToClipMatrix(RenderDeviceD3D*,const Matrix4*)</code>
    /// </summary>
    public void SetViewToClipMatrix(ACBindings.Internal.Matrix4* m) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderDeviceD3D, ACBindings.Internal.Matrix4*, void>)0x005A4890)(ref this, m);

    /// <summary>
    /// <code>Offset: 0x005A48C0
    /// void __cdecl RenderDeviceD3D::TransformPixelToClipPoint(const int,const int,const int,const int,float*,float*)</code>
    /// </summary>
    public static void TransformPixelToClipPoint(int nX, int nY, int nWidth, int nHeight, float* fClipX, float* fClipY) => ((delegate* unmanaged[Cdecl]<int, int, int, int, float*, float*, void>)0x005A48C0)(nX, nY, nWidth, nHeight, fClipX, fClipY);

    /// <summary>
    /// <code>Offset: 0x005A4910
    /// bool __thiscall RenderDeviceD3D::SetDefaultD3DStates(RenderDeviceD3D*)</code>
    /// </summary>
    public byte SetDefaultD3DStates() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderDeviceD3D, byte>)0x005A4910)(ref this);
}

