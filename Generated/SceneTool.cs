namespace ACBindings.Internal;


/// <summary>
/// Provides scene‑level rendering utilities, managing default materials, procedural geometry generation, camera handling, and debug overlay rendering for a legacy DirectX‑based 32‑bit Windows application.
/// </summary>
public unsafe struct SceneTool
{
    // Statics
    public static uint* sceneTimestamp = (uint*)0x00818C08;
    public static byte* m_RenderUIObjects = (byte*)0x00818C0C;
    public static uint* m_ScreenShotWidth = (uint*)0x00818C10;
    public static uint* m_ScreenShotHeight = (uint*)0x00818C14;
    public static uint* m_ScreenShotMaxX = (uint*)0x00818C18;
    public static uint* m_ScreenShotMaxY = (uint*)0x00818C1C;
    public static ACBindings.Internal.Position* m_CameraPosition = (ACBindings.Internal.Position*)0x00818C78;
    public static ACBindings.Internal.Position* m_WorldPosition = (ACBindings.Internal.Position*)0x00818CC0;
    public static float** m_LastFrameTimes = (float**)0x008383B8;
    public static float* m_FramesPerSecond = (float*)0x00838418;
    public static uint* m_CachedMaterialConditions = (uint*)0x0083841C;
    public static double* m_dLastOldResourcePurgeTime = (double*)0x00838428;
    public static ACBindings.Internal.RenderSurface** m_pScreenShotSurface = (ACBindings.Internal.RenderSurface**)0x00838430;
    public static uint* m_ScreenShotMinX = (uint*)0x00838438;
    public static uint* m_ScreenShotMinY = (uint*)0x0083843C;
    public static ACBindings.Internal.RenderMaterial** m_pDefaultMaterial = (ACBindings.Internal.RenderMaterial**)0x00838450;
    public static ACBindings.Internal.RenderMaterial** m_pPrimMaterial = (ACBindings.Internal.RenderMaterial**)0x00838454;
    public static ACBindings.Internal.RenderMaterial** m_pPrimObjectMaterial = (ACBindings.Internal.RenderMaterial**)0x00838458;
    public static ACBindings.Internal.RenderVertexBuffer** m_pPrimVertexBuffer = (ACBindings.Internal.RenderVertexBuffer**)0x0083845C;
    public static ACBindings.Internal.RenderMesh** m_pCylinderMesh = (ACBindings.Internal.RenderMesh**)0x00838460;
    public static ACBindings.Internal.RenderMesh** m_pSphereMesh = (ACBindings.Internal.RenderMesh**)0x00838464;
    public static ACBindings.Internal.DebugConsole** m_pDebugConsole = (ACBindings.Internal.DebugConsole**)0x00838468;
    public static ACBindings.Internal.ProfilerUI** m_pProfilerUI = (ACBindings.Internal.ProfilerUI**)0x0083846C;
    public static ACBindings.Internal.Matrix4* m_worldMatrix = (ACBindings.Internal.Matrix4*)0x008385B8;
    public static ACBindings.Internal.Matrix4* m_viewMatrix = (ACBindings.Internal.Matrix4*)0x008385F8;
    public static ACBindings.Internal.Matrix4* m_projMatrix = (ACBindings.Internal.Matrix4*)0x00838638;
    public static ACBindings.Internal.Matrix4* m_oldProjMatrix = (ACBindings.Internal.Matrix4*)0x008386B8;
    public static ACBindings.Internal.Matrix4* m_oldWorldMatrix = (ACBindings.Internal.Matrix4*)0x008386F8;

    // Methods

    /// <summary>Begins a new rendering cycle by incrementing the scene timestamp, setting up an identity transform matrix, and invoking the render device’s initialization routines when no active rendering state is detected.
    /// <code>Offset: 0x0043DC70
    /// void __cdecl SceneTool::BeginScene()</code>
    /// </summary>
    public static void BeginScene() => ((delegate* unmanaged[Cdecl]<void>)0x0043DC70)();

    /// <summary>Translates viewport pixel coordinates into clip‑space coordinates using the current render device resolution.
    /// <code>Offset: 0x0043DCD0
    /// void __cdecl SceneTool::ViewportToClip(const int,const int,float*,float*)</code>
    /// </summary>
    /// <param name="nX">The x‑coordinate in the viewport to be converted.</param>
    /// <param name="nY">The y‑coordinate in the viewport to be converted.</param>
    /// <param name="fClipX">Pointer where the resulting clip‑space x value will be stored.</param>
    /// <param name="fClipY">Pointer where the resulting clip‑space y value will be stored.</param>
    public static void ViewportToClip(int nX, int nY, float* fClipX, float* fClipY) => ((delegate* unmanaged[Cdecl]<int, int, float*, float*, void>)0x0043DCD0)(nX, nY, fClipX, fClipY);

