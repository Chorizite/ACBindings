namespace ACBindings;

// PrimD3DRender
public unsafe struct PrimD3DRender : System.IDisposable
{
    // Base Classes
    public ACBindings.Render BaseClass_Render; // ACBindings.Render

    // Statics
    public static ACBindings._D3DLIGHT9* pD3DSunlight = (ACBindings._D3DLIGHT9*)0x0086DFD4;

    // Child Types
    // PrimD3DRender_vtbl
    public unsafe struct PrimD3DRender_vtbl
    {
        // Members
        public System.IntPtr PrimD3DRender_dtor_0; // function pointer
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

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods
    // __int32 __thiscall PrimD3DRender::GetObjectMatrixInternal(PrimD3DRender*)
    public int GetObjectMatrixInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.PrimD3DRender, int>)0x0058BD80)(ref this);
    // void __thiscall PrimD3DRender::~PrimD3DRender(PrimD3DRender*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.PrimD3DRender, void>)0x0058BD90)(ref this);
    // void __cdecl PrimD3DRender::ScreenToViewTransform(AC1Legacy::Vector3*,float,float)
    public static void ScreenToViewTransform(ACBindings.AC1Legacy.Vector3* dirToPoint, float xPoint, float yPoint) => ((delegate* unmanaged[Cdecl]<ACBindings.AC1Legacy.Vector3*, float, float, void>)0x0059BA50)(dirToPoint, xPoint, yPoint);
    // void __thiscall PrimD3DRender::SetFOVInternal(Render*,float)
    public void SetFOVInternal(float a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.PrimD3DRender, float, void>)0x0059BB50)(ref this, a2);
    // void __thiscall PrimD3DRender::CleanupInternal(PrimD3DRender*)
    public void CleanupInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.PrimD3DRender, void>)0x0059BBE0)(ref this);
    // HRESULT __cdecl PrimD3DRender::InitializeLights()
    public static int InitializeLights() => ((delegate* unmanaged[Cdecl]<int>)0x0059BC00)();
    // int __cdecl PrimD3DRender::config_hardware_light(int,_D3DLIGHT9*,unsigned int,LIGHTINFO*)
    public static int config_hardware_light(int light_index, ACBindings._D3DLIGHT9* o_pHardwareLight, uint cellID, ACBindings.LIGHTINFO* i_pLightInfo) => ((delegate* unmanaged[Cdecl]<int, ACBindings._D3DLIGHT9*, uint, ACBindings.LIGHTINFO*, int>)0x0059BD40)(light_index, o_pHardwareLight, cellID, i_pLightInfo);
    // void __thiscall PrimD3DRender::UpdateLightsInternal(PrimD3DRender*)
    public void UpdateLightsInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.PrimD3DRender, void>)0x0059BEE0)(ref this);
    // void __thiscall PrimD3DRender::positionPushInternal(PrimD3DRender*,char,const Position*)
    public void positionPushInternal(sbyte a2, ACBindings.Position* a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.PrimD3DRender, sbyte, ACBindings.Position*, void>)0x0059C5F0)(ref this, a2, a3);
    // int __thiscall PrimD3DRender::positionPopInternal(PrimD3DRender*)
    public int positionPopInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.PrimD3DRender, int>)0x0059C790)(ref this);
    // void __thiscall PrimD3DRender::CalcObjectMatrixInternal(PrimD3DRender*)
    public void CalcObjectMatrixInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.PrimD3DRender, void>)0x0059C840)(ref this);
    // int __thiscall PrimD3DRender::InitInternal(PrimD3DRender*)
    public int InitInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.PrimD3DRender, int>)0x0059C990)(ref this);
    // Vec2Dscreen* __cdecl PrimD3DRender::xformStart(const AC1Legacy::Vector3*,int)
    public static ACBindings.Vec2Dscreen* xformStart(ACBindings.AC1Legacy.Vector3* worldVertex, int doprojection) => ((delegate* unmanaged[Cdecl]<ACBindings.AC1Legacy.Vector3*, int, ACBindings.Vec2Dscreen*>)0x0059C9A0)(worldVertex, doprojection);
    // BOOL __thiscall PrimD3DRender::xformPointInternal(PrimD3DRender*,AC1Legacy::Vector3*,Vec2D*)
    public byte xformPointInternal(ACBindings.AC1Legacy.Vector3* worldVertex, ACBindings.Vec2D* a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.PrimD3DRender, ACBindings.AC1Legacy.Vector3*, ACBindings.Vec2D*, byte>)0x0059CAB0)(ref this, worldVertex, a3);
}

