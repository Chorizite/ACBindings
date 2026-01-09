namespace ACBindings;

// Render
public unsafe struct Render
{
    // Statics
    public static float* s_rDegradeDistance = (float*)0x0081FC68;
    public static float* max_framerate = (float*)0x0081FC6C;
    public static float* min_framerate = (float*)0x0081FC70;
    public static float* ideal_framerate = (float*)0x0081FC74;
    public static byte* auto_update_deg_mul = (byte*)0x0081FC78;
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
    public static ACBindings.Render.LightingType* lighting_type = (ACBindings.Render.LightingType*)0x0081FCAC;
    public static uint* curr_detail_src_blend = (uint*)0x0081FCB0;
    public static uint* curr_detail_dst_blend = (uint*)0x0081FCB4;
    public static float* landscape_detail_tiling = (float*)0x0081FCB8;
    public static float* environment_detail_tiling = (float*)0x0081FCBC;
    public static float* building_detail_tiling = (float*)0x0081FCC0;
    public static float* object_detail_tiling = (float*)0x0081FCC4;
    public static float* curr_detail_tiling = (float*)0x0081FCC8;
    public static float* TextureUSize = (float*)0x0081FCCC;
    public static float* TextureVSize = (float*)0x0081FCD0;
    public static ACBindings.Vector3* object_scale_vec = (ACBindings.Vector3*)0x0081FEC0;
    public static ACBindings.Position* viewer_pos = (ACBindings.Position*)0x0081FF10;
    public static ACBindings.Position* player_pos = (ACBindings.Position*)0x0081FF60;
    public static ACBindings.RGBColor* diffuse = (ACBindings.RGBColor*)0x0081FFD0;
    public static ACBindings.view_vertex* portal_vertex = (ACBindings.view_vertex*)0x00847050;
    public static ACBindings.view_type* portal_view = (ACBindings.view_type*)0x00847054;
    public static double* tx = (double*)0x00847058;
    public static int* portal_npnts = (int*)0x00847060;
    public static float* PolyCurrentMod = (float*)0x00847064;
    public static ACBindings.HWLightUsage* curLightUsage = (ACBindings.HWLightUsage*)0x00847068;
    public static int* PolyCurrentPos = (int*)0x008470C8;
    public static float* ymin = (float*)0x008470CC;
    public static float* xmax = (float*)0x008470D0;
    public static int* static_light_used = (int*)0x008470D8;
    public static ACBindings.polyListEntry* PolyList = (ACBindings.polyListEntry*)0x008471C8;
    public static int* portal_inmask = (int*)0x008671C8;
    public static int* dynamic_light_used = (int*)0x00867248;
    public static float* local_object_radius = (float*)0x00867270;
    public static ACBindings.HWLightUsage* prevLightUsage = (ACBindings.HWLightUsage*)0x00867278;
    public static double* xinvscale = (double*)0x008672D8;
    public static double* bh = (double*)0x008672E0;
    public static ACBindings.polyListEntry* PolyNext = (ACBindings.polyListEntry*)0x008672E8;
    public static int* portal_view_num = (int*)0x008672EC;
    public static double* yinvscale = (double*)0x008672F0;
    public static double* bw = (double*)0x008672F8;
    public static float* ymax = (float*)0x00867300;
    public static float* xmin = (float*)0x00867304;
    public static ACBindings.CPolygon* PolyCurrent = (ACBindings.CPolygon*)0x0086730C;
    public static double* ty = (double*)0x00867310;
    public static float* s_rUserSuppliedDegradeBias = (float*)0x00867318;
    public static float* deg_mul = (float*)0x0086731C;
    public static int* selection_x = (int*)0x00867324;
    public static int* selection_y = (int*)0x00867328;
    public static ACBindings.portal_view_type* PortalList = (ACBindings.portal_view_type*)0x00867330;
    public static ACBindings.frameContext* FrameCurrent = (ACBindings.frameContext*)0x00867334;
    public static int* FramePushCount = (int*)0x00867338;
    public static int* pushLevelOffset = (int*)0x0086733C;
    public static int* FrameEra = (int*)0x00867340;
    public static int* useSunlight = (int*)0x00867344;
    public static byte* check_curr_object = (byte*)0x00867348;
    public static byte* check_curr_object_polys = (byte*)0x00867349;
    public static byte* check_selection = (byte*)0x0086734A;
    public static ACBindings.Render* m_pRenderer = (ACBindings.Render*)0x0086734C;
    public static uint* m_CacheOverallGraphicsQuality = (uint*)0x00867350;
    public static byte* sm_WantSafeRenderSettings = (byte*)0x00867354;
    public static ACBindings.CSurface* landscape_detail_surface = (ACBindings.CSurface*)0x00867364;
    public static ACBindings.CSurface* building_detail_surface = (ACBindings.CSurface*)0x00867368;
    public static ACBindings.CSurface* environment_detail_surface = (ACBindings.CSurface*)0x0086736C;
    public static ACBindings.CSurface* object_detail_surface = (ACBindings.CSurface*)0x00867370;
    public static ACBindings.CSurface* curr_detail_surface = (ACBindings.CSurface*)0x00867374;
    public static ACBindings.CMaterial* curr_material = (ACBindings.CMaterial*)0x00867378;
    public static ACBindings.CSurface* curr_surfaces = (ACBindings.CSurface*)0x0086737C;
    public static ACBindings.CSurface* curr_surface = (ACBindings.CSurface*)0x00867380;
    public static uint* curr_surface_type = (uint*)0x00867384;
    public static int* curr_texture_is_set = (int*)0x00867388;
    public static sbyte* UVIndexTbl = (sbyte*)0x0086738C;
    public static ACBindings.AC1Legacy.Vector3* selection_ray = (ACBindings.AC1Legacy.Vector3*)0x008673FC;
    public static ACBindings.RGBColor* luminosity = (ACBindings.RGBColor*)0x00867408;
    public static float* object_distance_2dsq = (float*)0x00867414;
    public static ACBindings.DrawParms* viewer_world_space = (ACBindings.DrawParms*)0x0086741C;
    public static ACBindings.AC1Legacy.Vector3* Zaxis = (ACBindings.AC1Legacy.Vector3*)0x00867438;
    public static ACBindings.frameContext* FrameStack = (ACBindings.frameContext*)0x008675D0;
    public static ACBindings.LightParms* world_lights = (ACBindings.LightParms*)0x008682B0;
    public static ACBindings.AC1Legacy.Vector3* local_object_center = (ACBindings.AC1Legacy.Vector3*)0x0086C124;
    public static ACBindings.AC1Legacy.Vector3* Yaxis = (ACBindings.AC1Legacy.Vector3*)0x0086C18C;
    public static ACBindings.Render.MouseSelectData* m_MouseSelectData = (ACBindings.Render.MouseSelectData*)0x0086C1A0;
    public static ACBindings.AC1Legacy.Vector3* Xaxis = (ACBindings.AC1Legacy.Vector3*)0x0086C1D0;
    public static float* particle_distance_2dsq = (float*)0x0086C208;
    public static ACBindings.SmartArray__void_ptr* m_RGRCallbacks = (ACBindings.SmartArray__void_ptr*)0x0086C214;
    public static ACBindings.LightParms* viewer_lights = (ACBindings.LightParms*)0x0087005C;

