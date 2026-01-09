namespace ACBindings;

// RenderDeviceD3D
public unsafe struct RenderDeviceD3D
{
    // Base Classes
    public ACBindings.RenderDevice BaseClass_RenderDevice; // ACBindings.RenderDevice

    // Statics
    public static int* building_view = (int*)0x00821E54;
    public static int* backup_building_view = (int*)0x00821E58;
    public static byte* s_bAllowDrawPrimitiveUP = (byte*)0x00821E5C;
    public static ACBindings.PView* indoor_pview = (ACBindings.PView*)0x008EE3CC;
    public static ACBindings.PView* outdoor_pview = (ACBindings.PView*)0x008EE3D0;
    public static int* ObjBuildingOrBuildingPart = (int*)0x008EE3D4;
    public static ACBindings.CPhysicsPart* s_current_physics_part = (ACBindings.CPhysicsPart*)0x008EE3D8;

    // Child Types
    // RenderDeviceD3D_vtbl
    public unsafe struct RenderDeviceD3D_vtbl
    {
        // Members
        public System.IntPtr RenderDeviceD3D_dtor_0; // function pointer
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

    // Members
    public uint m_AdapterID;
    public ACBindings._D3DDEVTYPE m_D3DDeviceType;
    public ACBindings._D3DCAPS9 m_D3DCaps;
    public ACBindings.tagRECT m_PresentSourceRect;
    public ACBindings.tagRECT m_PresentDestRect;
    public int* m_hPresentWindow;
    public uint m_nFrontBufferWidth;
    public uint m_nFrontBufferHeight;
    public System.IntPtr m_pDirect3DDevice;
    public System.IntPtr m_pPrimarySwapChain;
    public byte m_bForceStates;
    public ACBindings.RenderStateCacheType m_State;
    public byte m_bMaterialAlphaMode;
    public ACBindings._D3DMATERIAL9* m_pD3DCurrMaterial;
    public ACBindings._D3DMATERIAL9 m_defaultMaterial;
    public byte m_currentlyDrawingSky;
    public ACBindings.CMaterial* m_pCurrMaterial;
    public System.IntPtr m_primitiveVbuf;
    public System.IntPtr m_pSolidColorTexture;
    public uint m_currentSolidColor;
    public float m_gammaBrightnessVal;
    public byte m_ParticleState;
    public ACBindings.SmartArray__uint m_DefaultSamplerMappings;
    public ACBindings.TextureBasedFont* m_pDebugFont;
    public uint m_DebugFontWidth;
    public uint m_DebugFontHeight;
    public uint m_TotalVideoMemoryInBytes;

