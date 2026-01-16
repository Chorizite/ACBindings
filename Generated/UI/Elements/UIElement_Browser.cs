namespace ACBindings.Internal;


/// <summary>Browser UI component that hosts an embedded web view, manages visibility and fullscreen state, and interfaces with an IBrowserControl instance.</summary>
public unsafe struct UIElement_Browser
{
    // Base Classes
    public ACBindings.Internal.UIElement BaseClass_UIElement; // ACBindings.Internal.UIElement
    public ACBindings.Internal.IAlternateDCProvider BaseClass_IAlternateDCProvider; // ACBindings.Internal.IAlternateDCProvider
    public ACBindings.Internal.IBrowserCallback BaseClass_IBrowserCallback; // ACBindings.Internal.IBrowserCallback

    // Statics
    public static uint* sm_cVisibleWindows = (uint*)0x0083E40C;

    // Child Types
    public unsafe struct UIElement_Browser_vtbl
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

    // Members
    public ACBindings.Internal.IBrowserControl* m_pWebBrowser;
    public byte m_fFullScreen;
    public byte m_fLastTrueVisibility;
    public byte m_fAllowFullscreenBrowser;

    // Generated Constructor
    public UIElement_Browser(ACBindings.Internal.LayoutDesc* layout, ACBindings.Internal.ElementDesc* full_desc) {
        _ConstructorInternal(layout, full_desc);
    }

    // Methods

