namespace ACBindings.Internal;


/// <summary>Provides a Direct3D 9 rendering backend for the engine, extending the generic Render interface with device management, lighting configuration and world‑to‑screen transformations.</summary>
/// <remarks>Manages light sources, object matrices, viewport settings, and cleanup of D3D resources during construction and destruction.</remarks>
public unsafe struct PrimD3DRender : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.Render BaseClass_Render; // ACBindings.Internal.Render

    // Statics
    public static ACBindings.Internal._D3DLIGHT9** pD3DSunlight = (ACBindings.Internal._D3DLIGHT9**)0x0087222C;

    // Child Types
    public unsafe struct PrimD3DRender_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.PrimD3DRender*, void> PrimD3DRender_dtor_0; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.PrimD3DRender*, ACBindings.Internal.RenderConfig*, byte> Startup; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.PrimD3DRender*, void> Shutdown; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.PrimD3DRender*, ACBindings.Internal.RenderDevice*> CreateRenderDevice; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.PrimD3DRender*, int> InitInternal; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.PrimD3DRender*, void> CleanupInternal; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.PrimD3DRender*, int, int, int, int, int> Set3DViewInternal; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.PrimD3DRender*, float, void> SetFOVInternal; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.PrimD3DRender*, float, float> GetFogAdjustment; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.PrimD3DRender*, void> SetupViewportInternal; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.PrimD3DRender*, void> UpdateLightsInternal; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.PrimD3DRender*, ACBindings.Internal.CMaterial*, void> SetMaterialInternal; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.PrimD3DRender*, int, ACBindings.Internal.Position*, void> positionPushInternal; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.PrimD3DRender*, int> positionPopInternal; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.PrimD3DRender*, void> CalcObjectMatrixInternal; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.PrimD3DRender*, ACBindings.Internal.Matrix4*> GetObjectMatrixInternal; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.PrimD3DRender*, void> polyListFinishInternal; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.PrimD3DRender*, ACBindings.Internal.AC1Legacy.Vector3*, ACBindings.Internal.Vec2D*, ACBindings.Internal.BoundingType> xformPointInternal; // function pointer

        // Methods
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>Retrieves the internal object transformation matrix for the current render context.
    /// <code>Offset: 0x0058BD80
    /// __int32 __thiscall PrimD3DRender::GetObjectMatrixInternal(PrimD3DRender*)</code>
    /// </summary>
    /// <returns>The memory address or offset to the object's transformation matrix used by the rendering pipeline.</returns>
    public int GetObjectMatrixInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PrimD3DRender, int>)0x0058BD80)(ref this);

    /// <summary>Finalizes rendering resources for a PrimD3DRender object and releases associated memory when the allocation flag is set.
    /// <code>Offset: 0x0058BD90
    /// void __thiscall PrimD3DRender::~PrimD3DRender(PrimD3DRender*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PrimD3DRender, void>)0x0058BD90)(ref this);

    /// <summary>Converts 2D screen coordinates into a normalized 3D view direction vector using the current render device’s viewport and projection matrices.
    /// <code>Offset: 0x0059BA50
    /// void __cdecl PrimD3DRender::ScreenToViewTransform(AC1Legacy::Vector3*,float,float)</code>
    /// </summary>
    /// <param name="dirToPoint">Output vector containing the transformed direction.</param>
    /// <param name="xPoint">Horizontal screen coordinate in pixels.</param>
    /// <param name="yPoint">Vertical screen coordinate in pixels.</param>
    public static void ScreenToViewTransform(ACBindings.Internal.AC1Legacy.Vector3* dirToPoint, float xPoint, float yPoint) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.AC1Legacy.Vector3*, float, float, void>)0x0059BA50)(dirToPoint, xPoint, yPoint);

    /// <summary>Updates the rendering engine’s perspective projection to use a new vertical field‑of‑view, rebuilding the view‑to‑clip matrix for the current device.
    /// <code>Offset: 0x0059BB50
    /// void __thiscall PrimD3DRender::SetFOVInternal(Render*,float)</code>
    /// </summary>
    /// <param name="a2">The desired vertical FOV in radians.</param>
    public void SetFOVInternal(float a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PrimD3DRender, float, void>)0x0059BB50)(ref this, a2);

    /// <summary>Releases the shared Direct3D sun light resource used by PrimD3DRender when it is allocated.
    /// <code>Offset: 0x0059BBE0
    /// void __thiscall PrimD3DRender::CleanupInternal(PrimD3DRender*)</code>
    /// </summary>
    public void CleanupInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PrimD3DRender, void>)0x0059BBE0)(ref this);

    /// <summary>Sets up the scene’s default lighting by clearing the ambient color, configuring a downward‑directed white directional sunlight, and resetting active light state.
    /// <code>Offset: 0x0059BC00
    /// HRESULT __cdecl PrimD3DRender::InitializeLights()</code>
    /// </summary>
    /// <returns>Zero on success; otherwise an HRESULT error code.</returns>
    public static int InitializeLights() => ((delegate* unmanaged[Cdecl]<int>)0x0059BC00)();

    /// <summary>Configures a Direct3D 9 hardware light from the supplied LIGHTINFO data, setting its color, intensity, type (point, spot, directional), position, direction, attenuation and fall‑off values for rendering.
    /// <code>Offset: 0x0059BD40
    /// int __cdecl PrimD3DRender::config_hardware_light(int,_D3DLIGHT9*,unsigned int,LIGHTINFO*)</code>
    /// </summary>
    /// <param name="light_index">Index of the light in the device’s light array; currently unused but retained for API compatibility.</param>
    /// <param name="o_pHardwareLight">Pointer to a _D3DLIGHT9 structure that receives the configured light parameters.</param>
    /// <param name="cellID">Identifier for the rendering cell; not used by this function but part of the legacy signature.</param>
    /// <param name="i_pLightInfo">Source data containing type, color, intensity, position offset, and attenuation settings for the light.</param>
    /// <returns>Non‑zero if the hardware light was successfully configured, zero otherwise (e.g., when the render device is unavailable).</returns>
    public static int config_hardware_light(int light_index, ACBindings.Internal._D3DLIGHT9* o_pHardwareLight, uint cellID, ACBindings.Internal.LIGHTINFO* i_pLightInfo) => ((delegate* unmanaged[Cdecl]<int, ACBindings.Internal._D3DLIGHT9*, uint, ACBindings.Internal.LIGHTINFO*, int>)0x0059BD40)(light_index, o_pHardwareLight, cellID, i_pLightInfo);

    /// <summary>Computes and updates ambient, static, dynamic, and sunlight parameters for the D3D renderer. Recalculates light colors, transforms light positions into viewer space, and flags which lights are active.
    /// <code>Offset: 0x0059BEE0
    /// void __thiscall PrimD3DRender::UpdateLightsInternal(PrimD3DRender*)</code>
    /// </summary>
    public void UpdateLightsInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PrimD3DRender, void>)0x0059BEE0)(ref this);

    /// <summary>Pushes position and transformation data onto the renderer’s internal stack, handling optional scaling and coordinate conversion based on flag bits.
    /// <code>Offset: 0x0059C5F0
    /// void __thiscall PrimD3DRender::positionPushInternal(PrimD3DRender*,char,const Position*)</code>
    /// </summary>
    /// <param name="a2">Flags controlling processing: bit 0 indicates pushing base frame information; bit 1 triggers local‑to‑local transformation and object scaling.</param>
    /// <param name="a3">Pointer to a Position structure containing the object’s cell ID and frame data used for stack updates.</param>
    public void positionPushInternal(sbyte a2, ACBindings.Internal.Position* a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PrimD3DRender, sbyte, ACBindings.Internal.Position*, void>)0x0059C5F0)(ref this, a2, a3);

    /// <summary>Restores the rendering position and scaling state from an internal frame stack. If a previous frame exists it is reinstated; otherwise default values are applied.
    /// <code>Offset: 0x0059C790
    /// int __thiscall PrimD3DRender::positionPopInternal(PrimD3DRender*)</code>
    /// </summary>
    /// <returns>Non‑zero when a frame was restored, zero when the stack was empty and defaults were set.</returns>
    public int positionPopInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PrimD3DRender, int>)0x0059C790)(ref this);

    /// <summary>Calculates and applies the object's world transformation matrix from the current rendering frame, updating RenderDevice with a cached or identity matrix as appropriate.
    /// <code>Offset: 0x0059C840
    /// void __thiscall PrimD3DRender::CalcObjectMatrixInternal(PrimD3DRender*)</code>
    /// </summary>
    public void CalcObjectMatrixInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PrimD3DRender, void>)0x0059C840)(ref this);

    /// <summary>Initializes internal rendering components for PrimD3DRender, configuring its lighting system.
    /// <code>Offset: 0x0059C990
    /// int __thiscall PrimD3DRender::InitInternal(PrimD3DRender*)</code>
    /// </summary>
    /// <returns>Status code indicating successful initialization (value 1).</returns>
    public int InitInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PrimD3DRender, int>)0x0059C990)(ref this);

    /// <summary>Transforms a world‑space vertex into screen coordinates, optionally applying perspective projection. The computed values are stored in an internal rotating buffer and a pointer to the updated Vec2Dscreen structure is returned.
    /// <code>Offset: 0x0059C9A0
    /// Vec2Dscreen* __cdecl PrimD3DRender::xformStart(const AC1Legacy::Vector3*,int)</code>
    /// </summary>
    /// <param name="worldVertex">Pointer to the 3‑D position expressed in world space.</param>
    /// <param name="doprojection">Non‑zero triggers camera projection; zero returns unclipped coordinates.</param>
    /// <returns>Pointer to a Vec2Dscreen instance containing xw, yw, zw, and w components of the transformed vertex.</returns>
    public static ACBindings.Internal.Vec2Dscreen* xformStart(ACBindings.Internal.AC1Legacy.Vector3* worldVertex, int doprojection) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.AC1Legacy.Vector3*, int, ACBindings.Internal.Vec2Dscreen*>)0x0059C9A0)(worldVertex, doprojection);

    /// <summary>Transforms a vertex from world space into normalized screen coordinates and indicates whether it lies in front of the near clipping plane.
    /// <code>Offset: 0x0059CAB0
    /// BOOL __thiscall PrimD3DRender::xformPointInternal(PrimD3DRender*,AC1Legacy::Vector3*,Vec2D*)</code>
    /// </summary>
    /// <param name="worldVertex">Source vertex expressed in world coordinate system.</param>
    /// <param name="a3">Destination 2‑D vector receiving the transformed screen position.</param>
    /// <returns>True when the transformed point has a w component above the near‑plane threshold, indicating it is visible; otherwise false.</returns>
    public byte xformPointInternal(ACBindings.Internal.AC1Legacy.Vector3* worldVertex, ACBindings.Internal.Vec2D* a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PrimD3DRender, ACBindings.Internal.AC1Legacy.Vector3*, ACBindings.Internal.Vec2D*, byte>)0x0059CAB0)(ref this, worldVertex, a3);
}

