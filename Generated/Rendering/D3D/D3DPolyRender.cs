namespace ACBindings.Internal;


/// <summary>D3DPolyRender extends PrimD3DRender with Direct3D 9 support; it maintains the D3D9 DLL handle, device instance, and hashes of dynamic vertex streams while tracking a global mipmap level‑of‑detail bias for all rendered polygons.</summary>
public unsafe struct D3DPolyRender
{
    // Base Classes
    public ACBindings.Internal.PrimD3DRender BaseClass_PrimD3DRender; // ACBindings.Internal.PrimD3DRender

    // Statics
    public static uint* s_AlphaDelayMask = (uint*)0x00821D98;
    public static int* s_256AlphaTestRef = (int*)0x00821D9C;
    public static int* s_ddsAlphaTestRef = (int*)0x00821DA0;
    public static ushort* alphaedMeshCountClip = (ushort*)0x008729BC;
    public static ushort* alphaedMeshCountAlpha = (ushort*)0x008729C0;
    public static ushort* portalsDrawnCount = (ushort*)0x008729C4;
    public static ACBindings.Internal.AlphaListEntry** alphaedMeshListClip = (ACBindings.Internal.AlphaListEntry**)0x00872B20;
    public static ACBindings.Internal.AlphaListEntry** alphaedMeshListAlpha = (ACBindings.Internal.AlphaListEntry**)0x008B0380;

    // Child Types
    public unsafe struct D3DPolyRender_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.D3DPolyRender*, void> D3DPolyRender_dtor_0; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.D3DPolyRender*, ACBindings.Internal.RenderConfig*, byte> Startup; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.D3DPolyRender*, void> Shutdown; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.D3DPolyRender*, ACBindings.Internal.RenderDevice*> CreateRenderDevice; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.D3DPolyRender*, int> InitInternal; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.D3DPolyRender*, void> CleanupInternal; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.D3DPolyRender*, int, int, int, int, int> Set3DViewInternal; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.D3DPolyRender*, float, void> SetFOVInternal; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.D3DPolyRender*, float, float> GetFogAdjustment; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.D3DPolyRender*, void> SetupViewportInternal; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.D3DPolyRender*, void> UpdateLightsInternal; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.D3DPolyRender*, ACBindings.Internal.CMaterial*, void> SetMaterialInternal; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.D3DPolyRender*, int, ACBindings.Internal.Position*, void> positionPushInternal; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.D3DPolyRender*, int> positionPopInternal; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.D3DPolyRender*, void> CalcObjectMatrixInternal; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.D3DPolyRender*, ACBindings.Internal.Matrix4*> GetObjectMatrixInternal; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.D3DPolyRender*, void> polyListFinishInternal; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.D3DPolyRender*, ACBindings.Internal.AC1Legacy.Vector3*, ACBindings.Internal.Vec2D*, ACBindings.Internal.BoundingType> xformPointInternal; // function pointer
        public System.IntPtr CreateDxDiagReportFile;