    /// <summary>Constructs a UIElement_Browser, initializing its base UIElement with the provided layout and descriptor, loading the required browser library if necessary, and creating an IBrowserControl instance.
    /// <code>Offset: 0x0046B5B0
    /// void __thiscall UIElement_Browser::UIElement_Browser(UIElement_Browser*,const LayoutDesc*,const ElementDesc*)</code>
    /// </summary>
    /// <param name="layout">Layout description used for positioning and sizing elements.</param>
    /// <param name="full_desc">Full element description providing state and child information.</param>
    public void _ConstructorInternal(ACBindings.Internal.LayoutDesc* layout, ACBindings.Internal.ElementDesc* full_desc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Browser, ACBindings.Internal.LayoutDesc*, ACBindings.Internal.ElementDesc*, void>)0x0046B5B0)(ref this, layout, full_desc);

    /// <summary>Casts the browser element to UIElement when requested type matches 14; otherwise yields null.
    /// <code>Offset: 0x0046B650
    /// UIElement* __thiscall UIElement_Browser::DynamicCast(UIElement_Browser*,unsigned int)</code>
    /// </summary>
    /// <param name="i_eType">The type identifier for which a cast is desired.</param>
    /// <returns>Pointer to the UIElement base if i_eType equals 14, otherwise nullptr.</returns>
    public ACBindings.Internal.UIElement* DynamicCast(uint i_eType) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Browser, uint, ACBindings.Internal.UIElement*>)0x0046B650)(ref this, i_eType);

    /// <summary>Creates a new browser UI element from the supplied layout and element description, returning a pointer to the resulting UIElement.
    /// <code>Offset: 0x0046B670
    /// UIElement* __cdecl UIElement_Browser::Create(const LayoutDesc*,const ElementDesc*)</code>
    /// </summary>
    /// <param name="layout">Layout data describing dimensions and child elements for the UI.</param>
    /// <param name="full_desc">Full descriptor of the root element to be instantiated within the browser.</param>
    /// <returns>Pointer to the constructed UIElement or nullptr if memory allocation failed.</returns>
    public static ACBindings.Internal.UIElement* Create(ACBindings.Internal.LayoutDesc* layout, ACBindings.Internal.ElementDesc* full_desc) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.LayoutDesc*, ACBindings.Internal.ElementDesc*, ACBindings.Internal.UIElement*>)0x0046B670)(layout, full_desc);

    /// <summary>Sets the visibility state of a browser UI element and updates internal counters and fullscreen mode accordingly.
    /// <code>Offset: 0x0046B6A0
    /// void __thiscall UIElement_Browser::SetVisible(UIElement_Browser*,bool)</code>
    /// </summary>
    /// <param name="visible">True to make the element visible; false to hide it.</param>
    public void SetVisible(byte visible) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Browser, byte, void>)0x0046B6A0)(ref this, visible);

    /// <summary>Updates the UI element’s screen position, then notifies its embedded web browser of the new screen coordinates when a browser instance is attached.
    /// <code>Offset: 0x0046B720
    /// void __thiscall UIElement_Browser::UpdateForScreenPositionChange(UIElement_Browser*)</code>
    /// </summary>
    public void UpdateForScreenPositionChange() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Browser, void>)0x0046B720)(ref this);

    /// <summary>Updates the browser’s fullscreen mode to match the render device setting when fullscreen is permitted.
    /// <code>Offset: 0x0046B760
    /// void __thiscall UIElement_Browser::PostBlit(UIElement_Browser*,const Box2D*,UISurface*)</code>
    /// </summary>
    /// <param name="i_boxDest">Destination rectangle for blitting (currently unused).</param>
    /// <param name="i_pTargetSurface">Target surface for rendering (currently unused).</param>
    public void PostBlit(ACBindings.Internal.Box2D* i_boxDest, ACBindings.Internal.UISurface* i_pTargetSurface) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Browser, ACBindings.Internal.Box2D*, ACBindings.Internal.UISurface*, void>)0x0046B760)(ref this, i_boxDest, i_pTargetSurface);

    /// <summary>Creates and initializes the browser’s window helper by configuring the underlying IBrowserControl with screen coordinates and dimensions.
    /// <code>Offset: 0x0046B790
    /// bool __thiscall UIElement_Browser::CreateWindowHelper(UIElement_Browser*)</code>
    /// </summary>
    /// <returns>True if the window helper was created and configured successfully; otherwise, false.</returns>
    public byte CreateWindowHelper() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Browser, byte>)0x0046B790)(ref this);

    /// <summary>Marks the browser’s root UI region dirty if any child elements are registered, indicating a need for redraw. Returns false when no elements are present.
    /// <code>Offset: 0x0046B830
    /// bool __thiscall UIElement_Browser::ReleaseDC(UIElement_Browser*,HDC__*,int*)</code>
    /// </summary>
    /// <param name="i_hdc">Handle of a device context (unused in this implementation).</param>
    /// <param name="o_iResult">Receives 1 on success; remains unchanged if the operation fails.</param>
    /// <returns>True when at least one element is registered and the region was marked dirty; otherwise false.</returns>
    public byte ReleaseDC(System.IntPtr i_hdc, int* o_iResult) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Browser, System.IntPtr, int*, byte>)0x0046B830)(ref this, i_hdc, o_iResult);

    /// <summary>Initializes the browser element by determining its dimensions, creating the underlying web view, and performing standard UI element initialization.
    /// <code>Offset: 0x0046B8D0
    /// void __thiscall UIElement_Browser::Initialize(UIElement_Browser*)</code>
    /// </summary>
    public void Initialize() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Browser, void>)0x0046B8D0)(ref this);

    /// <summary>Resizes the browser element to the supplied width (cx) and height (cy), then propagates these dimensions to its internal web‑browser control if one is present.
    /// <code>Offset: 0x0046B8F0
    /// void __thiscall UIElement_Browser::ResizeTo(UIElement_Browser*,const int,const int)</code>
    /// </summary>
    /// <param name="cx">The target width in pixels.</param>
    /// <param name="cy">The target height in pixels.</param>
    public void ResizeTo(int cx, int cy) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Browser, int, int, void>)0x0046B8F0)(ref this, cx, cy);

    /// <summary>Collects all properties available for this browser element, including base class and browser-specific properties, into the supplied property set.
    /// <code>Offset: 0x0046B940
    /// bool __thiscall UIElement_Browser::InqAvailableProperties(UIElement_Browser*,AvailablePropertySet*)</code>
    /// </summary>
    /// <param name="o_set">The set to receive the available properties; must not be null.</param>
    /// <returns>True if properties were successfully queried; otherwise false.</returns>
    public byte InqAvailableProperties(ACBindings.Internal.AvailablePropertySet* o_set) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Browser, ACBindings.Internal.AvailablePropertySet*, byte>)0x0046B940)(ref this, o_set);

    /// <summary>Applies an attribute change to a browser UI element, forwards the update to the base UIElement, and updates the embedded web browser control when the attribute corresponds to the URL property.
    /// <code>Offset: 0x0046B990
    /// void __thiscall UIElement_Browser::OnSetAttribute(UIElement_Browser*,const BaseProperty*)</code>
    /// </summary>
    /// <param name="i_attribute">The property descriptor describing the attribute to set.</param>
    public void OnSetAttribute(ACBindings.Internal.BaseProperty* i_attribute) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Browser, ACBindings.Internal.BaseProperty*, void>)0x0046B990)(ref this, i_attribute);
}

