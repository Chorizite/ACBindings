namespace ACBindings.Internal;

public unsafe struct Render
{
    // Statics
    public static float* s_rDegradeDistance = (float*)0x0081FC68;
    public static float* max_framerate = (float*)0x0081FC6C;
    public static float* min_framerate = (float*)0x0081FC70;
    public static float* ideal_framerate = (float*)0x0081FC74;
    public static int* force_level = (int*)0x0081FC7C;
    public static float* object_scale = (float*)0x0081FC84;
    public static float* fov = (float*)0x0081FC88;
    public static float* scale = (float*)0x0081FC8C;
    public static float* vdst = (float*)0x0081FC90;
    public static float* znear = (float*)0x0081FC94;
    public static float* zfar = (float*)0x0081FC98;
    public static int* FrameEraNext = (int*)0x0081FC9C;
    public static int* CachedMatrixFrameEra = (int*)0x0081FCA0;
    public static int* max_static_lights = (int*)0x0081FCA4;
    public static int* max_dynamic_lights = (int*)0x0081FCA8;
    public static ACBindings.Internal.Render.LightingType* lighting_type = (ACBindings.Internal.Render.LightingType*)0x0081FCAC;
    public static uint* curr_detail_src_blend = (uint*)0x0081FCB0;
    public static uint* curr_detail_dst_blend = (uint*)0x0081FCB4;
    public static float* landscape_detail_tiling = (float*)0x0081FCB8;
    public static float* environment_detail_tiling = (float*)0x0081FCBC;
    public static float* building_detail_tiling = (float*)0x0081FCC0;
    public static float* object_detail_tiling = (float*)0x0081FCC4;
    public static float* curr_detail_tiling = (float*)0x0081FCC8;
    public static float* TextureUSize = (float*)0x0081FCCC;
    public static float* TextureVSize = (float*)0x0081FCD0;
    public static ACBindings.Internal.Vector3* object_scale_vec = (ACBindings.Internal.Vector3*)0x0081FEC0;
    public static ACBindings.Internal.RenderPrefs* m_RenderPrefs = (ACBindings.Internal.RenderPrefs*)0x0081FFA0;
    public static ACBindings.Internal.RGBColor* diffuse = (ACBindings.Internal.RGBColor*)0x0081FFD0;
    public static ACBindings.Internal.view_vertex* portal_vertex = (ACBindings.Internal.view_vertex*)0x00847050;
    public static ACBindings.Internal.view_type* portal_view = (ACBindings.Internal.view_type*)0x00847054;
    public static double* tx = (double*)0x00847058;
    public static int* portal_npnts = (int*)0x00847060;
    public static float* PolyCurrentMod = (float*)0x00847064;
    public static ACBindings.Internal.HWLightUsage* curLightUsage = (ACBindings.Internal.HWLightUsage*)0x00847068;
    public static int* PolyCurrentPos = (int*)0x008470C8;
    public static float* xmax = (float*)0x008470D0;
    public static int* static_light_used = (int*)0x008470D8;
    public static int* portal_inmask = (int*)0x008671C8;
    public static int* dynamic_light_used = (int*)0x00867248;
    public static float* local_object_radius = (float*)0x00867270;
    public static ACBindings.Internal.HWLightUsage* prevLightUsage = (ACBindings.Internal.HWLightUsage*)0x00867278;
    public static double* xinvscale = (double*)0x008672D8;
    public static double* bh = (double*)0x008672E0;
    public static ACBindings.Internal.polyListEntry* PolyNext = (ACBindings.Internal.polyListEntry*)0x008672E8;
    public static int* portal_view_num = (int*)0x008672EC;
    public static double* yinvscale = (double*)0x008672F0;
    public static double* bw = (double*)0x008672F8;
    public static float* ymax = (float*)0x00867300;
    public static float* xmin = (float*)0x00867304;
    public static ACBindings.Internal.CPolygon* PolyCurrent = (ACBindings.Internal.CPolygon*)0x0086730C;
    public static double* ty = (double*)0x00867310;
    public static float* s_rUserSuppliedDegradeBias = (float*)0x00867318;
    public static float* deg_mul = (float*)0x0086731C;
    public static int* selection_x = (int*)0x00867324;
    public static int* selection_y = (int*)0x00867328;
    public static ACBindings.Internal.portal_view_type* PortalList = (ACBindings.Internal.portal_view_type*)0x00867330;
    public static ACBindings.Internal.frameContext* FrameCurrent = (ACBindings.Internal.frameContext*)0x00867334;
    public static int* FramePushCount = (int*)0x00867338;
    public static int* pushLevelOffset = (int*)0x0086733C;
    public static int* FrameEra = (int*)0x00867340;
    public static int* useSunlight = (int*)0x00867344;
    public static ACBindings.Internal.Render* m_pRenderer = (ACBindings.Internal.Render*)0x0086734C;
    public static uint* m_CacheOverallGraphicsQuality = (uint*)0x00867350;
    public static ACBindings.Internal.CSurface* landscape_detail_surface = (ACBindings.Internal.CSurface*)0x00867364;
    public static ACBindings.Internal.CSurface* building_detail_surface = (ACBindings.Internal.CSurface*)0x00867368;
    public static ACBindings.Internal.CSurface* environment_detail_surface = (ACBindings.Internal.CSurface*)0x0086736C;
    public static ACBindings.Internal.CSurface* object_detail_surface = (ACBindings.Internal.CSurface*)0x00867370;
    public static ACBindings.Internal.CSurface* curr_detail_surface = (ACBindings.Internal.CSurface*)0x00867374;
    public static ACBindings.Internal.CMaterial* curr_material = (ACBindings.Internal.CMaterial*)0x00867378;
    public static ACBindings.Internal.CSurface* curr_surfaces = (ACBindings.Internal.CSurface*)0x0086737C;
    public static ACBindings.Internal.CSurface* curr_surface = (ACBindings.Internal.CSurface*)0x00867380;
    public static uint* curr_surface_type = (uint*)0x00867384;
    public static int* curr_texture_is_set = (int*)0x00867388;
    public static sbyte* UVIndexTbl = (sbyte*)0x0086738C;
    public static ACBindings.Internal.AC1Legacy.Vector3* selection_ray = (ACBindings.Internal.AC1Legacy.Vector3*)0x008673FC;
    public static ACBindings.Internal.RGBColor* luminosity = (ACBindings.Internal.RGBColor*)0x00867408;
    public static ACBindings.Internal.DrawParms* viewer_world_space = (ACBindings.Internal.DrawParms*)0x0086741C;
    public static ACBindings.Internal.AC1Legacy.Vector3* Zaxis = (ACBindings.Internal.AC1Legacy.Vector3*)0x00867438;
    public static ACBindings.Internal.AC1Legacy.Vector3* Yaxis = (ACBindings.Internal.AC1Legacy.Vector3*)0x0086C18C;
    public static ACBindings.Internal.AC1Legacy.Vector3* Xaxis = (ACBindings.Internal.AC1Legacy.Vector3*)0x0086C1D0;

