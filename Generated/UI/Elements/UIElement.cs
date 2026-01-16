namespace ACBindings.Internal;


/// <summary>Represents an interactive UI component capable of handling focus, drag-and-drop, media playback, layout, state transitions, and custom properties within a graphical application.</summary>
/// <remarks>Instances maintain references to child elements, callbacks for drag operations, and internal state used by the rendering system. The struct interacts with MediaMachine, LayoutDesc, and StateDesc objects to present dynamic content.</remarks>
public unsafe struct UIElement : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.UIRegion BaseClass_UIRegion; // ACBindings.Internal.UIRegion

    // Child Types
    public unsafe struct UIElement_vtbl
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
    // UIElement::FunctionSignatureChanged
    public enum FunctionSignatureChanged : uint
    {
    }
    // UIElement::Intialized_Has_Been_Replaced_With_PostInit
    public enum Intialized_Has_Been_Replaced_With_PostInit : uint
    {
    }

    // Members
    public ACBindings.Internal.UIElement* m_itemDragged;
    public ACBindings.Internal.UIElement* m_pFocusElement;
    public ACBindings.Internal.MediaMachine m_mediaMachine;
    public ACBindings.Internal.LayoutDesc* m_layout;
    public ACBindings.Internal.ElementDesc m_desc;
    public uint m_state;
    public ACBindings.Internal.StateDesc* m_curStateDesc;
    public ACBindings.Internal.PropertyCollection m_instanceProperties;
    public ACBindings.Internal.BorderLocation m_currentBorder;
    public int m_DragStartX;
    public int m_DragStartY;
    public int m_DragStartHeight;
    public int m_DragStartWidth;
    public int m_mouseInitialX;
    public int m_mouseInitialY;
    public static delegate* unmanaged[Cdecl]<ACBindings.Internal.UIElement*, ACBindings.Internal.UIElement*, byte> m_dragDropCallback; // function pointer
    public ACBindings.Internal.UILocationData m_defaultLocation;
    public ACBindings.Internal.StringInfo m_TTText;
    public byte m_bShouldBeMouseVisible;
    public byte m_bIsMouseVisible;
    public int m_cursorHotX;
    public int m_cursorHotY;
    public ACBindings.Internal.IDClass____tagDataID m_cursorDID;
    public ACBindings.Internal._7DD0ED236307E660189677EE91B10663 ___u24;
    public uint m_eClampGameView;
    public ACBindings.Internal.Box2D m_surfaceBox;
    public ACBindings.Internal.HashSet___UIListener_ptr m_hashListeners;
    public ACBindings.Internal.HashSetIterator___UIListener_ptr m_iterListeners;
    public uint m_idInputMap;

    // Generated Constructor
    public UIElement(ACBindings.Internal.LayoutDesc* layout, ACBindings.Internal.ElementDesc* full_desc) {
        _ConstructorInternal(layout, full_desc);
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>Sets the element's activatable state, enabling or disabling activation handling based on the provided boolean.
    /// <code>Offset: 0x004592D0
    /// void __thiscall UIElement::SetActivatable(UIElement*,bool)</code>
    /// </summary>
    /// <param name="b">True to mark the element as activatable; false to disable it.</param>
    public void SetActivatable(byte b) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement, byte, void>)0x004592D0)(ref this, b);

    /// <summary>Designates the UI element as temporary based on the provided flag.
    /// <code>Offset: 0x004592F0
    /// void __thiscall UIElement::SetObjectIsTemporary(UIElement*,bool)</code>
    /// </summary>
    /// <param name="b">True to mark the element as temporary; false to clear the temporary designation.</param>
    public void SetObjectIsTemporary(byte b) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement, byte, void>)0x004592F0)(ref this, b);

    /// <summary>Enables or disables dragging for the UI element.
    /// <code>Offset: 0x0045F9D0
    /// void __thiscall UIElement::SetDragable(UIElement*,bool)</code>
    /// </summary>
    /// <param name="b">True to enable dragging; false to disable.</param>
    public void SetDragable(byte b) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement, byte, void>)0x0045F9D0)(ref this, b);

    /// <summary>Sets whether the element activates automatically when shown.
    /// <code>Offset: 0x0045F9F0
    /// void __thiscall UIElement::SetActivateOnShow(UIElement*,bool)</code>
    /// </summary>
    /// <param name="b">True to enable activation on show; false to disable it.</param>
    public void SetActivateOnShow(byte b) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement, byte, void>)0x0045F9F0)(ref this, b);

    /// <summary>Sets the internal flag that determines whether this UI element's position should be persisted across sessions.
    /// <code>Offset: 0x0045FA10
    /// void __thiscall UIElement::SetSaveLocation(UIElement*,bool)</code>
    /// </summary>
    /// <param name="b">True to enable save‑location behavior; false to disable it.</param>
    public void SetSaveLocation(byte b) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement, byte, void>)0x0045FA10)(ref this, b);

    /// <summary>Sets the flag that determines whether the UI element retains its current size across layout changes.
    /// <code>Offset: 0x0045FA30
    /// void __thiscall UIElement::SetSaveSize(UIElement*,bool)</code>
    /// </summary>
    /// <param name="b">True to enable size preservation; false to disable it.</param>
    public void SetSaveSize(byte b) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement, byte, void>)0x0045FA30)(ref this, b);

    /// <summary>Enables or disables resize notifications for the UI element.
    /// <code>Offset: 0x0045FA50
    /// void __thiscall UIElement::SetNotifyOnResize(UIElement*,bool)</code>
    /// </summary>
    /// <param name="b">True to enable notification; false to disable.</param>
    public void SetNotifyOnResize(byte b) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement, byte, void>)0x0045FA50)(ref this, b);

    /// <summary>Sets whether the element notifies listeners when it moves.
    /// <code>Offset: 0x0045FA70
    /// void __thiscall UIElement::SetNotifyOnMove(UIElement*,bool)</code>
    /// </summary>
    /// <param name="b">Enable (true) or disable (false) movement notifications.</param>
    public void SetNotifyOnMove(byte b) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement, byte, void>)0x0045FA70)(ref this, b);

    /// <summary>Configures whether this UI element displays a context menu on interaction.
    /// <code>Offset: 0x0045FA90
    /// void __thiscall UIElement::SetContextMenu(UIElement*,bool)</code>
    /// </summary>
    /// <param name="b">True to enable the context menu; false to disable it.</param>
    public void SetContextMenu(byte b) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement, byte, void>)0x0045FA90)(ref this, b);

    /// <summary>Sets the flag that controls whether this UI element triggers a notification upon its creation.
    /// <code>Offset: 0x0045FAB0
    /// void __thiscall UIElement::SetNotifyOnCreate(UIElement*,bool)</code>
    /// </summary>
    /// <param name="b">True to enable creation notifications; false to disable them.</param>
    public void SetNotifyOnCreate(byte b) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement, byte, void>)0x0045FAB0)(ref this, b);

    /// <summary>Retrieves the nearest ancestor marked as the root element in the UI hierarchy, starting from the current element and moving upward.
    /// <code>Offset: 0x0045FB30
    /// UIElement* __thiscall UIElement::GetRootElement(UIElement*)</code>
    /// </summary>
    /// <returns>A pointer to the root UIElement if one is found; otherwise returns nullptr.</returns>
    public ACBindings.Internal.UIElement* GetRootElement() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement, ACBindings.Internal.UIElement*>)0x0045FB30)(ref this);

    /// <summary>Finds and returns the first ancestor element whose ID matches i_ID, or nullptr if no such ancestor exists.
    /// <code>Offset: 0x0045FB80
    /// UIElement* __thiscall UIElement::GetAncestorByID(UIElement*,const unsigned int)</code>
    /// </summary>
    /// <param name="i_ID">The element identifier to search for among ancestors.</param>
    /// <returns>A pointer to the matching ancestor UIElement, or nullptr when none is found.</returns>
    public ACBindings.Internal.UIElement* GetAncestorByID(uint i_ID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement, uint, ACBindings.Internal.UIElement*>)0x0045FB80)(ref this, i_ID);

    /// <summary>Determines whether a specified UIElement lies in the ancestry chain of this UIElement.
    /// <code>Offset: 0x0045FBB0
    /// bool __thiscall UIElement::IsAncestorOfMe(UIElement*,const UIElement*)</code>
    /// </summary>
    /// <param name="i_pAncestor">The UIElement to test as an ancestor.</param>
    /// <returns>True if i_pAncestor is an ancestor of this element; otherwise, false.</returns>
    public byte IsAncestorOfMe(ACBindings.Internal.UIElement* i_pAncestor) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement, ACBindings.Internal.UIElement*, byte>)0x0045FBB0)(ref this, i_pAncestor);

    /// <summary>Registers the UIElement’s input map with the global input manager using the supplied priority level. Invokes the element’s OnAction handler before performing the registration.
    /// <code>Offset: 0x0045FBE0
    /// bool __thiscall UIElement::RegisterInputMaps(UIElement*,int)</code>
    /// </summary>
    /// <param name="i_nPriority">Priority value used when registering the element’s input map; higher values typically indicate lower priority in event handling order.</param>
    /// <returns>True if the element was successfully registered with the input manager; otherwise false.</returns>
    public byte RegisterInputMaps(int i_nPriority) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement, int, byte>)0x0045FBE0)(ref this, i_nPriority);

    /// <summary>Detaches the element from its input map, performing cleanup and notifying listeners before removal.
    /// <code>Offset: 0x0045FC50
    /// bool __thiscall UIElement::UnregisterInputMaps(UIElement*)</code>
    /// </summary>
    /// <returns>True if the element had a non‑zero input map ID and was successfully unregistered; otherwise false.</returns>
    public byte UnregisterInputMaps() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement, byte>)0x0045FC50)(ref this);

    /// <summary>Processes an input event for a UI element, delegating to its base implementation first before invoking subclass‑specific handling. Returns true if the action was successfully processed.
    /// <code>Offset: 0x0045FCA0
    /// bool __thiscall UIElement::OnAction(UIElement*,const InputEvent*)</code>
    /// </summary>
    /// <param name="this">The UIElement instance receiving the event.</param>
    /// <param name="i_evt">Information about the input action that triggered the call.</param>
    /// <returns>True when the element handled the action; otherwise false.</returns>
    public byte OnAction(ACBindings.Internal.InputEvent* i_evt) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement, ACBindings.Internal.InputEvent*, byte>)0x0045FCA0)(ref this, i_evt);

    /// <summary>Handles an input event for a child UIElement by delegating to the appropriate virtual handler after verifying that the parent element accepts the action.
    /// <code>Offset: 0x0045FCE0
    /// bool __thiscall UIElement::OnChildAction(UIElement*,const UIElement*,const InputEvent*)</code>
    /// </summary>
    /// <param name="this">The UIElement instance processing the child action.</param>
    /// <param name="i_pChild">The child UIElement receiving the event.</param>
    /// <param name="i_evt">The input event data associated with the action.</param>
    /// <returns>True if the child action was successfully handled; otherwise, false.</returns>
    public byte OnChildAction(ACBindings.Internal.UIElement* i_pChild, ACBindings.Internal.InputEvent* i_evt) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement, ACBindings.Internal.UIElement*, ACBindings.Internal.InputEvent*, byte>)0x0045FCE0)(ref this, i_pChild, i_evt);

    /// <summary>Forwards an element message to the UIElementManager's broadcast system and returns whether the operation succeeded.
    /// <code>Offset: 0x0045FD10
    /// bool __thiscall UIElement::DefElementMessageHandler(UIElement*,const UIElementMessageInfo*)</code>
    /// </summary>
    /// <param name="i_rMsg">Message information containing identifiers, parameters, and coordinates for processing.</param>
    /// <returns>True if a manager instance exists and the message was successfully broadcast; otherwise false.</returns>
    public byte DefElementMessageHandler(ACBindings.Internal.UIElementMessageInfo* i_rMsg) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement, ACBindings.Internal.UIElementMessageInfo*, byte>)0x0045FD10)(ref this, i_rMsg);

    /// <summary>Compares the rendering order of this UIElement against a given UIRegion.
    /// <code>Offset: 0x0045FD40
    /// int __thiscall UIElement::CompareZLevel(UIElement*,const UIRegion*)</code>
    /// </summary>
    /// <param name="i_pRegion">The UIRegion to compare with.</param>
    /// <returns>An integer: negative if this element should be rendered before i_pRegion, positive if after, or zero if both share the same order.</returns>
    public int CompareZLevel(ACBindings.Internal.UIRegion* i_pRegion) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement, ACBindings.Internal.UIRegion*, int>)0x0045FD40)(ref this, i_pRegion);

    /// <summary>Starts a resizing operation on the UI element using the specified border and initial mouse coordinates, storing starting dimensions and cursor position while marking the element as in a resize state.
    /// <code>Offset: 0x0045FD80
    /// void __thiscall UIElement::StartResizing(UIElement*,BorderLocation,int,int)</code>
    /// </summary>
    /// <param name="border">The border location being dragged for resizing.</param>
    /// <param name="xInitialMouse">Initial X coordinate of the mouse when the drag started.</param>
    /// <param name="yInitialMouse">Initial Y coordinate of the mouse when the drag started.</param>
    public void StartResizing(ACBindings.Internal.BorderLocation border, int xInitialMouse, int yInitialMouse) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement, ACBindings.Internal.BorderLocation, int, int, void>)0x0045FD80)(ref this, border, xInitialMouse, yInitialMouse);

    /// <summary>Clears an internal flag that indicates the element was being resized and, when appropriate, triggers focus‑loss and action callbacks to signal that resizing has ended.
    /// <code>Offset: 0x0045FE40
    /// void __thiscall UIElement::StopResizing(UIElement*)</code>
    /// </summary>
    public void StopResizing() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement, void>)0x0045FE40)(ref this);

    /// <summary>Initiates a drag operation by recording the element's current position, size, and the initial mouse coordinates. Sets a flag indicating movement has begun unless dragging is already disabled or suspended.
    /// <code>Offset: 0x0045FE90
    /// void __thiscall UIElement::StartMovement(UIElement*,int,int)</code>
    /// </summary>
    /// <param name="xInitialMouse">The X coordinate of the mouse at the start of the drag.</param>
    /// <param name="yInitialMouse">The Y coordinate of the mouse at the start of the drag.</param>
    public void StartMovement(int xInitialMouse, int yInitialMouse) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement, int, int, void>)0x0045FE90)(ref this, xInitialMouse, yInitialMouse);

    /// <summary>Halts any active movement of the UI element by clearing its movement flag.
    /// <code>Offset: 0x0045FF00
    /// void __thiscall UIElement::StopMovement(UIElement*)</code>
    /// </summary>
    public void StopMovement() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement, void>)0x0045FF00)(ref this);

    /// <summary>Updates an element’s position in response to mouse movement, applying optional grid snapping and ensuring the element remains within its parent bounds.
    /// <code>Offset: 0x0045FF10
    /// void __thiscall UIElement::MouseMoveElement(UIElement*,int,int)</code>
    /// </summary>
    /// <param name="xWindow">The current horizontal mouse coordinate relative to the window.</param>
    /// <param name="yWindow">The current vertical mouse coordinate relative to the window.</param>
    public void MouseMoveElement(int xWindow, int yWindow) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement, int, int, void>)0x0045FF10)(ref this, xWindow, yWindow);

    /// <summary>Updates this element's cursor data and notifies the UI system to apply the new cursor configuration.
    /// <code>Offset: 0x00460030
    /// void __thiscall UIElement::SetCursor(_DWORD*,int,int,int)</code>
    /// </summary>
    /// <param name="a2">Identifier for the cursor graphic to display.</param>
    /// <param name="a3">Horizontal offset of the cursor hotspot relative to its image origin.</param>
    /// <param name="a4">Vertical offset of the cursor hotspot relative to its image origin.</param>
    public void SetCursor(int a2, int a3, int a4) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement, int, int, int, void>)0x00460030)(ref this, a2, a3, a4);

    /// <summary>Removes any custom cursor from this element, resetting hot‑spot coordinates to (0, 0). The UI system is then prompted to update its cursor state.
    /// <code>Offset: 0x00460060
    /// void __thiscall UIElement::UnSetCursor(UIElement*)</code>
    /// </summary>
    public void UnSetCursor() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement, void>)0x00460060)(ref this);

    /// <summary>Retrieves the width and height of the UI element's image when an image is present.
    /// <code>Offset: 0x00460090
    /// bool __thiscall UIElement::InqImageSize(UIElement*,int*,int*)</code>
    /// </summary>
    /// <param name="width">Receives the image width if available; otherwise remains unchanged.</param>
    /// <param name="height">Receives the image height if available; otherwise remains unchanged.</param>
    /// <returns>True if an image exists and its dimensions were successfully returned; otherwise, false.</returns>
    public byte InqImageSize(int* width, int* height) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement, int*, int*, byte>)0x00460090)(ref this, width, height);

    /// <summary>Positions the UI element so that its center aligns with the specified (x, y) coordinates.
    /// <code>Offset: 0x004600D0
    /// void __thiscall UIElement::CenterAt(UIElement*,const int,const int)</code>
    /// </summary>
    /// <param name="x">The horizontal coordinate to center the element at.</param>
    /// <param name="y">The vertical coordinate to center the element at.</param>
    public void CenterAt(int x, int y) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement, int, int, void>)0x004600D0)(ref this, x, y);

    /// <summary>Retrieves the original bounds and rendering depth of a UI element for layout calculations.
    /// <code>Offset: 0x00460110
    /// void __thiscall UIElement::GetOriginalPosition(UIElement*,Box2D*,int*)</code>
    /// </summary>
    /// <param name="position">The Box2D structure that receives the element's top-left (m_x0, m_y0) and bottom-right (m_x1, m_y1) coordinates.</param>
    /// <param name="zlevel">An integer pointer that will contain the element's z‑level after the call.</param>
    public void GetOriginalPosition(ACBindings.Internal.Box2D* position, int* zlevel) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement, ACBindings.Internal.Box2D*, int*, void>)0x00460110)(ref this, position, zlevel);

    /// <summary>Retrieves the current bounding box and z‑level of a UI element.
    /// <code>Offset: 0x00460180
    /// void __thiscall UIElement::GetCurrentPosition(UIElement*,Box2D*,int*)</code>
    /// </summary>
    /// <param name="position">Receives a copy of the element's Box2D rectangle representing its on‑screen bounds.</param>
    /// <param name="zlevel">Outputs the element's z‑level, determining its rendering order relative to sibling regions.</param>
    public void GetCurrentPosition(ACBindings.Internal.Box2D* position, int* zlevel) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement, ACBindings.Internal.Box2D*, int*, void>)0x00460180)(ref this, position, zlevel);

    /// <summary>Indicates whether the element owns its associated object based on an internal flag.
    /// <code>Offset: 0x004601D0
    /// bool __thiscall UIElement::GetShouldOwnObject(UIElement*)</code>
    /// </summary>
    /// <param name="this">The UIElement instance being queried.</param>
    /// <returns>True when the ownership bit is set; otherwise false.</returns>
    public byte GetShouldOwnObject() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement, byte>)0x004601D0)(ref this);

    /// <summary>Designates this UI element as the root component, toggling an internal flag and adjusting focus handling based on the element's action callback status.
    /// <code>Offset: 0x004601E0
    /// void __thiscall UIElement::SetIsRootElement(UIElement*,bool)</code>
    /// </summary>
    /// <param name="b">True to mark the element as the root; false to clear the root designation.</param>
    public void SetIsRootElement(byte b) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement, byte, void>)0x004601E0)(ref this, b);

    /// <summary>Enqueues this UI element into the global delete queue managed by UIElementManager when an instance is present; otherwise performs no action.
    /// <code>Offset: 0x00460250
    /// void __thiscall UIElement::AddToDeleteQueue(UIElement*)</code>
    /// </summary>
    public void AddToDeleteQueue() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement, void>)0x00460250)(ref this);

    /// <summary>Registers a UI element class with the manager using a unique type identifier and a factory callback.
    /// <code>Offset: 0x00460270
    /// void __cdecl UIElement::RegisterElementClass(unsigned int,UIElement*(__cdecl*createMethod)(const LayoutDesc*, const ElementDesc*))</code>
    /// </summary>
    /// <param name="type">Identifier for the element class to register.</param>
    /// <param name="createMethod">Pointer to the function that creates an instance of the element from layout and description data.</param>
    public static void RegisterElementClass(uint type, delegate* unmanaged[Cdecl]<ACBindings.Internal.LayoutDesc*, ACBindings.Internal.ElementDesc*, ACBindings.Internal.UIElement*> createMethod) => ((delegate* unmanaged[Cdecl]<uint, delegate* unmanaged[Cdecl]<ACBindings.Internal.LayoutDesc*, ACBindings.Internal.ElementDesc*, ACBindings.Internal.UIElement*>, void>)0x00460270)(type, createMethod);

    /// <summary>Determines whether the element should be considered visible to mouse input based on its internal flag or the presence of a valid tooltip text.
    /// <code>Offset: 0x00460290
    /// bool __thiscall UIElement::GetShouldBeMouseVisible(UIElement*)</code>
    /// </summary>
    /// <returns>True when the element’s flag (0x80) is set or it contains a non‑empty tooltip; otherwise false.</returns>
    public byte GetShouldBeMouseVisible() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement, byte>)0x00460290)(ref this);

    /// <summary>
    /// Attempts to assign input focus to this UI element. The element is flagged as having focus and the root of the UI hierarchy records it as the current focused element. Focus assignment succeeds only when the root permits focus changes; otherwise the method returns false.
    /// 
    /// <code>Offset: 0x004602C0
    /// bool __thiscall UIElement::TakeFocus(UIElement*)</code>
    /// </summary>
    /// <returns>True if focus was successfully set; otherwise false.</returns>
    public byte TakeFocus() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement, byte>)0x004602C0)(ref this);

    /// <summary>Determines whether the element currently has input focus within the UI system.
    /// <code>Offset: 0x00460310
    /// bool __thiscall UIElement::GetHasFocus(UIElement*)</code>
    /// </summary>
    /// <returns>True if this element is the active focus target; otherwise, false.</returns>
    public byte GetHasFocus() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement, byte>)0x00460310)(ref this);

    /// <summary>Retrieves the child element currently holding keyboard focus within this UI element.
    /// <code>Offset: 0x00460330
    /// UIElement* __thiscall UIElement::GetFocusDescendant(UIElement*)</code>
    /// </summary>
    /// <returns>The focused UIElement if one exists; otherwise, nullptr.</returns>
    public ACBindings.Internal.UIElement* GetFocusDescendant() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement, ACBindings.Internal.UIElement*>)0x00460330)(ref this);

    /// <summary>Updates the element's internal mouse visibility flag by combining its desired visibility state with any ongoing action that may alter visibility.
    /// <code>Offset: 0x00460340
    /// void __thiscall UIElement::UpdateMouseVisibility(UIElement*)</code>
    /// </summary>
    public void UpdateMouseVisibility() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement, void>)0x00460340)(ref this);

    /// <summary>Updates the element's clamp game view edge and propagates the change to its region when an object or parent exists.
    /// <code>Offset: 0x00460370
    /// void __thiscall UIElement::SetClampGameViewEdge(UIElement*,unsigned int)</code>
    /// </summary>
    /// <param name="i_eEdge">The new clamp game view edge value to apply.</param>
    public void SetClampGameViewEdge(uint i_eEdge) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement, uint, void>)0x00460370)(ref this, i_eEdge);

    /// <summary>Checks whether this element is visible within the active UI hierarchy by verifying its own visibility flag, the flags of all ancestor elements, and confirming that the root ancestor matches the one stored in UIElementManager.
    /// <code>Offset: 0x004603A0
    /// bool __thiscall UIElement::IsVisible(UIElement*)</code>
    /// </summary>
    /// <returns>True if the element and every ancestor are marked as visible and the top‑level element equals the manager’s current root; otherwise false.</returns>
    public byte IsVisible() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement, byte>)0x004603A0)(ref this);

    /// <summary>Broadcasts a message from this element to all registered listeners via the global UIElementManager.
    /// <code>Offset: 0x00460410
    /// bool __thiscall UIElement::BroadcastElementMessage(UIElement*,unsigned int,unsigned int,unsigned int)</code>
    /// </summary>
    /// <param name="i_idMessage">The identifier of the message to send.</param>
    /// <param name="i_dwParam1">First parameter data for the message.</param>
    /// <param name="i_dwParam2">Second parameter data for the message.</param>
    /// <returns>True if the message was successfully broadcast; otherwise false (e.g., no UIElementManager instance).</returns>
    public byte BroadcastElementMessage(uint i_idMessage, uint i_dwParam1, uint i_dwParam2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement, uint, uint, uint, byte>)0x00460410)(ref this, i_idMessage, i_dwParam1, i_dwParam2);

    /// <summary>Assigns the specified enum value to the UIElement's property identified by the given attribute ID, handling reference counts and triggering any associated change callbacks.
    /// <code>Offset: 0x00460470
    /// bool __thiscall UIElement::SetAttribute_Enum(UIElement*,unsigned int,unsigned int)</code>
    /// </summary>
    /// <param name="attribute">The identifier of the property to set.</param>
    /// <param name="val">The enumeration value to assign to that property.</param>
    /// <returns>True if the property was successfully updated and its change handler invoked; otherwise false.</returns>
    public byte SetAttribute_Enum(uint attribute, uint val) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement, uint, uint, byte>)0x00460470)(ref this, attribute, val);

    /// <summary>Sets a numeric instance property on the UI element identified by an attribute ID, updating its value and invoking focus‑loss handling if necessary.
    /// <code>Offset: 0x00460530
    /// bool __thiscall UIElement::SetAttribute_InstanceID(UIElement*,unsigned int,unsigned int)</code>
    /// </summary>
    /// <param name="this">The UI element whose attribute is to be set.</param>
    /// <param name="attribute">Identifier of the attribute/property to modify.</param>
    /// <param name="val">New numeric value for the specified property.</param>
    /// <returns>True when the property was found and updated successfully; otherwise false.</returns>
    public byte SetAttribute_InstanceID(uint attribute, uint val) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement, uint, uint, byte>)0x00460530)(ref this, attribute, val);

    /// <summary>Assigns a string-based value to a UI element's property identified by an unsigned integer attribute key. The operation updates the underlying property if available and triggers any associated focus loss handling. Returns true when the property change succeeds; otherwise returns false.
    /// <code>Offset: 0x004605F0
    /// bool __thiscall UIElement::SetAttribute_StringInfo(UIElement*,unsigned int,StringInfo)</code>
    /// </summary>
    /// <param name="attribute">The identifier of the property to set.</param>
    /// <param name="val">The StringInfo value containing the new string data for the property.</param>
    /// <returns>True if the attribute was updated and focus events processed successfully; otherwise false.</returns>
    public byte SetAttribute_StringInfo(uint attribute, ACBindings.Internal.StringInfo val) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement, uint, ACBindings.Internal.StringInfo, byte>)0x004605F0)(ref this, attribute, val);

    /// <summary>Sets an integer value on the UI element for the property identified by <paramref name="attribute"/> and triggers the element’s focus‑loss handler when the assignment succeeds.
    /// <code>Offset: 0x004606B0
    /// bool __thiscall UIElement::SetAttribute_Int(UIElement*,unsigned int,int)</code>
    /// </summary>
    /// <param name="attribute">Identifier of the property to modify.</param>
    /// <param name="val">Integer value to assign to the property.</param>
    /// <returns>True if the property exists, the integer is accepted by the property logic, and the element’s OnLoseFocus callback returns true; otherwise false.</returns>
    public byte SetAttribute_Int(uint attribute, int val) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement, uint, int, byte>)0x004606B0)(ref this, attribute, val);

    /// <summary>Assigns a floating‑point value to the specified attribute of this UIElement. If the value changes successfully, triggers loss‑of‑focus handling and returns true; otherwise returns false.
    /// <code>Offset: 0x00460760
    /// bool __thiscall UIElement::SetAttribute_Float(UIElement*,unsigned int,float)</code>
    /// </summary>
    /// <param name="attribute">Identifier for the attribute to modify.</param>
    /// <param name="val">The float value to set for the attribute.</param>
    /// <returns>True if the attribute was updated and focus handling occurred; otherwise, false.</returns>
    public byte SetAttribute_Float(uint attribute, float val) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement, uint, float, byte>)0x00460760)(ref this, attribute, val);

    /// <summary>Sets a boolean attribute on the element, applying any associated change logic and returning whether the operation succeeded.
    /// <code>Offset: 0x00460820
    /// bool __thiscall UIElement::SetAttribute_Bool(UIElement*,unsigned int,bool)</code>
    /// </summary>
    /// <param name="attribute">Identifier of the property to set.</param>
    /// <param name="val">Boolean value to assign to the property.</param>
    /// <returns>True if the attribute was updated successfully; otherwise false.</returns>
    public byte SetAttribute_Bool(uint attribute, byte val) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement, uint, byte, byte>)0x00460820)(ref this, attribute, val);

    /// <summary>Assigns an integer value to a data attribute identified by a property ID on this UI element. The update succeeds only if the attribute exists and accepts an integer input.
    /// <code>Offset: 0x004608D0
    /// bool __thiscall UIElement::SetAttribute_DataID(void*,unsigned int,int)</code>
    /// </summary>
    /// <param name="i_eName">Identifier of the attribute to modify.</param>
    /// <param name="a3">Integer value to assign to the attribute.</param>
    /// <returns>True when the attribute is present and updated; otherwise false.</returns>
    public byte SetAttribute_DataID(uint i_eName, int a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement, uint, int, byte>)0x004608D0)(ref this, i_eName, a3);

    /// <summary>Retrieves the enumeration value associated with a specified attribute from a UI element, storing it in the supplied output parameter.
    /// <code>Offset: 0x00460990
    /// bool __thiscall UIElement::GetAttribute_Enum(UIElement*,unsigned int,unsigned int*)</code>
    /// </summary>
    /// <param name="attribute">Identifier of the attribute whose enum value is requested.</param>
    /// <param name="val">Receives the retrieved enum value; set to 0 when no valid value is found.</param>
    /// <returns>True if an enumeration value was obtained (via the element’s action callback or a direct property lookup); otherwise false.</returns>
    public byte GetAttribute_Enum(uint attribute, uint* val) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement, uint, uint*, byte>)0x00460990)(ref this, attribute, val);

    /// <summary>Retrieves the unsigned integer value associated with a given attribute from a UI element, storing it through the provided pointer.
    /// <code>Offset: 0x00460A60
    /// bool __thiscall UIElement::GetAttribute_InstanceID(UIElement*,unsigned int,unsigned int*)</code>
    /// </summary>
    /// <param name="attribute">Identifier for the attribute whose value is requested.</param>
    /// <param name="val">Pointer to receive the retrieved unsigned integer; set to 0 on failure.</param>
    /// <returns>True if the attribute was found and its value extracted successfully; otherwise false.</returns>
    public byte GetAttribute_InstanceID(uint attribute, uint* val) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement, uint, uint*, byte>)0x00460A60)(ref this, attribute, val);

    /// <summary>
    /// Obtains the integer value associated with the specified attribute of a UI element, storing it through the provided output parameter.
    /// 
    /// <code>Offset: 0x00460B30
    /// bool __thiscall UIElement::GetAttribute_Int(UIElement*,unsigned int,int*)</code>
    /// </summary>
    /// <param name="attribute">The identifier for the attribute to retrieve.</param>
    /// <param name="val">Pointer to an int that receives the retrieved value; set to zero if retrieval fails.</param>
    /// <returns>True if the attribute exists and its value was successfully retrieved; otherwise, false.</returns>
    public byte GetAttribute_Int(uint attribute, int* val) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement, uint, int*, byte>)0x00460B30)(ref this, attribute, val);

    /// <summary>Gets the value of a specified float attribute for this UI element.
    /// <code>Offset: 0x00460BF0
    /// bool __thiscall UIElement::GetAttribute_Float(UIElement*,unsigned int,float*)</code>
    /// </summary>
    /// <param name="attribute">The identifier of the attribute whose floating-point value is requested.</param>
    /// <param name="val">Receives the retrieved float value; set to 0.0 if the attribute cannot be found or an error occurs.</param>
    /// <returns>True if the attribute value was successfully obtained, otherwise false.</returns>
    public byte GetAttribute_Float(uint attribute, float* val) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement, uint, float*, byte>)0x00460BF0)(ref this, attribute, val);

    /// <summary>Retrieves a boolean attribute from a UI element, storing the result in the provided output parameter.
    /// <code>Offset: 0x00460CC0
    /// bool __thiscall UIElement::GetAttribute_Bool(UIElement*,unsigned int,bool*)</code>
    /// </summary>
    /// <param name="attribute">Identifier of the attribute to retrieve.</param>
    /// <param name="val">Pointer to store the retrieved value; set to false if the attribute is unavailable.</param>
    /// <returns>True if the attribute was found and its value successfully obtained; otherwise, false.</returns>
    public byte GetAttribute_Bool(uint attribute, byte* val) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement, uint, byte*, byte>)0x00460CC0)(ref this, attribute, val);

    /// <summary>Retrieves the Data ID associated with the specified attribute name for the UI element, storing it in the supplied IDClass instance.
    /// <code>Offset: 0x00460D80
    /// bool __thiscall UIElement::GetAttribute_DataID(int*,unsigned int,IDClass&lt;_tagDataID,32,0&gt;*)</code>
    /// </summary>
    /// <param name="i_eName">Identifier of the attribute to query.</param>
    /// <param name="a3">Output parameter where the retrieved Data ID is stored; set to INVALID_DID_53 if not found.</param>
    /// <returns>True if the attribute exists and its Data ID was successfully obtained; otherwise, false.</returns>
    public byte GetAttribute_DataID(uint i_eName, ACBindings.Internal.IDClass____tagDataID* a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement, uint, ACBindings.Internal.IDClass____tagDataID*, byte>)0x00460D80)(ref this, i_eName, a3);

    /// <summary>Starts a tooltip anchored at the current mouse position using the element's tooltip text or its default action, optionally setting a custom display duration.
    /// <code>Offset: 0x00460E50
    /// UIElement* __thiscall UIElement::StartTooltipAtMouse(UIElement*,long double)</code>
    /// </summary>
    /// <param name="i_tTooltipDuration">Custom duration in seconds for which the tooltip remains visible; zero causes the system to use the default duration.</param>
    /// <returns>Pointer to the created tooltip UIElement, or null if no tooltip could be displayed.</returns>
    public ACBindings.Internal.UIElement* StartTooltipAtMouse(double i_tTooltipDuration) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement, double, ACBindings.Internal.UIElement*>)0x00460E50)(ref this, i_tTooltipDuration);

    /// <summary>Handles a mouse‑down input on the UI element by delegating to its base region, translating screen coordinates into element space, and broadcasting an event message through the UI element manager. If the element has the special flag set and the specified button is used, it also sends an additional message.
    /// <code>Offset: 0x00460FF0
    /// void __thiscall UIElement::MouseDown(UIElement*,unsigned int,unsigned int,unsigned int)</code>
    /// </summary>
    /// <param name="xWindow">X coordinate of the mouse cursor in window space.</param>
    /// <param name="yWindow">Y coordinate of the mouse cursor in window space.</param>
    /// <param name="button">Identifier of the mouse button that was pressed.</param>
    public void MouseDown(uint xWindow, uint yWindow, uint button) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement, uint, uint, uint, void>)0x00460FF0)(ref this, xWindow, yWindow, button);

    /// <summary>Transmits a mouse-tap event for this UI element, converting screen coordinates into element-relative positions and broadcasting it through the UIElementManager.
    /// <code>Offset: 0x004610C0
    /// void __thiscall UIElement::MouseTap(UIElement*,unsigned int,unsigned int,unsigned int)</code>
    /// </summary>
    /// <param name="xWindow">Screen X coordinate of the tap.</param>
    /// <param name="yWindow">Screen Y coordinate of the tap.</param>
    /// <param name="button">Mouse button identifier that triggered the tap.</param>
    public void MouseTap(uint xWindow, uint yWindow, uint button) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement, uint, uint, uint, void>)0x004610C0)(ref this, xWindow, yWindow, button);

    /// <summary>Processes a key‑up event by broadcasting an element message to the UI system.
    /// <code>Offset: 0x00461140
    /// bool __thiscall UIElement::KeyUp(UIElement*,unsigned int)</code>
    /// </summary>
    /// <param name="button">The identifier of the key that was released.</param>
    /// <returns>True if the message was successfully broadcast; otherwise, false when no UIElementManager instance is available.</returns>
    public byte KeyUp(uint button) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement, uint, byte>)0x00461140)(ref this, button);

    /// <summary>Notifies listeners that a key has been pressed on the element by broadcasting a key‑down message.
    /// <code>Offset: 0x004611A0
    /// bool __thiscall UIElement::KeyDown(UIElement*,unsigned int,float)</code>
    /// </summary>
    /// <param name="button">The identifier of the pressed button/key.</param>
    /// <param name="i_fExtent">The duration or extent of the key press, expressed in seconds.</param>
    /// <returns>True if the broadcast succeeds; otherwise false.</returns>
    public byte KeyDown(uint button, float i_fExtent) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement, uint, float, byte>)0x004611A0)(ref this, button, i_fExtent);

    /// <summary>Resizes the UI element by updating its position and dimensions during a border drag operation, applying constraints such as minimum/maximum sizes and optional grid snapping.
    /// <code>Offset: 0x00461210
    /// void __thiscall UIElement::MouseResizeElement(UIElement*,int,int)</code>
    /// </summary>
    /// <param name="xWindow">Current horizontal mouse coordinate relative to the window or parent container.</param>
    /// <param name="yWindow">Current vertical mouse coordinate relative to the window or parent container.</param>
    public void MouseResizeElement(int xWindow, int yWindow) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement, int, int, void>)0x00461210)(ref this, xWindow, yWindow);

    /// <summary>Updates the element's internal flag for whether the mouse cursor is over it and sends a mouse‑over message to any interested listeners.
    /// <code>Offset: 0x00461680
    /// void __thiscall UIElement::MouseOver(UIElement*,bool)</code>
    /// </summary>
    /// <param name="over">True when the cursor is hovering over the element; false otherwise.</param>
    public void MouseOver(byte over) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement, byte, void>)0x00461680)(ref this, over);

    /// <summary>Updates the internal state to reflect whether the mouse cursor is positioned over the top area of the UI element and notifies listeners via a broadcast message.
    /// <code>Offset: 0x004616B0
    /// void __thiscall UIElement::MouseOverTop(UIElement*,bool)</code>
    /// </summary>
    /// <param name="overTop">True if the mouse is over the top region; false otherwise.</param>
    public void MouseOverTop(byte overTop) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement, byte, void>)0x004616B0)(ref this, overTop);

    /// <summary>Replaces a target UI element with a newly created child element derived from its layout, performing a drag‑drop operation.
    /// <code>Offset: 0x004616E0
    /// bool __thiscall UIElement::DragItem(UIElement*,UIElement**)</code>
    /// </summary>
    /// <param name="elem">Pointer to the UIElement being dragged; will be updated if replacement succeeds.</param>
    /// <returns>True when the element was successfully replaced and broadcasted; otherwise false.</returns>
    public byte DragItem(ACBindings.Internal.UIElement** elem) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement, ACBindings.Internal.UIElement**, byte>)0x004616E0)(ref this, elem);

    /// <summary>Finds the UI element that should handle a drag‑and‑drop operation for the supplied element, returning either the current element itself when it is eligible or delegating to the element’s action handler to determine an appropriate catcher.
    /// <code>Offset: 0x004617D0
    /// UIElement* __thiscall UIElement::GetDragAndDropCatcher(UIElement*,UIElement*)</code>
    /// </summary>
    /// <param name="elem">The element currently being dragged (or considered as a potential drop target).</param>
    /// <returns>The UIElement that will catch the drag‑and‑drop operation, or null if none is suitable.</returns>
    public ACBindings.Internal.UIElement* GetDragAndDropCatcher(ACBindings.Internal.UIElement* elem) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement, ACBindings.Internal.UIElement*, ACBindings.Internal.UIElement*>)0x004617D0)(ref this, elem);

    /// <summary>Handles a dropped item by broadcasting a drop message to registered listeners and signals acceptance of the drop.
    /// <code>Offset: 0x00461860
    /// bool __thiscall UIElement::CatchDroppedItem(UIElement*,DragDropInfo*)</code>
    /// </summary>
    /// <param name="i_pcDDI">Information about the drag-and-drop operation, including source element and data.</param>
    /// <returns>True when the drop has been accepted; this implementation always returns true.</returns>
    public byte CatchDroppedItem(ACBindings.Internal.DragDropInfo* i_pcDDI) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement, ACBindings.Internal.DragDropInfo*, byte>)0x00461860)(ref this, i_pcDDI);

    /// <summary>Finalizes a drag‑and‑drop operation by broadcasting a completion message, indicating success or failure based on DragDropInfo data.
    /// <code>Offset: 0x00461880
    /// void __thiscall UIElement::DragAndDropComplete(UIElement*,DragDropInfo*)</code>
    /// </summary>
    /// <param name="i_pcDDI">Pointer to the structure containing drag‑and‑drop information used in the broadcast.</param>
    public void DragAndDropComplete(ACBindings.Internal.DragDropInfo* i_pcDDI) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement, ACBindings.Internal.DragDropInfo*, void>)0x00461880)(ref this, i_pcDDI);

    /// <summary>
    /// Sets the tooltip for this UI element to the specified text, updating internal state and visibility as needed.
    /// 
    /// <code>Offset: 0x004618A0
    /// void __thiscall UIElement::SetTooltip(UIElement*,const StringInfo*)</code>
    /// </summary>
    /// <param name="text">The StringInfo containing the new tooltip text.</param>
    public void SetTooltip(ACBindings.Internal.StringInfo* text) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement, ACBindings.Internal.StringInfo*, void>)0x004618A0)(ref this, text);

    /// <summary>Creates a UIObject representation of the calling UIElement, allocating either a lightweight or full surface‑based object depending on flags and attributes. The new object is stored through the provided output pointer. Returns true when creation succeeds.
    /// <code>Offset: 0x00461920
    /// bool __thiscall UIElement::MakeUIObject(UIElement*,UIObject**)</code>
    /// </summary>
    /// <param name="o_pcUIObject">Pointer to receive the newly allocated UIObject instance.</param>
    /// <returns>True if the UIObject was successfully created; otherwise, false.</returns>
    public byte MakeUIObject(ACBindings.Internal.UIObject** o_pcUIObject) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement, ACBindings.Internal.UIObject**, byte>)0x00461920)(ref this, o_pcUIObject);

    /// <summary>Assigns a new UIObject to this element, detaching any existing object and integrating the new one into the rendering system with updated properties.
    /// <code>Offset: 0x00461BA0
    /// bool __thiscall UIElement::SetUIObject(UIElement*,UIObject*)</code>
    /// </summary>
    /// <param name="i_pcUIObject">The UIObject to associate with this element; may be null to clear the association.</param>
    /// <returns>True after updating the element's object reference.</returns>
    public byte SetUIObject(ACBindings.Internal.UIObject* i_pcUIObject) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement, ACBindings.Internal.UIObject*, byte>)0x00461BA0)(ref this, i_pcUIObject);

    /// <summary>Sets whether the UI element should own its associated object, updating an internal flag and invoking focus‑loss or action callbacks as necessary.
    /// <code>Offset: 0x00461CB0
    /// void __thiscall UIElement::SetShouldOwnObject(UIElement*,bool)</code>
    /// </summary>
    /// <param name="b">True to enable ownership; false to disable it.</param>
    public void SetShouldOwnObject(byte b) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement, byte, void>)0x00461CB0)(ref this, b);

    /// <summary>Activates the element when visible and not already active, registering it with the UI manager and invoking its action handlers.
    /// <code>Offset: 0x00461D60
    /// bool __thiscall UIElement::Activate(UIElement*)</code>
    /// </summary>
    /// <returns>True if activation succeeded; otherwise false.</returns>
    public byte Activate() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement, byte>)0x00461D60)(ref this);

    /// <summary>Deactivates the UI element by clearing its active state flag, notifying the UI element manager, and handling focus cleanup.
    /// <code>Offset: 0x00461E30
    /// bool __thiscall UIElement::Deactivate(UIElement*)</code>
    /// </summary>
    /// <returns>True if the element was active and successfully deactivated; otherwise, false.</returns>
    public byte Deactivate() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement, byte>)0x00461E30)(ref this);

    /// <summary>Releases input focus held by this UI element, clears the reference in the root element, and notifies the UIElementManager to reset its focus pointer if needed.
    /// <code>Offset: 0x00461EC0
    /// bool __thiscall UIElement::RelinquishFocus(UIElement*)</code>
    /// </summary>
    /// <returns>Always returns true indicating that the focus relinquishment succeeded.</returns>
    public byte RelinquishFocus() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement, byte>)0x00461EC0)(ref this);

    /// <summary>Sets the element's desired mouse visibility and updates its internal flag accordingly. The method evaluates the current state, optionally triggers an action callback to determine visibility, and notifies the UI manager if the visibility changes.
    /// <code>Offset: 0x00461F10
    /// void __thiscall UIElement::SetMouseVisible(UIElement*,bool)</code>
    /// </summary>
    /// <param name="i_bShouldBeMouseVisible">Specifies whether the element should be able to display the mouse cursor.</param>
    public void SetMouseVisible(byte i_bShouldBeMouseVisible) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement, byte, void>)0x00461F10)(ref this, i_bShouldBeMouseVisible);

    /// <summary>Determines the current UI object mode of this element and writes it into the supplied output parameter.
    /// <code>Offset: 0x00461FB0
    /// void __thiscall UIElement::GetCurrentUIObjectMode(UIElement*,unsigned int*)</code>
    /// </summary>
    /// <param name="i_eMode">Pointer to store the resulting UI object mode value.</param>
    public void GetCurrentUIObjectMode(uint* i_eMode) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement, uint*, void>)0x00461FB0)(ref this, i_eMode);

    /// <summary>Retrieves the scaling factor of the UI object associated with this element, or returns a unit vector when no object exists or the element is in specific modes.
    /// <code>Offset: 0x00462040
    /// Vector3* __thiscall UIElement::GetObjectScale(UIElement*,Vector3*)</code>
    /// </summary>
    /// <param name="result">The output Vector3 that receives the scale value.</param>
    /// <returns>The supplied result pointer after it has been populated.</returns>
    public ACBindings.Internal.Vector3* GetObjectScale(ACBindings.Internal.Vector3* result) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement, ACBindings.Internal.Vector3*, ACBindings.Internal.Vector3*>)0x00462040)(ref this, result);

    /// <summary>Updates the attached UI object's scaling factors based on the element's current size, adjusting for aspect ratio when applicable.
    /// <code>Offset: 0x004620C0
    /// bool __thiscall UIElement::UpdateObjectScale(UIElement*)</code>
    /// </summary>
    /// <returns>true if the object's scale is changed; otherwise false (no object, mode 2 or 3, or unchanged).</returns>
    public byte UpdateObjectScale() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement, byte>)0x004620C0)(ref this);

    /// <summary>Retrieves the bounding rectangle representing the element’s surface area, delegating to the base region when a specific flag is set.
    /// <code>Offset: 0x00462220
    /// Box2D* __thiscall UIElement::GetSurfaceBox(UIElement*,Box2D*)</code>
    /// </summary>
    /// <param name="this">The UIElement instance whose surface box is requested.</param>
    /// <param name="result">Pointer to a Box2D structure that will receive the resulting coordinates.</param>
    /// <returns>Pointer to the supplied Box2D containing the calculated surface rectangle.</returns>
    public ACBindings.Internal.Box2D* GetSurfaceBox(ACBindings.Internal.Box2D* result) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement, ACBindings.Internal.Box2D*, ACBindings.Internal.Box2D*>)0x00462220)(ref this, result);

    /// <summary>Updates the element’s surface bounding box to match its current transform and size. When <paramref name="i_bPositionUpdate"/> is true it adjusts only the origin of the box; otherwise it recomputes the box’s width and height while keeping the origin unchanged.
    /// <code>Offset: 0x00462270
    /// bool __thiscall UIElement::UpdateSurfaceBox(UIElement*,const bool)</code>
    /// </summary>
    /// <param name="i_bPositionUpdate">If true, updates the box origin to reflect the element's position; if false, recalculates its dimensions based on current scale.</param>
    /// <returns>Always returns <c>true</c> to indicate success.</returns>
    public byte UpdateSurfaceBox(byte i_bPositionUpdate) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement, byte, byte>)0x00462270)(ref this, i_bPositionUpdate);

    /// <summary>Changes the element’s visibility, propagating the update to its UIRegion and notifying listeners of any state transitions.
    /// <code>Offset: 0x00462390
    /// void __thiscall UIElement::SetVisible(UIElement*,bool)</code>
    /// </summary>
    /// <param name="visible">True to make the element visible; false to hide it.</param>
    public void SetVisible(byte visible) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement, byte, void>)0x00462390)(ref this, visible);

    /// <summary>Processes a UI element message by updating internal state, managing focus transitions, and delegating to the base OnLoseFocus handler.
    /// <code>Offset: 0x00462420
    /// UIElementMessageListenResult __thiscall UIElement::ListenToElementMessage(UIElement*,const UIElementMessageInfo*)</code>
    /// </summary>
    /// <param name="i_rMsg">Information about the incoming message, including its identifier, source element, parameters, and coordinates.</param>
    /// <returns>The result of handling the message, typically indicating whether it was processed or ignored.</returns>
    public ACBindings.Internal.UIElementMessageListenResult ListenToElementMessage(ACBindings.Internal.UIElementMessageInfo* i_rMsg) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement, ACBindings.Internal.UIElementMessageInfo*, ACBindings.Internal.UIElementMessageListenResult>)0x00462420)(ref this, i_rMsg);

    /// <summary>Retrieves the set of available properties for this UIElement and writes them into the supplied AvailablePropertySet.
    /// <code>Offset: 0x004625B0
    /// bool __thiscall UIElement::InqAvailableProperties(UIElement*,AvailablePropertySet*)</code>
    /// </summary>
    /// <param name="set">The collection to receive the property descriptors.</param>
    /// <returns>True if a master property was found and the query succeeded; otherwise false.</returns>
    public byte InqAvailableProperties(ACBindings.Internal.AvailablePropertySet* set) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement, ACBindings.Internal.AvailablePropertySet*, byte>)0x004625B0)(ref this, set);

    /// <summary>Handles mouse hover over the element, optionally showing its tooltip and broadcasting a hover event to registered listeners.
    /// <code>Offset: 0x00462600
    /// bool __thiscall UIElement::MouseHover(UIElement*,int,int)</code>
    /// </summary>
    /// <param name="xWindow">X coordinate of the cursor in window space.</param>
    /// <param name="yWindow">Y coordinate of the cursor in window space.</param>
    /// <returns>True if a tooltip was started during this hover; otherwise, false.</returns>
    public byte MouseHover(int xWindow, int yWindow) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement, int, int, byte>)0x00462600)(ref this, xWindow, yWindow);

    /// <summary>Clears the element’s tooltip by resetting its text to an empty string and updating mouse visibility based on internal flags or the element’s current action state.
    /// <code>Offset: 0x004626C0
    /// void __thiscall UIElement::ClearTooltip(UIElement*)</code>
    /// </summary>
    public void ClearTooltip() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement, void>)0x004626C0)(ref this);

    /// <summary>Recalculates the element’s position, size, and z‑order based on its layout descriptor when the parent’s dimensions change. The method updates edge alignments, triggers focus loss callbacks, and notifies listeners of z‑level changes.
    /// <code>Offset: 0x00462720
    /// bool __thiscall UIElement::UpdateForParentSizeChange(UIElement*)</code>
    /// </summary>
    /// <returns>True if the geometry was updated; false if no layout descriptor is present.</returns>
    public byte UpdateForParentSizeChange() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement, byte>)0x00462720)(ref this);

    /// <summary>Assigns a new UIRegion as the parent of this UIElement, updating focus state, broadcasting layout change events, and adjusting size constraints accordingly.
    /// <code>Offset: 0x00462B30
    /// void __thiscall UIElement::SetParent(UIElement*,UIRegion*)</code>
    /// </summary>
    /// <param name="parent">The UIRegion that will become the element's new parent.</param>
    public void SetParent(ACBindings.Internal.UIRegion* parent) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement, ACBindings.Internal.UIRegion*, void>)0x00462B30)(ref this, parent);

    /// <summary>Forwards a UI message to the element’s registered listeners, invoking each listener’s handler if the message is newer than its last processed timestamp, then optionally triggers the element’s own action handlers and returns the final processing result.
    /// <code>Offset: 0x00462C00
    /// UIElementMessageListenResult __thiscall UIElement::ForwardElementMessage(UIElement*,const UIElementMessageInfo*,UIElementMessageListenResult)</code>
    /// </summary>
    /// <param name="this">The UIElement instance that receives the forwarded message.</param>
    /// <param name="i_rMsg">A pointer to a UIElementMessageInfo structure containing the message data, coordinates, and serial number.</param>
    /// <param name="i_eStatus">The current message listen status (e.g., default or stop) that may be updated by listeners during processing.</param>
    /// <returns>Returns the final UIElementMessageListenResult after all listeners and internal handlers have processed the message; this value indicates whether further propagation should continue, has been handled, or should stop.</returns>
    public ACBindings.Internal.UIElementMessageListenResult ForwardElementMessage(ACBindings.Internal.UIElementMessageInfo* i_rMsg, ACBindings.Internal.UIElementMessageListenResult i_eStatus) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement, ACBindings.Internal.UIElementMessageInfo*, ACBindings.Internal.UIElementMessageListenResult, ACBindings.Internal.UIElementMessageListenResult>)0x00462C00)(ref this, i_rMsg, i_eStatus);

    /// <summary>Initializes the UI element by resetting its media machine, applying its default state, clearing focus from child elements, updating mouse visibility, and broadcasting a global message when necessary.
    /// <code>Offset: 0x00462D70
    /// void __thiscall UIElement::Initialize(UIElement*)</code>
    /// </summary>
    public void Initialize() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement, void>)0x00462D70)(ref this);

    /// <summary>Applies the given property to a UI element, updating its state, visibility, behavior flags, and invoking associated callbacks based on the property's name.
    /// <code>Offset: 0x00462E60
    /// void __thiscall UIElement::OnSetAttribute(UIElement*,const BaseProperty*)</code>
    /// </summary>
    /// <param name="attribute">Property to apply; the method uses its name to determine which attribute of the element to set.</param>
    public void OnSetAttribute(ACBindings.Internal.BaseProperty* attribute) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement, ACBindings.Internal.BaseProperty*, void>)0x00462E60)(ref this, attribute);

    /// <summary>Handles mouse movement for this UI element, performing resize or move operations based on its current flags and broadcasting position updates when necessary.
    /// <code>Offset: 0x004633F0
    /// void __thiscall UIElement::MouseMove(UIElement*,int,int)</code>
    /// </summary>
    /// <param name="xWindow">The X coordinate of the mouse within the window.</param>
    /// <param name="yWindow">The Y coordinate of the mouse within the window.</param>
    public void MouseMove(int xWindow, int yWindow) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement, int, int, void>)0x004633F0)(ref this, xWindow, yWindow);

    /// <summary>Moves the UI element to a new screen position specified by the provided X and Y coordinates. The method adjusts internal geometry, updates any attached objects, and broadcasts movement notifications when necessary.
    /// <code>Offset: 0x004634C0
    /// void __thiscall UIElement::MoveTo(UIElement*,const int,const int)</code>
    /// </summary>
    /// <param name="x">Target X coordinate in screen space.</param>
    /// <param name="y">Target Y coordinate in screen space.</param>
    public void MoveTo(int x, int y) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement, int, int, void>)0x004634C0)(ref this, x, y);

    /// <summary>Retrieves the final child element of this UIElement's children list, or returns null when no children exist.
    /// <code>Offset: 0x00463690
    /// UIElement* __thiscall UIElement::GetLastChildElement(UIElement*)</code>
    /// </summary>
    /// <returns>The most recently added child UIElement pointer, or nullptr if the element has no children.</returns>
    public ACBindings.Internal.UIElement* GetLastChildElement() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement, ACBindings.Internal.UIElement*>)0x00463690)(ref this);

    /// <summary>Updates focus, activation state, child layout, and hit‑testing when the UI element's visibility changes.
    /// <code>Offset: 0x00463830
    /// void __thiscall UIElement::OnVisibilityChanged(UIElement*,bool)</code>
    /// </summary>
    /// <param name="i_bVisibleNow">True if the element is now visible; false if it has been hidden.</param>
    public void OnVisibilityChanged(byte i_bVisibleNow) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement, byte, void>)0x00463830)(ref this, i_bVisibleNow);

    /// <summary>Executes post‑initialization logic for this UIElement by traversing its child list and invoking each child's initialization routine, ensuring the entire hierarchy is properly set up after construction.
    /// <code>Offset: 0x004639A0
    /// void __thiscall UIElement::PostInit(UIElement*)</code>
    /// </summary>
    public void PostInit() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement, void>)0x004639A0)(ref this);

    /// <summary>Retrieves the value of a specified property for this UIElement instance.
    /// <code>Offset: 0x00463A00
    /// bool __thiscall UIElement::InqProperty(UIElement*,const unsigned int,BaseProperty*)</code>
    /// </summary>
    /// <param name="name">Identifier of the desired property.</param>
    /// <param name="property">Receives the matching BaseProperty structure when found.</param>
    /// <returns>True if the property exists and is retrieved; otherwise, false.</returns>
    public byte InqProperty(uint name, ACBindings.Internal.BaseProperty* property) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement, uint, ACBindings.Internal.BaseProperty*, byte>)0x00463A00)(ref this, name, property);

    /// <summary>Handles a mouse release event for this UI element, forwarding it to its base region, broadcasting a message via the global UIElementManager, and performing state‑dependent actions based on the released button.
    /// <code>Offset: 0x00463A70
    /// void __thiscall UIElement::MouseUp(UIElement*,unsigned int,unsigned int,unsigned int)</code>
    /// </summary>
    /// <param name="xWindow">The X coordinate of the mouse release within the window.</param>
    /// <param name="yWindow">The Y coordinate of the mouse release within the window.</param>
    /// <param name="button">The identifier of the mouse button that was released.</param>
    public void MouseUp(uint xWindow, uint yWindow, uint button) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement, uint, uint, uint, void>)0x00463A70)(ref this, xWindow, yWindow, button);

    /// <summary>Retrieves a child UIElement identified by the given unsigned integer ID from this element's children list.
    /// <code>Offset: 0x00463BA0
    /// UIElement* __thiscall UIElement::GetChild(UIElement*,unsigned int)</code>
    /// </summary>
    /// <param name="ID">Identifier of the desired child element.</param>
    /// <returns>Pointer to the matching UIElement if found; otherwise, nullptr.</returns>
    public ACBindings.Internal.UIElement* GetChild(uint ID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement, uint, ACBindings.Internal.UIElement*>)0x00463BA0)(ref this, ID);

    /// <summary>Recursively searches this element's child hierarchy for a UIElement whose ID matches the supplied value and returns a pointer to it, or null if no match is found.
    /// <code>Offset: 0x00463C00
    /// UIElement* __thiscall UIElement::GetChildRecursive(UIElement*,unsigned int)</code>
    /// </summary>
    /// <param name="this">The UIElement instance from which to start the search.</param>
    /// <param name="ID">The identifier of the desired child element.</param>
    /// <returns>Pointer to the matching UIElement, or nullptr when none exists in this branch.</returns>
    public ACBindings.Internal.UIElement* GetChildRecursive(uint ID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement, uint, ACBindings.Internal.UIElement*>)0x00463C00)(ref this, ID);

    /// <summary>Adds a new media image descriptor to this UIElement's media machine using two integer parameters.
    /// <code>Offset: 0x00463C80
    /// void __thiscall UIElement::SetMediaImage(int,int,int)</code>
    /// </summary>
    /// <param name="a2">The first value passed to the function; stored in the media image descriptor at offset 8.</param>
    /// <param name="a3">The second value passed to the function; stored in the media image descriptor at offset 12.</param>
    public void SetMediaImage(int a2, int a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement, int, int, void>)0x00463C80)(ref this, a2, a3);

    /// <summary>Associates a media image with the specified UI element state and updates the displayed image if that state is currently active.
    /// <code>Offset: 0x00463D10
    /// void __thiscall UIElement::SetMediaImageForState(int,int,int,unsigned int)</code>
    /// </summary>
    /// <param name="a2">Image identifier to assign to the state.</param>
    /// <param name="a3">Additional parameter (e.g., index or variant) for the image assignment.</param>
    /// <param name="stateID">Identifier of the target state within the element's layout description.</param>
    public void SetMediaImageForState(int a2, int a3, uint stateID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement, int, int, uint, void>)0x00463D10)(ref this, a2, a3, stateID);

    /// <summary>Resizes the UI element to a new size, applying any minimum or maximum limits defined by its attributes and updating related objects and child elements.
    /// <code>Offset: 0x00463D60
    /// void __thiscall UIElement::ResizeTo(UIElement*,const int,const int)</code>
    /// </summary>
    /// <param name="width">The desired width of the element.</param>
    /// <param name="height">The desired height of the element.</param>
    public void ResizeTo(int width, int height) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement, int, int, void>)0x00463D60)(ref this, width, height);

    /// <summary>Updates an element's associated UIObject to match its current screen position, applying any parent offsets obtained via OnAction if present, then clears the internal list of child regions.
    /// <code>Offset: 0x00463FB0
    /// void __thiscall UIElement::UpdateForScreenPositionChange(UIElement*)</code>
    /// </summary>
    public void UpdateForScreenPositionChange() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement, void>)0x00463FB0)(ref this);

    /// <summary>Propagates a change in hierarchy visibility to this UIElement and all its descendants, notifying them via the OnAction callback.
    /// <code>Offset: 0x00464090
    /// void __thiscall UIElement::UpdateForParentVisibilityChange(UIElement*,bool)</code>
    /// </summary>
    /// <param name="i_bHeirarchyVisible">True if the element should be visible; false otherwise.</param>
    public void UpdateForParentVisibilityChange(byte i_bHeirarchyVisible) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement, byte, void>)0x00464090)(ref this, i_bHeirarchyVisible);

    /// <summary>Retrieves the first child element of this UIElement, or null when none exist.
    /// <code>Offset: 0x00464110
    /// UIElement* __thiscall UIElement::GetFirstChildElement(UIElement*)</code>
    /// </summary>
    /// <returns>A pointer to the first child UIElement, or nullptr if no children are present.</returns>
    public ACBindings.Internal.UIElement* GetFirstChildElement() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement, ACBindings.Internal.UIElement*>)0x00464110)(ref this);

    /// <summary>Determines whether a property identified by the given name exists on the element itself, its current state, or its base descriptor.
    /// <code>Offset: 0x00464430
    /// bool __thiscall UIElement::ContainsProperty(UIElement*,const unsigned int)</code>
    /// </summary>
    /// <param name="name">Property identifier to check for existence.</param>
    /// <returns>True if the property is present in any of the checked collections; otherwise, false.</returns>
    public byte ContainsProperty(uint name) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement, uint, byte>)0x00464430)(ref this, name);

    /// <summary>Retrieves the child element that follows a specified sibling within this UIElement's children list, returning null if there is none.
    /// <code>Offset: 0x00464490
    /// UIElement* __thiscall UIElement::GetNextChildElement(UIElement*,UIElement*)</code>
    /// </summary>
    /// <param name="this">The UIElement whose child collection is searched.</param>
    /// <param name="i_pPrevChild">The child element after which to find the next sibling; may be null or not present in the list.</param>
    /// <returns>The next child UIElement in sequence, or nullptr if no subsequent child exists.</returns>
    public ACBindings.Internal.UIElement* GetNextChildElement(ACBindings.Internal.UIElement* i_pPrevChild) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement, ACBindings.Internal.UIElement*, ACBindings.Internal.UIElement*>)0x00464490)(ref this, i_pPrevChild);

    /// <summary>Retrieves the child element that precedes a specified child within this element's children list.
    /// <code>Offset: 0x004644F0
    /// UIElement* __thiscall UIElement::GetPrevChildElement(UIElement*,UIElement*)</code>
    /// </summary>
    /// <param name="i_pNextChild">The child element whose preceding sibling is requested.</param>
    /// <returns>The previous sibling UIElement if it exists; otherwise, null.</returns>
    public ACBindings.Internal.UIElement* GetPrevChildElement(ACBindings.Internal.UIElement* i_pNextChild) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement, ACBindings.Internal.UIElement*, ACBindings.Internal.UIElement*>)0x004644F0)(ref this, i_pNextChild);

    /// <summary>Searches this element's hierarchy for a child (or itself) whose ID equals the supplied relativeID, returning the first match discovered.
    /// <code>Offset: 0x00464690
    /// UIElement* __thiscall UIElement::FindRelative(UIElement*,unsigned int)</code>
    /// </summary>
    /// <param name="relativeID">The identifier of the UIElement to locate.</param>
    /// <returns>A pointer to the matching UIElement instance, or nullptr if no such element exists in this subtree.</returns>
    public ACBindings.Internal.UIElement* FindRelative(uint relativeID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement, uint, ACBindings.Internal.UIElement*>)0x00464690)(ref this, relativeID);

    /// <summary>Initializes a UIElement instance with the supplied layout and element descriptors, configuring geometry, z‑level, state, listeners, media machine, and drag‑drop callback.
    /// <code>Offset: 0x00464900
    /// void __thiscall UIElement::UIElement(UIElement*,const LayoutDesc*,const ElementDesc*)</code>
    /// </summary>
    /// <param name="layout">Layout description containing display size and shared resources; reference count is increased during construction.</param>
    /// <param name="full_desc">Full element descriptor providing position, size, state, and child information for the UI element.</param>
    public void _ConstructorInternal(ACBindings.Internal.LayoutDesc* layout, ACBindings.Internal.ElementDesc* full_desc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement, ACBindings.Internal.LayoutDesc*, ACBindings.Internal.ElementDesc*, void>)0x00464900)(ref this, layout, full_desc);

    /// <summary>Indicates whether the element is activatable by checking its internal flag.
    /// <code>Offset: 0x00464AA0
    /// bool __thiscall UIElement::GetActivatable(UIElement*)</code>
    /// </summary>
    /// <returns>True if the activation bit (bit 2) of m_nFlags is set; otherwise false.</returns>
    public byte GetActivatable() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement, byte>)0x00464AA0)(ref this);

    /// <summary>Indicates whether the UI element has an associated cursor.
    /// <code>Offset: 0x00464AB0
    /// bool __thiscall UIElement::HasCursor(UIElement*)</code>
    /// </summary>
    /// <returns>True if the element’s cursor identifier is valid; otherwise, false.</returns>
    public byte HasCursor() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement, byte>)0x00464AB0)(ref this);

    /// <summary>Registers a UIListener with the element so it receives element messages.
    /// <code>Offset: 0x00464AD0
    /// void __thiscall UIElement::RegisterForElementMessages(UIElement*,UIListener*)</code>
    /// </summary>
    /// <param name="i_pListener">The listener to register for element events.</param>
    public void RegisterForElementMessages(ACBindings.Internal.UIListener* i_pListener) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement, ACBindings.Internal.UIListener*, void>)0x00464AD0)(ref this, i_pListener);

    /// <summary>Unregisters the specified listener from receiving element messages, removing it from internal tracking structures and notifying the listener of its removal.
    /// <code>Offset: 0x00464B00
    /// void __thiscall UIElement::UnregisterForElementMessages(UIElement*,UIListener*)</code>
    /// </summary>
    /// <param name="i_pListener">The listener to remove from this element's message system.</param>
    public void UnregisterForElementMessages(ACBindings.Internal.UIListener* i_pListener) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement, ACBindings.Internal.UIListener*, void>)0x00464B00)(ref this, i_pListener);

    /// <summary>Assigns a base property to the element and triggers focus loss handling when the assignment succeeds.
    /// <code>Offset: 0x00464C90
    /// bool __thiscall UIElement::SetProperty(UIElement*,const BaseProperty*)</code>
    /// </summary>
    /// <param name="property">The property to apply to this UI element.</param>
    /// <returns>True if the property was stored successfully; otherwise false.</returns>
    public byte SetProperty(ACBindings.Internal.BaseProperty* property) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement, ACBindings.Internal.BaseProperty*, byte>)0x00464C90)(ref this, property);

    /// <summary>Deletes every child UIRegion attached to this UIElement and frees their resources.
    /// <code>Offset: 0x00464CD0
    /// void __thiscall UIElement::DeleteChildren(UIElement*)</code>
    /// </summary>
    public void DeleteChildren() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement, void>)0x00464CD0)(ref this);

    /// <summary>Destroys a UIElement instance, freeing child elements, stopping any active resizing, deregistering listeners, releasing associated layout and media resources, and clearing internal state before delegating to the base UIRegion destructor.
    /// <code>Offset: 0x00464E00
    /// void __thiscall UIElement::~UIElement(UIElement*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement, void>)0x00464E00)(ref this);

    /// <summary>Sets the element’s state to the specified value, updating its internal descriptor, propagating changes to child elements when necessary, refreshing property collections, and resetting media playback accordingly.
    /// <code>Offset: 0x00464FA0
    /// bool __thiscall UIElement::SetState(UIElement*,unsigned int)</code>
    /// </summary>
    /// <param name="state">The identifier of the new state to apply to this UI element.</param>
    /// <returns>True after successfully applying the state; this method always returns true.</returns>
    public byte SetState(uint state) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement, uint, byte>)0x00464FA0)(ref this, state);

    /// <summary>Synchronizes this UIElement with another by copying properties, media machine state, image, child elements, and overall state from the supplied source element.
    /// <code>Offset: 0x00465330
    /// void __thiscall UIElement::MatchElement(UIElement*,const UIElement*)</code>
    /// </summary>
    /// <param name="elem">The source UIElement whose configuration should be replicated onto this element.</param>
    public void MatchElement(ACBindings.Internal.UIElement* elem) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement, ACBindings.Internal.UIElement*, void>)0x00465330)(ref this, elem);

    /// <summary>Brings the specified child UIElement to the frontmost position among its siblings within this parent element's hierarchy, updating the rendering order accordingly.
    /// <code>Offset: 0x00465610
    /// void __thiscall UIElement::BringChildToTop(UIElement*,UIElement*)</code>
    /// </summary>
    /// <param name="i_pChild">The child element to bring to the top of the z‑order stack.</param>
    public void BringChildToTop(ACBindings.Internal.UIElement* i_pChild) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement, ACBindings.Internal.UIElement*, void>)0x00465610)(ref this, i_pChild);

    /// <summary>Searches recursively for a child UIElement with the given ID, invokes its OnAction code 12 if found, and returns the resulting integer; otherwise returns zero.
    /// <code>Offset: 0x00476820
    /// int __stdcall UIElement::GetChildRecursiveTemplate&lt;UIElement_Text&gt;(unsigned int)</code>
    /// </summary>
    /// <param name="ID">The identifier of the child element to locate within the hierarchy.</param>
    /// <returns>The result of the child's OnAction call (code 12), or 0 if no matching child is found.</returns>
    public static int GetChildRecursiveTemplate__UIElement_Text(uint ID) => ((delegate* unmanaged[Stdcall]<uint, int>)0x00476820)(ID);

    /// <summary>Searches the element hierarchy for a child with the specified ID and invokes its action handler with code 11.
    /// <code>Offset: 0x00482770
    /// int __stdcall UIElement::GetChildRecursiveTemplate&lt;UIElement_Scrollbar&gt;(unsigned int)</code>
    /// </summary>
    /// <param name="ID">The identifier of the child element to locate.</param>
    /// <returns>Result returned by the child’s OnAction call, or 0 if no matching child is found.</returns>
    public static int GetChildRecursiveTemplate__UIElement_Scrollbar(uint ID) => ((delegate* unmanaged[Stdcall]<uint, int>)0x00482770)(ID);

    /// <summary>Returns the administrative status of the character represented by the ACCharGenResult instance.
    /// <code>Offset: 0x005C8120
    /// int __thiscall UIElement::GetParent(ACCharGenResult*)</code>
    /// </summary>
    /// <param name="this">Pointer to the ACCharGenResult object whose admin flag is queried.</param>
    /// <returns>An integer indicating whether the character is an administrator (non‑zero) or not (zero).</returns>
    public int GetParent() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement, int>)0x005C8120)(ref this);
}

