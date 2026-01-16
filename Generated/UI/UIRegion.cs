namespace ACBindings.Internal;


/// <summary>Defines a rectangular area within the user interface that can display graphics, manage input events, and compose hierarchically with parent and child regions.</summary>
public unsafe struct UIRegion : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.UIListener BaseClass_UIListener; // ACBindings.Internal.UIListener

    // Child Types
    public unsafe struct UIRegion_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIListener*, void> UIListener_dtor_0; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIListener*, ACBindings.Internal.InputEvent*, byte> OnAction; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIListener*, uint, uint, uint, ACBindings.Internal.CallbackLoseFocusResult> OnLoseFocus; // function pointer
        public fixed byte gapC[4];
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIListener*, uint, ACBindings.Internal.UIElement*, uint, int, ACBindings.Internal.UIElementMessageListenResult> ListenToElementMessage; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIListener*, uint, int, void> ListenToGlobalMessage; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, byte, void> SetVisible; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, byte, void> SetShouldBlockClicks; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, byte, void> SetShouldEraseBackground; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, uint, void> SetClampGameViewEdge; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, byte> CheckOverOverride; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, int, int, void> MoveTo; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, int, int, void> ResizeTo; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, ACBindings.Internal.Box2D*, ACBindings.Internal.Box2D*> GetSurfaceBox; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, ACBindings.Internal.UIRegion*, int> CompareZLevel; // function pointer
        public System.IntPtr DrawHere;
        public System.IntPtr EraseSelf;
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, ACBindings.Internal.UIRegion*, void> SetParent; // function pointer
        public fixed byte gap48[4];
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, int, int, void> MouseMove; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, byte, void> MouseOver; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, byte, void> MouseOverTop; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, int, int, byte> MouseHover; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, void> MouseUnhover; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, uint, uint, uint, void> MouseDown; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, uint, uint, uint, void> MouseUp; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, byte> HasCursor; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, ACBindings.Internal.UIRegion*, void> AddChild; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, ACBindings.Internal.UIRegion*, void> RemoveChild; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, void> DrawStart; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, ACBindings.Internal.Box2D*, ACBindings.Internal.UISurface*, void> EraseBackground; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, ACBindings.Internal.Box2D*, ACBindings.Internal.UISurface*, void> PreBlit; // function pointer
        public System.IntPtr DrawSelf;
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, ACBindings.Internal.Box2D*, ACBindings.Internal.UISurface*, void> PostBlit; // function pointer
        public System.IntPtr DrawChildren;
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, void> DrawDone; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, uint, uint, uint, void> MouseTap; // function pointer

        // Methods
    }

    // Members
    public ACBindings.Internal.Box2D m_box;
    public ACBindings.Internal.tagPOINT m_ptTilingOffset;
    public int m_zlevel;
    public ACBindings.Internal.Graphic* m_image;
    public ACBindings.Internal.Graphic* m_alphaImage;
    public float m_alphaBlendMod;
    public sbyte _bf_a4;
    public fixed byte _padding_a5[3];
    public ACBindings.Internal.BlitMode m_eBlitMode;
    public ACBindings.Internal.UIRegion* m_parent;
    public ACBindings.Internal.UIObject* m_object;
    public ACBindings.Internal.HashList___UIRegion_ptr___UIRegion_ptr m_children;
    public ACBindings.Internal.HashSet__uint m_mouseDownTable;

    // Generated Constructor
    public UIRegion(ACBindings.Internal.UIRegion* parent, int x, int y, int width, int height) {
        _ConstructorInternal(parent, x, y, width, height);
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>Returns the first non‑null UIObject stored in this region or any of its parent regions, walking up the hierarchy until an object is found.
    /// <code>Offset: 0x004592B0
    /// UIObject* __thiscall UIRegion::GetObjectA(UIRegion*)</code>
    /// </summary>
    /// <returns>A pointer to the found UIObject, or nullptr if no object exists in the region chain.</returns>
    public ACBindings.Internal.UIObject* GetObjectA() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIRegion, ACBindings.Internal.UIObject*>)0x004592B0)(ref this);

    /// <summary>Updates the region’s internal mouse‑over flag based on whether the cursor currently hovers it.
    /// <code>Offset: 0x0045F970
    /// void __thiscall UIRegion::MouseOver(UIRegion*,bool)</code>
    /// </summary>
    /// <param name="over">True when the mouse is over the region; false otherwise.</param>
    public void MouseOver(byte over) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIRegion, byte, void>)0x0045F970)(ref this, over);

    /// <summary>Updates the region’s mouse‑over‑top state based on the supplied flag.
    /// <code>Offset: 0x0045F990
    /// void __thiscall UIRegion::MouseOverTop(UIRegion*,bool)</code>
    /// </summary>
    /// <param name="overTop">True when the pointer is over the top side of the region, false otherwise.</param>
    public void MouseOverTop(byte overTop) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIRegion, byte, void>)0x0045F990)(ref this, overTop);

    /// <summary>Enables or disables tooltip display for this UI region.
    /// <code>Offset: 0x0045F9B0
    /// void __thiscall UIRegion::SetTooltipOn(UIRegion*,bool)</code>
    /// </summary>
    /// <param name="on">True to enable tooltips on hover, false to disable them.</param>
    public void SetTooltipOn(byte on) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIRegion, byte, void>)0x0045F9B0)(ref this, on);

    /// <summary>Checks whether a specified mouse button is currently pressed within this UI region.
    /// <code>Offset: 0x004637F0
    /// bool __thiscall UIRegion::IsMouseDown(UIRegion*,unsigned int)</code>
    /// </summary>
    /// <param name="button">Identifier of the mouse button to query (e.g., left, right).</param>
    /// <returns>True if the button is down; otherwise, false.</returns>
    public byte IsMouseDown(uint button) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIRegion, uint, byte>)0x004637F0)(ref this, button);

    /// <summary>Sets whether the region clears its background before rendering.
    /// <code>Offset: 0x00464A80
    /// void __thiscall UIRegion::SetShouldEraseBackground(UIRegion*,bool)</code>
    /// </summary>
    /// <param name="i_bErase">True to enable background erasure; false to retain the existing background.</param>
    public void SetShouldEraseBackground(byte i_bErase) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIRegion, byte, void>)0x00464A80)(ref this, i_bErase);

    /// <summary>Releases the UIRegion's alpha image, freeing its resources.
    /// <code>Offset: 0x0069FBD0
    /// void __thiscall UIRegion::ClearAlphaImage(UIRegion*)</code>
    /// </summary>
    public void ClearAlphaImage() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIRegion, void>)0x0069FBD0)(ref this);

    /// <summary>Erases the specified rectangular area of the surface, clearing it to a transparent (null) color.
    /// <code>Offset: 0x0069FBF0
    /// void __thiscall UIRegion::EraseBackground(UIRegion*,const Box2D*,UISurface*)</code>
    /// </summary>
    /// <param name="i_boxObject">The rectangle defining the region to clear on the surface.</param>
    /// <param name="i_pSurface">The surface onto which the background will be erased.</param>
    public void EraseBackground(ACBindings.Internal.Box2D* i_boxObject, ACBindings.Internal.UISurface* i_pSurface) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIRegion, ACBindings.Internal.Box2D*, ACBindings.Internal.UISurface*, void>)0x0069FBF0)(ref this, i_boxObject, i_pSurface);

    /// <summary>Configures whether mouse click events are blocked by this region.
    /// <code>Offset: 0x0069FC50
    /// void __thiscall UIRegion::SetShouldBlockClicks(UIRegion*,bool)</code>
    /// </summary>
    /// <param name="i_bBlockClicks">True to block clicks from reaching underlying UI elements; false to allow them through.</param>
    public void SetShouldBlockClicks(byte i_bBlockClicks) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIRegion, byte, void>)0x0069FC50)(ref this, i_bBlockClicks);

    /// <summary>Configures the region to clamp its position to a specified edge of the game view. If the region is attached to a UI object, that object's clamp setting is updated and the UI layout is recalculated; otherwise the request propagates up to the parent region.
    /// <code>Offset: 0x0069FC70
    /// void __thiscall UIRegion::SetClampGameViewEdge(UIRegion*,unsigned int)</code>
    /// </summary>
    /// <param name="i_eEdge">The edge identifier to which the region should be clamped (e.g., left, right, top, bottom).</param>
    public void SetClampGameViewEdge(uint i_eEdge) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIRegion, uint, void>)0x0069FC70)(ref this, i_eEdge);

    /// <summary>Brings the region to the top of its parent’s child list, ensuring it renders above all sibling regions.
    /// <code>Offset: 0x0069FCA0
    /// void __thiscall UIRegion::BringToFront(UIRegion*)</code>
    /// </summary>
    public void BringToFront() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIRegion, void>)0x0069FCA0)(ref this);

    /// <summary>Determines whether a point given in the region’s parent coordinates falls inside the region’s bounds, optionally checking for non‑transparent pixels via the alpha image.
    /// <code>Offset: 0x0069FCC0
    /// bool __thiscall UIRegion::PointIsOverRegion(UIRegion*,int,int)</code>
    /// </summary>
    /// <param name="i_xParent">X coordinate of the point relative to the region’s parent.</param>
    /// <param name="i_yParent">Y coordinate of the point relative to the region’s parent.</param>
    /// <returns>True if the point lies within the bounding box and, when an alpha image is present, over a non‑transparent area; otherwise false.</returns>
    public byte PointIsOverRegion(int i_xParent, int i_yParent) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIRegion, int, int, byte>)0x0069FCC0)(ref this, i_xParent, i_yParent);

    /// <summary>Notifies the UIRegion of a mouse move event by forwarding the window coordinates to its listener.
    /// <code>Offset: 0x0069FD20
    /// void __thiscall UIRegion::NotifyMouseMove(UIRegion*,int,int)</code>
    /// </summary>
    /// <param name="xWindow">The horizontal position of the mouse within the window.</param>
    /// <param name="yWindow">The vertical position of the mouse within the window.</param>
    public void NotifyMouseMove(int xWindow, int yWindow) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIRegion, int, int, void>)0x0069FD20)(ref this, xWindow, yWindow);

    /// <summary>Notifies the UI system that a mouse tap occurred within this region at coordinates (x, y) with the specified mouse button.
    /// <code>Offset: 0x0069FD30
    /// void __thiscall UIRegion::NotifyMouseTap(UIRegion*,unsigned int,unsigned int,unsigned int)</code>
    /// </summary>
    /// <param name="x">The x-coordinate of the tap relative to the region.</param>
    /// <param name="y">The y-coordinate of the tap relative to the region.</param>
    /// <param name="button">The mouse button that generated the tap event.</param>
    public void NotifyMouseTap(uint x, uint y, uint button) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIRegion, uint, uint, uint, void>)0x0069FD30)(ref this, x, y, button);

    /// <summary>Computes the absolute left‑edge X coordinate of a UIRegion by summing its local box offset with those of its ancestors, returning 0 if the region contains an object or has no parent.
    /// <code>Offset: 0x0069FD40
    /// int __thiscall UIRegion::GetObjectX0(UIRegion*)</code>
    /// </summary>
    /// <returns>The accumulated X coordinate relative to the root region, or zero when the region is a leaf with an attached object or has no parent.</returns>
    public int GetObjectX0() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIRegion, int>)0x0069FD40)(ref this);

    /// <summary>Computes the vertical offset of a region’s object by summing the y‑coordinates of its parent regions until an ancestor containing an object is reached.
    /// <code>Offset: 0x0069FD70
    /// int __thiscall UIRegion::GetObjectY0(UIRegion*)</code>
    /// </summary>
    /// <returns>The cumulative Y0 value relative to the nearest ancestor with an object, or zero if no such ancestor exists.</returns>
    public int GetObjectY0() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIRegion, int>)0x0069FD70)(ref this);

    /// <summary>Determines the on-screen bounding rectangle of the region’s UIObject and writes it into a supplied Box2D structure.
    /// <code>Offset: 0x0069FDA0
    /// Box2D* __thiscall UIRegion::GetSurfaceBox(UIRegion*,Box2D*)</code>
    /// </summary>
    /// <param name="result">Pre‑allocated Box2D to receive the coordinates.</param>
    /// <returns>The same Box2D pointer that was passed in, with m_x0/m_y0 set to 0 and m_x1/m_y1 containing the object’s width – 1 and height – 1; if no UIObject is attached, m_x1 and m_y1 are –1.</returns>
    public ACBindings.Internal.Box2D* GetSurfaceBox(ACBindings.Internal.Box2D* result) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIRegion, ACBindings.Internal.Box2D*, ACBindings.Internal.Box2D*>)0x0069FDA0)(ref this, result);

    /// <summary>Retrieves the leftmost X coordinate of this region in screen space.
    /// <code>Offset: 0x0069FE00
    /// int __thiscall UIRegion::GetScreenX0(UIRegion*)</code>
    /// </summary>
    /// <returns>The screen X position of the region’s left edge, calculated from its associated UIObject or, if none, by adding this region’s local x0 to its parent’s screen X0 recursively. Returns 0 when no parent exists.</returns>
    public int GetScreenX0() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIRegion, int>)0x0069FE00)(ref this);

    /// <summary>Returns the screen‑space Y coordinate of the region’s top edge, taking into account an attached UIObject or the accumulated y offsets of ancestor regions.
    /// <code>Offset: 0x0069FE30
    /// int __thiscall UIRegion::GetScreenY0(UIRegion*)</code>
    /// </summary>
    /// <returns>The computed Y position in screen coordinates (0 when no object and no parent).</returns>
    public int GetScreenY0() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIRegion, int>)0x0069FE30)(ref this);

    /// <summary>Returns the width of the UIRegion in pixels.
    /// <code>Offset: 0x0069FE60
    /// int __thiscall UIRegion::GetWidth(UIRegion*)</code>
    /// </summary>
    /// <returns>The number of horizontal units spanning from the left to the right edge, inclusive.</returns>
    public int GetWidth() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIRegion, int>)0x0069FE60)(ref this);

    /// <summary>Computes and returns the height of the region in pixels based on its bounding box coordinates.
    /// <code>Offset: 0x0069FE70
    /// int __thiscall UIRegion::GetHeight(UIRegion*)</code>
    /// </summary>
    /// <returns>The height as an integer.</returns>
    public int GetHeight() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIRegion, int>)0x0069FE70)(ref this);

    /// <summary>Compares the z‑level of this region with another and indicates relative ordering.
    /// <code>Offset: 0x0069FE80
    /// int __thiscall UIRegion::CompareZLevel(UIRegion*,const UIRegion*)</code>
    /// </summary>
    /// <param name="i_pRegion">The UIRegion to compare against.</param>
    /// <returns>1 if this region has a higher z‑level, 0 if equal, -1 if lower.</returns>
    public int CompareZLevel(ACBindings.Internal.UIRegion* i_pRegion) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIRegion, ACBindings.Internal.UIRegion*, int>)0x0069FE80)(ref this, i_pRegion);

    /// <summary>Sets the UI region's alpha mask to the graphic identified by the supplied data ID, replacing any existing mask.
    /// <code>Offset: 0x0069FEB0
    /// Graphic* __thiscall UIRegion::SetAlphaImageByDID(_DWORD*,unsigned int)</code>
    /// </summary>
    /// <param name="a2">Data identifier of the graphic resource to use as the new alpha mask.</param>
    /// <returns>A pointer to the newly created Graphic object, or nullptr if allocation fails.</returns>
    public ACBindings.Internal.Graphic* SetAlphaImageByDID(uint a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIRegion, uint, ACBindings.Internal.Graphic*>)0x0069FEB0)(ref this, a2);

    /// <summary>Marks a sub‑region of this UIRegion as dirty so the visual system knows it must be redrawn, propagating the change up to the owning object or parent region.
    /// <code>Offset: 0x0069FF00
    /// void __thiscall UIRegion::AddDirtyRect(UIRegion*,const Box2D*)</code>
    /// </summary>
    /// <param name="rect">The rectangle (in local coordinates) that should be marked dirty; only the part intersecting the region is considered.</param>
    public void AddDirtyRect(ACBindings.Internal.Box2D* rect) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIRegion, ACBindings.Internal.Box2D*, void>)0x0069FF00)(ref this, rect);

    /// <summary>Iterates over a collection referenced by <paramref name="a4"/> and invokes an erasing routine on each element, forwarding the supplied <paramref name="a5"/> value to that routine.
    /// <code>Offset: 0x0069FFE0
    /// int __thiscall UIRegion::EraseSelf(void*,int,int,_DWORD*,int)</code>
    /// </summary>
    /// <param name="a2">Reserved for future use; not used in this implementation.</param>
    /// <param name="a3">Reserved for future use; not used in this implementation.</param>
    /// <param name="a4">Pointer to an array where the third element specifies the count of items and the first element is a base pointer used as the address for each item during erasure.</param>
    /// <param name="a5">Parameter passed to the erase routine for each item, typically representing flags or additional context.</param>
    /// <returns>Result code from the last invoked erase operation; if no items are present, the return value is undefined.</returns>
    public int EraseSelf(int a2, int a3, int* a4, int a5) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIRegion, int, int, int*, int, int>)0x0069FFE0)(ref this, a2, a3, a4, a5);

    /// <summary>Renders the UIRegion’s image onto the supplied surface using its current bounds, blit mode and alpha blend settings.
    /// <code>Offset: 0x006A0020
    /// void __thiscall UIRegion::DrawSelf(int,Box2D*,int,_DWORD*,UISurface*)</code>
    /// </summary>
    /// <param name="bounds">The bounding rectangle for this draw call.</param>
    /// <param name="a3">Unused in the rendering logic; present for compatibility with the original API.</param>
    /// <param name="a4">Pointer to an array of Box2D structures that define child element bounds. The first element points to the data, and index 2 holds the count of elements.</param>
    /// <param name="surface">The UISurface onto which the region is drawn.</param>
    public void DrawSelf(ACBindings.Internal.Box2D* bounds, int a3, int* a4, ACBindings.Internal.UISurface* surface) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIRegion, ACBindings.Internal.Box2D*, int, int*, ACBindings.Internal.UISurface*, void>)0x006A0020)(ref this, bounds, a3, a4, surface);

    /// <summary>Computes the absolute bounding box of a UI region's object, taking nested parent offsets into account, and writes it into the supplied Box2D structure.
    /// <code>Offset: 0x006A0100
    /// Box2D* __thiscall UIRegion::GetObjectBox(UIRegion*,Box2D*)</code>
    /// </summary>
    /// <param name="result">Box2D instance to receive the calculated coordinates.</param>
    /// <returns>Pointer to the result box containing the object's global bounds.</returns>
    public ACBindings.Internal.Box2D* GetObjectBox(ACBindings.Internal.Box2D* result) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIRegion, ACBindings.Internal.Box2D*, ACBindings.Internal.Box2D*>)0x006A0100)(ref this, result);

    /// <summary>Computes the absolute screen X position of this UIRegion’s right edge, factoring in any parent region and attached object.
    /// <code>Offset: 0x006A0190
    /// int __thiscall UIRegion::GetScreenX1(UIRegion*)</code>
    /// </summary>
    /// <returns>The screen X coordinate corresponding to the region's x1 value.</returns>
    public int GetScreenX1() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIRegion, int>)0x006A0190)(ref this);

    /// <summary>Returns the screen Y coordinate of this region’s bottom edge, taking into account its own position, any associated UIObject offset, and parent hierarchy.
    /// <code>Offset: 0x006A01E0
    /// int __thiscall UIRegion::GetScreenY1(UIRegion*)</code>
    /// </summary>
    /// <returns>The absolute Y position in screen coordinates of the region’s lower boundary.</returns>
    public int GetScreenY1() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIRegion, int>)0x006A01E0)(ref this);

    /// <summary>Computes the effective clip rectangle for a UI region by combining its own bounds—or those inherited from a parent—with the bounds of its visual object, storing the intersection in the supplied Box2D structure.
    /// <code>Offset: 0x006A0240
    /// Box2D* __thiscall UIRegion::GetClipBox(UIRegion*,Box2D*)</code>
    /// </summary>
    /// <param name="result">The Box2D that will receive the computed clipping rectangle; if no intersection occurs, it is set to an empty box (x0 = 0, y0 = 0, x1 = -1, y1 = -1).</param>
    /// <returns>A pointer to the provided result Box2D.</returns>
    public ACBindings.Internal.Box2D* GetClipBox(ACBindings.Internal.Box2D* result) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIRegion, ACBindings.Internal.Box2D*, ACBindings.Internal.Box2D*>)0x006A0240)(ref this, result);

    /// <summary>Computes the region's screen clipping rectangle by combining its local clip bounds with any parent offsets and virtual position adjustments, storing the result in the supplied Box2D structure.
    /// <code>Offset: 0x006A0340
    /// Box2D* __thiscall UIRegion::GetScreenClipBox(UIRegion*,Box2D*)</code>
    /// </summary>
    /// <param name="result">Pointer to a Box2D where the calculated screen coordinates will be written.</param>
    /// <returns>Returns the same Box2D pointer passed in after filling it with the computed screen clip box.</returns>
    public ACBindings.Internal.Box2D* GetScreenClipBox(ACBindings.Internal.Box2D* result) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIRegion, ACBindings.Internal.Box2D*, ACBindings.Internal.Box2D*>)0x006A0340)(ref this, result);

    /// <summary>Flags the region for redrawing by dispatching an action callback and registering its bounding rectangle as dirty.
    /// <code>Offset: 0x006A0430
    /// void __thiscall UIRegion::MakeRootDirtyHere(UIRegion*)</code>
    /// </summary>
    public void MakeRootDirtyHere() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIRegion, void>)0x006A0430)(ref this);

    /// <summary>Sets the UI region's alpha blending modifier, clamping the supplied value to the range 0–1 and updating the region if the new value differs from the current one.
    /// <code>Offset: 0x006A0460
    /// void __thiscall UIRegion::SetAlphaBlendMod(UIRegion*,float)</code>
    /// </summary>
    /// <param name="mod">The desired blend factor; values below 0 are treated as 0, above 1 as 1.</param>
    public void SetAlphaBlendMod(float mod) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIRegion, float, void>)0x006A0460)(ref this, mod);

    /// <summary>Reassigns the region's parent to the specified region, notifying listeners of the change and marking the region as needing redraw.
    /// <code>Offset: 0x006A04E0
    /// void __thiscall UIRegion::SetParent(UIRegion*,UIRegion*)</code>
    /// </summary>
    /// <param name="parent">The new parent region; may be null.</param>
    public void SetParent(ACBindings.Internal.UIRegion* parent) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIRegion, ACBindings.Internal.UIRegion*, void>)0x006A04E0)(ref this, parent);

    /// <summary>Sets the blit mode for this UI region, updating internal state and notifying listeners when changed.
    /// <code>Offset: 0x006A0570
    /// void __thiscall UIRegion::SetBlitMode(UIRegion*,BlitMode)</code>
    /// </summary>
    /// <param name="i_eBlitMode">The desired blit mode to apply.</param>
    public void SetBlitMode(ACBindings.Internal.BlitMode i_eBlitMode) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIRegion, ACBindings.Internal.BlitMode, void>)0x006A0570)(ref this, i_eBlitMode);

    /// <summary>Sets the tiling offset for this region and notifies listeners when the offset changes.
    /// <code>Offset: 0x006A05B0
    /// void __thiscall UIRegion::SetTilingOffset(UIRegion*,const tagPOINT*)</code>
    /// </summary>
    /// <param name="i_pt">The new tiling offset to apply.</param>
    public void SetTilingOffset(ACBindings.Internal.tagPOINT* i_pt) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIRegion, ACBindings.Internal.tagPOINT*, void>)0x006A05B0)(ref this, i_pt);

    /// <summary>Assigns a new graphic to the UI region, releasing any previous graphic and marking the region as needing redraw.
    /// <code>Offset: 0x006A0610
    /// void __thiscall UIRegion::SetImage(UIRegion*,Graphic*)</code>
    /// </summary>
    /// <param name="image">The graphic to display in this region; may be nullptr to clear the image.</param>
    public void SetImage(ACBindings.Internal.Graphic* image) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIRegion, ACBindings.Internal.Graphic*, void>)0x006A0610)(ref this, image);

    /// <summary>Removes the current image from the region, destroying it if present, and marks the area as dirty for redrawing.
    /// <code>Offset: 0x006A0660
    /// void __thiscall UIRegion::ClearImage(UIRegion*)</code>
    /// </summary>
    public void ClearImage() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIRegion, void>)0x006A0660)(ref this);

    /// <summary>Moves the UI region to the specified coordinates, updating its bounding box while preserving size and marking the affected area for redrawing.
    /// <code>Offset: 0x006A06B0
    /// void __thiscall UIRegion::MoveTo(UIRegion*,const int,const int)</code>
    /// </summary>
    /// <param name="x">The new X coordinate of the region's top-left corner.</param>
    /// <param name="y">The new Y coordinate of the region's top-left corner.</param>
    public void MoveTo(int x, int y) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIRegion, int, int, void>)0x006A06B0)(ref this, x, y);

    /// <summary>Resizes the UI region to the specified width and height, updating its bounding box and notifying listeners of any dimension changes.
    /// <code>Offset: 0x006A0740
    /// void __thiscall UIRegion::ResizeTo(UIRegion*,const int,const int)</code>
    /// </summary>
    /// <param name="width">Desired width in pixels.</param>
    /// <param name="height">Desired height in pixels.</param>
    public void ResizeTo(int width, int height) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIRegion, int, int, void>)0x006A0740)(ref this, width, height);

    /// <summary>Changes the UIRegion's displayed image to the graphic identified by the specified DID, updates its blitting mode, and marks the region for redrawing.
    /// <code>Offset: 0x006A07E0
    /// void __thiscall UIRegion::SetImageByDID(UIRegion*,unsigned int,int)</code>
    /// </summary>
    /// <param name="imageDID">The data identifier of the new graphic resource.</param>
    /// <param name="blitMode">Specifies the blending behavior: 2 selects Blit_3Alpha, 3 selects Blit_4Alpha; any other value defaults to normal blitting.</param>
    public void SetImageByDID(uint a2, int a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIRegion, uint, int, void>)0x006A07E0)(ref this, a2, a3);

    /// <summary>Renders the UI region and its children within a specified clipping rectangle, applying translation from the supplied position array and handling visibility flags.
    /// <code>Offset: 0x006A08B0
    /// void __thiscall UIRegion::DrawHere(_DWORD*,int*,Box2D*,_DWORD*,int)</code>
    /// </summary>
    /// <param name="a2">Array of integers containing positional data used to translate the region when rendering.</param>
    /// <param name="a3">Box2D defining the clipping rectangle that limits where the region may be drawn.</param>
    /// <param name="a4">Array whose second element holds a count of child bounds; each subsequent entry represents a Box2D for a child region and is used to determine intersections with the clip box.</param>
    /// <param name="a5">Depth or flag controlling recursion and drawing phases, typically non‑zero when rendering is active.</param>
    public void DrawHere(int* a2, ACBindings.Internal.Box2D* a3, int* a4, int a5) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIRegion, int*, ACBindings.Internal.Box2D*, int*, int, void>)0x006A08B0)(ref this, a2, a3, a4, a5);

    /// <summary>Draws child UIRegion objects that intersect a specified clipping rectangle, applying an offset and passing additional parameters to each child's draw routine.
    /// <code>Offset: 0x006A0B20
    /// int __thiscall UIRegion::DrawChildren(_DWORD*,_DWORD*,Box2D*,int,int)</code>
    /// </summary>
    /// <param name="a2">Array containing X and Y offsets applied to each child region's bounds before intersection testing.</param>
    /// <param name="a3">Clipping rectangle; only children whose bounding boxes intersect this box are drawn.</param>
    /// <param name="a4">First drawing parameter forwarded to child regions.</param>
    /// <param name="a5">Second drawing parameter forwarded to child regions.</param>
    /// <returns>Zero on successful completion.</returns>
    public int DrawChildren(int* a2, ACBindings.Internal.Box2D* a3, int a4, int a5) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIRegion, int*, ACBindings.Internal.Box2D*, int, int, int>)0x006A0B20)(ref this, a2, a3, a4, a5);

    /// <summary>Force updates the region’s state based on supplied flags: refreshes its associated object, marks the area dirty for repainting, and recursively propagates these actions to all child regions.
    /// <code>Offset: 0x006A0C10
    /// void __thiscall UIRegion::ForceUpdate(UIRegion*,unsigned int)</code>
    /// </summary>
    /// <param name="i_updateFlags">Bitmask controlling the update operations: bit 0 (value 1) triggers a redraw by calling OnAction and adding a dirty rectangle; bit 1 (value 2) updates the attached UIObject; bit 2 (value 4) forces the same update on all child regions.</param>
    public void ForceUpdate(uint i_updateFlags) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIRegion, uint, void>)0x006A0C10)(ref this, i_updateFlags);

    /// <summary>Notifies the region that a mouse button was pressed at the specified window coordinates, dispatching the event to registered listeners according to the button state and internal flags.
    /// <code>Offset: 0x006A0CA0
    /// void __thiscall UIRegion::NotifyMouseDown(UIRegion*,unsigned int,unsigned int,unsigned int)</code>
    /// </summary>
    /// <param name="this">The UIRegion instance receiving the notification.</param>
    /// <param name="xWindow">X coordinate of the mouse within the application window.</param>
    /// <param name="yWindow">Y coordinate of the mouse within the application window.</param>
    /// <param name="button">Identifier of the mouse button that was pressed (e.g., left, right, middle or extended buttons).</param>
    public void NotifyMouseDown(uint xWindow, uint yWindow, uint button) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIRegion, uint, uint, uint, void>)0x006A0CA0)(ref this, xWindow, yWindow, button);

    /// <summary>Notifies the region’s listeners when a mouse button is released, but only if that button was previously registered as pressed.
    /// <code>Offset: 0x006A0D00
    /// void __thiscall UIRegion::NotifyMouseUp(UIRegion*,unsigned int,unsigned int,unsigned int)</code>
    /// </summary>
    /// <param name="xWindow">The X coordinate of the mouse in window space at release time.</param>
    /// <param name="yWindow">The Y coordinate of the mouse in window space at release time.</param>
    /// <param name="button">Identifier for the released mouse button (e.g., left, right).</param>
    public void NotifyMouseUp(uint xWindow, uint yWindow, uint button) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIRegion, uint, uint, uint, void>)0x006A0D00)(ref this, xWindow, yWindow, button);

    /// <summary>Changes a UI region’s visibility, updating its rendering state and notifying listeners when the status changes.
    /// <code>Offset: 0x006A0D50
    /// void __thiscall UIRegion::SetVisible(UIRegion*,bool)</code>
    /// </summary>
    /// <param name="visible">The desired visibility flag for the region.</param>
    public void SetVisible(byte visible) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIRegion, byte, void>)0x006A0D50)(ref this, visible);

    /// <summary>Records a mouse‑down event for this region by storing the pressed button in its internal table.
    /// <code>Offset: 0x006A0EA0
    /// void __thiscall UIRegion::MouseDown(UIRegion*,unsigned int,unsigned int,unsigned int)</code>
    /// </summary>
    /// <param name="xWindow">X coordinate of the cursor within the window when the button was pressed.</param>
    /// <param name="yWindow">Y coordinate of the cursor within the window when the button was pressed.</param>
    /// <param name="button">Identifier of the mouse button that was pressed.</param>
    public void MouseDown(uint xWindow, uint yWindow, uint button) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIRegion, uint, uint, uint, void>)0x006A0EA0)(ref this, xWindow, yWindow, button);

    /// <summary>Removes the specified mouse button from the region's active mouse‑down table when released.
    /// <code>Offset: 0x006A0EC0
    /// void __thiscall UIRegion::MouseUp(UIRegion*,unsigned int,unsigned int,unsigned int)</code>
    /// </summary>
    /// <param name="xWindow">Horizontal pixel coordinate of the cursor within the window at release time.</param>
    /// <param name="yWindow">Vertical pixel coordinate of the cursor within the window at release time.</param>
    /// <param name="button">Identifier of the mouse button that was released.</param>
    public void MouseUp(uint xWindow, uint yWindow, uint button) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIRegion, uint, uint, uint, void>)0x006A0EC0)(ref this, xWindow, yWindow, button);

    /// <summary>Creates a UIRegion at position (x, y) with the specified width and height, initializing visual and interaction properties to default values.
    /// <code>Offset: 0x006A0F70
    /// void __thiscall UIRegion::UIRegion(UIRegion*,UIRegion*,int,int,int,int)</code>
    /// </summary>
    /// <param name="parent">Ignored; the new region’s m_parent is always set to null.</param>
    /// <param name="x">Left coordinate of the region relative to its parent.</param>
    /// <param name="y">Top coordinate of the region relative to its parent.</param>
    /// <param name="width">Width in pixels.</param>
    /// <param name="height">Height in pixels.</param>
    public void _ConstructorInternal(ACBindings.Internal.UIRegion* parent, int x, int y, int width, int height) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIRegion, ACBindings.Internal.UIRegion*, int, int, int, int, void>)0x006A0F70)(ref this, parent, x, y, width, height);

    /// <summary>Deterministically destroys a UIRegion instance, releasing owned graphics, decrementing the reference count of its associated UIObject if necessary, clearing child regions, removing mouse‑down entries, detaching from any parent region, and cleaning up event listener state.
    /// <code>Offset: 0x006A1070
    /// void __thiscall UIRegion::~UIRegion(UIRegion*)</code>
    /// </summary>
    /// <param name="this">The UIRegion object being destroyed.</param>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIRegion, void>)0x006A1070)(ref this);

    /// <summary>Removes the specified child region from this region’s child hierarchy and deallocates its list node.
    /// <code>Offset: 0x006A1150
    /// void __thiscall UIRegion::RemoveChild(UIRegion*,UIRegion*)</code>
    /// </summary>
    /// <param name="child">The child UIRegion to detach from the parent.</param>
    public void RemoveChild(ACBindings.Internal.UIRegion* child) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIRegion, ACBindings.Internal.UIRegion*, void>)0x006A1150)(ref this, child);

    /// <summary>Adds a UIRegion instance as a child of this region, inserting it into the children collection in order based on its comparison criteria.
    /// <code>Offset: 0x006A1580
    /// void __thiscall UIRegion::AddChild(UIRegion*,UIRegion*)</code>
    /// </summary>
    /// <param name="child">The UIRegion to attach as a child to the current region.</param>
    public void AddChild(ACBindings.Internal.UIRegion* child) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIRegion, ACBindings.Internal.UIRegion*, void>)0x006A1580)(ref this, child);

    /// <summary>Repositions the specified child region within its parent’s child list so that rendering follows its z‑level order, effectively bringing it to the front relative to other siblings.
    /// <code>Offset: 0x006A1610
    /// void __thiscall UIRegion::BringToFront(UIRegion*,UIRegion*)</code>
    /// </summary>
    /// <param name="child">The UIRegion to reposition among the parent’s children.</param>
    public void BringToFront(ACBindings.Internal.UIRegion* child) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIRegion, ACBindings.Internal.UIRegion*, void>)0x006A1610)(ref this, child);
}

