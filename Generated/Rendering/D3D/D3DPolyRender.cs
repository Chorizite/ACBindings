namespace ACBindings;

// D3DPolyRender
public unsafe struct D3DPolyRender
{
    // Base Classes
    public ACBindings.PrimD3DRender BaseClass_PrimD3DRender; // ACBindings.PrimD3DRender

    // Statics
    public static uint* s_AlphaDelayMask = (uint*)0x00821D98;
    public static int* s_256AlphaTestRef = (int*)0x00821D9C;
    public static int* s_ddsAlphaTestRef = (int*)0x00821DA0;
    public static ushort* alphaedMeshCountAlpha = (ushort*)0x0086D884;
    public static ushort* alphaedMeshCountClip = (ushort*)0x0086D888;
    public static ushort* portalsDrawnCount = (ushort*)0x0086D8D4;
    public static ACBindings.AlphaListEntry* alphaedMeshListAlpha = (ACBindings.AlphaListEntry*)0x008B0380;

    // Child Types
    // D3DPolyRender_vtbl
    public unsafe struct D3DPolyRender_vtbl
    {
        // Members
        public System.IntPtr D3DPolyRender_dtor_0; // function pointer
        public System.IntPtr Startup; // function pointer
        public System.IntPtr Shutdown; // function pointer
        public System.IntPtr CreateRenderDevice; // function pointer
        public System.IntPtr InitInternal; // function pointer
        public System.IntPtr CleanupInternal; // function pointer
        public System.IntPtr Set3DViewInternal; // function pointer
        public System.IntPtr SetFOVInternal; // function pointer
        public System.IntPtr GetFogAdjustment; // function pointer
        public System.IntPtr SetupViewportInternal; // function pointer
        public System.IntPtr UpdateLightsInternal; // function pointer
        public System.IntPtr SetMaterialInternal; // function pointer
        public System.IntPtr positionPushInternal; // function pointer
        public System.IntPtr positionPopInternal; // function pointer
        public System.IntPtr CalcObjectMatrixInternal; // function pointer
        public System.IntPtr GetObjectMatrixInternal; // function pointer
        public System.IntPtr polyListFinishInternal; // function pointer
        public System.IntPtr xformPointInternal; // function pointer
        public System.IntPtr CreateDxDiagReportFile;

        // Methods
    }

    // Members
    public int* m_hD3D9DLL;
    public System.IntPtr m_pDirect3D;
    public ACBindings.HashTable__uint__RenderVertexStreamD3D_ptr m_DynamicVertexStreamHash;
    public ACBindings.RenderIndexStreamD3D* m_pDynamicIndexStream;
    public float m_GlobalMipmapLODBias;

