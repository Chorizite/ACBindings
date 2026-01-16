namespace ACBindings.Internal;


/// <summary>Manages a scrollable UI region by linking horizontal and vertical scrollbar identifiers, tracking the content's offset and total dimensions for proper scrolling behavior.</summary>
/// <remarks>The fields m_iScrollableX and m_iScrollableY represent the current top-left corner of the visible viewport within the larger content area. The fields m_iScrollableWidth and m_iScrollableHeight denote the full size of that content, allowing scroll limits to be computed.</remarks>
public unsafe struct UIElement_Scrollable
{
    // Base Classes
    public ACBindings.Internal.UIElement BaseClass_UIElement; // ACBindings.Internal.UIElement

    // Child Types
    public unsafe struct UIElement_Scrollable_vtbl
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
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement_Scrollable*, void> AdjustToScrollableXYChange; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement_Scrollable*, byte, byte, byte, int> InqScrollDelta; // function pointer

        // Methods
    }

    // Members
    public uint m_eHorizonalScrollbarID;
    public uint m_eVerticalScrollbarID;
    public int m_iScrollableX;
    public int m_iScrollableY;
    public int m_iScrollableWidth;
    public int m_iScrollableHeight;

    // Generated Constructor
    public UIElement_Scrollable(ACBindings.Internal.LayoutDesc* i_rcLayout, ACBindings.Internal.ElementDesc* i_rcFullDesc) {
        _ConstructorInternal(i_rcLayout, i_rcFullDesc);
    }

    // Methods

    /// <summary>Initializes a scrollable UI element, delegating to its base constructor and setting all scrollbar identifiers and scroll extents to zero.
    /// <code>Offset: 0x00474150
    /// void __thiscall UIElement_Scrollable::UIElement_Scrollable(UIElement_Scrollable*,const LayoutDesc*,const ElementDesc*)</code>
    /// </summary>
    /// <param name="i_rcLayout">Descriptor providing layout dimensions for the UI element.</param>
    /// <param name="i_rcFullDesc">Complete description of the UI element including state and child information.</param>
    public void _ConstructorInternal(ACBindings.Internal.LayoutDesc* i_rcLayout, ACBindings.Internal.ElementDesc* i_rcFullDesc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Scrollable, ACBindings.Internal.LayoutDesc*, ACBindings.Internal.ElementDesc*, void>)0x00474150)(ref this, i_rcLayout, i_rcFullDesc);

    /// <summary>Performs a dynamic cast of the current scrollable element to its base UIElement type when the requested type identifier matches the Scrollable type; otherwise returns null.
    /// <code>Offset: 0x004741A0
    /// UIElement* __thiscall UIElement_Scrollable::DynamicCast(UIElement_Scrollable*,unsigned int)</code>
    /// </summary>
    /// <param name="this">The UIElement_Scrollable instance being cast.</param>
    /// <param name="i_eType">Identifier specifying the desired type for casting.</param>
    /// <returns>A UIElement pointer if i_eType equals the Scrollable type ID (10); otherwise, nullptr.</returns>
    public ACBindings.Internal.UIElement* DynamicCast(uint i_eType) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Scrollable, uint, ACBindings.Internal.UIElement*>)0x004741A0)(ref this, i_eType);

    /// <summary>Processes a mouse-down event for a scrollable UI element, delegating to the base UIElement handler and handling any root-level action that may cause focus loss.
    /// <code>Offset: 0x004741C0
    /// void __thiscall UIElement_Scrollable::MouseDown(UIElement_Scrollable*,unsigned int,unsigned int,unsigned int)</code>
    /// </summary>
    /// <param name="i_xWindow">The X coordinate of the mouse click within the window.</param>
    /// <param name="i_yWindow">The Y coordinate of the mouse click within the window.</param>
    /// <param name="i_eButton">Identifier for the mouse button that was pressed.</param>
    public void MouseDown(uint i_xWindow, uint i_yWindow, uint i_eButton) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Scrollable, uint, uint, uint, void>)0x004741C0)(ref this, i_xWindow, i_yWindow, i_eButton);

    /// <summary>Registers the scrollable UI element with the input system using a given priority.
    /// <code>Offset: 0x00474210
    /// bool __thiscall UIElement_Scrollable::RegisterInputMaps(UIElement_Scrollable*,int)</code>
    /// </summary>
    /// <param name="i_nPriority">The priority level at which this element should be registered for input handling.</param>
    /// <returns>True if registration succeeded; otherwise, false.</returns>
    public byte RegisterInputMaps(int i_nPriority) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Scrollable, int, byte>)0x00474210)(ref this, i_nPriority);

    /// <summary>Detaches input mappings associated with the scrollable UI element from both its local registry and the global ID manager.
    /// <code>Offset: 0x00474250
    /// bool __thiscall UIElement_Scrollable::UnregisterInputMaps(UIElement_Scrollable*)</code>
    /// </summary>
    /// <returns>True if either the element’s own unregistration succeeds or the global ID manager successfully removes the mapping; otherwise false.</returns>
    public byte UnregisterInputMaps() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Scrollable, byte>)0x00474250)(ref this);

    /// <summary>Retrieves the scrollbar associated with this scrollable element, selecting either the horizontal or vertical scrollbar based on the supplied flag. Returns a pointer to the matching UIElement_Scrollbar if it exists and is correctly linked; otherwise returns null.
    /// <code>Offset: 0x00474280
    /// UIElement_Scrollbar* __thiscall UIElement_Scrollable::GetScrollbarPointer_(UIElement_Scrollable*,bool)</code>
    /// </summary>
    /// <param name="i_bHorizontal">Specifies whether to retrieve the horizontal (true) or vertical (false) scrollbar.</param>
    /// <returns>Pointer to the found UIElement_Scrollbar, or nullptr when no appropriate scrollbar is present.</returns>
    public ACBindings.Internal.UIElement_Scrollbar* GetScrollbarPointer_(byte i_bHorizontal) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Scrollable, byte, ACBindings.Internal.UIElement_Scrollbar*>)0x00474280)(ref this, i_bHorizontal);

    /// <summary>Updates the horizontal or vertical scrollbar to reflect the element's current scroll position and size.
    /// <code>Offset: 0x004742E0
    /// void __thiscall UIElement_Scrollable::UpdateScrollbarPosition_(UIElement_Scrollable*,bool)</code>
    /// </summary>
    /// <param name="i_bHorizontal">Specifies whether the scrollbar is horizontal (true) or vertical (false).</param>
    public void UpdateScrollbarPosition_(byte i_bHorizontal) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Scrollable, byte, void>)0x004742E0)(ref this, i_bHorizontal);

    /// <summary>Queries all properties available for a scrollable UI element and populates the provided set.
    /// <code>Offset: 0x00474430
    /// bool __thiscall UIElement_Scrollable::InqAvailableProperties(UIElement_Scrollable*,AvailablePropertySet*)</code>
    /// </summary>
    /// <param name="o_rcSet">The set to receive property information; existing entries are augmented with scroll‑specific properties.</param>
    /// <returns>True if the query succeeded, otherwise false.</returns>
    public byte InqAvailableProperties(ACBindings.Internal.AvailablePropertySet* o_rcSet) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Scrollable, ACBindings.Internal.AvailablePropertySet*, byte>)0x00474430)(ref this, o_rcSet);

    /// <summary>Sets the element's scrollable X and Y coordinates, optionally clamping them to its content size unless forced or disabled by an internal flag.
    /// <code>Offset: 0x00474480
    /// void __thiscall UIElement_Scrollable::SetScrollableXY(UIElement_Scrollable*,int,int,bool)</code>
    /// </summary>
    /// <param name="i_iX">Desired horizontal offset for scrolling.</param>
    /// <param name="i_iY">Desired vertical offset for scrolling.</param>
    /// <param name="i_bForce">If true, sets the values directly; otherwise respects clamping rules and a specific attribute.</param>
    public void SetScrollableXY(int i_iX, int i_iY, byte i_bForce) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Scrollable, int, int, byte, void>)0x00474480)(ref this, i_iX, i_iY, i_bForce);

    /// <summary>Updates the scrollbar’s size, visibility, and position for a scrollable UI element based on its content dimensions and orientation.
    /// <code>Offset: 0x00474560
    /// void __thiscall UIElement_Scrollable::UpdateScrollbarSize_(UIElement_Scrollable*,bool)</code>
    /// </summary>
    /// <param name="i_bHorizontal">True to adjust the horizontal scrollbar; false updates the vertical one.</param>
    public void UpdateScrollbarSize_(byte i_bHorizontal) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Scrollable, byte, void>)0x00474560)(ref this, i_bHorizontal);

    /// <summary>Processes messages from a scrollbar control, updating the element’s scroll position or invoking action handlers based on the message identifier.
    /// <code>Offset: 0x00474730
    /// void __thiscall UIElement_Scrollable::HandleScrollbarMessage_(UIElement_Scrollable*,bool,const unsigned int,UIElement_Scrollbar*)</code>
    /// </summary>
    /// <param name="i_bHorizontal">True if the message originates from a horizontal scrollbar; otherwise vertical.</param>
    /// <param name="i_eMessageID">Identifier of the scrollbar event to handle.</param>
    /// <param name="i_pcScrollbar">Pointer to the scrollbar that generated the message.</param>
    public void HandleScrollbarMessage_(byte i_bHorizontal, uint i_eMessageID, ACBindings.Internal.UIElement_Scrollbar* i_pcScrollbar) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Scrollable, byte, uint, ACBindings.Internal.UIElement_Scrollbar*, void>)0x00474730)(ref this, i_bHorizontal, i_eMessageID, i_pcScrollbar);

    /// <summary>Initializes the scrollable element by locating the specified horizontal and vertical scrollbar elements, registering for their messages when they belong to this element, and updating both scrollbar sizes.
    /// <code>Offset: 0x00474870
    /// void __thiscall UIElement_Scrollable::PostInit(UIElement_Scrollable*)</code>
    /// </summary>
    public void PostInit() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Scrollable, void>)0x00474870)(ref this);

    /// <summary>Handles incoming messages for a scrollable UI element, routing them to attached scrollbars when appropriate and forwarding other events to its base class.
    /// <code>Offset: 0x00474920
    /// UIElementMessageListenResult __thiscall UIElement_Scrollable::ListenToElementMessage(UIElement_Scrollable*,const UIElementMessageInfo*)</code>
    /// </summary>
    /// <param name="i_rMsg">Message information targeting this element.</param>
    /// <returns>Result indicating whether the message was handled by the scrollable (value 2) or passed to the base UIElement.</returns>
    public ACBindings.Internal.UIElementMessageListenResult ListenToElementMessage(ACBindings.Internal.UIElementMessageInfo* i_rMsg) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Scrollable, ACBindings.Internal.UIElementMessageInfo*, ACBindings.Internal.UIElementMessageListenResult>)0x00474920)(ref this, i_rMsg);

    /// <summary>Handles assignment of horizontal or vertical scrollbar identifiers for a scrollable UI element, updates the corresponding scrollbar size, and forwards generic attribute handling to its base class.
    /// <code>Offset: 0x004749F0
    /// void __thiscall UIElement_Scrollable::OnSetAttribute(UIElement_Scrollable*,const BaseProperty*)</code>
    /// </summary>
    /// <param name="i_rcProperty">The property specifying which scrollbar identifier to set; may include an associated value that is propagated through the property's callback mechanism.</param>
    public void OnSetAttribute(ACBindings.Internal.BaseProperty* i_rcProperty) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Scrollable, ACBindings.Internal.BaseProperty*, void>)0x004749F0)(ref this, i_rcProperty);

    /// <summary>Resizes the scrollable UI element to the specified width and height, adjusting associated scrollbars when the underlying region's dimensions change.
    /// <code>Offset: 0x00474A80
    /// void __thiscall UIElement_Scrollable::ResizeTo(UIElement_Scrollable*,const int,const int)</code>
    /// </summary>
    /// <param name="i_iWidth">Desired new width in pixels.</param>
    /// <param name="i_iHeight">Desired new height in pixels.</param>
    public void ResizeTo(int i_iWidth, int i_iHeight) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Scrollable, int, int, void>)0x00474A80)(ref this, i_iWidth, i_iHeight);

    /// <summary>Adjusts the size of the scrollable area if new dimensions differ from current values. Updates scrollbar sizes and broadcasts a message to notify listeners of the change.
    /// <code>Offset: 0x00474AF0
    /// void __thiscall UIElement_Scrollable::ResizeScrollableArea(UIElement_Scrollable*,int,int)</code>
    /// </summary>
    /// <param name="i_iWidth">The desired width of the scrollable area.</param>
    /// <param name="i_iHeight">The desired height of the scrollable area.</param>
    public void ResizeScrollableArea(int i_iWidth, int i_iHeight) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Scrollable, int, int, void>)0x00474AF0)(ref this, i_iWidth, i_iHeight);
}