    // Methods
    // int __thiscall RenderDeviceD3D::Init(RenderDeviceD3D*)
    public int Init() => ((delegate* unmanaged[Thiscall]<ref ACBindings.RenderDeviceD3D, int>)0x005A00C0)(ref this);
    // void __thiscall RenderDeviceD3D::SetLandscape(RenderDeviceD3D*,LScape*)
    public void SetLandscape(ACBindings.LScape* lscape) => ((delegate* unmanaged[Thiscall]<ref ACBindings.RenderDeviceD3D, ACBindings.LScape*, void>)0x005A01D0)(ref this, lscape);
    // void __thiscall RenderDeviceD3D::DrawInside(RenderDeviceD3D*,CEnvCell*)
    public void DrawInside(ACBindings.CEnvCell* cell) => ((delegate* unmanaged[Thiscall]<ref ACBindings.RenderDeviceD3D, ACBindings.CEnvCell*, void>)0x005A01E0)(ref this, cell);
    // void __thiscall RenderDeviceD3D::DrawPortal(RenderDeviceD3D*,CPortalPoly*,int,int)
    public void DrawPortal(ACBindings.CPortalPoly* portal, int check, int portalPolyOrPortalContents) => ((delegate* unmanaged[Thiscall]<ref ACBindings.RenderDeviceD3D, ACBindings.CPortalPoly*, int, int, void>)0x005A01F0)(ref this, portal, check, portalPolyOrPortalContents);
    // void __thiscall RenderDeviceD3D::DrawLandCell(RenderDeviceD3D*,CLandCell*)
    public void DrawLandCell(ACBindings.CLandCell* cell) => ((delegate* unmanaged[Thiscall]<ref ACBindings.RenderDeviceD3D, ACBindings.CLandCell*, void>)0x005A0230)(ref this, cell);
    // void __thiscall RenderDeviceD3D::DrawSortCell(RenderDeviceD3D*,CSortCell*)
    public void DrawSortCell(ACBindings.CSortCell* cell) => ((delegate* unmanaged[Thiscall]<ref ACBindings.RenderDeviceD3D, ACBindings.CSortCell*, void>)0x005A0250)(ref this, cell);
    // void __thiscall RenderDeviceD3D::DrawEnvCell(RenderDeviceD3D*,CEnvCell*)
    public void DrawEnvCell(ACBindings.CEnvCell* cell) => ((delegate* unmanaged[Thiscall]<ref ACBindings.RenderDeviceD3D, ACBindings.CEnvCell*, void>)0x005A0280)(ref this, cell);
    // void __thiscall RenderDeviceD3D::DrawBuilding(RenderDeviceD3D*,CBuildingObj*)
    public void DrawBuilding(ACBindings.CBuildingObj* building) => ((delegate* unmanaged[Thiscall]<ref ACBindings.RenderDeviceD3D, ACBindings.CBuildingObj*, void>)0x005A03B0)(ref this, building);
    // ObjectDrawStatus __thiscall RenderDeviceD3D::DrawMeshInternal(RenderDeviceD3D*,CGfxObj*,bool,BoundingType)
    public ACBindings.ObjectDrawStatus DrawMeshInternal(ACBindings.CGfxObj* i_pObj, byte i_bBuilding, ACBindings.BoundingType i_bt) => ((delegate* unmanaged[Thiscall]<ref ACBindings.RenderDeviceD3D, ACBindings.CGfxObj*, byte, ACBindings.BoundingType, ACBindings.ObjectDrawStatus>)0x005A0470)(ref this, i_pObj, i_bBuilding, i_bt);
    // RenderSurface* __thiscall RenderDeviceD3D::CreateSurface(RenderDeviceD3D*)
    public ACBindings.RenderSurface* CreateSurface() => ((delegate* unmanaged[Thiscall]<ref ACBindings.RenderDeviceD3D, ACBindings.RenderSurface*>)0x005A0520)(ref this);
    // RenderTexture* __thiscall RenderDeviceD3D::CreateTexture(RenderDeviceD3D*)
    public ACBindings.RenderTexture* CreateTexture() => ((delegate* unmanaged[Thiscall]<ref ACBindings.RenderDeviceD3D, ACBindings.RenderTexture*>)0x005A0540)(ref this);
    // RenderIndexBuffer* __thiscall RenderDeviceD3D::CreateIndexBuffer(RenderDeviceD3D*)
    public ACBindings.RenderIndexBuffer* CreateIndexBuffer() => ((delegate* unmanaged[Thiscall]<ref ACBindings.RenderDeviceD3D, ACBindings.RenderIndexBuffer*>)0x005A0560)(ref this);
    // void __thiscall RenderDeviceD3D::SetVertexStream(RenderDeviceD3D*,const unsigned int,RenderVertexStreamD3D*)
    public void SetVertexStream(uint StreamIndex, ACBindings.RenderVertexStreamD3D* pStream) => ((delegate* unmanaged[Thiscall]<ref ACBindings.RenderDeviceD3D, uint, ACBindings.RenderVertexStreamD3D*, void>)0x005A05A0)(ref this, StreamIndex, pStream);
    // bool __thiscall RenderDeviceD3D::IsResetPossible(RenderDeviceD3D*)
    public byte IsResetPossible() => ((delegate* unmanaged[Thiscall]<ref ACBindings.RenderDeviceD3D, byte>)0x005A05E0)(ref this);
    // void __thiscall RenderDeviceD3D::ApplyVertexFormat(RenderDeviceD3D*,const VertexFormatInfo*)
    public void ApplyVertexFormat(ACBindings.VertexFormatInfo* VFI) => ((delegate* unmanaged[Thiscall]<ref ACBindings.RenderDeviceD3D, ACBindings.VertexFormatInfo*, void>)0x005A0610)(ref this, VFI);
    // bool __thiscall RenderDeviceD3D::DetectDeviceCaps(RenderDeviceD3D*)
    public byte DetectDeviceCaps() => ((delegate* unmanaged[Thiscall]<ref ACBindings.RenderDeviceD3D, byte>)0x005A0630)(ref this);
    // void __thiscall RenderDeviceD3D::SetViewport(RenderDeviceD3D*,unsigned int,unsigned int,unsigned int,unsigned int,bool)
    public void SetViewport(uint x, uint y, uint width, uint height, byte i_UseAutoAspect) => ((delegate* unmanaged[Thiscall]<ref ACBindings.RenderDeviceD3D, uint, uint, uint, uint, byte, void>)0x005A0800)(ref this, x, y, width, height, i_UseAutoAspect);
    // PixelFormatID __thiscall RenderDeviceD3D::SelectPixelFormat(RenderDeviceD3D*,const PixelFormatID,const unsigned int,const _D3DRESOURCETYPE,const bool,const unsigned __int8*,const unsigned int)
    public ACBindings.PixelFormatID SelectPixelFormat(ACBindings.PixelFormatID displayFormat, uint usage, ACBindings._D3DRESOURCETYPE resource, byte use32, byte* formats, uint numFormats) => ((delegate* unmanaged[Thiscall]<ref ACBindings.RenderDeviceD3D, ACBindings.PixelFormatID, uint, ACBindings._D3DRESOURCETYPE, byte, byte*, uint, ACBindings.PixelFormatID>)0x005A0880)(ref this, displayFormat, usage, resource, use32, formats, numFormats);
    // bool __thiscall RenderDeviceD3D::ChoosePixelFormats(RenderDeviceD3D*,const PixelFormatID)
    public byte ChoosePixelFormats(ACBindings.PixelFormatID displayFormat) => ((delegate* unmanaged[Thiscall]<ref ACBindings.RenderDeviceD3D, ACBindings.PixelFormatID, byte>)0x005A0980)(ref this, displayFormat);
    // bool __thiscall RenderDeviceD3D::CheckDisplayModes(RenderDeviceD3D*,const PixelFormatID,const unsigned int,unsigned int*)
    public byte CheckDisplayModes(ACBindings.PixelFormatID displayFormat, uint DesiredRefreshRate, uint* optimalRefreshRate) => ((delegate* unmanaged[Thiscall]<ref ACBindings.RenderDeviceD3D, ACBindings.PixelFormatID, uint, uint*, byte>)0x005A0BC0)(ref this, displayFormat, DesiredRefreshRate, optimalRefreshRate);
    // void __thiscall RenderDeviceD3D::ReleaseD3DResources(RenderDeviceD3D*)
    public void ReleaseD3DResources() => ((delegate* unmanaged[Thiscall]<ref ACBindings.RenderDeviceD3D, void>)0x005A0C80)(ref this);
    // void __thiscall RenderDeviceD3D::SetupDisplayAspectRatio(RenderDeviceD3D*)
    public void SetupDisplayAspectRatio() => ((delegate* unmanaged[Thiscall]<ref ACBindings.RenderDeviceD3D, void>)0x005A0CE0)(ref this);
    // void __thiscall RenderDeviceD3D::SetMipmapLODBiasForAllSamplers(RenderDeviceD3D*,const float)
    public void SetMipmapLODBiasForAllSamplers(float Bias) => ((delegate* unmanaged[Thiscall]<ref ACBindings.RenderDeviceD3D, float, void>)0x005A0D60)(ref this, Bias);
    // void __thiscall RenderDeviceD3D::BeginScene(RenderDeviceD3D*)
    public void BeginScene() => ((delegate* unmanaged[Thiscall]<ref ACBindings.RenderDeviceD3D, void>)0x005A0D90)(ref this);
    // void __thiscall RenderDeviceD3D::EndScene(RenderDeviceD3D*)
    public void EndScene() => ((delegate* unmanaged[Thiscall]<ref ACBindings.RenderDeviceD3D, void>)0x005A0E10)(ref this);
    // void __thiscall RenderDeviceD3D::Clear(RenderDeviceD3D*,unsigned int,const RGBAColor*,const float)
    public void Clear(uint clearFlags, ACBindings.RGBAColor* color, float depth) => ((delegate* unmanaged[Thiscall]<ref ACBindings.RenderDeviceD3D, uint, ACBindings.RGBAColor*, float, void>)0x005A0E40)(ref this, clearFlags, color, depth);
    // void __thiscall RenderDeviceD3D::Flip(RenderDeviceD3D*)
    public void Flip() => ((delegate* unmanaged[Thiscall]<ref ACBindings.RenderDeviceD3D, void>)0x005A0F60)(ref this);
    // void __thiscall RenderDeviceD3D::SetCurrentMaterial(RenderDeviceD3D*,const CMaterial*,bool)
    public void SetCurrentMaterial(ACBindings.CMaterial* material, byte force) => ((delegate* unmanaged[Thiscall]<ref ACBindings.RenderDeviceD3D, ACBindings.CMaterial*, byte, void>)0x005A0FF0)(ref this, material, force);
    // bool __thiscall RenderDeviceD3D::SetSolidColorTextureColor(RenderDeviceD3D*,unsigned int,bool)
    public byte SetSolidColorTextureColor(uint color, byte force) => ((delegate* unmanaged[Thiscall]<ref ACBindings.RenderDeviceD3D, uint, byte, byte>)0x005A1080)(ref this, color, force);
    // bool __thiscall RenderDeviceD3D::SetDefaultDeviceStates(RenderDeviceD3D*)
    public byte SetDefaultDeviceStates() => ((delegate* unmanaged[Thiscall]<ref ACBindings.RenderDeviceD3D, byte>)0x005A10F0)(ref this);
    // void __thiscall RenderDeviceD3D::SetRenderTarget(RenderDeviceD3D*,const unsigned int,RenderSurface*,RenderSurface*)
    public void SetRenderTarget(uint Index, ACBindings.RenderSurface* pRenderTarget, ACBindings.RenderSurface* pDepthStencilTarget) => ((delegate* unmanaged[Thiscall]<ref ACBindings.RenderDeviceD3D, uint, ACBindings.RenderSurface*, ACBindings.RenderSurface*, void>)0x005A1260)(ref this, Index, pRenderTarget, pDepthStencilTarget);
    // RenderSurface* __thiscall RenderDeviceD3D::GenerateSurfaceFromFrontBuffer(RenderDeviceD3D*)
    public ACBindings.RenderSurface* GenerateSurfaceFromFrontBuffer() => ((delegate* unmanaged[Thiscall]<ref ACBindings.RenderDeviceD3D, ACBindings.RenderSurface*>)0x005A1320)(ref this);
    // void __thiscall RenderDeviceD3D::EndRenderingDebugText(RenderDeviceD3D*)
    public void EndRenderingDebugText() => ((delegate* unmanaged[Thiscall]<ref ACBindings.RenderDeviceD3D, void>)0x005A1390)(ref this);
    // void __thiscall RenderDeviceD3D::RenderDebugText(RenderDeviceD3D*,const int,const int,const char*,const unsigned int)
    public void RenderDebugText(int ViewportX, int ViewportY, sbyte* pText, uint Color32) => ((delegate* unmanaged[Thiscall]<ref ACBindings.RenderDeviceD3D, int, int, sbyte*, uint, void>)0x005A13A0)(ref this, ViewportX, ViewportY, pText, Color32);
    // bool __thiscall RenderDeviceD3D::RenderPrimitivesInHardware(RenderDeviceD3D*,const PrimType,const unsigned int,RenderVertexStreamD3D*,const unsigned int,const unsigned int,const unsigned int)
    public byte RenderPrimitivesInHardware(ACBindings.PrimType PrimType, uint NumPrimitives, ACBindings.RenderVertexStreamD3D* VertexStream, uint VertexStreamFrameID, uint FirstRemoteVertexIndex, uint NumVertices) => ((delegate* unmanaged[Thiscall]<ref ACBindings.RenderDeviceD3D, ACBindings.PrimType, uint, ACBindings.RenderVertexStreamD3D*, uint, uint, uint, byte>)0x005A13D0)(ref this, PrimType, NumPrimitives, VertexStream, VertexStreamFrameID, FirstRemoteVertexIndex, NumVertices);
    // bool __thiscall RenderDeviceD3D::RenderDynamicPrimitives(RenderDeviceD3D*,const PrimType,const unsigned int,const void*,const unsigned int)
    public byte RenderDynamicPrimitives(ACBindings.PrimType PrimType, uint NumPrimitives, void* pVertices, uint VertexFormat) => ((delegate* unmanaged[Thiscall]<ref ACBindings.RenderDeviceD3D, ACBindings.PrimType, uint, void*, uint, byte>)0x005A1460)(ref this, PrimType, NumPrimitives, pVertices, VertexFormat);
    // HRESULT __cdecl RenderDeviceD3D::DrawPrimitiveUP(_D3DPRIMITIVETYPE,unsigned int,const void*,unsigned int)
    public static int DrawPrimitiveUP(ACBindings._D3DPRIMITIVETYPE PrimitiveType, uint nNumPrimitives, void* pVertexStreamZeroData, uint VertexStreamZeroStride) => ((delegate* unmanaged[Cdecl]<ACBindings._D3DPRIMITIVETYPE, uint, void*, uint, int>)0x005A1520)(PrimitiveType, nNumPrimitives, pVertexStreamZeroData, VertexStreamZeroStride);
    // bool __thiscall RenderDeviceD3D::GetFFFogEnable(RenderDeviceD3D*)
    public byte GetFFFogEnable() => ((delegate* unmanaged[Thiscall]<ref ACBindings.RenderDeviceD3D, byte>)0x005A1560)(ref this);
    // bool __thiscall RenderDeviceD3D::IsAvailableVideoMemoryLow(RenderDeviceD3D*)
    public byte IsAvailableVideoMemoryLow() => ((delegate* unmanaged[Thiscall]<ref ACBindings.RenderDeviceD3D, byte>)0x005A1570)(ref this);
    // void __thiscall RenderDeviceD3D::InvalidateCachedTexturePointer(RenderDeviceD3D*,void*)
    public void InvalidateCachedTexturePointer(System.IntPtr pD3DTexture) => ((delegate* unmanaged[Thiscall]<ref ACBindings.RenderDeviceD3D, System.IntPtr, void>)0x005A15B0)(ref this, pD3DTexture);
    // void __thiscall RenderDeviceD3D::InvalidateCachedVertexBufferPointer(RenderDeviceD3D*,void*)
    public void InvalidateCachedVertexBufferPointer(System.IntPtr pD3DVertexBuffer) => ((delegate* unmanaged[Thiscall]<ref ACBindings.RenderDeviceD3D, System.IntPtr, void>)0x005A15E0)(ref this, pD3DVertexBuffer);
    // void __thiscall RenderDeviceD3D::UpdateObjCell(RenderDeviceD3D*,CObjCell*)
    public void UpdateObjCell(ACBindings.CObjCell* cell) => ((delegate* unmanaged[Thiscall]<ref ACBindings.RenderDeviceD3D, ACBindings.CObjCell*, void>)0x005A17A0)(ref this, cell);
    // void __thiscall RenderDeviceD3D::DrawObjCellForDummies(RenderDeviceD3D*,CObjCell*)
    public void DrawObjCellForDummies(ACBindings.CObjCell* cell) => ((delegate* unmanaged[Thiscall]<ref ACBindings.RenderDeviceD3D, ACBindings.CObjCell*, void>)0x005A1870)(ref this, cell);
    // void __thiscall RenderDeviceD3D::DrawPartCell(RenderDeviceD3D*,unsigned int,CPartCell*,unsigned int)
    public void DrawPartCell(uint cellID, ACBindings.CPartCell* cell, uint leaf_index) => ((delegate* unmanaged[Thiscall]<ref ACBindings.RenderDeviceD3D, uint, ACBindings.CPartCell*, uint, void>)0x005A18B0)(ref this, cellID, cell, leaf_index);
    // void __thiscall RenderDeviceD3D::DrawBuildingLeaf(RenderDeviceD3D*,unsigned int)
    public void DrawBuildingLeaf(uint leaf_index) => ((delegate* unmanaged[Thiscall]<ref ACBindings.RenderDeviceD3D, uint, void>)0x005A18F0)(ref this, leaf_index);
    // ObjectDrawStatus __thiscall RenderDeviceD3D::DrawMesh(RenderDeviceD3D*,CGfxObj*,const Position*,bool)
    public ACBindings.ObjectDrawStatus DrawMesh(ACBindings.CGfxObj* i_pObj, ACBindings.Position* i_posObj, byte i_bBuilding) => ((delegate* unmanaged[Thiscall]<ref ACBindings.RenderDeviceD3D, ACBindings.CGfxObj*, ACBindings.Position*, byte, ACBindings.ObjectDrawStatus>)0x005A1970)(ref this, i_pObj, i_posObj, i_bBuilding);
    // bool __thiscall RenderDeviceD3D::GetD3DResources(RenderDeviceD3D*)
    public byte GetD3DResources() => ((delegate* unmanaged[Thiscall]<ref ACBindings.RenderDeviceD3D, byte>)0x005A1B40)(ref this);
    // void __thiscall RenderDeviceD3D::SetGamma(RenderDeviceD3D*,const float,const bool)
    public void SetGamma(float fBrightness, byte bWantCalibration) => ((delegate* unmanaged[Thiscall]<ref ACBindings.RenderDeviceD3D, float, byte, void>)0x005A1C80)(ref this, fBrightness, bWantCalibration);
    // void __thiscall RenderDeviceD3D::SetupState(RenderDeviceD3D*,const MaterialLayer*,const MaterialLayer*,const unsigned int,const RGBAColor*,const RGBAColor*,const bool)
    public void SetupState(ACBindings.MaterialLayer* pReferenceLayer, ACBindings.MaterialLayer* pLayer, uint VertexFormat, ACBindings.RGBAColor* DiffuseColorScale, ACBindings.RGBAColor* AmbientLightBoost, byte ForceTranslucent) => ((delegate* unmanaged[Thiscall]<ref ACBindings.RenderDeviceD3D, ACBindings.MaterialLayer*, ACBindings.MaterialLayer*, uint, ACBindings.RGBAColor*, ACBindings.RGBAColor*, byte, void>)0x005A1D80)(ref this, pReferenceLayer, pLayer, VertexFormat, DiffuseColorScale, AmbientLightBoost, ForceTranslucent);
    // bool __thiscall RenderDeviceD3D::InitDebugFont(RenderDeviceD3D*)
    public byte InitDebugFont() => ((delegate* unmanaged[Thiscall]<ref ACBindings.RenderDeviceD3D, byte>)0x005A2620)(ref this);
    // void __thiscall RenderDeviceD3D::BeginRenderingDebugText(RenderDeviceD3D*)
    public void BeginRenderingDebugText() => ((delegate* unmanaged[Thiscall]<ref ACBindings.RenderDeviceD3D, void>)0x005A26A0)(ref this);
    // bool __thiscall RenderDeviceD3D::RenderDynamicPrimitivesUsingMaterial(RenderDeviceD3D*,const PrimType,const unsigned int,const void*,const unsigned int,const RenderMaterial*,const RenderMaterial*,const RGBAColor*)
    public byte RenderDynamicPrimitivesUsingMaterial(ACBindings.PrimType PrimType, uint NumPrimitives, void* pVertices, uint VertexFormat, ACBindings.RenderMaterial* ReferenceMaterial, ACBindings.RenderMaterial* Material, ACBindings.RGBAColor* Color) => ((delegate* unmanaged[Thiscall]<ref ACBindings.RenderDeviceD3D, ACBindings.PrimType, uint, void*, uint, ACBindings.RenderMaterial*, ACBindings.RenderMaterial*, ACBindings.RGBAColor*, byte>)0x005A26D0)(ref this, PrimType, NumPrimitives, pVertices, VertexFormat, ReferenceMaterial, Material, Color);
    // void __thiscall RenderDeviceD3D::DrawBlock(RenderDeviceD3D*,CLandBlock*)
    public void DrawBlock(ACBindings.CLandBlock* block) => ((delegate* unmanaged[Thiscall]<ref ACBindings.RenderDeviceD3D, ACBindings.CLandBlock*, void>)0x005A28D0)(ref this, block);
    // void __thiscall RenderDeviceD3D::DrawObjCell(RenderDeviceD3D*,CObjCell*)
    public void DrawObjCell(ACBindings.CObjCell* cell) => ((delegate* unmanaged[Thiscall]<ref ACBindings.RenderDeviceD3D, ACBindings.CObjCell*, void>)0x005A2B50)(ref this, cell);
    // RenderVertexBufferD3D* __thiscall RenderDeviceD3D::CreateVertexBuffer(RenderDeviceD3D*)
    public ACBindings.RenderVertexBufferD3D* CreateVertexBuffer() => ((delegate* unmanaged[Thiscall]<ref ACBindings.RenderDeviceD3D, ACBindings.RenderVertexBufferD3D*>)0x005A2B80)(ref this);
    // void __thiscall RenderDeviceD3D::OnDeviceDisplayModeChange(RenderDeviceD3D*)
    public void OnDeviceDisplayModeChange() => ((delegate* unmanaged[Thiscall]<ref ACBindings.RenderDeviceD3D, void>)0x005A2BA0)(ref this);
    // void __thiscall RenderDeviceD3D::End(RenderDeviceD3D*)
    public void End() => ((delegate* unmanaged[Thiscall]<ref ACBindings.RenderDeviceD3D, void>)0x005A2C50)(ref this);
    // bool __thiscall RenderDeviceD3D::DetectDisplayFormats(RenderDeviceD3D*,const PixelFormatID)
    public byte DetectDisplayFormats(ACBindings.PixelFormatID displayFormat) => ((delegate* unmanaged[Thiscall]<ref ACBindings.RenderDeviceD3D, ACBindings.PixelFormatID, byte>)0x005A2CF0)(ref this, displayFormat);
    // bool __thiscall RenderDeviceD3D::SetupDisplayInfo(RenderDeviceD3D*,const PixelFormatID,const PixelFormatID,const PixelFormatID,const bool,const bool)
    public byte SetupDisplayInfo(ACBindings.PixelFormatID displayFormat, ACBindings.PixelFormatID colorFormat, ACBindings.PixelFormatID depthStencilFormat, byte has8BitStencil, byte bFullScreen) => ((delegate* unmanaged[Thiscall]<ref ACBindings.RenderDeviceD3D, ACBindings.PixelFormatID, ACBindings.PixelFormatID, ACBindings.PixelFormatID, byte, byte, byte>)0x005A2DF0)(ref this, displayFormat, colorFormat, depthStencilFormat, has8BitStencil, bFullScreen);
    // bool __thiscall RenderDeviceD3D::SelectBufferFormats(RenderDeviceD3D*,const RenderDevicePresentation*,PixelFormatID*,PixelFormatID*,unsigned int*)
    public byte SelectBufferFormats(ACBindings.RenderDevicePresentation* renderPres, ACBindings.PixelFormatID* colorFormat, ACBindings.PixelFormatID* depthStencilFormat, uint* optimalRefreshRate) => ((delegate* unmanaged[Thiscall]<ref ACBindings.RenderDeviceD3D, ACBindings.RenderDevicePresentation*, ACBindings.PixelFormatID*, ACBindings.PixelFormatID*, uint*, byte>)0x005A2EF0)(ref this, renderPres, colorFormat, depthStencilFormat, optimalRefreshRate);
    // void __thiscall RenderDeviceD3D::Begin(RenderDeviceD3D*)
    public void Begin() => ((delegate* unmanaged[Thiscall]<ref ACBindings.RenderDeviceD3D, void>)0x005A3310)(ref this);
    // void __thiscall RenderDeviceD3D::Shutdown(RenderDeviceD3D*)
    public void Shutdown() => ((delegate* unmanaged[Thiscall]<ref ACBindings.RenderDeviceD3D, void>)0x005A3520)(ref this);
    // bool __thiscall RenderDeviceD3D::SetupPresentation(RenderDeviceD3D*,const RenderDevicePresentation*,_D3DPRESENT_PARAMETERS_*)
    public byte SetupPresentation(ACBindings.RenderDevicePresentation* renderPres, System.IntPtr present) => ((delegate* unmanaged[Thiscall]<ref ACBindings.RenderDeviceD3D, ACBindings.RenderDevicePresentation*, System.IntPtr, byte>)0x005A3560)(ref this, renderPres, present);
    // bool __thiscall RenderDeviceD3D::ResetDevice(RenderDeviceD3D*,const RenderDevicePresentation*)
    public byte ResetDevice(ACBindings.RenderDevicePresentation* newPres) => ((delegate* unmanaged[Thiscall]<ref ACBindings.RenderDeviceD3D, ACBindings.RenderDevicePresentation*, byte>)0x005A3780)(ref this, newPres);
    // bool __thiscall RenderDeviceD3D::Startup(RenderDeviceD3D*,const unsigned int,const RenderDevicePresentation*,const RenderDeviceConfig*)
    public byte Startup(uint nDisplayAdapter, ACBindings.RenderDevicePresentation* presentation, ACBindings.RenderDeviceConfig* config) => ((delegate* unmanaged[Thiscall]<ref ACBindings.RenderDeviceD3D, uint, ACBindings.RenderDevicePresentation*, ACBindings.RenderDeviceConfig*, byte>)0x005A3910)(ref this, nDisplayAdapter, presentation, config);
    // void __thiscall RenderDeviceD3D::SetAlphaBlendEnable(RenderDeviceD3D*,const bool)
    public void SetAlphaBlendEnable(byte bValue) => ((delegate* unmanaged[Thiscall]<ref ACBindings.RenderDeviceD3D, byte, void>)0x005A3BA0)(ref this, bValue);
    // void __thiscall RenderDeviceD3D::SetAlphaTestEnable(RenderDeviceD3D*,const bool)
    public void SetAlphaTestEnable(byte bValue) => ((delegate* unmanaged[Thiscall]<ref ACBindings.RenderDeviceD3D, byte, void>)0x005A3BE0)(ref this, bValue);
    // void __thiscall RenderDeviceD3D::SetAlphaTestFunction(RenderDeviceD3D*,const AlphaTestFunc)
    public void SetAlphaTestFunction(ACBindings.AlphaTestFunc Value) => ((delegate* unmanaged[Thiscall]<ref ACBindings.RenderDeviceD3D, ACBindings.AlphaTestFunc, void>)0x005A3C20)(ref this, Value);
    // void __thiscall RenderDeviceD3D::SetAlphaTestRef(RenderDeviceD3D*,const unsigned int)
    public void SetAlphaTestRef(uint Value) => ((delegate* unmanaged[Thiscall]<ref ACBindings.RenderDeviceD3D, uint, void>)0x005A3C60)(ref this, Value);
    // void __thiscall RenderDeviceD3D::SetBlendFunction(RenderDeviceD3D*,const BlendMode,const BlendMode,const BlendOpType)
    public void SetBlendFunction(ACBindings.BlendMode SourceFactor, ACBindings.BlendMode DestFactor, ACBindings.BlendOpType Op) => ((delegate* unmanaged[Thiscall]<ref ACBindings.RenderDeviceD3D, ACBindings.BlendMode, ACBindings.BlendMode, ACBindings.BlendOpType, void>)0x005A3CA0)(ref this, SourceFactor, DestFactor, Op);
    // void __thiscall RenderDeviceD3D::SetCullMode(RenderDeviceD3D*,const CullModeType)
    public void SetCullMode(ACBindings.CullModeType Value) => ((delegate* unmanaged[Thiscall]<ref ACBindings.RenderDeviceD3D, ACBindings.CullModeType, void>)0x005A3D80)(ref this, Value);
    // void __thiscall RenderDeviceD3D::SetDepthBias(RenderDeviceD3D*,const float)
    public void SetDepthBias(float Value) => ((delegate* unmanaged[Thiscall]<ref ACBindings.RenderDeviceD3D, float, void>)0x005A3DC0)(ref this, Value);
    // void __thiscall RenderDeviceD3D::SetDepthBufferEnable(RenderDeviceD3D*,const bool)
    public void SetDepthBufferEnable(byte bValue) => ((delegate* unmanaged[Thiscall]<ref ACBindings.RenderDeviceD3D, byte, void>)0x005A3E00)(ref this, bValue);
    // void __thiscall RenderDeviceD3D::SetDepthBufferMode(RenderDeviceD3D*,const DepthTestMode,const bool)
    public void SetDepthBufferMode(ACBindings.DepthTestMode DepthTestMode, byte DepthWriteEnable) => ((delegate* unmanaged[Thiscall]<ref ACBindings.RenderDeviceD3D, ACBindings.DepthTestMode, byte, void>)0x005A3E20)(ref this, DepthTestMode, DepthWriteEnable);
    // void __thiscall RenderDeviceD3D::SetFFAmbientColor32(RenderDeviceD3D*,const unsigned int)
    public void SetFFAmbientColor32(uint Value) => ((delegate* unmanaged[Thiscall]<ref ACBindings.RenderDeviceD3D, uint, void>)0x005A3EB0)(ref this, Value);
    // void __thiscall RenderDeviceD3D::SetFFDiffuseColorSource(RenderDeviceD3D*,const ColorSource)
    public void SetFFDiffuseColorSource(ACBindings.ColorSource Value) => ((delegate* unmanaged[Thiscall]<ref ACBindings.RenderDeviceD3D, ACBindings.ColorSource, void>)0x005A3EF0)(ref this, Value);
    // void __thiscall RenderDeviceD3D::SetFFAmbientColorSource(RenderDeviceD3D*,const ColorSource)
    public void SetFFAmbientColorSource(ACBindings.ColorSource Value) => ((delegate* unmanaged[Thiscall]<ref ACBindings.RenderDeviceD3D, ACBindings.ColorSource, void>)0x005A3F40)(ref this, Value);
    // void __thiscall RenderDeviceD3D::SetFFFogEnable(RenderDeviceD3D*,const bool)
    public void SetFFFogEnable(byte bValue) => ((delegate* unmanaged[Thiscall]<ref ACBindings.RenderDeviceD3D, byte, void>)0x005A3F90)(ref this, bValue);
    // void __thiscall RenderDeviceD3D::SetFFFogSystemDisabled(RenderDeviceD3D*,const bool)
    public void SetFFFogSystemDisabled(byte bValue) => ((delegate* unmanaged[Thiscall]<ref ACBindings.RenderDeviceD3D, byte, void>)0x005A3FE0)(ref this, bValue);
    // void __thiscall RenderDeviceD3D::SetFFFogUserDisabled(RenderDeviceD3D*,const bool)
    public void SetFFFogUserDisabled(byte bValue) => ((delegate* unmanaged[Thiscall]<ref ACBindings.RenderDeviceD3D, byte, void>)0x005A4010)(ref this, bValue);
    // void __thiscall RenderDeviceD3D::SetFFFogAlphaDisabled(RenderDeviceD3D*,const bool)
    public void SetFFFogAlphaDisabled(byte bValue) => ((delegate* unmanaged[Thiscall]<ref ACBindings.RenderDeviceD3D, byte, void>)0x005A4040)(ref this, bValue);
    // void __thiscall RenderDeviceD3D::SetFFFogProperties(RenderDeviceD3D*,const RGBAColor*,const float,const float)
    public void SetFFFogProperties(ACBindings.RGBAColor* Color, float NearDistance, float FarDistance) => ((delegate* unmanaged[Thiscall]<ref ACBindings.RenderDeviceD3D, ACBindings.RGBAColor*, float, float, void>)0x005A4080)(ref this, Color, NearDistance, FarDistance);
    // void __thiscall RenderDeviceD3D::SetFFFogProperties(RenderDeviceD3D*,const RGBAUnion*,const float,const float)
    public void SetFFFogProperties(ACBindings.RGBAUnion* Color, float NearDistance, float FarDistance) => ((delegate* unmanaged[Thiscall]<ref ACBindings.RenderDeviceD3D, ACBindings.RGBAUnion*, float, float, void>)0x005A41B0)(ref this, Color, NearDistance, FarDistance);
    // void __thiscall RenderDeviceD3D::SetFFLighting(RenderDeviceD3D*,const bool)
    public void SetFFLighting(byte bValue) => ((delegate* unmanaged[Thiscall]<ref ACBindings.RenderDeviceD3D, byte, void>)0x005A41F0)(ref this, bValue);
    // void __thiscall RenderDeviceD3D::SetFFLightEnable(RenderDeviceD3D*,const unsigned int,const bool)
    public void SetFFLightEnable(uint Index, byte bValue) => ((delegate* unmanaged[Thiscall]<ref ACBindings.RenderDeviceD3D, uint, byte, void>)0x005A4230)(ref this, Index, bValue);
    // void __thiscall RenderDeviceD3D::SetFFSpecularColorSource(RenderDeviceD3D*,const ColorSource)
    public void SetFFSpecularColorSource(ACBindings.ColorSource Value) => ((delegate* unmanaged[Thiscall]<ref ACBindings.RenderDeviceD3D, ACBindings.ColorSource, void>)0x005A4280)(ref this, Value);
    // void __thiscall RenderDeviceD3D::SetFFSpecularEnable(RenderDeviceD3D*,const bool)
    public void SetFFSpecularEnable(byte bValue) => ((delegate* unmanaged[Thiscall]<ref ACBindings.RenderDeviceD3D, byte, void>)0x005A42D0)(ref this, bValue);
    // void __thiscall RenderDeviceD3D::SetFFEmissiveColorSource(RenderDeviceD3D*,const ColorSource)
    public void SetFFEmissiveColorSource(ACBindings.ColorSource Value) => ((delegate* unmanaged[Thiscall]<ref ACBindings.RenderDeviceD3D, ACBindings.ColorSource, void>)0x005A4310)(ref this, Value);
    // void __thiscall RenderDeviceD3D::SetFFTextureFactor32(RenderDeviceD3D*,const unsigned int)
    public void SetFFTextureFactor32(uint Value) => ((delegate* unmanaged[Thiscall]<ref ACBindings.RenderDeviceD3D, uint, void>)0x005A4350)(ref this, Value);
    // void __thiscall RenderDeviceD3D::SetFillMode(RenderDeviceD3D*,const FillModeType)
    public void SetFillMode(ACBindings.FillModeType Value) => ((delegate* unmanaged[Thiscall]<ref ACBindings.RenderDeviceD3D, ACBindings.FillModeType, void>)0x005A4390)(ref this, Value);
    // void __thiscall RenderDeviceD3D::SetMultiSampleAntialias(RenderDeviceD3D*,const bool)
    public void SetMultiSampleAntialias(byte bValue) => ((delegate* unmanaged[Thiscall]<ref ACBindings.RenderDeviceD3D, byte, void>)0x005A43D0)(ref this, bValue);
    // void __thiscall RenderDeviceD3D::SetSamplerAddressMode(RenderDeviceD3D*,const unsigned int,const TexAddress,const TexAddress)
    public void SetSamplerAddressMode(uint Sampler, ACBindings.TexAddress AddressModeU, ACBindings.TexAddress AddressModeV) => ((delegate* unmanaged[Thiscall]<ref ACBindings.RenderDeviceD3D, uint, ACBindings.TexAddress, ACBindings.TexAddress, void>)0x005A4420)(ref this, Sampler, AddressModeU, AddressModeV);
    // void __thiscall RenderDeviceD3D::SetSamplerFilterMode(RenderDeviceD3D*,const unsigned int,const TexFilterMode,const TexFilterMode,const TexFilterMode)
    public void SetSamplerFilterMode(uint Sampler, ACBindings.TexFilterMode MagFilterMode, ACBindings.TexFilterMode MinFilterMode, ACBindings.TexFilterMode MipFilterMode) => ((delegate* unmanaged[Thiscall]<ref ACBindings.RenderDeviceD3D, uint, ACBindings.TexFilterMode, ACBindings.TexFilterMode, ACBindings.TexFilterMode, void>)0x005A4460)(ref this, Sampler, MagFilterMode, MinFilterMode, MipFilterMode);
    // void __thiscall RenderDeviceD3D::SetSamplerMipmapLODBias(RenderDeviceD3D*,const unsigned int,const float)
    public void SetSamplerMipmapLODBias(uint Sampler, float Bias) => ((delegate* unmanaged[Thiscall]<ref ACBindings.RenderDeviceD3D, uint, float, void>)0x005A4520)(ref this, Sampler, Bias);
    // void __thiscall RenderDeviceD3D::SetStageFFAlphaSource(RenderDeviceD3D*,const unsigned int,const TextureOp,const unsigned int,const unsigned int)
    public void SetStageFFAlphaSource(uint Stage, ACBindings.TextureOp AlphaOp, uint AlphaArg1, uint AlphaArg2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.RenderDeviceD3D, uint, ACBindings.TextureOp, uint, uint, void>)0x005A4550)(ref this, Stage, AlphaOp, AlphaArg1, AlphaArg2);
    // void __thiscall RenderDeviceD3D::SetStageFFColorSource(RenderDeviceD3D*,const unsigned int,const TextureOp,const unsigned int,const unsigned int)
    public void SetStageFFColorSource(uint Stage, ACBindings.TextureOp ColorOp, uint ColorArg1, uint ColorArg2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.RenderDeviceD3D, uint, ACBindings.TextureOp, uint, uint, void>)0x005A4610)(ref this, Stage, ColorOp, ColorArg1, ColorArg2);
    // void __thiscall RenderDeviceD3D::SetStageFFTexCoordIndex(RenderDeviceD3D*,const unsigned int,const unsigned int)
    public void SetStageFFTexCoordIndex(uint Stage, uint TexCoordIndex) => ((delegate* unmanaged[Thiscall]<ref ACBindings.RenderDeviceD3D, uint, uint, void>)0x005A46C0)(ref this, Stage, TexCoordIndex);
    // void __thiscall RenderDeviceD3D::SetStageFFTextureTransformFlags(RenderDeviceD3D*,const unsigned int,const unsigned int)
    public void SetStageFFTextureTransformFlags(uint Stage, uint TextureTransformFlags) => ((delegate* unmanaged[Thiscall]<ref ACBindings.RenderDeviceD3D, uint, uint, void>)0x005A4710)(ref this, Stage, TextureTransformFlags);
    // void __thiscall RenderDeviceD3D::SetStageTexture(RenderDeviceD3D*,const unsigned int,RenderTexture*)
    public void SetStageTexture(uint Stage, ACBindings.RenderTexture* pTexture) => ((delegate* unmanaged[Thiscall]<ref ACBindings.RenderDeviceD3D, uint, ACBindings.RenderTexture*, void>)0x005A4760)(ref this, Stage, pTexture);
    // void __thiscall RenderDeviceD3D::SetStageTexture(RenderDeviceD3D*,const unsigned int,IDirect3DTexture9*)
    public void SetStageTexture(uint Stage, System.IntPtr pTexture) => ((delegate* unmanaged[Thiscall]<ref ACBindings.RenderDeviceD3D, uint, System.IntPtr, void>)0x005A47D0)(ref this, Stage, pTexture);
    // void __thiscall RenderDeviceD3D::SetModelToWorldMatrix(RenderDeviceD3D*,const Matrix4*)
    public void SetModelToWorldMatrix(ACBindings.Matrix4* m) => ((delegate* unmanaged[Thiscall]<ref ACBindings.RenderDeviceD3D, ACBindings.Matrix4*, void>)0x005A4820)(ref this, m);
    // void __thiscall RenderDeviceD3D::SetWorldToViewMatrix(RenderDeviceD3D*,const Matrix4*)
    public void SetWorldToViewMatrix(ACBindings.Matrix4* m) => ((delegate* unmanaged[Thiscall]<ref ACBindings.RenderDeviceD3D, ACBindings.Matrix4*, void>)0x005A4860)(ref this, m);
    // void __thiscall RenderDeviceD3D::SetViewToClipMatrix(RenderDeviceD3D*,const Matrix4*)
    public void SetViewToClipMatrix(ACBindings.Matrix4* m) => ((delegate* unmanaged[Thiscall]<ref ACBindings.RenderDeviceD3D, ACBindings.Matrix4*, void>)0x005A4890)(ref this, m);
    // void __cdecl RenderDeviceD3D::TransformPixelToClipPoint(const int,const int,const int,const int,float*,float*)
    public static void TransformPixelToClipPoint(int nX, int nY, int nWidth, int nHeight, float* fClipX, float* fClipY) => ((delegate* unmanaged[Cdecl]<int, int, int, int, float*, float*, void>)0x005A48C0)(nX, nY, nWidth, nHeight, fClipX, fClipY);
    // bool __thiscall RenderDeviceD3D::SetDefaultD3DStates(RenderDeviceD3D*)
    public byte SetDefaultD3DStates() => ((delegate* unmanaged[Thiscall]<ref ACBindings.RenderDeviceD3D, byte>)0x005A4910)(ref this);
}

