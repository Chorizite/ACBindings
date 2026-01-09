namespace ACBindings;

// RenderUI
public unsafe struct RenderUI
{
    // Statics
    public static ACBindings.RenderIndexBuffer* s_pUISurfaceIB = (ACBindings.RenderIndexBuffer*)0x0083A18C;
    public static byte* s_bCurrentlyRendering = (byte*)0x0083A190;
    public static uint* s_sceneID = (uint*)0x0083A194;
    public static ACBindings.HashList__UIObject_ptr__UIObject_ptr* s_hlObjects = (ACBindings.HashList__UIObject_ptr__UIObject_ptr*)0x0083A334;

    // Methods
    // bool __cdecl RenderUI::CreateUISurfaceIndexBuffer()
    public static byte CreateUISurfaceIndexBuffer() => ((delegate* unmanaged[Cdecl]<byte>)0x00448790)();
    // void __cdecl RenderUI::RenderObjects()
    public static void RenderObjects() => ((delegate* unmanaged[Cdecl]<void>)0x004488A0)();
    // void __cdecl RenderUI::ComputeGameViewport(unsigned int*,unsigned int*,unsigned int*,unsigned int*)
    public static void ComputeGameViewport(uint* o_X, uint* o_Y, uint* o_Width, uint* o_Height) => ((delegate* unmanaged[Cdecl]<uint*, uint*, uint*, uint*, void>)0x00448910)(o_X, o_Y, o_Width, o_Height);
    // void __cdecl RenderUI::RecalculateClampedPosition()
    public static void RecalculateClampedPosition() => ((delegate* unmanaged[Cdecl]<void>)0x00448BE0)();
    // void __cdecl RenderUI::Shutdown()
    public static void Shutdown() => ((delegate* unmanaged[Cdecl]<void>)0x00448EA0)();
    // void __cdecl RenderUI::UnlinkObject(UIObject*)
    public static void UnlinkObject(ACBindings.UIObject* object_) => ((delegate* unmanaged[Cdecl]<ACBindings.UIObject*, void>)0x00448F20)(object_);
    // void __cdecl RenderUI::LinkObject(UIObject*)
    public static void LinkObject(ACBindings.UIObject* object_) => ((delegate* unmanaged[Cdecl]<ACBindings.UIObject*, void>)0x00449320)(object_);
    // void __cdecl RenderUI::LinkObjectAfter(UIObject*,UIObject*)
    public static void LinkObjectAfter(ACBindings.UIObject* object_, ACBindings.UIObject* pExistingObjectToDrawAfter) => ((delegate* unmanaged[Cdecl]<ACBindings.UIObject*, ACBindings.UIObject*, void>)0x004493D0)(object_, pExistingObjectToDrawAfter);
}

