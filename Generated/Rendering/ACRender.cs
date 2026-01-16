namespace ACBindings.Internal;


/// <summary>Provides specialized rendering routines for terrain, detail surfaces, and portal geometry, extending base Render functionality with state management, alpha calculation, and polygon drawing utilities.</summary>
public unsafe struct ACRender
{
    // Base Classes
    public ACBindings.Internal.Render BaseClass_Render; // ACBindings.Internal.Render

    // Statics
    public static float* back_object_scale = (float*)0x00836B68;
    public static ACBindings.Internal.Render.LightingType* back_lighting_type = (ACBindings.Internal.Render.LightingType*)0x00836B6C;
    public static float* backup_detail_tiling = (float*)0x00836B70;
    public static ACBindings.Internal.AC1Legacy.Vector3* back_object_scale_vec = (ACBindings.Internal.AC1Legacy.Vector3*)0x00836BD4;
    public static ACBindings.Internal.CMaterial** back_curr_material = (ACBindings.Internal.CMaterial**)0x008FC60C;
    public static ACBindings.Internal.CSurface*** back_curr_surfaces = (ACBindings.Internal.CSurface***)0x008FC610;
    public static ACBindings.Internal.view_type** backup_view = (ACBindings.Internal.view_type**)0x008FC614;
    public static int* backup_view_num = (int*)0x008FC618;
    public static ACBindings.Internal.portal_view_type** BackupList = (ACBindings.Internal.portal_view_type**)0x008FC61C;
    public static ACBindings.Internal.CSurface** backup_detail_surface = (ACBindings.Internal.CSurface**)0x008FC620;
    public static ACBindings.Internal.RGBColor** curLandBlockVertexLighting = (ACBindings.Internal.RGBColor**)0x008FC624;

    // Child Types
    public unsafe struct ACRender_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ACRender*, void> DestructorACRender; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ACRender*, ACBindings.Internal.RenderConfig*, byte> Startup; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ACRender*, void> Shutdown; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ACRender*, ACBindings.Internal.RenderDevice*> CreateRenderDevice; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ACRender*, int> InitInternal; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ACRender*, void> CleanupInternal; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ACRender*, int, int, int, int, int> Set3DViewInternal; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ACRender*, float, void> SetFOVInternal; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ACRender*, float, float> GetFogAdjustment; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ACRender*, void> SetupViewportInternal; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ACRender*, void> UpdateLightsInternal; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ACRender*, ACBindings.Internal.CMaterial*, void> SetMaterialInternal; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ACRender*, int, ACBindings.Internal.Position*, void> positionPushInternal; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ACRender*, int> positionPopInternal; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ACRender*, void> CalcObjectMatrixInternal; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ACRender*, ACBindings.Internal.Matrix4*> GetObjectMatrixInternal; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ACRender*, void> polyListFinishInternal; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ACRender*, ACBindings.Internal.AC1Legacy.Vector3*, ACBindings.Internal.Vec2D*, ACBindings.Internal.BoundingType> xformPointInternal; // function pointer