    // Child Types
    public unsafe struct Render_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.Render*, void> RenderDestructor; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.Render*, ACBindings.Internal.RenderConfig*, byte> Startup; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.Render*, void> Shutdown; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.Render*, ACBindings.Internal.RenderDevice*> CreateRenderDevice; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.Render*, int> InitInternal; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.Render*, void> CleanupInternal; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.Render*, int, int, int, int, int> Set3DViewInternal; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.Render*, float, void> SetFOVInternal; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.Render*, float, float> GetFogAdjustment; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.Render*, void> SetupViewportInternal; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.Render*, void> UpdateLightsInternal; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.Render*, ACBindings.Internal.CMaterial*, void> SetMaterialInternal; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.Render*, int, ACBindings.Internal.Position*, void> positionPushInternal; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.Render*, int> positionPopInternal; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.Render*, void> CalcObjectMatrixInternal; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.Render*, ACBindings.Internal.Matrix4*> GetObjectMatrixInternal; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.Render*, void> polyListFinishInternal; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.Render*, ACBindings.Internal.AC1Legacy.Vector3*, ACBindings.Internal.Vec2D*, ACBindings.Internal.BoundingType> xformPointInternal; // function pointer

        // Methods
    }
    // Render::LightingType
    public enum LightingType : uint
    {
        DYNAMIC_LIGHTING = 0x0,
        STATIC_LIGHTING = 0x1,
        FULL_LIGHTING = 0x2,
        FORCE_LightingType_32_BIT = 0x7FFFFFFF
    }
    public unsafe struct MouseSelectData
    {
        // Members
        public byte bFoundPolygon;
        public double fClosestPolygon;
        public uint PolygonID;
        public int PolygonIndex;
        public byte bFoundSphere;
        public double fClosestSphere;
        public uint SphereID;
        public int SphereIndex;

        // Methods
    }

    // Members
    public System.IntPtr __vftable; // vtable pointer
    public ACBindings.Internal.RenderConfig m_Config;
    public uint m_nDisplayAdapter;
    public ACBindings.Internal.SmartArray___RenderDisplayModeType m_DisplayModes;

    // Methods

    /// <summary>
    /// <code>Offset: 0x0050DF00
    /// void __cdecl Render::SetObjectScale(const Vector3*)</code>
    /// </summary>
    public static void SetObjectScale(ACBindings.Internal.Vector3* scale) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.Vector3*, void>)0x0050DF00)(scale);

    /// <summary>
    /// <code>Offset: 0x0054BC30
    /// void __cdecl Render::SetOverallGraphicsQuality(unsigned int)</code>
    /// </summary>
    public static void SetOverallGraphicsQuality(uint Level) => ((delegate* unmanaged[Cdecl]<uint, void>)0x0054BC30)(Level);

    /// <summary>
    /// <code>Offset: 0x0054BD80
    /// unsigned int __cdecl Render::DetermineOverallGraphicsQuality()</code>
    /// </summary>
    public static uint DetermineOverallGraphicsQuality() => ((delegate* unmanaged[Cdecl]<uint>)0x0054BD80)();

    /// <summary>
    /// <code>Offset: 0x0054BE30
    /// int __cdecl Render::Set3DView(int,int,int,int)</code>
    /// </summary>
    public static int Set3DView(int x, int y, int width, int height) => ((delegate* unmanaged[Cdecl]<int, int, int, int, int>)0x0054BE30)(x, y, width, height);

    /// <summary>
    /// <code>Offset: 0x0054BE50
    /// void __cdecl Render::set_vdst(float)</code>
    /// </summary>
    public static void set_vdst(float vdst) => ((delegate* unmanaged[Cdecl]<float, void>)0x0054BE50)(vdst);

    /// <summary>
    /// <code>Offset: 0x0054BEE0
    /// int __cdecl Render::SetFOVRad(float)</code>
    /// </summary>
    public static int SetFOVRad(float radians) => ((delegate* unmanaged[Cdecl]<float, int>)0x0054BEE0)(radians);

    /// <summary>
    /// <code>Offset: 0x0054BF30
    /// void __cdecl Render::set_zfar(float)</code>
    /// </summary>
    public static void set_zfar(float zfar) => ((delegate* unmanaged[Cdecl]<float, void>)0x0054BF30)(zfar);

    /// <summary>
    /// <code>Offset: 0x0054BF50
    /// int __thiscall Render::SetFOVInternal(Render*,float)</code>
    /// </summary>
    public int SetFOVInternal(float a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Render, float, int>)0x0054BF50)(ref this, a2);

    /// <summary>
    /// <code>Offset: 0x0054C010
    /// void __cdecl Render::GetViewerBBox(const CSphere*,AC1Legacy::Vector3*,AC1Legacy::Vector3*)</code>
    /// </summary>
    public static void GetViewerBBox(ACBindings.Internal.CSphere* sphere, ACBindings.Internal.AC1Legacy.Vector3* top_left, ACBindings.Internal.AC1Legacy.Vector3* bottom_right) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.CSphere*, ACBindings.Internal.AC1Legacy.Vector3*, ACBindings.Internal.AC1Legacy.Vector3*, void>)0x0054C010)(sphere, top_left, bottom_right);

    /// <summary>
    /// <code>Offset: 0x0054C220
    /// AC1Legacy::Vector3* __cdecl Render::pick_ray(AC1Legacy::Vector3*,int,int)</code>
    /// </summary>
    public static ACBindings.Internal.AC1Legacy.Vector3* pick_ray(ACBindings.Internal.AC1Legacy.Vector3* result, int x, int y) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.AC1Legacy.Vector3*, int, int, ACBindings.Internal.AC1Legacy.Vector3*>)0x0054C220)(result, x, y);

    /// <summary>
    /// <code>Offset: 0x0054C360
    /// void __cdecl Render::set_selection_cursor(int,int,bool)</code>
    /// </summary>
    public static void set_selection_cursor(int x, int y, byte fPolyAccurate) => ((delegate* unmanaged[Cdecl]<int, int, byte, void>)0x0054C360)(x, y, fPolyAccurate);

    /// <summary>
    /// <code>Offset: 0x0054C3A0
    /// void __cdecl Render::clear_selection_cursor()</code>
    /// </summary>
    public static void clear_selection_cursor() => ((delegate* unmanaged[Cdecl]<void>)0x0054C3A0)();

    /// <summary>
    /// <code>Offset: 0x0054C3C0
    /// void __cdecl Render::SetSurfaceArray(CSurface**)</code>
    /// </summary>
    public static void SetSurfaceArray(ACBindings.Internal.CSurface** surf_array) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.CSurface**, void>)0x0054C3C0)(surf_array);

    /// <summary>
    /// <code>Offset: 0x0054C3D0
    /// void __cdecl Render::SetLandscapeDetailSurface(CSurface*)</code>
    /// </summary>
    public static void SetLandscapeDetailSurface(ACBindings.Internal.CSurface* s) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.CSurface*, void>)0x0054C3D0)(s);

    /// <summary>
    /// <code>Offset: 0x0054C3E0
    /// void __cdecl Render::SetBuildingDetailSurface(CSurface*)</code>
    /// </summary>
    public static void SetBuildingDetailSurface(ACBindings.Internal.CSurface* s) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.CSurface*, void>)0x0054C3E0)(s);

    /// <summary>
    /// <code>Offset: 0x0054C3F0
    /// void __cdecl Render::SetEnvironmentDetailSurface(CSurface*)</code>
    /// </summary>
    public static void SetEnvironmentDetailSurface(ACBindings.Internal.CSurface* s) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.CSurface*, void>)0x0054C3F0)(s);

    /// <summary>
    /// <code>Offset: 0x0054C400
    /// void __cdecl Render::SetObjectDetailSurface(CSurface*)</code>
    /// </summary>
    public static void SetObjectDetailSurface(ACBindings.Internal.CSurface* s) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.CSurface*, void>)0x0054C400)(s);

    /// <summary>
    /// <code>Offset: 0x0054C410
    /// void __cdecl Render::SetLandscapeDetailTiling(float)</code>
    /// </summary>
    public static void SetLandscapeDetailTiling(float tiling) => ((delegate* unmanaged[Cdecl]<float, void>)0x0054C410)(tiling);

    /// <summary>
    /// <code>Offset: 0x0054C420
    /// void __cdecl Render::SetEnvironmentDetailTiling(float)</code>
    /// </summary>
    public static void SetEnvironmentDetailTiling(float tiling) => ((delegate* unmanaged[Cdecl]<float, void>)0x0054C420)(tiling);

    /// <summary>
    /// <code>Offset: 0x0054C430
    /// void __cdecl Render::SetBuildingDetailTiling(float)</code>
    /// </summary>
    public static void SetBuildingDetailTiling(float tiling) => ((delegate* unmanaged[Cdecl]<float, void>)0x0054C430)(tiling);

    /// <summary>
    /// <code>Offset: 0x0054C440
    /// void __cdecl Render::SetObjectDetailTiling(float)</code>
    /// </summary>
    public static void SetObjectDetailTiling(float tiling) => ((delegate* unmanaged[Cdecl]<float, void>)0x0054C440)(tiling);

    /// <summary>
    /// <code>Offset: 0x0054C450
    /// float __cdecl Render::get_pt_limit(float,float,const Plane*)</code>
    /// </summary>
    public static float get_pt_limit(float x, float y, ACBindings.Internal.Plane* plane) => ((delegate* unmanaged[Cdecl]<float, float, ACBindings.Internal.Plane*, float>)0x0054C450)(x, y, plane);

    /// <summary>
    /// <code>Offset: 0x0054C540
    /// BoundingType __cdecl Render::corner_plane_check(float,float,float)</code>
    /// </summary>
    public static ACBindings.Internal.BoundingType corner_plane_check(float corner, float min, float max) => ((delegate* unmanaged[Cdecl]<float, float, float, ACBindings.Internal.BoundingType>)0x0054C540)(corner, min, max);

    /// <summary>
    /// <code>Offset: 0x0054C5C0
    /// void __cdecl Render::obj_view_set()</code>
    /// </summary>
    public static void obj_view_set() => ((delegate* unmanaged[Cdecl]<void>)0x0054C5C0)();

    /// <summary>
    /// <code>Offset: 0x0054C9C0
    /// void __cdecl Render::positionPush(const int,const Position*)</code>
    /// </summary>
    public static void positionPush(int op, ACBindings.Internal.Position* position) => ((delegate* unmanaged[Cdecl]<int, ACBindings.Internal.Position*, void>)0x0054C9C0)(op, position);

    /// <summary>
    /// <code>Offset: 0x0054C9E0
    /// int __cdecl Render::framePop()</code>
    /// </summary>
    public static int framePop() => ((delegate* unmanaged[Cdecl]<int>)0x0054C9E0)();

    /// <summary>
    /// <code>Offset: 0x0054C9F0
    /// void __cdecl Render::CalcObjectMatrix()</code>
    /// </summary>
    public static void CalcObjectMatrix() => ((delegate* unmanaged[Cdecl]<void>)0x0054C9F0)();

    /// <summary>
    /// <code>Offset: 0x0054CA00
    /// const Matrix4* __cdecl Render::GetObjectMatrix()</code>
    /// </summary>
    public static ACBindings.Internal.Matrix4* GetObjectMatrix() => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.Matrix4*>)0x0054CA00)();

    /// <summary>
    /// <code>Offset: 0x0054CA10
    /// void __cdecl Render::reset_active_lights_state()</code>
    /// </summary>
    public static void reset_active_lights_state() => ((delegate* unmanaged[Cdecl]<void>)0x0054CA10)();

    /// <summary>
    /// <code>Offset: 0x0054CBC0
    /// void __cdecl Render::add_active_light(int,int)</code>
    /// </summary>
    public static void add_active_light(int index, int lightClass) => ((delegate* unmanaged[Cdecl]<int, int, void>)0x0054CBC0)(index, lightClass);

    /// <summary>
    /// <code>Offset: 0x0054CD80
    /// void __cdecl Render::minimize_envcell_lighting(const Position*,float)</code>
    /// </summary>
    public static void minimize_envcell_lighting(ACBindings.Internal.Position* cellPos, float cellRadius) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.Position*, float, void>)0x0054CD80)(cellPos, cellRadius);

    /// <summary>
    /// <code>Offset: 0x0054CDC0
    /// int __cdecl Render::remove_object_light(const LIGHTINFO*)</code>
    /// </summary>
    public static int remove_object_light(ACBindings.Internal.LIGHTINFO* light_info) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.LIGHTINFO*, int>)0x0054CDC0)(light_info);

    /// <summary>
    /// <code>Offset: 0x0054CE30
    /// void __cdecl Render::restore_all_lighting()</code>
    /// </summary>
    public static void restore_all_lighting() => ((delegate* unmanaged[Cdecl]<void>)0x0054CE30)();

    /// <summary>
    /// <code>Offset: 0x0054CE60
    /// BoundingType __cdecl Render::viewconeCheck(const CSphere*)</code>
    /// </summary>
    public static ACBindings.Internal.BoundingType viewconeCheck(ACBindings.Internal.CSphere* sphere) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.CSphere*, ACBindings.Internal.BoundingType>)0x0054CE60)(sphere);

    /// <summary>
    /// <code>Offset: 0x0054CFD0
    /// int __cdecl Render::SetDegradeLevelInternal(float)</code>
    /// </summary>
    public static int SetDegradeLevelInternal(float new_deg_mul) => ((delegate* unmanaged[Cdecl]<float, int>)0x0054CFD0)(new_deg_mul);

    /// <summary>
    /// <code>Offset: 0x0054D0C0
    /// bool __cdecl Render::StartupRenderingSystem(const RenderConfig*)</code>
    /// </summary>
    public static byte StartupRenderingSystem(ACBindings.Internal.RenderConfig* config) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.RenderConfig*, byte>)0x0054D0C0)(config);

    /// <summary>
    /// <code>Offset: 0x0054D110
    /// bool __cdecl Render::StartupDevice(const unsigned int,const RenderDevicePresentation*,const RenderDeviceConfig*)</code>
    /// </summary>
    public static byte StartupDevice(uint nDisplayAdapter, ACBindings.Internal.RenderDevicePresentation* presentation, ACBindings.Internal.RenderDeviceConfig* deviceConfig) => ((delegate* unmanaged[Cdecl]<uint, ACBindings.Internal.RenderDevicePresentation*, ACBindings.Internal.RenderDeviceConfig*, byte>)0x0054D110)(nDisplayAdapter, presentation, deviceConfig);

    /// <summary>
    /// <code>Offset: 0x0054D160
    /// void __cdecl Render::ShutdownDevice()</code>
    /// </summary>
    public static void ShutdownDevice() => ((delegate* unmanaged[Cdecl]<void>)0x0054D160)();

    /// <summary>
    /// <code>Offset: 0x0054D190
    /// void __cdecl Render::ShutdownRenderingSystem()</code>
    /// </summary>
    public static void ShutdownRenderingSystem() => ((delegate* unmanaged[Cdecl]<void>)0x0054D190)();

    /// <summary>
    /// <code>Offset: 0x0054D200
    /// bool __cdecl Render::RestartDevice(const unsigned int,RenderDevicePresentation*,RenderDeviceConfig*)</code>
    /// </summary>
    public static byte RestartDevice(uint nDisplayAdapter, ACBindings.Internal.RenderDevicePresentation* presentation, ACBindings.Internal.RenderDeviceConfig* deviceConfig) => ((delegate* unmanaged[Cdecl]<uint, ACBindings.Internal.RenderDevicePresentation*, ACBindings.Internal.RenderDeviceConfig*, byte>)0x0054D200)(nDisplayAdapter, presentation, deviceConfig);

    /// <summary>
    /// <code>Offset: 0x0054D2A0
    /// RenderIndexBuffer* __cdecl Render::CreateIndexBuffer()</code>
    /// </summary>
    public static ACBindings.Internal.RenderIndexBuffer* CreateIndexBuffer() => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.RenderIndexBuffer*>)0x0054D2A0)();

    /// <summary>
    /// <code>Offset: 0x0054D2E0
    /// void __cdecl Render::SafelyStopUsingAndReleaseTexture(RenderTexture**)</code>
    /// </summary>
    public static void SafelyStopUsingAndReleaseTexture(ACBindings.Internal.RenderTexture** io_pTexture) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.RenderTexture**, void>)0x0054D2E0)(io_pTexture);

    /// <summary>
    /// <code>Offset: 0x0054D300
    /// unsigned int Render::GRPCallback_OnRenderPreferenceChanged()</code>
    /// </summary>
    public static uint GRPCallback_OnRenderPreferenceChanged() => ((delegate* unmanaged[Cdecl]<uint>)0x0054D300)();

    /// <summary>
    /// <code>Offset: 0x0054D310
    /// bool __cdecl Render::ShouldDropHighDetail()</code>
    /// </summary>
    public static byte ShouldDropHighDetail() => ((delegate* unmanaged[Cdecl]<byte>)0x0054D310)();

    /// <summary>
    /// <code>Offset: 0x0054D340
    /// float __cdecl Render::GetFramerate()</code>
    /// </summary>
    public static float GetFramerate() => ((delegate* unmanaged[Cdecl]<float>)0x0054D340)();

    /// <summary>
    /// <code>Offset: 0x0054D350
    /// bool __cdecl Render::GfxObjUnderSelectionRay(const CGfxObj*)</code>
    /// </summary>
    public static byte GfxObjUnderSelectionRay(ACBindings.Internal.CGfxObj* mesh) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.CGfxObj*, byte>)0x0054D350)(mesh);

    /// <summary>
    /// <code>Offset: 0x0054D560
    /// unsigned int __cdecl Render::GetMouseSelectionObjectID()</code>
    /// </summary>
    public static uint GetMouseSelectionObjectID() => ((delegate* unmanaged[Cdecl]<uint>)0x0054D560)();

    /// <summary>
    /// <code>Offset: 0x0054D590
    /// int __cdecl Render::GetMouseSelectionPartIndex()</code>
    /// </summary>
    public static int GetMouseSelectionPartIndex() => ((delegate* unmanaged[Cdecl]<int>)0x0054D590)();

    /// <summary>
    /// <code>Offset: 0x0054D700
    /// void __cdecl Render::CalcDegLevel()</code>
    /// </summary>
    public static void CalcDegLevel() => ((delegate* unmanaged[Cdecl]<void>)0x0054D700)();

    /// <summary>
    /// <code>Offset: 0x0054D9E0
    /// void __cdecl Render::update_viewpoint(const Position*)</code>
    /// </summary>
    public static void update_viewpoint(ACBindings.Internal.Position* viewer_pos) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.Position*, void>)0x0054D9E0)(viewer_pos);

    /// <summary>
    /// <code>Offset: 0x0054DC00
    /// void __cdecl Render::get_clip_height(float,float,ViewIntervalType*)</code>
    /// </summary>
    public static void get_clip_height(float x, float y, ACBindings.Internal.ViewIntervalType* vint) => ((delegate* unmanaged[Cdecl]<float, float, ACBindings.Internal.ViewIntervalType*, void>)0x0054DC00)(x, y, vint);

    /// <summary>
    /// <code>Offset: 0x0054DC70
    /// BoundingType __cdecl Render::block_plane_check(float,float,float,float,float,float)</code>
    /// </summary>
    public static ACBindings.Internal.BoundingType block_plane_check(float corner1, float corner2, float corner3, float corner4, float min, float max) => ((delegate* unmanaged[Cdecl]<float, float, float, float, float, float, ACBindings.Internal.BoundingType>)0x0054DC70)(corner1, corner2, corner3, corner4, min, max);

    /// <summary>
    /// <code>Offset: 0x0054DCF0
    /// void __cdecl Render::set_view(view_type*,int)</code>
    /// </summary>
    public static void set_view(ACBindings.Internal.view_type* view, int view_num) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.view_type*, int, void>)0x0054DCF0)(view, view_num);

    /// <summary>
    /// <code>Offset: 0x0054DD60
    /// void __cdecl Render::framePush(const int,const Frame*,const int)</code>
    /// </summary>
    public static void framePush(int op, ACBindings.Internal.Frame* frame, int prevIndex) => ((delegate* unmanaged[Cdecl]<int, ACBindings.Internal.Frame*, int, void>)0x0054DD60)(op, frame, prevIndex);

    /// <summary>
    /// <code>Offset: 0x0054DDC0
    /// void __cdecl Render::insert_light(int,int*,RenderLight*,RenderLight**,const LIGHTINFO*,const unsigned int,const Frame*,int)</code>
    /// </summary>
    public static void insert_light(int max_lights, int* num_lights, ACBindings.Internal.RenderLight* lights, ACBindings.Internal.RenderLight** sorted_lights, ACBindings.Internal.LIGHTINFO* light_info, uint cell_id, ACBindings.Internal.Frame* frame, int offset) => ((delegate* unmanaged[Cdecl]<int, int*, ACBindings.Internal.RenderLight*, ACBindings.Internal.RenderLight**, ACBindings.Internal.LIGHTINFO*, uint, ACBindings.Internal.Frame*, int, void>)0x0054DDC0)(max_lights, num_lights, lights, sorted_lights, light_info, cell_id, frame, offset);

    /// <summary>
    /// <code>Offset: 0x0054DFF0
    /// void __cdecl Render::add_static_light(const LIGHTINFO*,const unsigned int,const Frame*)</code>
    /// </summary>
    public static void add_static_light(ACBindings.Internal.LIGHTINFO* light_info, uint cell_id, ACBindings.Internal.Frame* frame) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.LIGHTINFO*, uint, ACBindings.Internal.Frame*, void>)0x0054DFF0)(light_info, cell_id, frame);

    /// <summary>
    /// <code>Offset: 0x0054E030
    /// void __cdecl Render::add_dynamic_light(const LIGHTINFO*,const unsigned int,const Frame*)</code>
    /// </summary>
    public static void add_dynamic_light(ACBindings.Internal.LIGHTINFO* light_info, uint cell_id, ACBindings.Internal.Frame* frame) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.LIGHTINFO*, uint, ACBindings.Internal.Frame*, void>)0x0054E030)(light_info, cell_id, frame);

    /// <summary>
    /// <code>Offset: 0x0054E060
    /// void __cdecl Render::useSunlightSet(int)</code>
    /// </summary>
    public static void useSunlightSet(int use_sunlight) => ((delegate* unmanaged[Cdecl]<int, void>)0x0054E060)(use_sunlight);

    /// <summary>
    /// <code>Offset: 0x0054E090
    /// void __cdecl Render::minimize_object_lighting()</code>
    /// </summary>
    public static void minimize_object_lighting() => ((delegate* unmanaged[Cdecl]<void>)0x0054E090)();

    /// <summary>
    /// <code>Offset: 0x0054E1A0
    /// bool __cdecl Render::StartupRenderingDevice(const RenderDevicePresentation*,const RenderDeviceConfig*)</code>
    /// </summary>
    public static byte StartupRenderingDevice(ACBindings.Internal.RenderDevicePresentation* presentation, ACBindings.Internal.RenderDeviceConfig* deviceConfig) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.RenderDevicePresentation*, ACBindings.Internal.RenderDeviceConfig*, byte>)0x0054E1A0)(presentation, deviceConfig);

    /// <summary>
    /// <code>Offset: 0x0054E260
    /// bool __cdecl Render::FlushGraphicsResources()</code>
    /// </summary>
    public static byte FlushGraphicsResources() => ((delegate* unmanaged[Cdecl]<byte>)0x0054E260)();

    /// <summary>
    /// <code>Offset: 0x0054E2C0
    /// bool __cdecl Render::RestartRenderingSystem(RenderDevicePresentation*,RenderDeviceConfig*)</code>
    /// </summary>
    public static byte RestartRenderingSystem(ACBindings.Internal.RenderDevicePresentation* presentation, ACBindings.Internal.RenderDeviceConfig* config) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.RenderDevicePresentation*, ACBindings.Internal.RenderDeviceConfig*, byte>)0x0054E2C0)(presentation, config);

    /// <summary>
    /// <code>Offset: 0x0054E320
    /// bool __cdecl Render::RestartRenderingSystem()</code>
    /// </summary>
    public static byte RestartRenderingSystem() => ((delegate* unmanaged[Cdecl]<byte>)0x0054E320)();

    /// <summary>
    /// <code>Offset: 0x0054E370
    /// void __cdecl Render::UnlinkRGRCallback(bool (__cdecl*RGRCallback)())</code>
    /// </summary>
    public static void UnlinkRGRCallback(delegate* unmanaged[Cdecl]<byte> RGRCallback) => ((delegate* unmanaged[Cdecl]<delegate* unmanaged[Cdecl]<byte>, void>)0x0054E370)(RGRCallback);

    /// <summary>
    /// <code>Offset: 0x0054E460
    /// void __cdecl Render::UpdateFromPreferences()</code>
    /// </summary>
    public static void UpdateFromPreferences() => ((delegate* unmanaged[Cdecl]<void>)0x0054E460)();

    /// <summary>
    /// <code>Offset: 0x0054E6A0
    /// int __cdecl Render::Init()</code>
    /// </summary>
    public static int Init() => ((delegate* unmanaged[Cdecl]<int>)0x0054E6A0)();

    /// <summary>
    /// <code>Offset: 0x0054E830
    /// void __cdecl Render::update_viewpoint(const Frame*)</code>
    /// </summary>
    public static void update_viewpoint(ACBindings.Internal.Frame* viewer_frame) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.Frame*, void>)0x0054E830)(viewer_frame);

    /// <summary>
    /// <code>Offset: 0x0054E860
    /// BoundingType __cdecl Render::block_check(ViewIntervalType*,ViewIntervalType*,ViewIntervalType*,ViewIntervalType*,float,float)</code>
    /// </summary>
    public static ACBindings.Internal.BoundingType block_check(ACBindings.Internal.ViewIntervalType* corner1, ACBindings.Internal.ViewIntervalType* corner2, ACBindings.Internal.ViewIntervalType* corner3, ACBindings.Internal.ViewIntervalType* corner4, float max_height, float min_height) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.ViewIntervalType*, ACBindings.Internal.ViewIntervalType*, ACBindings.Internal.ViewIntervalType*, ACBindings.Internal.ViewIntervalType*, float, float, ACBindings.Internal.BoundingType>)0x0054E860)(corner1, corner2, corner3, corner4, max_height, min_height);

    /// <summary>
    /// <code>Offset: 0x0054EBB0
    /// void __thiscall Render::Begin(Render*)</code>
    /// </summary>
    public void Begin() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Render, void>)0x0054EBB0)(ref this);

    /// <summary>
    /// <code>Offset: 0x0054EBC0
    /// void __thiscall Render::End(Render*)</code>
    /// </summary>
    public void End() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Render, void>)0x0054EBC0)(ref this);

    /// <summary>
    /// <code>Offset: 0x0054EBD0
    /// int __cdecl Render::copy_view(portal_view_type*,Vec2Dscreen**,unsigned int)</code>
    /// </summary>
    public static int copy_view(ACBindings.Internal.portal_view_type* portal_view, ACBindings.Internal.Vec2Dscreen** clip_view, uint num_pts) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.portal_view_type*, ACBindings.Internal.Vec2Dscreen**, uint, int>)0x0054EBD0)(portal_view, clip_view, num_pts);

    /// <summary>
    /// <code>Offset: 0x0054F3B0
    /// void __thiscall Render::Shutdown(Render*)</code>
    /// </summary>
    public void Shutdown() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Render, void>)0x0054F3B0)(ref this);

    /// <summary>
    /// <code>Offset: 0x0054F4A0
    /// void __cdecl Render::CheckForLostDevice()</code>
    /// </summary>
    public static void CheckForLostDevice() => ((delegate* unmanaged[Cdecl]<void>)0x0054F4A0)();

    /// <summary>
    /// <code>Offset: 0x0054F510
    /// char __cdecl Render::CC_SetGraphicsQuality(const char***)</code>
    /// </summary>
    public static sbyte CC_SetGraphicsQuality(sbyte*** m_charbuffer) => ((delegate* unmanaged[Cdecl]<sbyte***, sbyte>)0x0054F510)(m_charbuffer);

    /// <summary>
    /// <code>Offset: 0x0054F5C0
    /// char __thiscall Render::Startup(RenderConfig*,const RenderConfig*)</code>
    /// </summary>
    public sbyte Startup(ACBindings.Internal.RenderConfig* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Render, ACBindings.Internal.RenderConfig*, sbyte>)0x0054F5C0)(ref this, a2);

    /// <summary>
    /// <code>Offset: 0x0054FB60
    /// void __cdecl Render::set_default_view()</code>
    /// </summary>
    public static void set_default_view() => ((delegate* unmanaged[Cdecl]<void>)0x0054FB60)();

    /// <summary>
    /// <code>Offset: 0x0054FC10
    /// bool __cdecl Render::LinkRGRCallback(bool (__cdecl*RGRCallback)())</code>
    /// </summary>
    public static byte LinkRGRCallback(delegate* unmanaged[Cdecl]<byte> RGRCallback) => ((delegate* unmanaged[Cdecl]<delegate* unmanaged[Cdecl]<byte>, byte>)0x0054FC10)(RGRCallback);

    /// <summary>
    /// <code>Offset: 0x0054FC80
    /// int __thiscall Render::Set3DViewInternal(Render*,int,int,int,int)</code>
    /// </summary>
    public int Set3DViewInternal(int a2, int a3, int a4, int a5) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Render, int, int, int, int, int>)0x0054FC80)(ref this, a2, a3, a4, a5);

    /// <summary>
    /// <code>Offset: 0x0058BD30
    /// double __stdcall Render::GetFogAdjustment(float)</code>
    /// </summary>
    public static double GetFogAdjustment(float a1) => ((delegate* unmanaged[Stdcall]<float, double>)0x0058BD30)(a1);
}