    // Child Types
    // Render_vtbl
    public unsafe struct Render_vtbl
    {
        // Members
        public System.IntPtr RenderDestructor; // function pointer
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
    // Render::MouseSelectData
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
    public ACBindings.RenderConfig m_Config;
    public uint m_nDisplayAdapter;
    public ACBindings.SmartArray__RenderDisplayModeType m_DisplayModes;

    // Methods
    // void __cdecl Render::SetObjectScale(const Vector3*)
    public static void SetObjectScale(ACBindings.Vector3* scale) => ((delegate* unmanaged[Cdecl]<ACBindings.Vector3*, void>)0x0050DF00)(scale);
    // void __cdecl Render::SetOverallGraphicsQuality(unsigned int)
    public static void SetOverallGraphicsQuality(uint Level) => ((delegate* unmanaged[Cdecl]<uint, void>)0x0054BC30)(Level);
    // unsigned int __cdecl Render::DetermineOverallGraphicsQuality()
    public static uint DetermineOverallGraphicsQuality() => ((delegate* unmanaged[Cdecl]<uint>)0x0054BD80)();
    // int __cdecl Render::Set3DView(int,int,int,int)
    public static int Set3DView(int x, int y, int width, int height) => ((delegate* unmanaged[Cdecl]<int, int, int, int, int>)0x0054BE30)(x, y, width, height);
    // void __cdecl Render::set_vdst(float)
    public static void set_vdst(float vdst) => ((delegate* unmanaged[Cdecl]<float, void>)0x0054BE50)(vdst);
    // int __cdecl Render::SetFOVRad(float)
    public static int SetFOVRad(float radians) => ((delegate* unmanaged[Cdecl]<float, int>)0x0054BEE0)(radians);
    // void __cdecl Render::set_zfar(float)
    public static void set_zfar(float zfar) => ((delegate* unmanaged[Cdecl]<float, void>)0x0054BF30)(zfar);
    // int __thiscall Render::SetFOVInternal(Render*,float)
    public int SetFOVInternal(float a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Render, float, int>)0x0054BF50)(ref this, a2);
    // void __cdecl Render::GetViewerBBox(const CSphere*,AC1Legacy::Vector3*,AC1Legacy::Vector3*)
    public static void GetViewerBBox(ACBindings.CSphere* sphere, ACBindings.AC1Legacy.Vector3* top_left, ACBindings.AC1Legacy.Vector3* bottom_right) => ((delegate* unmanaged[Cdecl]<ACBindings.CSphere*, ACBindings.AC1Legacy.Vector3*, ACBindings.AC1Legacy.Vector3*, void>)0x0054C010)(sphere, top_left, bottom_right);
    // AC1Legacy::Vector3* __cdecl Render::pick_ray(AC1Legacy::Vector3*,int,int)
    public static ACBindings.AC1Legacy.Vector3* pick_ray(ACBindings.AC1Legacy.Vector3* result, int x, int y) => ((delegate* unmanaged[Cdecl]<ACBindings.AC1Legacy.Vector3*, int, int, ACBindings.AC1Legacy.Vector3*>)0x0054C220)(result, x, y);
    // void __cdecl Render::set_selection_cursor(int,int,bool)
    public static void set_selection_cursor(int x, int y, byte fPolyAccurate) => ((delegate* unmanaged[Cdecl]<int, int, byte, void>)0x0054C360)(x, y, fPolyAccurate);
    // void __cdecl Render::clear_selection_cursor()
    public static void clear_selection_cursor() => ((delegate* unmanaged[Cdecl]<void>)0x0054C3A0)();
    // void __cdecl Render::SetSurfaceArray(CSurface**)
    public static void SetSurfaceArray(ACBindings.CSurface** surf_array) => ((delegate* unmanaged[Cdecl]<ACBindings.CSurface**, void>)0x0054C3C0)(surf_array);
    // void __cdecl Render::SetLandscapeDetailSurface(CSurface*)
    public static void SetLandscapeDetailSurface(ACBindings.CSurface* s) => ((delegate* unmanaged[Cdecl]<ACBindings.CSurface*, void>)0x0054C3D0)(s);
    // void __cdecl Render::SetBuildingDetailSurface(CSurface*)
    public static void SetBuildingDetailSurface(ACBindings.CSurface* s) => ((delegate* unmanaged[Cdecl]<ACBindings.CSurface*, void>)0x0054C3E0)(s);
    // void __cdecl Render::SetEnvironmentDetailSurface(CSurface*)
    public static void SetEnvironmentDetailSurface(ACBindings.CSurface* s) => ((delegate* unmanaged[Cdecl]<ACBindings.CSurface*, void>)0x0054C3F0)(s);
    // void __cdecl Render::SetObjectDetailSurface(CSurface*)
    public static void SetObjectDetailSurface(ACBindings.CSurface* s) => ((delegate* unmanaged[Cdecl]<ACBindings.CSurface*, void>)0x0054C400)(s);
    // void __cdecl Render::SetLandscapeDetailTiling(float)
    public static void SetLandscapeDetailTiling(float tiling) => ((delegate* unmanaged[Cdecl]<float, void>)0x0054C410)(tiling);
    // void __cdecl Render::SetEnvironmentDetailTiling(float)
    public static void SetEnvironmentDetailTiling(float tiling) => ((delegate* unmanaged[Cdecl]<float, void>)0x0054C420)(tiling);
    // void __cdecl Render::SetBuildingDetailTiling(float)
    public static void SetBuildingDetailTiling(float tiling) => ((delegate* unmanaged[Cdecl]<float, void>)0x0054C430)(tiling);
    // void __cdecl Render::SetObjectDetailTiling(float)
    public static void SetObjectDetailTiling(float tiling) => ((delegate* unmanaged[Cdecl]<float, void>)0x0054C440)(tiling);
    // float __cdecl Render::get_pt_limit(float,float,const Plane*)
    public static float get_pt_limit(float x, float y, ACBindings.Plane* plane) => ((delegate* unmanaged[Cdecl]<float, float, ACBindings.Plane*, float>)0x0054C450)(x, y, plane);
    // BoundingType __cdecl Render::corner_plane_check(float,float,float)
    public static ACBindings.BoundingType corner_plane_check(float corner, float min, float max) => ((delegate* unmanaged[Cdecl]<float, float, float, ACBindings.BoundingType>)0x0054C540)(corner, min, max);
    // void __cdecl Render::obj_view_set()
    public static void obj_view_set() => ((delegate* unmanaged[Cdecl]<void>)0x0054C5C0)();
    // void __cdecl Render::positionPush(const int,const Position*)
    public static void positionPush(int op, ACBindings.Position* position) => ((delegate* unmanaged[Cdecl]<int, ACBindings.Position*, void>)0x0054C9C0)(op, position);
    // int __cdecl Render::framePop()
    public static int framePop() => ((delegate* unmanaged[Cdecl]<int>)0x0054C9E0)();
    // void __cdecl Render::CalcObjectMatrix()
    public static void CalcObjectMatrix() => ((delegate* unmanaged[Cdecl]<void>)0x0054C9F0)();
    // const Matrix4* __cdecl Render::GetObjectMatrix()
    public static ACBindings.Matrix4* GetObjectMatrix() => ((delegate* unmanaged[Cdecl]<ACBindings.Matrix4*>)0x0054CA00)();
    // void __cdecl Render::reset_active_lights_state()
    public static void reset_active_lights_state() => ((delegate* unmanaged[Cdecl]<void>)0x0054CA10)();
    // void __cdecl Render::add_active_light(int,int)
    public static void add_active_light(int index, int lightClass) => ((delegate* unmanaged[Cdecl]<int, int, void>)0x0054CBC0)(index, lightClass);
    // void __cdecl Render::minimize_envcell_lighting(const Position*,float)
    public static void minimize_envcell_lighting(ACBindings.Position* cellPos, float cellRadius) => ((delegate* unmanaged[Cdecl]<ACBindings.Position*, float, void>)0x0054CD80)(cellPos, cellRadius);
    // int __cdecl Render::remove_object_light(const LIGHTINFO*)
    public static int remove_object_light(ACBindings.LIGHTINFO* light_info) => ((delegate* unmanaged[Cdecl]<ACBindings.LIGHTINFO*, int>)0x0054CDC0)(light_info);
    // void __cdecl Render::restore_all_lighting()
    public static void restore_all_lighting() => ((delegate* unmanaged[Cdecl]<void>)0x0054CE30)();
    // BoundingType __cdecl Render::viewconeCheck(const CSphere*)
    public static ACBindings.BoundingType viewconeCheck(ACBindings.CSphere* sphere) => ((delegate* unmanaged[Cdecl]<ACBindings.CSphere*, ACBindings.BoundingType>)0x0054CE60)(sphere);
    // int __cdecl Render::SetDegradeLevelInternal(float)
    public static int SetDegradeLevelInternal(float new_deg_mul) => ((delegate* unmanaged[Cdecl]<float, int>)0x0054CFD0)(new_deg_mul);
    // bool __cdecl Render::StartupRenderingSystem(const RenderConfig*)
    public static byte StartupRenderingSystem(ACBindings.RenderConfig* config) => ((delegate* unmanaged[Cdecl]<ACBindings.RenderConfig*, byte>)0x0054D0C0)(config);
    // bool __cdecl Render::StartupDevice(const unsigned int,const RenderDevicePresentation*,const RenderDeviceConfig*)
    public static byte StartupDevice(uint nDisplayAdapter, ACBindings.RenderDevicePresentation* presentation, ACBindings.RenderDeviceConfig* deviceConfig) => ((delegate* unmanaged[Cdecl]<uint, ACBindings.RenderDevicePresentation*, ACBindings.RenderDeviceConfig*, byte>)0x0054D110)(nDisplayAdapter, presentation, deviceConfig);
    // void __cdecl Render::ShutdownDevice()
    public static void ShutdownDevice() => ((delegate* unmanaged[Cdecl]<void>)0x0054D160)();
    // void __cdecl Render::ShutdownRenderingSystem()
    public static void ShutdownRenderingSystem() => ((delegate* unmanaged[Cdecl]<void>)0x0054D190)();
    // bool __cdecl Render::RestartDevice(const unsigned int,RenderDevicePresentation*,RenderDeviceConfig*)
    public static byte RestartDevice(uint nDisplayAdapter, ACBindings.RenderDevicePresentation* presentation, ACBindings.RenderDeviceConfig* deviceConfig) => ((delegate* unmanaged[Cdecl]<uint, ACBindings.RenderDevicePresentation*, ACBindings.RenderDeviceConfig*, byte>)0x0054D200)(nDisplayAdapter, presentation, deviceConfig);
    // RenderIndexBuffer* __cdecl Render::CreateIndexBuffer()
    public static ACBindings.RenderIndexBuffer* CreateIndexBuffer() => ((delegate* unmanaged[Cdecl]<ACBindings.RenderIndexBuffer*>)0x0054D2A0)();
    // void __cdecl Render::SafelyStopUsingAndReleaseTexture(RenderTexture**)
    public static void SafelyStopUsingAndReleaseTexture(ACBindings.RenderTexture** io_pTexture) => ((delegate* unmanaged[Cdecl]<ACBindings.RenderTexture**, void>)0x0054D2E0)(io_pTexture);
    // unsigned int Render::GRPCallback_OnRenderPreferenceChanged()
    public static uint GRPCallback_OnRenderPreferenceChanged() => ((delegate* unmanaged[Cdecl]<uint>)0x0054D300)();
    // bool __cdecl Render::ShouldDropHighDetail()
    public static byte ShouldDropHighDetail() => ((delegate* unmanaged[Cdecl]<byte>)0x0054D310)();
    // float __cdecl Render::GetFramerate()
    public static float GetFramerate() => ((delegate* unmanaged[Cdecl]<float>)0x0054D340)();
    // bool __cdecl Render::GfxObjUnderSelectionRay(const CGfxObj*)
    public static byte GfxObjUnderSelectionRay(ACBindings.CGfxObj* mesh) => ((delegate* unmanaged[Cdecl]<ACBindings.CGfxObj*, byte>)0x0054D350)(mesh);
    // unsigned int __cdecl Render::GetMouseSelectionObjectID()
    public static uint GetMouseSelectionObjectID() => ((delegate* unmanaged[Cdecl]<uint>)0x0054D560)();
    // int __cdecl Render::GetMouseSelectionPartIndex()
    public static int GetMouseSelectionPartIndex() => ((delegate* unmanaged[Cdecl]<int>)0x0054D590)();
    // void __cdecl Render::CalcDegLevel()
    public static void CalcDegLevel() => ((delegate* unmanaged[Cdecl]<void>)0x0054D700)();
    // void __cdecl Render::update_viewpoint(const Position*)
    public static void update_viewpoint(ACBindings.Position* viewer_pos) => ((delegate* unmanaged[Cdecl]<ACBindings.Position*, void>)0x0054D9E0)(viewer_pos);
    // void __cdecl Render::get_clip_height(float,float,ViewIntervalType*)
    public static void get_clip_height(float x, float y, ACBindings.ViewIntervalType* vint) => ((delegate* unmanaged[Cdecl]<float, float, ACBindings.ViewIntervalType*, void>)0x0054DC00)(x, y, vint);
    // BoundingType __cdecl Render::block_plane_check(float,float,float,float,float,float)
    public static ACBindings.BoundingType block_plane_check(float corner1, float corner2, float corner3, float corner4, float min, float max) => ((delegate* unmanaged[Cdecl]<float, float, float, float, float, float, ACBindings.BoundingType>)0x0054DC70)(corner1, corner2, corner3, corner4, min, max);
    // void __cdecl Render::set_view(view_type*,int)
    public static void set_view(ACBindings.view_type* view, int view_num) => ((delegate* unmanaged[Cdecl]<ACBindings.view_type*, int, void>)0x0054DCF0)(view, view_num);
    // void __cdecl Render::framePush(const int,const Frame*,const int)
    public static void framePush(int op, ACBindings.Frame* frame, int prevIndex) => ((delegate* unmanaged[Cdecl]<int, ACBindings.Frame*, int, void>)0x0054DD60)(op, frame, prevIndex);
    // void __cdecl Render::insert_light(int,int*,RenderLight*,RenderLight**,const LIGHTINFO*,const unsigned int,const Frame*,int)
    public static void insert_light(int max_lights, int* num_lights, ACBindings.RenderLight* lights, ACBindings.RenderLight** sorted_lights, ACBindings.LIGHTINFO* light_info, uint cell_id, ACBindings.Frame* frame, int offset) => ((delegate* unmanaged[Cdecl]<int, int*, ACBindings.RenderLight*, ACBindings.RenderLight**, ACBindings.LIGHTINFO*, uint, ACBindings.Frame*, int, void>)0x0054DDC0)(max_lights, num_lights, lights, sorted_lights, light_info, cell_id, frame, offset);
    // void __cdecl Render::add_static_light(const LIGHTINFO*,const unsigned int,const Frame*)
    public static void add_static_light(ACBindings.LIGHTINFO* light_info, uint cell_id, ACBindings.Frame* frame) => ((delegate* unmanaged[Cdecl]<ACBindings.LIGHTINFO*, uint, ACBindings.Frame*, void>)0x0054DFF0)(light_info, cell_id, frame);
    // void __cdecl Render::add_dynamic_light(const LIGHTINFO*,const unsigned int,const Frame*)
    public static void add_dynamic_light(ACBindings.LIGHTINFO* light_info, uint cell_id, ACBindings.Frame* frame) => ((delegate* unmanaged[Cdecl]<ACBindings.LIGHTINFO*, uint, ACBindings.Frame*, void>)0x0054E030)(light_info, cell_id, frame);
    // void __cdecl Render::useSunlightSet(int)
    public static void useSunlightSet(int use_sunlight) => ((delegate* unmanaged[Cdecl]<int, void>)0x0054E060)(use_sunlight);
    // void __cdecl Render::minimize_object_lighting()
    public static void minimize_object_lighting() => ((delegate* unmanaged[Cdecl]<void>)0x0054E090)();
    // bool __cdecl Render::StartupRenderingDevice(const RenderDevicePresentation*,const RenderDeviceConfig*)
    public static byte StartupRenderingDevice(ACBindings.RenderDevicePresentation* presentation, ACBindings.RenderDeviceConfig* deviceConfig) => ((delegate* unmanaged[Cdecl]<ACBindings.RenderDevicePresentation*, ACBindings.RenderDeviceConfig*, byte>)0x0054E1A0)(presentation, deviceConfig);
    // bool __cdecl Render::FlushGraphicsResources()
    public static byte FlushGraphicsResources() => ((delegate* unmanaged[Cdecl]<byte>)0x0054E260)();
    // bool __cdecl Render::RestartRenderingSystem(RenderDevicePresentation*,RenderDeviceConfig*)
    public static byte RestartRenderingSystem(ACBindings.RenderDevicePresentation* presentation, ACBindings.RenderDeviceConfig* config) => ((delegate* unmanaged[Cdecl]<ACBindings.RenderDevicePresentation*, ACBindings.RenderDeviceConfig*, byte>)0x0054E2C0)(presentation, config);
    // bool __cdecl Render::RestartRenderingSystem()
    public static byte RestartRenderingSystem() => ((delegate* unmanaged[Cdecl]<byte>)0x0054E320)();
    // void __cdecl Render::UnlinkRGRCallback(bool (__cdecl*RGRCallback)())
    public static void UnlinkRGRCallback(delegate* unmanaged[Cdecl]<byte> RGRCallback) => ((delegate* unmanaged[Cdecl]<delegate* unmanaged[Cdecl]<byte>, void>)0x0054E370)(RGRCallback);
    // void __cdecl Render::UpdateFromPreferences()
    public static void UpdateFromPreferences() => ((delegate* unmanaged[Cdecl]<void>)0x0054E460)();
    // int __cdecl Render::Init()
    public static int Init() => ((delegate* unmanaged[Cdecl]<int>)0x0054E6A0)();
    // void __cdecl Render::update_viewpoint(const Frame*)
    public static void update_viewpoint(ACBindings.Frame* viewer_frame) => ((delegate* unmanaged[Cdecl]<ACBindings.Frame*, void>)0x0054E830)(viewer_frame);
    // BoundingType __cdecl Render::block_check(ViewIntervalType*,ViewIntervalType*,ViewIntervalType*,ViewIntervalType*,float,float)
    public static ACBindings.BoundingType block_check(ACBindings.ViewIntervalType* corner1, ACBindings.ViewIntervalType* corner2, ACBindings.ViewIntervalType* corner3, ACBindings.ViewIntervalType* corner4, float max_height, float min_height) => ((delegate* unmanaged[Cdecl]<ACBindings.ViewIntervalType*, ACBindings.ViewIntervalType*, ACBindings.ViewIntervalType*, ACBindings.ViewIntervalType*, float, float, ACBindings.BoundingType>)0x0054E860)(corner1, corner2, corner3, corner4, max_height, min_height);
    // void __thiscall Render::Begin(Render*)
    public void Begin() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Render, void>)0x0054EBB0)(ref this);
    // void __thiscall Render::End(Render*)
    public void End() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Render, void>)0x0054EBC0)(ref this);
    // int __cdecl Render::copy_view(portal_view_type*,Vec2Dscreen**,unsigned int)
    public static int copy_view(ACBindings.portal_view_type* portal_view, ACBindings.Vec2Dscreen** clip_view, uint num_pts) => ((delegate* unmanaged[Cdecl]<ACBindings.portal_view_type*, ACBindings.Vec2Dscreen**, uint, int>)0x0054EBD0)(portal_view, clip_view, num_pts);
    // void __thiscall Render::Shutdown(Render*)
    public void Shutdown() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Render, void>)0x0054F3B0)(ref this);
    // void __cdecl Render::CheckForLostDevice()
    public static void CheckForLostDevice() => ((delegate* unmanaged[Cdecl]<void>)0x0054F4A0)();
    // char __cdecl Render::CC_SetGraphicsQuality(const char***)
    public static sbyte CC_SetGraphicsQuality(sbyte*** m_charbuffer) => ((delegate* unmanaged[Cdecl]<sbyte***, sbyte>)0x0054F510)(m_charbuffer);
    // char __thiscall Render::Startup(RenderConfig*,const RenderConfig*)
    public sbyte Startup(ACBindings.RenderConfig* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Render, ACBindings.RenderConfig*, sbyte>)0x0054F5C0)(ref this, a2);
    // void __cdecl Render::set_default_view()
    public static void set_default_view() => ((delegate* unmanaged[Cdecl]<void>)0x0054FB60)();
    // bool __cdecl Render::LinkRGRCallback(bool (__cdecl*RGRCallback)())
    public static byte LinkRGRCallback(delegate* unmanaged[Cdecl]<byte> RGRCallback) => ((delegate* unmanaged[Cdecl]<delegate* unmanaged[Cdecl]<byte>, byte>)0x0054FC10)(RGRCallback);
    // int __thiscall Render::Set3DViewInternal(Render*,int,int,int,int)
    public int Set3DViewInternal(int a2, int a3, int a4, int a5) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Render, int, int, int, int, int>)0x0054FC80)(ref this, a2, a3, a4, a5);
    // double __stdcall Render::GetFogAdjustment(float)
    public static double GetFogAdjustment(float a1) => ((delegate* unmanaged[Stdcall]<float, double>)0x0058BD30)(a1);
}

