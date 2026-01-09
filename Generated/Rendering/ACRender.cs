namespace ACBindings;

// ACRender
public unsafe struct ACRender
{
    // Base Classes
    public ACBindings.Render BaseClass_Render; // ACBindings.Render

    // Statics
    public static float* back_object_scale = (float*)0x00836B68;
    public static ACBindings.Render.LightingType* back_lighting_type = (ACBindings.Render.LightingType*)0x00836B6C;
    public static float* backup_detail_tiling = (float*)0x00836B70;
    public static ACBindings.AC1Legacy.Vector3* back_object_scale_vec = (ACBindings.AC1Legacy.Vector3*)0x00836BD4;
    public static ACBindings.CMaterial* back_curr_material = (ACBindings.CMaterial*)0x008FC60C;
    public static ACBindings.CSurface* back_curr_surfaces = (ACBindings.CSurface*)0x008FC610;
    public static ACBindings.view_type* backup_view = (ACBindings.view_type*)0x008FC614;
    public static int* backup_view_num = (int*)0x008FC618;
    public static ACBindings.portal_view_type* BackupList = (ACBindings.portal_view_type*)0x008FC61C;
    public static ACBindings.CSurface* backup_detail_surface = (ACBindings.CSurface*)0x008FC620;
    public static ACBindings.RGBColor* curLandBlockVertexLighting = (ACBindings.RGBColor*)0x008FC624;

    // Child Types
    // ACRender_vtbl
    public unsafe struct ACRender_vtbl
    {
        // Members
        public System.IntPtr DestructorACRender; // function pointer
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

    // Methods
    // void __cdecl ACRender::backup_curr_state()
    public static void backup_curr_state() => ((delegate* unmanaged[Cdecl]<void>)0x005A1600)();
    // void __cdecl ACRender::restore_curr_state()
    public static void restore_curr_state() => ((delegate* unmanaged[Cdecl]<void>)0x005A16A0)();
    // unsigned __int8 __cdecl ACRender::get_alpha_for_z(const float)
    public static byte get_alpha_for_z(float zdist) => ((delegate* unmanaged[Cdecl]<float, byte>)0x006B7170)(zdist);
    // void __cdecl ACRender::SetDetailSurfaceInternal(int)
    public static void SetDetailSurfaceInternal(int detail_stage) => ((delegate* unmanaged[Cdecl]<int, void>)0x006B71C0)(detail_stage);
    // void __cdecl ACRender::landPolyDraw(CPolygon*)
    public static void landPolyDraw(ACBindings.CPolygon* p) => ((delegate* unmanaged[Cdecl]<ACBindings.CPolygon*, void>)0x006B7260)(p);
    // void __cdecl ACRender::landPolyDraw(CPolygon*,CPolygon*)
    public static void landPolyDraw(ACBindings.CPolygon* p1, ACBindings.CPolygon* p2) => ((delegate* unmanaged[Cdecl]<ACBindings.CPolygon*, ACBindings.CPolygon*, void>)0x006B76A0)(p1, p2);
    // void __cdecl ACRender::polyClipFinish(Vec2Dscreen**,int,Vec2Dscreen**,int*,int)
    public static void polyClipFinish(ACBindings.Vec2Dscreen** ptsIn, int ptCount, ACBindings.Vec2Dscreen** ptsOut, int* ptsOutCount, int viewPtChkMask) => ((delegate* unmanaged[Cdecl]<ACBindings.Vec2Dscreen**, int, ACBindings.Vec2Dscreen**, int*, int, void>)0x006B7C40)(ptsIn, ptCount, ptsOut, ptsOutCount, viewPtChkMask);
    // void __cdecl ACRender::landPolysDraw(CPolygon**,int)
    public static void landPolysDraw(ACBindings.CPolygon** polys, int num_polys) => ((delegate* unmanaged[Cdecl]<ACBindings.CPolygon**, int, void>)0x006B7F80)(polys, num_polys);
}

