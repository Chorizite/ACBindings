namespace ACBindings.Internal;


/// <summary>
/// Represents a Direct3D 9 rendering device that manages adapter configuration, capabilities, surfaces,
/// swap chain, state caching, material handling, and debug font resources for 32‑bit Windows applications.
/// </summary>
public unsafe struct RenderDeviceD3D
{
    // Base Classes
    public ACBindings.Internal.RenderDevice BaseClass_RenderDevice; // ACBindings.Internal.RenderDevice

    // Statics
    public static int* building_view = (int*)0x00821E54;
    public static int* backup_building_view = (int*)0x00821E58;
    public static byte* s_bAllowDrawPrimitiveUP = (byte*)0x00821E5C;
    public static ACBindings.Internal.PView** indoor_pview = (ACBindings.Internal.PView**)0x008EE3CC;
    public static ACBindings.Internal.PView** outdoor_pview = (ACBindings.Internal.PView**)0x008EE3D0;
    public static int* ObjBuildingOrBuildingPart = (int*)0x008EE3D4;
    public static ACBindings.Internal.CPhysicsPart** s_current_physics_part = (ACBindings.Internal.CPhysicsPart**)0x008EE3D8;

    // Child Types
    public unsafe struct RenderDeviceD3D_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.RenderDeviceD3D*, void> RenderDeviceD3D_dtor_0; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.RenderDeviceD3D*, uint, ACBindings.Internal.RenderDevicePresentation*, ACBindings.Internal.RenderDeviceConfig*, byte> Startup; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.RenderDeviceD3D*, void> Shutdown; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.RenderDeviceD3D*, ACBindings.Internal.RenderSurface*> CreateLocalSurface; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.RenderDeviceD3D*, ACBindings.Internal.RenderSurface*> CreateSurface; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.RenderDeviceD3D*, ACBindings.Internal.RenderTexture*> CreateTexture; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.RenderDeviceD3D*, ACBindings.Internal.RenderIndexBuffer*> CreateIndexBuffer; // function pointer
        public System.IntPtr CreateVertexBuffer;
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.RenderDeviceD3D*, void> BeginScene; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.RenderDeviceD3D*, void> EndScene; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.RenderDeviceD3D*, void> Flip; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.RenderDeviceD3D*, uint, ACBindings.Internal.RGBAColor*, float, void> Clear; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.RenderDeviceD3D*, byte> IsResetPossible; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.RenderDeviceD3D*, uint, ACBindings.Internal.RenderSurface*, ACBindings.Internal.RenderSurface*, void> SetRenderTarget; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.RenderDeviceD3D*, ACBindings.Internal.RenderDevicePresentation*, byte> ResetDevice; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.RenderDeviceD3D*, ACBindings.Internal.RenderSurface*> GenerateSurfaceFromFrontBuffer; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.RenderDeviceD3D*, uint, uint, uint, uint, byte, void> SetViewport; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.RenderDeviceD3D*, ACBindings.Internal.LScape*, void> SetLandscape; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.RenderDeviceD3D*, ACBindings.Internal.CEnvCell*, void> DrawInside; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.RenderDeviceD3D*, ACBindings.Internal.CPortalPoly*, int, int, void> DrawPortal; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.RenderDeviceD3D*, ACBindings.Internal.CLandBlock*, void> DrawBlock; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.RenderDeviceD3D*, ACBindings.Internal.CLandCell*, void> DrawLandCell; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.RenderDeviceD3D*, ACBindings.Internal.CSortCell*, void> DrawSortCell; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.RenderDeviceD3D*, ACBindings.Internal.CEnvCell*, void> DrawEnvCell; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.RenderDeviceD3D*, ACBindings.Internal.CObjCell*, void> DrawObjCell; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.RenderDeviceD3D*, ACBindings.Internal.CObjCell*, void> DrawObjCellForDummies; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.RenderDeviceD3D*, ACBindings.Internal.CBuildingObj*, void> DrawBuilding; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.RenderDeviceD3D*, uint, void> DrawBuildingLeaf; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.RenderDeviceD3D*, ACBindings.Internal.CGfxObj*, ACBindings.Internal.Position*, byte, ACBindings.Internal.ObjectDrawStatus> DrawMesh; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.RenderDeviceD3D*, ACBindings.Internal.CGfxObj*, ACBindings.Internal.Position*, void> DrawDetailMesh; // function pointer

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