        // Methods
    }

    // Methods

    /// <summary>Backs up the current rendering configuration and state by storing key Render properties into corresponding static ACRender fields for later restoration.
    /// <code>Offset: 0x005A1600
    /// void __cdecl ACRender::backup_curr_state()</code>
    /// </summary>
    public static void backup_curr_state() => ((delegate* unmanaged[Cdecl]<void>)0x005A1600)();

    /// <summary>Restores the render state by copying backup values for material, object scale, surfaces, lighting, portal list, view, detail surface and tiling back into the current rendering context, updating device alpha mode and color sources accordingly.
    /// <code>Offset: 0x005A16A0
    /// void __cdecl ACRender::restore_curr_state()</code>
    /// </summary>
    public static void restore_curr_state() => ((delegate* unmanaged[Cdecl]<void>)0x005A16A0)();

    /// <summary>Calculates an 8‑bit alpha value from a depth distance, mapping distances below 10 to full opacity, between 10 and 50 to linear fade, and above 50 to full transparency.
    /// <code>Offset: 0x006B7170
    /// unsigned __int8 __cdecl ACRender::get_alpha_for_z(const float)</code>
    /// </summary>
    /// <param name="zdist">Depth distance along the Z axis in world units.</param>
    /// <returns>Alpha component (0–255) corresponding to the input depth.</returns>
    public static byte get_alpha_for_z(float zdist) => ((delegate* unmanaged[Cdecl]<float, byte>)0x006B7170)(zdist);

    /// <summary>Configures a render device's texture stage with the current detail surface, setting sampler modes and filtering; for the first stage, also establishes blend and depth buffer settings.
    /// <code>Offset: 0x006B71C0
    /// void __cdecl ACRender::SetDetailSurfaceInternal(int)</code>
    /// </summary>
    /// <param name="detail_stage">Index of the texture stage to configure.</param>
    public static void SetDetailSurfaceInternal(int detail_stage) => ((delegate* unmanaged[Cdecl]<int, void>)0x006B71C0)(detail_stage);

    /// <summary>Renders a terrain polygon by building vertex data that includes position, lighting, and texture information based on the current render state, then submits a Direct3D triangle‑list draw call.
    /// <code>Offset: 0x006B7260
    /// void __cdecl ACRender::landPolyDraw(CPolygon*)</code>
    /// </summary>
    /// <param name="p">The CPolygon describing the land geometry to render.</param>
    public static void landPolyDraw(ACBindings.Internal.CPolygon* p) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.CPolygon*, void>)0x006B7260)(p);

    /// <summary>Draws a land polygon using DirectX, applying vertex lighting and texture mapping based on the current rendering configuration.
    /// <code>Offset: 0x006B76A0
    /// void __cdecl ACRender::landPolyDraw(CPolygon*,CPolygon*)</code>
    /// </summary>
    /// <param name="p1">The primary polygon to render.</param>
    /// <param name="p2">An optional secondary polygon used for detail surface rendering when enabled.</param>
    public static void landPolyDraw(ACBindings.Internal.CPolygon* p1, ACBindings.Internal.CPolygon* p2) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.CPolygon*, ACBindings.Internal.CPolygon*, void>)0x006B76A0)(p1, p2);

    /// <summary>Clips a polygon defined by the input vertex pointers against portal planes and writes the resulting vertices to an output buffer.
    /// <code>Offset: 0x006B7C40
    /// void __cdecl ACRender::polyClipFinish(Vec2Dscreen**,int,Vec2Dscreen**,int*,int)</code>
    /// </summary>
    /// <param name="ptsIn">Array of pointers to the original vertices that form the polygon to be clipped.</param>
    /// <param name="ptCount">Number of vertices in the ptsIn array.</param>
    /// <param name="ptsOut">Buffer into which the function writes the vertices that survive clipping; must be large enough for the worst‑case result.</param>
    /// <param name="ptsOutCount">Pointer to an integer that will receive the count of vertices written to ptsOut. If fewer than three vertices remain after clipping, no output is produced and this value remains unchanged.</param>
    /// <param name="viewPtChkMask">Bitmask controlling which portal planes are applied during the clipping process.</param>
    public static void polyClipFinish(ACBindings.Internal.Vec2Dscreen** ptsIn, int ptCount, ACBindings.Internal.Vec2Dscreen** ptsOut, int* ptsOutCount, int viewPtChkMask) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.Vec2Dscreen**, int, ACBindings.Internal.Vec2Dscreen**, int*, int, void>)0x006B7C40)(ptsIn, ptCount, ptsOut, ptsOutCount, viewPtChkMask);

    /// <summary>Draws land polygons with depth adjustment to prevent z‑fighting, selecting which polygon(s) to render based on their orientation relative to the current camera frame.
    /// <code>Offset: 0x006B7F80
    /// void __cdecl ACRender::landPolysDraw(CPolygon**,int)</code>
    /// </summary>
    /// <param name="polys">An array of pointers to CPolygon structures representing the polygons to be drawn.</param>
    /// <param name="num_polys">The number of polygons in the array; the routine only acts when this value is 2.</param>
    public static void landPolysDraw(ACBindings.Internal.CPolygon** polys, int num_polys) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.CPolygon**, int, void>)0x006B7F80)(polys, num_polys);
}

