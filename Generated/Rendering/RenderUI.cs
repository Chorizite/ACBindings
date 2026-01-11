namespace ACBindings.Internal;

public unsafe struct RenderUI
{
    // Statics
    public static ACBindings.Internal.RenderIndexBuffer* s_pUISurfaceIB = (ACBindings.Internal.RenderIndexBuffer*)0x0083A18C;
    public static uint* s_sceneID = (uint*)0x0083A194;

    // Methods

    /// <summary>
    /// <code>Offset: 0x00448790
    /// bool __cdecl RenderUI::CreateUISurfaceIndexBuffer()</code>
    /// </summary>
    public static byte CreateUISurfaceIndexBuffer() => ((delegate* unmanaged[Cdecl]<byte>)0x00448790)();

    /// <summary>
    /// <code>Offset: 0x004488A0
    /// void __cdecl RenderUI::RenderObjects()</code>
    /// </summary>
    public static void RenderObjects() => ((delegate* unmanaged[Cdecl]<void>)0x004488A0)();

    /// <summary>
    /// <code>Offset: 0x00448910
    /// void __cdecl RenderUI::ComputeGameViewport(unsigned int*,unsigned int*,unsigned int*,unsigned int*)</code>
    /// </summary>
    public static void ComputeGameViewport(uint* o_X, uint* o_Y, uint* o_Width, uint* o_Height) => ((delegate* unmanaged[Cdecl]<uint*, uint*, uint*, uint*, void>)0x00448910)(o_X, o_Y, o_Width, o_Height);

    /// <summary>
    /// <code>Offset: 0x00448BE0
    /// void __cdecl RenderUI::RecalculateClampedPosition()</code>
    /// </summary>
    public static void RecalculateClampedPosition() => ((delegate* unmanaged[Cdecl]<void>)0x00448BE0)();

    /// <summary>
    /// <code>Offset: 0x00448EA0
    /// void __cdecl RenderUI::Shutdown()</code>
    /// </summary>
    public static void Shutdown() => ((delegate* unmanaged[Cdecl]<void>)0x00448EA0)();

    /// <summary>
    /// <code>Offset: 0x00448F20
    /// void __cdecl RenderUI::UnlinkObject(UIObject*)</code>
    /// </summary>
    public static void UnlinkObject(ACBindings.Internal.UIObject* object_) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.UIObject*, void>)0x00448F20)(object_);

    /// <summary>
    /// <code>Offset: 0x00449320
    /// void __cdecl RenderUI::LinkObject(UIObject*)</code>
    /// </summary>
    public static void LinkObject(ACBindings.Internal.UIObject* object_) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.UIObject*, void>)0x00449320)(object_);

    /// <summary>
    /// <code>Offset: 0x004493D0
    /// void __cdecl RenderUI::LinkObjectAfter(UIObject*,UIObject*)</code>
    /// </summary>
    public static void LinkObjectAfter(ACBindings.Internal.UIObject* object_, ACBindings.Internal.UIObject* pExistingObjectToDrawAfter) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.UIObject*, ACBindings.Internal.UIObject*, void>)0x004493D0)(object_, pExistingObjectToDrawAfter);
}

