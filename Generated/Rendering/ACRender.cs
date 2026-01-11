namespace ACBindings.Internal;

public unsafe struct ACRender
{
    // Base Classes
    public ACBindings.Internal.Render BaseClass_Render; // ACBindings.Internal.Render

    // Statics
    public static float* back_object_scale = (float*)0x00836B68;
    public static ACBindings.Internal.Render.LightingType* back_lighting_type = (ACBindings.Internal.Render.LightingType*)0x00836B6C;
    public static float* backup_detail_tiling = (float*)0x00836B70;
    public static ACBindings.Internal.AC1Legacy.Vector3* back_object_scale_vec = (ACBindings.Internal.AC1Legacy.Vector3*)0x00836BD4;
    public static ACBindings.Internal.CMaterial* back_curr_material = (ACBindings.Internal.CMaterial*)0x008FC60C;
    public static ACBindings.Internal.CSurface* back_curr_surfaces = (ACBindings.Internal.CSurface*)0x008FC610;
    public static ACBindings.Internal.view_type* backup_view = (ACBindings.Internal.view_type*)0x008FC614;
    public static int* backup_view_num = (int*)0x008FC618;
    public static ACBindings.Internal.portal_view_type* BackupList = (ACBindings.Internal.portal_view_type*)0x008FC61C;
    public static ACBindings.Internal.CSurface* backup_detail_surface = (ACBindings.Internal.CSurface*)0x008FC620;
    public static ACBindings.Internal.RGBColor* curLandBlockVertexLighting = (ACBindings.Internal.RGBColor*)0x008FC624;

    // Child Types
    public unsafe struct ACRender_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ACRender*, void> DestructorACRender; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ACRender*, ACBindings.Internal.RenderConfig*, byte> Startup; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ACRender*, void> Shutdown; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ACRender*, ACBindings.Internal.RenderDevice*> CreateRenderDevice; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ACRender*, int> InitInternal; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ACRender*, void> CleanupInternal; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ACRender*, int, int, int, int, int> Set3DViewInternal; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ACRender*, float, void> SetFOVInternal; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ACRender*, float, float> GetFogAdjustment; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ACRender*, void> SetupViewportInternal; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ACRender*, void> UpdateLightsInternal; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ACRender*, ACBindings.Internal.CMaterial*, void> SetMaterialInternal; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ACRender*, int, ACBindings.Internal.Position*, void> positionPushInternal; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ACRender*, int> positionPopInternal; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ACRender*, void> CalcObjectMatrixInternal; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ACRender*, ACBindings.Internal.Matrix4*> GetObjectMatrixInternal; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ACRender*, void> polyListFinishInternal; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ACRender*, ACBindings.Internal.AC1Legacy.Vector3*, ACBindings.Internal.Vec2D*, ACBindings.Internal.BoundingType> xformPointInternal; // function pointer

        // Methods
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x005A1600
    /// void __cdecl ACRender::backup_curr_state()</code>
    /// </summary>
    public static void backup_curr_state() => ((delegate* unmanaged[Cdecl]<void>)0x005A1600)();

    /// <summary>
    /// <code>Offset: 0x005A16A0
    /// void __cdecl ACRender::restore_curr_state()</code>
    /// </summary>
    public static void restore_curr_state() => ((delegate* unmanaged[Cdecl]<void>)0x005A16A0)();

    /// <summary>
    /// <code>Offset: 0x006B7170
    /// unsigned __int8 __cdecl ACRender::get_alpha_for_z(const float)</code>
    /// </summary>
    public static byte get_alpha_for_z(float zdist) => ((delegate* unmanaged[Cdecl]<float, byte>)0x006B7170)(zdist);

    /// <summary>
    /// <code>Offset: 0x006B71C0
    /// void __cdecl ACRender::SetDetailSurfaceInternal(int)</code>
    /// </summary>
    public static void SetDetailSurfaceInternal(int detail_stage) => ((delegate* unmanaged[Cdecl]<int, void>)0x006B71C0)(detail_stage);

    /// <summary>
    /// <code>Offset: 0x006B7260
    /// void __cdecl ACRender::landPolyDraw(CPolygon*)</code>
    /// </summary>
    public static void landPolyDraw(ACBindings.Internal.CPolygon* p) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.CPolygon*, void>)0x006B7260)(p);

    /// <summary>
    /// <code>Offset: 0x006B76A0
    /// void __cdecl ACRender::landPolyDraw(CPolygon*,CPolygon*)</code>
    /// </summary>
    public static void landPolyDraw(ACBindings.Internal.CPolygon* p1, ACBindings.Internal.CPolygon* p2) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.CPolygon*, ACBindings.Internal.CPolygon*, void>)0x006B76A0)(p1, p2);

    /// <summary>
    /// <code>Offset: 0x006B7C40
    /// void __cdecl ACRender::polyClipFinish(Vec2Dscreen**,int,Vec2Dscreen**,int*,int)</code>
    /// </summary>
    public static void polyClipFinish(ACBindings.Internal.Vec2Dscreen** ptsIn, int ptCount, ACBindings.Internal.Vec2Dscreen** ptsOut, int* ptsOutCount, int viewPtChkMask) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.Vec2Dscreen**, int, ACBindings.Internal.Vec2Dscreen**, int*, int, void>)0x006B7C40)(ptsIn, ptCount, ptsOut, ptsOutCount, viewPtChkMask);

    /// <summary>
    /// <code>Offset: 0x006B7F80
    /// void __cdecl ACRender::landPolysDraw(CPolygon**,int)</code>
    /// </summary>
    public static void landPolysDraw(ACBindings.Internal.CPolygon** polys, int num_polys) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.CPolygon**, int, void>)0x006B7F80)(polys, num_polys);
}

