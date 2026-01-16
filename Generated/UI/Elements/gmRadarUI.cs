namespace ACBindings.Internal;


/// <summary>Manages the radar user interface, rendering nearby objects, compass tokens, coordinates, and handling lock/drag interactions.</summary>
public unsafe struct gmRadarUI : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.UIElement_Field BaseClass_UIElement_Field; // ACBindings.Internal.UIElement_Field
    public ACBindings.Internal.gmNoticeHandler BaseClass_gmNoticeHandler; // ACBindings.Internal.gmNoticeHandler
    public ACBindings.Internal.QualityChangeHandler BaseClass_QualityChangeHandler; // ACBindings.Internal.QualityChangeHandler

    // Child Types
    public unsafe struct gmRadarUI_vtbl
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
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, uint, ACBindings.Internal.UIElement*> DynamicCast; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, uint> GetUIElementType; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, uint, byte> SetState; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, ACBindings.Internal.UIElement*> GetParent; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, uint, ACBindings.Internal.UIElement*> GetAncestorByID; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, uint, byte> KeyUp; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, uint, float, byte> KeyDown; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, int, byte> RegisterInputMaps; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, byte> UnregisterInputMaps; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, ACBindings.Internal.UIElement*, ACBindings.Internal.InputEvent*, byte> OnChildAction; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, void> Initialize; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, void> PostInit; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, ACBindings.Internal.AvailablePropertySet*, byte> InqAvailableProperties; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, ACBindings.Internal.BaseProperty*, void> OnSetAttribute; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, uint, byte> ContainsProperty; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, uint, ACBindings.Internal.BaseProperty*, byte> InqProperty; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, ACBindings.Internal.BaseProperty*, byte> SetProperty; // function pointer
        public fixed byte gapD8[4];
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, ACBindings.Internal.UIElement*, ACBindings.Internal.UIElement.FunctionSignatureChanged> CatchDroppedItem; // function pointer
        public fixed byte gapE0[4];
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, ACBindings.Internal.UIElement*, byte, ACBindings.Internal.UIElement.FunctionSignatureChanged> DragAndDropComplete; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, ACBindings.Internal.UIElement**, byte> DragItem; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, ACBindings.Internal.UIElement*, ACBindings.Internal.UIElement*> GetDragAndDropCatcher; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, ACBindings.Internal.UIElement*, void> MatchElement; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, ACBindings.Internal.UIElement*, void> UpdateForChildSizeChange; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, byte, void> UpdateForParentVisibilityChange; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, byte> Activate; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, byte> Deactivate; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, byte> TakeFocus; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, byte> RelinquishFocus; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, byte> GetActivatable; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, byte, void> SetMouseVisible; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, void> UpdateForScreenPositionChange; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, ACBindings.Internal.UIObject*, byte> SetUIObject; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, ACBindings.Internal.UIObject**, byte> MakeUIObject; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, ACBindings.Internal.UIElement*, byte, void> OnChildActivationChanged; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, byte> GetShouldBeMouseVisible; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, ACBindings.Internal.UIElementMessageInfo*, ACBindings.Internal.UIElementMessageListenResult, ACBindings.Internal.UIElementMessageListenResult> ForwardElementMessage; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, ACBindings.Internal.UIElementMessageInfo*, byte> DefElementMessageHandler; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, byte, void> OnVisibilityChanged; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, ACBindings.Internal.UIElement.Intialized_Has_Been_Replaced_With_PostInit> Initialized; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.gmRadarUI*, void> UpdateFromPlayerModule; // function pointer

        // Methods
    }

    // Members
    public float m_fRadarRange;
    public ACBindings.Internal.SmartArray___RadarInfo m_aRadarInfos;
    public uint m_iidObjectUnderMouse;
    public float m_fPlayerHeading;
    public ACBindings.Internal.Vector2 m_vecCenterPoint;
    public int m_nRadarRadius;
    public float m_fNorthTokenMagnitude;
    public float m_fEastTokenMagnitude;
    public float m_fSouthTokenMagnitude;
    public float m_fWestTokenMagnitude;
    public ACBindings.Internal.UIElement* m_pNorthToken;
    public ACBindings.Internal.UIElement* m_pEastToken;
    public ACBindings.Internal.UIElement* m_pSouthToken;
    public ACBindings.Internal.UIElement* m_pWestToken;
    public ACBindings.Internal.UIElement* m_pCoordinateContainerField;
    public ACBindings.Internal.UIElement_Text* m_pCombinedCoordsText;
    public ACBindings.Internal.UIElement_Text* m_pXCoordText;
    public ACBindings.Internal.UIElement_Text* m_pYCoordText;
    public ACBindings.Internal.UIElement* m_pLockUIButton;
    public ACBindings.Internal.UIElement* m_pDragButton;
    public double m_ttNextUpdateTime;
    public double m_fCurXCoord;
    public double m_fCurYCoord;
    public uint m_eWindowID;

    // Generated Constructor
    public gmRadarUI(ACBindings.Internal.LayoutDesc* layout, ACBindings.Internal.ElementDesc* full_desc) {
        _ConstructorInternal(layout, full_desc);
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>Handles specific UI element messages for the radar interface, updating global message registration and toggling the player’s UI lock state based on incoming events.
    /// <code>Offset: 0x004D8210
    /// UIElementMessageListenResult __thiscall gmRadarUI::ListenToElementMessage(gmRadarUI*,const UIElementMessageInfo*)</code>
    /// </summary>
    /// <param name="i_rMsg">Information about the UI element message being processed.</param>
    /// <returns>The result returned by the base class ListenToElementMessage after any radar‑specific handling.</returns>
    public ACBindings.Internal.UIElementMessageListenResult ListenToElementMessage(ACBindings.Internal.UIElementMessageInfo* i_rMsg) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmRadarUI, ACBindings.Internal.UIElementMessageInfo*, ACBindings.Internal.UIElementMessageListenResult>)0x004D8210)(ref this, i_rMsg);

    /// <summary>Locks or unlocks the radar UI according to the current player module state, adjusting the lock button appearance and enabling or disabling dragging functionality.
    /// <code>Offset: 0x004D82E0
    /// void __thiscall gmRadarUI::UpdateLockedStatus(gmRadarUI*)</code>
    /// </summary>
    public void UpdateLockedStatus() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmRadarUI, void>)0x004D82E0)(ref this);

    /// <summary>Determines and writes the radar blip color for a given object into the supplied RGBAColor structure based on its qualities, flags, faction, and fellowship status.
    /// <code>Offset: 0x004D8350
    /// RGBAColor* __cdecl gmRadarUI::GetBlipColor(RGBAColor*,ACCWeenieObject*)</code>
    /// </summary>
    /// <param name="result">Pointer to an RGBAColor structure that receives the calculated color.</param>
    /// <param name="i_obj">Object whose radar representation is being queried; may be null, in which case a default color is returned.</param>
    /// <returns>Same pointer passed as result after it has been populated with the chosen color.</returns>
    public static ACBindings.Internal.RGBAColor* GetBlipColor(ACBindings.Internal.RGBAColor* result, ACBindings.Internal.ACCWeenieObject* i_obj) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.RGBAColor*, ACBindings.Internal.ACCWeenieObject*, ACBindings.Internal.RGBAColor*>)0x004D8350)(result, i_obj);

    /// <summary>Determines the radar blip shape for a given object by evaluating its fellowship, allegiance, and faction relationships with the local player.
    /// <code>Offset: 0x004D87C0
    /// RadarBlipShape __thiscall gmRadarUI::GetBlipShape(gmRadarUI*,ACCWeenieObject*)</code>
    /// </summary>
    /// <param name="i_obj">The object whose blip shape is requested.</param>
    /// <returns>RadarBlipShape value indicating how the object should appear on the radar: 0 if the object is null or hidden; 2 for allied objects; 3 for same‑faction but non‑allied objects; 4 for neutral or unrelated objects; 6 for fellowship members, with an offset if they are the fellowship leader.</returns>
    public ACBindings.Internal.RadarBlipShape GetBlipShape(ACBindings.Internal.ACCWeenieObject* i_obj) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmRadarUI, ACBindings.Internal.ACCWeenieObject*, ACBindings.Internal.RadarBlipShape>)0x004D87C0)(ref this, i_obj);

    /// <summary>Renders a single pixel on the radar surface at the specified coordinates using the given color.
    /// <code>Offset: 0x004D8890
    /// void __thiscall gmRadarUI::DrawPoint(gmRadarUI*,UISurface*,const RGBAColor*,int,int)</code>
    /// </summary>
    /// <param name="i_pSurface">The UI surface to draw on; if null, drawing is skipped.</param>
    /// <param name="color">Color of the point to render.</param>
    /// <param name="x">X coordinate in pixels.</param>
    /// <param name="y">Y coordinate in pixels.</param>
    public void DrawPoint(ACBindings.Internal.UISurface* i_pSurface, ACBindings.Internal.RGBAColor* color, int x, int y) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmRadarUI, ACBindings.Internal.UISurface*, ACBindings.Internal.RGBAColor*, int, int, void>)0x004D8890)(ref this, i_pSurface, color, x, y);

    /// <summary>Draws a cross-shaped marker around the specified coordinates on the supplied surface using the given color. If no surface is provided, the call simply returns without drawing.
    /// <code>Offset: 0x004D88D0
    /// void __thiscall gmRadarUI::DrawEdges(gmRadarUI*,UISurface*,const RGBAColor*,int,int)</code>
    /// </summary>
    /// <param name="i_pSurface">The target rendering surface; if null, drawing is skipped.</param>
    /// <param name="color">Color used for each edge pixel of the marker.</param>
    /// <param name="x">X-coordinate of the center point around which edges are drawn one pixel away.</param>
    /// <param name="y">Y-coordinate of the center point around which edges are drawn one pixel away.</param>
    public void DrawEdges(ACBindings.Internal.UISurface* i_pSurface, ACBindings.Internal.RGBAColor* color, int x, int y) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmRadarUI, ACBindings.Internal.UISurface*, ACBindings.Internal.RGBAColor*, int, int, void>)0x004D88D0)(ref this, i_pSurface, color, x, y);

    /// <summary>Renders four corner markers centered at the specified screen coordinate using the supplied RGBA color on a UI surface.
    /// <code>Offset: 0x004D8980
    /// void __thiscall gmRadarUI::DrawCorners(gmRadarUI*,UISurface*,const RGBAColor*,int,int)</code>
    /// </summary>
    /// <param name="i_pSurface">UI surface onto which corners are drawn; must be valid and initialized before calling.</param>
    /// <param name="color">Color used for the corner markers.</param>
    /// <param name="x">X‑coordinate of the center point for the corner markers.</param>
    /// <param name="y">Y‑coordinate of the center point for the corner markers.</param>
    public void DrawCorners(ACBindings.Internal.UISurface* i_pSurface, ACBindings.Internal.RGBAColor* color, int x, int y) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmRadarUI, ACBindings.Internal.UISurface*, ACBindings.Internal.RGBAColor*, int, int, void>)0x004D8980)(ref this, i_pSurface, color, x, y);

    /// <summary>Draws a single-pixel cross on the radar UI surface at the specified coordinates using the provided color and then draws the surrounding edges.
    /// <code>Offset: 0x004D8A40
    /// void __thiscall gmRadarUI::DrawCross(gmRadarUI*,UISurface*,const RGBAColor*,int,int)</code>
    /// </summary>
    /// <param name="i_pSurface">The UISurface to draw onto; if null, drawing is skipped.</param>
    /// <param name="color">Color of the cross as RGBA values.</param>
    /// <param name="x">X-coordinate on the surface where the cross is centered.</param>
    /// <param name="y">Y-coordinate on the surface where the cross is centered.</param>
    public void DrawCross(ACBindings.Internal.UISurface* i_pSurface, ACBindings.Internal.RGBAColor* color, int x, int y) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmRadarUI, ACBindings.Internal.UISurface*, ACBindings.Internal.RGBAColor*, int, int, void>)0x004D8A40)(ref this, i_pSurface, color, x, y);

    /// <summary>Renders an X-shaped marker at the specified (x, y) location on a UI surface using the provided color.
    /// <code>Offset: 0x004D8A90
    /// void __thiscall gmRadarUI::DrawX(gmRadarUI*,UISurface*,const RGBAColor*,int,int)</code>
    /// </summary>
    /// <param name="this">Reference to the gmRadarUI instance that owns the drawing context.</param>
    /// <param name="i_pSurface">The UI surface onto which the X is drawn.</param>
    /// <param name="color">Color of the X marker.</param>
    /// <param name="x">X coordinate on the surface where the marker should appear.</param>
    /// <param name="y">Y coordinate on the surface where the marker should appear.</param>
    public void DrawX(ACBindings.Internal.UISurface* i_pSurface, ACBindings.Internal.RGBAColor* color, int x, int y) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmRadarUI, ACBindings.Internal.UISurface*, ACBindings.Internal.RGBAColor*, int, int, void>)0x004D8A90)(ref this, i_pSurface, color, x, y);

    /// <summary>Draws a small upward-pointing triangle onto the specified surface at (x, y) using the supplied color.
    /// <code>Offset: 0x004D8AE0
    /// void __thiscall gmRadarUI::DrawTriangle(gmRadarUI*,UISurface*,const RGBAColor*,int,int)</code>
    /// </summary>
    /// <param name="i_pSurface">Rendering target; drawing is suppressed if null.</param>
    /// <param name="color">Color of the triangle pixels.</param>
    /// <param name="x">X coordinate of the triangle’s apex.</param>
    /// <param name="y">Y coordinate of the triangle’s apex.</param>
    public void DrawTriangle(ACBindings.Internal.UISurface* i_pSurface, ACBindings.Internal.RGBAColor* color, int x, int y) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmRadarUI, ACBindings.Internal.UISurface*, ACBindings.Internal.RGBAColor*, int, int, void>)0x004D8AE0)(ref this, i_pSurface, color, x, y);

    /// <summary>Draws a small inverted triangle onto the specified UISurface at coordinates (x, y) using the provided color.
    /// <code>Offset: 0x004D8B90
    /// void __thiscall gmRadarUI::DrawInvertedTriangle(gmRadarUI*,UISurface*,const RGBAColor*,int,int)</code>
    /// </summary>
    /// <param name="i_pSurface">The target surface to render the triangle onto.</param>
    /// <param name="color">Color used to fill the triangle pixels.</param>
    /// <param name="x">Horizontal coordinate of the triangle's bottom vertex.</param>
    /// <param name="y">Vertical coordinate of the triangle's bottom vertex.</param>
    public void DrawInvertedTriangle(ACBindings.Internal.UISurface* i_pSurface, ACBindings.Internal.RGBAColor* color, int x, int y) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmRadarUI, ACBindings.Internal.UISurface*, ACBindings.Internal.RGBAColor*, int, int, void>)0x004D8B90)(ref this, i_pSurface, color, x, y);

    /// <summary>Draws a small cross-shaped selection indicator at the given coordinates on the radar UI surface using the specified RGBA color.
    /// <code>Offset: 0x004D8C40
    /// void __thiscall gmRadarUI::DrawSelected(gmRadarUI*,UISurface*,const RGBAColor*,int,int)</code>
    /// </summary>
    /// <param name="i_pSurface">The UISurface onto which the marker is rendered; if null, no drawing occurs.</param>
    /// <param name="color">Color of the selection indicator.</param>
    /// <param name="x">X coordinate within the surface where the cross is centered.</param>
    /// <param name="y">Y coordinate within the surface where the cross is centered.</param>
    public void DrawSelected(ACBindings.Internal.UISurface* i_pSurface, ACBindings.Internal.RGBAColor* color, int x, int y) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmRadarUI, ACBindings.Internal.UISurface*, ACBindings.Internal.RGBAColor*, int, int, void>)0x004D8C40)(ref this, i_pSurface, color, x, y);

    /// <summary>Moves the radar UI element to the specified coordinates while enforcing bounds within its parent region, then records the new position in the player's chat window options.
    /// <code>Offset: 0x004D8E00
    /// void __thiscall gmRadarUI::MoveTo(gmRadarUI*,const int,const int)</code>
    /// </summary>
    /// <param name="i_x">The desired x‑coordinate for the radar UI.</param>
    /// <param name="i_y">The desired y‑coordinate for the radar UI.</param>
    public void MoveTo(int i_x, int i_y) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmRadarUI, int, int, void>)0x004D8E00)(ref this, i_x, i_y);

    /// <summary>Removes a radar display entry for the specified object and unregisters its notice handlers from the UI.
    /// <code>Offset: 0x004D8FF0
    /// void __thiscall gmRadarUI::RemoveObject(gmRadarUI*,ACCWeenieObject*)</code>
    /// </summary>
    /// <param name="i_pObj">The radar object to remove; if null, no action is taken.</param>
    public void RemoveObject(ACBindings.Internal.ACCWeenieObject* i_pObj) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmRadarUI, ACBindings.Internal.ACCWeenieObject*, void>)0x004D8FF0)(ref this, i_pObj);

    /// <summary>Determines the radar blip color corresponding to the specified object identifier and writes it into the supplied RGBAColor structure.
    /// <code>Offset: 0x004D9070
    /// RGBAColor* __cdecl gmRadarUI::GetBlipColor(RGBAColor*,unsigned int)</code>
    /// </summary>
    /// <param name="result">The RGBAColor structure that will receive the computed color. The function returns this pointer for convenience.</param>
    /// <param name="i_iid">The unique identifier of the game object whose blip color is to be retrieved.</param>
    /// <returns>Pointer to the supplied RGBAColor structure containing the determined color.</returns>
    public static ACBindings.Internal.RGBAColor* GetBlipColor(ACBindings.Internal.RGBAColor* result, uint i_iid) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.RGBAColor*, uint, ACBindings.Internal.RGBAColor*>)0x004D9070)(result, i_iid);

    /// <summary>Draws a hollow radar outline on the specified surface at position (x, y) using the provided color.
    /// <code>Offset: 0x004D9090
    /// void __thiscall gmRadarUI::DrawHollow(gmRadarUI*,UISurface*,const RGBAColor*,int,int)</code>
    /// </summary>
    /// <param name="i_pSurface">Target UI surface for rendering.</param>
    /// <param name="color">Color of the radar outline.</param>
    /// <param name="x">X coordinate where the outline begins.</param>
    /// <param name="y">Y coordinate where the outline begins.</param>
    public void DrawHollow(ACBindings.Internal.UISurface* i_pSurface, ACBindings.Internal.RGBAColor* color, int x, int y) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmRadarUI, ACBindings.Internal.UISurface*, ACBindings.Internal.RGBAColor*, int, int, void>)0x004D9090)(ref this, i_pSurface, color, x, y);

    /// <summary>Draws an X-shaped marker at the specified (x, y) position on the radar surface by rendering four corner pixels around the center after drawing edges and corners.
    /// <code>Offset: 0x004D90D0
    /// void __thiscall gmRadarUI::DrawXBox(gmRadarUI*,UISurface*,const RGBAColor*,int,int)</code>
    /// </summary>
    /// <param name="i_pSurface">The UISurface onto which the radar elements are rendered.</param>
    /// <param name="color">Pointer to an RGBAColor specifying the marker’s color.</param>
    /// <param name="x">X-coordinate of the marker’s central point on the surface.</param>
    /// <param name="y">Y-coordinate of the marker’s central point on the surface.</param>
    public void DrawXBox(ACBindings.Internal.UISurface* i_pSurface, ACBindings.Internal.RGBAColor* color, int x, int y) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmRadarUI, ACBindings.Internal.UISurface*, ACBindings.Internal.RGBAColor*, int, int, void>)0x004D90D0)(ref this, i_pSurface, color, x, y);

    /// <summary>Updates the radar UI based on current player module settings. If a window ID exists and the player system layout has not yet been loaded from file, it queries specific chat window options; when both options are present and valid, it triggers a loss‑of‑focus event with the retrieved values. Finally, it refreshes the UI's lock status.
    /// <code>Offset: 0x004D91A0
    /// void __thiscall gmRadarUI::UpdateFromPlayerModule(gmRadarUI*)</code>
    /// </summary>
    public void UpdateFromPlayerModule() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmRadarUI, void>)0x004D91A0)(ref this);

    /// <summary>Constructs a radar user interface element, initializing visual components and internal state for tracking objects within range.
    /// <code>Offset: 0x004D9400
    /// void __thiscall gmRadarUI::gmRadarUI(gmRadarUI*,const LayoutDesc*,const ElementDesc*)</code>
    /// </summary>
    /// <param name="layout">Layout descriptor defining display dimensions and available elements.</param>
    /// <param name="full_desc">Full element description specifying UI properties for the radar.</param>
    public void _ConstructorInternal(ACBindings.Internal.LayoutDesc* layout, ACBindings.Internal.ElementDesc* full_desc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmRadarUI, ACBindings.Internal.LayoutDesc*, ACBindings.Internal.ElementDesc*, void>)0x004D9400)(ref this, layout, full_desc);

    /// <summary>Performs a runtime cast of this gmRadarUI instance to the specified UIElement-derived type represented by an integer ID.
    /// <code>Offset: 0x004D9510
    /// UIElement* __thiscall gmRadarUI::DynamicCast(gmRadarUI*,unsigned int)</code>
    /// </summary>
    /// <param name="i_eType">Integer identifying the desired type (e.g., UIElement or gmRadarUI).</param>
    /// <returns>A pointer to the requested base class if the object matches that type; otherwise, nullptr.</returns>
    public ACBindings.Internal.UIElement* DynamicCast(uint i_eType) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmRadarUI, uint, ACBindings.Internal.UIElement*>)0x004D9510)(ref this, i_eType);

    /// <summary>Destroys a gmRadarUI instance by unregistering from global messages, freeing radar data, and invoking its base class destructors.
    /// <code>Offset: 0x004D9540
    /// void __thiscall gmRadarUI::~gmRadarUI(gmRadarUI*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmRadarUI, void>)0x004D9540)(ref this);

    /// <summary>Constructs a new radar user interface element from the specified layout and element description, initializing internal state accordingly.
    /// <code>Offset: 0x004D95D0
    /// UIElement* __cdecl gmRadarUI::Create(const LayoutDesc*,const ElementDesc*)</code>
    /// </summary>
    /// <param name="layout">Layout descriptor providing dimensions and element references for the radar UI.</param>
    /// <param name="full_desc">Full element description used to initialize the root UI element structure.</param>
    /// <returns>Pointer to the newly created UIElement, or nullptr if allocation fails.</returns>
    public static ACBindings.Internal.UIElement* Create(ACBindings.Internal.LayoutDesc* layout, ACBindings.Internal.ElementDesc* full_desc) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.LayoutDesc*, ACBindings.Internal.ElementDesc*, ACBindings.Internal.UIElement*>)0x004D95D0)(layout, full_desc);

    /// <summary>Responds to a deletion notice by removing the specified object from the radar display.
    /// <code>Offset: 0x004D9600
    /// void __thiscall gmRadarUI::RecvNotice_BeingDeleted(gmRadarUI*,CWeenieObject*)</code>
    /// </summary>
    /// <param name="i_obj">The game object that is being deleted.</param>
    public void RecvNotice_BeingDeleted(ACBindings.Internal.CWeenieObject* i_obj) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmRadarUI, ACBindings.Internal.CWeenieObject*, void>)0x004D9600)(ref this, i_obj);

    /// <summary>Updates a radar blip’s appearance—color and shape—to reflect the specified game object when it exists in the radar list.
    /// <code>Offset: 0x004D9610
    /// void __thiscall gmRadarUI::UpdateRadarLook(gmRadarUI*,ACCWeenieObject*)</code>
    /// </summary>
    /// <param name="i_pObj">The object whose radar representation should be refreshed; if null or not found, no changes are made.</param>
    public void UpdateRadarLook(ACBindings.Internal.ACCWeenieObject* i_pObj) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmRadarUI, ACBindings.Internal.ACCWeenieObject*, void>)0x004D9610)(ref this, i_pObj);

    /// <summary>Draws a radar blip on the specified UI surface at (x, y) using the shape and color from <paramref name="info"/>. The RGB components are scaled by <paramref name="intensity"/>, while the alpha remains unchanged. If the radar system is not blanked and the blip is marked as selected, an additional highlight is rendered around it.
    /// <code>Offset: 0x004D9690
    /// void __thiscall gmRadarUI::DrawBlip(gmRadarUI*,UISurface*,const RadarInfo*,float,int,int,bool)</code>
    /// </summary>
    /// <param name="i_pSurface">The UI surface to which the blip will be drawn.</param>
    /// <param name="info">Pointer to a <c>RadarInfo</c> structure describing the object’s shape and base color.</param>
    /// <param name="intensity">Multiplier applied to the RGB channels of the blip’s color.</param>
    /// <param name="x">Horizontal coordinate on the surface where the blip is drawn.</param>
    /// <param name="y">Vertical coordinate on the surface where the blip is drawn.</param>
    /// <param name="selected">If true, draws a selection highlight around the blip after rendering it.</param>
    public void DrawBlip(ACBindings.Internal.UISurface* i_pSurface, ACBindings.Internal.RadarInfo* info, float intensity, int x, int y, byte selected) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmRadarUI, ACBindings.Internal.UISurface*, ACBindings.Internal.RadarInfo*, float, int, int, byte, void>)0x004D9690)(ref this, i_pSurface, info, intensity, x, y, selected);

    /// <summary>Registers the radar UI element type with the UI framework, enabling its instantiation and use within the interface.
    /// <code>Offset: 0x004D97E0
    /// void __cdecl gmRadarUI::Register()</code>
    /// </summary>
    public static void Register() => ((delegate* unmanaged[Cdecl]<void>)0x004D97E0)();

    /// <summary>Updates the radar UI to reflect a changed look direction based on the provided object.
    /// <code>Offset: 0x004D9800
    /// void __thiscall gmRadarUI::RecvNotice_ChangeRadarLook(gmRadarUI*,CWeenieObject*)</code>
    /// </summary>
    /// <param name="i_obj">The object whose orientation should be used to update the radar view.</param>
    public void RecvNotice_ChangeRadarLook(ACBindings.Internal.CWeenieObject* i_obj) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmRadarUI, ACBindings.Internal.CWeenieObject*, void>)0x004D9800)(ref this, i_obj);

    /// <summary>Updates radar blips when an object's quality changes, adjusting color and shape for registered UI elements linked to that object or refreshing the radar view when the change concerns a different target.
    /// <code>Offset: 0x004D9810
    /// void __thiscall gmRadarUI::OnQualityChanged(gmRadarUI*,CWeenieObject*,StatType,unsigned int)</code>
    /// </summary>
    /// <param name="cwobj">The object whose quality changed.</param>
    /// <param name="stype">The stat type that triggered the update (unused in this implementation).</param>
    /// <param name="senum">An associated enum value for the stat change (unused in this implementation).</param>
    public void OnQualityChanged(ACBindings.Internal.CWeenieObject* cwobj, ACBindings.Internal.StatType stype, uint senum) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmRadarUI, ACBindings.Internal.CWeenieObject*, ACBindings.Internal.StatType, uint, void>)0x004D9810)(ref this, cwobj, stype, senum);

    /// <summary>Handles removal of a quality stat from an object by updating the radar display to reflect the change.
    /// <code>Offset: 0x004D98C0
    /// void __thiscall gmRadarUI::OnQualityRemoved(gmRadarUI*,CWeenieObject*,StatType,unsigned int)</code>
    /// </summary>
    /// <param name="cwobj">The object whose quality was removed.</param>
    /// <param name="stype">The type of stat that was removed.</param>
    /// <param name="senum">Enumeration value identifying the specific quality instance removed.</param>
    public void OnQualityRemoved(ACBindings.Internal.CWeenieObject* cwobj, ACBindings.Internal.StatType stype, uint senum) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmRadarUI, ACBindings.Internal.CWeenieObject*, ACBindings.Internal.StatType, uint, void>)0x004D98C0)(ref this, cwobj, stype, senum);

    /// <summary>Updates radar UI coordinates from the player system, formatting and displaying them in the coordinate fields while enabling or disabling visibility based on coordinate availability.
    /// <code>Offset: 0x004D98E0
    /// void __thiscall gmRadarUI::UpdateCoordinates(gmRadarUI*)</code>
    /// </summary>
    public void UpdateCoordinates() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmRadarUI, void>)0x004D98E0)(ref this);

    /// <summary>Repositions the radar compass tokens whenever the player’s facing direction changes. It queries the player object for its heading, converts it to radians, and calculates new screen coordinates for the North/East/South/West markers based on preset magnitudes, updating each token’s position accordingly.
    /// <code>Offset: 0x004D9CC0
    /// void __thiscall gmRadarUI::UpdateCompassTokens(gmRadarUI*)</code>
    /// </summary>
    public void UpdateCompassTokens() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmRadarUI, void>)0x004D9CC0)(ref this);

    /// <summary>Draws radar blips for all tracked objects onto the provided surface, calculates screen positions relative to the player, and displays a tooltip for the object nearest to the cursor.
    /// <code>Offset: 0x004D9FE0
    /// void __thiscall gmRadarUI::DrawObjects(gmRadarUI*,UISurface*)</code>
    /// </summary>
    /// <param name="i_pSurface">The rendering surface on which radar markers are drawn.</param>
    public void DrawObjects(ACBindings.Internal.UISurface* i_pSurface) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmRadarUI, ACBindings.Internal.UISurface*, void>)0x004D9FE0)(ref this, i_pSurface);

    /// <summary>Draws the radar UI and its child elements onto the specified surface, rendering objects, center markers, and edge outlines.
    /// <code>Offset: 0x004DA380
    /// char __thiscall gmRadarUI::DrawChildren(gmRadarUI*,_DWORD*,Box2D*,int,UISurface*)</code>
    /// </summary>
    /// <param name="a2">Pointer to auxiliary draw data passed to UIRegion::DrawChildren.</param>
    /// <param name="a3">Box defining the drawing region for the radar UI.</param>
    /// <param name="a4">Integer depth or layer index used by the base drawing routine.</param>
    /// <param name="i_pSurface">The surface onto which the radar UI will be rendered.</param>
    /// <returns>Returns a status byte indicating success (non‑zero) or failure (zero).</returns>
    public sbyte DrawChildren(int* a2, ACBindings.Internal.Box2D* a3, int a4, ACBindings.Internal.UISurface* i_pSurface) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmRadarUI, int*, ACBindings.Internal.Box2D*, int, ACBindings.Internal.UISurface*, sbyte>)0x004DA380)(ref this, a2, a3, a4, i_pSurface);

    /// <summary>Refreshes radar range, compass tokens, coordinates, and lock button state whenever the internal update timer elapses.
    /// <code>Offset: 0x004DA500
    /// void __thiscall gmRadarUI::UseTime(gmRadarUI*)</code>
    /// </summary>
    public void UseTime() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmRadarUI, void>)0x004DA500)(ref this);

    /// <summary>Handles global messages relevant to the radar UI, invoking UseTime for message ID 3 or UpdateLockedStatus for message ID 13.
    /// <code>Offset: 0x004DA640
    /// void __thiscall gmRadarUI::ListenToGlobalMessage(gmRadarUI*,unsigned int,int)</code>
    /// </summary>
    /// <param name="i_messageID">Identifier of the received global message.</param>
    /// <param name="i_data_int">Additional data associated with the message; unused in this implementation.</param>
    public void ListenToGlobalMessage(uint i_messageID, int i_data_int) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmRadarUI, uint, int, void>)0x004DA640)(ref this, i_messageID, i_data_int);

    /// <summary>Adds a blip representing the specified object to the radar UI if the object is visible and not already tracked. The method registers notice handlers to keep the blip updated or remove it when appropriate.
    /// <code>Offset: 0x004DA660
    /// void __thiscall gmRadarUI::AddObject(gmRadarUI*,ACCWeenieObject*)</code>
    /// </summary>
    /// <param name="i_pObj">The game object whose radar representation should be added. Must be non‑null, valid, and report that it can appear on the radar.</param>
    public void AddObject(ACBindings.Internal.ACCWeenieObject* i_pObj) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmRadarUI, ACBindings.Internal.ACCWeenieObject*, void>)0x004DA660)(ref this, i_pObj);

    /// <summary>Adds a newly created game object to the radar display when a creation notice is received.
    /// <code>Offset: 0x004DA7C0
    /// void __thiscall gmRadarUI::RecvNotice_CreateObject(gmRadarUI*,unsigned int)</code>
    /// </summary>
    /// <param name="i_iidObject">Identifier of the newly created object to be added to the radar.</param>
    public void RecvNotice_CreateObject(uint i_iidObject) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmRadarUI, uint, void>)0x004DA7C0)(ref this, i_iidObject);

    /// <summary>Initializes the radar UI component by registering notice handlers, clearing existing radar data, setting radar range from the player system, populating the radar with current world objects, and configuring the lock button based on UI lock state.
    /// <code>Offset: 0x004DA7F0
    /// void __thiscall gmRadarUI::Init(gmRadarUI*)</code>
    /// </summary>
    public void Init() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmRadarUI, void>)0x004DA7F0)(ref this);

    /// <summary>Initializes radar UI components, retrieves child elements such as lock and drag buttons, directional tokens, and coordinate displays, calculates token magnitudes relative to the radar center, registers global event and notice handlers, quality change callbacks, and sets up input action handling. If player data is already available, performs full radar initialization.
    /// <code>Offset: 0x004DA990
    /// void __thiscall gmRadarUI::PostInit(gmRadarUI*)</code>
    /// </summary>
    public void PostInit() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmRadarUI, void>)0x004DA990)(ref this);

    /// <summary>Handles a notification that the player's description has been received, triggering reinitialization of the radar interface and invoking its update routine.
    /// <code>Offset: 0x004DAFE0
    /// void __thiscall gmRadarUI::RecvNotice_PlayerDescReceived(gmRadarUI*,const CACQualities*,const CPlayerModule*)</code>
    /// </summary>
    /// <param name="i_playerDesc">Player quality data supplied with the notice (currently unused).</param>
    /// <param name="i_playerModule">Player module information supplied with the notice (currently unused).</param>
    public void RecvNotice_PlayerDescReceived(ACBindings.Internal.CACQualities* i_playerDesc, ACBindings.Internal.CPlayerModule* i_playerModule) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmRadarUI, ACBindings.Internal.CACQualities*, ACBindings.Internal.CPlayerModule*, void>)0x004DAFE0)(ref this, i_playerDesc, i_playerModule);
}

