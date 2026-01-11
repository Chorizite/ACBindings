namespace ACBindings.Internal;

public unsafe struct PrimD3DRender : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.Render BaseClass_Render; // ACBindings.Internal.Render

    // Statics
    public static ACBindings.Internal._D3DLIGHT9* pD3DSunlight = (ACBindings.Internal._D3DLIGHT9*)0x0087222C;

    // Child Types
    public unsafe struct PrimD3DRender_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.PrimD3DRender*, void> PrimD3DRender_dtor_0; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.PrimD3DRender*, ACBindings.Internal.RenderConfig*, byte> Startup; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.PrimD3DRender*, void> Shutdown; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.PrimD3DRender*, ACBindings.Internal.RenderDevice*> CreateRenderDevice; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.PrimD3DRender*, int> InitInternal; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.PrimD3DRender*, void> CleanupInternal; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.PrimD3DRender*, int, int, int, int, int> Set3DViewInternal; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.PrimD3DRender*, float, void> SetFOVInternal; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.PrimD3DRender*, float, float> GetFogAdjustment; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.PrimD3DRender*, void> SetupViewportInternal; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.PrimD3DRender*, void> UpdateLightsInternal; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.PrimD3DRender*, ACBindings.Internal.CMaterial*, void> SetMaterialInternal; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.PrimD3DRender*, int, ACBindings.Internal.Position*, void> positionPushInternal; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.PrimD3DRender*, int> positionPopInternal; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.PrimD3DRender*, void> CalcObjectMatrixInternal; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.PrimD3DRender*, ACBindings.Internal.Matrix4*> GetObjectMatrixInternal; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.PrimD3DRender*, void> polyListFinishInternal; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.PrimD3DRender*, ACBindings.Internal.AC1Legacy.Vector3*, ACBindings.Internal.Vec2D*, ACBindings.Internal.BoundingType> xformPointInternal; // function pointer

        // Methods
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x0058BD80
    /// __int32 __thiscall PrimD3DRender::GetObjectMatrixInternal(PrimD3DRender*)</code>
    /// </summary>
    public int GetObjectMatrixInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PrimD3DRender, int>)0x0058BD80)(ref this);

    /// <summary>
    /// <code>Offset: 0x0058BD90
    /// void __thiscall PrimD3DRender::~PrimD3DRender(PrimD3DRender*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PrimD3DRender, void>)0x0058BD90)(ref this);

    /// <summary>
    /// <code>Offset: 0x0059BA50
    /// void __cdecl PrimD3DRender::ScreenToViewTransform(AC1Legacy::Vector3*,float,float)</code>
    /// </summary>
    public static void ScreenToViewTransform(ACBindings.Internal.AC1Legacy.Vector3* dirToPoint, float xPoint, float yPoint) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.AC1Legacy.Vector3*, float, float, void>)0x0059BA50)(dirToPoint, xPoint, yPoint);

    /// <summary>
    /// <code>Offset: 0x0059BB50
    /// void __thiscall PrimD3DRender::SetFOVInternal(Render*,float)</code>
    /// </summary>
    public void SetFOVInternal(float a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PrimD3DRender, float, void>)0x0059BB50)(ref this, a2);

    /// <summary>
    /// <code>Offset: 0x0059BBE0
    /// void __thiscall PrimD3DRender::CleanupInternal(PrimD3DRender*)</code>
    /// </summary>
    public void CleanupInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PrimD3DRender, void>)0x0059BBE0)(ref this);

    /// <summary>
    /// <code>Offset: 0x0059BC00
    /// HRESULT __cdecl PrimD3DRender::InitializeLights()</code>
    /// </summary>
    public static int InitializeLights() => ((delegate* unmanaged[Cdecl]<int>)0x0059BC00)();

    /// <summary>
    /// <code>Offset: 0x0059BD40
    /// int __cdecl PrimD3DRender::config_hardware_light(int,_D3DLIGHT9*,unsigned int,LIGHTINFO*)</code>
    /// </summary>
    public static int config_hardware_light(int light_index, ACBindings.Internal._D3DLIGHT9* o_pHardwareLight, uint cellID, ACBindings.Internal.LIGHTINFO* i_pLightInfo) => ((delegate* unmanaged[Cdecl]<int, ACBindings.Internal._D3DLIGHT9*, uint, ACBindings.Internal.LIGHTINFO*, int>)0x0059BD40)(light_index, o_pHardwareLight, cellID, i_pLightInfo);

    /// <summary>
    /// <code>Offset: 0x0059BEE0
    /// void __thiscall PrimD3DRender::UpdateLightsInternal(PrimD3DRender*)</code>
    /// </summary>
    public void UpdateLightsInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PrimD3DRender, void>)0x0059BEE0)(ref this);

    /// <summary>
    /// <code>Offset: 0x0059C5F0
    /// void __thiscall PrimD3DRender::positionPushInternal(PrimD3DRender*,char,const Position*)</code>
    /// </summary>
    public void positionPushInternal(sbyte a2, ACBindings.Internal.Position* a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PrimD3DRender, sbyte, ACBindings.Internal.Position*, void>)0x0059C5F0)(ref this, a2, a3);

    /// <summary>
    /// <code>Offset: 0x0059C790
    /// int __thiscall PrimD3DRender::positionPopInternal(PrimD3DRender*)</code>
    /// </summary>
    public int positionPopInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PrimD3DRender, int>)0x0059C790)(ref this);

    /// <summary>
    /// <code>Offset: 0x0059C840
    /// void __thiscall PrimD3DRender::CalcObjectMatrixInternal(PrimD3DRender*)</code>
    /// </summary>
    public void CalcObjectMatrixInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PrimD3DRender, void>)0x0059C840)(ref this);

    /// <summary>
    /// <code>Offset: 0x0059C990
    /// int __thiscall PrimD3DRender::InitInternal(PrimD3DRender*)</code>
    /// </summary>
    public int InitInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PrimD3DRender, int>)0x0059C990)(ref this);

    /// <summary>
    /// <code>Offset: 0x0059C9A0
    /// Vec2Dscreen* __cdecl PrimD3DRender::xformStart(const AC1Legacy::Vector3*,int)</code>
    /// </summary>
    public static ACBindings.Internal.Vec2Dscreen* xformStart(ACBindings.Internal.AC1Legacy.Vector3* worldVertex, int doprojection) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.AC1Legacy.Vector3*, int, ACBindings.Internal.Vec2Dscreen*>)0x0059C9A0)(worldVertex, doprojection);

    /// <summary>
    /// <code>Offset: 0x0059CAB0
    /// BOOL __thiscall PrimD3DRender::xformPointInternal(PrimD3DRender*,AC1Legacy::Vector3*,Vec2D*)</code>
    /// </summary>
    public byte xformPointInternal(ACBindings.Internal.AC1Legacy.Vector3* worldVertex, ACBindings.Internal.Vec2D* a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PrimD3DRender, ACBindings.Internal.AC1Legacy.Vector3*, ACBindings.Internal.Vec2D*, byte>)0x0059CAB0)(ref this, worldVertex, a3);
}