    // Methods
    // int __thiscall D3DPolyRender::InitInternal(D3DPolyRender*)
    public int InitInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.D3DPolyRender, int>)0x0059CC70)(ref this);
    // void __cdecl D3DPolyRender::DrawPortalPolyInternal(CPolygon*,bool)
    public static void DrawPortalPolyInternal(ACBindings.CPolygon* p, byte zClear) => ((delegate* unmanaged[Cdecl]<ACBindings.CPolygon*, byte, void>)0x0059CCA0)(p, zClear);
    // char __thiscall D3DPolyRender::SelectBestAdapter(D3DPolyRender*)
    public sbyte SelectBestAdapter() => ((delegate* unmanaged[Thiscall]<ref ACBindings.D3DPolyRender, sbyte>)0x0059CFD0)(ref this);
    // bool __cdecl D3DPolyRender::SetDetailTiling(MeshBuffer*,float)
    public static byte SetDetailTiling(ACBindings.MeshBuffer* pMeshBuffer, float new_detail_tiling) => ((delegate* unmanaged[Cdecl]<ACBindings.MeshBuffer*, float, byte>)0x0059D160)(pMeshBuffer, new_detail_tiling);
    // bool __cdecl D3DPolyRender::DestroyMesh(MeshBuffer**)
    public static byte DestroyMesh(ACBindings.MeshBuffer** meshBuffer) => ((delegate* unmanaged[Cdecl]<ACBindings.MeshBuffer**, byte>)0x0059D1E0)(meshBuffer);
    // bool __cdecl D3DPolyRender::AddMeshToAlphaList(MeshBuffer*,int,CSurface*,bool,bool,bool)
    public static byte AddMeshToAlphaList(ACBindings.MeshBuffer* mesh, int surfaceNum, ACBindings.CSurface* surface, byte bFirstInGroup, byte overrideClip, byte clipOrAlpha) => ((delegate* unmanaged[Cdecl]<ACBindings.MeshBuffer*, int, ACBindings.CSurface*, byte, byte, byte, byte>)0x0059D240)(mesh, surfaceNum, surface, bFirstInGroup, overrideClip, clipOrAlpha);
    // int __thiscall D3DPolyRender::ReferenceDynamicIndexStream(D3DPolyRender*)
    public int ReferenceDynamicIndexStream() => ((delegate* unmanaged[Thiscall]<ref ACBindings.D3DPolyRender, int>)0x0059D370)(ref this);
    // int __cdecl D3DPolyRender::SetSurface(const CSurface*,bool,bool,bool)
    public static int SetSurface(ACBindings.CSurface* surface, byte stippled, byte singlePassDetailing, byte overrideClipmap) => ((delegate* unmanaged[Cdecl]<ACBindings.CSurface*, byte, byte, byte, int>)0x0059D520)(surface, stippled, singlePassDetailing, overrideClipmap);
    // bool __cdecl D3DPolyRender::RenderMeshSubset(int,CSurface*,bool,bool,MeshBuffer*)
    public static byte RenderMeshSubset(int subsetNum, ACBindings.CSurface* surface, byte detail_surface_is_set, byte overrideClipmapSetting, ACBindings.MeshBuffer* meshBuffer) => ((delegate* unmanaged[Cdecl]<int, ACBindings.CSurface*, byte, byte, ACBindings.MeshBuffer*, byte>)0x0059DA60)(subsetNum, surface, detail_surface_is_set, overrideClipmapSetting, meshBuffer);
    // bool __cdecl D3DPolyRender::SetStaticLightingVertexColors(MeshBuffer*,Position*)
    public static byte SetStaticLightingVertexColors(ACBindings.MeshBuffer* pMeshBuffer, ACBindings.Position* pos) => ((delegate* unmanaged[Cdecl]<ACBindings.MeshBuffer*, ACBindings.Position*, byte>)0x0059E0F0)(pMeshBuffer, pos);
    // bool __cdecl D3DPolyRender::FlushAlphaList(float)
    public static byte FlushAlphaList(float threshholdVal) => ((delegate* unmanaged[Cdecl]<float, byte>)0x0059E3F0)(threshholdVal);
    // bool __cdecl D3DPolyRender::DrawMesh(int,CSurface**,MeshBuffer*,bool)
    public static byte DrawMesh(int num_surfaces, ACBindings.CSurface** surfaces, ACBindings.MeshBuffer* meshBuffer, byte isEnvCell) => ((delegate* unmanaged[Cdecl]<int, ACBindings.CSurface**, ACBindings.MeshBuffer*, byte, byte>)0x0059E5B0)(num_surfaces, surfaces, meshBuffer, isEnvCell);
    // int __cdecl D3DPolyRender::SetSurface(CPolygon*,Sidedness,int)
    public static int SetSurface(ACBindings.CPolygon* p, ACBindings.Sidedness side, int singlePassDetailing) => ((delegate* unmanaged[Cdecl]<ACBindings.CPolygon*, ACBindings.Sidedness, int, int>)0x0059E760)(p, side, singlePassDetailing);
    // bool __stdcall D3DPolyRender::CreateDxDiagReportFile(char**)
    public static byte CreateDxDiagReportFile(sbyte** a1) => ((delegate* unmanaged[Stdcall]<sbyte**, byte>)0x0059E7C0)(a1);
    // bool __cdecl D3DPolyRender::DrawMesh(CGfxObj*,MeshBuffer*)
    public static byte DrawMesh(ACBindings.CGfxObj* obj, ACBindings.MeshBuffer* meshBuffer) => ((delegate* unmanaged[Cdecl]<ACBindings.CGfxObj*, ACBindings.MeshBuffer*, byte>)0x0059E8A0)(obj, meshBuffer);
    // void __cdecl D3DPolyRender::DrawPolyInternal(CPolygon*)
    public static void DrawPolyInternal(ACBindings.CPolygon* p) => ((delegate* unmanaged[Cdecl]<ACBindings.CPolygon*, void>)0x0059E8D0)(p);
    // __int32 __thiscall D3DPolyRender::polyListFinishInternal(D3DPolyRender*)
    public int polyListFinishInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.D3DPolyRender, int>)0x0059ECB0)(ref this);
    // char __thiscall D3DPolyRender::ResetDynamicBuffers(D3DPolyRender*)
    public sbyte ResetDynamicBuffers() => ((delegate* unmanaged[Thiscall]<ref ACBindings.D3DPolyRender, sbyte>)0x0059ECE0)(ref this);
    // char __thiscall D3DPolyRender::DetectDisplayModes(D3DPolyRender*)
    public sbyte DetectDisplayModes() => ((delegate* unmanaged[Thiscall]<ref ACBindings.D3DPolyRender, sbyte>)0x0059EFA0)(ref this);
    // bool __cdecl D3DPolyRender::ConstructMesh(int,CSurface**,CVertexArray*,int,CPolygon*,float,bool,MeshBuffer**)
    public static byte ConstructMesh(int num_surfaces, ACBindings.CSurface** surfaces, ACBindings.CVertexArray* vertex_array, int num_polygons, ACBindings.CPolygon* polygons, float detailTextureUVFactor, byte burn_in_static_lights, ACBindings.MeshBuffer** constructedMesh) => ((delegate* unmanaged[Cdecl]<int, ACBindings.CSurface**, ACBindings.CVertexArray*, int, ACBindings.CPolygon*, float, byte, ACBindings.MeshBuffer**, byte>)0x0059F0B0)(num_surfaces, surfaces, vertex_array, num_polygons, polygons, detailTextureUVFactor, burn_in_static_lights, constructedMesh);
    // RenderDeviceD3D* __thiscall D3DPolyRender::CreateRenderDevice(D3DPolyRender*)
    public ACBindings.RenderDeviceD3D* CreateRenderDevice() => ((delegate* unmanaged[Thiscall]<ref ACBindings.D3DPolyRender, ACBindings.RenderDeviceD3D*>)0x0059FAA0)(ref this);
    // bool __thiscall D3DPolyRender::Startup(RenderConfig*,const RenderConfig*)
    public byte Startup(ACBindings.RenderConfig* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.D3DPolyRender, ACBindings.RenderConfig*, byte>)0x0059FB00)(ref this, a2);
    // bool __cdecl D3DPolyRender::ConstructMesh(CGfxObj*,MeshBuffer**)
    public static byte ConstructMesh(ACBindings.CGfxObj* obj, ACBindings.MeshBuffer** constructedMesh) => ((delegate* unmanaged[Cdecl]<ACBindings.CGfxObj*, ACBindings.MeshBuffer**, byte>)0x0059FBA0)(obj, constructedMesh);
    // LONG __thiscall D3DPolyRender::Begin(D3DPolyRender*)
    public int Begin() => ((delegate* unmanaged[Thiscall]<ref ACBindings.D3DPolyRender, int>)0x0059FBE0)(ref this);
    // int __thiscall D3DPolyRender::End(D3DPolyRender*)
    public int End() => ((delegate* unmanaged[Thiscall]<ref ACBindings.D3DPolyRender, int>)0x0059FE00)(ref this);
    // LONG __thiscall D3DPolyRender::Shutdown(D3DPolyRender*)
    public int Shutdown() => ((delegate* unmanaged[Thiscall]<ref ACBindings.D3DPolyRender, int>)0x0059FFA0)(ref this);
    // RenderVertexStreamD3D* __thiscall D3DPolyRender::ReferenceVertexStream(D3DPolyRender*,unsigned int,unsigned int)
    public ACBindings.RenderVertexStreamD3D* ReferenceVertexStream(uint a2, uint a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.D3DPolyRender, uint, uint, ACBindings.RenderVertexStreamD3D*>)0x0059FFC0)(ref this, a2, a3);
}

