namespace ACBindings.Internal;


/// <summary>Represents a clickable button in the UI system, extending text functionality with press state and hot‑click handling.</summary>
public unsafe struct UIElement_Button : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.UIElement_Text BaseClass_UIElement_Text; // ACBindings.Internal.UIElement_Text

    // Child Types
    public unsafe struct UIElement_Button_vtbl
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
    public byte mousePressedOnButton;
    public byte hotClickingInProgress;
    public double nextHotClickTime;

    // Generated Constructor
    public UIElement_Button(ACBindings.Internal.LayoutDesc* layout, ACBindings.Internal.ElementDesc* full_desc) {
        _ConstructorInternal(layout, full_desc);
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>Creates a button UI element using the supplied layout and element description while initializing internal state flags.
    /// <code>Offset: 0x00471F10
    /// void __thiscall UIElement_Button::UIElement_Button(UIElement_Button*,const LayoutDesc*,const ElementDesc*)</code>
    /// </summary>
    /// <param name="layout">Layout descriptor defining visual properties for the button.</param>
    /// <param name="full_desc">Element description providing geometry, states, and other metadata for the button.</param>
    public void _ConstructorInternal(ACBindings.Internal.LayoutDesc* layout, ACBindings.Internal.ElementDesc* full_desc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Button, ACBindings.Internal.LayoutDesc*, ACBindings.Internal.ElementDesc*, void>)0x00471F10)(ref this, layout, full_desc);

    /// <summary>Performs a dynamic cast from a UIElement_Button instance to its base UIElement when the requested type identifier matches supported values (1 or 12). For type 10, returns the original button pointer; otherwise returns nullptr.
    /// <code>Offset: 0x00471F60
    /// UIElement* __thiscall UIElement_Button::DynamicCast(UIElement_Button*,unsigned int)</code>
    /// </summary>
    /// <param name="i_eType">Identifier of the target type for casting. Only values 1 and 12 result in a cast to the base element, while 10 returns this instance itself.</param>
    /// <returns>Pointer to the UIElement base if i_eType is 1 or 12; pointer to the button itself when i_eType equals 10; otherwise nullptr.</returns>
    public ACBindings.Internal.UIElement* DynamicCast(uint i_eType) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Button, uint, ACBindings.Internal.UIElement*>)0x00471F60)(ref this, i_eType);

    /// <summary>Destroys a UI button element by clearing any active hot‑click state, unregistering from global messages if necessary, and then invoking the text component destructor to clean up inherited resources.
    /// <code>Offset: 0x00471F80
    /// void __thiscall UIElement_Button::~UIElement_Button(UIElement_Button*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Button, void>)0x00471F80)(ref this);

    /// <summary>Creates a new button UI element using the specified layout description and element descriptor.
    /// <code>Offset: 0x00471FC0
    /// UIElement* __cdecl UIElement_Button::Create(const LayoutDesc*,const ElementDesc*)</code>
    /// </summary>
    /// <param name="layout">Layout information defining display size, elements, and headers for the UI system.</param>
    /// <param name="full_desc">Descriptor containing state definitions, child elements, and properties for the button.</param>
    /// <returns>Pointer to the constructed UIElement representing the button, or null if memory allocation fails.</returns>
    public static ACBindings.Internal.UIElement* Create(ACBindings.Internal.LayoutDesc* layout, ACBindings.Internal.ElementDesc* full_desc) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.LayoutDesc*, ACBindings.Internal.ElementDesc*, ACBindings.Internal.UIElement*>)0x00471FC0)(layout, full_desc);

    /// <summary>Handles global messages for button elements, forwarding to the base text element and managing hot‑click behavior when a click is in progress.
    /// <code>Offset: 0x00472020
    /// void __thiscall UIElement_Button::ListenToGlobalMessage(UIElement_Button*,unsigned int,int)</code>
    /// </summary>
    /// <param name="messageID">Identifier of the message to process.</param>
    /// <param name="data_int">Integer data associated with the message.</param>
    public void ListenToGlobalMessage(uint messageID, int data_int) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Button, uint, int, void>)0x00472020)(ref this, messageID, data_int);

    /// <summary>Updates the button’s visual state according to its enabled flag, mouse press status, hot‑click setting, and focus attributes.
    /// <code>Offset: 0x004720B0
    /// void __thiscall UIElement_Button::UpdateState_(UIElement_Button*)</code>
    /// </summary>
    public void UpdateState_() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Button, void>)0x004720B0)(ref this);

    /// <summary>Updates internal flags when changing the button's state, handling special transitions for states 1, 6, and 13 before delegating to the base UIElement.
    /// <code>Offset: 0x00472160
    /// bool __thiscall UIElement_Button::SetState(UIElement_Button*,unsigned int)</code>
    /// </summary>
    /// <param name="state">The desired state identifier for the button.</param>
    /// <returns>True if the state change was applied; otherwise false.</returns>
    public byte SetState(uint state) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Button, uint, byte>)0x00472160)(ref this, state);

    /// <summary>Handles a click on the button by dispatching an input event based on the element’s action attribute, if defined and enabled.
    /// <code>Offset: 0x00472210
    /// bool __thiscall UIElement_Button::HandleButtonClick(UIElement_Button*,const UIElementMessageInfo*)</code>
    /// </summary>
    /// <param name="this">The button instance receiving the click.</param>
    /// <param name="i_rMsg">Message information for the click event (unused in this handler).</param>
    /// <returns>True when the click triggers a valid input action; otherwise false.</returns>
    public byte HandleButtonClick(ACBindings.Internal.UIElementMessageInfo* i_rMsg) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Button, ACBindings.Internal.UIElementMessageInfo*, byte>)0x00472210)(ref this, i_rMsg);

    /// <summary>Registers the UIButton element class in the UI system so that instances can be created by the framework.
    /// <code>Offset: 0x004722E0
    /// void __cdecl UIElement_Button::Register()</code>
    /// </summary>
    public static void Register() => ((delegate* unmanaged[Cdecl]<void>)0x004722E0)();

    /// <summary>Performs post‑initialization of a button element by invoking the base scrollable initialization and refreshing its visual state.
    /// <code>Offset: 0x004722F0
    /// void __thiscall UIElement_Button::PostInit(UIElement_Button*)</code>
    /// </summary>
    public void PostInit() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Button, void>)0x004722F0)(ref this);

    /// <summary>Updates internal state and behavior of a UI button when an attribute changes, handling actions, focus changes, and hot‑click logic.
    /// <code>Offset: 0x00472300
    /// void __thiscall UIElement_Button::OnSetAttribute(UIElement_Button*,const BaseProperty*)</code>
    /// </summary>
    /// <param name="attribute">The property that has been set on the button.</param>
    public void OnSetAttribute(ACBindings.Internal.BaseProperty* attribute) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Button, ACBindings.Internal.BaseProperty*, void>)0x00472300)(ref this, attribute);

    /// <summary>Handles a mouse‑down event for the button, setting its pressed state and updating visual appearance. If the button is enabled and configured for hot clicking, broadcasts a click message and schedules the next permissible hot‑click time.
    /// <code>Offset: 0x004723B0
    /// void __thiscall UIElement_Button::MouseDown(UIElement_Button*,unsigned int,unsigned int,unsigned int)</code>
    /// </summary>
    /// <param name="xWindow">The X coordinate of the mouse event relative to the window.</param>
    /// <param name="yWindow">The Y coordinate of the mouse event relative to the window.</param>
    /// <param name="button">Identifier of the mouse button that was pressed (e.g., left or right).</param>
    public void MouseDown(uint xWindow, uint yWindow, uint button) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Button, uint, uint, uint, void>)0x004723B0)(ref this, xWindow, yWindow, button);

    /// <summary>Handles the release of a mouse button over the UI element, updating its pressed flag, managing any hot‑click behavior, refreshing visual state, and broadcasting a click event when conditions are met.
    /// <code>Offset: 0x004724A0
    /// void __thiscall UIElement_Button::MouseUp(UIElement_Button*,unsigned int,unsigned int,unsigned int)</code>
    /// </summary>
    /// <param name="xElement">X coordinate of the mouse within the element at the time of release.</param>
    /// <param name="yElement">Y coordinate of the mouse within the element at the time of release.</param>
    /// <param name="button">Index of the mouse button that was released (e.g., left or right).</param>
    public void MouseUp(uint xElement, uint yElement, uint button) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Button, uint, uint, uint, void>)0x004724A0)(ref this, xElement, yElement, button);

    /// <summary>Handles mouse‑over state changes for the button by propagating the event to its UIElement base class and updating visual state accordingly.
    /// <code>Offset: 0x004725B0
    /// void __thiscall UIElement_Button::MouseOverTop(UIElement_Button*,bool)</code>
    /// </summary>
    /// <param name="overTop">True if the mouse cursor is positioned over the top region of the button; false otherwise.</param>
    public void MouseOverTop(byte overTop) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Button, byte, void>)0x004725B0)(ref this, overTop);

    /// <summary>Handles UI element messages for a button, processing click events when the button is active and delegating other messages to its text base class.
    /// <code>Offset: 0x004725D0
    /// UIElementMessageListenResult __thiscall UIElement_Button::ListenToElementMessage(UIElement_Button*,const UIElementMessageInfo*)</code>
    /// </summary>
    /// <param name="i_rMsg">Information about the event being received by the UI element.</param>
    /// <returns>Indicates whether the message was handled by the button (result value 2) or forwarded to the base text handler.</returns>
    public ACBindings.Internal.UIElementMessageListenResult ListenToElementMessage(ACBindings.Internal.UIElementMessageInfo* i_rMsg) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Button, ACBindings.Internal.UIElementMessageInfo*, ACBindings.Internal.UIElementMessageListenResult>)0x004725D0)(ref this, i_rMsg);

    /// <summary>Queries the UI button element for all properties that can be applied, merging inherited text properties with button‑specific ones into the supplied set.
    /// <code>Offset: 0x00472620
    /// bool __thiscall UIElement_Button::InqAvailableProperties(UIElement_Button*,AvailablePropertySet*)</code>
    /// </summary>
    /// <param name="set">The collection to receive the available properties; must not be null.</param>
    /// <returns>True if both the base text element and the button property group were successfully queried; otherwise false.</returns>
    public byte InqAvailableProperties(ACBindings.Internal.AvailablePropertySet* set) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Button, ACBindings.Internal.AvailablePropertySet*, byte>)0x00472620)(ref this, set);
}

