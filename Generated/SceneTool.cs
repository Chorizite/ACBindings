namespace ACBindings.Internal;

public unsafe struct SceneTool
{
    // Statics
    public static uint* sceneTimestamp = (uint*)0x00818C08;
    public static uint* m_ScreenShotWidth = (uint*)0x00818C10;
    public static uint* m_ScreenShotHeight = (uint*)0x00818C14;
    public static uint* m_ScreenShotMaxX = (uint*)0x00818C18;
    public static uint* m_ScreenShotMaxY = (uint*)0x00818C1C;
    public static uint* m_CachedMaterialConditions = (uint*)0x0083841C;
    public static double* m_dLastOldResourcePurgeTime = (double*)0x00838428;
    public static ACBindings.Internal.RenderSurface* m_pScreenShotSurface = (ACBindings.Internal.RenderSurface*)0x00838430;
    public static uint* m_ScreenShotMinX = (uint*)0x00838438;
    public static uint* m_ScreenShotMinY = (uint*)0x0083843C;
    public static ACBindings.Internal.RenderMaterial* m_pDefaultMaterial = (ACBindings.Internal.RenderMaterial*)0x00838450;
    public static ACBindings.Internal.RenderMaterial* m_pPrimObjectMaterial = (ACBindings.Internal.RenderMaterial*)0x00838458;
    public static ACBindings.Internal.RenderMesh* m_pCylinderMesh = (ACBindings.Internal.RenderMesh*)0x00838460;
    public static ACBindings.Internal.RenderMesh* m_pSphereMesh = (ACBindings.Internal.RenderMesh*)0x00838464;
    public static ACBindings.Internal.ProfilerUI* m_pProfilerUI = (ACBindings.Internal.ProfilerUI*)0x0083846C;

    // Methods

    /// <summary>
    /// <code>Offset: 0x0043DC70
    /// void __cdecl SceneTool::BeginScene()</code>
    /// </summary>
    public static void BeginScene() => ((delegate* unmanaged[Cdecl]<void>)0x0043DC70)();

    /// <summary>
    /// <code>Offset: 0x0043DCD0
    /// void __cdecl SceneTool::ViewportToClip(const int,const int,float*,float*)</code>
    /// </summary>
    public static void ViewportToClip(int nX, int nY, float* fClipX, float* fClipY) => ((delegate* unmanaged[Cdecl]<int, int, float*, float*, void>)0x0043DCD0)(nX, nY, fClipX, fClipY);

