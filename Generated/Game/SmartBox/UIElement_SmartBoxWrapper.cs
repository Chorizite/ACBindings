namespace ACBindings.Internal;


/// <summary>Encapsulates a UI element that serves as the SmartBox wrapper within the game’s interface system.</summary>
/// <summary>It manages selection state, drag‑and‑drop behavior, lighting effects, and flip animations while delegating input handling to its base UIElement implementation.</summary>
public unsafe struct UIElement_SmartBoxWrapper
{
    // Base Classes
    public ACBindings.Internal.UIElement_Field BaseClass_UIElement_Field; // ACBindings.Internal.UIElement_Field
    public ACBindings.Internal.gmNoticeHandler BaseClass_gmNoticeHandler; // ACBindings.Internal.gmNoticeHandler

    // Child Types
    public unsafe struct UIElement_SmartBoxWrapper_vtbl
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

        // Methods
    }
    // UIElement_SmartBoxWrapper::SearchReason
    public enum SearchReason : byte
    {
        sr_None = 0x0,
        sr_MouseOver = 0x1,
        sr_Select = 0x2,
        sr_Examine = 0x3,
        sr_Use = 0x4,
        sr_Drop = 0x5,
        sr_Drag = 0x6,
        sr_TargetedUse = 0x7
    }

    // Members
    public uint m_cFlipCount;
    public double m_timeNextFlip;
    public uint m_iidUnderMouse;
    public uint m_iidSelectedObject;
    public ACBindings.Internal.UIElement_SmartBoxWrapper.SearchReason m_SearchReason;
    public byte m_fMouseMovementActive;
    public byte m_fMouseMovementInProgress;
    public ACBindings.Internal.SECTION_3D m_CurrentSection;
    public uint m_dropItemID;
    public uint m_targetMode;
    public ACBindings.Internal.UIElement* m_dragIcon;

    // Generated Constructor
    public UIElement_SmartBoxWrapper(ACBindings.Internal.LayoutDesc* layout, ACBindings.Internal.ElementDesc* full_desc) {
        _ConstructorInternal(layout, full_desc);
    }

    // Methods

    /// <summary>Constructs a smart box UI element using the provided layout and element description, initializing internal state variables and registering for global event handling.
    /// <code>Offset: 0x004E5DB0
    /// void __thiscall UIElement_SmartBoxWrapper::UIElement_SmartBoxWrapper(UIElement_SmartBoxWrapper*,const LayoutDesc*,const ElementDesc*)</code>
    /// </summary>
    /// <param name="layout">Pointer to the LayoutDesc that defines display dimensions and element collections for the UI element.</param>
    /// <param name="full_desc">Pointer to the ElementDesc specifying properties such as ID, type, positioning, and child elements for this smart box wrapper.</param>
    public void _ConstructorInternal(ACBindings.Internal.LayoutDesc* layout, ACBindings.Internal.ElementDesc* full_desc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_SmartBoxWrapper, ACBindings.Internal.LayoutDesc*, ACBindings.Internal.ElementDesc*, void>)0x004E5DB0)(ref this, layout, full_desc);

    /// <summary>Returns a pointer to the requested element type from the wrapper based on its identifier.
    /// <code>Offset: 0x004E5E60
    /// UIElement* __thiscall UIElement_SmartBoxWrapper::DynamicCast(UIElement_SmartBoxWrapper*,unsigned int)</code>
    /// </summary>
    /// <param name="i_eType">The desired element type ID; 268435504 requests the embedded UIElement, 3 requests the wrapper itself as a UIElement, other values yield nullptr.</param>
    /// <returns>A UIElement* pointing to the appropriate object when the requested type matches, otherwise nullptr.</returns>
    public ACBindings.Internal.UIElement* DynamicCast(uint i_eType) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_SmartBoxWrapper, uint, ACBindings.Internal.UIElement*>)0x004E5E60)(ref this, i_eType);

    /// <summary>Retrieves the identifier for this smart box wrapper's UI element type.
    /// <code>Offset: 0x004E5E80
    /// unsigned int __thiscall UIElement_SmartBoxWrapper::GetUIElementType(UIElement_SmartBoxWrapper*)</code>
    /// </summary>
    /// <returns>A 32‑bit unsigned integer that denotes the element type (currently a fixed constant).</returns>
    public uint GetUIElementType() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_SmartBoxWrapper, uint>)0x004E5E80)(ref this);

    /// <summary>Create a SmartBoxWrapper UIElement based on the provided layout and element description, allocating memory for the wrapper and initializing it via its constructor.
    /// <code>Offset: 0x004E5EE0
    /// UIElement* __cdecl UIElement_SmartBoxWrapper::Create(const LayoutDesc*,const ElementDesc*)</code>
    /// </summary>
    /// <param name="layout">The layout descriptor containing display dimensions and element hash tables used to configure the wrapper.</param>
    /// <param name="full_desc">Full element description specifying size, state, edges, and child elements that define the wrapper’s visual structure.</param>
    /// <returns>A pointer to the newly constructed UIElement instance; returns nullptr if memory allocation fails. </returns>
    public static ACBindings.Internal.UIElement* Create(ACBindings.Internal.LayoutDesc* layout, ACBindings.Internal.ElementDesc* full_desc) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.LayoutDesc*, ACBindings.Internal.ElementDesc*, ACBindings.Internal.UIElement*>)0x004E5EE0)(layout, full_desc);

    /// <summary>Resizes the wrapped UI element to the specified width and height, then updates the associated SmartBox display to match the element’s new screen position and dimensions.
    /// <code>Offset: 0x004E5F10
    /// void __thiscall UIElement_SmartBoxWrapper::ResizeTo(UIElement_SmartBoxWrapper*,const int,const int)</code>
    /// </summary>
    /// <param name="width">The desired width of the element in pixels.</param>
    /// <param name="height">The desired height of the element in pixels.</param>
    public void ResizeTo(int width, int height) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_SmartBoxWrapper, int, int, void>)0x004E5F10)(ref this, width, height);

    /// <summary>Moves this SmartBoxWrapper to the specified screen coordinates and updates the global SmartBox mode with its new bounds.
    /// <code>Offset: 0x004E5F60
    /// void __thiscall UIElement_SmartBoxWrapper::MoveTo(UIElement_SmartBoxWrapper*,const int,const int)</code>
    /// </summary>
    /// <param name="x">Target X coordinate in screen space.</param>
    /// <param name="y">Target Y coordinate in screen space.</param>
    public void MoveTo(int x, int y) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_SmartBoxWrapper, int, int, void>)0x004E5F60)(ref this, x, y);

    /// <summary>Applies a lighting configuration to a physics object referenced by its ID. Depending on the provided lighting mode, it sets low or high intensity values, or restores the object's original lighting if no mode is specified.
    /// <code>Offset: 0x004E5FB0
    /// void __thiscall UIElement_SmartBoxWrapper::ApplyLighting(UIElement_SmartBoxWrapper*,unsigned int,LightingMode)</code>
    /// </summary>
    /// <param name="objID">Identifier of the target physics object whose lighting should be modified.</param>
    /// <param name="lightingMode">Enumeration indicating the desired lighting state: low, high, or restore to default.</param>
    public void ApplyLighting(uint objID, ACBindings.Internal.LightingMode lightingMode) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_SmartBoxWrapper, uint, ACBindings.Internal.LightingMode, void>)0x004E5FB0)(ref this, objID, lightingMode);

    /// <summary>Processes a left-click targeting event by delegating to the client UI system to execute the specified target mode for an item, when a valid item ID and UI system are available.
    /// <code>Offset: 0x004E6010
    /// void __thiscall UIElement_SmartBoxWrapper::HandleTargetedUseLeftClick(UIElement_SmartBoxWrapper*,unsigned int,unsigned int)</code>
    /// </summary>
    /// <param name="itemID">Identifier of the item to use; ignored if zero.</param>
    /// <param name="mode">Target mode specifying how the item should be used (cast to Target_Mode).</param>
    public void HandleTargetedUseLeftClick(uint itemID, uint mode) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_SmartBoxWrapper, uint, uint, void>)0x004E6010)(ref this, itemID, mode);

    /// <summary>Registers the SmartBox wrapper UI element class with the UI system, enabling creation of instances through a registered factory method.
    /// <code>Offset: 0x004E60A0
    /// void __cdecl UIElement_SmartBoxWrapper::Register()</code>
    /// </summary>
    public static void Register() => ((delegate* unmanaged[Cdecl]<void>)0x004E60A0)();

    /// <summary>
    /// Determines which UI element is located under the given window coordinates by querying the SmartBox system and records the result, either setting a sentinel value for a managed instance or initiating a general search.
    /// 
    /// <code>Offset: 0x004E60C0
    /// void __thiscall UIElement_SmartBoxWrapper::FindObject(UIElement_SmartBoxWrapper*,int,int,bool)</code>
    /// </summary>
    /// <param name="i_xWindow">The X coordinate within the window where the search begins.</param>
    /// <param name="i_yWindow">The Y coordinate within the window where the search begins.</param>
    /// <param name="fAccurate">Flag indicating whether to perform an accurate hit test (currently unused).</param>
    public void FindObject(int i_xWindow, int i_yWindow, byte fAccurate) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_SmartBoxWrapper, int, int, byte, void>)0x004E60C0)(ref this, i_xWindow, i_yWindow, fAccurate);

    /// <summary>Handles a drop‑release event on the smart box wrapper by verifying that the dropped item targets this element and initiating a search for the appropriate object based on the item's coordinates.
    /// <code>Offset: 0x004E6110
    /// void __thiscall UIElement_SmartBoxWrapper::HandleDropRelease(UIElement_SmartBoxWrapper*,const UIElementMessageInfo*)</code>
    /// </summary>
    /// <param name="i_rMsg">Message information describing the drop action, including source element pointer, positional data, and additional parameters needed to process the drop.</param>
    public void HandleDropRelease(ACBindings.Internal.UIElementMessageInfo* i_rMsg) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_SmartBoxWrapper, ACBindings.Internal.UIElementMessageInfo*, void>)0x004E6110)(ref this, i_rMsg);

    /// <summary>Initializes the smart box wrapper UI element by calling its base initializer, creating a drag‑icon child element from a predefined layout, invoking focus loss handling, and releasing temporary layout resources.
    /// <code>Offset: 0x004E61A0
    /// void __thiscall UIElement_SmartBoxWrapper::PostInit(UIElement_SmartBoxWrapper*)</code>
    /// </summary>
    public void PostInit() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_SmartBoxWrapper, void>)0x004E61A0)(ref this);

    /// <summary>Checks whether this smart box wrapper exposes any properties belonging to property group 0x10000003, combining the result with its base class's availability check.
    /// <code>Offset: 0x004E6200
    /// bool __thiscall UIElement_SmartBoxWrapper::InqAvailableProperties(UIElement_SmartBoxWrapper*,AvailablePropertySet*)</code>
    /// </summary>
    /// <param name="set">The AvailablePropertySet to query; if null, the function returns false.</param>
    /// <returns>True only when the base class reports available properties and at least one property from group 0x10000003 is present in the set; otherwise false.</returns>
    public byte InqAvailableProperties(ACBindings.Internal.AvailablePropertySet* set) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_SmartBoxWrapper, ACBindings.Internal.AvailablePropertySet*, byte>)0x004E6200)(ref this, set);

    /// <summary>Handles element messages for the SmartBox wrapper, clearing tooltips and processing drop releases on message 21, initiating a drag search on message 33, then delegating remaining handling to the base UIElement implementation.
    /// <code>Offset: 0x004E6250
    /// UIElementMessageListenResult __thiscall UIElement_SmartBoxWrapper::ListenToElementMessage(UIElement_SmartBoxWrapper*,const UIElementMessageInfo*)</code>
    /// </summary>
    /// <param name="i_rMsg">Information about the incoming element message, including its identifier and coordinates.</param>
    /// <returns>Result of listening to the element message, as returned by UIElement::ListenToElementMessage.</returns>
    public ACBindings.Internal.UIElementMessageListenResult ListenToElementMessage(ACBindings.Internal.UIElementMessageInfo* i_rMsg) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_SmartBoxWrapper, ACBindings.Internal.UIElementMessageInfo*, ACBindings.Internal.UIElementMessageListenResult>)0x004E6250)(ref this, i_rMsg);

    /// <summary>Updates the smart box wrapper's flip counter and lighting state based on elapsed time, and initiates an object search when mouse‑over conditions are met.
    /// <code>Offset: 0x004E62B0
    /// void __thiscall UIElement_SmartBoxWrapper::Global_Loop(UIElement_SmartBoxWrapper*)</code>
    /// </summary>
    public void Global_Loop() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_SmartBoxWrapper, void>)0x004E62B0)(ref this);

    /// <summary>Handles mouse movement over the smart box wrapper, updating its internal search state and locating objects under the cursor when necessary.
    /// <code>Offset: 0x004E6350
    /// void __thiscall UIElement_SmartBoxWrapper::MouseMove(UIElement_SmartBoxWrapper*,int,int)</code>
    /// </summary>
    /// <param name="i_xWindow">The horizontal position of the mouse in window coordinates.</param>
    /// <param name="i_yWindow">The vertical position of the mouse in window coordinates.</param>
    public void MouseMove(int i_xWindow, int i_yWindow) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_SmartBoxWrapper, int, int, void>)0x004E6350)(ref this, i_xWindow, i_yWindow);

    /// <summary>Handles mouse button press events on the smart box UI element, delegating to the base class and performing context‑specific actions such as selecting objects, initiating targeted use, toggling camera control, or triggering object usage based on the button pressed.
    /// <code>Offset: 0x004E6390
    /// void __thiscall UIElement_SmartBoxWrapper::MouseDown(UIElement_SmartBoxWrapper*,unsigned int,unsigned int,unsigned int)</code>
    /// </summary>
    /// <param name="i_xWindow">The X coordinate of the mouse event in window space.</param>
    /// <param name="i_yWindow">The Y coordinate of the mouse event in window space.</param>
    /// <param name="i_button">The identifier of the mouse button that was pressed (e.g., 7, 8, or 10).</param>
    public void MouseDown(uint i_xWindow, uint i_yWindow, uint i_button) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_SmartBoxWrapper, uint, uint, uint, void>)0x004E6390)(ref this, i_xWindow, i_yWindow, i_button);

    /// <summary>Handles mouse button release for the smart box UI element, performing actions based on which button was released.
    /// <code>Offset: 0x004E64B0
    /// void __thiscall UIElement_SmartBoxWrapper::MouseUp(UIElement_SmartBoxWrapper*,unsigned int,unsigned int,unsigned int)</code>
    /// </summary>
    /// <param name="i_xWindow">X coordinate of the cursor in window space where the mouse up event occurred.</param>
    /// <param name="i_yWindow">Y coordinate of the cursor in window space where the mouse up event occurred.</param>
    /// <param name="i_button">Identifier of the button that was released (e.g., 7 or 8). Specific values trigger camera look toggling, end of drag movement, or initiation of an examine search.</param>
    public void MouseUp(uint i_xWindow, uint i_yWindow, uint i_button) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_SmartBoxWrapper, uint, uint, uint, void>)0x004E64B0)(ref this, i_xWindow, i_yWindow, i_button);

    /// <summary>Prepares the drag icon UI element for the specified item ID by setting its image and related properties. If the supplied item ID is zero, preparation fails.
    /// <code>Offset: 0x004E6580
    /// bool __thiscall UIElement_SmartBoxWrapper::PrepareDragIcon(UIElement_SmartBoxWrapper*,unsigned int)</code>
    /// </summary>
    /// <param name="itemID">Identifier of the item whose drag icon should be displayed.</param>
    /// <returns>True if a drag icon was prepared; false when no valid item ID is provided.</returns>
    public byte PrepareDragIcon(uint itemID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_SmartBoxWrapper, uint, byte>)0x004E6580)(ref this, itemID);

    /// <summary>Handles global messages for UIElement_SmartBoxWrapper, invoking internal actions such as the global loop when specific message IDs are received.
    /// <code>Offset: 0x004E6750
    /// void __thiscall UIElement_SmartBoxWrapper::ListenToGlobalMessage(UIElement_SmartBoxWrapper*,unsigned int,int)</code>
    /// </summary>
    /// <param name="this">The current UIElement_SmartBoxWrapper instance.</param>
    /// <param name="messageID">Identifier of the global message to process.</param>
    /// <param name="data_int">Supplementary integer data associated with the message (currently unused by this implementation).</param>
    public void ListenToGlobalMessage(uint messageID, int data_int) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_SmartBoxWrapper, uint, int, void>)0x004E6750)(ref this, messageID, data_int);

    /// <summary>Handles a notice indicating that an object has been found in the smart box context, updating lighting, selection, tooltips and drag‑drop state accordingly.
    /// <code>Offset: 0x004E6760
    /// void __thiscall UIElement_SmartBoxWrapper::RecvNotice_SmartBoxObjectFound(UIElement_SmartBoxWrapper*,unsigned int)</code>
    /// </summary>
    /// <param name="iidObject">The ID of the discovered object; 0 indicates no valid object was found.</param>
    public void RecvNotice_SmartBoxObjectFound(uint iidObject) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_SmartBoxWrapper, uint, void>)0x004E6760)(ref this, iidObject);
}