    /// <summary>Initializes a Direct3D render device by allocating indoor and outdoor view objects, resetting internal state, and setting default material properties.
    /// <code>Offset: 0x005A00C0
    /// int __thiscall RenderDeviceD3D::Init(RenderDeviceD3D*)</code>
    /// </summary>
    /// <returns>Non‑zero on success; zero if allocation fails or view initialization fails.</returns>
    public int Init() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderDeviceD3D, int>)0x005A00C0)(ref this);

    /// <summary>Associates the specified landscape with the DirectX rendering device so it can be used during scene rendering.
    /// <code>Offset: 0x005A01D0
    /// void __thiscall RenderDeviceD3D::SetLandscape(RenderDeviceD3D*,LScape*)</code>
    /// </summary>
    /// <param name="lscape">The landscape configuration to set for this render device.</param>
    public void SetLandscape(ACBindings.Internal.LScape* lscape) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderDeviceD3D, ACBindings.Internal.LScape*, void>)0x005A01D0)(ref this, lscape);

    /// <summary>Draws the interior geometry of the supplied environment cell by delegating to an indoor view object.
    /// <code>Offset: 0x005A01E0
    /// void __thiscall RenderDeviceD3D::DrawInside(RenderDeviceD3D*,CEnvCell*)</code>
    /// </summary>
    /// <param name="cell">The environment cell whose interior is to be rendered.</param>
    public void DrawInside(ACBindings.Internal.CEnvCell* cell) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderDeviceD3D, ACBindings.Internal.CEnvCell*, void>)0x005A01E0)(ref this, cell);

    /// <summary>Renders a portal polygon using the outdoor view context, temporarily disabling any current building view.
    /// <code>Offset: 0x005A01F0
    /// void __thiscall RenderDeviceD3D::DrawPortal(RenderDeviceD3D*,CPortalPoly*,int,int)</code>
    /// </summary>
    /// <param name="portal">Portal data containing an index and a reference to the polygon to render.</param>
    /// <param name="check">Flag that indicates whether visibility or clipping checks should be performed during rendering.</param>
    /// <param name="portalPolyOrPortalContents">Specifies whether the input represents a portal polygon or its contents, affecting how PView::DrawPortal processes it.</param>
    public void DrawPortal(ACBindings.Internal.CPortalPoly* portal, int check, int portalPolyOrPortalContents) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderDeviceD3D, ACBindings.Internal.CPortalPoly*, int, int, void>)0x005A01F0)(ref this, portal, check, portalPolyOrPortalContents);

    /// <summary>Draws all land polygons contained in the specified cell using the current Direct3D device.
    /// <code>Offset: 0x005A0230
    /// void __thiscall RenderDeviceD3D::DrawLandCell(RenderDeviceD3D*,CLandCell*)</code>
    /// </summary>
    /// <param name="cell">The land cell whose polygons should be rendered.</param>
    public void DrawLandCell(ACBindings.Internal.CLandCell* cell) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderDeviceD3D, ACBindings.Internal.CLandCell*, void>)0x005A0230)(ref this, cell);

    /// <summary>Renders a sorting cell by first drawing its associated building (if any) and then rendering the cell’s object geometry.
    /// <code>Offset: 0x005A0250
    /// void __thiscall RenderDeviceD3D::DrawSortCell(RenderDeviceD3D*,CSortCell*)</code>
    /// </summary>
    /// <param name="cell">The sorting cell that may contain a building reference and an object cell to be drawn.</param>
    public void DrawSortCell(ACBindings.Internal.CSortCell* cell) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderDeviceD3D, ACBindings.Internal.CSortCell*, void>)0x005A0250)(ref this, cell);

    /// <summary>Renders an environment cell onto the current Direct3D context, initializing lighting, detail surfaces, and drawing either a pre-built mesh or its polygon list if it has not already been drawn this frame.
    /// <code>Offset: 0x005A0280
    /// void __thiscall RenderDeviceD3D::DrawEnvCell(RenderDeviceD3D*,CEnvCell*)</code>
    /// </summary>
    /// <param name="cell">The environment cell to render. The function marks the cell as rendered for the current frame and sets up the rendering state accordingly.</param>
    public void DrawEnvCell(ACBindings.Internal.CEnvCell* cell) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderDeviceD3D, ACBindings.Internal.CEnvCell*, void>)0x005A0280)(ref this, cell);

    /// <summary>Renders a building object by setting detail surface and blending parameters, flushing alpha lists, and invoking the physics part drawing routines.
    /// <code>Offset: 0x005A03B0
    /// void __thiscall RenderDeviceD3D::DrawBuilding(RenderDeviceD3D*,CBuildingObj*)</code>
    /// </summary>
    /// <param name="building">The CBuildingObj instance representing the building to render.</param>
    public void DrawBuilding(ACBindings.Internal.CBuildingObj* building) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderDeviceD3D, ACBindings.Internal.CBuildingObj*, void>)0x005A03B0)(ref this, building);

    /// <summary>Draws the specified CGfxObj mesh while handling physics part deduplication, optional sunlight minimization, and portal rendering during building passes.
    /// <code>Offset: 0x005A0470
    /// ObjectDrawStatus __thiscall RenderDeviceD3D::DrawMeshInternal(RenderDeviceD3D*,CGfxObj*,bool,BoundingType)</code>
    /// </summary>
    /// <param name="i_pObj">The graphics object to render. The function uses its built‑mesh data when available.</param>
    /// <param name="i_bBuilding">True if the call occurs during a building pass; otherwise false.</param>
    /// <param name="i_bt">Bounding type used for culling decisions (not directly referenced in this implementation).</param>
    /// <returns>ObjectDrawStatus indicating whether the object was drawn or skipped. The value 2 typically denotes a successful draw or skip due to prior rendering.</returns>
    public ACBindings.Internal.ObjectDrawStatus DrawMeshInternal(ACBindings.Internal.CGfxObj* i_pObj, byte i_bBuilding, ACBindings.Internal.BoundingType i_bt) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderDeviceD3D, ACBindings.Internal.CGfxObj*, byte, ACBindings.Internal.BoundingType, ACBindings.Internal.ObjectDrawStatus>)0x005A0470)(ref this, i_pObj, i_bBuilding, i_bt);

    /// <summary>Creates a new render surface for the current device by allocating memory and initializing its internal state.
    /// <code>Offset: 0x005A0520
    /// RenderSurface* __thiscall RenderDeviceD3D::CreateSurface(RenderDeviceD3D*)</code>
    /// </summary>
    /// <returns>A pointer to the newly constructed RenderSurface object, or nullptr if allocation fails.</returns>
    public ACBindings.Internal.RenderSurface* CreateSurface() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderDeviceD3D, ACBindings.Internal.RenderSurface*>)0x005A0520)(ref this);

    /// <summary>Creates a new render texture for this device.
    /// <code>Offset: 0x005A0540
    /// RenderTexture* __thiscall RenderDeviceD3D::CreateTexture(RenderDeviceD3D*)</code>
    /// </summary>
    /// <returns>A pointer to the newly allocated RenderTexture instance, or nullptr if allocation fails.</returns>
    public ACBindings.Internal.RenderTexture* CreateTexture() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderDeviceD3D, ACBindings.Internal.RenderTexture*>)0x005A0540)(ref this);

    /// <summary>Creates a new index buffer object associated with this render device, performing base and D3D-specific initialization.
    /// <code>Offset: 0x005A0560
    /// RenderIndexBuffer* __thiscall RenderDeviceD3D::CreateIndexBuffer(RenderDeviceD3D*)</code>
    /// </summary>
    /// <returns>Pointer to the newly created RenderIndexBuffer on success; null if allocation fails.</returns>
    public ACBindings.Internal.RenderIndexBuffer* CreateIndexBuffer() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderDeviceD3D, ACBindings.Internal.RenderIndexBuffer*>)0x005A0560)(ref this);

    /// <summary>Sets the specified vertex stream on the Direct3D device by binding the vertex buffer from RenderVertexStreamD3D and configuring its format.
    /// <code>Offset: 0x005A05A0
    /// void __thiscall RenderDeviceD3D::SetVertexStream(RenderDeviceD3D*,const unsigned int,RenderVertexStreamD3D*)</code>
    /// </summary>
    /// <param name="StreamIndex">The zero-based index of the vertex stream slot to set.</param>
    /// <param name="pStream">The vertex stream containing the vertex buffer and layout information.</param>
    public void SetVertexStream(uint StreamIndex, ACBindings.Internal.RenderVertexStreamD3D* pStream) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderDeviceD3D, uint, ACBindings.Internal.RenderVertexStreamD3D*, void>)0x005A05A0)(ref this, StreamIndex, pStream);

    /// <summary>Determines whether the Direct3D device can be reset by testing interface support and updates device loss status.
    /// <code>Offset: 0x005A05E0
    /// bool __thiscall RenderDeviceD3D::IsResetPossible(RenderDeviceD3D*)</code>
    /// </summary>
    /// <returns>True if a reset is possible; false if the device is considered lost, setting m_bDeviceLost to true.</returns>
    public byte IsResetPossible() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderDeviceD3D, byte>)0x005A05E0)(ref this);

    /// <summary>Applies the vertex format described by VertexFormatInfo to the Direct3D device.
    /// <code>Offset: 0x005A0610
    /// void __thiscall RenderDeviceD3D::ApplyVertexFormat(RenderDeviceD3D*,const VertexFormatInfo*)</code>
    /// </summary>
    /// <param name="VFI">Vertex format information containing the DirectX format identifier used for rendering.</param>
    public void ApplyVertexFormat(ACBindings.Internal.VertexFormatInfo* VFI) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderDeviceD3D, ACBindings.Internal.VertexFormatInfo*, void>)0x005A0610)(ref this, VFI);

    /// <summary>Detects and populates the Direct3D9 device capabilities into the RenderDeviceD3D structure, translating raw D3DCAPS9 fields into higher‑level flags and limits for use by the rendering system.
    /// <code>Offset: 0x005A0630
    /// bool __thiscall RenderDeviceD3D::DetectDeviceCaps(RenderDeviceD3D*)</code>
    /// </summary>
    /// <returns>True upon completion; the method fills m_caps with supported features and may enable single‑pass detailing if conditions are met.</returns>
    public byte DetectDeviceCaps() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderDeviceD3D, byte>)0x005A0630)(ref this);

    /// <summary>Configures the rendering viewport on the Direct3D device with the specified position and size, optionally applying automatic aspect‑ratio adjustment.
    /// <code>Offset: 0x005A0800
    /// void __thiscall RenderDeviceD3D::SetViewport(RenderDeviceD3D*,unsigned int,unsigned int,unsigned int,unsigned int,bool)</code>
    /// </summary>
    /// <param name="x">The horizontal offset of the viewport within the render target.</param>
    /// <param name="y">The vertical offset of the viewport within the render target.</param>
    /// <param name="width">The width in pixels of the viewport.</param>
    /// <param name="height">The height in pixels of the viewport.</param>
    /// <param name="i_UseAutoAspect">If true, automatically adjusts the viewport to maintain the device’s aspect ratio; otherwise uses the supplied dimensions unchanged.</param>
    public void SetViewport(uint x, uint y, uint width, uint height, byte i_UseAutoAspect) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderDeviceD3D, uint, uint, uint, uint, byte, void>)0x005A0800)(ref this, x, y, width, height, i_UseAutoAspect);

    /// <summary>Selects the first pixel format from a preference list that is compatible with the device for the given usage and resource type, returning zero if no match exists.
    /// <code>Offset: 0x005A0880
    /// PixelFormatID __thiscall RenderDeviceD3D::SelectPixelFormat(RenderDeviceD3D*,const PixelFormatID,const unsigned int,const _D3DRESOURCETYPE,const bool,const unsigned __int8*,const unsigned int)</code>
    /// </summary>
    /// <param name="displayFormat">Desired pixel format for the surface to be created or used.</param>
    /// <param name="usage">Flags indicating how the surface will be employed (e.g., render target, texture).</param>
    /// <param name="resource">Direct3D resource type such as texture or depth stencil.</param>
    /// <param name="use32">If true, 32‑bit formats may be chosen; if false those options are skipped.</param>
    /// <param name="formats">Array of preference identifiers that map to specific PixelFormatID values; indices 0–2 represent 32‑bit formats and are considered only when use32 is true.</param>
    /// <param name="numFormats">Number of elements in the formats array.</param>
    /// <returns>The first compatible PixelFormatID found, or 0 if none meet the criteria.</returns>
    public ACBindings.Internal.PixelFormatID SelectPixelFormat(ACBindings.Internal.PixelFormatID displayFormat, uint usage, ACBindings.Internal._D3DRESOURCETYPE resource, byte use32, byte* formats, uint numFormats) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderDeviceD3D, ACBindings.Internal.PixelFormatID, uint, ACBindings.Internal._D3DRESOURCETYPE, byte, byte*, uint, ACBindings.Internal.PixelFormatID>)0x005A0880)(ref this, displayFormat, usage, resource, use32, formats, numFormats);

    /// <summary>Selects and configures suitable pixel formats for render targets, textures, surfaces and low‑quality variants based on the supplied display format. The chosen formats are stored in the device’s display info structure.
    /// <code>Offset: 0x005A0980
    /// bool __thiscall RenderDeviceD3D::ChoosePixelFormats(RenderDeviceD3D*,const PixelFormatID)</code>
    /// </summary>
    /// <param name="displayFormat">The desired display pixel format to base all selections on.</param>
    /// <returns>True if format selection succeeded; otherwise false (never occurs).</returns>
    public byte ChoosePixelFormats(ACBindings.Internal.PixelFormatID displayFormat) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderDeviceD3D, ACBindings.Internal.PixelFormatID, byte>)0x005A0980)(ref this, displayFormat);

    /// <summary>Checks whether a display mode matching the specified pixel format and, when in fullscreen, the current presentation resolution exists for this device. If a suitable mode is found, returns true and optionally updates the supplied optimal refresh rate to the highest value that does not exceed the desired limit.
    /// <code>Offset: 0x005A0BC0
    /// bool __thiscall RenderDeviceD3D::CheckDisplayModes(RenderDeviceD3D*,const PixelFormatID,const unsigned int,unsigned int*)</code>
    /// </summary>
    /// <param name="displayFormat">The pixel format to query for available display modes.</param>
    /// <param name="DesiredRefreshRate">The maximum acceptable refresh rate; if multiple matching modes exist, the returned optimal refresh rate will be the largest value that does not exceed this limit.</param>
    /// <param name="optimalRefreshRate">Output parameter. Receives the highest refresh rate found among qualifying modes that is ≤ DesiredRefreshRate; set to 0 if no such mode exists.</param>
    /// <returns>True if a matching display mode is available (or if the device is not in fullscreen mode); otherwise, false.</returns>
    public byte CheckDisplayModes(ACBindings.Internal.PixelFormatID displayFormat, uint DesiredRefreshRate, uint* optimalRefreshRate) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderDeviceD3D, ACBindings.Internal.PixelFormatID, uint, uint*, byte>)0x005A0BC0)(ref this, displayFormat, DesiredRefreshRate, optimalRefreshRate);

    /// <summary>Releases Direct3D rendering resources owned by this device, including vertex buffers, swap chains, and solid‑color textures, and resets the corresponding member pointers to null.
    /// <code>Offset: 0x005A0C80
    /// void __thiscall RenderDeviceD3D::ReleaseD3DResources(RenderDeviceD3D*)</code>
    /// </summary>
    public void ReleaseD3DResources() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderDeviceD3D, void>)0x005A0C80)(ref this);

    /// <summary>Sets the device’s display aspect ratio according to rendering preferences. For preset modes, it applies a fixed 4:3 (1.333…) or 16:9 (1.777…) ratio; otherwise it calculates the ratio from the current screen width and height.
    /// <code>Offset: 0x005A0CE0
    /// void __thiscall RenderDeviceD3D::SetupDisplayAspectRatio(RenderDeviceD3D*)</code>
    /// </summary>
    public void SetupDisplayAspectRatio() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderDeviceD3D, void>)0x005A0CE0)(ref this);

    /// <summary>Applies the specified MIPMAP LOD bias to all sampler units in the device.
    /// <code>Offset: 0x005A0D60
    /// void __thiscall RenderDeviceD3D::SetMipmapLODBiasForAllSamplers(RenderDeviceD3D*,const float)</code>
    /// </summary>
    /// <param name="Bias">The bias value applied uniformly across every sampler.</param>
    public void SetMipmapLODBiasForAllSamplers(float Bias) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderDeviceD3D, float, void>)0x005A0D60)(ref this, Bias);

    /// <summary>Begins a new rendering scene by initializing the Direct3D device state, selecting the appropriate fill mode according to the current wireframe setting, and configuring the texture sampler’s mip‑level of detail bias if the scene is not already open.
    /// <code>Offset: 0x005A0D90
    /// void __thiscall RenderDeviceD3D::BeginScene(RenderDeviceD3D*)</code>
    /// </summary>
    public void BeginScene() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderDeviceD3D, void>)0x005A0D90)(ref this);

    /// <summary>Ends the currently active rendering scene by invoking necessary cleanup on the Direct3D device and clearing the open‑scene flag.
    /// <code>Offset: 0x005A0E10
    /// void __thiscall RenderDeviceD3D::EndScene(RenderDeviceD3D*)</code>
    /// </summary>
    public void EndScene() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderDeviceD3D, void>)0x005A0E10)(ref this);

    /// <summary>Temporarily adjusts the viewport to cover the entire rendering surface, clears the selected buffers (render target, depth buffer, or stencil buffer) with the supplied color and depth value, then restores the original viewport.
    /// <code>Offset: 0x005A0E40
    /// void __thiscall RenderDeviceD3D::Clear(RenderDeviceD3D*,unsigned int,const RGBAColor*,const float)</code>
    /// </summary>
    /// <param name="clearFlags">Bitmask selecting which buffers to clear: bit 0 enables clearing the render target; bit 1 clears the stencil buffer if one is available; bit 2 clears the depth buffer.</param>
    /// <param name="color">Pointer to an RGBAColor structure that provides the clear color for the render target.</param>
    /// <param name="depth">Depth value applied when clearing the depth buffer.</param>
    public void Clear(uint clearFlags, ACBindings.Internal.RGBAColor* color, float depth) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderDeviceD3D, uint, ACBindings.Internal.RGBAColor*, float, void>)0x005A0E40)(ref this, clearFlags, color, depth);

    /// <summary>Flips the primary swap chain to present a new frame, handling device loss, resetting stage textures and dynamic buffers, and advancing the internal frame counter.
    /// <code>Offset: 0x005A0F60
    /// void __thiscall RenderDeviceD3D::Flip(RenderDeviceD3D*)</code>
    /// </summary>
    public void Flip() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderDeviceD3D, void>)0x005A0F60)(ref this);

    /// <summary>Updates the Direct3D device’s current material, optionally forcing a change even if the same material is already active. When no material is supplied, reverts to the default material.
    /// <code>Offset: 0x005A0FF0
    /// void __thiscall RenderDeviceD3D::SetCurrentMaterial(RenderDeviceD3D*,const CMaterial*,bool)</code>
    /// </summary>
    /// <param name="material">The material to apply; if null, the default material is used.</param>
    /// <param name="force">If true forces the device to update its material state even when the new material matches the current one.</param>
    public void SetCurrentMaterial(ACBindings.Internal.CMaterial* material, byte force) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderDeviceD3D, ACBindings.Internal.CMaterial*, byte, void>)0x005A0FF0)(ref this, material, force);

    /// <summary>Updates the device's solid‑color texture to the specified 32‑bit ARGB color when the current color differs or a forced update is requested.
    /// <code>Offset: 0x005A1080
    /// bool __thiscall RenderDeviceD3D::SetSolidColorTextureColor(RenderDeviceD3D*,unsigned int,bool)</code>
    /// </summary>
    /// <param name="color">The new color for the solid‑color texture.</param>
    /// <param name="force">If true, forces an update even if the color has not changed.</param>
    /// <returns>True on success; false if acquiring or updating the texture fails.</returns>
    public byte SetSolidColorTextureColor(uint color, byte force) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderDeviceD3D, uint, byte, byte>)0x005A1080)(ref this, color, force);

    /// <summary>Configures the DirectX9 device with a predefined set of default rendering state values, including blend modes, depth testing, lighting, sampler settings, and texture stages.
    /// <code>Offset: 0x005A10F0
    /// bool __thiscall RenderDeviceD3D::SetDefaultDeviceStates(RenderDeviceD3D*)</code>
    /// </summary>
    /// <returns>True after applying the default state configuration.</returns>
    public byte SetDefaultDeviceStates() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderDeviceD3D, byte>)0x005A10F0)(ref this);

    /// <summary>Sets the current render and optional depth‑stencil surfaces on the Direct3D device, updating internal state and viewport dimensions.
    /// <code>Offset: 0x005A1260
    /// void __thiscall RenderDeviceD3D::SetRenderTarget(RenderDeviceD3D*,const unsigned int,RenderSurface*,RenderSurface*)</code>
    /// </summary>
    /// <param name="Index">Specifies the render target slot to bind (used for multi‑target rendering).</param>
    /// <param name="pRenderTarget">Surface that receives rendered color output.</param>
    /// <param name="pDepthStencilTarget">Optional depth‑stencil surface; may be null to remove the current depth buffer.</param>
    public void SetRenderTarget(uint Index, ACBindings.Internal.RenderSurface* pRenderTarget, ACBindings.Internal.RenderSurface* pDepthStencilTarget) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderDeviceD3D, uint, ACBindings.Internal.RenderSurface*, ACBindings.Internal.RenderSurface*, void>)0x005A1260)(ref this, Index, pRenderTarget, pDepthStencilTarget);

    /// <summary>Creates a render surface that mirrors the front buffer of the Direct3D device and returns it.
    /// <code>Offset: 0x005A1320
    /// RenderSurface* __thiscall RenderDeviceD3D::GenerateSurfaceFromFrontBuffer(RenderDeviceD3D*)</code>
    /// </summary>
    /// <returns>A RenderSurface instance representing the current front buffer, or null when creation fails or the device is lost.</returns>
    public ACBindings.Internal.RenderSurface* GenerateSurfaceFromFrontBuffer() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderDeviceD3D, ACBindings.Internal.RenderSurface*>)0x005A1320)(ref this);

    /// <summary>Finalizes rendering of queued debug text by drawing font primitives with appropriate texture and filtering settings, then clears the vertex buffer and resets the ready flag.
    /// <code>Offset: 0x005A1390
    /// void __thiscall RenderDeviceD3D::EndRenderingDebugText(RenderDeviceD3D*)</code>
    /// </summary>
    public void EndRenderingDebugText() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderDeviceD3D, void>)0x005A1390)(ref this);

    /// <summary>Renders debug text at the specified viewport coordinates using the device's debug font and a 32‑bit color.
    /// <code>Offset: 0x005A13A0
    /// void __thiscall RenderDeviceD3D::RenderDebugText(RenderDeviceD3D*,const int,const int,const char*,const unsigned int)</code>
    /// </summary>
    /// <param name="ViewportX">The horizontal coordinate in the current viewport where the text begins.</param>
    /// <param name="ViewportY">The vertical coordinate in the current viewport where the text begins.</param>
    /// <param name="pText">Null‑terminated string containing the text to display.</param>
    /// <param name="Color32">32‑bit ARGB color specifying the text's appearance.</param>
    public void RenderDebugText(int ViewportX, int ViewportY, sbyte* pText, uint Color32) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderDeviceD3D, int, int, sbyte*, uint, void>)0x005A13A0)(ref this, ViewportX, ViewportY, pText, Color32);

    /// <summary>Renders a batch of primitives using Direct3D hardware by binding the supplied vertex stream and issuing a draw call.
    /// <code>Offset: 0x005A13D0
    /// bool __thiscall RenderDeviceD3D::RenderPrimitivesInHardware(RenderDeviceD3D*,const PrimType,const unsigned int,RenderVertexStreamD3D*,const unsigned int,const unsigned int,const unsigned int)</code>
    /// </summary>
    /// <param name="PrimType">The type of primitive (e.g., point list, line list, triangle list) to render.</param>
    /// <param name="NumPrimitives">Number of primitives to render.</param>
    /// <param name="VertexStream">Pointer to the vertex stream containing vertex data.</param>
    /// <param name="VertexStreamFrameID">Expected frame identifier for the vertex stream; rendering is skipped if mismatched.</param>
    /// <param name="FirstRemoteVertexIndex">Starting index within the vertex buffer from which drawing begins.</param>
    /// <param name="NumVertices">Total vertices in the stream (currently unused by this function).</param>
    /// <returns>True when the underlying Direct3D call succeeds; otherwise false.</returns>
    public byte RenderPrimitivesInHardware(ACBindings.Internal.PrimType PrimType, uint NumPrimitives, ACBindings.Internal.RenderVertexStreamD3D* VertexStream, uint VertexStreamFrameID, uint FirstRemoteVertexIndex, uint NumVertices) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderDeviceD3D, ACBindings.Internal.PrimType, uint, ACBindings.Internal.RenderVertexStreamD3D*, uint, uint, uint, byte>)0x005A13D0)(ref this, PrimType, NumPrimitives, VertexStream, VertexStreamFrameID, FirstRemoteVertexIndex, NumVertices);

    /// <summary>Renders a dynamic set of primitives using the supplied vertex data and format, allocating an appropriate vertex stream and issuing a hardware draw call.
    /// <code>Offset: 0x005A1460
    /// bool __thiscall RenderDeviceD3D::RenderDynamicPrimitives(RenderDeviceD3D*,const PrimType,const unsigned int,const void*,const unsigned int)</code>
    /// </summary>
    /// <param name="PrimType">Specifies the primitive type (e.g., point list, line list, triangle strip).</param>
    /// <param name="NumPrimitives">Number of primitives to render.</param>
    /// <param name="pVertices">Pointer to an array containing vertex data in the format described by VertexFormat.</param>
    /// <param name="VertexFormat">Descriptor that defines the layout and attributes of each vertex.</param>
    /// <returns>True if the rendering operation succeeded; otherwise, false.</returns>
    public byte RenderDynamicPrimitives(ACBindings.Internal.PrimType PrimType, uint NumPrimitives, void* pVertices, uint VertexFormat) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderDeviceD3D, ACBindings.Internal.PrimType, uint, void*, uint, byte>)0x005A1460)(ref this, PrimType, NumPrimitives, pVertices, VertexFormat);

    /// <summary>Draws primitives directly from supplied vertex data using the specified primitive type.
    /// <code>Offset: 0x005A1520
    /// HRESULT __cdecl RenderDeviceD3D::DrawPrimitiveUP(_D3DPRIMITIVETYPE,unsigned int,const void*,unsigned int)</code>
    /// </summary>
    /// <param name="PrimitiveType">Specifies the D3D primitive type to render (e.g., triangle list, line strip).</param>
    /// <param name="nNumPrimitives">Number of primitives to draw.</param>
    /// <param name="pVertexStreamZeroData">Pointer to vertex data for stream zero.</param>
    /// <param name="VertexStreamZeroStride">Byte stride between consecutive vertices in the buffer.</param>
    /// <returns>Returns S_FALSE (value 1) when primitive drawing is disabled; otherwise forwards to Direct3D DrawPrimitiveUP and returns its HRESULT indicating success or failure.</returns>
    public static int DrawPrimitiveUP(ACBindings.Internal._D3DPRIMITIVETYPE PrimitiveType, uint nNumPrimitives, void* pVertexStreamZeroData, uint VertexStreamZeroStride) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal._D3DPRIMITIVETYPE, uint, void*, uint, int>)0x005A1520)(PrimitiveType, nNumPrimitives, pVertexStreamZeroData, VertexStreamZeroStride);

    /// <summary>Determines whether the fixed‑function fog mode is active on this render device.
    /// <code>Offset: 0x005A1560
    /// bool __thiscall RenderDeviceD3D::GetFFFogEnable(RenderDeviceD3D*)</code>
    /// </summary>
    /// <returns>true if FFFog is enabled; otherwise false.</returns>
    public byte GetFFFogEnable() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderDeviceD3D, byte>)0x005A1560)(ref this);

    /// <summary>Indicates whether the device’s available video memory falls below predefined thresholds, signalling a low‑memory situation.
    /// <code>Offset: 0x005A1570
    /// bool __thiscall RenderDeviceD3D::IsAvailableVideoMemoryLow(RenderDeviceD3D*)</code>
    /// </summary>
    /// <returns>True if available video memory is considered low; otherwise, false.</returns>
    public byte IsAvailableVideoMemoryLow() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderDeviceD3D, byte>)0x005A1570)(ref this);

    /// <summary>Removes the specified Direct3D texture reference from all cached rendering stages, ensuring subsequent draws do not use an invalidated texture.
    /// <code>Offset: 0x005A15B0
    /// void __thiscall RenderDeviceD3D::InvalidateCachedTexturePointer(RenderDeviceD3D*,void*)</code>
    /// </summary>
    /// <param name="pD3DTexture">The Direct3D texture pointer to be cleared from the device's render state cache.</param>
    public void InvalidateCachedTexturePointer(System.IntPtr pD3DTexture) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderDeviceD3D, System.IntPtr, void>)0x005A15B0)(ref this, pD3DTexture);

    /// <summary>Invalidates the cached vertex buffer pointer if it references the given Direct3D 9 vertex buffer.
    /// <code>Offset: 0x005A15E0
    /// void __thiscall RenderDeviceD3D::InvalidateCachedVertexBufferPointer(RenderDeviceD3D*,void*)</code>
    /// </summary>
    /// <param name="pD3DVertexBuffer">The vertex buffer whose cached reference should be cleared when matched.</param>
    public void InvalidateCachedVertexBufferPointer(System.IntPtr pD3DVertexBuffer) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderDeviceD3D, System.IntPtr, void>)0x005A15E0)(ref this, pD3DVertexBuffer);

    /// <summary>Updates each shadow object in the given cell by computing its viewer distance and, when that distance exceeds 50 units, normalizes the heading vector before applying the update.
    /// <code>Offset: 0x005A17A0
    /// void __thiscall RenderDeviceD3D::UpdateObjCell(RenderDeviceD3D*,CObjCell*)</code>
    /// </summary>
    /// <param name="cell">The object cell whose shadow objects are processed for viewer-distance updates.</param>
    public void UpdateObjCell(ACBindings.Internal.CObjCell* cell) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderDeviceD3D, ACBindings.Internal.CObjCell*, void>)0x005A17A0)(ref this, cell);

    /// <summary>Updates the specified CObjCell and renders it using the base RenderDevice implementation, sorting its shadow parts when more than one exists.
    /// <code>Offset: 0x005A1870
    /// void __thiscall RenderDeviceD3D::DrawObjCellForDummies(RenderDeviceD3D*,CObjCell*)</code>
    /// </summary>
    /// <param name="this">The render device instance performing the drawing operation.</param>
    /// <param name="cell">The object cell to update and draw; must not be null.</param>
    public void DrawObjCellForDummies(ACBindings.Internal.CObjCell* cell) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderDeviceD3D, ACBindings.Internal.CObjCell*, void>)0x005A1870)(ref this, cell);

    /// <summary>Renders all shadow parts contained in a CPartCell for the specified leaf index.
    /// <code>Offset: 0x005A18B0
    /// void __thiscall RenderDeviceD3D::DrawPartCell(RenderDeviceD3D*,unsigned int,CPartCell*,unsigned int)</code>
    /// </summary>
    /// <param name="cellID">Identifier of the cell to render; currently unused within this method but may be relevant for higher‑level logic.</param>
    /// <param name="cell">The part cell whose shadow parts are drawn.</param>
    /// <param name="leaf_index">Index identifying the rendering context or leaf used when drawing each shadow part.</param>
    public void DrawPartCell(uint cellID, ACBindings.Internal.CPartCell* cell, uint leaf_index) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderDeviceD3D, uint, ACBindings.Internal.CPartCell*, uint, void>)0x005A18B0)(ref this, cellID, cell, leaf_index);

    /// <summary>Renders the specified building leaf by drawing its associated part cells while preserving and restoring rendering state.
    /// <code>Offset: 0x005A18F0
    /// void __thiscall RenderDeviceD3D::DrawBuildingLeaf(RenderDeviceD3D*,unsigned int)</code>
    /// </summary>
    /// <param name="leaf_index">Index of the leaf to render within the current building object.</param>
    public void DrawBuildingLeaf(uint leaf_index) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderDeviceD3D, uint, void>)0x005A18F0)(ref this, leaf_index);

    /// <summary>Renders a CGfxObj mesh with portal and view cone culling, returning an ObjectDrawStatus indicating visibility.
    /// <code>Offset: 0x005A1970
    /// ObjectDrawStatus __thiscall RenderDeviceD3D::DrawMesh(RenderDeviceD3D*,CGfxObj*,const Position*,bool)</code>
    /// </summary>
    /// <param name="i_pObj">The graphics object to render, containing geometry, material, and bounding information.</param>
    /// <param name="i_posObj">World-space position of the object used for spatial tests such as portals and view‑cone checks.</param>
    /// <param name="i_bBuilding">Flag indicating building mode; when true, objects outside the view cone are still drawn with special handling.</param>
    /// <returns>An ObjectDrawStatus value that reflects whether the mesh was fully visible, partially visible, or completely culled.</returns>
    public ACBindings.Internal.ObjectDrawStatus DrawMesh(ACBindings.Internal.CGfxObj* i_pObj, ACBindings.Internal.Position* i_posObj, byte i_bBuilding) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderDeviceD3D, ACBindings.Internal.CGfxObj*, ACBindings.Internal.Position*, byte, ACBindings.Internal.ObjectDrawStatus>)0x005A1970)(ref this, i_pObj, i_posObj, i_bBuilding);

    /// <summary>Initializes Direct3D 9 rendering resources for the device, creating frame buffer, render target, depth‑stencil surfaces, swap chain and a solid‑color texture.
    /// <code>Offset: 0x005A1B40
    /// bool __thiscall RenderDeviceD3D::GetD3DResources(RenderDeviceD3D*)</code>
    /// </summary>
    /// <returns>True if all resources were created successfully; otherwise false.</returns>
    public byte GetD3DResources() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderDeviceD3D, byte>)0x005A1B40)(ref this);

    /// <summary>Adjusts the device's gamma ramp based on a brightness value, optionally enabling calibration.
    /// <code>Offset: 0x005A1C80
    /// void __thiscall RenderDeviceD3D::SetGamma(RenderDeviceD3D*,const float,const bool)</code>
    /// </summary>
    /// <param name="fBrightness">Desired brightness level, clamped between –0.2 and 1.0.</param>
    /// <param name="bWantCalibration">If true, requests the hardware to perform gamma calibration during the update.</param>
    public void SetGamma(float fBrightness, byte bWantCalibration) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderDeviceD3D, float, byte, void>)0x005A1C80)(ref this, fBrightness, bWantCalibration);

    /// <summary>Configures the Direct3D device state to render a material layer, applying lighting, blending, depth testing, culling and texture stage settings based on the supplied parameters.
    /// <code>Offset: 0x005A1D80
    /// void __thiscall RenderDeviceD3D::SetupState(RenderDeviceD3D*,const MaterialLayer*,const MaterialLayer*,const unsigned int,const RGBAColor*,const RGBAColor*,const bool)</code>
    /// </summary>
    /// <param name="pReferenceLayer">Reference material layer that is currently unused but retained for compatibility with older code.</param>
    /// <param name="pLayer">Material layer whose properties are applied to configure the device state.</param>
    /// <param name="VertexFormat">Identifier of the vertex format; not used in this implementation.</param>
    /// <param name="DiffuseColorScale">Scaling factor applied to diffuse, specular and dye colors before they are sent to Direct3D.</param>
    /// <param name="AmbientLightBoost">Additional ambient light added to the renderer’s current ambient color.</param>
    /// <param name="ForceTranslucent">If true forces rendering as translucent by disabling alpha test and depth write when appropriate.</param>
    public void SetupState(ACBindings.Internal.MaterialLayer* pReferenceLayer, ACBindings.Internal.MaterialLayer* pLayer, uint VertexFormat, ACBindings.Internal.RGBAColor* DiffuseColorScale, ACBindings.Internal.RGBAColor* AmbientLightBoost, byte ForceTranslucent) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderDeviceD3D, ACBindings.Internal.MaterialLayer*, ACBindings.Internal.MaterialLayer*, uint, ACBindings.Internal.RGBAColor*, ACBindings.Internal.RGBAColor*, byte, void>)0x005A1D80)(ref this, pReferenceLayer, pLayer, VertexFormat, DiffuseColorScale, AmbientLightBoost, ForceTranslucent);

    /// <summary>Initializes the debug font used by the device, creating or replacing an existing texture-based font and setting its spacing values.
    /// <code>Offset: 0x005A2620
    /// bool __thiscall RenderDeviceD3D::InitDebugFont(RenderDeviceD3D*)</code>
    /// </summary>
    /// <returns>True if the font was created successfully; otherwise false.</returns>
    public byte InitDebugFont() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderDeviceD3D, byte>)0x005A2620)(ref this);

    /// <summary>Prepares the debug text system for rendering by ensuring the debug font is available, resetting the vertex buffer count, and marking the font ready for drawing.
    /// <code>Offset: 0x005A26A0
    /// void __thiscall RenderDeviceD3D::BeginRenderingDebugText(RenderDeviceD3D*)</code>
    /// </summary>
    public void BeginRenderingDebugText() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderDeviceD3D, void>)0x005A26A0)(ref this);

    /// <summary>
    /// Renders a series of primitives using the specified material and color, setting up rendering state per material layer before drawing.
    /// 
    /// <code>Offset: 0x005A26D0
    /// bool __thiscall RenderDeviceD3D::RenderDynamicPrimitivesUsingMaterial(RenderDeviceD3D*,const PrimType,const unsigned int,const void*,const unsigned int,const RenderMaterial*,const RenderMaterial*,const RGBAColor*)</code>
    /// </summary>
    /// <param name="PrimType">The type of primitives to render (e.g., triangle list).</param>
    /// <param name="NumPrimitives">Number of primitives to draw.</param>
    /// <param name="pVertices">Pointer to vertex data for the primitives.</param>
    /// <param name="VertexFormat">Vertex format descriptor used when rendering.</param>
    /// <param name="ReferenceMaterial">Base material providing default state information.</param>
    /// <param name="Material">Material whose layers are applied during rendering.</param>
    /// <param name="Color">Color overlay applied to each layer; if alpha is zero, rendering is skipped.</param>
    /// <returns>True if at least one primitive was successfully rendered; otherwise false.</returns>
    public byte RenderDynamicPrimitivesUsingMaterial(ACBindings.Internal.PrimType PrimType, uint NumPrimitives, void* pVertices, uint VertexFormat, ACBindings.Internal.RenderMaterial* ReferenceMaterial, ACBindings.Internal.RenderMaterial* Material, ACBindings.Internal.RGBAColor* Color) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderDeviceD3D, ACBindings.Internal.PrimType, uint, void*, uint, ACBindings.Internal.RenderMaterial*, ACBindings.Internal.RenderMaterial*, ACBindings.Internal.RGBAColor*, byte>)0x005A26D0)(ref this, PrimType, NumPrimitives, pVertices, VertexFormat, ReferenceMaterial, Material, Color);

    /// <summary>Renders the specified land block by drawing each of its constituent cells, updating shadow information, setting material modes, and issuing draw calls for terrain and objects.
    /// <code>Offset: 0x005A28D0
    /// void __thiscall RenderDeviceD3D::DrawBlock(RenderDeviceD3D*,CLandBlock*)</code>
    /// </summary>
    /// <param name="block">The land block to render.</param>
    public void DrawBlock(ACBindings.Internal.CLandBlock* block) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderDeviceD3D, ACBindings.Internal.CLandBlock*, void>)0x005A28D0)(ref this, block);

    /// <summary>Renders a CObjCell by delegating to DrawPartCell; when the supplied cell is null, renders a default part.
    /// <code>Offset: 0x005A2B50
    /// void __thiscall RenderDeviceD3D::DrawObjCell(RenderDeviceD3D*,CObjCell*)</code>
    /// </summary>
    /// <param name="this">The rendering device context.</param>
    /// <param name="cell">Object cell to render; if null, a fallback is drawn.</param>
    public void DrawObjCell(ACBindings.Internal.CObjCell* cell) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderDeviceD3D, ACBindings.Internal.CObjCell*, void>)0x005A2B50)(ref this, cell);

    /// <summary>Creates and initializes a new vertex buffer object for Direct3D rendering.
    /// <code>Offset: 0x005A2B80
    /// RenderVertexBufferD3D* __thiscall RenderDeviceD3D::CreateVertexBuffer(RenderDeviceD3D*)</code>
    /// </summary>
    /// <returns>A pointer to the newly created RenderVertexBufferD3D instance, or nullptr if memory allocation fails.</returns>
    public ACBindings.Internal.RenderVertexBufferD3D* CreateVertexBuffer() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderDeviceD3D, ACBindings.Internal.RenderVertexBufferD3D*>)0x005A2B80)(ref this);

    /// <summary>Responds to a change in the display mode by resetting aspect ratio, default states, and viewport; updates UI positions; reinitializes gamma for full‑screen mode; clears the screen three times while flipping the back buffer; pauses briefly between each clear.
    /// <code>Offset: 0x005A2BA0
    /// void __thiscall RenderDeviceD3D::OnDeviceDisplayModeChange(RenderDeviceD3D*)</code>
    /// </summary>
    public void OnDeviceDisplayModeChange() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderDeviceD3D, void>)0x005A2BA0)(ref this);

    /// <summary>Releases Direct3D resources associated with the device, cleans up indoor and outdoor PView objects, and unregisters related global variables.
    /// <code>Offset: 0x005A2C50
    /// void __thiscall RenderDeviceD3D::End(RenderDeviceD3D*)</code>
    /// </summary>
    public void End() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderDeviceD3D, void>)0x005A2C50)(ref this);

    /// <summary>Detects support for compressed texture formats on the current Direct3D device by testing DXT1–DXT5 against the specified display format, updates capability flags, and selects a compatible pixel format via ChoosePixelFormats.
    /// <code>Offset: 0x005A2CF0
    /// bool __thiscall RenderDeviceD3D::DetectDisplayFormats(RenderDeviceD3D*,const PixelFormatID)</code>
    /// </summary>
    /// <param name="displayFormat">The pixel format to test against when detecting supported compressed textures.</param>
    /// <returns>True if a suitable pixel format was found and chosen; otherwise false after logging an error message.</returns>
    public byte DetectDisplayFormats(ACBindings.Internal.PixelFormatID displayFormat) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderDeviceD3D, ACBindings.Internal.PixelFormatID, byte>)0x005A2CF0)(ref this, displayFormat);

    /// <summary>Configures the device's display parameters based on specified pixel format IDs, including render target, texture, depth buffer formats and stencil usage. Detects available display formats and updates internal display information accordingly.
    /// <code>Offset: 0x005A2DF0
    /// bool __thiscall RenderDeviceD3D::SetupDisplayInfo(RenderDeviceD3D*,const PixelFormatID,const PixelFormatID,const PixelFormatID,const bool,const bool)</code>
    /// </summary>
    /// <param name="displayFormat">Desired display pixel format ID.</param>
    /// <param name="colorFormat">Pixel format for color buffers or textures.</param>
    /// <param name="depthStencilFormat">Pixel format for depth/stencil buffer.</param>
    /// <param name="has8BitStencil">Indicates whether an 8‑bit stencil buffer should be enabled.</param>
    /// <param name="bFullScreen">Specifies full-screen mode (currently unused in this implementation).</param>
    /// <returns>True if the display formats were detected and information updated successfully; otherwise false.</returns>
    public byte SetupDisplayInfo(ACBindings.Internal.PixelFormatID displayFormat, ACBindings.Internal.PixelFormatID colorFormat, ACBindings.Internal.PixelFormatID depthStencilFormat, byte has8BitStencil, byte bFullScreen) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderDeviceD3D, ACBindings.Internal.PixelFormatID, ACBindings.Internal.PixelFormatID, ACBindings.Internal.PixelFormatID, byte, byte, byte>)0x005A2DF0)(ref this, displayFormat, colorFormat, depthStencilFormat, has8BitStencil, bFullScreen);

    /// <summary>Selects appropriate color and depth/stencil pixel formats for the device based on presentation settings and hardware capabilities.
    /// <code>Offset: 0x005A2EF0
    /// bool __thiscall RenderDeviceD3D::SelectBufferFormats(RenderDeviceD3D*,const RenderDevicePresentation*,PixelFormatID*,PixelFormatID*,unsigned int*)</code>
    /// </summary>
    /// <param name="renderPres">Presentation parameters including window handle, resolution, fullscreen mode, refresh rate, bits per pixel, etc.</param>
    /// <param name="colorFormat">Receives the chosen pixel format identifier for the color buffer.</param>
    /// <param name="depthStencilFormat">Receives the selected depth/stencil buffer format identifier.</param>
    /// <param name="optimalRefreshRate">Receives an optimal refresh rate if a suitable full‑screen mode is found; may remain unchanged otherwise.</param>
    /// <returns>True when formats are successfully chosen and device display information is set up; otherwise false.</returns>
    public byte SelectBufferFormats(ACBindings.Internal.RenderDevicePresentation* renderPres, ACBindings.Internal.PixelFormatID* colorFormat, ACBindings.Internal.PixelFormatID* depthStencilFormat, uint* optimalRefreshRate) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderDeviceD3D, ACBindings.Internal.RenderDevicePresentation*, ACBindings.Internal.PixelFormatID*, ACBindings.Internal.PixelFormatID*, uint*, byte>)0x005A2EF0)(ref this, renderPres, colorFormat, depthStencilFormat, optimalRefreshRate);

    /// <summary>Initializes a Direct3D 9 rendering device, setting default adapter, device type, capabilities, presentation rectangles, swap chain, and sampler mappings. Configures the state cache, registers debug variables, and prepares the device for rendering.
    /// <code>Offset: 0x005A3310
    /// void __thiscall RenderDeviceD3D::Begin(RenderDeviceD3D*)</code>
    /// </summary>
    public void Begin() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderDeviceD3D, void>)0x005A3310)(ref this);

    /// <summary>Shuts down the Direct3D rendering device by releasing its underlying IDirect3DDevice9 and resetting internal state.
    /// <code>Offset: 0x005A3520
    /// void __thiscall RenderDeviceD3D::Shutdown(RenderDeviceD3D*)</code>
    /// </summary>
    public void Shutdown() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderDeviceD3D, void>)0x005A3520)(ref this);

    /// <summary>
    /// Configures the presentation parameters for a Direct3D9 rendering device based on supplied presentation settings and selected buffer formats, updating internal window and rectangle data.
    /// 
    /// <code>Offset: 0x005A3560
    /// bool __thiscall RenderDeviceD3D::SetupPresentation(RenderDeviceD3D*,const RenderDevicePresentation*,_D3DPRESENT_PARAMETERS_*)</code>
    /// </summary>
    /// <param name="this">The RenderDeviceD3D instance being configured.</param>
    /// <param name="renderPres">Presentation options such as render window handle, resolution, fullscreen mode, antialiasing, and refresh rate.</param>
    /// <param name="present">Structure to receive the filled D3DPRESENT_PARAMETERS for device creation.</param>
    /// <returns>True when buffer formats are selected successfully and all parameters are valid; otherwise false.</returns>
    public byte SetupPresentation(ACBindings.Internal.RenderDevicePresentation* renderPres, System.IntPtr present) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderDeviceD3D, ACBindings.Internal.RenderDevicePresentation*, System.IntPtr, byte>)0x005A3560)(ref this, renderPres, present);

    /// <summary>Resets the Direct3D rendering device with a new presentation configuration, releasing existing resources and recreating the swap chain and related objects.
    /// <code>Offset: 0x005A3780
    /// bool __thiscall RenderDeviceD3D::ResetDevice(RenderDeviceD3D*,const RenderDevicePresentation*)</code>
    /// </summary>
    /// <param name="newPres">The presentation settings to apply during the reset process.</param>
    /// <returns>True if the device was successfully reset; otherwise false.</returns>
    public byte ResetDevice(ACBindings.Internal.RenderDevicePresentation* newPres) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderDeviceD3D, ACBindings.Internal.RenderDevicePresentation*, byte>)0x005A3780)(ref this, newPres);

    /// <summary>Initializes a Direct3D rendering device for the specified display adapter and presentation settings. Detects hardware capabilities, configures swap‑chain parameters, attempts to create the D3D9 device with fallback options, loads required resources, and prepares a debug font for rendering.
    /// <code>Offset: 0x005A3910
    /// bool __thiscall RenderDeviceD3D::Startup(RenderDeviceD3D*,const unsigned int,const RenderDevicePresentation*,const RenderDeviceConfig*)</code>
    /// </summary>
    /// <param name="nDisplayAdapter">Index of the video adapter to use.</param>
    /// <param name="presentation">Pointer to presentation settings such as window handle, width, height and fullscreen mode.</param>
    /// <param name="config">Pointer to device configuration options including focus window and pure device flag.</param>
    /// <returns>True if the device was created and initialized successfully; otherwise false.</returns>
    public byte Startup(uint nDisplayAdapter, ACBindings.Internal.RenderDevicePresentation* presentation, ACBindings.Internal.RenderDeviceConfig* config) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderDeviceD3D, uint, ACBindings.Internal.RenderDevicePresentation*, ACBindings.Internal.RenderDeviceConfig*, byte>)0x005A3910)(ref this, nDisplayAdapter, presentation, config);

    /// <summary>Enables or disables alpha blending on the D3D device and updates the cached state.
    /// <code>Offset: 0x005A3BA0
    /// void __thiscall RenderDeviceD3D::SetAlphaBlendEnable(RenderDeviceD3D*,const bool)</code>
    /// </summary>
    /// <param name="bValue">True to enable alpha blending, false to disable it.</param>
    public void SetAlphaBlendEnable(byte bValue) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderDeviceD3D, byte, void>)0x005A3BA0)(ref this, bValue);

    /// <summary>Enables or disables alpha testing on the Direct3D device and updates the internal render state cache.
    /// <code>Offset: 0x005A3BE0
    /// void __thiscall RenderDeviceD3D::SetAlphaTestEnable(RenderDeviceD3D*,const bool)</code>
    /// </summary>
    /// <param name="bValue">True to enable alpha testing, false to disable.</param>
    public void SetAlphaTestEnable(byte bValue) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderDeviceD3D, byte, void>)0x005A3BE0)(ref this, bValue);

    /// <summary>Sets the alpha test function used by the Direct3D device to determine pixel visibility based on alpha values.
    /// <code>Offset: 0x005A3C20
    /// void __thiscall RenderDeviceD3D::SetAlphaTestFunction(RenderDeviceD3D*,const AlphaTestFunc)</code>
    /// </summary>
    /// <param name="Value">The comparison function that specifies how source alpha is tested against a reference value for subsequent rendering operations.</param>
    public void SetAlphaTestFunction(ACBindings.Internal.AlphaTestFunc Value) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderDeviceD3D, ACBindings.Internal.AlphaTestFunc, void>)0x005A3C20)(ref this, Value);

    /// <summary>Sets the alpha‑test reference value used by the Direct3D device, updating internal state only when necessary or forced.
    /// <code>Offset: 0x005A3C60
    /// void __thiscall RenderDeviceD3D::SetAlphaTestRef(RenderDeviceD3D*,const unsigned int)</code>
    /// </summary>
    /// <param name="Value">The new reference value applied during alpha testing.</param>
    public void SetAlphaTestRef(uint Value) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderDeviceD3D, uint, void>)0x005A3C60)(ref this, Value);

    /// <summary>Sets source and destination blend modes, blend operation, and alpha‑blend enable state for the Direct3D device; applies changes only when values differ from cached state or forcing is requested.
    /// <code>Offset: 0x005A3CA0
    /// void __thiscall RenderDeviceD3D::SetBlendFunction(RenderDeviceD3D*,const BlendMode,const BlendMode,const BlendOpType)</code>
    /// </summary>
    /// <param name="SourceFactor">Blend factor applied to incoming pixel color.</param>
    /// <param name="DestFactor">Blend factor applied to existing framebuffer content.</param>
    /// <param name="Op">Operation used to combine source and destination colors.</param>
    public void SetBlendFunction(ACBindings.Internal.BlendMode SourceFactor, ACBindings.Internal.BlendMode DestFactor, ACBindings.Internal.BlendOpType Op) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderDeviceD3D, ACBindings.Internal.BlendMode, ACBindings.Internal.BlendMode, ACBindings.Internal.BlendOpType, void>)0x005A3CA0)(ref this, SourceFactor, DestFactor, Op);

    /// <summary>Changes the face‑culling mode for the Direct3D device, updating the internal state cache and applying the change when required.
    /// <code>Offset: 0x005A3D80
    /// void __thiscall RenderDeviceD3D::SetCullMode(RenderDeviceD3D*,const CullModeType)</code>
    /// </summary>
    /// <param name="Value">The desired cull mode (e.g., back, front, none).</param>
    public void SetCullMode(ACBindings.Internal.CullModeType Value) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderDeviceD3D, ACBindings.Internal.CullModeType, void>)0x005A3D80)(ref this, Value);

    /// <summary>Sets the slope‑scale depth bias on the Direct3D device when supported by the hardware.
    /// <code>Offset: 0x005A3DC0
    /// void __thiscall RenderDeviceD3D::SetDepthBias(RenderDeviceD3D*,const float)</code>
    /// </summary>
    /// <param name="Value">The bias value to apply; larger values increase the offset applied to depth values during rendering.</param>
    public void SetDepthBias(float Value) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderDeviceD3D, float, void>)0x005A3DC0)(ref this, Value);

    /// <summary>Calls QueryInterface on the Direct3D device, requesting an interface identified by a hard‑coded GUID (value 7), passing the boolean argument cast as a void**.
    /// <code>Offset: 0x005A3E00
    /// void __thiscall RenderDeviceD3D::SetDepthBufferEnable(RenderDeviceD3D*,const bool)</code>
    /// </summary>
    /// <param name="bValue">Boolean value cast to void** and supplied as the output pointer parameter to QueryInterface; its constness indicates it is not intended for modification.</param>
    public void SetDepthBufferEnable(byte bValue) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderDeviceD3D, byte, void>)0x005A3E00)(ref this, bValue);

    /// <summary>Sets the depth buffer configuration, selecting the depth test function and whether depth writes are enabled on the Direct3D device.
    /// <code>Offset: 0x005A3E20
    /// void __thiscall RenderDeviceD3D::SetDepthBufferMode(RenderDeviceD3D*,const DepthTestMode,const bool)</code>
    /// </summary>
    /// <param name="DepthTestMode">The depth comparison operation to use when evaluating fragments against the depth buffer (e.g., less, greater, always).</param>
    /// <param name="DepthWriteEnable">Indicates whether fragment depth values should be written to the depth buffer after passing the test.</param>
    public void SetDepthBufferMode(ACBindings.Internal.DepthTestMode DepthTestMode, byte DepthWriteEnable) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderDeviceD3D, ACBindings.Internal.DepthTestMode, byte, void>)0x005A3E20)(ref this, DepthTestMode, DepthWriteEnable);

    /// <summary>Sets the FF ambient color state on the Direct3D device, updating only when changed or forced.
    /// <code>Offset: 0x005A3EB0
    /// void __thiscall RenderDeviceD3D::SetFFAmbientColor32(RenderDeviceD3D*,const unsigned int)</code>
    /// </summary>
    /// <param name="Value">The 32‑bit ARGB color to apply as the FF ambient color.</param>
    public void SetFFAmbientColor32(uint Value) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderDeviceD3D, uint, void>)0x005A3EB0)(ref this, Value);

    /// <summary>Sets the diffuse color source used by the fixed‑function pipeline. If forcing state changes or the requested source differs from the current setting, updates internal state and queries the Direct3D device for the appropriate interface.
    /// <code>Offset: 0x005A3EF0
    /// void __thiscall RenderDeviceD3D::SetFFDiffuseColorSource(RenderDeviceD3D*,const ColorSource)</code>
    /// </summary>
    /// <param name="Value">The desired <c>ColorSource</c> value indicating where diffuse color is sourced (e.g., vertex data).</param>
    public void SetFFDiffuseColorSource(ACBindings.Internal.ColorSource Value) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderDeviceD3D, ACBindings.Internal.ColorSource, void>)0x005A3EF0)(ref this, Value);

    /// <summary>Configures the ambient color source for full‑frame rendering, updating the Direct3D device when the value changes or force states is enabled.
    /// <code>Offset: 0x005A3F40
    /// void __thiscall RenderDeviceD3D::SetFFAmbientColorSource(RenderDeviceD3D*,const ColorSource)</code>
    /// </summary>
    /// <param name="this">Pointer to the RenderDeviceD3D instance.</param>
    /// <param name="Value">Desired ColorSource enumeration indicating the source of the ambient color.</param>
    public void SetFFAmbientColorSource(ACBindings.Internal.ColorSource Value) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderDeviceD3D, ACBindings.Internal.ColorSource, void>)0x005A3F40)(ref this, Value);

    /// <summary>Enables or disables Fast Forward fog, updating internal state and notifying the Direct3D device when necessary.
    /// <code>Offset: 0x005A3F90
    /// void __thiscall RenderDeviceD3D::SetFFFogEnable(RenderDeviceD3D*,const bool)</code>
    /// </summary>
    /// <param name="bValue">Desired state for fog enablement; true to request enabling, false to disable.</param>
    public void SetFFFogEnable(byte bValue) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderDeviceD3D, byte, void>)0x005A3F90)(ref this, bValue);

    /// <summary>Disables or enables the FFFog system state for the device, updating internal cache and turning off fog rendering when disabled.
    /// <code>Offset: 0x005A3FE0
    /// void __thiscall RenderDeviceD3D::SetFFFogSystemDisabled(RenderDeviceD3D*,const bool)</code>
    /// </summary>
    /// <param name="this">The RenderDeviceD3D instance whose fog system state is modified.</param>
    /// <param name="bValue">True to disable the fog system; false to enable it.</param>
    public void SetFFFogSystemDisabled(byte bValue) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderDeviceD3D, byte, void>)0x005A3FE0)(ref this, bValue);

    /// <summary>Disables or enables user‑controlled fog by updating the device’s internal state; disabling immediately turns off fog rendering.
    /// <code>Offset: 0x005A4010
    /// void __thiscall RenderDeviceD3D::SetFFFogUserDisabled(RenderDeviceD3D*,const bool)</code>
    /// </summary>
    /// <param name="bValue">True to disable fog for the user, false to reenable it.</param>
    public void SetFFFogUserDisabled(byte bValue) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderDeviceD3D, byte, void>)0x005A4010)(ref this, bValue);

    /// <summary>Updates the Direct3D rendering state to enable or disable fog alpha, propagating the change to the underlying device when necessary.
    /// <code>Offset: 0x005A4040
    /// void __thiscall RenderDeviceD3D::SetFFFogAlphaDisabled(RenderDeviceD3D*,const bool)</code>
    /// </summary>
    /// <param name="bValue">True to disable fog alpha; false to allow it.</param>
    public void SetFFFogAlphaDisabled(byte bValue) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderDeviceD3D, byte, void>)0x005A4040)(ref this, bValue);

    /// <summary>Sets the color and near/far distances of the fog effect in the Direct3D device, updating state only when changed or forced.
    /// <code>Offset: 0x005A4080
    /// void __thiscall RenderDeviceD3D::SetFFFogProperties(RenderDeviceD3D*,const RGBAColor*,const float,const float)</code>
    /// </summary>
    /// <param name="Color">Pointer to an RGBAColor structure specifying the fog color.</param>
    /// <param name="NearDistance">The distance from the camera at which fog begins.</param>
    /// <param name="FarDistance">The distance from the camera at which fog fully obscures objects.</param>
    public void SetFFFogProperties(ACBindings.Internal.RGBAColor* Color, float NearDistance, float FarDistance) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderDeviceD3D, ACBindings.Internal.RGBAColor*, float, float, void>)0x005A4080)(ref this, Color, NearDistance, FarDistance);

    /// <summary>Configures the device's linear fog parameters—color, start distance, and end distance—from an RGBA union value.
    /// <code>Offset: 0x005A41B0
    /// void __thiscall RenderDeviceD3D::SetFFFogProperties(RenderDeviceD3D*,const RGBAUnion*,const float,const float)</code>
    /// </summary>
    /// <param name="Color">The fog color specified as an RGBAUnion structure.</param>
    /// <param name="NearDistance">The distance at which fog begins.</param>
    /// <param name="FarDistance">The distance at which fog fully saturates.</param>
    public void SetFFFogProperties(ACBindings.Internal.RGBAUnion* Color, float NearDistance, float FarDistance) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderDeviceD3D, ACBindings.Internal.RGBAUnion*, float, float, void>)0x005A41B0)(ref this, Color, NearDistance, FarDistance);

    /// <summary>Enables or disables forward‑facing lighting on the Direct3D9 device, updating the internal state cache if a change occurs.
    /// <code>Offset: 0x005A41F0
    /// void __thiscall RenderDeviceD3D::SetFFLighting(RenderDeviceD3D*,const bool)</code>
    /// </summary>
    /// <param name="bValue">True to enable FF lighting; false to disable.</param>
    public void SetFFLighting(byte bValue) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderDeviceD3D, byte, void>)0x005A41F0)(ref this, bValue);

    /// <summary>Enables or disables a fixed‑function light at the specified index, updating the device state if forced or changed.
    /// <code>Offset: 0x005A4230
    /// void __thiscall RenderDeviceD3D::SetFFLightEnable(RenderDeviceD3D*,const unsigned int,const bool)</code>
    /// </summary>
    /// <param name="Index">The zero‑based identifier of the lighting unit to modify.</param>
    /// <param name="bValue">True to enable the light; false to disable it.</param>
    public void SetFFLightEnable(uint Index, byte bValue) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderDeviceD3D, uint, byte, void>)0x005A4230)(ref this, Index, bValue);

    /// <summary>Configures the fixed‑function pipeline to use a specified source for specular lighting calculations.
    /// <code>Offset: 0x005A4280
    /// void __thiscall RenderDeviceD3D::SetFFSpecularColorSource(RenderDeviceD3D*,const ColorSource)</code>
    /// </summary>
    /// <param name="Value">Specifies whether specular color is derived from vertex data or another source (e.g., texture).</param>
    public void SetFFSpecularColorSource(ACBindings.Internal.ColorSource Value) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderDeviceD3D, ACBindings.Internal.ColorSource, void>)0x005A4280)(ref this, Value);

    /// <summary>Enables or disables fixed‑function specular lighting for the device.
    /// <code>Offset: 0x005A42D0
    /// void __thiscall RenderDeviceD3D::SetFFSpecularEnable(RenderDeviceD3D*,const bool)</code>
    /// </summary>
    /// <param name="bValue">True to enable FF specular; false to disable.</param>
    public void SetFFSpecularEnable(byte bValue) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderDeviceD3D, byte, void>)0x005A42D0)(ref this, bValue);

    /// <summary>Configures the fixed‑function pipeline to use the specified emissive color source during rendering.
    /// <code>Offset: 0x005A4310
    /// void __thiscall RenderDeviceD3D::SetFFEmissiveColorSource(RenderDeviceD3D*,const ColorSource)</code>
    /// </summary>
    /// <param name="Value">The desired emissive color source value.</param>
    public void SetFFEmissiveColorSource(ACBindings.Internal.ColorSource Value) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderDeviceD3D, ACBindings.Internal.ColorSource, void>)0x005A4310)(ref this, Value);

    /// <summary>Updates the device’s fixed-function pipeline with a new 32‑bit texture factor, forcing a Direct3D state change when required.
    /// <code>Offset: 0x005A4350
    /// void __thiscall RenderDeviceD3D::SetFFTextureFactor32(RenderDeviceD3D*,const unsigned int)</code>
    /// </summary>
    /// <param name="this">The RenderDeviceD3D instance whose state is being updated.</param>
    /// <param name="Value">The 32‑bit value to set as the FFTextureFactor32 state.</param>
    public void SetFFTextureFactor32(uint Value) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderDeviceD3D, uint, void>)0x005A4350)(ref this, Value);

    /// <summary>Sets the device's rendering fill mode to the specified value, updating Direct3D when the mode changes or is forced.
    /// <code>Offset: 0x005A4390
    /// void __thiscall RenderDeviceD3D::SetFillMode(RenderDeviceD3D*,const FillModeType)</code>
    /// </summary>
    /// <param name="Value">The desired fill mode (e.g., solid or wireframe).</param>
    public void SetFillMode(ACBindings.Internal.FillModeType Value) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderDeviceD3D, ACBindings.Internal.FillModeType, void>)0x005A4390)(ref this, Value);

    /// <summary>Sets the multisample anti‑aliasing flag on the Direct3D device, updating the internal render state when supported and respecting a forced‑state override.
    /// <code>Offset: 0x005A43D0
    /// void __thiscall RenderDeviceD3D::SetMultiSampleAntialias(RenderDeviceD3D*,const bool)</code>
    /// </summary>
    /// <param name="bValue">True to enable multisample anti‑aliasing; false to disable it.</param>
    public void SetMultiSampleAntialias(byte bValue) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderDeviceD3D, byte, void>)0x005A43D0)(ref this, bValue);

    /// <summary>Sets the texture addressing mode for a given sampler’s U and V axes in the underlying Direct3D device.
    /// <code>Offset: 0x005A4420
    /// void __thiscall RenderDeviceD3D::SetSamplerAddressMode(RenderDeviceD3D*,const unsigned int,const TexAddress,const TexAddress)</code>
    /// </summary>
    /// <param name="Sampler">Index of the texture sampler to configure.</param>
    /// <param name="AddressModeU">Desired address mode for the U coordinate (e.g., wrap, clamp).</param>
    /// <param name="AddressModeV">Desired address mode for the V coordinate.</param>
    public void SetSamplerAddressMode(uint Sampler, ACBindings.Internal.TexAddress AddressModeU, ACBindings.Internal.TexAddress AddressModeV) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderDeviceD3D, uint, ACBindings.Internal.TexAddress, ACBindings.Internal.TexAddress, void>)0x005A4420)(ref this, Sampler, AddressModeU, AddressModeV);

    /// <summary>Configures the magnification, minification, and mipmap filtering modes of a sampler on a Direct3D 9 device while respecting global texture filtering preferences and device capabilities.
    /// <code>Offset: 0x005A4460
    /// void __thiscall RenderDeviceD3D::SetSamplerFilterMode(RenderDeviceD3D*,const unsigned int,const TexFilterMode,const TexFilterMode,const TexFilterMode)</code>
    /// </summary>
    /// <param name="Sampler">Index or handle identifying the sampler to configure.</param>
    /// <param name="MagFilterMode">Desired magnification filter mode (e.g., linear or anisotropic).</param>
    /// <param name="MinFilterMode">Desired minification filter mode; may be overridden by anisotropy support and device caps.</param>
    /// <param name="MipFilterMode">Desired mipmap filtering mode, potentially adjusted to point filtering when no texture filtering is enabled.</param>
    public void SetSamplerFilterMode(uint Sampler, ACBindings.Internal.TexFilterMode MagFilterMode, ACBindings.Internal.TexFilterMode MinFilterMode, ACBindings.Internal.TexFilterMode MipFilterMode) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderDeviceD3D, uint, ACBindings.Internal.TexFilterMode, ACBindings.Internal.TexFilterMode, ACBindings.Internal.TexFilterMode, void>)0x005A4460)(ref this, Sampler, MagFilterMode, MinFilterMode, MipFilterMode);

    /// <summary>Sets the mip‑level–of‑detail bias on the Direct3D 9 device for the specified sampler.
    /// <code>Offset: 0x005A4520
    /// void __thiscall RenderDeviceD3D::SetSamplerMipmapLODBias(RenderDeviceD3D*,const unsigned int,const float)</code>
    /// </summary>
    /// <param name="Sampler">Index of the texture sampler to modify.</param>
    /// <param name="Bias">Desired LOD bias value; positive values increase mip‑map usage, negative values reduce it.</param>
    public void SetSamplerMipmapLODBias(uint Sampler, float Bias) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderDeviceD3D, uint, float, void>)0x005A4520)(ref this, Sampler, Bias);

    /// <summary>Configures a render stage's alpha operation and its two arguments on the Direct3D 9 device, updating internal cache to prevent unnecessary state changes.
    /// <code>Offset: 0x005A4550
    /// void __thiscall RenderDeviceD3D::SetStageFFAlphaSource(RenderDeviceD3D*,const unsigned int,const TextureOp,const unsigned int,const unsigned int)</code>
    /// </summary>
    /// <param name="Stage">Index of the texture stage to configure.</param>
    /// <param name="AlphaOp">Operation defining how the alpha channel is processed.</param>
    /// <param name="AlphaArg1">First argument for the alpha operation.</param>
    /// <param name="AlphaArg2">Second argument for the alpha operation.</param>
    public void SetStageFFAlphaSource(uint Stage, ACBindings.Internal.TextureOp AlphaOp, uint AlphaArg1, uint AlphaArg2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderDeviceD3D, uint, ACBindings.Internal.TextureOp, uint, uint, void>)0x005A4550)(ref this, Stage, AlphaOp, AlphaArg1, AlphaArg2);

    /// <summary>Configures the color operation and its arguments for a specified texture stage on the Direct3D 9 device, updating internal cache to avoid redundant state changes.
    /// <code>Offset: 0x005A4610
    /// void __thiscall RenderDeviceD3D::SetStageFFColorSource(RenderDeviceD3D*,const unsigned int,const TextureOp,const unsigned int,const unsigned int)</code>
    /// </summary>
    /// <param name="Stage">Index of the texture stage to configure.</param>
    /// <param name="ColorOp">Operation applied to the color channel (e.g., modulate, add).</param>
    /// <param name="ColorArg1">First operand for the color operation.</param>
    /// <param name="ColorArg2">Second operand for the color operation.</param>
    public void SetStageFFColorSource(uint Stage, ACBindings.Internal.TextureOp ColorOp, uint ColorArg1, uint ColorArg2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderDeviceD3D, uint, ACBindings.Internal.TextureOp, uint, uint, void>)0x005A4610)(ref this, Stage, ColorOp, ColorArg1, ColorArg2);

    /// <summary>Sets the texture coordinate index for a specified render stage, updating the Direct3D state when changed or forced.
    /// <code>Offset: 0x005A46C0
    /// void __thiscall RenderDeviceD3D::SetStageFFTexCoordIndex(RenderDeviceD3D*,const unsigned int,const unsigned int)</code>
    /// </summary>
    /// <param name="Stage">The zero‑based index of the texture stage to configure.</param>
    /// <param name="TexCoordIndex">The texture coordinate set index to assign to that stage.</param>
    public void SetStageFFTexCoordIndex(uint Stage, uint TexCoordIndex) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderDeviceD3D, uint, uint, void>)0x005A46C0)(ref this, Stage, TexCoordIndex);

    /// <summary>Sets the fixed-function texture transform flags for a specified rendering stage and updates the Direct3D device when necessary.
    /// <code>Offset: 0x005A4710
    /// void __thiscall RenderDeviceD3D::SetStageFFTextureTransformFlags(RenderDeviceD3D*,const unsigned int,const unsigned int)</code>
    /// </summary>
    /// <param name="Stage">The zero‑based index of the render stage to configure.</param>
    /// <param name="TextureTransformFlags">Bitmask specifying which texture transformation options are enabled.</param>
    public void SetStageFFTextureTransformFlags(uint Stage, uint TextureTransformFlags) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderDeviceD3D, uint, uint, void>)0x005A4710)(ref this, Stage, TextureTransformFlags);

    /// <summary>Assigns a 2D texture to the specified sampler stage on the Direct3D device, restoring lost resources and updating internal state as needed.
    /// <code>Offset: 0x005A4760
    /// void __thiscall RenderDeviceD3D::SetStageTexture(RenderDeviceD3D*,const unsigned int,RenderTexture*)</code>
    /// </summary>
    /// <param name="Stage">Zero-based index of the sampler stage to set.</param>
    /// <param name="pTexture">Pointer to the texture to bind; may be null to clear the stage.</param>
    public void SetStageTexture(uint Stage, ACBindings.Internal.RenderTexture* pTexture) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderDeviceD3D, uint, ACBindings.Internal.RenderTexture*, void>)0x005A4760)(ref this, Stage, pTexture);

    /// <summary>Assigns pTexture to the specified rendering stage on the Direct3D device, updating the cached stage state only when necessary or when forced.
    /// <code>Offset: 0x005A47D0
    /// void __thiscall RenderDeviceD3D::SetStageTexture(RenderDeviceD3D*,const unsigned int,IDirect3DTexture9*)</code>
    /// </summary>
    /// <param name="Stage">Index of the texture stage to update.</param>
    /// <param name="pTexture">Pointer to the IDirect3DTexture9 object to bind; may be NULL to unbind the stage.</param>
    public void SetStageTexture(uint Stage, System.IntPtr pTexture) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderDeviceD3D, uint, System.IntPtr, void>)0x005A47D0)(ref this, Stage, pTexture);

    /// <summary>Sets the model‑to‑world transformation matrix for the DirectX 9 device and updates the internal state cache.
    /// <code>Offset: 0x005A4820
    /// void __thiscall RenderDeviceD3D::SetModelToWorldMatrix(RenderDeviceD3D*,const Matrix4*)</code>
    /// </summary>
    /// <param name="m">Pointer to a Matrix4 containing the new world transform.</param>
    public void SetModelToWorldMatrix(ACBindings.Internal.Matrix4* m) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderDeviceD3D, ACBindings.Internal.Matrix4*, void>)0x005A4820)(ref this, m);

    /// <summary>Sets the world‑to‑view transformation used by the device, updating both internal state and the Direct3D9 transform matrix.
    /// <code>Offset: 0x005A4860
    /// void __thiscall RenderDeviceD3D::SetWorldToViewMatrix(RenderDeviceD3D*,const Matrix4*)</code>
    /// </summary>
    /// <param name="m">A pointer to a 4×4 matrix defining the new world‑to‑view transform.</param>
    public void SetWorldToViewMatrix(ACBindings.Internal.Matrix4* m) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderDeviceD3D, ACBindings.Internal.Matrix4*, void>)0x005A4860)(ref this, m);

    /// <summary>Sets the view‑to‑clip transformation matrix used by the Direct3D device, updating internal rendering state and applying it via the device’s transform interface.
    /// <code>Offset: 0x005A4890
    /// void __thiscall RenderDeviceD3D::SetViewToClipMatrix(RenderDeviceD3D*,const Matrix4*)</code>
    /// </summary>
    /// <param name="m">Matrix defining conversion from view space to clip space.</param>
    public void SetViewToClipMatrix(ACBindings.Internal.Matrix4* m) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderDeviceD3D, ACBindings.Internal.Matrix4*, void>)0x005A4890)(ref this, m);

    /// <summary>Converts pixel coordinates within a rectangle to clip-space coordinates in the range [-1, 1].
    /// <code>Offset: 0x005A48C0
    /// void __cdecl RenderDeviceD3D::TransformPixelToClipPoint(const int,const int,const int,const int,float*,float*)</code>
    /// </summary>
    /// <param name="nX">The X position in pixels relative to the rectangle's left edge.</param>
    /// <param name="nY">The Y position in pixels relative to the rectangle's top edge.</param>
    /// <param name="nWidth">The width of the source rectangle in pixels.</param>
    /// <param name="nHeight">The height of the source rectangle in pixels.</param>
    /// <param name="fClipX">Output pointer that receives the transformed X coordinate in clip space.</param>
    /// <param name="fClipY">Output pointer that receives the transformed Y coordinate in clip space.</param>
    public static void TransformPixelToClipPoint(int nX, int nY, int nWidth, int nHeight, float* fClipX, float* fClipY) => ((delegate* unmanaged[Cdecl]<int, int, int, int, float*, float*, void>)0x005A48C0)(nX, nY, nWidth, nHeight, fClipX, fClipY);

    /// <summary>Initializes the Direct3D device with a standard set of states, querying interfaces, configuring sampler and texture stages, and releasing unused resources.
    /// <code>Offset: 0x005A4910
    /// bool __thiscall RenderDeviceD3D::SetDefaultD3DStates(RenderDeviceD3D*)</code>
    /// </summary>
    /// <returns>True indicating that the default D3D state initialization succeeded.</returns>
    public byte SetDefaultD3DStates() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderDeviceD3D, byte>)0x005A4910)(ref this);
}