    /// <summary>Creates a cylindrical mesh with 10 radial segments in the supplied RenderMesh instance, initializing vertex and index buffers for triangle list rendering.
    /// <code>Offset: 0x0043DD30
    /// char __cdecl SceneTool::BuildCylinderMesh(RenderMesh*)</code>
    /// </summary>
    /// <param name="a1">RenderMesh to populate with geometry.</param>
    /// <returns>Non-zero on success, zero if LOD batch creation fails.</returns>
    public static sbyte BuildCylinderMesh(ACBindings.Internal.RenderMesh* a1) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.RenderMesh*, sbyte>)0x0043DD30)(a1);

    /// <summary>Copies the current world, view, and projection matrices from the render device into internal storage and marks that the matrices have been cached.
    /// <code>Offset: 0x0043E640
    /// void __cdecl SceneTool::StoreMatrices()</code>
    /// </summary>
    public static void StoreMatrices() => ((delegate* unmanaged[Cdecl]<void>)0x0043E640)();

    /// <summary>Prepares the graphics device for rendering by ensuring the device is not lost and applying user preferences to the render system.
    /// <code>Offset: 0x0043E690
    /// void __cdecl SceneTool::PrepareGraphicsDevice()</code>
    /// </summary>
    public static void PrepareGraphicsDevice() => ((delegate* unmanaged[Cdecl]<void>)0x0043E690)();

    /// <summary>Purges outdated graphics resources when sufficient time has elapsed and video memory is low, freeing up memory.
    /// <code>Offset: 0x0043E760
    /// void __cdecl SceneTool::PurgeOldGraphicsResources()</code>
    /// </summary>
    public static void PurgeOldGraphicsResources() => ((delegate* unmanaged[Cdecl]<void>)0x0043E760)();

    /// <summary>Sets the camera's cell ID and frame based on the provided Position.
    /// <code>Offset: 0x0043E8E0
    /// void __cdecl SceneTool::SetupCamera(const Position*)</code>
    /// </summary>
    /// <param name="position">The source Position from which to copy cell ID and frame data.</param>
    public static void SetupCamera(ACBindings.Internal.Position* position) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.Position*, void>)0x0043E8E0)(position);

    /// <summary>Swaps the forward and up axes within a 4×4 transformation matrix, exchanging their corresponding basis columns while preserving translation and other matrix components.
    /// <code>Offset: 0x0043E900
    /// void __cdecl SceneTool::SwapMatrixForwardAndUp(Matrix4*)</code>
    /// </summary>
    /// <param name="mMatrix">The matrix whose forward (third column) and up (second column) vectors are to be interchanged.</param>
    public static void SwapMatrixForwardAndUp(ACBindings.Internal.Matrix4* mMatrix) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.Matrix4*, void>)0x0043E900)(mMatrix);

    /// <summary>Exchanges the forward and up axis columns of a transposed 4×4 transformation matrix, swapping their basis vectors.
    /// <code>Offset: 0x0043E990
    /// void __cdecl SceneTool::SwapTransposedMatrixForwardAndUp(Matrix4*)</code>
    /// </summary>
    /// <param name="mMatrix">The matrix whose forward (second column) and up (third column) vectors are swapped.</param>
    public static void SwapTransposedMatrixForwardAndUp(ACBindings.Internal.Matrix4* mMatrix) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.Matrix4*, void>)0x0043E990)(mMatrix);

    /// <summary>Renders a textured triangle using the supplied vertices, UV coordinates, texture, color tint, depth testing/writing flags, cull mode, blend modes and alpha handling.
    /// <code>Offset: 0x0043EAF0
    /// void __cdecl SceneTool::DrawTexturedTriangle(const Vector3*,const Vector3*,const Vector3*,const TexCoordPair*,const TexCoordPair*,const TexCoordPair*,const RenderTexture*,const RGBAColor*,const bool,const bool,const CullModeType,const BlendMode,const BlendMode,const bool)</code>
    /// </summary>
    /// <param name="a">First vertex position of the triangle.</param>
    /// <param name="b">Second vertex position of the triangle.</param>
    /// <param name="c">Third vertex position of the triangle.</param>
    /// <param name="UVa">Texture coordinate for vertex *a.</param>
    /// <param name="UVb">Texture coordinate for vertex *b.</param>
    /// <param name="UVc">Texture coordinate for vertex *c.</param>
    /// <param name="pTexture">Render texture to apply to the triangle. If null, no texture is bound.</param>
    /// <param name="color">Color tint applied to the rendered triangle.</param>
    /// <param name="depthTest">Specifies whether depth testing is enabled for this draw call.</param>
    /// <param name="depthWrite">Specifies whether depth writing is enabled.</param>
    /// <param name="cullMode">Defines which face of the triangle is culled (front, back or none).</param>
    /// <param name="SourceBlend">Blend factor used for source blending.</param>
    /// <param name="DestBlend">Blend factor used for destination blending.</param>
    /// <param name="TextureHasAlpha">Indicates whether the texture contains an alpha channel for proper blending.</param>
    public static void DrawTexturedTriangle(ACBindings.Internal.Vector3* a, ACBindings.Internal.Vector3* b, ACBindings.Internal.Vector3* c, ACBindings.Internal.TexCoordPair* UVa, ACBindings.Internal.TexCoordPair* UVb, ACBindings.Internal.TexCoordPair* UVc, ACBindings.Internal.RenderTexture* pTexture, ACBindings.Internal.RGBAColor* color, byte depthTest, byte depthWrite, ACBindings.Internal.CullModeType cullMode, ACBindings.Internal.BlendMode SourceBlend, ACBindings.Internal.BlendMode DestBlend, byte TextureHasAlpha) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.Vector3*, ACBindings.Internal.Vector3*, ACBindings.Internal.Vector3*, ACBindings.Internal.TexCoordPair*, ACBindings.Internal.TexCoordPair*, ACBindings.Internal.TexCoordPair*, ACBindings.Internal.RenderTexture*, ACBindings.Internal.RGBAColor*, byte, byte, ACBindings.Internal.CullModeType, ACBindings.Internal.BlendMode, ACBindings.Internal.BlendMode, byte, void>)0x0043EAF0)(a, b, c, UVa, UVb, UVc, pTexture, color, depthTest, depthWrite, cullMode, SourceBlend, DestBlend, TextureHasAlpha);

    /// <summary>Draws a single triangle using the specified vertex positions and solid color, applying depth testing, depth writing, face culling, and source/destination blend modes.
    /// <code>Offset: 0x0043EC30
    /// void __cdecl SceneTool::DrawTriangle(const Vector3*,const Vector3*,const Vector3*,const RGBAColor*,const bool,const bool,const CullModeType,const BlendMode,const BlendMode)</code>
    /// </summary>
    /// <param name="a">First vertex position of the triangle.</param>
    /// <param name="b">Second vertex position.</param>
    /// <param name="c">Third vertex position.</param>
    /// <param name="color">Color applied to all vertices.</param>
    /// <param name="depthTest">Enable or disable depth testing when rendering.</param>
    /// <param name="depthWrite">Control whether the triangle writes to the depth buffer.</param>
    /// <param name="cullMode">Specifies which faces (front, back, none) are culled during rendering.</param>
    /// <param name="SourceBlend">Blend factor used for source color blending.</param>
    /// <param name="DestBlend">Blend factor used for destination color blending.</param>
    public static void DrawTriangle(ACBindings.Internal.Vector3* a, ACBindings.Internal.Vector3* b, ACBindings.Internal.Vector3* c, ACBindings.Internal.RGBAColor* color, byte depthTest, byte depthWrite, ACBindings.Internal.CullModeType cullMode, ACBindings.Internal.BlendMode SourceBlend, ACBindings.Internal.BlendMode DestBlend) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.Vector3*, ACBindings.Internal.Vector3*, ACBindings.Internal.Vector3*, ACBindings.Internal.RGBAColor*, byte, byte, ACBindings.Internal.CullModeType, ACBindings.Internal.BlendMode, ACBindings.Internal.BlendMode, void>)0x0043EC30)(a, b, c, color, depthTest, depthWrite, cullMode, SourceBlend, DestBlend);

    /// <summary>Draws a polygon by fan‑filling triangles from the first vertex using the supplied vertex array and rendering state parameters.
    /// <code>Offset: 0x0043EC90
    /// void __cdecl SceneTool::DrawPolygon(const Vector3*,const unsigned int,const RGBAColor*,const bool,const bool,const CullModeType,const BlendMode,const BlendMode)</code>
    /// </summary>
    /// <param name="points">Pointer to an array of Vector3 that defines the polygon vertices in order.</param>
    /// <param name="numPoints">Number of vertices in the points array; must be at least three for a drawable polygon.</param>
    /// <param name="color">Uniform RGBAColor applied to all vertices of each triangle.</param>
    /// <param name="depthTest">Enable or disable depth testing during rendering.</param>
    /// <param name="depthWrite">Enable or disable writing to the depth buffer when drawing.</param>
    /// <param name="cullMode">Cull mode used to determine which triangle faces are discarded.</param>
    /// <param name="SourceBlend">Source blend factor applied during rendering.</param>
    /// <param name="DestBlend">Destination blend factor applied during rendering.</param>
    public static void DrawPolygon(ACBindings.Internal.Vector3* points, uint numPoints, ACBindings.Internal.RGBAColor* color, byte depthTest, byte depthWrite, ACBindings.Internal.CullModeType cullMode, ACBindings.Internal.BlendMode SourceBlend, ACBindings.Internal.BlendMode DestBlend) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.Vector3*, uint, ACBindings.Internal.RGBAColor*, byte, byte, ACBindings.Internal.CullModeType, ACBindings.Internal.BlendMode, ACBindings.Internal.BlendMode, void>)0x0043EC90)(points, numPoints, color, depthTest, depthWrite, cullMode, SourceBlend, DestBlend);

    /// <summary>Renders a textured polygon by decomposing it into triangles, applying the specified texture, color tint, depth testing and writing options, face culling mode, blend modes, and alpha handling.
    /// <code>Offset: 0x0043ED10
    /// void __cdecl SceneTool::DrawTexturedPolygon(const Vector3*,const unsigned int,const TexCoordPair*,const RenderTexture*,const RGBAColor*,const bool,const bool,const CullModeType,const BlendMode,const BlendMode,const bool)</code>
    /// </summary>
    /// <param name="points">Array of vertex positions that define the polygon in order.</param>
    /// <param name="numPoints">Number of vertices contained in the points array.</param>
    /// <param name="pUVPairs">Array of UV coordinate pairs corresponding to each vertex.</param>
    /// <param name="pTexture">Texture resource used for sampling during rendering.</param>
    /// <param name="color">Optional color tint applied to the rendered polygon.</param>
    /// <param name="depthTest">When true, performs depth buffer testing.</param>
    /// <param name="depthWrite">When true, writes depth values to the depth buffer.</param>
    /// <param name="cullMode">Specifies which face orientation to cull (e.g., back or front).</param>
    /// <param name="SourceBlend">Blend mode used for the source color component.</param>
    /// <param name="DestBlend">Blend mode used for the destination color component.</param>
    /// <param name="TextureHasAlpha">Indicates whether the texture contains an alpha channel that should influence blending.</param>
    public static void DrawTexturedPolygon(ACBindings.Internal.Vector3* points, uint numPoints, ACBindings.Internal.TexCoordPair* pUVPairs, ACBindings.Internal.RenderTexture* pTexture, ACBindings.Internal.RGBAColor* color, byte depthTest, byte depthWrite, ACBindings.Internal.CullModeType cullMode, ACBindings.Internal.BlendMode SourceBlend, ACBindings.Internal.BlendMode DestBlend, byte TextureHasAlpha) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.Vector3*, uint, ACBindings.Internal.TexCoordPair*, ACBindings.Internal.RenderTexture*, ACBindings.Internal.RGBAColor*, byte, byte, ACBindings.Internal.CullModeType, ACBindings.Internal.BlendMode, ACBindings.Internal.BlendMode, byte, void>)0x0043ED10)(points, numPoints, pUVPairs, pTexture, color, depthTest, depthWrite, cullMode, SourceBlend, DestBlend, TextureHasAlpha);

    /// <summary>Constructs procedural sphere geometry in the supplied RenderMesh, creating vertex buffers and an LOD batch for rendering.
    /// <code>Offset: 0x0043ED80
    /// char __cdecl SceneTool::BuildSphereMesh(RenderMesh*)</code>
    /// </summary>
    /// <param name="a1">RenderMesh to populate with sphere data.</param>
    /// <returns>Non‑zero if mesh construction succeeded; zero otherwise.</returns>
    public static sbyte BuildSphereMesh(ACBindings.Internal.RenderMesh* a1) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.RenderMesh*, sbyte>)0x0043ED80)(a1);

    /// <summary>Initializes the scene's world, view, and projection matrices to identity values and updates the rendering device accordingly.
    /// <code>Offset: 0x0043F5D0
    /// void __cdecl SceneTool::IdentityMatrices()</code>
    /// </summary>
    public static void IdentityMatrices() => ((delegate* unmanaged[Cdecl]<void>)0x0043F5D0)();

    /// <summary>Performs per‑frame maintenance by purging stale graphics resources, updating optional debug console and profiler UI components, and recording the current local timestamp.
    /// <code>Offset: 0x0043F7B0
    /// bool __cdecl SceneTool::Think()</code>
    /// </summary>
    /// <returns>Always returns true to indicate completion of the think cycle.</returns>
    public static byte Think() => ((delegate* unmanaged[Cdecl]<byte>)0x0043F7B0)();

    /// <summary>Renders a debug heads‑up display when the debug flag is set, drawing an overlay polygon and displaying FPS and camera position text on screen.
    /// <code>Offset: 0x0043F7F0
    /// void __cdecl SceneTool::RenderDebugHUD()</code>
    /// </summary>
    public static void RenderDebugHUD() => ((delegate* unmanaged[Cdecl]<void>)0x0043F7F0)();

    /// <summary>Renders a line between two points with specified color and depth behavior.
    /// <code>Offset: 0x0043FCB0
    /// void __cdecl SceneTool::DrawLine(const Vector3*,const Vector3*,const RGBAColor*,const bool,const bool)</code>
    /// </summary>
    /// <param name="a">The starting point of the line.</param>
    /// <param name="b">The ending point of the line.</param>
    /// <param name="color">Color to apply to the line, including alpha transparency.</param>
    /// <param name="depthTest">If true, enables depth testing for the line.</param>
    /// <param name="depthWrite">If true, writes the line's depth value to the buffer.</param>
    public static void DrawLine(ACBindings.Internal.Vector3* a, ACBindings.Internal.Vector3* b, ACBindings.Internal.RGBAColor* color, byte depthTest, byte depthWrite) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.Vector3*, ACBindings.Internal.Vector3*, ACBindings.Internal.RGBAColor*, byte, byte, void>)0x0043FCB0)(a, b, color, depthTest, depthWrite);

    /// <summary>Finalizes rendering for the current frame, drawing UI elements, profiler and debug console overlays when enabled, updating the HUD, and calculating performance metrics such as frames per second.
    /// <code>Offset: 0x0043FCD0
    /// void __cdecl SceneTool::EndFrame(const bool)</code>
    /// </summary>
    /// <param name="bDrawUI">Ignored; present only for compatibility with legacy interfaces.</param>
    public static void EndFrame(byte bDrawUI) => ((delegate* unmanaged[Cdecl]<byte, void>)0x0043FCD0)(bDrawUI);

    /// <summary>Terminates the SceneTool subsystem by unregistering global settings, unlinking rendering callbacks, and freeing all allocated resources such as profiler UI, debug console, vertex buffer, meshes, materials, and screenshot surface. Resets the initialization flag to indicate shutdown has completed.
    /// <code>Offset: 0x0043FDD0
    /// void __cdecl SceneTool::Shutdown()</code>
    /// </summary>
    public static void Shutdown() => ((delegate* unmanaged[Cdecl]<void>)0x0043FDD0)();

    /// <summary>Creates or replaces the scene's default, primitive, and object materials by allocating new RenderMaterial instances, initializing their layer stacks with standard settings, and optimizing them. Releases any previously allocated materials before creating new ones.
    /// <code>Offset: 0x0043FFE0
    /// bool __cdecl SceneTool::CreateDefaultMaterial()</code>
    /// </summary>
    /// <returns>True if all material allocations and initializations succeeded; otherwise false.</returns>
    public static byte CreateDefaultMaterial() => ((delegate* unmanaged[Cdecl]<byte>)0x0043FFE0)();

    /// <summary>Initializes the SceneTool subsystem by setting up default materials, geometry meshes, camera matrices, debug console, profiler UI, and registering global configuration variables for screenshots and UI rendering.
    /// <code>Offset: 0x004402D0
    /// bool __cdecl SceneTool::Startup()</code>
    /// </summary>
    /// <returns>True if all resources were successfully created; otherwise false.</returns>
    public static byte Startup() => ((delegate* unmanaged[Cdecl]<byte>)0x004402D0)();
}

