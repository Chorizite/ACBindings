namespace ACBindings.Internal;


/// <summary>Manages rendering of user interface elements, handling viewport calculation, object ordering, and index buffer creation for the UI system.</summary>
public unsafe struct RenderUI
{
    // Statics
    public static ACBindings.Internal.RenderIndexBuffer** s_pUISurfaceIB = (ACBindings.Internal.RenderIndexBuffer**)0x0083A18C;
    public static byte* s_bCurrentlyRendering = (byte*)0x0083A190;
    public static uint* s_sceneID = (uint*)0x0083A194;
    public static ACBindings.Internal.HashList___UIObject_ptr___UIObject_ptr* s_hlObjects = (ACBindings.Internal.HashList___UIObject_ptr___UIObject_ptr*)0x0083A334;

    // Methods

    /// <summary>Create or replace the index buffer used for UI surface rendering. The method allocates a new RenderIndexBuffer, initializes it with six indices that form two triangles covering a quad, locks the buffer to write these indices, and unlocks it. If any step fails, the function returns false.
    /// <code>Offset: 0x00448790
    /// bool __cdecl RenderUI::CreateUISurfaceIndexBuffer()</code>
    /// </summary>
    /// <returns>True if the index buffer was successfully created and initialized; otherwise false.</returns>
    public static byte CreateUISurfaceIndexBuffer() => ((delegate* unmanaged[Cdecl]<byte>)0x00448790)();

    /// <summary>Renders all highlighted objects in the current scene, invoking each object's render callback and updating the spell selection notice afterward.
    /// <code>Offset: 0x004488A0
    /// void __cdecl RenderUI::RenderObjects()</code>
    /// </summary>
    public static void RenderObjects() => ((delegate* unmanaged[Cdecl]<void>)0x004488A0)();

    /// <summary>Computes the minimal viewport rectangle that encloses all relevant UI elements, clamping it to the current display dimensions.
    /// <code>Offset: 0x00448910
    /// void __cdecl RenderUI::ComputeGameViewport(unsigned int*,unsigned int*,unsigned int*,unsigned int*)</code>
    /// </summary>
    /// <param name="o_X">Receives the X coordinate of the viewport's left edge.</param>
    /// <param name="o_Y">Receives the Y coordinate of the viewport's top edge.</param>
    /// <param name="o_Width">Receives the width of the computed viewport.</param>
    /// <param name="o_Height">Receives the height of the computed viewport.</param>
    public static void ComputeGameViewport(uint* o_X, uint* o_Y, uint* o_Width, uint* o_Height) => ((delegate* unmanaged[Cdecl]<uint*, uint*, uint*, uint*, void>)0x00448910)(o_X, o_Y, o_Width, o_Height);

    /// <summary>Recalculates the clamped position of the UI viewport, updates the rendering system with the new coordinates and size, and notifies other components of the change.
    /// <code>Offset: 0x00448BE0
    /// void __cdecl RenderUI::RecalculateClampedPosition()</code>
    /// </summary>
    public static void RecalculateClampedPosition() => ((delegate* unmanaged[Cdecl]<void>)0x00448BE0)();

    /// <summary>Shuts down the UI system, freeing all control specifications and destroying the surface interface when available.
    /// <code>Offset: 0x00448EA0
    /// void __cdecl RenderUI::Shutdown()</code>
    /// </summary>
    public static void Shutdown() => ((delegate* unmanaged[Cdecl]<void>)0x00448EA0)();

    /// <summary>Removes a UI object from RenderUI’s internal list, decrementing its reference count and invoking cleanup when the count reaches zero.
    /// <code>Offset: 0x00448F20
    /// void __cdecl RenderUI::UnlinkObject(UIObject*)</code>
    /// </summary>
    /// <param name="object">The UI object to unlink from rendering.</param>
    public static void UnlinkObject(ACBindings.Internal.UIObject* object_) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.UIObject*, void>)0x00448F20)(object_);

    /// <summary>Links a UIObject into RenderUI's internal rendering list, maintaining depth‑and‑touch‑time order and incrementing its reference count. If object is nullptr, no action occurs.
    /// <code>Offset: 0x00449320
    /// void __cdecl RenderUI::LinkObject(UIObject*)</code>
    /// </summary>
    /// <param name="object">The UIObject to link; may be null.</param>
    public static void LinkObject(ACBindings.Internal.UIObject* object_) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.UIObject*, void>)0x00449320)(object_);

    /// <summary>Links a UIObject into RenderUI's internal rendering list, inserting it immediately after pExistingObjectToDrawAfter if provided; otherwise adds it to the front of the list. Upon successful link, increases the object's reference count.
    /// <code>Offset: 0x004493D0
    /// void __cdecl RenderUI::LinkObjectAfter(UIObject*,UIObject*)</code>
    /// </summary>
    /// <param name="object">The UIObject to be linked into the render order.</param>
    /// <param name="pExistingObjectToDrawAfter">Optional existing UIObject after which the new object will appear; if null, the new object is inserted at the front of the list.</param>
    public static void LinkObjectAfter(ACBindings.Internal.UIObject* object_, ACBindings.Internal.UIObject* pExistingObjectToDrawAfter) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.UIObject*, ACBindings.Internal.UIObject*, void>)0x004493D0)(object_, pExistingObjectToDrawAfter);
}

