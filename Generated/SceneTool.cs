namespace ACBindings;

// SceneTool
public unsafe struct SceneTool
{
    // Statics
    public static uint* sceneTimestamp = (uint*)0x00818C08;
    public static byte* m_RenderUIObjects = (byte*)0x00818C0C;
    public static uint* m_ScreenShotWidth = (uint*)0x00818C10;
    public static uint* m_ScreenShotHeight = (uint*)0x00818C14;
    public static uint* m_ScreenShotMaxX = (uint*)0x00818C18;
    public static uint* m_ScreenShotMaxY = (uint*)0x00818C1C;
    public static ACBindings.Position* m_CameraPosition = (ACBindings.Position*)0x00818C7C;
    public static ACBindings.Position* m_WorldPosition = (ACBindings.Position*)0x00818CC8;
    public static float* m_LastFrameTimes = (float*)0x008383B8;
    public static float* m_FramesPerSecond = (float*)0x00838418;
    public static uint* m_CachedMaterialConditions = (uint*)0x0083841C;
    public static double* m_dLastOldResourcePurgeTime = (double*)0x00838428;
    public static ACBindings.RenderSurface* m_pScreenShotSurface = (ACBindings.RenderSurface*)0x00838430;
    public static uint* m_ScreenShotMinX = (uint*)0x00838438;
    public static uint* m_ScreenShotMinY = (uint*)0x0083843C;
    public static ACBindings.RenderMaterial* m_pDefaultMaterial = (ACBindings.RenderMaterial*)0x00838450;
    public static ACBindings.RenderMaterial* m_pPrimMaterial = (ACBindings.RenderMaterial*)0x00838454;
    public static ACBindings.RenderMaterial* m_pPrimObjectMaterial = (ACBindings.RenderMaterial*)0x00838458;
    public static ACBindings.RenderVertexBuffer* m_pPrimVertexBuffer = (ACBindings.RenderVertexBuffer*)0x0083845C;
    public static ACBindings.RenderMesh* m_pCylinderMesh = (ACBindings.RenderMesh*)0x00838460;
    public static ACBindings.RenderMesh* m_pSphereMesh = (ACBindings.RenderMesh*)0x00838464;
    public static ACBindings.DebugConsole* m_pDebugConsole = (ACBindings.DebugConsole*)0x00838468;
    public static ACBindings.ProfilerUI* m_pProfilerUI = (ACBindings.ProfilerUI*)0x0083846C;
    public static ACBindings.Matrix4* m_worldMatrix = (ACBindings.Matrix4*)0x008385B8;
    public static ACBindings.Matrix4* m_viewMatrix = (ACBindings.Matrix4*)0x008385F8;
    public static ACBindings.Matrix4* m_projMatrix = (ACBindings.Matrix4*)0x00838638;
    public static ACBindings.Matrix4* m_oldViewMatrix = (ACBindings.Matrix4*)0x00838678;
    public static ACBindings.Matrix4* m_oldProjMatrix = (ACBindings.Matrix4*)0x008386B8;
    public static ACBindings.Matrix4* m_oldWorldMatrix = (ACBindings.Matrix4*)0x008386F8;

