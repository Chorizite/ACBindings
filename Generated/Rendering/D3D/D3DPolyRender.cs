namespace ACBindings.Internal;

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
    public static ACBindings.Internal.AlphaListEntry* alphaedMeshListClip = (ACBindings.Internal.AlphaListEntry*)0x00872B20;
    public static ACBindings.Internal.AlphaListEntry* alphaedMeshListAlpha = (ACBindings.Internal.AlphaListEntry*)0x008B0380;

    // Child Types
    public unsafe struct D3DPolyRender_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.D3DPolyRender*, void> D3DPolyRender_dtor_0; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.D3DPolyRender*, ACBindings.Internal.RenderConfig*, byte> Startup; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.D3DPolyRender*, void> Shutdown; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.D3DPolyRender*, ACBindings.Internal.RenderDevice*> CreateRenderDevice; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.D3DPolyRender*, int> InitInternal; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.D3DPolyRender*, void> CleanupInternal; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.D3DPolyRender*, int, int, int, int, int> Set3DViewInternal; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.D3DPolyRender*, float, void> SetFOVInternal; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.D3DPolyRender*, float, float> GetFogAdjustment; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.D3DPolyRender*, void> SetupViewportInternal; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.D3DPolyRender*, void> UpdateLightsInternal; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.D3DPolyRender*, ACBindings.Internal.CMaterial*, void> SetMaterialInternal; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.D3DPolyRender*, int, ACBindings.Internal.Position*, void> positionPushInternal; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.D3DPolyRender*, int> positionPopInternal; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.D3DPolyRender*, void> CalcObjectMatrixInternal; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.D3DPolyRender*, ACBindings.Internal.Matrix4*> GetObjectMatrixInternal; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.D3DPolyRender*, void> polyListFinishInternal; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.D3DPolyRender*, ACBindings.Internal.AC1Legacy.Vector3*, ACBindings.Internal.Vec2D*, ACBindings.Internal.BoundingType> xformPointInternal; // function pointer
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

    /// <summary>
    /// <code>Offset: 0x0059CC70
    /// int __thiscall D3DPolyRender::InitInternal(D3DPolyRender*)</code>
    /// </summary>
    public int InitInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.D3DPolyRender, int>)0x0059CC70)(ref this);

    /// <summary>
    /// <code>Offset: 0x0059CCA0
    /// void __cdecl D3DPolyRender::DrawPortalPolyInternal(CPolygon*,bool)</code>
    /// </summary>
    public static void DrawPortalPolyInternal(ACBindings.Internal.CPolygon* p, byte zClear) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.CPolygon*, byte, void>)0x0059CCA0)(p, zClear);

    /// <summary>
    /// <code>Offset: 0x0059CFD0
    /// char __thiscall D3DPolyRender::SelectBestAdapter(D3DPolyRender*)</code>
    /// </summary>
    public sbyte SelectBestAdapter() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.D3DPolyRender, sbyte>)0x0059CFD0)(ref this);

    /// <summary>
    /// <code>Offset: 0x0059D160
    /// bool __cdecl D3DPolyRender::SetDetailTiling(MeshBuffer*,float)</code>
    /// </summary>
    public static byte SetDetailTiling(ACBindings.Internal.MeshBuffer* pMeshBuffer, float new_detail_tiling) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.MeshBuffer*, float, byte>)0x0059D160)(pMeshBuffer, new_detail_tiling);

    /// <summary>
    /// <code>Offset: 0x0059D1E0
    /// bool __cdecl D3DPolyRender::DestroyMesh(MeshBuffer**)</code>
    /// </summary>
    public static byte DestroyMesh(ACBindings.Internal.MeshBuffer** meshBuffer) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.MeshBuffer**, byte>)0x0059D1E0)(meshBuffer);

    /// <summary>
    /// <code>Offset: 0x0059D240
    /// bool __cdecl D3DPolyRender::AddMeshToAlphaList(MeshBuffer*,int,CSurface*,bool,bool,bool)</code>
    /// </summary>
    public static byte AddMeshToAlphaList(ACBindings.Internal.MeshBuffer* mesh, int surfaceNum, ACBindings.Internal.CSurface* surface, byte bFirstInGroup, byte overrideClip, byte clipOrAlpha) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.MeshBuffer*, int, ACBindings.Internal.CSurface*, byte, byte, byte, byte>)0x0059D240)(mesh, surfaceNum, surface, bFirstInGroup, overrideClip, clipOrAlpha);

    /// <summary>
    /// <code>Offset: 0x0059D370
    /// int __thiscall D3DPolyRender::ReferenceDynamicIndexStream(D3DPolyRender*)</code>
    /// </summary>
    public int ReferenceDynamicIndexStream() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.D3DPolyRender, int>)0x0059D370)(ref this);

    /// <summary>
    /// <code>Offset: 0x0059D520
    /// int __cdecl D3DPolyRender::SetSurface(const CSurface*,bool,bool,bool)</code>
    /// </summary>
    public static int SetSurface(ACBindings.Internal.CSurface* surface, byte stippled, byte singlePassDetailing, byte overrideClipmap) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.CSurface*, byte, byte, byte, int>)0x0059D520)(surface, stippled, singlePassDetailing, overrideClipmap);

    /// <summary>
    /// <code>Offset: 0x0059DA60
    /// bool __cdecl D3DPolyRender::RenderMeshSubset(int,CSurface*,bool,bool,MeshBuffer*)</code>
    /// </summary>
    public static byte RenderMeshSubset(int subsetNum, ACBindings.Internal.CSurface* surface, byte detail_surface_is_set, byte overrideClipmapSetting, ACBindings.Internal.MeshBuffer* meshBuffer) => ((delegate* unmanaged[Cdecl]<int, ACBindings.Internal.CSurface*, byte, byte, ACBindings.Internal.MeshBuffer*, byte>)0x0059DA60)(subsetNum, surface, detail_surface_is_set, overrideClipmapSetting, meshBuffer);

    /// <summary>
    /// <code>Offset: 0x0059E0F0
    /// bool __cdecl D3DPolyRender::SetStaticLightingVertexColors(MeshBuffer*,Position*)</code>
    /// </summary>
    public static byte SetStaticLightingVertexColors(ACBindings.Internal.MeshBuffer* pMeshBuffer, ACBindings.Internal.Position* pos) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.MeshBuffer*, ACBindings.Internal.Position*, byte>)0x0059E0F0)(pMeshBuffer, pos);

    /// <summary>
    /// <code>Offset: 0x0059E3F0
    /// bool __cdecl D3DPolyRender::FlushAlphaList(float)</code>
    /// </summary>
    public static byte FlushAlphaList(float threshholdVal) => ((delegate* unmanaged[Cdecl]<float, byte>)0x0059E3F0)(threshholdVal);

    /// <summary>
    /// <code>Offset: 0x0059E5B0
    /// bool __cdecl D3DPolyRender::DrawMesh(int,CSurface**,MeshBuffer*,bool)</code>
    /// </summary>
    public static byte DrawMesh(int num_surfaces, ACBindings.Internal.CSurface** surfaces, ACBindings.Internal.MeshBuffer* meshBuffer, byte isEnvCell) => ((delegate* unmanaged[Cdecl]<int, ACBindings.Internal.CSurface**, ACBindings.Internal.MeshBuffer*, byte, byte>)0x0059E5B0)(num_surfaces, surfaces, meshBuffer, isEnvCell);

    /// <summary>
    /// <code>Offset: 0x0059E760
    /// int __cdecl D3DPolyRender::SetSurface(CPolygon*,Sidedness,int)</code>
    /// </summary>
    public static int SetSurface(ACBindings.Internal.CPolygon* p, ACBindings.Internal.Sidedness side, int singlePassDetailing) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.CPolygon*, ACBindings.Internal.Sidedness, int, int>)0x0059E760)(p, side, singlePassDetailing);

    /// <summary>
    /// <code>Offset: 0x0059E7C0
    /// bool __stdcall D3DPolyRender::CreateDxDiagReportFile(char**)</code>
    /// </summary>
    public static byte CreateDxDiagReportFile(sbyte** a1) => ((delegate* unmanaged[Stdcall]<sbyte**, byte>)0x0059E7C0)(a1);

    /// <summary>
    /// <code>Offset: 0x0059E8A0
    /// bool __cdecl D3DPolyRender::DrawMesh(CGfxObj*,MeshBuffer*)</code>
    /// </summary>
    public static byte DrawMesh(ACBindings.Internal.CGfxObj* obj, ACBindings.Internal.MeshBuffer* meshBuffer) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.CGfxObj*, ACBindings.Internal.MeshBuffer*, byte>)0x0059E8A0)(obj, meshBuffer);

    /// <summary>
    /// <code>Offset: 0x0059E8D0
    /// void __cdecl D3DPolyRender::DrawPolyInternal(CPolygon*)</code>
    /// </summary>
    public static void DrawPolyInternal(ACBindings.Internal.CPolygon* p) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.CPolygon*, void>)0x0059E8D0)(p);

    /// <summary>
    /// <code>Offset: 0x0059ECB0
    /// __int32 __thiscall D3DPolyRender::polyListFinishInternal(D3DPolyRender*)</code>
    /// </summary>
    public int polyListFinishInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.D3DPolyRender, int>)0x0059ECB0)(ref this);

    /// <summary>
    /// <code>Offset: 0x0059ECE0
    /// char __thiscall D3DPolyRender::ResetDynamicBuffers(D3DPolyRender*)</code>
    /// </summary>
    public sbyte ResetDynamicBuffers() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.D3DPolyRender, sbyte>)0x0059ECE0)(ref this);

    /// <summary>
    /// <code>Offset: 0x0059EFA0
    /// char __thiscall D3DPolyRender::DetectDisplayModes(D3DPolyRender*)</code>
    /// </summary>
    public sbyte DetectDisplayModes() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.D3DPolyRender, sbyte>)0x0059EFA0)(ref this);

    /// <summary>
    /// <code>Offset: 0x0059F0B0
    /// bool __cdecl D3DPolyRender::ConstructMesh(int,CSurface**,CVertexArray*,int,CPolygon*,float,bool,MeshBuffer**)</code>
    /// </summary>
    public static byte ConstructMesh(int num_surfaces, ACBindings.Internal.CSurface** surfaces, ACBindings.Internal.CVertexArray* vertex_array, int num_polygons, ACBindings.Internal.CPolygon* polygons, float detailTextureUVFactor, byte burn_in_static_lights, ACBindings.Internal.MeshBuffer** constructedMesh) => ((delegate* unmanaged[Cdecl]<int, ACBindings.Internal.CSurface**, ACBindings.Internal.CVertexArray*, int, ACBindings.Internal.CPolygon*, float, byte, ACBindings.Internal.MeshBuffer**, byte>)0x0059F0B0)(num_surfaces, surfaces, vertex_array, num_polygons, polygons, detailTextureUVFactor, burn_in_static_lights, constructedMesh);

    /// <summary>
    /// <code>Offset: 0x0059FAA0
    /// RenderDeviceD3D* __thiscall D3DPolyRender::CreateRenderDevice(D3DPolyRender*)</code>
    /// </summary>
    public ACBindings.Internal.RenderDeviceD3D* CreateRenderDevice() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.D3DPolyRender, ACBindings.Internal.RenderDeviceD3D*>)0x0059FAA0)(ref this);

    /// <summary>
    /// <code>Offset: 0x0059FB00
    /// bool __thiscall D3DPolyRender::Startup(RenderConfig*,const RenderConfig*)</code>
    /// </summary>
    public byte Startup(ACBindings.Internal.RenderConfig* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.D3DPolyRender, ACBindings.Internal.RenderConfig*, byte>)0x0059FB00)(ref this, a2);

    /// <summary>
    /// <code>Offset: 0x0059FBA0
    /// bool __cdecl D3DPolyRender::ConstructMesh(CGfxObj*,MeshBuffer**)</code>
    /// </summary>
    public static byte ConstructMesh(ACBindings.Internal.CGfxObj* obj, ACBindings.Internal.MeshBuffer** constructedMesh) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.CGfxObj*, ACBindings.Internal.MeshBuffer**, byte>)0x0059FBA0)(obj, constructedMesh);

    /// <summary>
    /// <code>Offset: 0x0059FBE0
    /// LONG __thiscall D3DPolyRender::Begin(D3DPolyRender*)</code>
    /// </summary>
    public int Begin() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.D3DPolyRender, int>)0x0059FBE0)(ref this);

    /// <summary>
    /// <code>Offset: 0x0059FE00
    /// int __thiscall D3DPolyRender::End(D3DPolyRender*)</code>
    /// </summary>
    public int End() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.D3DPolyRender, int>)0x0059FE00)(ref this);

    /// <summary>
    /// <code>Offset: 0x0059FFA0
    /// LONG __thiscall D3DPolyRender::Shutdown(D3DPolyRender*)</code>
    /// </summary>
    public int Shutdown() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.D3DPolyRender, int>)0x0059FFA0)(ref this);

    /// <summary>
    /// <code>Offset: 0x0059FFC0
    /// RenderVertexStreamD3D* __thiscall D3DPolyRender::ReferenceVertexStream(D3DPolyRender*,unsigned int,unsigned int)</code>
    /// </summary>
    public ACBindings.Internal.RenderVertexStreamD3D* ReferenceVertexStream(uint a2, uint a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.D3DPolyRender, uint, uint, ACBindings.Internal.RenderVertexStreamD3D*>)0x0059FFC0)(ref this, a2, a3);
}