        // Methods
    }

    // Members
    public int* m_hD3D9DLL;
    public System.IntPtr m_pDirect3D;
    public ACBindings.Internal.HashTable__uint___RenderVertexStreamD3D_ptr m_DynamicVertexStreamHash;
    public ACBindings.Internal.RenderIndexStreamD3D* m_pDynamicIndexStream;
    public float m_GlobalMipmapLODBias;

    // Methods

    /// <summary>Initializes the D3DPolyRender instance by delegating to its base class and resetting alpha‑mesh counters.
    /// <code>Offset: 0x0059CC70
    /// int __thiscall D3DPolyRender::InitInternal(D3DPolyRender*)</code>
    /// </summary>
    /// <returns>Non‑zero when initialization succeeds; otherwise returns the failure code from the base class InitInternal call.</returns>
    public int InitInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.D3DPolyRender, int>)0x0059CC70)(ref this);

    /// <summary>Transforms and renders a portal polygon, performing clipping, setting rendering states, and issuing a triangle fan draw call.
    /// <code>Offset: 0x0059CCA0
    /// void __cdecl D3DPolyRender::DrawPortalPolyInternal(CPolygon*,bool)</code>
    /// </summary>
    /// <param name="p">The CPolygon instance containing the vertices of the portal to render.</param>
    /// <param name="zClear">If true, uses an alternate projection matrix; otherwise increments portal count and uses the standard matrix.</param>
    public static void DrawPortalPolyInternal(ACBindings.Internal.CPolygon* p, byte zClear) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.CPolygon*, byte, void>)0x0059CCA0)(p, zClear);

    /// <summary>Selects the optimal display adapter from available adapters, respecting user preferences and system capabilities, and stores the chosen index in the renderer’s configuration.
    /// <code>Offset: 0x0059CFD0
    /// char __thiscall D3DPolyRender::SelectBestAdapter(D3DPolyRender*)</code>
    /// </summary>
    /// <returns>Non‑zero if an adapter was successfully selected; zero otherwise.</returns>
    public sbyte SelectBestAdapter() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.D3DPolyRender, sbyte>)0x0059CFD0)(ref this);

    /// <summary>Applies a detail tiling factor to the specified mesh buffer by scaling its UV coordinates and recording the new value. Returns true if successful, otherwise false.
    /// <code>Offset: 0x0059D160
    /// bool __cdecl D3DPolyRender::SetDetailTiling(MeshBuffer*,float)</code>
    /// </summary>
    /// <param name="pMeshBuffer">The mesh buffer whose UV tiling will be modified.</param>
    /// <param name="new_detail_tiling">Scaling factor applied to the mesh's texture coordinate deltas.</param>
    /// <returns>True when the detail tiling was successfully set; false if the mesh type is unsupported or the update fails.</returns>
    public static byte SetDetailTiling(ACBindings.Internal.MeshBuffer* pMeshBuffer, float new_detail_tiling) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.MeshBuffer*, float, byte>)0x0059D160)(pMeshBuffer, new_detail_tiling);

    /// <summary>Destroys the specified mesh, releasing associated DirectX resources and freeing allocated memory.
    /// <code>Offset: 0x0059D1E0
    /// bool __cdecl D3DPolyRender::DestroyMesh(MeshBuffer**)</code>
    /// </summary>
    /// <param name="meshBuffer">Pointer to a MeshBuffer reference; after execution the referenced buffer is destroyed and set to null.</param>
    /// <returns>True if the operation succeeded (always true in this implementation).</returns>
    public static byte DestroyMesh(ACBindings.Internal.MeshBuffer** meshBuffer) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.MeshBuffer**, byte>)0x0059D1E0)(meshBuffer);

    /// <summary>Adds a mesh to the renderer's alpha or clip list, storing rendering data and optionally capturing object transform for the first mesh in a group.
    /// <code>Offset: 0x0059D240
    /// bool __cdecl D3DPolyRender::AddMeshToAlphaList(MeshBuffer*,int,CSurface*,bool,bool,bool)</code>
    /// </summary>
    /// <param name="mesh">Pointer to the mesh buffer containing vertex and index data.</param>
    /// <param name="surfaceNum">Index of the surface within the mesh that will be rendered.</param>
    /// <param name="surface">Pointer to the CSurface defining material and rendering properties.</param>
    /// <param name="bFirstInGroup">If true, records transform state and other per-group information for this mesh.</param>
    /// <param name="overrideClip">Flag that overrides default clipping behavior when adding to the alpha list.</param>
    /// <param name="clipOrAlpha">Selects whether the mesh is added to the clip list (true) or the alpha list (false).</param>
    /// <returns>True if the mesh was successfully queued; false if the corresponding list has reached its maximum capacity.</returns>
    public static byte AddMeshToAlphaList(ACBindings.Internal.MeshBuffer* mesh, int surfaceNum, ACBindings.Internal.CSurface* surface, byte bFirstInGroup, byte overrideClip, byte clipOrAlpha) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.MeshBuffer*, int, ACBindings.Internal.CSurface*, byte, byte, byte, byte>)0x0059D240)(mesh, surfaceNum, surface, bFirstInGroup, overrideClip, clipOrAlpha);

    /// <summary>Provides access to the renderer's dynamic index stream, creating and initializing it if required. Returns a handle to the stream or zero on error.
    /// <code>Offset: 0x0059D370
    /// int __thiscall D3DPolyRender::ReferenceDynamicIndexStream(D3DPolyRender*)</code>
    /// </summary>
    /// <returns>A non‑zero integer representing the created or existing index stream; zero indicates failure to allocate or initialize the stream.</returns>
    public int ReferenceDynamicIndexStream() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.D3DPolyRender, int>)0x0059D370)(ref this);

    /// <summary>Configures the Direct3D pipeline for a given surface, setting textures, blending modes, alpha testing, and fog parameters according to the surface's properties and supplied flags.
    /// <code>Offset: 0x0059D520
    /// int __cdecl D3DPolyRender::SetSurface(const CSurface*,bool,bool,bool)</code>
    /// </summary>
    /// <param name="surface">Pointer to the CSurface that defines material color, texture map, translucency, and lighting attributes.</param>
    /// <param name="stippled">If true, uses wrap addressing for the primary texture and enables clip‑map style alpha handling; otherwise clamps mapping.</param>
    /// <param name="singlePassDetailing">When true, activates a second texture stage that blends an additional detail texture over the base surface in a single rendering pass.</param>
    /// <param name="overrideClipmap">Forces clip‑map style blending and alpha testing regardless of the surface’s inherent flags.</param>
    /// <returns>Alpha value (0–255) used for the current render state, computed from the surface’s translucency and adjusted for material alpha or fog conditions.</returns>
    public static int SetSurface(ACBindings.Internal.CSurface* surface, byte stippled, byte singlePassDetailing, byte overrideClipmap) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.CSurface*, byte, byte, byte, int>)0x0059D520)(surface, stippled, singlePassDetailing, overrideClipmap);

    /// <summary>Renders a specified submesh from a mesh buffer onto the given surface, applying detail surfaces, clip‑map overrides, UV animation and lighting settings before drawing.
    /// <code>Offset: 0x0059DA60
    /// bool __cdecl D3DPolyRender::RenderMeshSubset(int,CSurface*,bool,bool,MeshBuffer*)</code>
    /// </summary>
    /// <param name="subsetNum">Index of the submesh within the mesh buffer to render.</param>
    /// <param name="surface">Target surface onto which the subset is rendered.</param>
    /// <param name="detail_surface_is_set">If true, a detail surface is applied during rendering.</param>
    /// <param name="overrideClipmapSetting">Overrides clip‑map configuration for this draw call.</param>
    /// <param name="meshBuffer">Container holding mesh data and rendering options such as UV animation and detail tiling.</param>
    /// <returns>True. The function always returns true after attempting to render the subset.</returns>
    public static byte RenderMeshSubset(int subsetNum, ACBindings.Internal.CSurface* surface, byte detail_surface_is_set, byte overrideClipmapSetting, ACBindings.Internal.MeshBuffer* meshBuffer) => ((delegate* unmanaged[Cdecl]<int, ACBindings.Internal.CSurface*, byte, byte, ACBindings.Internal.MeshBuffer*, byte>)0x0059DA60)(subsetNum, surface, detail_surface_is_set, overrideClipmapSetting, meshBuffer);

    /// <summary>Applies baked static lighting to a mesh buffer, computing per‑vertex colors from the world’s static lights and storing them in the vertex stream.
    /// <code>Offset: 0x0059E0F0
    /// bool __cdecl D3DPolyRender::SetStaticLightingVertexColors(MeshBuffer*,Position*)</code>
    /// </summary>
    /// <param name="pMeshBuffer">The mesh buffer whose vertices will receive the baked lighting information.</param>
    /// <param name="pos">The object position used to transform light positions into the mesh’s local space during color calculation.</param>
    /// <returns>True if lighting was successfully applied or already baked; otherwise, false on failure (e.g., incompatible FVF or lock error).</returns>
    public static byte SetStaticLightingVertexColors(ACBindings.Internal.MeshBuffer* pMeshBuffer, ACBindings.Internal.Position* pos) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.MeshBuffer*, ACBindings.Internal.Position*, byte>)0x0059E0F0)(pMeshBuffer, pos);

    /// <summary>Flushes queued alpha‑rendered and clip‑rendered mesh subsets when either count meets a threshold derived from the supplied value; otherwise no rendering occurs.
    /// <code>Offset: 0x0059E3F0
    /// bool __cdecl D3DPolyRender::FlushAlphaList(float)</code>
    /// </summary>
    /// <param name="threshholdVal">Multiplier used to compute the minimum mesh count (multiplied by 3000.0) required before flushing.</param>
    /// <returns>True if all queued subsets were rendered successfully; false if the flush was skipped or any subset failed.</returns>
    public static byte FlushAlphaList(float threshholdVal) => ((delegate* unmanaged[Cdecl]<float, byte>)0x0059E3F0)(threshholdVal);

    /// <summary>Draws a 3D mesh composed of multiple surfaces, selecting appropriate rendering passes for alpha and clipping based on surface attributes and current render settings.
    /// <code>Offset: 0x0059E5B0
    /// bool __cdecl D3DPolyRender::DrawMesh(int,CSurface**,MeshBuffer*,bool)</code>
    /// </summary>
    /// <param name="num_surfaces">The number of surface elements in the mesh to be rendered.</param>
    /// <param name="surfaces">An array of pointers to CSurface objects that define each part of the mesh.</param>
    /// <param name="meshBuffer">Provides vertex and index data for the mesh, as well as flags indicating alpha or stipple usage per surface.</param>
    /// <param name="isEnvCell">Specifies whether the mesh belongs to an environmental cell; this influences texture handling decisions.</param>
    /// <returns>True if all mesh subsets were rendered successfully; otherwise false.</returns>
    public static byte DrawMesh(int num_surfaces, ACBindings.Internal.CSurface** surfaces, ACBindings.Internal.MeshBuffer* meshBuffer, byte isEnvCell) => ((delegate* unmanaged[Cdecl]<int, ACBindings.Internal.CSurface**, ACBindings.Internal.MeshBuffer*, byte, byte>)0x0059E5B0)(num_surfaces, surfaces, meshBuffer, isEnvCell);

    /// <summary>Selects and configures rendering surface for a polygon side, updating UV indexing and stippling flags before delegating to the core SetSurface routine.
    /// <code>Offset: 0x0059E760
    /// int __cdecl D3DPolyRender::SetSurface(CPolygon*,Sidedness,int)</code>
    /// </summary>
    /// <param name="p">Polygon whose surfaces, texture coordinates, and stippling information are used for rendering configuration.</param>
    /// <param name="side">Indicates which side of the polygon (positive or negative) should be rendered.</param>
    /// <param name="singlePassDetailing">Flag specifying whether to perform detailing in a single rendering pass.</param>
    /// <returns>Result code from the underlying surface-setting operation, typically zero on success.</returns>
    public static int SetSurface(ACBindings.Internal.CPolygon* p, ACBindings.Internal.Sidedness side, int singlePassDetailing) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.CPolygon*, ACBindings.Internal.Sidedness, int, int>)0x0059E760)(p, side, singlePassDetailing);

    /// <summary>Creates a temporary DxDiag report by launching dxdiag.exe, writes its output to a new file in the system's temp directory, and returns whether the operation succeeded.
    /// <code>Offset: 0x0059E7C0
    /// bool __stdcall D3DPolyRender::CreateDxDiagReportFile(char**)</code>
    /// </summary>
    /// <param name="a1">Pointer to a char* that will receive the full path of the created report file.</param>
    /// <returns>True if the process was started and completed successfully; otherwise false.</returns>
    public static byte CreateDxDiagReportFile(sbyte** a1) => ((delegate* unmanaged[Stdcall]<sbyte**, byte>)0x0059E7C0)(a1);

    /// <summary>Draws a graphics object's mesh onto the screen using Direct3D rendering.
    /// <code>Offset: 0x0059E8A0
    /// bool __cdecl D3DPolyRender::DrawMesh(CGfxObj*,MeshBuffer*)</code>
    /// </summary>
    /// <param name="obj">Graphics object containing surface definitions and vertex data to be rendered.</param>
    /// <param name="meshBuffer">Buffer holding vertex/index information used during drawing.</param>
    /// <returns>True if the mesh was rendered successfully; otherwise, false.</returns>
    public static byte DrawMesh(ACBindings.Internal.CGfxObj* obj, ACBindings.Internal.MeshBuffer* meshBuffer) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.CGfxObj*, ACBindings.Internal.MeshBuffer*, byte>)0x0059E8A0)(obj, meshBuffer);

    /// <summary>Renders a polygon using Direct3D, applying culling, lighting, optional detailing, and texture mapping based on the current rendering configuration.
    /// <code>Offset: 0x0059E8D0
    /// void __cdecl D3DPolyRender::DrawPolyInternal(CPolygon*)</code>
    /// </summary>
    /// <param name="p">Pointer to the CPolygon structure that defines the vertices, UV indices, surface identifiers, stippling flag, sides type, and other attributes of the polygon to be drawn.</param>
    public static void DrawPolyInternal(ACBindings.Internal.CPolygon* p) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.CPolygon*, void>)0x0059E8D0)(p);

    /// <summary>Finalizes the current polygon batch by rendering each queued polygon using Direct3D and prepares for the next frame.
    /// <code>Offset: 0x0059ECB0
    /// __int32 __thiscall D3DPolyRender::polyListFinishInternal(D3DPolyRender*)</code>
    /// </summary>
    /// <returns>An integer status code; currently always returns Render::PolyNext to signal completion.</returns>
    public int polyListFinishInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.D3DPolyRender, int>)0x0059ECB0)(ref this);

    /// <summary>Resets all dynamic vertex streams managed by the renderer, reallocating buffers when required and notifying the index stream of a frame change.
    /// <code>Offset: 0x0059ECE0
    /// char __thiscall D3DPolyRender::ResetDynamicBuffers(D3DPolyRender*)</code>
    /// </summary>
    /// <returns>Non‑zero if all buffers were successfully reset; zero if any buffer could not be resized.</returns>
    public sbyte ResetDynamicBuffers() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.D3DPolyRender, sbyte>)0x0059ECE0)(ref this);

    /// <summary>Enumerates all display modes supported by the Direct3D adapter and stores them in the render's display mode collection.
    /// <code>Offset: 0x0059EFA0
    /// char __thiscall D3DPolyRender::DetectDisplayModes(D3DPolyRender*)</code>
    /// </summary>
    /// <returns>Non‑zero if enumeration succeeded; otherwise zero.</returns>
    public sbyte DetectDisplayModes() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.D3DPolyRender, sbyte>)0x0059EFA0)(ref this);

    /// <summary>Builds a Direct3D mesh buffer from the supplied surfaces, vertex array, and polygon data while applying texture scaling and optional static lighting.
    /// <code>Offset: 0x0059F0B0
    /// bool __cdecl D3DPolyRender::ConstructMesh(int,CSurface**,CVertexArray*,int,CPolygon*,float,bool,MeshBuffer**)</code>
    /// </summary>
    /// <param name="num_surfaces">The number of surface descriptors to process.</param>
    /// <param name="surfaces">Array of pointers to CSurface structures that define each surface’s type, textures, and properties.</param>
    /// <param name="vertex_array">Container holding the vertices that form the mesh geometry.</param>
    /// <param name="num_polygons">The number of polygons that compose the mesh faces.</param>
    /// <param name="polygons">Array describing polygon connectivity, attributes, and surface assignments.</param>
    /// <param name="detailTextureUVFactor">Scaling factor for texture UV coordinates; values less than or equal to zero select a default tiling mode.</param>
    /// <param name="burn_in_static_lights">If true, static lighting information is baked into vertex colors during construction.</param>
    /// <param name="constructedMesh">Output parameter that receives the newly created MeshBuffer on success.</param>
    /// <returns>True if the mesh buffer was successfully constructed and assigned to *constructedMesh; otherwise false.</returns>
    public static byte ConstructMesh(int num_surfaces, ACBindings.Internal.CSurface** surfaces, ACBindings.Internal.CVertexArray* vertex_array, int num_polygons, ACBindings.Internal.CPolygon* polygons, float detailTextureUVFactor, byte burn_in_static_lights, ACBindings.Internal.MeshBuffer** constructedMesh) => ((delegate* unmanaged[Cdecl]<int, ACBindings.Internal.CSurface**, ACBindings.Internal.CVertexArray*, int, ACBindings.Internal.CPolygon*, float, byte, ACBindings.Internal.MeshBuffer**, byte>)0x0059F0B0)(num_surfaces, surfaces, vertex_array, num_polygons, polygons, detailTextureUVFactor, burn_in_static_lights, constructedMesh);

    /// <summary>Creates a Direct3D rendering device for the poly renderer and initializes its internal state.
    /// <code>Offset: 0x0059FAA0
    /// RenderDeviceD3D* __thiscall D3DPolyRender::CreateRenderDevice(D3DPolyRender*)</code>
    /// </summary>
    /// <returns>A pointer to the newly allocated RenderDeviceD3D instance; returns nullptr if memory allocation fails.</returns>
    public ACBindings.Internal.RenderDeviceD3D* CreateRenderDevice() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.D3DPolyRender, ACBindings.Internal.RenderDeviceD3D*>)0x0059FAA0)(ref this);

    /// <summary>Initializes the D3DPolyRender instance by loading Direct3D 9, creating a device, selecting the optimal adapter, and enumerating available display modes.
    /// <code>Offset: 0x0059FB00
    /// bool __thiscall D3DPolyRender::Startup(RenderConfig*,const RenderConfig*)</code>
    /// </summary>
    /// <param name="a2">Configuration parameters to use during initialization.</param>
    /// <returns>True if all steps succeed; otherwise false.</returns>
    public byte Startup(ACBindings.Internal.RenderConfig* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.D3DPolyRender, ACBindings.Internal.RenderConfig*, byte>)0x0059FB00)(ref this, a2);

    /// <summary>Creates a Direct3D mesh from the surfaces and polygons of the supplied CGfxObj, storing the result in the provided MeshBuffer pointer.
    /// <code>Offset: 0x0059FBA0
    /// bool __cdecl D3DPolyRender::ConstructMesh(CGfxObj*,MeshBuffer**)</code>
    /// </summary>
    /// <param name="obj">The graphics object whose surface and polygon data are used to build the mesh.</param>
    /// <param name="constructedMesh">Receives the constructed MeshBuffer instance on success; may be left null if construction fails.</param>
    /// <returns>True if the mesh was successfully created; otherwise, false.</returns>
    public static byte ConstructMesh(ACBindings.Internal.CGfxObj* obj, ACBindings.Internal.MeshBuffer** constructedMesh) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.CGfxObj*, ACBindings.Internal.MeshBuffer**, byte>)0x0059FBA0)(obj, constructedMesh);

    /// <summary>Initializes the Direct3D polygon renderer by resetting counters, clearing dynamic streams, and registering rendering variables such as mipmap LOD bias, alpha delay mask, and alpha test reference values.
    /// <code>Offset: 0x0059FBE0
    /// LONG __thiscall D3DPolyRender::Begin(D3DPolyRender*)</code>
    /// </summary>
    /// <returns>A status code from the final InterlockedDecrement operation; non‑zero may indicate that other references remain.</returns>
    public int Begin() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.D3DPolyRender, int>)0x0059FBE0)(ref this);

    /// <summary>Finalizes the Direct3D rendering context by unregistering configuration variables, releasing internal callbacks and caches, unloading the DirectX DLL, and freeing associated resources.
    /// <code>Offset: 0x0059FE00
    /// int __thiscall D3DPolyRender::End(D3DPolyRender*)</code>
    /// </summary>
    /// <returns>The result of FreeLibrary when a DirectX DLL was loaded (non‑zero on success); zero if no library was unloaded.</returns>
    public int End() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.D3DPolyRender, int>)0x0059FE00)(ref this);

    /// <summary>Ends the current rendering session, releases resources, and reinitializes the renderer for a fresh start.
    /// <code>Offset: 0x0059FFA0
    /// LONG __thiscall D3DPolyRender::Shutdown(D3DPolyRender*)</code>
    /// </summary>
    /// <returns>The result code from initiating a new render session via Begin.</returns>
    public int Shutdown() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.D3DPolyRender, int>)0x0059FFA0)(ref this);

    /// <summary>References a vertex stream identified by the supplied id, creating a new stream when none exists.
    /// <code>Offset: 0x0059FFC0
    /// RenderVertexStreamD3D* __thiscall D3DPolyRender::ReferenceVertexStream(D3DPolyRender*,unsigned int,unsigned int)</code>
    /// </summary>
    /// <param name="a2">The unique identifier of the desired vertex stream.</param>
    /// <param name="a3">The requested minimum vertex count for the stream; if less than 8192 it is rounded up to that value.</param>
    /// <returns>A pointer to the referenced RenderVertexStreamD3D instance, or null on allocation failure.</returns>
    public ACBindings.Internal.RenderVertexStreamD3D* ReferenceVertexStream(uint a2, uint a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.D3DPolyRender, uint, uint, ACBindings.Internal.RenderVertexStreamD3D*>)0x0059FFC0)(ref this, a2, a3);
}