    // Methods
    // void __cdecl SceneTool::BeginScene()
    public static void BeginScene() => ((delegate* unmanaged[Cdecl]<void>)0x0043DC70)();
    // void __cdecl SceneTool::ViewportToClip(const int,const int,float*,float*)
    public static void ViewportToClip(int nX, int nY, float* fClipX, float* fClipY) => ((delegate* unmanaged[Cdecl]<int, int, float*, float*, void>)0x0043DCD0)(nX, nY, fClipX, fClipY);
    // char __cdecl SceneTool::BuildCylinderMesh(RenderMesh*)
    public static sbyte BuildCylinderMesh(ACBindings.RenderMesh* a1) => ((delegate* unmanaged[Cdecl]<ACBindings.RenderMesh*, sbyte>)0x0043DD30)(a1);
    // void __cdecl SceneTool::StoreMatrices()
    public static void StoreMatrices() => ((delegate* unmanaged[Cdecl]<void>)0x0043E640)();
    // void __cdecl SceneTool::PrepareGraphicsDevice()
    public static void PrepareGraphicsDevice() => ((delegate* unmanaged[Cdecl]<void>)0x0043E690)();
    // void __cdecl SceneTool::PurgeOldGraphicsResources()
    public static void PurgeOldGraphicsResources() => ((delegate* unmanaged[Cdecl]<void>)0x0043E760)();
    // void __cdecl SceneTool::SetupCamera(const Position*)
    public static void SetupCamera(ACBindings.Position* position) => ((delegate* unmanaged[Cdecl]<ACBindings.Position*, void>)0x0043E8E0)(position);
    // void __cdecl SceneTool::SwapMatrixForwardAndUp(Matrix4*)
    public static void SwapMatrixForwardAndUp(ACBindings.Matrix4* mMatrix) => ((delegate* unmanaged[Cdecl]<ACBindings.Matrix4*, void>)0x0043E900)(mMatrix);
    // void __cdecl SceneTool::SwapTransposedMatrixForwardAndUp(Matrix4*)
    public static void SwapTransposedMatrixForwardAndUp(ACBindings.Matrix4* mMatrix) => ((delegate* unmanaged[Cdecl]<ACBindings.Matrix4*, void>)0x0043E990)(mMatrix);
    // void __cdecl SceneTool::DrawTexturedTriangle(const Vector3*,const Vector3*,const Vector3*,const TexCoordPair*,const TexCoordPair*,const TexCoordPair*,const RenderTexture*,const RGBAColor*,const bool,const bool,const CullModeType,const BlendMode,const BlendMode,const bool)
    public static void DrawTexturedTriangle(ACBindings.Vector3* a, ACBindings.Vector3* b, ACBindings.Vector3* c, ACBindings.TexCoordPair* UVa, ACBindings.TexCoordPair* UVb, ACBindings.TexCoordPair* UVc, ACBindings.RenderTexture* pTexture, ACBindings.RGBAColor* color, byte depthTest, byte depthWrite, ACBindings.CullModeType cullMode, ACBindings.BlendMode SourceBlend, ACBindings.BlendMode DestBlend, byte TextureHasAlpha) => ((delegate* unmanaged[Cdecl]<ACBindings.Vector3*, ACBindings.Vector3*, ACBindings.Vector3*, ACBindings.TexCoordPair*, ACBindings.TexCoordPair*, ACBindings.TexCoordPair*, ACBindings.RenderTexture*, ACBindings.RGBAColor*, byte, byte, ACBindings.CullModeType, ACBindings.BlendMode, ACBindings.BlendMode, byte, void>)0x0043EAF0)(a, b, c, UVa, UVb, UVc, pTexture, color, depthTest, depthWrite, cullMode, SourceBlend, DestBlend, TextureHasAlpha);
    // void __cdecl SceneTool::DrawTriangle(const Vector3*,const Vector3*,const Vector3*,const RGBAColor*,const bool,const bool,const CullModeType,const BlendMode,const BlendMode)
    public static void DrawTriangle(ACBindings.Vector3* a, ACBindings.Vector3* b, ACBindings.Vector3* c, ACBindings.RGBAColor* color, byte depthTest, byte depthWrite, ACBindings.CullModeType cullMode, ACBindings.BlendMode SourceBlend, ACBindings.BlendMode DestBlend) => ((delegate* unmanaged[Cdecl]<ACBindings.Vector3*, ACBindings.Vector3*, ACBindings.Vector3*, ACBindings.RGBAColor*, byte, byte, ACBindings.CullModeType, ACBindings.BlendMode, ACBindings.BlendMode, void>)0x0043EC30)(a, b, c, color, depthTest, depthWrite, cullMode, SourceBlend, DestBlend);
    // void __cdecl SceneTool::DrawPolygon(const Vector3*,const unsigned int,const RGBAColor*,const bool,const bool,const CullModeType,const BlendMode,const BlendMode)
    public static void DrawPolygon(ACBindings.Vector3* points, uint numPoints, ACBindings.RGBAColor* color, byte depthTest, byte depthWrite, ACBindings.CullModeType cullMode, ACBindings.BlendMode SourceBlend, ACBindings.BlendMode DestBlend) => ((delegate* unmanaged[Cdecl]<ACBindings.Vector3*, uint, ACBindings.RGBAColor*, byte, byte, ACBindings.CullModeType, ACBindings.BlendMode, ACBindings.BlendMode, void>)0x0043EC90)(points, numPoints, color, depthTest, depthWrite, cullMode, SourceBlend, DestBlend);
    // void __cdecl SceneTool::DrawTexturedPolygon(const Vector3*,const unsigned int,const TexCoordPair*,const RenderTexture*,const RGBAColor*,const bool,const bool,const CullModeType,const BlendMode,const BlendMode,const bool)
    public static void DrawTexturedPolygon(ACBindings.Vector3* points, uint numPoints, ACBindings.TexCoordPair* pUVPairs, ACBindings.RenderTexture* pTexture, ACBindings.RGBAColor* color, byte depthTest, byte depthWrite, ACBindings.CullModeType cullMode, ACBindings.BlendMode SourceBlend, ACBindings.BlendMode DestBlend, byte TextureHasAlpha) => ((delegate* unmanaged[Cdecl]<ACBindings.Vector3*, uint, ACBindings.TexCoordPair*, ACBindings.RenderTexture*, ACBindings.RGBAColor*, byte, byte, ACBindings.CullModeType, ACBindings.BlendMode, ACBindings.BlendMode, byte, void>)0x0043ED10)(points, numPoints, pUVPairs, pTexture, color, depthTest, depthWrite, cullMode, SourceBlend, DestBlend, TextureHasAlpha);
    // char __cdecl SceneTool::BuildSphereMesh(RenderMesh*)
    public static sbyte BuildSphereMesh(ACBindings.RenderMesh* a1) => ((delegate* unmanaged[Cdecl]<ACBindings.RenderMesh*, sbyte>)0x0043ED80)(a1);
    // void __cdecl SceneTool::IdentityMatrices()
    public static void IdentityMatrices() => ((delegate* unmanaged[Cdecl]<void>)0x0043F5D0)();
    // bool __cdecl SceneTool::Think()
    public static byte Think() => ((delegate* unmanaged[Cdecl]<byte>)0x0043F7B0)();
    // void __cdecl SceneTool::RenderDebugHUD()
    public static void RenderDebugHUD() => ((delegate* unmanaged[Cdecl]<void>)0x0043F7F0)();
    // void __cdecl SceneTool::DrawLine(const Vector3*,const Vector3*,const RGBAColor*,const bool,const bool)
    public static void DrawLine(ACBindings.Vector3* a, ACBindings.Vector3* b, ACBindings.RGBAColor* color, byte depthTest, byte depthWrite) => ((delegate* unmanaged[Cdecl]<ACBindings.Vector3*, ACBindings.Vector3*, ACBindings.RGBAColor*, byte, byte, void>)0x0043FCB0)(a, b, color, depthTest, depthWrite);
    // void __cdecl SceneTool::EndFrame(const bool)
    public static void EndFrame(byte bDrawUI) => ((delegate* unmanaged[Cdecl]<byte, void>)0x0043FCD0)(bDrawUI);
    // void __cdecl SceneTool::Shutdown()
    public static void Shutdown() => ((delegate* unmanaged[Cdecl]<void>)0x0043FDD0)();
    // bool __cdecl SceneTool::CreateDefaultMaterial()
    public static byte CreateDefaultMaterial() => ((delegate* unmanaged[Cdecl]<byte>)0x0043FFE0)();
    // bool __cdecl SceneTool::Startup()
    public static byte Startup() => ((delegate* unmanaged[Cdecl]<byte>)0x004402D0)();
}

