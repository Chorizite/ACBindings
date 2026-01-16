namespace ACBindings.Internal;


/// <summary>Handles the rendering subsystem’s configuration, maintaining the chosen video adapter, available display modes, and renderer settings for a 32‑bit Direct3D application.</summary>
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
    public static ACBindings.Internal.Position* viewer_pos = (ACBindings.Internal.Position*)0x0081FF10;
    public static ACBindings.Internal.Position* player_pos = (ACBindings.Internal.Position*)0x0081FF58;
    public static ACBindings.Internal.RenderPrefs* m_RenderPrefs = (ACBindings.Internal.RenderPrefs*)0x0081FFA0;
    public static ACBindings.Internal.RGBColor* diffuse = (ACBindings.Internal.RGBColor*)0x0081FFD0;
    public static ACBindings.Internal.view_vertex** portal_vertex = (ACBindings.Internal.view_vertex**)0x00847050;
    public static ACBindings.Internal.view_type** portal_view = (ACBindings.Internal.view_type**)0x00847054;
    public static double* tx = (double*)0x00847058;
    public static int* portal_npnts = (int*)0x00847060;
    public static float* PolyCurrentMod = (float*)0x00847064;
    public static ACBindings.Internal.HWLightUsage** curLightUsage = (ACBindings.Internal.HWLightUsage**)0x00847068;
    public static int* PolyCurrentPos = (int*)0x008470C8;
    public static float* ymin = (float*)0x008470CC;
    public static float* xmax = (float*)0x008470D0;
    public static int** static_light_used = (int**)0x008470D8;
    public static ACBindings.Internal.polyListEntry** PolyList = (ACBindings.Internal.polyListEntry**)0x008471C8;
    public static int* portal_inmask = (int*)0x008671C8;
    public static int** dynamic_light_used = (int**)0x00867248;
    public static float* local_object_radius = (float*)0x00867270;
    public static ACBindings.Internal.HWLightUsage** prevLightUsage = (ACBindings.Internal.HWLightUsage**)0x00867278;
    public static double* xinvscale = (double*)0x008672D8;
    public static double* bh = (double*)0x008672E0;
    public static ACBindings.Internal.polyListEntry** PolyNext = (ACBindings.Internal.polyListEntry**)0x008672E8;
    public static int* portal_view_num = (int*)0x008672EC;
    public static double* yinvscale = (double*)0x008672F0;
    public static double* bw = (double*)0x008672F8;
    public static float* ymax = (float*)0x00867300;
    public static float* xmin = (float*)0x00867304;
    public static ACBindings.Internal.CPolygon** PolyCurrent = (ACBindings.Internal.CPolygon**)0x0086730C;
    public static double* ty = (double*)0x00867310;
    public static float* s_rUserSuppliedDegradeBias = (float*)0x00867318;
    public static float* deg_mul = (float*)0x0086731C;
    public static int* selection_x = (int*)0x00867324;
    public static int* selection_y = (int*)0x00867328;
    public static ACBindings.Internal.portal_view_type** PortalList = (ACBindings.Internal.portal_view_type**)0x00867330;
    public static ACBindings.Internal.frameContext** FrameCurrent = (ACBindings.Internal.frameContext**)0x00867334;
    public static int* FramePushCount = (int*)0x00867338;
    public static int* pushLevelOffset = (int*)0x0086733C;
    public static int* FrameEra = (int*)0x00867340;
    public static int* useSunlight = (int*)0x00867344;
    public static byte* check_curr_object = (byte*)0x00867348;
    public static byte* check_curr_object_polys = (byte*)0x00867349;
    public static byte* check_selection = (byte*)0x0086734A;
    public static ACBindings.Internal.Render** m_pRenderer = (ACBindings.Internal.Render**)0x0086734C;
    public static uint* m_CacheOverallGraphicsQuality = (uint*)0x00867350;
    public static byte* sm_WantSafeRenderSettings = (byte*)0x00867354;
    public static ACBindings.Internal.CSurface** landscape_detail_surface = (ACBindings.Internal.CSurface**)0x00867364;
    public static ACBindings.Internal.CSurface** building_detail_surface = (ACBindings.Internal.CSurface**)0x00867368;
    public static ACBindings.Internal.CSurface** environment_detail_surface = (ACBindings.Internal.CSurface**)0x0086736C;
    public static ACBindings.Internal.CSurface** object_detail_surface = (ACBindings.Internal.CSurface**)0x00867370;
    public static ACBindings.Internal.CSurface** curr_detail_surface = (ACBindings.Internal.CSurface**)0x00867374;
    public static ACBindings.Internal.CMaterial** curr_material = (ACBindings.Internal.CMaterial**)0x00867378;
    public static ACBindings.Internal.CSurface*** curr_surfaces = (ACBindings.Internal.CSurface***)0x0086737C;
    public static ACBindings.Internal.CSurface** curr_surface = (ACBindings.Internal.CSurface**)0x00867380;
    public static uint* curr_surface_type = (uint*)0x00867384;
    public static int* curr_texture_is_set = (int*)0x00867388;
    public static sbyte** UVIndexTbl = (sbyte**)0x0086738C;
    public static ACBindings.Internal.AC1Legacy.Vector3* selection_ray = (ACBindings.Internal.AC1Legacy.Vector3*)0x008673FC;
    public static ACBindings.Internal.RGBColor* luminosity = (ACBindings.Internal.RGBColor*)0x00867408;
    public static float* object_distance_2dsq = (float*)0x00867414;
    public static ACBindings.Internal.DrawParms* viewer_world_space = (ACBindings.Internal.DrawParms*)0x0086741C;
    public static ACBindings.Internal.AC1Legacy.Vector3* Zaxis = (ACBindings.Internal.AC1Legacy.Vector3*)0x00867438;
    public static ACBindings.Internal.LightParms* world_lights = (ACBindings.Internal.LightParms*)0x008682B0;
    public static ACBindings.Internal.AC1Legacy.Vector3* local_object_center = (ACBindings.Internal.AC1Legacy.Vector3*)0x0086C124;
    public static ACBindings.Internal.AC1Legacy.Vector3* Yaxis = (ACBindings.Internal.AC1Legacy.Vector3*)0x0086C18C;
    public static ACBindings.Internal.Render.MouseSelectData* m_MouseSelectData = (ACBindings.Internal.Render.MouseSelectData*)0x0086C1A0;
    public static ACBindings.Internal.AC1Legacy.Vector3* Xaxis = (ACBindings.Internal.AC1Legacy.Vector3*)0x0086C1D0;
    public static float* particle_distance_2dsq = (float*)0x0086C208;
    public static ACBindings.Internal.SmartArray__void_ptr* m_RGRCallbacks = (ACBindings.Internal.SmartArray__void_ptr*)0x0086C20C;
    public static ACBindings.Internal.LightParms* viewer_lights = (ACBindings.Internal.LightParms*)0x0086C238;

    // Child Types
    public unsafe struct Render_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.Render*, void> RenderDestructor; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.Render*, ACBindings.Internal.RenderConfig*, byte> Startup; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.Render*, void> Shutdown; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.Render*, ACBindings.Internal.RenderDevice*> CreateRenderDevice; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.Render*, int> InitInternal; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.Render*, void> CleanupInternal; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.Render*, int, int, int, int, int> Set3DViewInternal; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.Render*, float, void> SetFOVInternal; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.Render*, float, float> GetFogAdjustment; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.Render*, void> SetupViewportInternal; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.Render*, void> UpdateLightsInternal; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.Render*, ACBindings.Internal.CMaterial*, void> SetMaterialInternal; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.Render*, int, ACBindings.Internal.Position*, void> positionPushInternal; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.Render*, int> positionPopInternal; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.Render*, void> CalcObjectMatrixInternal; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.Render*, ACBindings.Internal.Matrix4*> GetObjectMatrixInternal; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.Render*, void> polyListFinishInternal; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.Render*, ACBindings.Internal.AC1Legacy.Vector3*, ACBindings.Internal.Vec2D*, ACBindings.Internal.BoundingType> xformPointInternal; // function pointer

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

    /// <summary>Captures the outcome of a mouse selection query, storing proximity and identification data for polygons and spheres.</summary>
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

    /// <summary>Sets the object's scaling factor from a Vector3, updating internal scale components and determining the maximum component value.
    /// <code>Offset: 0x0050DF00
    /// void __cdecl Render::SetObjectScale(const Vector3*)</code>
    /// </summary>
    /// <param name="scale">Pointer to a Vector3 containing X, Y, and Z scale values.</param>
    public static void SetObjectScale(ACBindings.Internal.Vector3* scale) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.Vector3*, void>)0x0050DF00)(scale);

    /// <summary>Configures the renderer's graphics settings to match a predefined overall quality level.
    /// <code>Offset: 0x0054BC30
    /// void __cdecl Render::SetOverallGraphicsQuality(unsigned int)</code>
    /// </summary>
    /// <param name="Level">An unsigned integer specifying the desired graphics quality (1–5).</param>
    public static void SetOverallGraphicsQuality(uint Level) => ((delegate* unmanaged[Cdecl]<uint, void>)0x0054BC30)(Level);

    /// <summary>Determines the overall graphics quality level by evaluating current rendering preferences and mapping them to discrete tiers.
    /// <code>Offset: 0x0054BD80
    /// unsigned int __cdecl Render::DetermineOverallGraphicsQuality()</code>
    /// </summary>
    /// <returns>An unsigned integer indicating the quality tier: 1 through 5 for supported configurations, or 0 if no suitable tier matches.</returns>
    public static uint DetermineOverallGraphicsQuality() => ((delegate* unmanaged[Cdecl]<uint>)0x0054BD80)();

    /// <summary>Defines the rendering viewport for 3D content by specifying its position and dimensions.
    /// <code>Offset: 0x0054BE30
    /// int __cdecl Render::Set3DView(int,int,int,int)</code>
    /// </summary>
    /// <param name="x">Horizontal offset of the viewport's origin in pixels.</param>
    /// <param name="y">Vertical offset of the viewport's origin in pixels.</param>
    /// <param name="width">Width of the viewport in pixels.</param>
    /// <param name="height">Height of the viewport in pixels.</param>
    /// <returns>An integer status code indicating success or failure of setting the 3D view.</returns>
    public static int Set3DView(int x, int y, int width, int height) => ((delegate* unmanaged[Cdecl]<int, int, int, int, int>)0x0054BE30)(x, y, width, height);

    /// <summary>Configures rendering depth parameters based on a supplied view distance factor, adjusting the near clipping plane and informing the underlying renderer of an appropriate view angle.
    /// <code>Offset: 0x0054BE50
    /// void __cdecl Render::set_vdst(float)</code>
    /// </summary>
    /// <param name="vdst">The desired view distance scaling factor used to compute near clip distance and view angle.</param>
    public static void set_vdst(float vdst) => ((delegate* unmanaged[Cdecl]<float, void>)0x0054BE50)(vdst);

    /// <summary>Sets the camera's field‑of‑view using a radian value, validating that it lies between 0 and π.
    /// <code>Offset: 0x0054BEE0
    /// int __cdecl Render::SetFOVRad(float)</code>
    /// </summary>
    /// <param name="radians">The desired FOV expressed in radians.</param>
    /// <returns>Non‑zero if the FOV was applied successfully; zero if the input was out of range.</returns>
    public static int SetFOVRad(float radians) => ((delegate* unmanaged[Cdecl]<float, int>)0x0054BEE0)(radians);

    /// <summary>Sets the far clipping plane distance for the renderer, updating internal state and invoking necessary configuration changes.
    /// <code>Offset: 0x0054BF30
    /// void __cdecl Render::set_zfar(float)</code>
    /// </summary>
    /// <param name="zfar">The new far-plane distance in world units.</param>
    public static void set_zfar(float zfar) => ((delegate* unmanaged[Cdecl]<float, void>)0x0054BF30)(zfar);

    /// <summary>Sets the camera's field‑of‑view in the render context and recomputes internal scaling and projection parameters.
    /// <code>Offset: 0x0054BF50
    /// int __thiscall Render::SetFOVInternal(Render*,float)</code>
    /// </summary>
    /// <param name="a2">Desired field‑of‑view angle in radians.</param>
    /// <returns>The 32‑bit bit pattern of the supplied FOV value (the raw integer representation of the float).</returns>
    public int SetFOVInternal(float a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Render, float, int>)0x0054BF50)(ref this, a2);

    /// <summary>Computes an axis‑aligned bounding box in view space that encloses the supplied sphere. The resulting top‑left and bottom‑right corners are written into the provided output vectors.
    /// <code>Offset: 0x0054C010
    /// void __cdecl Render::GetViewerBBox(const CSphere*,AC1Legacy::Vector3*,AC1Legacy::Vector3*)</code>
    /// </summary>
    /// <param name="sphere">The input sphere to be bounded.</param>
    /// <param name="top_left">Receives the coordinates of the box's minimal corner in viewer space.</param>
    /// <param name="bottom_right">Receives the coordinates of the box's maximal corner in viewer space.</param>
    public static void GetViewerBBox(ACBindings.Internal.CSphere* sphere, ACBindings.Internal.AC1Legacy.Vector3* top_left, ACBindings.Internal.AC1Legacy.Vector3* bottom_right) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.CSphere*, ACBindings.Internal.AC1Legacy.Vector3*, ACBindings.Internal.AC1Legacy.Vector3*, void>)0x0054C010)(sphere, top_left, bottom_right);

    /// <summary>Computes the normalized direction vector of a picking ray originating at the camera and passing through pixel (x, y) on the viewport.
    /// <code>Offset: 0x0054C220
    /// AC1Legacy::Vector3* __cdecl Render::pick_ray(AC1Legacy::Vector3*,int,int)</code>
    /// </summary>
    /// <param name="result">Pointer to a Vector3 that receives the calculated ray direction.</param>
    /// <param name="x">Screen-space X coordinate of the target pixel.</param>
    /// <param name="y">Screen-space Y coordinate of the target pixel.</param>
    /// <returns>Same pointer as passed in, pointing to the normalized ray vector.</returns>
    public static ACBindings.Internal.AC1Legacy.Vector3* pick_ray(ACBindings.Internal.AC1Legacy.Vector3* result, int x, int y) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.AC1Legacy.Vector3*, int, int, ACBindings.Internal.AC1Legacy.Vector3*>)0x0054C220)(result, x, y);

    /// <summary>Sets the selection cursor coordinates and updates internal state to initiate a new selection check, optionally enabling polygon‑accurate mode.
    /// <code>Offset: 0x0054C360
    /// void __cdecl Render::set_selection_cursor(int,int,bool)</code>
    /// </summary>
    /// <param name="x">The horizontal coordinate of the selection cursor.</param>
    /// <param name="y">The vertical coordinate of the selection cursor.</param>
    /// <param name="fPolyAccurate">If true, selection will consider only entire polygons; otherwise a simpler bounding check is used.</param>
    public static void set_selection_cursor(int x, int y, byte fPolyAccurate) => ((delegate* unmanaged[Cdecl]<int, int, byte, void>)0x0054C360)(x, y, fPolyAccurate);

    /// <summary>Clears the current selection cursor state, resetting selection flags and counters.
    /// <code>Offset: 0x0054C3A0
    /// void __cdecl Render::clear_selection_cursor()</code>
    /// </summary>
    public static void clear_selection_cursor() => ((delegate* unmanaged[Cdecl]<void>)0x0054C3A0)();

    /// <summary>Assigns the supplied array of surface pointers as the active rendering surfaces for subsequent operations.
    /// <code>Offset: 0x0054C3C0
    /// void __cdecl Render::SetSurfaceArray(CSurface**)</code>
    /// </summary>
    /// <param name="surf_array">Array of CSurface pointers that the renderer will use.</param>
    public static void SetSurfaceArray(ACBindings.Internal.CSurface** surf_array) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.CSurface**, void>)0x0054C3C0)(surf_array);

    /// <summary>Assigns the specified surface as the current landscape detail surface for rendering.
    /// <code>Offset: 0x0054C3D0
    /// void __cdecl Render::SetLandscapeDetailSurface(CSurface*)</code>
    /// </summary>
    /// <param name="s">The surface to use for landscape details.</param>
    public static void SetLandscapeDetailSurface(ACBindings.Internal.CSurface* s) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.CSurface*, void>)0x0054C3D0)(s);

    /// <summary>Sets the surface to be used for building detail rendering.
    /// <code>Offset: 0x0054C3E0
    /// void __cdecl Render::SetBuildingDetailSurface(CSurface*)</code>
    /// </summary>
    /// <param name="s">The surface containing texture and appearance data for building details.</param>
    public static void SetBuildingDetailSurface(ACBindings.Internal.CSurface* s) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.CSurface*, void>)0x0054C3E0)(s);

    /// <summary>Designates the surface used for environment‑detail rendering within the Render system.
    /// <code>Offset: 0x0054C3F0
    /// void __cdecl Render::SetEnvironmentDetailSurface(CSurface*)</code>
    /// </summary>
    /// <param name="s">Surface that provides detail textures and properties for environmental effects.</param>
    public static void SetEnvironmentDetailSurface(ACBindings.Internal.CSurface* s) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.CSurface*, void>)0x0054C3F0)(s);

    /// <summary>Assigns the specified surface as the current object detail surface for rendering.
    /// <code>Offset: 0x0054C400
    /// void __cdecl Render::SetObjectDetailSurface(CSurface*)</code>
    /// </summary>
    /// <param name="s">The surface to use for detailed object rendering.</param>
    public static void SetObjectDetailSurface(ACBindings.Internal.CSurface* s) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.CSurface*, void>)0x0054C400)(s);

    /// <summary>Sets the tiling factor used when rendering landscape details.
    /// <code>Offset: 0x0054C410
    /// void __cdecl Render::SetLandscapeDetailTiling(float)</code>
    /// </summary>
    /// <param name="tiling">The scaling value applied to landscape texture tiling.</param>
    public static void SetLandscapeDetailTiling(float tiling) => ((delegate* unmanaged[Cdecl]<float, void>)0x0054C410)(tiling);

    /// <summary>Sets the tiling factor used when rendering environmental details.
    /// <code>Offset: 0x0054C420
    /// void __cdecl Render::SetEnvironmentDetailTiling(float)</code>
    /// </summary>
    /// <param name="tiling">The new tiling value determining repetition of environmental textures or effects.</param>
    public static void SetEnvironmentDetailTiling(float tiling) => ((delegate* unmanaged[Cdecl]<float, void>)0x0054C420)(tiling);

    /// <summary>Sets building detail tiling factor used during rendering of buildings.
    /// <code>Offset: 0x0054C430
    /// void __cdecl Render::SetBuildingDetailTiling(float)</code>
    /// </summary>
    /// <param name="tiling">The new tiling value applied to building textures.</param>
    public static void SetBuildingDetailTiling(float tiling) => ((delegate* unmanaged[Cdecl]<float, void>)0x0054C430)(tiling);

    /// <summary>Sets the global object detail tiling value used during rendering.
    /// <code>Offset: 0x0054C440
    /// void __cdecl Render::SetObjectDetailTiling(float)</code>
    /// </summary>
    /// <param name="tiling">Tiling factor to apply to rendered objects.</param>
    public static void SetObjectDetailTiling(float tiling) => ((delegate* unmanaged[Cdecl]<float, void>)0x0054C440)(tiling);

    /// <summary>Computes a depth limit from the point (x, y) relative to a plane, returning a signed distance constrained by the plane’s normal direction and magnitude.
    /// <code>Offset: 0x0054C450
    /// float __cdecl Render::get_pt_limit(float,float,const Plane*)</code>
    /// </summary>
    /// <param name="x">X coordinate of the point in world space.</param>
    /// <param name="y">Y coordinate of the point in world space.</param>
    /// <param name="plane">Plane used for the calculation; its normal determines the sign and bounds of the return value.</param>
    /// <returns>Float representing a constrained distance from the point to the plane. For planes whose normal points upward (z &gt; 0.0002), returns the negative of the projected distance when that distance is between 0 and 1000, otherwise zero or an out‑of‑range sentinel value. For planes with downward normals (z &lt; -0.0002), returns the positive projected distance within the same bounds; outside those bounds it returns zero or the sentinel. If the normal’s z component is close to zero (between –0.0002 and 0.0002), a side test determines whether to return zero or the sentinel.</returns>
    public static float get_pt_limit(float x, float y, ACBindings.Internal.Plane* plane) => ((delegate* unmanaged[Cdecl]<float, float, ACBindings.Internal.Plane*, float>)0x0054C450)(x, y, plane);

    /// <summary>Determines the positional relationship of a point along a plane normal relative to specified minimum and maximum bounds.
    /// <code>Offset: 0x0054C540
    /// BoundingType __cdecl Render::corner_plane_check(float,float,float)</code>
    /// </summary>
    /// <param name="corner">Coordinate value of the point along the plane normal.</param>
    /// <param name="min">Lower bound defining one side of the plane.</param>
    /// <param name="max">Upper bound defining the opposite side of the plane.</param>
    /// <returns>BoundingType representing whether the point is outside (0), intersects the boundary (1), or lies entirely inside (2).</returns>
    public static ACBindings.Internal.BoundingType corner_plane_check(float corner, float min, float max) => ((delegate* unmanaged[Cdecl]<float, float, float, ACBindings.Internal.BoundingType>)0x0054C540)(corner, min, max);

    /// <summary>Transforms portal geometry and associated clipping planes into view space using the current frame matrix, updating vertex positions and plane equations for rendering.
    /// <code>Offset: 0x0054C5C0
    /// void __cdecl Render::obj_view_set()</code>
    /// </summary>
    public static void obj_view_set() => ((delegate* unmanaged[Cdecl]<void>)0x0054C5C0)();

    /// <summary>Pushes a rendering position onto the render state stack using the specified operation code and Position data.
    /// <code>Offset: 0x0054C9C0
    /// void __cdecl Render::positionPush(const int,const Position*)</code>
    /// </summary>
    /// <param name="op">Operation code determining how the position should be handled during rendering.</param>
    /// <param name="position">Pointer to Position structure containing object cell ID, frame, and base class information.</param>
    public static void positionPush(int op, ACBindings.Internal.Position* position) => ((delegate* unmanaged[Cdecl]<int, ACBindings.Internal.Position*, void>)0x0054C9C0)(op, position);

    /// <summary>Terminates the current rendering frame, invoking the renderer's internal frame‑pop routine.
    /// <code>Offset: 0x0054C9E0
    /// int __cdecl Render::framePop()</code>
    /// </summary>
    /// <returns>An integer status code from the underlying renderer indicating success or failure.</returns>
    public static int framePop() => ((delegate* unmanaged[Cdecl]<int>)0x0054C9E0)();

    /// <summary>Computes the world‑space transformation matrix for renderable objects, updating internal state used by the rendering pipeline.
    /// <code>Offset: 0x0054C9F0
    /// void __cdecl Render::CalcObjectMatrix()</code>
    /// </summary>
    public static void CalcObjectMatrix() => ((delegate* unmanaged[Cdecl]<void>)0x0054C9F0)();

    /// <summary>Retrieves the current object's transformation matrix used during rendering.
    /// <code>Offset: 0x0054CA00
    /// const Matrix4* __cdecl Render::GetObjectMatrix()</code>
    /// </summary>
    /// <returns>A pointer to a constant Matrix4 representing the object-to-world transform.</returns>
    public static ACBindings.Internal.Matrix4* GetObjectMatrix() => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.Matrix4*>)0x0054CA00)();

    /// <summary>Restores the renderer’s internal light state to defaults, clearing active light counts and disabling all lighting flags.
    /// <code>Offset: 0x0054CA10
    /// void __cdecl Render::reset_active_lights_state()</code>
    /// </summary>
    public static void reset_active_lights_state() => ((delegate* unmanaged[Cdecl]<void>)0x0054CA10)();

    /// <summary>Adds or updates an active light in the renderer's internal list by storing the light's identifier and class, ensuring existing entries are moved to inactive slots if replaced.
    /// <code>Offset: 0x0054CBC0
    /// void __cdecl Render::add_active_light(int,int)</code>
    /// </summary>
    /// <param name="index">The unique identifier of the light to be added or updated.</param>
    /// <param name="lightClass">The classification or type code associated with the light.</param>
    public static void add_active_light(int index, int lightClass) => ((delegate* unmanaged[Cdecl]<int, int, void>)0x0054CBC0)(index, lightClass);

    /// <summary>Configures rendering light state by resetting active lights, marking all dynamic lights as active, and enabling or disabling each fixed-function light according to current global flags.
    /// <code>Offset: 0x0054CD80
    /// void __cdecl Render::minimize_envcell_lighting(const Position*,float)</code>
    /// </summary>
    /// <param name="cellPos">The position of an environment cell; currently unused but reserved for future use.</param>
    /// <param name="cellRadius">The radius of the environment cell; currently unused.</param>
    public static void minimize_envcell_lighting(ACBindings.Internal.Position* cellPos, float cellRadius) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.Position*, float, void>)0x0054CD80)(cellPos, cellRadius);

    /// <summary>Determines whether the supplied LIGHTINFO represents an object light of type zero with both internal flags cleared, returning non-zero when these conditions hold.
    /// <code>Offset: 0x0054CDC0
    /// int __cdecl Render::remove_object_light(const LIGHTINFO*)</code>
    /// </summary>
    /// <param name="light_info">Pointer to the LIGHTINFO structure whose state is evaluated.</param>
    /// <returns>Non-zero if light_info->type equals zero and the two internal flag variables are unset; otherwise zero.</returns>
    public static int remove_object_light(ACBindings.Internal.LIGHTINFO* light_info) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.LIGHTINFO*, int>)0x0054CDC0)(light_info);

    /// <summary>Restores all lighting by resetting the used flags for static and dynamic lights, marking every light as active for subsequent rendering passes.
    /// <code>Offset: 0x0054CE30
    /// void __cdecl Render::restore_all_lighting()</code>
    /// </summary>
    public static void restore_all_lighting() => ((delegate* unmanaged[Cdecl]<void>)0x0054CE30)();

    /// <summary>Determines whether the specified sphere lies within the viewer's view cone, accounting for clipping planes and portal geometry.
    /// <code>Offset: 0x0054CE60
    /// BoundingType __cdecl Render::viewconeCheck(const CSphere*)</code>
    /// </summary>
    /// <param name="sphere">Sphere to test against the current view frustum.</param>
    /// <returns>An enum value indicating whether the sphere is outside, partially visible, or fully inside the view cone.</returns>
    public static ACBindings.Internal.BoundingType viewconeCheck(ACBindings.Internal.CSphere* sphere) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.CSphere*, ACBindings.Internal.BoundingType>)0x0054CE60)(sphere);

    /// <summary>Adjusts rendering parameters according to a specified degradation multiplier, updating limits on static/dynamic lights and distance thresholds for objects and particles.
    /// <code>Offset: 0x0054CFD0
    /// int __cdecl Render::SetDegradeLevelInternal(float)</code>
    /// </summary>
    /// <param name="new_deg_mul">Multiplier applied to degrade rendering quality.</param>
    /// <returns>1 indicating success.</returns>
    public static int SetDegradeLevelInternal(float new_deg_mul) => ((delegate* unmanaged[Cdecl]<float, int>)0x0054CFD0)(new_deg_mul);

    /// <summary>Initializes the rendering subsystem using the supplied configuration if no renderer is currently active. Supports only Direct3D drivers; fails otherwise.
    /// <code>Offset: 0x0054D0C0
    /// bool __cdecl Render::StartupRenderingSystem(const RenderConfig*)</code>
    /// </summary>
    /// <param name="config">Configuration data for initializing the renderer, including graphics driver selection.</param>
    /// <returns>True when the rendering system starts successfully; false if a renderer already exists, an unsupported driver is specified, allocation fails, or initialization of the renderer object fails.</returns>
    public static byte StartupRenderingSystem(ACBindings.Internal.RenderConfig* config) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.RenderConfig*, byte>)0x0054D0C0)(config);

    /// <summary>Initializes the rendering system by selecting a display adapter and configuring its presentation parameters.
    /// <code>Offset: 0x0054D110
    /// bool __cdecl Render::StartupDevice(const unsigned int,const RenderDevicePresentation*,const RenderDeviceConfig*)</code>
    /// </summary>
    /// <param name="nDisplayAdapter">Zero‑based index of the video adapter to use for rendering.</param>
    /// <param name="presentation">Pointer to a RenderDevicePresentation structure containing window handle, resolution, fullscreen settings, and related options.</param>
    /// <param name="deviceConfig">Optional pointer to additional device configuration; may be null.</param>
    /// <returns>True if the render device was successfully created and configured; otherwise false.</returns>
    public static byte StartupDevice(uint nDisplayAdapter, ACBindings.Internal.RenderDevicePresentation* presentation, ACBindings.Internal.RenderDeviceConfig* deviceConfig) => ((delegate* unmanaged[Cdecl]<uint, ACBindings.Internal.RenderDevicePresentation*, ACBindings.Internal.RenderDeviceConfig*, byte>)0x0054D110)(nDisplayAdapter, presentation, deviceConfig);

    /// <summary>Terminates the current rendering device and releases its associated graphics resources.
    /// <code>Offset: 0x0054D160
    /// void __cdecl Render::ShutdownDevice()</code>
    /// </summary>
    public static void ShutdownDevice() => ((delegate* unmanaged[Cdecl]<void>)0x0054D160)();

    /// <summary>Terminates the rendering system, releasing all associated resources and destroying device and renderer instances.
    /// <code>Offset: 0x0054D190
    /// void __cdecl Render::ShutdownRenderingSystem()</code>
    /// </summary>
    public static void ShutdownRenderingSystem() => ((delegate* unmanaged[Cdecl]<void>)0x0054D190)();

    /// <summary>Restarts the rendering device using the supplied presentation parameters. If the initial attempt fails, retries with the previously active configuration and restores focus window and stencil‑buffer settings.
    /// <code>Offset: 0x0054D200
    /// bool __cdecl Render::RestartDevice(const unsigned int,RenderDevicePresentation*,RenderDeviceConfig*)</code>
    /// </summary>
    /// <param name="nDisplayAdapter">Index of the display adapter to use (currently unused).</param>
    /// <param name="presentation">Pointer to a RenderDevicePresentation structure containing window handle, dimensions, fullscreen options, etc.</param>
    /// <param name="deviceConfig">Pointer to a RenderDeviceConfig structure; its focus window and stencil‑buffer flag are preserved during the restart.</param>
    /// <returns>True if the device was successfully reinitialized; otherwise false.</returns>
    public static byte RestartDevice(uint nDisplayAdapter, ACBindings.Internal.RenderDevicePresentation* presentation, ACBindings.Internal.RenderDeviceConfig* deviceConfig) => ((delegate* unmanaged[Cdecl]<uint, ACBindings.Internal.RenderDevicePresentation*, ACBindings.Internal.RenderDeviceConfig*, byte>)0x0054D200)(nDisplayAdapter, presentation, deviceConfig);

    /// <summary>Creates and initializes a new index buffer. If a renderer exists, obtains one from the render device; otherwise allocates a fresh buffer, sets up its vtable, and calls Begin on it.
    /// <code>Offset: 0x0054D2A0
    /// RenderIndexBuffer* __cdecl Render::CreateIndexBuffer()</code>
    /// </summary>
    /// <returns>A pointer to the initialized RenderIndexBuffer, or null if memory allocation fails.</returns>
    public static ACBindings.Internal.RenderIndexBuffer* CreateIndexBuffer() => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.RenderIndexBuffer*>)0x0054D2A0)();

    /// <summary>Stops usage of the specified texture and releases its resources, then clears the caller’s pointer.
    /// <code>Offset: 0x0054D2E0
    /// void __cdecl Render::SafelyStopUsingAndReleaseTexture(RenderTexture**)</code>
    /// </summary>
    /// <param name="io_pTexture">A pointer to a RenderTexture pointer; the function releases the texture via its interface and sets this pointer to null.</param>
    public static void SafelyStopUsingAndReleaseTexture(ACBindings.Internal.RenderTexture** io_pTexture) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.RenderTexture**, void>)0x0054D2E0)(io_pTexture);

    /// <summary>Computes the current overall graphics quality based on system preferences and stores the result in a cache.
    /// <code>Offset: 0x0054D300
    /// unsigned int Render::GRPCallback_OnRenderPreferenceChanged()</code>
    /// </summary>
    /// <returns>The computed graphics quality level as an unsigned integer.</returns>
    public static uint GRPCallback_OnRenderPreferenceChanged() => ((delegate* unmanaged[Cdecl]<uint>)0x0054D300)();

    /// <summary>Decides whether to drop high‑detail rendering based on configuration and environment texture detail settings.
    /// <code>Offset: 0x0054D310
    /// bool __cdecl Render::ShouldDropHighDetail()</code>
    /// </summary>
    /// <returns>True if high‑detail textures should be omitted; otherwise, false.</returns>
    public static byte ShouldDropHighDetail() => ((delegate* unmanaged[Cdecl]<byte>)0x0054D310)();

    /// <summary>Retrieves the current rendering frame rate as a floating‑point value.
    /// <code>Offset: 0x0054D340
    /// float __cdecl Render::GetFramerate()</code>
    /// </summary>
    /// <returns>The number of frames rendered per second.</returns>
    public static float GetFramerate() => ((delegate* unmanaged[Cdecl]<float>)0x0054D340)();

    /// <summary>Determines whether the specified graphics object lies under the current selection ray, updating internal mouse‑selection data accordingly.
    /// <code>Offset: 0x0054D350
    /// bool __cdecl Render::GfxObjUnderSelectionRay(const CGfxObj*)</code>
    /// </summary>
    /// <param name="mesh">The CGfxObj to test against the selection ray.</param>
    /// <returns>True if the object (or one of its polygons) intersects the selection ray; otherwise false.</returns>
    public static byte GfxObjUnderSelectionRay(ACBindings.Internal.CGfxObj* mesh) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.CGfxObj*, byte>)0x0054D350)(mesh);

    /// <summary>Returns the identifier of the object under the mouse cursor, preferring polygons over spheres; returns 0 if no selectable object is found.
    /// <code>Offset: 0x0054D560
    /// unsigned int __cdecl Render::GetMouseSelectionObjectID()</code>
    /// </summary>
    /// <returns>The object's ID as an unsigned integer, or 0 when nothing is selected.</returns>
    public static uint GetMouseSelectionObjectID() => ((delegate* unmanaged[Cdecl]<uint>)0x0054D560)();

    /// <summary>Gets the index of the geometry part currently highlighted by the mouse selection.
    /// <code>Offset: 0x0054D590
    /// int __cdecl Render::GetMouseSelectionPartIndex()</code>
    /// </summary>
    /// <returns>The polygon index if a polygon was found; otherwise, the sphere index if a sphere was found; if no object was selected, returns 0.</returns>
    public static int GetMouseSelectionPartIndex() => ((delegate* unmanaged[Cdecl]<int>)0x0054D590)();

    /// <summary>Computes a degradation multiplier to adjust rendering quality based on the current frames‑per‑second and predefined thresholds. When auto‑update is enabled, it clamps the result to [-1, 1] and updates the internal degrade level if the change exceeds a small threshold.
    /// <code>Offset: 0x0054D700
    /// void __cdecl Render::CalcDegLevel()</code>
    /// </summary>
    public static void CalcDegLevel() => ((delegate* unmanaged[Cdecl]<void>)0x0054D700)();

    /// <summary>Updates the rendering system's viewpoint to match the supplied Position, configuring camera axes, view matrix, and optional selection ray.
    /// <code>Offset: 0x0054D9E0
    /// void __cdecl Render::update_viewpoint(const Position*)</code>
    /// </summary>
    /// <param name="viewer_pos">The Position representing the viewer's location, orientation, and cell identifier.</param>
    public static void update_viewpoint(ACBindings.Internal.Position* viewer_pos) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.Position*, void>)0x0054D9E0)(viewer_pos);

    /// <summary>Computes clip height limits for point (x, y) across all defined planes and stores them in the supplied ViewIntervalType.
    /// <code>Offset: 0x0054DC00
    /// void __cdecl Render::get_clip_height(float,float,ViewIntervalType*)</code>
    /// </summary>
    /// <param name="x">The horizontal coordinate of the point to evaluate.</param>
    /// <param name="y">The vertical coordinate of the point to evaluate.</param>
    /// <param name="vint">Structure that receives an array of clip height limits; bound[0] contains the limit from the primary plane, subsequent entries correspond to portal planes.</param>
    public static void get_clip_height(float x, float y, ACBindings.Internal.ViewIntervalType* vint) => ((delegate* unmanaged[Cdecl]<float, float, ACBindings.Internal.ViewIntervalType*, void>)0x0054DC00)(x, y, vint);

    /// <summary>Determines whether a block defined by four corner points lies entirely inside, entirely outside, or partially intersecting the specified min‑max range.
    /// <code>Offset: 0x0054DC70
    /// BoundingType __cdecl Render::block_plane_check(float,float,float,float,float,float)</code>
    /// </summary>
    /// <param name="corner1">Coordinate of the first corner of the block.</param>
    /// <param name="corner2">Coordinate of the second corner of the block.</param>
    /// <param name="corner3">Coordinate of the third corner of the block.</param>
    /// <param name="corner4">Coordinate of the fourth corner of the block.</param>
    /// <param name="min">Lower bound defining the plane or region to test against.</param>
    /// <param name="max">Upper bound defining the plane or region to test against.</param>
    /// <returns>BoundingType indicating OUTSIDE if all corners are outside, ENTIRELY_INSIDE if all corners are inside, or INTERSECT otherwise.</returns>
    public static ACBindings.Internal.BoundingType block_plane_check(float corner1, float corner2, float corner3, float corner4, float min, float max) => ((delegate* unmanaged[Cdecl]<float, float, float, float, float, float, ACBindings.Internal.BoundingType>)0x0054DC70)(corner1, corner2, corner3, corner4, min, max);

    /// <summary>Sets up rendering parameters for a specified portal view, configuring viewport bounds and vertex references based on the provided view structure and index.
    /// <code>Offset: 0x0054DCF0
    /// void __cdecl Render::set_view(view_type*,int)</code>
    /// </summary>
    /// <param name="view">The view structure containing polygon and vertex data used to configure rendering state.</param>
    /// <param name="view_num">Index of the polygon within the view whose data is applied to the rendering configuration.</param>
    public static void set_view(ACBindings.Internal.view_type* view, int view_num) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.view_type*, int, void>)0x0054DCF0)(view, view_num);

    /// <summary>Pushes a rendering frame onto the render stack or resets it when no frame is provided.
    /// <code>Offset: 0x0054DD60
    /// void __cdecl Render::framePush(const int,const Frame*,const int)</code>
    /// </summary>
    /// <param name="op">Operation code indicating how the frame should be processed by the renderer.</param>
    /// <param name="frame">The frame containing orientation and position data to apply; if null, clears the current frame.</param>
    /// <param name="prevIndex">Unused in this implementation; historically represents previous frame index.</param>
    public static void framePush(int op, ACBindings.Internal.Frame* frame, int prevIndex) => ((delegate* unmanaged[Cdecl]<int, ACBindings.Internal.Frame*, int, void>)0x0054DD60)(op, frame, prevIndex);

    /// <summary>Inserts a new render light into the renderer's sorted light list, maintaining order by distance to the player and respecting the maximum capacity. The function populates RenderLight fields from LIGHTINFO, computes a hardware light index, and configures the Direct3D light accordingly.
    /// <code>Offset: 0x0054DDC0
    /// void __cdecl Render::insert_light(int,int*,RenderLight*,RenderLight**,const LIGHTINFO*,const unsigned int,const Frame*,int)</code>
    /// </summary>
    /// <param name="max_lights">Maximum number of lights that can be stored; if insertion would exceed this limit the new light is discarded.</param>
    /// <param name="num_lights">Pointer to the current count of active lights; will be incremented when a new light is added.</param>
    /// <param name="lights">Array of RenderLight structures representing all lights; used as base for computing the hardware index.</param>
    /// <param name="sorted_lights">Array of pointers to RenderLight entries sorted by distance; this function inserts the new light into the correct position.</param>
    /// <param name="light_info">Information describing the new light, including type, offset, color, intensity, and falloff.</param>
    /// <param name="cell_id">Identifier of the cell where the light originates; used in distance calculation and hardware configuration.</param>
    /// <param name="frame">Transformation frame for positioning the light relative to world coordinates.</param>
    /// <param name="offset">Base index offset for calculating the Direct3D light index.</param>
    public static void insert_light(int max_lights, int* num_lights, ACBindings.Internal.RenderLight* lights, ACBindings.Internal.RenderLight** sorted_lights, ACBindings.Internal.LIGHTINFO* light_info, uint cell_id, ACBindings.Internal.Frame* frame, int offset) => ((delegate* unmanaged[Cdecl]<int, int*, ACBindings.Internal.RenderLight*, ACBindings.Internal.RenderLight**, ACBindings.Internal.LIGHTINFO*, uint, ACBindings.Internal.Frame*, int, void>)0x0054DDC0)(max_lights, num_lights, lights, sorted_lights, light_info, cell_id, frame, offset);

    /// <summary>Adds a static lighting source to the scene, registering it within the specified spatial cell and applying the provided frame transform.
    /// <code>Offset: 0x0054DFF0
    /// void __cdecl Render::add_static_light(const LIGHTINFO*,const unsigned int,const Frame*)</code>
    /// </summary>
    /// <param name="light_info">Pointer to a LIGHTINFO structure describing the light’s type, position, color, intensity, falloff, cone angle, and viewer‑space location.</param>
    /// <param name="cell_id">Index of the spatial partition or cell where the static light should be added.</param>
    /// <param name="frame">Pointer to a Frame that defines the light’s orientation and origin in world space.</param>
    public static void add_static_light(ACBindings.Internal.LIGHTINFO* light_info, uint cell_id, ACBindings.Internal.Frame* frame) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.LIGHTINFO*, uint, ACBindings.Internal.Frame*, void>)0x0054DFF0)(light_info, cell_id, frame);

    /// <summary>Adds a dynamic light into the renderer’s world lights list and maintains sorted order among existing lights.
    /// <code>Offset: 0x0054E030
    /// void __cdecl Render::add_dynamic_light(const LIGHTINFO*,const unsigned int,const Frame*)</code>
    /// </summary>
    /// <param name="light_info">Pointer to a LIGHTINFO structure that defines the type, position, color, intensity, and other properties of the light.</param>
    /// <param name="cell_id">Identifier of the spatial cell or region where the light should be applied.</param>
    /// <param name="frame">Reference frame used to transform the light’s offset into world coordinates for correct placement in the scene.</param>
    public static void add_dynamic_light(ACBindings.Internal.LIGHTINFO* light_info, uint cell_id, ACBindings.Internal.Frame* frame) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.LIGHTINFO*, uint, ACBindings.Internal.Frame*, void>)0x0054E030)(light_info, cell_id, frame);

    /// <summary>Enables or disables sunlight handling in the rendering system.
    /// <code>Offset: 0x0054E060
    /// void __cdecl Render::useSunlightSet(int)</code>
    /// </summary>
    /// <param name="use_sunlight">Non‑zero to activate sunlight; zero to deactivate it.</param>
    public static void useSunlightSet(int use_sunlight) => ((delegate* unmanaged[Cdecl]<int, void>)0x0054E060)(use_sunlight);

    /// <summary>Selects a limited set of active lights for rendering objects, ensuring that no more than eight are used. Resets previous lighting state, evaluates dynamic and static light sources, updates usage flags, and configures each enabled light in the rendering device according to system settings.
    /// <code>Offset: 0x0054E090
    /// void __cdecl Render::minimize_object_lighting()</code>
    /// </summary>
    public static void minimize_object_lighting() => ((delegate* unmanaged[Cdecl]<void>)0x0054E090)();

    /// <summary>Initializes the rendering system using the specified presentation and configuration. The method sets up necessary subsystems such as database loading, font mapping, and the rendering device, then creates key stone resources. If any step fails, previously initialized components are cleaned up before returning false.
    /// <code>Offset: 0x0054E1A0
    /// bool __cdecl Render::StartupRenderingDevice(const RenderDevicePresentation*,const RenderDeviceConfig*)</code>
    /// </summary>
    /// <param name="presentation">Presentation parameters for the render window (size, fullscreen mode, refresh rate, etc.).</param>
    /// <param name="deviceConfig">Configuration data for the rendering device (graphics settings and capabilities).</param>
    /// <returns>True if all subsystems and resources were successfully started; otherwise, false.</returns>
    public static byte StartupRenderingDevice(ACBindings.Internal.RenderDevicePresentation* presentation, ACBindings.Internal.RenderDeviceConfig* deviceConfig) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.RenderDevicePresentation*, ACBindings.Internal.RenderDeviceConfig*, byte>)0x0054E1A0)(presentation, deviceConfig);

    /// <summary>Flushes the renderer's graphics resources by resetting stage textures, purging and restoring any lost resources, and invoking all registered callbacks.
    /// <code>Offset: 0x0054E260
    /// bool __cdecl Render::FlushGraphicsResources()</code>
    /// </summary>
    /// <returns>True if a renderer was present and flushing succeeded; otherwise, false.</returns>
    public static byte FlushGraphicsResources() => ((delegate* unmanaged[Cdecl]<byte>)0x0054E260)();

    /// <summary>Restarts the rendering system using the supplied device presentation and configuration settings.
    /// <code>Offset: 0x0054E2C0
    /// bool __cdecl Render::RestartRenderingSystem(RenderDevicePresentation*,RenderDeviceConfig*)</code>
    /// </summary>
    /// <param name="presentation">Presentation parameters such as window handle, resolution, fullscreen mode, etc.</param>
    /// <param name="config">Rendering device configuration details.</param>
    /// <returns>True if the restart succeeded; otherwise false.</returns>
    public static byte RestartRenderingSystem(ACBindings.Internal.RenderDevicePresentation* presentation, ACBindings.Internal.RenderDeviceConfig* config) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.RenderDevicePresentation*, ACBindings.Internal.RenderDeviceConfig*, byte>)0x0054E2C0)(presentation, config);

    /// <summary>Restarts the rendering system using the current renderer settings and device configuration.
    /// <code>Offset: 0x0054E320
    /// bool __cdecl Render::RestartRenderingSystem()</code>
    /// </summary>
    /// <returns>True if the restart succeeds, otherwise false.</returns>
    public static byte RestartRenderingSystem() => ((delegate* unmanaged[Cdecl]<byte>)0x0054E320)();

    /// <summary>Removes an RGR callback from the internal list if it is currently registered.
    /// <code>Offset: 0x0054E370
    /// void __cdecl Render::UnlinkRGRCallback(bool (__cdecl*RGRCallback)())</code>
    /// </summary>
    /// <param name="RGRCallback">Pointer to the callback function to unlink.</param>
    public static void UnlinkRGRCallback(delegate* unmanaged[Cdecl]<byte> RGRCallback) => ((delegate* unmanaged[Cdecl]<delegate* unmanaged[Cdecl]<byte>, void>)0x0054E370)(RGRCallback);

    /// <summary>Synchronizes the renderer’s configuration with stored preferences. Adjusts display resolution, fullscreen mode, refresh rate, anti‑aliasing, texture details, screen brightness, aspect ratio, field of view, and other rendering parameters as needed, applying changes to the device and flushing resources when appropriate.
    /// <code>Offset: 0x0054E460
    /// void __cdecl Render::UpdateFromPreferences()</code>
    /// </summary>
    public static void UpdateFromPreferences() => ((delegate* unmanaged[Cdecl]<void>)0x0054E460)();

    /// <summary>Initializes the rendering system by preparing light lists, clearing frame buffers, setting up clipping planes, and loading necessary resources.
    /// <code>Offset: 0x0054E6A0
    /// int __cdecl Render::Init()</code>
    /// </summary>
    /// <returns>Zero if initialization succeeds; a non‑zero value indicates failure.</returns>
    public static int Init() => ((delegate* unmanaged[Cdecl]<int>)0x0054E6A0)();

    /// <summary>Updates the rendering viewpoint using the supplied frame information, setting camera position and orientation for subsequent draw calls.
    /// <code>Offset: 0x0054E830
    /// void __cdecl Render::update_viewpoint(const Frame*)</code>
    /// </summary>
    /// <param name="viewer_frame">Frame containing the viewer's orientation quaternion, rotation matrix, and origin coordinates to be used as the new camera transform.</param>
    public static void update_viewpoint(ACBindings.Internal.Frame* viewer_frame) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.Frame*, void>)0x0054E830)(viewer_frame);

    /// <summary>Determines whether a block defined by four corners and vertical bounds lies inside, partially overlaps, or is outside the current portal volume.
    /// <code>Offset: 0x0054E860
    /// BoundingType __cdecl Render::block_check(ViewIntervalType*,ViewIntervalType*,ViewIntervalType*,ViewIntervalType*,float,float)</code>
    /// </summary>
    /// <param name="corner1">First corner of the block.</param>
    /// <param name="corner2">Second corner of the block.</param>
    /// <param name="corner3">Third corner of the block.</param>
    /// <param name="corner4">Fourth corner of the block.</param>
    /// <param name="max_height">Maximum vertical extent to test against.</param>
    /// <param name="min_height">Minimum vertical extent to test against.</param>
    /// <returns>BoundingType indicating whether the block is INSIDE, PARTIALLY_INSIDE, or OUTSIDE the portal volume.</returns>
    public static ACBindings.Internal.BoundingType block_check(ACBindings.Internal.ViewIntervalType* corner1, ACBindings.Internal.ViewIntervalType* corner2, ACBindings.Internal.ViewIntervalType* corner3, ACBindings.Internal.ViewIntervalType* corner4, float max_height, float min_height) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.ViewIntervalType*, ACBindings.Internal.ViewIntervalType*, ACBindings.Internal.ViewIntervalType*, ACBindings.Internal.ViewIntervalType*, float, float, ACBindings.Internal.BoundingType>)0x0054E860)(corner1, corner2, corner3, corner4, max_height, min_height);

    /// <summary>Initializes rendering state by resetting the current display adapter index and clearing any stored display mode information.
    /// <code>Offset: 0x0054EBB0
    /// void __thiscall Render::Begin(Render*)</code>
    /// </summary>
    public void Begin() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Render, void>)0x0054EBB0)(ref this);

    /// <summary>Ends the rendering process by resetting the Render::m_DisplayModes array to its default state.
    /// <code>Offset: 0x0054EBC0
    /// void __thiscall Render::End(Render*)</code>
    /// </summary>
    public void End() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Render, void>)0x0054EBC0)(ref this);

    /// <summary>Copies and processes a portal view into Render::view data, optionally using a supplied set of screen coordinates to clip the view. Builds the vertex list, polygon indices, bounds, and transforms vertices into world direction vectors.
    /// <code>Offset: 0x0054EBD0
    /// int __cdecl Render::copy_view(portal_view_type*,Vec2Dscreen**,unsigned int)</code>
    /// </summary>
    /// <param name="portal_view">The portal view structure that will receive the processed view data.</param>
    /// <param name="clip_view">Array of pointers to screen-space points defining a clipping region; if null, a full-screen quad is created.</param>
    /// <param name="num_pts">Number of points in clip_view array.</param>
    /// <returns>1 on success; 0 if the view could not be formed (e.g., fewer than three vertices).</returns>
    public static int copy_view(ACBindings.Internal.portal_view_type* portal_view, ACBindings.Internal.Vec2Dscreen** clip_view, uint num_pts) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.portal_view_type*, ACBindings.Internal.Vec2Dscreen**, uint, int>)0x0054EBD0)(portal_view, clip_view, num_pts);

    /// <summary>Shuts down the rendering subsystem, unregistering all global variables and commands, clearing display modes, and resetting the current display adapter index.
    /// <code>Offset: 0x0054F3B0
    /// void __thiscall Render::Shutdown(Render*)</code>
    /// </summary>
    public void Shutdown() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Render, void>)0x0054F3B0)(ref this);

    /// <summary>Verifies whether the current rendering device has been lost and attempts to recover it; terminates the program with a diagnostic message if recovery fails.
    /// <code>Offset: 0x0054F4A0
    /// void __cdecl Render::CheckForLostDevice()</code>
    /// </summary>
    public static void CheckForLostDevice() => ((delegate* unmanaged[Cdecl]<void>)0x0054F4A0)();

    /// <summary>Sets the overall graphics quality level from a string argument or displays the current level when no argument is supplied.
    /// <code>Offset: 0x0054F510
    /// char __cdecl Render::CC_SetGraphicsQuality(const char***)</code>
    /// </summary>
    /// <param name="m_charbuffer">Array of command-line arguments; first element may contain the desired quality value as a numeric string.</param>
    /// <returns>Non-zero on success, zero if parsing fails or invalid value provided.</returns>
    public static sbyte CC_SetGraphicsQuality(sbyte*** m_charbuffer) => ((delegate* unmanaged[Cdecl]<sbyte***, sbyte>)0x0054F510)(m_charbuffer);

    /// <summary>Initializes the rendering subsystem using supplied configuration and registers graphics preferences.
    /// <code>Offset: 0x0054F5C0
    /// char __thiscall Render::Startup(RenderConfig*,const RenderConfig*)</code>
    /// </summary>
    /// <param name="a2">Configuration data containing initial graphics options to apply during startup.</param>
    /// <returns>Always returns 1 to indicate successful initialization.</returns>
    public sbyte Startup(ACBindings.Internal.RenderConfig* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Render, ACBindings.Internal.RenderConfig*, sbyte>)0x0054F5C0)(ref this, a2);

    /// <summary>Initializes the default rendering view by clearing portal, polygon, and vertex buffers, resetting their sizes and counts, setting block sizes to 128, and registering a cleanup routine to execute at program exit.
    /// <code>Offset: 0x0054FB60
    /// void __cdecl Render::set_default_view()</code>
    /// </summary>
    public static void set_default_view() => ((delegate* unmanaged[Cdecl]<void>)0x0054FB60)();

    /// <summary>Registers an RGR callback for rendering operations, adding it to the internal list only if it is not already present and resizing storage when necessary.
    /// <code>Offset: 0x0054FC10
    /// bool __cdecl Render::LinkRGRCallback(bool (__cdecl*RGRCallback)())</code>
    /// </summary>
    /// <param name="RGRCallback">Pointer to a function that returns bool and takes no parameters.</param>
    /// <returns>True upon successful registration; always returned in current implementation.</returns>
    public static byte LinkRGRCallback(delegate* unmanaged[Cdecl]<byte> RGRCallback) => ((delegate* unmanaged[Cdecl]<delegate* unmanaged[Cdecl]<byte>, byte>)0x0054FC10)(RGRCallback);

    /// <summary>Configures the renderer for a three‑dimensional view by applying the current field‑of‑view value, resetting all selection state, and restoring the default camera position before signaling success.
    /// <code>Offset: 0x0054FC80
    /// int __thiscall Render::Set3DViewInternal(Render*,int,int,int,int)</code>
    /// </summary>
    /// <param name="a2">Unused parameter; has no effect on the 3D view configuration.</param>
    /// <param name="a3">Unused parameter; has no effect on the 3D view configuration.</param>
    /// <param name="a4">Unused parameter; has no effect on the 3D view configuration.</param>
    /// <param name="a5">Unused parameter; has no effect on the 3D view configuration.</param>
    /// <returns>Always returns 1 to indicate successful setup of the 3‑dimensional view.</returns>
    public int Set3DViewInternal(int a2, int a3, int a4, int a5) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Render, int, int, int, int, int>)0x0054FC80)(ref this, a2, a3, a4, a5);

    /// <summary>Retrieves the fog adjustment factor used in rendering. The current implementation simply returns the provided value unchanged.
    /// <code>Offset: 0x0058BD30
    /// double __stdcall Render::GetFogAdjustment(float)</code>
    /// </summary>
    /// <param name="a1">The fog adjustment factor supplied by the caller.</param>
    /// <returns>The same value as a double, representing the fog adjustment to apply during rendering.</returns>
    public static double GetFogAdjustment(float a1) => ((delegate* unmanaged[Stdcall]<float, double>)0x0058BD30)(a1);
}