    /// <summary>
    /// <code>Offset: 0x0043DD30
    /// char __cdecl SceneTool::BuildCylinderMesh(RenderMesh*)</code>
    /// </summary>
    public static sbyte BuildCylinderMesh(ACBindings.Internal.RenderMesh* a1) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.RenderMesh*, sbyte>)0x0043DD30)(a1);

    /// <summary>
    /// <code>Offset: 0x0043E640
    /// void __cdecl SceneTool::StoreMatrices()</code>
    /// </summary>
    public static void StoreMatrices() => ((delegate* unmanaged[Cdecl]<void>)0x0043E640)();

    /// <summary>
    /// <code>Offset: 0x0043E690
    /// void __cdecl SceneTool::PrepareGraphicsDevice()</code>
    /// </summary>
    public static void PrepareGraphicsDevice() => ((delegate* unmanaged[Cdecl]<void>)0x0043E690)();

    /// <summary>
    /// <code>Offset: 0x0043E760
    /// void __cdecl SceneTool::PurgeOldGraphicsResources()</code>
    /// </summary>
    public static void PurgeOldGraphicsResources() => ((delegate* unmanaged[Cdecl]<void>)0x0043E760)();

    /// <summary>
    /// <code>Offset: 0x0043E8E0
    /// void __cdecl SceneTool::SetupCamera(const Position*)</code>
    /// </summary>
    public static void SetupCamera(ACBindings.Internal.Position* position) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.Position*, void>)0x0043E8E0)(position);

    /// <summary>
    /// <code>Offset: 0x0043E900
    /// void __cdecl SceneTool::SwapMatrixForwardAndUp(Matrix4*)</code>
    /// </summary>
    public static void SwapMatrixForwardAndUp(ACBindings.Internal.Matrix4* mMatrix) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.Matrix4*, void>)0x0043E900)(mMatrix);

    /// <summary>
    /// <code>Offset: 0x0043E990
    /// void __cdecl SceneTool::SwapTransposedMatrixForwardAndUp(Matrix4*)</code>
    /// </summary>
    public static void SwapTransposedMatrixForwardAndUp(ACBindings.Internal.Matrix4* mMatrix) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.Matrix4*, void>)0x0043E990)(mMatrix);

    /// <summary>
    /// <code>Offset: 0x0043EAF0
    /// void __cdecl SceneTool::DrawTexturedTriangle(const Vector3*,const Vector3*,const Vector3*,const TexCoordPair*,const TexCoordPair*,const TexCoordPair*,const RenderTexture*,const RGBAColor*,const bool,const bool,const CullModeType,const BlendMode,const BlendMode,const bool)</code>
    /// </summary>
    public static void DrawTexturedTriangle(ACBindings.Internal.Vector3* a, ACBindings.Internal.Vector3* b, ACBindings.Internal.Vector3* c, ACBindings.Internal.TexCoordPair* UVa, ACBindings.Internal.TexCoordPair* UVb, ACBindings.Internal.TexCoordPair* UVc, ACBindings.Internal.RenderTexture* pTexture, ACBindings.Internal.RGBAColor* color, byte depthTest, byte depthWrite, ACBindings.Internal.CullModeType cullMode, ACBindings.Internal.BlendMode SourceBlend, ACBindings.Internal.BlendMode DestBlend, byte TextureHasAlpha) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.Vector3*, ACBindings.Internal.Vector3*, ACBindings.Internal.Vector3*, ACBindings.Internal.TexCoordPair*, ACBindings.Internal.TexCoordPair*, ACBindings.Internal.TexCoordPair*, ACBindings.Internal.RenderTexture*, ACBindings.Internal.RGBAColor*, byte, byte, ACBindings.Internal.CullModeType, ACBindings.Internal.BlendMode, ACBindings.Internal.BlendMode, byte, void>)0x0043EAF0)(a, b, c, UVa, UVb, UVc, pTexture, color, depthTest, depthWrite, cullMode, SourceBlend, DestBlend, TextureHasAlpha);

    /// <summary>
    /// <code>Offset: 0x0043EC30
    /// void __cdecl SceneTool::DrawTriangle(const Vector3*,const Vector3*,const Vector3*,const RGBAColor*,const bool,const bool,const CullModeType,const BlendMode,const BlendMode)</code>
    /// </summary>
    public static void DrawTriangle(ACBindings.Internal.Vector3* a, ACBindings.Internal.Vector3* b, ACBindings.Internal.Vector3* c, ACBindings.Internal.RGBAColor* color, byte depthTest, byte depthWrite, ACBindings.Internal.CullModeType cullMode, ACBindings.Internal.BlendMode SourceBlend, ACBindings.Internal.BlendMode DestBlend) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.Vector3*, ACBindings.Internal.Vector3*, ACBindings.Internal.Vector3*, ACBindings.Internal.RGBAColor*, byte, byte, ACBindings.Internal.CullModeType, ACBindings.Internal.BlendMode, ACBindings.Internal.BlendMode, void>)0x0043EC30)(a, b, c, color, depthTest, depthWrite, cullMode, SourceBlend, DestBlend);

    /// <summary>
    /// <code>Offset: 0x0043EC90
    /// void __cdecl SceneTool::DrawPolygon(const Vector3*,const unsigned int,const RGBAColor*,const bool,const bool,const CullModeType,const BlendMode,const BlendMode)</code>
    /// </summary>
    public static void DrawPolygon(ACBindings.Internal.Vector3* points, uint numPoints, ACBindings.Internal.RGBAColor* color, byte depthTest, byte depthWrite, ACBindings.Internal.CullModeType cullMode, ACBindings.Internal.BlendMode SourceBlend, ACBindings.Internal.BlendMode DestBlend) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.Vector3*, uint, ACBindings.Internal.RGBAColor*, byte, byte, ACBindings.Internal.CullModeType, ACBindings.Internal.BlendMode, ACBindings.Internal.BlendMode, void>)0x0043EC90)(points, numPoints, color, depthTest, depthWrite, cullMode, SourceBlend, DestBlend);

    /// <summary>
    /// <code>Offset: 0x0043ED10
    /// void __cdecl SceneTool::DrawTexturedPolygon(const Vector3*,const unsigned int,const TexCoordPair*,const RenderTexture*,const RGBAColor*,const bool,const bool,const CullModeType,const BlendMode,const BlendMode,const bool)</code>
    /// </summary>
    public static void DrawTexturedPolygon(ACBindings.Internal.Vector3* points, uint numPoints, ACBindings.Internal.TexCoordPair* pUVPairs, ACBindings.Internal.RenderTexture* pTexture, ACBindings.Internal.RGBAColor* color, byte depthTest, byte depthWrite, ACBindings.Internal.CullModeType cullMode, ACBindings.Internal.BlendMode SourceBlend, ACBindings.Internal.BlendMode DestBlend, byte TextureHasAlpha) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.Vector3*, uint, ACBindings.Internal.TexCoordPair*, ACBindings.Internal.RenderTexture*, ACBindings.Internal.RGBAColor*, byte, byte, ACBindings.Internal.CullModeType, ACBindings.Internal.BlendMode, ACBindings.Internal.BlendMode, byte, void>)0x0043ED10)(points, numPoints, pUVPairs, pTexture, color, depthTest, depthWrite, cullMode, SourceBlend, DestBlend, TextureHasAlpha);

    /// <summary>
    /// <code>Offset: 0x0043ED80
    /// char __cdecl SceneTool::BuildSphereMesh(RenderMesh*)</code>
    /// </summary>
    public static sbyte BuildSphereMesh(ACBindings.Internal.RenderMesh* a1) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.RenderMesh*, sbyte>)0x0043ED80)(a1);

    /// <summary>
    /// <code>Offset: 0x0043F5D0
    /// void __cdecl SceneTool::IdentityMatrices()</code>
    /// </summary>
    public static void IdentityMatrices() => ((delegate* unmanaged[Cdecl]<void>)0x0043F5D0)();

    /// <summary>
    /// <code>Offset: 0x0043F7B0
    /// bool __cdecl SceneTool::Think()</code>
    /// </summary>
    public static byte Think() => ((delegate* unmanaged[Cdecl]<byte>)0x0043F7B0)();

    /// <summary>
    /// <code>Offset: 0x0043F7F0
    /// void __cdecl SceneTool::RenderDebugHUD()</code>
    /// </summary>
    public static void RenderDebugHUD() => ((delegate* unmanaged[Cdecl]<void>)0x0043F7F0)();

    /// <summary>
    /// <code>Offset: 0x0043FCB0
    /// void __cdecl SceneTool::DrawLine(const Vector3*,const Vector3*,const RGBAColor*,const bool,const bool)</code>
    /// </summary>
    public static void DrawLine(ACBindings.Internal.Vector3* a, ACBindings.Internal.Vector3* b, ACBindings.Internal.RGBAColor* color, byte depthTest, byte depthWrite) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.Vector3*, ACBindings.Internal.Vector3*, ACBindings.Internal.RGBAColor*, byte, byte, void>)0x0043FCB0)(a, b, color, depthTest, depthWrite);

    /// <summary>
    /// <code>Offset: 0x0043FCD0
    /// void __cdecl SceneTool::EndFrame(const bool)</code>
    /// </summary>
    public static void EndFrame(byte bDrawUI) => ((delegate* unmanaged[Cdecl]<byte, void>)0x0043FCD0)(bDrawUI);

    /// <summary>
    /// <code>Offset: 0x0043FDD0
    /// void __cdecl SceneTool::Shutdown()</code>
    /// </summary>
    public static void Shutdown() => ((delegate* unmanaged[Cdecl]<void>)0x0043FDD0)();

    /// <summary>
    /// <code>Offset: 0x0043FFE0
    /// bool __cdecl SceneTool::CreateDefaultMaterial()</code>
    /// </summary>
    public static byte CreateDefaultMaterial() => ((delegate* unmanaged[Cdecl]<byte>)0x0043FFE0)();

    /// <summary>
    /// <code>Offset: 0x004402D0
    /// bool __cdecl SceneTool::Startup()</code>
    /// </summary>
    public static byte Startup() => ((delegate* unmanaged[Cdecl]<byte>)0x004402D0)();
}

